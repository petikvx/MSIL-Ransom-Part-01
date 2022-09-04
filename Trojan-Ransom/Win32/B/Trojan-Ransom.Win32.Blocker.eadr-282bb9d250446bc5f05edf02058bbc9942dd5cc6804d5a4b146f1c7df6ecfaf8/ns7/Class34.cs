using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns5;

namespace ns7;

internal class Class34
{
	private class Class36
	{
		private readonly Class34 class34_0;

		private readonly byte[] byte_0;

		private readonly Class39 class39_0;

		private readonly Class38 class38_0;

		public bool bool_0 = true;

		public Class36(Class34 class34_1, byte[] byte_1, Class39 class39_1, Class38 class38_1)
		{
			class34_0 = class34_1;
			class38_0 = class38_1;
			class39_0 = class39_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class34_0.method_4(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{D277C1CB-A72B-49B5-AE9B-AB7823D8FAFD}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class37 @class = new Class37(class34_0);
				class39_0.method_2(destinationArray, class38_0.method_2(), class38_0.method_1(), class38_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class34_0.delegate3_0 != null)
				{
					class34_0.delegate3_0(this, new EventArgs4(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class37
	{
		private readonly Class34 class34_0;

		public bool bool_0;

		public Class37(Class34 class34_1)
		{
			class34_0 = class34_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class34_0.method_3(Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class34_0.method_2(Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class38
	{
		public static Class38 class38_0 = new Class38(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class38(string string_3, string string_4, string string_5)
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

	private Delegate3 delegate3_0;

	internal bool method_0(byte[] byte_0, Class38 class38_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class7.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum1.const_0, Class7.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class33.smethod_0(byte_, "<RSAKeyValue><Modulus>wH7WDTRVKGH5PCnbMCEgc/yfDGJN+/qY4sr6AHT0Sq1MaU2Vv4UmRCgyZgYL+kHbm87VLCpg9XzWmp/EBOadgGHRbynp4SE0euS7fDutIvSmyc/07GbUcO2aQrkAfKSyPd2za8jkLB4AWLSNSgTf+ONbU/XwJJ2PputJzWYM8Fs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum1.const_0, Class33.string_0);
			return false;
		}
		method_4(Enum1.const_1);
		Class39 @class = new Class39("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class36 class2 = new Class36(this, array, @class, class38_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
		IL_001b:
		return result;
	}

	[SpecialName]
	public void method_1(Delegate3 delegate3_1)
	{
		Delegate3 @delegate = delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_1);
			@delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_2(Enum1 enum1_0, string string_0, string string_1)
	{
		delegate3_0?.Invoke(this, new EventArgs4(enum1_0, string_0, string_1));
	}

	protected void method_3(Enum1 enum1_0, string string_0)
	{
		method_2(enum1_0, string_0, string.Empty);
	}

	protected void method_4(Enum1 enum1_0)
	{
		method_3(enum1_0, string.Empty);
	}
}
