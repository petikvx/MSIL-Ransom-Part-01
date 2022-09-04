using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns1;
using ns4;
using ns5;
using ns7;

namespace ns3;

internal class Class20
{
	private sealed class Class22
	{
		private readonly Class20 class20_0;

		private readonly byte[] byte_0;

		private readonly Class29 class29_0;

		private readonly Class24 class24_0;

		public bool bool_0 = true;

		public Class22(Class20 class20_1, byte[] byte_1, Class29 class29_1, Class24 class24_1)
		{
			class20_0 = class20_1;
			class24_0 = class24_1;
			class29_0 = class29_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class20_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{728FC7D8-C82A-41DF-BE75-06C0E1BDEBC5}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class23 @class = new Class23(class20_0);
				class29_0.method_2(destinationArray, class24_0.method_2(), class24_0.method_1(), class24_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class20_0.delegate1_0 != null)
				{
					class20_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class23
	{
		private readonly Class20 class20_0;

		public bool bool_0;

		public Class23(Class20 class20_1)
		{
			class20_0 = class20_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class20_0.method_4(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class20_0.method_3(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class24
	{
		public static Class24 class24_0 = new Class24(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class24(string string_3, string string_4, string string_5)
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

	internal bool method_1(byte[] byte_0, Class24 class24_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class7.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class7.string_0);
			return false;
		}
		byte[] array = Class19.smethod_0(byte_, "<RSAKeyValue><Modulus>pnkhpb1JSBpVqW4/NvrLnmGy/zzesg7cSjCHtV7EffsMNeCGLNlGiTA+vdhqELhaXUnLR/SGbHDDy9++gl0RodLmiwu0633963t9M3/uSLiOZ7bGj4jmA45Ul3s6nVrB7EpIaQBCj4kEUnKuVlsEjj5f5nzPU6funB2T9OaxCKk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum0.const_0, Class19.string_0);
			return false;
		}
		method_5(Enum0.const_1);
		Class29 @class = new Class29("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class22 class2 = new Class22(this, array, @class, class24_0);
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
