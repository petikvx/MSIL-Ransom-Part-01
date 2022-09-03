using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AQW_Level_bot;

[DesignerGenerated]
public class Clicking : Form
{
	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	private int time;

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

	public Clicking()
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		ListBox1 = new ListBox();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.get_Items().AddRange(new object[13]
		{
			"http://adf.ly/8DkRo", "http://adf.ly/13jzS ", "http://adf.ly/1icWR ", "http://adf.ly/8Mts6 ", "http://adf.ly/8Mfob ", "http://adf.ly/COxnD ", "http://adf.ly/COxvI ", "http://adf.ly/COxwg ", "http://adf.ly/COxxl ", "http://adf.ly/COxzD ",
			"http://adf.ly/COy0J ", "http://adf.ly/COy1X", "http://adf.ly/COy2r  "
		});
		ListBox listBox = ListBox1;
		Point location = new Point(12, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(260, 238);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("Clicking");
		((Form)this).set_Text("Clicking");
		((Control)this).ResumeLayout(false);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			time++;
			if (time == 1)
			{
				Type typeFromHandle = typeof(WebRequest);
				object[] array = new object[1];
				ListBox listBox = ListBox1;
				array[0] = RuntimeHelpers.GetObjectValue(listBox.get_SelectedItem());
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Create", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					listBox.set_SelectedItem(RuntimeHelpers.GetObjectValue(array2[0]));
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)obj;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				streamReader.ReadToEnd();
			}
			if (time == 20)
			{
				try
				{
					ListBox1.set_SelectedIndex(ListBox1.get_SelectedIndex() + 1);
					time = 0;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ListBox1.set_SelectedIndex(0);
					time = 0;
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
