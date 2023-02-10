using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace f5LX;

[DesignerGenerated]
public class k9EH : UserControl
{
	private IContainer components;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("button3")]
	private virtual Button button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("avatar")]
	private virtual Button avatar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	private virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	private virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public k9EH()
	{
		Xs4g();
	}

	[DebuggerNonUserCode]
	protected override void Hx9y(bool j0HZ)
	{
		try
		{
			if (j0HZ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(j0HZ);
		}
	}

	[DebuggerStepThrough]
	private void Xs4g()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		Label1 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		button3 = new Button();
		avatar = new Button();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(52, 161));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(90, 19));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Contact Us");
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((Control)Button1).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(97, 191));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(45, 25));
		((Control)Button1).set_TabIndex(15);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.Transparent);
		((Control)Button2).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(132, 192));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(45, 25));
		((Control)Button2).set_TabIndex(14);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)button3).set_BackColor(Color.Transparent);
		((Control)button3).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Location(new Point(26, 192));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(45, 25));
		((Control)button3).set_TabIndex(13);
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)avatar).set_BackColor(Color.Transparent);
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(61, 192));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(12);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox1).set_Location(new Point(14, 19));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(168, 125));
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)avatar);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("ProfileController");
		((Control)this).set_Size(new Size(204, 235));
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
