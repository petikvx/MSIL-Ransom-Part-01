using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GClass9
{
	public class GClass10
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class1
		{
			public static readonly Class1 class1_0;

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		private string string_0;

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

		protected bool method_0(byte[] byte_0)
		{
			while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
			}
			return (byte)(int)/*OpCode not supported: Nop*/ != 0;
		}

		protected unsafe void method_1()
		{
			//Discarded unreachable code: IL_001b, IL_0023
			//IL_0003: Expected F4, but got I
			//IL_000f: Expected O, but got I4
			//IL_0011: Invalid comparison between Unknown and O
			while (true)
			{
				double num = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				IntPtr intPtr = ((IntPtr[])/*Error near IL_0002: Stack underflow*/)[num];
				*(float*)(nint)/*Error near IL_0003: Stack underflow*/ = (nint)intPtr;
				_ = (short)/*Error near IL_0004: Stack underflow*/;
				/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
				if (/*Error near IL_000c: Stack underflow*/ <= /*Error near IL_000c: Stack underflow*/)
				{
					this = (GClass10)checked((byte)/*Error near IL_000d: Stack underflow*/);
					if (/*Error near IL_0016: Stack underflow*/ <= this)
					{
						break;
					}
				}
			}
			/*Error near IL_0016: Invalid metadata token*/;
		}

		protected extern void method_2(string string_2, string string_3);

		private extern void method_3(string string_2, bool bool_0);

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass11 : GClass10
	{
		private string string_2;
	}

	public class GClass12 : GClass10
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

	public extern GClass9(long long_1);

	public GClass9(byte[] byte_2)
	{
		((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
	}
}
