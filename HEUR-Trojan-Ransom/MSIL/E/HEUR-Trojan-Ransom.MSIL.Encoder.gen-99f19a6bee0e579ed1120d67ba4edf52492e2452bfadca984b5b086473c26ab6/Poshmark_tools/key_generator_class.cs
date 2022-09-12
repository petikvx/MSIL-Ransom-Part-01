using System;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using WindowsFormsApplication1;

namespace Poshmark_tools;

internal class key_generator_class
{
	public string system_key
	{
		get
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected O, but got Unknown
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string result = "";
			try
			{
				try
				{
					SelectQuery val = new SelectQuery("Select * from Win32_ComputerSystem");
					ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
					try
					{
						ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ManagementObject val3 = (ManagementObject)enumerator.get_Current();
								val3.Get();
								text4 = ((ManagementBaseObject)val3).get_Item("Manufacturer").ToString();
								text3 = ((ManagementBaseObject)val3).get_Item("Model").ToString();
							}
						}
						finally
						{
							((IDisposable)enumerator)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				catch
				{
				}
				try
				{
					ManagementObjectSearcher val4 = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
					ManagementObjectCollection val5 = val4.Get();
					ManagementObjectEnumerator enumerator2 = val5.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ManagementObject val6 = (ManagementObject)enumerator2.get_Current();
							text = ((ManagementBaseObject)val6).get_Item("Version").ToString();
							text2 = ((ManagementBaseObject)val6).get_Item("SerialNumber").ToString();
						}
					}
					finally
					{
						((IDisposable)enumerator2)?.Dispose();
					}
				}
				catch
				{
				}
				try
				{
					ManagementObjectSearcher val7 = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
					ManagementObjectCollection val8 = val7.Get();
					ManagementObjectEnumerator enumerator3 = val8.GetEnumerator();
					try
					{
						if (enumerator3.MoveNext())
						{
							ManagementObject val9 = (ManagementObject)enumerator3.get_Current();
							text5 = ((ManagementBaseObject)val9).get_Item("ProcessorID").ToString();
						}
					}
					finally
					{
						((IDisposable)enumerator3)?.Dispose();
					}
				}
				catch
				{
				}
				try
				{
					ManagementClass val10 = new ManagementClass("Win32_BaseBoard");
					ManagementObjectCollection instances = val10.GetInstances();
					ManagementObjectEnumerator enumerator4 = instances.GetEnumerator();
					try
					{
						if (enumerator4.MoveNext())
						{
							ManagementObject val11 = (ManagementObject)enumerator4.get_Current();
							text6 = ((ManagementBaseObject)val11).get_Properties().get_Item("SerialNumber").get_Value()
								.ToString();
						}
					}
					finally
					{
						((IDisposable)enumerator4)?.Dispose();
					}
				}
				catch
				{
				}
				Environment.OSVersion.Version.ToString();
				text7 = Environment.MachineName;
				result = text7 + "<" + text4 + "<" + text3 + "<" + text6 + "<" + text5 + "<" + text + "<" + text2;
			}
			catch (Exception)
			{
			}
			return result;
		}
	}

	public static DateTime real_time
	{
		get
		{
			DateTime result = DateTime.Now;
			try
			{
				TcpClient tcpClient = new TcpClient("time.nist.gov", 13);
				using StreamReader streamReader = new StreamReader(tcpClient.GetStream());
				string text = streamReader.ReadToEnd();
				string s = text.Substring(7, 17);
				result = (Form1.today_date_microsolft = DateTime.ParseExact(s, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal));
			}
			catch
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
					WebResponse response = httpWebRequest.GetResponse();
					string s2 = response.Headers["date"];
					result = (Form1.today_date_microsolft = DateTime.ParseExact(s2, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal));
				}
				catch
				{
				}
			}
			return result;
		}
	}

	public static string Value()
	{
		string text = "";
		if (string.IsNullOrEmpty(text))
		{
			text = diskId();
		}
		return text;
	}

	private static string identifier(string wmiClass, string wmiProperty)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(wmiClass);
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == "")
				{
					try
					{
						text = ((ManagementBaseObject)val2).get_Item(wmiProperty).ToString()!.TrimStart(new char[0]).TrimEnd(new char[0]);
					}
					catch
					{
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text;
	}

	private static string diskId()
	{
		return identifier("Win32_DiskDrive", "Model") + "--" + identifier("Win32_DiskDrive", "Signature") + "--" + identifier("Win32_DiskDrive", "SerialNumber");
	}
}
