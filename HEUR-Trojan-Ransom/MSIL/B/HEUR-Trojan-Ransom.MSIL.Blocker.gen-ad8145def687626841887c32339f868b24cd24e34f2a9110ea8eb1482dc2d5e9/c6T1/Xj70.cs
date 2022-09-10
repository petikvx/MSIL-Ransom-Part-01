using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ay6b0;
using En4j1;
using Gz67Tp;
using Microsoft.VisualBasic.CompilerServices;
using a4J8;
using a9X5Lj;
using b1FGj4;
using d4TYs8;
using e7G6;
using i1ZAj;
using n4WNr6;
using r7FGf;
using z4CFw3;

namespace c6T1;

public class Xj70
{
	public class Dq4w
	{
		public int num { get; set; }

		public object Ass
		{
			[CompilerGenerated]
			get
			{
				return _Ass;
			}
			[CompilerGenerated]
			set
			{
				_Ass = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public string[] Names { get; set; }

		public byte[] Data { get; set; }

		public byte[] Salt { get; set; }

		public string ResName { get; set; }

		public string Res { get; set; }

		public int TNum { get; set; }

		public int Mnum { get; set; }

		public string MName { get; set; }
	}

	private string provider;

	private string datafile;

	private string constring;

	private OleDbConnection myconnection;

	private DataSet ds;

	private OleDbDataAdapter da;

	private object UsernameTextBox;

	private object PasswordTextBox;

