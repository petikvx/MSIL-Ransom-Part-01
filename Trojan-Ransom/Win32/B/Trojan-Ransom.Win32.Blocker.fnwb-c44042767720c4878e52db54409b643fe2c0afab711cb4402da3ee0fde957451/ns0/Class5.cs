using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		internal sealed class Class7
		{
			internal static int smethod_0(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 37:
						return Class9.smethod_8(693, 750);
					}
				}
			}

			internal static Assembly smethod_1(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 88:
						return Class9.smethod_9(byte_0, byte_1, evidence_0, 267, 358);
					}
				}
			}

			internal static int smethod_2(Array array_0, int int_0, int int_1, int int_2)
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 84:
						return Class9.smethod_10(array_0, int_0, 663, 735);
					}
				}
			}

			internal static int smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 106:
						return Class6.smethod_13(stream_0, byte_0, int_0, int_1, 889, 850);
					}
				}
			}

			internal static object smethod_4(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 55:
						return smethod_10(resourceManager_0, string_0, 988, 949);
					}
				}
			}

			internal static string smethod_5(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 99:
						return Class8.smethod_14(specialFolder_0, 634, 623);
					}
				}
			}

			internal static byte[] smethod_6(Encoding encoding_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 19:
						return Class5.smethod_16(encoding_0, string_0, 251, 137);
					}
				}
			}

			internal static string smethod_7(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 81:
						return Class8.smethod_15(resolveEventArgs_0, 611, 568);
					}
				}
			}

			internal static MethodInfo smethod_8(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 47:
						return Class5.smethod_17(assembly_0, 540, 593);
					}
				}
			}

			internal static string smethod_9(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 92:
						return Class5.smethod_18(string_0, string_1, 971, 987);
					}
				}
			}

			internal static object smethod_10(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 105:
						return Class5.smethod_26(resourceManager_0, string_0, 226, 209);
					}
				}
			}

			internal static void smethod_11(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 59:
						Class6.smethod_18(object_0, 552, 545);
						return;
					case 60:
						smethod_26(object_0, 777, 808);
						return;
					}
				}
			}

			internal static Assembly smethod_12(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 8:
						return Class9.smethod_14(237, 227);
					}
				}
			}

			internal static Evidence smethod_13(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 16:
						return smethod_16(assembly_0, 727, 722);
					}
				}
			}

			internal static void smethod_14(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 64:
						Class8.smethod_23(appDomain_0, resolveEventHandler_0, 648, 694);
						return;
					}
				}
			}

			internal static Encoding smethod_15(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 26:
						return Class9.smethod_15(1017, 993);
					}
				}
			}

			internal static Evidence smethod_16(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 5:
						return Class6.smethod_26(assembly_0, 320, 357);
					}
				}
			}

			internal static void smethod_17(RegistryKey registryKey_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 76:
						Class9.smethod_21(registryKey_0, 338, 320);
						return;
					}
				}
			}

			internal static char[] smethod_18(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 43:
						return Class6.smethod_27(string_0, 497, 412);
					}
				}
			}

			internal static string smethod_19(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 20:
						return Class6.smethod_28(resolveEventArgs_0, 578, 562);
					}
				}
			}

			internal static void smethod_20(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 24:
						Class5.smethod_29(appDomain_0, string_0, object_0, 300, 381);
						return;
					}
				}
			}

			internal static int smethod_21(Random random_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 46:
						return smethod_27(random_0, int_0, int_1, 492, 442);
					}
				}
			}

			internal static Assembly smethod_22(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 50:
						return Class8.smethod_31(byte_0, byte_1, evidence_0, 761, 674);
					}
				}
			}

			internal static byte[] smethod_23(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 66:
						return Class6.smethod_29(memoryStream_0, 526, 553);
					}
				}
			}

			internal static Type smethod_24(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 35:
						return smethod_28(runtimeTypeHandle_0, 217, 200);
					}
				}
			}

			internal static ParameterInfo[] smethod_25(MethodBase methodBase_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 65:
						return smethod_29(methodBase_0, 851, 874);
					}
				}
			}

			internal static void smethod_26(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 33:
						Class8.smethod_38(object_0, 995, 977);
						return;
					case 34:
						smethod_41(object_0, 1009, 1005);
						return;
					}
				}
			}

			internal static int smethod_27(Random random_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 86:
						return Class8.smethod_39(random_0, int_0, int_1, 538, 524);
					}
				}
			}

			internal static Type smethod_28(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 17:
						return Class8.smethod_40(runtimeTypeHandle_0, 828, 887);
					}
				}
			}

			internal static ParameterInfo[] smethod_29(MethodBase methodBase_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 57:
						return Class8.smethod_41(methodBase_0, 695, 736);
					}
				}
			}

			internal static string[] smethod_30(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 52:
						return Class9.smethod_24(assembly_0, 171, 228);
					}
				}
			}

			internal static object smethod_31(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 13:
						return Class8.smethod_42(appDomain_0, string_0, 220, 131);
					}
				}
			}

			internal static void smethod_32(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 92:
						Class9.smethod_25(stream_0, byte_0, int_0, int_1, 44, 123);
						return;
					}
				}
			}

			internal static void smethod_33(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 113:
						Class8.smethod_43(registryKey_0, string_0, object_0, 655, 660);
						return;
					}
				}
			}

			internal static Assembly smethod_34(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 92:
						return Class8.smethod_49(369, 303);
					}
				}
			}

			internal static string smethod_35(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 89:
						return Class5.smethod_42(string_0, string_1, 43, 51);
					}
				}
			}

			internal static void smethod_36(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 19:
						Class6.smethod_45(appDomain_0, resolveEventHandler_0, 821, 793);
						return;
					}
				}
			}

			internal static int smethod_37(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 107:
						return Class8.smethod_50(103, 55);
					}
				}
			}

			internal static void smethod_38(RegistryKey registryKey_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 106:
						smethod_42(registryKey_0, 348, 380);
						return;
					}
				}
			}

			internal static void smethod_39(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 104:
						Class8.smethod_51(string_0, string_1, 134, 164);
						return;
					}
				}
			}

			internal static void smethod_40(ResourceManager resourceManager_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 104:
						Class6.smethod_46(resourceManager_0, 422, 477);
						return;
					}
				}
			}

			internal static void smethod_41(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 28:
						Monitor.Exit(object_0);
						return;
					case 29:
						Monitor.Enter(object_0);
						return;
					}
				}
			}

			internal static void smethod_42(RegistryKey registryKey_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 32:
						registryKey_0.Close();
						return;
					}
				}
			}

			internal static void smethod_43(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 1:
						registryKey_0.SetValue(string_0, object_0);
						return;
					}
				}
			}

			internal static AppDomain smethod_44(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 36:
						return AppDomain.CurrentDomain;
					}
				}
			}

			internal static string[] smethod_45(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 24:
						return assembly_0.GetManifestResourceNames();
					}
				}
			}

			internal static void smethod_46(Array array_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 95:
						Array.Reverse(array_0);
						return;
					}
				}
			}

			internal static void smethod_47(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 117:
						appDomain_0.SetData(string_0, object_0);
						return;
					}
				}
			}

			internal static int smethod_48(Array array_0, int int_0, int int_1, int int_2)
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 3:
						return array_0.GetLength(int_0);
					}
				}
			}

			internal static byte[] smethod_49(Encoding encoding_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 90:
						return encoding_0.GetBytes(string_0);
					}
				}
			}
		}

		internal static Assembly smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					return Class8.smethod_8(567, 592);
				}
			}
		}

		internal static object smethod_1(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return Class7.smethod_4(resourceManager_0, string_0, 393, 446);
				}
			}
		}

		internal static void smethod_2(Array array_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					Class8.smethod_9(array_0, 184, 230);
					return;
				}
			}
		}

		internal static void smethod_3(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 94:
					smethod_10(object_0, 499, 511);
					return;
				case 95:
					Class7.smethod_11(object_0, 534, 557);
					return;
				}
			}
		}

		internal static string smethod_4(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return Class7.smethod_5(specialFolder_0, 1013, 918);
				}
			}
		}

		internal static RegistryKey smethod_5(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return Class5.smethod_10(registryKey_0, string_0, bool_0, 510, 384);
				}
			}
		}

		internal static object smethod_6(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 25:
					return smethod_11(appDomain_0, string_0, 332, 280);
				}
			}
		}

		internal static int smethod_7(Random random_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 90:
					return Class5.smethod_11(random_0, int_0, int_1, 8, 87);
				}
			}
		}

		internal static byte[] smethod_8(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return Class7.smethod_6(encoding_0, string_0, 794, 777);
				}
			}
		}

		internal static void smethod_9(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					Class8.smethod_16(array_0, runtimeFieldHandle_0, 682, 661);
					return;
				}
			}
		}

		internal static void smethod_10(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					Class7.smethod_11(object_0, 13, 49);
					return;
				}
			}
		}

		internal static object smethod_11(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					return smethod_14(appDomain_0, string_0, 759, 705);
				}
			}
		}

		internal static Assembly smethod_12(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					return Class8.smethod_17(byte_0, 446, 390);
				}
			}
		}

		internal static int smethod_13(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 43:
					return smethod_19(stream_0, byte_0, int_0, int_1, 864, 862);
				}
			}
		}

		internal static object smethod_14(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 54:
					return Class8.smethod_24(appDomain_0, string_0, 82, 28);
				}
			}
		}

		internal static void smethod_15(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 17:
					Class9.smethod_16(registryKey_0, string_0, object_0, 1020, 896);
					return;
				}
			}
		}

		internal static void smethod_16(RegistryKey registryKey_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					Class7.smethod_17(registryKey_0, 865, 813);
					return;
				}
			}
		}

		internal static char[] smethod_17(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 61:
					return Class7.smethod_18(string_0, 424, 387);
				}
			}
		}

		internal static void smethod_18(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					Class7.smethod_26(object_0, 610, 576);
					return;
				}
			}
		}

		internal static int smethod_19(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 62:
					return smethod_30(stream_0, byte_0, int_0, int_1, 793, 782);
				}
			}
		}

		internal static string smethod_20(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					return Class5.smethod_30(specialFolder_0, 528, 582);
				}
			}
		}

		internal static Assembly smethod_21(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					return smethod_31(byte_0, 61, 50);
				}
			}
		}

		internal static AppDomain smethod_22(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return Class8.smethod_32(853, 803);
				}
			}
		}

		internal static byte[] smethod_23(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 85:
					return Class9.smethod_22(encoding_0, string_0, 689, 742);
				}
			}
		}

		internal static void smethod_24(Array array_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					smethod_32(array_0, 43, 119);
					return;
				}
			}
		}

		internal static string[] smethod_25(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 127:
					return Class7.smethod_30(assembly_0, 742, 722);
				}
			}
		}

		internal static Evidence smethod_26(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					return smethod_39(assembly_0, 586, 521);
				}
			}
		}

		internal static char[] smethod_27(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Class5.smethod_34(string_0, 919, 901);
				}
			}
		}

		internal static string smethod_28(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 112:
					return Class8.smethod_44(resolveEventArgs_0, 682, 716);
				}
			}
		}

		internal static byte[] smethod_29(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return Class8.smethod_45(memoryStream_0, 588, 567);
				}
			}
		}

		internal static int smethod_30(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 23:
					return Class8.smethod_46(stream_0, byte_0, int_0, int_1, 919, 900);
				}
			}
		}

		internal static Assembly smethod_31(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return Class5.smethod_35(byte_0, 990, 912);
				}
			}
		}

		internal static void smethod_32(Array array_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					Class9.smethod_26(array_0, 987, 972);
					return;
				}
			}
		}

		internal static int smethod_33(Array array_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 90:
					return Class5.smethod_36(array_0, int_0, 1009, 990);
				}
			}
		}

		internal static Assembly smethod_34(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return Class7.smethod_34(262, 346);
				}
			}
		}

		internal static void smethod_35(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					smethod_40(array_0, runtimeFieldHandle_0, 914, 1017);
					return;
				}
			}
		}

		internal static object smethod_36(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return Class8.smethod_47(methodBase_0, object_0, object_1, 790, 878);
				}
			}
		}

		internal static string smethod_37(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return smethod_41(509, 504);
				}
			}
		}

		internal static string smethod_38(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					return Class7.smethod_35(string_0, string_1, 907, 978);
				}
			}
		}

		internal static Evidence smethod_39(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 67:
					return smethod_47(assembly_0, 547, 593);
				}
			}
		}

		internal static void smethod_40(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 107:
					Class8.smethod_52(array_0, runtimeFieldHandle_0, 27, 104);
					return;
				}
			}
		}

		internal static string smethod_41(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return smethod_48(523, 543);
				}
			}
		}

		internal static Assembly smethod_42(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 21:
					return Class8.smethod_53(byte_0, byte_1, evidence_0, 162, 244);
				}
			}
		}

		internal static object smethod_43(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 33:
					return Class8.smethod_54(resourceManager_0, string_0, 840, 819);
				}
			}
		}

		internal static bool smethod_44(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 27:
					return smethod_49(string_0, 248, 167);
				}
			}
		}

		internal static void smethod_45(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static void smethod_46(ResourceManager resourceManager_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					resourceManager_0.ReleaseAllResources();
					return;
				}
			}
		}

		internal static Evidence smethod_47(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return assembly_0.get_Evidence();
				}
			}
		}

		internal static string smethod_48(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return Application.get_ExecutablePath();
				}
			}
		}

		internal static bool smethod_49(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return File.Exists(string_0);
				}
			}
		}

		internal static int smethod_50(Random random_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 110:
					return random_0.Next(int_0, int_1);
				}
			}
		}

		internal static int smethod_51(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 14:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static string smethod_52(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 113:
					return Environment.GetFolderPath(specialFolder_0);
				}
			}
		}
	}

	internal sealed class Class8
	{
		internal static void smethod_0(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 32:
					Class9.smethod_4(registryKey_0, string_0, object_0, 749, 704);
					return;
				}
			}
		}

		internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					return Class5.smethod_12(runtimeTypeHandle_0, 546, 558);
				}
			}
		}

		internal static ParameterInfo[] smethod_2(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return Class5.smethod_13(methodBase_0, 847, 783);
				}
			}
		}

		internal static string smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return Class9.smethod_5(342, 261);
				}
			}
		}

		internal static string[] smethod_4(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 26:
					return smethod_10(assembly_0, 171, 142);
				}
			}
		}

		internal static string smethod_5(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return Class6.Class7.smethod_7(resolveEventArgs_0, 398, 479);
				}
			}
		}

		internal static void smethod_6(RegistryKey registryKey_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					Class9.smethod_6(registryKey_0, 690, 762);
					return;
				}
			}
		}

		internal static char[] smethod_7(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return Class5.smethod_14(string_0, 377, 324);
				}
			}
		}

		internal static Assembly smethod_8(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return Class6.Class7.smethod_12(390, 398);
				}
			}
		}

		internal static void smethod_9(Array array_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 94:
					Class5.smethod_19(array_0, 990, 939);
					return;
				}
			}
		}

		internal static string[] smethod_10(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					return Class5.smethod_20(assembly_0, 297, 319);
				}
			}
		}

		internal static AppDomain smethod_11(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					return smethod_18(664, 750);
				}
			}
		}

		internal static Evidence smethod_12(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 6:
					return Class6.Class7.smethod_13(assembly_0, 635, 619);
				}
			}
		}

		internal static object smethod_13(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return Class5.smethod_21(methodBase_0, object_0, object_1, 265, 292);
				}
			}
		}

		internal static string smethod_14(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 21:
					return Class6.smethod_20(specialFolder_0, 630, 530);
				}
			}
		}

		internal static string smethod_15(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return Class6.Class7.smethod_19(resolveEventArgs_0, 907, 927);
				}
			}
		}

		internal static void smethod_16(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 63:
					Class9.smethod_17(array_0, runtimeFieldHandle_0, 440, 482);
					return;
				}
			}
		}

		internal static Assembly smethod_17(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 56:
					return Class6.smethod_21(byte_0, 888, 862);
				}
			}
		}

		internal static AppDomain smethod_18(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return Class6.smethod_22(667, 745);
				}
			}
		}

		internal static bool smethod_19(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return Class9.smethod_18(string_0, 750, 662);
				}
			}
		}

		internal static void smethod_20(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					Class6.Class7.smethod_20(appDomain_0, string_0, object_0, 581, 605);
					return;
				}
			}
		}

		internal static void smethod_21(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					smethod_25(string_0, string_1, 412, 402);
					return;
				}
			}
		}

		internal static int smethod_22(Random random_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 85:
					return Class6.Class7.smethod_21(random_0, int_0, int_1, 693, 667);
				}
			}
		}

		internal static void smethod_23(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 62:
					smethod_33(appDomain_0, resolveEventHandler_0, 144, 133);
					return;
				}
			}
		}

		internal static object smethod_24(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return Class6.Class7.smethod_31(appDomain_0, string_0, 637, 624);
				}
			}
		}

		internal static void smethod_25(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					Class5.smethod_31(string_0, string_1, 194, 249);
					return;
				}
			}
		}

		internal static int smethod_26(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return smethod_34(777, 814);
				}
			}
		}

		internal static int smethod_27(Array array_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 21:
					return Class6.smethod_33(array_0, int_0, 898, 984);
				}
			}
		}

		internal static void smethod_28(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 111:
					Class6.Class7.smethod_32(stream_0, byte_0, int_0, int_1, 311, 363);
					return;
				}
			}
		}

		internal static RegistryKey smethod_29(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return Class5.smethod_32(registryKey_0, string_0, bool_0, 412, 423);
				}
			}
		}

		internal static void smethod_30(ResourceManager resourceManager_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					Class5.smethod_33(resourceManager_0, 82, 94);
					return;
				}
			}
		}

		internal static Assembly smethod_31(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return Class6.smethod_42(byte_0, byte_1, evidence_0, 235, 254);
				}
			}
		}

		internal static AppDomain smethod_32(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return smethod_48(173, 203);
				}
			}
		}

		internal static void smethod_33(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 21:
					Class6.Class7.smethod_36(appDomain_0, resolveEventHandler_0, 78, 93);
					return;
				}
			}
		}

		internal static int smethod_34(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return Class6.Class7.smethod_37(477, 438);
				}
			}
		}

		internal static Encoding smethod_35(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					return Class5.smethod_37(85, 106);
				}
			}
		}

		internal static object smethod_36(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					return Class6.smethod_43(resourceManager_0, string_0, 273, 304);
				}
			}
		}

		internal static MethodInfo smethod_37(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 30:
					return Class5.smethod_38(assembly_0, 510, 424);
				}
			}
		}

		internal static void smethod_38(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					Class6.Class7.smethod_41(object_0, 716, 721);
					return;
				}
			}
		}

		internal static int smethod_39(Random random_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 22:
					return Class6.smethod_50(random_0, int_0, int_1, 278, 376);
				}
			}
		}

		internal static Type smethod_40(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return Class5.smethod_43(runtimeTypeHandle_0, 192, 216);
				}
			}
		}

		internal static ParameterInfo[] smethod_41(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return Class9.smethod_28(methodBase_0, 12, 24);
				}
			}
		}

		internal static object smethod_42(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return Class9.smethod_29(appDomain_0, string_0, 472, 446);
				}
			}
		}

		internal static void smethod_43(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 27:
					Class6.Class7.smethod_43(registryKey_0, string_0, object_0, 580, 581);
					return;
				}
			}
		}

		internal static string smethod_44(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return Class5.smethod_44(resolveEventArgs_0, 965, 933);
				}
			}
		}

		internal static byte[] smethod_45(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Class5.smethod_45(memoryStream_0, 802, 814);
				}
			}
		}

		internal static int smethod_46(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 19:
					return Class6.smethod_51(stream_0, byte_0, int_0, int_1, 774, 776);
				}
			}
		}

		internal static object smethod_47(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return Class9.smethod_30(methodBase_0, object_0, object_1, 392, 485);
				}
			}
		}

		internal static AppDomain smethod_48(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return Class6.Class7.smethod_44(484, 448);
				}
			}
		}

		internal static Assembly smethod_49(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 94:
					return Assembly.GetExecutingAssembly();
				}
			}
		}

		internal static int smethod_50(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 80:
					return Environment.TickCount;
				}
			}
		}

		internal static void smethod_51(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					File.Copy(string_0, string_1);
					return;
				}
			}
		}

		internal static void smethod_52(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
			}
		}

		internal static Assembly smethod_53(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static object smethod_54(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return resourceManager_0.GetObject(string_0);
				}
			}
		}

		internal static void smethod_55(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 18:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		internal static char[] smethod_56(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 77:
					return string_0.ToCharArray();
				}
			}
		}
	}

	internal sealed class Class9
	{
		internal static bool smethod_0(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 117:
					return Class8.smethod_19(string_0, 447, 404);
				}
			}
		}

		internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					return smethod_11(memoryStream_0, 998, 998);
				}
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					Class6.Class7.smethod_14(appDomain_0, resolveEventHandler_0, 129, 193);
					return;
				}
			}
		}

		internal static void smethod_3(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					Class8.smethod_20(appDomain_0, string_0, object_0, 62, 10);
					return;
				}
			}
		}

		internal static void smethod_4(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					Class6.smethod_15(registryKey_0, string_0, object_0, 907, 922);
					return;
				}
			}
		}

		internal static string smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return Class5.smethod_22(99, 113);
				}
			}
		}

		internal static void smethod_6(RegistryKey registryKey_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					Class6.smethod_16(registryKey_0, 839, 805);
					return;
				}
			}
		}

		internal static void smethod_7(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					Class8.smethod_21(string_0, string_1, 830, 809);
					return;
				}
			}
		}

		internal static int smethod_8(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return Class8.smethod_26(953, 939);
				}
			}
		}

		internal static Assembly smethod_9(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Class6.Class7.smethod_22(byte_0, byte_1, evidence_0, 397, 447);
				}
			}
		}

		internal static int smethod_10(Array array_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 72:
					return Class8.smethod_27(array_0, int_0, 886, 867);
				}
			}
		}

		internal static byte[] smethod_11(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 0:
					return Class6.Class7.smethod_23(memoryStream_0, 985, 923);
				}
			}
		}

		internal static void smethod_12(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 3:
					Class8.smethod_28(stream_0, byte_0, int_0, int_1, 6, 105);
					return;
				}
			}
		}

		internal static RegistryKey smethod_13(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 77:
					return Class8.smethod_29(registryKey_0, string_0, bool_0, 599, 579);
				}
			}
		}

		internal static Assembly smethod_14(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					return Class6.smethod_34(908, 1012);
				}
			}
		}

		internal static Encoding smethod_15(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 24:
					return Class8.smethod_35(431, 498);
				}
			}
		}

		internal static void smethod_16(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 124:
					Class6.Class7.smethod_33(registryKey_0, string_0, object_0, 143, 254);
					return;
				}
			}
		}

		internal static void smethod_17(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					Class6.smethod_35(array_0, runtimeFieldHandle_0, 926, 992);
					return;
				}
			}
		}

		internal static bool smethod_18(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return smethod_23(string_0, 854, 779);
				}
			}
		}

		internal static object smethod_19(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					return Class6.smethod_36(methodBase_0, object_0, object_1, 1009, 1010);
				}
			}
		}

		internal static string smethod_20(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 13:
					return Class6.smethod_37(853, 801);
				}
			}
		}

		internal static void smethod_21(RegistryKey registryKey_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					Class6.Class7.smethod_38(registryKey_0, 526, 612);
					return;
				}
			}
		}

		internal static byte[] smethod_22(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return smethod_39(encoding_0, string_0, 424, 423);
				}
			}
		}

		internal static bool smethod_23(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					return Class6.smethod_44(string_0, 462, 469);
				}
			}
		}

		internal static string[] smethod_24(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return Class6.Class7.smethod_45(assembly_0, 210, 202);
				}
			}
		}

		internal static void smethod_25(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 87:
					Class8.smethod_55(stream_0, byte_0, int_0, int_1, 215, 197);
					return;
				}
			}
		}

		internal static void smethod_26(Array array_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					Class6.Class7.smethod_46(array_0, 792, 839);
					return;
				}
			}
		}

		internal static void smethod_27(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 105:
					Class6.Class7.smethod_47(appDomain_0, string_0, object_0, 780, 889);
					return;
				}
			}
		}

		internal static ParameterInfo[] smethod_28(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return methodBase_0.GetParameters();
				}
			}
		}

		internal static object smethod_29(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return appDomain_0.GetData(string_0);
				}
			}
		}

		internal static object smethod_30(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return methodBase_0.Invoke(object_0, object_1);
				}
			}
		}

		internal static Assembly smethod_31(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 6:
					return Assembly.Load(byte_0);
				}
			}
		}

		internal static Encoding smethod_32(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return Encoding.Default;
				}
			}
		}

		internal static RegistryKey smethod_33(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					return registryKey_0.OpenSubKey(string_0, bool_0);
				}
			}
		}
	}

	internal static void smethod_0(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				smethod_15(resourceManager_0, 463, 422);
				return;
			}
		}
	}

	internal static Assembly smethod_1(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return Class6.smethod_12(byte_0, 443, 495);
			}
		}
	}

	internal static MethodInfo smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return Class6.Class7.smethod_8(assembly_0, 719, 736);
			}
		}
	}

	internal static AppDomain smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return Class8.smethod_11(822, 826);
			}
		}
	}

	internal static void smethod_4(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				Class6.smethod_9(array_0, runtimeFieldHandle_0, 529, 539);
				return;
			}
		}
	}

	internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return Class6.Class7.smethod_9(string_0, string_1, 622, 562);
			}
		}
	}

	internal static void smethod_6(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				Class9.smethod_7(string_0, string_1, 859, 849);
				return;
			}
		}
	}

	internal static Evidence smethod_7(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class8.smethod_12(assembly_0, 783, 777);
			}
		}
	}

	internal static void smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 5:
				Class9.smethod_12(stream_0, byte_0, int_0, int_1, 771, 768);
				return;
			}
		}
	}

	internal static Encoding smethod_9(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class6.Class7.smethod_15(737, 763);
			}
		}
	}

	internal static RegistryKey smethod_10(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				return Class9.smethod_13(registryKey_0, string_0, bool_0, 973, 896);
			}
		}
	}

	internal static int smethod_11(Random random_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 95:
				return Class8.smethod_22(random_0, int_0, int_1, 315, 366);
			}
		}
	}

	internal static Type smethod_12(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return smethod_23(runtimeTypeHandle_0, 1020, 944);
			}
		}
	}

	internal static ParameterInfo[] smethod_13(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return smethod_24(methodBase_0, 169, 247);
			}
		}
	}

	internal static char[] smethod_14(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class6.smethod_17(string_0, 33, 28);
			}
		}
	}

	internal static void smethod_15(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				smethod_25(resourceManager_0, 140, 142);
				return;
			}
		}
	}

	internal static byte[] smethod_16(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return Class6.smethod_23(encoding_0, string_0, 637, 552);
			}
		}
	}

	internal static MethodInfo smethod_17(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				return smethod_27(assembly_0, 885, 824);
			}
		}
	}

	internal static string smethod_18(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return smethod_28(string_0, string_1, 476, 416);
			}
		}
	}

	internal static void smethod_19(Array array_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				Class6.smethod_24(array_0, 785, 839);
				return;
			}
		}
	}

	internal static string[] smethod_20(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return Class6.smethod_25(assembly_0, 805, 858);
			}
		}
	}

	internal static object smethod_21(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 45:
				return Class9.smethod_19(methodBase_0, object_0, object_1, 805, 854);
			}
		}
	}

	internal static string smethod_22(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return Class9.smethod_20(959, 946);
			}
		}
	}

	internal static Type smethod_23(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				return Class6.Class7.smethod_24(runtimeTypeHandle_0, 198, 229);
			}
		}
	}

	internal static ParameterInfo[] smethod_24(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 94:
				return Class6.Class7.smethod_25(methodBase_0, 931, 994);
			}
		}
	}

	internal static void smethod_25(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				Class8.smethod_30(resourceManager_0, 202, 192);
				return;
			}
		}
	}

	internal static object smethod_26(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return Class8.smethod_36(resourceManager_0, string_0, 587, 572);
			}
		}
	}

	internal static MethodInfo smethod_27(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				return Class8.smethod_37(assembly_0, 436, 426);
			}
		}
	}

	internal static string smethod_28(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				return Class6.smethod_38(string_0, string_1, 147, 153);
			}
		}
	}

	internal static void smethod_29(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				Class9.smethod_27(appDomain_0, string_0, object_0, 321, 296);
				return;
			}
		}
	}

	internal static string smethod_30(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return smethod_40(specialFolder_0, 14, 62);
			}
		}
	}

	internal static void smethod_31(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				Class6.Class7.smethod_39(string_0, string_1, 480, 392);
				return;
			}
		}
	}

	internal static RegistryKey smethod_32(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				return smethod_41(registryKey_0, string_0, bool_0, 629, 603);
			}
		}
	}

	internal static void smethod_33(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				Class6.Class7.smethod_40(resourceManager_0, 177, 217);
				return;
			}
		}
	}

	internal static char[] smethod_34(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return Class8.smethod_56(string_0, 711, 650);
			}
		}
	}

	internal static Assembly smethod_35(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Class9.smethod_31(byte_0, 180, 178);
			}
		}
	}

	internal static int smethod_36(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 47:
				return Class6.Class7.smethod_48(array_0, int_0, 831, 828);
			}
		}
	}

	internal static Encoding smethod_37(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return Class9.smethod_32(27, 13);
			}
		}
	}

	internal static MethodInfo smethod_38(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return smethod_46(assembly_0, 728, 640);
			}
		}
	}

	internal static byte[] smethod_39(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 15:
				return Class6.Class7.smethod_49(encoding_0, string_0, 137, 211);
			}
		}
	}

	internal static string smethod_40(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return Class6.smethod_52(specialFolder_0, 880, 769);
			}
		}
	}

	internal static RegistryKey smethod_41(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return Class9.smethod_33(registryKey_0, string_0, bool_0, 993, 901);
			}
		}
	}

	internal static string smethod_42(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return string_0 + string_1;
			}
		}
	}

	internal static Type smethod_43(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	internal static string smethod_44(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 96:
				return resolveEventArgs_0.Name;
			}
		}
	}

	internal static byte[] smethod_45(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return memoryStream_0.ToArray();
			}
		}
	}

	internal static MethodInfo smethod_46(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return assembly_0.EntryPoint;
			}
		}
	}
}
