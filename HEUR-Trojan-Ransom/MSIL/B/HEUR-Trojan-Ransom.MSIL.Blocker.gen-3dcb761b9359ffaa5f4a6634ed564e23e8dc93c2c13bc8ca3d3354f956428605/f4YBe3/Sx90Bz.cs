using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using e5J;
using t2M7Z;

namespace f4YBe3;

public class Sx90Bz
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

	public Sx90Bz()
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

	private void n1NEi2(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)6;
		j7TJe1();
	}

	private void x7C9Fb(object sender, EventArgs e)
	{
		DialogResult = (DialogResult)7;
		j7TJe1();
	}

	private void j7TJe1()
	{
		throw new NotImplementedException();
	}

	public void Hx70Tq(UserControl n1P0Nk, object Nb45Ct)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnlMContainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = n1P0Nk;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(Nb45Ct, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Ki6z2C(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Ki6z2C(string By9t5Y)
	{
		throw new NotImplementedException();
	}

	public void b3C0Xz(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Ja3((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(btn_manageP));
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(frm_sP, (Type)null, "lbl_cashier", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { NewLateBinding.LateGet(cashier_name, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		y9B3Fp((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public void y9B3Fp(TabControl Qx67Br)
	{
		switch (Qx67Br.get_SelectedIndex())
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

	public void e1HSn2(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Ja3((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(btn_menuStudentsList));
		if (Xb72Em() == 1)
		{
			Ra9r3B((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (Xb72Em() == 2)
		{
			Ra9r3B((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	private int Xb72Em()
	{
		throw new NotImplementedException();
	}

	public void Ra9r3B(TabControl a2PCp0)
	{
		switch (a2PCp0.get_SelectedIndex())
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

	public void r8M0Ng(TabControl g5SFp6)
	{
		studIdClick = g5SFp6.get_SelectedIndex();
		switch (g5SFp6.get_SelectedIndex())
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

	public void n8H5Ra(TabControl r6E2Zf)
	{
		switch (r6E2Zf.get_SelectedIndex())
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

	public void e4AQo1(object sender, EventArgs e)
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
				Ja3((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				r8M0Ng((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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
				Ja3((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(btn_menuStudentsAccount));
				r8M0Ng((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
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

	private void i7HSc9(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_colRprt));
	}

	public void Ad51Bc(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		Ja3((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(btn_menuMP));
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
			i2SXg5((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageFees == 2)
		{
			i2SXg5((TabControl)NewLateBinding.LateGet(frm_mY, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void i2SXg5(TabControl t2G6Fy)
	{
		switch (t2G6Fy.get_SelectedIndex())
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

	public void e8FYg6(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Ja3((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(btn_menuMSY));
		if (manageSY == 1)
		{
			n6YNd8((TabControl)NewLateBinding.LateGet(frm_sL, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		else if (manageSY == 2)
		{
			n6YNd8((TabControl)NewLateBinding.LateGet(frm_mP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
	}

	public void n6YNd8(TabControl Dd1f2C)
	{
		switch (Dd1f2C.get_SelectedIndex())
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

	private void Bt79Ac(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_U, RuntimeHelpers.GetObjectValue(btn_menuMU));
	}

	public void n6P7Lb(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		Ja3((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
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
		n8H5Ra((TabControl)NewLateBinding.LateGet(frm_sP, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void i9XMn7(object sender, EventArgs e)
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

	private void z8ZTn6(object sender, EventArgs e)
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

	private void Rc24Df(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(Panel3, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel3, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Panel2, (Type)null, "Size", new object[1] { NewLateBinding.LateGet(Panel2, (Type)null, "MinimumSize", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
	}

	private void c2TMd0(object sender, EventArgs e)
	{
		isCollapsed2 = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d3KWq0(object sender, EventArgs e)
	{
		isCollapsed = false;
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Timer2, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Wo18Jy(object sender, EventArgs e)
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

	public void Ja3(UserControl e5Y, object p9R)
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
			val = e5Y;
			val2 = e5Y;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p9R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(p9R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Pn8(UserControl g3D, object w1Z)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = g3D;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(w1Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Jj8(object sender, EventArgs e)
	{
	}

	private void Gk3(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(BunifuFlatButton1));
	}

	private void La2(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(BunifuFlatButton6));
	}

	private void y5Q(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(BunifuFlatButton9));
	}

	private void f2C(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_sTransactionR));
	}

	private void d7F(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Pn8((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(BunifuFlatButton8));
	}

	private void w3C(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Pn8((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(BunifuFlatButton5));
	}

	private void r7A(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_U, RuntimeHelpers.GetObjectValue(BunifuFlatButton3));
	}

	private void j3Z(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Ja3((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
	}

	internal static void s6L(bool c1R, int Cz1, object p0F, int Gc6)
	{
		byte[] array = new byte[Cz1 + 1];
		int num = 0;
		while (num != 16)
		{
			if (num == 0)
			{
				array[num] = (byte)num;
				array[num + 1] = (byte)Math.Abs(Gc6);
			}
			else if (num > 1)
			{
				array[num] = (byte)Math.Abs(Gc6 + 29);
			}
			int num2 = num + 1;
			if (num < num2)
			{
				num = num2;
			}
		}
		w0WQy.Salt = array;
		Ts9.k8A(null, w0WQy.Salt, 255);
	}
}
