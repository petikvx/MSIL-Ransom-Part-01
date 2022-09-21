using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GClass16
{
	public class GClass17
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class8
		{
			public static readonly Class8 class8_0;

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public extern Class8();

			internal extern bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0);
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public extern string String_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set;
		}

		public extern string String_1
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set;
		}

		protected extern bool method_0(byte[] byte_0);

		protected void method_1()
		{
			throw /*Error near IL_0002: Stack underflow*/;
		}

		protected unsafe void method_2(string string_2, string string_3)
		{
			do
			{
				/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
				*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
			}
			while (/*Error near IL_0009: Stack underflow*/ != /*Error near IL_0009: Stack underflow*/);
			throw /*Error near IL_000b: Stack underflow*/;
		}

		private extern void method_3(string string_2, bool bool_0);

		public extern GClass17();

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass18 : GClass17
	{
		[CompilerGenerated]
		private string string_2;
	}

	public class GClass19 : GClass17
	{
	}

	private readonly byte[] byte_0;

	private byte[] byte_1;

	private readonly object object_0;

	private GEnum0 genum0_0;

	private long long_0;

	private readonly int int_0;

	private int int_1;

	private uint uint_0;

	public extern GClass16(long long_1);

	public extern GClass16(byte[] byte_2);
}
