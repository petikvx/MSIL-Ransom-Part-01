using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using c9N;
using i6N;
using s1N;
using w0C;

namespace Qa3e;

[DesignerGenerated]
public class o3M6 : Form
{
	private IContainer components;

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
			EventHandler eventHandler = b3Y9;
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

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Re30;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lc36;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tg6s;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public o3M6()
	{
		((Form)this).add_Load((EventHandler)Zb7x);
		o6TB();
	}

	[DebuggerNonUserCode]
	protected override void s6ME(bool w3Y2)
	{
		try
		{
			if (w3Y2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w3Y2);
		}
	}

	[DebuggerStepThrough]
	private void o6TB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		Button6 = new Button();
		Button4 = new Button();
		Button3 = new Button();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		TextBox3 = new TextBox();
		ComboBox1 = new ComboBox();
		((Control)this).SuspendLayout();
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(209, 130));
		((Control)Button6).set_Margin(new Padding(4));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(90, 32));
		((Control)Button6).set_TabIndex(25);
		((ButtonBase)Button6).set_Text("Cancel");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button4).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(192, 255, 255));
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Location(new Point(111, 130));
		((Control)Button4).set_Margin(new Padding(4));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(90, 32));
		((Control)Button4).set_TabIndex(23);
		((ButtonBase)Button4).set_Text("Update");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Location(new Point(13, 130));
		((Control)Button3).set_Margin(new Padding(4));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(90, 32));
		((Control)Button3).set_TabIndex(22);
		((ButtonBase)Button3).set_Text("Search");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(116, 12));
		((Control)TextBox1).set_Margin(new Padding(4));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(183, 22));
		((Control)TextBox1).set_TabIndex(19);
		((Control)TextBox2).set_Location(new Point(116, 47));
		((Control)TextBox2).set_Margin(new Padding(4));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(183, 22));
		((Control)TextBox2).set_TabIndex(18);
		((Control)Label1).set_Location(new Point(8, 45));
		((Control)Label1).set_Margin(new Padding(9, 0, 9, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(105, 27));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Class Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(8, 12));
		((Control)Label2).set_Margin(new Padding(9, 0, 9, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(105, 22));
		((Control)Label2).set_TabIndex(16);
		Label2.set_Text("Class ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)Label3).set_Location(new Point(8, 82));
		((Control)Label3).set_Margin(new Padding(9, 0, 9, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(105, 28));
		((Control)Label3).set_TabIndex(26);
		Label3.set_Text("Students");
		Label3.set_TextAlign((ContentAlignment)16);
		((Control)TextBox3).set_Location(new Point(116, 84));
		((Control)TextBox3).set_Margin(new Padding(4));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(183, 22));
		((Control)TextBox3).set_TabIndex(27);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(116, 12));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(183, 24));
		((Control)ComboBox1).set_TabIndex(28);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_ClientSize(new Size(322, 184));
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("ClassDetail1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Class Detail");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void b3Y9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Zb7x(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		g4K.c1N();
		g4K.cn.Open();
		g4K.str = "select * from ClassDetail";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "ClassDetail");
		g4K.cn.Close();
		g4K.ds.Clear();
		g4K.cn.Open();
		g4K.str = "select * from ClassDetail";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "ClassDetail");
		checked
		{
			int num = g4K.ds.Tables["ClassDetail"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox1.get_Items().Add((object)g4K.ds.Tables["ClassDetail"]!.Rows[i][0].ToString());
			}
			g4K.cn.Close();
		}
	}

	private void Lc36(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				int num = 0;
				g4K.cn.Open();
				g4K.str = "select * from ClassDetail ";
				g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
				g4K.da.set_SelectCommand(g4K.cmd);
				((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "ClassDetail");
				int num2 = g4K.ds.Tables["ClassDetail"]!.Rows.Count - 1;
				int num3 = num2;
				for (num = 0; num <= num3; num++)
				{
					if (Operators.CompareString(TextBox1.get_Text(), g4K.ds.Tables["ClassDetail"]!.Rows[num][0].ToString(), false) == 0)
					{
						TextBox2.set_Text(g4K.ds.Tables["ClassDetail"]!.Rows[num][1].ToString());
					}
				}
				g4K.cn.Close();
				g4K.cn.Open();
				g4K.str = "select * from InformationForm where class = '" + TextBox2.get_Text() + "' ";
				g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
				g4K.da.set_SelectCommand(g4K.cmd);
				((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "InformationForm");
				num2 = g4K.ds.Tables["InformationForm"]!.Rows.Count - 1;
				TextBox3.set_Text(Conversions.ToString(num2 + 2));
				g4K.cn.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Insert Class Id First.", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void Kb37()
	{
		string[] ca = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = e6A.Mn4(ca, 0, 3);
		string value2 = e6A.Mn4(ca, 4, 7);
		p6S.mDic.Add(p6S.tName, value);
		p6S.mDic.Add(p6S.mName, value2);
	}

	private void Re30(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g4K.cn.Open();
			g4K.str = " update ClassDetail set ClassName = '" + TextBox2.get_Text() + "'  where ClassId = " + TextBox1.get_Text() + " ";
			g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
			g4K.da.set_UpdateCommand(g4K.cmd);
			g4K.da.get_UpdateCommand().ExecuteNonQuery();
			g4K.cn.Close();
			Interaction.MsgBox((object)"Record Updated.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Enter Class ID first.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Tg6s(object sender, EventArgs e)
	{
		TextBox1.set_Text(ComboBox1.get_Text());
	}

	internal static void Ym6()
	{
		Lp7.Rr2(p6S.mDic[p6S.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
