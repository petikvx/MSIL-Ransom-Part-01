using System;
using System.Net;
using System.Text;
using ns0;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns2;

internal class Class44
{
	internal class Class46
	{
		private readonly Class44 class44_0;

		private readonly byte[] byte_0;

		private readonly Class53 class53_0;

		private readonly Class48 class48_0;

		public bool bool_0 = true;

		public Class46(Class44 class44_1, byte[] byte_1, Class53 class53_1, Class48 class48_1)
		{
			class44_0 = class44_1;
			class48_0 = class48_1;
			class53_0 = class53_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class42.smethod_156(class44_0, Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{DFA8ED2E-5616-44FF-892B-A77949B35FF3}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class47 @class = new Class47(class44_0);
				Class53 class2 = class53_0;
				string string_ = class48_0.string_0;
				string string_2 = class48_0.string_1;
				string string_3 = class48_0.string_2;
				Delegate3 delegate3_ = @class.method_0;
				Class42.smethod_169(destinationArray, class2, delegate3_, string_, string_2, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class44_0.delegate2_0 != null)
				{
					class44_0.delegate2_0(this, new EventArgs3(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class47
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
				Class42.smethod_117(class44_0, Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class42.smethod_136(class44_0, Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class48
	{
		public static Class48 class48_0 = new Class48(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class48(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate2 delegate2_0;
}
