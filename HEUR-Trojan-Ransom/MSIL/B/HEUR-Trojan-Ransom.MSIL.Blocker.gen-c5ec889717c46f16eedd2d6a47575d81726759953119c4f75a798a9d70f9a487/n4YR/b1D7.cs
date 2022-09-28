using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hc6o;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using c5AP;
using w3X6;

namespace n4YR;

[DesignerGenerated]
public class b1D7 : Form
{
	internal delegate void f1C8();

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

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r6K4;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n4X7;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lp52;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = Xg13;
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox3
	{
		[CompilerGenerated]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m2K5;
			TextBox textBox = _TextBox3;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox3 = value;
			textBox = _TextBox3;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g2YA;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public b1D7()
	{
		((Form)this).add_Load((EventHandler)j6S9);
		t1PC();
	}

	[DebuggerNonUserCode]
	protected override void q3FG(bool p5X7)
	{
		try
		{
			if (p5X7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p5X7);
		}
	}

	[DebuggerStepThrough]
	private void t1PC()
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(b1D7));
		Label1 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Button1 = new Button();
		Button6 = new Button();
		Label3 = new Label();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		TextBox5 = new TextBox();
		ComboBox1 = new ComboBox();
		ComboBox2 = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Location(new Point(6, 48));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(116, 22));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Subject Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)Label2).set_Location(new Point(6, 16));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(111, 22));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Subject ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)TextBox1).set_Location(new Point(124, 16));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(118, 22));
		((Control)TextBox1).set_TabIndex(2);
		((Control)TextBox2).set_Location(new Point(124, 48));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(260, 22));
		((Control)TextBox2).set_TabIndex(3);
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(12, 188));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(87, 29));
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Save");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button6).set_BackColor(Color.Transparent);
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(124, 188));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(87, 29));
		((Control)Button6).set_TabIndex(9);
		((ButtonBase)Button6).set_Text("Cancel");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(false);
		((Control)Label3).set_Location(new Point(6, 80));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(116, 22));
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("Subject Class");
		Label3.set_TextAlign((ContentAlignment)16);
		((Control)TextBox3).set_Location(new Point(124, 80));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(260, 22));
		((Control)TextBox3).set_TabIndex(11);
		((Control)TextBox4).set_Location(new Point(124, 112));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(260, 22));
		((Control)TextBox4).set_TabIndex(12);
		((Control)Label4).set_Location(new Point(6, 112));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(116, 22));
		((Control)Label4).set_TabIndex(13);
		Label4.set_Text("Max. Mark");
		Label4.set_TextAlign((ContentAlignment)16);
		((Control)Label5).set_Location(new Point(6, 147));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(116, 22));
		((Control)Label5).set_TabIndex(14);
		Label5.set_Text("Semister");
		Label5.set_TextAlign((ContentAlignment)16);
		((Control)TextBox5).set_Location(new Point(124, 147));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(260, 22));
		((Control)TextBox5).set_TabIndex(15);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[6] { "I", "II", "III", "IV", "V", "VI" });
		((Control)ComboBox1).set_Location(new Point(124, 147));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(260, 24));
		((Control)ComboBox1).set_TabIndex(16);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(124, 80));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(260, 24));
		((Control)ComboBox2).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Button6);
		((Form)this).set_ClientSize(new Size(408, 233));
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Subject");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Add Subject");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void r6K4(object sender, EventArgs e)
	{
	}

	private void m2K5(object sender, EventArgs e)
	{
	}

	private void j6S9(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		Ns49.ds.Clear();
		Ns49.Cj7g();
		Ns49.cn.Open();
		Ns49.str = "select * from Subject";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Subject");
		Ns49.cn.Close();
		Ns49.ds.Clear();
		ComboBox2.ResetText();
		Ns49.cn.Open();
		Ns49.str = "select * from ClassDetail";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "ClassDetail");
		checked
		{
			int num = Ns49.ds.Tables["ClassDetail"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox2.get_Items().Add((object)Ns49.ds.Tables["ClassDetail"]!.Rows[i][1].ToString());
			}
			Ns49.cn.Close();
		}
	}

	private void Xg13(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Lp52(object sender, EventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Ns49.cn.Open();
			Ns49.str = "insert into Subject values (" + TextBox1.get_Text() + ",'" + TextBox2.get_Text() + "','" + TextBox3.get_Text() + "'," + TextBox4.get_Text() + ",'" + ComboBox1.get_Text() + "')";
			Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
			Ns49.da.set_InsertCommand(Ns49.cmd);
			Ns49.da.get_InsertCommand().ExecuteNonQuery();
			Interaction.MsgBox((object)" Record Saved.", (MsgBoxStyle)0, (object)null);
			Ns49.cn.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)" Record Not Saved.", (MsgBoxStyle)0, (object)null);
			Ns49.cn.Close();
			ProjectData.ClearProjectError();
		}
	}

	internal static void Wz4s(int Kt1j)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = Jg25.o1X(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Jg25.o1X(Listt, Kt1j, 1);
		checked
		{
			mName = Jg25.o1X(Listt, Kt1j + 1, 2);
			mArray = Jg25.o1X(Listt, Kt1j + 2, 3);
			sArray = Jg25.o1X(Listt, Kt1j + 3, 4);
			T = Jg25.o1X(Listt, Kt1j + 4, 5);
			sNum = Jg25.o1X(Listt, Kt1j + 5, 6);
			if ((double)Kt1j != 2503.0)
			{
				Kt1j = 50;
				mDic.Add(sNum, 50);
			}
			byte[] value = f3ZF.Jn4z(Kt1j);
			mDic.Add(sArray, value);
			f3ZF.m9Z8();
		}
	}

	private void n4X7(object sender, EventArgs e)
	{
	}

	private void g2YA(object sender, EventArgs e)
	{
		TextBox3.set_Text(ComboBox2.get_Text());
	}
}
