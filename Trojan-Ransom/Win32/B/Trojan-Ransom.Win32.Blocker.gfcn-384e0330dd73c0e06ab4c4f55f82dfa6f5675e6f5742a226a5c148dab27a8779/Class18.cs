using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

internal class Class18
{
	private class Class20
	{
		private readonly Class18 class18_0;

		private readonly object object_0;

		private readonly Class31 class31_0;

		private readonly Class22 class22_0;

		public bool bool_0;

		public Class20(Class18 class18_1, byte[] byte_0, Class31 class31_1, Class22 class22_1)
		{
			Class52.KPUgGmhz2nAeI();
			bool_0 = true;
			base._002Ector();
			class18_0 = class18_1;
			class22_0 = class22_1;
			class31_0 = class31_1;
			object_0 = byte_0;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class18_0.method_5((Enum0)3);
				byte[] bytes = Encoding.UTF8.GetBytes("{139706E3-BB37-4325-9217-F497D07A7A69}");
				byte[] array = new byte[bytes.Length + ((Array)object_0).Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy((Array)object_0, 0, array, bytes.Length, ((Array)object_0).Length);
				Class21 @class = new Class21(class18_0);
				class31_0.method_2(array, class22_0.method_2(), class22_0.method_1(), class22_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class18_0.amoOcUuUjT != null)
				{
					class18_0.amoOcUuUjT(this, new EventArgs3((Enum0)2, string_0));
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
			Class52.KPUgGmhz2nAeI();
			base._002Ector();
			class18_0 = class18_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class18_0.method_4((Enum0)3, string_0);
				bool_0 = false;
			}
			else
			{
				class18_0.method_3((Enum0)4, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class22
	{
		public static Class22 class22_0;

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class22(string string_3, string string_4, string string_5)
		{
			Class52.KPUgGmhz2nAeI();
			base._002Ector();
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

		static Class22()
		{
			Class52.KPUgGmhz2nAeI();
			class22_0 = new Class22(null, null, null);
		}
	}

	private IWebProxy iwebProxy_0;

	private Delegate1 amoOcUuUjT;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class22 class22_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class7.smethod_0(byte_0);
		}
		catch (Exception)
		{
			method_4((Enum0)1, Class7.string_0);
			return false;
		}
		byte[] array = Class17.smethod_0(byte_, "<RSAKeyValue><Modulus>yeSQNhwaUyOHszNlgY3OxTDVVT2G6EKoXtc+ZFy32Y0JPhWR+d5/vAsgYMfUzTa2nbTIMis45tsYCA4dvVcPEbk1YqOn13psUgE6R6FDvAokska+sQCLWQpvAbIBNdFkZ/YlXJXsEhHs46BbjTccXXEyUchnDMkKidLs/BWrG9E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4((Enum0)1, Class17.string_0);
			return false;
		}
		method_5((Enum0)2);
		Class31 @class = new Class31("!653e0e72-04fb-0ac1-fb7f-330ac338a602");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class20 class2 = new Class20(this, array, @class, class22_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate1 delegate1_0)
	{
		Delegate1 @delegate = amoOcUuUjT;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref amoOcUuUjT, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_3(Enum0 enum0_0, string string_0, string string_1)
	{
		amoOcUuUjT?.Invoke(this, new EventArgs3(enum0_0, string_0, string_1));
	}

	protected void method_4(Enum0 enum0_0, string string_0)
	{
		method_3(enum0_0, string_0, string.Empty);
	}

	protected void method_5(Enum0 enum0_0)
	{
		method_4(enum0_0, string.Empty);
	}

	public Class18()
	{
		Class52.KPUgGmhz2nAeI();
		base._002Ector();
	}
}
