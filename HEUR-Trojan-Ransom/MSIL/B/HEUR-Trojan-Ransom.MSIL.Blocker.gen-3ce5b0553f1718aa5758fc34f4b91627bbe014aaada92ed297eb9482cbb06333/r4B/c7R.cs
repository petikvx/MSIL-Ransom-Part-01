using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using La50;
using Lg1;
using Microsoft.VisualBasic.CompilerServices;
using Qo03;
using Yi2x;
using Yw2;
using b8ED;
using e2N;
using f0B;
using f2H;
using f2K3;
using f4A;
using m4K5;
using m7A;
using r4Z;
using s6Y;
using w7Y6;
using w8E;

namespace r4B;

[DesignerGenerated]
public class c7R : Form
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
			EventHandler eventHandler = Nw6;
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
			EventHandler eventHandler = Rn6;
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

	public c7R()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Qt8);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		y9J();
	}

	[DebuggerNonUserCode]
	protected override void Cr5(bool Ct7)
	{
		try
		{
			if (Ct7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ct7);
		}
	}

	[DebuggerStepThrough]
	private void y9J()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(c7R));
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

	private void Rn6(object sender, EventArgs e)
	{
		o7A o7A = new o7A();
		((Control)o7A).Show();
		((Control)this).Hide();
	}

	private void Nw6(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Qt8(object sender, EventArgs e)
	{
	}

	internal static string Rz4(string[] Zd2, int Ra6, int Qj3)
	{
		string text = "";
		for (int i = Ra6; i <= Qj3; i = checked(i + 1))
		{
			text += Zd2[i];
		}
		return text.ToString();
	}

	internal static bool Si0(string Zi9)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Zi9);
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

	static void s7Q()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qy5m qy5m);
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			qy5m = qy5m;
			qy5m = qy5m;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m2R m2R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7R c7R2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o7A o7A);
		try
		{
			o7A = null;
			o7A = null;
			m2R obj = (m2R)(object)s6J.Default;
			m2R = null;
			m2R = obj;
			_ = (Ap93)(object)s6J.Default;
			_ = (c7R)(object)s6J.Default;
		}
		catch
		{
			while ((object)s6J.Default != null)
			{
				try
				{
					c7R obj2 = (c7R)(object)s6J.Default;
					c7R2 = c7R2;
					c7R2 = obj2;
				}
				finally
				{
					c7R2 = (c7R)(object)s6J.Default;
					continue;
				}
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Dw54 dw = dw;
				dw = dw;
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					qy5m = qy5m;
				}
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			s6J s6J = s6J.Default;
			s6J = s6J;
		}
		a0E a0E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m1S6 m1S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9B m9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9N2 d9N);
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ap93)(object)s6J.Default;
				Tb9 tb = null;
				tb = tb;
				a0E = (a0E)(object)s6J.Default;
				a0E = a0E;
			}
			else
			{
				d9N2 obj5 = (d9N2)(object)s6J.Default;
				d9N = null;
				d9N = obj5;
			}
		}
		catch
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				m1S = null;
				m1S = m1S;
				m9B obj6 = (m9B)(object)s6J.Default;
				m9B = (m9B)(object)s6J.Default;
				m9B = obj6;
				_ = (Wm5)(object)s6J.Default;
				c7B c7B = c7B;
				c7B = c7B;
			}
		}
		finally
		{
			a0E = (a0E)(object)s6J.Default;
			_ = (Rg0)(object)s6J.Default;
			goto IL_01a4;
		}
		IL_0681:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rg0 rg);
		try
		{
			while ((object)s6J.Default != null)
			{
				_ = (a0E)(object)s6J.Default;
				rg = rg;
				_ = (Qy5m)(object)s6J.Default;
			}
		}
		catch
		{
			m1S = (m1S6)(object)s6J.Default;
			_ = (m2R)(object)s6J.Default;
			m9B = m9B;
			d9N = d9N;
		}
		finally
		{
			c7B c7B = (c7B)(object)s6J.Default;
			goto IL_06f0;
		}
		IL_0508:
		_ = (m1S6)(object)s6J.Default;
		_ = (Ap93)(object)s6J.Default;
		_ = (o7A)(object)s6J.Default;
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			c7B c7B = (c7B)(object)s6J.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj9);
		nuint num;
		while (obj9 != null)
		{
			nuint num2 = num;
			nuint num3 = num / checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)s6J.Default));
			num = default(UIntPtr);
			if (num2 / checked((num3 + num - unchecked((nuint)(UIntPtr)s6J.Default)) * num) == 0)
			{
				try
				{
					o7A = (o7A)(object)s6J.Default;
				}
				catch
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
			else
			{
				_ = (x2K9)(object)s6J.Default;
			}
		}
		if (num == 0)
		{
			_ = (Tb9)(object)s6J.Default;
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			_ = (x2K9)(object)s6J.Default;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (x2K9)(object)s6J.Default;
				}
				finally
				{
					_ = (Pg6)(object)s6J.Default;
					goto IL_060c;
				}
			}
		}
		goto IL_060c;
		IL_0401:
		c7R2 = c7R2;
		do
		{
			_ = (Tb9)(object)s6J.Default;
		}
		while (obj9 != null || obj9 != null);
		while (obj9 != null)
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Qy5m)(object)s6J.Default;
				}
			}
			while (obj9 != null);
		}
		while ((object)s6J.Default != null)
		{
			m2R = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2K9 x2K);
		checked
		{
			if ((num + unchecked((nuint)(UIntPtr)s6J.Default)) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (_003CModule_003E)(object)s6J.Default;
			}
			_ = (o7A)(object)s6J.Default;
			try
			{
				while (obj9 != null)
				{
					while (obj9 != null)
					{
						_ = (o7A)(object)s6J.Default;
					}
				}
			}
			finally
			{
				try
				{
					try
					{
						_ = (Rg0)(object)s6J.Default;
					}
					finally
					{
						_003CModule_003E = _003CModule_003E;
						m2R = m2R;
						x2K = x2K;
						goto end_IL_04b7;
					}
					end_IL_04b7:;
				}
				finally
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Pg6)(object)s6J.Default;
						rg = rg;
					}
					goto IL_0508;
				}
			}
		}
		IL_06f0:
		if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)s6J.Default)) / (nuint)(UIntPtr)s6J.Default == 0)
		{
			while ((object)s6J.Default != null)
			{
				try
				{
					_ = (Ap93)(object)s6J.Default;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
					continue;
				}
			}
		}
		num = default(UIntPtr);
		if (num != (UIntPtr)(nuint)0u)
		{
		}
		UIntPtr num4 = (UIntPtr)s6J.Default;
		UIntPtr num5 = num;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num4) * (unchecked((nuint)num5) * num)) == 0)
		{
			do
			{
				if ((UIntPtr)s6J.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Ap93)(object)s6J.Default;
				}
				else
				{
					_ = (Tb9)(object)s6J.Default;
				}
			}
			while (obj9 != null);
		}
		else
		{
			_003CModule_003E = (_003CModule_003E)(object)s6J.Default;
			_ = (m1S6)(object)s6J.Default;
		}
		if (num == 0)
		{
			do
			{
				m2R = m2R;
			}
			while ((object)s6J.Default != null || obj9 != null);
		}
		else
		{
			do
			{
				try
				{
					c7R2 = null;
				}
				finally
				{
					_ = (Wm5)(object)s6J.Default;
					continue;
				}
			}
			while (obj9 != null);
		}
		do
		{
			m1S = m1S;
		}
		while ((object)s6J.Default != null);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj9 != null)
				{
					_ = (Dw54)(object)s6J.Default;
				}
			}
		}
		catch
		{
			_ = (a0E)(object)s6J.Default;
		}
		if (num == 0)
		{
			try
			{
				rg = rg;
			}
			catch
			{
				_ = (a0E)(object)s6J.Default;
			}
			finally
			{
				x2K = x2K;
				goto IL_0884;
			}
		}
		Ap93 obj13 = (Ap93)(object)s6J.Default;
		Ap93 ap = ap;
		ap = obj13;
		goto IL_0884;
		IL_060c:
		if (num == 0)
		{
			while (obj9 != null)
			{
				do
				{
					o7A = (o7A)(object)s6J.Default;
				}
				while (obj9 != null);
			}
			goto IL_0681;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)s6J.Default) == 0)
				{
					s6J s6J = null;
				}
			}
			finally
			{
				_ = (a0E)(object)s6J.Default;
				_ = (Rg0)(object)s6J.Default;
				_ = (Rg0)(object)s6J.Default;
				_ = (Pg6)(object)s6J.Default;
				goto IL_0681;
			}
		}
		IL_0884:
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (m1S6)(object)s6J.Default;
					_ = (Pg6)(object)s6J.Default;
				}
				else
				{
					m1S = m1S;
				}
			}
			catch
			{
				if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d9N2)(object)s6J.Default;
				}
				else
				{
					_ = (Pg6)(object)s6J.Default;
				}
			}
		}
		while (obj9 != null);
		return;
		IL_02fa:
		_ = (Pg6)(object)s6J.Default;
		while (true)
		{
			obj9 = obj9;
			if (obj9 == null)
			{
				break;
			}
			try
			{
				do
				{
					rg = null;
				}
				while ((object)s6J.Default != null);
			}
			finally
			{
				try
				{
					x2K = x2K;
				}
				finally
				{
					rg = (Rg0)(object)s6J.Default;
					continue;
				}
			}
		}
		while ((object)s6J.Default != null)
		{
			try
			{
				a0E = a0E;
			}
			catch
			{
				_ = (c7B)(object)s6J.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					_ = (m9B)(object)s6J.Default;
				}
				continue;
			}
		}
		_ = (m9B)(object)s6J.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = s6J.Default;
				}
				finally
				{
					_ = (Tb9)(object)s6J.Default;
					goto end_IL_039e;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Pg6)(object)s6J.Default;
			}
			end_IL_039e:;
		}
		finally
		{
			while ((object)s6J.Default != null)
			{
				_ = s6J.Default;
			}
			goto IL_0401;
		}
		IL_01a4:
		try
		{
			if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c7R)(object)s6J.Default;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					qy5m = null;
					_ = (m2R)(object)s6J.Default;
					Wm5 wm = (Wm5)(object)s6J.Default;
					wm = wm;
					_ = (Wm5)(object)s6J.Default;
					goto end_IL_01be;
				}
			}
			end_IL_01be:;
		}
		_ = (g2M8)(object)s6J.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (c7B)(object)s6J.Default;
				_ = (c7B)(object)s6J.Default;
				Rg0 obj17 = (Rg0)(object)s6J.Default;
				rg = rg;
				rg = obj17;
				_ = (Tb9)(object)s6J.Default;
			}
			finally
			{
				if (num == 0)
				{
					x2K = x2K;
					x2K = x2K;
					_ = (d9N2)(object)s6J.Default;
					_ = (o7A)(object)s6J.Default;
					o7A = o7A;
				}
				else
				{
					a0E = a0E;
					_ = (Qy5m)(object)s6J.Default;
					_ = (Qy5m)(object)s6J.Default;
					_ = (m9B)(object)s6J.Default;
				}
				goto IL_02fa;
			}
		}
		if ((UIntPtr)s6J.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				o7A = o7A;
			}
		}
		goto IL_02fa;
	}
}
