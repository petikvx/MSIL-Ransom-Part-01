using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class UIAgentRequest : Request
{
	private ClientUIRequest m_parentRequest;

	public ClientUIRequest ParentRequest => m_parentRequest;

	protected InfoCardUIAgent UIAgent
	{
		get
		{
			if (ParentRequest != null)
			{
				return ParentRequest.UIAgent;
			}
			return null;
		}
	}

	public override WindowsIdentity RequestorIdentity => ParentRequest.RequestorIdentity;

	public UIAgentRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: this(rpcHandle, inArgs, outArgs, parent, ExceptionList.Empty)
	{
	}

	public UIAgentRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent, ExceptionList exceptionList)
		: base(rpcHandle, inArgs, outArgs, exceptionList)
	{
		m_parentRequest = parent;
	}

	public static uint Authorize(IntPtr rpcIfHandle, IntPtr context)
	{
		uint num = 5u;
		if (IntPtr.Zero == rpcIfHandle)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("rpcIfHandle");
		}
		if (IntPtr.Zero == context)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("context");
		}
		try
		{
			WindowsIdentity windowsIdentity = Utility.GetWindowsIdentity(context);
			try
			{
				uint rpcClientPid = Utility.GetRpcClientPid(context);
				InfoCardUIAgent infoCardUIAgent = InfoCardUIAgent.FindByPid(rpcClientPid);
				if (infoCardUIAgent == null)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new SecurityException());
				}
				NativeMcppMethods.CheckSIDAgainstCurrentRpcUser(infoCardUIAgent.TrustedUserSid);
				num = 0u;
				return num;
			}
			finally
			{
				windowsIdentity.Dispose();
			}
		}
		catch (SecurityException)
		{
			InfoCardTrace.Assert(5 == num, "Unexpected value for err!", new object[0]);
			return num;
		}
		catch (Exception e)
		{
			InfoCardService.Crash(e);
			return num;
		}
	}

	public static void BindToService(IntPtr uiagentRpcHandle, IntPtr nativeDesktopName, int cbUserSid, IntPtr pUserSid, int cbTrustedSid, IntPtr pTrustedSid, out IntPtr nativeStartEventHandle, out IntPtr nativeCompleteEventHandle, out RpcUIAgentGetWorkCallback callback)
	{
		string desktopName = Marshal.PtrToStringUni(nativeDesktopName);
		callback = null;
		nativeStartEventHandle = IntPtr.Zero;
		nativeCompleteEventHandle = IntPtr.Zero;
		using WindowsIdentity windowsIdentity = Utility.GetWindowsIdentity(uiagentRpcHandle);
		WindowsImpersonationContext val = windowsIdentity.Impersonate();
		try
		{
			if (NativeMethods.I_RpcBindingInqLocalClientPID(uiagentRpcHandle, out var pid) != 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("FailedToBindToService")));
			}
			InfoCardUIAgent infoCardUIAgent = InfoCardUIAgent.FindByPid(pid);
			if (infoCardUIAgent != null)
			{
				callback = infoCardUIAgent.Bind(desktopName, out var userSid, out var hStartEvent, out var hCompleteEvent);
				byte[] array = new byte[Math.Max(cbUserSid, cbTrustedSid)];
				windowsIdentity.User!.GetBinaryForm(array, 0);
				Marshal.Copy(array, 0, pUserSid, cbUserSid);
				userSid.GetBinaryForm(array, 0);
				Marshal.Copy(array, 0, pTrustedSid, cbTrustedSid);
				nativeStartEventHandle = hStartEvent.DangerousGetHandle();
				nativeCompleteEventHandle = hCompleteEvent.DangerousGetHandle();
			}
		}
		finally
		{
			val.Undo();
		}
	}

	protected override void OnInitializeAsSystem()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		try
		{
			NativeMcppMethods.CheckSIDAgainstCurrentRpcUser(ParentRequest.UIAgentLogonSid);
		}
		catch (Win32Exception ex)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("UnableToAuthenticateUIAgent"), (Exception)ex));
		}
		catch (SecurityException ex2)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("UnableToAuthenticateUIAgent"), (Exception)ex2));
		}
	}

	protected InfoCardPolicy GetPolicy()
	{
		if (!(ParentRequest is GetTokenRequest getTokenRequest))
		{
			return null;
		}
		return getTokenRequest.Policy;
	}
}
