using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using w3X6;

namespace c5AP;

[DesignerGenerated]
public class Jg25 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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
			EventHandler eventHandler = c8MC;
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			EventHandler eventHandler = Zn5p;
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
			EventHandler eventHandler = Bq4;
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
			EventHandler eventHandler = r1H;
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
			EventHandler eventHandler = t0J;
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
			EventHandler eventHandler = c8X0;
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
			EventHandler eventHandler = e8E;
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

	public Jg25()
	{
		((Form)this).add_Load((EventHandler)j4XS);
		p1B9();
	}

	[DebuggerNonUserCode]
	protected override void a8X1(bool x6G5)
	{
		try
		{
			if (x6G5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x6G5);
		}
	}

	[DebuggerStepThrough]
	private void p1B9()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		Label4 = new Label();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		Label3 = new Label();
		Button6 = new Button();
		Button4 = new Button();
		Button3 = new Button();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		Label5 = new Label();
		TextBox5 = new TextBox();
		ComboBox1 = new ComboBox();
		ComboBox2 = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)Label4).set_Location(new Point(8, 111));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(116, 22));
		((Control)Label4).set_TabIndex(27);
		Label4.set_Text("Max. Mark");
		Label4.set_TextAlign((ContentAlignment)16);
		((Control)TextBox4).set_Location(new Point(126, 111));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(260, 22));
		((Control)TextBox4).set_TabIndex(26);
		((Control)TextBox3).set_Location(new Point(126, 79));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(260, 22));
		((Control)TextBox3).set_TabIndex(25);
		((Control)Label3).set_Location(new Point(8, 79));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(116, 22));
		((Control)Label3).set_TabIndex(24);
		Label3.set_Text("Subject Class");
		Label3.set_TextAlign((ContentAlignment)16);
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(240, 194));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(93, 30));
		((Control)Button6).set_TabIndex(23);
		((ButtonBase)Button6).set_Text("Cancel");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Location(new Point(126, 194));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(93, 30));
		((Control)Button4).set_TabIndex(21);
		((ButtonBase)Button4).set_Text("Update");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Location(new Point(11, 194));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(93, 30));
		((Control)Button3).set_TabIndex(20);
		((ButtonBase)Button3).set_Text("Search");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)TextBox2).set_Location(new Point(126, 47));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(260, 22));
		((Control)TextBox2).set_TabIndex(17);
		((Control)TextBox1).set_Location(new Point(126, 15));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(260, 22));
		((Control)TextBox1).set_TabIndex(16);
		((Control)TextBox1).set_Visible(false);
		((Control)Label2).set_Location(new Point(8, 15));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(116, 22));
		((Control)Label2).set_TabIndex(15);
		Label2.set_Text("Subject ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)Label1).set_Location(new Point(8, 47));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(116, 22));
		((Control)Label1).set_TabIndex(14);
		Label1.set_Text("Subject Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)Label5).set_Location(new Point(8, 147));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(116, 22));
		((Control)Label5).set_TabIndex(28);
		Label5.set_Text("Semister");
		Label5.set_TextAlign((ContentAlignment)16);
		((Control)TextBox5).set_Location(new Point(126, 147));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(260, 22));
		((Control)TextBox5).set_TabIndex(29);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[6] { "I", "II", "III", "IV", "V", "VI" });
		((Control)ComboBox1).set_Location(new Point(126, 145));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(260, 24));
		((Control)ComboBox1).set_TabIndex(30);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(126, 15));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(260, 24));
		((Control)ComboBox2).set_TabIndex(31);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_ClientSize(new Size(402, 241));
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Subject1");
		((Form)this).set_Text("Subjects Detail");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void c8X0(object sender, EventArgs e)
	{
	}

	private void c8MC(object sender, EventArgs e)
	{
	}

	private void j4XS(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		Ns49.ds.Clear();
		Ns49.Cj7g();
		Ns49.cn.Open();
		Ns49.str = "select * from Subject";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Subject");
		Ns49.cn.Close();
		Ns49.ds.Clear();
		Ns49.cn.Open();
		Ns49.str = "select * from Subject";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Subject");
		checked
		{
			int num = Ns49.ds.Tables["Subject"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox2.get_Items().Add((object)Ns49.ds.Tables["Subject"]!.Rows[i][0].ToString());
			}
			Ns49.cn.Close();
		}
	}

	private void Zn5p(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static string o1X(string[] j6W, int w9D, int a5T)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = w9D; i <= a5T; i = checked(i + 1))
		{
			stringBuilder.Append(j6W[i]);
		}
		return stringBuilder.ToString();
	}

	private void r1H(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				((Control)ComboBox1).set_Visible(false);
				int num = 0;
				Ns49.cn.Open();
				Ns49.str = "select * from Subject ";
				Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
				Ns49.da.set_SelectCommand(Ns49.cmd);
				((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Subject");
				int num2 = Ns49.ds.Tables["Subject"]!.Rows.Count - 1;
				int num3 = num2;
				for (num = 0; num <= num3; num++)
				{
					if (Operators.CompareString(TextBox1.get_Text(), Ns49.ds.Tables["Subject"]!.Rows[num][0].ToString(), false) == 0)
					{
						TextBox2.set_Text(Ns49.ds.Tables["Subject"]!.Rows[num][1].ToString());
						TextBox3.set_Text(Ns49.ds.Tables["Subject"]!.Rows[num][2].ToString());
						TextBox4.set_Text(Ns49.ds.Tables["Subject"]!.Rows[num][3].ToString());
						TextBox5.set_Text(Ns49.ds.Tables["Subject"]!.Rows[num][4].ToString());
					}
				}
				Ns49.cn.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Insert Subject Id First.", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void t0J(object sender, EventArgs e)
	{
	}

	private void Bq4(object sender, EventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Ns49.cn.Open();
			Ns49.str = " update Subject set SubjectName = '" + TextBox2.get_Text() + "', SubjectClass = '" + TextBox3.get_Text() + "', mark = " + TextBox4.get_Text() + " semister = '" + ComboBox1.get_Text() + "' where SubjectID = " + TextBox1.get_Text() + " ";
			Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
			Ns49.da.set_UpdateCommand(Ns49.cmd);
			Ns49.da.get_UpdateCommand().ExecuteNonQuery();
			Ns49.cn.Close();
			Interaction.MsgBox((object)"Record Updated.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Enter Subject ID first.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool Sc3(string Ro0)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Ro0);
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

	private void e8E(object sender, EventArgs e)
	{
		TextBox1.set_Text(ComboBox2.get_Text());
	}
}
