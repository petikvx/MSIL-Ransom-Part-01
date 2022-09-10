using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using At;
using Fb3;
using Fe8;
using Gr8;
using Jt8;
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
using Yy4;
using d6J;
using e5J;
using f1;
using f4YBe3;
using g5L;
using g9A;
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
using x3A;
using z2R;

namespace d5;

public class j1
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

	public j1()
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

	private void o3(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)6;
		e8();
	}

	private void e8()
	{
		throw new NotImplementedException();
	}

	private void Nn(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)7;
		e8();
	}

	public void n9(UserControl i6, object n9)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = i6;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(n9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Xg(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Xg(string Jx)
	{
		throw new NotImplementedException();
	}

	public void q8(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		c9((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(btn_manageP));
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "lbl_cashier", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(cashier_name, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		g6((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public void g6(TabControl Hr)
	{
		switch (Hr.get_SelectedIndex())
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

	public void Li(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		c9((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(btn_menuStudentsList));
		if (Go() == 1)
		{
			Jo((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (Go() == 2)
		{
			Jo((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private int Go()
	{
		throw new NotImplementedException();
	}

	public void Jo(TabControl Ef)
	{
		switch (Ef.get_SelectedIndex())
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

	public void De(TabControl a8)
	{
		studIdClick = a8.get_SelectedIndex();
		switch (a8.get_SelectedIndex())
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

	public void b0(TabControl z7)
	{
		switch (z7.get_SelectedIndex())
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

	public void Nt(object sender, EventArgs e)
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
				c9((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				De((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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
				c9((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				De((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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

	private void Jm(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_colRprt));
	}

	public void y3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		c9((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(btn_menuMP));
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
			s4((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageFees == 2)
		{
			s4((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void s4(TabControl b1)
	{
		switch (b1.get_SelectedIndex())
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

	public void Kz(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		c9((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(btn_menuMSY));
		if (manageSY == 1)
		{
			a3((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageSY == 2)
		{
			a3((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void a3(TabControl Rx)
	{
		switch (Rx.get_SelectedIndex())
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

	private void Zn(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_U, RuntimeHelpers.GetObjectValue(btn_menuMU));
	}

	public void b7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		c9((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
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
		b0((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void b3(object sender, EventArgs e)
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

	private void Fw(object sender, EventArgs e)
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

	private void Bs(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Panel3, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Panel2, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
	}

	private void Ty(object sender, EventArgs e)
	{
		isCollapsed2 = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void o7(object sender, EventArgs e)
	{
		isCollapsed = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void f1(object sender, EventArgs e)
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

	public void c9(UserControl p2, object a7)
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
			val = p2;
			val2 = p2;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(a7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(a7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Lc(UserControl b9, object Fi)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = b9;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Fi, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void w8(object sender, EventArgs e)
	{
	}

	private void f2(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(BunifuFlatButton1));
	}

	private void Lj(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(BunifuFlatButton6));
	}

	private void Cx(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(BunifuFlatButton9));
	}

	private void o0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_sTransactionR));
	}

	private void b5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lc((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(BunifuFlatButton8));
	}

	private void Ni(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Lc((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(BunifuFlatButton5));
	}

	private void Ew(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_U, RuntimeHelpers.GetObjectValue(BunifuFlatButton3));
	}

	private void Dr(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		c9((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
	}

	static void Hc()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0067: Expected I, but got O
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yb1 yb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se9 se);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0N z0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rc8 rc);
		try
		{
			try
			{
				yb = yb;
				_ = yb.DialogResult is Yb1;
			}
			finally
			{
				se = se;
				se = null;
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			z0N = z0N;
			z0N = z0N;
			rc = rc;
			rc = rc;
			goto IL_004d;
		}
		IL_004d:
		Gk27Jg gk27Jg = gk27Jg;
		object obj = gk27Jg.DialogResult;
		nuint num = (nuint)(nint)((obj is UIntPtr) ? obj : null);
		nuint num2 = num;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9J a9J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i0 i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xz5 xz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		if (checked(num2 - num) == 0)
		{
			do
			{
				if (!(((Js)null).DialogResult is UIntPtr))
				{
					a9J = null;
					_ = a9J.DialogResult is Fa3;
					i = i;
					_ = (i.DialogResult as k1D).DialogResult is o8A;
					xz = xz;
					xz = xz;
				}
				obj2 = obj2;
			}
			while (obj2 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bw7 bw);
		try
		{
			try
			{
				do
				{
					xz = xz;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					bw = bw;
					bw = bw;
				}
				catch
				{
					f5B f5B = f5B.DialogResult as f5B;
					_ = (f5B.DialogResult as e8C).DialogResult is Xq1k6;
				}
				goto end_IL_00e5;
			}
			end_IL_00e5:;
		}
		finally
		{
			_ = ((Ey)null).DialogResult is Sx90Bz;
			goto IL_014a;
		}
		IL_014a:
		try
		{
			_ = z0N.DialogResult is Cy2;
		}
		catch
		{
			_ = ((f5B)null).DialogResult is w0WQy;
		}
		Cg8 cg = cg;
		w7C w7C = (cg.DialogResult as Ya3).DialogResult as w7C;
		w7C = w7C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm pm);
		try
		{
			while (((((a9J.DialogResult as e1L).DialogResult as e8C).DialogResult as y2).DialogResult as e1L).DialogResult is object)
			{
				_ = (yb.DialogResult as f5B).DialogResult is Cy2;
			}
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					_ = ((Se9)null).DialogResult is Cy2;
				}
				else
				{
					pm = null;
					pm = null;
				}
			}
			finally
			{
				try
				{
					pm = null;
				}
				finally
				{
					Aa0 aa = aa;
					_ = (Nb1)(object)aa.db_lccsams_connection;
					goto end_IL_01ed;
				}
			}
			end_IL_01ed:;
		}
		Ya3 ya = ya;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq1k6 xq1k);
		if (!(((ya.DialogResult as o8A).DialogResult as f5B).DialogResult is UIntPtr))
		{
			do
			{
				xq1k = xq1k;
				xq1k = null;
			}
			while (obj2 != null || obj2 != null);
		}
		_ = (((o8A)null).DialogResult as o8A).DialogResult is Nb1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ey ey);
		try
		{
			do
			{
				if (!((gk27Jg.DialogResult as Gk27Jg).DialogResult is UIntPtr))
				{
					_ = ((k8R)null).DialogResult is Ts9;
				}
			}
			while ((pm.DialogResult as z0N).DialogResult is object);
		}
		catch
		{
			num = default(UIntPtr);
			nuint num3 = num;
			j1 j2 = j2;
			object obj6 = (j2.DialogResult as Ya3).DialogResult;
			if ((int)checked(num3 + ((obj6 is UIntPtr) ? obj6 : null)) == 0)
			{
				try
				{
					_ = ((Bw7)null).DialogResult is Se9;
				}
				finally
				{
					ey = ((o8A)null).DialogResult as Ey;
					_ = ey.DialogResult is w0WQy;
					goto end_IL_02dd;
				}
			}
			end_IL_02dd:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8R k8R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wp0 wp);
		try
		{
			while (obj2 != null)
			{
				num = default(UIntPtr);
				nuint intPtr = num;
				k8R = rc.DialogResult as k8R;
				object obj8 = (k8R.DialogResult as f5B).DialogResult;
				_003F val = ((obj8 is UIntPtr) ? obj8 : null) / num;
				num = default(UIntPtr);
				if ((int)checked(intPtr - val * unchecked(num / num)) == 0)
				{
					wp = null;
					wp = null;
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				k8R = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out By7 by);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8A o8A);
		try
		{
			if (!((ey.DialogResult as Ya3).DialogResult is UIntPtr))
			{
				_ = ((Br7)null).DialogResult is Cy2;
			}
			else
			{
				Sx90Bz sx90Bz = sx90Bz;
				_ = sx90Bz.DialogResult is e8C;
			}
		}
		catch
		{
			try
			{
				_ = (((a9J)null).DialogResult as Xq1k6).DialogResult is Wp0;
				f5B f5B = ((Ts9)null).DialogResult as f5B;
			}
			finally
			{
				o8A = null;
				o8A = o8A;
				e8C e8C = null;
				_ = e8C.DialogResult is St91Q;
				_ = ((Fa3)null).DialogResult is e1L;
				goto end_IL_03fc;
			}
			end_IL_03fc:;
		}
		finally
		{
			by = by;
			by = null;
			goto IL_0466;
		}
		IL_0466:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num == 0)
		{
			_ = i.DialogResult is Yb1;
			Br7 br = o8A.DialogResult as Br7;
			br = br;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			cg = ((Js)null).DialogResult as Cg8;
		}
		else
		{
			wp = wp;
			_ = (((y2)null).DialogResult as o8A).DialogResult is Ey;
			f5B f5B = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ts9 ts);
		try
		{
			do
			{
				ts = null;
				_ = (ts.DialogResult as k1D).DialogResult is Gp3;
				_ = ts.DialogResult is Yb1;
				gk27Jg = gk27Jg;
			}
			while (((Ya3)null).DialogResult is object);
		}
		catch
		{
			while (((Ts9)null).DialogResult is object)
			{
				_ = bw.DialogResult is Br7;
			}
		}
		finally
		{
			_ = z0N.DialogResult is Ey;
			goto IL_0554;
		}
		IL_0554:
		try
		{
			_ = ((i0)null).DialogResult is Rq7;
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj2 != null)
		{
			if (!(yb.DialogResult is UIntPtr))
			{
				_ = k8R.DialogResult is Pm;
				_ = ((Xq1k6)null).DialogResult is f5B;
				_ = (o8A.DialogResult as Br7).DialogResult is Cg8;
				_ = z0N.DialogResult is y2;
			}
			else if (!(by.DialogResult is UIntPtr))
			{
				_ = (se.DialogResult as Ya3).DialogResult is Yb1;
			}
			else
			{
				ya = xq1k.DialogResult as Ya3;
			}
		}
		try
		{
			object obj13 = i.DialogResult;
			if ((int)(unchecked((nuint)default(UIntPtr)) / ((obj13 is UIntPtr) ? obj13 : null)) == 0)
			{
				y2 y = null;
				y = y;
			}
			else
			{
				pm = ts.DialogResult as Pm;
			}
		}
		catch
		{
			Js js;
			do
			{
				e8C e8C = ((Se9)null).DialogResult as e8C;
				js = null;
			}
			while (js.DialogResult is object);
		}
		finally
		{
			_ = ((Pm)null).DialogResult is k8R;
			return;
		}
	}
}
