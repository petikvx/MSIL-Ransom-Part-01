using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ag14Na;
using Ag80Sw;
using Kb0k6R;
using Kz92Sn;
using Microsoft.VisualBasic.CompilerServices;
using Tp7z2P;
using n4B1Pm;
using p2Y1Em;
using p6F5Wj;
using r7SMc5;
using r8XBa2;
using t1KNi0;
using t2K0Az;
using t6MNx0;
using t8J4Ef;
using x2ZBs0;
using x5Q4Lq;
using x9LFg6;
using y8PQt3;

namespace x7D4Ck;

[DesignerGenerated]
public class Xe4g3L : Form
{
	private IContainer components;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	private int i;

	private object Form2;

	private Cy89Fz.o3W7Lf o3W7Lf_0 = new Cy89Fz.o3W7Lf();

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(q6PHt3);
			Component timer = (Component)(object)_Timer1;
			if ((int)(Timer)timer != 0)
			{
				((Timer)((timer is Timer) ? timer : null)).remove_Tick(obj as EventHandler);
			}
			_Timer1 = value;
			timer = (Component)(object)_Timer1;
			if (timer is Timer)
			{
				((Timer)timer).add_Tick((EventHandler)obj);
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return o3W7Lf_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			o3W7Lf_0.label_0 = value;
		}
	}

	public Xe4g3L()
	{
		((Form)this).add_Load((EventHandler)q2EFa4);
		Cr32Eg();
	}

	protected override void n4A5Pt(bool t8D7Cs)
	{
		try
		{
			if (t8D7Cs && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t8D7Cs);
		}
	}

	private void Cr32Eg()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		components = new Container();
		ProgressBar1 = new ProgressBar();
		Timer1 = new Timer(components);
		Label3 = new Label();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)ProgressBar1).set_BackColor(Color.Black);
		((Control)ProgressBar1).set_Dock((DockStyle)2);
		((Control)ProgressBar1).set_Location(new Point(0, 280));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(600, 16));
		((Control)ProgressBar1).set_TabIndex(0);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Arial Rounded MT Bold", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(27, 134));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(539, 37));
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("LIBRARY MANAGEMENT SYSTEM");
		((Control)PictureBox1).set_Location(new Point(270, 54));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(63, 58));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(6);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(229, 171));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(140, 20));
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Login Successfully");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(600, 296));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("progressbar");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("progressbar");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void q6PHt3(object sender, EventArgs e)
	{
		checked
		{
			ProgressBar1.set_Value(ProgressBar1.get_Value() + 1);
			i++;
			if (i > 20)
			{
				Timer1.set_Enabled(false);
				((Control)this).Hide();
				NewLateBinding.LateCall(Form2, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void q2EFa4(object sender, EventArgs e)
	{
		Timer1.set_Enabled(true);
		ProgressBar1.set_Maximum(20);
		i = 1;
	}

	static void t9C7Po()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = num;
			nuint num2 = num;
			num = default(UIntPtr);
			if (checked(num2 + num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Wk4s1B wk4s1B = wk4s1B;
					wk4s1B = wk4s1B;
					_ = (o9A2Ym)(object)Sg5c1M.Default;
					Di35Ts di35Ts = di35Ts;
					di35Ts = di35Ts;
				}
				else
				{
					_ = (Di35Ts)(object)Sg5c1M.Default;
				}
			}
		}
		finally
		{
			while ((object)((Qf50Jc)(object)Sg5c1M.Default).ListView1 != null)
			{
				obj = null;
			}
			goto IL_0087;
		}
		IL_0087:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7TYc5 s7TYc);
		do
		{
			try
			{
				qf50Jc = qf50Jc;
			}
			catch
			{
				s7TYc = s7TYc;
				s7TYc = s7TYc;
			}
			finally
			{
				try
				{
					_ = (f6ASw4)(object)qf50Jc.ListView1;
				}
				catch
				{
					_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
				}
				continue;
			}
		}
		while (obj != null);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj != null)
			{
				num = default(UIntPtr);
				UIntPtr num3 = num;
				UIntPtr num4 = num;
				num = default(UIntPtr);
				if (unchecked((nuint)num3) - (unchecked((nuint)num4) - (num - num)) == 0)
				{
					while (obj != null)
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dq6e2L dq6e2L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z2S7Ta z2S7Ta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gd43Lj gd43Lj);
		try
		{
			_ = (Ag58Qx)(object)((Qf50Jc)null).ListView1;
		}
		catch
		{
			_ = (Gf7z4M)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
		}
		finally
		{
			do
			{
				if ((UIntPtr)((Qf50Jc)null).ListView1 != (UIntPtr)(nuint)0u)
				{
					_ = (o9A2Ym)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					gd43Lj = gd43Lj;
					gd43Lj = gd43Lj;
					z2S7Ta = (z2S7Ta)(object)Sg5c1M.Default;
					z2S7Ta = null;
				}
				else
				{
					Rx3a7Y rx3a7Y = null;
					rx3a7Y = rx3a7Y;
					_ = (Ag58Qx)(object)Sg5c1M.Default;
					_ = (Ag58Qx)(object)Sg5c1M.Default;
					dq6e2L = null;
					dq6e2L = dq6e2L;
				}
			}
			while ((object)((Qf50Jc)null).ListView1 != null);
			goto IL_01da;
		}
		IL_053b:
		_ = (i9XEz8)Sg5c1M.Default;
		_ = (i9XEz8)qf50Jc.ListView1;
		_ = (f6ASw4)(object)qf50Jc.ListView1;
		_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
		_ = (Wk4s1B)Sg5c1M.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy89Fz cy89Fz);
		try
		{
			try
			{
			}
			finally
			{
				cy89Fz = cy89Fz;
				goto end_IL_057b;
			}
			end_IL_057b:;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Ns12Zw ns12Zw = ns12Zw;
					ns12Zw = ns12Zw;
				}
			}
			finally
			{
				goto end_IL_058a;
			}
			end_IL_058a:;
		}
		Sg5c1M sg5c1M = null;
		while ((object)((Qf50Jc)null).ListView1 != null)
		{
		}
		_ = (a2K0Zg)(object)Sg5c1M.Default;
		while (obj != null)
		{
			if ((nuint)(UIntPtr)Sg5c1M.Default / (nuint)(UIntPtr)Sg5c1M.Default == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Gf7z4M)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
				}
				else
				{
					_ = (Nw9r7H)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				}
			}
		}
		return;
		IL_0304:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xe4g3L xe4g3L);
		while (obj != null)
		{
			try
			{
				UIntPtr num5 = (UIntPtr)qf50Jc.ListView1;
				num = default(UIntPtr);
				checked
				{
					nuint num6 = unchecked((nuint)num5) - num;
					num = default(UIntPtr);
					if (num6 * num == 0)
					{
						_ = (Gd43Lj)(object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
						sg5c1M = sg5c1M;
						sg5c1M = sg5c1M;
						z2S7Ta = z2S7Ta;
						_ = (i9XEz8)((Qf50Jc)null).ListView1;
					}
					else
					{
						xe4g3L = xe4g3L;
						xe4g3L = xe4g3L;
					}
				}
			}
			catch
			{
				if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
				{
					_ = (Ag58Qx)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
				}
			}
		}
		if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / num == 0)
			{
				try
				{
					_ = (Di35Ts)(object)Sg5c1M.Default;
					_ = (Rx3a7Y)(object)Sg5c1M.Default;
					_ = (Cy89Fz)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
					_ = (o9A2Ym)(object)Sg5c1M.Default;
				}
				finally
				{
					_ = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
					goto IL_0383;
				}
			}
		}
		goto IL_0383;
		IL_0383:
		try
		{
			do
			{
				_ = (s7TYc5)(object)((Qf50Jc)null).ListView1;
			}
			while (obj != null);
		}
		catch
		{
			while (true)
			{
				if ((object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1 != null)
				{
					dq6e2L = dq6e2L;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		if (num == 0)
		{
			while (obj != null)
			{
				cy89Fz = cy89Fz;
				cy89Fz = cy89Fz;
				qf50Jc = (Qf50Jc)(object)Sg5c1M.Default;
				_ = (Rx3a7Y)(object)Sg5c1M.Default;
				_ = (a2K0Zg)(object)qf50Jc.ListView1;
			}
		}
		UIntPtr num7 = (UIntPtr)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num7) * num * num) == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					o9A2Ym o9A2Ym = o9A2Ym;
					o9A2Ym = o9A2Ym;
				}
				else
				{
					i9XEz8 i9XEz = i9XEz;
					i9XEz = i9XEz;
				}
			}
		}
		while (obj != null)
		{
			_ = Sg5c1M.Default;
			_ = (Cy89Fz)(object)Sg5c1M.Default;
			Wk4s1B wk4s1B = (Wk4s1B)((Qf50Jc)null).ListView1;
		}
		try
		{
			do
			{
				if (num == 0)
				{
					_ = (Sg5c1M)(object)qf50Jc.ListView1;
				}
			}
			while ((object)qf50Jc.ListView1 != null);
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qf50Jc)(object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
				}
				catch
				{
					_ = (a2K0Zg)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
					sg5c1M = sg5c1M;
					z2S7Ta = z2S7Ta;
					gd43Lj = gd43Lj;
				}
			}
			else
			{
				do
				{
					_ = (Sg5c1M)(object)((Qf50Jc)null).ListView1;
				}
				while (obj != null);
			}
			goto IL_053b;
		}
		IL_01da:
		_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
		_ = (Nw9r7H)(object)Sg5c1M.Default;
		try
		{
			_ = (o9A2Ym)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
			_ = (i9XEz8)Sg5c1M.Default;
			_ = (Qf50Jc)(object)Sg5c1M.Default;
		}
		catch
		{
		}
		finally
		{
			try
			{
				_ = (Gf7z4M)(object)qf50Jc.ListView1;
			}
			finally
			{
				f6ASw4 f6ASw = (f6ASw4)(object)qf50Jc.ListView1;
				f6ASw = f6ASw;
				goto IL_0304;
			}
		}
	}
}
