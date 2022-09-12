using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;

namespace w5P;

[DesignerGenerated]
public class e2A : Form
{
	private Label _Label2;

	private Label _Label3;

	private Label _Label4;

	private Label _Label5;

	private Label _Label6;

	private Label _Label8;

	internal IContainer C;

	internal Button M;

	internal Label N;

	internal Label a;

	public e2A()
	{
		f4E();
	}

	protected override void Ze6(bool t1L)
	{
		try
		{
			if (t1L && C != null)
			{
				C.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t1L);
		}
	}

	private void f4E()
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
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		y0F(new Button());
		w3G(new Label());
		Mq9(new Label());
		Wi8(new Label());
		Mz8(new Label());
		y8C(new Label());
		q2K(new Label());
		f7G(new Label());
		Jp4(new Label());
		((Control)this).SuspendLayout();
		((ButtonBase)s6X()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)s6X()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s6X()).set_Location(new Point(18, 339));
		((Control)s6X()).set_Name("Button2");
		((Control)s6X()).set_Size(new Size(129, 40));
		((Control)s6X()).set_TabIndex(85);
		((ButtonBase)s6X()).set_Text("Back to Menu");
		((ButtonBase)s6X()).set_UseVisualStyleBackColor(true);
		Rj1().set_AutoSize(true);
		((Control)Rj1()).set_BackColor(Color.Transparent);
		((Control)Rj1()).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Rj1()).set_Location(new Point(12, 9));
		((Control)Rj1()).set_Name("Label2");
		((Control)Rj1()).set_Size(new Size(314, 31));
		((Control)Rj1()).set_TabIndex(84);
		Rj1().set_Text("HEAVENS FELL HOTEL");
		q4C().set_AutoSize(true);
		((Control)q4C()).set_BackColor(Color.Transparent);
		((Control)q4C()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q4C()).set_Location(new Point(12, 51));
		((Control)q4C()).set_Name("Label1");
		((Control)q4C()).set_Size(new Size(103, 22));
		((Control)q4C()).set_TabIndex(83);
		q4C().set_Text("ABOUT US");
		Sx0().set_AutoSize(true);
		((Control)Sx0()).set_BackColor(Color.Transparent);
		((Control)Sx0()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Sx0()).set_Location(new Point(73, 103));
		((Control)Sx0()).set_Name("Label3");
		((Control)Sx0()).set_Size(new Size(500, 22));
		((Control)Sx0()).set_TabIndex(86);
		Sx0().set_Text("\"HEAVENS FELL HOTEL IS A HOTEL WHEREIN HEAVENS");
		e0X().set_AutoSize(true);
		((Control)e0X()).set_BackColor(Color.Transparent);
		((Control)e0X()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e0X()).set_Location(new Point(73, 137));
		((Control)e0X()).set_Name("Label4");
		((Control)e0X()).set_Size(new Size(522, 22));
		((Control)e0X()).set_TabIndex(87);
		e0X().set_Text("HAVE FALLEN FROM THEIR REIGN IN THE SKY RESULTING");
		p1E().set_AutoSize(true);
		((Control)p1E()).set_BackColor(Color.Transparent);
		((Control)p1E()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p1E()).set_Location(new Point(73, 171));
		((Control)p1E()).set_Name("Label5");
		((Control)p1E()).set_Size(new Size(471, 22));
		((Control)p1E()).set_TabIndex(88);
		p1E().set_Text("INTO THIS GLORIOUS SPACE CREATED BY THE ONE");
		k7K().set_AutoSize(true);
		((Control)k7K()).set_BackColor(Color.Transparent);
		((Control)k7K()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k7K()).set_Location(new Point(73, 206));
		((Control)k7K()).set_Name("Label6");
		((Control)k7K()).set_Size(new Size(475, 22));
		((Control)k7K()).set_TabIndex(89);
		k7K().set_Text("WHO SALVAGED HEAVEN ITSELF, THOU SHALL CALL");
		g9Y().set_AutoSize(true);
		((Control)g9Y()).set_BackColor(Color.Transparent);
		((Control)g9Y()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g9Y()).set_Location(new Point(554, 206));
		((Control)g9Y()).set_Name("Label7");
		((Control)g9Y()).set_Size(new Size(95, 22));
		((Control)g9Y()).set_TabIndex(90);
		g9Y().set_Text("HIS NAME");
		r7D().set_AutoSize(true);
		((Control)r7D()).set_BackColor(Color.Transparent);
		((Control)r7D()).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r7D()).set_Location(new Point(280, 240));
		((Control)r7D()).set_Name("Label8");
		((Control)r7D()).set_Size(new Size(181, 31));
		((Control)r7D()).set_TabIndex(91);
		r7D().set_Text("BOSS GIAN!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(772, 392));
		((Control)this).get_Controls().Add((Control)(object)r7D());
		((Control)this).get_Controls().Add((Control)(object)g9Y());
		((Control)this).get_Controls().Add((Control)(object)k7K());
		((Control)this).get_Controls().Add((Control)(object)p1E());
		((Control)this).get_Controls().Add((Control)(object)e0X());
		((Control)this).get_Controls().Add((Control)(object)Sx0());
		((Control)this).get_Controls().Add((Control)(object)s6X());
		((Control)this).get_Controls().Add((Control)(object)Rj1());
		((Control)this).get_Controls().Add((Control)(object)q4C());
		((Control)this).set_Name("Form11");
		((Form)this).set_Text("ABOUT US");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button s6X()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0F(Button o0N)
	{
		EventHandler eventHandler = a6R;
		Button m = M;
		if (m != null)
		{
			((Control)m).remove_Click(eventHandler);
		}
		Button val = (M = o0N);
		m = M;
		if (m != null)
		{
			((Control)m).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Rj1()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3G(Label To2)
	{
		_Label2 = To2;
	}

	[SpecialName]
	internal virtual Label q4C()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mq9(Label Ys7)
	{
		Label val = (N = Ys7);
	}

	[SpecialName]
	internal virtual Label Sx0()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wi8(Label d2D)
	{
		_Label3 = d2D;
	}

	[SpecialName]
	internal virtual Label e0X()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz8(Label Mn1)
	{
		_Label4 = Mn1;
	}

	[SpecialName]
	internal virtual Label p1E()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8C(Label Kf9)
	{
		_Label5 = Kf9;
	}

	[SpecialName]
	internal virtual Label k7K()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2K(Label Tm0)
	{
		_Label6 = Tm0;
	}

	[SpecialName]
	internal virtual Label g9Y()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7G(Label b7S)
	{
		EventHandler eventHandler = Qi1;
		Label val = a;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Label val2 = (a = b7S);
		val = a;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label r7D()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp4(Label Te2)
	{
		_Label8 = Te2;
	}

	private void a6R(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)i7X.Forms.Ek0()).Show();
	}

	private void Qi1(object sender, EventArgs e)
	{
		((Control)r7D()).Show();
	}

	internal static bool r5A(int Fa9)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Fa9 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Fa9 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Fa9 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Fa9 = -1;
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
}
