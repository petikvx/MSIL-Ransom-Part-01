using System;
using System.Net;
using System.Text;

namespace ns9;

internal class Class39
{
	internal class Class41
	{
		private readonly Class39 class39_0;

		private readonly byte[] byte_0;

		private readonly Class50 class50_0;

		private readonly Class43 class43_0;

		public bool bool_0;

		public Class41(Class39 class39_1, byte[] byte_1, Class50 class50_1, Class43 class43_1)
		{
			while (true)
			{
				bool_0 = true;
				int num = 0;
				if (!M1i3l3SFGfy90RoGeZ3())
				{
					break;
				}
				do
				{
					switch (num)
					{
					default:
						goto IL_0003;
					case 4:
						break;
					case 0:
					case 1:
						base._002Ector();
						goto case 2;
					case 2:
					case 5:
						class39_0 = class39_1;
						goto case 3;
					case 3:
						class43_0 = class43_1;
						class50_0 = class50_1;
						byte_0 = byte_1;
						return;
					case 6:
						return;
					}
					break;
					IL_0003:
					num = 3;
				}
				while (M1i3l3SFGfy90RoGeZ3());
			}
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				Class17.smethod_19(class39_0, Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{F10BA855-5D50-46A2-B1AD-DE0A2F07B75F}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class42 @class = new Class42(class39_0);
				Class50 class2 = class50_0;
				string string_ = class43_0.string_0;
				string string_2 = class43_0.string_1;
				string string_3 = class43_0.string_2;
				Delegate15 delegate15_ = @class.method_0;
				Class17.smethod_51(string_, class2, destinationArray, delegate15_, string_2, string_3);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class39_0.delegate14_0 != null)
				{
					class39_0.delegate14_0(this, new EventArgs3(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		internal static bool M1i3l3SFGfy90RoGeZ3()
		{
			return true;
		}

		internal static bool aj1WKdSOgJhZVCuWeMJ()
		{
			return false;
		}
	}

	private class Class42
	{
		private readonly Class39 class39_0;

		public bool bool_0;

		public Class42(Class39 class39_1)
		{
			class39_0 = class39_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class17.smethod_183(class39_0, Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class17.smethod_186(class39_0, Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		internal static bool eMeEqmShWC4gZ5X1FgR()
		{
			return true;
		}

		internal static bool hfoUsOSCEbaDByWZs55()
		{
			return false;
		}
	}

	internal class Class43
	{
		public static Class43 class43_0 = new Class43(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public Class43(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}

		internal static bool MMLL3MS2ZwqOiU3odF5()
		{
			return true;
		}

		internal static bool F38ra9SryUNyNiYNj7o()
		{
			return false;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate14 delegate14_0;
}
