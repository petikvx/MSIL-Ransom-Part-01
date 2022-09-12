using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using z2SR;

namespace Eb2;

[DesignerGenerated]
public class Nb6 : Form
{
	private Label _Label3;

	private Label _Label4;

	private TextBox _TextBox1;

	private Button _Button2;

	private Button _Button3;

	private ErrorProvider _ErrorProvider1;

	internal IContainer L;

	internal Label c;

	internal Label s;

	internal TextBox m;

	internal TextBox O;

	internal TextBox e;

	internal Button k;

	internal ErrorProvider G;

	internal ErrorProvider r;

	internal ErrorProvider J;

	public Nb6()
	{
		Az0();
	}

	protected override void c7S(bool x8T)
	{
		try
		{
			if (x8T && L != null)
			{
				L.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x8T);
		}
	}

	private void Az0()
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
		IContainer container = (L = new Container());
		Ko5(new Label());
		Ta7(new Label());
		Kn5(new Label());
		Ya4(new Label());
		Yo0(new TextBox());
		m3F(new TextBox());
		Er8(new TextBox());
		a4X(new TextBox());
		e3W(new Button());
		d1W(new Button());
		Zc6(new Button());
		y5X(new ErrorProvider(L));
		Cc5(new ErrorProvider(L));
		Je6(new ErrorProvider(L));
		Kz8(new ErrorProvider(L));
		((ISupportInitialize)Fb4()).BeginInit();
		((ISupportInitialize)Ky6()).BeginInit();
		((ISupportInitialize)w3L()).BeginInit();
		((ISupportInitialize)Py8()).BeginInit();
		((Control)this).SuspendLayout();
		Ww0().set_AutoSize(true);
		((Control)Ww0()).set_Location(new Point(13, 13));
		((Control)Ww0()).set_Name("Label1");
		((Control)Ww0()).set_Size(new Size(72, 13));
		((Control)Ww0()).set_TabIndex(0);
		Ww0().set_Text("Book Number");
		Ad9().set_AutoSize(true);
		((Control)Ad9()).set_Location(new Point(13, 53));
		((Control)Ad9()).set_Name("Label2");
		((Control)Ad9()).set_Size(new Size(63, 13));
		((Control)Ad9()).set_TabIndex(1);
		Ad9().set_Text("Book Name");
		Ny5().set_AutoSize(true);
		((Control)Ny5()).set_Location(new Point(16, 95));
		((Control)Ny5()).set_Name("Label3");
		((Control)Ny5()).set_Size(new Size(69, 13));
		((Control)Ny5()).set_TabIndex(2);
		Ny5().set_Text("Author Name");
		g2D().set_AutoSize(true);
		((Control)g2D()).set_Location(new Point(16, 143));
		((Control)g2D()).set_Name("Label4");
		((Control)g2D()).set_Size(new Size(91, 13));
		((Control)g2D()).set_TabIndex(3);
		g2D().set_Text("Number of Copies");
		((Control)Nm4()).set_Location(new Point(122, 10));
		((Control)Nm4()).set_Name("TextBox1");
		((Control)Nm4()).set_Size(new Size(167, 20));
		((Control)Nm4()).set_TabIndex(4);
		((Control)Rd9()).set_Location(new Point(122, 50));
		((Control)Rd9()).set_Name("TextBox2");
		((Control)Rd9()).set_Size(new Size(167, 20));
		((Control)Rd9()).set_TabIndex(5);
		((Control)Py9()).set_Location(new Point(122, 95));
		((Control)Py9()).set_Name("TextBox3");
		((Control)Py9()).set_Size(new Size(167, 20));
		((Control)Py9()).set_TabIndex(6);
		((Control)Gz9()).set_Location(new Point(122, 140));
		((Control)Gz9()).set_Name("TextBox4");
		((Control)Gz9()).set_Size(new Size(167, 20));
		((Control)Gz9()).set_TabIndex(7);
		((Control)Ys0()).set_Location(new Point(13, 200));
		((Control)Ys0()).set_Name("Button1");
		((Control)Ys0()).set_Size(new Size(75, 23));
		((Control)Ys0()).set_TabIndex(8);
		((ButtonBase)Ys0()).set_Text("Clear");
		((ButtonBase)Ys0()).set_UseVisualStyleBackColor(true);
		((Control)x2R()).set_Location(new Point(111, 200));
		((Control)x2R()).set_Name("Button2");
		((Control)x2R()).set_Size(new Size(75, 23));
		((Control)x2R()).set_TabIndex(9);
		((ButtonBase)x2R()).set_Text("Update");
		((ButtonBase)x2R()).set_UseVisualStyleBackColor(true);
		((Control)c4B()).set_Location(new Point(214, 199));
		((Control)c4B()).set_Name("Button3");
		((Control)c4B()).set_Size(new Size(75, 23));
		((Control)c4B()).set_TabIndex(10);
		((ButtonBase)c4B()).set_Text("Exit");
		((ButtonBase)c4B()).set_UseVisualStyleBackColor(true);
		Fb4().set_ContainerControl((ContainerControl)(object)this);
		Ky6().set_ContainerControl((ContainerControl)(object)this);
		w3L().set_ContainerControl((ContainerControl)(object)this);
		Py8().set_ContainerControl((ContainerControl)(object)this);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(319, 261));
		((Control)this).get_Controls().Add((Control)(object)c4B());
		((Control)this).get_Controls().Add((Control)(object)x2R());
		((Control)this).get_Controls().Add((Control)(object)Ys0());
		((Control)this).get_Controls().Add((Control)(object)Gz9());
		((Control)this).get_Controls().Add((Control)(object)Py9());
		((Control)this).get_Controls().Add((Control)(object)Rd9());
		((Control)this).get_Controls().Add((Control)(object)Nm4());
		((Control)this).get_Controls().Add((Control)(object)g2D());
		((Control)this).get_Controls().Add((Control)(object)Ny5());
		((Control)this).get_Controls().Add((Control)(object)Ad9());
		((Control)this).get_Controls().Add((Control)(object)Ww0());
		((Control)this).set_Name("Form8");
		((Form)this).set_Text("Update Form");
		((ISupportInitialize)Fb4()).EndInit();
		((ISupportInitialize)Ky6()).EndInit();
		((ISupportInitialize)w3L()).EndInit();
		((ISupportInitialize)Py8()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ww0()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ko5(Label Te8)
	{
		Label val = (c = Te8);
	}

	[SpecialName]
	internal virtual Label Ad9()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ta7(Label f1F)
	{
		Label val = (s = f1F);
	}

	[SpecialName]
	internal virtual Label Ny5()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn5(Label d5D)
	{
		_Label3 = d5D;
	}

	[SpecialName]
	internal virtual Label g2D()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ya4(Label r6P)
	{
		_Label4 = r6P;
	}

	[SpecialName]
	internal virtual TextBox Nm4()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo0(TextBox Ls5)
	{
		_TextBox1 = Ls5;
	}

	[SpecialName]
	internal virtual TextBox Rd9()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3F(TextBox Sk2)
	{
		TextBox val = (m = Sk2);
	}

	[SpecialName]
	internal virtual TextBox Py9()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Er8(TextBox d0H)
	{
		TextBox val = (O = d0H);
	}

	[SpecialName]
	internal virtual TextBox Gz9()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4X(TextBox Sn4)
	{
		TextBox val = (e = Sn4);
	}

	[SpecialName]
	internal virtual Button Ys0()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3W(Button n7K)
	{
		EventHandler eventHandler = Qi6;
		Button val = k;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (k = n7K);
		val = k;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x2R()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1W(Button Cj5)
	{
		EventHandler eventHandler = a8K;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Cj5;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button c4B()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc6(Button Nd4)
	{
		EventHandler eventHandler = j2X;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = Nd4;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ErrorProvider Fb4()
	{
		return _ErrorProvider1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5X(ErrorProvider r7Y)
	{
		_ErrorProvider1 = r7Y;
	}

	[SpecialName]
	internal virtual ErrorProvider Ky6()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cc5(ErrorProvider t3K)
	{
		ErrorProvider val = (G = t3K);
	}

	[SpecialName]
	internal virtual ErrorProvider w3L()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je6(ErrorProvider Nj0)
	{
		ErrorProvider val = (r = Nj0);
	}

	[SpecialName]
	internal virtual ErrorProvider Py8()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kz8(ErrorProvider q9T)
	{
		ErrorProvider val = (J = q9T);
	}

	private void Qi6(object sender, EventArgs e)
	{
		Nm4().set_Text("");
		Rd9().set_Text("");
		Py9().set_Text("");
		Gz9().set_Text("");
	}

	private void j2X(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void a8K(object sender, EventArgs e)
	{
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Nm4().get_Text(), "", false) == 0)
		{
			Fb4().SetError((Control)(object)Nm4(), "Please Enter Book Number");
		}
		else
		{
			Fb4().Clear();
		}
		if (Operators.CompareString(Rd9().get_Text(), "", false) == 0)
		{
			Ky6().SetError((Control)(object)Rd9(), "Please Enter Book Name");
		}
		else
		{
			Ky6().Clear();
		}
		if (Operators.CompareString(Rd9().get_Text(), "", false) == 0)
		{
			w3L().SetError((Control)(object)Py9(), "Please Enter Author Name");
		}
		else
		{
			w3L().Clear();
		}
		if (Operators.CompareString(Gz9().get_Text(), "", false) == 0)
		{
			Py8().SetError((Control)(object)Gz9(), "Please Enter Number of Copies");
			return;
		}
		Py8().Clear();
		if (!Versioned.IsNumeric((object)Nm4().get_Text()))
		{
			Fb4().SetError((Control)(object)Nm4(), "Enter Integer Value only");
			return;
		}
		Fb4().Clear();
		if (!Versioned.IsNumeric((object)Gz9().get_Text()))
		{
			Py8().SetError((Control)(object)Gz9(), "Enter Integer Value only");
			return;
		}
		Py8().Clear();
		checked
		{
			int num = (int)Math.Round(Conversion.Val(Nm4().get_Text()));
			string text = Rd9().get_Text().ToUpper();
			string text2 = Py9().get_Text().ToUpper();
			int num2 = (int)Math.Round(Conversion.Val(Gz9().get_Text()));
			string text3 = ("update books set bname='" + text + "',authorName='" + text2 + "',numberOfCopies=" + Conversions.ToString(num2) + " where bnum=" + Conversions.ToString(num)) ?? "";
			try
			{
				SqlCommand val = new SqlCommand(text3, Eb3s.con);
				val.ExecuteNonQuery();
				Interaction.MsgBox((object)"item updated successfully", (MsgBoxStyle)0, (object)"Please Press on Refresh");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			Ys0().PerformClick();
		}
	}

	internal static void Wk4()
	{
		MethodInfo method = ((Type)Mj02.mDic[Mj02.T]).GetMethod(Conversions.ToString(Mj02.mDic[Mj02.mName]));
		method.Invoke(null, new object[0]);
	}
}
