using System;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal sealed class Class6
		{
			internal sealed class Class7
			{
				[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
				private struct Struct4
				{
				}

				private static readonly char[] char_0;

				private static readonly char[] char_1;

				private static readonly string[] string_0;

				internal static Struct4 struct4_0/* Not supported: data(00 00 24 00 00 00 33 25 30 3E 9A 14 9F 13 9A 3A B4 11 C1 1E 00 30 2D 25 65 3E CF 14 C0 13 CE 3A AB 11 90 1E 0B 30 33 25 64 3E 84 14 9F 13 CC 3A BF 11 C2 1E 14 30 37 25 34 3E C8 14 C2 13 9E 3A B0 11 9D 1E 5A 30 65 25 30 3E 91 14 92 13) */;

				static Class7()
				{
					char[] array_ = new char[39];
					Class8.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 70, 46);
					char_1 = array_;
					char[] array = new char[8];
					array[6] = 'Ấ';
					array[3] = 'Ꭶ';
					array[1] = '㸇';
					array[0] = '─';
					array[2] = 'ᒩ';
					array[7] = '〹';
					array[4] = '㪯';
					array[5] = 'ᆆ';
					string_0 = new string[1];
					char_0 = array;
				}

				internal static string smethod_0(int int_0, int int_1)
				{
					int num = int_0 ^ 0x7E2B68BD ^ int_1;
					char[] array = char_1;
					int num2 = array[num];
					string result;
					if ((result = string_0[num2]) != null)
					{
						return result;
					}
					int num3 = array[num + 1];
					num3 = (int)((uint)array[num + 2] << 16) + num3;
					char[] array2 = new char[num3];
					char[] array3 = char_0;
					int num4 = array3.Length;
					num += 3;
					for (int num5 = 0; num5 < num3; num5 = 1 + num5)
					{
						array2[num5] = (char)(array[num + num5] ^ array3[(num5 + num2) % num4]);
					}
					result = new string(array2);
					string_0[num2] = result;
					return result;
				}

				[SecuritySafeCritical]
				internal static string[] smethod_1(Assembly assembly_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 122:
							return Class5.smethod_7(assembly_0, 592, 548);
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_2(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 23:
							return Class8.smethod_1(resolveEventArgs_0, 314, 258);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 103:
							Class8.smethod_0(array_0, runtimeFieldHandle_0, 452, 428);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static Stream smethod_4(PackagePart packagePart_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 20:
							return Class8.smethod_2(packagePart_0, 528, 555);
						}
					}
				}

				[SecuritySafeCritical]
				internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
				{
					while (true)
					{
						switch (int_3 ^ int_2)
						{
						case 89:
							return Class0.smethod_20(stream_0, byte_0, int_0, int_1, 442, 445);
						}
					}
				}

				[SecuritySafeCritical]
				internal static byte[] smethod_6(MemoryStream memoryStream_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 4:
							return Class4.smethod_20(memoryStream_0, 247, 206);
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_7(Assembly assembly_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 113:
							return Class5.smethod_8(assembly_0, 706, 733);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_8(Form form_0, IButtonControl ibuttonControl_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 88:
							Class8.smethod_6(form_0, ibuttonControl_0, 924, 971);
							return;
						case 89:
							Class8.smethod_16(form_0, ibuttonControl_0, 989, 899);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_9(Form form_0, FormBorderStyle formBorderStyle_0, int int_0, int int_1)
				{
					//IL_0016: Unknown result type (might be due to invalid IL or missing references)
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 53:
							Class8.smethod_7(form_0, formBorderStyle_0, 184, 249);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_10(Form form_0, bool bool_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 34:
							Class4.smethod_22(form_0, bool_0, 619, 555);
							return;
						case 35:
							Class5.smethod_21(form_0, bool_0, 668, 695);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_11(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 39:
							Class8.smethod_8(930, 1013);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_12(Form form_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 55:
							Class0.smethod_24(form_0, 490, 454);
							return;
						case 56:
							Class8.smethod_17(form_0, 995, 932);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_13(Control control_0, Color color_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 103:
							Class5.smethod_13(control_0, color_0, 184, 206);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_14(PictureBox pictureBox_0, Image image_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 101:
							Class4.smethod_24(pictureBox_0, image_0, 346, 333);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static Assembly smethod_15(byte[] byte_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 113:
							return Class5.smethod_14(byte_0, 847, 864);
						}
					}
				}
			}

			internal sealed class Class8
			{
				[SecuritySafeCritical]
				internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 104:
							Class0.smethod_34(array_0, runtimeFieldHandle_0, 287, 363);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_1(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 56:
							return Class6.smethod_28(resolveEventArgs_0, 744, 712);
						}
					}
				}

				[SecuritySafeCritical]
				internal static Stream smethod_2(PackagePart packagePart_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 59:
							return Class0.smethod_35(packagePart_0, 696, 745);
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_3(Exception exception_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 68:
							return Class4.smethod_35(exception_0, 1020, 913);
						case 69:
							return Class4.smethod_35(exception_0, 431, 449);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_4(Control control_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 6:
							Class0.smethod_37(control_0, 665, 660);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static Package smethod_5(Stream stream_0, FileMode fileMode_0, FileAccess fileAccess_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 101:
							return Class0.smethod_38(stream_0, fileMode_0, fileAccess_0, 453, 412);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_6(Form form_0, IButtonControl ibuttonControl_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 87:
							smethod_16(form_0, ibuttonControl_0, 814, 881);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_7(Form form_0, FormBorderStyle formBorderStyle_0, int int_0, int int_1)
				{
					//IL_0016: Unknown result type (might be due to invalid IL or missing references)
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 65:
							Class4.smethod_39(form_0, formBorderStyle_0, 455, 505);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_8(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 87:
							smethod_19(311, 358);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static RegistryKey smethod_9(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 127:
							return smethod_20(registryKey_0, string_0, 751, 676);
						}
					}
				}

				[SecuritySafeCritical]
				internal static object smethod_10(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 76:
							return smethod_21(registryKey_0, string_0, object_0, 415, 465);
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_11(object object_0, object object_1, object object_2, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 96:
							return smethod_36(object_0, object_1, object_2, 301, 266);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_12(PictureBox pictureBox_0, bool bool_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 126:
							Class0.smethod_39(pictureBox_0, bool_0, 753, 681);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static bool smethod_13(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 110:
							return smethod_22(assembly_0, assembly_1, 125, 16);
						case 111:
							return smethod_22(assembly_0, assembly_1, 835, 813);
						}
					}
				}

				[SecuritySafeCritical]
				internal static Assembly smethod_14(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 87:
							return smethod_23(466, 426);
						}
					}
				}

				[SecuritySafeCritical]
				internal static string smethod_15(MemberInfo memberInfo_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 110:
							return Class0.smethod_40(memberInfo_0, 192, 135);
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_16(Form form_0, IButtonControl ibuttonControl_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 94:
							form_0.set_CancelButton(ibuttonControl_0);
							return;
						case 95:
							form_0.set_AcceptButton(ibuttonControl_0);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_17(Form form_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 71:
							form_0.Close();
							return;
						case 72:
							Application.Run(form_0);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static int smethod_18(Version version_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 0:
							return version_0.Major;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_19(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 81:
							Application.DoEvents();
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static RegistryKey smethod_20(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 75:
							return registryKey_0.OpenSubKey(string_0);
						}
					}
				}

				[SecuritySafeCritical]
				internal static object smethod_21(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 78:
							return registryKey_0.GetValue(string_0, object_0);
						}
					}
				}

				[SecuritySafeCritical]
				internal static bool smethod_22(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 109:
							return assembly_0 == assembly_1;
						case 110:
							return assembly_0 != assembly_1;
						}
					}
				}

				[SecuritySafeCritical]
				internal static Assembly smethod_23(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 120:
							return Assembly.GetExecutingAssembly();
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_24(Form form_0, Size size_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 67:
							form_0.set_ClientSize(size_0);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static MethodInfo smethod_25(Assembly assembly_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 71:
							return assembly_0.EntryPoint;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_26(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 17:
							appDomain_0.AssemblyResolve += resolveEventHandler_0;
							return;
						case 18:
							appDomain_0.ResourceResolve += resolveEventHandler_0;
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static void smethod_27(Control control_0, Color color_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 82:
							control_0.set_BackColor(color_0);
							return;
						}
					}
				}

				[SecuritySafeCritical]
				internal static DateTime smethod_28(string string_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 111:
							return DateTime.Parse(string_0);
						}
					}
				}

				[SecuritySafeCritical]
				internal static bool smethod_29(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 9:
							return dateTime_0 > dateTime_1;
						case 10:
							return dateTime_0 < dateTime_1;
						}
					}
				}

				[SecuritySafeCritical]
				internal static AppDomain smethod_30(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 1:
							return AppDomain.CurrentDomain;
						}
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_0(AssemblyName assemblyName_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 62:
						return Class4.smethod_25(assemblyName_0, 519, 522);
					}
				}
			}

			[SecuritySafeCritical]
			internal static AssemblyName smethod_1(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 41:
						return Class0.smethod_25(assembly_0, 386, 470);
					}
				}
			}

			[SecuritySafeCritical]
			internal static RegistryKey smethod_2(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 88:
						return Class8.smethod_9(registryKey_0, string_0, 438, 457);
					}
				}
			}

			[SecuritySafeCritical]
			internal static int smethod_3(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 51:
						return Class4.smethod_26(string_0, 511, 435);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_4(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 43:
						smethod_21(object_0, 274, 336);
						return;
					case 44:
						smethod_37(object_0, 420, 392);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static Evidence smethod_5(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 23:
						return smethod_22(assembly_0, 431, 475);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Stream smethod_6(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 114:
						return Class4.smethod_27(assembly_0, string_0, 896, 907);
					}
				}
			}

			[SecuritySafeCritical]
			internal static object smethod_7(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 2:
						return Class8.smethod_10(registryKey_0, string_0, object_0, 458, 390);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Assembly smethod_8(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 101:
						return Class0.smethod_26(resolveEventArgs_0, 40, 96);
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_9(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 68:
						return Class5.smethod_15(string_0, 279, 298);
					}
				}
			}

			[SecuritySafeCritical]
			internal static bool smethod_10(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 103:
						return Class4.smethod_28(dateTime_0, dateTime_1, 897, 952);
					case 104:
						return Class4.smethod_28(dateTime_0, dateTime_1, 673, 667);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Assembly smethod_11(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 125:
						return Class0.smethod_27(byte_0, byte_1, evidence_0, 851, 871);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Type smethod_12(Exception exception_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 9:
						return Class0.smethod_28(exception_0, 391, 426);
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_13(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 80:
						return smethod_23(699, 670);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_14(Form form_0, Size size_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 109:
						smethod_18(form_0, size_0, 543, 537);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_15(Form form_0, FormStartPosition formStartPosition_0, int int_0, int int_1)
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 80:
						Class4.smethod_40(form_0, formStartPosition_0, 834, 828);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_16(string[] string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 33:
						return Class4.smethod_41(string_0, 467, 460);
					}
				}
			}

			[SecuritySafeCritical]
			internal static DialogResult smethod_17(string string_0, int int_0, int int_1)
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 60:
						return smethod_38(string_0, 402, 409);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_18(Form form_0, Size size_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 5:
						Class8.smethod_24(form_0, size_0, 119, 52);
						return;
					case 6:
						form_0.set_AutoScaleBaseSize(size_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static MethodInfo smethod_19(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 18:
						return Class8.smethod_25(assembly_0, 428, 491);
					}
				}
			}

			[SecuritySafeCritical]
			internal static PackagePart smethod_20(Package package_0, Uri uri_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 106:
						return Class5.smethod_24(package_0, uri_0, 653, 722);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_21(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 66:
						smethod_37(object_0, 83, 126);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static Evidence smethod_22(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 116:
						return smethod_39(assembly_0, 432, 490);
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_23(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 37:
						return Class4.smethod_42(187, 166);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_24(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 17:
						Class8.smethod_26(appDomain_0, resolveEventHandler_0, 730, 715);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_25(Control control_0, Size size_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 56:
						smethod_40(control_0, size_0, 45, 26);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static bool smethod_26(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 59:
						return Class4.smethod_43(string_0, string_1, 91, 48);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_27(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 79:
						Class4.smethod_44(stream_0, byte_0, int_0, int_1, 122, 69);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_28(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 32:
						return resolveEventArgs_0.Name;
					}
				}
			}

			[SecuritySafeCritical]
			internal static DateTime smethod_29(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 62:
						return DateTime.Now;
					}
				}
			}

			[SecuritySafeCritical]
			internal static AssemblyName smethod_30(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 126:
						return assembly_0.GetName();
					}
				}
			}

			[SecuritySafeCritical]
			internal static Assembly smethod_31(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 28:
						return resolveEventArgs_0.RequestingAssembly;
					}
				}
			}

			[SecuritySafeCritical]
			internal static ControlCollection smethod_32(Control control_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 75:
						return control_0.get_Controls();
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_33(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 43:
						appDomain_0.SetData(string_0, object_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static object smethod_34(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 45:
						return appDomain_0.GetData(string_0);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_35(RegistryKey registryKey_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 13:
						registryKey_0.Close();
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_36(object object_0, object object_1, object object_2, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 39:
						return string.Concat(object_0, object_1, object_2);
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_37(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 44:
						Monitor.Exit(object_0);
						return;
					case 45:
						Monitor.Enter(object_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static DialogResult smethod_38(string string_0, int int_0, int int_1)
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 11:
						return MessageBox.Show(string_0);
					}
				}
			}

			[SecuritySafeCritical]
			internal static Evidence smethod_39(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 90:
						return assembly_0.get_Evidence();
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_40(Control control_0, Size size_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 55:
						control_0.set_Size(size_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_41(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 10:
						return string_0 + string_1;
					}
				}
			}

			[SecuritySafeCritical]
			internal static byte[] smethod_42(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 122:
						return memoryStream_0.ToArray();
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_43(PictureBox pictureBox_0, Image image_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 38:
						pictureBox_0.set_Image(image_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static Stream smethod_44(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 65:
						return assembly_0.GetManifestResourceStream(string_0);
					}
				}
			}

			[SecuritySafeCritical]
			internal static long smethod_45(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 45:
						return stream_0.Length;
					}
				}
			}

			[SecuritySafeCritical]
			internal static void smethod_46(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_0, int int_1)
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 12:
						buttonBase_0.set_FlatStyle(flatStyle_0);
						return;
					}
				}
			}

			[SecuritySafeCritical]
			internal static string smethod_47(string string_0, object object_0, object object_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 109:
						return string.Format(string_0, object_0, object_1);
					}
				}
			}
		}

		[SecuritySafeCritical]
		internal static ControlCollection smethod_0(Control control_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return Class0.smethod_29(control_0, 588, 566);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_1(object object_0, object object_1, object object_2, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 122:
					return Class6.Class8.smethod_11(object_0, object_1, object_2, 846, 814);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DateTime smethod_2(ref DateTime dateTime_0, double double_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 41:
					return smethod_16(ref dateTime_0, double_0, 1012, 923);
				}
			}
		}

		[SecuritySafeCritical]
		internal static Color smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Class4.smethod_29(678, 748);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DialogResult smethod_4(Form form_0, int int_0, int int_1)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 0:
					return smethod_17(form_0, 955, 948);
				}
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_5(Version version_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return Class0.smethod_30(version_0, 557, 515);
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_6(Control control_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 50:
					Class4.smethod_30(control_0, int_0, 302, 349);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string[] smethod_7(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return smethod_45(assembly_0, 604, 551);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_8(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					return smethod_46(assembly_0, 526, 600);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_9(ref DateTime dateTime_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return smethod_25(ref dateTime_0, string_0, 296, 262);
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_10(Control control_0, Point point_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					smethod_47(control_0, point_0, 320, 383);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_11(Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return smethod_48(type_0, 343, 286);
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_12(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 96:
					return Class0.smethod_41(methodBase_0, object_0, object_1, 473, 442);
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_13(Control control_0, Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					Class6.Class8.smethod_27(control_0, color_0, 377, 299);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_14(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					return Class0.smethod_42(byte_0, 573, 550);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_15(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 61:
					return Class0.smethod_43(string_0, 588, 538);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DateTime smethod_16(ref DateTime dateTime_0, double double_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					return smethod_26(ref dateTime_0, double_0, 736, 737);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DialogResult smethod_17(Form form_0, int int_0, int int_1)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return smethod_27(form_0, 685, 708);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_18(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 57:
					return Class6.smethod_41(string_0, string_1, 661, 671);
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_19(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					smethod_49(control_0, eventHandler_0, 797, 871);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static DateTime smethod_20(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 29:
					return Class6.Class8.smethod_28(string_0, 979, 956);
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_21(Form form_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					form_0.set_MinimizeBox(bool_0);
					return;
				case 44:
					form_0.set_TopMost(bool_0);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_22(Control control_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					control_0.ResumeLayout(bool_0);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_23(string string_0, string string_1, string string_2, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return string_0 + string_1 + string_2;
				}
			}
		}

		[SecuritySafeCritical]
		internal static PackagePart smethod_24(Package package_0, Uri uri_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return package_0.GetPart(uri_0);
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_25(ref DateTime dateTime_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return dateTime_0.ToString(string_0);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DateTime smethod_26(ref DateTime dateTime_0, double double_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					return dateTime_0.AddDays(double_0);
				}
			}
		}

		[SecuritySafeCritical]
		internal static DialogResult smethod_27(Form form_0, int int_0, int int_1)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 105:
					return form_0.ShowDialog();
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_28(Control control_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 112:
					control_0.set_Text(string_0);
					return;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_29(AssemblyName assemblyName_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return assemblyName_0.Name;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Color smethod_30(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return Color.White;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_31(Control control_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 77:
					control_0.set_TabIndex(int_0);
					return;
				}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_0(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				Class0.smethod_31(appDomain_0, string_0, object_0, 640, 764);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				return Class0.smethod_32(appDomain_0, string_0, 635, 554);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(PictureBox pictureBox_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				Class5.Class6.Class8.smethod_12(pictureBox_0, bool_0, 721, 687);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_3(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return smethod_31(stream_0, 575, 567);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				smethod_32(buttonBase_0, flatStyle_0, 380, 351);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				Class5.Class6.smethod_24(appDomain_0, resolveEventHandler_0, 300, 317);
				return;
			case 124:
				Class5.Class6.Class8.smethod_26(appDomain_0, resolveEventHandler_0, 982, 964);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_6(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				return Class5.smethod_18(string_0, string_1, 415, 422);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7(Control control_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				smethod_21(control_0, string_0, 88, 126);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_8(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return smethod_33(876, 815);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_9(Control control_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				Class5.Class6.smethod_25(control_0, size_0, 652, 692);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_10(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				Class5.smethod_19(control_0, eventHandler_0, 86, 99);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_11(string string_0, object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return smethod_34(string_0, object_0, object_1, 207, 132);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_12(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 62:
				return Class5.Class6.Class8.smethod_13(assembly_0, assembly_1, 301, 323);
			case 63:
				return Class5.Class6.Class8.smethod_13(assembly_0, assembly_1, 808, 839);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_13(RegistryKey registryKey_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				Class0.smethod_33(registryKey_0, 784, 868);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_14(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				return Class5.Class6.Class8.smethod_14(89, 14);
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_15(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				return Class5.smethod_20(string_0, 546, 575);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_16(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				return Class5.Class6.smethod_26(string_0, string_1, 869, 862);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_17(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 101:
				Class5.Class6.smethod_27(stream_0, byte_0, int_0, int_1, 947, 1020);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_18(MemberInfo memberInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 70:
				return Class5.Class6.Class8.smethod_15(memberInfo_0, 293, 331);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_19(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return Class5.Class6.Class8.smethod_3(exception_0, 381, 312);
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_20(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return Class5.Class6.smethod_42(memoryStream_0, 1012, 910);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_21(Control control_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				Class5.smethod_28(control_0, string_0, 632, 520);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_22(Form form_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				Class5.smethod_21(form_0, bool_0, 132, 168);
				return;
			case 64:
				form_0.set_MaximizeBox(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_23(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return smethod_50(runtimeTypeHandle_0, 31, 104);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_24(PictureBox pictureBox_0, Image image_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				Class5.Class6.smethod_43(pictureBox_0, image_0, 757, 723);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_25(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return Class5.smethod_29(assemblyName_0, 848, 808);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_26(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				return smethod_51(string_0, 586, 602);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream smethod_27(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 11:
				return Class5.Class6.smethod_44(assembly_0, string_0, 847, 782);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_28(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return Class5.Class6.Class8.smethod_29(dateTime_0, dateTime_1, 12, 5);
			case 58:
				return Class5.Class6.Class8.smethod_29(dateTime_0, dateTime_1, 494, 484);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Color smethod_29(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				return Class5.smethod_30(230, 169);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_30(Control control_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 115:
				Class5.smethod_31(control_0, int_0, 492, 417);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_31(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Class5.Class6.smethod_45(stream_0, 929, 908);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_32(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				Class5.Class6.smethod_46(buttonBase_0, flatStyle_0, 74, 70);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_33(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return Class5.Class6.Class8.smethod_30(269, 268);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_34(string string_0, object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return Class5.Class6.smethod_47(string_0, object_0, object_1, 818, 863);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_35(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return exception_0.StackTrace;
			case 110:
				return exception_0.Message;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_36(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 2:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_37(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_38(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return exception_0.GetType();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_39(Form form_0, FormBorderStyle formBorderStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 62:
				form_0.set_FormBorderStyle(formBorderStyle_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_40(Form form_0, FormStartPosition formStartPosition_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				form_0.set_StartPosition(formStartPosition_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_41(string[] string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return string.Concat(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_42(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				return Environment.NewLine;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_43(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return string_0.Equals(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_44(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 63:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] smethod_45(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_46(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return assembly_0.FullName;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_47(Control control_0, Point point_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				control_0.set_Location(point_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_48(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return type_0.Assembly;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_49(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				control_0.add_Click(eventHandler_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_50(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_51(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return string_0.Length;
			}
		}
	}
}
