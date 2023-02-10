using System;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Text;

namespace ModuleNameSpace;

internal class Credential_Form
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct CREDUI_INFO
	{
		public int cbSize;

		public IntPtr hwndParent;

		public string pszMessageText;

		public string pszCaptionText;

		public IntPtr hbmBanner;
	}

	[Flags]
	private enum CREDUI_FLAGS
	{
		INCORRECT_PASSWORD = 1,
		DO_NOT_PERSIST = 2,
		REQUEST_ADMINISTRATOR = 4,
		EXCLUDE_CERTIFICATES = 8,
		REQUIRE_CERTIFICATE = 0x10,
		SHOW_SAVE_CHECK_BOX = 0x40,
		ALWAYS_SHOW_UI = 0x80,
		REQUIRE_SMARTCARD = 0x100,
		PASSWORD_ONLY_OK = 0x200,
		VALIDATE_USERNAME = 0x400,
		COMPLETE_USERNAME = 0x800,
		PERSIST = 0x1000,
		SERVER_CREDENTIAL = 0x4000,
		EXPECT_CONFIRMATION = 0x20000,
		GENERIC_CREDENTIALS = 0x40000,
		USERNAME_TARGET_CREDENTIALS = 0x80000,
		KEEP_USERNAME = 0x100000
	}

	public enum CredUI_ReturnCodes
	{
		NO_ERROR = 0,
		ERROR_CANCELLED = 1223,
		ERROR_NO_SUCH_LOGON_SESSION = 1312,
		ERROR_NOT_FOUND = 1168,
		ERROR_INVALID_ACCOUNT_NAME = 1315,
		ERROR_INSUFFICIENT_BUFFER = 122,
		ERROR_INVALID_PARAMETER = 87,
		ERROR_INVALID_FLAGS = 1004
	}

	public class User_Pwd
	{
		public string User = string.Empty;

		public string Password = string.Empty;

		public string Domain = string.Empty;
	}

	[DllImport("credui", CharSet = CharSet.Unicode)]
	private static extern CredUI_ReturnCodes CredUIPromptForCredentials(ref CREDUI_INFO credinfo, string targetName, IntPtr reserved1, int iError, StringBuilder userName, int maxUserName, StringBuilder password, int maxPassword, [MarshalAs(UnmanagedType.Bool)] ref bool pfSave, CREDUI_FLAGS flags);

	internal static User_Pwd PromptForPassword(string caption, string message, string target, string user, PSCredentialTypes credTypes, PSCredentialUIOptions options)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder(user, 128);
		CREDUI_INFO credinfo = default(CREDUI_INFO);
		if (!string.IsNullOrEmpty(message))
		{
			credinfo.pszMessageText = message;
		}
		if (!string.IsNullOrEmpty(caption))
		{
			credinfo.pszCaptionText = caption;
		}
		credinfo.cbSize = Marshal.SizeOf(credinfo);
		bool pfSave = false;
		CREDUI_FLAGS cREDUI_FLAGS = CREDUI_FLAGS.DO_NOT_PERSIST;
		if ((credTypes & 1) == 1)
		{
			cREDUI_FLAGS |= CREDUI_FLAGS.GENERIC_CREDENTIALS;
			if ((options & 2) == 2)
			{
				cREDUI_FLAGS |= CREDUI_FLAGS.ALWAYS_SHOW_UI;
			}
		}
		if (CredUIPromptForCredentials(ref credinfo, target, IntPtr.Zero, 0, stringBuilder2, 128, stringBuilder, 128, ref pfSave, cREDUI_FLAGS) == CredUI_ReturnCodes.NO_ERROR)
		{
			User_Pwd user_Pwd = new User_Pwd();
			user_Pwd.User = stringBuilder2.ToString();
			user_Pwd.Password = stringBuilder.ToString();
			user_Pwd.Domain = "";
			return user_Pwd;
		}
		return null;
	}
}
