using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns5;
using ns7;
using ns8;

namespace ns6;

internal class Class44
{
	private sealed class Class46
	{
		private readonly Class44 class44_0;

		private readonly byte[] byte_0;

		private readonly Class55 class55_0;

		private readonly Class48 class48_0;

		public bool bool_0 = true;

		public Class46(Class44 class44_1, byte[] byte_1, Class55 class55_1, Class48 class48_1)
		{
			class44_0 = class44_1;
			class48_0 = class48_1;
			class55_0 = class55_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class44_0.method_5(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{0D11B329-2752-44F3-ACE5-4122455C2392}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class47 @class = new Class47(class44_0);
				class55_0.method_2(destinationArray, class48_0.method_2(), class48_0.method_1(), class48_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class44_0.delegate3_0 != null)
				{
					class44_0.delegate3_0(this, new EventArgs4(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class47
	{
		private readonly Class44 class44_0;

		public bool bool_0;

		public Class47(Class44 class44_1)
		{
			class44_0 = class44_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class44_0.method_4(Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class44_0.method_3(Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class48
	{
		public static Class48 class48_0 = new Class48(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class48(string string_3, string string_4, string string_5)
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

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class48 class48_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class28.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum1.const_0, Class28.string_0);
			return false;
		}
		byte[] array = Class43.smethod_0(byte_, "<RSAKeyValue><Modulus>vjAFUbuvRqT+4rawOdIC+fTCmHofz5szYcuvDRMJihyCSbSX0MSubB+51PhrcTfdaOy/Fxa5nyW02memtSvz6xxjENIxi0a1wzelAV6XeiPYmz4SlL0a0gKlw4Kh6a7YBhXU4AYxlIs2qh488sXgG6UBX/EPF/uZnchGa4jw3yk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum1.const_0, Class43.string_0);
			return false;
		}
		method_5(Enum1.const_1);
		Class55 @class = new Class55("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class46 class2 = new Class46(this, array, @class, class48_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate3 delegate3_1)
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

	protected void method_3(Enum1 enum1_0, string string_0, string string_1)
	{
		delegate3_0?.Invoke(this, new EventArgs4(enum1_0, string_0, string_1));
	}

	protected void method_4(Enum1 enum1_0, string string_0)
	{
		method_3(enum1_0, string_0, string.Empty);
	}

	protected void method_5(Enum1 enum1_0)
	{
		method_4(enum1_0, string.Empty);
	}
}
