using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class Request : IDisposable
{
	private class RequestHandleDictionary : HandleDictionary<Request>
	{
	}

	private static RequestHandleDictionary s_existingClientRequests = new RequestHandleDictionary();

	private static ExceptionTranslationTable s_exceptionToHResultTable = ExceptionTranslationTable.Instance;

	private Stream m_inArgs;

	private Stream m_outArgs;

	private int m_requestHandle;

	private static object s_syncRoot = new object();

	private IWebProxy m_proxy;

	private object m_syncRoot;

	private IntPtr m_rpcHandle;

	private Exception m_processingException;

	private ExceptionList m_recoverableExceptions;

	private WindowsImpersonationContext m_impersonationContext;

	private int m_initHResult;

	private string m_extendedErrorMessage;

	private int m_lcid = -1;

	public Exception ProcessingException
	{
		get
		{
			return m_processingException;
		}
		set
		{
			m_processingException = value;
		}
	}

	public IWebProxy UserProxy
	{
		get
		{
			if (m_proxy == null)
			{
				m_proxy = WebRequest.GetSystemWebProxy();
			}
			return m_proxy;
		}
	}

	public int UserLanguage
	{
		get
		{
			InfoCardTrace.Assert(m_lcid >= 0, " The user language has not been set in the service", new object[0]);
			return m_lcid;
		}
		set
		{
			m_lcid = value;
		}
	}

	protected Stream InArgs => m_inArgs;

	public Stream OutArgs => m_outArgs;

	protected object SyncRoot => m_syncRoot;

	protected IntPtr RpcHandle => m_rpcHandle;

	public int RequestHandle => m_requestHandle;

	public abstract WindowsIdentity RequestorIdentity { get; }

	protected Request(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ExceptionList recoverableExceptions)
	{
		m_inArgs = inArgs;
		m_outArgs = outArgs;
		m_rpcHandle = rpcHandle;
		m_recoverableExceptions = recoverableExceptions;
		m_syncRoot = new object();
		m_initHResult = 0;
		InsertThisRequestIntoDictionary();
	}

	internal void Initialize()
	{
		try
		{
			OnInitializeAsSystem();
			ImpersonateRequestor();
			OnInitializeAsUser();
		}
		catch (Exception e)
		{
			m_initHResult = HandleException(e, isInitializing: true);
		}
	}

	private void ImpersonateRequestor()
	{
		InfoCardTrace.Assert(null != RequestorIdentity, "RequestorIdentity can not be null, the derived class  should have populated this on initialize", new object[0]);
		if (RequestorIdentity.IsSystem)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("UserIdentityEqualSystemNotSupported")));
		}
		m_impersonationContext = RequestorIdentity.Impersonate();
	}

	private int GetHResultFromException(Exception e)
	{
		int result = 0;
		Type type = e.GetType();
		if (s_exceptionToHResultTable.ContainsKey(type))
		{
			result = s_exceptionToHResultTable[type];
		}
		else if (e is Win32Exception)
		{
			result = ((Win32Exception)e).NativeErrorCode;
		}
		else
		{
			InfoCardService.Crash(e);
		}
		return result;
	}

	protected int HandleException(Exception e)
	{
		return HandleException(e, isInitializing: false);
	}

	protected int HandleException(Exception e, bool isInitializing)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		int errorCode = 0;
		if (InfoCardTrace.IsFatal(e))
		{
			InfoCardTrace.TraceAndLogException(e);
			InfoCardService.Crash(e);
		}
		Exception ex = ((!(e is InfoCardRequestException)) ? e : e.InnerException);
		if (isInitializing || !OnHandleException(ex, out errorCode))
		{
			if (ex is InfoCardBaseException)
			{
				errorCode = ((InfoCardBaseException)ex).get_NativeHResult();
				m_extendedErrorMessage = ((InfoCardBaseException)ex).get_ExtendedMessage();
			}
			else if (m_recoverableExceptions == ExceptionList.AllNonFatal)
			{
				CommunicationException ex2 = new CommunicationException(SR.GetString("ClientAPIInfocardError"), ex);
				InfoCardTrace.TraceAndLogException((Exception)(object)ex2);
				errorCode = ((InfoCardBaseException)ex2).get_NativeHResult();
			}
			else if (m_recoverableExceptions.Contains(ex.GetType()))
			{
				errorCode = GetHResultFromException(ex);
			}
			else
			{
				InfoCardTrace.TraceAndLogException(e);
				InfoCardService.Crash(e);
			}
		}
		return errorCode;
	}

	protected virtual void PreProcessRequest()
	{
		ProcessingException = null;
		OnMarshalInArgs();
		if (ProcessingException != null)
		{
			Exception processingException = ProcessingException;
			ProcessingException = null;
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InfoCardRequestException(processingException.Message, processingException));
		}
		if (InArgs.Position != InArgs.Length)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceInvalidDataInRequest")));
		}
		InArgs.Close();
	}

	protected virtual void PostProcessRequest()
	{
		ProcessingException = null;
		OutArgs.Flush();
		OnMarshalOutArgs();
		if (ProcessingException != null)
		{
			Exception processingException = ProcessingException;
			ProcessingException = null;
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InfoCardRequestException(processingException.Message, processingException));
		}
	}

	protected virtual void ProcessRequest()
	{
		ProcessingException = null;
		OnProcess();
		if (ProcessingException != null)
		{
			Exception processingException = ProcessingException;
			ProcessingException = null;
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InfoCardRequestException(processingException.Message, processingException));
		}
	}

	public int DoProcessRequest(out string extendedMessage)
	{
		int num = m_initHResult;
		if (num == 0)
		{
			try
			{
				PreProcessRequest();
				ProcessRequest();
				PostProcessRequest();
			}
			catch (Exception e)
			{
				num = HandleException(e);
			}
		}
		extendedMessage = m_extendedErrorMessage;
		return num;
	}

	public static Request FindRequestByHandle(int requestHandle)
	{
		lock (s_syncRoot)
		{
			return s_existingClientRequests[requestHandle];
		}
	}

	public void Dispose()
	{
		OnDisposeAsUser();
		if (m_impersonationContext != null)
		{
			m_impersonationContext.Undo();
			m_impersonationContext = null;
		}
		OnDisposeAsSystem();
		RemoveThisRequestFromDictionary();
		GC.SuppressFinalize(this);
	}

	protected virtual void OnInitializeAsSystem()
	{
	}

	protected virtual void OnInitializeAsUser()
	{
	}

	protected virtual void OnDisposeAsUser()
	{
	}

	protected abstract void OnMarshalInArgs();

	protected abstract void OnProcess();

	protected abstract void OnMarshalOutArgs();

	protected virtual void OnDisposeAsSystem()
	{
	}

	protected virtual bool OnHandleException(Exception e, out int errorCode)
	{
		errorCode = 0;
		return false;
	}

	private void InsertThisRequestIntoDictionary()
	{
		int num = 0;
		lock (s_syncRoot)
		{
			try
			{
				num = s_existingClientRequests.GetNewHandle();
			}
			catch (IndexOutOfRangeException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("TooManyClientRequests"), inner));
			}
			m_requestHandle = num;
			s_existingClientRequests[m_requestHandle] = this;
		}
	}

	private void RemoveThisRequestFromDictionary()
	{
		lock (s_syncRoot)
		{
			s_existingClientRequests.Remove(m_requestHandle);
		}
	}
}
