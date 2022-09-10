using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using At;
using Fb3;
using Fe8;
using Gr8;
using Jt8;
using Lx6;
using Microsoft.VisualBasic.CompilerServices;
using Mp;
using Mp4;
using Mq9t1R;
using Pi76L;
using Qs8;
using Tn5q2;
using Xb0;
using Xp2;
using Yy4;
using d5;
using d6J;
using f1;
using f4YBe3;
using g5L;
using i6E;
using j3F;
using j7;
using j7S;
using k2T;
using m5Q;
using o5Q;
using p9E;
using q7B;
using t2M7Z;
using w1P;
using w6;
using w9J;
using z2R;

namespace e5J;

public class Ts9
{
	private object frm_sP;

	private object procPayment;

	private object frm_sA;

	private object frm_sL;

	private object frm_sTR;

	private object frm_mY;

	private object frm_mP;

	private object frm_U;

	private object frm_sSg;

	private bool isCollapsed;

	private bool isCollapsed2;

	public int studIdClick;

	private object cashier_name;

	private int current_menu;

	private int manageFees;

	private int manageSY;

	private object dlg_logout;

	private object form_login;

	private object pnlMContainer;

	private object lbl_title;

	private object btn_manageP;

	private object btn_menuStudentsList;

	private object btn_menuStudentsAccount;

	private object btn_menuMSY;

	private object btn_colRprt;

	private object btn_menuMP;

	private object btn_menuMU;

	private object BunifuFlatButton4;

	private object PictureBox2;

	private object Label4;

	private object Label3;

	private object Panel3;

	private object Panel2;

	private object Timer1;

	private object Timer2;

	private object pnl_subcontainer;

	private object BunifuFlatButton6;

	private object BunifuFlatButton9;

	private object btn_sTransactionR;

	private object BunifuFlatButton8;

	private object BunifuFlatButton5;

	private object BunifuFlatButton3;

	private object BunifuFlatButton1;

	public DialogResult DialogResult { get; set; }

	public Ts9()
	{
		frm_sP = RuntimeHelpers.GetObjectValue(new object());
		frm_sA = RuntimeHelpers.GetObjectValue(new object());
		frm_sL = RuntimeHelpers.GetObjectValue(new object());
		frm_sTR = RuntimeHelpers.GetObjectValue(new object());
		frm_mY = RuntimeHelpers.GetObjectValue(new object());
		frm_mP = RuntimeHelpers.GetObjectValue(new object());
		frm_U = RuntimeHelpers.GetObjectValue(new object());
		frm_sSg = RuntimeHelpers.GetObjectValue(new object());
		isCollapsed = true;
		isCollapsed2 = true;
	}

