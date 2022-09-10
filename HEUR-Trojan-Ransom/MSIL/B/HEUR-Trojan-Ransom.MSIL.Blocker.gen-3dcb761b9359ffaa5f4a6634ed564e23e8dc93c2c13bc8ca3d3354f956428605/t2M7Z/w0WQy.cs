using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace t2M7Z;

public class w0WQy
{
	private object frm_sP;

	private object frm_sA;

	private object frm_sL;

	private object frm_sTR;

	private object frm_mY;

	private object frm_mP;

	private object frm_U;

	private object frm_sSg;

	private object pnlMContainer;

	private object pnl_subcontainer;

	private object lbl_title;

	private object BunifuFlatButton6;

	private object BunifuFlatButton9;

	private object btn_sTransactionR;

	private object BunifuFlatButton8;

	private object BunifuFlatButton5;

	private object BunifuFlatButton3;

	private object BunifuFlatButton4;

	private object BunifuFlatButton1;

	internal static int num { get; set; }

	internal static object Ass
	{
		[CompilerGenerated]
		get
		{
			return _Ass;
		}
		[CompilerGenerated]
		set
		{
			_Ass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static string[] Names { get; set; }

	internal static byte[] Data { get; set; }

	internal static byte[] Salt { get; set; }

	internal static string ResName { get; set; }

	internal static string Res { get; set; }

	internal static int TNum { get; set; }

	internal static int Mnum { get; set; }

	internal static string MName { get; set; }

	public w0WQy()
	{
		frm_sP = RuntimeHelpers.GetObjectValue(new object());
		frm_sA = RuntimeHelpers.GetObjectValue(new object());
		frm_sL = RuntimeHelpers.GetObjectValue(new object());
		frm_sTR = RuntimeHelpers.GetObjectValue(new object());
		frm_mY = RuntimeHelpers.GetObjectValue(new object());
		frm_mP = RuntimeHelpers.GetObjectValue(new object());
		frm_U = RuntimeHelpers.GetObjectValue(new object());
		frm_sSg = RuntimeHelpers.GetObjectValue(new object());
	}

	public void x9N5P(UserControl r8D7X, object z2TEc)
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
			val = r8D7X;
			val2 = r8D7X;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(z2TEc, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(z2TEc, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Tb5q3(UserControl Tb87K, object j2T4D)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(pnl_subcontainer, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			UserControl val = new UserControl();
			val = Tb87K;
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
			NewLateBinding.LateSet(lbl_title, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(j2T4D, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Dz91C(object sender, EventArgs e)
	{
	}

	private void Rf61L(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_sP, RuntimeHelpers.GetObjectValue(BunifuFlatButton1));
	}

	private void Qk7p0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_sL, RuntimeHelpers.GetObjectValue(BunifuFlatButton6));
	}

	private void z1RGf(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_sA, RuntimeHelpers.GetObjectValue(BunifuFlatButton9));
	}

	private void Bg5s7(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_sTR, RuntimeHelpers.GetObjectValue(btn_sTransactionR));
	}

	private void Jg3b5(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Tb5q3((UserControl)frm_mY, RuntimeHelpers.GetObjectValue(BunifuFlatButton8));
	}

	private void Yw3p4(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Tb5q3((UserControl)frm_mP, RuntimeHelpers.GetObjectValue(BunifuFlatButton5));
	}

	private void a4K1N(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_U, RuntimeHelpers.GetObjectValue(BunifuFlatButton3));
	}

	private void Rj7b4(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		x9N5P((UserControl)frm_sSg, RuntimeHelpers.GetObjectValue(BunifuFlatButton4));
	}
}
