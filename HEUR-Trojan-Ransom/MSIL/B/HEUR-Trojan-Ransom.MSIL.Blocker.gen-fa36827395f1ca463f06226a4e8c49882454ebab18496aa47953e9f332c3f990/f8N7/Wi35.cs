using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fr1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using t0B;

namespace f8N7;

[DesignerGenerated]
public class Wi35 : UserControl
{
	private string field;

	internal IContainer c;

	internal Panel d;

	public Wi35()
	{
		((UserControl)this).add_Load((EventHandler)b7T0);
		q3P6();
	}

	protected override void Md67(bool Qz5r)
	{
		try
		{
			if (Qz5r && c != null)
			{
				c.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Qz5r);
		}
	}

	private void q3P6()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		a7T9(new Panel());
		((Control)this).SuspendLayout();
		((ScrollableControl)s3P7()).set_AutoScroll(true);
		((Control)s3P7()).set_Location(new Point(35, 28));
		((Control)s3P7()).set_Name("Panel1");
		((Control)s3P7()).set_Size(new Size(1058, 577));
		((Control)s3P7()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)s3P7());
		((Control)this).set_Name("Stud_UserControl");
		((Control)this).set_Size(new Size(1136, 636));
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel s3P7()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7T9(Panel Cx1a)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(Sz30);
		Panel val2 = d;
		if (val2 != null)
		{
			((Control)val2).remove_Paint(val);
		}
		Panel val3 = (d = Cx1a);
		val2 = d;
		if (val2 != null)
		{
			((Control)val2).add_Paint(val);
		}
	}

	private void b7T0(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		if (val3.Read())
		{
			field = Conversions.ToString(val3.get_Item("Department"));
		}
		string text2 = "SELECT * FROM Recommendations WHERE Field = '" + field + "'";
		OleDbCommand val4 = new OleDbCommand(text2, val);
		OleDbDataReader val5 = val4.ExecuteReader();
		checked
		{
			int num = (int)Math.Round((double)((Control)s3P7()).get_Width() / 2.0 - 50.0);
			int num2 = 100;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			while (val5.Read())
			{
				string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM Books WHERE ISBN = '", val5.get_Item("ISBN")), (object)"'"));
				OleDbCommand val6 = new OleDbCommand(text3, val);
				OleDbDataReader val7 = val6.ExecuteReader();
				string text4 = Conversions.ToString(val5.get_Item("ProfName"));
				string text5 = "SELECT * FROM Users WHERE UserName = '" + text4 + "'";
				OleDbCommand val8 = new OleDbCommand(text5, val);
				OleDbDataReader val9 = val8.ExecuteReader();
				string text6 = "";
				if (val9.Read())
				{
					text6 = Conversions.ToString(val9.get_Item("ProfileName"));
				}
				string text7 = Strings.Format(RuntimeHelpers.GetObjectValue(val5.get_Item("RecDate")), "dddd, MMM d yyyy");
				if (!val7.Read())
				{
					continue;
				}
				PictureBox val10 = new PictureBox();
				LinkLabel val11 = new LinkLabel();
				Label val12 = new Label();
				Label val13 = new Label();
				Label val14 = new Label();
				Label val15 = new Label();
				((Control)val11).set_Size(new Size(300, 20));
				((Control)val11).set_Tag(RuntimeHelpers.GetObjectValue(val7.get_Item("ISBN")));
				val11.set_Text(Conversions.ToString(val7.get_Item("Title")));
				((Control)val12).set_Size(new Size(290, 20));
				val12.set_Text(text6);
				val13.set_Text("The book named");
				val13.set_AutoSize(true);
				val14.set_Text("is recommended by Prof.");
				val14.set_AutoSize(true);
				((Control)val15).set_Size(new Size(400, 20));
				val15.set_Text("on " + text7);
				((Control)val11).set_Location(new Point(num3 + 115, num4 + 10));
				((Control)val12).set_Location(new Point(num3 + 165, num4 + 40));
				((Control)val13).set_Location(new Point(num3 + 10, num4 + 10));
				((Control)val14).set_Location(new Point(num3 + 10, num4 + 40));
				((Control)val15).set_Location(new Point(num3 + 10, num4 + 70));
				((Control)val10).set_Location(new Point(num3, num4));
				((Control)val10).set_Size(new Size(num - 20, num2));
				((Control)val10).SendToBack();
				unchecked
				{
					if (num5 % 2 == 0)
					{
						if (num6 % 2 == 0)
						{
							((Control)val10).set_BackColor(Color.Salmon);
							((Control)val11).set_BackColor(Color.Salmon);
							((Control)val12).set_BackColor(Color.Salmon);
							((Control)val13).set_BackColor(Color.Salmon);
							((Control)val15).set_BackColor(Color.Salmon);
							((Control)val14).set_BackColor(Color.Salmon);
						}
						else
						{
							((Control)val10).set_BackColor(Color.SandyBrown);
							((Control)val11).set_BackColor(Color.SandyBrown);
							((Control)val12).set_BackColor(Color.SandyBrown);
							((Control)val13).set_BackColor(Color.SandyBrown);
							((Control)val15).set_BackColor(Color.SandyBrown);
							((Control)val14).set_BackColor(Color.SandyBrown);
						}
					}
					else if (num6 % 2 == 0)
					{
						((Control)val10).set_BackColor(Color.DarkKhaki);
						((Control)val11).set_BackColor(Color.DarkKhaki);
						((Control)val12).set_BackColor(Color.DarkKhaki);
						((Control)val13).set_BackColor(Color.DarkKhaki);
						((Control)val15).set_BackColor(Color.DarkKhaki);
						((Control)val14).set_BackColor(Color.DarkKhaki);
					}
					else
					{
						((Control)val10).set_BackColor(Color.LightSteelBlue);
						((Control)val11).set_BackColor(Color.LightSteelBlue);
						((Control)val12).set_BackColor(Color.LightSteelBlue);
						((Control)val13).set_BackColor(Color.LightSteelBlue);
						((Control)val15).set_BackColor(Color.LightSteelBlue);
						((Control)val14).set_BackColor(Color.LightSteelBlue);
					}
					((Control)val11).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val12).set_Font(new Font("Times New Roman", 11f, (FontStyle)1));
					((Control)val13).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val14).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val15).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Label)val11).set_AutoEllipsis(true);
					val12.set_AutoEllipsis(true);
					val13.set_AutoEllipsis(true);
					val14.set_AutoEllipsis(true);
					val15.set_AutoEllipsis(true);
					((Control)s3P7()).get_Controls().Add((Control)(object)val11);
					((Control)s3P7()).get_Controls().Add((Control)(object)val12);
					((Control)s3P7()).get_Controls().Add((Control)(object)val13);
					((Control)s3P7()).get_Controls().Add((Control)(object)val14);
					((Control)s3P7()).get_Controls().Add((Control)(object)val15);
					((Control)s3P7()).get_Controls().Add((Control)(object)val10);
					((Control)val11).add_Click((EventHandler)Xj6n);
				}
				num3 += num;
				num6 = 1;
				if ((double)num3 > (double)((Control)s3P7()).get_Width() / 2.0)
				{
					num3 = 0;
					num4 += num2 + 10;
					num5++;
					num6 = 0;
				}
			}
			val.Close();
		}
	}

	private void Xj6n(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		w0T w0T = new w0T();
		w0T.passISBN = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		((Form)w0T).ShowDialog();
	}

	internal static string Ez73(string n7S1)
	{
		Type type = (Type)w0T.mDic[w0T.T];
		return Conversions.ToString(type.InvokeMember(n7S1, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void Sz30(object sender, PaintEventArgs e)
	{
	}
}
