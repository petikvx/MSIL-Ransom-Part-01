using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using At;
using Fb3;
using Gr8;
using Kc0;
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
using e5J;
using f1;
using f4YBe3;
using g5L;
using i6E;
using j3F;
using j7;
using j7S;
using m5Q;
using o5Q;
using p9E;
using q7B;
using w1P;
using w6;
using w9J;
using x3A;
using z2R;

namespace Jt8;

public class Se9
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

	public Se9()
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

	private void a5S(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)1;
		Tc1();
	}

	private void j4D(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)2;
		Tc1();
	}

	private void Tc1()
	{
		throw new NotImplementedException();
	}

	public void Bj5(UserControl Dd0, object Mi4)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = Dd0;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Mi4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			n2M(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void n2M(string p1D)
	{
		throw new NotImplementedException();
	}

	public void s1C(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Lw5((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(btn_manageP));
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "lbl_cashier", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(cashier_name, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		Nx8((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public void Nx8(TabControl Pz5)
	{
		switch (Pz5.get_SelectedIndex())
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

	public void Dy7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Lw5((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(btn_menuStudentsList));
		if (e5D() == 1)
		{
			Gm1((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (e5D() == 2)
		{
			Gm1((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private int e5D()
	{
		throw new NotImplementedException();
	}

	public void Gm1(TabControl Lc1)
	{
		switch (Lc1.get_SelectedIndex())
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

	public void p1X(TabControl x3A)
	{
		studIdClick = x3A.get_SelectedIndex();
		switch (x3A.get_SelectedIndex())
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

	public void Af8(TabControl f6K)
	{
		switch (f6K.get_SelectedIndex())
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

	public void i3X(object sender, EventArgs e)
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
				Lw5((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				p1X((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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
				Lw5((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				p1X((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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

	private void p1R(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_colRprt));
	}

	public void j6W(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		Lw5((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(btn_menuMP));
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
			Ks1((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageFees == 2)
		{
			Ks1((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void Ks1(TabControl Qt6)
	{
		switch (Qt6.get_SelectedIndex())
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

	public void Yx6(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Lw5((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(btn_menuMSY));
		if (manageSY == 1)
		{
			a1N((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageSY == 2)
		{
			a1N((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void a1N(TabControl Xb6)
	{
		switch (Xb6.get_SelectedIndex())
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

	private void Rs5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_U, RuntimeHelpers.GetObjectValue(btn_menuMU));
	}

	public void p4A(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		Lw5((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
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
		Af8((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void Gp8(object sender, EventArgs e)
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

	private void y4K(object sender, EventArgs e)
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

	private void Xw5(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Panel3, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Panel2, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
	}

	private void Kw1(object sender, EventArgs e)
	{
		isCollapsed2 = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Xz0(object sender, EventArgs e)
	{
		isCollapsed = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void a4K(object sender, EventArgs e)
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

	public void Lw5(UserControl Co5, object y3N)
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
			val = Co5;
			val2 = Co5;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(y3N, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(y3N, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void d7H(UserControl Am0, object Kd3)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = Am0;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Kd3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Le6(object sender, EventArgs e)
	{
	}

	private void Be3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(BunifuFlatButton1));
	}

	private void t4M(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(BunifuFlatButton6));
	}

	private void e4B(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(BunifuFlatButton9));
	}

	private void Fq5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_sTransactionR));
	}

	private void Ct3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		d7H((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(BunifuFlatButton8));
	}

	private void Xc2(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		d7H((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(BunifuFlatButton5));
	}

	private void z5P(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_U, RuntimeHelpers.GetObjectValue(BunifuFlatButton3));
	}

	private void Ky7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lw5((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
	}

	static void e9W()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		_ = ((Yb1)null).DialogResult is Se9;
		nuint num = checked(num + num);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2 y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cg8 cg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5B f5B);
		if (num == (UIntPtr)(nuint)0u)
		{
			y = y;
			_ = y.DialogResult is k8R;
		}
		else
		{
			do
			{
				_ = ((z0N)null).DialogResult is Sx90Bz;
				y = y;
				f5B = f5B;
				Gk27Jg gk27Jg = f5B.DialogResult as Gk27Jg;
				_ = gk27Jg.DialogResult is o8A;
				cg = null;
			}
			while (cg.DialogResult is object);
		}
		object obj = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k1D k1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9J a9J);
		while (true)
		{
			a9J = a9J;
			if (!(a9J.DialogResult is object))
			{
				break;
			}
			try
			{
				while (obj != null)
				{
					k1D = cg.DialogResult as k1D;
					_ = (k1D.DialogResult as Js).DialogResult is z0N;
				}
			}
			catch
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se9 se);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rc8 rc);
		while (obj != null)
		{
			do
			{
				se = null;
				_ = (se.DialogResult as Ts9).DialogResult is Js;
				rc = rc;
			}
			while (rc.DialogResult is object);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0 i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out St91Q st91Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ey ey);
		try
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					k1D = k1D;
				}
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					ey = null;
					_ = ey.DialogResult is Cg8;
					w7C w7C = w7C;
					w7C = w7C;
					_ = (se.DialogResult as k1D).DialogResult is k8R;
				}
				else
				{
					By7 by = (((((i0)null).DialogResult as Fa3).DialogResult as y2).DialogResult as o8A).DialogResult as By7;
					_ = by.DialogResult is t0F;
					_ = ey.DialogResult is t0F;
				}
			}
		}
		catch
		{
			if (!(((Gk27Jg)null).DialogResult is UIntPtr))
			{
				while (obj != null)
				{
					k8R k8R = (((e8C)null).DialogResult as Xq1k6).DialogResult as k8R;
					z0N z0N = k8R.DialogResult as z0N;
					z0N = z0N;
					st91Q = st91Q;
					_ = st91Q.DialogResult is Ey;
				}
			}
			else
			{
				do
				{
					i = null;
					y = i.DialogResult as y2;
				}
				while (obj != null);
			}
		}
		UIntPtr num2 = (UIntPtr)Aa0.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq1k6 xq1k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8A o8A);
		checked
		{
			if (unchecked((nuint)num2) * num == 0)
			{
				_ = ((e1L)null).DialogResult is Pm;
			}
			else
			{
				_ = y.DialogResult is a9J;
			}
			try
			{
				do
				{
					num = default(UIntPtr);
					if (num == 0)
					{
					}
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					try
					{
						f5B = f5B;
					}
					catch
					{
						_ = ((Ya3)null).DialogResult is e1L;
						_ = (Wp0)(object)((Aa0)null).db_lccsams_connection;
					}
				}
				catch
				{
					try
					{
						Yb1 yb = null;
						_ = yb.DialogResult is Rq7;
						goto end_IL_02e4;
					}
					catch
					{
						xq1k = xq1k;
						Wp0 wp = xq1k.DialogResult as Wp0;
						_ = wp.DialogResult is Aa0;
						goto end_IL_02e4;
					}
					end_IL_02e4:;
				}
			}
			try
			{
				_ = (((f5B)null).DialogResult as Ts9).DialogResult is a9J;
				st91Q = st91Q;
				se = se;
				o8A = null;
				Yb1 yb = o8A.DialogResult as Yb1;
			}
			finally
			{
				if (num == 0)
				{
					do
					{
						w7C w7C = (((a9J)null).DialogResult as e1L).DialogResult as w7C;
					}
					while (obj != null);
				}
				goto IL_0392;
			}
		}
		IL_054e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Js js);
		if (!(js.DialogResult is UIntPtr))
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = o8A.DialogResult is Js;
				}
				while ((((y2)null).DialogResult as Se9).DialogResult is object);
			}
		}
		else
		{
			_ = ((By7)null).DialogResult is Ya3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sx90Bz sx90Bz);
		while (((Se9)null).DialogResult is object)
		{
			while (sx90Bz.DialogResult is object)
			{
				while (obj != null)
				{
					_ = k1D.DialogResult is Ts9;
				}
			}
		}
		try
		{
			do
			{
				try
				{
					_ = se.DialogResult is Ts9;
					o8A = null;
				}
				finally
				{
					_ = k1D.DialogResult is Js;
					continue;
				}
			}
			while (obj != null);
			return;
		}
		catch
		{
			Aa0 aa = aa;
			if ((UIntPtr)aa.db_lccsams_connection == (UIntPtr)(nuint)0u)
			{
				Pm pm = null;
				_ = pm.DialogResult is i0;
				a9J = null;
			}
			else
			{
				_ = (ey.DialogResult as Br7).DialogResult is Pm;
			}
			return;
		}
		IL_0392:
		try
		{
			if (num == 0)
			{
				se = se;
				_ = (((Js)null).DialogResult as Gk27Jg).DialogResult is Bw7;
			}
		}
		catch
		{
			try
			{
				try
				{
					Bw7 bw = bw;
					_ = bw.DialogResult is St91Q;
				}
				finally
				{
					_ = y.DialogResult is Js;
					goto end_IL_03ba;
				}
				end_IL_03ba:;
			}
			finally
			{
				do
				{
					_ = se.DialogResult is o8A;
				}
				while (obj != null);
				goto end_IL_03b9;
			}
			end_IL_03b9:;
		}
		while (obj != null)
		{
			while (((Se9)null).DialogResult is object)
			{
			}
		}
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = ((Gk27Jg)null).DialogResult is Ey;
				}
				else
				{
					o8A = (o8A)(object)((Aa0)null).db_lccsams_connection;
					e1L obj11 = ((St91Q)null).DialogResult as e1L;
					e1L e1L = e1L;
					e1L = obj11;
					rc = rc;
				}
			}
			catch
			{
				try
				{
					_ = ((Yb1)null).DialogResult is Yb1;
				}
				finally
				{
					_ = o8A.DialogResult is By7;
					goto end_IL_0464;
				}
				end_IL_0464:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ya3 ya);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j1 j);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy2 cy);
		do
		{
			try
			{
				_ = xq1k.DialogResult is Ya3;
			}
			finally
			{
				if (num == 0)
				{
					js = js;
					sx90Bz = js.DialogResult as Sx90Bz;
					sx90Bz = sx90Bz;
					ya = ya;
					ya = null;
					_ = js.DialogResult is Rq7;
					j = j;
					Cy2 obj13 = j.DialogResult as Cy2;
					cy = cy;
					cy = obj13;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				try
				{
					rc = (i.DialogResult as Fa3).DialogResult as Rc8;
				}
				catch
				{
					_ = ((St91Q)null).DialogResult is j1;
				}
			}
		}
		finally
		{
			ey = ey;
			goto IL_054e;
		}
	}
}
