using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QQCaptor;

public class Config : Form
{
	private IContainer components;

	private CheckBox checkZuiXiaoHua;

	private CheckBox checkBoxShowAllFriendTime;

	private Button buttonCancel;

	private Button buttonOK;

	private Label label1;

	private Label label2;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Label label3;

	public bool m_bCancel = true;

	public bool m_bShowAllTime;

	public string m_sTieTiaoLiuYan = "yxz123.com";

	public string m_sSlaveChuoHao = "yxz123.com";

	public bool m_bOK;

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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		checkZuiXiaoHua = new CheckBox();
		checkBoxShowAllFriendTime = new CheckBox();
		buttonCancel = new Button();
		buttonOK = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)checkZuiXiaoHua).set_AutoSize(true);
		((Control)checkZuiXiaoHua).set_ForeColor(Color.Blue);
		((Control)checkZuiXiaoHua).set_Location(new Point(28, 23));
		((Control)checkZuiXiaoHua).set_Name("checkZuiXiaoHua");
		((Control)checkZuiXiaoHua).set_Size(new Size(168, 16));
		((Control)checkZuiXiaoHua).set_TabIndex(5);
		((Control)checkZuiXiaoHua).set_Text("点击关闭的时候程序最小化");
		((ButtonBase)checkZuiXiaoHua).set_UseVisualStyleBackColor(true);
		((Control)checkBoxShowAllFriendTime).set_ForeColor(Color.Blue);
		((Control)checkBoxShowAllFriendTime).set_Location(new Point(28, 47));
		((Control)checkBoxShowAllFriendTime).set_Name("checkBoxShowAllFriendTime");
		((Control)checkBoxShowAllFriendTime).set_Size(new Size(312, 30));
		((Control)checkBoxShowAllFriendTime).set_TabIndex(6);
		((Control)checkBoxShowAllFriendTime).set_Text("[抢车位]显示空位数和爱心车位颜色和最近登录时间，占用时间比较久");
		((ButtonBase)checkBoxShowAllFriendTime).set_UseVisualStyleBackColor(true);
		((Control)buttonCancel).set_Location(new Point(194, 182));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(77, 33));
		((Control)buttonCancel).set_TabIndex(8);
		((Control)buttonCancel).set_Text("取消");
		((ButtonBase)buttonCancel).set_UseVisualStyleBackColor(true);
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		((Control)buttonOK).set_Location(new Point(97, 182));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(77, 33));
		((Control)buttonOK).set_TabIndex(7);
		((Control)buttonOK).set_Text("确定");
		((ButtonBase)buttonOK).set_UseVisualStyleBackColor(true);
		((Control)buttonOK).add_Click((EventHandler)buttonOK_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(26, 89));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(161, 12));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("老板键默认为：ALT + 空格键");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(26, 121));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(89, 12));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("默认贴条留言：");
		((Control)textBox_0).set_Location(new Point(121, 118));
		((Control)textBox_0).set_Name("textBox默认贴条留言");
		((Control)textBox_0).set_Size(new Size(212, 21));
		((Control)textBox_0).set_TabIndex(11);
		((Control)textBox_1).set_Location(new Point(121, 145));
		((Control)textBox_1).set_Name("textBox默认奴隶绰号");
		((Control)textBox_1).set_Size(new Size(212, 21));
		((Control)textBox_1).set_TabIndex(13);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(26, 148));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(89, 12));
		((Control)label3).set_TabIndex(12);
		((Control)label3).set_Text("默认奴隶绰号：");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(367, 236));
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Control)this).get_Controls().Add((Control)(object)checkBoxShowAllFriendTime);
		((Control)this).get_Controls().Add((Control)(object)checkZuiXiaoHua);
		((Control)this).set_Name("Config");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("系统配置");
		((Form)this).add_Load((EventHandler)Config_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Config()
	{
		InitializeComponent();
	}

	private void Config_Load(object sender, EventArgs e)
	{
		checkZuiXiaoHua.set_Checked(m_bCancel);
		checkBoxShowAllFriendTime.set_Checked(m_bShowAllTime);
		((Control)textBox_0).set_Text(m_sTieTiaoLiuYan);
		((Control)textBox_1).set_Text(m_sSlaveChuoHao);
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		m_bOK = true;
		m_bCancel = checkZuiXiaoHua.get_Checked();
		m_bShowAllTime = checkBoxShowAllFriendTime.get_Checked();
		m_sTieTiaoLiuYan = ((Control)textBox_0).get_Text();
		m_sSlaveChuoHao = ((Control)textBox_1).get_Text();
		((Form)this).Close();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
