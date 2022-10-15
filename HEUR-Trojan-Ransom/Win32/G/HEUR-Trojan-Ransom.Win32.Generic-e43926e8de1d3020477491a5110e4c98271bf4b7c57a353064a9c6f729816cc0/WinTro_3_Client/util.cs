namespace WinTro_3_Client;

internal class util
{
	public const int KB = 1024;

	public const int MB = 1048576;

	public static string AttaccaParametri(string[] array, int startIndex)
	{
		string text = "";
		for (int i = startIndex; i < array.Length; i++)
		{
			text += array[i];
		}
		return text;
	}
}
