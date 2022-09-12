using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Lt35;
using Microsoft.VisualBasic.CompilerServices;
using x5NZ;

namespace z1F4;

[DesignerGenerated]
public class Se8q : Form
{
	private IContainer components;

	private Button _Button1;

	private Button _Button3;

	private Button _Button4;

	private PictureBox _PictureBox1;

	internal Label K;

	internal Label m;

	internal Label A;

	internal Button E;

	internal GroupBox I;

	internal Label D;

	internal Splitter o;

	public Se8q()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Fy18));
		((Form)this).add_Load((EventHandler)Yc6w);
		x2QJ();
	}

	protected override void s4Q2(bool c9RN)
	{
		try
		{
			if (c9RN && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c9RN);
		}
	}

	private void x2QJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		Fx0g(new Label());
		a8D9(new Label());
		Rr0s(new Label());
		Ap0m(new Button());
		Xz3g(new Button());
		Pz9g(new Button());
		Wj0x(new Button());
		b0N5(new GroupBox());
		g2BR(new Label());
		z7JC(new Splitter());
		Pj1m(new PictureBox());
		((Control)Bp14()).SuspendLayout();
		((ISupportInitialize)n6JL()).BeginInit();
		((Control)this).SuspendLayout();
		o1PH().set_AutoSize(true);
		((Control)o1PH()).set_Location(new Point(6, 27));
		((Control)o1PH()).set_Name("Label1");
		((Control)o1PH()).set_Size(new Size(72, 13));
		((Control)o1PH()).set_TabIndex(0);
		o1PH().set_Text("Books Details");
		Fw6z().set_AutoSize(true);
		((Control)Fw6z()).set_Location(new Point(6, 76));
		((Control)Fw6z()).set_Name("Label2");
		((Control)Fw6z()).set_Size(new Size(93, 13));
		((Control)Fw6z()).set_TabIndex(1);
		Fw6z().set_Text("Change Password");
		Tz8g().set_AutoSize(true);
		((Control)Tz8g()).set_Location(new Point(6, 125));
		((Control)Tz8g()).set_Name("Label3");
		((Control)Tz8g()).set_Size(new Size(79, 13));
		((Control)Tz8g()).set_TabIndex(3);
		Tz8g().set_Text("Student Details");
		((Control)c3R7()).set_Location(new Point(147, 71));
		((Control)c3R7()).set_Name("Button1");
		((Control)c3R7()).set_Size(new Size(154, 23));
		((Control)c3R7()).set_TabIndex(4);
		((ButtonBase)c3R7()).set_Text("Change Password");
		((ButtonBase)c3R7()).set_UseVisualStyleBackColor(true);
		((Control)Bt0e()).set_Location(new Point(147, 120));
		((Control)Bt0e()).set_Name("Button2");
		((Control)Bt0e()).set_Size(new Size(154, 23));
		((Control)Bt0e()).set_TabIndex(5);
		((ButtonBase)Bt0e()).set_Text("Student Tables");
		((ButtonBase)Bt0e()).set_UseVisualStyleBackColor(true);
		((Control)Xs38()).set_Location(new Point(147, 22));
		((Control)Xs38()).set_Name("Button3");
		((Control)Xs38()).set_Size(new Size(154, 23));
		((Control)Xs38()).set_TabIndex(6);
		((ButtonBase)Xs38()).set_Text("Add Update Delete Books");
		((ButtonBase)Xs38()).set_UseVisualStyleBackColor(true);
		((Control)Sw62()).set_Location(new Point(147, 168));
		((Control)Sw62()).set_Name("Button4");
		((Control)Sw62()).set_Size(new Size(154, 23));
		((Control)Sw62()).set_TabIndex(7);
		((ButtonBase)Sw62()).set_Text("Staff Tables");
		((ButtonBase)Sw62()).set_UseVisualStyleBackColor(true);
		((Control)Bp14()).get_Controls().Add((Control)(object)So97());
		((Control)Bp14()).get_Controls().Add((Control)(object)o1PH());
		((Control)Bp14()).get_Controls().Add((Control)(object)Xs38());
		((Control)Bp14()).get_Controls().Add((Control)(object)Fw6z());
		((Control)Bp14()).get_Controls().Add((Control)(object)c3R7());
		((Control)Bp14()).get_Controls().Add((Control)(object)Sw62());
		((Control)Bp14()).get_Controls().Add((Control)(object)Tz8g());
		((Control)Bp14()).get_Controls().Add((Control)(object)Bt0e());
		((Control)Bp14()).set_Location(new Point(236, 12));
		((Control)Bp14()).set_Name("GroupBox1");
		((Control)Bp14()).set_Size(new Size(329, 219));
		((Control)Bp14()).set_TabIndex(12);
		Bp14().set_TabStop(false);
		So97().set_AutoSize(true);
		((Control)So97()).set_Location(new Point(6, 173));
		((Control)So97()).set_Name("Label4");
		((Control)So97()).set_Size(new Size(84, 13));
		((Control)So97()).set_TabIndex(7);
		So97().set_Text("Leacture Details");
		((Control)Ng83()).set_Location(new Point(0, 0));
		((Control)Ng83()).set_Name("Splitter1");
		((Control)Ng83()).set_Size(new Size(230, 248));
		((Control)Ng83()).set_TabIndex(13);
		Ng83().set_TabStop(false);
		((Control)n6JL()).set_Location(new Point(13, 12));
		((Control)n6JL()).set_Name("PictureBox1");
		((Control)n6JL()).set_Size(new Size(204, 219));
		n6JL().set_SizeMode((PictureBoxSizeMode)1);
		n6JL().set_TabIndex(14);
		n6JL().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(577, 248));
		((Control)this).get_Controls().Add((Control)(object)n6JL());
		((Control)this).get_Controls().Add((Control)(object)Ng83());
		((Control)this).get_Controls().Add((Control)(object)Bp14());
		((Control)this).set_Name("Form5");
		((Form)this).set_Text("Admin Control Form");
		((Control)Bp14()).ResumeLayout(false);
		((Control)Bp14()).PerformLayout();
		((ISupportInitialize)n6JL()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Label o1PH()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx0g(Label Np6w)
	{
		Label val = (K = Np6w);
	}

	[SpecialName]
	internal virtual Label Fw6z()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8D9(Label Hd13)
	{
		Label val = (m = Hd13);
	}

	[SpecialName]
	internal virtual Label Tz8g()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rr0s(Label Md72)
	{
		Label val = (A = Md72);
	}

	[SpecialName]
	internal virtual Button c3R7()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap0m(Button Zj9a)
	{
		EventHandler eventHandler = Zb5q;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Zj9a;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Bt0e()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz3g(Button q8ZF)
	{
		EventHandler eventHandler = y1JM;
		Button e = E;
		if (e != null)
		{
			((Control)e).remove_Click(eventHandler);
		}
		Button val = (E = q8ZF);
		e = E;
		if (e != null)
		{
			((Control)e).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Xs38()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pz9g(Button Ke3f)
	{
		EventHandler eventHandler = z5CN;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = Ke3f;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Sw62()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj0x(Button p0JG)
	{
		EventHandler eventHandler = x9B1;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = p0JG;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Bp14()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0N5(GroupBox Hd6a)
	{
		GroupBox val = (I = Hd6a);
	}

	[SpecialName]
	internal virtual Label So97()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2BR(Label Aj5f)
	{
		Label val = (D = Aj5f);
	}

	[SpecialName]
	internal virtual Splitter Ng83()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7JC(Splitter e4X6)
	{
		Splitter val = (o = e4X6);
	}

	[SpecialName]
	internal virtual PictureBox n6JL()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pj1m(PictureBox q9GY)
	{
		_PictureBox1 = q9GY;
	}

	private void z5CN(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.r8G3()).Show();
		((Control)this).Hide();
	}

	private void Fy18(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Ad5o()).Show();
	}

	private void Yc6w(object sender, EventArgs e)
	{
	}

	private void Zb5q(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Dz1i()).Show();
	}

	private void y1JM(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Lf03()).Show();
	}

	private void x9B1(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Sp72()).Show();
	}

	internal static void Rc49()
	{
		string[] yz = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Zz9s.Lf5(yz, 0, 3);
		string value2 = Zz9s.Lf5(yz, 4, 7);
		Mj02.mDic.Add(Mj02.tName, value);
		Mj02.mDic.Add(Mj02.mName, value2);
	}
}
