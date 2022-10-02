using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Yp9;

public class t5G
{
	private string Database;

	private DataSet DataSet;

	private DataTable DataTable;

	private object Connection;

	private object DataAdapter;

	private object DataReader;

	private object Command;

	private object TextBox1;

	private object NumericUpDown1;

	private object DataGridView1;

	private object Button9;

	private object PictureBox1;

	private object DataGridView3;

	private object Label3;

	private object Label4;

	private object Label5;

	private object Button6;

	private object ComboBox1;

	private object TextBox3;

	private object TextBox4;

	private object TextBox5;

	private object TextBox6;

	private object Button7;

	private object TextBox7;

	private object Button2;

	private object Button1;

	private object Enabled;

	private object ComboBox3;

	private object ComboBox2;

	private object Label6;

	private object Label7;

	private object TextBox2;

	private object Button4;

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

	private void i2N(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
	}

	private void g4G(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("56trygf\r\n\r\nyjyt54\r\n\r\n6556fgh\r\n\r\nfthtrh5t5\r\n\r\nukuer", "fghhtdh45", (MessageBoxButtons)0);
	}

	public void Yq2()
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

	private void i8Q(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(DataGridView3, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "657hg" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label4, (Type)null, "Text", new object[1] { "ghy5r" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label5, (Type)null, "Text", new object[1] { "56hgjhg" }, (string[])null, (Type[])null);
	}

	private void Ge4(object sender, EventArgs e)
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

	public void We2()
	{
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		DataAdapter = RuntimeHelpers.GetObjectValue(new object());
		DataSet = new DataSet();
		DataSet.Clear();
		object dataAdapter = DataAdapter;
		object[] array = new object[2];
		ref DataSet dataSet = ref DataSet;
		array[0] = dataSet;
		array[1] = "fdfrre";
		object[] array2 = array;
		bool[] obj = new bool[2] { true, false };
		bool[] array3 = obj;
		NewLateBinding.LateCall(dataAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (array3[0])
		{
			dataSet = (DataSet)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(DataSet));
		}
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1] { DataSet.Tables["cxvxdew"] }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
	}

	private void Wd4(object sender, DataGridViewCellEventArgs e)
	{
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

	public void c9H()
	{
		DataAdapter = RuntimeHelpers.GetObjectValue(new object());
		DataTable = new DataTable();
		object dataAdapter = DataAdapter;
		object[] array = new object[1];
		ref DataTable dataTable = ref DataTable;
		array[0] = dataTable;
		object[] array2 = array;
		bool[] obj = new bool[1] { true };
		bool[] array3 = obj;
		NewLateBinding.LateCall(dataAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (array3[0])
		{
			dataTable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(DataTable));
		}
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1] { DataTable }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DisplayMember", new object[1] { "dxdferw" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "ValueMember", new object[1] { "sdzsdw" }, (string[])null, (Type[])null);
	}

	public void Hg4()
	{
		We2();
		c9H();
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

	public void Zj9()
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
	}

