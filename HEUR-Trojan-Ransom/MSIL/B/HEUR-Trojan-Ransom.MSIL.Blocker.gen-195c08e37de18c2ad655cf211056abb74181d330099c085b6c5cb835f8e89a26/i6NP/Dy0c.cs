using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Ba95Nn;
using Cp6r3F;
using Eg7s4Q;
using Gn65;
using Ki47;
using Kp62Wz;
using Mg3e;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using Nt61;
using Qe84;
using Ta50;
using Xf6w;
using b1D6So;
using f1W6;
using f3W1Tn;
using i1J6;
using n8Z0;
using o6FHd3;
using r7D4Eb;
using r9R2;
using t7JR;
using t8KCs3;
using x4K5;

namespace i6NP;

public class Dy0c
{
	private object T;

	private object m_n;

	private object m;

	private object k;

	private object U;

	private object E;

	private object I;

	private object R;

	private object x;

	private object B;

	private object m_J;

	private object G;

	private object y;

	private object Z;

	private object nn;

	private object ns;

	private object nk;

	private x6WSe8.r0Y8Nt D = new x6WSe8.r0Y8Nt();

	public object K
	{
		get
		{
			return D.M;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			D.M = objectValue;
		}
	}

	public object F
	{
		get
		{
			return k;
		}
		set
		{
			k = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object b
	{
		get
		{
			return D.k;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			D.k = objectValue;
		}
	}

	public object n
	{
		get
		{
			return U;
		}
		set
		{
			U = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object J
	{
		get
		{
			return D.Y;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			D.Y = objectValue;
		}
	}

	public Dy0c()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		D.U = (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null);
	}

	private void Ed6r()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		D.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand("Select * From PatientTb", D.U);
		object obj = (object)new SqlDataAdapter((SqlCommand)cloneable);
		IListSource listSource = new DataTable();
		((DbDataAdapter)((obj is SqlDataAdapter) ? obj : null)).Fill((DataTable)listSource);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { (DataTable)listSource }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		D.U.Close();
	}

	public void b9AW()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		D.U.Open();
		IConvertible convertible = "select * from DiagnosisTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(convertible as string, D.U);
		object obj = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill(obj as DataSet);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { ((DataSet)obj).Tables[0] }, (string[])null, (Type[])null, false, true);
		D.U.Close();
	}

