using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns1;
using ns2;
using ns4;

namespace ns3;

internal class Class11
{
	private sealed class Class13
	{
		private readonly Class11 class11_0;

		private readonly byte[] byte_0;

		private readonly Class16 class16_0;

		private readonly Class15 class15_0;

		public bool bool_0 = true;

		public Class13(Class11 class11_1, byte[] byte_1, Class16 class16_1, Class15 class15_1)
		{
			class11_0 = class11_1;
			class15_0 = class15_1;
			class16_0 = class16_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class11_0.method_4(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{027F678B-7D46-4866-9354-BA5F76CF2B30}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class14 @class = new Class14(class11_0);
				class16_0.method_2(destinationArray, class15_0.method_2(), class15_0.method_1(), class15_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class11_0.delegate0_0 != null)
				{
					class11_0.delegate0_0(this, new EventArgs0(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class14
	{
		private readonly Class11 class11_0;

		public bool bool_0;

		public Class14(Class11 class11_1)
		{
			class11_0 = class11_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class11_0.method_3(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class11_0.method_2(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class15
	{
		public static Class15 class15_0 = new Class15(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class15(string string_3, string string_4, string string_5)
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

	private Delegate0 delegate0_0;

	internal bool method_0(byte[] byte_0, Class15 class15_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class3.smethod_0(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum0.const_0, Class3.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class10.smethod_0(byte_, "<RSAKeyValue><Modulus>1utbqtnTdY+lHJLb1g1ilF595fM1A7KWvoSgUM+SF53WrN80hAR5XZKOjAHRbGc5ILUnFvfq4CVZy0LcGGiYzdfV3ELzrReG242mgjFIrhES6LW41Ef4qStAGa8UUOaLArxqHbWRuSKbzbRehbITJQsS7dMY80JfqSHFTSjTgr0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum0.const_0, Class10.string_0);
			return false;
		}
		method_4(Enum0.const_1);
		Class16 @class = new Class16("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class13 class2 = new Class13(this, array, @class, class15_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
		IL_001b:
		return result;
	}

	[SpecialName]
	public void method_1(Delegate0 delegate0_1)
	{
		Delegate0 @delegate = delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
			@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_2(Enum0 enum0_0, string string_0, string string_1)
	{
		delegate0_0?.Invoke(this, new EventArgs0(enum0_0, string_0, string_1));
	}

	protected void method_3(Enum0 enum0_0, string string_0)
	{
		method_2(enum0_0, string_0, string.Empty);
	}

	protected void method_4(Enum0 enum0_0)
	{
		method_3(enum0_0, string.Empty);
	}
}
