using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class wd : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private bool donot;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual Button Button1
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

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public wd()
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		ListBox1 = new ListBox();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(12, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(260, 199);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		Button button = Button1;
		location = new Point(154, 217);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(118, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Withdraw");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(12, 219);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(136, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		TextBox1.set_Text("$0.00");
		Button button3 = Button2;
		location = new Point(12, 243);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(260, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Get withdraw options");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 276);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("wd");
		((Form)this).set_Text("ShiftCode - Withdraw");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string getWithdrawAmount()
	{
		string text = TextBox1.get_Text();
		try
		{
			string result = text.Replace("$", "");
			string text2 = text.Split(new char[1] { '.' })[1];
			if (text2.Length < 2)
			{
				TextBox textBox = TextBox1;
				textBox.set_Text(textBox.get_Text() + "0");
				donot = true;
				return result;
			}
			if (text2.Length > 2)
			{
				TextBox1.set_Text(text.Substring(0, checked(text.Length - 1)));
				donot = true;
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "0.00";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (donot)
		{
			donot = false;
			return;
		}
		try
		{
			int num = ((TextBoxBase)TextBox1).get_SelectionStart();
			TextBox1.set_Text("$" + getWithdrawAmount().ToString());
			if (num == 0)
			{
				num = 1;
			}
			((TextBoxBase)TextBox1).set_SelectionStart(num);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!MyProject.Forms.aio.autocontrolled)
			{
				Interaction.MsgBox((object)("Unable to make $ output error log:\r\n" + ex2.ToString()), (MsgBoxStyle)0, (object)null);
			}
			ProjectData.ClearProjectError();
		}
	}

	public object getWithdrawOptions(bool str = false)
	{
		string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/members/withdraw.php", ""));
		string text2 = text;
		string value = "action=\"withdraw.php?";
		List<string> list = new List<string>();
		while (text2.Contains(value))
		{
			text2 = text2.Remove(0, text2.IndexOf(value));
			text2 = text2.Remove(0, checked(text2.IndexOf("title=") + 7));
			string[] array = text2.Split(new char[1] { '"' });
			if (!list.Contains(array[0]))
			{
				list.Add(array[0]);
			}
		}
		if (str)
		{
			string text3 = list[0];
			bool flag = true;
			{
				foreach (string item in list)
				{
					if (!flag)
					{
						text3 = text3 + "|" + item;
					}
					else
					{
						flag = false;
					}
				}
				return text3;
			}
		}
		return list;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		List<string> list = (List<string>)getWithdrawOptions();
		foreach (string item in list)
		{
			ListBox1.get_Items().Add((object)item);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox(Operators.AddObject(Operators.AddObject((object)string.Concat("Withdrawing " + getWithdrawAmount().ToString(), " through "), ListBox1.get_SelectedItem()), (object)"."), (MsgBoxStyle)0, (object)null);
	}
}