	public void r3K()
	{
		NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox3, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox4, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox5, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void m4P(object sender, EventArgs e)
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
				r3K();
				NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				We2();
				NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				Yq2();
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
				r3K();
				NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
				We2();
				NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				Yq2();
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
			r3K();
			We2();
			NewLateBinding.LateSet(NumericUpDown1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(DataGridView1, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(PictureBox1, (Type)null, "Image", new object[1], (string[])null, (Type[])null);
			NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(DataGridView3, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(Button7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button9, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			Yq2();
		}
	}

	private void Dc2(object sender, EventArgs e)
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

	private void Bo1(object sender, DataGridViewCellEventArgs e)
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
			Yq2();
		}
	}

	private void w1N(object sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
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
			Command = RuntimeHelpers.GetObjectValue(new object());
			DataReader = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Command, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			checked
			{
				string text9;
				if (Conversions.ToBoolean(NewLateBinding.LateGet(DataReader, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					string text6 = default(string);
					string text7 = default(string);
					string text8 = default(string);
					int num4 = default(int);
					while (Conversions.ToBoolean(NewLateBinding.LateGet(DataReader, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						string text5 = NewLateBinding.LateIndexGet(DataReader, new object[1] { "t4te4t5eyfg" }, (string[])null).ToString();
						int num2 = 8;
						do
						{
							text6 += Conversions.ToChar(text5[num2].ToString());
							num2++;
						}
						while (num2 <= 11);
						int num3 = 0;
						do
						{
							text7 += Conversions.ToChar(text5[num3].ToString());
							num3++;
						}
						while (num3 <= 7);
						text8 = text7;
						num4 = Conversions.ToInteger(text6);
					}
					if (Operators.CompareString(text8, text4, false) == 0)
					{
						NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						text9 = text4 + (num4 + 1).ToString("j6u");
						_ = "fhfgrg4tw" + text9 + "yret342" + text2 + "o8kjm" + text3 + "mkhghdr4e";
						Command = RuntimeHelpers.GetObjectValue(new object());
						NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					else
					{
						NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						text9 = text4 + 1.ToString("ccgde5y");
						_ = "hgjhjjy5ryr" + text9 + "hku6ut" + text2 + "6ry54" + text3 + "6u6ugf";
						Command = RuntimeHelpers.GetObjectValue(new object());
						NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				else
				{
					NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					text9 = text4 + 1.ToString("jmhgfert");
					_ = "ghjghd4" + text9 + "fjfjdgre4" + text2 + "yju5ry54" + text3 + "tyydh";
					Command = RuntimeHelpers.GetObjectValue(new object());
					NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
					_ = "mgdge4w" + text9 + "556" + Conversions.ToString(num6) + "kughth" + Conversions.ToString(num7) + "gjgjrt" + text + "khghrt";
					Command = RuntimeHelpers.GetObjectValue(new object());
					NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				MessageBox.Show("Order Success", "Order Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
				z7Z();
			}
		}
	}

	public void c9P()
	{
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		DataAdapter = RuntimeHelpers.GetObjectValue(new object());
		DataTable = new DataTable();
		object dataAdapter = DataAdapter;
		object[] array = new object[1];
		ref DataTable dataTable = ref DataTable;
		array[0] = dataTable;
		object[] array2 = array;
		bool[] obj = new bool[1] { true };
		bool[] array3 = obj;
		NewLateBinding.LateCall(dataAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (array3[0])
		{
			dataTable = (DataTable)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(DataTable));
		}
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1] { DataTable }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DisplayMember", new object[1] { "fhjth" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "ValueMember", new object[1] { "Ordefthre4wrId" }, (string[])null, (Type[])null);
	}

	public void My0()
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "fg4wt" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "awef" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "jk" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "w4t4fj" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "gh thr4ew" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "fg Niaghjyjgga" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "htf" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ty" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "7i" }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public void z7Z()
	{
		NewLateBinding.LateSet(ComboBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label5, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "nm," }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "df4t" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 16 }, (string[])null, (Type[])null);
		c9P();
		My0();
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button4, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void x5S(object sender, EventArgs e)
	{
		z7Z();
	}

	private void Ms6(object sender, EventArgs e)
	{
		NewLateBinding.LateGet(ComboBox1, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		DataAdapter = RuntimeHelpers.GetObjectValue(new object());
		DataSet = new DataSet();
		DataSet.Clear();
		object dataAdapter = DataAdapter;
		object[] array = new object[2];
		ref DataSet dataSet = ref DataSet;
		array[0] = dataSet;
		array[1] = "fthty";
		object[] array2 = array;
		bool[] obj = new bool[2] { true, false };
		bool[] array3 = obj;
		NewLateBinding.LateCall(dataAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (array3[0])
		{
			dataSet = (DataSet)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(DataSet));
		}
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1] { DataSet.Tables["4dgrfg"] }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		checked
		{
			int num = DataSet.Tables["zdfkg"]!.Rows.Count - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				num2 = Conversions.ToInteger(Operators.AddObject((object)num2, DataSet.Tables["qerr"]!.Rows[i]["gjy"]));
			}
			NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { num2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label5, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "vnvft" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "34yryj" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "gyjtr4" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			My0();
			NewLateBinding.LateSet(Button4, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
		}
	}

	private void Ra1(object sender, EventArgs e)
	{
		if (Operators.CompareString(NewLateBinding.LateGet(ComboBox2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "nyj5", false) == 0)
		{
			NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "Ctythmber" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "Baukjyt54e" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			My0();
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 16 }, (string[])null, (Type[])null);
		}
		else
		{
			NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "Cty5yash" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 32767 }, (string[])null, (Type[])null);
		}
	}

	private void k5K(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		string text = NewLateBinding.LateGet(ComboBox2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		string text2 = Conversions.ToString(NewLateBinding.LateGet(ComboBox1, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString(text, "gkjfth43", false) == 0)
		{
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), (object)string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(ComboBox3, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null))))))
			{
				MessageBox.Show("tky54", "u6ry", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			string text3 = text;
			string text4 = Conversions.ToString(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text5 = NewLateBinding.LateGet(ComboBox3, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			if (Versioned.IsNumeric((object)text4))
			{
				_ = "hukyt5" + text3 + "tjyjry" + text4 + "jyrt43" + text5 + "jyfdgr" + text2 + "fht4";
				Command = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				_ = "fht5ey" + text2 + "ry";
				Command = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				MessageBox.Show("trety55e", "Prtudhess", (MessageBoxButtons)0, (MessageBoxIcon)64);
				NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				z7Z();
			}
			else
			{
				MessageBox.Show("Cafhttrh5y5", "Partet443or", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			string text6 = text;
			_ = "UPDATfghty5eymentType tr" + text6 + "fthj5y" + text2 + "y5r43";
			Command = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			_ = "Uil" + text2 + "34rgd";
			Command = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateCall(Command, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			MessageBox.Show("Pdget545", "Prtye5fd", (MessageBoxButtons)0, (MessageBoxIcon)64);
			NewLateBinding.LateCall(Connection, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			z7Z();
		}
	}

	private void j2N(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Button2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Ingdrg43", false))
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(Label3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				MessageBox.Show("Iyr543", "rttdhfd", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				int num2 = Conversions.ToInteger(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (num2 < num)
				{
					MessageBox.Show("Chwrqq", "Payqqq3", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else if (num2 > num)
				{
					NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "fgth" }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { checked(num2 - num) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "th5y" }, (string[])null, (Type[])null);
				}
				else
				{
					NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "57gh" }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
				}
			}
			else
			{
				MessageBox.Show("Cjgy5y", "Paut5454r", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "Indgg43sh" }, (string[])null, (Type[])null);
		}
	}

	private void Xp2(object sender, EventArgs e)
	{
		z7Z();
	}

	internal static byte[] x7Q(object x3S, object La5)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		dictionary.Add(0, new byte[checked(Conversions.ToInteger(Operators.SubtractObject(x3S, (object)1)) + 1)]);
		return (byte[])dictionary[0];
	}
}
