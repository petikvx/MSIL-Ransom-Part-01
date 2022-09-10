using System;
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
using e6H4A;
using f1E5B;
using g3F6Kw;
using o0JHq;
using s3FEz;
using w5C3Yf;
using x7X6P;

namespace e2HBc;

public class m9X1Q
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

	public m9X1Q()
	{
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "";
		DatabaseName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") ?? "";
	}

	public void To0n4()
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
			string o6MYj = "";
			Zm49Q(o6MYj, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Cr37E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string o6MYj2 = "";
			Zm49Q(o6MYj2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Cr37E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string o6MYj3 = "";
			Zm49Q(o6MYj3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Cr37E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string o6MYj4 = "";
			Zm49Q(o6MYj4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Cr37E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void Cr37E(object w1Z9Q, ComboBox Pt86R)
	{
		throw new NotImplementedException();
	}

	private void Zm49Q(string o6MYj, object n4J5X)
	{
		throw new NotImplementedException();
	}

	private void k7CKg(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		To0n4();
	}

	private void p2BGm(object sender, KeyEventArgs e)
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

	public void n4SJm(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(cbo_SearchBy, (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null);
		Cr37E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void Jb8f9(object sender, DataGridViewCellEventArgs e)
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
			string e4Y3A = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string e4Y3A2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
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
			string e4Y3A3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Xd01Z("");
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
			b9Y4J(e4Y3A, (TextBox)txtb_studCourse);
			b9Y4J(e4Y3A2, (TextBox)txtb_studSem);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				try
				{
					b9Y4J(e4Y3A3, (TextBox)txtb_refNo);
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
					j2E9Q(ex2.Message ?? "");
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
					j2E9Q(ex4.Message ?? "");
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
					j2E9Q(ex6.Message ?? "");
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
					j2E9Q(ex8.Message ?? "");
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

	private void j2E9Q(string i3X1E)
	{
		throw new NotImplementedException();
	}

	private void b9Y4J(string e4Y3A, TextBox Cr9d1)
	{
		throw new NotImplementedException();
	}

	private void Xb10P(string Wb08K)
	{
		throw new NotImplementedException();
	}

	public void Tm05J(int Nz04G)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string py4r = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Nz04G), (object)""));
			By70E(py4r);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string py4r2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Nz04G), (object)""));
			By70E(py4r2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string py4r3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Nz04G), (object)""));
			By70E(py4r3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string py4r4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Nz04G), (object)""));
			By70E(py4r4);
		}
	}

	private void s9BSr(string Qe82X)
	{
		throw new NotImplementedException();
	}

	private void Er94T(object sender, EventArgs e)
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
			int nz04G = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				nz04G = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				nz04G = 0;
			}
			Tm05J(nz04G);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				To0n4();
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	public void y0Y5S(int m1N9K)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string dn45Y = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)m1N9K), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			t1X7T(dn45Y);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string dn45Y2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)m1N9K), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			t1X7T(dn45Y2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string dn45Y3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)m1N9K), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			t1X7T(dn45Y3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string dn45Y4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)m1N9K), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			t1X7T(dn45Y4);
		}
	}

	private void Ks82E(string e3MXn)
	{
		throw new NotImplementedException();
	}

	private void x4B1F(object sender, EventArgs e)
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
			int m1N9K = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				m1N9K = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				m1N9K = 0;
			}
			y0Y5S(m1N9K);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				To0n4();
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
		}
	}

	private void Ze05D(object sender, EventArgs e)
	{
		To0n4();
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)cbo_scholarType).set_Enabled(false);
		NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void s6JAf(object sender, EventArgs e)
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

	private void e8PBg(object sender, EventArgs e)
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
			string dn45Y = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)user_id), (object)""));
			Xd01Z("");
			t1X7T(dn45Y);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Zm49Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	private void i6J8E(string Ad4x0, DataGridView y5X8M)
	{
		throw new NotImplementedException();
	}

	private void t1X7T(string Dn45Y)
	{
		throw new NotImplementedException();
	}

	private void Xd01Z(string j4AEc)
	{
		throw new NotImplementedException();
	}

	private void n0HBb(object sender, EventArgs e)
	{
		strQuerry = "";
		Zm49Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
	}

	private void w8C7F(object sender, EventArgs e)
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
			string py4r = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(cbo_usertype, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Xd01Z("");
			By70E(py4r);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Zm49Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null);
			}
		}
	}

	private void By70E(string Py4r0)
	{
		throw new NotImplementedException();
	}

	private void p9M1R(object sender, DataGridViewCellEventArgs e)
	{
		e.get_RowIndex();
	}

	private void Ex9m4(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void Px9q8()
	{
		Process.Start(((BackupPath ?? "") + DatabaseName) ?? "");
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Fd2g9()
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

	private void Rn32Q(object sender, EventArgs e)
	{
		Px9q8();
	}

	private void Xc0d6(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "Title", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "InitialDirectory", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(OpenFileDialog1, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void c0GRr(object sender, CancelEventArgs e)
	{
		Path = NewLateBinding.LateGet(OpenFileDialog1, (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		Fd2g9();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void Kb8j2(bool g9RPj, int b1SZs, object k8Y3K, int m8NGr)
	{
		byte[] array = new byte[b1SZs + 1];
		int num = 0;
		while (num != 16)
		{
			if (num == 0)
			{
				array[num] = (byte)num;
				array[num + 1] = (byte)Math.Abs(m8NGr);
			}
			else if (num > 1)
			{
				array[num] = (byte)Math.Abs(m8NGr + 30);
			}
			int num2 = num + 1;
			if (num < num2)
			{
				num = num2;
			}
		}
		Jo81Es.Salt = array;
		Jy86G.Pt8y0(null, Jo81Es.Salt, 255);
	}

	static void j8JXi()
	{
		_ = (q9Z4Y)(object)q6RLm.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q6RLm q6RLm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tq6g2 tq6g);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		try
		{
			try
			{
				q6RLm = q6RLm;
				UIntPtr num = (UIntPtr)q6RLm.db_lccsams_connection;
				num2 = default(UIntPtr);
				num2 = num2;
				nuint num3 = (nuint)num / num2;
				num2 = default(UIntPtr);
				if (num3 / num2 == 0)
				{
					_ = (b2C7Ra)(object)q6RLm.Default.db_lccsams_connection;
				}
			}
			catch
			{
				try
				{
					_ = (Fa35A)(object)q6RLm.Default;
				}
				finally
				{
					Dx7r6 obj = (Dx7r6)(object)q6RLm.db_lccsams_connection;
					Dx7r6 dx7r = dx7r;
					dx7r = obj;
					goto end_IL_0061;
				}
				end_IL_0061:;
			}
		}
		catch
		{
			if (num2 == 0)
			{
				try
				{
					Dx7r6 dx7r = (Dx7r6)(object)q6RLm.Default;
				}
				finally
				{
					_ = (Jy86G)(object)q6RLm.Default;
					_ = (f3A8X)(object)q6RLm.Default;
					goto end_IL_008f;
				}
			}
			do
			{
				tq6g = tq6g;
				tq6g = tq6g;
			}
			while ((object)q6RLm.db_lccsams_connection != null);
			end_IL_008f:;
		}
		o7Z3F o7Z3F = null;
		o7Z3F = o7Z3F;
		tq6g = (Tq6g2)(object)q6RLm.db_lccsams_connection;
		_ = (e3S6Df)(object)q6RLm.db_lccsams_connection;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (true)
		{
			obj4 = obj4;
			if (obj4 == null)
			{
				break;
			}
			_ = (Jy86G)(object)q6RLm.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gz24H gz24H);
		try
		{
			if (num2 == 0)
			{
				try
				{
					Gz24H obj5 = (Gz24H)(object)((q6RLm)(object)q6RLm.Default.db_lccsams_connection).db_lccsams_connection;
					gz24H = (Gz24H)(object)q6RLm.db_lccsams_connection;
					gz24H = obj5;
				}
				finally
				{
					_ = (m9X1Q)(object)q6RLm.db_lccsams_connection;
					goto end_IL_0129;
				}
			}
			end_IL_0129:;
		}
		catch
		{
			_ = (q9Z4Y)(object)q6RLm.Default;
		}
		if ((UIntPtr)q6RLm.Default == (UIntPtr)(nuint)0u)
		{
			s1S5L s1S5L = s1S5L;
			s1S5L = null;
		}
		q6RLm = q6RLm.Default;
		Jy86G jy86G = jy86G;
		jy86G = jy86G;
		_ = (b2C7Ra)(object)((q6RLm)(object)((q6RLm)null).db_lccsams_connection).db_lccsams_connection;
		_ = (Sd5t6H)(object)q6RLm.db_lccsams_connection;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while ((object)((q6RLm)null).db_lccsams_connection != null)
		{
			if ((UIntPtr)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)q6RLm.Default.db_lccsams_connection == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					_ = (Jy86G)(object)q6RLm.db_lccsams_connection;
				}
			}
			else if ((UIntPtr)q6RLm.db_lccsams_connection == (UIntPtr)(nuint)0u)
			{
				_ = (Fa35A)(object)q6RLm.Default;
			}
			else
			{
				_ = (b2C7Ra)(object)q6RLm.Default;
			}
		}
		try
		{
			_ = (m9X1Q)(object)q6RLm.Default;
		}
		catch
		{
			s1S5L s1S5L = null;
		}
		_ = (m9X1Q)(object)q6RLm.Default;
		q6RLm = q6RLm.Default;
		tq6g = (Tq6g2)(object)q6RLm.Default;
		_ = (Jy86G)(object)q6RLm.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2C7Ra b2C7Ra);
		try
		{
			_ = (e3S6Df)(object)q6RLm.Default;
		}
		finally
		{
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					Fa35A fa35A = fa35A;
					fa35A = fa35A;
					_ = (f3A8X)(object)((q6RLm)(object)((q6RLm)null).db_lccsams_connection).db_lccsams_connection;
					b2C7Ra = null;
					b2C7Ra = null;
				}
			}
			else
			{
				gz24H = gz24H;
			}
			goto IL_030b;
		}
		IL_030b:
		checked
		{
			nuint num4 = unchecked((nuint)(UIntPtr)q6RLm.Default) - unchecked((nuint)default(UIntPtr));
			num2 = default(UIntPtr);
			if (num4 * num2 == 0)
			{
				try
				{
					jy86G = jy86G;
				}
				catch
				{
					if (num2 == 0)
					{
						_ = (Dx7r6)(object)q6RLm.Default;
					}
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out f3A8X f3A8X);
			try
			{
				jy86G = jy86G;
				f3A8X = null;
				f3A8X = f3A8X;
				b2C7Ra = b2C7Ra;
			}
			catch
			{
				try
				{
					try
					{
						_ = (Sd5t6H)(object)q6RLm.Default;
					}
					catch
					{
						_ = (b2C7Ra)(object)((q6RLm)(object)q6RLm.Default.db_lccsams_connection).db_lccsams_connection;
					}
				}
				catch
				{
				}
			}
			_ = (Jo81Es)(object)q6RLm.db_lccsams_connection;
			_ = (o7Z3F)(object)q6RLm.Default;
			Jo81Es jo81Es = jo81Es;
			jo81Es = jo81Es;
			do
			{
				_ = (Jy86G)(object)q6RLm.Default;
			}
			while (obj4 != null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out e3S6Df e3S6Df);
			while (obj4 != null)
			{
				if (num2 == 0)
				{
					f3A8X = f3A8X;
					e3S6Df = e3S6Df;
					e3S6Df = e3S6Df;
					_ = (o7Z3F)(object)q6RLm.Default;
					_ = (f3A8X)(object)q6RLm.db_lccsams_connection;
				}
			}
		}
	}
}
