using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Qd4;

namespace Eb8;

[DesignerGenerated]
public class k6N : Form
{
	private Label _Label1;

	private Label _Label2;

	private Label _Label3;

	private Label _Label4;

	internal IContainer a;

	internal TextBox c;

	internal TextBox T;

	internal TextBox n;

	internal TextBox S;

	public k6N()
	{
		y6Q();
	}

	protected override void Jc6(bool e2A)
	{
		try
		{
			if (e2A && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e2A);
		}
	}

	private void y6Q()
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
		t6N(new Label());
		Bx2(new TextBox());
		e6R(new Label());
		Wa9(new Label());
		Xr9(new Label());
		b6N(new TextBox());
		y7N(new TextBox());
		Rs1(new TextBox());
		((Control)this).SuspendLayout();
		j8G().set_AutoSize(true);
		((Control)j8G()).set_Location(new Point(12, 31));
		((Control)j8G()).set_Name("Label1");
		((Control)j8G()).set_Size(new Size(39, 13));
		((Control)j8G()).set_TabIndex(0);
		j8G().set_Text("Label1");
		((Control)Bg5()).set_Location(new Point(58, 31));
		((Control)Bg5()).set_Name("TextBox1");
		((Control)Bg5()).set_Size(new Size(193, 20));
		((Control)Bg5()).set_TabIndex(1);
		p5K().set_AutoSize(true);
		((Control)p5K()).set_Location(new Point(12, 75));
		((Control)p5K()).set_Name("Label2");
		((Control)p5K()).set_Size(new Size(39, 13));
		((Control)p5K()).set_TabIndex(2);
		p5K().set_Text("Label2");
		Ej7().set_AutoSize(true);
		((Control)Ej7()).set_Location(new Point(12, 119));
		((Control)Ej7()).set_Name("Label3");
		((Control)Ej7()).set_Size(new Size(39, 13));
		((Control)Ej7()).set_TabIndex(3);
		Ej7().set_Text("Label3");
		g4P().set_AutoSize(true);
		((Control)g4P()).set_Location(new Point(12, 162));
		((Control)g4P()).set_Name("Label4");
		((Control)g4P()).set_Size(new Size(39, 13));
		((Control)g4P()).set_TabIndex(4);
		g4P().set_Text("Label4");
		((Control)s2A()).set_Location(new Point(57, 72));
		((Control)s2A()).set_Name("TextBox2");
		((Control)s2A()).set_Size(new Size(193, 20));
		((Control)s2A()).set_TabIndex(5);
		((Control)a7P()).set_Location(new Point(58, 119));
		((Control)a7P()).set_Name("TextBox3");
		((Control)a7P()).set_Size(new Size(193, 20));
		((Control)a7P()).set_TabIndex(6);
		((Control)g5D()).set_Location(new Point(58, 155));
		((Control)g5D()).set_Name("TextBox4");
		((Control)g5D()).set_Size(new Size(193, 20));
		((Control)g5D()).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)g5D());
		((Control)this).get_Controls().Add((Control)(object)a7P());
		((Control)this).get_Controls().Add((Control)(object)s2A());
		((Control)this).get_Controls().Add((Control)(object)g4P());
		((Control)this).get_Controls().Add((Control)(object)Ej7());
		((Control)this).get_Controls().Add((Control)(object)p5K());
		((Control)this).get_Controls().Add((Control)(object)Bg5());
		((Control)this).get_Controls().Add((Control)(object)j8G());
		((Control)this).set_Name("AddCTHD");
		((Form)this).set_Text("AddCTHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label j8G()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6N(Label Hi8)
	{
		_Label1 = Hi8;
	}

	[SpecialName]
	internal virtual TextBox Bg5()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx2(TextBox m4M)
	{
		TextBox val = (c = m4M);
	}

	[SpecialName]
	internal virtual Label p5K()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6R(Label Tx3)
	{
		_Label2 = Tx3;
	}

	[SpecialName]
	internal virtual Label Ej7()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa9(Label k4S)
	{
		_Label3 = k4S;
	}

	[SpecialName]
	internal virtual Label g4P()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr9(Label a4C)
	{
		_Label4 = a4C;
	}

	[SpecialName]
	internal virtual TextBox s2A()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6N(TextBox Fo1)
	{
		TextBox val = (T = Fo1);
	}

	[SpecialName]
	internal virtual TextBox a7P()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7N(TextBox q4C)
	{
		TextBox val = (n = q4C);
	}

	[SpecialName]
	internal virtual TextBox g5D()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs1(TextBox Pt9)
	{
		TextBox val = (S = Pt9);
	}

	internal static bool My9(int Yc8)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Yc8 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Yc8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Yc8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Yc8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	internal static string Pc3(string[] y9Z, int Ed9, int Kt2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Ed9; i <= Kt2; i = checked(i + 1))
		{
			stringBuilder.Append(y9Z[i]);
		}
		return stringBuilder.ToString();
	}

	internal static void i4C()
	{
		string[] y9Z = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Pc3(y9Z, 0, 3);
		string value2 = Pc3(y9Z, 4, 7);
		k8A.mDic.Add(k8A.tName, value);
		k8A.mDic.Add(k8A.mName, value2);
	}
}
