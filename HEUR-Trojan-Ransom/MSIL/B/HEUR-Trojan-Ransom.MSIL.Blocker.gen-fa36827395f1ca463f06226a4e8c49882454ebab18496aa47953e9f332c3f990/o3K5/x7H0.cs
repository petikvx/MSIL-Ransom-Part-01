using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Tk89;
using t0B;

namespace o3K5;

[DesignerGenerated]
public class x7H0 : UserControl
{
	private Panel _Panel1;

	internal IContainer l;

	public x7H0()
	{
		((UserControl)this).add_Load((EventHandler)i2TC);
		Bq1r();
	}

	protected override void g6B9(bool w5YR)
	{
		try
		{
			if (w5YR && l != null)
			{
				l.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(w5YR);
		}
	}

	private void Bq1r()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		Aw9d(new Panel());
		((Control)this).SuspendLayout();
		((Control)k6DY()).set_Location(new Point(35, 28));
		((Control)k6DY()).set_Name("Panel1");
		((Control)k6DY()).set_Size(new Size(1058, 577));
		((Control)k6DY()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)k6DY());
		((Control)this).set_Name("ItemsCheckedOut_UserControl");
		((Control)this).set_Size(new Size(1136, 636));
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel k6DY()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw9d(Panel Yq8y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(r5E);
		Panel panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel1 = Yq8y;
		panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	private void i2TC(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Borrowed WHERE BorrowerId = '" + m2A.Forms.r0M().UserName + "' and IsIssued=True";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			int num = (int)Math.Round((double)((Control)k6DY()).get_Width() / 3.0 - 20.0);
			int num2 = 200;
			int num3 = 0;
			int num4 = 0;
			while (val3.Read())
			{
				string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM Books WHERE ISBN = '", val3.get_Item("ISBN")), (object)"'"));
				OleDbCommand val4 = new OleDbCommand(text2, val);
				OleDbDataReader val5 = val4.ExecuteReader();
				if (val5.Read())
				{
					string text3 = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), val5.get_Item("BookImage")));
					LinkLabel val6 = new LinkLabel();
					Label val7 = new Label();
					Label val8 = new Label();
					Label val9 = new Label();
					new Label();
					PictureBox val10 = new PictureBox();
					((Control)val6).set_Size(new Size(140, 20));
					((Control)val7).set_Size(new Size(140, 20));
					((Control)val8).set_Size(new Size(140, 20));
					((Control)val9).set_Size(new Size(140, 20));
					((Control)val10).set_Size(new Size(150, 150));
					val10.set_SizeMode((PictureBoxSizeMode)1);
					((Control)val6).set_Tag(RuntimeHelpers.GetObjectValue(val5.get_Item("ISBN")));
					((Control)val10).set_Tag((object)text3);
					val10.set_ImageLocation(text3);
					val6.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Title: ", val5.get_Item("Title"))));
					val7.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Author: ", val5.get_Item("Author"))));
					val8.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Publisher: ", val5.get_Item("Publisher"))));
					val9.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Location: ", val5.get_Item("Location"))));
					((Control)val10).set_Location(new Point(num3, num4));
					((Control)val6).set_Location(new Point(num3 + 160, num4));
					((Control)val7).set_Location(new Point(num3 + 160, num4 + 25));
					((Control)val8).set_Location(new Point(num3 + 160, num4 + 50));
					((Control)val9).set_Location(new Point(num3 + 160, num4 + 75));
					((Control)val6).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val7).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val8).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val9).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Label)val6).set_AutoEllipsis(true);
					val7.set_AutoEllipsis(true);
					val8.set_AutoEllipsis(true);
					val9.set_AutoEllipsis(true);
					((Control)k6DY()).get_Controls().Add((Control)(object)val6);
					((Control)k6DY()).get_Controls().Add((Control)(object)val10);
					((Control)k6DY()).get_Controls().Add((Control)(object)val7);
					((Control)k6DY()).get_Controls().Add((Control)(object)val8);
					((Control)k6DY()).get_Controls().Add((Control)(object)val9);
					((Control)val6).add_Click((EventHandler)Tm6x);
					num3 += num;
					if ((double)num3 > 2.0 * ((double)((Control)k6DY()).get_Width() / 3.0))
					{
						num3 = 0;
						num4 += num2;
					}
				}
			}
			val.Close();
		}
	}

	private void Tm6x(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Kk03 kk = new Kk03();
		kk.passISBN = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		((Form)kk).ShowDialog();
	}

	internal static byte o9A1(byte g8Z, byte[] e3Y, int k6E, int y1F)
	{
		g8Z = (byte)(g8Z ^ checked((byte)(e3Y[unchecked(y1F % e3Y.Length)] ^ ((y1F + unchecked(k6E % e3Y.Length)) & k6E))));
		return g8Z;
	}

	private void r5E(object sender, PaintEventArgs e)
	{
	}
}
