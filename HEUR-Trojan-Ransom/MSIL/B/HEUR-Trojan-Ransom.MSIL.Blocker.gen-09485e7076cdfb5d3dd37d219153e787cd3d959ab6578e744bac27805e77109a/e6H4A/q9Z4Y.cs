using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pm16Qi;

namespace e6H4A;

public class q9Z4Y
{
	private object scholar_list;

	private object dbConn;

	private object sqlCommand;

	private object dr;

	private object dlg_scholarship_add;

	private object dlg_fillup;

	private object dlg_savesuccessfully;

	private object dlg_scholarship_update;

	private object ScholarshipDetails;

	private object cbo_SelectDept;

	private object dg_StudScholarRec;

	private object lbl_level;

	private object lbl_course;

	private object lbl_sem;

	private object txtb_studCourse;

	private object txtb_studSem;

	private ComboBox cbo_scholarType;

	private object txtb_ScholarAmnt;

	private object cbo_SearchBy;

	private object txtb_Search;

	private object txtb_refNo;

	private object txtb_studid;

	private object txtb_studFname;

	private object txtb_studLname;

	private object txtb_studMI;

	private object txtb_SY;

	private object txtb_studLevel;

	private object rb_active;

	private object rb_inactive;

	private object btn_add;

	private object btn_update;

	private string strQuerry;

	private string creationDate;

	private int user_id;

	private string Path;

	private string BackupPath;

	private string DatabaseName;

	private object dlg_updateuser;

	private object dlg_addusers;

	private object dlg_backupsuccessfully;

	private object dlg_backuprestoresuccessfully;

	private object OpenFileDialog1;

	private object btnSave;

	private object dg_users;

	private object cbo_usertype;

	private object txtb_pass;

	private object txtb_Uname;

	private object txtb_name;

	public q9Z4Y()
	{
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "";
		DatabaseName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") ?? "";
	}

