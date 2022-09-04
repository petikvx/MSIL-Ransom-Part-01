using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns4;
using ns6;

namespace ns7;

internal class Class16
{
	private class Class18
	{
		private readonly Class16 class16_0;

		private readonly byte[] byte_0;

		private readonly Class21 class21_0;

		private readonly Class20 class20_0;

		public bool bool_0 = true;

		public Class18(Class16 class16_1, byte[] byte_1, Class21 class21_1, Class20 class20_1)
		{
			class16_0 = class16_1;
			class20_0 = class20_1;
			class21_0 = class21_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class16_0.method_4(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{E57A3F59-F478-4463-A996-10AB20CDFCF0}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class19 @class = new Class19(class16_0);
				class21_0.method_2(destinationArray, class20_0.method_2(), class20_0.method_1(), class20_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class16_0.delegate0_0 != null)
				{
					class16_0.delegate0_0(this, new EventArgs0(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class19
	{
		private readonly Class16 class16_0;

		public bool bool_0;

		public Class19(Class16 class16_1)
		{
			class16_0 = class16_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class16_0.method_3(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class16_0.method_2(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class20
	{
		public static Class20 class20_0 = new Class20(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class20(string string_3, string string_4, string string_5)
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

	internal bool method_0(byte[] byte_0, Class20 class20_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class8.smethod_0(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum0.const_0, Class8.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class15.smethod_0(byte_, "<RSAKeyValue><Modulus>ohK26Y61S5Mc8RTXrp3MzOkpGNCT5a/0OBYgX4uSKX0zraWWakUeyW+zL23/krF6cRQfT2n3WRJqGzvAM4hY+ZE9W415TOPFIZV2u6vy4XFrz4bMhA05cXpZYuy7wvD6XZ6iBK9fP4TNVF+GtytdktkLkU2IzZUJITACvhbox4c=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum0.const_0, Class15.string_0);
			return false;
		}
		method_4(Enum0.const_1);
		Class21 @class = new Class21("!adf533de-cba0-b8e4-f040-9880b75e3911");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class18 class2 = new Class18(this, array, @class, class20_0);
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
