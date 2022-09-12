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

		public unsafe string String_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set
			{
				//Discarded unreachable code: IL_0015, IL_001b, IL_0024, IL_002d
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Invalid comparison between Unknown and I4
				while ((int)/*Error near IL_0005: Stack underflow*/ != 0 || /*Error near IL_000b: Stack underflow*/!= /*Error near IL_000b: Stack underflow*/)
				{
				}
				uint num = (uint)((sbyte[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/];
				long num2 = *(long*)(nint)/*Error near IL_000d: ldloc 2 (out-of-bounds)*/;
				((long[])/*Error near IL_0010: Stack underflow*/)[num] = num2;
				/*Error near IL_0010: Invalid metadata token*/;
			}
		}

		public extern string String_1
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			private set;
		}

		protected extern bool method_0(byte[] byte_0);

		protected extern void method_1();

		protected extern void method_2(string string_2, string string_3);

		private extern void method_3(string string_2, bool bool_0);

		public GClass13()
		{
			//Discarded unreachable code: IL_0011
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			_003F val;
			do
			{
				byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
				val = /*Error near IL_0002: Stack underflow*/^ num;
			}
			while ((int)/*Error near IL_0008: Stack underflow*/ != (ushort)val);
			((double[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (double)/*Error near IL_0009: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_000c: Invalid metadata token*/;
		}

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

	public unsafe GClass12(byte[] byte_2)
	{
		//Discarded unreachable code: IL_002a, IL_0033, IL_0039
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and F4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I
		while (true)
		{
			float num = *(float*)(nint)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
			if ((float)/*Error near IL_0008: Stack underflow*/ < num)
			{
				continue;
			}
			uint num3;
			checked
			{
				byte num2 = (byte)(*unchecked((float*)(nint)/*Error near IL_0009: Stack underflow*/));
				_003F val = unchecked(/*Error near IL_000b: Stack underflow*/ * num2);
				if (/*Error near IL_0010: Stack underflow*/ == val)
				{
					continue;
				}
				num3 = (uint)/*Error near IL_0011: Stack underflow*/;
			}
			_003F val2 = /*Error near IL_0012: Stack underflow*/+ num3;
			if (/*Error near IL_0017: Stack underflow*/ >= val2 && /*Error near IL_001c: Stack underflow*/== /*Error near IL_001c: Stack underflow*/)
			{
				_003F val3 = /*Error near IL_001f: Stack underflow*/- this;
				if (/*Error near IL_0024: Stack underflow*/ > val3)
				{
					break;
				}
			}
		}
		/*Error near IL_0025: Invalid metadata token*/;
	}
}
