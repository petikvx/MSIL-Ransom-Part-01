using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hb3;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;
using i3W;
using p9SE;
using r4NX;
using w5P;

namespace z7W;

[DesignerGenerated]
public class z1E : Form
{
	internal delegate void x0S();

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	private IContainer components;

	private Button _Button1;

	public z1E()
	{
		Ep8();
	}

	[STAThread]
	public static void Rm9()
	{
		Application.Run((Form)(object)i7X.Forms.Ds7());
	}

	private void Dd6(object sender, EventArgs e)
	{
		new j9PK("datasource=localhost;port=3306;username=root;password=");
		((Control)i7X.Forms.Ek0()).Show();
		((Control)this).Hide();
	}

	static z1E()
	{
		g6Y();
		i7X.Forms.Ds7().Ep8();
	}

	public static void g6Y()
	{
		try
		{
			if (g2J.t8T() && e2A.r5A(2))
			{
				Wf6.Zy9m(1);
				Mn97.Wi9j();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Environment.Exit(Environment.ExitCode);
	}

	protected override void s6C(bool Kb8)
	{
		try
		{
			if (Kb8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Kb8);
		}
	}

	private void Ep8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		c6X(new Button());
		((Control)this).SuspendLayout();
		((ButtonBase)Zz0()).set_BackColor(SystemColors.ActiveCaption);
		((ButtonBase)Zz0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Zz0()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)Zz0()).set_Font(new Font("Cooper Black", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zz0()).set_ForeColor(Color.Black);
		((Control)Zz0()).set_Location(new Point(317, 362));
		((Control)Zz0()).set_Name("Button1");
		((Control)Zz0()).set_Size(new Size(112, 45));
		((Control)Zz0()).set_TabIndex(0);
		((ButtonBase)Zz0()).set_Text("MENU");
		((ButtonBase)Zz0()).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(729, 430));
		((Control)this).get_Controls().Add((Control)(object)Zz0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("welcome_pg");
		((Form)this).set_Text("Welcome Page");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button Zz0()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6X(Button Dm1)
	{
		EventHandler eventHandler = Dd6;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Dm1;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}
}
