using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns0;
using ns2;
using ns3;
using ns4;

namespace ns1;

internal class Class18
{
	private class Class20
	{
		private readonly Class18 class18_0;

		private readonly byte[] byte_0;

		private readonly Class29 class29_0;

		private readonly Class22 class22_0;

		public bool bool_0 = true;

		public Class20(Class18 class18_1, byte[] byte_1, Class29 class29_1, Class22 class22_1)
		{
			class18_0 = class18_1;
			class22_0 = class22_1;
			class29_0 = class29_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class18_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{E64808BD-F34D-427F-9390-8A8D22926312}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class21 @class = new Class21(class18_0);
				class29_0.method_2(destinationArray, class22_0.method_2(), class22_0.method_1(), class22_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class18_0.delegate1_0 != null)
				{
					class18_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class21
	{
		private readonly Class18 class18_0;

		public bool bool_0;

		public Class21(Class18 class18_1)
		{
			class18_0 = class18_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class18_0.method_4(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class18_0.method_3(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class22
	{
		public static Class22 class22_0 = new Class22(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class22(string string_3, string string_4, string string_5)
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

	internal bool method_1(byte[] byte_0, Class22 class22_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class2.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class2.string_0);
			return false;
		}
		byte[] array = Class17.smethod_0(byte_, "<RSAKeyValue><Modulus>ys7fnuRK3xuJrwTCnCiHO/lco0qsCtFOHxO7O+tKD8apfU5VTPXWAnWQVBpgagzvMYzLxP+xpPo5A5gCsyv2FOdimcl/f80qxRCbp1Q1uHS/3ts23y1aefngpsRovEJrRHu6+wGr/coQkKwTBdbDMtjROYjSsbvt9rOLLmXZNnc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum0.const_0, Class17.string_0);
			return false;
		}
		method_5(Enum0.const_1);
		Class29 @class = new Class29("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class20 class2 = new Class20(this, array, @class, class22_0);
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
