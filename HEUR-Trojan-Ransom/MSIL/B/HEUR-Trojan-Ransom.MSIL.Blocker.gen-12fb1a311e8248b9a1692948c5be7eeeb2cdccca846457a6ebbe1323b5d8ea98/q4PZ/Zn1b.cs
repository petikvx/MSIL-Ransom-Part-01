using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
using a3S0;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using s6N8;
using w0WN;
using x5PX;

namespace q4PZ;

[DesignerGenerated]
public class Zn1b : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n5HW;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z8ZB;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Zn1b()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)b3A9);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		f3B7();
	}

	[DebuggerNonUserCode]
	protected override void q7TR(bool Fi70)
	{
		try
		{
			if (Fi70 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fi70);
		}
	}

	[DebuggerStepThrough]
	private void f3B7()
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
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Zn1b));
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(364, 27));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(107, 17));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("About System");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(727, 27));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(14);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(35, 27));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Go To Main");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(189, 104));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(469, 346));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(15);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(170, 65));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(446, 17));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("One fully-integrated software solution to manage your entire business");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmBillingDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmBillingDetail");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void z8ZB(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void n5HW(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void b3A9(object sender, EventArgs e)
	{
	}

	internal static string x8PG(string[] Yz6i, int g7Y6, int g0EM)
	{
		string text = "";
		for (int i = g7Y6; i <= g0EM; i = checked(i + 1))
		{
			text += Yz6i[i];
		}
		string result = text.ToString();
		Tf67.byte_0[107] = (byte)((Tf67.byte_0[107] ^ Hi84.char_0[591]) & 0xA1);
		return result;
	}

	internal static bool Qi85(string q2NS)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(q2NS);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	static void Yz1a()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = o0E3.Default;
			_ = (w1H)(object)o0E3.Default;
			obj = obj;
		}
		while (obj != null);
		_ = (Sf06)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			do
			{
				try
				{
					w0A = w0A;
					w0A = w0A;
				}
				finally
				{
					_ = (x4N6)(object)o0E3.Default;
					continue;
				}
			}
			while ((object)o0E3.Default != null);
		}
		catch
		{
			do
			{
				uIntPtr = uIntPtr;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gn = gn;
					gn = null;
				}
			}
			while ((object)o0E3.Default != null);
		}
		_ = (Zn1b)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		do
		{
			i5NX = i5NX;
			i5NX = i5NX;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		checked
		{
			try
			{
				_ = (w0A)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				_ = (w1H)(object)o0E3.Default;
			}
			catch
			{
				try
				{
					try
					{
						k0WR k0WR = k0WR;
						k0WR = k0WR;
					}
					finally
					{
						w0A = (w0A)(object)o0E3.Default;
						goto end_IL_00d2;
					}
					end_IL_00d2:;
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
						_ = (w0A)(object)o0E3.Default;
					}
				}
			}
			w0A = w0A;
			_ = (Tf67)(object)o0E3.Default;
			_ = (Tf67)(object)o0E3.Default;
			_ = (x4N6)(object)o0E3.Default;
			try
			{
				_ = (Tf67)(object)o0E3.Default;
			}
			catch
			{
				while (obj != null)
				{
					w8W = default(w8W);
					w8W = default(w8W);
				}
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
				else
				{
					_ = (k0WR)(object)o0E3.Default;
				}
			}
			finally
			{
				_ = (k0WR)(object)o0E3.Default;
				goto end_IL_0184;
			}
			end_IL_0184:;
		}
		finally
		{
			gn = gn;
			goto IL_01c4;
		}
		IL_076d:
		_ = (k4C9)(object)o0E3.Default;
		if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
		{
			do
			{
				try
				{
					_ = o0E3.Default;
				}
				finally
				{
					_ = o0E3.Default;
					continue;
				}
			}
			while (obj != null);
		}
		else
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		_ = (Zn1b)(object)o0E3.Default;
		try
		{
			do
			{
				_ = o0E3.Default;
			}
			while (obj != null);
			return;
		}
		finally
		{
			try
			{
				do
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
				while (obj != null);
				return;
			}
			catch
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
					return;
				}
				catch
				{
					i5NX = null;
					return;
				}
			}
		}
		IL_0367:
		do
		{
			UIntPtr num = (UIntPtr)o0E3.Default;
			uIntPtr = default(UIntPtr);
			nuint num2;
			checked
			{
				num2 = (unchecked((nuint)num) - uIntPtr) * uIntPtr;
				uIntPtr = default(UIntPtr);
			}
			if (num2 / uIntPtr == 0)
			{
				do
				{
					w0A = (w0A)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		try
		{
			do
			{
				_ = o0E3.Default;
			}
			while (obj != null);
		}
		catch
		{
			while ((object)o0E3.Default != null)
			{
				hi = hi;
				hi = null;
			}
		}
		_ = (f5R4)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		while ((object)o0E3.Default != null)
		{
			try
			{
				w8W = w8W;
			}
			finally
			{
				try
				{
					p9B = p9B;
					p9B = p9B;
					_ = (Pg2c)(object)o0E3.Default;
				}
				catch
				{
					pg2c = (Pg2c)(object)o0E3.Default;
				}
				continue;
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				w8W = (w8W)o0E3.Default;
			}
		}
		p9B = p9B;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		while (obj != null)
		{
			try
			{
				try
				{
					gn = (Gn76)(object)o0E3.Default;
					dg = (Dg19)(object)o0E3.Default;
					w1H w1H = (w1H)(object)o0E3.Default;
					w1H = w1H;
				}
				finally
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					goto end_IL_045b;
				}
				end_IL_045b:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				else
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		do
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					w8W = w8W;
					continue;
				}
				zn1b = (Zn1b)(object)o0E3.Default;
				zn1b = zn1b;
				_ = (Pg2c)(object)o0E3.Default;
				_ = (f5R4)(object)o0E3.Default;
				w1H w1H = (w1H)(object)o0E3.Default;
			}
		}
		while ((object)o0E3.Default != null);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					pg2c = (Pg2c)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		else
		{
			_ = (k4C9)(object)o0E3.Default;
		}
		while (obj != null)
		{
			try
			{
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				continue;
			}
		}
		hi = (Hi84)(object)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			pg2c = pg2c;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		checked
		{
			while (obj != null)
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr == 0)
					{
						_ = (Sf06)(object)o0E3.Default;
						_ = (Gn76)(object)o0E3.Default;
						a9X = a9X;
						a9X = null;
					}
					else
					{
						_ = (p9B)(object)o0E3.Default;
					}
				}
				catch
				{
					do
					{
						_ = (w1H)(object)o0E3.Default;
					}
					while (obj != null);
				}
			}
			_ = (k0WR)(object)o0E3.Default;
			_ = (Pg2c)(object)o0E3.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr + uIntPtr * uIntPtr == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
				while (obj != null)
				{
					try
					{
						p9B = (p9B)(object)o0E3.Default;
					}
					catch
					{
						o0E = o0E;
						o0E = o0E;
					}
				}
			}
		}
		if (uIntPtr == 0 && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			pg2c = null;
		}
		while (obj != null)
		{
			do
			{
				dg = dg;
			}
			while (obj != null || obj != null);
		}
		w0A = w0A;
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (w8W)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
		}
		catch
		{
			_ = (f5R4)(object)o0E3.Default;
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr != 0)
			{
				try
				{
					_ = (w0A)(object)o0E3.Default;
				}
				finally
				{
					gn = gn;
					goto IL_076d;
				}
			}
			_ = (Sf06)(object)o0E3.Default;
			zn1b = zn1b;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					a9X = a9X;
				}
			}
		}
		goto IL_076d;
		IL_01c4:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				finally
				{
					_ = (k4C9)(object)o0E3.Default;
					_ = (Tf67)(object)o0E3.Default;
					goto IL_0227;
				}
			}
			pg2c = pg2c;
			pg2c = pg2c;
		}
		else
		{
			_ = (x4N6)(object)o0E3.Default;
			_ = (x4N6)(object)o0E3.Default;
		}
		goto IL_0227;
		IL_0227:
		UIntPtr num3 = (UIntPtr)o0E3.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num3) + uIntPtr != 0 || (uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default)) * ((unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default)) * (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + uIntPtr == 0)
				{
					do
					{
						_ = (_003CModule_003E)(object)o0E3.Default;
					}
					while (obj != null);
				}
			}
			while (obj != null);
			if (unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				w8W = (w8W)o0E3.Default;
				_003CModule_003E _003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
				goto IL_0367;
			}
		}
		try
		{
			while ((object)o0E3.Default != null)
			{
				Et0 et = (Et0)o0E3.Default;
				et = default(Et0);
			}
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (w0A)(object)o0E3.Default;
			}
			else
			{
				dg = null;
				dg = dg;
			}
			goto IL_0367;
		}
	}

	static void x4MK()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			tf = tf;
			tf = null;
			_ = (w8W)o0E3.Default;
			_ = (Sf06)(object)o0E3.Default;
		}
		else
		{
			k4C9 k4C = k4C;
			k4C = null;
		}
		nuint num = default(UIntPtr);
		if (num == 0)
		{
			f5R4 f5R = f5R;
			f5R = f5R;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		checked
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)o0E3.Default) + (unchecked(num / num) + unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
				{
					_ = (k4C9)(object)o0E3.Default;
					_ = (Tf67)(object)o0E3.Default;
				}
				else
				{
					while (true)
					{
						obj = obj;
						if (obj != null)
						{
							_ = (Zn1b)(object)o0E3.Default;
							continue;
						}
						break;
					}
				}
				goto IL_00ce;
			}
		}
		IL_0253:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		try
		{
			try
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_0255;
				}
				end_IL_0255:;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w1H)(object)o0E3.Default;
				}
				else
				{
					sf = null;
				}
				goto end_IL_0254;
			}
			end_IL_0254:;
		}
		catch
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
				while (obj != null)
				{
					et = et;
					et = et;
				}
			}
			finally
			{
				_ = (p9B)(object)o0E3.Default;
				goto end_IL_0291;
			}
			end_IL_0291:;
		}
		while (obj != null)
		{
			_ = (w1H)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				f5R4 f5R = (f5R4)(object)o0E3.Default;
			}
			finally
			{
				if (num == 0)
				{
					p9B p9B = (p9B)(object)o0E3.Default;
					p9B = p9B;
				}
				goto IL_0307;
			}
		}
		goto IL_0307;
		IL_05fb:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		try
		{
			do
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Et0)o0E3.Default;
				}
				else
				{
					hi = null;
				}
			}
			while (obj != null);
		}
		catch
		{
		}
		_ = (i5NX)(object)o0E3.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				else
				{
					k0WR k0WR = null;
				}
			}
			else
			{
				do
				{
					_ = (i5NX)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					pg2c = pg2c;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					hi = hi;
				}
				finally
				{
					o0E3 o0E = o0E3.Default;
					a9X = null;
					Et0 et = default(Et0);
					goto end_IL_06a2;
				}
				end_IL_06a2:;
			}
			finally
			{
				try
				{
					w0A = w0A;
				}
				catch
				{
					_ = (Tf67)(object)o0E3.Default;
					_ = (Dg19)(object)o0E3.Default;
					_ = (w8W)o0E3.Default;
				}
				goto end_IL_06a1;
			}
			end_IL_06a1:;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			x4N6 x4N = null;
			_ = (w1H)(object)o0E3.Default;
			hi = hi;
		}
		else
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		do
		{
			try
			{
				try
				{
					pg2c = pg2c;
				}
				finally
				{
					w8W w8W = default(w8W);
					goto end_IL_0740;
				}
				end_IL_0740:;
			}
			finally
			{
				_ = (w1H)(object)o0E3.Default;
				continue;
			}
		}
		while (obj != null);
		return;
		IL_01f3:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					a9X = null;
					a9X = a9X;
				}
				finally
				{
					_ = (g9Z)(object)o0E3.Default;
					goto end_IL_01f4;
				}
			}
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (w0A)(object)o0E3.Default;
			}
			else
			{
				_ = (Pg2c)(object)o0E3.Default;
			}
			end_IL_01f4:;
		}
		finally
		{
			_ = (g9Z)(object)o0E3.Default;
			goto IL_0253;
		}
		IL_0507:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		try
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gn = (Gn76)(object)o0E3.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
			do
			{
				_ = (Tf67)(object)o0E3.Default;
				_ = (g9Z)(object)o0E3.Default;
				tf = tf;
			}
			while ((object)o0E3.Default != null);
		}
		gn = (Gn76)(object)o0E3.Default;
		sf = sf;
		_ = (k4C9)(object)o0E3.Default;
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj != null);
		try
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				finally
				{
					w0A = null;
					continue;
				}
			}
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = o0E3.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (w1H)(object)o0E3.Default;
			}
			goto IL_05fb;
		}
		IL_03bb:
		try
		{
			if (num == 0)
			{
				w1H w1H = null;
			}
		}
		catch
		{
			while ((object)o0E3.Default != null)
			{
				do
				{
					pg2c = pg2c;
					_ = (Et0)o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null)
		{
			a9X = a9X;
		}
		checked
		{
			do
			{
				if ((unchecked((nuint)(UIntPtr)o0E3.Default) + num) * (unchecked((nuint)(UIntPtr)o0E3.Default) + num) != 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (w1H)(object)o0E3.Default;
					}
				}
				else
				{
					_ = (Et0)o0E3.Default;
				}
			}
			while ((object)o0E3.Default != null);
			try
			{
				num = default(UIntPtr);
				if (num + num == 0)
				{
					do
					{
						_ = (w1H)(object)o0E3.Default;
					}
					while (obj != null);
				}
				else
				{
					Gn76 obj9 = (Gn76)(object)o0E3.Default;
					gn = gn;
					gn = obj9;
					tf = tf;
				}
			}
			finally
			{
				try
				{
					UIntPtr num2 = unchecked((UIntPtr)o0E3.Default);
					num = default(UIntPtr);
					if (unchecked((nuint)num2) * num * num == 0)
					{
						k4C9 k4C = (k4C9)(object)o0E3.Default;
					}
				}
				finally
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
						gn = gn;
					}
					goto IL_0507;
				}
			}
		}
		IL_00ce:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			finally
			{
				try
				{
					_ = (f5R4)(object)o0E3.Default;
				}
				finally
				{
					_ = (g9Z)(object)o0E3.Default;
					goto IL_0108;
				}
			}
		}
		goto IL_0108;
		IL_0307:
		_ = (w8W)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				hi = (Hi84)(object)o0E3.Default;
				hi = hi;
				_ = (Zn1b)(object)o0E3.Default;
				_ = (Zn1b)(object)o0E3.Default;
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				w1H obj11 = (w1H)(object)o0E3.Default;
				w1H w1H = w1H;
				w1H = obj11;
			}
			catch
			{
				o0E3 o0E = o0E3.Default;
			}
		}
		_ = o0E3.Default;
		_ = (k0WR)(object)o0E3.Default;
		try
		{
			pg2c = pg2c;
			pg2c = null;
		}
		finally
		{
			try
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			finally
			{
				_ = (Tf67)(object)o0E3.Default;
				goto IL_03bb;
			}
		}
		IL_0108:
		if (num == 0)
		{
			o0E3 o0E = o0E;
			o0E = o0E;
		}
		else if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		else
		{
			x4N6 x4N = x4N;
			x4N = null;
		}
		try
		{
			try
			{
				sf = sf;
				sf = null;
			}
			finally
			{
				_ = (x4N6)(object)o0E3.Default;
				goto end_IL_014d;
			}
			end_IL_014d:;
		}
		catch
		{
			_ = (w8W)o0E3.Default;
		}
		try
		{
			try
			{
				w0A = (w0A)(object)o0E3.Default;
				w0A = w0A;
			}
			finally
			{
				_ = (Tf67)(object)o0E3.Default;
				goto end_IL_017c;
			}
			end_IL_017c:;
		}
		catch
		{
			while ((object)o0E3.Default != null)
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
		}
		finally
		{
			if (num == 0)
			{
				k0WR k0WR = k0WR;
				k0WR = k0WR;
			}
			else
			{
				do
				{
					_ = (Hi84)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			goto IL_01f3;
		}
	}

	static void Tt38()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		while ((object)o0E3.Default != null)
		{
			try
			{
				_ = (Gn76)(object)o0E3.Default;
			}
			catch
			{
				do
				{
					zn1b = zn1b;
					zn1b = null;
				}
				while ((object)o0E3.Default != null);
			}
		}
		UIntPtr uIntPtr;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = (UIntPtr)o0E3.Default;
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				finally
				{
					_ = (w1H)(object)o0E3.Default;
					goto IL_008b;
				}
			}
			_ = (a9X)(object)o0E3.Default;
		}
		goto IL_008b;
		IL_014f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		Dg19 dg;
		try
		{
			sf = sf;
			sf = sf;
			dg = null;
			dg = null;
			a9X = a9X;
		}
		catch
		{
			w1H = w1H;
			w1H = w1H;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		try
		{
			checked
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default) != 0)
					{
						_ = (Dg19)(object)o0E3.Default;
					}
					else
					{
						_ = (w8W)o0E3.Default;
					}
				}
				while (obj3 != null);
			}
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
			{
				pg2c = pg2c;
				pg2c = null;
			}
			goto IL_01e7;
		}
		IL_0630:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				dg = (Dg19)(object)o0E3.Default;
			}
			else
			{
				_ = (g9Z)(object)o0E3.Default;
				dg = (Dg19)(object)o0E3.Default;
				_ = (w1H)(object)o0E3.Default;
				_ = (Sf06)(object)o0E3.Default;
			}
		}
		else
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				finally
				{
					gn = gn;
					_ = (x4N6)(object)o0E3.Default;
					_ = (Gn76)(object)o0E3.Default;
					x4N6 x4N = null;
					continue;
				}
			}
		}
		_ = (Et0)o0E3.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default / uIntPtr) * uIntPtr != 0)
			{
				return;
			}
			try
			{
				return;
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					return;
				}
				catch
				{
					_ = (f5R4)(object)o0E3.Default;
					return;
				}
			}
		}
		IL_01e7:
		if (uIntPtr == 0 && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while ((object)o0E3.Default != null)
		{
			try
			{
				k0WR = k0WR;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		try
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		catch
		{
			try
			{
				o0E = o0E;
			}
			finally
			{
				zn1b = (Zn1b)(object)o0E3.Default;
				goto end_IL_024d;
			}
			end_IL_024d:;
		}
		_ = (k4C9)(object)o0E3.Default;
		Tf67 tf = (Tf67)(object)o0E3.Default;
		tf = null;
		_ = (a9X)(object)o0E3.Default;
		_ = (Dg19)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (i5NX)(object)o0E3.Default;
					_ = (x4N6)(object)o0E3.Default;
					hi = null;
					hi = hi;
					i5NX = i5NX;
					i5NX = i5NX;
				}
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					p9B = null;
					p9B = null;
				}
			}
		}
		w0A w0A = (w0A)(object)o0E3.Default;
		w0A = w0A;
		w1H = null;
		g9Z g9Z = g9Z;
		g9Z = g9Z;
		_ = (g9Z)(object)o0E3.Default;
		while ((object)o0E3.Default != null)
		{
			_ = (w8W)o0E3.Default;
		}
		try
		{
			_ = (i5NX)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				w1H = w1H;
			}
			finally
			{
				do
				{
					_ = (w1H)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
				goto IL_039e;
			}
		}
		IL_039e:
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				zn1b = zn1b;
			}
			else if (uIntPtr == 0)
			{
				_ = (Pg2c)(object)o0E3.Default;
			}
			else
			{
				a9X = a9X;
				tf = tf;
				_ = o0E3.Default;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				i5NX = null;
			}
		}
		g9Z = g9Z;
		try
		{
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			tf = (Tf67)(object)o0E3.Default;
			i5NX = (i5NX)(object)o0E3.Default;
			_ = (g9Z)(object)o0E3.Default;
			_ = (i5NX)(object)o0E3.Default;
		}
		_ = (f5R4)(object)o0E3.Default;
		checked
		{
			while (obj3 != null)
			{
				if (unchecked((nuint)(UIntPtr)o0E3.Default) * uIntPtr == 0)
				{
					try
					{
						_ = (x4N6)(object)o0E3.Default;
					}
					catch
					{
						_ = (i5NX)(object)o0E3.Default;
					}
				}
			}
			dg = null;
			i5NX = i5NX;
			_ = (Et0)o0E3.Default;
			w8W w8W = w8W;
			w8W = w8W;
			hi = hi;
			sf = sf;
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (f5R4)(object)o0E3.Default;
		}
		else
		{
			pg2c = pg2c;
		}
		o0E = o0E;
		do
		{
			try
			{
				try
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				catch
				{
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					w1H = w1H;
				}
				else
				{
					hi = hi;
				}
			}
		}
		while (obj3 != null);
		if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (i5NX)(object)o0E3.Default;
			}
		}
		else
		{
			hi = (Hi84)(object)o0E3.Default;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					k0WR = (k0WR)(object)o0E3.Default;
					_ = o0E3.Default;
					_003CModule_003E = null;
				}
				while (obj3 != null);
			}
			else
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
					g9Z = null;
					dg = null;
					zn1b = zn1b;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
		}
		finally
		{
			try
			{
				pg2c = (Pg2c)(object)o0E3.Default;
			}
			finally
			{
				do
				{
					p9B = p9B;
				}
				while ((object)o0E3.Default != null);
				goto IL_05f3;
			}
		}
		IL_05f3:
		try
		{
			_ = (Tf67)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				_ = (f5R4)(object)o0E3.Default;
			}
			catch
			{
				try
				{
					dg = dg;
				}
				finally
				{
					gn = gn;
					gn = gn;
					goto end_IL_060f;
				}
				end_IL_060f:;
			}
			goto IL_0630;
		}
		IL_008b:
		try
		{
			try
			{
				k0WR = null;
				k0WR = k0WR;
			}
			catch
			{
				_ = (k4C9)(object)o0E3.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Gn76)(object)o0E3.Default;
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				x4N6 obj16 = (x4N6)(object)o0E3.Default;
				x4N6 x4N = x4N;
				x4N = obj16;
			}
			goto IL_00f8;
		}
		IL_00f8:
		try
		{
			o0E = null;
			o0E = o0E;
			a9X obj17 = (a9X)(object)o0E3.Default;
			a9X = a9X;
			a9X = obj17;
			_ = (p9B)(object)o0E3.Default;
		}
		finally
		{
			while (obj3 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (k0WR)(object)o0E3.Default;
				}
			}
			goto IL_014f;
		}
	}
}
