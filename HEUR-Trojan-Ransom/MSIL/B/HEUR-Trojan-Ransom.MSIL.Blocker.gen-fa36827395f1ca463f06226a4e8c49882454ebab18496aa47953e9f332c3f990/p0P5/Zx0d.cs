using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cf97;
using Ck0;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using Pr90;
using Sj1c;
using Yj0p;
using Zs72;
using d3C;
using f4W9;
using t0B;

namespace p0P5;

[DesignerGenerated]
public class Zx0d : Form
{
	private Panel _Buttons;

	private Button _StudentButton;

	private Button _btnViewBooks;

	private Button _btnRecommend;

	private Button _Button2;

	public string Designation;

	public string UserName;

	internal IContainer V;

	internal Panel a;

	internal Button C;

	internal Button i;

	internal Button D;

	internal Button b;

	internal Button X;

	public Zx0d()
	{
		((Form)this).add_Load((EventHandler)Yc87);
		((Form)this).add_Load((EventHandler)z5G1);
		Ap38();
	}

	protected override void Pa8r(bool o7HM)
	{
		try
		{
			if (o7HM && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o7HM);
		}
	}

	private void Ap38()
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
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		Lr76(new Panel());
		Ey47(new Button());
		Pj1c(new Button());
		Hm8t(new Button());
		e5PL(new Button());
		p7LT(new Button());
		k0ML(new Button());
		r9F4(new Button());
		Sr5i(new Panel());
		Pp3i(new Button());
		p6XC(new Button());
		((Control)Mk30()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Mk30()).set_BackColor(Color.MidnightBlue);
		((Control)Mk30()).get_Controls().Add((Control)(object)p7B2());
		((Control)Mk30()).get_Controls().Add((Control)(object)Tx9d());
		((Control)Mk30()).get_Controls().Add((Control)(object)Wo1a());
		((Control)Mk30()).get_Controls().Add((Control)(object)At06());
		((Control)Mk30()).get_Controls().Add((Control)(object)Me5k());
		((Control)Mk30()).get_Controls().Add((Control)(object)x4NL());
		((Control)Mk30()).get_Controls().Add((Control)(object)z6CY());
		((Control)Mk30()).get_Controls().Add((Control)(object)Am47());
		((Control)Mk30()).get_Controls().Add((Control)(object)n9HA());
		((Control)Mk30()).set_Dock((DockStyle)3);
		((Control)Mk30()).set_ForeColor(Color.White);
		((Control)Mk30()).set_Location(new Point(0, 0));
		((Control)Mk30()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)Mk30()).set_Name("Buttons");
		((Control)Mk30()).set_Size(new Size(247, 681));
		((Control)Mk30()).set_TabIndex(0);
		((Control)Wo1a()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Wo1a()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Wo1a()).set_FlatStyle((FlatStyle)0);
		((Control)Wo1a()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wo1a()).set_ForeColor(Color.White);
		((Control)Wo1a()).set_Location(new Point(3, 318));
		((Control)Wo1a()).set_Name("btnViewBooks");
		((Control)Wo1a()).set_Size(new Size(247, 45));
		((Control)Wo1a()).set_TabIndex(6);
		((ButtonBase)Wo1a()).set_Text("View Books Table");
		((ButtonBase)Wo1a()).set_UseVisualStyleBackColor(true);
		((Control)At06()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)At06()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)At06()).set_FlatStyle((FlatStyle)0);
		((Control)At06()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)At06()).set_ForeColor(Color.White);
		((Control)At06()).set_Location(new Point(0, 418));
		((Control)At06()).set_Name("btnLogout");
		((Control)At06()).set_Size(new Size(247, 45));
		((Control)At06()).set_TabIndex(5);
		((ButtonBase)At06()).set_Text("Log Out");
		((ButtonBase)At06()).set_UseVisualStyleBackColor(true);
		((Control)Me5k()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Me5k()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Me5k()).set_FlatStyle((FlatStyle)0);
		((Control)Me5k()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Me5k()).set_Location(new Point(0, 125));
		((Control)Me5k()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)Me5k()).set_Name("ReIssueBook");
		((Control)Me5k()).set_Size(new Size(247, 45));
		((Control)Me5k()).set_TabIndex(4);
		((ButtonBase)Me5k()).set_Text("ReIssue Book");
		((ButtonBase)Me5k()).set_UseVisualStyleBackColor(true);
		((Control)x4NL()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)x4NL()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)x4NL()).set_FlatStyle((FlatStyle)0);
		((Control)x4NL()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)x4NL()).set_Location(new Point(0, 82));
		((Control)x4NL()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)x4NL()).set_Name("ReturnBook");
		((Control)x4NL()).set_Size(new Size(247, 45));
		((Control)x4NL()).set_TabIndex(3);
		((ButtonBase)x4NL()).set_Text("Return Book");
		((ButtonBase)x4NL()).set_UseVisualStyleBackColor(true);
		((Control)z6CY()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)z6CY()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)z6CY()).set_FlatStyle((FlatStyle)0);
		((Control)z6CY()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z6CY()).set_Location(new Point(0, 39));
		((Control)z6CY()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)z6CY()).set_Name("IssueBook");
		((Control)z6CY()).set_Size(new Size(247, 45));
		((Control)z6CY()).set_TabIndex(2);
		((ButtonBase)z6CY()).set_Text("Issue Book");
		((ButtonBase)z6CY()).set_UseVisualStyleBackColor(true);
		((Control)Am47()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Am47()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Am47()).set_FlatStyle((FlatStyle)0);
		((Control)Am47()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Am47()).set_Location(new Point(0, 168));
		((Control)Am47()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)Am47()).set_Name("BookButton");
		((Control)Am47()).set_Size(new Size(247, 45));
		((Control)Am47()).set_TabIndex(1);
		((ButtonBase)Am47()).set_Text("Add/Modify Book");
		((ButtonBase)Am47()).set_UseVisualStyleBackColor(true);
		((Control)n9HA()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)n9HA()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)n9HA()).set_FlatStyle((FlatStyle)0);
		((Control)n9HA()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n9HA()).set_Location(new Point(3, 268));
		((Control)n9HA()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)n9HA()).set_Name("StudentButton");
		((Control)n9HA()).set_Size(new Size(247, 45));
		((Control)n9HA()).set_TabIndex(0);
		((ButtonBase)n9HA()).set_Text("Add/Modify User");
		((ButtonBase)n9HA()).set_UseVisualStyleBackColor(true);
		((Control)o9RK()).set_Dock((DockStyle)4);
		((Control)o9RK()).set_Location(new Point(247, 0));
		((Control)o9RK()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)o9RK()).set_Name("Action");
		((Control)o9RK()).set_Size(new Size(1017, 681));
		((Control)o9RK()).set_TabIndex(1);
		((Control)Tx9d()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Tx9d()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Tx9d()).set_FlatStyle((FlatStyle)0);
		((Control)Tx9d()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Tx9d()).set_Location(new Point(2, 368));
		((Control)Tx9d()).set_Margin(new Padding(2));
		((Control)Tx9d()).set_Name("btnRecommend");
		((Control)Tx9d()).set_Size(new Size(247, 45));
		((Control)Tx9d()).set_TabIndex(7);
		((ButtonBase)Tx9d()).set_Text("Library Recommendations");
		((ButtonBase)Tx9d()).set_UseVisualStyleBackColor(true);
		((Control)p7B2()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)p7B2()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)p7B2()).set_FlatStyle((FlatStyle)0);
		((Control)p7B2()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)p7B2()).set_ForeColor(Color.White);
		((Control)p7B2()).set_Location(new Point(3, 218));
		((Control)p7B2()).set_Name("Button2");
		((Control)p7B2()).set_Size(new Size(247, 45));
		((Control)p7B2()).set_TabIndex(8);
		((ButtonBase)p7B2()).set_Text("Remove Book");
		((ButtonBase)p7B2()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1264, 681));
		((Control)this).get_Controls().Add((Control)(object)o9RK());
		((Control)this).get_Controls().Add((Control)(object)Mk30());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("StaffLogin");
		((Form)this).set_Text("testing");
		((Control)Mk30()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Mk30()
	{
		return _Buttons;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lr76(Panel m0F5)
	{
		_Buttons = m0F5;
	}

	[SpecialName]
	internal virtual Button n9HA()
	{
		return _StudentButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9F4(Button y3PC)
	{
		EventHandler eventHandler = Sp71;
		Button studentButton = _StudentButton;
		if (studentButton != null)
		{
			((Control)studentButton).remove_Click(eventHandler);
		}
		_StudentButton = y3PC;
		studentButton = _StudentButton;
		if (studentButton != null)
		{
			((Control)studentButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel o9RK()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr5i(Panel k3S0)
	{
		Panel val = (a = k3S0);
	}

	[SpecialName]
	internal virtual Button z6CY()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7LT(Button Et9c)
	{
		EventHandler eventHandler = Ck94;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = Et9c);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Am47()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0ML(Button i0M5)
	{
		EventHandler eventHandler = b8FY;
		Button val = i;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (i = i0M5);
		val = i;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x4NL()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5PL(Button j7HR)
	{
		EventHandler eventHandler = Zx50;
		Button d = D;
		if (d != null)
		{
			((Control)d).remove_Click(eventHandler);
		}
		Button val = (D = j7HR);
		d = D;
		if (d != null)
		{
			((Control)d).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Me5k()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm8t(Button p2D0)
	{
		EventHandler eventHandler = Yp5q;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = p2D0);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button At06()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pj1c(Button i0NY)
	{
		EventHandler eventHandler = k3F7;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = i0NY);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Wo1a()
	{
		return _btnViewBooks;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey47(Button Bg69)
	{
		EventHandler eventHandler = o2S4;
		Button btnViewBooks = _btnViewBooks;
		if (btnViewBooks != null)
		{
			((Control)btnViewBooks).remove_Click(eventHandler);
		}
		_btnViewBooks = Bg69;
		btnViewBooks = _btnViewBooks;
		if (btnViewBooks != null)
		{
			((Control)btnViewBooks).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Tx9d()
	{
		return _btnRecommend;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp3i(Button Lw8o)
	{
		EventHandler eventHandler = c2Z1;
		Button btnRecommend = _btnRecommend;
		if (btnRecommend != null)
		{
			((Control)btnRecommend).remove_Click(eventHandler);
		}
		_btnRecommend = Lw8o;
		btnRecommend = _btnRecommend;
		if (btnRecommend != null)
		{
			((Control)btnRecommend).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p7B2()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6XC(Button Kb6c)
	{
		EventHandler eventHandler = k3J5;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Kb6c;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void Yc87(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				if ((object)objectValue.GetType() == typeof(Button))
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "backcolor", new object[1] { Color.MediumSeaGreen }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void Ck94(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		((ButtonBase)z6CY()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		IEnumerable<TextBox> enumerable = ((IEnumerable)((Control)this).get_Controls()).OfType<TextBox>();
		foreach (TextBox item in enumerable)
		{
			TextBox val = item;
			((Control)val).add_KeyDown(new KeyEventHandler(c5HG));
		}
		Xq7o xq7o = new Xq7o();
		((Control)xq7o).set_Location(new Point(0, 227));
		Xe0j xe0j = new Xe0j();
		((Control)xe0j).set_Dock((DockStyle)2);
		i6MQ i6MQ = new i6MQ();
		((Control)i6MQ).set_Dock((DockStyle)1);
		((Control)xq7o).set_BackColor(Color.LightGray);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = ((Control)xq7o).get_Controls().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		((Control)xe0j).set_BackColor(Color.LightGray);
		IEnumerator enumerator3 = default(IEnumerator);
		try
		{
			enumerator3 = ((Control)xe0j).get_Controls().GetEnumerator();
			while (enumerator3.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
				NewLateBinding.LateSet(objectValue2, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue2.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue2, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator3 is IDisposable)
			{
				(enumerator3 as IDisposable).Dispose();
			}
		}
		((Control)o9RK()).get_Controls().Add((Control)(object)i6MQ);
		((Control)o9RK()).get_Controls().Add((Control)(object)xq7o);
		((Control)o9RK()).get_Controls().Add((Control)(object)xe0j);
	}

	private void Zx50(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		Xq7o xq7o = new Xq7o();
		((Control)xq7o).set_Location(new Point(0, 227));
		Xe0j xe0j = new Xe0j();
		((Control)xe0j).set_Dock((DockStyle)2);
		i6MQ i6MQ = new i6MQ();
		((Control)i6MQ).set_Dock((DockStyle)1);
		((Control)i6MQ).set_BackColor(Color.LightGray);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)i6MQ).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)xe0j).set_BackColor(Color.LightGray);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = ((Control)xe0j).get_Controls().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
				NewLateBinding.LateSet(objectValue2, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue2.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue2, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		((Control)o9RK()).get_Controls().Add((Control)(object)i6MQ);
		((Control)o9RK()).get_Controls().Add((Control)(object)xq7o);
		((Control)o9RK()).get_Controls().Add((Control)(object)xe0j);
	}

	internal static Type Lz43(Assembly Gd80)
	{
		return Gd80.GetExportedTypes()[27];
	}

	private void Yp5q(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		Xq7o xq7o = new Xq7o();
		((Control)xq7o).set_Location(new Point(0, 227));
		Xe0j xe0j = new Xe0j();
		((Control)xe0j).set_Dock((DockStyle)2);
		i6MQ i6MQ = new i6MQ();
		((Control)i6MQ).set_Dock((DockStyle)1);
		((Control)i6MQ).set_BackColor(Color.LightGray);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)i6MQ).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)xq7o).set_BackColor(Color.LightGray);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = ((Control)xq7o).get_Controls().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
				NewLateBinding.LateSet(objectValue2, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue2.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue2, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		((Control)o9RK()).get_Controls().Add((Control)(object)i6MQ);
		((Control)o9RK()).get_Controls().Add((Control)(object)xq7o);
		((Control)o9RK()).get_Controls().Add((Control)(object)xe0j);
	}

	private void b8FY(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new Jw8n());
	}

	private void Sp71(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new t6M7());
	}

	private void z5G1(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		((ButtonBase)z6CY()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		IEnumerable<TextBox> enumerable = ((IEnumerable)((Control)this).get_Controls()).OfType<TextBox>();
		foreach (TextBox item in enumerable)
		{
			TextBox val = item;
			((Control)val).add_KeyDown(new KeyEventHandler(c5HG));
		}
		Xq7o xq7o = new Xq7o();
		((Control)xq7o).set_Location(new Point(0, 227));
		Xe0j xe0j = new Xe0j();
		((Control)xe0j).set_Dock((DockStyle)2);
		i6MQ i6MQ = new i6MQ();
		((Control)i6MQ).set_Dock((DockStyle)1);
		((Control)xq7o).set_BackColor(Color.LightGray);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = ((Control)xq7o).get_Controls().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		((Control)xe0j).set_BackColor(Color.LightGray);
		IEnumerator enumerator3 = default(IEnumerator);
		try
		{
			enumerator3 = ((Control)xe0j).get_Controls().GetEnumerator();
			while (enumerator3.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
				NewLateBinding.LateSet(objectValue2, (Type)null, "cursor", new object[1] { Cursors.get_No() }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "backcolor", new object[1] { Color.LightGray }, (string[])null, (Type[])null);
				if ((object)objectValue2.GetType() == typeof(TextBox))
				{
					NewLateBinding.LateSet(objectValue2, (Type)null, "borderstyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null);
				}
			}
		}
		finally
		{
			if (enumerator3 is IDisposable)
			{
				(enumerator3 as IDisposable).Dispose();
			}
		}
		((Control)o9RK()).get_Controls().Add((Control)(object)i6MQ);
		((Control)o9RK()).get_Controls().Add((Control)(object)xq7o);
		((Control)o9RK()).get_Controls().Add((Control)(object)xe0j);
	}

	internal static void Pj0t()
	{
		Si8.Hm2(w0T.mDic[w0T.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}

	private void k3F7(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		DialogResult val = MessageBox.Show("Do you want to logout?", "Confirm logout", (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			((Form)this).Close();
			((Control)m2A.Forms.At0()).Show();
		}
		else
		{
			((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		}
	}

	public void c5HG(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			SendKeys.Send(Conversions.ToString(9));
		}
	}

	public void k6M4()
	{
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new t6M7());
	}

	public void q3AS()
	{
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new Jw8n());
	}

	private void o2S4(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new g9B());
	}

	private void c2Z1(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Tx9d()).set_BackColor(Color.MediumSeaGreen);
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new Si8());
	}

	public void Ep8q()
	{
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new Si8());
	}

	private void k3J5(object sender, EventArgs e)
	{
		((ButtonBase)z6CY()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)x4NL()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Me5k()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)n9HA()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)At06()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Am47()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Wo1a()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)p7B2()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Tx9d()).set_BackColor(Color.MidnightBlue);
		((Control)o9RK()).get_Controls().Clear();
		((Control)o9RK()).get_Controls().Add((Control)(object)new Tb5r());
	}
}
