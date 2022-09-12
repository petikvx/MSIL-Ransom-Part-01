using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Dy1a;
using Gb1;
using Hc8;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic.CompilerServices;
using Qw80;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using q3F;
using q8X;
using z2Z;

namespace p0H;

[DesignerGenerated]
public class m0N : Form
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
			EventHandler eventHandler = Se1;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			Label obj = label;
			Pj8.byte_0[23] = (byte)((Pj8.byte_0[23] | Pj8.byte_0[55]) & 0x6B);
			if (obj != null)
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
			EventHandler eventHandler = z2P;
			Label label = _Label7;
			Label obj = label;
			Mb5.char_0[209] = (char)((Mb5.char_0[209] + Mb5.char_0[115]) & '\u008d');
			if (obj != null)
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

	public m0N()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Rn5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Tt4();
	}

	[DebuggerNonUserCode]
	protected override void q5C(bool Df1)
	{
		try
		{
			if (Df1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Df1);
		}
	}

	[DebuggerStepThrough]
	private void Tt4()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(m0N));
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

	private void z2P(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void Se1(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Rn5(object sender, EventArgs e)
	{
	}

	internal static string Pi1(string[] p6R, int Gb7, int Xj2)
	{
		string text = "";
		for (int i = Gb7; i <= Xj2; i = checked(i + 1))
		{
			text += p6R[i];
		}
		return text.ToString();
	}

	internal static bool j9T(string k2D)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(k2D);
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

	static void Lx5()
	{
		_ = (Gj4)Nf2.Default;
		Pm9 obj = (Pm9)(object)Nf2.Default;
		Pm9 pm = pm;
		pm = obj;
		Nf2 nf = nf;
		nf = nf;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		try
		{
			num = (UIntPtr)Nf2.Default;
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					d1X obj2 = (d1X)(object)Nf2.Default;
					d1X = d1X;
					d1X = obj2;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					_003CModule_003E = _003CModule_003E;
					obj3 = obj3;
				}
				while (obj3 != null);
			}
			else if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) * num) == 0)
			{
				gj = (Gj4)Nf2.Default;
				gj = default(Gj4);
			}
			else
			{
				f0F = (f0F)(object)Nf2.Default;
				f0F = f0F;
				co = null;
				co = co;
				r8M = r8M;
				r8M = default(r8M);
				_ = (Pm9)(object)Nf2.Default;
			}
			goto IL_0129;
		}
		IL_0129:
		try
		{
		}
		catch
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
		try
		{
			try
			{
				if (num == 0)
				{
					_ = Nf2.Default;
					r8M = r8M;
				}
				else
				{
					eb = eb;
					eb = eb;
				}
			}
			finally
			{
				while ((object)Nf2.Default != null)
				{
					_ = (d1X)(object)Nf2.Default;
				}
				goto end_IL_013b;
			}
			end_IL_013b:;
		}
		finally
		{
			try
			{
				_ = (d1X)(object)Nf2.Default;
			}
			finally
			{
				_ = (d1X)(object)Nf2.Default;
				goto IL_01cc;
			}
		}
		IL_0370:
		try
		{
			try
			{
				do
				{
					_ = (w4R)(object)Nf2.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				if (num == 0)
				{
					d1X = d1X;
				}
				goto end_IL_0371;
			}
			end_IL_0371:;
		}
		catch
		{
			nuint num2 = num;
			num = default(UIntPtr);
			if (checked(num2 * num) == 0)
			{
				do
				{
					d1X = d1X;
				}
				while ((object)Nf2.Default != null);
			}
		}
		_ = (Pj8)(object)Nf2.Default;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				co = co;
			}
			finally
			{
				do
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
				goto IL_0428;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		do
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				d8B = null;
				d8B = d8B;
			}
		}
		while (obj3 != null);
		goto IL_0428;
		IL_01cc:
		while (obj3 != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Gj4)Nf2.Default;
			}
			else
			{
				_ = (f2L)(object)Nf2.Default;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (f2L)(object)Nf2.Default;
				}
				finally
				{
					goto end_IL_01d3;
				}
			}
			end_IL_01d3:;
		}
		catch
		{
			_ = (o5CZ)(object)Nf2.Default;
		}
		_ = (Pj8)(object)Nf2.Default;
		_ = (Np8)(object)Nf2.Default;
		if (num == 0)
		{
			if (num == 0)
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj3 != null);
			}
		}
		else
		{
			_ = (Gj4)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		try
		{
			if (num != 0)
			{
				try
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				finally
				{
					o5CZ obj7 = (o5CZ)(object)Nf2.Default;
					o5CZ = o5CZ;
					o5CZ = obj7;
					goto end_IL_023d;
				}
			}
			x8D9 x8D = x8D;
			x8D = null;
			end_IL_023d:;
		}
		finally
		{
			while (true)
			{
				if ((object)Nf2.Default != null)
				{
					gj = default(Gj4);
				}
				else if (obj3 == null)
				{
					break;
				}
			}
			goto IL_02a7;
		}
		IL_0428:
		_ = (Gj4)Nf2.Default;
		_ = (x8D9)(object)Nf2.Default;
		_ = (m0N)(object)Nf2.Default;
		checked
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					num = default(UIntPtr);
					if (num + (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
					{
						_ = (f9T6)(object)Nf2.Default;
					}
					else
					{
						_ = (Np8)(object)Nf2.Default;
					}
				}
				finally
				{
					try
					{
						d8B = d8B;
						gj = gj;
						eb = (Eb1)(object)Nf2.Default;
					}
					catch
					{
						_ = (Gj4)Nf2.Default;
					}
					continue;
				}
			}
			d8B = (d8B)(object)Nf2.Default;
			nf = null;
			d8B = null;
			try
			{
				num = default(UIntPtr);
				nuint num3 = num;
				num = default(UIntPtr);
				if (num3 + num == 0)
				{
					_ = (d8B)(object)Nf2.Default;
				}
			}
			catch
			{
				_ = (o5CZ)(object)Nf2.Default;
			}
			finally
			{
				if (num == 0)
				{
					try
					{
						f2L f2L = f2L;
					}
					finally
					{
						pm = pm;
						goto IL_053f;
					}
				}
				_003CModule_003E = null;
				goto IL_053f;
			}
		}
		IL_02a7:
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) * num != 0)
				{
					try
					{
						_ = (Pj8)(object)Nf2.Default;
					}
					finally
					{
						o5CZ = o5CZ;
						goto IL_0370;
					}
				}
				if (num == 0)
				{
					pm = pm;
				}
				else
				{
					_ = (r8M)Nf2.Default;
					f0F = f0F;
					_ = (Gj4)Nf2.Default;
					pm = (Pm9)(object)Nf2.Default;
				}
			}
			else if (num == 0)
			{
				nuint num4 = num * (unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)));
				num = default(UIntPtr);
				if (num4 - num == 0)
				{
					_ = (r8M)Nf2.Default;
				}
			}
			goto IL_0370;
		}
		IL_05d9:
		do
		{
			IL_05d9_2:
			if ((object)Nf2.Default != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (Gj4)Nf2.Default;
					goto IL_05d9_2;
				}
			}
		}
		while (obj3 != null);
		try
		{
			while (obj3 != null)
			{
			}
		}
		catch
		{
			_ = (d1X)(object)Nf2.Default;
		}
		while (obj3 != null)
		{
			if (num == 0)
			{
				try
				{
					_ = (Co4)(object)Nf2.Default;
				}
				finally
				{
					_ = (Co4)(object)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
					continue;
				}
			}
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				nuint num5 = num;
				num = default(UIntPtr);
				if (checked(num5 * num) == 0)
				{
					d4E d4E = (d4E)(object)Nf2.Default;
					d4E = d4E;
					_ = (Pj8)(object)Nf2.Default;
					_ = (d1X)(object)Nf2.Default;
				}
				else
				{
					_ = (Np8)(object)Nf2.Default;
				}
			}
		}
		_ = (d1X)(object)Nf2.Default;
		while (obj3 != null)
		{
			if (num == 0)
			{
				do
				{
					eb = eb;
				}
				while (obj3 != null);
			}
		}
		Mb5 mb = null;
		mb = mb;
		try
		{
			mb = mb;
		}
		catch
		{
		}
		while (obj3 != null)
		{
			_ = (f2L)(object)Nf2.Default;
		}
		return;
		IL_053f:
		co = (Co4)(object)Nf2.Default;
		if ((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default == 0)
		{
			_ = (f0F)(object)Nf2.Default;
		}
		else
		{
			try
			{
				try
				{
					_ = Nf2.Default;
				}
				finally
				{
					_ = (Co4)(object)Nf2.Default;
					goto end_IL_0572;
				}
				end_IL_0572:;
			}
			catch
			{
				x8D9 x8D = (x8D9)(object)Nf2.Default;
				_ = (f9T6)(object)Nf2.Default;
			}
		}
		try
		{
		}
		finally
		{
			if (num == 0)
			{
				_003CModule_003E = null;
			}
			goto IL_05d9;
		}
	}

	static void We7()
	{
		_ = (x8D9)(object)Nf2.Default;
		_ = (f0F)(object)Nf2.Default;
		UIntPtr uIntPtr = (UIntPtr)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			pj = pj;
			pj = null;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (d8B)(object)Nf2.Default;
			}
			finally
			{
				d8B obj = (d8B)(object)Nf2.Default;
				d8B = null;
				d8B = obj;
				goto IL_0075;
			}
		}
		goto IL_0075;
		IL_0848:
		_ = (Eb1)(object)Nf2.Default;
		object obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		try
		{
			k6D = (k6D9)(object)Nf2.Default;
		}
		finally
		{
			do
			{
				d8B = d8B;
				_ = (Gj4)Nf2.Default;
				_ = (o5CZ)(object)Nf2.Default;
			}
			while (obj2 != null || obj2 != null);
			goto IL_0894;
		}
		IL_08ee:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = Nf2.Default;
					continue;
				}
			}
		}
		finally
		{
			while ((object)Nf2.Default != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Pm9)(object)Nf2.Default;
					continue;
				}
				d1X = d1X;
				f9T = (f9T6)(object)Nf2.Default;
				_ = (k6D9)(object)Nf2.Default;
				_ = (w4R)(object)Nf2.Default;
			}
			goto IL_0968;
		}
		IL_03ac:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		try
		{
			try
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					_ = (m0N)(object)Nf2.Default;
					x8D = x8D;
					f9T = f9T;
					o5CZ obj3 = (o5CZ)(object)Nf2.Default;
					o5CZ = o5CZ;
					o5CZ = obj3;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					f2L obj5 = (f2L)(object)Nf2.Default;
					f2L = (f2L)(object)Nf2.Default;
					f2L = obj5;
				}
				else
				{
					_ = (f2L)(object)Nf2.Default;
				}
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				pj = pj;
				m0N m0N2 = null;
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		while (obj2 != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Co4)(object)Nf2.Default;
					mb = null;
				}
				else
				{
					_ = (Pj8)(object)Nf2.Default;
				}
				continue;
			}
			while (obj2 != null)
			{
				_ = (Gj4)Nf2.Default;
				k6D9 obj8 = (k6D9)(object)Nf2.Default;
				k6D = k6D;
				k6D = obj8;
			}
		}
		while ((object)Nf2.Default != null)
		{
			_ = (d4E)(object)Nf2.Default;
		}
		try
		{
			f2L = f2L;
			k6D = (k6D9)(object)Nf2.Default;
			_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
			_ = (f0F)(object)Nf2.Default;
		}
		finally
		{
			while (obj2 != null)
			{
			}
			goto IL_0519;
		}
		IL_0075:
		do
		{
			try
			{
				pj = pj;
			}
			catch
			{
				_ = (f0F)(object)Nf2.Default;
			}
			obj2 = Nf2.Default;
		}
		while (obj2 != null || (object)Nf2.Default != null);
		UIntPtr num = (UIntPtr)Nf2.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num) - (unchecked((nuint)default(UIntPtr)) + (uIntPtr + uIntPtr)) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
				try
				{
					try
					{
						pm = pm;
						pm = null;
					}
					finally
					{
						pj = pj;
						goto end_IL_00df;
					}
					end_IL_00df:;
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						pm = pm;
						pm = pm;
						_ = (Eb1)(object)Nf2.Default;
						_ = (w4R)(object)Nf2.Default;
					}
					goto IL_01c5;
				}
			}
			_ = (x8D9)(object)Nf2.Default;
			goto IL_01c5;
		}
		IL_06af:
		x8D = x8D;
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Eb1)(object)Nf2.Default;
				}
				finally
				{
					_ = (f2L)(object)Nf2.Default;
					k6D = k6D;
					goto end_IL_06b7;
				}
			}
			end_IL_06b7:;
		}
		finally
		{
			try
			{
				_ = (Pm9)(object)Nf2.Default;
			}
			catch
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			finally
			{
				try
				{
					_ = Nf2.Default;
					_ = (d4E)(object)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
				}
				finally
				{
					f2L = (f2L)(object)Nf2.Default;
					goto IL_073e;
				}
			}
		}
		IL_07ec:
		_ = (m0N)(object)Nf2.Default;
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					do
					{
						_ = (Mb5)(object)Nf2.Default;
						d1X = d1X;
						_ = (Pm9)(object)Nf2.Default;
					}
					while ((object)Nf2.Default != null);
				}
				finally
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (Gj4)Nf2.Default;
					}
					goto IL_0848;
				}
			}
			goto IL_0848;
		}
		IL_0519:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		try
		{
			try
			{
				r8M = r8M;
			}
			finally
			{
				try
				{
					f0F = null;
					_ = (d8B)(object)Nf2.Default;
					_ = (Pj8)(object)Nf2.Default;
					d4E obj11 = (d4E)(object)Nf2.Default;
					d4E = d4E;
					d4E = obj11;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					goto end_IL_051a;
				}
			}
			end_IL_051a:;
		}
		finally
		{
			try
			{
				d4E = d4E;
			}
			catch
			{
				try
				{
					nf = nf;
				}
				finally
				{
					pj = pj;
					goto end_IL_0575;
				}
				end_IL_0575:;
			}
			goto IL_0599;
		}
		IL_0968:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (f2L)(object)Nf2.Default;
			f2L = f2L;
			_ = (m0N)(object)Nf2.Default;
		}
		return;
		IL_0599:
		while (obj2 != null)
		{
			_ = (d4E)(object)Nf2.Default;
		}
		_ = (w4R)(object)Nf2.Default;
		f2L = f2L;
		d4E = d4E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		while (obj2 != null)
		{
			try
			{
				f0F = f0F;
				co = co;
				co = co;
				r8M = default(r8M);
			}
			catch
			{
				mb = (Mb5)(object)Nf2.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				continue;
			}
		}
		try
		{
			f9T = null;
			_ = (r8M)Nf2.Default;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			else
			{
				d4E = d4E;
			}
			goto IL_0659;
		}
		IL_01c5:
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) * uIntPtr != 0)
				{
					try
					{
						_ = Nf2.Default;
					}
					catch
					{
						r8M = r8M;
						r8M = r8M;
						nf = nf;
						nf = nf;
						d1X obj14 = (d1X)(object)Nf2.Default;
						d1X = (d1X)(object)Nf2.Default;
						d1X = obj14;
					}
				}
				else
				{
					while (obj2 != null)
					{
						x8D9 obj16 = (x8D9)(object)Nf2.Default;
						x8D = (x8D9)(object)Nf2.Default;
						x8D = obj16;
					}
				}
			}
			while ((object)Nf2.Default != null);
		}
		do
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (f0F)(object)Nf2.Default;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		while (obj2 != null)
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		if (uIntPtr == 0)
		{
			_ = (k6D9)(object)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					mb = mb;
					mb = mb;
					mb = mb;
					f9T = f9T;
					f9T = f9T;
					_ = (f2L)(object)Nf2.Default;
				}
				catch
				{
					_ = (m0N)(object)Nf2.Default;
					_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					_003CModule_003E = null;
					Gj4 obj17 = (Gj4)Nf2.Default;
					gj = gj;
					gj = obj17;
				}
			}
		}
		while ((object)Nf2.Default != null);
		_ = (Mb5)(object)Nf2.Default;
		_ = (_003CModule_003E)(object)Nf2.Default;
		mb = mb;
		gj = default(Gj4);
		while (true)
		{
			if (obj2 != null)
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N2);
				while ((object)Nf2.Default != null)
				{
					f9T = f9T;
					_ = (k6D9)(object)Nf2.Default;
					m0N obj19 = (m0N)(object)Nf2.Default;
					m0N2 = m0N2;
					m0N2 = obj19;
					f0F obj20 = (f0F)(object)Nf2.Default;
					f0F = (f0F)(object)Nf2.Default;
					f0F = obj20;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					nf = Nf2.Default;
				}
				goto end_IL_030d;
			}
			end_IL_030d:;
		}
		finally
		{
			while (obj2 != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					m0N m0N2 = (m0N)(object)Nf2.Default;
					continue;
				}
			}
			goto IL_03ac;
		}
		IL_0659:
		try
		{
			try
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			catch
			{
				pj = pj;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				_ = (w4R)(object)Nf2.Default;
			}
		}
		finally
		{
			try
			{
				_ = (Gj4)Nf2.Default;
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					o5CZ = o5CZ;
				}
			}
			goto IL_06af;
		}
		IL_073e:
		UIntPtr num2 = (UIntPtr)Nf2.Default;
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)num2) - uIntPtr) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					k6D = (k6D9)(object)Nf2.Default;
				}
				finally
				{
					_ = (d4E)(object)Nf2.Default;
					goto IL_07ec;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (k6D9)(object)Nf2.Default;
			}
			else
			{
				co = co;
				_ = (d8B)(object)Nf2.Default;
				_ = (m0N)(object)Nf2.Default;
			}
		}
		else if (uIntPtr == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_ = (o5CZ)(object)Nf2.Default;
			_ = (Np8)(object)Nf2.Default;
		}
		goto IL_07ec;
		IL_0894:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)Nf2.Default != null)
			{
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			x8D = x8D;
			goto IL_08ee;
		}
		try
		{
			_ = (Eb1)(object)Nf2.Default;
		}
		finally
		{
			do
			{
				d8B = (d8B)(object)Nf2.Default;
			}
			while (obj2 != null);
			goto IL_08ee;
		}
	}
}
