using System;
using System.Net;
using System.Text;

namespace ns4;

internal class Class26
{
	internal class Class28
	{
		private readonly Class26 class26_0;

		private readonly object object_0;

		private readonly Class37 class37_0;

		private readonly Class30 class30_0;

		public bool bool_0;

		public Class28(Class26 class26_1, byte[] byte_0, Class37 class37_1, Class30 class30_1)
		{
			Class42.hMqjKD0znI7T7();
			bool_0 = true;
			base._002Ector();
			class26_0 = class26_1;
			class30_0 = class30_1;
			class37_0 = class37_1;
			object_0 = byte_0;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class24.smethod_115(class26_0, Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{ED572A83-61B0-47F7-BC2D-38A950D9B848}");
				byte[] array = new byte[bytes.Length + ((Array)object_0).Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy((Array)object_0, 0, array, bytes.Length, ((Array)object_0).Length);
				Class29 @class = new Class29(class26_0);
				Class37 class2 = class37_0;
				string string_ = class30_0.string_0;
				string string_2 = class30_0.string_1;
				string string_3 = class30_0.string_2;
				Delegate2 delegate2_ = @class.method_0;
				Class24.smethod_135(string_, string_3, array, delegate2_, class2, string_2);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class26_0.delegate1_0 != null)
				{
					class26_0.delegate1_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class29
	{
		private readonly Class26 class26_0;

		public bool bool_0;

		public Class29(Class26 class26_1)
		{
			Class42.hMqjKD0znI7T7();
			base._002Ector();
			class26_0 = class26_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class24.smethod_67(class26_0, Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class24.smethod_111(class26_0, Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class30
	{
		public static Class30 class30_0;

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class30(string string_3, string string_4, string string_5)
		{
			Class42.hMqjKD0znI7T7();
			base._002Ector();
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}

		static Class30()
		{
			Class42.hMqjKD0znI7T7();
			class30_0 = new Class30(null, null, null);
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate1 delegate1_0;

	public Class26()
	{
		Class42.hMqjKD0znI7T7();
		base._002Ector();
	}
}
