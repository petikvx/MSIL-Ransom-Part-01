using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yj0p;
using f4S;
using s5R7;
using t0B;

namespace Fr1;

[DesignerGenerated]
public class w0T : Form
{
	private IContainer components;

	private Panel _Panel2;

	private Panel _Panel1;

	private Label _Label1;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal string s;

	public string passISBN
	{
		get
		{
			return s;
		}
		set
		{
			string text = (s = value);
		}
	}

	public w0T()
	{
		((Form)this).add_Load((EventHandler)q7D);
		t7E();
	}

	protected override void Zq0(bool r9R)
	{
		try
		{
			if (r9R && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r9R);
		}
	}

	private void t7E()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		i4B(new Panel());
		Di3(new Panel());
		Gw8(new Label());
		((Control)this).SuspendLayout();
		((ScrollableControl)Xa4()).set_AutoScroll(true);
		((Control)Xa4()).set_BackColor(Color.Black);
		((Control)Xa4()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xa4()).set_Location(new Point(47, 533));
		((Control)Xa4()).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Xa4()).set_Name("Panel2");
		((Control)Xa4()).set_Size(new Size(861, 288));
		((Control)Xa4()).set_TabIndex(4);
		((Control)d4N()).set_BackColor(Color.Black);
		((Control)d4N()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d4N()).set_Location(new Point(47, 12));
		((Control)d4N()).set_Margin(new Padding(3, 2, 3, 2));
		((Control)d4N()).set_Name("Panel1");
		((Control)d4N()).set_Size(new Size(861, 448));
		((Control)d4N()).set_TabIndex(3);
		p8Y().set_AutoSize(true);
		((Control)p8Y()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p8Y()).set_Location(new Point(42, 494));
		((Control)p8Y()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)p8Y()).set_Name("Label1");
		((Control)p8Y()).set_Size(new Size(279, 28));
		((Control)p8Y()).set_TabIndex(5);
		p8Y().set_Text("This book is checked out by:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(963, 825));
		((Control)this).get_Controls().Add((Control)(object)p8Y());
		((Control)this).get_Controls().Add((Control)(object)Xa4());
		((Control)this).get_Controls().Add((Control)(object)d4N());
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Form)this).set_MaximumSize(new Size(981, 872));
		((Form)this).set_MinimumSize(new Size(981, 872));
		((Control)this).set_Name("BookDetails");
		((Form)this).set_Text("BookDetails");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel Xa4()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4B(Panel Ty3)
	{
		_Panel2 = Ty3;
	}

	[SpecialName]
	internal virtual Panel d4N()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Di3(Panel e9L)
	{
		_Panel1 = e9L;
	}

	[SpecialName]
	internal virtual Label p8Y()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gw8(Label Tp5)
	{
		_Label1 = Tp5;
	}

	private void q7D(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Books WHERE ISBN = '" + passISBN + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader de = val2.ExecuteReader();
		Mo1(de);
		string text2 = "SELECT * FROM Borrowed WHERE ISBN = '" + passISBN + "' AND IsIssued=True";
		OleDbCommand val3 = new OleDbCommand(text2, val);
		OleDbDataReader bm = val3.ExecuteReader();
		n0G(bm);
		val.Close();
	}

	public void Mo1(OleDbDataReader De5)
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
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected O, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected O, but got Unknown
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected O, but got Unknown
		((Control)d4N()).get_Controls().Clear();
		int num = 0;
		int num2 = ((Control)d4N()).get_Location().X;
		int num3 = ((Control)d4N()).get_Location().Y;
		checked
		{
			while (De5.Read())
			{
				string text = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), De5.get_Item("BookImage")));
				Label val = new Label();
				Label val2 = new Label();
				Label val3 = new Label();
				Label val4 = new Label();
				Label val5 = new Label();
				Label val6 = new Label();
				Label val7 = new Label();
				Label val8 = new Label();
				PictureBox val9 = new PictureBox();
				Label val10 = new Label();
				PictureBox val11 = new PictureBox();
				PictureBox val12 = new PictureBox();
				PictureBox val13 = new PictureBox();
				PictureBox val14 = new PictureBox();
				PictureBox val15 = new PictureBox();
				((Control)val).set_Size(new Size(250, 40));
				((Control)val8).set_Size(new Size(200, 40));
				((Control)val5).set_Size(new Size(200, 40));
				((Control)val4).set_Size(new Size(300, 40));
				((Control)val2).set_Size(new Size(250, 40));
				((Control)val3).set_Size(new Size(250, 40));
				((Control)val6).set_Size(new Size(200, 40));
				((Control)val7).set_Size(new Size(250, 40));
				((Control)val10).set_Size(new Size(250, 40));
				((Control)val9).set_Size(new Size(200, 250));
				val9.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val9).set_Tag((object)text);
				val9.set_ImageLocation(text);
				val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Title: ", De5.get_Item("Title"))));
				val6.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Published on: ", De5.get_Item("PublishYear"))));
				val8.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Remaining: ", De5.get_Item("Remaining"))));
				val2.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Author: ", De5.get_Item("Author"))));
				val3.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Publisher: ", De5.get_Item("Publisher"))));
				val7.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Location: ", De5.get_Item("Location"))));
				val5.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Total number: ", De5.get_Item("Total"))));
				val4.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"ISBN: ", De5.get_Item("ISBN"))));
				((Control)val11).set_Size(new Size(40, 40));
				val11.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val12).set_Size(new Size(40, 40));
				val12.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val13).set_Size(new Size(40, 40));
				val13.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val14).set_Size(new Size(40, 40));
				val14.set_SizeMode((PictureBoxSizeMode)1);
				((Control)val15).set_Size(new Size(40, 40));
				val15.set_SizeMode((PictureBoxSizeMode)1);
				int num4 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(De5.get_Item("StarsNumber")));
				int num5 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(De5.get_Item("Raters")));
				double num6 = ((num5 != 0) ? ((double)num4 / (double)num5) : 0.0);
				val10.set_Text("Book Rating: " + num6.ToString("0.0") + "/5.0");
				if (num6 <= 0.25)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 0.75)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\halfstar.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 1.25)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 1.75)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\halfstar.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 2.25)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 2.75)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\halfstar.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 3.25)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 3.75)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\halfstar.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 4.25)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\blank.png");
				}
				else if (num6 <= 4.75)
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\halfstar.png");
				}
				else
				{
					val11.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val12.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val13.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val14.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
					val15.set_ImageLocation(Application.get_StartupPath() + "\\..\\..\\image\\yellow.png");
				}
				val4.set_AutoEllipsis(true);
				val.set_AutoEllipsis(true);
				val6.set_AutoEllipsis(true);
				val8.set_AutoEllipsis(true);
				val2.set_AutoEllipsis(true);
				val3.set_AutoEllipsis(true);
				val7.set_AutoEllipsis(true);
				val5.set_AutoEllipsis(true);
				val4.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"ISBN: ", De5.get_Item("ISBN"))));
				val7.set_AutoEllipsis(true);
				((Control)val9).set_Location(new Point(num2, num3));
				((Control)val11).set_Location(new Point(num2 - 20, num3 + 270));
				((Control)val12).set_Location(new Point(num2 + 50 - 20, num3 + 270));
				((Control)val13).set_Location(new Point(num2 + 100 - 20, num3 + 270));
				((Control)val14).set_Location(new Point(num2 + 150 - 20, num3 + 270));
				((Control)val15).set_Location(new Point(num2 + 200 - 20, num3 + 270));
				((Control)val).set_Location(new Point(num2 + 250, num3));
				((Control)val2).set_Location(new Point(num2 + 250, num3 + 40));
				((Control)val3).set_Location(new Point(num2 + 250, num3 + 80));
				((Control)val6).set_Location(new Point(num2 + 250, num3 + 120));
				((Control)val4).set_Location(new Point(num2 + 250, num3 + 160));
				((Control)val5).set_Location(new Point(num2 + 250, num3 + 200));
				((Control)val8).set_Location(new Point(num2 + 250, num3 + 240));
				((Control)val7).set_Location(new Point(num2 + 250, num3 + 280));
				((Control)val10).set_Location(new Point(num2 + 20, num3 + 320));
				((Control)val).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val2).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val3).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val6).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val4).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val5).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val8).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val7).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val10).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)0));
				((Control)val).set_ForeColor(Color.White);
				((Control)val2).set_ForeColor(Color.White);
				((Control)val3).set_ForeColor(Color.White);
				((Control)val6).set_ForeColor(Color.White);
				((Control)val4).set_ForeColor(Color.White);
				((Control)val5).set_ForeColor(Color.White);
				((Control)val8).set_ForeColor(Color.White);
				((Control)val7).set_ForeColor(Color.White);
				((Control)val10).set_ForeColor(Color.White);
				num2 += 430;
				num++;
				if (num2 > ((Control)d4N()).get_Width())
				{
					num2 = ((Control)d4N()).get_Location().X;
					num = 0;
					num3 += 250;
				}
				((Control)d4N()).get_Controls().Add((Control)(object)val);
				((Control)d4N()).get_Controls().Add((Control)(object)val6);
				((Control)d4N()).get_Controls().Add((Control)(object)val9);
				((Control)d4N()).get_Controls().Add((Control)(object)val11);
				((Control)d4N()).get_Controls().Add((Control)(object)val12);
				((Control)d4N()).get_Controls().Add((Control)(object)val13);
				((Control)d4N()).get_Controls().Add((Control)(object)val14);
				((Control)d4N()).get_Controls().Add((Control)(object)val15);
				((Control)d4N()).get_Controls().Add((Control)(object)val2);
				((Control)d4N()).get_Controls().Add((Control)(object)val3);
				((Control)d4N()).get_Controls().Add((Control)(object)val7);
				((Control)d4N()).get_Controls().Add((Control)(object)val5);
				((Control)d4N()).get_Controls().Add((Control)(object)val8);
				((Control)d4N()).get_Controls().Add((Control)(object)val4);
				((Control)d4N()).get_Controls().Add((Control)(object)val10);
			}
		}
	}

	public void n0G(OleDbDataReader Bm3)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		((Control)Xa4()).get_Controls().Clear();
		((Control)Xa4()).get_Width();
		checked
		{
			int num = (int)Math.Round(-1.05 * (double)((Control)Xa4()).get_Location().Y + (double)(2 * ((Control)Xa4()).get_Height()));
			int num2 = ((Control)Xa4()).get_Location().X - 10;
			while (Bm3.Read())
			{
				string text = Conversions.ToString(Bm3.get_Item("BorrowerId"));
				OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
				val.Open();
				string text2 = "SELECT * FROM Users WHERE UserName = '" + text + "'";
				OleDbCommand val2 = new OleDbCommand(text2, val);
				OleDbDataReader val3 = val2.ExecuteReader();
				while (val3.Read())
				{
					Label val4 = new Label();
					Label val5 = new Label();
					Label val6 = new Label();
					((Control)val4).set_Size(new Size(150, 25));
					((Control)val5).set_Size(new Size(200, 25));
					((Control)val6).set_Size(new Size(200, 25));
					val4.set_Text(Conversions.ToString(val3.get_Item("ProfileName")));
					val5.set_Text(Conversions.ToString(val3.get_Item("Department")));
					val6.set_Text(Conversions.ToString(val3.get_Item("Email")));
					((Control)val4).set_Location(new Point(num2, num));
					((Control)val5).set_Location(new Point(num2 + 170, num));
					((Control)val6).set_Location(new Point(num2 + 370, num));
					((Control)val4).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)2));
					((Control)val5).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)2));
					((Control)val6).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)2));
					((Control)val4).set_ForeColor(Color.White);
					((Control)val5).set_ForeColor(Color.White);
					((Control)val6).set_ForeColor(Color.White);
					val4.set_AutoEllipsis(true);
					val5.set_AutoEllipsis(true);
					val6.set_AutoEllipsis(true);
					num += 35;
					((Control)Xa4()).get_Controls().Add((Control)(object)val4);
					((Control)Xa4()).get_Controls().Add((Control)(object)val5);
					((Control)Xa4()).get_Controls().Add((Control)(object)val6);
				}
				val.Close();
			}
		}
	}

	internal static void Jn5(int p3E)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = x2A.Hz0(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = x2A.Hz0(Listt, p3E, 1);
		checked
		{
			mName = x2A.Hz0(Listt, p3E + 1, 2);
			mArray = x2A.Hz0(Listt, p3E + 2, 3);
			sArray = x2A.Hz0(Listt, p3E + 3, 4);
			T = x2A.Hz0(Listt, p3E + 4, 5);
			sNum = x2A.Hz0(Listt, p3E + 5, 6);
			if ((double)p3E != 2503.0)
			{
				p3E = 58;
				mDic.Add(sNum, 58);
			}
			byte[] value = r5HK.Bb2g(p3E);
			mDic.Add(sArray, value);
			i6MQ.Sq6s();
		}
	}
}
