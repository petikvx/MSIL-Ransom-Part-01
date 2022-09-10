using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;
using System.Threading;

namespace System.ServiceModel.Activation;

internal abstract class ListenerAdapterBase
{
	private const int WebhostMajorVersion = 7;

	private const int WebhostMinorVersion = 0;

	private WebHostUnsafeNativeMethods.WebhostListenerCallbacks listenerCallbacks;

	private int protocolHandle;

	private int closed;

	protected string protocolName;

	private static WebHostUnsafeNativeMethods.SafeFreeLibrary webHostIpm;

	private static WebHostUnsafeNativeMethods.WebhostGetVersion webhostGetVersion;

	private static WebHostUnsafeNativeMethods.WebhostRegisterProtocol webhostRegisterProtocol;

	private static WebHostUnsafeNativeMethods.WebhostOpenListenerChannelInstance webhostOpenListenerChannelInstance;

	private static WebHostUnsafeNativeMethods.WebhostCloseAllListenerChannelInstances webhostCloseAllListenerChannelInstances;

	private static WebHostUnsafeNativeMethods.WebhostUnregisterProtocol webhostUnregisterProtocol;

	static ListenerAdapterBase()
	{
		webHostIpm = WebHostUnsafeNativeMethods.LoadLibraryEx(SMSvcHost.ListenerAdapterNativeLibrary, IntPtr.Zero, 8);
		if (webHostIpm.IsInvalid)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new Win32Exception());
		}
		webhostGetVersion = (WebHostUnsafeNativeMethods.WebhostGetVersion)GetProcDelegate<WebHostUnsafeNativeMethods.WebhostGetVersion>(webHostIpm, "WebhostGetVersion");
		webhostRegisterProtocol = (WebHostUnsafeNativeMethods.WebhostRegisterProtocol)GetProcDelegate<WebHostUnsafeNativeMethods.WebhostRegisterProtocol>(webHostIpm, "WebhostRegisterProtocol");
		webhostUnregisterProtocol = (WebHostUnsafeNativeMethods.WebhostUnregisterProtocol)GetProcDelegate<WebHostUnsafeNativeMethods.WebhostUnregisterProtocol>(webHostIpm, "WebhostUnregisterProtocol");
		webhostOpenListenerChannelInstance = (WebHostUnsafeNativeMethods.WebhostOpenListenerChannelInstance)GetProcDelegate<WebHostUnsafeNativeMethods.WebhostOpenListenerChannelInstance>(webHostIpm, "WebhostOpenListenerChannelInstance");
		webhostCloseAllListenerChannelInstances = (WebHostUnsafeNativeMethods.WebhostCloseAllListenerChannelInstances)GetProcDelegate<WebHostUnsafeNativeMethods.WebhostCloseAllListenerChannelInstances>(webHostIpm, "WebhostCloseAllListenerChannelInstances");
	}

	protected ListenerAdapterBase(string protocolName)
	{
		if (string.IsNullOrEmpty(protocolName))
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("protocolName"));
		}
		this.protocolName = protocolName;
		listenerCallbacks = default(WebHostUnsafeNativeMethods.WebhostListenerCallbacks);
		listenerCallbacks.dwBytesInCallbackStructure = Marshal.SizeOf((object)listenerCallbacks);
		listenerCallbacks.webhostListenerConfigManagerConnected = onConfigManagerConnected;
		listenerCallbacks.webhostListenerConfigManagerDisconnected = onConfigManagerDisconnected;
		listenerCallbacks.webhostListenerConfigManagerInitializationCompleted = onConfigManagerInitializationCompleted;
		listenerCallbacks.webhostListenerApplicationPoolCreated = onApplicationPoolCreated;
		listenerCallbacks.webhostListenerApplicationPoolDeleted = onApplicationPoolDeleted;
		listenerCallbacks.webhostListenerApplicationPoolIdentityChanged = onApplicationPoolIdentityChanged;
		listenerCallbacks.webhostListenerApplicationPoolStateChanged = onApplicationPoolStateChanged;
		listenerCallbacks.webhostListenerApplicationPoolCanOpenNewListenerChannelInstance = onApplicationPoolCanLaunchQueueInstance;
		listenerCallbacks.webhostListenerApplicationPoolAllListenerChannelInstancesStopped = onApplicationPoolAllQueueInstancesStopped;
		listenerCallbacks.webhostListenerApplicationCreated = onApplicationCreated;
		listenerCallbacks.webhostListenerApplicationDeleted = onApplicationDeleted;
		listenerCallbacks.webhostListenerApplicationBindingsChanged = onApplicationBindingsChanged;
		listenerCallbacks.webhostListenerApplicationAppPoolChanged = onApplicationAppPoolChanged;
		listenerCallbacks.webhostListenerApplicationRequestsBlockedChanged = onApplicationRequestsBlockedChanged;
	}

	private static Delegate GetProcDelegate<TDelegate>(WebHostUnsafeNativeMethods.SafeFreeLibrary library, string procName)
	{
		IntPtr procAddress = WebHostUnsafeNativeMethods.GetProcAddress(library, procName);
		if (procAddress == IntPtr.Zero)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new Win32Exception(SR.GetString("WebHostProcNotFound", procName, SMSvcHost.ListenerAdapterNativeLibrary)));
		}
		return Marshal.GetDelegateForFunctionPointer(procAddress, typeof(TDelegate));
	}

	protected unsafe string[] ParseBindings(IntPtr bindingsMultiSz, int numberOfBindings)
	{
		if (bindingsMultiSz == IntPtr.Zero)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("bindingsMultiSz"));
		}
		if (numberOfBindings < 0)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentException("numberOfBindings"));
		}
		string[] array = new string[numberOfBindings];
		ushort* ptr = (ushort*)(void*)bindingsMultiSz;
		for (int i = 0; i < numberOfBindings; i++)
		{
			string text = Marshal.PtrToStringUni((IntPtr)ptr);
			if (!string.IsNullOrEmpty(text))
			{
				array[i] = text;
				ptr += text.Length + 1;
				continue;
			}
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentException("bindingsMultiSz"));
		}
		return array;
	}

	private void onApplicationAppPoolChanged(IntPtr context, string appKey, string appPoolId)
	{
		OnApplicationAppPoolChanged(appKey, appPoolId);
	}

	protected abstract void OnApplicationAppPoolChanged(string appKey, string appPoolId);

	private void onApplicationBindingsChanged(IntPtr context, string appKey, IntPtr bindingsMultiSz, int numberOfBindings)
	{
		OnApplicationBindingsChanged(appKey, bindingsMultiSz, numberOfBindings);
	}

	protected abstract void OnApplicationBindingsChanged(string appKey, IntPtr bindingsMultiSz, int numberOfBindings);

	private void onApplicationCreated(IntPtr context, string appKey, string path, int siteId, string appPoolId, IntPtr bindingsMultiSz, int numberOfBindings, bool requestsBlocked)
	{
		OnApplicationCreated(appKey, path, siteId, appPoolId, bindingsMultiSz, numberOfBindings, requestsBlocked);
	}

	protected abstract void OnApplicationCreated(string appKey, string path, int siteId, string appPoolId, IntPtr bindingsMultiSz, int numberOfBindings, bool requestsBlocked);

	private void onApplicationDeleted(IntPtr context, string appKey)
	{
		OnApplicationDeleted(appKey);
	}

	protected abstract void OnApplicationDeleted(string appKey);

	private void onApplicationPoolAllQueueInstancesStopped(IntPtr context, string appPoolId, int listenerChannelId)
	{
		OnApplicationPoolAllQueueInstancesStopped(appPoolId, listenerChannelId);
	}

	protected abstract void OnApplicationPoolAllQueueInstancesStopped(string appPoolId, int listenerChannelId);

	private void onApplicationPoolCanLaunchQueueInstance(IntPtr context, string appPoolId, int listenerChannelId)
	{
		OnApplicationPoolCanLaunchQueueInstance(appPoolId, listenerChannelId);
	}

	protected abstract void OnApplicationPoolCanLaunchQueueInstance(string appPoolId, int listenerChannelId);

	private void onApplicationPoolCreated(IntPtr context, string appPoolId, IntPtr sid)
	{
		OnApplicationPoolCreated(appPoolId, new SecurityIdentifier(sid));
	}

	protected abstract void OnApplicationPoolCreated(string appPoolId, SecurityIdentifier sid);

	private void onApplicationPoolDeleted(IntPtr context, string appPoolId)
	{
		OnApplicationPoolDeleted(appPoolId);
	}

	protected abstract void OnApplicationPoolDeleted(string appPoolId);

	private void onApplicationPoolIdentityChanged(IntPtr context, string appPoolId, IntPtr sid)
	{
		OnApplicationPoolIdentityChanged(appPoolId, new SecurityIdentifier(sid));
	}

	protected abstract void OnApplicationPoolIdentityChanged(string appPoolId, SecurityIdentifier sid);

	private void onApplicationPoolStateChanged(IntPtr context, string appPoolId, bool isEnabled)
	{
		OnApplicationPoolStateChanged(appPoolId, isEnabled);
	}

	protected abstract void OnApplicationPoolStateChanged(string appPoolId, bool isEnabled);

	private void onApplicationRequestsBlockedChanged(IntPtr context, string appKey, bool requestsBlocked)
	{
		OnApplicationRequestsBlockedChanged(appKey, requestsBlocked);
	}

	protected abstract void OnApplicationRequestsBlockedChanged(string appKey, bool requestsBlocked);

	private void onConfigManagerConnected(IntPtr context)
	{
		OnConfigManagerConnected();
	}

	protected abstract void OnConfigManagerConnected();

	private void onConfigManagerDisconnected(IntPtr context, int hresult)
	{
		OnConfigManagerDisconnected(hresult);
	}

	protected abstract void OnConfigManagerDisconnected(int hresult);

	private void onConfigManagerInitializationCompleted(IntPtr context)
	{
		OnConfigManagerInitializationCompleted();
	}

	protected abstract void OnConfigManagerInitializationCompleted();

	protected void Close()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		if (Interlocked.Increment(ref closed) <= 1)
		{
			int num = webhostUnregisterProtocol(protocolHandle);
			if (num != 0 && DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)655380, (TraceRecord)new StringTraceRecord("HRESULT", SR.GetString("TraceCodeWasWebHostAPIFailed", "WebhostUnregisterProtocol", num.ToString(CultureInfo.CurrentCulture))), this, null);
			}
		}
	}

	protected int OpenListenerChannelInstance(string appPoolId, int listenerChannelId, byte[] queueBlob)
	{
		int queueBlobByteCount = ((queueBlob != null) ? queueBlob.Length : 0);
		return webhostOpenListenerChannelInstance(protocolHandle, appPoolId, listenerChannelId, queueBlob, queueBlobByteCount);
	}

	internal virtual void Open()
	{
		int num = webhostGetVersion(out var major, out var minor);
		if (num != 0)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new Win32Exception(num));
		}
		if (major == 7 && minor == 0)
		{
			num = webhostRegisterProtocol(protocolName, ref listenerCallbacks, IntPtr.Zero, out protocolHandle);
			if (num != 0 || protocolHandle == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new Win32Exception(num));
			}
			return;
		}
		throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new PlatformNotSupportedException(SR.GetString("WebHostVersionMismatch", 7, 0, major, minor)));
	}

	protected int CloseAllListenerChannelInstances(string appPoolId, int listenerChannelId)
	{
		if (string.IsNullOrEmpty(appPoolId))
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("appPoolId"));
		}
		return webhostCloseAllListenerChannelInstances(protocolHandle, appPoolId, listenerChannelId);
	}
}
