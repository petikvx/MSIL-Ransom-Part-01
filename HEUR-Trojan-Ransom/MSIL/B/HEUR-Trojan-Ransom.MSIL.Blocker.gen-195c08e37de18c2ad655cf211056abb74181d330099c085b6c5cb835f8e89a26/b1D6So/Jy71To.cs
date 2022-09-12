using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
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
using f1W6;
using f3W1Tn;
using i1J6;
using i6NP;
using n8Z0;
using o6FHd3;
using r7D4Eb;
using r9R2;
using t7JR;
using x4K5;

namespace b1D6So;

public class Jy71To
{
	public class g6BLq5
	{
		private object s;

		private string[] a;

		private byte[] L;

		private string m_I;

		private string v;

		private int l;

		private string q;

		private x6WSe8.Dy85Pc G = new x6WSe8.Dy85Pc();

		public int K
		{
			get
			{
				return G.E;
			}
			set
			{
				G.E = value;
			}
		}

		public object T
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

		public string[] T
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

		public byte[] w
		{
			get
			{
				return G.G;
			}
			set
			{
				G.G = value as byte[];
			}
		}

		public byte[] y
		{
			get
			{
				return L;
			}
			set
			{
				L = value;
			}
		}

		public string d
		{
			get
			{
				return this.m_I;
			}
			set
			{
				this.m_I = value;
			}
		}

		public string I
		{
			get
			{
				return v;
			}
			set
			{
				v = value;
			}
		}

		public int F
		{
			get
			{
				return l;
			}
			set
			{
				l = value;
			}
		}

		public int b
		{
			get
			{
				return G.t;
			}
			set
			{
				G.t = value;
			}
		}

		public string o
		{
			get
			{
				return q;
			}
			set
			{
				q = value;
			}
		}
	}

	private SqlConnection d;

	private object e;

	private object c;

	private object P;

	private object b;

	private n1CJ.n6RK n = new n1CJ.n6RK();

