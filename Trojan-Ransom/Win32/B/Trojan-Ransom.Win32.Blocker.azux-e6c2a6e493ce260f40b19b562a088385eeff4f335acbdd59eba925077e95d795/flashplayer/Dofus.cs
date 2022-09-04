using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using flashplayer.My.Resources;

namespace flashplayer;

[DesignerGenerated]
public class Dofus : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
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

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Dofus()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void vmethod_0(bool bool_0)
	{
		try
		{
			if (bool_0 && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_0);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dofus));
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		Button1 = new Button();
		PictureBox1 = new PictureBox();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(121, 22);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(49, 52);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ERROR:\r\nsqsqsq\r\n\r\nQsqsqsq");
		((Control)GroupBox1).set_BackColor(SystemColors.HighlightText);
		((Control)GroupBox1).set_BackgroundImageLayout((ImageLayout)0);
		((Control)GroupBox1).set_CausesValidation(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		GroupBox1.set_FlatStyle((FlatStyle)3);
		GroupBox groupBox = GroupBox1;
		location = new Point(-50, 118);
		((Control)groupBox).set_Location(location);
		GroupBox groupBox2 = GroupBox1;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(0);
		((Control)groupBox2).set_Margin(val);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox3 = GroupBox1;
		((Padding)(ref val))._002Ector(0);
		((Control)groupBox3).set_Padding(val);
		GroupBox groupBox4 = GroupBox1;
		size = new Size(617, 149);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox1).set_TabIndex(1);
		GroupBox1.set_TabStop(false);
		Button button = Button1;
		location = new Point(330, 13);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("OK");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		PictureBox1.set_Image((Image)(object)Resources.Bitmap_0);
		PictureBox pictureBox = PictureBox1;
		location = new Point(20, 17);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(82, 78);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(376, 161);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Dofus");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("Dofus");
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
