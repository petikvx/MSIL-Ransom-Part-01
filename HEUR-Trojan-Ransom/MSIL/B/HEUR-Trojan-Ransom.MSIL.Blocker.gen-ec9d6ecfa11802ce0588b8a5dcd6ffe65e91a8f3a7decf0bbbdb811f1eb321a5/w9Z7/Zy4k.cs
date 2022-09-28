using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wi84;
using b9NH;
using g7J;
using m5GN;

namespace w9Z7;

[DesignerGenerated]
public class Zy4k : Form
{
	private Label _Label1;

	private Button _Button6;

	private Button _Button7;

	private Button _Button8;

	private Button _Button4;

	internal IContainer B;

	internal Button v;

	internal Button P;

	internal Button l;

	internal j6R M;

	public Zy4k()
	{
		((Form)this).add_Load((EventHandler)Tr92);
		Sx0c();
	}

	protected override void Nq6s(bool o6Y0)
	{
		try
		{
			if (o6Y0 && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o6Y0);
		}
	}

	private void Sx0c()
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
		s7Z9(new Button());
		g4Y9(new Button());
		i0CA(new Button());
		r6F9(new Label());
		e1EF(new Button());
		Zz76(new Button());
		w1K9(new Button());
		Nd28(new Button());
		((Control)this).SuspendLayout();
		((Control)g0D2()).set_Location(new Point(40, 35));
		((Control)g0D2()).set_Name("Button1");
		((Control)g0D2()).set_Size(new Size(171, 34));
		((Control)g0D2()).set_TabIndex(0);
		((ButtonBase)g0D2()).set_Text("Add Student to Database");
		((ButtonBase)g0D2()).set_UseVisualStyleBackColor(true);
		((Control)k7NJ()).set_Location(new Point(40, 75));
		((Control)k7NJ()).set_Name("Button2");
		((Control)k7NJ()).set_Size(new Size(171, 34));
		((Control)k7NJ()).set_TabIndex(0);
		((ButtonBase)k7NJ()).set_Text("Update/Modify Student Database");
		((ButtonBase)k7NJ()).set_UseVisualStyleBackColor(true);
		((Control)j7N9()).set_Location(new Point(40, 115));
		((Control)j7N9()).set_Name("Button3");
		((Control)j7N9()).set_Size(new Size(171, 34));
		((Control)j7N9()).set_TabIndex(0);
		((ButtonBase)j7N9()).set_Text("Display All Records");
		((ButtonBase)j7N9()).set_UseVisualStyleBackColor(true);
		Xe19().set_AutoSize(true);
		((Control)Xe19()).set_Location(new Point(77, 19));
		((Control)Xe19()).set_Name("Label1");
		((Control)Xe19()).set_Size(new Size(93, 13));
		((Control)Xe19()).set_TabIndex(1);
		Xe19().set_Text("Student Database");
		((Control)f8Z0()).set_Location(new Point(40, 155));
		((Control)f8Z0()).set_Name("Button6");
		((Control)f8Z0()).set_Size(new Size(171, 34));
		((Control)f8Z0()).set_TabIndex(0);
		((ButtonBase)f8Z0()).set_Text("Display Single Record");
		((ButtonBase)f8Z0()).set_UseVisualStyleBackColor(true);
		((Control)Zi7q()).set_Location(new Point(40, 277));
		((Control)Zi7q()).set_Name("Button7");
		((Control)Zi7q()).set_Size(new Size(171, 34));
		((Control)Zi7q()).set_TabIndex(0);
		((ButtonBase)Zi7q()).set_Text("Exit");
		((ButtonBase)Zi7q()).set_UseVisualStyleBackColor(true);
		((Control)Bx8w()).set_Location(new Point(40, 195));
		((Control)Bx8w()).set_Name("Button8");
		((Control)Bx8w()).set_Size(new Size(171, 35));
		((Control)Bx8w()).set_TabIndex(2);
		((ButtonBase)Bx8w()).set_Text("Display Partial Records");
		((ButtonBase)Bx8w()).set_UseVisualStyleBackColor(true);
		((Control)Xx25()).set_Location(new Point(40, 236));
		((Control)Xx25()).set_Name("Button4");
		((Control)Xx25()).set_Size(new Size(171, 35));
		((Control)Xx25()).set_TabIndex(2);
		((ButtonBase)Xx25()).set_Text("Delete Single Record");
		((ButtonBase)Xx25()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(256, 333));
		((Control)this).get_Controls().Add((Control)(object)Xx25());
		((Control)this).get_Controls().Add((Control)(object)Bx8w());
		((Control)this).get_Controls().Add((Control)(object)Xe19());
		((Control)this).get_Controls().Add((Control)(object)Zi7q());
		((Control)this).get_Controls().Add((Control)(object)f8Z0());
		((Control)this).get_Controls().Add((Control)(object)j7N9());
		((Control)this).get_Controls().Add((Control)(object)k7NJ());
		((Control)this).get_Controls().Add((Control)(object)g0D2());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Student Form");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button g0D2()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7Z9(Button Dc3m)
	{
		EventHandler eventHandler = Kq6c;
		Button val = v;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (v = Dc3m);
		val = v;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k7NJ()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4Y9(Button Gr4z)
	{
		EventHandler eventHandler = Zb67;
		Button p = P;
		if (p != null)
		{
			((Control)p).remove_Click(eventHandler);
		}
		Button val = (P = Gr4z);
		p = P;
		if (p != null)
		{
			((Control)p).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j7N9()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0CA(Button e6Q4)
	{
		EventHandler eventHandler = s0MQ;
		Button val = l;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (l = e6Q4);
		val = l;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xe19()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6F9(Label q0XT)
	{
		_Label1 = q0XT;
	}

	[SpecialName]
	internal virtual Button f8Z0()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1EF(Button Zo8r)
	{
		EventHandler eventHandler = c7D1;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = Zo8r;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zi7q()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz76(Button Sd5m)
	{
		EventHandler eventHandler = Wx18;
		Button button = _Button7;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button7 = Sd5m;
		button = _Button7;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Bx8w()
	{
		return _Button8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1K9(Button Bq36)
	{
		EventHandler eventHandler = Zi7e;
		Button button = _Button8;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button8 = Bq36;
		button = _Button8;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Xx25()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd28(Button Mc6x)
	{
		EventHandler eventHandler = o0XD;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = Mc6x;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void Wx18(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		DialogResult val = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", (MessageBoxButtons)3);
		if ((int)val == 6)
		{
			M.Dt5();
			((Form)this).Close();
		}
	}

	internal static string[] Si97()
	{
		t9L5.f3YH();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		p1RD.mDic.Add("bee", value);
		return t9L5.d3N5();
	}

	private void Tr92(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		j6R j6R = (M = new j6R());
		M.Jq8("server=localhost;userid=root;password=root;database=student;");
		try
		{
			M.f1N();
			MessageBox.Show("Connected to DataBase Student");
			M.Dt5();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
		finally
		{
			M.g5Z();
		}
	}

	private void c7D1(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.Re3d()).Show();
	}

	private void Kq6c(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.b3SG()).Show();
	}

	private void Zb67(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.i4J2()).Show();
	}

	private void s0MQ(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.Af9x()).Show();
	}

	private void Zi7e(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.x8R2()).Show();
	}

	private void o0XD(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.Yc98()).Show();
	}
}
