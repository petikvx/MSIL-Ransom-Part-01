using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cp6r3F;
using Ki47;
using Kp62Wz;
using Mg3e;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ne12Qa;
using Nt61;
using Qe84;
using Ta50;
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

namespace Ba95Nn;

public class n6R9Wx
{
	[StructLayout(LayoutKind.Auto)]
	internal struct d5ZJx9
	{
		internal IContainer c;
	}

	private SqlConnection d;

	private object A;

	private object D;

	private object e;

	private object c;

	public n6R9Wx()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		d = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
	}

	private void Ad3i7E(object sender, EventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		d.Open();
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" insert into TreatmentTb values(", NewLateBinding.LateGet(A, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(D, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(this.e, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand(enumerable as string, d);
		dbCommand = (DbCommand)new SqlCommand((string)enumerable, d);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Successfully Added", (MsgBoxStyle)0, (object)null);
		d.Close();
		Hq83Gs();
	}

	public void Hq83Gs()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		d.Open();
		IComparable<string> comparable = "select * from TreatmentTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)comparable, d);
		ISerializable serializable = new DataSet();
		((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null).Fill((DataSet)serializable);
		NewLateBinding.LateSet(c, (Type)null, "DataSource", new object[1] { ((DataSet)serializable).Tables[0] }, (string[])null, (Type[])null);
		d.Close();
	}

	private void Lg3k4X(object sender, EventArgs e)
	{
		Hq83Gs();
	}

	private void d6NTz8(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(A, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(D, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(this.e, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		d.Open();
		ICloneable cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update TreatmentTb set TreatDesc ='", NewLateBinding.LateGet(D, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', TreatCost='"), NewLateBinding.LateGet(this.e, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where TreatID = "), NewLateBinding.LateGet(A, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), d);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Updated Successfully", (MsgBoxStyle)0, (object)null);
		d.Close();
		Hq83Gs();
	}

	private void Cg9c7Z(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(A, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Treament ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		d.Open();
		IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from TreatmentTb where TreatID=", NewLateBinding.LateGet(A, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)enumerable, d);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Treatment Delete", (MsgBoxStyle)0, (object)null);
		d.Close();
		Hq83Gs();
	}

	private void Ky6f8D(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void Rq87Dx(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		((x6WSe8)obj).c7Q4Sk();
	}

	private void Wt32Jr(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		((p1HNe2)obj).e4R9Af();
	}

	private void So3f6Y(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void c7W6Hx()
	{
		throw new NotImplementedException();
	}

	static void a2P3Yw()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj24Mt xj24Mt);
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ);
		while (true)
		{
			xj24Mt = xj24Mt;
			obj = xj24Mt.J;
			if (obj != null)
			{
				e1TFq = (e1TFq0)((Kx43)e1TFq.J).F;
				Dw0j dw0j = (Dw0j)((Dy0c)e1TFq.K).J;
				dw0j = dw0j;
				continue;
			}
			n1CJ = n1CJ;
			if (n1CJ.J == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		nuint uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		try
		{
			try
			{
				_ = (q9D2)((m4DM)null).J;
			}
			finally
			{
				e1TFq = e1TFq;
				goto end_IL_007b;
			}
			end_IL_007b:;
		}
		catch
		{
			kx = kx;
			if ((UIntPtr)((n1CJ)((Cr38)kx.n).K).K == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					qs = qs;
					_ = (p1HNe2)qs.K;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0N2 f0N);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (p1HNe2)((Cr38)null).F;
				}
			}
			finally
			{
				try
				{
					z5TS z5TS = z5TS;
					z5TS = z5TS;
				}
				finally
				{
					f0N = (f0N2)(object)Ef3a.Default;
					_ = (c4G3Tk)((Bs0e1Z)f0N.b).J;
					goto end_IL_00ff;
				}
			}
			end_IL_00ff:;
		}
		finally
		{
			_ = (s8PZ)kx.K;
			goto IL_016f;
		}
		IL_016f:
		uIntPtr = default(UIntPtr);
		checked
		{
			if ((uIntPtr + unchecked((nuint)(UIntPtr)((Cr38)((e1TFq0)((Dw0j)null).n).K).b)) * uIntPtr == 0)
			{
				try
				{
					do
					{
						c4G3Tk c4G3Tk = (c4G3Tk)n1CJ.F;
						c4G3Tk = c4G3Tk;
					}
					while (obj != null);
				}
				finally
				{
					_ = (p1HNe2)(object)Ef3a.Default;
					goto IL_01d4;
				}
			}
			goto IL_01d4;
		}
		IL_01d4:
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)((Xj24Mt)((Xj24Mt)null).K).K)) == 0)
		{
			_ = (n6R9Wx)f0N.n;
		}
		else if ((UIntPtr)kx.F == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
			while (true)
			{
				Cr38 cr = (Cr38)xj24Mt.K;
				if (cr.n == null)
				{
					break;
				}
				m4DM = (m4DM)m4DM.J;
				f0N = (f0N2)m4DM.J;
			}
		}
		do
		{
			f0N = f0N;
		}
		while (obj != null);
		while (obj != null)
		{
		}
		x6WSe8 x6WSe = x6WSe;
		x6WSe = null;
		qs = (Qs58)((Xj24Mt)((Xj24Mt)f0N.J).n).n;
		_ = (e1TFq0)f0N.n;
		_ = (Ef3a)f0N.n;
		n1CJ = n1CJ;
		_ = (Kx43)((Bs0e1Z)n1CJ.J).F;
		do
		{
			z5TS z5TS = (z5TS)n1CJ.b;
		}
		while (obj != null);
		_ = (q9D2)((Dw0j)null).J;
		f0N = f0N;
		Bs0e1Z bs0e1Z = bs0e1Z;
		g4WRd3 g4WRd = (g4WRd3)bs0e1Z.J;
		g4WRd = g4WRd;
		_ = (_003CModule_003E)((f0N2)((Dy0c)((Qs58)null).F).K).K;
		g4WRd = g4WRd;
	}
}
