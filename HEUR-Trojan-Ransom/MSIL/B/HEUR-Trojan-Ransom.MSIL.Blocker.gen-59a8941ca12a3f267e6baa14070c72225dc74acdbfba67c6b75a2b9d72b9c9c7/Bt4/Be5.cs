using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bm7;
using Ma2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;

namespace Bt4;

public class Be5
{
	internal sealed class Wb5
	{
		internal object I;

		internal object w;

		internal object v;

		internal Wb5()
		{
		}
	}

	private object x;

	private object S;

	private object b;

	private object U;

	private object o;

	private Rd0.Cn3 h = new Rd0.Cn3();

	public object O
	{
		get
		{
			return h.U;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			h.U = objectValue;
		}
	}

	public object f
	{
		get
		{
			return h.N;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			h.N = objectValue;
		}
	}

	private void t6T(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		int num = e.get_RowIndex();
		object obj = O;
		object[] obj2 = new object[1] { num };
		Array array = obj2;
		bool[] obj3 = new bool[1] { true };
		Array array2 = obj3;
		object obj4 = NewLateBinding.LateGet(obj, (Type)null, "Rows", obj2, (string[])null, (Type[])null, obj3);
		if (((bool[])array2)[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(int));
		}
		object obj5 = (object)(DataGridViewRow)obj4;
		NewLateBinding.LateSet(x, (Type)null, "Text", new object[1] { ((DataGridViewRow)obj5).get_Cells().get_Item(0).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(S, (Type)null, "Text", new object[1] { ((DataGridViewRow)((obj5 is DataGridViewRow) ? obj5 : null)).get_Cells().get_Item(1).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(b, (Type)null, "Text", new object[1] { ((DataGridViewRow)((obj5 is DataGridViewRow) ? obj5 : null)).get_Cells().get_Item(2).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(U, (Type)null, "Text", new object[1] { ((DataGridViewRow)((obj5 is DataGridViewRow) ? obj5 : null)).get_Cells().get_Item(3).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(h.x, (Type)null, "Text", new object[1] { ((DataGridViewRow)obj5).get_Cells().get_Item(4).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o, (Type)null, "Text", new object[1] { ((DataGridViewRow)obj5).get_Cells().get_Item(5).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(h.S, (Type)null, "Text", new object[1] { ((DataGridViewRow)((obj5 is DataGridViewRow) ? obj5 : null)).get_Cells().get_Item(6).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(h.b, (Type)null, "Text", new object[1] { ((DataGridViewRow)((obj5 is DataGridViewRow) ? obj5 : null)).get_Cells().get_Item(7).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		obj4 = NewLateBinding.LateGet(O, (Type)null, "Rows", (object[])(array = new object[1] { num }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
		if ((array2 as bool[])[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(int));
		}
		DataGridViewBand val = (DataGridViewBand)(DataGridViewRow)obj4;
		((DataGridViewRow)val).get_Cells().get_Item(0).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(1).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(2).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(3).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(4).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(h.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(5).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)val).get_Cells().get_Item(6).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(h.S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)((val is DataGridViewRow) ? val : null)).get_Cells().get_Item(7).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(h.b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}

	private void Kx4(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(O, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		IEnumerable enumerable = "Select request.idrequest, r_fname, r_lname, r_address, bloodtype.bloodtype, r_quantityrequest, r_status, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser where r_status = 'Pending';";
		Tp5();
		object obj = objectValue;
		NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { f }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { (string)enumerable }, (string[])null, (Type[])null);
		obj = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(O, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[8]
			{
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "idrequest" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null)
			} }, (string[])null, (Type[])null, (bool[])null, true);
		}
		Np4();
	}

	private void Np4()
	{
		throw new NotImplementedException();
	}

	private void Tp5()
	{
		throw new NotImplementedException();
	}

	private void z4X(object sender, EventArgs e)
	{
		Jr1();
		Fr7.k6A();
	}

	private void Jr1()
	{
		throw new NotImplementedException();
	}

	private void p8B(object sender, EventArgs e)
	{
		Jr1();
		q1S.s3S();
	}

	private void q2C(object sender, EventArgs e)
	{
	}

	private void Re1(object sender, EventArgs e)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		Tp5();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "@param1", null };
		object obj3 = h.x;
		obj2[1] = NewLateBinding.LateGet(obj3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj4 = obj2;
		bool[] obj5 = new bool[2] { false, true };
		Array array = obj5;
		NewLateBinding.LateCall(obj, (Type)null, "AddWithValue", obj2, (string[])null, (Type[])null, obj5, true);
		if ((array as bool[])[1])
		{
			NewLateBinding.LateSetComplex(obj3, (Type)null, "Text", new object[1] { (obj4 as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				enumerable = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue2, new object[1] { "idbloodtype" }, (string[])null));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				_Exception val = (_Exception)(object)ex;
				Interaction.MsgBox((object)((Exception)(object)val).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		Np4();
		object obj6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE `blood_msdb`.`request` \r\n                  SET \r\n                    `idbloodtype` = '" + (string)enumerable + "',\r\n                    `r_fname` = '"), NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',\r\n                    `r_lname` = '"), NewLateBinding.LateGet(b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',\r\n                    `r_address`  = '"), NewLateBinding.LateGet(U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',\r\n                    `r_quantityrequest` = '"), NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'\r\n                WHERE\r\n                    idrequest = '"), NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"';"));
		Tp5();
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { f }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { obj6 as string}, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			object obj7 = ex2;
			Interaction.MsgBox((object)((Exception)obj7).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		Np4();
		Interaction.MsgBox((object)"Record Updated! ", (MsgBoxStyle)0, (object)null);
		Kx4(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void f0E(object sender, EventArgs e)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"DELETE FROM `blood_msdb`.`request` WHERE (`idrequest` = '", NewLateBinding.LateGet(x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"');"));
		Tp5();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { f }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { enumerable as string}, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj = ex;
			Interaction.MsgBox((object)(obj as Exception).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		Np4();
		Interaction.MsgBox((object)"Successfully deleted!", (MsgBoxStyle)0, (object)null);
		Kx4(RuntimeHelpers.GetObjectValue(sender), e);
	}

	internal static void Yd5()
	{
		throw new NotImplementedException();
	}

	internal static object Tc3(object object_0)
	{
		AppDomain domain = Thread.GetDomain();
		object[] obj = new object[1] { object_0 };
		object obj2 = obj;
		bool[] obj3 = new bool[1] { true };
		Array array = obj3;
		object obj4 = NewLateBinding.LateGet((object)domain, (Type)null, "Load", obj, (string[])null, (Type[])null, obj3);
		if (((bool[])array)[0])
		{
			object_0 = RuntimeHelpers.GetObjectValue((obj2 as object[])[0]);
		}
		return RuntimeHelpers.GetObjectValue(obj4);
	}
}
