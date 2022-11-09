using System;
using System.Collections;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using f8N7;
using t0B;

namespace d3C;

[DesignerGenerated]
public class Si8 : UserControl
{
	private IContainer components;

	private Panel _Panel1;

	internal Button D;

	public Si8()
	{
		((UserControl)this).add_Load((EventHandler)Lf6);
		j1P();
	}

	protected override void Xm8(bool n5L)
	{
		try
		{
			if (n5L && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(n5L);
		}
	}

	private void j1P()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		g4K(new Panel());
		Yb7(new Button());
		((Control)this).SuspendLayout();
		((Control)Yc3()).set_Location(new Point(35, 28));
		((Control)Yc3()).set_Name("Panel1");
		((Control)Yc3()).set_Size(new Size(1058, 535));
		((Control)Yc3()).set_TabIndex(0);
		((ButtonBase)s2N()).set_BackColor(Color.MediumSeaGreen);
		((Control)s2N()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)s2N()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)s2N()).set_FlatStyle((FlatStyle)1);
		((Control)s2N()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s2N()).set_ForeColor(Color.White);
		((Control)s2N()).set_Location(new Point(467, 569));
		((Control)s2N()).set_Name("Button1");
		((Control)s2N()).set_Size(new Size(191, 38));
		((Control)s2N()).set_TabIndex(1);
		((ButtonBase)s2N()).set_Text("Delete");
		((ButtonBase)s2N()).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)s2N());
		((Control)this).get_Controls().Add((Control)(object)Yc3());
		((Control)this).set_Name("StaffRecommend");
		((Control)this).set_Size(new Size(1136, 636));
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Yc3()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4K(Panel j6N)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(Qf9);
		Panel panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel1 = j6N;
		panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button s2N()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yb7(Button Nk9)
	{
		EventHandler eventHandler = Eg5;
		Button d = D;
		if (d != null)
		{
			((Control)d).remove_Click(eventHandler);
		}
		Button val = (D = Nk9);
		d = D;
		if (d != null)
		{
			((Control)d).add_Click(eventHandler);
		}
	}

	private void Lf6(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Recommendations WHERE Field = 'Staff'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			int num = (int)Math.Round((double)((Control)Yc3()).get_Width() / 2.0 - 50.0);
			int num2 = 100;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 1;
			while (val3.Read())
			{
				string text2 = Conversions.ToString(val3.get_Item("ProfName"));
				string text3 = "SELECT * FROM Users WHERE UserName = '" + text2 + "'";
				OleDbCommand val4 = new OleDbCommand(text3, val);
				OleDbDataReader val5 = val4.ExecuteReader();
				string text4 = "";
				if (val5.Read())
				{
					text4 = Conversions.ToString(val5.get_Item("ProfileName"));
				}
				string text5 = Strings.Format(RuntimeHelpers.GetObjectValue(val3.get_Item("RecDate")), "dddd, MMM d yyyy");
				PictureBox val6 = new PictureBox();
				Label val7 = new Label();
				Label val8 = new Label();
				Label val9 = new Label();
				Label val10 = new Label();
				Label val11 = new Label();
				CheckBox val12 = new CheckBox();
				((Control)val12).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val7).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val8).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val9).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val10).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val11).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val7).set_Size(new Size(300, 20));
				val7.set_Text(Conversions.ToString(val3.get_Item("ISBN")));
				((Control)val8).set_Size(new Size(270, 20));
				val8.set_Text(text4);
				val9.set_Text("The book with ISBN");
				val9.set_AutoSize(true);
				val10.set_Text("is recommended by Prof.");
				val10.set_AutoSize(true);
				((Control)val11).set_Size(new Size(400, 20));
				val11.set_Text("on " + text5);
				((Control)val7).set_Location(new Point(num3 + 145, num4 + 10));
				((Control)val8).set_Location(new Point(num3 + 175, num4 + 40));
				((Control)val9).set_Location(new Point(num3 + 20, num4 + 10));
				((Control)val10).set_Location(new Point(num3 + 20, num4 + 40));
				((Control)val11).set_Location(new Point(num3 + 20, num4 + 70));
				((Control)val6).set_Location(new Point(num3, num4));
				((Control)val12).set_Location(new Point(num3, num4));
				((Control)val12).set_Size(new Size(20, 20));
				((Control)val6).set_Size(new Size(num - 20, num2));
				((Control)val6).SendToBack();
				unchecked
				{
					if (num5 % 2 == 0)
					{
						if (num6 % 2 == 0)
						{
							((Control)val6).set_BackColor(Color.Salmon);
							((Control)val7).set_BackColor(Color.Salmon);
							((Control)val8).set_BackColor(Color.Salmon);
							((Control)val9).set_BackColor(Color.Salmon);
							((Control)val11).set_BackColor(Color.Salmon);
							((Control)val10).set_BackColor(Color.Salmon);
							((ButtonBase)val12).set_BackColor(Color.Salmon);
						}
						else
						{
							((Control)val6).set_BackColor(Color.SandyBrown);
							((Control)val7).set_BackColor(Color.SandyBrown);
							((Control)val8).set_BackColor(Color.SandyBrown);
							((Control)val9).set_BackColor(Color.SandyBrown);
							((Control)val11).set_BackColor(Color.SandyBrown);
							((Control)val10).set_BackColor(Color.SandyBrown);
							((ButtonBase)val12).set_BackColor(Color.SandyBrown);
						}
					}
					else if (num6 % 2 == 0)
					{
						((Control)val6).set_BackColor(Color.DarkKhaki);
						((Control)val7).set_BackColor(Color.DarkKhaki);
						((Control)val8).set_BackColor(Color.DarkKhaki);
						((Control)val9).set_BackColor(Color.DarkKhaki);
						((Control)val11).set_BackColor(Color.DarkKhaki);
						((Control)val10).set_BackColor(Color.DarkKhaki);
						((ButtonBase)val12).set_BackColor(Color.DarkKhaki);
					}
					else
					{
						((Control)val6).set_BackColor(Color.LightSteelBlue);
						((Control)val7).set_BackColor(Color.LightSteelBlue);
						((Control)val8).set_BackColor(Color.LightSteelBlue);
						((Control)val9).set_BackColor(Color.LightSteelBlue);
						((Control)val11).set_BackColor(Color.LightSteelBlue);
						((Control)val10).set_BackColor(Color.LightSteelBlue);
						((ButtonBase)val12).set_BackColor(Color.LightSteelBlue);
					}
					((Control)val7).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val8).set_Font(new Font("Times New Roman", 11f, (FontStyle)1));
					((Control)val9).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val10).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val11).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					val7.set_AutoEllipsis(true);
					val8.set_AutoEllipsis(true);
					val9.set_AutoEllipsis(true);
					val10.set_AutoEllipsis(true);
					val11.set_AutoEllipsis(true);
					((Control)val6).SendToBack();
					((Control)Yc3()).get_Controls().Add((Control)(object)val7);
					((Control)Yc3()).get_Controls().Add((Control)(object)val8);
					((Control)Yc3()).get_Controls().Add((Control)(object)val9);
					((Control)Yc3()).get_Controls().Add((Control)(object)val10);
					((Control)Yc3()).get_Controls().Add((Control)(object)val11);
					((Control)Yc3()).get_Controls().Add((Control)(object)val12);
					((Control)Yc3()).get_Controls().Add((Control)(object)val6);
				}
				num3 += num;
				num6 = 1;
				if ((double)num3 > (double)((Control)Yc3()).get_Width() / 2.0)
				{
					num3 = 0;
					num4 += num2 + 10;
					num5++;
					num6 = 0;
				}
				num7++;
			}
			val.Close();
		}
	}

	private void Qf9(object sender, PaintEventArgs e)
	{
	}

	internal static void Hm2(string Pn5)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Wi35.Ez73(Pn5);
	}

	private void Eg5(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)Yc3()).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (!(val is CheckBox) || !((CheckBox)val).get_Checked())
				{
					continue;
				}
				string name = val.get_Name();
				Control[] array = ((Control)this).get_Controls().Find(name, true);
				int num = 0;
				Control val2 = val;
				Control[] array2 = array;
				foreach (Control val3 in array2)
				{
					num = checked(num + 1);
					if (num == 1)
					{
						val2 = val3;
					}
					if (num != 3)
					{
					}
				}
				OleDbConnection val4 = new OleDbConnection(m2A.Forms.At0().connectionString);
				val4.Open();
				string text = " DELETE FROM Recommendations WHERE ISBN = '" + val2.get_Text() + "' and Field='Staff'";
				OleDbCommand val5 = new OleDbCommand(text, val4);
				flag = true;
				try
				{
					val5.ExecuteNonQuery();
					((Component)(object)val5).Dispose();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				val4.Close();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		if (flag)
		{
			MessageBox.Show("Successfully deleted");
		}
		m2A.Forms.y3X().Ep8q();
	}
}
