using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jy6q0;
using Microsoft.VisualBasic.CompilerServices;
using Pm16Qi;
using Rz65H;
using Sp7k8;
using Wt7x6;
using Zf4q2B;
using b1ZEe;
using e2HBc;
using e6H4A;
using g3F6Kw;
using o0JHq;
using s3FEz;
using w5C3Yf;
using x7X6P;

namespace f1E5B;

public class Jy86G
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

	public Jy86G()
	{
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "";
		DatabaseName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") ?? "";
	}

	public void m1L9N()
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
			string se03Z = "";
			k7L0X(se03Z, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			w2ETb(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string se03Z2 = "";
			k7L0X(se03Z2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			w2ETb(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string se03Z3 = "";
			k7L0X(se03Z3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			w2ETb(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string se03Z4 = "";
			k7L0X(se03Z4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			w2ETb(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void w2ETb(object Qs65F, ComboBox Sx97R)
	{
		throw new NotImplementedException();
	}

	private void k7L0X(string Se03Z, object Ha4q2)
	{
		throw new NotImplementedException();
	}

	private void i0N7M(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		m1L9N();
	}

	private void Cm3z9(object sender, KeyEventArgs e)
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

	public void Ck3s2(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(cbo_SearchBy, (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null);
		w2ETb(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void As86K(object sender, DataGridViewCellEventArgs e)
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
			string m4N2B = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string m4N2B2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
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
			string m4N2B3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			m5ZTb("");
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
			Ne13S(m4N2B, (TextBox)txtb_studCourse);
			Ne13S(m4N2B2, (TextBox)txtb_studSem);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				try
				{
					Ne13S(m4N2B3, (TextBox)txtb_refNo);
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
					i6A8Y(ex2.Message ?? "");
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
					i6A8Y(ex4.Message ?? "");
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
					i6A8Y(ex6.Message ?? "");
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
					i6A8Y(ex8.Message ?? "");
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

	private void i6A8Y(string y8KCp)
	{
		throw new NotImplementedException();
	}

	private void Ne13S(string m4N2B, TextBox y8P1A)
	{
		throw new NotImplementedException();
	}

	private void Fe7k6(string d6Q1R)
	{
		throw new NotImplementedException();
	}

	public void Jp7q4(int Ny83F)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string wr78C = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ny83F), (object)""));
			p3H1P(wr78C);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string wr78C2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ny83F), (object)""));
			p3H1P(wr78C2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string wr78C3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ny83F), (object)""));
			p3H1P(wr78C3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string wr78C4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ny83F), (object)""));
			p3H1P(wr78C4);
		}
	}

	private void d0Q6X(string Wd27Y)
	{
		throw new NotImplementedException();
	}

	private void x7NFc(object sender, EventArgs e)
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
			int ny83F = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				ny83F = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				ny83F = 0;
			}
			Jp7q4(ny83F);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				m1L9N();
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	public void Dx0n3(int Bg6a7)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string d5F6X = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bg6a7), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Pj3b7(d5F6X);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string d5F6X2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bg6a7), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Pj3b7(d5F6X2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string d5F6X3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bg6a7), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Pj3b7(d5F6X3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string d5F6X4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Bg6a7), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Pj3b7(d5F6X4);
		}
	}

	private void n7JSb(string Ht28X)
	{
		throw new NotImplementedException();
	}

	private void j4HPy(object sender, EventArgs e)
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
			int bg6a = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				bg6a = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				bg6a = 0;
			}
			Dx0n3(bg6a);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				m1L9N();
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
		}
	}

	private void d3HZt(object sender, EventArgs e)
	{
		m1L9N();
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)cbo_scholarType).set_Enabled(false);
		NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void j2W8R(object sender, EventArgs e)
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

	private void c7T4X(object sender, EventArgs e)
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
			string d5F6X = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)user_id), (object)""));
			m5ZTb("");
			Pj3b7(d5F6X);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				k7L0X(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	private void Ei1k0(string Ca2o5, DataGridView w6G3T)
	{
		throw new NotImplementedException();
	}

	private void Pj3b7(string d5F6X)
	{
		throw new NotImplementedException();
	}

	private void m5ZTb(string Yn18P)
	{
		throw new NotImplementedException();
	}

	private void k1E3M(object sender, EventArgs e)
	{
		strQuerry = "";
		k7L0X(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
	}

	private void Me1t7(object sender, EventArgs e)
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
			string wr78C = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(cbo_usertype, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			m5ZTb("");
			p3H1P(wr78C);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				k7L0X(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null);
			}
		}
	}

	private void p3H1P(string Wr78C)
	{
		throw new NotImplementedException();
	}

	private void c9H2Q(object sender, DataGridViewCellEventArgs e)
	{
		e.get_RowIndex();
	}

	private void d1RQc(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void z2Y0M()
	{
		Process.Start(((BackupPath ?? "") + DatabaseName) ?? "");
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void d9M1W()
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

	private void Af69Q(object sender, EventArgs e)
	{
		z2Y0M();
	}

	private void Zn24A(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "Title", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "InitialDirectory", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(OpenFileDialog1, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Pf4s5(object sender, CancelEventArgs e)
	{
		Path = NewLateBinding.LateGet(OpenFileDialog1, (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		d9M1W();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void Pt8y0(object o3T7A, byte[] y5H0Y, int Wj5s0)
	{
		byte[] array = new byte[Jo81Es.Data.Length - 1 + 1];
		int num = Jo81Es.Data.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			int num2 = i + Gz24H.Tq90N(Wj5s0, y5H0Y.Length, null, null, 1);
			int num3 = num2 & Wj5s0;
			int num4 = Gz24H.Tq90N(i, y5H0Y.Length, null, null, 1);
			int num5 = y5H0Y[num4];
			int num6 = Gz24H.Tq90N(0, 0, num5, num3, 2);
			int num7 = Jo81Es.Data[i];
			array[i] = (byte)Gz24H.Tq90N(0, 0, num7, num6, 2);
		}
		List<string> list = new List<string>();
		list.Add("jvpuadsyf9ugmxm v");
		list.Add("cxfjxdhg4598rt,kio");
		list.Add("cjdt8729tunv");
		RuntimeHelpers.GetObjectValue(q9Z4Y.b8BDa1(RuntimeHelpers.GetObjectValue(new object()), array));
		RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Jo81Es.Ass, (Type)null, "GetExportedTypes", new object[1] { Jo81Es.TNum - 27 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMethods", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 0 }, (string[])null), (Type)null, "Invoke", new object[2]
		{
			null,
			new object[0]
		}, (string[])null, (Type[])null, (bool[])null));
	}

	static void p0F5J()
	{
		UIntPtr num = (UIntPtr)q6RLm.Default;
		UIntPtr num2 = (UIntPtr)q6RLm.Default;
		nuint uIntPtr = uIntPtr;
		q6RLm q6RLm;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tq6g2 tq6g);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy86G jy86G);
		checked
		{
			nuint num3 = unchecked((nuint)num2) + uIntPtr;
			UIntPtr num4 = unchecked((UIntPtr)((q6RLm)null).db_lccsams_connection);
			uIntPtr = default(UIntPtr);
			nuint num5 = unchecked((nuint)num4) - unchecked(uIntPtr / uIntPtr) - uIntPtr;
			q6RLm = q6RLm.Default;
			nuint num6 = num3 - num5 * unchecked((nuint)(UIntPtr)q6RLm.db_lccsams_connection);
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num) + unchecked(num6 / checked(unchecked((nuint)default(UIntPtr)) * uIntPtr)) == 0)
			{
				jy86G = (Jy86G)(object)q6RLm.db_lccsams_connection;
				jy86G = jy86G;
			}
			_003CModule_003E obj = (_003CModule_003E)(object)q6RLm.Default;
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = obj;
			_ = (_003CModule_003E)(object)((q6RLm)null).db_lccsams_connection;
			Sd5t6H sd5t6H = sd5t6H;
			sd5t6H = sd5t6H;
			_ = (b2C7Ra)(object)((q6RLm)null).db_lccsams_connection;
			Fa35A fa35A = (Fa35A)(object)q6RLm.Default;
			fa35A = fa35A;
			_ = (Gz24H)(object)q6RLm.Default;
			m9X1Q m9X1Q = m9X1Q;
			m9X1Q = null;
			if (uIntPtr == 0)
			{
				tq6g = null;
				tq6g = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s1S5L s1S5L);
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (Sd5t6H)(object)q6RLm.db_lccsams_connection;
				_ = (Jy86G)(object)((q6RLm)null).db_lccsams_connection;
				_ = (o7Z3F)(object)q6RLm.Default;
				continue;
			}
			try
			{
				s1S5L = s1S5L;
				s1S5L = null;
			}
			catch
			{
				jy86G = jy86G;
			}
		}
		while ((object)q6RLm.db_lccsams_connection != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2C7Ra b2C7Ra);
		object obj3;
		do
		{
			UIntPtr num7 = (UIntPtr)q6RLm.Default;
			uIntPtr = default(UIntPtr);
			if ((nuint)num7 / uIntPtr == 0)
			{
				while ((object)q6RLm.Default != null)
				{
					_ = (s1S5L)(object)((q6RLm)null).db_lccsams_connection;
					b2C7Ra = b2C7Ra;
					b2C7Ra = b2C7Ra;
				}
			}
			obj3 = q6RLm.db_lccsams_connection;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jo81Es jo81Es);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (s1S5L)(object)q6RLm.db_lccsams_connection;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					tq6g = tq6g;
				}
				else
				{
					jo81Es = jo81Es;
					jo81Es = jo81Es;
				}
			}
		}
		try
		{
			jo81Es = jo81Es;
		}
		catch
		{
			while ((object)q6RLm.Default.db_lccsams_connection != null)
			{
				Sd5t6H sd5t6H = null;
			}
		}
		try
		{
			_ = (Sd5t6H)(object)q6RLm.Default;
		}
		finally
		{
			if ((UIntPtr)q6RLm.db_lccsams_connection == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)q6RLm.db_lccsams_connection;
			}
			else
			{
				try
				{
					_ = (s1S5L)(object)((q6RLm)(object)q6RLm.Default.db_lccsams_connection).db_lccsams_connection;
				}
				catch
				{
					jy86G = jy86G;
				}
			}
			goto IL_02bb;
		}
		IL_02bb:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e3S6Df e3S6Df);
		do
		{
			_ = (Fa35A)(object)q6RLm.Default;
			_ = (f3A8X)(object)q6RLm.Default;
			e3S6Df = e3S6Df;
			e3S6Df = e3S6Df;
			_ = (Sd5t6H)(object)q6RLm.Default;
		}
		while (obj3 != null);
		checked
		{
			while (true)
			{
				if (obj3 != null)
				{
					UIntPtr num8 = unchecked((UIntPtr)((q6RLm)null).db_lccsams_connection);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num8) - uIntPtr == 0)
					{
						_ = (Dx7r6)(object)q6RLm.Default;
					}
					else
					{
						m9X1Q m9X1Q = null;
					}
				}
				else if ((object)q6RLm.Default == null)
				{
					break;
				}
			}
			s1S5L = s1S5L;
			_ = (q9Z4Y)(object)q6RLm.Default;
			try
			{
				try
				{
					e3S6Df = (e3S6Df)(object)q6RLm.Default.db_lccsams_connection;
					Fa35A fa35A = (Fa35A)(object)q6RLm.db_lccsams_connection;
				}
				catch
				{
					_ = (Sd5t6H)(object)q6RLm.Default;
				}
			}
			catch
			{
				while ((object)q6RLm.db_lccsams_connection != null)
				{
					do
					{
						Sd5t6H sd5t6H = (Sd5t6H)(object)q6RLm.Default;
					}
					while ((object)((q6RLm)null).db_lccsams_connection != null);
				}
			}
			if (unchecked((nuint)(UIntPtr)q6RLm.Default.db_lccsams_connection) - uIntPtr == 0)
			{
				_ = (Jo81Es)(object)q6RLm.Default;
			}
		}
	}
}
