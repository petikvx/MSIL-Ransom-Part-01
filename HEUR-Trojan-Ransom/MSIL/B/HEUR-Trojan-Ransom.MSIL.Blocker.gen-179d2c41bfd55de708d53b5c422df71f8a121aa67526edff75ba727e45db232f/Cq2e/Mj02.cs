using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lt35;
using Microsoft.VisualBasic.CompilerServices;
using o3D8;
using r4CR;
using x5NZ;
using y0R;

namespace Cq2e;

[DesignerGenerated]
public class Mj02 : Form
{
	private IContainer components;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal ProgressBar G;

	internal Timer W;

	internal PictureBox F;

	public Mj02()
	{
		((Form)this).add_Load((EventHandler)g9NS);
		Qs5t();
	}

	protected override void p4D2(bool w4BY)
	{
		try
		{
			if (w4BY && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w4BY);
		}
	}

	private void Qs5t()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		components = new Container();
		Ai70(new ProgressBar());
		Nw72(new Timer(components));
		Zo12(new PictureBox());
		((ISupportInitialize)e2L1()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)m3YE()).set_Location(new Point(23, 265));
		((Control)m3YE()).set_Name("ProgressBar1");
		((Control)m3YE()).set_Size(new Size(345, 23));
		m3YE().set_Style((ProgressBarStyle)1);
		((Control)m3YE()).set_TabIndex(0);
		((Control)m3YE()).set_UseWaitCursor(true);
		Lj8f().set_Enabled(true);
		((Control)e2L1()).set_Dock((DockStyle)5);
		((Control)e2L1()).set_Location(new Point(0, 0));
		((Control)e2L1()).set_Name("PictureBox1");
		((Control)e2L1()).set_Size(new Size(391, 324));
		e2L1().set_SizeMode((PictureBoxSizeMode)1);
		e2L1().set_TabIndex(1);
		e2L1().set_TabStop(false);
		((Control)e2L1()).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(391, 324));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)m3YE());
		((Control)this).get_Controls().Add((Control)(object)e2L1());
		((Control)this).set_Name("loading");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_UseWaitCursor(true);
		((ISupportInitialize)e2L1()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual ProgressBar m3YE()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai70(ProgressBar b8B5)
	{
		ProgressBar val = (G = b8B5);
	}

	[SpecialName]
	internal virtual Timer Lj8f()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw72(Timer Bi9f)
	{
		EventHandler eventHandler = Fq57;
		Timer w = W;
		if (w != null)
		{
			w.remove_Tick(eventHandler);
		}
		Timer val = (W = Bi9f);
		w = W;
		if (w != null)
		{
			w.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox e2L1()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo12(PictureBox Gt16)
	{
		PictureBox val = (F = Gt16);
	}

	private void g9NS(object sender, EventArgs e)
	{
	}

	private void Fq57(object sender, EventArgs e)
	{
		m3YE().Increment(5);
		if (m3YE().get_Value() == 100)
		{
			Lj8f().Stop();
			((Control)Fb9z.Forms.Ad5o()).Show();
			((Control)this).Hide();
		}
	}

	[STAThread]
	public static void k5HG()
	{
		try
		{
			int nc;
			do
			{
				nc = 2;
			}
			while (!Lt8o.Sr21() || !g0W3.p7CN(nc));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Zz9s.Lf5(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Zz9s.Lf5(Listt, 1, 1);
			mName = Zz9s.Lf5(Listt, 2, 2);
			mArray = Zz9s.Lf5(Listt, 3, 3);
			sArray = Zz9s.Lf5(Listt, 4, 4);
			T = Zz9s.Lf5(Listt, 5, 5);
			sNum = Zz9s.Lf5(Listt, 6, 6);
			mDic.Add(sNum, 96);
			byte[] value = Zz9s.g7P(96, 15);
			mDic.Add(sArray, value);
			Tf4.s7Z();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
