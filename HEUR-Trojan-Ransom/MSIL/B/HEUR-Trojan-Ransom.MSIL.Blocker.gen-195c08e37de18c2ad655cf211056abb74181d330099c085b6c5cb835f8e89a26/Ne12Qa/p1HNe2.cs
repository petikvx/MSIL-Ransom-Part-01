using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using Ba95Nn;
using Cp6r3F;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using b1D6So;
using o6FHd3;
using r9R2;

namespace Ne12Qa;

public class p1HNe2
{
	private SqlConnection A;

	private object q;

	private object N;

	private object x;

	private z5TS.m3D5 Q = new z5TS.m3D5();

	public p1HNe2()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		A = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
	}

	private void Qj3g7R(object sender, EventArgs e)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		A.Open();
		object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into PatientTb values(", NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(Q.q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(N, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(Q.r, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(Q.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Q.W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		object obj2 = (object)new SqlCommand(obj as string, A);
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Successfully Added", (MsgBoxStyle)0, (object)null);
		A.Close();
		Hy35Cn();
	}

	public void Hy35Cn()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		A.Open();
		IConvertible convertible = "select * from PatientTb";
		ICloneable cloneable = (ICloneable)new SqlDataAdapter((string)convertible, A);
		MarshalByValueComponent marshalByValueComponent = new DataSet();
		((DbDataAdapter)(SqlDataAdapter)cloneable).Fill(marshalByValueComponent as DataSet);
		NewLateBinding.LateSet(x, (Type)null, "DataSource", new object[1] { ((DataSet)marshalByValueComponent).Tables[0] }, (string[])null, (Type[])null);
		A.Close();
	}

	private void Tq6c5A(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		A.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update PatientTb set PatientName ='", NewLateBinding.LateGet(Q.q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', PatientGender='"), (object)NewLateBinding.LateGet(N, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', PatientBlood='"), (object)NewLateBinding.LateGet(Q.r, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"' Where PatientId = "), NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), A);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Updated Successfully", (MsgBoxStyle)0, (object)null);
		A.Close();
		Hy35Cn();
	}

	private void La97Td(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Patient ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		A.Open();
		IEquatable<string> equatable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from PatientTb where PatientId=", NewLateBinding.LateGet(q, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)equatable, A);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Patient Delete", (MsgBoxStyle)0, (object)null);
		A.Close();
		Hy35Cn();
	}

	private void Cm79Rw(object sender, EventArgs e)
	{
		Hy35Cn();
	}

	private void Hi1e8A(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Er96Dp(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void t1Y9Wd(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Rp7o4H(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	internal void e4R9Af()
	{
		throw new NotImplementedException();
	}

	internal static int w9HTb3()
	{
		while (true)
		{
			try
			{
				object obj = new WebClient();
				try
				{
					IDisposable disposable = (obj as WebClient).OpenRead("https://www.google.com");
					try
					{
						return 100;
					}
					finally
					{
						if ((Stream)disposable != null)
						{
							((IDisposable)(disposable as Stream)).Dispose();
						}
					}
				}
				finally
				{
					if (obj is WebClient)
					{
						((IDisposable)(obj as WebClient)).Dispose();
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
}
