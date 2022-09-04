using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns3;
using ns4;
using ns8;

namespace ns9;

internal class Class28
{
	private class Class30
	{
		private readonly Class28 class28_0;

		private readonly byte[] byte_0;

		private readonly Class39 class39_0;

		private readonly Class32 class32_0;

		public bool bool_0 = true;

		public Class30(Class28 class28_1, byte[] byte_1, Class39 class39_1, Class32 class32_1)
		{
			class28_0 = class28_1;
			class32_0 = class32_1;
			class39_0 = class39_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class28_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{7A5EA081-A00F-4176-B3C6-1041FBCB5A61}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class31 @class = new Class31(class28_0);
				class39_0.method_2(destinationArray, class32_0.method_2(), class32_0.method_1(), class32_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class28_0.delegate2_0 != null)
				{
					class28_0.delegate2_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class31
	{
		private readonly Class28 class28_0;

		public bool bool_0;

		public Class31(Class28 class28_1)
		{
			class28_0 = class28_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class28_0.method_4(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class28_0.method_3(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class32
	{
		public static Class32 class32_0 = new Class32(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class32(string string_3, string string_4, string string_5)
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

	private Delegate2 delegate2_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class32 class32_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class15.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class15.string_0);
			return false;
		}
		byte[] array = Class27.smethod_0(byte_, "<RSAKeyValue><Modulus>2KSj8Sx4qVigpRMBR44blmX9MjzDPIuTdoRn8QsZ++dag7A+k7A+8BGDkuZmCDaVxwIMe5SjI7/+eascLtHJqsXoiAZDzhAiitfO9bnizCQQfBbdfR0cUJClKpP8bDCCpYvLUeilhj3yNeCdVzAyoQOe5msw3OBij9boQsdK5BM=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum0.const_0, Class27.string_0);
			return false;
		}
		method_5(Enum0.const_1);
		Class39 @class = new Class39("!97eef185-c809-fc97-6033-37d53397c9d8");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class30 class2 = new Class30(this, array, @class, class32_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate2 delegate2_1)
	{
		Delegate2 @delegate = delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_1);
			@delegate = Interlocked.CompareExchange(ref delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_3(Enum0 enum0_0, string string_0, string string_1)
	{
		delegate2_0?.Invoke(this, new EventArgs3(enum0_0, string_0, string_1));
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
