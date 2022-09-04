using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns1;
using ns3;

namespace ns4;

public class GClass4
{
	private sealed class Class19
	{
		private readonly Class21 class21_0;

		public bool bool_0 = true;

		internal GClass4 gclass4_0;

		internal byte[] byte_0;

		internal Class26 class26_0;

		public Class19(GClass4 gclass4_1, byte[] byte_1, Class26 class26_1, Class21 class21_1)
		{
			GClass4 gClass = (gclass4_0 = gclass4_1);
			class21_0 = class21_1;
			Class26 @class = (class26_0 = class26_1);
			byte[] array = (byte_0 = byte_1);
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				gclass4_0.method_4(GEnum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{6E58F09E-1D19-4C9A-BA17-00BCCC513BF5}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class20 @class = new Class20(gclass4_0);
				class26_0.method_2(destinationArray, class21_0.method_2(), class21_0.method_1(), class21_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (gclass4_0.gdelegate1_0 != null)
				{
					gclass4_0.gdelegate1_0(this, new GEventArgs3(GEnum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		static Class19()
		{
			GClass11.smethod_0();
		}
	}

	private sealed class Class20
	{
		public bool bool_0;

		internal GClass4 gclass4_0;

		public Class20(GClass4 gclass4_1)
		{
			GClass4 gClass = (gclass4_0 = gclass4_1);
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				gclass4_0.method_3(GEnum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				gclass4_0.method_2(GEnum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		static Class20()
		{
			GClass11.smethod_0();
		}
	}

	internal sealed class Class21
	{
		public static Class21 class21_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class21(string string_3, string string_4, string string_5)
		{
			string text = (string_0 = string_3);
			string text2 = (string_2 = string_5);
			string text3 = (string_1 = string_4);
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

		static Class21()
		{
			GClass11.smethod_0();
			class21_0 = new Class21(null, null, null);
		}
	}

	protected const string string_0 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	internal IWebProxy iwebProxy_0;

	internal GDelegate1 gdelegate1_0;

	public event GDelegate1 SendingReportFeedback
	{
		add
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		remove
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public void method_0(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	internal bool method_1(byte[] byte_0, Class21 class21_0)
	{
		byte[] byte_;
		try
		{
			byte_ = GClass3.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_3(GEnum1.const_0, GClass3.string_0);
			return false;
		}
		byte[] array = Class17.smethod_0(byte_, "<RSAKeyValue><Modulus>xDrp4GnCR0V35kcPM9DNy/vnR9ZUsDAFHXlrhtpx+9EXKjxor1uvARQor6S7AAyoKa28a5Tajd2S4aOOKAlylB6Ge8ysCUS289dxFCEuNsgJarD3abwhm5h4kJlHOwd1jZm6ZxQ1wrzdCIcjZNHJ47ijwbh8c6+hw0OaCQa2Hc0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(GEnum1.const_0, Class17.string_0);
			return false;
		}
		method_4(GEnum1.const_1);
		Class26 @class = new Class26("d3a855bf-a70d-bb65-1c60-5854a5278499");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class19 class2 = new Class19(this, array, @class, class21_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void method_2(GEnum1 genum1_0, string string_1, string string_2)
	{
		gdelegate1_0?.Invoke(this, new GEventArgs3(genum1_0, string_1, string_2));
	}

	protected void method_3(GEnum1 genum1_0, string string_1)
	{
		method_2(genum1_0, string_1, string.Empty);
	}

	protected void method_4(GEnum1 genum1_0)
	{
		method_3(genum1_0, string.Empty);
	}

	static GClass4()
	{
		GClass11.smethod_0();
	}
}
