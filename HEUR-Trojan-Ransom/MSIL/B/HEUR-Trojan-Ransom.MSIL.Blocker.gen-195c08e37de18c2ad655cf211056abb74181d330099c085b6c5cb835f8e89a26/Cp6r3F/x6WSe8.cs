using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ba95Nn;
using Eg7s4Q;
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
using i6NP;
using n8Z0;
using o6FHd3;
using r7D4Eb;
using r9R2;
using t7JR;
using t8KCs3;
using x4K5;

namespace Cp6r3F;

public class x6WSe8
{
	internal sealed class r0Y8Nt
	{
		internal SqlConnection U;

		internal object O;

		internal object M;

		internal object k;

		internal object Y;

		internal object X;

		internal object V;

		internal object c;

		internal object f;

		internal object E;

		internal object G;

		internal object S;

		internal object I;

		internal object Q;

		internal object t;

		internal object j;

		internal r0Y8Nt()
		{
		}
	}

	internal sealed class Dy85Pc
	{
		internal int E;

		internal byte[] G;

		internal int t;

		internal Dy85Pc()
		{
		}
	}

	private object L;

	private e1TFq0.y3RMn1 Q = new e1TFq0.y3RMn1();

	public x6WSe8()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		object obj = (object)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
		Q.V = (SqlConnection)((obj is SqlConnection) ? obj : null);
	}

	private void Ce4a9W(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		Q.V.Open();
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into ReceptionistTb values(", NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(Q.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(Q.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)enumerable, Q.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Successfully Added", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		c1C8Hx();
	}

	public void c1C8Hx()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Q.V.Open();
		IConvertible convertible = "select * from ReceptionistTb";
		DbDataAdapter dbDataAdapter = (DbDataAdapter)new SqlDataAdapter((string)convertible, Q.V);
		ISerializable serializable = new DataSet();
		((dbDataAdapter is SqlDataAdapter) ? dbDataAdapter : null).Fill((DataSet)serializable);
		NewLateBinding.LateSet(Q.d, (Type)null, "DataSource", new object[1] { (serializable as DataSet).Tables[0] }, (string[])null, (Type[])null);
		Q.V.Close();
	}

	private void Kq56Pb(object sender, EventArgs e)
	{
		c1C8Hx();
	}

	private void Dq42Ad(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(Q.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		Q.V.Open();
		object obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update ReceptionistTb set RecepName ='", NewLateBinding.LateGet(Q.G, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPhone='"), NewLateBinding.LateGet(L, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', RecepPass='"), NewLateBinding.LateGet(Q.X, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where RecepID = "), NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), Q.V);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Updated Successfully", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		c1C8Hx();
	}

	private void w6N3Ba(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Receptionist ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		Q.V.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from ReceptionistTb where RecepID=", NewLateBinding.LateGet(Q.M, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand((string)comparable, Q.V);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Receptionist Delete", (MsgBoxStyle)0, (object)null);
		Q.V.Close();
		c1C8Hx();
	}

	private void Qz84Xd(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	private void Gk73Lz(object sender, EventArgs e)
	{
		object obj = new Jy71To();
		(obj as Jy71To).Df8b9W();
	}

	private void g4ETx0(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		((n6R9Wx)obj).c7W6Hx();
	}

	private void Lx9m7W(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		(obj as e1TFq0).g0DJf5();
	}

	internal void c7Q4Sk()
	{
		throw new NotImplementedException();
	}

	static void s9SZt5()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			obj = obj;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p1HNe2 p1HNe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0N2 f0N);
		if (num == 0)
		{
			try
			{
				try
				{
					bs0e1Z = null;
					qs = (Qs58)bs0e1Z.b;
					qs = null;
				}
				finally
				{
					e1TFq = e1TFq;
					_ = (Dy0c)e1TFq.b;
					goto end_IL_0014;
				}
				end_IL_0014:;
			}
			catch
			{
				try
				{
					n1CJ = n1CJ;
					n1CJ = n1CJ;
					p1HNe = p1HNe;
					p1HNe = null;
				}
				catch
				{
					f0N = null;
				}
			}
		}
		else
		{
			n1CJ = null;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)((n1CJ)null).F) - num == 0)
			{
				_ = (m4DM)((Dy0c)null).J;
				goto IL_00e7;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		try
		{
			kx = null;
			_ = (i3C0Qc)kx.b;
		}
		finally
		{
			if ((UIntPtr)((Xj24Mt)null).J == (UIntPtr)(nuint)0u)
			{
				z5TS z5TS = (z5TS)((f0N2)kx.K).F;
				z5TS = z5TS;
			}
			goto IL_00e7;
		}
		IL_053a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw0j dw0j);
		if (num == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Kx43)m4DM.J;
			}
			while (((f0N2)((Dw0j)((Cr38)dw0j.b).F).n).b != null);
		}
		return;
		IL_00e7:
		try
		{
			_ = (s2QH)m4DM.n;
		}
		finally
		{
			_ = (s8PZ)((m4DM)null).F;
			goto IL_01a4;
		}
		IL_01a4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dy0c dy0c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c4G3Tk c4G3Tk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj24Mt xj24Mt);
		Cr38 cr;
		do
		{
			xj24Mt = xj24Mt;
			cr = (Cr38)((n1CJ)xj24Mt.F).n;
			if ((UIntPtr)cr.b != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Kx43)kx.n).F == (UIntPtr)(nuint)0u)
				{
					q9D2 q9D = (q9D2)e1TFq.K;
					q9D = q9D;
					_ = (c4G3Tk)((Dw0j)m4DM.F).K;
					_ = (p1HNe2)dy0c.b;
					c4G3Tk = null;
					c4G3Tk = c4G3Tk;
				}
				else
				{
					m4DM = null;
				}
			}
			else
			{
				do
				{
					dy0c = dy0c;
					_ = (f0N2)dy0c.b;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		do
		{
			_ = (f0N2)((f0N2)cr.K).b;
		}
		while (kx.F != null || xj24Mt.n != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i3C0Qc i3C0Qc);
		try
		{
			try
			{
				bs0e1Z = (Bs0e1Z)(object)Ef3a.Default;
			}
			catch
			{
				_ = (q9D2)f0N.F;
				_ = (s2QH)dw0j.J;
				i3C0Qc = default(i3C0Qc);
				i3C0Qc = i3C0Qc;
				i3C0Qc = i3C0Qc;
				c4G3Tk = (c4G3Tk)kx.J;
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Ef3a)qs.n;
				}
				while (obj != null);
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						_ = (Dw0j)((e1TFq0)null).J;
						continue;
					}
					goto end_IL_0291;
				}
				end_IL_0291:;
			}
		}
		c4G3Tk = c4G3Tk;
		_ = (q9D2)n1CJ.n;
		_ = (x6WSe8)((Cr38)null).J;
		_ = (z5TS)((Qs58)((Bs0e1Z)null).b).K;
		try
		{
			_ = (e1TFq0)((Qs58)null).b;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s8PZ s8PZ);
			while (obj != null)
			{
				try
				{
					s8PZ obj7 = (s8PZ)(object)Ef3a.Default;
					s8PZ = s8PZ;
					s8PZ = obj7;
				}
				finally
				{
					_ = (Bs0e1Z)(object)Ef3a.Default;
					continue;
				}
			}
		}
		xj24Mt = xj24Mt;
		while (true)
		{
			if (obj != null)
			{
				_ = (z5TS)m4DM.b;
				_ = (s8PZ)((Xj24Mt)(object)Ef3a.Default).b;
				p1HNe = p1HNe;
				_ = (Cr38)cr.b;
			}
			else if (((Xj24Mt)null).F == null)
			{
				break;
			}
		}
		f0N = null;
		while (f0N.J != null)
		{
			try
			{
				while (obj != null)
				{
					e1TFq = null;
				}
			}
			finally
			{
				continue;
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		while (obj != null)
		{
			if ((UIntPtr)qs.b == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (s2QH)bs0e1Z.K;
					_ = (Jy71To)bs0e1Z.F;
					_ = (Cr38)e1TFq.n;
					g4WRd3 g4WRd = default(g4WRd3);
				}
				catch
				{
					xj24Mt = null;
				}
			}
		}
		cr = cr;
		try
		{
			_ = (s2QH)((Bs0e1Z)null).K;
		}
		catch
		{
			if (num != 0)
			{
				try
				{
					i3C0Qc = i3C0Qc;
				}
				finally
				{
					_ = (_003CModule_003E)((Qs58)null).n;
					goto end_IL_0435;
				}
			}
			do
			{
				z5TS z5TS = (z5TS)bs0e1Z.J;
			}
			while (obj != null);
			end_IL_0435:;
		}
		if ((UIntPtr)m4DM.n == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Jy71To obj11 = (Jy71To)((e1TFq0)((Cr38)null).b).b;
					Jy71To jy71To = jy71To;
					jy71To = obj11;
				}
				else
				{
					_ = (Ef3a)xj24Mt.n;
				}
				goto IL_04cf;
			}
		}
		goto IL_04cf;
		IL_04cf:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (c4G3Tk)((Qs58)(object)Ef3a.Default).b;
				}
				finally
				{
					kx = null;
					goto end_IL_04d0;
				}
			}
			end_IL_04d0:;
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				_ = (Bs0e1Z)((f0N2)null).n;
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					f0N = null;
				}
			}
			goto IL_053a;
		}
	}
}
