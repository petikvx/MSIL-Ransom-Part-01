using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GClass12
{
	public class GClass13
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class5
		{
			public static readonly Class5 class5_0;

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public extern Class5();

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

		protected unsafe bool method_0(byte[] byte_0)
		{
			//Discarded unreachable code: IL_000f
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			uint num;
			checked
			{
				num = (uint)(*unchecked((ulong*)(long)(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/)));
			}
			_003F val = /*Error near IL_0009: Stack underflow*/>> (int)num;
			_ = ((long[])/*Error near IL_000a: Stack underflow*/)[val];
			/*Error near IL_000a: Invalid metadata token*/;
		}

		protected extern void method_1();

		protected extern void method_2(string string_2, string string_3);

		private extern void method_3(string string_2, bool bool_0);

		public extern GClass13();

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass14 : GClass13
	{
		[CompilerGenerated]
		private string string_2;
	}

	public class GClass15 : GClass13
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

	public extern GClass12(long long_1);

	public GClass12(byte[] byte_2)
	{
		//IL_0004: Expected I, but got I8
		while (true)
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			ulong num = (ulong)/*Error near IL_0003: Stack underflow*/;
			((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (nint)num;
			if (/*Error near IL_000a: Stack underflow*/ > /*Error near IL_000a: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_000a*/;
			}
		}
	}
}
