using System;
using System.Net;
using System.Text;
using ns0;
using ns5;
using ns6;
using ns8;

namespace ns7;

internal class Class27
{
	internal class Class29
	{
		private readonly Class27 class27_0;

		private readonly byte[] byte_0;

		private readonly Class38 class38_0;

		private readonly Class31 class31_0;

		public bool bool_0 = true;

		public Class29(Class27 class27_1, byte[] byte_1, Class38 class38_1, Class31 class31_1)
		{
			class27_0 = class27_1;
			class31_0 = class31_1;
			class38_0 = class38_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class24.smethod_86(class27_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{8101C3F8-A792-4EB9-952B-26F7AB9A4B5A}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class30 @class = new Class30(class27_0);
				Class38 class2 = class38_0;
				string string_ = class31_0.string_0;
				string string_2 = class31_0.string_1;
				string string_3 = class31_0.string_2;
				Delegate3 delegate3_ = @class.method_0;
				Class24.smethod_52(string_, string_2, class2, delegate3_, destinationArray, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class27_0.delegate2_0 != null)
				{
					class27_0.delegate2_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class30
	{
		private readonly Class27 class27_0;

		public bool bool_0;

		public Class30(Class27 class27_1)
		{
			class27_0 = class27_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class24.smethod_142(class27_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class24.smethod_78(class27_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class31
	{
		public static Class31 class31_0 = new Class31(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class31(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate2 delegate2_0;
}
