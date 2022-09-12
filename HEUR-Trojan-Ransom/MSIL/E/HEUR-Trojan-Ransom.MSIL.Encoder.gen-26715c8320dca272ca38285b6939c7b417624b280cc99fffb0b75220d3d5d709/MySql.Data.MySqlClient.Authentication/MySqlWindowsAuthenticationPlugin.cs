using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MySql.Data.MySqlClient.Authentication;

[SuppressUnmanagedCodeSecurity]
internal class MySqlWindowsAuthenticationPlugin : MySqlAuthenticationPlugin
{
	private SECURITY_HANDLE outboundCredentials = new SECURITY_HANDLE(0);

	private SECURITY_HANDLE clientContext = new SECURITY_HANDLE(0);

	private SECURITY_INTEGER lifetime = new SECURITY_INTEGER(0);

	private bool continueProcessing;

	private string targetName;

	private const int SEC_E_OK = 0;

	private const int SEC_I_CONTINUE_NEEDED = 590610;

	private const int SEC_I_COMPLETE_NEEDED = 4115;

	private const int SEC_I_COMPLETE_AND_CONTINUE = 4116;

	private const int SECPKG_CRED_OUTBOUND = 2;

	private const int SECURITY_NETWORK_DREP = 0;

	private const int SECURITY_NATIVE_DREP = 16;

	private const int SECPKG_CRED_INBOUND = 1;

	private const int MAX_TOKEN_SIZE = 12288;

	private const int SECPKG_ATTR_SIZES = 0;

	private const int STANDARD_CONTEXT_ATTRIBUTES = 0;

	public override string PluginName => "authentication_windows_client";

	protected override void CheckConstraints()
	{
		string text = string.Empty;
		int platform = (int)Environment.OSVersion.Platform;
		if (platform != 4 && platform != 128)
		{
			if (Environment.OSVersion.Platform == PlatformID.MacOSX)
			{
				text = "Mac OS/X";
			}
		}
		else
		{
			text = "Unix";
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new MySqlException(string.Format(Resources.WinAuthNotSupportOnPlatform, text));
		}
		base.CheckConstraints();
	}

	public override string GetUsername()
	{
		string username = base.GetUsername();
		if (string.IsNullOrEmpty(username))
		{
			return "auth_windows";
		}
		return username;
	}

	protected override byte[] MoreData(byte[] moreData)
	{
		if (moreData == null)
		{
			AcquireCredentials();
		}
		byte[] clientBlob = null;
		if (continueProcessing)
		{
			InitializeClient(out clientBlob, moreData, out continueProcessing);
		}
		if (continueProcessing && clientBlob != null && clientBlob.Length != 0)
		{
			return clientBlob;
		}
		FreeCredentialsHandle(ref outboundCredentials);
		DeleteSecurityContext(ref clientContext);
		return null;
	}

	private void InitializeClient(out byte[] clientBlob, byte[] serverBlob, out bool continueProcessing)
	{
		clientBlob = null;
		continueProcessing = true;
		SecBufferDesc pOutput = new SecBufferDesc(12288);
		SECURITY_INTEGER ptsExpiry = new SECURITY_INTEGER(0);
		int num = -1;
		try
		{
			uint pfContextAttr = 0u;
			if (serverBlob == null)
			{
				num = InitializeSecurityContext(ref outboundCredentials, IntPtr.Zero, targetName, 0, 0, 0, IntPtr.Zero, 0, out clientContext, out pOutput, out pfContextAttr, out ptsExpiry);
			}
			else
			{
				SecBufferDesc SecBufferDesc = new SecBufferDesc(serverBlob);
				try
				{
					num = InitializeSecurityContext(ref outboundCredentials, ref clientContext, targetName, 0, 0, 0, ref SecBufferDesc, 0, out clientContext, out pOutput, out pfContextAttr, out ptsExpiry);
				}
				finally
				{
					SecBufferDesc.Dispose();
				}
			}
			if (4115 == num || 4116 == num)
			{
				CompleteAuthToken(ref clientContext, ref pOutput);
			}
			if (num != 0 && num != 590610 && num != 4115 && num != 4116)
			{
				throw new MySqlException("InitializeSecurityContext() failed  with errorcode " + num);
			}
			clientBlob = pOutput.GetSecBufferByteArray();
		}
		finally
		{
			pOutput.Dispose();
		}
		continueProcessing = num != 0 && num != 4115;
	}

	private void AcquireCredentials()
	{
		continueProcessing = true;
		int num = AcquireCredentialsHandle(null, "Negotiate", 2, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero, ref outboundCredentials, ref lifetime);
		if (num != 0)
		{
			throw new MySqlException("AcquireCredentialsHandle failed with errorcode" + num);
		}
	}

	[DllImport("secur32", CharSet = CharSet.Unicode)]
	private static extern int AcquireCredentialsHandle(string pszPrincipal, string pszPackage, int fCredentialUse, IntPtr PAuthenticationID, IntPtr pAuthData, int pGetKeyFn, IntPtr pvGetKeyArgument, ref SECURITY_HANDLE phCredential, ref SECURITY_INTEGER ptsExpiry);

	[DllImport("secur32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int InitializeSecurityContext(ref SECURITY_HANDLE phCredential, IntPtr phContext, string pszTargetName, int fContextReq, int Reserved1, int TargetDataRep, IntPtr pInput, int Reserved2, out SECURITY_HANDLE phNewContext, out SecBufferDesc pOutput, out uint pfContextAttr, out SECURITY_INTEGER ptsExpiry);

	[DllImport("secur32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int InitializeSecurityContext(ref SECURITY_HANDLE phCredential, ref SECURITY_HANDLE phContext, string pszTargetName, int fContextReq, int Reserved1, int TargetDataRep, ref SecBufferDesc SecBufferDesc, int Reserved2, out SECURITY_HANDLE phNewContext, out SecBufferDesc pOutput, out uint pfContextAttr, out SECURITY_INTEGER ptsExpiry);

	[DllImport("secur32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CompleteAuthToken(ref SECURITY_HANDLE phContext, ref SecBufferDesc pToken);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int QueryContextAttributes(ref SECURITY_HANDLE phContext, uint ulAttribute, out SecPkgContext_Sizes pContextAttributes);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int FreeCredentialsHandle(ref SECURITY_HANDLE pCred);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int DeleteSecurityContext(ref SECURITY_HANDLE pCred);
}
