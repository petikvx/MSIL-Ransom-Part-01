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
using x7D4Ck;
using x9LFg6;

namespace y8PQt3;

[DesignerGenerated]
public class Ag58Qx : Form
{
	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	private int i;

	private Di35Ts.b9DKf3 b9DKf3_0 = new Di35Ts.b9DKf3();

	internal virtual Label Label1
	{
		get
		{
			return b9DKf3_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			b9DKf3_0.label_0 = ((value is Label) ? value : null);
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return b9DKf3_0.pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			b9DKf3_0.pictureBox_0 = ((value is PictureBox) ? value : null);
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return b9DKf3_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			b9DKf3_0.label_1 = value;
		}
	}

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
			return b9DKf3_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Ls04Er);
			object timer_ = b9DKf3_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick((EventHandler)obj);
			}
			b9DKf3_0.timer_0 = ((value is Timer) ? value : null);
			timer_ = b9DKf3_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)timer_).add_Tick((EventHandler)obj);
			}
		}
	}

	public Ag58Qx()
	{
		((Form)this).add_Load((EventHandler)d5G7Tk);
		Gp6c3D();
	}

	protected override void w4X2Qi(bool d5X6Wz)
	{
		try
		{
			if (d5X6Wz && b9DKf3_0.icontainer_0 != null)
			{
				b9DKf3_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d5X6Wz);
		}
	}

	private void Gp6c3D()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		object obj = new Container();
		b9DKf3_0.icontainer_0 = obj as IContainer;
		Label1 = new Label();
		Label3 = new Label();
		ProgressBar1 = new ProgressBar();
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(b9DKf3_0.icontainer_0);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(204, 136));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(125, 17));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Login Successfully");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Arial Rounded MT Bold", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(24, 107));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(454, 32));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("LIBRARY MANAGEMENT SYSTEM");
		((Control)ProgressBar1).set_BackColor(Color.Black);
		((Control)ProgressBar1).set_Dock((DockStyle)2);
		((Control)ProgressBar1).set_Location(new Point(0, 224));
		((Control)ProgressBar1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(533, 13));
		((Control)ProgressBar1).set_TabIndex(8);
		((Control)PictureBox1).set_Location(new Point(239, 59));
		((Control)PictureBox1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(56, 46));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(533, 237));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Control)this).set_Name("progressbarstudent");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("progressbarstudent");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void d5G7Tk(object sender, EventArgs e)
	{
		Timer1.set_Enabled(true);
		ProgressBar1.set_Maximum(50);
		i = 1;
	}

	private void Ls04Er(object sender, EventArgs e)
	{
		checked
		{
			ProgressBar1.set_Value(ProgressBar1.get_Value() + 1);
			i++;
			if (i > 50)
			{
				Timer1.set_Enabled(false);
				((Control)this).Hide();
				NewLateBinding.LateCall(b9DKf3_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	static void Dj26En()
	{
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj = obj;
				if (obj == null)
				{
					break;
				}
				_ = (Ns12Zw)(object)Sg5c1M.Default;
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		Gf7z4M gf7z4M = gf7z4M;
		gf7z4M = null;
		_ = (Dq6e2L)(object)Sg5c1M.Default;
		Cy89Fz cy89Fz = cy89Fz;
		cy89Fz = cy89Fz;
		UIntPtr num = (UIntPtr)Sg5c1M.Default;
		Qf50Jc qf50Jc = qf50Jc;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns12Zw ns12Zw);
		checked
		{
			if (unchecked((nuint)num) + unchecked((nuint)(UIntPtr)qf50Jc.ListView1) == 0)
			{
				while (true)
				{
					if ((object)((Qf50Jc)null).ListView1 != null)
					{
						_ = (s7TYc5)(object)Sg5c1M.Default;
					}
					else if (obj == null)
					{
						break;
					}
				}
			}
			else
			{
				_ = (Dq6e2L)(object)((Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1).ListView1;
			}
			UIntPtr num2 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num2) * uIntPtr == 0)
			{
				try
				{
					if (uIntPtr == 0)
					{
						ns12Zw = null;
						ns12Zw = ns12Zw;
					}
					else
					{
						_ = (Ns12Zw)(object)Sg5c1M.Default;
					}
				}
				finally
				{
					if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
					{
						Wk4s1B wk4s1B = wk4s1B;
						wk4s1B = wk4s1B;
					}
					goto IL_0138;
				}
			}
			goto IL_0138;
		}
		IL_0138:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Ag58Qx)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				_ = (o9A2Ym)(object)Sg5c1M.Default;
			}
			goto IL_01da;
		}
		try
		{
			_ = (Ag58Qx)(object)((Qf50Jc)null).ListView1;
			_ = (Rx3a7Y)(object)qf50Jc.ListView1;
			_ = (Cy89Fz)(object)qf50Jc.ListView1;
		}
		catch
		{
			_ = (Cy89Fz)(object)Sg5c1M.Default;
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (f6ASw4)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
			}
			else
			{
				_ = (z2S7Ta)(object)Sg5c1M.Default;
			}
			goto IL_01da;
		}
		IL_0456:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gd43Lj gd43Lj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xe4g3L xe4g3L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7TYc5 s7TYc);
		checked
		{
			if (unchecked((nuint)(UIntPtr)((Qf50Jc)(object)qf50Jc.ListView1).ListView1) - unchecked((nuint)(UIntPtr)Sg5c1M.Default) == 0)
			{
				if ((uIntPtr + (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)))) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (obj != null)
					{
						gd43Lj = gd43Lj;
						_ = (Xe4g3L)(object)Sg5c1M.Default;
						ns12Zw = ns12Zw;
						xe4g3L = xe4g3L;
					}
				}
			}
			else
			{
				try
				{
					while (obj != null)
					{
						f6ASw4 f6ASw = null;
					}
				}
				catch
				{
					while ((object)Sg5c1M.Default != null)
					{
						_ = (Rx3a7Y)(object)Sg5c1M.Default;
					}
				}
			}
			qf50Jc = (Qf50Jc)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
			while (obj != null)
			{
				try
				{
					try
					{
						_ = Sg5c1M.Default;
						_ = (Xe4g3L)(object)((Qf50Jc)null).ListView1;
					}
					finally
					{
						_ = (_003CModule_003E)(object)Sg5c1M.Default;
						goto end_IL_0527;
					}
					end_IL_0527:;
				}
				catch
				{
					try
					{
						gd43Lj = gd43Lj;
					}
					catch
					{
						s7TYc = s7TYc;
					}
				}
			}
		}
		try
		{
			_ = (Dq6e2L)(object)Sg5c1M.Default;
			return;
		}
		catch
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (i9XEz8)Sg5c1M.Default;
					return;
				}
				catch
				{
					i9XEz8 i9XEz = (i9XEz8)Sg5c1M.Default;
					return;
				}
			}
			return;
		}
		IL_01da:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Wk4s1B)Sg5c1M.Default;
				}
				catch
				{
					ns12Zw = null;
				}
			}
			catch
			{
				_ = (a2K0Zg)(object)qf50Jc.ListView1;
			}
		}
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (f6ASw4)(object)qf50Jc.ListView1;
				}
				finally
				{
					gd43Lj = null;
					gd43Lj = gd43Lj;
					goto end_IL_0215;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				xe4g3L = (Xe4g3L)(object)Sg5c1M.Default;
				xe4g3L = xe4g3L;
			}
			end_IL_0215:;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out f6ASw4 f6ASw);
			while (obj != null)
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ns12Zw)(object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
					f6ASw = f6ASw;
					f6ASw = f6ASw;
				}
			}
			goto IL_02ad;
		}
		IL_02ad:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (s7TYc5)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
			}
			while ((object)qf50Jc.ListView1 != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out z2S7Ta z2S7Ta);
			while (obj != null)
			{
				z2S7Ta = z2S7Ta;
				z2S7Ta = z2S7Ta;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					gf7z4M = gf7z4M;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					f6ASw4 f6ASw = (f6ASw4)(object)((Qf50Jc)null).ListView1;
				}
				goto IL_0389;
			}
		}
		goto IL_0389;
		IL_0389:
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Cy89Fz)(object)Sg5c1M.Default;
				}
				catch
				{
					_ = (a2K0Zg)(object)Sg5c1M.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					_ = (o9A2Ym)(object)Sg5c1M.Default;
				}
				else
				{
					gd43Lj = gd43Lj;
				}
			}
		}
		_003CModule_003E = _003CModule_003E;
		_ = (Di35Ts)(object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
		_ = (Dq6e2L)(object)Sg5c1M.Default;
		try
		{
			i9XEz8 i9XEz = i9XEz;
			i9XEz = i9XEz;
			_ = (Xe4g3L)(object)Sg5c1M.Default;
			s7TYc = s7TYc;
			s7TYc = null;
		}
		finally
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr + uIntPtr - uIntPtr) != 0)
				{
					_ = (Gf7z4M)(object)qf50Jc.ListView1;
					continue;
				}
				qf50Jc = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
				Sg5c1M sg5c1M = null;
				sg5c1M = sg5c1M;
				_ = (Xe4g3L)(object)qf50Jc.ListView1;
			}
			while (obj != null);
			goto IL_0456;
		}
	}

	static void d3YKq5()
	{
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		f6ASw4 f6ASw;
		checked
		{
			nuint num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (unchecked(num / checked(unchecked((nuint)default(UIntPtr)) - uIntPtr)) + uIntPtr == 0)
			{
				_ = (o9A2Ym)(object)Sg5c1M.Default;
				goto IL_008f;
			}
			try
			{
			}
			finally
			{
				while ((object)qf50Jc.ListView1 != null)
				{
					f6ASw = (f6ASw4)(object)Sg5c1M.Default;
					f6ASw = f6ASw;
				}
				goto IL_008f;
			}
		}
		IL_0279:
		Cy89Fz cy89Fz = null;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Ag58Qx)(object)qf50Jc.ListView1;
			_ = (Gf7z4M)(object)Sg5c1M.Default;
		}
		cy89Fz = (Cy89Fz)(object)qf50Jc.ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				do
				{
					Nw9r7H nw9r7H = null;
					nw9r7H = nw9r7H;
				}
				while (obj != null);
			}
		}
		o9A2Ym o9A2Ym = o9A2Ym;
		o9A2Ym = o9A2Ym;
		try
		{
			_ = (_003CModule_003E)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		}
		catch
		{
			try
			{
				_ = (Cy89Fz)(object)Sg5c1M.Default;
			}
			finally
			{
				_ = (Gd43Lj)(object)Sg5c1M.Default;
				goto end_IL_02fe;
			}
			end_IL_02fe:;
		}
		_ = (a2K0Zg)(object)Sg5c1M.Default;
		f6ASw = null;
		_ = (Ag58Qx)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (i9XEz8)Sg5c1M.Default;
			}
			while (obj != null);
		}
		return;
		IL_0214:
		while ((object)((Qf50Jc)null).ListView1 != null)
		{
			while ((object)Sg5c1M.Default != null)
			{
				_ = (o9A2Ym)(object)qf50Jc.ListView1;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z2S7Ta z2S7Ta);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Rx3a7Y obj3 = (Rx3a7Y)(object)Sg5c1M.Default;
					Rx3a7Y rx3a7Y = rx3a7Y;
					rx3a7Y = obj3;
				}
				finally
				{
					Rx3a7Y rx3a7Y = null;
					goto IL_0279;
				}
			}
			try
			{
				z2S7Ta = z2S7Ta;
				_ = (Rx3a7Y)(object)Sg5c1M.Default;
			}
			finally
			{
				_ = (z2S7Ta)(object)qf50Jc.ListView1;
				goto IL_0279;
			}
		}
		goto IL_0279;
		IL_008f:
		_ = (_003CModule_003E)(object)Sg5c1M.Default;
		_ = (Ag58Qx)(object)Sg5c1M.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (true)
			{
				obj = obj;
				if (obj != null)
				{
					z2S7Ta obj4 = (z2S7Ta)(object)Sg5c1M.Default;
					z2S7Ta = (z2S7Ta)(object)Sg5c1M.Default;
					z2S7Ta = obj4;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Qf50Jc)(object)Sg5c1M.Default).ListView1 == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (i9XEz8)((Qf50Jc)null).ListView1;
					_ = (i9XEz8)qf50Jc.ListView1;
				}
			}
			else
			{
				Ns12Zw ns12Zw = ns12Zw;
				ns12Zw = ns12Zw;
			}
		}
		nuint num2 = checked(uIntPtr + uIntPtr);
		UIntPtr num3 = (UIntPtr)Sg5c1M.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num2 * (unchecked((nuint)num3) - uIntPtr) == 0)
			{
				Gd43Lj gd43Lj = gd43Lj;
				gd43Lj = null;
				goto IL_0214;
			}
		}
		try
		{
			while (obj != null)
			{
				cy89Fz = null;
				cy89Fz = cy89Fz;
			}
		}
		finally
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Gf7z4M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				_ = (z2S7Ta)(object)Sg5c1M.Default;
				_ = (Qf50Jc)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
				_ = (Cy89Fz)(object)Sg5c1M.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)qf50Jc.ListView1;
			}
			goto IL_0214;
		}
	}
}
