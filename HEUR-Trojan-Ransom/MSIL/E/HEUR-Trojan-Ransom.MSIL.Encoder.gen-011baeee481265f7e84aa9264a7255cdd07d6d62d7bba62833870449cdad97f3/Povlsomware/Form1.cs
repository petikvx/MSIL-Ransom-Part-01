using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Povlsomware;

public class Form1 : Form
{
	private IContainer components_002D0;

	private ListBox listdata_002D1;

	private Label label2_002D2;

	public Form1()
	{
		InitializeComponent_002D0();
		((Control)label2_002D2).set_Text(Povlsomware_Program_002D2.count + _Constants_Generated_002D7.Field_0_002D0);
		ObjectCollection items = listdata_002D1.get_Items();
		object[] array = Povlsomware_Program_002D2.encryptedFiles.ToArray();
		items.AddRange(array);
	}

	protected override void Dispose(bool disposing_002D0)
	{
		if (disposing_002D0 && components_002D0 != null)
		{
			components_002D0.Dispose();
		}
		((Form)this).Dispose(disposing_002D0);
	}

	private void InitializeComponent_002D0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		listdata_002D1 = new ListBox();
		label2_002D2 = new Label();
		((Control)this).SuspendLayout();
		((Control)listdata_002D1).set_BackColor(Color.Maroon);
		((Control)listdata_002D1).set_Font(new Font(_Constants_Generated_002D7.Field_1_002D1, _Constants_Generated_002D7.Field_2_002D2, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)listdata_002D1).set_ForeColor(Color.Black);
		((ListControl)listdata_002D1).set_FormattingEnabled(true);
		listdata_002D1.set_HorizontalScrollbar(true);
		((Control)listdata_002D1).set_Location(new Point(0, _Constants_Generated_002D7.Field_3_002D3));
		((Control)listdata_002D1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listdata_002D1).set_Name(_Constants_Generated_002D7.Field_4_002D4);
		((Control)listdata_002D1).set_Size(new Size(_Constants_Generated_002D7.Field_5_002D5, _Constants_Generated_002D7.Field_6_002D6));
		((Control)listdata_002D1).set_TabIndex(6);
		((Control)label2_002D2).set_AutoSize(true);
		((Control)label2_002D2).set_Font(new Font(_Constants_Generated_002D7.Field_7_002D7, _Constants_Generated_002D7.Field_8_002D8, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2_002D2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2_002D2).set_Location(new Point(_Constants_Generated_002D7.Field_9_002D9, _Constants_Generated_002D7.Field_10_002Da));
		((Control)label2_002D2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2_002D2).set_Name(_Constants_Generated_002D7.Field_11_002Db);
		((Control)label2_002D2).set_Size(new Size(_Constants_Generated_002D7.Field_12_002Dc, _Constants_Generated_002D7.Field_13_002Dd));
		((Control)label2_002D2).set_TabIndex(7);
		((Control)label2_002D2).set_Text(_Constants_Generated_002D7.Field_14_002De);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(_Constants_Generated_002D7.Field_15_002Df, _Constants_Generated_002D7.Field_16_002Dg));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(_Constants_Generated_002D7.Field_17_002Dh, _Constants_Generated_002D7.Field_18_002Di));
		((Control)this).get_Controls().Add((Control)(object)label2_002D2);
		((Control)this).get_Controls().Add((Control)(object)listdata_002D1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(_Constants_Generated_002D7.Field_19_002Dj);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(_Constants_Generated_002D7.Field_20_002Dk);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
