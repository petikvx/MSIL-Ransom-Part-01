using System;
using System.Net;
using System.Text;
using System.Threading;

public class GClass6
{
	private class Class19
	{
		private readonly GClass6 gclass6_0;

		private readonly byte[] byte_0;

		private readonly Class24 class24_0;

		private readonly Class21 class21_0;

		public bool bool_0 = true;

		public Class19(GClass6 gclass6_1, byte[] byte_1, Class24 class24_1, Class21 class21_1)
		{
			gclass6_0 = gclass6_1;
			class21_0 = class21_1;
			class24_0 = class24_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == GClass4.smethod_0(960))
			{
				gclass6_0.method_4(GEnum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(GClass4.smethod_0(965));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class20 @class = new Class20(gclass6_0);
				class24_0.method_2(destinationArray, class21_0.method_2(), class21_0.method_1(), class21_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (gclass6_0.gdelegate0_0 != null)
				{
					gclass6_0.gdelegate0_0(this, new GEventArgs0(GEnum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class20
	{
		private readonly GClass6 gclass6_0;

		public bool bool_0;

		public Class20(GClass6 gclass6_1)
		{
			gclass6_0 = gclass6_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(GClass4.smethod_0(1018)))
			{
				gclass6_0.method_3(GEnum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				gclass6_0.method_2(GEnum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class21
	{
		public static Class21 class21_0 = new Class21(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class21(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}

		public string method_0()
		{
			return string_2;
		}

		public string method_1()
		{
			return string_1;
		}

		public string method_2()
		{
			return string_0;
		}
	}

	protected const string string_0 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private IWebProxy iwebProxy_0;

	private GDelegate0 gdelegate0_0;

	public event GDelegate0 SendingReportFeedback
	{
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class21 class21_0)
	{
		byte[] byte_;
		try
		{
			byte_ = GClass5.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_3(GEnum1.const_0, GClass5.string_0);
			return false;
		}
		byte[] array = Class18.smethod_0(byte_, GClass4.smethod_0(585));
		if (array == null)
		{
			method_3(GEnum1.const_0, Class18.string_0);
			return false;
		}
		method_4(GEnum1.const_1);
		Class24 @class = new Class24(GClass4.smethod_0(911));
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
		gdelegate0_0?.Invoke(this, new GEventArgs0(genum1_0, string_1, string_2));
	}

	protected void method_3(GEnum1 genum1_0, string string_1)
	{
		method_2(genum1_0, string_1, string.Empty);
	}

	protected void method_4(GEnum1 genum1_0)
	{
		method_3(genum1_0, string.Empty);
	}
}
