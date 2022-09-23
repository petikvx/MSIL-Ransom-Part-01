using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GClass22
{
	public class GClass23
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class10
		{
			public static readonly Class10 class10_0;

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public extern Class10();

			internal extern bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0);
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public unsafe string String_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set
			{
				//Discarded unreachable code: IL_0006, IL_000e, IL_0019
				//IL_0009: Expected I8, but got I
				_ = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}

		public extern string String_1
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set;
		}

		protected bool method_0(byte[] byte_0)
		{
			//Discarded unreachable code: IL_0004, IL_000c, IL_0016
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected I4, but got Unknown
			//IL_0004: Unsupported input type for neg.
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected I8, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			/*Error: stloc 0 (out-of-bounds)*/;
			_003F val = checked(/*Error near IL_0002: Stack underflow*/ - /*Error near IL_0002: Stack underflow*/);
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (sbyte)(int)val;
			/*Error near IL_0003: Unknown opcode: 0xF8*/;
		}

		protected extern void method_1();

		protected extern void method_2(string string_2, string string_3);

		private extern void method_3(string string_2, bool bool_0);

		public extern GClass23();

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass24 : GClass23
	{
		[CompilerGenerated]
		private string string_2;
	}

	public class GClass25 : GClass23
	{
	}

	private readonly byte[] byte_0;

	private byte[] byte_1;

	private readonly object object_0;

	private GEnum1 genum1_0;

	private long long_0;

	private readonly int int_0;

	private int int_1;

	private uint uint_0;

	public extern GClass22(long long_1);

	public extern GClass22(byte[] byte_2);
}
