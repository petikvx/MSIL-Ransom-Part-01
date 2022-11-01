using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;

namespace YullySpoofer;

public class CODSelect : Form
{
	private IContainer components;

	private SiticoneButton siticoneButton7;

	private GunaTextBox DirectoryCod;

	private Label label2;

	private Label label1;

	public CODSelect()
	{
		InitializeComponent();
	}

	private void CODSelect_Load(object sender, EventArgs e)
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

	[DllImport("DwmApi")]
	private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

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
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CODSelect));
		siticoneButton7 = new SiticoneButton();
		DirectoryCod = new GunaTextBox();
		label2 = new Label();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)siticoneButton7).set_BackColor(Color.FromArgb(10, 10, 10));
		siticoneButton7.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton7);
		siticoneButton7.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton7);
		siticoneButton7.set_FillColor(Color.FromArgb(12, 12, 12));
		((Control)siticoneButton7).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton7).set_ForeColor(Color.White);
		siticoneButton7.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton7);
		((Control)siticoneButton7).set_Location(new Point(12, 97));
		((Control)siticoneButton7).set_Name("siticoneButton7");
		siticoneButton7.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton7);
		((Control)siticoneButton7).set_Size(new Size(317, 32));
		((Control)siticoneButton7).set_TabIndex(57);
		((Control)siticoneButton7).set_Text("Save");
		((Control)siticoneButton7).add_Click((EventHandler)siticoneButton7_Click);
		((Control)DirectoryCod).set_BackColor(Color.Transparent);
		DirectoryCod.set_BaseColor(Color.FromArgb(12, 12, 12));
		DirectoryCod.set_BorderColor(Color.FromArgb(20, 20, 20));
		DirectoryCod.set_BorderSize(1);
		((Control)DirectoryCod).set_Cursor(Cursors.get_IBeam());
		DirectoryCod.set_FocusedBaseColor(Color.FromArgb(12, 12, 12));
		DirectoryCod.set_FocusedBorderColor(Color.FromArgb(12, 12, 12));
		DirectoryCod.set_FocusedForeColor(Color.White);
		((Control)DirectoryCod).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)DirectoryCod).set_ForeColor(Color.FromArgb(93, 101, 111));
		((Control)DirectoryCod).set_Location(new Point(12, 53));
		((Control)DirectoryCod).set_Name("DirectoryCod");
		DirectoryCod.set_PasswordChar('\0');
		DirectoryCod.set_Radius(3);
		DirectoryCod.set_SelectedText("");
		((Control)DirectoryCod).set_Size(new Size(317, 35));
		((Control)DirectoryCod).set_TabIndex(58);
		((Control)DirectoryCod).add_TextChanged((EventHandler)DirectoryCod_TextChanged);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(158, 159, 168));
		((Control)label2).set_Location(new Point(12, 27));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(121, 15));
		((Control)label2).set_TabIndex(59);
		((Control)label2).set_Text("Call Of Duty Directory");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("SimSun", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(184, 53, 239));
		((Control)label1).set_Location(new Point(139, 29));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(23, 12));
		((Control)label1).set_TabIndex(60);
		((Control)label1).set_Text("[?]");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(10, 10, 10));
		((Form)this).set_ClientSize(new Size(335, 157));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)DirectoryCod);
		((Control)this).get_Controls().Add((Control)(object)siticoneButton7);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("CODSelect");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)CODSelect_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void label1_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Input Where Call Of Duty Is Installed\\n Example: C:\\Users\\YOURUSERNAME\\Documents\\Call of Duty Modern Warfare Just Input The Directory Where Its Installed", "Call Of Duty Cleaner");
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(((Control)this).get_Handle(), 19, new int[1] { 1 }, 4) != 0)
		{
			DwmSetWindowAttribute(((Control)this).get_Handle(), 20, new int[1] { 1 }, 4);
		}
	}

	private void siticoneButton7_Click(object sender, EventArgs e)
	{
		CallOfDutyCleaner.CodDirectory = ((Control)DirectoryCod).get_Text();
		((Form)this).Close();
	}

	private void DirectoryCod_TextChanged(object sender, EventArgs e)
	{
	}
}
