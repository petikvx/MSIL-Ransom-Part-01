internal sealed class Class72
{
	private sealed class Class73
	{
		public static readonly Class73 class73_0 = new Class73();

		private Class73()
		{
		}

		public string method_0(string string_0, int int_0)
		{
			int num = string_0.Length;
			char[] array = string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ int_0);
			}
			return new string(array);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		return Class73.class73_0.method_0(string_0, int_0);
	}
}
