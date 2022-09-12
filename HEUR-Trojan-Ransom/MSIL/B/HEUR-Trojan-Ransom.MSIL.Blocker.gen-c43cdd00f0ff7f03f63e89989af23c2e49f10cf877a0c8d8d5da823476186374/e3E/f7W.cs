using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace e3E;

public class f7W
{
	private string save_excel;

	public string Site_id { get; set; }

	public object DockContainerItem1
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem1;
		}
		[CompilerGenerated]
		set
		{
			_DockContainerItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object DockContainerItem2
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem2;
		}
		[CompilerGenerated]
		set
		{
			_DockContainerItem2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ComboBoxEx1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx1;
		}
		[CompilerGenerated]
		set
		{
			_ComboBoxEx1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ModelCb
	{
		[CompilerGenerated]
		get
		{
			return _ModelCb;
		}
		[CompilerGenerated]
		set
		{
			_ModelCb = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ComboBoxEx2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx2;
		}
		[CompilerGenerated]
		set
		{
			_ComboBoxEx2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Name
	{
		[CompilerGenerated]
		get
		{
			return _Name;
		}
		[CompilerGenerated]
		set
		{
			_Name = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object FpSpread1
	{
		[CompilerGenerated]
		get
		{
			return _FpSpread1;
		}
		[CompilerGenerated]
		set
		{
			_FpSpread1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ButtonItem2
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem2;
		}
		[CompilerGenerated]
		set
		{
			_ButtonItem2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object NewBtn1
	{
		[CompilerGenerated]
		get
		{
			return _NewBtn1;
		}
		[CompilerGenerated]
		set
		{
			_NewBtn1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ButtonItem3
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem3;
		}
		[CompilerGenerated]
		set
		{
			_ButtonItem3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object SaveBtn1
	{
		[CompilerGenerated]
		get
		{
			return _SaveBtn1;
		}
		[CompilerGenerated]
		set
		{
			_SaveBtn1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ButtonItem4
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem4;
		}
		[CompilerGenerated]
		set
		{
			_ButtonItem4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object DelBtn1
	{
		[CompilerGenerated]
		get
		{
			return _DelBtn1;
		}
		[CompilerGenerated]
		set
		{
			_DelBtn1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ButtonItem5
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem5;
		}
		[CompilerGenerated]
		set
		{
			_ButtonItem5 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PrtBtn1
	{
		[CompilerGenerated]
		get
		{
			return _PrtBtn1;
		}
		[CompilerGenerated]
		set
		{
			_PrtBtn1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ButtonItem6
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem6;
		}
		[CompilerGenerated]
		set
		{
			_ButtonItem6 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object XlsBtn1
	{
		[CompilerGenerated]
		get
		{
			return _XlsBtn1;
		}
		[CompilerGenerated]
		set
		{
			_XlsBtn1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object FindBtn
	{
		[CompilerGenerated]
		get
		{
			return _FindBtn;
		}
		[CompilerGenerated]
		set
		{
			_FindBtn = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Emp_No
	{
		[CompilerGenerated]
		get
		{
			return _Emp_No;
		}
		[CompilerGenerated]
		set
		{
			_Emp_No = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object FarPoint
	{
		[CompilerGenerated]
		get
		{
			return _FarPoint;
		}
		[CompilerGenerated]
		set
		{
			_FarPoint = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object SaveFileDialog1
	{
		[CompilerGenerated]
		get
		{
			return _SaveFileDialog1;
		}
		[CompilerGenerated]
		set
		{
			_SaveFileDialog1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private void Ci0(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(DockContainerItem1, (Type)null, "Text", new object[1] { "Form Menu" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Text", new object[1] { "Retrieve Condition" }, (string[])null, (Type[])null, false, true);
		if (o2K(RuntimeHelpers.GetObjectValue(ComboBoxEx1), "SELECT model_no FROM tbl_modelmaster WHERE site_id = '" + Site_id + "' ORDER BY model_no"))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBoxEx1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ALL" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(ComboBoxEx1, (Type)null, "Text", new object[1] { "ALL" }, (string[])null, (Type[])null, false, true);
		}
		o2K(RuntimeHelpers.GetObjectValue(ModelCb), "select cus_nm from tbl_customer where site_id = '" + Site_id + "' and cus_type = '1차'  ORDER BY cus_nm");
		NewLateBinding.LateCall(NewLateBinding.LateGet(ModelCb, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ALL" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(ModelCb, (Type)null, "Text", new object[1] { "ALL" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxEx2, (Type)null, "Text", new object[1] { "ALL" }, (string[])null, (Type[])null, false, true);
		o2K(RuntimeHelpers.GetObjectValue(ComboBoxEx2), "select code_name from tbl_codemaster where site_id = '" + Site_id + "' and class_id = 'R0036' order by dis_order");
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBoxEx2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ALL" }, (string[])null, (Type[])null, (bool[])null, true);
		if (i3W(RuntimeHelpers.GetObjectValue(FpSpread1), RuntimeHelpers.GetObjectValue(Name)))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			o8Y(RuntimeHelpers.GetObjectValue(FpSpread1));
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FrozenColumnCount", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Protect", new object[1] { false }, (string[])null, (Type[])null, false, true);
		}
		t0Z(RuntimeHelpers.GetObjectValue(ButtonItem2), RuntimeHelpers.GetObjectValue(Name), "NEW");
		Dq7(RuntimeHelpers.GetObjectValue(NewBtn1), RuntimeHelpers.GetObjectValue(Name), "NEW");
		t0Z(RuntimeHelpers.GetObjectValue(ButtonItem3), RuntimeHelpers.GetObjectValue(Name), "SAVE");
		Dq7(RuntimeHelpers.GetObjectValue(SaveBtn1), RuntimeHelpers.GetObjectValue(Name), "SAVE");
		t0Z(RuntimeHelpers.GetObjectValue(ButtonItem4), RuntimeHelpers.GetObjectValue(Name), "DELETE");
		Dq7(RuntimeHelpers.GetObjectValue(DelBtn1), RuntimeHelpers.GetObjectValue(Name), "DELETE");
		t0Z(RuntimeHelpers.GetObjectValue(ButtonItem5), RuntimeHelpers.GetObjectValue(Name), "PRINT");
		Dq7(RuntimeHelpers.GetObjectValue(PrtBtn1), RuntimeHelpers.GetObjectValue(Name), "PRINT");
		t0Z(RuntimeHelpers.GetObjectValue(ButtonItem6), RuntimeHelpers.GetObjectValue(Name), "EXCEL");
		Dq7(RuntimeHelpers.GetObjectValue(XlsBtn1), RuntimeHelpers.GetObjectValue(Name), "EXCEL");
		t0Z(RuntimeHelpers.GetObjectValue(FindBtn), RuntimeHelpers.GetObjectValue(Name), "FIND");
	}

	private void Dq7(object Hf6, object c3J, string s6F)
	{
		throw new NotImplementedException();
	}

	private void t0Z(object Tj2, object z8L, string Cy4)
	{
		throw new NotImplementedException();
	}

	private void o8Y(object t7S)
	{
		throw new NotImplementedException();
	}

	private bool i3W(object f8X, object g5R)
	{
		throw new NotImplementedException();
	}

	private bool o2K(object n2S, string Kk1)
	{
		throw new NotImplementedException();
	}

	private void Wq6(object sender, EventArgs e)
	{
		object obj = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "RowCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "ForeColor", new object[1] { Color.OrangeRed }, (string[])null, (Type[])null, false, true);
		object obj2 = obj;
		object[] obj3 = new object[3]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			0,
			Site_id
		};
		object[] array = obj3;
		bool[] obj4 = new bool[3] { false, false, true };
		bool[] array2 = obj4;
		NewLateBinding.LateCall(obj2, (Type)null, "SetValue", obj3, (string[])null, (Type[])null, obj4, true);
		if (array2[2])
		{
			Site_id = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
		}
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", array = new object[3]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			8,
			Emp_No
		}, (string[])null, (Type[])null, array2 = new bool[3] { false, false, true }, true);
		if (array2[2])
		{
			Emp_No = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[2]));
		}
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[3]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			9,
			DateAndTime.get_Now()
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", array = new object[3]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			10,
			Emp_No
		}, (string[])null, (Type[])null, array2 = new bool[3] { false, false, true }, true);
		if (array2[2])
		{
			Emp_No = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[2]));
		}
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[3]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			11,
			DateAndTime.get_Now()
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetActiveCell", new object[2]
		{
			Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
			0
		}, (string[])null, (Type[])null, (bool[])null, true);
		object obj5;
		object obj6;
		NewLateBinding.LateCall(FpSpread1, (Type)null, "ShowActiveCell", array = new object[2]
		{
			NewLateBinding.LateGet(obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(FarPoint, (Type)null, "Win", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Spread", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "VerticalPosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bottom", new object[0], (string[])null, (Type[])null, (bool[])null),
			NewLateBinding.LateGet(obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(FarPoint, (Type)null, "Win", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Spread", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HorizontalPosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)
		}, (string[])null, (Type[])null, array2 = new bool[2] { true, true }, true);
		if (array2[0])
		{
			NewLateBinding.LateSetComplex(obj5, (Type)null, "Bottom", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
		}
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj6, (Type)null, "Left", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		obj = null;
	}

	private void Jr0(object o5K)
	{
		throw new NotImplementedException();
	}

	private void Ps6(object sender, EventArgs e)
	{
		string qx = "";
		if (Jy4(RuntimeHelpers.GetObjectValue(FpSpread1), qx, 1))
		{
			o8Y(RuntimeHelpers.GetObjectValue(FpSpread1));
		}
	}

	private bool Jy4(object Yt0, string Qx1, int c4L)
	{
		throw new NotImplementedException();
	}

	private void Rt1(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
	}

	private void s3R(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "";
			object obj = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return;
			}
			DialogResult val = MessageBox.Show("Are you sure To delete this row?", "Delete", (MessageBoxButtons)4);
			if ((int)val == 6)
			{
				text += "DELETE FROM TBL_PRICE\r\n";
				string text2 = text + "WHERE MODEL_NO = '";
				object obj2 = obj;
				object obj3;
				object[] obj4 = new object[2]
				{
					NewLateBinding.LateGet(obj3 = obj, (Type)null, "ActiveRowIndex", new object[0], (string[])null, (Type[])null, (bool[])null),
					3
				};
				object[] array = obj4;
				bool[] obj5 = new bool[2] { true, false };
				bool[] array2 = obj5;
				object obj6 = NewLateBinding.LateGet(obj2, (Type)null, "GetValue", obj4, (string[])null, (Type[])null, obj5);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "ActiveRowIndex", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
				}
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text2, obj6), (object)"'"), (object)"\r\n"));
				string text3 = text + "  AND CUS_NO1 = (SELECT CUS_NO FROM TBL_CUSTOMER WHERE CUS_NO = A.CUS_NM = '";
				obj6 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array = new object[2]
				{
					NewLateBinding.LateGet(obj3 = obj, (Type)null, "ActiveRowIndex", new object[0], (string[])null, (Type[])null, (bool[])null),
					1
				}, (string[])null, (Type[])null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "ActiveRowIndex", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
				}
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text3, obj6), (object)"')"), (object)"\r\n"));
				string text4 = text + "  AND CUS_NO2 = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE CLASS_ID = 'R0036' AND CODE_NAME = '";
				obj6 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array = new object[2]
				{
					NewLateBinding.LateGet(obj3 = obj, (Type)null, "ActiveRowIndex", new object[0], (string[])null, (Type[])null, (bool[])null),
					2
				}, (string[])null, (Type[])null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "ActiveRowIndex", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
				}
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text4, obj6), (object)"')"), (object)"\r\n"));
				string text5 = text + "  AND UPRICE = '";
				obj6 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array = new object[2]
				{
					NewLateBinding.LateGet(obj3 = obj, (Type)null, "ActiveRowIndex", new object[0], (string[])null, (Type[])null, (bool[])null),
					5
				}, (string[])null, (Type[])null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "ActiveRowIndex", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
				}
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text5, obj6), (object)"'"), (object)"\r\n"));
				text += "\r\n";
				MessageBox.Show("삭제되었습니다", "Message");
			}
			obj = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error: " + ex2.Message, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void c7J(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(save_excel, "", false) == 0)
		{
			MessageBox.Show("Select Spread for Printing!!");
		}
		else if (Operators.CompareString(save_excel, "FpSpread1", false) == 0)
		{
			if (!Pj6(RuntimeHelpers.GetObjectValue(FpSpread1), "NO SHIP(Board) Summary", 0))
			{
				Interaction.MsgBox((object)"Fail to Print", (MsgBoxStyle)0, (object)null);
			}
		}
		else
		{
			MessageBox.Show("Select Spread for Printing!!");
		}
	}

	private bool Pj6(object i2R, string p9J, int o1J)
	{
		throw new NotImplementedException();
	}

	private void c9N(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(save_excel, "", false) == 0)
		{
			MessageBox.Show("Select Spread for Saving!!");
		}
		else if (Operators.CompareString(save_excel, "FpSpread1", false) == 0)
		{
			Zr5(RuntimeHelpers.GetObjectValue(SaveFileDialog1), RuntimeHelpers.GetObjectValue(FpSpread1));
		}
		else
		{
			MessageBox.Show("Select Spread for Saving!!");
		}
	}

	private void Zr5(object Pt5, object Ss0)
	{
		throw new NotImplementedException();
	}

	private void j3Z(object Kb1, object Mq7)
	{
		save_excel = "FpSpread1";
	}

	private void f5Q(object c0Y, object n0E)
	{
		j6X(RuntimeHelpers.GetObjectValue(FpSpread1), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(n0E, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}

	private void j6X(object Hs3, object Dq0)
	{
		throw new NotImplementedException();
	}

	internal static int Td5(int Bx4, int f3D)
	{
		return Bx4 % f3D;
	}
}
