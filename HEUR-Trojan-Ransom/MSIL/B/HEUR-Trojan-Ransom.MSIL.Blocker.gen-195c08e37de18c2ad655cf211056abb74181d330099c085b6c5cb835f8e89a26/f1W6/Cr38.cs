using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Ba95Nn;
using Cp6r3F;
using Eg7s4Q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using b1D6So;
using o6FHd3;

namespace f1W6;

public class Cr38
{
	private object T;

	private object m_n;

	private object s;

	private object k;

	private object V;

	private object U;

	private object E;

	private object I;

	private object R;

	private object p;

	private object Q;

	private object B;

	private object a;

	private object C;

	private object G;

	private object y;

	private object Z;

	private object nT;

	private object nn;

	private object ns;

	internal static i3C0Qc b/* Not supported: data(26 72 D7 D4 22 53 46 ED 43 56 48 0A 0D 0C 80 88 38 7F 79 C3 D6 27 91 E9 B0 E8 E8 31 30 24 10 E7 81 50 53 22 35 78 0C 46 FC 05 BB 9D E4 11 C7 39 EE 7E EB D5 0D FA CB 6C 71 AF 28 E8 2B E2 0D 11 4A 8B 85 7C 75 5A 8E 83 0F DA 10 FD 50 35 71 C6 91 1D D4 AC FF 13 5F 32 93 01 CA 16 C2 B9 FD A1 21 67 D2 2B 33 F0 15 96 1F E7 5C F0 FC 20 6A D4 F2 C2 5B 19 58 6E 57 80 39 10 40 9F 0E D9 0F 97 4C E1 C8 16 46 5E 2B 6C 72 D7 A1 A0 01 0D 6F 53 02 ED C2 B1 7B 28 26 59 BC 89 83 DF 33 38 23 68 28 1C 10 58 A9 05 9E 83 F3 F7 15 4C ED 29 ED 9A 89 5B 0A 86 9A C0 B3 C0 B8 8E F8 B4 37 B6 4F 7E C5 D3 EF 7C 11 51 CA EA 83 B8 97 4D 89 CA 7F C6 D1 1E C4 9C 12 A9 5C 35 E1 C7 D4 C7 AD 4A 6D E3 27 E1 35 06 2F 64 28 B8 96 99 6F 55 1A 9F 36 95 DA EC 58 C3 A2 10 68 51 05 E0 4C 4C B5 C4 09 38 8A FB 2A AA 60 85 CC 0C 72 8E 67 4D 9E AF 90 CE 85 8D 28 3F CC 64 2E 5B 02 A3 8F F4 0A D3 B3 93 5C 3B 2B DD 8B DF 82 88 C8 50 0E FE B8 E4 55 7E D3 DD DA BB EF FD 29 F5 F4 3C 21 79 79 E6 84 D2 0E D8 08 71 D1 39 B7 1D 73 42 E1 3D) */;

	internal static char[] O;

	private e1TFq0.Hc4m6Q u;

	public object K
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

	public object F
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

	public object b
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

	public object n
	{
		get
		{
			return u.y;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			u.y = objectValue;
		}
	}

	public object J
	{
		get
		{
			return E;
		}
		set
		{
			E = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Cr38()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		object obj = (object)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		u.V = (SqlConnection)((obj is SqlConnection) ? obj : null);
	}

	private void De72()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		u.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand("Select * From PatientTb", u.V);
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter((SqlCommand)(object)((dbCommand is SqlCommand) ? dbCommand : null));
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		((DbDataAdapter)((dataAdapter is SqlDataAdapter) ? dataAdapter : null)).Fill(marshalByValueComponent as DataTable);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { marshalByValueComponent as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		u.V.Close();
	}

	public void t0X9()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		u.V.Open();
		IEnumerable enumerable = "select * from DiagnosisTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter(enumerable as string, u.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)xmlSerializable);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { ((DataSet)xmlSerializable).Tables[0] }, (string[])null, (Type[])null, false, true);
		u.V.Close();
	}

