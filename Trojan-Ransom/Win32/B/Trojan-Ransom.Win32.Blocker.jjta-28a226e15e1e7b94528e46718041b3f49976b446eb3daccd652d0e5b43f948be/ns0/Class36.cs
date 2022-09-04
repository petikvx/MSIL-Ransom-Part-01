using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns1;
using ns3;
using ns8;
using ns9;

namespace ns0;

internal class Class36
{
	private sealed class Class38
	{
		private readonly Class36 class36_0;

		private readonly byte[] byte_0;

		private readonly Class41 class41_0;

		private readonly Class40 class40_0;

		public bool bool_0 = true;

		public Class38(Class36 class36_1, byte[] byte_1, Class41 class41_1, Class40 class40_1)
		{
			class36_0 = class36_1;
			class40_0 = class40_1;
			class41_0 = class41_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class36_0.method_4(Enum2.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{D5D8F5B0-12EB-4325-8C3D-C60F341D062A}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class39 @class = new Class39(class36_0);
				class41_0.method_2(destinationArray, class40_0.method_2(), class40_0.method_1(), class40_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class36_0.delegate3_0 != null)
				{
					class36_0.delegate3_0(this, new EventArgs4(Enum2.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class39
	{
		private readonly Class36 class36_0;

		public bool bool_0;

		public Class39(Class36 class36_1)
		{
			class36_0 = class36_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class36_0.method_3(Enum2.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class36_0.method_2(Enum2.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class40
	{
		public static Class40 class40_0 = new Class40(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class40(string string_3, string string_4, string string_5)
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

	internal bool method_0(byte[] byte_0, Class40 class40_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class7.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum2.const_0, Class7.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class35.smethod_0(byte_, "<RSAKeyValue><Modulus>p6N6JV0BnuyACajNdlbRUC2RwdRYwNeajeuXTW2VeRmr3uolPJ/o0vUENggAaQNJMDg2DGorP4XNkjHcd7nHbSdbuBHE5wsa27wYvFiPx79nBTnk1lqKIXace0wPQkaY5iLNTu0NeMI7a076OhoseQVpbuAe7XCq8weXG0anSHU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum2.const_0, Class35.string_0);
			return false;
		}
		method_4(Enum2.const_1);
		Class41 @class = new Class41("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class38 class2 = new Class38(this, array, @class, class40_0);
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

	protected void method_2(Enum2 enum2_0, string string_0, string string_1)
	{
		delegate3_0?.Invoke(this, new EventArgs4(enum2_0, string_0, string_1));
	}

	protected void method_3(Enum2 enum2_0, string string_0)
	{
		method_2(enum2_0, string_0, string.Empty);
	}

	protected void method_4(Enum2 enum2_0)
	{
		method_3(enum2_0, string.Empty);
	}
}
