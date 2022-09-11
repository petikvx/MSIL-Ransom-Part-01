using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Shareware.Shareware.core;

public class SharewareHook
{
	public class UserHWID
	{
		[Flags]
		private enum DockInfo
		{
			DOCKINFO_DOCKED = 2,
			DOCKINFO_UNDOCKED = 1,
			DOCKINFO_USER_SUPPLIED = 4,
			DOCKINFO_USER_DOCKED = 5,
			DOCKINFO_USER_UNDOCKED = 6
		}

		[StructLayout(LayoutKind.Sequential)]
		public class HW_PROFILE_INFO
		{
			[MarshalAs(UnmanagedType.U4)]
			public int dwDockInfo;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
			public string szHwProfileGuid;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szHwProfileName;
		}

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool GetCurrentHwProfile(IntPtr lpHwProfileInfo);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string PathName, StringBuilder VolumeNameBuffer, int VolumeNameSize, ref int VolumeSerialNumber, ref int MaximumComponentLength, ref int FileSystemFlags, StringBuilder FileSystemNameBuffer, int FileSystemNameSize);

		private static HW_PROFILE_INFO ProfileInfo()
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				HW_PROFILE_INFO hW_PROFILE_INFO = new HW_PROFILE_INFO();
				intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)hW_PROFILE_INFO));
				Marshal.StructureToPtr((object)hW_PROFILE_INFO, intPtr, fDeleteOld: false);
				if (!GetCurrentHwProfile(intPtr))
				{
					throw new Exception("Error cant get current hw profile!");
				}
				Marshal.PtrToStructure(intPtr, (object)hW_PROFILE_INFO);
				return hW_PROFILE_INFO;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				throw new Exception(ex2.ToString());
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}

		private static string GetVolumeSerial(string strDriveLetter)
		{
			int VolumeSerialNumber = 0;
			StringBuilder stringBuilder = new StringBuilder(256);
			StringBuilder stringBuilder2 = new StringBuilder(256);
			string PathName = strDriveLetter + ":";
			int MaximumComponentLength = default(int);
			int FileSystemFlags = default(int);
			GetVolumeInformationA(ref PathName, stringBuilder, stringBuilder.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, stringBuilder2, stringBuilder2.Capacity);
			return Convert.ToString(VolumeSerialNumber);
		}

		public static string getHWID()
		{
			HW_PROFILE_INFO hW_PROFILE_INFO = ProfileInfo();
			string text = hW_PROFILE_INFO.szHwProfileGuid.ToString();
			string volumeSerial = GetVolumeSerial(Environment.SystemDirectory.Substring(0, 1));
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(text + volumeSerial));
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString();
			}
		}
	}
}