	public object ErrorProvider1
	{
		[CompilerGenerated]
		get
		{
			return _ErrorProvider1;
		}
		[CompilerGenerated]
		set
		{
			_ErrorProvider1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[CompilerGenerated]
		set
		{
			_Button1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[CompilerGenerated]
		set
		{
			_OK = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Xj70()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		myconnection = new OleDbConnection();
		da = new OleDbDataAdapter();
	}

	public void Lj81()
	{
		NewLateBinding.LateCall(UsernameTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(PasswordTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Wx7s(object sender, EventArgs e)
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(UsernameTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			object errorProvider = ErrorProvider1;
			object[] array = new object[2];
			ref object usernameTextBox = ref UsernameTextBox;
			ref object reference = ref usernameTextBox;
			array[0] = usernameTextBox;
			array[1] = "Please input Username";
			object[] array2 = array;
			bool[] obj = new bool[2] { true, false };
			bool[] array3 = obj;
			NewLateBinding.LateCall(errorProvider, (Type)null, "SetError", array, (string[])null, (Type[])null, obj, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		else
		{
			object errorProvider2 = ErrorProvider1;
			object[] array4 = new object[2];
			ref object usernameTextBox2 = ref UsernameTextBox;
			ref object reference = ref usernameTextBox2;
			array4[0] = usernameTextBox2;
			array4[1] = "Incorrect Username";
			object[] array2 = array4;
			bool[] obj2 = new bool[2] { true, false };
			bool[] array3 = obj2;
			NewLateBinding.LateCall(errorProvider2, (Type)null, "SetError", array4, (string[])null, (Type[])null, obj2, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(PasswordTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			object errorProvider3 = ErrorProvider1;
			object[] array5 = new object[2];
			ref object passwordTextBox = ref PasswordTextBox;
			ref object reference = ref passwordTextBox;
			array5[0] = passwordTextBox;
			array5[1] = "Please input Password";
			object[] array2 = array5;
			bool[] obj3 = new bool[2] { true, false };
			bool[] array3 = obj3;
			NewLateBinding.LateCall(errorProvider3, (Type)null, "SetError", array5, (string[])null, (Type[])null, obj3, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		else
		{
			object errorProvider4 = ErrorProvider1;
			object[] array6 = new object[2];
			ref object passwordTextBox2 = ref PasswordTextBox;
			ref object reference = ref passwordTextBox2;
			array6[0] = passwordTextBox2;
			array6[1] = "Incorrect Password";
			object[] array2 = array6;
			bool[] obj4 = new bool[2] { true, false };
			bool[] array3 = obj4;
			NewLateBinding.LateCall(errorProvider4, (Type)null, "SetError", array6, (string[])null, (Type[])null, obj4, true);
			if (array3[0])
			{
				reference = RuntimeHelpers.GetObjectValue(array2[0]);
			}
		}
		provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb";
		constring = provider + datafile;
		myconnection.set_ConnectionString(constring);
		myconnection.Open();
		OleDbCommand val = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" SELECT * FROM [TableUser] WHERE [username] = '", NewLateBinding.LateGet(UsernameTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND [password] = '"), NewLateBinding.LateGet(PasswordTextBox, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), myconnection);
		OleDbDataReader val2 = val.ExecuteReader();
		bool flag = false;
		while (val2.Read())
		{
			flag = true;
			val2.get_Item("FirstName").ToString();
			val2.get_Item("LastName").ToString();
		}
		if (flag)
		{
			Lj81();
			NewLateBinding.LateCall(ErrorProvider1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Ka07();
		}
		myconnection.Close();
	}

	private void Ka07()
	{
		throw new NotImplementedException();
	}

	internal static void q7SZ()
	{
		throw new NotImplementedException();
	}

	private void Jf89(object sender, EventArgs e)
	{
		a1Q5();
	}

	private void a1Q5()
	{
		throw new NotImplementedException();
	}

	static void x8AK()
	{
		Mn3s8 mn3s = mn3s;
		_ = (Ft83Xn)mn3s.GroupBox2;
		Ey0e9Q ey0e9Q = ey0e9Q;
		_ = (f0W2)ey0e9Q.ErrorProvider1;
		Xj70 obj = (Xj70)(object)g7FZc5.Default;
		Xj70 xj = null;
		xj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g7FZc5 g7FZc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		do
		{
			UIntPtr num = (UIntPtr)((Mn3s8)Ey0e9Q.OK).GroupBox2;
			num2 = num2;
			UIntPtr num3 = num2;
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)num) * (unchecked((nuint)num3) * ((unchecked((nuint)default(UIntPtr)) - num2 * num2) * (num2 - num2)))) / num2 == 0)
			{
				_ = (Xj70)Mn3s8.Button1;
				g7FZc = g7FZc;
				g7FZc = g7FZc;
				_ = (Ey0e9Q)(object)g7FZc5.Default;
				_ = (Ft83Xn)Ey0e9Q.Button1;
			}
			obj2 = obj2;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0W2 f0W);
		while (true)
		{
			if ((object)g7FZc5.Default != null)
			{
				f0W = f0W;
				_ = (Mn3s8)((Ey0e9Q)((p5A6T)f0W.GroupBox2).GroupBox2).ErrorProvider1;
				_ = (p5A6T)(object)((q2A7D)null).Text;
				_ = (o2FH)q2A7D.OK;
			}
			else if (xj.ErrorProvider1 == null && obj2 == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fa16Ls fa16Ls);
		try
		{
			try
			{
				z1X8Wt z1X8Wt = null;
				z1X8Wt = z1X8Wt;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = (o2FH)((Ey0e9Q)ey0e9Q.ErrorProvider1).GroupBox2;
			}
			finally
			{
				f0W = (f0W2)OK;
				goto end_IL_014e;
			}
			end_IL_014e:;
		}
		finally
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out q2A7D q2A7D);
				while (true)
				{
					q2A7D = q2A7D;
					if (q2A7D.ErrorProvider1 != null)
					{
						_ = (Mn3s8)(object)mn3s.Text;
						xj = null;
						continue;
					}
					break;
				}
			}
			finally
			{
				fa16Ls = fa16Ls;
				fa16Ls = fa16Ls;
				goto IL_01fb;
			}
		}
		IL_01fb:
		while (obj2 != null)
		{
			do
			{
				try
				{
					q2A7D q2A7D = null;
				}
				catch
				{
					_ = (z1X8Wt)(object)o2FH.Ee91();
				}
			}
			while (obj2 != null);
		}
		_ = (z1X8Wt)p5A6T.Button1;
		if (num2 == 0)
		{
			_ = (Xj70)f0W.GroupBox2;
		}
		while (obj2 != null)
		{
			try
			{
				_ = (f0W2)((f0W2)null).GroupBox2;
			}
			finally
			{
				try
				{
					p5A6T p5A6T = (p5A6T)(object)g7FZc5.Default;
					p5A6T = (p5A6T)((Xj70)p5A6T.GroupBox2).ErrorProvider1;
				}
				finally
				{
					_ = (Ft83Xn)(object)o2FH.Ee91();
					continue;
				}
			}
		}
		while (obj2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				fa16Ls = fa16Ls;
			}
		}
		while (OK != null)
		{
		}
	}

	static void a6G4()
	{
		f0W2 f0W = (f0W2)q2A7D.OK;
		_ = (o2FH)f0W.GroupBox2;
		_ = (o2FH)p5A6T.Button1;
		UIntPtr num = (UIntPtr)o2FH.Ee91();
		checked
		{
			nuint num2 = unchecked((nuint)(UIntPtr)((Mn3s8)(object)o2FH.Ee91()).Text) - unchecked((nuint)(UIntPtr)OK);
			if (unchecked((nuint)num) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					g7FZc5 g7FZc = null;
					g7FZc = g7FZc;
				}
				finally
				{
					goto IL_0077;
				}
			}
			goto IL_0077;
		}
		IL_02a1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ey0e9Q ey0e9Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fa16Ls fa16Ls);
		do
		{
			fa16Ls = fa16Ls;
			fa16Ls = fa16Ls;
			_ = (Xj70)(object)((Mn3s8)null).Text;
			_ = (f0W2)(object)g7FZc5.Default;
			_ = (Ey0e9Q)ey0e9Q.GroupBox2;
		}
		while (Mn3s8.Button1 != null);
		Ft83Xn ft83Xn;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			UIntPtr num3 = (UIntPtr)Button1;
			nuint num2 = default(UIntPtr);
			if (checked(unchecked((nuint)num3) * num2) / (nuint)(UIntPtr)Yp0w5.OK == 0)
			{
				if ((UIntPtr)Ey0e9Q.Button1 == (UIntPtr)(nuint)0u)
				{
					_ = (p5A6T)Yp0w5.OK;
				}
			}
			else if (num2 == 0)
			{
				ft83Xn = null;
				_ = (f0W2)(object)o2FH.Ee91();
			}
			else
			{
				_ = (Yp0w5)Button1;
			}
		}
		fa16Ls = fa16Ls;
		return;
		IL_0077:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q2A7D q2A7D);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			obj = null;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					q2A7D = q2A7D;
					_ = (o2FH)((f0W2)(object)q2A7D.Text).GroupBox2;
				}
				finally
				{
					_ = (Ey0e9Q)OK;
					continue;
				}
			}
		}
		ft83Xn = (Ft83Xn)(object)((p5A6T)null).Text;
		ft83Xn = ft83Xn;
		p5A6T p5A6T = (p5A6T)(object)((Ey0e9Q)(object)f0W.Text).Text;
		p5A6T = p5A6T;
		while ((object)g7FZc5.Default != null)
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			p5A6T = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mn3s8 mn3s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj70 xj);
		if ((UIntPtr)g7FZc5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Fa16Ls)q2A7D.GroupBox2;
			}
			else if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (Ft83Xn)(object)g7FZc5.Default;
			}
			else
			{
				mn3s = mn3s;
				xj = (Xj70)mn3s.GroupBox2;
				xj = xj;
				_003CModule_003E _003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)xj.ErrorProvider1) * unchecked((nuint)(UIntPtr)Mn3s8.Button1) * unchecked((nuint)(UIntPtr)o2FH.Ee91()) == 0)
			{
				try
				{
					do
					{
						mn3s = null;
					}
					while (obj != null);
				}
				finally
				{
					_ = (Fx3n6R)((Mn3s8)q2A7D.OK).ErrorProvider1;
					goto IL_01f7;
				}
			}
			goto IL_01f7;
		}
		IL_01f7:
		do
		{
			_ = (Ey0e9Q)mn3s.ErrorProvider1;
		}
		while (obj != null);
		if ((UIntPtr)((Yp0w5)null).GroupBox2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					f0W = null;
				}
				finally
				{
					_ = (Xj70)((q2A7D)null).ErrorProvider1;
					_ = (Ey0e9Q)Ey0e9Q.OK;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
		}
		finally
		{
			while (true)
			{
				ey0e9Q = ey0e9Q;
				if (ey0e9Q.GroupBox2 != null)
				{
					try
					{
						_ = (_003CModule_003E)((Yp0w5)((q2A7D)null).GroupBox2).GroupBox2;
					}
					finally
					{
						_ = (_003CModule_003E)(object)o2FH.Ee91();
						p5A6T = p5A6T;
						_ = (Fx3n6R)(object)g7FZc5.Default;
						q2A7D = q2A7D;
						continue;
					}
				}
				break;
			}
			goto IL_02a1;
		}
	}
}
