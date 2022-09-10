using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace RestorePriorPervasive;

internal class Program
{
	private static List<string> m_PrioPervasiveDlls = new List<string>();

	private static List<string> m_PriorPervasiveDLLsEXEs = new List<string>();

	private static string m_PervasiveReg = string.Empty;

	private static string m_PSODBCCIReg = string.Empty;

	private static string m_PSODBCEIReg = string.Empty;

	private static string m_PS0AReg = string.Empty;

	private static void Main(string[] args)
	{
		if (args.Length != 2)
		{
			Console.WriteLine("Parameters: [Old Pervasive Version] [Peachtree Program Path]");
			return;
		}
		string text = "V" + args[0];
		string text2 = args[1];
		string path = text2 + "ArchivedPervasive\\";
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
		FileSystemInfo[] array = fileSystemInfos;
		foreach (FileSystemInfo fileSystemInfo in array)
		{
			if (fileSystemInfo is FileInfo fileInfo)
			{
				string text3 = fileInfo.Name.ToUpper();
				if (fileInfo.Extension.ToUpper() == ".REG" && IntPtr.Size == 8)
				{
					string text4 = File.ReadAllText(fileInfo.FullName);
					File.WriteAllText(fileInfo.FullName, text4.Replace("HKEY_LOCAL_MACHINE\\SOFTWARE\\", "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\"), Encoding.Unicode);
				}
				switch (text3)
				{
				case "PSODBCCI.REG":
					m_PSODBCCIReg = fileInfo.FullName;
					break;
				case "PSODBCEI.REG":
					m_PSODBCEIReg = fileInfo.FullName;
					break;
				case "PSOA.REG":
					m_PS0AReg = fileInfo.FullName;
					break;
				case "PRIORPERVASIVE.REG":
					m_PervasiveReg = fileInfo.FullName;
					break;
				}
			}
		}
		FileSystemInfo[] array2 = fileSystemInfos;
		foreach (FileSystemInfo fileSystemInfo2 in array2)
		{
			if (fileSystemInfo2 is DirectoryInfo directoryInfo2)
			{
				string text5 = directoryInfo2.Name.ToUpper();
				if (text5 == text)
				{
					DirectoryInfo directoryInfo3 = directoryInfo2.GetDirectories()[0];
					string name = directoryInfo3.Name;
					RestorePriorPervasiveFileSystem(name, directoryInfo3.FullName);
					RestoreRegistrySettings(name);
					ConstructListOfPriorPervasiveDlls(name);
					ConstructListOfPrioPervasiveExesDlls(name);
					SetDLLsEXEsToReadonly(name);
					RegisterPriorPervasiveDlls(name);
				}
			}
		}
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}

	private static void RestoreRegistrySettings(string rootPath)
	{
		Process process = new Process();
		string fileName = "RegEdit.exe";
		string[] array = new string[4] { m_PervasiveReg, m_PS0AReg, m_PSODBCCIReg, m_PSODBCEIReg };
		string contents = "\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBCINST.INI\\ODBC Drivers]\n\"Pervasive ODBC Client Interface\"=\"Installed\"";
		string contents2 = "\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBCINST.INI\\ODBC Drivers]\n\"Pervasive ODBC Engine Interface\"=\"Installed\"";
		string contents3 = "\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBCINST.INI\\ODBC Translators]\n\"Pervasive Software OEM to ANSI\"=\"Installed\"";
		File.AppendAllText(m_PSODBCCIReg, contents, Encoding.Unicode);
		File.AppendAllText(m_PSODBCEIReg, contents2, Encoding.Unicode);
		File.AppendAllText(m_PS0AReg, contents3, Encoding.Unicode);
		string text = "/s ";
		string[] array2 = new string[4]
		{
			text + "\"" + array[0] + "\"",
			text + "\"" + array[1] + "\"",
			text + "\"" + array[2] + "\"",
			text + "\"" + array[3] + "\""
		};
		foreach (string arguments in array2)
		{
			process.StartInfo = new ProcessStartInfo(fileName, arguments);
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
		}
	}

	private static void RestorePriorPervasiveFileSystem(string rootPath, string srcPath)
	{
		Process process = new Process();
		string arguments = "\"" + srcPath + "\" " + rootPath + ":\\ /Q /Y /S /E";
		process.StartInfo = new ProcessStartInfo("XCopy.exe", arguments);
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
	}

	private static void RegisterPriorPervasiveDlls(string rootPath)
	{
		Process process = new Process();
		try
		{
			foreach (string prioPervasiveDll in m_PrioPervasiveDlls)
			{
				string arguments = "/s " + prioPervasiveDll;
				process.StartInfo = new ProcessStartInfo("Regsvr32.exe", arguments);
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch (Exception)
		{
		}
	}

	private static void ConstructListOfPriorPervasiveDlls(string rootPath)
	{
		string path = rootPath + ":\\pvsw\\bin";
		string[] files = Directory.GetFiles(path);
		string[] array = files;
		foreach (string text in array)
		{
			string text2 = text.Substring(text.Length - 3, 3).ToUpper();
			if (text2 == "DLL" && !text.Contains("w3odbcei") && !text.Contains("w3sqlmgr") && !text.Contains("w3dbav") && !text.Contains("dto"))
			{
				m_PrioPervasiveDlls.Add(text);
			}
		}
	}

	private static void ConstructListOfPrioPervasiveExesDlls(string rootPath)
	{
		string path = rootPath + ":\\pvsw\\bin";
		string[] files = Directory.GetFiles(path);
		string[] array = files;
		foreach (string text in array)
		{
			string text2 = text.Substring(text.Length - 3, 3).ToUpper();
			if (text2 == "EXE" || text2 == "DLL")
			{
				m_PriorPervasiveDLLsEXEs.Add(text);
			}
		}
	}

	private static void SetDLLsEXEsToReadonly(string rootPath)
	{
		foreach (string priorPervasiveDLLsex in m_PriorPervasiveDLLsEXEs)
		{
			FileInfo fileInfo = new FileInfo(priorPervasiveDLLsex);
			fileInfo.IsReadOnly = true;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(rootPath + ":\\Documents and Settings\\All Users\\Start Menu\\Programs\\Startup");
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo2 in array)
		{
			if (fileInfo2.Name.Contains("Pervasive.SQL Workgroup Engine"))
			{
				fileInfo2.IsReadOnly = true;
			}
		}
	}
}
