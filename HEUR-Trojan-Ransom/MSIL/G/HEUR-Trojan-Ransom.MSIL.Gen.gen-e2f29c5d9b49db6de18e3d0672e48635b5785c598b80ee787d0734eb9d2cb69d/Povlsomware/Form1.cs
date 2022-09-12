using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Povlsomware;

public class Form1 : Form
{
	private IContainer icontainer_0;

	private ListBox listBox_0;

	private Label label_0;

	public Form1()
	{
		method_0();
		((Control)label_0).set_Text(Class0.count + Class5.string_0);
		ObjectCollection items = listBox_0.get_Items();
		object[] array = Class0.encryptedFiles.ToArray();
		items.AddRange(array);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		listBox_0 = new ListBox();
		label_0 = new Label();
		((Control)this).SuspendLayout();
		((Control)listBox_0).set_BackColor(Color.Maroon);
		((Control)listBox_0).set_Font(new Font(Class5.string_1, Class5.float_0, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)listBox_0).set_ForeColor(Color.Black);
		((ListControl)listBox_0).set_FormattingEnabled(true);
		listBox_0.set_HorizontalScrollbar(true);
		((Control)listBox_0).set_Location(new Point(Class5.sbyte_0, Class5.sbyte_1));
		((Control)listBox_0).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listBox_0).set_Name(Class5.string_2);
		((Control)listBox_0).set_Size(new Size(Class5.int_0, Class5.int_1));
		((Control)listBox_0).set_TabIndex(5);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Class5.string_3, Class5.float_1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(Class5.a, Class5.b));
		((Control)label_0).set_Name(Class5.c);
		((Control)label_0).set_Size(new Size(Class5.d, Class5.e));
		((Control)label_0).set_TabIndex(6);
		((Control)label_0).set_Text(Class5.f);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(Class5.g, Class5.h));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(Class5.i, Class5.j));
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Class5.k);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Class5.l);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
