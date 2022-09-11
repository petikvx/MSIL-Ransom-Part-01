using ns1;

namespace ns0;

internal sealed class Class4
{
	private static string string_0;

	private static string string_1;

	private static object object_0 = new object();

	internal static string String_0
	{
		get
		{
			lock (object_0)
			{
				return string_0;
			}
		}
		set
		{
			lock (object_0)
			{
				string_0 = value;
			}
		}
	}

	internal static string String_1
	{
		get
		{
			lock (object_0)
			{
				return string_1;
			}
		}
		set
		{
			lock (object_0)
			{
				string_1 = value;
			}
		}
	}

	internal static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			LXComboBox.smethod_0(byte_0, byte_1, i);
		}
	}
}
