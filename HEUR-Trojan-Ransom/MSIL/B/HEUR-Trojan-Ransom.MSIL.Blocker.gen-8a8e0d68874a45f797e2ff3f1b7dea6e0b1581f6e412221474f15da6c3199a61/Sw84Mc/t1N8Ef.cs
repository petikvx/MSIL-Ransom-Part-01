using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Sw84Mc;

public class t1N8Ef
{
	[StructLayout(LayoutKind.Auto)]
	internal struct s3M4Do
	{
		internal object object_0;

		internal SqlConnection sqlConnection_0;

		internal SqlCommand sqlCommand_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal object object_9;

		internal object object_10;

		internal object object_11;

		internal object object_12;

		internal object object_13;

		internal object object_14;

		internal object object_15;

		internal object object_16;

		internal object object_17;
	}

	private object TableAdapterManager;

	private object Database2DataSet3;

	private object RoomTableAdapter;

	private void Tj39Cb(object sender, EventArgs e)
	{
		k8Q9Nq();
		NewLateBinding.LateCall(d1BYe9(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private object d1BYe9()
	{
		throw new NotImplementedException();
	}

	private void k8Q9Nq()
	{
		throw new NotImplementedException();
	}

	private void d4E2Rp(object sender, EventArgs e)
	{
		object roomTableAdapter = RoomTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet3;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(roomTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Room", new object[1] { ((object[])obj)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void n8E6Hg()
	{
		throw new NotImplementedException();
	}
}