	public Jy71To()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		d = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=A:\\Ritik Dev\\HospitalDB\\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
	}

	private void Ha42Dx(object sender, EventArgs e)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		d.Open();
		IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"insert into DoctorTb values(", NewLateBinding.LateGet(n.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",'"), NewLateBinding.LateGet(n.H, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(this.e, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"', "), NewLateBinding.LateGet(c, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)", '"), NewLateBinding.LateGet(P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"));
		ICloneable cloneable = (ICloneable)new SqlCommand((string)comparable, d);
		((SqlCommand)cloneable).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Successfully Added", (MsgBoxStyle)0, (object)null);
		d.Close();
		Sp6i3W();
	}

	public void Sp6i3W()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		d.Open();
		ICloneable cloneable = "select * from DoctorTb";
		object obj = (object)new SqlDataAdapter((string)cloneable, d);
		object obj2 = new DataSet();
		((DbDataAdapter)((obj is SqlDataAdapter) ? obj : null)).Fill((DataSet)obj2);
		NewLateBinding.LateSet(n.Y, (Type)null, "DataSource", new object[1] { ((DataSet)obj2).Tables[0] }, (string[])null, (Type[])null);
		d.Close();
	}

	private void Dq5i0H(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(n.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(n.H, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			Interaction.MsgBox((object)"Incomplete Information", (MsgBoxStyle)0, (object)null);
			return;
		}
		d.Open();
		DbCommand dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Update DoctorTb set DoctorName ='", NewLateBinding.LateGet(n.H, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorGender ='"), (object)NewLateBinding.LateGet(this.e, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"',DoctorExp ="), NewLateBinding.LateGet(c, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)",DoctorSpec ='"), NewLateBinding.LateGet(P, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"', DoctorPass='"), NewLateBinding.LateGet(b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' Where DoctorID = "), NewLateBinding.LateGet(n.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"")), d);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Updated Successfully", (MsgBoxStyle)0, (object)null);
		d.Close();
		Sp6i3W();
	}

	private void Rf80Fa(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(n.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			Interaction.MsgBox((object)"Enter The Doctor ID", (MsgBoxStyle)0, (object)null);
			return;
		}
		d.Open();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Delete from DoctorTb where DoctorID=", NewLateBinding.LateGet(n.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
		DbCommand dbCommand = (DbCommand)new SqlCommand(convertible as string, d);
		((SqlCommand)dbCommand).ExecuteNonQuery();
		Interaction.MsgBox((object)"Doctor Delete", (MsgBoxStyle)0, (object)null);
		d.Close();
		Sp6i3W();
	}

	private void d6F2Zp(object sender, EventArgs e)
	{
		Sp6i3W();
	}

	private void Sb67Bw(object sender, EventArgs e)
	{
		object obj = new e1TFq0();
		((e1TFq0)obj).g0DJf5();
	}

	private void r6E3Rk(object sender, EventArgs e)
	{
		object obj = new n6R9Wx();
		(obj as n6R9Wx).c7W6Hx();
	}

	private void Gc8e1Y(object sender, EventArgs e)
	{
		object obj = new x6WSe8();
		(obj as x6WSe8).c7Q4Sk();
	}

	private void Bd2f5C(object sender, EventArgs e)
	{
		object obj = new p1HNe2();
		(obj as p1HNe2).e4R9Af();
	}

	internal void Df8b9W()
	{
		throw new NotImplementedException();
	}

	static void Tr0w7F()
	{
		Dy0c dy0c = null;
		i3C0Qc i3C0Qc = (i3C0Qc)dy0c.b;
		i3C0Qc = i3C0Qc;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qs58 qs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n1CJ n1CJ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0N2 f0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			try
			{
				_ = (Xj24Mt)((Qs58)null).F;
			}
			catch
			{
				try
				{
					e1TFq = (e1TFq0)((Cr38)null).K;
				}
				catch
				{
					qs = qs;
					bs0e1Z = (Bs0e1Z)qs.J;
					cr = (Cr38)((n1CJ)bs0e1Z.J).b;
					_ = (Dw0j)cr.b;
				}
			}
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					_ = (c4G3Tk)n1CJ.b;
				}
				finally
				{
					_ = (Dy0c)((Dy0c)((Bs0e1Z)null).n).J;
					goto end_IL_008c;
				}
			}
			try
			{
				f0N = null;
				_ = (_003CModule_003E)f0N.n;
				Xj24Mt xj24Mt = xj24Mt;
				xj24Mt = xj24Mt;
				_ = (n1CJ)(object)Ef3a.Default;
				_ = (Dy0c)xj24Mt.b;
			}
			finally
			{
				n1CJ = n1CJ;
				goto end_IL_008c;
			}
			end_IL_008c:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw0j dw0j);
		if (num == 0)
		{
			Dw0j obj4 = (Dw0j)dy0c.n;
			dw0j = (Dw0j)((Kx43)null).n;
			dw0j = obj4;
		}
		else
		{
			while (e1TFq.F != null)
			{
				do
				{
					_ = (q9D2)((e1TFq0)null).b;
					obj5 = obj5;
				}
				while (obj5 != null);
			}
		}
		z5TS z5TS = z5TS;
		z5TS = z5TS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out c4G3Tk c4G3Tk);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			do
			{
				if (num != 0)
				{
					if (unchecked((nuint)(UIntPtr)((n1CJ)null).F) + num == 0)
					{
						n6R9Wx n6R9Wx = null;
						n6R9Wx = n6R9Wx;
					}
					else
					{
						c4G3Tk obj6 = (c4G3Tk)(object)Ef3a.Default;
						c4G3Tk = c4G3Tk;
						c4G3Tk = obj6;
					}
					continue;
				}
				try
				{
					kx = kx;
					_ = (Dw0j)kx.K;
				}
				catch
				{
					_003CModule_003E obj7 = (_003CModule_003E)(object)Ef3a.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj7;
				}
			}
			while (obj5 != null);
			while (obj5 != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		if ((UIntPtr)dw0j.K == (UIntPtr)(nuint)0u)
		{
			try
			{
				dw0j = (Dw0j)((Dy0c)null).K;
			}
			finally
			{
				m4DM = null;
				_ = (n1CJ)m4DM.J;
				goto IL_0250;
			}
		}
		goto IL_0250;
		IL_043c:
		_ = (x6WSe8)qs.n;
		return;
		IL_0250:
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					n1CJ = (n1CJ)qs.J;
				}
				finally
				{
					dy0c = dy0c;
					continue;
				}
			}
		}
		while (n1CJ.J != null);
		if ((UIntPtr)qs.K == (UIntPtr)(nuint)0u)
		{
			_ = (We04)qs.n;
		}
		checked
		{
			c4G3Tk c4G3Tk;
			if (unchecked((nuint)(UIntPtr)((Xj24Mt)null).K) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (i3C0Qc)((Xj24Mt)null).F;
			}
			else
			{
				try
				{
					while (obj5 != null)
					{
						x6WSe8 x6WSe = (x6WSe8)dy0c.F;
						x6WSe = x6WSe;
					}
				}
				catch
				{
					try
					{
						_ = (We04)((Xj24Mt)((n1CJ)n1CJ.F).b).K;
					}
					finally
					{
						c4G3Tk = (c4G3Tk)bs0e1Z.F;
						goto end_IL_02d1;
					}
					end_IL_02d1:;
				}
			}
			_ = (m4DM)(object)Ef3a.Default;
			c4G3Tk = (c4G3Tk)((n1CJ)null).F;
		}
		if ((UIntPtr)((Xj24Mt)null).K == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (c4G3Tk)((Dy0c)f0N.K).K;
			}
			else
			{
				_ = (s2QH)kx.K;
			}
		}
		do
		{
			UIntPtr num2 = (UIntPtr)m4DM.J;
			num = default(UIntPtr);
			if ((nuint)num2 / num == 0)
			{
				_ = (Dy0c)f0N.b;
			}
		}
		while (obj5 != null);
		if (num != 0)
		{
		}
		try
		{
			do
			{
				nuint num3 = (nuint)(UIntPtr)cr.n / (nuint)(UIntPtr)((Kx43)f0N.J).K;
				num = default(UIntPtr);
				if (num3 / num / (nuint)(UIntPtr)qs.n == 0)
				{
					_ = (Ef3a)bs0e1Z.K;
				}
			}
			while (obj5 != null);
		}
		finally
		{
			if (num == 0)
			{
				_ = (c4G3Tk)e1TFq.n;
			}
			else if (num == 0)
			{
				_003CModule_003E _003CModule_003E = null;
			}
			goto IL_043c;
		}
	}

	static void o7ZMs3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs0e1Z bs0e1Z);
		try
		{
		}
		finally
		{
			i3C0Qc i3C0Qc = default(i3C0Qc);
			bs0e1Z = bs0e1Z;
			_ = (_003CModule_003E)bs0e1Z.b;
			goto IL_0036;
		}
		IL_0036:
		n1CJ n1CJ = null;
		n1CJ = n1CJ;
		Dy0c dy0c = (Dy0c)n1CJ.K;
		Jy71To jy71To = (Jy71To)dy0c.J;
		jy71To = jy71To;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		f0N2 f0N = f0N;
		f0N = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj24Mt xj24Mt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kx43 kx);
		if ((UIntPtr)((m4DM)null).b == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Dw0j)null).F != (UIntPtr)(nuint)0u)
			{
				try
				{
					xj24Mt = xj24Mt;
					Kx43 obj = (Kx43)xj24Mt.b;
					kx = kx;
					kx = obj;
				}
				finally
				{
					_ = (z5TS)f0N.J;
					goto IL_010d;
				}
			}
			_ = (We04)n1CJ.b;
		}
		else
		{
			while (true)
			{
				obj2 = Ef3a.Default;
				if (obj2 == null)
				{
					break;
				}
				_ = (s8PZ)((Bs0e1Z)null).b;
			}
		}
		goto IL_010d;
		IL_0263:
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw0j dw0j);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Bs0e1Z)(object)Ef3a.Default;
			_ = (Dy0c)dy0c.K;
			_ = (_003CModule_003E)dw0j.F;
		}
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m4DM m4DM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr38 cr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e1TFq0 e1TFq);
		checked
		{
			if (unchecked((nuint)num) - uIntPtr == 0)
			{
				try
				{
					try
					{
						_ = (n1CJ)((m4DM)null).b;
					}
					finally
					{
						m4DM = m4DM;
						_ = (s8PZ)m4DM.F;
						goto end_IL_02b1;
					}
					end_IL_02b1:;
				}
				catch
				{
					if (uIntPtr == 0)
					{
						_ = (n6R9Wx)xj24Mt.b;
					}
				}
			}
			else
			{
				kx = kx;
				cr = cr;
				n1CJ = null;
				kx = kx;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s2QH s2QH);
			if (unchecked((nuint)(UIntPtr)kx.F) + uIntPtr == 0)
			{
				s2QH obj4 = (s2QH)xj24Mt.b;
				s2QH = s2QH;
				s2QH = obj4;
			}
			else if (uIntPtr + unchecked((nuint)(UIntPtr)((m4DM)e1TFq.F).J) + uIntPtr == 0)
			{
			}
			try
			{
				try
				{
					try
					{
						_ = (Kx43)((Dw0j)null).K;
					}
					catch
					{
						s2QH = s2QH;
					}
				}
				catch
				{
					try
					{
						bs0e1Z = bs0e1Z;
					}
					catch
					{
						_ = (s8PZ)((n1CJ)bs0e1Z.J).n;
					}
				}
			}
			catch
			{
				while (true)
				{
					if (obj2 != null)
					{
						_ = (c4G3Tk)((Bs0e1Z)null).b;
					}
					else if (dy0c.n == null)
					{
						break;
					}
				}
			}
		}
		if ((UIntPtr)m4DM.K == (UIntPtr)(nuint)0u)
		{
			_ = (x6WSe8)xj24Mt.J;
		}
		do
		{
			z5TS z5TS = null;
			z5TS = z5TS;
		}
		while (((Cr38)((Bs0e1Z)((e1TFq0)((m4DM)null).n).n).F).F != null);
		return;
		IL_010d:
		dw0j = dw0j;
		_ = (Xj24Mt)((Cr38)dw0j.b).b;
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				try
				{
					dy0c = dy0c;
				}
				finally
				{
					cr = cr;
					_ = (Qs58)cr.J;
					continue;
				}
			}
		}
		try
		{
			do
			{
				bs0e1Z = (Bs0e1Z)(object)Ef3a.Default;
				_ = (Dw0j)((m4DM)dw0j.J).n;
				_ = (Ef3a)((Dy0c)null).K;
			}
			while (obj2 != null || obj2 != null);
		}
		catch
		{
			uIntPtr = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Qs58)null).n;
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				e1TFq = e1TFq;
				_ = (s8PZ)((Qs58)e1TFq.n).F;
			}
		}
		_ = (m4DM)(object)Ef3a.Default;
		_ = (Xj24Mt)(object)Ef3a.Default;
		e1TFq = e1TFq;
		try
		{
			_ = (Kx43)((Dy0c)null).F;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				dy0c = (Dy0c)((Dw0j)((m4DM)bs0e1Z.J).F).b;
			}
			goto IL_0263;
		}
	}
}
