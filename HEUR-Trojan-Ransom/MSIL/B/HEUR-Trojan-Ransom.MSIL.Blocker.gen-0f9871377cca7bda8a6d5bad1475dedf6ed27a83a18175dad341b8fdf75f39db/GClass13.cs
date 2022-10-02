using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GClass13
{
	public class GClass14
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class7
		{
			public static readonly Class7 class7_0;

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public extern Class7();

			internal extern bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0);
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public string String_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set
			{
				//Discarded unreachable code: IL_0023, IL_002a
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				while ((nuint)checked((nint)/*Error near IL_0001: Stack underflow*/) < (nuint)unchecked((nint)""))
				{
				}
				sbyte num = checked((sbyte)(uint)/*Error near IL_000e: Stack underflow*/);
				_003F val = /*Error near IL_0010: Stack underflow*/>> (int)num;
				float num2 = (float)val;
				do
				{
					num2 = ((float[])/*Error near IL_0011: Stack underflow*/)[val];
				}
				while (0 == 0);
				_ = 6;
				/*Error near IL_001e: Invalid metadata token*/;
			}
		}

		public unsafe string String_1
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set
			{
				//Discarded unreachable code: IL_0012, IL_0019
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				do
				{
					*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
					checked
					{
						_ = (short)/*Error near IL_0003: Stack underflow*/;
					}
				}
				while (this == null);
				_ = 6;
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}

		protected extern bool method_0(byte[] byte_0);

		protected extern void method_1();

		protected void method_2(string string_2, string string_3)
		{
			//Discarded unreachable code: IL_0009
			checked
			{
				_ = (long)/*Error near IL_0001: Stack underflow*/;
			}
			_ = (short)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}

		private extern void method_3(string string_2, bool bool_0);

		public extern GClass14();

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass15 : GClass14
	{
		[CompilerGenerated]
		private string string_2;
	}

	public class GClass16 : GClass14
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

	public extern GClass13(long long_1);

	public extern GClass13(byte[] byte_2);
}
