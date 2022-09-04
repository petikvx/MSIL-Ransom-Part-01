using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using n.My;

namespace n;

[DesignerGenerated]
public class chat : Form
{
	private IContainer components;

	[AccessedThroughProperty("T2")]
	private TextBox _T2;

	[AccessedThroughProperty("B1")]
	private Button _B1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("T1")]
	private RichTextBox _T1;

	public static bool clos;

	public string nick;

	internal virtual TextBox T2
	{
		get
		{
			return _T2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = T2_TextChanged;
			KeyPressEventHandler val = new KeyPressEventHandler(T2_KeyPress);
			if (_T2 != null)
			{
				((Control)_T2).remove_TextChanged(eventHandler);
				((Control)_T2).remove_KeyPress(val);
			}
			_T2 = value;
			if (_T2 != null)
			{
				((Control)_T2).add_TextChanged(eventHandler);
				((Control)_T2).add_KeyPress(val);
			}
		}
	}

	internal virtual Button B1
	{
		get
		{
			return _B1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = B1_Click;
			if (_B1 != null)
			{
				((Control)_B1).remove_Click(eventHandler);
			}
			_B1 = value;
			if (_B1 != null)
			{
				((Control)_B1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual RichTextBox T1
	{
		get
		{
			return _T1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = T1_TextChanged;
			if (_T1 != null)
			{
				((Control)_T1).remove_TextChanged(eventHandler);
			}
			_T1 = value;
			if (_T1 != null)
			{
				((Control)_T1).add_TextChanged(eventHandler);
			}
		}
	}

	public chat()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((Form)this).add_MaximizedBoundsChanged((EventHandler)chat_MaximizedBoundsChanged);
		((Control)this).add_SizeChanged((EventHandler)chat_SizeChanged);
		((Form)this).add_Load((EventHandler)chat_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(chat_FormClosing));
		((Control)this).add_Resize((EventHandler)chat_Resize);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		components = new Container();
		T2 = new TextBox();
		B1 = new Button();
		Timer1 = new Timer(components);
		T1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((TextBoxBase)T2).set_BackColor(SystemColors.WindowText);
		((TextBoxBase)T2).set_ForeColor(SystemColors.InactiveCaption);
		TextBox t = T2;
		Point location = new Point(12, 364);
		((Control)t).set_Location(location);
		((Control)T2).set_Name("T2");
		TextBox t2 = T2;
		Size size = new Size(450, 20);
		((Control)t2).set_Size(size);
		((Control)T2).set_TabIndex(2);
		((ButtonBase)B1).set_FlatStyle((FlatStyle)0);
		Button b = B1;
		location = new Point(468, 364);
		((Control)b).set_Location(location);
		((Control)B1).set_Name("B1");
		Button b2 = B1;
		size = new Size(133, 23);
		((Control)b2).set_Size(size);
		((Control)B1).set_TabIndex(3);
		((ButtonBase)B1).set_Text("Send");
		((ButtonBase)B1).set_UseVisualStyleBackColor(true);
		Timer1.set_Enabled(true);
		((TextBoxBase)T1).set_BackColor(SystemColors.WindowText);
		T1.set_ForeColor(SystemColors.InactiveCaption);
		RichTextBox t3 = T1;
		location = new Point(12, 12);
		((Control)t3).set_Location(location);
		((Control)T1).set_Name("T1");
		((TextBoxBase)T1).set_ReadOnly(true);
		RichTextBox t4 = T1;
		size = new Size(450, 346);
		((Control)t4).set_Size(size);
		((Control)T1).set_TabIndex(4);
		T1.set_Text("");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(413, 233);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)T1);
		((Control)this).get_Controls().Add((Control)(object)B1);
		((Control)this).get_Controls().Add((Control)(object)T2);
		((Control)this).set_Name("chat");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("chat");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void chat_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!clos)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void chat_Resize(object sender, EventArgs e)
	{
		fx();
	}

	private void chat_MaximizedBoundsChanged(object sender, EventArgs e)
	{
		fx();
	}

	public void fx()
	{
		try
		{
			((Control)T1).set_Width(((Control)this).get_Width() - 40);
			((Control)T2).set_Width(((Control)B1).get_Left() - 20);
			((Control)T2).set_Top(((Control)this).get_Height() - ((Control)T2).get_Height() - 50);
			((Control)T1).set_Height(((Control)T2).get_Top() - 20);
			((Control)B1).set_Left(((Control)T1).get_Width() - ((Control)B1).get_Width() + 12);
			((Control)B1).set_Top(((Control)T2).get_Top() - 3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void T2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 13)
		{
			return;
		}
		try
		{
			if (T2.get_Text().Length > 0)
			{
				B b = MyProject.Forms.B;
				string y = IND.Y;
				TextBox t = T2;
				string s = t.get_Text();
				string text = API.ENB(ref s);
				t.set_Text(s);
				string T = "#21" + y + text;
				b.SEND(ref T);
				RichTextBox t2 = T1;
				t2.set_Text(t2.get_Text() + "Me : " + T2.get_Text() + "\r\n");
				T2.set_Text("");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void chat_SizeChanged(object sender, EventArgs e)
	{
		fx();
	}

	private void chat_Load(object sender, EventArgs e)
	{
		try
		{
			B b = MyProject.Forms.B;
			string T = "#20";
			b.SEND(ref T);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).set_TopMost(true);
		((Control)this).Show();
	}

	private void B1_Click(object sender, EventArgs e)
	{
		try
		{
			if (T2.get_Text().Length > 0)
			{
				B b = MyProject.Forms.B;
				string y = IND.Y;
				TextBox t = T2;
				string s = t.get_Text();
				string text = API.ENB(ref s);
				t.set_Text(s);
				string T = "#21" + y + text;
				b.SEND(ref T);
				RichTextBox t2 = T1;
				t2.set_Text(t2.get_Text() + "Me : " + T2.get_Text() + "\r\n");
				T2.set_Text("");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void T2_TextChanged(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (clos)
		{
			((Form)this).Close();
		}
	}

	private void T1_TextChanged(object sender, EventArgs e)
	{
		try
		{
			((TextBoxBase)T1).set_SelectionStart(T1.get_Text().Length - 1);
			((TextBoxBase)T1).ScrollToCaret();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
