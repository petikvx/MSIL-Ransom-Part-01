internal sealed class Class29
{
	private sealed class Class30
	{
		public static readonly Class30 class30_0 = new Class30();

		private Class30()
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
		return Class30.class30_0.method_0(string_0, int_0);
	}
}
