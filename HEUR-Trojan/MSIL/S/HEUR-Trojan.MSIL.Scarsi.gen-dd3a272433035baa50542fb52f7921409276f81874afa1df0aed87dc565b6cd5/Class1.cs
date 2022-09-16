using System.Net;

internal sealed class Class1
{
	internal static byte[] smethod_0(string string_0)
	{
		byte[] array = null;
		WebClient webClient;
		while (true)
		{
			webClient = new WebClient();
			try
			{
				array = webClient.DownloadData(string_0);
			}
			catch
			{
				continue;
			}
			break;
		}
		webClient.Dispose();
		return array;
	}
}
