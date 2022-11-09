using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cf97;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using f4W9;
using r9A;
using t0B;

namespace w1H;

[DesignerGenerated]
public class Pf0 : Form
{
	public string connectionString;

	private Button _LoginButton;

	private Panel _Panel1;

	private RadioButton _PublisherRadioButton;

	private RadioButton _AuthorRadioButton;

	private RadioButton _FieldRadioButton1;

	private RadioButton _ISBNRadioButton;

	private Label _Label2;

	private PictureBox _PictureBox1;

	private Timer _Timer2;

	internal IContainer x;

	internal Button i;

	internal RadioButton l;

	internal Panel e;

	internal Button W;

	internal Button D;

	internal TextBox r;

	public Pf0()
	{
		((Form)this).add_Load((EventHandler)Nq8);
		connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb";
		w1Y();
	}

	public void s8R(OleDbDataReader x0J)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		((Control)t7J()).get_Controls().Clear();
		checked
		{
			int num = (int)Math.Round((double)((Control)t7J()).get_Width() / 3.0);
			int num2 = 220;
			int num3 = 0;
			int num4 = 0;
			while (x0J.Read())
			{
				string imageLocation = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), x0J.get_Item("BookImage")));
				LinkLabel val = new LinkLabel();
				Label val2 = new Label();
				Label val3 = new Label();
				Label val4 = new Label();
				PictureBox val5 = new PictureBox();
				PictureBox val6 = new PictureBox();
				((Control)val6).set_Size(new Size(390, 210));
				((Control)val).set_Size(new Size(170, 20));
				((Control)val2).set_Size(new Size(170, 20));
				((Control)val3).set_Size(new Size(170, 20));
				((Control)val4).set_Size(new Size(170, 20));
				((Control)val5).set_Size(new Size(200, 200));
				val5.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val).set_Tag(RuntimeHelpers.GetObjectValue(x0J.get_Item("ISBN")));
				((Control)val5).set_Tag(RuntimeHelpers.GetObjectValue(x0J.get_Item("ISBN")));
				val5.set_ImageLocation(imageLocation);
				val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Title: ", x0J.get_Item("Title"))));
				val2.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Author: ", x0J.get_Item("Author"))));
				val3.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Publisher: ", x0J.get_Item("Publisher"))));
				val4.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Location: ", x0J.get_Item("Location"))));
				val.set_VisitedLinkColor(Color.Black);
				val.set_LinkColor(Color.Black);
				((Control)val).set_ForeColor(Color.Black);
				val5.set_ForeColor(Color.Black);
				((Control)val).set_ForeColor(Color.Black);
				((Control)val2).set_ForeColor(Color.Black);
				((Control)val3).set_ForeColor(Color.Black);
				((Control)val4).set_ForeColor(Color.Black);
				((Control)val).set_BackColor(Color.LightGray);
				((Control)val5).set_BackColor(Color.LightGray);
				((Control)val).set_BackColor(Color.LightGray);
				((Control)val2).set_BackColor(Color.LightGray);
				((Control)val3).set_BackColor(Color.LightGray);
				((Control)val4).set_BackColor(Color.LightGray);
				((Control)val6).set_BackColor(Color.LightGray);
				((Control)val6).set_Location(new Point(num3 + 5, num4 + 5));
				((Control)val5).set_Location(new Point(num3 + 10, num4 + 10));
				((Control)val).set_Location(new Point(num3 + 220, num4 + 10));
				((Control)val2).set_Location(new Point(num3 + 220, num4 + 30));
				((Control)val3).set_Location(new Point(num3 + 220, num4 + 60));
				((Control)val4).set_Location(new Point(num3 + 220, num4 + 90));
				val2.set_AutoEllipsis(true);
				val4.set_AutoEllipsis(true);
				val3.set_AutoEllipsis(true);
				((Label)val).set_AutoEllipsis(true);
				((Control)val6).SendToBack();
				((Control)val).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val2).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val3).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val4).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)t7J()).get_Controls().Add((Control)(object)val);
				((Control)t7J()).get_Controls().Add((Control)(object)val5);
				((Control)t7J()).get_Controls().Add((Control)(object)val2);
				((Control)t7J()).get_Controls().Add((Control)(object)val3);
				((Control)t7J()).get_Controls().Add((Control)(object)val4);
				((Control)t7J()).get_Controls().Add((Control)(object)val6);
				((Control)val5).add_Click((EventHandler)Yk4);
				((Control)val5).add_MouseEnter((EventHandler)Nd0);
				((Control)val).add_Click((EventHandler)d2D);
				num3 += num;
				if (num3 == ((Control)t7J()).get_Width())
				{
					num3 = 0;
					num4 += num2;
				}
			}
		}
	}

	private void Nd0(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, (Type)null, "cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null);
	}

	private void Yk4(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		w0T w0T = new w0T();
		w0T.passISBN = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		((Form)w0T).ShowDialog();
	}

	private void d2D(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		w0T w0T = new w0T();
		w0T.passISBN = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		((Form)w0T).ShowDialog();
	}

	[STAThread]
	public static void b8X()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!Jw8n.Mk0t(2) || !t6M7.s0K())
				{
				}
				w0T.Jn5(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	private void p2T(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(connectionString);
		val.Open();
		string text = "SELECT * FROM Books ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader x0J = val2.ExecuteReader();
		s8R(x0J);
		val.Close();
	}

	private void Lw5(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)m2A.Forms.Ka0()).ShowDialog();
	}

	private void a3R(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(n9Q().get_Text(), "Enter Book Details", false) == 0)
		{
			MessageBox.Show("Please mention the string to search");
		}
		else if (Wi3().get_Checked())
		{
			OleDbConnection val = new OleDbConnection(connectionString);
			string text = "SELECT * FROM Books WHERE Title like '%" + n9Q().get_Text() + "%'";
			OleDbCommand val2 = new OleDbCommand(text, val);
			val.Open();
			OleDbDataReader val3 = val2.ExecuteReader();
			s8R(val3);
			if (!val3.get_HasRows())
			{
				MessageBox.Show("No search results found!");
			}
			val.Close();
		}
		else if (n9G().get_Checked())
		{
			OleDbConnection val4 = new OleDbConnection(connectionString);
			val4.Open();
			string text2 = "SELECT * FROM Books WHERE ISBN like '%" + n9Q().get_Text() + "%'";
			OleDbCommand val5 = new OleDbCommand(text2, val4);
			OleDbDataReader val6 = val5.ExecuteReader();
			s8R(val6);
			if (!val6.get_HasRows())
			{
				MessageBox.Show("No search results found!");
			}
			val4.Close();
		}
		else if (p9W().get_Checked())
		{
			OleDbConnection val7 = new OleDbConnection(connectionString);
			val7.Open();
			string text3 = "SELECT * FROM Books WHERE Field like '%" + n9Q().get_Text() + "%'";
			OleDbCommand val8 = new OleDbCommand(text3, val7);
			OleDbDataReader val9 = val8.ExecuteReader();
			s8R(val9);
			if (!val9.get_HasRows())
			{
				MessageBox.Show("No search results found!");
			}
			val7.Close();
		}
		else if (p3D().get_Checked())
		{
			OleDbConnection val10 = new OleDbConnection(connectionString);
			val10.Open();
			string text4 = "SELECT * FROM Books WHERE Publisher like '%" + n9Q().get_Text() + "%'";
			OleDbCommand val11 = new OleDbCommand(text4, val10);
			OleDbDataReader val12 = val11.ExecuteReader();
			s8R(val12);
			if (!val12.get_HasRows())
			{
				MessageBox.Show("No search results found!");
			}
			val10.Close();
		}
		else if (Jp2().get_Checked())
		{
			OleDbConnection val13 = new OleDbConnection(connectionString);
			val13.Open();
			string text5 = "SELECT * FROM Books WHERE Author like '%" + n9Q().get_Text() + "%'";
			OleDbCommand val14 = new OleDbCommand(text5, val13);
			OleDbDataReader val15 = val14.ExecuteReader();
			s8R(val15);
			if (!val15.get_HasRows())
			{
				MessageBox.Show("No search results found!");
			}
			val13.Close();
		}
		else
		{
			MessageBox.Show("Please choose a search criteria", "No radio buttons checked");
		}
	}

	private void Ar9(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		DialogResult val = MessageBox.Show("Are you sure you want to exit?", "Exit", (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			((Form)this).Close();
		}
	}

	private void Cm8(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (Operators.CompareString(n9Q().get_Text(), "Enter Book Details", false) == 0)
		{
			n9Q().set_Text("");
			Font font = new Font("Comic Sans MS", 12f, (FontStyle)0);
			((Control)n9Q()).set_Font(font);
			((TextBoxBase)n9Q()).set_ForeColor(Color.Black);
		}
	}

	private void Gb6(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (Operators.CompareString(n9Q().get_Text(), "", false) == 0)
		{
			Font font = new Font("Comic Sans MS", 12f, (FontStyle)2);
			((Control)n9Q()).set_Font(font);
			((TextBoxBase)n9Q()).set_ForeColor(Color.Gray);
			n9Q().set_Text("Enter Book Details");
		}
	}

	private void q4L()
	{
		Si8().set_Enabled(true);
		Si8().set_Interval(20000);
	}

	private void Mq2(object sender, EventArgs e)
	{
		int hour = DateTime.Now.Hour;
		Console.WriteLine(hour);
		if (hour == 18)
		{
			m4B.b2S();
			m4B.Nc1();
		}
	}

	private void a7H(object sender, PaintEventArgs e)
	{
	}

	protected override void r9K(bool Pp5)
	{
		try
		{
			if (Pp5 && x != null)
			{
				x.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pp5);
		}
	}

	private void w1Y()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected O, but got Unknown
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected O, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		IContainer container = (x = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pf0));
		c6P(new Panel());
		g3E(new Button());
		Jp2(new RadioButton());
		Nx6(new RadioButton());
		n3Y(new RadioButton());
		e5R(new RadioButton());
		Sk4(new RadioButton());
		Ro3(new TextBox());
		f4E(new Panel());
		Wg0(new Label());
		Pp1(new Button());
		s0T(new PictureBox());
		o4S(new Button());
		Nz1(new Button());
		q9Y(new Timer(x));
		((Control)o4J()).SuspendLayout();
		((ISupportInitialize)Nb2()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)o4J()).set_BackColor(Color.Black);
		((Control)o4J()).get_Controls().Add((Control)(object)a1Q());
		((Control)o4J()).get_Controls().Add((Control)(object)n9G());
		((Control)o4J()).get_Controls().Add((Control)(object)p3D());
		((Control)o4J()).get_Controls().Add((Control)(object)Jp2());
		((Control)o4J()).get_Controls().Add((Control)(object)p9W());
		((Control)o4J()).get_Controls().Add((Control)(object)Wi3());
		((Control)o4J()).get_Controls().Add((Control)(object)n9Q());
		((Control)o4J()).set_Location(new Point(26, 147));
		((Control)o4J()).set_Name("Panel1");
		((Control)o4J()).set_Size(new Size(1209, 144));
		((Control)o4J()).set_TabIndex(3);
		((ButtonBase)a1Q()).set_BackColor(Color.White);
		((Control)a1Q()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)a1Q()).set_FlatStyle((FlatStyle)1);
		((Control)a1Q()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a1Q()).set_ForeColor(Color.Black);
		((Control)a1Q()).set_Location(new Point(1018, 44));
		((Control)a1Q()).set_Name("Button1");
		((Control)a1Q()).set_Size(new Size(90, 30));
		((Control)a1Q()).set_TabIndex(5);
		((ButtonBase)a1Q()).set_Text("SEARCH");
		((ButtonBase)a1Q()).set_UseVisualStyleBackColor(false);
		((ButtonBase)n9G()).set_AutoSize(true);
		((Control)n9G()).set_Cursor(Cursors.get_Hand());
		((Control)n9G()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)n9G()).set_ForeColor(Color.White);
		((Control)n9G()).set_Location(new Point(844, 95));
		((Control)n9G()).set_Name("ISBNRadioButton");
		((Control)n9G()).set_Size(new Size(66, 24));
		((Control)n9G()).set_TabIndex(11);
		n9G().set_TabStop(true);
		((ButtonBase)n9G()).set_Text("ISBN");
		((ButtonBase)n9G()).set_UseVisualStyleBackColor(true);
		((ButtonBase)p3D()).set_AutoSize(true);
		((Control)p3D()).set_Cursor(Cursors.get_Hand());
		((Control)p3D()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p3D()).set_ForeColor(Color.White);
		((Control)p3D()).set_Location(new Point(674, 95));
		((Control)p3D()).set_Name("PublisherRadioButton");
		((Control)p3D()).set_Size(new Size(90, 24));
		((Control)p3D()).set_TabIndex(10);
		p3D().set_TabStop(true);
		((ButtonBase)p3D()).set_Text("Publisher");
		((ButtonBase)p3D()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Jp2()).set_AutoSize(true);
		((Control)Jp2()).set_Cursor(Cursors.get_Hand());
		((Control)Jp2()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Jp2()).set_ForeColor(Color.White);
		((Control)Jp2()).set_Location(new Point(320, 95));
		((Control)Jp2()).set_Name("AuthorRadioButton");
		((Control)Jp2()).set_Size(new Size(76, 24));
		((Control)Jp2()).set_TabIndex(9);
		Jp2().set_TabStop(true);
		((ButtonBase)Jp2()).set_Text("Author");
		((ButtonBase)Jp2()).set_UseVisualStyleBackColor(true);
		((ButtonBase)p9W()).set_AutoSize(true);
		((Control)p9W()).set_Cursor(Cursors.get_Hand());
		((Control)p9W()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p9W()).set_ForeColor(Color.White);
		((Control)p9W()).set_Location(new Point(474, 95));
		((Control)p9W()).set_Name("FieldRadioButton1");
		((Control)p9W()).set_Size(new Size(61, 24));
		((Control)p9W()).set_TabIndex(8);
		p9W().set_TabStop(true);
		((ButtonBase)p9W()).set_Text("Field");
		((ButtonBase)p9W()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Wi3()).set_AutoSize(true);
		((Control)Wi3()).set_Cursor(Cursors.get_Hand());
		((Control)Wi3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Wi3()).set_ForeColor(Color.White);
		((Control)Wi3()).set_Location(new Point(173, 95));
		((Control)Wi3()).set_Name("TitleRadioButton");
		((Control)Wi3()).set_Size(new Size(60, 24));
		((Control)Wi3()).set_TabIndex(7);
		Wi3().set_TabStop(true);
		((ButtonBase)Wi3()).set_Text("Title");
		((ButtonBase)Wi3()).set_UseVisualStyleBackColor(true);
		((Control)n9Q()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)n9Q()).set_ForeColor(Color.Black);
		((Control)n9Q()).set_Location(new Point(81, 44));
		((Control)n9Q()).set_Name("SearchTextBox");
		((Control)n9Q()).set_Size(new Size(912, 30));
		((Control)n9Q()).set_TabIndex(0);
		n9Q().set_Text("Enter Book Details");
		((ScrollableControl)t7J()).set_AutoScroll(true);
		((Control)t7J()).set_BackColor(Color.Black);
		((Control)t7J()).set_Location(new Point(26, 297));
		((Control)t7J()).set_Name("Panel2");
		((Control)t7J()).set_Size(new Size(1209, 372));
		((Control)t7J()).set_TabIndex(4);
		Tr5().set_AutoSize(true);
		((Control)Tr5()).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Tr5()).set_Location(new Point(146, 42));
		((Control)Tr5()).set_Name("Label2");
		((Control)Tr5()).set_Size(new Size(712, 38));
		((Control)Tr5()).set_TabIndex(5);
		Tr5().set_Text("LIBRARY MANAGEMENT SYSTEM - IIT GUWAHATI");
		((ButtonBase)Qf0()).set_BackColor(Color.White);
		((Control)Qf0()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Qf0()).set_FlatStyle((FlatStyle)1);
		((Control)Qf0()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)Qf0()).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((ButtonBase)Qf0()).set_ImageAlign((ContentAlignment)16);
		((Control)Qf0()).set_Location(new Point(1136, 106));
		((Control)Qf0()).set_Name("Button2");
		((Control)Qf0()).set_Size(new Size(90, 35));
		((Control)Qf0()).set_TabIndex(7);
		((ButtonBase)Qf0()).set_Text("Exit");
		((ButtonBase)Qf0()).set_TextAlign((ContentAlignment)64);
		((ButtonBase)Qf0()).set_UseVisualStyleBackColor(false);
		Nb2().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)Nb2()).set_Location(new Point(29, 12));
		((Control)Nb2()).set_Name("PictureBox1");
		((Control)Nb2()).set_Size(new Size(100, 100));
		Nb2().set_SizeMode((PictureBoxSizeMode)1);
		Nb2().set_TabIndex(6);
		Nb2().set_TabStop(false);
		((ButtonBase)m6E()).set_BackColor(Color.White);
		((Control)m6E()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)m6E()).set_FlatStyle((FlatStyle)1);
		((Control)m6E()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)m6E()).set_Image((Image)componentResourceManager.GetObject("LoginButton.Image"));
		((ButtonBase)m6E()).set_ImageAlign((ContentAlignment)16);
		((Control)m6E()).set_Location(new Point(1040, 106));
		((Control)m6E()).set_Name("LoginButton");
		((Control)m6E()).set_Size(new Size(90, 35));
		((Control)m6E()).set_TabIndex(2);
		((ButtonBase)m6E()).set_Text("Login");
		((ButtonBase)m6E()).set_TextAlign((ContentAlignment)64);
		((ButtonBase)m6E()).set_UseVisualStyleBackColor(false);
		((ButtonBase)z4F()).set_BackColor(Color.White);
		((Control)z4F()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)z4F()).set_FlatStyle((FlatStyle)1);
		((Control)z4F()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)z4F()).set_Image((Image)componentResourceManager.GetObject("BrowseButton.Image"));
		((ButtonBase)z4F()).set_ImageAlign((ContentAlignment)16);
		((Control)z4F()).set_Location(new Point(884, 106));
		((Control)z4F()).set_Name("BrowseButton");
		((Control)z4F()).set_Size(new Size(140, 35));
		((Control)z4F()).set_TabIndex(1);
		((ButtonBase)z4F()).set_Text("Browse All");
		((ButtonBase)z4F()).set_TextAlign((ContentAlignment)64);
		((ButtonBase)z4F()).set_UseVisualStyleBackColor(false);
		Si8().set_Enabled(true);
		Si8().set_Interval(3600000);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoScroll(true);
		((Form)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1280, 720));
		((Control)this).get_Controls().Add((Control)(object)Qf0());
		((Control)this).get_Controls().Add((Control)(object)Nb2());
		((Control)this).get_Controls().Add((Control)(object)Tr5());
		((Control)this).get_Controls().Add((Control)(object)o4J());
		((Control)this).get_Controls().Add((Control)(object)m6E());
		((Control)this).get_Controls().Add((Control)(object)z4F());
		((Control)this).get_Controls().Add((Control)(object)t7J());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximumSize(new Size(1280, 720));
		((Form)this).set_MinimumSize(new Size(1280, 720));
		((Control)this).set_Name("MainPage");
		((Control)o4J()).ResumeLayout(false);
		((Control)o4J()).PerformLayout();
		((ISupportInitialize)Nb2()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button z4F()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nz1(Button Ht9)
	{
		EventHandler eventHandler = p2T;
		Button val = i;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (i = Ht9);
		val = i;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button m6E()
	{
		return _LoginButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4S(Button Qf2)
	{
		EventHandler eventHandler = Lw5;
		Button loginButton = _LoginButton;
		if (loginButton != null)
		{
			((Control)loginButton).remove_Click(eventHandler);
		}
		_LoginButton = Qf2;
		loginButton = _LoginButton;
		if (loginButton != null)
		{
			((Control)loginButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel o4J()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6P(Panel Xn7)
	{
		_Panel1 = Xn7;
	}

	[SpecialName]
	internal virtual RadioButton Wi3()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk4(RadioButton Ef4)
	{
		RadioButton val = (l = Ef4);
	}

	[SpecialName]
	internal virtual RadioButton p3D()
	{
		return _PublisherRadioButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nx6(RadioButton Tp7)
	{
		_PublisherRadioButton = Tp7;
	}

	[SpecialName]
	internal virtual RadioButton Jp2()
	{
		return _AuthorRadioButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3Y(RadioButton o3P)
	{
		_AuthorRadioButton = o3P;
	}

	[SpecialName]
	internal virtual RadioButton p9W()
	{
		return _FieldRadioButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5R(RadioButton t5N)
	{
		_FieldRadioButton1 = t5N;
	}

	[SpecialName]
	internal virtual Panel t7J()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4E(Panel Dj8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(a7H);
		Panel val2 = e;
		if (val2 != null)
		{
			((Control)val2).remove_Paint(val);
		}
		Panel val3 = (e = Dj8);
		val2 = e;
		if (val2 != null)
		{
			((Control)val2).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual RadioButton n9G()
	{
		return _ISBNRadioButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp2(RadioButton m0B)
	{
		_ISBNRadioButton = m0B;
	}

	[SpecialName]
	internal virtual Label Tr5()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wg0(Label y9Z)
	{
		_Label2 = y9Z;
	}

	[SpecialName]
	internal virtual PictureBox Nb2()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0T(PictureBox k6P)
	{
		_PictureBox1 = k6P;
	}

	[SpecialName]
	internal virtual Button Qf0()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp1(Button Lq6)
	{
		EventHandler eventHandler = Ar9;
		Button w = W;
		if (w != null)
		{
			((Control)w).remove_Click(eventHandler);
		}
		Button val = (W = Lq6);
		w = W;
		if (w != null)
		{
			((Control)w).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button a1Q()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3E(Button Lp6)
	{
		EventHandler eventHandler = a3R;
		Button d = D;
		if (d != null)
		{
			((Control)d).remove_Click(eventHandler);
		}
		Button val = (D = Lp6);
		d = D;
		if (d != null)
		{
			((Control)d).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox n9Q()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro3(TextBox z3Z)
	{
		EventHandler eventHandler = Cm8;
		EventHandler eventHandler2 = Gb6;
		TextBox val = r;
		if (val != null)
		{
			((Control)val).remove_Enter(eventHandler);
			((Control)val).remove_Leave(eventHandler2);
		}
		TextBox val2 = (r = z3Z);
		val = r;
		if (val != null)
		{
			((Control)val).add_Enter(eventHandler);
			((Control)val).add_Leave(eventHandler2);
		}
	}

	[SpecialName]
	internal virtual Timer Si8()
	{
		return _Timer2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9Y(Timer x2D)
	{
		EventHandler eventHandler = Mq2;
		Timer timer = _Timer2;
		if (timer != null)
		{
			timer.remove_Tick(eventHandler);
		}
		_Timer2 = x2D;
		timer = _Timer2;
		if (timer != null)
		{
			timer.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	private void Nq8(object sender, EventArgs e)
	{
		q4L();
	}
}
