internal sealed class Class36
{
	private sealed class Class37
	{
		public static readonly Class37 class37_0 = new Class37();

		private Class37()
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
		return Class37.class37_0.method_0(string_0, int_0);
	}
}
