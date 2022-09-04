using System;
using System.Net;
using System.Text;
using ns1;
using ns5;
using ns7;
using ns9;

namespace ns2;

internal class Class15
{
	internal class Class17
	{
		private readonly Class15 class15_0;

		private readonly byte[] byte_0;

		private readonly Class27 class27_0;

		private readonly Class19 class19_0;

		public bool bool_0 = true;

		public Class17(Class15 class15_1, byte[] byte_1, Class27 class27_1, Class19 class19_1)
		{
			class15_0 = class15_1;
			class19_0 = class19_1;
			class27_0 = class27_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class24.smethod_176(class15_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{FDC54A6F-5294-4961-88B8-331D8BE2D74A}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class18 @class = new Class18(class15_0);
				Class27 class2 = class27_0;
				string string_ = class19_0.string_0;
				string string_2 = class19_0.string_1;
				string string_3 = class19_0.string_2;
				Delegate2 delegate2_ = @class.method_0;
				Class24.smethod_116(string_, string_3, destinationArray, string_2, class2, delegate2_);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class15_0.delegate1_0 != null)
				{
					class15_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class18
	{
		private readonly Class15 class15_0;

		public bool bool_0;

		public Class18(Class15 class15_1)
		{
			class15_0 = class15_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class24.smethod_13(class15_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class24.smethod_94(class15_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class19
	{
		public static Class19 class19_0 = new Class19(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class19(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate1 delegate1_0;
}
