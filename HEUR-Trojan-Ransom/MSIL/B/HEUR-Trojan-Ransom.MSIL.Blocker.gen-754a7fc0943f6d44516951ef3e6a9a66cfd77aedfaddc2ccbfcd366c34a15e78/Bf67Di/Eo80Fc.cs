using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bg;
using Dx;
using Ei7w3F;
using Go6i1R;
using Hq;
using Microsoft.VisualBasic.CompilerServices;
using Qg52D;
using Sf94Hc;
using Xf;
using a5;
using d8;
using g6;
using t5P2G;
using z0B8Z;

namespace Bf67Di;

public class Eo80Fc
{
	public class k4HMb5
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

	public Eo80Fc()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		myconnection = new OleDbConnection();
		da = new OleDbDataAdapter();
	}

	public void d2XAe6()
	{
		NewLateBinding.LateCall(UsernameTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(PasswordTextBox, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void My2z0N(object sender, EventArgs e)
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
			d2XAe6();
			NewLateBinding.LateCall(ErrorProvider1, (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Mf6p5L();
		}
		myconnection.Close();
	}

	private void Mf6p5L()
	{
		throw new NotImplementedException();
	}

	internal static void Kq6p0S()
	{
		throw new NotImplementedException();
	}

	private void e3XDa6(object sender, EventArgs e)
	{
		Gc01Rm();
	}

	private void Gc01Rm()
	{
		throw new NotImplementedException();
	}

	static void Gm40Jb()
	{
		_ = (x8)Wz.Button1;
		_ = (Pa)Button1;
		x8 x = x;
		x = x;
		Tw0f1 tw0f = tw0f;
		tw0f = tw0f;
		d9C5Xt d9C5Xt = d9C5Xt;
		UIntPtr num = (UIntPtr)d9C5Xt.Text;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bi48Xf bi48Xf);
		checked
		{
			if (unchecked((nuint)num) - uIntPtr == 0)
			{
				bi48Xf = bi48Xf;
				if (unchecked((UIntPtr)bi48Xf.Text == (UIntPtr)(nuint)0u))
				{
					if (uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
					{
						bi48Xf = bi48Xf;
					}
					else
					{
						d9C5Xt = null;
					}
				}
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Yd43Gw)Button1;
			}
			finally
			{
				_ = (j1)OK;
				goto IL_00d6;
			}
		}
		goto IL_00d6;
		IL_0388:
		_ = (Tw0f1)a7.OK;
		return;
		IL_030e:
		uIntPtr = default(UIntPtr);
		object obj;
		if (checked(uIntPtr * (uIntPtr * uIntPtr)) == 0)
		{
			while (obj != null)
			{
				_ = (Wz)(object)Yd43Gw.Nb8f0R();
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eo80Fc eo80Fc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wz wz);
		try
		{
			_ = (a7)(object)Yd43Gw.Nb8f0R();
		}
		finally
		{
			try
			{
				_ = (j1)((Bi48Xf)eo80Fc.ErrorProvider1).GroupBox2;
			}
			finally
			{
				try
				{
					_ = (Yd43Gw)(object)wz.Text;
				}
				finally
				{
					_ = (Zz21N)Nr.Button1;
					goto IL_0388;
				}
			}
		}
		IL_0189:
		_ = (Eo80Fc)f7.Button1;
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (f7)((Wz)null).ErrorProvider1;
			}
		}
		catch
		{
			try
			{
				bi48Xf = bi48Xf;
			}
			catch
			{
				Eo80Fc obj2 = (Eo80Fc)f7.OK;
				eo80Fc = null;
				eo80Fc = obj2;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Eo80Fc)Button1;
				}
				finally
				{
					_ = (_003CModule_003E)((Nr)null).ErrorProvider1;
					goto end_IL_01cf;
				}
				end_IL_01cf:;
			}
			finally
			{
				try
				{
					wz = wz;
				}
				finally
				{
					_ = (d9C5Xt)((f7)null).GroupBox2;
					goto IL_020a;
				}
			}
		}
		IL_020a:
		try
		{
			Pa pa = pa;
			pa = pa;
			_ = (j1)wz.ErrorProvider1;
		}
		finally
		{
			f7 f = (f7)(object)((a7)(object)x8.Default).Text;
			_ = (Qi79E)((Wz)(object)Yd43Gw.Nb8f0R()).ErrorProvider1;
			_ = (f7)(object)x8.Default;
			_ = (Wz)(object)Yd43Gw.Nb8f0R();
			goto IL_02a2;
		}
		IL_00d6:
		do
		{
			_ = (Zz21N)f7.Button1;
			obj = null;
		}
		while (((Wz)null).GroupBox2 != null);
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) + unchecked(uIntPtr / (uIntPtr / uIntPtr) / uIntPtr) != 0)
			{
			}
			d9C5Xt = d9C5Xt;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out f7 f);
			while ((object)bi48Xf.Text != null)
			{
				do
				{
					f = f;
					f = f;
				}
				while (obj != null);
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Yd43Gw)(object)((Bi48Xf)null).Text;
				a7 a = null;
				_ = (d9C5Xt)a.GroupBox2;
			}
			else
			{
				_ = (Nr)(object)x8.Default;
			}
			goto IL_0189;
		}
		IL_02a2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j1 j);
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (f7)(object)x8.Default;
				}
			}
			catch
			{
				j = j;
				j = j;
			}
		}
		_ = (x8)a7.Button1;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					wz = null;
				}
				catch
				{
					d9C5Xt = (d9C5Xt)(object)((Nr)OK).Text;
					_ = (j1)(object)Yd43Gw.Nb8f0R();
					f7 f = null;
				}
			}
		}
		finally
		{
			do
			{
				wz = wz;
			}
			while ((object)Yd43Gw.Nb8f0R() != null);
			goto IL_030e;
		}
	}
}
