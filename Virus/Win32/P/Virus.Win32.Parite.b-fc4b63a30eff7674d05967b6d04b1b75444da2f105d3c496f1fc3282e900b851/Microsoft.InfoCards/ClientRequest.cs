using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class ClientRequest : Request
{
	internal delegate void AsyncEntryCallback();

	private class ServiceAsyncOperation
	{
		private AsyncEntryCallback m_cancelCallback;

		private AsyncEntryCallback m_entryCallback;

		private ManualResetEvent m_syncEvent;

		private Exception m_exception;

		private bool m_complete;

		private bool m_cancelled;

		private object m_sync;

		public bool WasCancelled => m_cancelled;

		public Exception ExecutionException => m_exception;

		public ServiceAsyncOperation(AsyncEntryCallback entry, AsyncEntryCallback cancel)
		{
			m_entryCallback = entry;
			m_cancelCallback = cancel;
			m_sync = new object();
			m_syncEvent = new ManualResetEvent(initialState: false);
		}

		public void Complete()
		{
			if (m_complete)
			{
				return;
			}
			lock (m_sync)
			{
				if (!m_complete)
				{
					m_complete = true;
					m_syncEvent.Set();
				}
			}
		}

		public void WaitForCompletion()
		{
			m_syncEvent.WaitOne();
		}

		public void Execute()
		{
			lock (m_sync)
			{
				if (m_cancelled)
				{
					return;
				}
				m_complete = false;
				m_syncEvent.Reset();
			}
			try
			{
				m_entryCallback();
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					InfoCardService.Crash(ex);
				}
				else
				{
					m_exception = ex;
				}
			}
		}

		public void Cancel()
		{
			lock (m_sync)
			{
				if (m_complete)
				{
					return;
				}
				m_cancelled = true;
				try
				{
					if (m_cancelCallback != null)
					{
						m_cancelCallback();
					}
				}
				finally
				{
					Complete();
				}
			}
		}
	}

	private const int OutstandingCallWaitTime = 30000;

	private IDictionary m_asyncOps;

	private IDictionary m_cachedCerts;

	private Process m_callerProcess;

	private WindowsIdentity m_callerIdentity;

	private Dictionary<Type, object> m_contextBag;

	private object m_serviceAsyncSyncRoot;

	private ServiceAsyncOperation m_serviceAsyncOperation;

	private bool m_cancelled;

	private bool m_untrusted;

	public override WindowsIdentity RequestorIdentity => m_callerIdentity;

	public Process CallerProcess => m_callerProcess;

	public uint CallerPid => (uint)CallerProcess.Id;

	public static Process GetCallingProcessFromRpcHandle(IntPtr RpcHandle)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		if (NativeMethods.I_RpcBindingInqLocalClientPID(RpcHandle, out var pid) != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceErrorGettingClientPid")));
		}
		Process result = null;
		bool flag = false;
		bool flag2 = false;
		while (!flag)
		{
			flag = true;
			try
			{
				if (flag2)
				{
					NativeMcppMethods.AddSystemAccessToProcess(RpcHandle, pid);
				}
				result = ProcessMonitor.GetProcessById((int)pid);
			}
			catch (ArgumentException)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
			}
			catch (Win32Exception ex2)
			{
				bool flag3 = false;
				if (5 == ex2.NativeErrorCode && !flag2)
				{
					flag = false;
					flag2 = true;
					flag3 = true;
				}
				if (!flag3)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new SecurityException(SR.GetString("ClientAPIInfocardError"), ex2));
				}
			}
		}
		return result;
	}

	public ClientRequest(Process callingProcess, WindowsIdentity userIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: this(callingProcess, userIdentity, rpcHandle, inArgs, outArgs, ExceptionList.AllNonFatal)
	{
	}

	public ClientRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs, ExceptionList recoverableExceptions)
		: base(rpcHandle, inArgs, outArgs, recoverableExceptions)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == callingProcess, "callingProcess");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == callingIdentity, "userIdentity");
		InfoCardTrace.ThrowInvalidArgumentConditional(IntPtr.Zero == rpcHandle, "rpcHandle");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == inArgs, "inArgs");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == outArgs, "outArgs");
		m_callerProcess = callingProcess;
		m_callerIdentity = callingIdentity;
		m_contextBag = new Dictionary<Type, object>();
		m_serviceAsyncSyncRoot = new object();
		InfoCardService.LifeTimeMonitor.AddClient();
	}

	protected override void OnInitializeAsSystem()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (CallerProcess.HasExited)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
		}
	}

	public T GetContext<T>()
	{
		object value = null;
		if (m_contextBag.TryGetValue(typeof(T), out value))
		{
			return (T)value;
		}
		return default(T);
	}

	public void SetContext<T>(T value)
	{
		m_contextBag[typeof(T)] = value;
	}

	public void ClearContext<T>()
	{
		m_contextBag.Remove(typeof(T));
	}

	public void AddAsyncOp(RpcAsyncResult async)
	{
		lock (base.SyncRoot)
		{
			if (m_asyncOps == null)
			{
				m_asyncOps = new HybridDictionary();
			}
			m_asyncOps[async.Handle] = async;
		}
	}

	public void CancelAsyncOp(int handle)
	{
		lock (base.SyncRoot)
		{
			if (m_asyncOps != null && m_asyncOps.Contains(handle))
			{
				RpcAsyncResult rpcAsyncResult = (RpcAsyncResult)m_asyncOps[handle];
				rpcAsyncResult.Cancel();
			}
		}
	}

	public void RemoveAsyncOp(int handle)
	{
		lock (base.SyncRoot)
		{
			m_asyncOps.Remove(handle);
		}
	}

	private RpcAsyncResult FindAsyncOp(int handle)
	{
		lock (base.SyncRoot)
		{
			return (RpcAsyncResult)m_asyncOps[handle];
		}
	}

	protected void CheckIfAllAsyncOpsCompleted()
	{
		lock (base.SyncRoot)
		{
			if (m_asyncOps == null)
			{
				return;
			}
			foreach (RpcAsyncResult value in m_asyncOps.Values)
			{
				_ = value;
			}
		}
	}

	public RpcAsyncResult WaitForAsyncCompletion(int handle)
	{
		RpcAsyncResult rpcAsyncResult = FindAsyncOp(handle);
		if (rpcAsyncResult == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceInvalidAsyncHandle")));
		}
		IAsyncResult asyncResult = rpcAsyncResult;
		asyncResult.AsyncWaitHandle.WaitOne();
		Exception exception = rpcAsyncResult.Exception;
		if (exception != null)
		{
			throw new InfoCardRequestException(SR.GetString("ServiceAsyncOpGeneratedException"), exception);
		}
		return rpcAsyncResult;
	}

	public void CertCacheAdd(string recipientIdentifier, X509Certificate2 cert)
	{
		lock (base.SyncRoot)
		{
			if (m_cachedCerts == null)
			{
				m_cachedCerts = new HybridDictionary();
			}
			m_cachedCerts[recipientIdentifier] = cert;
		}
	}

	public X509Certificate2 CertCacheFind(string recipientId)
	{
		lock (base.SyncRoot)
		{
			return (X509Certificate2)m_cachedCerts[recipientId];
		}
	}

	public static uint Authorize(IntPtr rpcIfHandle, IntPtr context)
	{
		uint num = 5u;
		InfoCardTrace.ThrowInvalidArgumentConditional(IntPtr.Zero == rpcIfHandle, "rpcIfHandle");
		InfoCardTrace.ThrowInvalidArgumentConditional(IntPtr.Zero == context, "context");
		try
		{
			using WindowsIdentity windowsIdentity = Utility.GetWindowsIdentity(context);
			if (!windowsIdentity.IsAuthenticated)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new SecurityException());
			}
			if (!ValidateToken(context, windowsIdentity))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceInvalidCallerToken")));
			}
			num = 0u;
			return num;
		}
		catch (RuntimeWrappedException ex)
		{
			InfoCardTrace.TraceAndLogException((Exception)ex);
			InfoCardService.Crash();
			return num;
		}
		catch (SecurityException)
		{
			InfoCardTrace.Assert(5 == num, "Unexpected value for err!", new object[0]);
			return num;
		}
		catch (InfoCardBaseException)
		{
			throw;
		}
		catch (Exception ex3)
		{
			if (InfoCardTrace.IsFatal(ex3))
			{
				InfoCardService.Crash(ex3);
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceUnableToValidateCallerToken", new object[1] { ex3.Message })));
		}
	}

	private static bool ValidateToken(IntPtr rpcItfHandle, WindowsIdentity rpcIdentity)
	{
		Process callingProcessFromRpcHandle = GetCallingProcessFromRpcHandle(rpcItfHandle);
		WindowsIdentity windowsIdentity = NativeMcppMethods.CreateServiceExecutionIdentity(callingProcessFromRpcHandle);
		bool result;
		if (result = windowsIdentity.User!.Value == rpcIdentity.User!.Value)
		{
			result = NativeMcppMethods.IsTokenValid(callingProcessFromRpcHandle);
		}
		return result;
	}

	protected override void OnDisposeAsSystem()
	{
		m_callerProcess = null;
		object[] array = null;
		lock (base.SyncRoot)
		{
			if (m_asyncOps != null)
			{
				array = new object[m_asyncOps.Values.Count];
				m_asyncOps.Values.CopyTo(array, 0);
			}
		}
		if (array != null)
		{
			object[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				RpcAsyncResult rpcAsyncResult = (RpcAsyncResult)array2[i];
				rpcAsyncResult.Dispose();
			}
		}
		InfoCardService.LifeTimeMonitor.RemoveClient();
		base.OnDisposeAsSystem();
	}

	protected void ExecuteCancelable(AsyncEntryCallback entry, AsyncEntryCallback cancel)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		lock (m_serviceAsyncSyncRoot)
		{
			if (m_cancelled)
			{
				if (m_untrusted)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException());
				}
				throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
			}
			InfoCardTrace.Assert(null == m_serviceAsyncOperation, "Only a single cancelable service operation can be running at a time", new object[0]);
			m_serviceAsyncOperation = new ServiceAsyncOperation(entry, cancel);
			try
			{
				if (!ThreadPool.QueueUserWorkItem(InfoCardTrace.ThunkCallback((WaitCallback)ServiceAsyncEntry), m_serviceAsyncOperation))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("UnableToQueueThreadpool")));
				}
				m_serviceAsyncOperation.WaitForCompletion();
				if (m_serviceAsyncOperation.WasCancelled)
				{
					if (m_untrusted)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException());
					}
					throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
				}
				if (m_serviceAsyncOperation.ExecutionException != null)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(m_serviceAsyncOperation.ExecutionException.Message, m_serviceAsyncOperation.ExecutionException));
				}
			}
			finally
			{
				m_serviceAsyncOperation = null;
			}
		}
	}

	protected void CancelServiceAsyncOperation(bool untrusted)
	{
		if (m_serviceAsyncOperation != null)
		{
			m_serviceAsyncOperation.Cancel();
		}
		m_untrusted = untrusted;
		m_cancelled = true;
	}

	private static void ServiceAsyncEntry(object state)
	{
		ServiceAsyncOperation serviceAsyncOperation = (ServiceAsyncOperation)state;
		try
		{
			serviceAsyncOperation.Execute();
		}
		finally
		{
			serviceAsyncOperation.Complete();
		}
	}
}
