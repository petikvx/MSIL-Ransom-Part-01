using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class ct : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("ListBox3")]
	private ListBox _ListBox3;

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

	internal virtual ListBox ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual ListBox ListBox3
	{
		get
		{
			return _ListBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox3 = value;
		}
	}

	public ct()
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
		Button2 = new Button();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		ListBox3 = new ListBox();
		((Control)this).SuspendLayout();
		Button button = Button2;
		Point location = new Point(12, 387);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		Size size = new Size(313, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(7);
		((ButtonBase)Button2).set_Text("Get contests");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(12, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(313, 121);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(4);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		ListBox listBox3 = ListBox2;
		location = new Point(12, 136);
		((Control)listBox3).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox4 = ListBox2;
		size = new Size(313, 121);
		((Control)listBox4).set_Size(size);
		((Control)ListBox2).set_TabIndex(4);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		ListBox listBox5 = ListBox3;
		location = new Point(12, 260);
		((Control)listBox5).set_Location(location);
		((Control)ListBox3).set_Name("ListBox3");
		ListBox listBox6 = ListBox3;
		size = new Size(313, 121);
		((Control)listBox6).set_Size(size);
		((Control)ListBox3).set_TabIndex(8);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(337, 417);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("ct");
		((Form)this).set_Text("Contests");
		((Control)this).ResumeLayout(false);
	}

	public object getJackpot(bool str = false)
	{
		string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/members/pts/jackpot/index.php", ""));
		string text2 = text;
		string value = "<div><b>";
		List<string> list = new List<string>();
		checked
		{
			while (text2.Contains(value))
			{
				text2 = text2.Remove(0, text2.IndexOf(value) + 8);
				string[] array = text2.Split(new char[1] { '<' });
				string text3 = array[0];
				text2 = text2.Remove(0, text2.IndexOf("$") + 1);
				array = text2.Split(new char[1] { '<' });
				list.Add(text3 + "|" + array[0]);
			}
			if (str)
			{
				string text4 = list[0];
				bool flag = true;
				{
					foreach (string item in list)
					{
						if (!flag)
						{
							text4 = text4 + "|" + item;
						}
						else
						{
							flag = false;
						}
					}
					return text4;
				}
			}
			return list;
		}
	}

	public object getContest(string type, bool str = false)
	{
		switch (type)
		{
		case "offer":
			type = "pts.php";
			break;
		case "referral":
			type = "ref.php";
			break;
		case "click":
			type = "ptc.php";
			break;
		}
		string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/contests/" + type, ""));
		string text2 = text;
		string value = "<td><b>";
		List<string> list = new List<string>();
		while (text2.Contains(value))
		{
			text2 = text2.Remove(0, checked(text2.IndexOf(value) + 7));
			string[] array = text2.Split(new char[1] { '<' });
			list.Add(array[0]);
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
		List<string> list = (List<string>)getContest("offer");
		List<string> list2 = (List<string>)getContest("referral");
		List<string> list3 = (List<string>)getContest("click");
		List<string> list4 = (List<string>)getJackpot();
		foreach (string item in list)
		{
			ListBox1.get_Items().Add((object)item);
		}
		foreach (string item2 in list2)
		{
			ListBox2.get_Items().Add((object)item2);
		}
		foreach (string item3 in list3)
		{
			ListBox3.get_Items().Add((object)item3);
		}
		foreach (string item4 in list4)
		{
			ListBox3.get_Items().Add((object)item4);
		}
	}
}
