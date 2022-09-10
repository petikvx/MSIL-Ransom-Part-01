using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jy6q0;
using Microsoft.VisualBasic.CompilerServices;
using Pm16Qi;
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

namespace Rz65H;

public class Gz24H
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

	public Gz24H()
	{
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "";
		DatabaseName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") ?? "";
	}

	public void z5WCp()
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
			string xb96D = "";
			Bx24Q(xb96D, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			x6P8Z(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string xb96D2 = "";
			Bx24Q(xb96D2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			x6P8Z(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string xb96D3 = "";
			Bx24Q(xb96D3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			x6P8Z(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
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
			string xb96D4 = "";
			Bx24Q(xb96D4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			x6P8Z(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void x6P8Z(object f9Z0H, ComboBox Ln0o5)
	{
		throw new NotImplementedException();
	}

	private void Bx24Q(string Xb96D, object Kj54S)
	{
		throw new NotImplementedException();
	}

	private void z7TCr(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		z5WCp();
	}

	private void t0LWe(object sender, KeyEventArgs e)
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

	public void Bs6w3(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(cbo_SearchBy, (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null);
		x6P8Z(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void g7FEz(object sender, DataGridViewCellEventArgs e)
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
			string j2T3Z = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string j2T3Z2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
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
			string j2T3Z3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			z0NJo("");
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
			Xx62K(j2T3Z, (TextBox)txtb_studCourse);
			Xx62K(j2T3Z2, (TextBox)txtb_studSem);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				try
				{
					Xx62K(j2T3Z3, (TextBox)txtb_refNo);
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
					Dg6r8(ex2.Message ?? "");
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
					Dg6r8(ex4.Message ?? "");
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
					Dg6r8(ex6.Message ?? "");
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
					Dg6r8(ex8.Message ?? "");
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

	private void Dg6r8(string r0N5Q)
	{
		throw new NotImplementedException();
	}

	private void Xx62K(string j2T3Z, TextBox z4PCr)
	{
		throw new NotImplementedException();
	}

	private void Bg6i4(string Ty3e2)
	{
		throw new NotImplementedException();
	}

	public void e8A9K(int q2X0N)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string p0K4P = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)q2X0N), (object)""));
			Wy4k8(p0K4P);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string p0K4P2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)q2X0N), (object)""));
			Wy4k8(p0K4P2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string p0K4P3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)q2X0N), (object)""));
			Wy4k8(p0K4P3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string p0K4P4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)q2X0N), (object)""));
			Wy4k8(p0K4P4);
		}
	}

	private void Bq0r1(string Bf08N)
	{
		throw new NotImplementedException();
	}

	private void Wj95E(object sender, EventArgs e)
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
			int q2X0N = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				q2X0N = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				q2X0N = 0;
			}
			e8A9K(q2X0N);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				z5WCp();
				NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	public void p2TYb(int Ye6w5)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			string w7BSi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_refNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ye6w5), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Rw1t6(w7BSi);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			string w7BSi2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ye6w5), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Rw1t6(w7BSi2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
		{
			string w7BSi3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ye6w5), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Rw1t6(w7BSi3);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo_SelectDept, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
		{
			string w7BSi4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)""), NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)Ye6w5), (object)""), NewLateBinding.LateGet(txtb_studid, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			Rw1t6(w7BSi4);
		}
	}

	private void w7KDi(string o7GSw)
	{
		throw new NotImplementedException();
	}

	private void Jt0w1(object sender, EventArgs e)
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
			int ye6w = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtb_ScholarAmnt, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_active, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				ye6w = 1;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rb_inactive, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				ye6w = 0;
			}
			p2TYb(ye6w);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				z5WCp();
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_refNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
		}
	}

	private void z5B3C(object sender, EventArgs e)
	{
		z5WCp();
		NewLateBinding.LateCall(txtb_ScholarAmnt, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)cbo_scholarType).set_Enabled(false);
		NewLateBinding.LateSet(txtb_ScholarAmnt, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_add, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
	}

	private void w2D3P(object sender, EventArgs e)
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

	private void o2B1Q(object sender, EventArgs e)
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
			string w7BSi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), (object)user_id), (object)""));
			z0NJo("");
			Rw1t6(w7BSi);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Bx24Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btn_update, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
		}
	}

	private void Aj8x2(string Sg03T, DataGridView q7YAe)
	{
		throw new NotImplementedException();
	}

	private void Rw1t6(string w7BSi)
	{
		throw new NotImplementedException();
	}

	private void z0NJo(string p5K9M)
	{
		throw new NotImplementedException();
	}

	private void Pt41T(object sender, EventArgs e)
	{
		strQuerry = "";
		Bx24Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
	}

	private void Em24W(object sender, EventArgs e)
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
			string p0K4P = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"", NewLateBinding.LateGet(txtb_name, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_Uname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(txtb_pass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""), NewLateBinding.LateGet(cbo_usertype, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
			z0NJo("");
			Wy4k8(p0K4P);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(txtb_name, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_Uname, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(txtb_pass, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(cbo_usertype, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null);
				Bx24Q(strQuerry, RuntimeHelpers.GetObjectValue(dg_users));
				NewLateBinding.LateSet(btnSave, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null);
			}
		}
	}

	private void Wy4k8(string p0K4P)
	{
		throw new NotImplementedException();
	}

	private void g3GWt(object sender, DataGridViewCellEventArgs e)
	{
		e.get_RowIndex();
	}

	private void Qd90S(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void As73B()
	{
		Process.Start(((BackupPath ?? "") + DatabaseName) ?? "");
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Dz72A()
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

	private void y1F0B(object sender, EventArgs e)
	{
		As73B();
	}

	private void Jq0w8(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "Title", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OpenFileDialog1, (Type)null, "InitialDirectory", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(OpenFileDialog1, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void j4B9X(object sender, CancelEventArgs e)
	{
		Path = NewLateBinding.LateGet(OpenFileDialog1, (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		Dz72A();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static int Tq90N(int c9X7H, int c2Q3X, object Le29Y, object n2S5R, int r1AFw)
	{
		return r1AFw switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(Le29Y, Operators.NotObject(n2S5R)), Operators.AndObject(Operators.NotObject(Le29Y), n2S5R))), 
			1 => c9X7H % c2Q3X, 
			_ => 0, 
		};
	}

	static void r4F0M()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jy86G jy86G);
		while (obj != null)
		{
			try
			{
				obj = null;
			}
			catch
			{
				Jy86G obj2 = (Jy86G)(object)q6RLm.Default;
				jy86G = jy86G;
				jy86G = obj2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		q6RLm q6RLm;
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					q6RLm = q6RLm.Default;
					_ = (f3A8X)(object)q6RLm.db_lccsams_connection;
					e3S6Df e3S6Df = (e3S6Df)(object)q6RLm.Default;
					e3S6Df = e3S6Df;
				}
			}
		}
		finally
		{
			try
			{
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Jo81Es)(object)q6RLm.Default;
					_ = (Tq6g2)(object)q6RLm.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)q6RLm.Default;
				}
			}
			catch
			{
				UIntPtr num = (UIntPtr)((q6RLm)null).db_lccsams_connection;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) * uIntPtr == 0)
					{
						_ = (Fa35A)(object)q6RLm.Default;
					}
				}
			}
			goto IL_00d8;
		}
		IL_00d8:
		q6RLm = q6RLm.Default;
		checked
		{
			try
			{
				_ = (m9X1Q)(object)q6RLm.Default;
			}
			catch
			{
				nuint num2 = unchecked((nuint)(UIntPtr)q6RLm.db_lccsams_connection) * unchecked((nuint)(UIntPtr)q6RLm.Default) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (num2 * uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						Sd5t6H sd5t6H = sd5t6H;
						sd5t6H = sd5t6H;
					}
					else
					{
						Sd5t6H sd5t6H = null;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx7r6 dx7r);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gz24H gz24H);
		try
		{
			if (uIntPtr / (nuint)(UIntPtr)q6RLm.Default == 0)
			{
				_ = (s1S5L)(object)((q6RLm)null).db_lccsams_connection;
				_ = (Dx7r6)(object)q6RLm.db_lccsams_connection;
				_ = (q9Z4Y)(object)q6RLm.Default;
			}
			else
			{
				s1S5L s1S5L = s1S5L;
				s1S5L = null;
				q9Z4Y q9Z4Y = q9Z4Y;
				q9Z4Y = null;
			}
		}
		catch
		{
			try
			{
				_ = (Jy86G)(object)q6RLm.db_lccsams_connection;
				dx7r = null;
				dx7r = dx7r;
			}
			catch
			{
				gz24H = gz24H;
				gz24H = gz24H;
			}
			finally
			{
				while ((object)q6RLm.Default.db_lccsams_connection != null)
				{
					_ = (q9Z4Y)(object)q6RLm.Default;
				}
				goto end_IL_01a2;
			}
			end_IL_01a2:;
		}
		if ((UIntPtr)((q6RLm)null).db_lccsams_connection == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0)
			{
				gz24H = null;
			}
			else
			{
				try
				{
					_ = (Fa35A)(object)((q6RLm)null).db_lccsams_connection;
				}
				catch
				{
					dx7r = dx7r;
				}
			}
		}
		try
		{
			if ((UIntPtr)q6RLm.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					gz24H = (Gz24H)(object)q6RLm.Default.db_lccsams_connection;
				}
				finally
				{
					s1S5L s1S5L = null;
					goto end_IL_0234;
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out f3A8X f3A8X);
			while ((object)q6RLm.Default != null)
			{
				_ = (f3A8X)(object)q6RLm.Default.db_lccsams_connection;
				f3A8X = f3A8X;
				f3A8X = f3A8X;
				_ = (e3S6Df)(object)q6RLm.Default;
			}
			end_IL_0234:;
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m9X1Q m9X1Q);
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (o7Z3F)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
				}
				catch
				{
					_ = (b2C7Ra)(object)q6RLm.db_lccsams_connection;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (o7Z3F)(object)q6RLm.db_lccsams_connection;
				}
				finally
				{
					e3S6Df e3S6Df = null;
					m9X1Q = m9X1Q;
					m9X1Q = null;
					continue;
				}
			}
			while (obj != null);
		}
		_ = (o7Z3F)(object)q6RLm.Default;
		while (obj != null)
		{
			q6RLm = null;
		}
		checked
		{
			while (obj != null)
			{
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num4 = uIntPtr - uIntPtr;
				UIntPtr num5 = unchecked((UIntPtr)q6RLm.db_lccsams_connection);
				uIntPtr = default(UIntPtr);
				if (num3 * (num4 + (unchecked((nuint)num5) + (uIntPtr - uIntPtr))) == 0)
				{
					gz24H = gz24H;
					gz24H = null;
					_ = (Jo81Es)(object)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection;
				}
				else
				{
					_ = (Jo81Es)(object)q6RLm.Default;
					_ = (Jo81Es)(object)q6RLm.Default;
				}
			}
			o7Z3F o7Z3F = (o7Z3F)(object)q6RLm.Default;
			o7Z3F = o7Z3F;
			_ = (b2C7Ra)(object)((q6RLm)null).db_lccsams_connection;
			nuint num6 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num6 - (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * uIntPtr)) == 0)
			{
				unchecked
				{
					if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((q6RLm)(object)q6RLm.db_lccsams_connection).db_lccsams_connection != 0)
					{
						_ = (o7Z3F)(object)q6RLm.Default;
					}
				}
			}
			else
			{
				if (uIntPtr == 0)
				{
					try
					{
						_ = (_003CModule_003E)(object)q6RLm.Default;
					}
					finally
					{
						_ = (m9X1Q)(object)q6RLm.Default;
						goto IL_04c0;
					}
				}
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					Fa35A fa35A = (Fa35A)(object)q6RLm.db_lccsams_connection;
					fa35A = fa35A;
				}
				else
				{
					q6RLm = q6RLm;
					_ = (b2C7Ra)(object)q6RLm.Default;
					_ = (Jo81Es)(object)q6RLm.Default;
				}
			}
			goto IL_04c0;
		}
		IL_04c0:
		m9X1Q = m9X1Q;
		gz24H = gz24H;
	}

	static void Xd94R()
	{
		_ = (o7Z3F)(object)q6RLm.Default;
		q6RLm q6RLm = (q6RLm)(object)q6RLm.db_lccsams_connection;
		if ((UIntPtr)q6RLm.db_lccsams_connection == (UIntPtr)(nuint)0u)
		{
			_ = (o7Z3F)(object)((q6RLm)null).db_lccsams_connection;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					Tq6g2 obj = (Tq6g2)(object)q6RLm.Default;
					Tq6g2 tq6g = tq6g;
					tq6g = obj;
				}
			}
		}
		catch
		{
			if ((UIntPtr)q6RLm.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (f3A8X)(object)q6RLm.Default;
				}
				catch
				{
					q6RLm = (q6RLm)(object)((q6RLm)(object)((q6RLm)null).db_lccsams_connection).db_lccsams_connection;
				}
			}
			else
			{
				try
				{
					_ = (Tq6g2)(object)q6RLm.Default;
				}
				catch
				{
					_ = (m9X1Q)(object)q6RLm.db_lccsams_connection;
				}
			}
		}
		q6RLm = null;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Dx7r6)(object)q6RLm.Default;
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)q6RLm.Default) * (uIntPtr - unchecked((nuint)(UIntPtr)q6RLm.Default.db_lccsams_connection)) == 0)
					{
						_ = (e3S6Df)(object)q6RLm.db_lccsams_connection;
					}
					goto IL_0126;
				}
			}
			goto IL_0126;
		}
		IL_017f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
		do
		{
			e3S6Df e3S6Df = (e3S6Df)(object)q6RLm.Default;
			obj6 = obj6;
		}
		while (obj6 != null);
		_ = (f3A8X)(object)q6RLm.Default;
		_ = (_003CModule_003E)(object)q6RLm.Default;
		nuint num = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num + uIntPtr) != 0)
		{
			return;
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Tq6g2)(object)((q6RLm)null).db_lccsams_connection;
			}
			else
			{
				q6RLm = null;
			}
			return;
		}
		finally
		{
			try
			{
				q6RLm = null;
				return;
			}
			catch
			{
				_ = (Tq6g2)(object)q6RLm.Default;
				return;
			}
		}
		IL_0126:
		try
		{
			_ = (Dx7r6)(object)q6RLm.Default;
			Jy86G jy86G = (Jy86G)(object)((q6RLm)null).db_lccsams_connection;
			jy86G = jy86G;
			_ = (s1S5L)(object)q6RLm.db_lccsams_connection;
			Jo81Es jo81Es = jo81Es;
			jo81Es = null;
		}
		finally
		{
			e3S6Df e3S6Df = (e3S6Df)(object)q6RLm.Default;
			e3S6Df = e3S6Df;
			goto IL_017f;
		}
	}
}
