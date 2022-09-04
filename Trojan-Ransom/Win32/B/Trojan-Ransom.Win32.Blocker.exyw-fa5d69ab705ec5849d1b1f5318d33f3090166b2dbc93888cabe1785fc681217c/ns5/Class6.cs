namespace ns5;

internal sealed class Class6
{
	internal static string dtth = "y";

	internal static string cfvds = Reverse("gnirtS46esaBmorF");

	public static string Reverse(string text)
	{
		char[] array = text.ToCharArray();
		string text2 = string.Empty;
		for (int num = array.Length - 1; num > -1; num--)
		{
			text2 += array[num];
		}
		return text2;
	}
}
