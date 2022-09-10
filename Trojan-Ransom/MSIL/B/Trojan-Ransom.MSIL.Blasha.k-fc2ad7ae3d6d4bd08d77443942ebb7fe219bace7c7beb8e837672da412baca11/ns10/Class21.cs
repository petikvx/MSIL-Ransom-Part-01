using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns9;

namespace ns10;

internal class Class21
{
	private class Class23
	{
		private readonly Class21 class21_0;

		private readonly byte[] byte_0;

		private readonly Class32 class32_0;

		private readonly Class25 class25_0;

		public bool bool_0 = true;

		public Class23(Class21 class21_1, byte[] byte_1, Class32 class32_1, Class25 class25_1)
		{
			class21_0 = class21_1;
			class25_0 = class25_1;
			class32_0 = class32_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class21_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{AD0283FE-A9AC-4E1B-A185-D1AD2EF9B5AE}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class24 @class = new Class24(class21_0);
				class32_0.method_2(destinationArray, class25_0.method_2(), class25_0.method_1(), class25_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class21_0.delegate1_0 != null)
				{
					class21_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class24
	{
		private readonly Class21 class21_0;

		public bool bool_0;

		public Class24(Class21 class21_1)
		{
			class21_0 = class21_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class21_0.method_4(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class21_0.method_3(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class25
	{
		public static Class25 class25_0 = new Class25(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class25(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}

		[SpecialName]
		public string method_0()
		{
			return string_2;
		}

		[SpecialName]
		public string method_1()
		{
			return string_1;
		}

		[SpecialName]
		public string method_2()
		{
			return string_0;
		}
	}

	private IWebProxy iwebProxy_0;

	private Delegate1 delegate1_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class25 class25_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class8.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class8.string_0);
			return false;
		}
		byte[] array = Class20.smethod_0(byte_, "<RSAKeyValue><Modulus>7IFGM6lkpFmE/8lXrULOl+qu+Hp4+NDTFtZ5zsSeaUD9orfm6zsO4/biVBSoUlk4FNz/LjlVQ65VPgoUbSktgmp5hArX0WNTMFdTeh4rjACoXy8E38g19hPuuzaXOwtpQi396czJAoyXQfSWwtG3Zz2FF4IkK8VVO6M655HbTvs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum0.const_0, Class20.string_0);
			return false;
		}
		method_5(Enum0.const_1);
		Class32 @class = new Class32("e33c5ec1-5af5-f087-56f1-a5e5e2bcf871");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class23 class2 = new Class23(this, array, @class, class25_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_3(Enum0 enum0_0, string string_0, string string_1)
	{
		delegate1_0?.Invoke(this, new EventArgs3(enum0_0, string_0, string_1));
	}

	protected void method_4(Enum0 enum0_0, string string_0)
	{
		method_3(enum0_0, string_0, string.Empty);
	}

	protected void method_5(Enum0 enum0_0)
	{
		method_4(enum0_0, string.Empty);
	}
}