	private void Jq7a()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		u.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand("Select * From TreatmentTb", u.V);
		object obj = (object)new SqlDataAdapter((SqlCommand)dbCommand);
		IXmlSerializable xmlSerializable = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)obj).Fill((DataTable)xmlSerializable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { (DataTable)xmlSerializable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		u.V.Close();
	}

	private void g0PJ(object sender, EventArgs e)
	{
		De72();
		Jq7a();
		j5CE();
	}

	private void q1TS(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		IComparable<string> comparable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)comparable, u.V);
		new DataTable();
		IDataRecord dataRecord = (IDataRecord)((SqlCommand)dbCommand).ExecuteReader();
		while (((SqlDataReader)((dataRecord is SqlDataReader) ? dataRecord : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)((dataRecord is SqlDataReader) ? dataRecord : null)).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		u.V.Close();
	}

	private void Bq30(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		IEnumerable enumerable = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		object obj = (object)new SqlCommand(enumerable as string, u.V);
		new DataTable();
		IDataRecord dataRecord = (IDataRecord)((SqlCommand)obj).ExecuteReader();
		while (((SqlDataReader)dataRecord).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)dataRecord).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		u.V.Close();
	}

	internal void j4HG()
	{
		throw new NotImplementedException();
	}

	private void k4FS(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(u.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(s, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		object obj = (object)new SqlCommand(comparable as string, u.V);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Mo20(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(u.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(s, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(u.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(s, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), u.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Sw6g(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Diagnosis ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(obj as string, u.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void k8S0(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void a9M4(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void s0A8(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void d7J8(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Gc8y(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(p, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(u.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(u.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(equatable as string, u.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	public void Ht02()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		u.V.Open();
		IEnumerable enumerable = "select * from DoctorTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter(enumerable as string, u.V);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null).Fill((DataSet)marshalByValueComponent);
		NewLateBinding.LateSet(B, (Type)null, "DataSource", new object[1] { ((DataSet)marshalByValueComponent).Tables[0] }, (string[])null, (Type[])null);
		u.V.Close();
	}

	private void n4K7(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(u.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(p, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(u.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(u.L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), u.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void r3XD(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Doctor ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)convertible, u.V);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Nr07(object sender, EventArgs e)
	{
		j5CE();
	}

	private void g2B0(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void c8GT(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Nf0t(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Ft59(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Lw2i()
	{
		throw new NotImplementedException();
	}

	private void b6P3(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(C, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(u.S, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(u.R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(u.B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)cloneable, u.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	public void p5X3()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		u.V.Open();
		IComparable comparable = "select * from PatientTb";
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter(comparable as string, u.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)((dataAdapter is SqlDataAdapter) ? dataAdapter : null)).Fill((DataSet)xmlSerializable);
		NewLateBinding.LateSet(u.w, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		u.V.Close();
	}

	private void i4QC(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(u.B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(u.R, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(C, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(u.S, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), u.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Hg31(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Patient ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(equatable as string, u.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void j4KN(object sender, EventArgs e)
	{
		j5CE();
	}

	private void Zd7w(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void s3FA(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void k2X4(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void j2RN(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void Gk0q()
	{
		throw new NotImplementedException();
	}

	private void Cz47(object sender, EventArgs e)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(nn, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(convertible as string, u.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	public void s6F8()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		u.V.Open();
		IEnumerable enumerable = "select * from ReceptionistTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)enumerable, u.V);
		ISupportInitializeNotification supportInitializeNotification = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(supportInitializeNotification as DataSet);
		NewLateBinding.LateSet(u.k, (Type)null, "DataSource", new object[1] { ((DataSet)supportInitializeNotification).Tables[0] }, (string[])null, (Type[])null);
		u.V.Close();
	}

	private void o7QB(object sender, EventArgs e)
	{
		j5CE();
	}

	private void Fa6f(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(nn, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(nT, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(nn, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), u.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Bw01(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand((string)comparable, u.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void k1N8(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Rg2b(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void m0L5(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Xm25(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void Kd3s()
	{
		throw new NotImplementedException();
	}

	private void d4D2(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		u.V.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(u.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(u.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(cloneable as string, u.V);
		dbCommand = (DbCommand)new SqlCommand(cloneable as string, u.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	public void j5CE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		u.V.Open();
		object obj = "select * from TreatmentTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)obj, u.V);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(u.f, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		u.V.Close();
	}

	private void Fq12(object sender, EventArgs e)
	{
		j5CE();
	}

	private void Nm3w(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(u.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(u.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(u.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(u.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), u.V);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void Ha95(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(u.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		u.V.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(u.J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand(enumerable as string, u.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		u.V.Close();
		j5CE();
	}

	private void n0QX(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Af81(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void a2FK(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Yd1s(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void e6M2()
	{
		throw new NotImplementedException();
	}
}
