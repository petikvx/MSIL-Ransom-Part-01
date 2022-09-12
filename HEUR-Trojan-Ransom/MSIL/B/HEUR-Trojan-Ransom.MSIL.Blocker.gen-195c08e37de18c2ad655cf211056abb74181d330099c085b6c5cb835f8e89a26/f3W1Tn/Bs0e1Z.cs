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
using i1J6;
using i6NP;
using n8Z0;
using o6FHd3;
using r7D4Eb;
using r9R2;
using t7JR;
using t8KCs3;
using x4K5;

namespace f3W1Tn;

public class Bs0e1Z
{
	private object q;

	private object l;

	private object k;

	private object G;

	private object d;

	private object o;

	private object h;

	private object r;

	private object P;

	private object U;

	private object j;

	private object Y;

	private object c;

	private object V;

	private object W;

	private object Z;

	private object lq;

	private object ll;

	private object lN;

	private object lk;

	private object lG;

	private object lT;

	private c4G3Tk.n7E4Ze w = new c4G3Tk.n7E4Ze();

	public object K
	{
		get
		{
			return G;
		}
		set
		{
			G = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object F
	{
		get
		{
			return w.M;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			w.M = objectValue;
		}
	}

	public object b
	{
		get
		{
			return w.I;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			w.I = objectValue;
		}
	}

	public object n
	{
		get
		{
			return w.u;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			w.u = objectValue;
		}
	}

	public object J
	{
		get
		{
			return w.T;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			w.T = objectValue;
		}
	}

	public Bs0e1Z()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		w.j = (SqlConnection)cloneable;
	}

