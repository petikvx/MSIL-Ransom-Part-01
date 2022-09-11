using System;
using System.Configuration.Assemblies;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;

public class GClass0 : MarshalByRefObject
{
	internal sealed class Class9
	{
		public ApartmentState apartmentState_0;

		public string string_0;

		public byte[] byte_0;

		public AssemblyHashAlgorithm assemblyHashAlgorithm_0;

		public extern Class9();
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 434)]
	private struct Struct1
	{
	}

	private Class9 class9_0;

	private Class1.Class2 class2_0;

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly Array array_0;

	internal static Struct1 struct1_0/* Not supported: data(AD 07 55 65 82 78 AF 14 EA 84 3F 1F 11 63 AE 26 43 78 AB DC 57 49 CD 82 C4 D2 A8 77 60 90 76 C3 08 7F 05 66 10 A0 A3 04 35 9E A1 FC 46 E8 D2 B9 7E 88 24 67 A8 82 41 CA 4C 46 1B 67 E0 4F B2 C6 83 83 FD 12 14 12 BD F3 EA 29 D5 C0 24 15 04 E9 A0 56 8F EC 8B 87 C6 38 1D 1A 9E 57 E7 49 83 D1 31 6A AD 6D 1C 15 55 BA 83 26 B0 D8 F0 E1 2D 27 A2 7D B3 6A F5 77 D0 FF A5 8E 21 46 6A 86 CA D4 DB BA F8 41 62 2B B8 18 9F 68 35 E1 47 3A D5 23 D0 68 95 0D 58 AA 65 73 C3 47 94 97 BD 51 0D 31 20 AF 5C 85 3F 36 FE EB 6A 5F E0 14 B5 29 F1 5A D5 98 41 86 03 AB 63 2E 56 A7 49 81 22 8D AD 2C B9 DF 9F 51 6B 58 B0 45 54 81 2A 47 BB 3B 40 38 A5 E2 78 4D 4C D4 03 B7 79 42 96 DD CF 69 C6 7C 62 D6 63 E3 B5 63 01 17 70 AA 5F 5A C4 41 B0 8A B6 C1 92 E3 E6 EE A0 52 A8 E2 C3 B7 2C A5 4B 78 8E 06 F5 FE 2B F1 C9 F2 E8 DF 41 17 64 F0 52 E6 53 BF 59 23 51 57 C3 4C E6 F7 85 9E 5B 16 4B 2E 91 4B 49 89 A8 20 D0 EC C8 4F 81 1D 6E EE A0 5C 36 5C 2A 89 D0 BD 09 28 0E 9E BA 61 84 59 1B 09 84 B4 4C BE A6 99 64 A3 92 BA FB FB 38 B4 09 9B 04 7D 06 27 77 39 63 CC 20 62 C3 A2 B5 53 D1 24 9A 23 17 95 B7 09 DA 4A 3A 0A B9 25 6B 7B A3 D2 64 D4 F2 94 96 A4 A3 C7 47 64 02 3D 9D 24 F7 C2 3C 45 EC 66 0B 48 98 4D B2 56 39 F0 D9 15 5A 11 ED 7A 05 B9 25 AF DB E5 7A 78 7A 11 9B 99 78 93 46 BA 34 23 A4 FB 78 91 BD 2B 8A 7A FB 91 1E 07 EE F3) */;

	public Stream Stream_0
	{
		[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
		get
		{
			//Discarded unreachable code: IL_000e, IL_0019, IL_0025, IL_002b, IL_0030
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected F8, but got Unknown
			//IL_0020: Invalid comparison between I4 and F4
			//IL_0026: Invalid comparison between Unknown and I4
			while (true)
			{
				if (/*Error near IL_0009: Stack underflow*/ <= /*Error near IL_0009: Stack underflow*/)
				{
				}
			}
		}
	}

	internal extern void method_0();

	internal extern int method_1();

	internal extern int method_2(bool bool_0);

	[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
	public extern int method_3(string string_0, Evidence evidence_0, byte[] byte_0, AssemblyHashAlgorithm assemblyHashAlgorithm_0);

	[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
	public extern int method_4(string string_0, Evidence evidence_0, object object_2);

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
	public override object vmethod_0()
	{
		//Discarded unreachable code: IL_000e
		//IL_0007: Expected I4, but got F4
		//IL_0009: Expected F4, but got I4
		((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = 0;
		sbyte num = (sbyte)/*Error near IL_0008: Stack underflow*/;
		((float[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = num;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	public extern GClass0();

	internal static extern string smethod_0(long long_0, int int_0, int int_1);

	unsafe static Thread NOuUkuRtcIsiSHoQCpsuOySUHREE(ThreadStart threadStart_0)
	{
		//Discarded unreachable code: IL_000c, IL_0011
		//IL_0007: Expected I, but got F4
		//IL_001b: Invalid comparison between I4 and F8
		while (true)
		{
			*(IntPtr*)6 = (IntPtr)(-1.7307485E+19f);
		}
	}

	static extern void PaaYydxmmcNmJddYLqPIupMXcZRj(Thread thread_0, ApartmentState apartmentState_0);

	static void NmcJTozjrTsncvZVWKGWtiQnvxGm(Thread thread_0)
	{
		_ = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0003: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static void AWkoOCqYTsjsrsyhdLGKWtvHjUFF(Thread thread_0)
	{
		//Discarded unreachable code: IL_000c, IL_0013, IL_0021, IL_0028
		/*Error: ldloc 1 (out-of-bounds)*/;
		_ = 1.6670783E-06f;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern MemoryStream kutRiGgeqrhaEXGLLEyWOpgeuhjP();

	static extern BinaryFormatter PccGABFAKkzNFOEIhRPTrzWAlDkWA();

	static extern void DyrODxGfbhbDLiBfLARlZrQOEIpfb(BinaryFormatter binaryFormatter_0, Stream stream_0, object object_2);

	static extern void pOjvhJUuNBTNpUCdgHDpBeJNUjxEA(Stream stream_0, long long_0);

	static extern PermissionSet SjeTVcHbRwmBvOYSwJYNmyhxcFqy(PermissionState permissionState_0);

	void LwRqeaAitQEnJATztbvrLVtLEsjdb()
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0017, IL_001d
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I, but got Unknown
		//IL_0017: Unsupported input type for neg.
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Thread weuIRxjAVOUtakXjQinbTnHhZjRKA();

	static extern bool iMvrdgNFTtDkfVYdxHeRjspuHnLQ(Thread thread_0, ApartmentState apartmentState_0);

	static extern AppDomain wUkxqQNpRDHBRMoHauLqFijHsVCi();

	static extern int CmSPnADhTRpXEEpGSkDHJdPePchQ(AppDomain appDomain_0, string string_0, Evidence evidence_0, string[] string_1, byte[] byte_0, AssemblyHashAlgorithm assemblyHashAlgorithm_0);

	static extern Assembly kKhNCHNmJConezFgTNgIOZXxjbJf(string string_0, Evidence evidence_0, byte[] byte_0, AssemblyHashAlgorithm assemblyHashAlgorithm_0);

	static extern MethodInfo SvFvZXRXuUAoKYDtqtAiYldIZPew(Assembly assembly_0);

	static extern Type EGvbqGwHVMdCNhdjxBymSerrBVNlA(RuntimeTypeHandle runtimeTypeHandle_0);

	static object[] TXGgkDntiAbEuUoBFNRFgBuEbBIQ(MemberInfo memberInfo_0, Type type_0, bool bool_0)
	{
		//Discarded unreachable code: IL_0013, IL_0023, IL_0029
		//IL_0018: Expected F4, but got I4
		//IL_0024: Invalid comparison between Unknown and I4
		short num = checked((short)/*Error near IL_0001: Stack underflow*/);
		_ = ((short[])((sbyte[])/*Error near IL_0003: Stack underflow*/)[num])[3L];
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern StringBuilder AyfwPGwTzIFiqlRbmhrCmbIzfMeBA();

	static extern StringBuilder OPfqaAxQghSZPOKBUTomYdIICIXs(StringBuilder stringBuilder_0, char char_0);

	static string irteDGWDfUFGHgYZmelftRoMEIxA(object object_2)
	{
		//Discarded unreachable code: IL_0009
		while (true)
		{
		}
	}

	static void EvJonAELphUvltqqFygkWJknBoac(Array array_1, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		checked
		{
			_ = (nint)/*Error near IL_0002: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}
}
