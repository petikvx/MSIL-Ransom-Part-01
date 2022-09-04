using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using JEZA_IOJ.Hello;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace JEZA_IOJ;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	internal virtual _003F Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual _003F ComboBox1
	{
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ComboBox1_SelectedIndexChanged;
			if (_ComboBox1 != null)
			{
				_ComboBox1.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			if (_ComboBox1 != null)
			{
				_ComboBox1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual _003F CheckedListBox1
	{
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual _003F ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		Label1 = new Label();
		ComboBox1 = new ComboBox();
		CheckedListBox1 = new CheckedListBox();
		ProgressBar1 = new ProgressBar();
		((Control)this).SuspendLayout();
		((Label)Label1).set_AutoSize(true);
		object label = (object)Label1;
		Point location = new Point(92, 105);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		object label2 = (object)Label1;
		Size size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		((Label)Label1).set_Text("Label1");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		object comboBox = (object)ComboBox1;
		location = new Point(29, 54);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		object comboBox2 = (object)ComboBox1;
		size = new Size(214, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(1);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		object checkedListBox = (object)CheckedListBox1;
		location = new Point(55, 139);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		object checkedListBox2 = (object)CheckedListBox1;
		size = new Size(200, 94);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(2);
		object progressBar = (object)ProgressBar1;
		location = new Point(43, 25);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		object progressBar2 = (object)ProgressBar1;
		size = new Size(162, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(504, 273);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)ProgressBar1);
		((Control)this).get_Controls().Add((Control)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)ComboBox1);
		((Control)this).get_Controls().Add((Control)Label1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		DrWeb.AndESET();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"You don't have the permission to do that!", (MsgBoxStyle)0, (object)null);
	}

	static Nullable smethod_0()
	{
		//Discarded unreachable code: IL_0002
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xFB*/;
		}
	}
}
