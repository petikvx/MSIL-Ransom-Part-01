using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.Win32;

public class GClass0
{
	public static string string_0;

	public static string string_1;

	static GClass0()
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0017, IL_0025, IL_002a, IL_0031, IL_0038
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected native int or pointer, but got F8
		//IL_001a: Unsupported input type for neg.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I, but got F4
		_003F val;
		do
		{
			val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		}
		while (/*Error near IL_0006: Stack underflow*/ < val);
		/*Error near IL_0006: Unknown opcode: 0xFD*/;
	}

	public extern GClass0();

	[STAThread]
	public static extern void Main();

	public static extern void smethod_0();

	public static extern byte[] smethod_1(string string_2);

	public static object smethod_2(string string_2)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	public static extern void smethod_3(byte[] byte_0, string string_2, byte[] byte_1);

	public static extern void smethod_4();

	public unsafe static object smethod_5()
	{
		//IL_0008: Invalid comparison between I4 and F4
		while ((float)(int)(*(ushort*)(nint)/*Error: ldarga 0 (out-of-bounds)*/) == -1.3249431E-38f || /*Error near IL_0012: Stack underflow*/>= /*Error near IL_0012: Stack underflow*/)
		{
		}
		_ = 1;
		/*Error: Unexpected end of block*/;
	}

	public static extern void smethod_6();

	public static extern string smethod_7();

	public static extern byte[] smethod_8(byte[] byte_0);

	static extern string smethod_9(object object_0);

	static extern string smethod_10(Environment.SpecialFolder specialFolder_0);

	static extern string smethod_11(string string_2, string string_3, string string_4);

	static extern RegistryKey smethod_12(RegistryKey registryKey_0, string string_2);

	static string smethod_13(string string_2)
	{
		//Discarded unreachable code: IL_000b
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got I4
		while (true)
		{
			_003F val = checked(/*Error near IL_0003: Stack underflow*/ * string_2);
			((object[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (byte)val;
		}
	}

	static extern string smethod_14(string string_2, string string_3);

	static extern string smethod_15(string string_2);

	static extern void smethod_16(RegistryKey registryKey_0, string string_2, object object_0);

	static extern void smethod_17(int int_0);

	static extern Process smethod_18();

	static extern ProcessModule smethod_19(Process process_0);

	static string smethod_20(ProcessModule processModule_0)
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_0016, IL_0020
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0005: Stack underflow*/% processModule_0;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern int smethod_21(string string_2, string string_3, bool bool_0);

	static extern Process[] smethod_22();

	static extern void smethod_23(Process process_0);

	static extern void smethod_24(Exception exception_0);

	static extern void smethod_25();

	static extern byte[] smethod_26(string string_2);

	static extern void smethod_27(string string_2, byte[] byte_0);

	static extern void smethod_28(int int_0);

	static extern Assembly smethod_29();

	static extern ResourceManager smethod_30(string string_2, Assembly assembly_0);

	static extern object smethod_31(ResourceManager resourceManager_0, string string_2);

	static extern Encoding smethod_32();

	static extern byte[] smethod_33(string string_2);

	static extern string smethod_34(Encoding encoding_0, byte[] byte_0);

	unsafe static Assembly smethod_35(byte[] byte_0)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_001a
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		//IL_0008: Expected I4, but got I8
		//IL_000f: Invalid comparison between Unknown and I4
		_003F val2;
		checked
		{
			ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0003: Stack underflow*/+ num;
			val2 = /*Error near IL_0004: Stack underflow*/+ val;
		}
		*(sbyte*)(nint)/*Error near IL_0005: Stack underflow*/ = (sbyte)(int)val2;
		int num2 = checked((int)/*Error near IL_0006: Stack underflow*/);
		long num3 = ((long[])/*Error near IL_0007: Stack underflow*/)[num2];
		((int[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (int)num3;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Type smethod_36(Assembly assembly_0, string string_2);

	static extern MethodInfo smethod_37(Type type_0, string string_2, BindingFlags bindingFlags_0);

	static extern object smethod_38(object object_0, object object_1);

	static extern object smethod_39(MethodBase methodBase_0, object object_0, object[] object_1);

	unsafe static DirectoryInfo smethod_40(string string_2)
	{
		//IL_0004: Invalid comparison between Unknown and I4
		uint num;
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			num = checked((uint)(int)/*Error near IL_0003: Stack underflow*/);
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ <= (int)num);
		return (DirectoryInfo)/*Error near IL_000a: Stack underflow*/;
	}

	static extern string[] smethod_41(string string_2, char[] char_0);

	static extern DirectoryInfo smethod_42(string string_2);

	static extern Process[] smethod_43(string string_2);

	static extern string smethod_44(string string_2, string string_3);

	static extern Process smethod_45(string string_2);

	static extern ConnectionOptions smethod_46();

	static extern void smethod_47(ConnectionOptions connectionOptions_0, ImpersonationLevel impersonationLevel_0);

	static extern string smethod_48();

	static extern ManagementScope smethod_49(string string_2, ConnectionOptions connectionOptions_0);

	static void smethod_50(ManagementScope managementScope_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
		int num = checked((int)/*Error near IL_0003: Stack underflow*/);
		_003F val = /*Error near IL_0004: Stack underflow*/% num;
		_ = ((short[])/*Error near IL_0005: Stack underflow*/)[val];
		/*Error: Unexpected end of block*/;
	}

	static extern object smethod_51(object object_0);

	static extern string smethod_52(string string_2, object object_0);

	static ObjectQuery smethod_53(string string_2)
	{
		//Discarded unreachable code: IL_0019
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000d: Stack underflow*/<= /*Error near IL_000d: Stack underflow*/)
		{
		}
		int num = ((byte[])/*Error near IL_0010: Stack underflow*/)[4];
		checked
		{
			_ = (ushort)unchecked(/*Error near IL_0012: Stack underflow*/ - num);
			/*Error near IL_0014: Invalid metadata token*/;
		}
	}

	static extern ManagementObjectSearcher smethod_54(ManagementScope managementScope_0, ObjectQuery objectQuery_0);

	static ManagementObjectCollection smethod_55(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0001
		/*Error: Unknown opcode: 0xF9*/;
	}

	static extern ManagementObjectEnumerator smethod_56(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_57(ManagementObjectEnumerator managementObjectEnumerator_0);

	static object smethod_58(ManagementBaseObject managementBaseObject_0, string string_2)
	{
		//Discarded unreachable code: IL_0011, IL_0017, IL_001d, IL_0029, IL_0036
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Incompatible stack heights: 0 vs 1
		uint num;
		do
		{
			num = checked((uint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num || /*Error near IL_000d: Stack underflow*/> /*Error near IL_000d: Stack underflow*/);
		_ = ~/*Error near IL_0010: Stack underflow*/;
		/*Error near IL_0010: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_59(object object_0);

	static extern bool smethod_60(string string_2, string string_3);

	static extern bool smethod_61(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern void smethod_62(IDisposable idisposable_0);

	static extern Exception smethod_63(int int_0);

	static extern bool smethod_64(object object_0);

	static extern int smethod_65(string string_2);

	static extern MemoryStream smethod_66(byte[] byte_0);

	static extern ZipArchive smethod_67(Stream stream_0);

	static extern ReadOnlyCollection<ZipArchiveEntry> smethod_68(ZipArchive zipArchive_0);

	unsafe static string smethod_69(ZipArchiveEntry zipArchiveEntry_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0019, IL_001b, IL_0020, IL_0025, IL_002e, IL_0033, IL_0041, IL_0042
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				_ = *(sbyte*)(nint)/*Error near IL_0006: Stack underflow*/;
			}
		}
	}

	static extern Stream smethod_70(ZipArchiveEntry zipArchiveEntry_0);

	static extern MemoryStream smethod_71();

	static extern void smethod_72(Stream stream_0, Stream stream_1);

	static extern object smethod_73(object object_0, Type type_0, string string_2, object[] object_1, string[] string_3, Type[] type_1, bool[] bool_0);

	static extern bool smethod_74(IEnumerator ienumerator_0);

	static extern string smethod_75(string string_2);

	static extern void smethod_76(ZipArchiveEntry zipArchiveEntry_0, string string_2, bool bool_0);

	static string smethod_77(string string_2, string string_3, string string_4, string string_5)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				int num = (int)/*Error near IL_0006: Stack underflow*/;
				_003F val = /*Error near IL_0007: Stack underflow*// num;
				if (/*Error near IL_000c: Stack underflow*/ <= val)
				{
					break;
				}
			}
		}
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_000d: ldloc 0 (out-of-bounds)*/;
		_ = -78 % string_2;
		/*Error: Unexpected end of block*/;
	}

	static extern object smethod_78(object object_0, object object_1);

	static extern string smethod_79(string string_2, string string_3, string string_4);

	static extern string smethod_80(string string_2, int int_0, int int_1);

	static string smethod_81(string string_2, string string_3, string string_4, int int_0, int int_1, CompareMethod compareMethod_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_000f, IL_0017, IL_001c, IL_0021, IL_0027
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_82();

	static extern string smethod_83(string string_2);

	static extern string smethod_84(string string_2, string string_3, string string_4);

	unsafe static ManagementObjectSearcher smethod_85(ObjectQuery objectQuery_0)
	{
		//Discarded unreachable code: IL_000c
		//IL_0004: Expected I4, but got F8
		//IL_0008: Expected O, but got I4
		double num = (double)/*Error near IL_0001: Stack underflow*/;
		/*OpCode not supported: Ckfinite*/;
		*(short*)(nint)/*Error near IL_0004: Stack underflow*/ = (short)(int)num;
		_ = *(uint*)(nint)/*Error near IL_0005: Stack underflow*/;
		_ = 7;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern RijndaelManaged smethod_86();

	static MD5CryptoServiceProvider smethod_87()
	{
		return (MD5CryptoServiceProvider)/*Error near IL_0004: Stack underflow*/;
	}

	static extern byte[] smethod_88(Encoding encoding_0, string string_2);

	static byte[] smethod_89(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0003, IL_0010
		//IL_000b: Incompatible stack heights: 0 vs 2
		short num = checked((short)/*Error near IL_0001: Stack underflow*/);
		((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_90(Array array_0, int int_0, Array array_1, int int_1, int int_2);

	static extern void smethod_91(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_92(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static ICryptoTransform smethod_93(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern byte[] smethod_94(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);
}
