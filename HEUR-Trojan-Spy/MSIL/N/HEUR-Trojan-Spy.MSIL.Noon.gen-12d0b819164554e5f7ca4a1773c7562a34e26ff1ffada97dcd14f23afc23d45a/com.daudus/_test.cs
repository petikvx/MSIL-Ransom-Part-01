using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

[StandardModule]
internal sealed class _test
{
	public static void ConnectorTest(ref object m_repository)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_repository, (Type)null, "GetElementByID", new object[1] { 6453 }, (string[])null, (Type[])null, (bool[])null));
		RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_repository, (Type)null, "GetElementByID", new object[1] { 6452 }, (string[])null, (Type[])null, (bool[])null));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Connectors", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", new object[2] { "test link 2", "Association" }, (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue2, (Type)null, "SupplierID", new object[1] { 6452 }, (string[])null, (Type[])null);
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue2, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Connectors", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Console.WriteLine("Connector Created");
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type)null, "Constraints", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", new object[2] { "constraint2", "type" }, (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue3, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", new object[2] { "Tag", "Value" }, (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue3, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ClientEnd", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue4, (Type)null, "Visibility", new object[1] { "Private" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue4, (Type)null, "Role", new object[1] { "m_client" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(objectValue4, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "SupplierEnd", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue5, (Type)null, "Visibility", new object[1] { "Protected" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue5, (Type)null, "Role", new object[1] { "m_supplier" }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(objectValue5, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Console.WriteLine("Client and Supplier set");
		Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, (Type)null, "Role", new object[0], (string[])null, (Type[])null, (bool[])null)));
		Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, (Type)null, "Role", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}
}
