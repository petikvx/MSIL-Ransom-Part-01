using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dn57;
using Fg5p;
using Jr8;
using Microsoft.VisualBasic.CompilerServices;
using Ps92;
using Wy4;
using Xr2;
using b1C5;
using j8P3;
using k6J;
using n0WD;
using n4M;
using n7K;
using o1N;
using o9R;
using p6S;
using y1M;
using y8D;

namespace Cd2;

[DesignerGenerated]
public class Sm6 : Form
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
			EventHandler eventHandler = Df4;
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
			EventHandler eventHandler = e7D;
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

	public Sm6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sp9);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		m5F();
	}

	[DebuggerNonUserCode]
	protected override void o7T(bool Ks1)
	{
		try
		{
			if (Ks1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ks1);
		}
	}

	[DebuggerStepThrough]
	private void m5F()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Sm6));
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

	private void e7D(object sender, EventArgs e)
	{
		Jy1 jy = new Jy1();
		((Control)jy).Show();
		((Control)this).Hide();
	}

	private void Df4(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Sp9(object sender, EventArgs e)
	{
	}

	internal static string j6C(string[] t7K, int w7C, int Nm9)
	{
		string text = "";
		for (int i = w7C; i <= Nm9; i = checked(i + 1))
		{
			text += t7K[i];
		}
		return text.ToString();
	}

	internal static bool s2C(string Fr5)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Fr5);
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

	static void f1H()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				finally
				{
					en = null;
					en = en;
					goto end_IL_000c;
				}
				end_IL_000c:;
			}
			catch
			{
				sm = (Sm6)(object)a7W.Default;
				sm = null;
			}
		}
		else
		{
			nuint num = (nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default;
			num2 = (UIntPtr)a7W.Default;
			if (checked(num - num2 * num2) == 0)
			{
				try
				{
					b1YL obj2 = (b1YL)(object)a7W.Default;
					b1YL = null;
					b1YL = obj2;
				}
				finally
				{
					_ = (j3J)(object)a7W.Default;
					_ = (_003CModule_003E)(object)a7W.Default;
					jy = jy;
					jy = jy;
					_ = (y8R)(object)a7W.Default;
					_ = (y8R)(object)a7W.Default;
					goto IL_00e4;
				}
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (Ta6)(object)a7W.Default;
			}
		}
		goto IL_00e4;
		IL_0534:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		try
		{
			try
			{
				b6E = (b6E)(object)a7W.Default;
			}
			catch
			{
				ta = ta;
			}
		}
		catch
		{
			try
			{
				_ = (j3J)(object)a7W.Default;
			}
			finally
			{
				_ = (Jy1)(object)a7W.Default;
				goto end_IL_0554;
			}
			end_IL_0554:;
		}
		finally
		{
			try
			{
			}
			catch
			{
				do
				{
					_ = (En1)(object)a7W.Default;
				}
				while (obj5 != null);
			}
			goto IL_058c;
		}
		IL_00e4:
		sm = sm;
		_ = (Em1)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			nuint num3 = num2;
			num2 = default(UIntPtr);
			if (checked(num3 + num2 - unchecked((nuint)(UIntPtr)a7W.Default)) / checked(num2 - num2) == 0)
			{
				s9EJ = (s9EJ)(object)a7W.Default;
				s9EJ = null;
				obj5 = null;
			}
		}
		else
		{
			en = null;
		}
		_ = (Ta6)(object)a7W.Default;
		_ = (Sm6)(object)a7W.Default;
		sm = (Sm6)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0A1 i0A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				zo = (Zo8)(object)a7W.Default;
				zo = zo;
				b1YL = b1YL;
				i0A = null;
				i0A = null;
			}
			else
			{
				try
				{
					en = (En1)(object)a7W.Default;
					ln = (Ln53)(object)a7W.Default;
					ln = ln;
				}
				catch
				{
					en = null;
				}
			}
		}
		catch
		{
			_ = (i0A1)(object)a7W.Default;
		}
		_ = (a1B)(object)a7W.Default;
		zo = zo;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		if (num2 / num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					_ = (Nn9a)(object)a7W.Default;
				}
				while ((object)a7W.Default != null);
			}
			else
			{
				while (obj5 != null)
				{
					a1B = null;
					a1B = a1B;
				}
			}
		}
		if (num2 == 0)
		{
			while (obj5 != null)
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		jy = (Jy1)(object)a7W.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (En1)(object)a7W.Default;
					_ = (i0A1)(object)a7W.Default;
				}
				catch
				{
					i0A = null;
				}
			}
			else
			{
				while (obj5 != null)
				{
					_ = (Ln53)(object)a7W.Default;
					zo = (Zo8)(object)a7W.Default;
				}
			}
		}
		else
		{
			do
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
			while ((object)a7W.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (b6E)(object)a7W.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Ln53)(object)a7W.Default;
				}
				while (obj5 != null);
			}
		}
		catch
		{
			while ((object)a7W.Default != null)
			{
				try
				{
					_ = (Jy1)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
				}
				catch
				{
					_003CModule_003E = null;
					jy = jy;
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		do
		{
			en = en;
			en = null;
			_ = (i0A1)(object)a7W.Default;
			_ = (_003CModule_003E)(object)a7W.Default;
		}
		while (obj5 != null);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (Ta6)(object)a7W.Default;
			Nn9a nn9a = nn9a;
			nn9a = nn9a;
		}
		else
		{
			try
			{
				b6E = b6E;
				b6E = b6E;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		do
		{
			num2 = default(UIntPtr);
			if (num2 != (UIntPtr)(nuint)0u)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					b6E = b6E;
					_ = (Nn9a)(object)a7W.Default;
				}
				continue;
			}
			UIntPtr num4 = num2;
			num2 = default(UIntPtr);
			if ((nuint)num4 / num2 == 0)
			{
				em = (Em1)(object)a7W.Default;
				em = em;
			}
			else
			{
				en = null;
			}
		}
		while (obj5 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			UIntPtr num5 = (UIntPtr)a7W.Default;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) + num2 - num2 == 0)
				{
					_ = (Nn9a)(object)a7W.Default;
				}
				else
				{
					while ((object)a7W.Default != null)
					{
						ta = ta;
						ta = ta;
						a7W = a7W.Default;
						a7W = null;
						em = null;
					}
				}
			}
		}
		finally
		{
			while (true)
			{
				if (obj5 != null)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
				else if ((object)a7W.Default == null)
				{
					break;
				}
			}
			goto IL_04d8;
		}
		IL_058c:
		if (num2 == 0)
		{
			ta = ta;
		}
		else
		{
			ln = (Ln53)(object)a7W.Default;
		}
		while (obj5 != null)
		{
			try
			{
				try
				{
					b1YL = b1YL;
					b1YL = (b1YL)(object)a7W.Default;
					_ = (j3J)(object)a7W.Default;
				}
				catch
				{
					s9EJ = s9EJ;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					_ = (j3J)(object)a7W.Default;
					a7W = a7W;
					_ = (Qg6)(object)a7W.Default;
				}
				else
				{
					a1B = a1B;
				}
			}
		}
		_ = (b1YL)(object)a7W.Default;
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			while ((object)a7W.Default != null)
			{
				_ = a7W.Default;
			}
		}
		else
		{
			while (obj5 != null)
			{
				en = null;
			}
		}
		while ((object)a7W.Default != null)
		{
			do
			{
				_ = (Zo8)(object)a7W.Default;
			}
			while (obj5 != null);
		}
		_ = a7W.Default;
		s9EJ = (s9EJ)(object)a7W.Default;
		_ = (Qg6)(object)a7W.Default;
		if (num2 == 0)
		{
			_ = (_003CModule_003E)(object)a7W.Default;
		}
		else
		{
			i0A = i0A;
		}
		_ = a7W.Default;
		if (num2 == 0)
		{
			do
			{
				_ = (Em1)(object)a7W.Default;
			}
			while (obj5 != null);
		}
		else if (num2 / (nuint)(UIntPtr)a7W.Default == 0)
		{
			ta = null;
		}
		else
		{
			i0A = null;
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u && num2 == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				em = em;
				return;
			}
			ln = ln;
			_ = (Ta6)(object)a7W.Default;
		}
		return;
		IL_04d8:
		_ = (Sm6)(object)a7W.Default;
		do
		{
			em = em;
		}
		while ((object)a7W.Default != null);
		try
		{
			try
			{
				while (obj5 != null)
				{
					_ = (Ln53)(object)a7W.Default;
				}
			}
			finally
			{
				if (num2 == 0)
				{
					ta = ta;
				}
				goto end_IL_04f7;
			}
			end_IL_04f7:;
		}
		finally
		{
			do
			{
				_ = (En1)(object)a7W.Default;
			}
			while (obj5 != null);
			goto IL_0534;
		}
	}

	static void Tf1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)a7W.Default;
				_ = (b6E)(object)a7W.Default;
				_ = a7W.Default;
				_ = a7W.Default;
				_ = (b1YL)(object)a7W.Default;
			}
			finally
			{
				while ((object)a7W.Default != null)
				{
				}
				goto IL_004d;
			}
			IL_004d:
			obj = obj;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		while (obj != null)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (b1YL)(object)a7W.Default;
				}
				while (obj != null);
				continue;
			}
			UIntPtr num = (UIntPtr)a7W.Default;
			num2 = num2;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked(checked(unchecked((nuint)num) + num2) / (nuint)(UIntPtr)a7W.Default) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					_ = (i0A1)(object)a7W.Default;
				}
			}
		}
		_ = (b6E)(object)a7W.Default;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (b6E)(object)a7W.Default;
			}
		}
		catch
		{
			_ = (Ta6)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qg6 qg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		try
		{
			_ = (a1B)(object)a7W.Default;
		}
		finally
		{
			qg = qg;
			qg = null;
			_ = (Nn9a)(object)a7W.Default;
			_ = (s9EJ)(object)a7W.Default;
			en = en;
			en = en;
			goto IL_013f;
		}
		IL_0375:
		while (obj != null)
		{
			do
			{
				Ta6 ta = null;
			}
			while (obj != null);
		}
		Nn9a nn9a;
		try
		{
			_ = (Sm6)(object)a7W.Default;
		}
		catch
		{
			try
			{
				do
				{
					_ = (i0A1)(object)a7W.Default;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					en = en;
					goto end_IL_039e;
				}
				catch
				{
					_ = a7W.Default;
					nn9a = nn9a;
					goto end_IL_039e;
				}
				end_IL_039e:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
		while (obj != null)
		{
			b1YL = b1YL;
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (En1)(object)a7W.Default;
			}
		}
		catch
		{
			do
			{
				qg = qg;
			}
			while (obj != null);
		}
		finally
		{
			goto IL_0413;
		}
		IL_0413:
		while (true)
		{
			if ((object)a7W.Default != null)
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		do
		{
			try
			{
				try
				{
					en = en;
				}
				finally
				{
					_ = (b1YL)(object)a7W.Default;
					ln = ln;
					ln = ln;
					s9EJ obj7 = (s9EJ)(object)a7W.Default;
					s9EJ = s9EJ;
					s9EJ = obj7;
					goto end_IL_0422;
				}
				end_IL_0422:;
			}
			finally
			{
				do
				{
					_ = (Sm6)(object)a7W.Default;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		b1YL = b1YL;
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_ = (j3J)(object)a7W.Default;
						en = en;
						_ = (j3J)(object)a7W.Default;
					}
					else
					{
						_ = (Nn9a)(object)a7W.Default;
					}
				}
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					y8R y8R = (y8R)(object)a7W.Default;
					y8R = y8R;
				}
			}
			finally
			{
				try
				{
					ln = ln;
				}
				finally
				{
					_ = (Qg6)(object)a7W.Default;
					goto end_IL_04e7;
				}
			}
			end_IL_04e7:;
		}
		_ = (a1B)(object)a7W.Default;
		_ = (a1B)(object)a7W.Default;
		_ = (Jy1)(object)a7W.Default;
		num2 = default(UIntPtr);
		if (num2 != (UIntPtr)(nuint)0u)
		{
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u && num2 == (UIntPtr)(nuint)0u)
		{
			_ = (Qg6)(object)a7W.Default;
		}
		_ = (y8R)(object)a7W.Default;
		nn9a = nn9a;
		_ = (Ta6)(object)a7W.Default;
		return;
		IL_013f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		checked
		{
			if (unchecked((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u))
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					do
					{
						Nn9a obj9 = (Nn9a)(object)a7W.Default;
						nn9a = null;
						nn9a = obj9;
					}
					while ((object)a7W.Default != null);
				}
				else
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
			Ta6 ta = ta;
			ta = ta;
			nn9a = null;
			try
			{
				_ = (b1YL)(object)a7W.Default;
			}
			catch
			{
				while (obj != null)
				{
					_ = (b1YL)(object)a7W.Default;
				}
			}
			while ((object)a7W.Default != null)
			{
				num2 = default(UIntPtr);
				if (num2 - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					qg = qg;
					continue;
				}
				if (num2 == 0)
				{
					_ = (y8R)(object)a7W.Default;
					continue;
				}
				nm2f = null;
				nm2f = nm2f;
			}
			do
			{
				_ = (y8R)(object)a7W.Default;
			}
			while ((object)a7W.Default != null);
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (Qg6)(object)a7W.Default;
			}
			_ = (Nn9a)(object)a7W.Default;
			UIntPtr num3 = unchecked((UIntPtr)a7W.Default);
			nuint num4 = num2 + num2;
			num2 = default(UIntPtr);
			if (unchecked((nuint)num3) + (num4 + num2) == 0)
			{
				try
				{
					try
					{
						_ = (Qg6)(object)a7W.Default;
					}
					finally
					{
						_ = (Qg6)(object)a7W.Default;
						goto end_IL_027d;
					}
					end_IL_027d:;
				}
				catch
				{
					while (obj != null)
					{
						_ = (En1)(object)a7W.Default;
					}
				}
			}
		}
		try
		{
			do
			{
				b1YL = b1YL;
				b1YL = b1YL;
			}
			while ((object)a7W.Default != null);
		}
		catch
		{
			do
			{
				_ = (Jy1)(object)a7W.Default;
			}
			while (obj != null);
		}
		finally
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				nuint num5 = num2 / checked(unchecked((nuint)(UIntPtr)a7W.Default) + num2);
				num2 = default(UIntPtr);
				if (num5 / num2 == 0)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			goto IL_0329;
		}
		IL_0329:
		nn9a = null;
		nn9a = null;
		if (num2 == 0)
		{
			try
			{
				do
				{
					nm2f = nm2f;
				}
				while (obj != null);
			}
			finally
			{
				goto IL_0375;
			}
		}
		while (obj != null)
		{
			if (num2 == 0)
			{
				_ = (b6E)(object)a7W.Default;
				nn9a = null;
			}
		}
		goto IL_0375;
	}

	static void r0X()
	{
		_ = (Ln53)(object)a7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			try
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				finally
				{
					_ = a7W.Default;
					goto end_IL_000c;
				}
				end_IL_000c:;
			}
			finally
			{
				try
				{
					_ = (Qg6)(object)a7W.Default;
				}
				finally
				{
					_ = (Ln53)(object)a7W.Default;
					goto IL_0046;
				}
			}
			IL_0046:
			obj = obj;
		}
		while (obj != null);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = a7W.Default;
				}
				finally
				{
					_ = (Sm6)(object)a7W.Default;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		Qg6 qg;
		try
		{
			try
			{
				Ta6 obj2 = (Ta6)(object)a7W.Default;
				ta = ta;
				ta = obj2;
			}
			catch
			{
				a1B = a1B;
				a1B = a1B;
			}
		}
		catch
		{
			do
			{
				_ = (y8R)(object)a7W.Default;
				qg = null;
				qg = qg;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					_ = (b1YL)(object)a7W.Default;
					_ = (Sm6)(object)a7W.Default;
				}
			}
			catch
			{
				b6E = null;
				b6E = b6E;
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn9a nn9a);
		try
		{
			uIntPtr = uIntPtr;
			if (checked(uIntPtr * uIntPtr) != 0)
			{
				try
				{
					_ = (En1)(object)a7W.Default;
				}
				finally
				{
					_ = (Sm6)(object)a7W.Default;
					goto end_IL_011d;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				nn9a = (Nn9a)(object)a7W.Default;
				nn9a = null;
			}
			end_IL_011d:;
		}
		finally
		{
			goto IL_0174;
		}
		IL_055c:
		checked
		{
			while ((object)a7W.Default != null)
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					while (obj != null)
					{
						_ = (j3J)(object)a7W.Default;
					}
				}
			}
			try
			{
				try
				{
					do
					{
						_ = (Jy1)(object)a7W.Default;
						_ = (j3J)(object)a7W.Default;
						_ = (s9EJ)(object)a7W.Default;
					}
					while (obj != null);
					return;
				}
				finally
				{
					_ = (Sm6)(object)a7W.Default;
					return;
				}
			}
			catch
			{
				while (obj != null)
				{
				}
				return;
			}
		}
		IL_0389:
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b1YL b1YL);
			do
			{
				b1YL = b1YL;
				b1YL = null;
			}
			while (obj != null);
		}
		else
		{
			Em1 em = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (Ta6)(object)a7W.Default;
			}
			else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
			{
				_ = (s9EJ)(object)a7W.Default;
			}
			while (obj != null)
			{
				_ = (En1)(object)a7W.Default;
				s9EJ = s9EJ;
				s9EJ = s9EJ;
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default) + uIntPtr - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				_ = (b6E)(object)a7W.Default;
				goto IL_0496;
			}
			try
			{
				do
				{
					_ = a7W.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (b6E)(object)a7W.Default;
				Sm6 sm = (Sm6)(object)a7W.Default;
				goto IL_0496;
			}
		}
		IL_0174:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (a1B)(object)a7W.Default;
			}
		}
		a1B = a1B;
		try
		{
			_ = (Sm6)(object)a7W.Default;
		}
		catch
		{
			Sm6 obj7 = (Sm6)(object)a7W.Default;
			Sm6 sm = sm;
			sm = obj7;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7W a7W);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			nuint num = uIntPtr;
			UIntPtr num2 = (UIntPtr)a7W.Default;
			nuint num3 = (nuint)(UIntPtr)a7W.Default / uIntPtr;
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num / checked(unchecked((nuint)num2) * (num3 + num4 * (uIntPtr + unchecked((nuint)(UIntPtr)a7W.Default)))) == 0)
			{
				if (uIntPtr == 0)
				{
					a7W = a7W.Default;
					a7W = null;
				}
				else
				{
					a1B = null;
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
				while (obj != null)
				{
					_ = (y8R)(object)a7W.Default;
					b6E = b6E;
					_ = (Ln53)(object)a7W.Default;
					Em1 obj9 = (Em1)(object)a7W.Default;
					em = em;
					em = obj9;
				}
			}
			goto IL_027f;
		}
		IL_027f:
		checked
		{
			if (unchecked((nuint)(UIntPtr)a7W.Default) - uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					do
					{
						_ = (b1YL)(object)a7W.Default;
					}
					while (obj != null);
				}
			}
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					a1B = a1B;
					a7W = a7W;
					_ = (j3J)(object)a7W.Default;
					ta = ta;
				}
				finally
				{
					nn9a = (Nn9a)(object)a7W.Default;
					goto end_IL_02b2;
				}
			}
			end_IL_02b2:;
		}
		catch
		{
			do
			{
				_ = (Sm6)(object)a7W.Default;
				_ = (i0A1)(object)a7W.Default;
				_ = (Qg6)(object)a7W.Default;
				ta = ta;
			}
			while ((object)a7W.Default != null || obj != null);
		}
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		finally
		{
			try
			{
				try
				{
					j3J j3J = j3J;
					j3J = j3J;
				}
				catch
				{
					Jy1 jy = null;
					jy = jy;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			goto IL_0389;
		}
		IL_0496:
		while (true)
		{
			if (obj != null)
			{
				while ((object)a7W.Default != null)
				{
					_ = (Em1)(object)a7W.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			nn9a = nn9a;
		}
		_003CModule_003E = null;
		_ = (En1)(object)a7W.Default;
		_ = (Qg6)(object)a7W.Default;
		qg = null;
		s9EJ = null;
		_ = (Ta6)(object)a7W.Default;
		while (obj != null)
		{
			do
			{
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
				_ = (a1B)(object)a7W.Default;
				_003CModule_003E = _003CModule_003E;
			}
			while ((object)a7W.Default != null);
		}
		try
		{
			_ = (Ta6)(object)a7W.Default;
		}
		finally
		{
			a7W = a7W;
			goto IL_055c;
		}
	}

	static void Ft3()
	{
		object obj2;
		nuint uIntPtr;
		do
		{
			uIntPtr = (UIntPtr)a7W.Default;
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					a1B a1B = null;
					a1B = a1B;
				}
				catch
				{
					_ = (b1YL)(object)a7W.Default;
				}
			}
			else
			{
				_ = (j3J)(object)a7W.Default;
			}
			obj2 = a7W.Default;
		}
		while (obj2 != null);
		i0A1 i0A;
		do
		{
			i0A = null;
			i0A = i0A;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		try
		{
			while ((object)a7W.Default != null)
			{
				s9EJ = s9EJ;
				s9EJ = s9EJ;
			}
		}
		finally
		{
			_ = (Zo8)(object)a7W.Default;
			goto IL_0092;
		}
		IL_07ce:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		if (checked(uIntPtr - uIntPtr) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (b6E)(object)a7W.Default;
			}
			else if (uIntPtr / checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
			{
				nm2f = nm2f;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zo8 zo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		while ((object)a7W.Default != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Zo8)(object)a7W.Default;
					b6E = b6E;
				}
				else
				{
					_ = (s9EJ)(object)a7W.Default;
				}
			}
			finally
			{
				ta = (Ta6)(object)a7W.Default;
				zo = null;
				_ = (_003CModule_003E)(object)a7W.Default;
				ln = ln;
				continue;
			}
		}
		return;
		IL_0430:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Em1 em);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sm6 sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy1 jy);
		Qg6 qg;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)a7W.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				unchecked
				{
					if (uIntPtr == (UIntPtr)(nuint)0u)
					{
						if (uIntPtr == (UIntPtr)(nuint)0u)
						{
							y8R y8R = null;
						}
						else
						{
							_ = (y8R)(object)a7W.Default;
							_ = (Qg6)(object)a7W.Default;
							_ = (a1B)(object)a7W.Default;
							i0A = i0A;
						}
					}
					else
					{
						em = em;
					}
				}
			}
			try
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
				{
					try
					{
						sm = (Sm6)(object)a7W.Default;
						sm = sm;
						_ = (Sm6)(object)a7W.Default;
						_ = (a1B)(object)a7W.Default;
						_003CModule_003E = _003CModule_003E;
					}
					finally
					{
						_ = (i0A1)(object)a7W.Default;
						goto end_IL_049c;
					}
				}
				end_IL_049c:;
			}
			catch
			{
				while (obj2 != null)
				{
					try
					{
						_ = (b1YL)(object)a7W.Default;
					}
					finally
					{
						en = en;
						continue;
					}
				}
			}
			Nm2f obj4 = (Nm2f)(object)a7W.Default;
			nm2f = nm2f;
			nm2f = obj4;
			_ = (j3J)(object)a7W.Default;
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && unchecked((nuint)(UIntPtr)a7W.Default) * uIntPtr == 0)
				{
					j3J j3J = null;
					_ = (Em1)(object)a7W.Default;
					zo = zo;
					_ = (Nm2f)(object)a7W.Default;
				}
			}
			while ((object)a7W.Default != null)
			{
				if (unchecked((nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default) == 0)
				{
					_ = (Jy1)(object)a7W.Default;
					_003CModule_003E = _003CModule_003E;
					_ = (i0A1)(object)a7W.Default;
				}
			}
			while (obj2 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + unchecked(uIntPtr / (nuint)(UIntPtr)a7W.Default) * uIntPtr == 0)
					{
						jy = null;
						continue;
					}
					qg = qg;
					_ = (b6E)(object)a7W.Default;
					_ = (En1)(object)a7W.Default;
				}
			}
			Nn9a nn9a = nn9a;
			nn9a = nn9a;
			_ = (Qg6)(object)a7W.Default;
			_ = (b1YL)(object)a7W.Default;
			qg = qg;
			b6E = (b6E)(object)a7W.Default;
			nuint num = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num + unchecked(uIntPtr / uIntPtr) + uIntPtr == 0 && uIntPtr == 0)
			{
				try
				{
					sm = (Sm6)(object)a7W.Default;
					_ = (b1YL)(object)a7W.Default;
					_ = (Em1)(object)a7W.Default;
				}
				catch
				{
					sm = sm;
				}
			}
			try
			{
				_ = (Sm6)(object)a7W.Default;
			}
			finally
			{
				try
				{
					try
					{
						en = en;
					}
					catch
					{
						_ = (y8R)(object)a7W.Default;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						ta = (Ta6)(object)a7W.Default;
					}
				}
				goto IL_0752;
			}
		}
		IL_0752:
		do
		{
			if (uIntPtr != 0)
			{
				_ = (y8R)(object)a7W.Default;
			}
			else
			{
				_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
			}
		}
		while (obj2 != null);
		sm = sm;
		s9EJ = (s9EJ)(object)a7W.Default;
		_ = (y8R)(object)a7W.Default;
		jy = (Jy1)(object)a7W.Default;
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			do
			{
				try
				{
					sm = (Sm6)(object)a7W.Default;
					jy = jy;
				}
				finally
				{
					_ = (b6E)(object)a7W.Default;
					i0A = i0A;
					continue;
				}
			}
			while (obj2 != null);
			goto IL_07ce;
		}
		IL_0092:
		do
		{
			ln = ln;
			ln = ln;
		}
		while (obj2 != null);
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					jy = jy;
					jy = null;
				}
				catch
				{
					_ = (Nn9a)(object)a7W.Default;
				}
			}
			while (obj2 != null);
		}
		else
		{
			_ = (i0A1)(object)a7W.Default;
		}
		qg = null;
		qg = null;
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				qg = null;
			}
		}
		catch
		{
			do
			{
				_ = (Nn9a)(object)a7W.Default;
			}
			while ((object)a7W.Default != null || obj2 != null);
		}
		try
		{
			try
			{
				_ = (Ln53)(object)a7W.Default;
				Zo8 obj10 = (Zo8)(object)a7W.Default;
				zo = (Zo8)(object)a7W.Default;
				zo = obj10;
			}
			finally
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)a7W.Default;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					ta = null;
					ta = null;
					goto end_IL_0129;
				}
			}
			end_IL_0129:;
		}
		catch
		{
			while ((object)a7W.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Em1)(object)a7W.Default;
					continue;
				}
				b6E = null;
				b6E = b6E;
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)a7W.Default / (nuint)(UIntPtr)a7W.Default) == 0)
			{
				b1YL b1YL = (b1YL)(object)a7W.Default;
				b1YL = b1YL;
			}
			_ = a7W.Default;
			while ((object)a7W.Default != null)
			{
				try
				{
					try
					{
						y8R y8R = null;
						y8R = y8R;
					}
					finally
					{
						_ = (_003CModule_003E)(object)a7W.Default;
						goto end_IL_0201;
					}
					end_IL_0201:;
				}
				catch
				{
					try
					{
						s9EJ = s9EJ;
					}
					catch
					{
						_ = (_003CModule_003E)(object)a7W.Default;
						_ = (Sm6)(object)a7W.Default;
						_ = (Jy1)(object)a7W.Default;
					}
				}
			}
			if (uIntPtr == 0)
			{
				try
				{
					j3J obj14 = (j3J)(object)a7W.Default;
					j3J j3J = j3J;
					j3J = obj14;
				}
				catch
				{
					_003CModule_003E = null;
				}
				finally
				{
					try
					{
						b6E = b6E;
						_ = (j3J)(object)a7W.Default;
					}
					finally
					{
						_ = (s9EJ)(object)a7W.Default;
						_ = a7W.Default;
						goto IL_02c4;
					}
				}
			}
			while (obj2 != null)
			{
				qg = qg;
			}
			goto IL_02c4;
		}
		IL_02c4:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					en = en;
					en = en;
				}
				else
				{
					qg = qg;
				}
			}
			else
			{
				while (obj2 != null)
				{
					jy = jy;
					_ = a7W.Default;
				}
			}
		}
		else
		{
			try
			{
				if ((nuint)(UIntPtr)a7W.Default / (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)a7W.Default) == 0)
				{
					em = (Em1)(object)a7W.Default;
					em = em;
					qg = null;
					_ = (Ln53)(object)a7W.Default;
				}
			}
			catch
			{
				do
				{
					ln = ln;
				}
				while ((object)a7W.Default != null);
			}
		}
		try
		{
			while ((object)a7W.Default != null)
			{
				try
				{
					b6E = (b6E)(object)a7W.Default;
				}
				catch
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		catch
		{
			do
			{
				_ = (_003CModule_003E)(object)a7W.Default;
			}
			while (obj2 != null);
		}
		ta = ta;
		_ = (a1B)(object)a7W.Default;
		try
		{
			_ = (Ta6)(object)a7W.Default;
		}
		finally
		{
			do
			{
				a1B a1B = (a1B)(object)a7W.Default;
			}
			while (obj2 != null);
			goto IL_0430;
		}
	}

	static void Tb0()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta6 ta);
		nuint num;
		while ((object)a7W.Default != null)
		{
			num = unchecked((nuint)default(UIntPtr)) / ((nuint)(UIntPtr)a7W.Default / unchecked((nuint)default(UIntPtr)));
			if (checked(num - num) == 0)
			{
				ta = (Ta6)(object)a7W.Default;
				ta = null;
			}
			else
			{
				_ = (i0A1)(object)a7W.Default;
			}
		}
		_ = (Zo8)(object)a7W.Default;
		_ = (y8R)(object)a7W.Default;
		_ = (i0A1)(object)a7W.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		Jy1 jy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ln53 ln);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y8R y8R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out En1 en);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nm2f nm2f);
		checked
		{
			if (num - num == 0)
			{
				if (num == 0)
				{
					en = en;
					en = en;
				}
				else
				{
					try
					{
						ln = (Ln53)(object)a7W.Default;
						ln = ln;
						nm2f = nm2f;
						nm2f = nm2f;
					}
					catch
					{
						nm2f = nm2f;
					}
				}
			}
			else
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 == null)
					{
						break;
					}
					nuint num2 = num;
					num = default(UIntPtr);
					if (num2 - num + num == 0)
					{
						_ = (Nn9a)(object)a7W.Default;
					}
				}
			}
			do
			{
				ln = ln;
			}
			while (obj2 != null);
			jy = (Jy1)(object)a7W.Default;
			jy = jy;
			y8R = y8R;
			y8R = null;
			ln = ln;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j3J j3J);
		if (num == 0 && (UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			en = en;
			nm2f = null;
			j3J obj3 = (j3J)(object)a7W.Default;
			j3J = (j3J)(object)a7W.Default;
			j3J = obj3;
		}
		_ = (y8R)(object)a7W.Default;
		_ = (b1YL)(object)a7W.Default;
		i0A1 i0A = i0A;
		i0A = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1B a1B);
		try
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					a1B obj4 = (a1B)(object)a7W.Default;
					a1B = null;
					a1B = obj4;
				}
			}
			else
			{
				while ((object)a7W.Default != null)
				{
					_ = (Zo8)(object)a7W.Default;
					_ = (Zo8)(object)a7W.Default;
				}
			}
		}
		finally
		{
			if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
			{
				y8R = y8R;
			}
			goto IL_0215;
		}
		IL_03a9:
		a7W a7W = a7W;
		b1YL b1YL = (b1YL)(object)a7W.Default;
		b1YL = b1YL;
		Nn9a obj5 = (Nn9a)(object)a7W.Default;
		Nn9a nn9a = nn9a;
		nn9a = obj5;
		Sm6 sm = null;
		a1B = a1B;
		try
		{
			while (obj2 != null)
			{
				_ = (Nn9a)(object)a7W.Default;
				_ = (Nm2f)(object)a7W.Default;
			}
		}
		catch
		{
			_ = (b1YL)(object)a7W.Default;
		}
		_ = (En1)(object)a7W.Default;
		if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)a7W.Default == (UIntPtr)(nuint)0u)
				{
					a7W = a7W.Default;
				}
				else
				{
					_ = (Zo8)(object)a7W.Default;
				}
			}
			else
			{
				while (obj2 != null)
				{
					_ = a7W.Default;
				}
			}
		}
		checked
		{
			if (num == 0)
			{
				nuint num3 = num;
				nuint num4 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)a7W.Default);
				num = default(UIntPtr);
				if (num3 + (num4 - num) == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						b1YL = b1YL;
					}
					else
					{
						_ = (a1B)(object)a7W.Default;
						_ = (Qg6)(object)a7W.Default;
						_ = (Ln53)(object)a7W.Default;
					}
				}
			}
			else
			{
				_ = (Nm2f)(object)a7W.Default;
			}
			if (num == 0)
			{
				try
				{
					while (obj2 != null)
					{
						_ = (Nn9a)(object)a7W.Default;
						_ = (Jy1)(object)a7W.Default;
					}
				}
				finally
				{
					while ((object)a7W.Default != null)
					{
						_ = a7W.Default;
					}
					goto IL_0571;
				}
			}
			goto IL_0571;
		}
		IL_074a:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				UIntPtr num5 = (UIntPtr)a7W.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num5) * num + unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)a7W.Default;
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
		}
		catch
		{
			_ = (Ln53)(object)a7W.Default;
		}
		if (num == 0)
		{
			b1YL = (b1YL)(object)a7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9EJ s9EJ);
		if (num == 0)
		{
			while (obj2 != null)
			{
				if (num == 0)
				{
					s9EJ = s9EJ;
					s9EJ = s9EJ;
				}
				else
				{
					_ = (En1)(object)a7W.Default;
				}
			}
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					jy = jy;
				}
				finally
				{
					s9EJ = s9EJ;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6E b6E);
		try
		{
			while ((object)a7W.Default != null)
			{
				ta = ta;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				a7W = null;
				b6E = b6E;
				_ = (s9EJ)(object)a7W.Default;
			}
		}
		while (obj2 != null)
		{
			_ = (Ta6)(object)a7W.Default;
		}
		try
		{
			_ = a7W.Default;
			return;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Qg6)(object)a7W.Default;
				}
				while (obj2 != null);
				return;
			}
			finally
			{
				_ = (s9EJ)(object)a7W.Default;
				return;
			}
		}
		IL_023b:
		Em1 em;
		try
		{
			_ = (b6E)(object)a7W.Default;
		}
		finally
		{
			em = null;
			em = em;
			goto IL_0258;
		}
		IL_0571:
		do
		{
			IL_0571_2:
			if (obj2 != null)
			{
				try
				{
					_ = (a1B)(object)a7W.Default;
				}
				finally
				{
					_ = (Nm2f)(object)a7W.Default;
					_ = (Em1)(object)a7W.Default;
					en = null;
					goto IL_0571_2;
				}
			}
		}
		while ((object)a7W.Default != null);
		if (checked(num + num) == 0)
		{
			do
			{
				try
				{
					_ = (Em1)(object)a7W.Default;
					b6E = (b6E)(object)a7W.Default;
				}
				finally
				{
					_ = (i0A1)(object)a7W.Default;
					continue;
				}
			}
			while ((object)a7W.Default != null);
		}
		try
		{
			_ = (Nn9a)(object)a7W.Default;
			_ = (b1YL)(object)a7W.Default;
			_ = (b6E)(object)a7W.Default;
		}
		finally
		{
			_ = (Ln53)(object)a7W.Default;
			goto IL_05ea;
		}
		IL_0660:
		while (obj2 != null)
		{
			if (num == 0)
			{
				do
				{
					j3J = null;
				}
				while (obj2 != null);
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			j3J = j3J;
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					ln = ln;
				}
				catch
				{
					j3J = j3J;
				}
			}
		}
		try
		{
			try
			{
				_ = (y8R)(object)a7W.Default;
				_ = (j3J)(object)a7W.Default;
				em = em;
				_ = (i0A1)(object)a7W.Default;
			}
			finally
			{
				y8R = y8R;
				goto end_IL_069e;
			}
			end_IL_069e:;
		}
		catch
		{
			try
			{
				_ = (a1B)(object)a7W.Default;
			}
			catch
			{
				nm2f = null;
				en = null;
			}
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					_ = (j3J)(object)a7W.Default;
				}
				else
				{
					_ = (s9EJ)(object)a7W.Default;
					_ = (Jy1)(object)a7W.Default;
					y8R = (y8R)(object)a7W.Default;
				}
			}
			catch
			{
				_ = (i0A1)(object)a7W.Default;
				_ = (a1B)(object)a7W.Default;
			}
			goto IL_074a;
		}
		IL_0258:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				do
				{
					Sm6 obj14 = (Sm6)(object)a7W.Default;
					sm = sm;
					sm = obj14;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					nm2f = nm2f;
					ln = null;
					_ = (Jy1)(object)a7W.Default;
				}
				finally
				{
					a1B = null;
					a7W obj15 = a7W.Default;
					a7W = a7W.Default;
					a7W = obj15;
					sm = (Sm6)(object)a7W.Default;
					goto IL_0333;
				}
			}
		}
		try
		{
			em = (Em1)(object)a7W.Default;
			_ = a7W.Default;
		}
		catch
		{
			try
			{
				_ = (y8R)(object)a7W.Default;
			}
			catch
			{
				a1B = (a1B)(object)a7W.Default;
				_ = (j3J)(object)a7W.Default;
				_ = (En1)(object)a7W.Default;
				ln = ln;
			}
		}
		goto IL_0333;
		IL_0215:
		try
		{
		}
		finally
		{
			_ = (a1B)(object)a7W.Default;
			b6E obj18 = (b6E)(object)a7W.Default;
			b6E = b6E;
			b6E = obj18;
			goto IL_023b;
		}
		IL_0333:
		if (num == 0)
		{
			try
			{
				try
				{
					j3J = null;
				}
				catch
				{
					sm = sm;
				}
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)a7W.Default;
				}
				finally
				{
					nm2f = nm2f;
					_ = (a1B)(object)a7W.Default;
					_ = (Qg6)(object)a7W.Default;
					goto end_IL_034e;
				}
				end_IL_034e:;
			}
			goto IL_03a9;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Jy1)(object)a7W.Default;
			}
		}
		finally
		{
			_ = (Em1)(object)a7W.Default;
			goto IL_03a9;
		}
		IL_05ea:
		nuint num6 = num;
		num = default(UIntPtr);
		if (checked(num6 * num) / (nuint)(UIntPtr)a7W.Default == 0)
		{
			checked
			{
				try
				{
					num = default(UIntPtr);
					if (num + num * unchecked((nuint)(UIntPtr)a7W.Default) == 0)
					{
						em = null;
					}
					else
					{
						y8R = null;
					}
				}
				finally
				{
					goto IL_0660;
				}
			}
		}
		do
		{
			Qg6 qg = null;
			qg = qg;
		}
		while (obj2 != null);
		goto IL_0660;
	}
}
