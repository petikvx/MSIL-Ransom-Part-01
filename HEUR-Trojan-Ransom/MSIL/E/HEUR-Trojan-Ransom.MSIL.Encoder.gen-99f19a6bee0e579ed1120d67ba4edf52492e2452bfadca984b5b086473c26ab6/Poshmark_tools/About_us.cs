using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace Poshmark_tools;

public class About_us : UserControl
{
	private IContainer components = null;

	public MetroTextBox Aboutus_metroTextBox1;

	private TextBox textBox1;

	public About_us()
	{
		InitializeComponent();
		((Control)Aboutus_metroTextBox1).set_Text("Poshmark Pro Tools is an easy and highly effective Poshmark Windows App which is proven to generate sales, followers and exposure.\r\n\r\nSelling this app without the permission of owner is prohibitted, if found the licence will be cancelled.\r\n\r\nVisit our Website for latest Updates:  http://poshmarktools.com/");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(About_us));
		Aboutus_metroTextBox1 = new MetroTextBox();
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)Aboutus_metroTextBox1).set_Dock((DockStyle)5);
		Aboutus_metroTextBox1.FontSize = MetroTextBoxSize.Medium;
		((Control)Aboutus_metroTextBox1).set_Location(new Point(0, 0));
		Aboutus_metroTextBox1.Multiline = true;
		((Control)Aboutus_metroTextBox1).set_Name("Aboutus_metroTextBox1");
		Aboutus_metroTextBox1.ReadOnly = true;
		((Control)Aboutus_metroTextBox1).set_Size(new Size(379, 314));
		Aboutus_metroTextBox1.Style = MetroColorStyle.Brown;
		((Control)Aboutus_metroTextBox1).set_TabIndex(0);
		((Control)Aboutus_metroTextBox1).set_Text(componentResourceManager.GetString("Aboutus_metroTextBox1.Text"));
		Aboutus_metroTextBox1.UseStyleColors = true;
		((Control)textBox1).set_BackColor(SystemColors.Control);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(3, 180));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(328, 19));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("Email us: support@poshmarktools.com");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)Aboutus_metroTextBox1);
		((Control)this).set_Name("About_us");
		((Control)this).set_Size(new Size(379, 314));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
