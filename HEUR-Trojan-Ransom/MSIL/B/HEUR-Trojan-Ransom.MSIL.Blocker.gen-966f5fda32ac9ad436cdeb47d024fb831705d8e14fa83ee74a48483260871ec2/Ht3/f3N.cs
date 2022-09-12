using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;

namespace Ht3;

[DesignerGenerated]
public class f3N : Form
{
	private TextBox _TextBox1;

	private Label _Label3;

	private Label _Label4;

	private TextBox _TextBox2;

	private TextBox _TextBox4;

	internal IContainer Q;

	internal Label s;

	internal Label h;

	internal TextBox O;

	public f3N()
	{
		Jx5();
	}

	protected override void Di7(bool So2)
	{
		try
		{
			if (So2 && Q != null)
			{
				Q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(So2);
		}
	}

	private void Jx5()
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
		e8T(new Label());
		Hp7(new TextBox());
		Xi5(new Label());
		Ks9(new Label());
		Gq1(new Label());
		w6N(new TextBox());
		s3W(new TextBox());
		k2S(new TextBox());
		((Control)this).SuspendLayout();
		Nb6().set_AutoSize(true);
		((Control)Nb6()).set_Location(new Point(12, 31));
		((Control)Nb6()).set_Name("Label1");
		((Control)Nb6()).set_Size(new Size(39, 13));
		((Control)Nb6()).set_TabIndex(0);
		Nb6().set_Text("Label1");
		((Control)b6X()).set_Location(new Point(58, 31));
		((Control)b6X()).set_Name("TextBox1");
		((Control)b6X()).set_Size(new Size(193, 20));
		((Control)b6X()).set_TabIndex(1);
		Xr6().set_AutoSize(true);
		((Control)Xr6()).set_Location(new Point(12, 75));
		((Control)Xr6()).set_Name("Label2");
		((Control)Xr6()).set_Size(new Size(39, 13));
		((Control)Xr6()).set_TabIndex(2);
		Xr6().set_Text("Label2");
		Zz7().set_AutoSize(true);
		((Control)Zz7()).set_Location(new Point(12, 119));
		((Control)Zz7()).set_Name("Label3");
		((Control)Zz7()).set_Size(new Size(39, 13));
		((Control)Zz7()).set_TabIndex(3);
		Zz7().set_Text("Label3");
		q9D().set_AutoSize(true);
		((Control)q9D()).set_Location(new Point(12, 162));
		((Control)q9D()).set_Name("Label4");
		((Control)q9D()).set_Size(new Size(39, 13));
		((Control)q9D()).set_TabIndex(4);
		q9D().set_Text("Label4");
		((Control)t8Q()).set_Location(new Point(57, 72));
		((Control)t8Q()).set_Name("TextBox2");
		((Control)t8Q()).set_Size(new Size(193, 20));
		((Control)t8Q()).set_TabIndex(5);
		((Control)i6C()).set_Location(new Point(58, 119));
		((Control)i6C()).set_Name("TextBox3");
		((Control)i6C()).set_Size(new Size(193, 20));
		((Control)i6C()).set_TabIndex(6);
		((Control)i1J()).set_Location(new Point(58, 155));
		((Control)i1J()).set_Name("TextBox4");
		((Control)i1J()).set_Size(new Size(193, 20));
		((Control)i1J()).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)i1J());
		((Control)this).get_Controls().Add((Control)(object)i6C());
		((Control)this).get_Controls().Add((Control)(object)t8Q());
		((Control)this).get_Controls().Add((Control)(object)q9D());
		((Control)this).get_Controls().Add((Control)(object)Zz7());
		((Control)this).get_Controls().Add((Control)(object)Xr6());
		((Control)this).get_Controls().Add((Control)(object)b6X());
		((Control)this).get_Controls().Add((Control)(object)Nb6());
		((Control)this).set_Name("AddCTHD");
		((Form)this).set_Text("AddCTHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Nb6()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8T(Label i8G)
	{
		Label val = (s = i8G);
	}

	[SpecialName]
	internal virtual TextBox b6X()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp7(TextBox Lm3)
	{
		_TextBox1 = Lm3;
	}

	[SpecialName]
	internal virtual Label Xr6()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xi5(Label z0Q)
	{
		Label val = (h = z0Q);
	}

	[SpecialName]
	internal virtual Label Zz7()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks9(Label f5E)
	{
		_Label3 = f5E;
	}

	[SpecialName]
	internal virtual Label q9D()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq1(Label Rg9)
	{
		_Label4 = Rg9;
	}

	[SpecialName]
	internal virtual TextBox t8Q()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6N(TextBox g7B)
	{
		_TextBox2 = g7B;
	}

	[SpecialName]
	internal virtual TextBox i6C()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3W(TextBox Lr0)
	{
		TextBox val = (O = Lr0);
	}

	[SpecialName]
	internal virtual TextBox i1J()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2S(TextBox Cy1)
	{
		_TextBox4 = Cy1;
	}

	internal static bool s2G(int j3L)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(j3L + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				j3L = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				j3L = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				j3L = -1;
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

	internal static string Ts9(string[] a7K, int z0G, int x2G)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = z0G; i <= x2G; i = checked(i + 1))
		{
			stringBuilder.Append(a7K[i]);
		}
		return stringBuilder.ToString();
	}

	internal static void p2M()
	{
		string[] a7K = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Ts9(a7K, 0, 3);
		string value2 = Ts9(a7K, 4, 7);
		Lp07.mDic.Add(Lp07.tName, value);
		Lp07.mDic.Add(Lp07.mName, value2);
	}
}
