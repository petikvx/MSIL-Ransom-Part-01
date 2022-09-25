using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns6;
using ns7;
using ns8;

namespace ns5;

internal class Class43
{
	private class Class45
	{
		private readonly Class43 class43_0;

		private readonly byte[] byte_0;

		private readonly Class54 class54_0;

		private readonly Class47 class47_0;

		public bool bool_0 = true;

		public Class45(Class43 class43_1, byte[] byte_1, Class54 class54_1, Class47 class47_1)
		{
			class43_0 = class43_1;
			class47_0 = class47_1;
			class54_0 = class54_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class43_0.method_5(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{AF295A79-00B2-4D3D-BD32-EE9D992F67E8}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class46 @class = new Class46(class43_0);
				class54_0.method_2(destinationArray, class47_0.method_2(), class47_0.method_1(), class47_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class43_0.delegate3_0 != null)
				{
					class43_0.delegate3_0(this, new EventArgs4(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class46
	{
		private readonly Class43 class43_0;

		public bool bool_0;

		public Class46(Class43 class43_1)
		{
			class43_0 = class43_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class43_0.method_4(Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class43_0.method_3(Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class47
	{
		public static Class47 class47_0 = new Class47(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class47(string string_3, string string_4, string string_5)
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

	internal bool method_1(byte[] byte_0, Class47 class47_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class27.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum1.const_0, Class27.string_0);
			return false;
		}
		byte[] array = Class42.smethod_0(byte_, "<RSAKeyValue><Modulus>wa7O88OVJ67c19ApJG6yDkTUrYtUcdDrsJxad45dic1h0P/ULd9T+5aM6ZLj3ZsRmlpptZID5t9LWeiVINl4C8osesX+tkaYto/dEg88DaT9T+bl0vKMTdddhfBmacO0u/N0wbcTe5iKmwvc0rCMWWM3wace+aW95uEAAnf5+Zs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_4(Enum1.const_0, Class42.string_0);
			return false;
		}
		method_5(Enum1.const_1);
		Class54 @class = new Class54("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class45 class2 = new Class45(this, array, @class, class47_0);
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
