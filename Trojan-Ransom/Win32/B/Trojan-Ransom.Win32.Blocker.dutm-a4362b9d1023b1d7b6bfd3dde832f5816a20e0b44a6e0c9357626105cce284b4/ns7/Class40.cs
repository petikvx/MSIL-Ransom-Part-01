using System;
using System.Net;
using System.Text;
using ns2;
using ns3;
using ns5;
using ns6;
using ns9;

namespace ns7;

internal class Class40
{
	internal sealed class Class42
	{
		private readonly Class40 class40_0;

		private readonly byte[] byte_0;

		private readonly Class45 class45_0;

		private readonly Class44 class44_0;

		public bool bool_0 = true;

		public Class42(Class40 class40_1, byte[] byte_1, Class45 class45_1, Class44 class44_1)
		{
			class40_0 = class40_1;
			class44_0 = class44_1;
			class45_0 = class45_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class29.smethod_194(class40_0, Enum2.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{92D2F7FD-A57F-4267-8A28-6C0BFBF28D32}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class43 @class = new Class43(class40_0);
				Class45 class2 = class45_0;
				string string_ = Class29.smethod_171(class44_0);
				string string_2 = Class29.smethod_75(class44_0);
				string string_3 = Class29.smethod_0(class44_0);
				Delegate4 delegate4_ = @class.method_0;
				Class29.smethod_63(delegate4_, class2, destinationArray, string_, string_2, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class40_0.delegate3_0 != null)
				{
					class40_0.delegate3_0(this, new EventArgs4(Enum2.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class43
	{
		private readonly Class40 class40_0;

		public bool bool_0;

		public Class43(Class40 class40_1)
		{
			class40_0 = class40_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class29.smethod_203(string_0, class40_0, Enum2.const_2);
				bool_0 = false;
			}
			else
			{
				Class29.smethod_14(class40_0, Enum2.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class44
	{
		public static Class44 class44_0 = new Class44(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class44(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate3 delegate3_0;
}