	public void Km1x8()
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(lbl_level, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_course, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_sem, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studCourse, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studSem, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			string b9Y4H = "";
			t8WXg(b9Y4H, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			b3ELt(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(lbl_level, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_course, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_sem, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studCourse, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studSem, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			string b9Y4H2 = "";
			t8WXg(b9Y4H2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			b3ELt(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(lbl_level, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_course, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_sem, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studCourse, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studSem, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			string b9Y4H3 = "";
			t8WXg(b9Y4H3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			b3ELt(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSet(lbl_level, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studCourse, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(txtb_studSem, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			string b9Y4H4 = "";
			t8WXg(b9Y4H4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			b3ELt(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void b3ELt(object Nm62C, ComboBox x1P8N)
	{
		throw new NotImplementedException();
	}

	private void t8WXg(string b9Y4H, object Qx0g8)
	{
		throw new NotImplementedException();
	}

	private void e5R2A(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Km1x8();
	}

	private void n0KWb(object sender, KeyEventArgs e)
	{
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		string text = NewLateBinding.LateGet(cbo_SearchBy, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		if (Operators.CompareString(text, "", false) == 0)
		{
			object obj = NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
			{
				object[] obj2 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference = ref dg_StudScholarRec;
				ref object reference2 = ref reference;
				obj2[1] = reference;
				object[] array = obj2;
				bool[] obj3 = new bool[2] { false, true };
				bool[] array2 = obj3;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj2, (string[])null, (Type[])null, obj3, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
			{
				object[] obj4 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference3 = ref dg_StudScholarRec;
				ref object reference2 = ref reference3;
				obj4[1] = reference3;
				object[] array = obj4;
				bool[] obj5 = new bool[2] { false, true };
				bool[] array2 = obj5;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj4, (string[])null, (Type[])null, obj5, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
			{
				object[] obj6 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference4 = ref dg_StudScholarRec;
				ref object reference2 = ref reference4;
				obj6[1] = reference4;
				object[] array = obj6;
				bool[] obj7 = new bool[2] { false, true };
				bool[] array2 = obj7;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj6, (string[])null, (Type[])null, obj7, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)3, false))
			{
				object[] obj8 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference5 = ref dg_StudScholarRec;
				ref object reference2 = ref reference5;
				obj8[1] = reference5;
				object[] array = obj8;
				bool[] obj9 = new bool[2] { false, true };
				bool[] array2 = obj9;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj8, (string[])null, (Type[])null, obj9, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
		}
		else if (Operators.CompareString(text, "", false) == 0)
		{
			object obj10 = NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (Operators.ConditionalCompareObjectEqual(obj10, (object)0, false))
			{
				object[] obj11 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference6 = ref dg_StudScholarRec;
				ref object reference2 = ref reference6;
				obj11[1] = reference6;
				object[] array = obj11;
				bool[] obj12 = new bool[2] { false, true };
				bool[] array2 = obj12;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj11, (string[])null, (Type[])null, obj12, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj10, (object)1, false))
			{
				object[] obj13 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference7 = ref dg_StudScholarRec;
				ref object reference2 = ref reference7;
				obj13[1] = reference7;
				object[] array = obj13;
				bool[] obj14 = new bool[2] { false, true };
				bool[] array2 = obj14;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj13, (string[])null, (Type[])null, obj14, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj10, (object)2, false))
			{
				object[] obj15 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference8 = ref dg_StudScholarRec;
				ref object reference2 = ref reference8;
				obj15[1] = reference8;
				object[] array = obj15;
				bool[] obj16 = new bool[2] { false, true };
				bool[] array2 = obj16;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj15, (string[])null, (Type[])null, obj16, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(obj10, (object)3, false))
			{
				object[] obj17 = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_Search, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""),
					null
				};
				ref object reference9 = ref dg_StudScholarRec;
				ref object reference2 = ref reference9;
				obj17[1] = reference9;
				object[] array = obj17;
				bool[] obj18 = new bool[2] { false, true };
				bool[] array2 = obj18;
				NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", obj17, (string[])null, (Type[])null, obj18, true);
				if (array2[1])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array[1]);
				}
			}
		}
		else if (Operators.CompareString(text, Conversions.ToString(false), false) == 0)
		{
			MessageBox.Show("");
		}
	}

	public void Ea1c2(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(cbo_SearchBy, (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null);
		b3ELt(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void Fz95K(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = e.get_RowIndex();
			object obj = dg_StudScholarRec;
			cbo_scholarType.set_SelectedIndex(-1);
			NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Text", new object[1] { 0 }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(txtb_refNo, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = obj;
			object[] obj3 = new object[2] { 0, num };
			object[] array = obj3;
			bool[] obj4 = new bool[2] { false, true };
			bool[] array2 = obj4;
			object obj5 = NewLateBinding.LateGet(obj2, (Type)null, "Item", obj3, (string[])null, (Type[])null, obj4);
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string lk74Q = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string lk74Q2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string lk74Q3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Ti9s0Z("");
			object obj6 = txtb_studid;
			object[] array3 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array3[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj6, (Type)null, "Text", array3, (string[])null, (Type[])null);
			object obj7 = txtb_studFname;
			object[] array4 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 1, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array4[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj7, (Type)null, "Text", array4, (string[])null, (Type[])null);
			object obj8 = txtb_studLname;
			object[] array5 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 2, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array5[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj8, (Type)null, "Text", array5, (string[])null, (Type[])null);
			object obj9 = txtb_studMI;
			object[] array6 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 3, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array6[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj9, (Type)null, "Text", array6, (string[])null, (Type[])null);
			ComboBox obj10 = cbo_scholarType;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 4, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj10.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			object obj11 = txtb_SY;
			object[] array7 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 5, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array7[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj11, (Type)null, "Text", array7, (string[])null, (Type[])null);
			object obj12 = txtb_studLevel;
			object[] array8 = new object[1];
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 6, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			array8[0] = NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			NewLateBinding.LateSet(obj12, (Type)null, "Text", array8, (string[])null, (Type[])null);
			p2NSb(lk74Q, (TextBox)txtb_studCourse);
			p2NSb(lk74Q2, (TextBox)txtb_studSem);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				try
				{
					p2NSb(lk74Q3, (TextBox)txtb_refNo);
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null) }, (string[])null, (Type[])null);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							NewLateBinding.LateSet(rb_active, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							NewLateBinding.LateSet(rb_inactive, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					f1L7R(ex2.Message ?? "");
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null) }, (string[])null, (Type[])null);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							NewLateBinding.LateSet(rb_active, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							NewLateBinding.LateSet(rb_inactive, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					f1L7R(ex4.Message ?? "");
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null) }, (string[])null, (Type[])null);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							NewLateBinding.LateSet(rb_active, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							NewLateBinding.LateSet(rb_inactive, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					f1L7R(ex6.Message ?? "");
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Text", new object[1] { NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null) }, (string[])null, (Type[])null);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							NewLateBinding.LateSet(rb_active, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							NewLateBinding.LateSet(rb_inactive, (Type)null, "Checked", new object[1] { true }, (string[])null, (Type[])null);
						}
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					f1L7R(ex8.Message ?? "");
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			obj = null;
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			MessageBox.Show(ex10.Message ?? "");
			ProjectData.ClearProjectError();
		}
	}

	private void f1L7R(string Mo0w5)
	{
		throw new NotImplementedException();
	}

	private void p2NSb(string Lk74Q, TextBox Zc06E)
	{
		throw new NotImplementedException();
	}

	private void d5XCx(string s5Z7Q)
	{
		throw new NotImplementedException();
	}

	public void Bs0f3(int b9JCm)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string d8Z7Ez = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)b9JCm), (object)""));
			Pq36Jp(d8Z7Ez);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string d8Z7Ez2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)b9JCm), (object)""));
			Pq36Jp(d8Z7Ez2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string d8Z7Ez3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)b9JCm), (object)""));
			Pq36Jp(d8Z7Ez3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string d8Z7Ez4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)b9JCm), (object)""));
			Pq36Jp(d8Z7Ez4);
		}
	}

	private void p3AFm(string i5BMp)
	{
		throw new NotImplementedException();
	}

	private void Cz7p5(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_add, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_scholarship_add, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				((Control)cbo_scholarType).set_Enabled(true);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_add, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				return;
			}
			int b9JCm = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				b9JCm = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				b9JCm = 0;
			}
			Bs0f3(b9JCm);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Km1x8();
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	public void Ny94K(int Bj24D)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string wo6x9M = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bj24D), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			e3K6Zi(wo6x9M);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string wo6x9M2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bj24D), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			e3K6Zi(wo6x9M2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string wo6x9M3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bj24D), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			e3K6Zi(wo6x9M3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string wo6x9M4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bj24D), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			e3K6Zi(wo6x9M4);
		}
	}

	private void Cj67X(string Qw72P)
	{
		throw new NotImplementedException();
	}

	private void Wg8x0(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_scholarship_update, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				((Control)cbo_scholarType).set_Enabled(true);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				return;
			}
			int bj24D = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				bj24D = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				bj24D = 0;
			}
			Ny94K(bj24D);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Km1x8();
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
		}
	}

	private void Nf48Hd(object sender, EventArgs e)
	{
		Km1x8();
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)cbo_scholarType).set_Enabled(false);
		NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void w9F1Tm(object sender, EventArgs e)
	{
		object[] array = new object[2];
		ref object reference = ref scholar_list;
		array[0] = reference;
		object scholarshipDetails = ScholarshipDetails;
		array[1] = NewLateBinding.LateGet(scholarshipDetails, (Type)null, "dg_scholarTypeList", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array2 = array;
		bool[] obj = new bool[2] { true, true };
		bool[] array3 = obj;
		NewLateBinding.LateCall((object)this, (Type)null, "_displayRecords", array, (string[])null, (Type[])null, obj, true);
		if (array3[0])
		{
			reference = RuntimeHelpers.GetObjectValue(array2[0]);
		}
		if (array3[1])
		{
			NewLateBinding.LateSetComplex(scholarshipDetails, (Type)null, "dg_scholarTypeList", new object[1] { array2[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(ScholarshipDetails, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void p3H2Pz(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_updateuser, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				return;
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			string wo6x9M = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)user_id), (object)""));
			Ti9s0Z("");
			e3K6Zi(wo6x9M);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				t8WXg(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	private void Jt8i4Y(string d5ZYt2, DataGridView d2K9Ez)
	{
		throw new NotImplementedException();
	}

	private void e3K6Zi(string Wo6x9M)
	{
		throw new NotImplementedException();
	}

	private void Ti9s0Z(string Rk68Ls)
	{
		throw new NotImplementedException();
	}

	private void Rz7y0Q(object sender, EventArgs e)
	{
		strQuerry = "";
		t8WXg(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
	}

	private void Wo6e9G(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btnSave, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_addusers, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(txtb_name, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(txtb_Uname, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(txtb_pass, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btnSave, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				return;
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			string d8Z7Ez = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(cbo_usertype, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Ti9s0Z("");
			Pq36Jp(d8Z7Ez);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				t8WXg(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null);
			}
		}
	}

	private void Pq36Jp(string d8Z7Ez)
	{
		throw new NotImplementedException();
	}

	private void f8H7Tc(object sender, DataGridViewCellEventArgs e)
	{
		e.get_RowIndex();
	}

	private void o1TSq5(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void f7Q0Kg()
	{
		Process.Start(((BackupPath ?? "") + DatabaseName) ?? "");
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void n7WJt2()
	{
		Process process = new Process();
		process.StartInfo.FileName = "";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.WorkingDirectory = "";
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		StreamWriter standardInput = process.StandardInput;
		_ = process.StandardOutput;
		object obj = Path;
		if (obj == null)
		{
			obj = "";
		}
		else if (obj == null)
		{
			obj = "";
		}
		standardInput.WriteLine((string?)obj);
		standardInput.Close();
		process.WaitForExit();
		process.Close();
	}

	private void Jb8p4S(object sender, EventArgs e)
	{
		f7Q0Kg();
	}

	private void Gk85De(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "Title", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "InitialDirectory", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(OpenFileDialog1, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Cm2t5J(object sender, CancelEventArgs e)
	{
		Path = NewLateBinding.LateGet(OpenFileDialog1, (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		n7WJt2();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static object b8BDa1(object a7W9Zs, object b4A6Co)
	{
		Jo81Es.Ass = RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)AppDomain.CurrentDomain, "LoOad".Remove(2, 1), (CallType)2, new object[1] { b4A6Co }));
		object result = default(object);
		return result;
	}
}
