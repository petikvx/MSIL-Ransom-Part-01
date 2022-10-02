using System;
using System.Net;
using System.Text;
using ns1;
using ns2;
using ns5;
using ns8;

namespace ns7;

internal class Class23
{
	internal sealed class Class25
	{
		private readonly Class23 class23_0;

		private readonly byte[] byte_0;

		private readonly Class35 class35_0;

		private readonly Class27 class27_0;

		public bool bool_0 = true;

		public Class25(Class23 class23_1, byte[] byte_1, Class35 class35_1, Class27 class27_1)
		{
			class23_0 = class23_1;
			class27_0 = class27_1;
			class35_0 = class35_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class29.smethod_193(class23_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{92D2F7FD-A57F-4267-8A28-6C0BFBF28D32}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class26 @class = new Class26(class23_0);
				Class35 class2 = class35_0;
				string string_ = class27_0.string_0;
				string string_2 = class27_0.string_1;
				string string_3 = class27_0.string_2;
				Delegate2 delegate2_ = @class.method_0;
				Class29.smethod_170(delegate2_, class2, string_2, string_, destinationArray, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class23_0.delegate1_0 != null)
				{
					class23_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class26
	{
		private readonly Class23 class23_0;

		public bool bool_0;

		public Class26(Class23 class23_1)
		{
			class23_0 = class23_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class29.smethod_147(class23_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class29.smethod_39(class23_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class27
	{
		public static Class27 class27_0 = new Class27(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class27(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate1 delegate1_0;
}
