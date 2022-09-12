using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Ba95Nn;
using Cp6r3F;
using Gn65;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using b1D6So;
using o6FHd3;

namespace Kp62Wz;

public class Xj24Mt
{
	private object T;

	private object m;

	private object O;

	private object k;

	private object U;

	private object E;

	private object x;

	private object d;

	private object Q;

	private object B;

	private object m_J;

	private object G;

	private object f;

	private object Z;

	private object nm;

	private object ns;

	private We04.Xx56 v = new We04.Xx56();

	public object K
	{
		get
		{
			return v.M;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			v.M = objectValue;
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
			return v.s;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			v.s = objectValue;
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
			return v.G;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			v.G = objectValue;
		}
	}

	public Xj24Mt()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		v.c = (SqlConnection)cloneable;
	}

	private void w7NAd2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		v.c.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand("Select * From PatientTb", v.c);
		ICloneable cloneable2 = (ICloneable)new SqlDataAdapter((SqlCommand)cloneable);
		ISupportInitialize supportInitialize = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)cloneable2).Fill((DataTable)supportInitialize);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { supportInitialize as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		v.c.Close();
	}

	public void Lq01Ef()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		v.c.Open();
		IComparable comparable = "select * from DiagnosisTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)comparable, v.c);
		IListSource listSource = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill((DataSet)listSource);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { (listSource as DataSet).Tables[0] }, (string[])null, (Type[])null, false, true);
		v.c.Close();
	}

	private void k9Z5Xs()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		v.c.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", v.c);
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter((SqlCommand)obj);
		object obj2 = new DataTable();
		((DbDataAdapter)((dataAdapter is SqlDataAdapter) ? dataAdapter : null)).Fill((DataTable)obj2);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { obj2 as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		v.c.Close();
	}

	private void Bp7k0G(object sender, EventArgs e)
	{
		w7NAd2();
		k9Z5Xs();
		Rz2a1W();
	}

	private void Kn3p9F(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IComparable comparable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)comparable, v.c);
		new DataTable();
		object obj = ((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((obj is SqlDataReader) ? obj : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)obj).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		v.c.Close();
	}

	private void x5LPs6(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IConvertible convertible = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(convertible as string, v.c);
		new DataTable();
		object obj = ((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)obj).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((obj is SqlDataReader) ? obj : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		v.c.Close();
	}

	internal void Dq72Lb()
	{
		throw new NotImplementedException();
	}

	private void Gk6o9X(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(v.r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		object obj = (object)new SqlCommand(comparable as string, v.c);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Gj47Mn(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(v.r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(m, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(O, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Lm67Wo(object sender, EventArgs e)
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
		v.c.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(T, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(equatable as string, v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Ep5t8A(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Ay8e6G(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Qs3x7D(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Ds1r3A(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void p9B6Yk(object sender, EventArgs e)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(v.d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(v.Q, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(v.a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		object obj = (object)new SqlCommand((string)enumerable, v.c);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	public void m3TSk6()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		v.c.Open();
		IEnumerable enumerable = "select * from DoctorTb";
		object obj = (object)new SqlDataAdapter((string)enumerable, v.c);
		IListSource listSource = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)obj).Fill((DataSet)listSource);
		NewLateBinding.LateSet(Q, (Type)null, "DataSource", new object[1] { (listSource as DataSet).Tables[0] }, (string[])null, (Type[])null);
		v.c.Close();
	}

	private void Bd7e1W(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(v.d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(v.Q, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(v.a, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), v.c);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void q9ZTd8(object sender, EventArgs e)
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
		v.c.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Gq6t4H(object sender, EventArgs e)
	{
		Rz2a1W();
	}

	private void Dc06Ka(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	private void w0ECs3(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Sd2y9D(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void j8H7Pa(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void i3S5Pe()
	{
		throw new NotImplementedException();
	}

	private void Ry2b4N(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(v.l, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(v.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(v.E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.m_J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)comparable, v.c);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	public void Te46Yp()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		v.c.Open();
		object obj = "select * from PatientTb";
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter(obj as string, v.c);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill((DataSet)marshalByValueComponent);
		NewLateBinding.LateSet(f, (Type)null, "DataSource", new object[1] { ((DataSet)marshalByValueComponent).Tables[0] }, (string[])null, (Type[])null);
		v.c.Close();
	}

	private void a3FEf5(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.E, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(v.l, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(v.f, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), v.c);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void x2P7Qt(object sender, EventArgs e)
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
		v.c.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(B, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		object obj2 = (object)new SqlCommand((string)obj, v.c);
		((SqlCommand)obj2).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void e1S9Lk(object sender, EventArgs e)
	{
		Rz2a1W();
	}

	private void Fj3k9T(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Qq4p5C(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void b8N7Hn(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void a3M5Gs(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void i6H8Mn()
	{
		throw new NotImplementedException();
	}

	private void b8QJr2(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(v.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(v.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(v.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	public void b6C5Ht()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		v.c.Open();
		IConvertible convertible = "select * from ReceptionistTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(convertible as string, v.c);
		IListSource listSource = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill(listSource as DataSet);
		NewLateBinding.LateSet(v.U, (Type)null, "DataSource", new object[1] { (listSource as DataSet).Tables[0] }, (string[])null, (Type[])null);
		v.c.Close();
	}

	private void Rs19Er(object sender, EventArgs e)
	{
		Rz2a1W();
	}

	private void Ex9e8S(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(v.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(v.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(v.o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(v.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), v.c);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void n0JXo8(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(v.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(v.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(comparable as string, v.c);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Po20Ki(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Cn1x4Y(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void c6Q0Ya(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Jc58Qm(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void o1P3Mp()
	{
		throw new NotImplementedException();
	}

	private void Aj8y1M(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		v.c.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(nm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(v.i, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, v.c);
		cloneable = (ICloneable)new SqlCommand((string)obj, v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	public void Rz2a1W()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		v.c.Open();
		object obj = "select * from TreatmentTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)obj, v.c);
		ISupportInitializeNotification supportInitializeNotification = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill((DataSet)supportInitializeNotification);
		NewLateBinding.LateSet(v.t, (Type)null, "DataSource", new object[1] { (supportInitializeNotification as DataSet).Tables[0] }, (string[])null, (Type[])null);
		v.c.Close();
	}

	private void z3XTc6(object sender, EventArgs e)
	{
		Rz2a1W();
	}

	private void d7QHp8(object sender, EventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(nm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(v.i, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(v.i, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(ns, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(nm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), v.c);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void Nq21Jr(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(nm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		v.c.Open();
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(nm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, v.c);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		v.c.Close();
		Rz2a1W();
	}

	private void f9A8Kc(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void p4LRm8(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void b1BQp8(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void f5JKm3(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void Pr54Fz()
	{
		throw new NotImplementedException();
	}
}
