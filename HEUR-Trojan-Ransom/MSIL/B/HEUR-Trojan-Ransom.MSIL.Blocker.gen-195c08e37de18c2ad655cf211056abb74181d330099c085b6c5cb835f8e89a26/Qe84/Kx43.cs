using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Ba95Nn;
using Cp6r3F;
using Mg3e;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using Ta50;
using b1D6So;
using o6FHd3;

namespace Qe84;

public class Kx43
{
	private object T;

	private object m_n;

	private object O;

	private object s;

	private object k;

	private object V;

	private object H;

	private object E;

	private object I;

	private object R;

	private object d;

	private object Q;

	private object B;

	private object a;

	private object m_J;

	private object w;

	private object y;

	private object Z;

	private object nT;

	private object nO;

	private e1TFq0.Hc4m6Q r;

	public object K
	{
		get
		{
			return s;
		}
		set
		{
			s = RuntimeHelpers.GetObjectValue(value);
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
			return V;
		}
		set
		{
			V = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object n
	{
		get
		{
			return r.y;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			r.y = objectValue;
		}
	}

	public object J
	{
		get
		{
			return H;
		}
		set
		{
			H = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Kx43()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		r.V = (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null);
	}

	private void Kp9q()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		r.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand("Select * From PatientTb", r.V);
		object obj = (object)new SqlDataAdapter((SqlCommand)cloneable);
		IListSource listSource = new DataTable();
		((DbDataAdapter)((obj is SqlDataAdapter) ? obj : null)).Fill((DataTable)listSource);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { (DataTable)listSource }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	public void y0D3()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		r.V.Open();
		IConvertible convertible = "select * from DiagnosisTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(convertible as string, r.V);
		object obj = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill(obj as DataSet);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { ((DataSet)obj).Tables[0] }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	private void Jz06()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		r.V.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", r.V);
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		ISerializable serializable = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(serializable as DataTable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { serializable as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	private void e3T2(object sender, EventArgs e)
	{
		Kp9q();
		Jz06();
		m4D1();
	}

	private void Dn1s(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		r.V.Open();
		IEquatable<string> equatable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(equatable as string, r.V);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		r.V.Close();
	}

	private void o3C1(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, r.V);
		new DataTable();
		IDataReader dataReader = (IDataReader)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
		while (((SqlDataReader)dataReader).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		r.V.Close();
	}

	internal void Sf9m()
	{
		throw new NotImplementedException();
	}

	private void y6QL(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(comparable as string, r.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Ds5d(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(r.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void a2JL(object sender, EventArgs e)
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
		r.V.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable2 = (ICloneable)new SqlCommand((string)cloneable, r.V);
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Ew07(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Zp8g(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void i1F8(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void s8Z6(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void d4TM(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(r.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	public void Pw24()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		object obj = "select * from DoctorTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)obj, r.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(Q, (Type)null, "DataSource", new object[1] { ((DataSet)xmlSerializable).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void y8PJ(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(r.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Gr08(object sender, EventArgs e)
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
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void o0BH(object sender, EventArgs e)
	{
		m4D1();
	}

	private void g4C7(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void Pg3y(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Pe4t(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void r5A8(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Et4d()
	{
		throw new NotImplementedException();
	}

	private void Mr9q(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(a, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(r.S, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(r.R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r.B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	public void i1WJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IEnumerable enumerable = "select * from PatientTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)enumerable, r.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(r.w, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Cy74(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(a, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(r.S, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void q0D6(object sender, EventArgs e)
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
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Rx5d(object sender, EventArgs e)
	{
		m4D1();
	}

	private void Wk41(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Tj8z(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void f3S7(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void d9Y2(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void z5A0()
	{
		throw new NotImplementedException();
	}

	private void Aj4k(object sender, EventArgs e)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)convertible, r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	public void Zy7g()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IComparable<string> comparable = "select * from ReceptionistTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)comparable, r.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(r.k, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void c7Z0(object sender, EventArgs e)
	{
		m4D1();
	}

	private void w6JQ(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Tm94(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(obj as string, r.V);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Hw1t(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void m1Y5(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Hj02(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Mn59(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void q5A1()
	{
		throw new NotImplementedException();
	}

	private void f5AR(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, r.V);
		cloneable = (ICloneable)new SqlCommand(enumerable as string, r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	public void m4D1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IEnumerable<char> enumerable = "select * from TreatmentTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter((string)enumerable, r.V);
		ISerializable serializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)serializable);
		NewLateBinding.LateSet(r.f, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Gk6e(object sender, EventArgs e)
	{
		m4D1();
	}

	private void Yx86(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void q7N5(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand(cloneable as string, r.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		m4D1();
	}

	private void Te5m(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Sp1z(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void f9WT(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Xk0o(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void o8HQ()
	{
		throw new NotImplementedException();
	}

	internal static void Ap3y(Jy71To.g6BLq5 g6BLq5_0, int int_0, string string_0, bool bool_0)
	{
		if (int_0 <= 0)
		{
			return;
		}
		checked
		{
			int_0 *= 5;
			if (string_0 == null)
			{
				return;
			}
			string_0 = string_0.Remove(0, 3);
			if (bool_0)
			{
				return;
			}
			bool_0 = true;
			object t = g6BLq5_0.T;
			Array array = t as object[];
			for (int i = 0; i < (array as object[]).Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue((array as object[])[i]);
				try
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(g6BLq5_0.T, (Type)null, "GetManifestResourceStream", new object[1] { Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue)) }, (string[])null, (Type[])null, (bool[])null));
					object obj = Math.Abs(178176);
					if (Operators.ConditionalCompareObjectEqual((object)Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null))), obj, false))
					{
						g6BLq5_0.w = (byte[])n1CJ.Jm3j(RuntimeHelpers.GetObjectValue(obj), null);
						((Stream)objectValue2).ReadAsync(g6BLq5_0.w, 0, Conversions.ToInteger(obj)).Wait();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Qs58.c9X2(bool_0: false, 15, g6BLq5_0, 210);
		}
	}
}
