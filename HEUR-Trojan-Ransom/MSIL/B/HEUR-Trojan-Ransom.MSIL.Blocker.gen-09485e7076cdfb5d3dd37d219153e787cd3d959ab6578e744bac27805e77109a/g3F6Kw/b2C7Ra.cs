using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jy6q0;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pm16Qi;
using Rz65H;
using Wt7x6;
using b1ZEe;
using e2HBc;
using e6H4A;
using f1E5B;
using s3FEz;
using w5C3Yf;
using x7X6P;

namespace g3F6Kw;

[DesignerGenerated]
public class b2C7Ra : Form
{
	private IContainer components;

	private int m_ChildFormNumber;

	internal virtual object btn_PrintCreceipts
	{
		[CompilerGenerated]
		get
		{
			return _btn_PrintCreceipts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_PrintCreceipts = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btn_save
	{
		[CompilerGenerated]
		get
		{
			return _btn_save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_save = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public b2C7Ra()
	{
		a7L3Ps();
	}

	[DebuggerNonUserCode]
	protected override void Ni13Lb(bool Ym3k9L)
	{
		try
		{
			if (Ym3k9L && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ym3k9L);
		}
	}

	[DebuggerStepThrough]
	private void a7L3Ps()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		btn_PrintCreceipts = RuntimeHelpers.GetObjectValue(new object());
		btn_save = RuntimeHelpers.GetObjectValue(new object());
		Panel1 = new Panel();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "ButtonText", new object[1] { "CANCEL" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Location", new object[1]
		{
			new Point(249, 529)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Name", new object[1] { "btn_PrintCreceipts" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "TabIndex", new object[1] { 58 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Text", new object[1] { "CANCEL" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_PrintCreceipts, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "ButtonText", new object[1] { "SAVE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Location", new object[1]
		{
			new Point(404, 529)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Name", new object[1] { "btn_save" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "TabIndex", new object[1] { 57 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Text", new object[1] { "SAVE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_save, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).set_Location(new Point(2, 1));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(538, 520));
		((Control)Panel1).set_TabIndex(59);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(552, 578));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)btn_PrintCreceipts);
		((Control)this).get_Controls().Add((Control)btn_save);
		((Control)this).set_Name("proceespayment");
		((Control)this).ResumeLayout(false);
	}

	private void b7ERi6(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		m_ChildFormNumber++;
		val.set_Text("Window " + Conversions.ToString(m_ChildFormNumber));
		((Control)val).Show();
	}

	private void z0YCb8(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)f3A8X.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void p4G7Rm(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)f3A8X.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void f9EQp7(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void k1KZo9(object sender, EventArgs e)
	{
	}

	private void Zc0n9K(object sender, EventArgs e)
	{
	}

	private void Lo59Df(object sender, EventArgs e)
	{
	}

	private void Kf7e5J(object sender, EventArgs e)
	{
	}

	private void w8M9Qg(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void x0C3Hk(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void Fo0e3S(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void Cg90Tb(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void Bn3q6H(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}

	internal static object i5NKj7(object y6SCq3, object Ej02Ng)
	{
		return new byte[Conversions.ToInteger(Operators.SubtractObject(y6SCq3, (object)1)) + 1];
	}

	static void d7FWp1()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q6RLm q6RLm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Gz24H gz24H);
			while (true)
			{
				obj = ((q6RLm)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection).db_lccsams_connection;
				if (obj == null)
				{
					break;
				}
				try
				{
					num = num;
					num = default(UIntPtr);
					nuint num2 = num;
					num = default(UIntPtr);
					if (num2 - num == 0)
					{
						q6RLm = q6RLm;
						_ = (b2C7Ra)(object)q6RLm.db_lccsams_connection;
					}
					else
					{
						Gz24H obj2 = (Gz24H)(object)q6RLm.Default;
						gz24H = gz24H;
						gz24H = obj2;
					}
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)q6RLm.Default) + (num + unchecked((nuint)(UIntPtr)q6RLm.Default.db_lccsams_connection)) == 0)
					{
						_ = (m9X1Q)(object)q6RLm.Default;
					}
				}
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (f3A8X)(object)q6RLm.Default;
			}
		}
		catch
		{
			if ((UIntPtr)q6RLm.Default.db_lccsams_connection == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (b2C7Ra)(object)((q6RLm)(object)((q6RLm)null).db_lccsams_connection).db_lccsams_connection;
				}
			}
			else
			{
				_ = (Jo81Es)(object)q6RLm.Default.db_lccsams_connection;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9Z4Y q9Z4Y);
		try
		{
			try
			{
				if (num == 0)
				{
					o7Z3F o7Z3F = null;
					o7Z3F = o7Z3F;
				}
			}
			catch
			{
				try
				{
					_ = (Fa35A)(object)q6RLm.db_lccsams_connection;
				}
				catch
				{
					q9Z4Y obj5 = (q9Z4Y)(object)q6RLm.Default.db_lccsams_connection;
					q9Z4Y = q9Z4Y;
					q9Z4Y = obj5;
				}
			}
		}
		catch
		{
			e3S6Df e3S6Df = e3S6Df;
			e3S6Df = e3S6Df;
		}
		Fa35A fa35A = (Fa35A)(object)q6RLm.Default;
		fa35A = fa35A;
		_ = (Jo81Es)(object)((q6RLm)null).db_lccsams_connection;
		Jy86G jy86G = jy86G;
		jy86G = jy86G;
		if (num == 0)
		{
			_ = (Gz24H)(object)q6RLm.db_lccsams_connection;
		}
		do
		{
			_ = q6RLm.Default;
		}
		while ((object)q6RLm.Default != null);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = q6RLm.Default;
				}
				while (obj != null);
			}
			else
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / num == 0)
				{
					q9Z4Y = q9Z4Y;
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (o7Z3F)(object)q6RLm.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2C7Ra b2C7Ra2);
		if (num == 0)
		{
			try
			{
				try
				{
					b2C7Ra2 = b2C7Ra2;
					b2C7Ra2 = b2C7Ra2;
				}
				finally
				{
					Tq6g2 tq6g = tq6g;
					tq6g = null;
					goto end_IL_028d;
				}
				end_IL_028d:;
			}
			finally
			{
				if (num == 0)
				{
					_ = (Tq6g2)(object)q6RLm.Default;
				}
				goto IL_02c4;
			}
		}
		goto IL_02c4;
		IL_02c4:
		try
		{
			if (num == 0)
			{
				Gz24H gz24H = null;
			}
		}
		catch
		{
			try
			{
				f3A8X f3A8X = f3A8X;
				f3A8X = f3A8X;
			}
			catch
			{
				b2C7Ra2 = b2C7Ra2;
			}
		}
	}
}
