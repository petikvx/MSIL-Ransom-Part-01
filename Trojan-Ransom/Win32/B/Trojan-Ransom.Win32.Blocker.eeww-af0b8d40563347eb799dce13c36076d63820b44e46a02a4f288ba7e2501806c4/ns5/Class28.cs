using System;
using System.Net;
using System.Text;
using ns2;

namespace ns5;

internal class Class28
{
	internal sealed class Class30
	{
		private readonly Class28 class28_0;

		private readonly byte[] byte_0;

		private readonly Class39 class39_0;

		private readonly Class32 class32_0;

		public bool bool_0 = true;

		public Class30(Class28 class28_1, byte[] byte_1, Class39 class39_1, Class32 class32_1)
		{
			class28_0 = class28_1;
			class32_0 = class32_1;
			class39_0 = class39_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class25.smethod_225(class28_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{1F0FBEB0-B22C-481C-B5BE-4B0B198A0F51}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class31 @class = new Class31(class28_0);
				Class39 class2 = class39_0;
				string string_ = class32_0.string_0;
				string string_2 = class32_0.string_1;
				string string_3 = class32_0.string_2;
				Delegate2 delegate2_ = @class.method_0;
				Class25.smethod_183(string_2, destinationArray, delegate2_, class2, string_, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class28_0.delegate1_0 != null)
				{
					class28_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class31
	{
		private readonly Class28 class28_0;

		public bool bool_0;

		public Class31(Class28 class28_1)
		{
			class28_0 = class28_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class25.smethod_128(class28_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class25.smethod_63(class28_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class32
	{
		public static Class32 class32_0 = new Class32(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class32(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate1 delegate1_0;
}
