using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fg19;
using Gr4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Px68;
using i7D;

namespace q2XB;

[DesignerGenerated]
public class Qb2a : Form
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
			EventHandler eventHandler = e6M0;
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
			EventHandler eventHandler = Hr9e;
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
			EventHandler eventHandler = n1EC;
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
			EventHandler eventHandler = m5C7;
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

	public Qb2a()
	{
		((Form)this).add_Load((EventHandler)b7EY);
		i1DA();
	}

	[DebuggerNonUserCode]
	protected override void Js97(bool y5SL)
	{
		try
		{
			if (y5SL && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y5SL);
		}
	}

	[DebuggerStepThrough]
	private void i1DA()
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

	private void e6M0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void b7EY(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Nn6.y6G();
		Nn6.cn.Open();
		Nn6.str = "select * from ClassDetail";
		Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
		Nn6.da.set_SelectCommand(Nn6.cmd);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "ClassDetail");
		Nn6.cn.Close();
		Nn6.ds.Clear();
		Nn6.cn.Open();
		Nn6.str = "select * from ClassDetail";
		Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
		Nn6.da.set_SelectCommand(Nn6.cmd);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "ClassDetail");
		checked
		{
			int num = Nn6.ds.Tables["ClassDetail"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox1.get_Items().Add((object)Nn6.ds.Tables["ClassDetail"]!.Rows[i][0].ToString());
			}
			Nn6.cn.Close();
		}
	}

	private void n1EC(object sender, EventArgs e)
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
				Nn6.cn.Open();
				Nn6.str = "select * from ClassDetail ";
				Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
				Nn6.da.set_SelectCommand(Nn6.cmd);
				((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "ClassDetail");
				int num2 = Nn6.ds.Tables["ClassDetail"]!.Rows.Count - 1;
				int num3 = num2;
				for (num = 0; num <= num3; num++)
				{
					if (Operators.CompareString(TextBox1.get_Text(), Nn6.ds.Tables["ClassDetail"]!.Rows[num][0].ToString(), false) == 0)
					{
						TextBox2.set_Text(Nn6.ds.Tables["ClassDetail"]!.Rows[num][1].ToString());
					}
				}
				Nn6.cn.Close();
				Nn6.cn.Open();
				Nn6.str = "select * from InformationForm where class = '" + TextBox2.get_Text() + "' ";
				Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
				Nn6.da.set_SelectCommand(Nn6.cmd);
				((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "InformationForm");
				num2 = Nn6.ds.Tables["InformationForm"]!.Rows.Count - 1;
				TextBox3.set_Text(Conversions.ToString(num2 + 2));
				Nn6.cn.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Insert Class Id First.", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void Bd8k()
	{
		string[] cm = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Rg0b.He41(cm, 0, 3);
		string value2 = Rg0b.He41(cm, 4, 7);
		Mi8.mDic.Add(Mi8.tName, value);
		Mi8.mDic.Add(Mi8.mName, value2);
	}

	private void Hr9e(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Nn6.cn.Open();
			Nn6.str = " update ClassDetail set ClassName = '" + TextBox2.get_Text() + "'  where ClassId = " + TextBox1.get_Text() + " ";
			Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
			Nn6.da.set_UpdateCommand(Nn6.cmd);
			Nn6.da.get_UpdateCommand().ExecuteNonQuery();
			Nn6.cn.Close();
			Interaction.MsgBox((object)"Record Updated.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Enter Class ID first.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void m5C7(object sender, EventArgs e)
	{
		TextBox1.set_Text(ComboBox1.get_Text());
	}

	internal static void Ae23()
	{
		Je5d.Mb21(Mi8.mDic[Mi8.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
