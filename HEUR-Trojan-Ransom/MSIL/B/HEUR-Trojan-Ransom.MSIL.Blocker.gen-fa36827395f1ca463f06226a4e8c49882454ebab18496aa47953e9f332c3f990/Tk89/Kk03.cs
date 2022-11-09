using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using Zs72;
using f4S;
using t0B;

namespace Tk89;

[DesignerGenerated]
public class Kk03 : Form
{
	private Panel _Panel1;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox5;

	private int _ct;

	internal IContainer h;

	internal Label Y;

	internal string j;

	internal int c;

	internal string g;

	public string passISBN
	{
		get
		{
			return j;
		}
		set
		{
			string text = (j = value);
		}
	}

	public int prev
	{
		get
		{
			return c;
		}
		set
		{
			int num = (c = value);
		}
	}

	public int ct
	{
		get
		{
			return _ct;
		}
		set
		{
			_ct = value;
		}
	}

	public Kk03()
	{
		((Form)this).add_Load((EventHandler)w5NG);
		string text = (g = m2A.Forms.r0M().UserName);
		ct = 0;
		s5Q7();
	}

	protected override void c8Z6(bool Zy28)
	{
		try
		{
			if (Zy28 && h != null)
			{
				h.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zy28);
		}
	}

	private void s5Q7()
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
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		Jn36(new Panel());
		z4E1(new Label());
		Ki2x(new PictureBox());
		x8AR(new PictureBox());
		Ms51(new PictureBox());
		z5GQ(new PictureBox());
		Xy09(new PictureBox());
		((ISupportInitialize)w2M6()).BeginInit();
		((ISupportInitialize)Lw4r()).BeginInit();
		((ISupportInitialize)Dg39()).BeginInit();
		((ISupportInitialize)Er61()).BeginInit();
		((ISupportInitialize)Aw4q()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)a3QX()).set_BackColor(Color.Black);
		((Control)a3QX()).set_Location(new Point(35, 10));
		((Control)a3QX()).set_Name("Panel1");
		((Control)a3QX()).set_Size(new Size(646, 364));
		((Control)a3QX()).set_TabIndex(0);
		t7H8().set_AutoSize(true);
		((Control)t7H8()).set_Font(new Font("Comic Sans MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t7H8()).set_Location(new Point(248, 396));
		((Control)t7H8()).set_Name("Label1");
		((Control)t7H8()).set_Size(new Size(161, 30));
		((Control)t7H8()).set_TabIndex(1);
		t7H8().set_Text("Rate this book");
		((Control)w2M6()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)w2M6()).set_Cursor(Cursors.get_Hand());
		((Control)w2M6()).set_Location(new Point(197, 435));
		((Control)w2M6()).set_Name("PictureBox1");
		((Control)w2M6()).set_Size(new Size(50, 50));
		w2M6().set_SizeMode((PictureBoxSizeMode)1);
		w2M6().set_TabIndex(2);
		w2M6().set_TabStop(false);
		((Control)Lw4r()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Lw4r()).set_Cursor(Cursors.get_Hand());
		((Control)Lw4r()).set_Location(new Point(253, 435));
		((Control)Lw4r()).set_Name("PictureBox2");
		((Control)Lw4r()).set_Size(new Size(50, 50));
		Lw4r().set_SizeMode((PictureBoxSizeMode)1);
		Lw4r().set_TabIndex(3);
		Lw4r().set_TabStop(false);
		((Control)Dg39()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Dg39()).set_Cursor(Cursors.get_Hand());
		((Control)Dg39()).set_Location(new Point(309, 435));
		((Control)Dg39()).set_Name("PictureBox3");
		((Control)Dg39()).set_Size(new Size(50, 50));
		Dg39().set_SizeMode((PictureBoxSizeMode)1);
		Dg39().set_TabIndex(4);
		Dg39().set_TabStop(false);
		((Control)Er61()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Er61()).set_Cursor(Cursors.get_Hand());
		((Control)Er61()).set_Location(new Point(365, 435));
		((Control)Er61()).set_Name("PictureBox4");
		((Control)Er61()).set_Size(new Size(50, 50));
		Er61().set_SizeMode((PictureBoxSizeMode)1);
		Er61().set_TabIndex(5);
		Er61().set_TabStop(false);
		((Control)Aw4q()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Aw4q()).set_Cursor(Cursors.get_Hand());
		((Control)Aw4q()).set_Location(new Point(421, 435));
		((Control)Aw4q()).set_Name("PictureBox5");
		((Control)Aw4q()).set_Size(new Size(50, 50));
		Aw4q().set_SizeMode((PictureBoxSizeMode)1);
		Aw4q().set_TabIndex(6);
		Aw4q().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(724, 507));
		((Control)this).get_Controls().Add((Control)(object)Aw4q());
		((Control)this).get_Controls().Add((Control)(object)Er61());
		((Control)this).get_Controls().Add((Control)(object)Dg39());
		((Control)this).get_Controls().Add((Control)(object)Lw4r());
		((Control)this).get_Controls().Add((Control)(object)w2M6());
		((Control)this).get_Controls().Add((Control)(object)t7H8());
		((Control)this).get_Controls().Add((Control)(object)a3QX());
		((Form)this).set_MaximumSize(new Size(740, 546));
		((Form)this).set_MinimumSize(new Size(740, 546));
		((Control)this).set_Name("RatingBookDetails");
		((Form)this).set_Text("RatingBookDetails");
		((ISupportInitialize)w2M6()).EndInit();
		((ISupportInitialize)Lw4r()).EndInit();
		((ISupportInitialize)Dg39()).EndInit();
		((ISupportInitialize)Er61()).EndInit();
		((ISupportInitialize)Aw4q()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel a3QX()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn36(Panel Ab2t)
	{
		_Panel1 = Ab2t;
	}

	[SpecialName]
	internal virtual Label t7H8()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4E1(Label y0YK)
	{
		Label val = (Y = y0YK);
	}

	[SpecialName]
	internal virtual PictureBox w2M6()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki2x(PictureBox j2S9)
	{
		EventHandler eventHandler = f1P8;
		PictureBox pictureBox = _PictureBox1;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox1 = j2S9;
		pictureBox = _PictureBox1;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Lw4r()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8AR(PictureBox x3MJ)
	{
		EventHandler eventHandler = Fn25;
		PictureBox pictureBox = _PictureBox2;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox2 = x3MJ;
		pictureBox = _PictureBox2;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Dg39()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms51(PictureBox Kt76)
	{
		EventHandler eventHandler = Ne0f;
		PictureBox pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox3 = Kt76;
		pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Er61()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5GQ(PictureBox d0M6)
	{
		EventHandler eventHandler = Xe5z;
		PictureBox pictureBox = _PictureBox4;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox4 = d0M6;
		pictureBox = _PictureBox4;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Aw4q()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy09(PictureBox Zg8s)
	{
		EventHandler eventHandler = Fc37;
		PictureBox pictureBox = _PictureBox5;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox5 = Zg8s;
		pictureBox = _PictureBox5;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	public void s4BL(OleDbDataReader x9F6)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		((Control)a3QX()).get_Controls().Clear();
		int num = 0;
		int num2 = ((Control)a3QX()).get_Location().X;
		int num3 = ((Control)a3QX()).get_Location().Y;
		checked
		{
			while (x9F6.Read())
			{
				string text = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), x9F6.get_Item("BookImage")));
				Label val = new Label();
				Label val2 = new Label();
				Label val3 = new Label();
				Label val4 = new Label();
				Label val5 = new Label();
				Label val6 = new Label();
				Label val7 = new Label();
				Label val8 = new Label();
				PictureBox val9 = new PictureBox();
				((Control)val).set_Size(new Size(250, 40));
				((Control)val8).set_Size(new Size(200, 40));
				((Control)val5).set_Size(new Size(200, 40));
				((Control)val4).set_Size(new Size(300, 40));
				((Control)val2).set_Size(new Size(250, 40));
				((Control)val3).set_Size(new Size(250, 40));
				((Control)val6).set_Size(new Size(200, 40));
				((Control)val7).set_Size(new Size(250, 40));
				((Control)val9).set_Size(new Size(200, 250));
				val9.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val9).set_Tag((object)text);
				val9.set_ImageLocation(text);
				val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Title: ", x9F6.get_Item("Title"))));
				val6.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Published on: ", x9F6.get_Item("PublishYear"))));
				val8.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Remaining: ", x9F6.get_Item("Remaining"))));
				val2.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Author: ", x9F6.get_Item("Author"))));
				val3.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Publisher: ", x9F6.get_Item("Publisher"))));
				val7.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Location: ", x9F6.get_Item("Location"))));
				val5.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Total number: ", x9F6.get_Item("Total"))));
				val4.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"ISBN: ", x9F6.get_Item("ISBN"))));
				val4.set_AutoEllipsis(true);
				val.set_AutoEllipsis(true);
				val6.set_AutoEllipsis(true);
				val8.set_AutoEllipsis(true);
				val2.set_AutoEllipsis(true);
				val3.set_AutoEllipsis(true);
				val7.set_AutoEllipsis(true);
				val5.set_AutoEllipsis(true);
				val4.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"ISBN: ", x9F6.get_Item("ISBN"))));
				val7.set_AutoEllipsis(true);
				((Control)val9).set_Location(new Point(num2, num3 + 10));
				((Control)val).set_Location(new Point(num2 + 250, num3));
				((Control)val2).set_Location(new Point(num2 + 250, num3 + 40));
				((Control)val3).set_Location(new Point(num2 + 250, num3 + 80));
				((Control)val6).set_Location(new Point(num2 + 250, num3 + 120));
				((Control)val4).set_Location(new Point(num2 + 250, num3 + 160));
				((Control)val5).set_Location(new Point(num2 + 250, num3 + 200));
				((Control)val8).set_Location(new Point(num2 + 250, num3 + 240));
				((Control)val7).set_Location(new Point(num2 + 250, num3 + 280));
				((Control)val).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val2).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val3).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val6).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val4).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val5).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val8).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val7).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val).set_ForeColor(Color.White);
				((Control)val2).set_ForeColor(Color.White);
				((Control)val3).set_ForeColor(Color.White);
				((Control)val6).set_ForeColor(Color.White);
				((Control)val4).set_ForeColor(Color.White);
				((Control)val5).set_ForeColor(Color.White);
				((Control)val8).set_ForeColor(Color.White);
				((Control)val7).set_ForeColor(Color.White);
				num2 += 430;
				num++;
				if (num2 > ((Control)a3QX()).get_Width())
				{
					num2 = ((Control)a3QX()).get_Location().X;
					num = 0;
					num3 += 250;
				}
				((Control)a3QX()).get_Controls().Add((Control)(object)val);
				((Control)a3QX()).get_Controls().Add((Control)(object)val6);
				((Control)a3QX()).get_Controls().Add((Control)(object)val9);
				((Control)a3QX()).get_Controls().Add((Control)(object)val2);
				((Control)a3QX()).get_Controls().Add((Control)(object)val3);
				((Control)a3QX()).get_Controls().Add((Control)(object)val7);
				((Control)a3QX()).get_Controls().Add((Control)(object)val5);
				((Control)a3QX()).get_Controls().Add((Control)(object)val8);
				((Control)a3QX()).get_Controls().Add((Control)(object)val4);
			}
		}
	}

	private void w5NG(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader x9F = val2.ExecuteReader();
		s4BL(x9F);
		val.Close();
		val.Open();
		string text2 = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		val2 = new OleDbCommand(text2, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Conversions.ToInteger(val3.get_Item("Starcount"));
					ct++;
				}
			}
			val.Close();
			if (ct == 0)
			{
				w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
			}
			if (ct == 1)
			{
				if (prev == 1)
				{
					w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				if (prev == 2)
				{
					w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				if (prev == 3)
				{
					w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				if (prev == 4)
				{
					w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				if (prev == 5)
				{
					w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
				}
			}
		}
	}

	internal static string[] Fr79()
	{
		Ra7k();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		w0T.mDic.Add("bee", value);
		return Xe0j.Sx2o();
	}

	private void f1P8(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		ct = 0;
		string text = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val3.get_Item("Starcount")));
					ct++;
				}
			}
			val.Close();
			int num = 1;
			int num2 = 1;
			if (ct == 0)
			{
				val.Open();
				string text2 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text2, val);
				OleDbDataReader val4 = val2.ExecuteReader();
				while (val4.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("Raters")));
					num++;
					num2++;
					string text3 = "1";
					string text4 = "insert into RatingList (ISBN, UserName, Starcount) values('" + passISBN + "', '" + g + "', ' " + text3 + " ')";
					OleDbCommand val5 = new OleDbCommand(text4, val);
					OleDbDataReader val6 = val5.ExecuteReader();
					string text5 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val5 = new OleDbCommand(text5, val);
					val6 = val5.ExecuteReader();
					MessageBox.Show("Your rating has been submitted succesfully", "Success");
					val6.Close();
				}
				val.Close();
			}
			else
			{
				val.Open();
				string text6 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text6, val);
				OleDbDataReader val7 = val2.ExecuteReader();
				while (val7.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("Raters")));
					num++;
					num -= prev;
					string text7 = "1";
					string text8 = "UPDATE RatingList SET Starcount='" + text7 + "' WHERE ISBN = '" + passISBN + "' AND Username = '" + g + "'";
					OleDbCommand val8 = new OleDbCommand(text8, val);
					OleDbDataReader val9 = val8.ExecuteReader();
					string text9 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val8 = new OleDbCommand(text9, val);
					val9 = val8.ExecuteReader();
					MessageBox.Show("Your rating has been updated succesfully", "Success");
					val9.Close();
				}
			}
		}
	}

	internal static void Ra7k()
	{
		string[] fa = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = x2A.Hz0(fa, 0, 3);
		string value2 = x2A.Hz0(fa, 4, 7);
		w0T.mDic.Add(w0T.tName, value);
		w0T.mDic.Add(w0T.mName, value2);
	}

	private void Fn25(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		ct = 0;
		string text = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val3.get_Item("Starcount")));
					ct++;
				}
			}
			val.Close();
			int num = 1;
			int num2 = 1;
			if (ct == 0)
			{
				val.Open();
				string text2 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text2, val);
				OleDbDataReader val4 = val2.ExecuteReader();
				while (val4.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("Raters")));
					num += 2;
					num2++;
					string text3 = "2";
					string text4 = "insert into RatingList (ISBN, UserName, Starcount) values('" + passISBN + "', '" + g + "', ' " + text3 + " ')";
					OleDbCommand val5 = new OleDbCommand(text4, val);
					OleDbDataReader val6 = val5.ExecuteReader();
					string text5 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val5 = new OleDbCommand(text5, val);
					val6 = val5.ExecuteReader();
					MessageBox.Show("Your rating has been submitted succesfully", "Success");
					val6.Close();
				}
				val.Close();
			}
			else
			{
				val.Open();
				string text6 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text6, val);
				OleDbDataReader val7 = val2.ExecuteReader();
				while (val7.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("Raters")));
					num += 2;
					num -= prev;
					string text7 = "2";
					string text8 = "UPDATE RatingList SET Starcount='" + text7 + "' WHERE ISBN = '" + passISBN + "' AND Username = '" + g + "'";
					OleDbCommand val8 = new OleDbCommand(text8, val);
					OleDbDataReader val9 = val8.ExecuteReader();
					string text9 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val8 = new OleDbCommand(text9, val);
					val9 = val8.ExecuteReader();
					MessageBox.Show("Your rating has been updated succesfully", "Success");
					val9.Close();
				}
			}
		}
	}

	private void Ne0f(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		ct = 0;
		string text = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val3.get_Item("Starcount")));
					ct++;
				}
			}
			val.Close();
			int num = 1;
			int num2 = 1;
			if (ct == 0)
			{
				val.Open();
				string text2 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text2, val);
				OleDbDataReader val4 = val2.ExecuteReader();
				while (val4.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("Raters")));
					num += 3;
					num2++;
					string text3 = "3";
					string text4 = "insert into RatingList (ISBN, UserName, Starcount) values('" + passISBN + "', '" + g + "', ' " + text3 + " ')";
					OleDbCommand val5 = new OleDbCommand(text4, val);
					OleDbDataReader val6 = val5.ExecuteReader();
					string text5 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val5 = new OleDbCommand(text5, val);
					val6 = val5.ExecuteReader();
					MessageBox.Show("Your rating has been submitted succesfully", "Success");
					val6.Close();
				}
				val.Close();
			}
			else
			{
				val.Open();
				string text6 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text6, val);
				OleDbDataReader val7 = val2.ExecuteReader();
				while (val7.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("Raters")));
					num += 3;
					num -= prev;
					string text7 = "3";
					string text8 = "UPDATE RatingList SET Starcount='" + text7 + "' WHERE ISBN = '" + passISBN + "' AND Username = '" + g + "'";
					OleDbCommand val8 = new OleDbCommand(text8, val);
					OleDbDataReader val9 = val8.ExecuteReader();
					string text9 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val8 = new OleDbCommand(text9, val);
					val9 = val8.ExecuteReader();
					MessageBox.Show("Your rating has been updated succesfully", "Success");
					val9.Close();
				}
			}
		}
	}

	private void Xe5z(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		ct = 0;
		string text = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val3.get_Item("Starcount")));
					ct++;
				}
			}
			val.Close();
			int num = 1;
			int num2 = 1;
			if (ct == 0)
			{
				val.Open();
				string text2 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text2, val);
				OleDbDataReader val4 = val2.ExecuteReader();
				while (val4.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("Raters")));
					num += 4;
					num2++;
					string text3 = "4";
					string text4 = "insert into RatingList (ISBN, UserName, Starcount) values('" + passISBN + "', '" + g + "', ' " + text3 + " ')";
					OleDbCommand val5 = new OleDbCommand(text4, val);
					OleDbDataReader val6 = val5.ExecuteReader();
					string text5 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val5 = new OleDbCommand(text5, val);
					val6 = val5.ExecuteReader();
					MessageBox.Show("Your rating has been submitted succesfully", "Success");
					val6.Close();
				}
				val.Close();
			}
			else
			{
				val.Open();
				string text6 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text6, val);
				OleDbDataReader val7 = val2.ExecuteReader();
				while (val7.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("Raters")));
					num += 4;
					num -= prev;
					string text7 = "4";
					string text8 = "UPDATE RatingList SET Starcount='" + text7 + "' WHERE ISBN = '" + passISBN + "' AND Username = '" + g + "'";
					OleDbCommand val8 = new OleDbCommand(text8, val);
					OleDbDataReader val9 = val8.ExecuteReader();
					string text9 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val8 = new OleDbCommand(text9, val);
					val9 = val8.ExecuteReader();
					MessageBox.Show("Your rating has been updated succesfully", "Success");
					val9.Close();
				}
			}
		}
	}

	private void Fc37(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		w2M6().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Lw4r().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Dg39().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Er61().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		Aw4q().set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		ct = 0;
		string text = "SELECT * FROM RatingList WHERE ISBN = '" + passISBN + "' ";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("UserName"), (object)g, false))
				{
					prev = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val3.get_Item("Starcount")));
					ct++;
				}
			}
			val.Close();
			int num = 1;
			int num2 = 1;
			if (ct == 0)
			{
				val.Open();
				string text2 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text2, val);
				OleDbDataReader val4 = val2.ExecuteReader();
				while (val4.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val4.get_Item("Raters")));
					num += 5;
					num2++;
					string text3 = "5";
					string text4 = "insert into RatingList (ISBN, UserName, Starcount) values('" + passISBN + "', '" + g + "', ' " + text3 + " ')";
					OleDbCommand val5 = new OleDbCommand(text4, val);
					OleDbDataReader val6 = val5.ExecuteReader();
					string text5 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val5 = new OleDbCommand(text5, val);
					val6 = val5.ExecuteReader();
					MessageBox.Show("Your rating has been submitted succesfully", "Success");
					val6.Close();
				}
				val.Close();
			}
			else
			{
				val.Open();
				string text6 = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
				val2 = new OleDbCommand(text6, val);
				OleDbDataReader val7 = val2.ExecuteReader();
				while (val7.Read())
				{
					num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("StarsNumber")));
					num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(val7.get_Item("Raters")));
					num += 5;
					num -= prev;
					string text7 = "5";
					string text8 = "UPDATE RatingList SET Starcount='" + text7 + "' WHERE ISBN = '" + passISBN + "' AND Username = '" + g + "'";
					OleDbCommand val8 = new OleDbCommand(text8, val);
					OleDbDataReader val9 = val8.ExecuteReader();
					string text9 = "UPDATE Books SET StarsNumber='" + num + "', Raters = '" + num2 + "' WHERE ISBN = '" + passISBN + "'";
					val8 = new OleDbCommand(text9, val);
					val9 = val8.ExecuteReader();
					MessageBox.Show("Your rating has been updated succesfully", "Success");
					val9.Close();
				}
			}
		}
	}
}
