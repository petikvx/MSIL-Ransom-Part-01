using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QQCaptor;

public class FriendCuohao : Form
{
	public string m_sSlaveChuoHao = "";

	public bool m_bOK;

	private IContainer components;

	private Label label1;

	private TextBox textBoxChuoHao;

	private Button buttonOK;

	private Button buttonCancel;

	public FriendCuohao()
	{
		InitializeComponent();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		m_sSlaveChuoHao = ((Control)textBoxChuoHao).get_Text();
		((Form)this).Close();
		m_bOK = true;
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		m_bOK = false;
	}

	private void textBoxChuoHao_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			m_sSlaveChuoHao = ((Control)textBoxChuoHao).get_Text();
			((Form)this).Close();
			m_bOK = true;
		}
	}

	private void FriendCuohao_Load(object sender, EventArgs e)
	{
		((Control)textBoxChuoHao).set_Text(m_sSlaveChuoHao);
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
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		label1 = new Label();
		textBoxChuoHao = new TextBox();
		buttonOK = new Button();
		buttonCancel = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("宋体", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(23, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(122, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("给奴隶取个绰号吧：");
		((Control)textBoxChuoHao).set_Location(new Point(25, 51));
		((Control)textBoxChuoHao).set_Name("textBoxChuoHao");
		((Control)textBoxChuoHao).set_Size(new Size(237, 21));
		((Control)textBoxChuoHao).set_TabIndex(1);
		((Control)textBoxChuoHao).add_KeyDown(new KeyEventHandler(textBoxChuoHao_KeyDown));
		((Control)buttonOK).set_Location(new Point(54, 89));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(75, 23));
		((Control)buttonOK).set_TabIndex(2);
		((Control)buttonOK).set_Text("确定");
		((ButtonBase)buttonOK).set_UseVisualStyleBackColor(true);
		((Control)buttonOK).add_Click((EventHandler)buttonOK_Click);
		((Control)buttonCancel).set_Location(new Point(158, 89));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(75, 23));
		((Control)buttonCancel).set_TabIndex(3);
		((Control)buttonCancel).set_Text("取消");
		((ButtonBase)buttonCancel).set_UseVisualStyleBackColor(true);
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(287, 133));
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Control)this).get_Controls().Add((Control)(object)textBoxChuoHao);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("FriendCuohao");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("好友买卖");
		((Form)this).add_Load((EventHandler)FriendCuohao_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
