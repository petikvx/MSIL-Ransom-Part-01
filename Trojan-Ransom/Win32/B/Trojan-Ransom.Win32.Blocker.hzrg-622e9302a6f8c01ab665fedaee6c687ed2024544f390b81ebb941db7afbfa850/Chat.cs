using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Chat : Form
{
	public delegate void GDelegate0(string string_0, string string_1);

	private IContainer icontainer_0;

	[AccessedThroughProperty("txtchat")]
	private TextBox _txtchat;

	[AccessedThroughProperty("send")]
	private Button _send;

	[AccessedThroughProperty("sendtext")]
	private TextBox _sendtext;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	public virtual TextBox txtchat
	{
		get
		{
			return _txtchat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtchat = value;
		}
	}

	public virtual Button send
	{
		get
		{
			return _send;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = send_Click;
			if (_send != null)
			{
				((Control)_send).remove_Click(eventHandler);
			}
			_send = value;
			if (_send != null)
			{
				((Control)_send).add_Click(eventHandler);
			}
		}
	}

	public virtual TextBox sendtext
	{
		get
		{
			return _sendtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_sendtext = value;
		}
	}

	public virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	public Chat()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		txtchat = new TextBox();
		send = new Button();
		sendtext = new TextBox();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((TextBoxBase)txtchat).set_BackColor(Color.White);
		TextBox obj = txtchat;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		txtchat.set_Multiline(true);
		((Control)txtchat).set_Name("txtchat");
		((TextBoxBase)txtchat).set_ReadOnly(true);
		txtchat.set_ScrollBars((ScrollBars)2);
		TextBox obj2 = txtchat;
		Size size = new Size(260, 212);
		((Control)obj2).set_Size(size);
		((Control)txtchat).set_TabIndex(0);
		Button obj3 = send;
		location = new Point(197, 255);
		((Control)obj3).set_Location(location);
		((Control)send).set_Name("send");
		Button obj4 = send;
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)send).set_TabIndex(1);
		((ButtonBase)send).set_Text("Send");
		((ButtonBase)send).set_UseVisualStyleBackColor(true);
		TextBox obj5 = sendtext;
		location = new Point(12, 232);
		((Control)obj5).set_Location(location);
		((Control)sendtext).set_Name("sendtext");
		TextBox obj6 = sendtext;
		size = new Size(260, 20);
		((Control)obj6).set_Size(size);
		((Control)sendtext).set_TabIndex(2);
		Button button = Button1;
		location = new Point(12, 255);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(284, 290);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)sendtext);
		((Control)this).get_Controls().Add((Control)(object)send);
		((Control)this).get_Controls().Add((Control)(object)txtchat);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Chat");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Chat");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void send_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(sendtext.get_Text().Trim(), "", false) != 0)
		{
			Class5.smethod_4("CHAT|" + sendtext.get_Text());
			TextBox val = txtchat;
			val.set_Text(val.get_Text() + "\r\nYou: " + sendtext.get_Text());
			sendtext.set_Text((string)null);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	public void method_0(string string_0, string string_1)
	{
		TextBox val = txtchat;
		val.set_Text(val.get_Text() + "\r\n" + string_0 + ": " + string_1);
		((TextBoxBase)txtchat).set_SelectionStart(txtchat.get_Text().Length);
		((TextBoxBase)txtchat).ScrollToCaret();
	}

	public void method_1(string string_0, string string_1)
	{
		((Control)this).Invoke((Delegate)new GDelegate0(method_0), new object[2] { string_0, string_1 });
	}
}