	private void Ff1(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)1;
		x1Z();
	}

	private void n6P(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)2;
		x1Z();
	}

	private void x1Z()
	{
		throw new NotImplementedException();
	}

	public void y2F(UserControl i1X, object Bg1)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = i1X;
			((Control)val).set_Dock((DockStyle)5);
			object obj = NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[1] { val };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				val = (UserControl)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(UserControl));
			}
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Bg1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			q4E(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void q4E(string s9D)
	{
		throw new NotImplementedException();
	}

	public void Lz0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		m6K((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(btn_manageP));
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "lbl_cashier", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(cashier_name, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		d1E((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public void d1E(TabControl Ty1)
	{
		switch (Ty1.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	public void Xy3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		m6K((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(btn_menuStudentsList));
		if (Rj8() == 1)
		{
			Xy1((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (Rj8() == 2)
		{
			Xy1((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private int Rj8()
	{
		throw new NotImplementedException();
	}

	public void Xy1(TabControl f9F)
	{
		switch (f9F.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	public void Nm4(TabControl x0K)
	{
		studIdClick = x0K.get_SelectedIndex();
		switch (x0K.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sA, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sA, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sA, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sA, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	public void Qj6(TabControl Zg0)
	{
		switch (Zg0.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sSg, (Type)null, "cbo_SelectDept", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sSg, (Type)null, "cbo_SelectDept", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sSg, (Type)null, "cbo_SelectDept", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sSg, (Type)null, "cbo_SelectDept", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	public void s1W(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			switch (current_menu)
			{
			default:
				MessageBox.Show("Please select a student first");
				break;
			case 2:
				m6K((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				Nm4((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
				switch (studIdClick)
				{
				default:
					MessageBox.Show("");
					break;
				case 0:
				{
					object obj19 = frm_sA;
					object[] obj20 = new object[2] { sender, e };
					object[] array = obj20;
					bool[] obj21 = new bool[2] { true, true };
					bool[] array2 = obj21;
					NewLateBinding.LateCall(obj19, (Type)null, "txtb_studAcct_ID_Click", obj20, (string[])null, (Type[])null, obj21, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 1:
				{
					object obj16 = frm_sA;
					object[] obj17 = new object[2] { sender, e };
					object[] array = obj17;
					bool[] obj18 = new bool[2] { true, true };
					bool[] array2 = obj18;
					NewLateBinding.LateCall(obj16, (Type)null, "txtb_eStud_id_Click", obj17, (string[])null, (Type[])null, obj18, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 2:
				{
					object obj22 = frm_sA;
					object[] obj23 = new object[2] { sender, e };
					object[] array = obj23;
					bool[] obj24 = new bool[2] { true, true };
					bool[] array2 = obj24;
					NewLateBinding.LateCall(obj22, (Type)null, "txtb_sStud_id_Click", obj23, (string[])null, (Type[])null, obj24, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 3:
				{
					object obj13 = frm_sA;
					object[] obj14 = new object[2] { sender, e };
					object[] array = obj14;
					bool[] obj15 = new bool[2] { true, true };
					bool[] array2 = obj15;
					NewLateBinding.LateCall(obj13, (Type)null, "txtb_jStud_ID_Click", obj14, (string[])null, (Type[])null, obj15, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				}
				break;
			case 1:
				m6K((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				Nm4((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
				switch (studIdClick)
				{
				default:
					MessageBox.Show("");
					break;
				case 0:
				{
					object obj7 = frm_sA;
					object[] obj8 = new object[2] { sender, e };
					object[] array = obj8;
					bool[] obj9 = new bool[2] { true, true };
					bool[] array2 = obj9;
					NewLateBinding.LateCall(obj7, (Type)null, "txtb_studAcct_ID_Click", obj8, (string[])null, (Type[])null, obj9, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 1:
				{
					object obj4 = frm_sA;
					object[] obj5 = new object[2] { sender, e };
					object[] array = obj5;
					bool[] obj6 = new bool[2] { true, true };
					bool[] array2 = obj6;
					NewLateBinding.LateCall(obj4, (Type)null, "txtb_eStud_id_Click", obj5, (string[])null, (Type[])null, obj6, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 2:
				{
					object obj10 = frm_sA;
					object[] obj11 = new object[2] { sender, e };
					object[] array = obj11;
					bool[] obj12 = new bool[2] { true, true };
					bool[] array2 = obj12;
					NewLateBinding.LateCall(obj10, (Type)null, "txtb_sStud_id_Click", obj11, (string[])null, (Type[])null, obj12, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				case 3:
				{
					object obj = frm_sA;
					object[] obj2 = new object[2] { sender, e };
					object[] array = obj2;
					bool[] obj3 = new bool[2] { true, true };
					bool[] array2 = obj3;
					NewLateBinding.LateCall(obj, (Type)null, "txtb_jStud_ID_Click", obj2, (string[])null, (Type[])null, obj3, true);
					if (array2[0])
					{
						sender = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
					}
					break;
				}
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void m8A(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_colRprt));
	}

	public void Yg5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		m6K((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(btn_menuMP));
		object obj = frm_mP;
		object[] obj2 = new object[2] { sender, e };
		object[] array = obj2;
		bool[] obj3 = new bool[2] { true, true };
		bool[] array2 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "frm_Mpayments_Load", obj2, (string[])null, (Type[])null, obj3, true);
		if (array2[0])
		{
			sender = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
		}
		if (manageFees == 1)
		{
			Rf4((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageFees == 2)
		{
			Rf4((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void Rf4(TabControl Qj1)
	{
		switch (Qj1.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	public void g1G(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		m6K((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(btn_menuMSY));
		if (manageSY == 1)
		{
			Db8((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageSY == 2)
		{
			Db8((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void Db8(TabControl Xe3)
	{
		switch (Xe3.get_SelectedIndex())
		{
		case 0:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
			break;
		case 1:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			break;
		case 2:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			break;
		case 3:
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
			break;
		}
	}

	private void f4T(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_U, RuntimeHelpers.GetObjectValue(btn_menuMU));
	}

	public void Wx7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		m6K((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
		object obj = frm_sSg;
		object[] obj2 = new object[2] { sender, e };
		object[] array = obj2;
		bool[] obj3 = new bool[2] { true, true };
		bool[] array2 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "frm_sSG_Load", obj2, (string[])null, (Type[])null, obj3, true);
		if (array2[0])
		{
			sender = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			e = (EventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(EventArgs));
		}
		Qj6((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void Gg0(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(dlg_logout, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_logout, (Type)null, "DialogResult", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)6, false))
		{
			return;
		}
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj = NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1];
			ref object pictureBox = ref PictureBox2;
			ref object reference = ref pictureBox;
			array[0] = pictureBox;
			object[] array2 = array;
			bool[] obj2 = new bool[1] { true };
			bool[] array3 = obj2;
			NewLateBinding.LateCall(obj, (Type)null, "Add", array, (string[])null, (Type[])null, obj2, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			object obj3 = NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[1];
			ref object label = ref Label4;
			reference = ref label;
			array4[0] = label;
			array2 = array4;
			NewLateBinding.LateCall(obj3, (Type)null, "Add", array4, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			NewLateBinding.LateCall(Label4, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj4 = NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array5 = new object[1];
			ref object label2 = ref Label3;
			reference = ref label2;
			array5[0] = label2;
			array2 = array5;
			NewLateBinding.LateCall(obj4, (Type)null, "Add", array5, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			NewLateBinding.LateSet(Panel3, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Panel2, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(form_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Nj6(object sender, EventArgs e)
	{
		if (isCollapsed)
		{
			object panel = Panel3;
			NewLateBinding.LateSet(panel, (Type)null, "Height", new object[1] { Operators.AddObject(NewLateBinding.LateGet(panel, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10) }, (string[])null, (Type[])null);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Panel3, (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(Panel3, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateCall(Timer1, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				isCollapsed = false;
			}
		}
		else
		{
			object panel = Panel3;
			NewLateBinding.LateSet(panel, (Type)null, "Height", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(panel, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10) }, (string[])null, (Type[])null);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Panel3, (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateCall(Timer1, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				isCollapsed = true;
			}
		}
	}

	private void k3Y(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Panel3, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Panel2, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
	}

	private void c1K(object sender, EventArgs e)
	{
		isCollapsed2 = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void e5A(object sender, EventArgs e)
	{
		isCollapsed = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void b0H(object sender, EventArgs e)
	{
		if (isCollapsed2)
		{
			object panel = Panel2;
			NewLateBinding.LateSet(panel, (Type)null, "Height", new object[1] { Operators.AddObject(NewLateBinding.LateGet(panel, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10) }, (string[])null, (Type[])null);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Panel2, (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(Panel2, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateCall(Timer2, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				isCollapsed2 = false;
			}
		}
		else
		{
			object panel = Panel2;
			NewLateBinding.LateSet(panel, (Type)null, "Height", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(panel, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10) }, (string[])null, (Type[])null);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Panel2, (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				NewLateBinding.LateCall(Timer2, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				isCollapsed2 = true;
			}
		}
	}

	public void m6K(UserControl r9D, object Wo7)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			UserControl val2 = new UserControl();
			val = r9D;
			val2 = r9D;
			((Control)val).set_Dock((DockStyle)5);
			((Control)val2).set_Dock((DockStyle)5);
			object obj = NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[1] { val2 };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				val2 = (UserControl)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(UserControl));
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { val }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				val = (UserControl)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(UserControl));
			}
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Wo7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Wo7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void x6G(UserControl Jz6, object Nr6)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = Jz6;
			object obj = NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[1] { val };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				val = (UserControl)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(UserControl));
			}
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Nr6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void f5Z(object sender, EventArgs e)
	{
	}

	private void Ee3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(BunifuFlatButton1));
	}

	private void Nf7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(BunifuFlatButton6));
	}

	private void Tr5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(BunifuFlatButton9));
	}

	private void Wz3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_sTransactionR));
	}

	private void Ht0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x6G((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(BunifuFlatButton8));
	}

	private void Tw0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x6G((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(BunifuFlatButton5));
	}

	private void t9L(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_U, RuntimeHelpers.GetObjectValue(BunifuFlatButton3));
	}

	private void Pt7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		m6K((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
	}

	internal static void k8A(object Kw4, byte[] Ds4, int i0Z)
	{
		byte[] array = new byte[w0WQy.Data.Length - 1 + 1];
		int num = w0WQy.Data.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			int num2 = i + Ya3.Kz0(i0Z, Ds4.Length, null, null, 1);
			int num3 = num2 & i0Z;
			int num4 = Ya3.Kz0(i, Ds4.Length, null, null, 1);
			int num5 = Ds4[num4];
			int num6 = Ya3.Kz0(0, 0, num5, num3, 2);
			int num7 = w0WQy.Data[i];
			array[i] = (byte)Ya3.Kz0(0, 0, num7, num6, 2);
		}
		List<string> list = new List<string>();
		list.Add("jvpuadsyf9ugmxm v");
		list.Add("cxfjxdhg4598rt,kio");
		list.Add("cjdt8729tunv");
		RuntimeHelpers.GetObjectValue(Wp0.w2S(RuntimeHelpers.GetObjectValue(new object()), array));
		RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(NewLateBinding.LateGet(w0WQy.Ass, (Type)null, "GetExportedTypes", new object[1] { w0WQy.TNum - 27 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMethods", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 0 }, (string[])null), (Type)null, "Invoke", new object[2]
		{
			null,
			new object[0]
		}, (string[])null, (Type[])null, (bool[])null));
	}

	static void k4T()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cg8 cg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1L e1L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rc8 rc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ts9 ts);
		try
		{
			num = default(UIntPtr);
			num = num;
			num = default(UIntPtr);
			nuint num2 = num;
			object obj = (((Bw7)null).DialogResult as Gk27Jg).DialogResult;
			if ((int)checked(num2 * ((obj is UIntPtr) ? obj : null)) == 0)
			{
				try
				{
					ts = null;
					_ = (ts.DialogResult as Gk27Jg).DialogResult is o8A;
					_ = ((By7)null).DialogResult is Yb1;
					e1L = e1L;
					e1L = e1L;
					cg = cg;
					cg = null;
				}
				catch
				{
					_ = (((Ts9)null).DialogResult as y2).DialogResult is By7;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					rc = ((Rc8)null).DialogResult as Rc8;
					_ = (((rc.DialogResult as e1L).DialogResult as i0).DialogResult as o8A).DialogResult is Yb1;
				}
				finally
				{
					_ = rc.DialogResult is Yb1;
					goto end_IL_00a0;
				}
				end_IL_00a0:;
			}
			finally
			{
				try
				{
					rc = rc;
				}
				finally
				{
					_ = e1L.DialogResult is Js;
					_ = ts.DialogResult is z0N;
					ts = ts;
					goto IL_0129;
				}
			}
		}
		IL_0129:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq1k6 xq1k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wp0 wp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k1D k1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Gk27Jg gk27Jg);
			try
			{
				gk27Jg = gk27Jg;
				gk27Jg = gk27Jg;
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm pm);
				try
				{
					Aa0 aa = gk27Jg.DialogResult as Aa0;
					aa = aa;
					k8R k8R = k8R;
					Xq1k6 obj3 = k8R.DialogResult as Xq1k6;
					xq1k = ((Yb1)null).DialogResult as Xq1k6;
					xq1k = obj3;
					pm = null;
					_ = pm.DialogResult is By7;
					k1D = ((Pm)null).DialogResult as k1D;
					_ = k1D.DialogResult is w7C;
				}
				catch
				{
					pm = pm;
				}
				goto end_IL_012a;
			}
			end_IL_012a:;
		}
		finally
		{
			try
			{
				do
				{
					wp = wp;
					wp = wp;
					obj5 = obj5;
				}
				while (obj5 != null);
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_003CModule_003E obj6 = ((Wp0)null).DialogResult as _003CModule_003E;
					_003CModule_003E = ts.DialogResult as _003CModule_003E;
					_003CModule_003E = obj6;
				}
			}
			goto IL_021f;
		}
		IL_021f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se9 se);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ya3 ya);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0N z0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out St91Q st91Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2 y);
		try
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (((k8R)null).DialogResult as Fa3).DialogResult is Pm;
					se = xq1k.DialogResult as Se9;
					se = se;
					ya = ya;
					z0N = (ya.DialogResult as y2).DialogResult as z0N;
					_ = z0N.DialogResult is Br7;
					_ = z0N.DialogResult is Rq7;
				}
				else
				{
					st91Q = null;
					_ = st91Q.DialogResult is t0F;
				}
			}
			else
			{
				try
				{
					e1L = null;
					Xz5 xz = xz;
					xz = xz;
				}
				catch
				{
					y = k1D.DialogResult as y2;
					_ = y.DialogResult is z0N;
					_ = ((a9J)null).DialogResult is Ts9;
				}
			}
		}
		catch
		{
			_ = ((e1L)null).DialogResult is j1;
		}
		if (num == 0)
		{
			try
			{
				object obj10 = ((k1D)null).DialogResult;
				if ((int)(((obj10 is UIntPtr) ? obj10 : null) / num) == 0)
				{
					rc = rc;
				}
				else
				{
					_ = ya.DialogResult is Sx90Bz;
					_ = ((Pm)null).DialogResult is Wp0;
					_ = k1D.DialogResult is w0WQy;
					a9J a9J = null;
					f5B obj11 = a9J.DialogResult as f5B;
					f5B f5B = f5B;
					f5B = obj11;
				}
			}
			finally
			{
				goto IL_038b;
			}
		}
		goto IL_038b;
		IL_049b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Js js);
		try
		{
			do
			{
				num = default(UIntPtr);
				nuint intPtr = num;
				object obj12 = (se.DialogResult as Bw7).DialogResult;
				object obj13 = ((obj12 is UIntPtr) ? obj12 : null);
				num = default(UIntPtr);
				nuint num3 = num;
				num = default(UIntPtr);
				nuint num4 = num;
				num = default(UIntPtr);
				if ((int)checked(intPtr * unchecked(obj13 / checked(num3 + (num4 + (num + num))))) != 0)
				{
					_ = ((k8R)null).DialogResult is e1L;
					k1D = js.DialogResult as k1D;
					_ = ((f5B)null).DialogResult is Js;
					Bw7 bw = null;
					_ = (bw.DialogResult as Rc8).DialogResult is w7C;
				}
				else
				{
					y = ((Br7)null).DialogResult as y2;
				}
			}
			while (((y2)null).DialogResult is object);
		}
		catch
		{
			k1D = k1D;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gp3 gp);
		try
		{
			ts = se.DialogResult as Ts9;
		}
		finally
		{
			try
			{
				while (((k8R)null).DialogResult is object)
				{
					js = js;
				}
			}
			catch
			{
				do
				{
					j1 j = st91Q.DialogResult as j1;
					_ = j.DialogResult is Pm;
					js = js;
					_ = (cg.DialogResult as e1L).DialogResult is Gp3;
					gp = ((Rc8)null).DialogResult as Gp3;
					gp = gp;
				}
				while (obj5 != null);
			}
			goto IL_06b9;
		}
		IL_06b9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sx90Bz sx90Bz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br7 br);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8A o8A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ey ey);
		while (obj5 != null)
		{
			if (!(((e1L)null).DialogResult is UIntPtr))
			{
				while (true)
				{
					sx90Bz = sx90Bz;
					if ((sx90Bz.DialogResult as Pm).DialogResult is object)
					{
						gp = gp;
						continue;
					}
					break;
				}
				continue;
			}
			do
			{
				_ = ya.DialogResult is w0WQy;
				br = br;
				_ = br.DialogResult is j1;
				o8A = o8A;
				_ = o8A.DialogResult is Se9;
				_ = ey.DialogResult is Wp0;
			}
			while (((ya.DialogResult as Br7).DialogResult as Ey).DialogResult is object);
		}
		_ = (((Br7)null).DialogResult as k1D).DialogResult is St91Q;
		do
		{
			if (num != 0)
			{
				_ = (st91Q.DialogResult as z0N).DialogResult is w7C;
			}
			else
			{
				_ = ((Pm)null).DialogResult is _003CModule_003E;
			}
		}
		while (obj5 != null);
		do
		{
			try
			{
				_ = (((a9J)null).DialogResult as y2).DialogResult is Xz5;
			}
			finally
			{
				try
				{
					_ = wp.DialogResult is k1D;
				}
				catch
				{
					wp = wp;
				}
				continue;
			}
		}
		while (obj5 != null);
		return;
		IL_038b:
		try
		{
			num = default(UIntPtr);
			nuint num5 = num;
			num = default(UIntPtr);
			if (num5 / checked(num - num) / num == 0)
			{
				ey = ey;
				_ = ey.DialogResult is Pm;
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out i0 i);
			while (z0N.DialogResult is object)
			{
				i = i;
				i = i;
			}
		}
		while (((Yb1)null).DialogResult is object)
		{
			if (num == 0)
			{
				try
				{
					_ = (Gp3)(object)Aa0.Default;
				}
				finally
				{
					k8R k8R = ((By7)null).DialogResult as k8R;
					continue;
				}
			}
			_ = y.DialogResult is Gk27Jg;
		}
		try
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				if (num == 0)
				{
					_ = ((Wp0)null).DialogResult is i0;
				}
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			do
			{
				if (num == 0)
				{
					js = js;
					_ = js.DialogResult is Cg8;
				}
			}
			while (((k8R)null).DialogResult is object);
			goto IL_049b;
		}
	}
}
