using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QQCaptor.Tools;

public class BuKuaiMiMaAdd : Form
{
	public bool m_bOK;

	public string m_sBuKuaiPass = "";

	public string m_sOldPass = "";

	public string m_sNewPass = "";

	private SymmetricMethod sm = new SymmetricMethod();

	private IContainer components;

	private TextBox textOldPass;

	private Label label2;

	private TextBox textNewPass;

	private Label label1;

	private Label label3;

	private Button button_0;

	public BuKuaiMiMaAdd()
	{
		InitializeComponent();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		m_sOldPass = ((Control)textOldPass).get_Text();
		m_sNewPass = ((Control)textNewPass).get_Text();
		if (m_sOldPass == string.Empty)
		{
			MessageBox.Show("请输入旧密码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textOldPass).Select();
		}
		else if (m_sNewPass == string.Empty)
		{
			MessageBox.Show("请输入新密码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textNewPass).Select();
		}
		else if (m_sOldPass == m_sBuKuaiPass)
		{
			m_bOK = true;
			m_sBuKuaiPass = m_sNewPass;
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("旧密码输入错误", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void textNewPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			button_0_Click(null, null);
		}
	}

	private void textOldPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			((Control)textNewPass).Select();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		textOldPass = new TextBox();
		label2 = new Label();
		textNewPass = new TextBox();
		label1 = new Label();
		label3 = new Label();
		button_0 = new Button();
		((Control)this).SuspendLayout();
		((Control)textOldPass).set_Location(new Point(38, 66));
		((Control)textOldPass).set_Name("textOldPass");
		textOldPass.set_PasswordChar('*');
		((Control)textOldPass).set_Size(new Size(166, 21));
		((Control)textOldPass).set_TabIndex(5);
		((Control)textOldPass).add_KeyDown(new KeyEventHandler(textOldPass_KeyDown));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label2).set_ForeColor(Color.Blue);
		((Control)label2).set_Location(new Point(36, 46));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 12));
		((Control)label2).set_TabIndex(6);
		((Control)label2).set_Text("旧密码：");
		((Control)textNewPass).set_Location(new Point(38, 115));
		((Control)textNewPass).set_Name("textNewPass");
		textNewPass.set_PasswordChar('*');
		((Control)textNewPass).set_Size(new Size(166, 21));
		((Control)textNewPass).set_TabIndex(7);
		((Control)textNewPass).add_KeyDown(new KeyEventHandler(textNewPass_KeyDown));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(38, 95));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(53, 12));
		((Control)label1).set_TabIndex(8);
		((Control)label1).set_Text("新密码：");
		((Control)label3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label3).set_ForeColor(Color.Blue);
		((Control)label3).set_Location(new Point(12, 9));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(214, 29));
		((Control)label3).set_TabIndex(9);
		((Control)label3).set_Text("为了你的账号安全，请设置捕快密码，第一次设置旧密码默认为8888");
		((Control)button_0).set_Location(new Point(82, 152));
		((Control)button_0).set_Name("button确定");
		((Control)button_0).set_Size(new Size(75, 23));
		((Control)button_0).set_TabIndex(10);
		((Control)button_0).set_Text("确定");
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(238, 187));
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textNewPass);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textOldPass);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Name("BuKuaiMiMaAdd");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("捕快密码设置");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
