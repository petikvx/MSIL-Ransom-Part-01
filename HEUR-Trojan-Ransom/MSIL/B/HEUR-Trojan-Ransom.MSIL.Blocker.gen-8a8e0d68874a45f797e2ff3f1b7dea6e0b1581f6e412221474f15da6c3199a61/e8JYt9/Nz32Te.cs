using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Wc93E;

namespace e8JYt9;

public class Nz32Te
{
	private object RegisterBindingSource;

	private object TableAdapterManager;

	private object Database1DataSet;

	private object PaymentsTableAdapter;

	private object Database2DataSet2;

	private Np7d3.Jn5f9 jn5f9_0;

	private void f4G9We(object sender, EventArgs e)
	{
		f1Q7Lq();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private void f1Q7Lq()
	{
		throw new NotImplementedException();
	}

	private void Nt1b5B(object sender, EventArgs e)
	{
		object paymentsTableAdapter = PaymentsTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet2;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(paymentsTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { ((object[])obj)[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_ = jn5f9_0.object_0;
		object[] array2 = new object[1];
		database2DataSet = Database1DataSet;
		array2[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		obj = array2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array2, (string[])null, (Type[])null, (bool[])(obj3 = new bool[1] { true }), true);
		if (((bool[])obj3)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { ((object[])obj)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void x9LRn1()
	{
		throw new NotImplementedException();
	}
}
