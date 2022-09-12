using System;
using System.Net;
using System.Text;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns0;

internal class Class25
{
	internal sealed class Class27
	{
		private readonly Class25 class25_0;

		private readonly byte[] byte_0;

		private readonly Class36 class36_0;

		private readonly Class29 class29_0;

		public bool bool_0 = true;

		public Class27(Class25 class25_1, byte[] byte_1, Class36 class36_1, Class29 class29_1)
		{
			class25_0 = class25_1;
			class29_0 = class29_1;
			class36_0 = class36_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class3.smethod_8(class25_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{F0AD520B-9402-458F-A96E-580FD3730237}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class28 @class = new Class28(class25_0);
				Class36 class2 = class36_0;
				string string_ = class29_0.string_0;
				string string_2 = class29_0.string_1;
				string string_3 = class29_0.string_2;
				Delegate2 delegate2_ = @class.method_0;
				Class3.smethod_166(string_, destinationArray, string_2, delegate2_, class2, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class25_0.delegate1_0 != null)
				{
					class25_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class28
	{
		private readonly Class25 class25_0;

		public bool bool_0;

		public Class28(Class25 class25_1)
		{
			class25_0 = class25_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class3.smethod_68(class25_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class3.smethod_2(class25_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class29
	{
		public static Class29 class29_0 = new Class29(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class29(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate1 delegate1_0;
}
