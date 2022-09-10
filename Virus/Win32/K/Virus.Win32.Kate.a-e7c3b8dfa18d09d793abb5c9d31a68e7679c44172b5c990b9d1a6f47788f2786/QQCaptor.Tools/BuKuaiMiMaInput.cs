using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QQCaptor.Tools;

public class BuKuaiMiMaInput : Form
{
	public bool m_bOK;

	public string m_sBuKuaiPass = "";

	public string m_sPass = "";

	private SymmetricMethod sm = new SymmetricMethod();

	private IContainer components;

	private TextBox textNewPass;

	private Label label1;

	private Button button_0;

	public BuKuaiMiMaInput()
	{
		InitializeComponent();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		m_sPass = ((Control)textNewPass).get_Text();
		if (m_sPass == string.Empty)
		{
			MessageBox.Show("请输入密码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textNewPass).Select();
		}
		else if (m_sPass == m_sBuKuaiPass)
		{
			m_bOK = true;
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("密码输入错误", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void textNewPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			button_0_Click(null, null);
		}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		textNewPass = new TextBox();
		label1 = new Label();
		button_0 = new Button();
		((Control)this).SuspendLayout();
		((Control)textNewPass).set_Location(new Point(36, 36));
		((Control)textNewPass).set_Name("textNewPass");
		textNewPass.set_PasswordChar('*');
		((Control)textNewPass).set_Size(new Size(166, 21));
		((Control)textNewPass).set_TabIndex(7);
		((Control)textNewPass).add_KeyDown(new KeyEventHandler(textNewPass_KeyDown));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(36, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(41, 12));
		((Control)label1).set_TabIndex(8);
		((Control)label1).set_Text("密码：");
		((Control)button_0).set_Location(new Point(82, 73));
		((Control)button_0).set_Name("button确定");
		((Control)button_0).set_Size(new Size(75, 23));
		((Control)button_0).set_TabIndex(10);
		((Control)button_0).set_Text("确定");
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(238, 113));
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)textNewPass);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("BuKuaiMiMaInput");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("密码验证");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
