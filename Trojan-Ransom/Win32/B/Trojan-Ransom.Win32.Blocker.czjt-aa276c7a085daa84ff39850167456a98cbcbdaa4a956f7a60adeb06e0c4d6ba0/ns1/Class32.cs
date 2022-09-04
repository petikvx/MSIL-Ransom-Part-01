using System;
using System.Net;
using System.Text;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;
using ns8;

namespace ns1;

internal class Class32
{
	internal class Class34
	{
		private readonly Class32 class32_0;

		private readonly byte[] byte_0;

		private readonly Class37 class37_0;

		private readonly Class36 class36_0;

		public bool bool_0 = true;

		public Class34(Class32 class32_1, byte[] byte_1, Class37 class37_1, Class36 class36_1)
		{
			class32_0 = class32_1;
			class36_0 = class36_1;
			class37_0 = class37_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class24.smethod_90(class32_0, Enum2.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{FDC54A6F-5294-4961-88B8-331D8BE2D74A}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class35 @class = new Class35(class32_0);
				Class37 class2 = class37_0;
				string string_ = Class24.smethod_141(class36_0);
				string string_2 = Class24.smethod_37(class36_0);
				string string_3 = Class24.smethod_108(class36_0);
				Delegate4 delegate4_ = @class.method_0;
				Class24.smethod_17(string_2, class2, delegate4_, string_3, string_, destinationArray);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class32_0.delegate3_0 != null)
				{
					class32_0.delegate3_0(this, new EventArgs4(Enum2.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class35
	{
		private readonly Class32 class32_0;

		public bool bool_0;

		public Class35(Class32 class32_1)
		{
			class32_0 = class32_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class24.smethod_100(Enum2.const_2, string_0, class32_0);
				bool_0 = false;
			}
			else
			{
				Class24.smethod_64(class32_0, Enum2.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class36
	{
		public static Class36 class36_0 = new Class36(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class36(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate3 delegate3_0;
}