	private void b2N1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		D.U.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", D.U);
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		ISerializable serializable = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(serializable as DataTable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { serializable as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		D.U.Close();
	}

	private void b3X1(object sender, EventArgs e)
	{
		Ed6r();
		b2N1();
		Cc5m();
	}

	private void m5G4(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		D.U.Open();
		IEquatable<string> equatable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(equatable as string, D.U);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		D.U.Close();
	}

	private void f0KE(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		object obj = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, D.U);
		new DataTable();
		IDataReader dataReader = (IDataReader)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
		while (((SqlDataReader)dataReader).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		D.U.Close();
	}

	internal void Dn31()
	{
		throw new NotImplementedException();
	}

	private void r0RF(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(D.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(comparable as string, D.U);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void t6F5(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(D.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(D.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), D.U);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void y1K2(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Diagnosis ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable2 = (ICloneable)new SqlCommand((string)cloneable, D.U);
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void d5SC(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Mi21(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void p6T1(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void Gy79(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Ty76(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(D.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(D.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, D.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	public void Cm46()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		D.U.Open();
		object obj = "select * from DoctorTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)obj, D.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(D.c, (Type)null, "DataSource", new object[1] { ((DataSet)xmlSerializable).Tables[0] }, (string[])null, (Type[])null);
		D.U.Close();
	}

	private void n5Y0(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(D.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(D.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(D.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), D.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void m0RJ(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Doctor ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, D.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void j5H3(object sender, EventArgs e)
	{
		Cc5m();
	}

	private void i4QD(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void t2RF(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Dj84(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Pb10(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Ca8m()
	{
		throw new NotImplementedException();
	}

	private void Eo86(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(D.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(D.E, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(D.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, D.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	public void Ab2i()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		D.U.Open();
		IEnumerable enumerable = "select * from PatientTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)enumerable, D.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(D.S, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		D.U.Close();
	}

	private void Jm6r(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(D.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(D.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(D.E, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), D.U);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void Jf0i(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Patient ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, D.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void Wf3t(object sender, EventArgs e)
	{
		Cc5m();
	}

	private void e2F9(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Dg6p(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Wi45(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void i7HD(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void e9NL()
	{
		throw new NotImplementedException();
	}

	private void Wg7e(object sender, EventArgs e)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(D.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(D.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)convertible, D.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	public void j7D8()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		D.U.Open();
		IComparable<string> comparable = "select * from ReceptionistTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)comparable, D.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(nn, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		D.U.Close();
	}

	private void Yq34(object sender, EventArgs e)
	{
		Cc5m();
	}

	private void Ky8z(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(D.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(D.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(D.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(D.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), D.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void e6P1(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(D.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(D.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(obj as string, D.U);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void Ge7g(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void o8YP(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void w4H1(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Xm31(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void j0W9()
	{
		throw new NotImplementedException();
	}

	private void j3Z2(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		D.U.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(D.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(D.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, D.U);
		cloneable = (ICloneable)new SqlCommand(enumerable as string, D.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	public void Cc5m()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		D.U.Open();
		IEnumerable<char> enumerable = "select * from TreatmentTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter((string)enumerable, D.U);
		ISerializable serializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)serializable);
		NewLateBinding.LateSet(nk, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		D.U.Close();
	}

	private void q3D0(object sender, EventArgs e)
	{
		Cc5m();
	}

	private void m1AD(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(D.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(D.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(D.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(D.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), D.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void a9W4(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(D.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		D.U.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(D.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand(cloneable as string, D.U);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		D.U.Close();
		Cc5m();
	}

	private void x3PK(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Ro06(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void g4B1(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Tn18(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void Jg56()
	{
		throw new NotImplementedException();
	}

	internal static object f3WK(Jy71To.g6BLq5 g6BLq5_0, object object_0)
	{
		g6BLq5_0.T = RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(f0N2.q4LYj3()), "Load", (CallType)2, new object[1] { object_0 }));
		object result = default(object);
		return result;
	}

	static void i8Y9()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw0j dw0j);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ef3a ef3a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9D2 q9D);
		try
		{
			e1TFq = e1TFq;
			if ((UIntPtr)e1TFq.J != (UIntPtr)(nuint)0u)
			{
				try
				{
					dw0j = (Dw0j)dw0j.J;
					_ = (e1TFq0)dw0j.n;
				}
				finally
				{
					m4DM = m4DM;
					m4DM = m4DM;
					_ = (e1TFq0)n1CJ.K;
					goto end_IL_0000;
				}
			}
			try
			{
				q9D = (q9D2)((m4DM)((Dy0c)null).F).b;
				q9D = q9D;
				ef3a = Ef3a.Default;
				ef3a = null;
			}
			catch
			{
				n1CJ = n1CJ;
				_ = (p1HNe2)((m4DM)n1CJ.F).n;
			}
			end_IL_0000:;
		}
		catch
		{
			try
			{
				num = default(UIntPtr);
				num = num;
				if (num / num == 0)
				{
					dw0j = dw0j;
					ef3a = (Ef3a)((Qs58)null).F;
				}
				else
				{
					s8PZ s8PZ = (s8PZ)((f0N2)null).K;
					s8PZ = s8PZ;
				}
			}
			catch
			{
				_ = (Kx43)m4DM.b;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj24Mt xj24Mt);
		if (num == 0)
		{
			try
			{
				while (obj4 != null)
				{
					bs0e1Z = (Bs0e1Z)((Cr38)xj24Mt.n).F;
					_ = (x6WSe8)bs0e1Z.b;
				}
			}
			catch
			{
				try
				{
					ef3a = ef3a;
				}
				catch
				{
					n1CJ = n1CJ;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n6R9Wx n6R9Wx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p1HNe2 p1HNe);
		try
		{
			try
			{
				if (num == 0)
				{
					cr = cr;
					qs = (Qs58)cr.n;
				}
				else
				{
					n6R9Wx = n6R9Wx;
					n6R9Wx = n6R9Wx;
				}
			}
			catch
			{
				x6WSe8 x6WSe = (x6WSe8)(object)Ef3a.Default;
				x6WSe = x6WSe;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				p1HNe = p1HNe;
				p1HNe = p1HNe;
			}
			else if (num == 0)
			{
				_ = (s2QH)cr.J;
			}
			else
			{
				_ = (Cr38)((f0N2)null).b;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		if (num == 0)
		{
			i3C0Qc i3C0Qc = i3C0Qc;
			i3C0Qc = i3C0Qc;
		}
		else
		{
			do
			{
				try
				{
					p1HNe = null;
				}
				finally
				{
					dy0c = (Dy0c)e1TFq.J;
					_ = (x6WSe8)((Cr38)dy0c.n).b;
					continue;
				}
			}
			while (obj4 != null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			while (obj4 != null)
			{
				do
				{
					p1HNe = p1HNe;
					_ = (q9D2)((Qs58)((e1TFq0)((Dy0c)((Dw0j)null).n).n).K).J;
					qs = qs;
					_ = (x6WSe8)cr.n;
				}
				while (((Kx43)null).K != null);
			}
		}
		else
		{
			q9D = q9D;
		}
		checked
		{
			try
			{
				n6R9Wx = null;
				n6R9Wx = n6R9Wx;
				e1TFq = (e1TFq0)dy0c.n;
			}
			finally
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)((Dy0c)((Kx43)null).K).b) + unchecked((nuint)(UIntPtr)bs0e1Z.b) == 0)
					{
						_ = (e1TFq0)xj24Mt.n;
					}
				}
				catch
				{
					while (dy0c.b != null)
					{
						q9D = q9D;
					}
				}
				goto IL_034e;
			}
		}
		IL_034e:
		We04 we;
		do
		{
			we = null;
			we = null;
		}
		while (obj4 != null);
		e1TFq = e1TFq;
		_ = (Bs0e1Z)((f0N2)null).F;
		we = (We04)dw0j.n;
		try
		{
		}
		finally
		{
			try
			{
				_ = (s2QH)bs0e1Z.K;
			}
			catch
			{
				c4G3Tk c4G3Tk = c4G3Tk;
				c4G3Tk = null;
			}
			goto IL_03aa;
		}
		IL_071a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		checked
		{
			try
			{
				_ = (c4G3Tk)kx.K;
				return;
			}
			finally
			{
				if (num * (num * num) == 0 && unchecked((nuint)(UIntPtr)xj24Mt.J) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (g4WRd3)xj24Mt.K;
				}
				return;
			}
		}
		IL_0562:
		if ((UIntPtr)Ef3a.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (num == 0)
				{
					_ = (n1CJ)cr.b;
				}
			}
			while (obj4 != null);
		}
		else
		{
			try
			{
				if (num == 0)
				{
					_ = (Bs0e1Z)((Cr38)((Kx43)null).J).b;
				}
				else
				{
					_ = (Xj24Mt)((f0N2)((e1TFq0)((Xj24Mt)e1TFq.K).b).F).F;
					z5TS obj11 = (z5TS)dw0j.K;
					z5TS z5TS = z5TS;
					z5TS = obj11;
					z5TS = (z5TS)e1TFq.J;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (g4WRd3)((Xj24Mt)null).F;
					_ = (g4WRd3)Ef3a.Default;
					_ = (Qs58)((Bs0e1Z)null).K;
				}
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)((f0N2)((Bs0e1Z)((Xj24Mt)null).n).K).b) + unchecked((nuint)(UIntPtr)((Kx43)null).F) == 0)
			{
				try
				{
					do
					{
						bs0e1Z = bs0e1Z;
					}
					while (bs0e1Z.n != null);
				}
				finally
				{
					goto IL_071a;
				}
			}
		}
		try
		{
			if ((UIntPtr)e1TFq.J == (UIntPtr)(nuint)0u)
			{
				f0N2 f0N = null;
				_ = (Kx43)kx.b;
			}
			else
			{
				cr = (Cr38)dy0c.n;
			}
		}
		catch
		{
			try
			{
				_ = (Dy0c)((Bs0e1Z)((e1TFq0)null).n).b;
				_ = (Cr38)qs.n;
			}
			catch
			{
				_ = (q9D2)n1CJ.J;
				_ = (s2QH)dw0j.K;
			}
		}
		goto IL_071a;
		IL_04c9:
		try
		{
			try
			{
				try
				{
					n6R9Wx = n6R9Wx;
				}
				catch
				{
					f0N2 f0N = f0N;
					f0N = f0N;
				}
			}
			catch
			{
				try
				{
					_ = (Jy71To)((Cr38)qs.K).n;
				}
				finally
				{
					_ = (x6WSe8)((f0N2)null).b;
					goto end_IL_04eb;
				}
				end_IL_04eb:;
			}
		}
		catch
		{
			try
			{
				cr = null;
				p1HNe = null;
			}
			finally
			{
				do
				{
					_ = (g4WRd3)m4DM.J;
				}
				while (obj4 != null);
				goto end_IL_0519;
			}
			end_IL_0519:;
		}
		try
		{
			if (num == 0)
			{
				_ = (g4WRd3)cr.b;
			}
		}
		finally
		{
			ef3a = ef3a;
			goto IL_0562;
		}
		IL_03aa:
		_ = (_003CModule_003E)n1CJ.b;
		if (num == 0)
		{
			nuint num2 = num;
			num = default(UIntPtr);
			if (num2 / num / num == 0)
			{
				do
				{
					we = we;
				}
				while (obj4 != null);
			}
			else
			{
				try
				{
					_ = (We04)bs0e1Z.J;
				}
				catch
				{
					n6R9Wx = null;
				}
			}
		}
		else
		{
			qs = qs;
		}
		checked
		{
			try
			{
				s2QH obj19 = (s2QH)((m4DM)((f0N2)qs.n).n).F;
				s2QH s2QH = s2QH;
				s2QH = obj19;
			}
			finally
			{
				try
				{
					we = (We04)((Bs0e1Z)(object)Ef3a.Default).n;
				}
				finally
				{
					if (num * unchecked((nuint)(UIntPtr)dy0c.F) == 0)
					{
						Jy71To jy71To = jy71To;
						jy71To = jy71To;
						kx = (Kx43)((Qs58)n1CJ.b).F;
						kx = null;
						q9D = null;
						_ = (Xj24Mt)dy0c.b;
					}
					else
					{
						_ = (i3C0Qc)cr.n;
					}
					goto IL_04c9;
				}
			}
		}
	}
}
