internal class Class2
{
	internal static string smethod_0(string string_0, int int_0)
	{
		int num = 201596314 + int_0;
		char[] array = string_0.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			int num2 = i;
			char c = array[i];
			array[num2] = (char)((((c & 0xFF) ^ num++) << 8) | (byte)(((int)c >> 8) ^ num++));
		}
		return string.Intern(new string(array));
	}
}
