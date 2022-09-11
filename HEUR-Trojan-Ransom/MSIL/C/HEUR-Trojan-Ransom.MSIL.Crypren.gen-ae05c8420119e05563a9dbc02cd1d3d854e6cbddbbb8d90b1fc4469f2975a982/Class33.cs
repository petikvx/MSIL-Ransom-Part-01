internal sealed class Class33
{
	private sealed class Class34
	{
		public static readonly Class34 class34_0 = new Class34();

		private Class34()
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
		return Class34.class34_0.method_0(string_0, int_0);
	}
}
