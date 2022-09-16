using System.Net;

namespace WindowsFormsApp59;

internal class High
{
	internal static byte[] GetData(string url)
	{
		byte[] array = null;
		WebClient webClient;
		while (true)
		{
			webClient = new WebClient();
			try
			{
				array = webClient.DownloadData(url);
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
