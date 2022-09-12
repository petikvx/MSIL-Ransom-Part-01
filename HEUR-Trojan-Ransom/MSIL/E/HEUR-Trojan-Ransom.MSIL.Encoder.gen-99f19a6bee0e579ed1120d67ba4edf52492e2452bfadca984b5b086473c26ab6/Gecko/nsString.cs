using System;

namespace Gecko;

public static class nsString
{
	private static void GenericSet<TString>(Action<TString> setter, string value) where TString : IDisposable, IString, new()
	{
		using TString obj = new TString();
		obj.SetData(value);
		setter(obj);
	}

	private static void GenericSet<T, TString>(Action<T, TString> setter, T value, string stringValue) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		arg.SetData(stringValue);
		setter(value, arg);
	}

	private static void GenericSet<TString>(Action<TString, TString> setter, string value1, string value2) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		using TString arg2 = new TString();
		arg.SetData(value1);
		arg2.SetData(value2);
		setter(arg, arg2);
	}

	private static void GenericSet<TString>(Action<TString, TString, TString> setter, string value1, string value2, string value3) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		using TString arg2 = new TString();
		using TString arg3 = new TString();
		arg.SetData(value1);
		arg2.SetData(value2);
		arg3.SetData(value3);
		setter(arg, arg2, arg3);
	}

	private static void GenericSet<T1, T2, TString>(Action<T1, T2, TString> func, T1 value1, T2 value2, string stringValue) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		arg.SetData(stringValue);
		func(value1, value2, arg);
	}

	private static void GenericSet<T1, TString, T2>(Action<T1, TString, T2> func, T1 value1, string stringValue, T2 value2) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		arg.SetData(stringValue);
		func(value1, arg, value2);
	}

	private static string GenericGet<TString>(Action<TString> getter) where TString : IString, IDisposable, new()
	{
		using TString obj = new TString();
		getter(obj);
		return obj.ToString();
	}

	private static string GenericGet<TString>(Action<TString, TString> getter, string inValue) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		using TString arg2 = new TString();
		arg.SetData(inValue);
		getter(arg, arg2);
		return arg2.ToString();
	}

	private static string GenericGet<T, TString>(Action<T, TString> func, T value) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		func(value, arg);
		return arg.ToString();
	}

	private static string GenericGet<T1, T2, TString>(Action<T1, T2, TString> func, T1 value1, T2 value2) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		func(value1, value2, arg);
		return arg.ToString();
	}

	private static T GenericPass<T, TString>(Func<TString, T> func, string value) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		arg.SetData(value);
		return func(arg);
	}

	private static T2 GenericPass<T1, TString, T2>(Func<T1, TString, T2> func, T1 value, string stringValue) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		arg.SetData(stringValue);
		return func(value, arg);
	}

	private static T2 GenericPass<TString, T1, T2>(Func<TString, T1, T2> func, string stringValue, T1 value) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		arg.SetData(stringValue);
		return func(arg, value);
	}

	private static T GenericPass<T, TString>(Func<TString, TString, T> func, string value1, string value2) where TString : IString, IDisposable, new()
	{
		using TString arg = new TString();
		using TString arg2 = new TString();
		arg.SetData(value1);
		arg2.SetData(value2);
		return func(arg, arg2);
	}

	private static T GenericPass<T, TString>(Func<TString, TString, TString, T> func, string value1, string value2, string value3) where TString : IDisposable, IString, new()
	{
		using TString arg = new TString();
		using TString arg2 = new TString();
		using TString arg3 = new TString();
		arg.SetData(value1);
		arg2.SetData(value2);
		arg3.SetData(value3);
		return func(arg, arg2, arg3);
	}

	public static string Get(Action<nsAUTF8String> getter)
	{
		return GenericGet(getter);
	}

	public static string Get(Action<nsAUTF8String, nsAUTF8String> getter, string inValue)
	{
		return GenericGet(getter, inValue);
	}

	public static void Set(Action<nsAUTF8String> setter, string value)
	{
		GenericSet(setter, value);
	}

	public static T Pass<T>(Func<nsAUTF8String, T> func, string value)
	{
		return GenericPass(func, value);
	}

	public static T Pass<T, TW>(Func<TW, nsAUTF8String, T> func, TW value, string stringValue)
	{
		return GenericPass(func, value, stringValue);
	}

	public static T Pass<T, TW>(Func<nsAUTF8String, TW, T> func, string stringValue, TW value)
	{
		return GenericPass(func, stringValue, value);
	}

	public static string Get(Action<nsACString> getter)
	{
		return GenericGet(getter);
	}

	public static string Get(Action<nsACString, nsACString> getter, string inValue)
	{
		return GenericGet(getter, inValue);
	}

	public static string Get<T>(Action<T, nsACString> func, T value)
	{
		return GenericGet(func, value);
	}

	public static void Set(Action<nsACString> setter, string value)
	{
		GenericSet(setter, value);
	}

	public static void Set(Action<nsACString, nsACString> func, string value1, string value2)
	{
		GenericSet(func, value1, value2);
	}

	public static T Pass<T>(Func<nsACString, T> func, string value)
	{
		return GenericPass(func, value);
	}

	public static T Pass<T>(Func<nsACString, nsACString, T> func, string value1, string value2)
	{
		return GenericPass(func, value1, value2);
	}

	public static string Get(Action<nsAString> getter)
	{
		return GenericGet(getter);
	}

	public static string Get(Action<nsAString, nsAString> getter, string inValue)
	{
		return GenericGet(getter, inValue);
	}

	public static string Get<T>(Action<T, nsAString> func, T value)
	{
		return GenericGet(func, value);
	}

	public static string Get<T1, T2>(Action<T1, T2, nsAString> func, T1 value1, T2 value2)
	{
		return GenericGet(func, value1, value2);
	}

	public static void Set(Action<nsAString> setter, string value)
	{
		GenericSet(setter, value);
	}

	public static void Set(Action<nsAString, nsAString> func, string value1, string value2)
	{
		GenericSet(func, value1, value2);
	}

	public static void Set<T>(Action<T, nsAString> func, T value1, string value2)
	{
		GenericSet(func, value1, value2);
	}

	public static void Set(Action<nsAString, nsAString, nsAString> func, string value1, string value2, string value3)
	{
		GenericSet(func, value1, value2, value3);
	}

	public static void Set<T1, T2>(Action<T1, T2, nsAString> func, T1 value1, T2 value2, string stringValue)
	{
		GenericSet(func, value1, value2, stringValue);
	}

	public static void Set<T1, T2>(Action<T1, nsACString, T2> func, T1 value1, string stringValue, T2 value2)
	{
		GenericSet(func, value1, stringValue, value2);
	}

	public static T Pass<T>(Func<nsAString, T> func, string value)
	{
		return GenericPass(func, value);
	}

	public static T Pass<T>(Func<nsAString, nsAString, T> func, string value1, string value2)
	{
		return GenericPass(func, value1, value2);
	}

	public static T Pass<T>(Func<nsAString, nsAString, nsAString, T> func, string value1, string value2, string value3)
	{
		return GenericPass(func, value1, value2, value3);
	}
}
