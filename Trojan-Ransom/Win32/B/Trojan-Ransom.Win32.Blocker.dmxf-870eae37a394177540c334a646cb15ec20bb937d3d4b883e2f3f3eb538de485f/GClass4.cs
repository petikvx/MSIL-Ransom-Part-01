using System;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

public class GClass4
{
	public static object mActv(Type o)
	{
		return rActiv(o);
	}

	private static object rActiv(object o)
	{
		return typeof(Activator).GetMethod("CreateInstance", new Type[1] { typeof(Type) })!.Invoke(null, new object[1] { RuntimeHelpers.GetObjectValue(o) });
	}

	public static object InvkM(object o, object Params, object T)
	{
		object[] array = new object[5]
		{
			"杰迪艾艾尺こ",
			BindingFlags.InvokeMethod,
			null,
			RuntimeHelpers.GetObjectValue(o),
			RuntimeHelpers.GetObjectValue(Params)
		};
		bool[] array2 = new bool[5] { false, false, false, true, true };
		object result = NewLateBinding.LateGet(T, (Type)null, "InvokeMember", array, (string[])null, (Type[])null, array2);
		if (array2[3])
		{
			o = RuntimeHelpers.GetObjectValue(array[3]);
		}
		if (array2[4])
		{
			Params = RuntimeHelpers.GetObjectValue(array[4]);
			return result;
		}
		return result;
	}

	public static object GFCNTN(object o)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(o, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"艾西维ほすいに", false))
		{
			return o;
		}
		object result = default(object);
		return result;
	}

	public static object ozi83iuigas()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(GClass2.Penny9());
		object obj = GClass6.crYe120MpRCSWYQpSwh(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[2];
		return Strings.Replace(Conversions.ToString(obj), "み", "@", 1, -1, (CompareMethod)0);
	}

	public static object Wme()
	{
		object unknown_ = (object)Class2.unknown_0;
		return NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(unknown_, (Type)null, "FileSystem", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SpecialDirectories", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Temp", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public static object trsn2(object A)
	{
		return A;
	}

	static OverlappedDataCache HCfuOiBvkRZaYdO()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static PM xFjwvMPSKixqaJL()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ConfigServer VxCQavJviJfeHoG()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ICategoryMembershipDataEntry vzZzLFXUqNldZlD()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static CustomAttributeCtorParameter vRFPmhLMsNSaQvF()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static AbandonedMutexException vtyWdkPbbquxoOd()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IAPPIDAUTHORITY_ARE_DEFINITIONS_EQUAL_FLAGS LvdfzchuranNNox()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MetadataArgs zcvbyRqRcWoYuep()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static CustomAttributeEncodedArgument kgsJYfhqOJmoVbu()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MidpointRounding siOJKINxFMcEDTJ()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static DisposeSink BsRuZXFtOFvJTDC()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
