using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public sealed class MainForm : Form
{
	private sealed class Class1
	{
		public MainForm mainForm_0;

		public string string_0;

		public bool bool_0;

		public void method_0()
		{
			mainForm_0.updateProgress.get_Items().Add((object)(bool_0 ? (DateTime.Now.ToShortTimeString() + "\t") : (string_0 ?? string.Empty)));
		}
	}

	private sealed class Class2
	{
		public MainForm mainForm_0;

		public string string_0;

		public bool bool_0;

		public void method_0()
		{
			mainForm_0.updateProgress.get_Items().set_Item(mainForm_0.updateProgress.get_Items().get_Count() - 1, (object)(bool_0 ? (DateTime.Now.ToShortTimeString() + "\t") : (string_0 ?? string.Empty)));
		}
	}

	private sealed class Class3
	{
		public string string_0;

		public bool method_0(Process process_0)
		{
			return process_0.MainModule!.FileName == string_0 + "\\MuttleyBot.exe";
		}
	}

	private IContainer icontainer_0;

	private ListBox updateProgress;

	public MainForm()
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		updateProgress = new ListBox();
		((Control)this).SuspendLayout();
		((ListControl)updateProgress).set_FormattingEnabled(true);
		((Control)updateProgress).set_Location(new Point(12, 12));
		((Control)updateProgress).set_Name("updateProgress");
		((Control)updateProgress).set_Size(new Size(260, 95));
		((Control)updateProgress).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(284, 121));
		((Control)this).get_Controls().Add((Control)(object)updateProgress);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("Muttley Bot Installer");
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)this).ResumeLayout(false);
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		method_8();
	}

	private string method_0(string string_0)
	{
		WebClient webClient = new WebClient();
		string result = webClient.DownloadString(string_0);
		webClient.Dispose();
		return result;
	}

	private void method_1(string string_0, string string_1)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		method_2("Downloading " + string_0.Split(new char[1] { '/' }).Last() + " 0%");
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			httpWebRequest.Method = "GET";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write, FileShare.None);
			long num = 0L;
			long contentLength = httpWebResponse.ContentLength;
			byte[] array = new byte[1024];
			int num2;
			while ((num2 = responseStream.Read(array, 0, array.Length)) > 0)
			{
				fileStream.Write(array, 0, num2);
				num += num2;
				double value = (double)num / (double)contentLength * 100.0;
				method_4("Downloading " + string_0.Split(new char[1] { '/' }).Last() + " " + Math.Round(value, 2) + "%");
			}
			httpWebResponse.Close();
			fileStream.Close();
			responseStream.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void method_2(string string_0)
	{
		method_3(string_0, bool_0: false);
	}

	private void method_3(string string_0, bool bool_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Class1 @class = new Class1();
		@class.string_0 = string_0;
		@class.bool_0 = bool_0;
		@class.mainForm_0 = this;
		((Control)this).Invoke((Delegate)new MethodInvoker(@class.method_0));
	}

	private void method_4(string string_0)
	{
		method_5(string_0, bool_0: false);
	}

	private void method_5(string string_0, bool bool_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Class2 @class = new Class2();
		@class.string_0 = string_0;
		@class.bool_0 = bool_0;
		@class.mainForm_0 = this;
		((Control)this).Invoke((Delegate)new MethodInvoker(@class.method_0));
	}

	private string method_6()
	{
		StreamReader streamReader = new StreamReader(File.Open("version.txt", FileMode.OpenOrCreate));
		string result = streamReader.ReadLine();
		streamReader.Close();
		return result;
	}

	private void method_7(string string_0)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open("version.txt", FileMode.Create));
		streamWriter.Write(string_0);
		streamWriter.Close();
	}

	private void method_8()
	{
		Thread thread = new Thread(method_9);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private void method_9()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		Class3 @class = new Class3();
		@class.string_0 = "C:\\Program Files\\Muttley Bot";
		method_2("Starting update...");
		method_2("Getting Downloads List");
		string text = method_0("http://muttleytools.pl/link/version.txt");
		List<string> list = method_0("http://muttleytools.pl/link/installNewest.txt").Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		FolderBrowserDialog val = new FolderBrowserDialog();
		if (Environment.GetCommandLineArgs().Contains("-u"))
		{
			@class.string_0 = Environment.CurrentDirectory;
		}
		else
		{
			while (true)
			{
				val.set_SelectedPath(Environment.CurrentDirectory);
				if ((int)((CommonDialog)val).ShowDialog() != 1)
				{
					Environment.Exit(-1);
				}
				else
				{
					@class.string_0 = val.get_SelectedPath();
				}
				if (Directory.Exists(@class.string_0))
				{
					break;
				}
				MessageBox.Show("Folder doesn't exist, please choose it again", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		bool flag;
		if (flag = method_6() != text)
		{
			method_2("New version is avalaiable!");
			foreach (Process item in Process.GetProcessesByName("MuttleyBot").Where(@class.method_0))
			{
				if ((int)MessageBox.Show("Before continuing update MuttleyBot have to be closed. Do it now?", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					item.Kill();
					Thread.Sleep(500);
					continue;
				}
				return;
			}
			method_2("Removing " + @class.string_0 + "\\MuttleyBot.exe");
			File.Delete(@class.string_0 + "\\MuttleyBot.exe");
		}
		else
		{
			method_2("Any new version is not avalaiable");
		}
		Directory.CreateDirectory(@class.string_0 + "\\Documentation");
		Directory.CreateDirectory(@class.string_0 + "\\Scripts");
		foreach (string item2 in list)
		{
			string string_ = item2.Split(new char[1] { ' ' })[1];
			string text2 = @class.string_0 + item2.Split(new char[1] { ' ' })[2];
			switch (item2[0])
			{
			case '1':
				if (!File.Exists(text2))
				{
					method_1(string_, text2);
				}
				break;
			case '2':
				method_1(string_, text2);
				break;
			case '3':
				if (flag)
				{
					method_1(string_, text2);
				}
				break;
			}
		}
		if (flag)
		{
			method_2("Starting MuttleyBot.exe");
			Process.Start(@class.string_0 + "\\MuttleyBot.exe");
			method_2("Shutting down...");
			Thread.Sleep(1000);
			Environment.Exit(0);
		}
	}
}
