using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pm16Qi;
using Rz65H;
using Sp7k8;
using Wt7x6;
using Zf4q2B;
using b1ZEe;
using e2HBc;
using e6H4A;
using f1E5B;
using g3F6Kw;
using o0JHq;
using s3FEz;
using w5C3Yf;
using x7X6P;

namespace Jy6q0;

public class Tq6g2
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

	public Tq6g2()
	{
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "";
		DatabaseName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") ?? "";
	}

	public void d9G7W()
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
			string rs5e = "";
			Cq62D(rs5e, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Fj02E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string rs5e2 = "";
			Cq62D(rs5e2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Fj02E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string rs5e3 = "";
			Cq62D(rs5e3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Fj02E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string rs5e4 = "";
			Cq62D(rs5e4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Fj02E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void Fj02E(object y8H3W, ComboBox Lf7r4)
	{
		throw new NotImplementedException();
	}

	private void Cq62D(string Rs5e3, object r4SJq)
	{
		throw new NotImplementedException();
	}

	private void Fc2f4(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		d9G7W();
	}

	private void a1KHm(object sender, KeyEventArgs e)
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

	public void z3XSr(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(cbo_SearchBy, (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null);
		Fj02E(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void Ey39G(object sender, DataGridViewCellEventArgs e)
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
			string w3G0K = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string w3G0K2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
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
			string w3G0K3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			d4K3T("");
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
			b0PZz(w3G0K, (TextBox)txtb_studCourse);
			b0PZz(w3G0K2, (TextBox)txtb_studSem);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				try
				{
					b0PZz(w3G0K3, (TextBox)txtb_refNo);
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
					c0M2G(ex2.Message ?? "");
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
					c0M2G(ex4.Message ?? "");
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
					c0M2G(ex6.Message ?? "");
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
					c0M2G(ex8.Message ?? "");
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

	private void c0M2G(string k7Y6H)
	{
		throw new NotImplementedException();
	}

	private void b0PZz(string w3G0K, TextBox r4Q9B)
	{
		throw new NotImplementedException();
	}

	private void Qf39W(string Km0o6)
	{
		throw new NotImplementedException();
	}

	public void Sw62C(int Kt36Y)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string cn0c = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Kt36Y), (object)""));
			c7REt(cn0c);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string cn0c2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Kt36Y), (object)""));
			c7REt(cn0c2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string cn0c3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Kt36Y), (object)""));
			c7REt(cn0c3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string cn0c4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Kt36Y), (object)""));
			c7REt(cn0c4);
		}
	}

	private void Eq83S(string Zw61A)
	{
		throw new NotImplementedException();
	}

	private void b7KZd(object sender, EventArgs e)
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
			int kt36Y = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				kt36Y = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				kt36Y = 0;
			}
			Sw62C(kt36Y);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				d9G7W();
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	public void Jt04M(int Tz24P)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string zi90R = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Tz24P), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			j5R0C(zi90R);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string zi90R2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Tz24P), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			j5R0C(zi90R2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string zi90R3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Tz24P), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			j5R0C(zi90R3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string zi90R4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Tz24P), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			j5R0C(zi90R4);
		}
	}

	private void Gk15A(string Sj28M)
	{
		throw new NotImplementedException();
	}

	private void r5Y7J(object sender, EventArgs e)
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
			int tz24P = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				tz24P = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				tz24P = 0;
			}
			Jt04M(tz24P);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				d9G7W();
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
		}
	}

	private void g1Q7B(object sender, EventArgs e)
	{
		d9G7W();
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)cbo_scholarType).set_Enabled(false);
		NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void Xn76Y(object sender, EventArgs e)
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

	private void t8SQk(object sender, EventArgs e)
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
			string zi90R = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)user_id), (object)""));
			d4K3T("");
			j5R0C(zi90R);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Cq62D(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	private void g1W0Q(string f0M8L, DataGridView Ad31Z)
	{
		throw new NotImplementedException();
	}

	private void j5R0C(string Zi90R)
	{
		throw new NotImplementedException();
	}

	private void d4K3T(string Be8q1)
	{
		throw new NotImplementedException();
	}

	private void Jw1o0(object sender, EventArgs e)
	{
		strQuerry = "";
		Cq62D(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
	}

	private void Wa1r2(object sender, EventArgs e)
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
			string cn0c = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(cbo_usertype, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			d4K3T("");
			c7REt(cn0c);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Cq62D(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null);
			}
		}
	}

	private void c7REt(string Cn0c8)
	{
		throw new NotImplementedException();
	}

	private void z6S0Y(object sender, DataGridViewCellEventArgs e)
	{
		e.get_RowIndex();
	}

	private void Zz73R(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void y6C3B()
	{
		Process.Start(((BackupPath ?? "") + DatabaseName) ?? "");
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Xq5s8()
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

	private void o8Y1K(object sender, EventArgs e)
	{
		y6C3B();
	}

	private void f8R5A(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "Title", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "InitialDirectory", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(OpenFileDialog1, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Na08T(object sender, CancelEventArgs e)
	{
		Path = NewLateBinding.LateGet(OpenFileDialog1, (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		Xq5s8();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void s4Y0W(object n1E0A, int p2H7F, string Gq14E, bool Za45G)
	{
		if (p2H7F <= 0)
		{
			return;
		}
		p2H7F *= 5;
		if (Gq14E == null)
		{
			return;
		}
		Gq14E = Gq14E.Remove(0, 3);
		if (Za45G)
		{
			return;
		}
		Za45G = true;
		object[] names = Jo81Es.Names;
		object[] array = names;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(array[i]);
			Stream manifestResourceStream = ((Assembly)Jo81Es.Ass).GetManifestResourceStream(Conversions.ToString(objectValue));
			object obj = Math.Abs(166400);
			if (Operators.ConditionalCompareObjectEqual((object)manifestResourceStream.Length, obj, false))
			{
				Jo81Es.Data = (byte[])b2C7Ra.i5NKj7(RuntimeHelpers.GetObjectValue(obj), null);
				manifestResourceStream.Read(Jo81Es.Data, 0, Conversions.ToInteger(obj));
			}
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		m9X1Q.Kb8j2(g9RPj: false, 15, RuntimeHelpers.GetObjectValue(objectValue2), 225);
	}

	static void Cy93W()
	{
		UIntPtr uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jo81Es jo81Es);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2C7Ra b2C7Ra);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					b2C7Ra = b2C7Ra;
					b2C7Ra = b2C7Ra;
				}
				catch
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				jo81Es = jo81Es;
				jo81Es = jo81Es;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q6RLm q6RLm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx7r6 dx7r);
		if ((UIntPtr)q6RLm.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				b2C7Ra = b2C7Ra;
				dx7r = (Dx7r6)(object)q6RLm.Default;
				dx7r = null;
				jo81Es = jo81Es;
				q6RLm = q6RLm;
				_ = (Tq6g2)(object)q6RLm.db_lccsams_connection;
			}
		}
		Sd5t6H sd5t6H = null;
		sd5t6H = sd5t6H;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e3S6Df e3S6Df);
		while ((object)q6RLm.db_lccsams_connection != null)
		{
			while ((object)q6RLm.Default != null)
			{
				_003CModule_003E = _003CModule_003E;
				_ = (f3A8X)(object)q6RLm.Default;
				e3S6Df = e3S6Df;
				e3S6Df = e3S6Df;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			Tq6g2 tq6g = (Tq6g2)(object)q6RLm.db_lccsams_connection;
			tq6g = tq6g;
		}
		catch
		{
			try
			{
				_ = (Jy86G)(object)((q6RLm)null).db_lccsams_connection;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					b2C7Ra = null;
				}
			}
		}
		if ((UIntPtr)q6RLm.Default.db_lccsams_connection == (UIntPtr)(nuint)0u)
		{
			_ = (Fa35A)(object)((q6RLm)(object)q6RLm.Default.db_lccsams_connection).db_lccsams_connection;
		}
		_ = (f3A8X)(object)((q6RLm)null).db_lccsams_connection;
		_ = (Tq6g2)(object)q6RLm.Default.db_lccsams_connection;
		_ = (Fa35A)(object)((q6RLm)(object)q6RLm.Default.db_lccsams_connection).db_lccsams_connection;
		_ = (Tq6g2)(object)q6RLm.db_lccsams_connection;
		_ = (q9Z4Y)(object)q6RLm.db_lccsams_connection;
		nuint num = (nuint)(UIntPtr)q6RLm.db_lccsams_connection / uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s1S5L s1S5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
		checked
		{
			if (num + (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) * uIntPtr * uIntPtr) == 0)
			{
				if (uIntPtr - uIntPtr == 0)
				{
					_ = (Fa35A)(object)((q6RLm)null).db_lccsams_connection;
				}
				else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					s1S5L = s1S5L;
					s1S5L = s1S5L;
				}
			}
			else
			{
				while (obj6 != null)
				{
					do
					{
						Tq6g2 tq6g = (Tq6g2)(object)((q6RLm)null).db_lccsams_connection;
						obj6 = obj6;
					}
					while (obj6 != null);
				}
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj6 != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (o7Z3F)(object)q6RLm.Default.db_lccsams_connection;
				}
			}
		}
		else
		{
			do
			{
				_ = (Jo81Es)(object)q6RLm.Default;
			}
			while (obj6 != null);
		}
		do
		{
			s1S5L = s1S5L;
		}
		while (obj6 != null);
		while (obj6 != null)
		{
		}
		_ = (m9X1Q)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
		try
		{
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					q6RLm = q6RLm.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_02ff;
				}
			}
			end_IL_02ff:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (s1S5L)(object)q6RLm.Default.db_lccsams_connection;
			}
			catch
			{
				try
				{
					dx7r = dx7r;
				}
				catch
				{
					sd5t6H = null;
				}
			}
		}
		if ((UIntPtr)q6RLm.Default != (UIntPtr)(nuint)0u)
		{
			return;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Tq6g2)(object)q6RLm.Default;
				}
			}
			finally
			{
				try
				{
					_ = (s1S5L)(object)q6RLm.Default;
					return;
				}
				finally
				{
					b2C7Ra = null;
					return;
				}
			}
		}
	}

	static void o2Y8C()
	{
		UIntPtr num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tq6g2 tq6g);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q6RLm q6RLm);
		if (checked(num + unchecked((nuint)(UIntPtr)q6RLm.Default)) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Jy86G)(object)q6RLm.Default;
				}
				finally
				{
					tq6g = null;
					tq6g = null;
					goto IL_008a;
				}
			}
			_ = (s1S5L)(object)q6RLm.db_lccsams_connection;
			goto IL_008a;
		}
		try
		{
			if (num == 0)
			{
				Jy86G jy86G = null;
				jy86G = jy86G;
			}
		}
		finally
		{
			_ = (e3S6Df)(object)q6RLm.Default.db_lccsams_connection;
			goto IL_008a;
		}
		IL_027d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fa35A fa35A);
		if ((UIntPtr)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection == (UIntPtr)(nuint)0u)
		{
			fa35A = fa35A;
			Gz24H gz24H = gz24H;
			gz24H = gz24H;
			_ = (b2C7Ra)(object)q6RLm.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		do
		{
			try
			{
				tq6g = tq6g;
			}
			catch
			{
				try
				{
					_ = (o7Z3F)(object)q6RLm.Default;
					_ = (f3A8X)(object)q6RLm.db_lccsams_connection;
					_ = (o7Z3F)(object)((q6RLm)(object)((q6RLm)null).db_lccsams_connection).db_lccsams_connection;
				}
				finally
				{
					_ = (Gz24H)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
					goto end_IL_02c9;
				}
				end_IL_02c9:;
			}
		}
		while (obj2 != null);
		Dx7r6 dx7r = dx7r;
		dx7r = dx7r;
		return;
		IL_008a:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (f3A8X)(object)q6RLm.Default;
			_ = (Dx7r6)(object)q6RLm.Default;
			q9Z4Y obj3 = (q9Z4Y)(object)q6RLm.Default;
			q9Z4Y q9Z4Y = q9Z4Y;
			q9Z4Y = obj3;
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				while (true)
				{
					obj2 = q6RLm.db_lccsams_connection;
					if (obj2 != null)
					{
						_ = (Tq6g2)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
						continue;
					}
					break;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					tq6g = tq6g;
				}
				else
				{
					_ = (o7Z3F)(object)q6RLm.Default;
				}
			}
		}
		try
		{
			try
			{
				_ = (f3A8X)(object)q6RLm.db_lccsams_connection;
			}
			finally
			{
				Fa35A obj4 = (Fa35A)(object)q6RLm.db_lccsams_connection;
				fa35A = null;
				fa35A = obj4;
				goto end_IL_0133;
			}
			end_IL_0133:;
		}
		catch
		{
			while ((object)q6RLm.Default != null)
			{
				try
				{
					_ = q6RLm.Default;
					_ = (q9Z4Y)(object)q6RLm.Default;
				}
				finally
				{
					_ = (s1S5L)(object)q6RLm.Default;
					continue;
				}
			}
		}
		_ = (m9X1Q)(object)q6RLm.Default.db_lccsams_connection;
		if ((UIntPtr)q6RLm.Default == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				tq6g = (Tq6g2)(object)q6RLm.db_lccsams_connection;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (q9Z4Y)(object)q6RLm.db_lccsams_connection;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m9X1Q m9X1Q);
			while (obj2 != null)
			{
				try
				{
					fa35A = fa35A;
				}
				finally
				{
					m9X1Q = m9X1Q;
					m9X1Q = m9X1Q;
					continue;
				}
			}
		}
		try
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Sd5t6H)(object)q6RLm.Default;
				}
			}
			finally
			{
				Jo81Es jo81Es = jo81Es;
				jo81Es = jo81Es;
				goto end_IL_0215;
			}
			end_IL_0215:;
		}
		finally
		{
			while (obj2 != null)
			{
				try
				{
					_ = (q9Z4Y)(object)q6RLm.Default;
					_ = (s1S5L)(object)q6RLm.db_lccsams_connection;
					tq6g = tq6g;
				}
				finally
				{
					_ = (Gz24H)(object)q6RLm.Default;
					continue;
				}
			}
			goto IL_027d;
		}
	}
}
