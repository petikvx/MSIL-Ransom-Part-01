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
using Xf6w;
using b1D6So;
using f1W6;
using f3W1Tn;
using i1J6;
using i6NP;
using n8Z0;
using o6FHd3;
using r7D4Eb;
using r9R2;
using t7JR;
using t8KCs3;
using x4K5;

namespace Ta50;

public class n1CJ
{
	internal sealed class n6RK
	{
		internal object v;

		internal object H;

		internal object Y;

		internal n6RK()
		{
		}
	}

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

	private x6WSe8.r0Y8Nt q = new x6WSe8.r0Y8Nt();

	public object K
	{
		get
		{
			return q.M;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q.M = objectValue;
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
			return q.k;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q.k = objectValue;
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
			return q.Y;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q.Y = objectValue;
		}
	}

	public n1CJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		q.U = (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null);
	}

	private void Ro71()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		q.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand("Select * From PatientTb", q.U);
		object obj = (object)new SqlDataAdapter((SqlCommand)cloneable);
		IListSource listSource = new DataTable();
		((DbDataAdapter)((obj is SqlDataAdapter) ? obj : null)).Fill((DataTable)listSource);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { (DataTable)listSource }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		q.U.Close();
	}

	public void i8S5()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		q.U.Open();
		IConvertible convertible = "select * from DiagnosisTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(convertible as string, q.U);
		object obj = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill(obj as DataSet);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { ((DataSet)obj).Tables[0] }, (string[])null, (Type[])null, false, true);
		q.U.Close();
	}

	private void Li50()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		q.U.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", q.U);
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		ISerializable serializable = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(serializable as DataTable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { serializable as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		q.U.Close();
	}

	private void Yf6c(object sender, EventArgs e)
	{
		Ro71();
		Li50();
		z6BQ();
	}

	private void Bp85(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		q.U.Open();
		IEquatable<string> equatable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(equatable as string, q.U);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		q.U.Close();
	}

	private void y4FK(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		object obj = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, q.U);
		new DataTable();
		IDataReader dataReader = (IDataReader)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
		while (((SqlDataReader)dataReader).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		q.U.Close();
	}

	internal void Rm39()
	{
		throw new NotImplementedException();
	}

	private void z1B4(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(comparable as string, q.U);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void y0B3(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(this.m_n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(q.O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), q.U);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Jd2e(object sender, EventArgs e)
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
		q.U.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable2 = (ICloneable)new SqlCommand((string)cloneable, q.U);
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Gn76(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Nt10(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void d4L6(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void f3S7(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Gz4p(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(q.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, q.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	public void a8KZ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		q.U.Open();
		object obj = "select * from DoctorTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)obj, q.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(q.c, (Type)null, "DataSource", new object[1] { ((DataSet)xmlSerializable).Tables[0] }, (string[])null, (Type[])null);
		q.U.Close();
	}

	private void n8Z3(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(R, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(q.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(q.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), q.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void s7E9(object sender, EventArgs e)
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
		q.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, q.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Zz37(object sender, EventArgs e)
	{
		z6BQ();
	}

	private void s6JA(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void e2Q8(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Pm26(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Gf31(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Zg80()
	{
		throw new NotImplementedException();
	}

	private void Za38(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(q.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(q.E, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(q.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, q.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	public void Ed98()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		q.U.Open();
		IEnumerable enumerable = "select * from PatientTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)enumerable, q.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(q.S, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		q.U.Close();
	}

	private void o5X8(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(q.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(q.E, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), q.U);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void y8EQ(object sender, EventArgs e)
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
		q.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, q.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Fp8k(object sender, EventArgs e)
	{
		z6BQ();
	}

	private void Jk9e(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void f7Z8(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void f1QZ(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void a0S1(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void n4Y1()
	{
		throw new NotImplementedException();
	}

	private void s4X2(object sender, EventArgs e)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(q.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(q.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)convertible, q.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	public void k4W1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		q.U.Open();
		IComparable<string> comparable = "select * from ReceptionistTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)comparable, q.U);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(nn, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		q.U.Close();
	}

	private void Fs2x(object sender, EventArgs e)
	{
		z6BQ();
	}

	private void Mn19(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(q.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(q.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(q.Q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(q.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), q.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Xz05(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(q.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(q.I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(obj as string, q.U);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Tc07(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void s0XL(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void x6E9(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Bo24(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void Zs92()
	{
		throw new NotImplementedException();
	}

	private void b6JL(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		q.U.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(q.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(q.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, q.U);
		cloneable = (ICloneable)new SqlCommand(enumerable as string, q.U);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	public void z6BQ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		q.U.Open();
		IEnumerable<char> enumerable = "select * from TreatmentTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter((string)enumerable, q.U);
		ISerializable serializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)serializable);
		NewLateBinding.LateSet(nk, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		q.U.Close();
	}

	private void To9n(object sender, EventArgs e)
	{
		z6BQ();
	}

	private void c9W0(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(q.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(q.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(q.j, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(q.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), q.U);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void Sb27(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(q.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		q.U.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(q.t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj = (object)new SqlCommand(cloneable as string, q.U);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		q.U.Close();
		z6BQ();
	}

	private void c8AZ(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void s0M6(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void Xn21(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void En18(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void n2S5()
	{
		throw new NotImplementedException();
	}

	internal static object Jm3j(object object_0, object object_1)
	{
		return new byte[checked(Conversions.ToInteger(Operators.SubtractObject(object_0, (object)1)) + 1)];
	}

	static void Ha4q()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		We04 we;
		try
		{
			num = num;
			if (num == 0)
			{
				_ = (Xj24Mt)((n1CJ)null).n;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				kx = kx;
				_ = (Ef3a)kx.K;
				Ef3a ef3a = (Ef3a)((Dy0c)null).F;
				ef3a = ef3a;
			}
		}
		finally
		{
			We04 obj = (We04)((e1TFq0)kx.n).J;
			we = (We04)(object)Ef3a.Default;
			we = obj;
			goto IL_0086;
		}
		IL_0086:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		try
		{
			while (true)
			{
				obj2 = Ef3a.Default;
				if (obj2 != null)
				{
					if (num == 0)
					{
						Ef3a ef3a = null;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			cr = cr;
			cr = cr;
			goto IL_00bd;
		}
		IL_00bd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		Dw0j dw0j;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z5TS z5TS);
		checked
		{
			try
			{
				nuint num2 = num;
				m4DM = (m4DM)kx.n;
				if (num2 + unchecked((nuint)(UIntPtr)((Kx43)m4DM.b).J) == 0)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
					while (true)
					{
						bs0e1Z = bs0e1Z;
						if (bs0e1Z.K != null)
						{
							_ = (f0N2)((Cr38)null).J;
							continue;
						}
						break;
					}
				}
				else
				{
					do
					{
						_ = (Qs58)kx.b;
					}
					while (obj2 != null);
				}
			}
			finally
			{
				_ = (_003CModule_003E)((n1CJ)null).K;
				dw0j = null;
				_ = (_003CModule_003E)((Dy0c)dw0j.b).J;
				qs = qs;
				_ = (f0N2)qs.F;
				z5TS = z5TS;
				z5TS = z5TS;
				goto IL_0181;
			}
		}
		IL_0181:
		_ = (f0N2)qs.n;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c4G3Tk c4G3Tk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9D2 q9D);
		do
		{
			try
			{
				try
				{
					dy0c = dy0c;
					n1CJ2 = (n1CJ)((Qs58)((Xj24Mt)dy0c.F).n).b;
					Xj24Mt xj24Mt = (Xj24Mt)n1CJ2.J;
					_ = (Cr38)((e1TFq0)xj24Mt.b).n;
				}
				finally
				{
					_ = (p1HNe2)dy0c.F;
					goto end_IL_0191;
				}
				end_IL_0191:;
			}
			catch
			{
				nuint num3 = num;
				num = default(UIntPtr);
				if (checked(num3 * num) == 0)
				{
					c4G3Tk = null;
					c4G3Tk = c4G3Tk;
					_ = (q9D2)m4DM.F;
					_ = (c4G3Tk)((Kx43)null).F;
					q9D2 obj3 = (q9D2)((Dy0c)m4DM.F).K;
					q9D = q9D;
					q9D = obj3;
				}
				else
				{
					e1TFq0 obj4 = (e1TFq0)((Qs58)((Qs58)null).J).F;
					e1TFq = (e1TFq0)((Dw0j)null).J;
					e1TFq = obj4;
				}
			}
		}
		while (obj2 != null);
		_ = (Kx43)((Kx43)null).F;
		UIntPtr num4 = (UIntPtr)((f0N2)cr.b).F;
		num = default(UIntPtr);
		checked
		{
			if ((unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num4) - num - unchecked((nuint)(UIntPtr)((f0N2)null).n))) * num + (num - unchecked((nuint)(UIntPtr)kx.F)) == 0)
			{
				if (num == 0)
				{
					_ = (Jy71To)qs.K;
				}
				else
				{
					e1TFq = (e1TFq0)((Dw0j)null).n;
				}
			}
			try
			{
				we = we;
			}
			finally
			{
				try
				{
					Bs0e1Z bs0e1Z = (Bs0e1Z)qs.b;
				}
				catch
				{
					try
					{
						_ = (s2QH)((Bs0e1Z)null).F;
					}
					catch
					{
						_ = (We04)dw0j.J;
					}
				}
				goto IL_036e;
			}
		}
		IL_036e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s8PZ s8PZ);
		if (num == 0)
		{
			nuint num5 = num;
			num = default(UIntPtr);
			if (num5 / num == 0)
			{
				s8PZ = s8PZ;
				s8PZ = s8PZ;
			}
		}
		else
		{
			s2QH s2QH = null;
			s2QH = s2QH;
		}
		try
		{
			do
			{
				if (num == 0)
				{
					m4DM = (m4DM)((Dy0c)null).J;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					z5TS = z5TS;
					_ = (We04)(object)Ef3a.Default;
					e1TFq = e1TFq;
					_ = (i3C0Qc)((n1CJ)e1TFq.J).n;
				}
				else
				{
					_ = (m4DM)((e1TFq0)null).n;
				}
			}
			finally
			{
				goto IL_0428;
			}
		}
		IL_0428:
		_ = (q9D2)((f0N2)null).b;
		f0N2 f0N = f0N;
		s8PZ = (s8PZ)f0N.J;
		do
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				try
				{
					_ = (e1TFq0)cr.n;
				}
				catch
				{
					m4DM = m4DM;
				}
			}
		}
		while (obj2 != null);
		if ((UIntPtr)((f0N2)dw0j.b).K == (UIntPtr)(nuint)0u)
		{
			_ = (g4WRd3)((e1TFq0)((Dy0c)null).n).F;
		}
		else
		{
			Ef3a ef3a = null;
		}
		if (num == 0)
		{
			try
			{
				while (obj2 != null)
				{
					c4G3Tk = c4G3Tk;
				}
			}
			catch
			{
				do
				{
					_ = (z5TS)((Xj24Mt)(object)Ef3a.Default).b;
					dw0j = dw0j;
					_ = (f0N2)((m4DM)m4DM.n).J;
					q9D = (q9D2)((Dy0c)e1TFq.b).K;
				}
				while (((n1CJ)null).b != null);
			}
		}
		try
		{
			x6WSe8 x6WSe = null;
			x6WSe = x6WSe;
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					s8PZ = null;
				}
				else
				{
					_ = (Kx43)((Dw0j)(object)Ef3a.Default).F;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					i3C0Qc i3C0Qc = i3C0Qc;
					i3C0Qc = default(i3C0Qc);
					we = we;
					_ = (Kx43)((Cr38)null).b;
					_ = (Ef3a)((m4DM)n1CJ2.b).F;
				}
				else
				{
					cr = cr;
				}
			}
		}
	}

	static void j9EY()
	{
		object obj = null;
		Xj24Mt xj24Mt = xj24Mt;
		_ = (g4WRd3)xj24Mt.F;
		_ = (Qs58)(object)Ef3a.Default;
		m4DM m4DM;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out p1HNe2 p1HNe);
			do
			{
				try
				{
					p1HNe2 obj2 = (p1HNe2)xj24Mt.b;
					p1HNe = p1HNe;
					p1HNe = obj2;
				}
				catch
				{
					_ = (Ef3a)((Dy0c)null).F;
				}
			}
			while (obj != null);
		}
		finally
		{
			m4DM = null;
			m4DM = m4DM;
			goto IL_006b;
		}
		IL_006b:
		Kx43 kx = kx;
		kx = kx;
		_ = (Bs0e1Z)m4DM.J;
		kx = kx;
		_ = (m4DM)((Qs58)null).b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		while (obj != null)
		{
			do
			{
				cr = cr;
				xj24Mt = (Xj24Mt)cr.K;
			}
			while (obj != null);
		}
		while (obj != null || obj != null)
		{
		}
		nuint num = (UIntPtr)Ef3a.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num == 0)
		{
			while (obj != null)
			{
				if (num / (nuint)(UIntPtr)((f0N2)null).K == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		_ = (m4DM)((Dy0c)null).K;
		num = default(UIntPtr);
		if (checked(num + (num - num)) == 0)
		{
			do
			{
				cr = cr;
			}
			while ((object)Ef3a.Default != null);
		}
		_003CModule_003E = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		_ = (f0N2)dy0c.F;
		n6R9Wx obj4 = (n6R9Wx)(object)Ef3a.Default;
		n6R9Wx n6R9Wx = n6R9Wx;
		n6R9Wx = obj4;
		Bs0e1Z bs0e1Z = null;
		n6R9Wx = (n6R9Wx)bs0e1Z.n;
		s8PZ s8PZ = (s8PZ)((Qs58)null).F;
		s8PZ = s8PZ;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		try
		{
			if ((UIntPtr)xj24Mt.F == (UIntPtr)(nuint)0u)
			{
				if (num / checked(unchecked((nuint)(UIntPtr)Ef3a.Default) * num) == 0)
				{
					e1TFq = null;
					_ = (g4WRd3)e1TFq.b;
				}
				else
				{
					dy0c = (Dy0c)((Dw0j)(object)Ef3a.Default).b;
				}
			}
		}
		catch
		{
			if ((UIntPtr)e1TFq.K == (UIntPtr)(nuint)0u)
			{
				_ = (f0N2)dy0c.n;
			}
		}
		n1CJ n1CJ2 = null;
		n1CJ2 = n1CJ2;
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qs58)((e1TFq0)((m4DM)null).J).n;
					_ = (n1CJ)((Xj24Mt)((Kx43)((n1CJ)((Cr38)null).K).F).J).J;
					p1HNe2 p1HNe = (p1HNe2)(object)Ef3a.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Cr38)((e1TFq0)dy0c.b).b;
				}
				while (((Xj24Mt)dy0c.J).J != null);
			}
		}
		catch
		{
			try
			{
				We04 we = null;
				we = we;
			}
			catch
			{
			}
		}
	}
}