	private void j5G2Dn()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		w.j.Open();
		object obj = (object)new SqlCommand("Select * From PatientTb", w.j);
		IDbDataAdapter dbDataAdapter = (IDbDataAdapter)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		ISupportInitialize supportInitialize = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)dbDataAdapter).Fill(supportInitialize as DataTable);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { supportInitialize as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		w.j.Close();
	}

	public void p5PZg4()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		w.j.Open();
		IConvertible convertible = "select * from DiagnosisTb";
		object obj = (object)new SqlDataAdapter(convertible as string, w.j);
		ISerializable serializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)obj).Fill(serializable as DataSet);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null, false, true);
		w.j.Close();
	}

	private void z0G5Lf()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		w.j.Open();
		object obj = (object)new SqlCommand("Select * From TreatmentTb", w.j);
		object obj2 = (object)new SqlDataAdapter((SqlCommand)((obj is SqlCommand) ? obj : null));
		IXmlSerializable xmlSerializable = new DataTable();
		((DbDataAdapter)((obj2 is SqlDataAdapter) ? obj2 : null)).Fill(xmlSerializable as DataTable);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { xmlSerializable as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		w.j.Close();
	}

	private void x0R8Cb(object sender, EventArgs e)
	{
		j5G2Dn();
		z0G5Lf();
		Xj37Gs();
	}

	private void q7TSb0(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IEnumerable enumerable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		object obj = (object)new SqlCommand((string)enumerable, w.j);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)dbDataReader).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		w.j.Close();
	}

	private void a6Q8Do(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IConvertible convertible = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		DbCommand dbCommand = (DbCommand)new SqlCommand(convertible as string, w.j);
		new DataTable();
		IDisposable disposable = (IDisposable)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
		while (((SqlDataReader)((disposable is SqlDataReader) ? disposable : null)).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)disposable).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		w.j.Close();
	}

	internal void z6Q9Ci()
	{
		throw new NotImplementedException();
	}

	private void Bi0x2R(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(l, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(w.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(k, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)enumerable, w.j);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void r9J0Ds(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(l, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(w.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(k, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(l, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(w.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(k, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), w.j);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Je16Wj(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Diagnosis ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(comparable as string, w.j);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Ce3x4R(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void a8HTq4(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void Fm53Hc(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Fj3p4Z(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void e3WEs6(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(w.L, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(w.S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(h, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)convertible, w.j);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	public void Kg42Dp()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		w.j.Open();
		IConvertible convertible = "select * from DoctorTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter(convertible as string, w.j);
		object obj = new DataSet();
		((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null).Fill((DataSet)obj);
		NewLateBinding.LateSet(P, (Type)null, "DataSource", new object[1] { ((DataSet)obj).Tables[0] }, (string[])null, (Type[])null);
		w.j.Close();
	}

	private void Ga79Jx(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(h, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(w.L, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(w.S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(h, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(r, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), w.j);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Si73Am(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Doctor ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(d, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(enumerable as string, w.j);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Fe1g3L(object sender, EventArgs e)
	{
		Xj37Gs();
	}

	private void Rq6t0L(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	private void Xc8z9G(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Wj0n8M(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void r1XYq5(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Ng2j4Y()
	{
		throw new NotImplementedException();
	}

	private void Ew0i6N(object sender, EventArgs e)
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(j, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(w.c, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(Y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(c, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)comparable, w.j);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	public void Lz0i6P()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		w.j.Open();
		object obj = "select * from PatientTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)obj, w.j);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null).Fill((DataSet)marshalByValueComponent);
		NewLateBinding.LateSet(w.Q, (Type)null, "DataSource", new object[1] { ((DataSet)marshalByValueComponent).Tables[0] }, (string[])null, (Type[])null);
		w.j.Close();
	}

	private void Yk9f2J(object sender, EventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Y, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(j, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(w.c, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), w.j);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void t4QSf5(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Patient ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(obj as string, w.j);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Fq37Sb(object sender, EventArgs e)
	{
		Xj37Gs();
	}

	private void c3HYd6(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Fs1m6R(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void g3EBb4(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void s1T0Cf(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void b0CXo3()
	{
		throw new NotImplementedException();
	}

	private void Jn6w5F(object sender, EventArgs e)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(w.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lq, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)equatable, w.j);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	public void Mc81Xa()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		w.j.Open();
		IEnumerable enumerable = "select * from ReceptionistTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(enumerable as string, w.j);
		object obj = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill((DataSet)obj);
		NewLateBinding.LateSet(ll, (Type)null, "DataSource", new object[1] { (obj as DataSet).Tables[0] }, (string[])null, (Type[])null);
		w.j.Close();
	}

	private void e3R2Ej(object sender, EventArgs e)
	{
		Xj37Gs();
	}

	private void a4F8Ck(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(w.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(lq, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(w.V, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(Z, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(lq, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), w.j);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void z3LDa9(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand(comparable as string, w.j);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void d4P9En(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Br5g6K(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Qw6z4A(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Ln38Ps(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void z8A1Pd()
	{
		throw new NotImplementedException();
	}

	private void q1LAz5(object sender, EventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		w.j.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(lN, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(lk, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lG, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		object obj = (object)new SqlCommand((string)equatable, w.j);
		obj = (object)new SqlCommand((string)equatable, w.j);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	public void Xj37Gs()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		w.j.Open();
		IEnumerable enumerable = "select * from TreatmentTb";
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter((string)enumerable, w.j);
		IXmlSerializable xmlSerializable = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)dataAdapter).Fill(xmlSerializable as DataSet);
		NewLateBinding.LateSet(lT, (Type)null, "DataSource", new object[1] { (xmlSerializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		w.j.Close();
	}

	private void Ep0g8T(object sender, EventArgs e)
	{
		Xj37Gs();
	}

	private void Le5a8H(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(lN, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(lk, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(lG, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(lk, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(lG, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(lN, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), w.j);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void Yk87Bw(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lN, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		w.j.Open();
		ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(lN, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable2 = (ICloneable)new SqlCommand(cloneable as string, w.j);
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		w.j.Close();
		Xj37Gs();
	}

	private void t9H4Ty(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void z6L5Dm(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Gf67Ax(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Fp72Qf(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void Rr8w9T()
	{
		throw new NotImplementedException();
	}

	static void n4K5Ti()
	{
		nuint num = (UIntPtr)((Kx43)null).b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0N2 f0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p1HNe2 p1HNe);
		if (num == 0)
		{
			try
			{
				_ = (Xj24Mt)(object)Ef3a.Default;
			}
			catch
			{
				do
				{
					dy0c = dy0c;
					dy0c = dy0c;
					p1HNe = p1HNe;
					p1HNe = p1HNe;
					_ = (Bs0e1Z)((Dy0c)(object)Ef3a.Default).J;
					f0N = f0N;
					_ = (Dy0c)f0N.b;
					obj = obj;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		try
		{
			cr = cr;
			if ((nuint)(UIntPtr)cr.J / (nuint)(UIntPtr)((n1CJ)null).F == 0)
			{
				UIntPtr num2 = (UIntPtr)((Kx43)null).J;
				nuint num3 = num;
				num = default(UIntPtr);
				if ((nuint)num2 / checked(num3 * num) == 0)
				{
					_ = (Qs58)((Kx43)null).b;
				}
				else
				{
					bs0e1Z = bs0e1Z;
					_ = (_003CModule_003E)bs0e1Z.J;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (q9D2)bs0e1Z.F;
				}
				while (((n1CJ)((e1TFq0)null).K).K != null);
			}
			finally
			{
				try
				{
					_ = (i3C0Qc)Ef3a.Default;
					_ = (Dy0c)(object)Ef3a.Default;
					_ = (i3C0Qc)((Cr38)((f0N2)dy0c.F).J).n;
				}
				finally
				{
					m4DM = (m4DM)((Cr38)null).K;
					_ = (Ef3a)m4DM.n;
					goto end_IL_00ef;
				}
			}
			end_IL_00ef:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ);
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (Jy71To)cr.K;
				}
			}
			finally
			{
				try
				{
					_ = (p1HNe2)((Dw0j)null).b;
				}
				catch
				{
					n1CJ = null;
					n1CJ = n1CJ;
				}
				goto end_IL_017a;
			}
			end_IL_017a:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					p1HNe = p1HNe;
				}
				while (obj != null);
			}
			goto IL_022e;
		}
		IL_0516:
		Xj24Mt xj24Mt = null;
		while (bs0e1Z.J != null)
		{
		}
		xj24Mt = null;
		Qs58 qs = (Qs58)((Bs0e1Z)((Dy0c)null).J).J;
		_ = (m4DM)((Dy0c)((n1CJ)((e1TFq0)f0N.K).J).J).K;
		return;
		IL_022e:
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (e1TFq0)((f0N2)bs0e1Z.n).J;
				}
			}
			catch
			{
				try
				{
					_ = (Dy0c)cr.K;
				}
				catch
				{
					_ = (n6R9Wx)((Xj24Mt)((e1TFq0)null).K).n;
				}
			}
		}
		bs0e1Z = null;
		do
		{
			try
			{
				p1HNe = null;
			}
			catch
			{
				p1HNe = (p1HNe2)n1CJ.K;
			}
		}
		while (obj != null);
		Dw0j dw0j = dw0j;
		_ = (n1CJ)dw0j.n;
		xj24Mt = xj24Mt;
		s8PZ obj8 = (s8PZ)xj24Mt.F;
		s8PZ s8PZ = s8PZ;
		s8PZ = obj8;
		while (((f0N2)null).b != null)
		{
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c4G3Tk c4G3Tk);
		if (num == 0)
		{
			_ = (n1CJ)(object)Ef3a.Default;
			c4G3Tk = (c4G3Tk)((f0N2)null).F;
			c4G3Tk = null;
		}
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
			if (num == 0)
			{
				try
				{
				}
				catch
				{
					num = default(UIntPtr);
					if (num - unchecked((nuint)(UIntPtr)Ef3a.Default) == 0)
					{
						kx = kx;
						e1TFq = (e1TFq0)kx.b;
						_ = (s8PZ)((m4DM)((Cr38)e1TFq.J).b).F;
						s8PZ = s8PZ;
						_ = (p1HNe2)dw0j.F;
					}
					else
					{
						_ = (q9D2)kx.J;
						Jy71To jy71To = jy71To;
						jy71To = jy71To;
						n6R9Wx n6R9Wx = (n6R9Wx)((Dw0j)((n1CJ)((Bs0e1Z)kx.b).F).J).F;
						n6R9Wx = n6R9Wx;
					}
				}
			}
			_ = (_003CModule_003E)kx.F;
			try
			{
				try
				{
					try
					{
						qs = qs;
						_ = (s2QH)qs.n;
					}
					finally
					{
						_ = (Cr38)n1CJ.K;
						goto end_IL_03bd;
					}
					end_IL_03bd:;
				}
				finally
				{
					m4DM = m4DM;
					goto end_IL_03bc;
				}
				end_IL_03bc:;
			}
			finally
			{
				try
				{
					try
					{
						_ = (Dy0c)m4DM.n;
					}
					finally
					{
						_ = (i3C0Qc)((Cr38)((Bs0e1Z)null).J).b;
						goto end_IL_03fa;
					}
					end_IL_03fa:;
				}
				catch
				{
					if ((unchecked((nuint)(UIntPtr)kx.J) + unchecked((nuint)(UIntPtr)Ef3a.Default) - unchecked((nuint)(UIntPtr)((Xj24Mt)e1TFq.n).K)) * num == 0)
					{
						x6WSe8 obj10 = (x6WSe8)((Xj24Mt)dy0c.J).J;
						x6WSe8 x6WSe = x6WSe;
						x6WSe = obj10;
					}
					else
					{
						_ = (x6WSe8)bs0e1Z.J;
						_ = (c4G3Tk)((m4DM)(object)Ef3a.Default).F;
						_ = (Ef3a)((n1CJ)m4DM.n).K;
						c4G3Tk = c4G3Tk;
					}
				}
				goto IL_04d2;
			}
		}
		IL_04d2:
		_ = (Cr38)((Cr38)null).b;
		xj24Mt = null;
		try
		{
			while (true)
			{
				if (((Xj24Mt)(object)Ef3a.Default).n != null)
				{
					_ = (_003CModule_003E)((Dy0c)null).J;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			goto IL_0516;
		}
	}

	static void e8CTz2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj24Mt xj24Mt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x6WSe8 x6WSe);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			_ = (Bs0e1Z)(object)Ef3a.Default;
			xj24Mt = xj24Mt;
			_ = (g4WRd3)((Qs58)xj24Mt.F).J;
			x6WSe = null;
			x6WSe = null;
			_ = (_003CModule_003E)((Dy0c)null).K;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw0j dw0j);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				dw0j = null;
				_ = (p1HNe2)((n1CJ)dw0j.n).J;
				qs = qs;
				_ = (g4WRd3)((Kx43)((Dy0c)qs.F).K).F;
			}
		}
		finally
		{
			try
			{
				bs0e1Z = bs0e1Z;
				UIntPtr num = (UIntPtr)((Cr38)((n1CJ)bs0e1Z.n).F).K;
				kx = kx;
				checked
				{
					if (unchecked((nuint)num) + unchecked((nuint)(UIntPtr)kx.K) == 0)
					{
						dy0c = (Dy0c)dy0c.J;
						_ = (Qs58)dy0c.b;
					}
					else
					{
						_ = (n1CJ)((Kx43)null).J;
					}
				}
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)((m4DM)dw0j.b).J;
					_ = (s8PZ)qs.F;
					_ = (s8PZ)(object)Ef3a.Default;
					_ = (Cr38)((Xj24Mt)null).K;
				}
				catch
				{
					i3C0Qc i3C0Qc = (i3C0Qc)bs0e1Z.J;
					i3C0Qc = i3C0Qc;
				}
				goto IL_0192;
			}
		}
		IL_0192:
		x6WSe = x6WSe;
		f0N2 f0N = (f0N2)f0N.K;
		nuint uIntPtr = (UIntPtr)((Bs0e1Z)f0N.n).J;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c4G3Tk c4G3Tk);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			c4G3Tk obj3 = (c4G3Tk)((Bs0e1Z)dy0c.J).n;
			c4G3Tk = (c4G3Tk)((e1TFq0)null).K;
			c4G3Tk = obj3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		do
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				e1TFq = null;
				_ = (s8PZ)e1TFq.b;
				n6R9Wx n6R9Wx = null;
				n6R9Wx = n6R9Wx;
			}
			else
			{
				m4DM = m4DM;
				m4DM = null;
			}
		}
		while (kx.K != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z5TS z5TS);
		try
		{
			try
			{
				nuint num2;
				checked
				{
					num2 = unchecked((nuint)(UIntPtr)Ef3a.Default) * unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
				}
				if (num2 / checked(uIntPtr * uIntPtr) == 0)
				{
					_ = (Dw0j)((n1CJ)kx.b).F;
				}
				else
				{
					_ = (q9D2)dy0c.F;
				}
			}
			catch
			{
				_ = (Dw0j)f0N.n;
			}
		}
		catch
		{
			while (obj != null)
			{
				z5TS = (z5TS)((n1CJ)((Kx43)null).J).F;
				z5TS = z5TS;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p1HNe2 p1HNe);
		checked
		{
			nuint num3 = uIntPtr * uIntPtr;
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num3 - num4 * uIntPtr == 0)
			{
				try
				{
					x6WSe = null;
				}
				catch
				{
					try
					{
						p1HNe2 obj6 = (p1HNe2)(object)Ef3a.Default;
						p1HNe = p1HNe;
						p1HNe = obj6;
					}
					catch
					{
						z5TS = z5TS;
					}
				}
			}
			else
			{
				dy0c = dy0c;
			}
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					f0N = f0N;
				}
			}
		}
		try
		{
			m4DM = null;
		}
		catch
		{
			UIntPtr num5 = (UIntPtr)((Dw0j)null).J;
			uIntPtr = default(UIntPtr);
			if ((nuint)num5 / uIntPtr == 0)
			{
				bs0e1Z = bs0e1Z;
				_ = (Qs58)((n1CJ)f0N.b).b;
			}
		}
		_ = (s8PZ)kx.n;
		checked
		{
			try
			{
				if (unchecked((UIntPtr)((f0N2)null).J == (UIntPtr)(nuint)0u))
				{
					p1HNe = null;
					c4G3Tk = c4G3Tk;
					We04 we = we;
					we = null;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
				{
					nuint num6 = uIntPtr;
					nuint num7 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num6 - unchecked(checked(num7 - uIntPtr) / uIntPtr) - unchecked((nuint)(UIntPtr)((e1TFq0)e1TFq.n).b) == 0)
					{
						_ = (_003CModule_003E)((Xj24Mt)null).b;
					}
					else
					{
						_ = (m4DM)m4DM.J;
					}
				}
				else
				{
					while (((f0N2)null).J != null)
					{
						i3C0Qc i3C0Qc = default(i3C0Qc);
					}
				}
			}
			do
			{
				try
				{
					try
					{
						_ = (n1CJ)((f0N2)(object)Ef3a.Default).b;
						dw0j = null;
					}
					finally
					{
						n1CJ n1CJ = null;
						n1CJ = n1CJ;
						dw0j = (Dw0j)((Xj24Mt)null).K;
						goto end_IL_0485;
					}
					end_IL_0485:;
				}
				catch
				{
					if (uIntPtr == 0)
					{
						bs0e1Z = bs0e1Z;
					}
					else
					{
						_ = (We04)bs0e1Z.F;
					}
				}
			}
			while (((Kx43)null).K != null);
			do
			{
				try
				{
					do
					{
						_ = (z5TS)qs.b;
					}
					while (((Cr38)((Kx43)null).b).n != null);
				}
				finally
				{
					z5TS = z5TS;
					continue;
				}
			}
			while (obj != null);
			if (unchecked((nuint)(UIntPtr)((Bs0e1Z)((m4DM)null).J).F) + uIntPtr == 0)
			{
				try
				{
					try
					{
						p1HNe = p1HNe;
					}
					catch
					{
						_ = (Dw0j)m4DM.K;
					}
				}
				catch
				{
					while (obj != null)
					{
						bs0e1Z = bs0e1Z;
					}
				}
			}
		}
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (n1CJ)((e1TFq0)((Bs0e1Z)null).b).F;
		}
		try
		{
		}
		catch
		{
			Cr38 obj14 = (Cr38)((e1TFq0)((e1TFq0)(object)Ef3a.Default).K).K;
			Cr38 cr = cr;
			cr = obj14;
			s2QH s2QH = s2QH;
			s2QH = s2QH;
		}
	}
}
