using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using A_0024r;
using Dn7;
using Je5;
using Microsoft.VisualBasic.CompilerServices;
using Xt9;
using ns1;
using ns10;
using ns11;
using ns12;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns5;

public class GClass0 : Application
{
	internal delegate void Delegate0();

	internal static byte[] O;

	internal static byte[] R;

	internal static Assembly v;

	private static StringBuilder u;

	private static Type[] d;

	private static void smethod_0()
	{
		try
		{
			StringBuilder stringBuilder = u;
			if (stringBuilder != null && 16 <= stringBuilder.Capacity)
			{
				u = null;
				stringBuilder.Clear();
			}
			string[] array = new string[16];
			int int_ = 15;
			int num = 15;
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				array[i] = GClass1.smethod_0(int_, i).ToString();
			}
			O = GClass1.smethod_1(array, int_);
			R = GClass2.smethod_0(Qk7.Sp2());
			v = Class7.smethod_0().Load(R);
			smethod_1(v.GetExportedTypes());
			string text = string.Concat(new string[4] { "h", "A", "5", "1" });
			Type[] array2 = Xs1();
			foreach (Type type in array2)
			{
				if (Operators.CompareString(type.Name, text, false) == 0)
				{
					((Delegate0)Class8.smethod_0(type))();
					break;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	public static void Main()
	{
		smethod_0();
	}

	[SpecialName]
	internal static Type[] Xs1()
	{
		return d;
	}

	[SpecialName]
	internal static void smethod_1(Type[] type_0)
	{
		d = type_0;
	}

	unsafe static void Mm4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		nuint num;
		checked
		{
			num = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Class5.Default);
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) + num == 0)
			{
				_ = (Class4)(object)Class5.Default;
			}
			else
			{
				@class = (Class2)(object)Class5.Default;
				@class = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			@struct = @struct;
			@struct = @struct;
			class2 = class2;
			Class7 class3 = class2;
			obj = Class5.Default;
			_ = (Struct1)class3.t(obj, null, null);
			object object_ = obj;
			type = null;
			Type type_ = type;
			cultureInfo = null;
			Class7 obj2 = (Class7)((Class7)null).t(object_, type_, cultureInfo);
			bindingFlags = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_ = bindingFlags;
			array = array;
			MethodBase[] methodBase_ = array;
			bindingFlags = default(BindingFlags);
			Class7 obj3 = (Class7)((Class7)(object)obj2.e(bindingFlags_, methodBase_, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), (object)null, (CultureInfo)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)), null)).t(null, null, cultureInfo);
			BindingFlags bindingFlags_2 = bindingFlags;
			array2 = array2;
			_ = (Qk7)(object)obj3.t(bindingFlags_2, array2, obj, null);
			class4 = class4;
			class4 = class4;
		}
		catch
		{
			if ((UIntPtr)class2.t(bindingFlags, array2, obj, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				catch
				{
					Class7 class5 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class5.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null);
					class6 = null;
					class6 = class6;
					_ = (Class10)(object)class2.t(bindingFlags, null, obj, null);
					Struct2 obj4 = (Struct2)Class5.Default;
					struct2 = struct2;
					struct2 = obj4;
				}
			}
		}
		while (obj != null)
		{
			do
			{
				if (num == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class8);
		try
		{
			_ = Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class7 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_4 = bindingFlags;
			Type type_2 = (Type)(object)Class5.Default;
			array3 = null;
			Type[] type_3 = array3;
			array4 = (ParameterModifier[])(object)Class5.Default;
			array5 = (PropertyInfo[])(object)class7.W(bindingFlags_4, null, type_2, type_3, array4);
			GClass1 obj7 = (GClass1)(object)((Class7)null).W(bindingFlags_3, array5, type, array3, array4);
			gClass = gClass;
			gClass = obj7;
			class6 = class6;
			class8 = class8;
			class8 = null;
		}
		catch
		{
			BindingFlags bindingFlags_5 = bindingFlags;
			FieldInfo[] fieldInfo_ = array2;
			Class7 class9 = class2;
			BindingFlags bindingFlags_6 = bindingFlags;
			BindingFlags bindingFlags_7 = bindingFlags;
			Class7 class10 = class2;
			MethodBase[] methodBase_2 = array;
			Type[] type_4 = array3;
			Class7 class11 = class2;
			Class7 class12 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = (BindingFlags)class12.j(bindingFlags, null, ref *(object[]*)class2.e(bindingFlags, null, (Type[])class2.t(obj, (Type)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), cultureInfo), null), array4, cultureInfo, (string[])(object)class2.t(bindingFlags, array2, Class5.Default, null), out *(object*)null);
			MethodBase[] methodBase_3 = array;
			reference = ref *(object[]*)null;
			ref object[] object_2 = ref reference;
			ParameterModifier[] parameterModifier_ = array4;
			CultureInfo cultureInfo_ = cultureInfo;
			array6 = array6;
			string[] string_ = array6;
			reference2 = ref reference2;
			_ = (Class5)(object)((Class7)(object)((Class7)null).t(bindingFlags_5, fieldInfo_, (object)class9.W(bindingFlags_6, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_7, (PropertyInfo[])(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class10.e(default(BindingFlags), methodBase_2, type_4, (ParameterModifier[])(object)class11.j(bindingFlags_8, methodBase_3, ref object_2, parameterModifier_, cultureInfo_, string_, out reference2)), ref *(object[]*)Class5.Default, array4, cultureInfo, array6, out reference2), (Type)null, array3, (ParameterModifier[])null), (Type)(object)class2.j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null), null, out reference2), array3, array4), (CultureInfo)null)).t(bindingFlags, array2, obj, cultureInfo);
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num == 0)
		{
			try
			{
				_ = (Class10)(object)class2.e(bindingFlags, null, null, array4);
			}
			catch
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])class2.t(obj, type, cultureInfo), type, array3, (ParameterModifier[])(object)((Class7)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)((Class7)null).t((BindingFlags)((Class7)null).e(bindingFlags, array, array3, array4), (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)Class5.Default)), (ParameterModifier[])null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null)), array, (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
				{
					gClass2 = gClass2;
					gClass2 = gClass2;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					BindingFlags bindingFlags_9 = bindingFlags;
					PropertyInfo[] propertyInfo_ = array5;
					Type type_5 = type;
					Type[] type_6 = array3;
					Class7 class13 = class2;
					BindingFlags bindingFlags_10 = bindingFlags;
					Type type_7 = type;
					BindingFlags bindingFlags_11 = bindingFlags;
					ref object[] object_3 = ref reference;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)(object)((Class7)null).W(bindingFlags_9, propertyInfo_, type_5, type_6, (ParameterModifier[])(object)((Class7)(object)class13.W(bindingFlags_10, null, type_7, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_11, (MethodBase[])null, ref object_3, (ParameterModifier[])null, (CultureInfo)(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)(object)Class5.Default), (string[])null, out reference2))).W(bindingFlags, array5, type, null, array4))).t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4), null, obj, (CultureInfo)(object)Class5.Default);
					Class7 class14 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class14.j(bindingFlags, null, ref *(object[]*)Class5.Default, array4, null, null, out reference2);
				}
				finally
				{
					qk = null;
					qk = qk;
					continue;
				}
			}
		}
		finally
		{
			Class7 class15 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class15.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, null);
			goto IL_0758;
		}
		IL_1b4f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class17);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					_ = (Struct2)class2.t(obj, null, cultureInfo);
				}
				finally
				{
					struct2 = (Struct2)Class5.Default;
					Class7 obj10 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_12 = bindingFlags;
					object object_4 = Class5.Default;
					Type type_8 = type;
					Class7 class16 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj10.t(bindingFlags_12, null, ((Class7)null).t(object_4, type_8, (CultureInfo)(object)class16.e(bindingFlags, array, null, null)), null);
					goto end_IL_1b50;
				}
			}
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				goto end_IL_1b50;
			}
			end_IL_1b50:;
		}
		finally
		{
			do
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					class17 = null;
					_ = (Class2)(object)Class5.Default;
					Class7 class18 = class2;
					Class7 class19 = class2;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)class18.t(class19.e(bindingFlags, array, null, array4), (Type)(object)Class5.Default, null);
					_ = (Class8)(object)Class5.Default;
				}
			}
			while ((object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)((Class7)(object)Class5.Default).t(null, null, null), (Type[])null, array4) != null);
			goto IL_1cd7;
		}
		IL_3fd2:
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr)) == 0)
			{
				num = default(UIntPtr);
				if ((num + unchecked((nuint)(UIntPtr)Class5.Default)) * (num + num) == 0)
				{
					if (num - unchecked((nuint)(UIntPtr)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array4)) == 0)
					{
						@struct = @struct;
					}
					else
					{
						_ = (Class9)(object)Class5.Default;
					}
				}
				else if (num == 0)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
				return;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
			}
			return;
		}
		finally
		{
			_ = (Class0)(object)class2.W(bindingFlags, null, null, array3, (ParameterModifier[])(object)class2.e(bindingFlags, array, (Type[])class2.t(obj, type, null), null));
			return;
		}
		IL_35a4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class20);
		try
		{
			do
			{
				if (num != 0)
				{
					qk = null;
					continue;
				}
				@struct = default(Struct1);
				@struct = @struct;
				class6 = class6;
				_ = (Struct1)class2.W(default(BindingFlags), array5, (Type)(object)Class5.Default, array3, null);
			}
			while ((object)class2.t(default(BindingFlags), array2, obj, cultureInfo) != null);
		}
		finally
		{
			while (obj != null)
			{
				class20 = Class5.Default;
			}
			goto IL_364b;
		}
		IL_0f55:
		while ((object)Class5.Default != null)
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		if (num == 0)
		{
			class4 = (Class0)(object)((Class7)null).t(bindingFlags, array2, (object)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array6, out reference2), cultureInfo);
			_ = (Class2)(object)class2.j(bindingFlags, null, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out reference2);
			goto IL_1021;
		}
		try
		{
		}
		finally
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				_ = (Class10)(object)Class5.Default;
				goto IL_1021;
			}
		}
		IL_1d24:
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, null);
				}
				while (obj != null);
			}
		}
		catch
		{
			do
			{
				class2 = class2;
				class17 = null;
				class2 = null;
				_ = (Class7)((Class7)null).t(obj, (Type)null, cultureInfo);
			}
			while ((object)Class5.Default != null || obj != null);
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					@class = @class;
				}
			}
			else
			{
				try
				{
					@struct = (Struct1)Class5.Default;
				}
				catch
				{
					Class7 class21 = class2;
					BindingFlags bindingFlags_13 = bindingFlags;
					Class7 class22 = class2;
					Class7 class23 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = (BindingFlags)class23.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)Class5.Default), (Type[])(object)Class5.Default, null);
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)class2.j(bindingFlags, null, ref *(object[]*)class2.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default), array4, null, (string[])(object)Class5.Default, out *(object*)null);
					object object_5 = Class5.Default;
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class21.t(bindingFlags_13, (FieldInfo[])(object)class22.t(bindingFlags_14, fieldInfo_2, object_5, (CultureInfo)(object)class24.t(bindingFlags, null, obj, cultureInfo)), Class5.Default, null);
					class2 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).e(bindingFlags, array, (Type[])null, array4);
				}
			}
		}
		catch
		{
			do
			{
				qk = qk;
				_ = (Class7)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		_ = (GClass2)(object)Class5.Default;
		Class8 class27;
		do
		{
			try
			{
				_ = (Class2)(object)class2.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				_ = (Class4)(object)Class5.Default;
				Class7 class25 = class2;
				Class7 obj14 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_15 = bindingFlags;
				MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
				ref object[] object_6 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
				string[] string_2 = array6;
				Class7 class26 = class2;
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_5 = array;
				Class7 obj15 = (Class7)(object)class2.e(bindingFlags, array, array3, array4);
				bindingFlags = default(BindingFlags);
				class27 = (Class8)class25.t(obj14.j(bindingFlags_15, methodBase_4, ref object_6, parameterModifier_2, null, string_2, out *(object*)class26.e(bindingFlags_16, methodBase_5, null, (ParameterModifier[])(object)obj15.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default))), (Type)(object)Class5.Default, cultureInfo);
			}
		}
		while (obj != null || obj != null);
		Class10 class28 = (Class10)(object)Class5.Default;
		while (obj != null)
		{
		}
		class4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		checked
		{
			nuint num2 = unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default));
			num = default(UIntPtr);
			if (num2 * num == 0)
			{
				class20 = class20;
			}
			try
			{
				do
				{
					try
					{
						gClass3 = gClass3;
					}
					catch
					{
						class4 = null;
					}
				}
				while (obj != null);
			}
			catch
			{
				_ = Class5.Default;
			}
			if (num == 0)
			{
				_ = (Class6)(object)Class5.Default;
				class8 = class8;
				Class7 class29 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class29.W(bindingFlags, array5, null, (Type[])((Class7)null).t(obj, (Type)(object)class2.W(bindingFlags, array5, type, array3, array4), (CultureInfo)null), array4);
			}
		}
		if (num == 0)
		{
			do
			{
				gClass2 = (GClass3)(object)Class5.Default;
				_ = (Class2)((Class7)(object)Class5.Default).t(class2.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array6, out *(object*)null), type, (CultureInfo)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array6, out *(object*)Class5.Default));
				qk = qk;
				Class7 class30 = class2;
				Type type_9 = type;
				Class7 class31 = class2;
				bindingFlags = default(BindingFlags);
				class28 = (Class10)(object)((Class7)null).W((BindingFlags)((Class7)null).t(class30.t(null, type_9, (CultureInfo)(object)class31.W(bindingFlags, null, type, array3, null)), type, (CultureInfo)null), array5, (Type)(object)Class5.Default, array3, array4);
			}
			while (obj != null);
		}
		try
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				while (obj != null)
				{
					class27 = null;
				}
				goto end_IL_221e;
			}
			end_IL_221e:;
		}
		catch
		{
			Class7 class32 = class2;
			MethodBase[] methodBase_6 = (MethodBase[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
			Class7 class33 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class32.e(default(BindingFlags), methodBase_6, null, (ParameterModifier[])(object)class33.j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, cultureInfo, null, out reference2));
		}
		_ = (GClass1)(object)class2.W(bindingFlags, null, null, (Type[])(object)class2.e(bindingFlags, array, array3, array4), array4);
		Class7 class34 = class2;
		Class7 class35 = class2;
		Class7 obj21 = (Class7)class2.t(null, (Type)(object)Class5.Default, cultureInfo);
		BindingFlags bindingFlags_17 = bindingFlags;
		PropertyInfo[] propertyInfo_2 = array5;
		Class7 class36 = class2;
		BindingFlags bindingFlags_18 = bindingFlags;
		PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
		BindingFlags bindingFlags_19 = bindingFlags;
		MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
		ref object[] object_7 = ref reference;
		ParameterModifier[] parameterModifier_3 = array4;
		CultureInfo cultureInfo_2 = cultureInfo;
		string[] string_3 = (string[])(object)((Class7)null).t(default(BindingFlags), array2, obj, (CultureInfo)null);
		Class7 class37 = class2;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)class34.j((BindingFlags)class35.t((BindingFlags)obj21.W(bindingFlags_17, propertyInfo_2, (Type)(object)class36.W(bindingFlags_18, propertyInfo_3, null, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_19, methodBase_7, ref object_7, parameterModifier_3, cultureInfo_2, string_3, out *(object*)class37.e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, array2, ((Class7)(object)Class5.Default).e(bindingFlags, array, array3, array4), null), array3, array4))), null, (ParameterModifier[])(object)Class5.Default), array2, null, cultureInfo), array, ref reference, (ParameterModifier[])((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), cultureInfo, null, out reference2);
		try
		{
			class20 = class20;
			Class7 class38 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)class38.e(bindingFlags, null, array3, null);
		}
		catch
		{
			gClass2 = gClass2;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class8 = class8;
			}
		}
		try
		{
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while ((object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, array, ref reference, array4, cultureInfo, array6, out reference2), array3, (ParameterModifier[])null), (object)null, cultureInfo) != null);
		}
		catch
		{
			checked
			{
				if (num == 0)
				{
					if (num * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)class2.t(obj, (Type)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference2)), (CultureInfo)(object)Class5.Default)).t(obj, null, cultureInfo), array2, null, cultureInfo)) == 0)
					{
						class17 = null;
					}
				}
				else
				{
					do
					{
						gClass = (GClass1)(object)class2.t(bindingFlags, array2, Class5.Default, cultureInfo);
					}
					while (obj != null);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				goto IL_262d;
			}
		}
		goto IL_262d;
		IL_389b:
		_ = (Class8)(object)Class5.Default;
		_ = (GClass2)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null);
		_ = (Class8)(object)Class5.Default;
		class27 = null;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass3)(object)class2.j(bindingFlags, array, ref reference, null, null, array6, out reference2);
			}
			catch
			{
				gClass3 = null;
			}
			goto IL_3a52;
		}
		try
		{
			gClass2 = gClass2;
		}
		finally
		{
			class20 = class20;
			goto IL_3a52;
		}
		IL_1021:
		_ = (Qk7)(object)Class5.Default;
		try
		{
			gClass2 = (GClass3)(object)Class5.Default;
		}
		finally
		{
			while (true)
			{
				Class7 class39 = class2;
				bindingFlags = default(BindingFlags);
				if ((object)class39.W(bindingFlags, null, type, null, array4) != null)
				{
					while ((object)Class5.Default != null)
					{
						_ = (Struct1)class2.t(bindingFlags, null, ((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)Class5.Default, array6, out reference2), cultureInfo);
						_ = (GClass1)(object)Class5.Default;
						_ = (Class0)(object)Class5.Default;
						@class = null;
					}
					continue;
				}
				break;
			}
			goto IL_10de;
		}
		IL_1cd7:
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				class2 = class2;
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, null) == (UIntPtr)(nuint)0u)
				{
					qk = (Qk7)class2.t(obj, type, null);
				}
				goto IL_1d24;
			}
		}
		goto IL_1d24;
		IL_0758:
		class4 = (Class0)(object)class2.j(bindingFlags, array, ref *(object[]*)null, array4, null, array6, out reference2);
		class17 = class17;
		class17 = class17;
		do
		{
			_ = (Class2)(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)class2.W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array4, null, null, out *(object*)null), null)).t((BindingFlags)Class5.Default, null, null, (CultureInfo)(object)Class5.Default), null, obj, cultureInfo);
			qk = qk;
			@class = @class;
			struct2 = default(Struct2);
		}
		while (obj != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					class8 = (Class6)(object)Class5.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		struct2 = (Struct2)((Class7)class2.t(Class5.Default, (Type)(object)Class5.Default, null)).e(bindingFlags, null, array3, array4);
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)Class5.Default;
				}
				else
				{
					_ = (GClass3)class2.t(null, null, null);
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class20 = class20;
					class20 = null;
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		checked
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - num == 0)
				{
					Class7 class40 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class40.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array4);
					continue;
				}
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					struct2 = struct2;
					continue;
				}
			}
			class2 = null;
			class6 = class6;
			_003CModule_003E = null;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			finally
			{
				if (num == 0)
				{
					gClass3 = gClass3;
					gClass3 = null;
				}
				else
				{
					Class10 obj26 = (Class10)class2.t(obj, null, (CultureInfo)(object)Class5.Default);
					class28 = (Class10)(object)class2.t((BindingFlags)Class5.Default, array2, null, cultureInfo);
					class28 = obj26;
				}
				goto end_IL_0999;
			}
			end_IL_0999:;
		}
		catch
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (Class5)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array4, cultureInfo, (string[])(object)class2.W(bindingFlags, array5, type, null, array4), out *(object*)Class5.Default);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		num = default(UIntPtr);
		checked
		{
			if (num + num == 0)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) + num == 0)
					{
						class8 = class8;
					}
				}
				finally
				{
					try
					{
						_ = (GClass1)(object)class2.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default);
					}
					finally
					{
						_ = (Qk7)(object)Class5.Default;
						goto IL_0b4a;
					}
				}
			}
			if (num == 0)
			{
				try
				{
					Class7 class41 = class2;
					object object_8 = obj;
					Class7 obj28 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					struct2 = (Struct2)class41.t(object_8, (Type)(object)obj28.t(bindingFlags, array2, obj, cultureInfo), null);
					class4 = class4;
					struct2 = default(Struct2);
					struct2 = struct2;
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					class28 = null;
				}
			}
			goto IL_0b4a;
		}
		IL_10de:
		_ = (Struct1)Class5.Default;
		while ((object)Class5.Default != null)
		{
			Class7 class42 = class2;
			BindingFlags bindingFlags_20 = bindingFlags;
			PropertyInfo[] propertyInfo_4 = array5;
			Type type_10 = type;
			Type[] type_11 = array3;
			bindingFlags = default(BindingFlags);
			Class7 obj30 = (Class7)(object)class42.W(bindingFlags_20, propertyInfo_4, type_10, type_11, (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array4, (CultureInfo)null, array6, out reference2)).e(bindingFlags, null, array3, null));
			Class7 class43 = class2;
			Class7 class44 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class6)obj30.t(class43.e((BindingFlags)class44.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default), null, array3, array4), type, (CultureInfo)(object)Class5.Default);
		}
		_ = (Class2)(object)((Class7)class2.t(obj, null, cultureInfo)).e((BindingFlags)((Class7)null).W(bindingFlags, array5, type, array3, (ParameterModifier[])null), array, array3, array4);
		try
		{
			if ((UIntPtr)class2.j(bindingFlags, null, ref reference, null, null, (string[])(object)class2.e((BindingFlags)class2.t(bindingFlags, (FieldInfo[])((Class7)null).t(obj, type, cultureInfo), Class5.Default, cultureInfo), null, array3, (ParameterModifier[])(object)Class5.Default), out reference2) == (UIntPtr)(nuint)0u)
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_21 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array5;
				Type type_12 = type;
				Type[] type_13 = (Type[])(object)Class5.Default;
				Class7 class45 = class2;
				bindingFlags = default(BindingFlags);
				gClass3 = (GClass2)(object)((Class7)null).W(bindingFlags_21, propertyInfo_5, type_12, type_13, (ParameterModifier[])(object)class45.t(bindingFlags, array2, null, cultureInfo));
			}
		}
		catch
		{
			_ = (Class8)(object)Class5.Default;
		}
		try
		{
			do
			{
				_ = (Class4)(object)Class5.Default;
			}
			while (obj != null);
		}
		finally
		{
			if (checked(num * num) == 0)
			{
				Class8 obj32 = (Class8)(object)Class5.Default;
				Class7 obj33 = (Class7)(object)Class5.Default;
				MethodBase[] methodBase_8 = array;
				Class7 class46 = class2;
				Class7 class47 = class2;
				bindingFlags = default(BindingFlags);
				class27 = (Class8)(object)obj33.j(default(BindingFlags), methodBase_8, ref *(object[]*)((Class7)null).t((BindingFlags)class46.t((BindingFlags)class47.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, null, out reference2), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), (FieldInfo[])null, (object)null, cultureInfo), null, null, array6, out reference2);
				class27 = obj32;
			}
			goto IL_139f;
		}
		IL_1a54:
		num = default(UIntPtr);
		if (checked(num * num) == 0)
		{
			_ = (Class6)(object)Class5.Default;
		}
		else
		{
			struct2 = default(Struct2);
		}
		_ = (Class8)(object)Class5.Default;
		_ = (Class10)(object)Class5.Default;
		Class7 class48 = class2;
		Class7 class49 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)((Class7)null).W((BindingFlags)class48.j(default(BindingFlags), (MethodBase[])(object)class49.W(bindingFlags, array5, type, array3, array4), ref reference, null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array4);
		@struct = (Struct1)Class5.Default;
		try
		{
			qk = null;
		}
		finally
		{
			if (num == 0)
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
			}
			goto IL_1b4f;
		}
		IL_262d:
		try
		{
			checked
			{
				try
				{
					class27 = null;
				}
				finally
				{
					if (num + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null)) == 0)
					{
						class27 = (Class8)(object)Class5.Default;
					}
					goto end_IL_262e;
				}
			}
			end_IL_262e:;
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					_ = (Struct2)((Class7)null).W((BindingFlags)Class5.Default, array5, type, (Type[])(object)Class5.Default, array4);
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Class7 class50 = class2;
					BindingFlags bindingFlags_22 = bindingFlags;
					MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_4 = array4;
					string[] string_4 = array6;
					Class7 obj34 = (Class7)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])((Class7)null).t(obj, type, cultureInfo), (Type[])null, array4);
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)(object)class50.j(bindingFlags_22, methodBase_9, ref *(object[]*)null, parameterModifier_4, null, string_4, out *(object*)obj34.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default))).j(bindingFlags, (MethodBase[])class2.t(obj, type, null), ref *(object[]*)null, array4, cultureInfo, array6, out reference2);
				}
				goto end_IL_2667;
			}
			end_IL_2667:;
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		}
		else if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])class2.t(obj, type, null), (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class28 = class28;
				_ = (Struct1)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				struct2 = struct2;
			}
			catch
			{
				Class7 obj36 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)obj36.j(bindingFlags, array, ref reference, array4, cultureInfo, null, out reference2);
			}
		}
		else
		{
			do
			{
				_ = (Qk7)class2.t(obj, type, null);
			}
			while (obj != null);
		}
		if (num == 0)
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)((Class7)class2.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)class2.j(bindingFlags, null, ref reference, array4, cultureInfo, array6, out *(object*)class2.t(bindingFlags, array2, Class5.Default, null)))).t(obj, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					object object_9 = ((Class7)(object)Class5.Default).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array6, out reference2);
					Class7 class51 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)null).t(object_9, (Type)null, (CultureInfo)(object)class51.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, null));
				}
			}
		}
		else
		{
			class20 = class20;
			_ = (Class8)(object)Class5.Default;
		}
		GClass0 gClass4;
		try
		{
			gClass2 = gClass2;
			_ = (Class7)(object)Class5.Default;
			gClass = gClass;
		}
		finally
		{
			try
			{
				do
				{
					@struct = @struct;
				}
				while (obj != null);
			}
			finally
			{
				gClass4 = gClass4;
				goto IL_2a15;
			}
		}
		IL_3b1a:
		do
		{
			_ = (Class2)(object)Class5.Default;
		}
		while ((object)Class5.Default != null);
		try
		{
			do
			{
				BindingFlags bindingFlags_23 = bindingFlags;
				MethodBase[] methodBase_10 = array;
				Type[] type_14 = (Type[])(object)Class5.Default;
				Class7 class52 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)((Class7)null).e(bindingFlags_23, methodBase_10, type_14, (ParameterModifier[])(object)class52.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null));
			}
			while (obj != null);
		}
		catch
		{
			@class = (Class2)(object)class2.e(default(BindingFlags), array, array3, (ParameterModifier[])(object)Class5.Default);
		}
		Class7 obj39 = (Class7)(object)Class5.Default;
		MethodBase[] methodBase_11 = (MethodBase[])(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj39.e(default(BindingFlags), methodBase_11, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null), array4) == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				try
				{
					Class7 class53 = class2;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass0)(object)class53.t(bindingFlags, array2, obj, null);
					qk = qk;
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					goto IL_3ca2;
				}
			}
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				_ = (Class9)(object)Class5.Default;
			}
			else
			{
				gClass4 = null;
				_ = (Class4)(object)((Class7)class2.t(obj, type, null)).t(bindingFlags, null, null, cultureInfo);
			}
		}
		goto IL_3ca2;
		IL_3146:
		try
		{
			qk = null;
		}
		catch
		{
			class28 = class28;
		}
		_ = (Class0)(object)Class5.Default;
		if (num == 0)
		{
			while (obj != null)
			{
				@struct = @struct;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class17 = class17;
			}
			catch
			{
				Class7 class54 = class2;
				BindingFlags bindingFlags_24 = bindingFlags;
				PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
				Class7 obj41 = (Class7)(object)Class5.Default;
				object object_10 = obj;
				MethodBase[] methodBase_12 = array;
				ref object[] object_11 = ref *(object[]*)Class5.Default;
				Class7 class55 = class2;
				bindingFlags = default(BindingFlags);
				Type type_15 = (Type)obj41.t(object_10, null, (CultureInfo)(object)((Class7)null).j(default(BindingFlags), methodBase_12, ref object_11, (ParameterModifier[])(object)class55.e(bindingFlags, null, array3, array4), cultureInfo, array6, out *(object*)null));
				Type[] type_16 = array3;
				Class7 class56 = class2;
				BindingFlags bindingFlags_25 = bindingFlags;
				MethodBase[] methodBase_13 = (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, cultureInfo);
				Class7 obj42 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class54.W(bindingFlags_24, propertyInfo_6, type_15, type_16, (ParameterModifier[])(object)class56.e(bindingFlags_25, methodBase_13, (Type[])(object)((Class7)(object)obj42.e(bindingFlags, array, (Type[])(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, null)).e(bindingFlags, null, (Type[])(object)Class5.Default, array4), array4)).t(bindingFlags, array2, obj, cultureInfo), array4));
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (checked(num * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					@struct = @struct;
					class20 = class20;
					Class7 class57 = class2;
					Class7 class58 = class2;
					BindingFlags bindingFlags_26 = bindingFlags;
					object object_12 = Class5.Default;
					Class7 class59 = class2;
					BindingFlags bindingFlags_27 = bindingFlags;
					ref object[] object_13 = ref reference;
					CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_14 = array;
					ref object[] object_14 = ref *(object[]*)class2.t((BindingFlags)((Class7)null).j(bindingFlags, array, ref reference, array4, cultureInfo, (string[])null, out reference2), null, Class5.Default, cultureInfo);
					CultureInfo cultureInfo_4 = cultureInfo;
					string[] string_5 = array6;
					Class7 obj44 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_29 = bindingFlags;
					Class7 class60 = class2;
					BindingFlags bindingFlags_30 = (BindingFlags)class2.e(bindingFlags, array, array3, array4);
					Class7 obj45 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					@struct = (Struct1)class57.t(null, (Type)(object)class58.t(bindingFlags_26, null, object_12, (CultureInfo)(object)class59.j(bindingFlags_27, null, ref object_13, null, cultureInfo_3, (string[])(object)((Class7)null).j(bindingFlags_28, methodBase_14, ref object_14, (ParameterModifier[])null, cultureInfo_4, string_5, out *(object*)obj44.e(bindingFlags_29, (MethodBase[])(object)class60.t(bindingFlags_30, null, obj45.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])class2.t(obj, (Type)(object)Class5.Default, cultureInfo), out reference2), (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, null)), out *(object*)null)), (CultureInfo)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, array2, (object)null, cultureInfo)).t(Class5.Default, type, cultureInfo));
				}
				finally
				{
					class20 = null;
					goto IL_35a4;
				}
			}
		}
		else
		{
			while ((object)class2.j(bindingFlags, array, ref reference, array4, null, array6, out *(object*)Class5.Default) != null)
			{
				if (checked(num + num) == 0)
				{
					_ = (GClass2)(object)((Class7)((Class7)null).t(class2.t(obj, type, cultureInfo), type, cultureInfo)).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, null, cultureInfo, null, out reference2);
				}
			}
		}
		goto IL_35a4;
		IL_364b:
		Class7 class61 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)class61.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
		gClass = (GClass1)(object)Class5.Default;
		if (num == 0)
		{
			qk = qk;
		}
		else
		{
			if (num == 0)
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				finally
				{
					_ = Class5.Default;
					goto IL_36ed;
				}
			}
			do
			{
				_ = (Struct2)Class5.Default;
				gClass2 = gClass2;
				@class = (Class2)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
			}
			while (obj != null);
		}
		goto IL_36ed;
		IL_139f:
		class20 = class20;
		_ = (Class6)(object)Class5.Default;
		gClass4 = null;
		gClass4 = gClass4;
		class6 = (Class4)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				do
				{
					_ = (Qk7)(object)((Class7)null).e(bindingFlags, array, array3, array4);
					class28 = class28;
					_ = (GClass0)(object)((Class7)(object)class2.e((BindingFlags)Class5.Default, null, array3, array4)).t(bindingFlags, array2, obj, cultureInfo);
				}
				while ((object)Class5.Default != null);
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				while (true)
				{
					Class7 class62 = class2;
					object object_15 = obj;
					Class7 class63 = class2;
					bindingFlags = default(BindingFlags);
					if (class62.t(object_15, (Type)(object)class63.W(bindingFlags, array5, type, array3, array4), cultureInfo) == null)
					{
						break;
					}
					class8 = class8;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					_ = (Class8)(object)class2.W(bindingFlags, null, type, array3, null);
					_ = (GClass1)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
					goto end_IL_14b2;
				}
				end_IL_14b2:;
			}
			finally
			{
				do
				{
					class4 = null;
				}
				while (obj != null);
				goto end_IL_14b1;
			}
			end_IL_14b1:;
		}
		finally
		{
			_ = (Class4)(object)Class5.Default;
			goto IL_151c;
		}
		IL_36ed:
		try
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					_003CModule_003E = null;
				}
				else
				{
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
				}
			}
			while (obj != null);
		}
		finally
		{
			if (checked(num * unchecked((nuint)(UIntPtr)class2.W(bindingFlags, array5, type, (Type[])class2.t(null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)class2.j((BindingFlags)Class5.Default, null, ref reference, array4, (CultureInfo)(object)class2.e(bindingFlags, null, array3, array4), array6, out *(object*)null), null), obj, cultureInfo), array3, array4), null), (ParameterModifier[])(object)Class5.Default))) == 0)
			{
				do
				{
					Class7 obj47 = (Class7)(object)Class5.Default;
					Type type_17 = (Type)(object)class2.t(default(BindingFlags), array2, obj, cultureInfo);
					Type[] type_18 = array3;
					Class7 class64 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj47.W(default(BindingFlags), null, type_17, type_18, (ParameterModifier[])(object)class64.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out reference2));
				}
				while (obj != null);
			}
			goto IL_389b;
		}
		IL_3ca2:
		_ = (Class9)(object)Class5.Default;
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)(object)class2.t((BindingFlags)class2.W(bindingFlags, null, null, null, null), null, Class5.Default, (CultureInfo)(object)Class5.Default);
				continue;
			}
			try
			{
				_ = (Qk7)(object)Class5.Default;
				Class7 class65 = class2;
				BindingFlags bindingFlags_31 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = array5;
				Type type_19 = type;
				Class7 class66 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class65.W(bindingFlags_31, propertyInfo_7, type_19, (Type[])(object)class66.e(bindingFlags, array, null, array4), array4);
				Class7 class67 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)null).W((BindingFlags)class67.t(bindingFlags, array2, null, (CultureInfo)(object)Class5.Default), (PropertyInfo[])null, (Type)null, array3, array4);
				Class7 class68 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_32 = bindingFlags;
				Class7 class69 = class2;
				bindingFlags = default(BindingFlags);
				class4 = (Class0)(object)class68.W(bindingFlags_32, (PropertyInfo[])(object)class69.W(bindingFlags, null, (Type)(object)Class5.Default, array3, null), (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null);
			}
			finally
			{
				_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref *(object[]*)((Class7)null).e((BindingFlags)class2.t(null, (Type)(object)class2.t((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4), array2, ((Class7)(object)Class5.Default).W(bindingFlags, array5, type, null, array4), null), cultureInfo), array, (Type[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), array4), null, (CultureInfo)(object)Class5.Default, array6, out reference2);
				_ = (GClass0)(object)Class5.Default;
				continue;
			}
		}
		Class7 class70 = class2;
		BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_8 = (PropertyInfo[])((Class7)null).t(obj, (Type)null, (CultureInfo)null);
		Class7 obj48 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)class70.W(bindingFlags_33, propertyInfo_8, (Type)(object)obj48.j(bindingFlags, array, ref reference, null, cultureInfo, null, out reference2), array3, array4);
		_ = Class5.Default;
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj != null);
		class20 = class20;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass2 = gClass2;
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
				class27 = (Class8)(object)Class5.Default;
				class2 = class2;
				_ = Class5.Default;
			}
			finally
			{
				_ = Class5.Default;
				goto IL_3fd2;
			}
		}
		gClass3 = gClass3;
		goto IL_3fd2;
		IL_3a52:
		do
		{
			if ((UIntPtr)((Class7)(object)((Class7)null).t(bindingFlags, array2, (object)null, cultureInfo)).t((BindingFlags)Class5.Default, array2, null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				Class7 class71 = class2;
				Class7 class72 = class2;
				BindingFlags bindingFlags_34 = bindingFlags;
				Class7 obj50 = (Class7)(object)class2.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4), array5, type, (Type[])(object)Class5.Default, array4);
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)obj50.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
				Type type_20 = (Type)(object)class2.W(bindingFlags, null, type, null, array4);
				Class7 class73 = class2;
				BindingFlags bindingFlags_35 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = array5;
				Type type_21 = type;
				Class7 class74 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class2)class71.t(class72.W(bindingFlags_34, propertyInfo_9, type_20, null, (ParameterModifier[])(object)class73.W(bindingFlags_35, propertyInfo_10, type_21, (Type[])(object)class74.W(bindingFlags, array5, null, array3, array4), array4)), (Type)(object)class2.W(bindingFlags, array5, null, array3, array4), null);
			}
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				if (num == 0)
				{
					class27 = class27;
				}
				else
				{
					_ = (Class0)(object)class2.e((BindingFlags)Class5.Default, array, array3, array4);
				}
			}
		}
		finally
		{
			try
			{
				class4 = class4;
				@class = null;
				_ = (GClass3)(object)Class5.Default;
			}
			catch
			{
				class8 = null;
			}
			finally
			{
				while (obj != null)
				{
					class8 = null;
					_ = (Struct2)Class5.Default;
				}
				goto IL_3b1a;
			}
		}
		IL_2da7:
		_ = (Class8)(object)Class5.Default;
		try
		{
			class28 = null;
		}
		catch
		{
		}
		try
		{
			gClass2 = (GClass3)(object)Class5.Default;
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)((Class7)((Class7)(object)Class5.Default).t(obj, null, null)).t(obj, null, (CultureInfo)(object)Class5.Default);
					class27 = (Class8)(object)Class5.Default;
					Class7 obj53 = (Class7)(object)Class5.Default;
					object object_16 = obj;
					Type type_22 = type;
					Class7 obj54 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_36 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array2;
					object object_17 = obj;
					Class7 obj55 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)obj53.t(object_16, type_22, (CultureInfo)(object)obj54.t(bindingFlags_36, fieldInfo_3, object_17, (CultureInfo)(object)obj55.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)Class5.Default)));
				}
				catch
				{
					class27 = (Class8)(object)((Class7)null).W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)class2.W(bindingFlags, null, null, (Type[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null));
					_ = (Class9)(object)Class5.Default;
					class17 = class17;
				}
			}
			goto IL_300d;
		}
		IL_2a15:
		while (obj != null)
		{
			BindingFlags bindingFlags_37 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_11 = array5;
			Type type_23 = type;
			Type[] type_24 = (Type[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)((Class7)null).W(bindingFlags_37, propertyInfo_11, type_23, type_24, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])(object)Class5.Default));
		}
		while (obj != null)
		{
			Class7 class75 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_38 = (BindingFlags)((Class7)(object)class75.W(bindingFlags, array5, type, null, (ParameterModifier[])class2.t(null, type, null))).t(obj, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, null, array3, array4), (PropertyInfo[])(object)((Class7)(object)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, array5, (Type)class2.t(null, null, (CultureInfo)(object)Class5.Default), (Type[])(object)((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])((Class7)(object)class2.W(bindingFlags, array5, type, null, array4)).t(null, null, cultureInfo), array4), array4), array, ref *(object[]*)Class5.Default, array4, cultureInfo, array6, out reference2)).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)((Class7)null).t((object)null, type, cultureInfo)).W((BindingFlags)Class5.Default, array5, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])null, out reference2)), array2, obj, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, array4), cultureInfo, array6, out reference2), type, array3, array4), (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4));
			ref object[] object_18 = ref reference;
			Class7 obj57 = (Class7)(object)class2.W(bindingFlags, array5, (Type)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])class2.t(obj, type, cultureInfo), type, array3, array4), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			BindingFlags bindingFlags_39 = bindingFlags;
			MethodBase[] methodBase_15 = array;
			ref object[] object_19 = ref *(object[]*)Class5.Default;
			Class7 obj58 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			checked
			{
				nuint num3 = unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_38, (MethodBase[])null, ref object_18, (ParameterModifier[])(object)obj57.j(bindingFlags_39, methodBase_15, ref object_19, (ParameterModifier[])(object)obj58.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default, array6, out *(object*)null), (CultureInfo)(object)Class5.Default, array6, out reference2) / (nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr));
				nuint num4 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (num3 - num4 * (num * num) == 0)
				{
					while (obj != null)
					{
						_ = (GClass3)(object)Class5.Default;
					}
				}
			}
		}
		try
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class28 = class28;
				}
			}
		}
		finally
		{
			gClass4 = gClass4;
			goto IL_2da7;
		}
		IL_300d:
		while (obj != null)
		{
			try
			{
				Class7 class76 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_40 = bindingFlags;
				ref object[] object_20 = ref *(object[]*)((Class7)null).t(obj, type, cultureInfo);
				Class7 class77 = class2;
				bindingFlags = default(BindingFlags);
				@struct = (Struct1)class76.j(bindingFlags_40, null, ref object_20, null, (CultureInfo)(object)class77.e(bindingFlags, (MethodBase[])(object)class2.j((BindingFlags)((Class7)null).j(bindingFlags, array, ref *(object[]*)class2.t(obj, type, cultureInfo), array4, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)Class5.Default), null, ref reference, array4, cultureInfo, array6, out *(object*)Class5.Default), array3, (ParameterModifier[])(object)Class5.Default), array6, out reference2);
			}
			finally
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					continue;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					gClass3 = null;
				}
			}
			catch
			{
			}
		}
		try
		{
			while (obj != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 obj60 = (Class7)(object)Class5.Default;
					Class7 class78 = class2;
					BindingFlags bindingFlags_41 = bindingFlags;
					MethodBase[] methodBase_16 = array;
					ref object[] object_21 = ref reference;
					Class7 class79 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj60.W((BindingFlags)class78.j(bindingFlags_41, methodBase_16, ref object_21, (ParameterModifier[])(object)class79.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), (CultureInfo)(object)Class5.Default, array6, out reference2), array5, type, array3, null);
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		finally
		{
			checked
			{
				try
				{
					if (num * unchecked(checked(num - unchecked((nuint)(UIntPtr)Class5.Default)) / num) == 0)
					{
						class20 = class20;
					}
					else
					{
						_ = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, null);
					}
				}
				finally
				{
					while (obj != null)
					{
						gClass4 = gClass4;
					}
					goto IL_3146;
				}
			}
		}
		IL_0b4a:
		if ((UIntPtr)class2.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, array4), array6, out reference2) == (UIntPtr)(nuint)0u)
		{
			Class7 class80 = class2;
			BindingFlags bindingFlags_42 = (BindingFlags)((Class7)null).t(bindingFlags, array2, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
			Class7 obj61 = (Class7)(object)Class5.Default;
			object object_22 = obj;
			Type type_25 = type;
			Class7 class81 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_17 = array;
			ref object[] object_23 = ref *(object[]*)class2.t(bindingFlags, array2, null, cultureInfo);
			ParameterModifier[] parameterModifier_5 = array4;
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)class80.W(bindingFlags_42, null, (Type)obj61.t(object_22, type_25, (CultureInfo)((Class7)(object)class81.j(bindingFlags_43, methodBase_17, ref object_23, parameterModifier_5, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)(object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)class2.t((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)class2.W((BindingFlags)class2.t(Class5.Default, type, cultureInfo), null, type, (Type[])(object)Class5.Default, array4), (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default), (FieldInfo[])(object)Class5.Default, obj, null)).W(bindingFlags, null, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)null).e((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array, (Type[])null, array4), obj, cultureInfo)), obj, null)).j((BindingFlags)class2.j(bindingFlags, array, ref reference, null, cultureInfo, array6, out *(object*)Class5.Default), null, ref *(object[]*)null, array4, (CultureInfo)(object)class2.j(bindingFlags, null, ref *(object[]*)class2.t(bindingFlags, array2, null, (CultureInfo)(object)class2.W((BindingFlags)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4), array5, null, (Type[])(object)Class5.Default, (ParameterModifier[])class2.t(null, null, cultureInfo))), null, null, (string[])(object)Class5.Default, out *(object*)null), null, out reference2), array4), (string[])(object)Class5.Default, out *(object*)null)).t(null, type, null)), array3, array4) / num == 0)
			{
				try
				{
					_ = (Struct2)class2.j(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, array5, type, array3, array4), ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference2);
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					goto IL_0f55;
				}
			}
			try
			{
				struct2 = struct2;
			}
			catch
			{
				class2 = null;
				class6 = null;
				_ = (_003CModule_003E)(object)class2.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
				_ = (Class2)(object)Class5.Default;
			}
			goto IL_0f55;
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		finally
		{
			_ = (Class6)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default);
			_003CModule_003E = _003CModule_003E;
			goto IL_0f55;
		}
		IL_151c:
		class27 = null;
		_ = (GClass1)(object)Class5.Default;
		while (true)
		{
			Class7 class82 = class2;
			bindingFlags = default(BindingFlags);
			if ((object)class82.W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)Class5.Default) == null)
			{
				break;
			}
			while (obj != null)
			{
				while (obj != null)
				{
					class17 = (Class9)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).e(bindingFlags, array, array3, array4);
				}
			}
			catch
			{
				struct2 = struct2;
				_ = (Class9)(object)class2.W(bindingFlags, array5, null, null, array4);
			}
		}
		catch
		{
			try
			{
				try
				{
					class28 = class28;
					_ = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, array, array3, null), (Type[])null, array4);
					Class7 class83 = class2;
					BindingFlags bindingFlags_44 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array2;
					Class7 class84 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_45 = (BindingFlags)((Class7)(object)class83.t(bindingFlags_44, fieldInfo_4, class84.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array6, out reference2), cultureInfo)).t(obj, null, (CultureInfo)(object)Class5.Default);
					Class7 obj64 = (Class7)class2.t(obj, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).t(bindingFlags_45, (FieldInfo[])(object)obj64.t(bindingFlags, array2, obj, cultureInfo), (object)null, cultureInfo);
				}
				finally
				{
					_ = (Struct2)Class5.Default;
					goto end_IL_15e3;
				}
				end_IL_15e3:;
			}
			finally
			{
				_ = (Class7)(object)Class5.Default;
				goto end_IL_15e2;
			}
			end_IL_15e2:;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				class20 = class20;
				_ = (Class6)(object)Class5.Default;
				_ = (Class5)((Class7)(object)Class5.Default).t(obj, null, cultureInfo);
			}
			while (obj != null);
		}
		else
		{
			try
			{
				try
				{
					@class = (Class2)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					struct2 = struct2;
				}
			}
			catch
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		_ = (Class6)(object)class2.t((BindingFlags)class2.j(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, array, array3, array4), ref *(object[]*)null, array4, null, array6, out reference2), array2, obj, cultureInfo);
		while ((object)Class5.Default != null)
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = default(Struct1);
				}
				else
				{
					_ = (GClass0)(object)class2.W(bindingFlags, array5, type, null, null);
				}
			}
		}
		gClass2 = null;
		do
		{
			try
			{
				class20 = null;
			}
			catch
			{
				while (((Class7)null).t(obj, (Type)null, (CultureInfo)null) != null)
				{
					gClass2 = null;
				}
			}
		}
		while ((object)Class5.Default != null);
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				class8 = class8;
				_ = (Class8)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)Class5.Default, array6, out *(object*)null);
			}
			else
			{
				Class7 class85 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class85.t(bindingFlags, array2, null, (CultureInfo)class2.t(null, (Type)(object)class2.j(bindingFlags, array, ref reference, array4, (CultureInfo)(object)class2.W(bindingFlags, null, type, null, array4), null, out *(object*)Class5.Default), null));
			}
		}
		while (obj != null || (object)Class5.Default != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])null, array4) / checked(num + (num * unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				_ = (Class4)(object)((Class7)(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, null)).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)class2.t(default(BindingFlags), null, null, (CultureInfo)(object)Class5.Default), out reference2);
			}
			goto IL_1a54;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class27 = class27;
			}
		}
		finally
		{
			gClass2 = gClass2;
			goto IL_1a54;
		}
	}

	unsafe static void smethod_2()
	{
		Class7 @class = @class;
		Class7 class2 = @class;
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		PropertyInfo[] propertyInfo_ = null;
		Type type_ = (Type)(object)Class5.Default;
		Type[] array = array;
		Type[] type_2 = array;
		ParameterModifier[] parameterModifier_ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class4);
		if ((UIntPtr)class2.W(bindingFlags_, propertyInfo_, type_, type_2, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
					ref object[] object_ = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					cultureInfo = cultureInfo;
					CultureInfo cultureInfo_ = cultureInfo;
					array2 = array2;
					Class2 class3 = (Class2)(object)((Class7)null).j(bindingFlags_2, (MethodBase[])null, ref object_, parameterModifier_2, cultureInfo_, array2, out *(object*)null);
					class3 = class3;
					class4 = (Class10)(object)Class5.Default;
					class4 = class4;
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				goto IL_00db;
			}
		}
		goto IL_00db;
		IL_3885:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		Class7 obj = (Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, array, (ParameterModifier[])(object)@class.W(bindingFlags, propertyInfo_, null, null, parameterModifier_)), cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		ref object object_3;
		Type type_3;
		UIntPtr num;
		Class8 class6;
		if ((UIntPtr)obj.e(bindingFlags, methodBase_, array, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num / (nuint)(UIntPtr)Class5.Default == 0)
			{
				do
				{
					BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
					Class7 class5 = @class;
					BindingFlags bindingFlags_4 = bindingFlags;
					Class7 obj2 = (Class7)(object)@class.t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, null, cultureInfo);
					object object_2 = obj3;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags_3, propertyInfo_, (Type)null, (Type[])null, (ParameterModifier[])((Class7)(object)class5.e(bindingFlags_4, (MethodBase[])obj2.t(object_2, (Type)(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])null, cultureInfo, array2, out object_3), cultureInfo), null, null)).t(null, type_3, cultureInfo));
				}
				while (obj3 != null);
			}
		}
		else
		{
			while (obj3 != null)
			{
				try
				{
					class6 = null;
				}
				finally
				{
					_ = (Struct1)@class.W(bindingFlags, propertyInfo_, null, array, parameterModifier_);
					continue;
				}
			}
		}
		Class7 obj4 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_5 = bindingFlags;
		Class7 class7 = @class;
		ref object[] object_4 = ref reference;
		Class7 class8 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)obj4.W(bindingFlags_5, null, null, (Type[])(object)class7.j(default(BindingFlags), methodBase_, ref object_4, (ParameterModifier[])(object)class8.j(bindingFlags, methodBase_, ref reference, parameterModifier_, null, null, out object_3), cultureInfo, array2, out object_3), null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			try
			{
				@struct = default(Struct2);
				@struct = @struct;
				@class = @class;
				Class7 class9 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class9.j(bindingFlags, methodBase_, ref reference, parameterModifier_, cultureInfo, array2, out object_3);
			}
			catch
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				qk = qk;
				goto end_IL_3aa4;
			}
			end_IL_3aa4:;
		}
		catch
		{
			if (num == 0)
			{
				_ = Class5.Default;
			}
			else
			{
				class4 = class4;
			}
		}
		FieldInfo[] fieldInfo_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		try
		{
			num = default(UIntPtr);
			nuint num2 = num / num / (nuint)(UIntPtr)Class5.Default;
			num = default(UIntPtr);
			if (checked(num2 * num) == 0)
			{
				_ = (GClass0)(object)@class.t(bindingFlags, fieldInfo_, obj3, cultureInfo);
				gClass = (GClass1)(object)Class5.Default;
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				try
				{
					gClass2 = (GClass2)(object)Class5.Default;
				}
				catch
				{
					qk = qk;
				}
			}
		}
		catch
		{
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			_ = (GClass1)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref reference, parameterModifier_, null, array2, out *(object*)null);
		}
		finally
		{
			try
			{
				try
				{
					class10 = null;
				}
				finally
				{
					class4 = class4;
					goto end_IL_3c0b;
				}
				end_IL_3c0b:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num / (nuint)(UIntPtr)Class5.Default == 0)
				{
					gClass3 = (GClass3)(object)Class5.Default;
				}
			}
			goto IL_3c97;
		}
		IL_00db:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		while (true)
		{
			Class7 class11 = @class;
			BindingFlags bindingFlags_6 = bindingFlags;
			fieldInfo_ = null;
			obj3 = obj3;
			if ((object)class11.t(bindingFlags_6, fieldInfo_, obj3, cultureInfo) == null)
			{
				break;
			}
			gClass4 = null;
			gClass4 = null;
		}
		Class7 class12 = @class;
		BindingFlags bindingFlags_7 = bindingFlags;
		methodBase_ = (MethodBase[])(object)Class5.Default;
		Class7 obj10 = (Class7)(object)class12.e(bindingFlags_7, methodBase_, array, null);
		Class7 obj11 = (Class7)(object)Class5.Default;
		object object_5 = obj3;
		type_3 = (Type)(object)Class5.Default;
		num = (nuint)(UIntPtr)obj10.W((BindingFlags)obj11.t(object_5, type_3, cultureInfo), null, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default) / unchecked((nuint)default(UIntPtr));
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					class4 = (Class10)(object)Class5.Default;
				}
			}
			catch
			{
				gClass2 = null;
				gClass2 = gClass2;
			}
		}
		Class7 class13 = @class;
		BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
		Class7 obj13 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_9 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_3, (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (ParameterModifier[])null);
		bindingFlags = default(BindingFlags);
		ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_);
		CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
		object_3 = ref *(object*)Class5.Default;
		_ = (Class7)(object)class13.j(bindingFlags_8, methodBase_, ref *(object[]*)obj13.j(bindingFlags_9, null, ref *(object[]*)null, parameterModifier_3, cultureInfo_2, null, out object_3), parameterModifier_, cultureInfo, array2, out object_3);
		if ((nuint)(UIntPtr)Class5.Default / num == 0)
		{
			Class7 class14 = @class;
			BindingFlags bindingFlags_10 = bindingFlags;
			Class7 class15 = @class;
			BindingFlags bindingFlags_11 = bindingFlags;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo)).t(obj3, (Type)@class.t(Class5.Default, type_3, (CultureInfo)(object)Class5.Default), cultureInfo);
			object object_6 = ((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null)).t(default(BindingFlags), fieldInfo_, null, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class14.W(bindingFlags_10, propertyInfo_, type_3, (Type[])(object)class15.t(bindingFlags_11, fieldInfo_2, object_6, (CultureInfo)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj3, (CultureInfo)null)), null) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_);
				}
				finally
				{
					gClass = null;
					gClass = gClass;
					goto IL_043e;
				}
			}
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					Class7 class16 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class16.t(bindingFlags, fieldInfo_, obj3, cultureInfo);
				}
				else
				{
					_ = (GClass0)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
				}
			}
		}
		goto IL_043e;
		IL_3c97:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class17);
		while (obj3 != null)
		{
			try
			{
				try
				{
					qk = null;
				}
				finally
				{
					@class = (Class7)(object)@class.t(bindingFlags, fieldInfo_, obj3, cultureInfo);
					_ = (Qk7)(object)Class5.Default;
					class10 = null;
					goto end_IL_3c4e;
				}
				end_IL_3c4e:;
			}
			catch
			{
				class17 = class17;
			}
		}
		do
		{
			@struct = @struct;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class18);
		while ((object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null) != null)
		{
			_ = (Struct2)Class5.Default;
			class18 = class18;
			_ = (Class10)(object)Class5.Default;
		}
		while (obj3 != null)
		{
			@class = null;
		}
		class10 = class10;
		if (num == 0)
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class17 = class17;
				}
			}
			while (obj3 != null);
			goto IL_3dd1;
		}
		try
		{
			if (num == 0)
			{
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_3), type_3, array, (ParameterModifier[])null);
				gClass4 = gClass4;
				class18 = null;
			}
			else
			{
				class4 = class4;
			}
		}
		finally
		{
			Class7 class19 = @class;
			bindingFlags = default(BindingFlags);
			gClass = (GClass1)(object)class19.W(bindingFlags, propertyInfo_, type_3, null, null);
			goto IL_3dd1;
		}
		IL_0d7c:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					class6 = class6;
				}
			}
			else
			{
				while (true)
				{
					Class7 class20 = @class;
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
					Type[] type_4 = array;
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_12 = bindingFlags;
					Type[] type_5 = (Type[])(object)Class5.Default;
					BindingFlags bindingFlags_13 = bindingFlags;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)class20.W(default(BindingFlags), propertyInfo_2, null, type_4, (ParameterModifier[])(object)class21.W(bindingFlags_12, propertyInfo_, type_3, type_5, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_13, methodBase_2, ref *(object[]*)null, parameterModifier_, (CultureInfo)((Class7)null).t((object)null, type_3, (CultureInfo)(object)class22.j(bindingFlags, methodBase_, ref reference, null, null, array2, out object_3)), array2, out *(object*)null))) == null)
					{
						break;
					}
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		Class7 class23;
		Class7 class24;
		BindingFlags bindingFlags_14;
		MethodBase[] methodBase_3;
		string[] string_;
		do
		{
			_ = (GClass3)(object)Class5.Default;
			class23 = @class;
			class24 = @class;
			bindingFlags_14 = bindingFlags;
			methodBase_3 = (MethodBase[])(object)Class5.Default;
			string_ = array2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class23.j((BindingFlags)class24.j(bindingFlags_14, methodBase_3, ref *(object[]*)null, parameterModifier_, null, string_, out *(object*)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, (CultureInfo)null)), (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])null), array, parameterModifier_), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, @class.t(obj3, type_3, null), (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo), (Type)(object)Class5.Default, (Type[])null, parameterModifier_)), out object_3) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class26);
		do
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					class26 = (Class4)(object)class25.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out object_3);
					class26 = null;
					continue;
				}
			}
		}
		while (obj3 != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			nuint num3 = num;
			Class7 class27 = @class;
			bindingFlags = default(BindingFlags);
			if (checked(num3 * unchecked((nuint)(UIntPtr)class27.j(bindingFlags, methodBase_, ref reference, parameterModifier_, cultureInfo, (string[])@class.t(obj3, type_3, (CultureInfo)(object)Class5.Default), out *(object*)Class5.Default))) == 0)
			{
				do
				{
					class4 = class4;
				}
				while (obj3 != null);
			}
			else
			{
				while (true)
				{
					Class7 obj15 = (Class7)(object)Class5.Default;
					object object_7 = obj3;
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj16 = (Class7)obj15.t(object_7, (Type)(object)class28.t(bindingFlags, fieldInfo_, null, cultureInfo), (CultureInfo)(object)Class5.Default);
					object object_8 = @class.W(bindingFlags, propertyInfo_, type_3, (Type[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj3, cultureInfo), null);
					BindingFlags bindingFlags_15 = bindingFlags;
					ref object[] object_9 = ref reference;
					bindingFlags = default(BindingFlags);
					if (obj16.t(object_8, type_3, (CultureInfo)(object)((Class7)null).j(bindingFlags_15, methodBase_, ref object_9, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, propertyInfo_, type_3, array, (ParameterModifier[])null), (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null)) != null)
					{
						Class7 class29 = @class;
						Type[] type_6 = array;
						Class7 class30 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class9)(object)class29.W(default(BindingFlags), propertyInfo_, type_3, type_6, (ParameterModifier[])(object)class30.j(bindingFlags, methodBase_, ref reference, null, cultureInfo, (string[])(object)((Class7)(object)@class.t(bindingFlags, fieldInfo_, obj3, cultureInfo)).t(default(BindingFlags), null, null, null), out object_3));
						continue;
					}
					break;
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				if ((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_3, (Type[])(object)Class5.Default, parameterModifier_) / checked((unchecked((nuint)(UIntPtr)Class5.Default) - num) * unchecked((nuint)(UIntPtr)@class.W(bindingFlags, propertyInfo_, type_3, array, (ParameterModifier[])(object)Class5.Default))) / (nuint)(UIntPtr)Class5.Default == 0)
				{
					_ = (Class6)(object)Class5.Default;
					gClass2 = gClass2;
					Class5 obj17 = Class5.Default;
					class10 = class10;
					class10 = obj17;
					_ = Class5.Default;
				}
			}
		}
		gClass2 = gClass2;
		do
		{
			UIntPtr num4 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num4) + num - num != 0)
				{
					class6 = class6;
				}
				else
				{
					class10 = class10;
				}
			}
		}
		while (obj3 != null);
		if (num == 0)
		{
			while (true)
			{
				Class7 obj18 = (Class7)(object)@class.t(bindingFlags, fieldInfo_, obj3, cultureInfo);
				BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
				Class7 obj19 = (Class7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array2, out *(object*)null);
				bindingFlags = default(BindingFlags);
				if ((object)obj18.e(bindingFlags_16, (MethodBase[])(object)obj19.t(bindingFlags, fieldInfo_, obj3, null), null, (ParameterModifier[])(object)Class5.Default) == null)
				{
					break;
				}
				while ((object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, array, null)).W(bindingFlags, propertyInfo_, (Type)(object)@class.e((BindingFlags)Class5.Default, null, null, parameterModifier_), (Type[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out *(object*)null), parameterModifier_) != null)
				{
					qk = (Qk7)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, null);
				}
			}
		}
		num = default(UIntPtr);
		if (checked(num - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			_ = (Class8)(object)((Class7)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo)).e(bindingFlags, null, array, parameterModifier_);
		}
		else if (num == 0)
		{
			BindingFlags bindingFlags_17;
			Class7 class31;
			do
			{
				class17 = class17;
				@class = null;
				bindingFlags_17 = (BindingFlags)@class.j((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, null, ref reference, parameterModifier_, null, array2, out object_3), parameterModifier_), null, ref reference, null, null, (string[])@class.t(Class5.Default, (Type)(object)((Class7)null).W(default(BindingFlags), propertyInfo_, (Type)null, array, parameterModifier_), cultureInfo), out *(object*)Class5.Default);
				class31 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).W(bindingFlags_17, (PropertyInfo[])(object)((Class7)(object)class31.W(bindingFlags, propertyInfo_, type_3, array, parameterModifier_)).j(bindingFlags, null, ref reference, null, cultureInfo, array2, out *(object*)Class5.Default), type_3, array, (ParameterModifier[])null) != null);
		}
		_ = (Qk7)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null);
		_ = (GClass3)(object)Class5.Default;
		while (obj3 != null)
		{
			_ = (Struct1)@class.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)((Class7)@class.t(obj3, null, cultureInfo)).t(bindingFlags, fieldInfo_, obj3, null), (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, parameterModifier_, cultureInfo, null, out *(object*)null), (string[])(object)Class5.Default, out *(object*)null);
		}
		gClass3 = gClass3;
		try
		{
			class18 = class18;
			Class7 class32 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)class32.t(bindingFlags, null, null, cultureInfo);
			_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_3, array, (ParameterModifier[])(object)Class5.Default);
			@class = @class;
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, array2, out *(object*)null);
			}
		}
		try
		{
			_ = (GClass2)(object)Class5.Default;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass2)((Class7)@class.t(null, type_3, cultureInfo)).t(obj3, null, cultureInfo);
				}
				catch
				{
					@struct = default(Struct2);
				}
			}
			else
			{
				try
				{
					class6 = null;
					class6 = class6;
					@class = null;
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		do
		{
			num = default(UIntPtr);
			checked
			{
				nuint num5 = unchecked(num / num) - unchecked((nuint)(UIntPtr)((Class7)(object)@class.t(bindingFlags, fieldInfo_, obj3, null)).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_3, (Type[])null, parameterModifier_), (CultureInfo)(object)@class.t(bindingFlags, null, obj3, null), (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, (CultureInfo)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo)), ref reference, parameterModifier_, cultureInfo, array2, out *(object*)null), out *(object*)null));
				nuint num6 = num * num;
				UIntPtr num7 = unchecked((UIntPtr)Class5.Default);
				num = default(UIntPtr);
				nuint num8 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)num7 / num);
				Class7 class33 = @class;
				bindingFlags = default(BindingFlags);
				nuint num9 = unchecked(checked((num8 + unchecked((nuint)(UIntPtr)class33.W(bindingFlags, propertyInfo_, null, null, (ParameterModifier[])(object)Class5.Default))) * unchecked((nuint)(UIntPtr)Class5.Default) + num) / (nuint)(UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)null, cultureInfo)) * unchecked((nuint)default(UIntPtr));
				UIntPtr num10 = unchecked((UIntPtr)@class.e(bindingFlags, methodBase_, null, null));
				num = default(UIntPtr);
				nuint num11 = unchecked(num6 / checked(num9 - unchecked((nuint)num10) * num)) * num;
				num = default(UIntPtr);
				if (num5 * (num11 - num) == 0)
				{
				}
			}
		}
		while ((object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array2, out object_3) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (CultureInfo)null);
				}
				finally
				{
					qk = (Qk7)(object)Class5.Default;
					@struct = @struct;
					_ = (Class2)(object)@class.t(bindingFlags, null, obj3, cultureInfo);
					_ = (Qk7)(object)Class5.Default;
					goto end_IL_19ad;
				}
				end_IL_19ad:;
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				gClass = null;
				goto end_IL_19ac;
			}
			end_IL_19ac:;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					class4 = class4;
				}
				else
				{
					struct2 = (Struct1)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, @class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.W(bindingFlags, propertyInfo_, type_3, (Type[])(object)Class5.Default, parameterModifier_), null, cultureInfo), cultureInfo)).W(bindingFlags, propertyInfo_, (Type)((Class7)null).t(obj3, type_3, cultureInfo), null, null), (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), (Type[])(object)Class5.Default, parameterModifier_);
				}
			}
			catch
			{
				if (checked(num * unchecked((nuint)default(UIntPtr))) == 0)
				{
					Class7 class34 = @class;
					Class7 obj24 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_18 = (BindingFlags)obj24.t(bindingFlags, null, obj3, null);
					ref object[] object_10 = ref *(object[]*)@class.t(obj3, null, cultureInfo);
					CultureInfo cultureInfo_3 = cultureInfo;
					string[] string_2 = array2;
					Class7 obj25 = (Class7)@class.t(obj3, null, cultureInfo);
					BindingFlags bindingFlags_19 = (BindingFlags)@class.W((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, null, cultureInfo, array2, out object_3), null, null, array, parameterModifier_);
					Type type_7 = (Type)(object)Class5.Default;
					Class7 class35 = @class;
					Class7 class36 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class34.j(bindingFlags_18, methodBase_, ref object_10, parameterModifier_, cultureInfo_3, string_2, out *(object*)obj25.W(bindingFlags_19, null, type_7, null, (ParameterModifier[])class35.t(null, (Type)(object)((Class7)(object)((Class7)null).j((BindingFlags)class36.t(bindingFlags, fieldInfo_, Class5.Default, null), (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, null, null), ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])null, out *(object*)Class5.Default)).W((BindingFlags)Class5.Default, propertyInfo_, null, (Type[])(object)((Class7)(object)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)@class.W(bindingFlags, null, type_3, null, parameterModifier_))).t((BindingFlags)Class5.Default, fieldInfo_, null, null), (ParameterModifier[])(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo), (Type[])null, parameterModifier_), (Type)(object)Class5.Default, array, parameterModifier_)).t((BindingFlags)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj3, null), fieldInfo_, obj3, null)), cultureInfo)));
				}
			}
			goto IL_1da2;
		}
		IL_3244:
		_ = (Class9)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class37);
		try
		{
			while (obj3 != null)
			{
			}
		}
		catch
		{
			class37 = class37;
		}
		class4 = class4;
		_ = (Qk7)(object)Class5.Default;
		gClass2 = gClass2;
		gClass3 = gClass3;
		gClass3 = null;
		gClass3 = null;
		while (true)
		{
			if (obj3 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class2)(object)@class.W(bindingFlags, propertyInfo_, type_3, array, parameterModifier_);
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		gClass4 = (GClass0)(object)Class5.Default;
		try
		{
			do
			{
				_ = (GClass2)(object)Class5.Default;
			}
			while (obj3 != null || obj3 != null);
		}
		finally
		{
			_ = (Class7)(object)Class5.Default;
			goto IL_3339;
		}
		IL_3339:
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				_ = (GClass2)((Class7)null).t(obj3, type_3, cultureInfo);
			}
		}
		@class = null;
		if (num == 0)
		{
			try
			{
				class4 = class4;
			}
			finally
			{
				goto IL_3356;
			}
		}
		goto IL_3356;
		IL_406b:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				Class7 class38 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)class38.j(bindingFlags, methodBase_, ref reference, parameterModifier_, cultureInfo, (string[])((Class7)(object)Class5.Default).t(null, null, cultureInfo), out object_3);
				_003CModule_003E = null;
			}
		}
		catch
		{
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class39.j(bindingFlags, methodBase_, ref reference, parameterModifier_, null, array2, out object_3);
		}
		class18 = null;
		_ = (Class6)(object)@class.e((BindingFlags)@class.t(obj3, null, null), methodBase_, (Type[])(object)Class5.Default, null);
		gClass = gClass;
		_ = (Qk7)(object)Class5.Default;
		gClass = gClass;
		if (num == 0)
		{
			_ = (Struct1)@class.t(bindingFlags, fieldInfo_, null, null);
			return;
		}
		while ((object)Class5.Default != null)
		{
			do
			{
				_ = (Class4)(object)Class5.Default;
			}
			while (obj3 != null);
		}
		return;
		IL_1f30:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (Class9)(object)Class5.Default;
		}
		else
		{
			Class7 obj29 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)((Class7)(object)obj29.t(bindingFlags, null, null, cultureInfo)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
		}
		try
		{
			try
			{
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Class10)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), null, array, null)).t(null, null, cultureInfo);
				class37 = class37;
			}
			while ((object)Class5.Default != null);
		}
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_);
			}
		}
		while (obj3 != null || obj3 != null);
		while (obj3 != null)
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					class10 = (Class5)(object)class40.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_3, array, null);
					qk = (Qk7)@class.t(@class.t(obj3, type_3, cultureInfo), null, cultureInfo);
				}
				else
				{
					_ = (Class4)@class.t(obj3, null, cultureInfo);
				}
			}
			while (obj3 != null);
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		finally
		{
			if ((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr)) == 0)
			{
				while (true)
				{
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).t((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, obj3, cultureInfo), fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default) != null)
					{
						_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_3, (Type[])(object)Class5.Default, parameterModifier_), (string[])(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array2, out object_3))).W(bindingFlags, null, null, array, null), cultureInfo, (string[])(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, cultureInfo), array, (ParameterModifier[])null), array, parameterModifier_), out object_3), out *(object*)@class.t(bindingFlags, fieldInfo_, obj3, null));
						continue;
					}
					break;
				}
			}
			goto IL_22ce;
		}
		IL_22ce:
		_ = (Class4)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array2, out object_3);
			_ = (GClass0)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_3, (Type[])(object)Class5.Default, (ParameterModifier[])null);
			_ = (Class10)((Class7)null).t(obj3, (Type)(object)Class5.Default, (CultureInfo)null);
			class4 = null;
		}
		else if (num / (nuint)(UIntPtr)Class5.Default == 0)
		{
			class10 = Class5.Default;
		}
		try
		{
			while (obj3 != null)
			{
				_ = (GClass2)(object)Class5.Default;
				class6 = null;
				_ = (GClass3)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(null, (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, methodBase_, array, null), null, parameterModifier_), cultureInfo), obj3, (CultureInfo)(object)Class5.Default)).e(bindingFlags, methodBase_, array, parameterModifier_);
				Class7 obj32 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj32.j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).e((BindingFlags)@class.t(obj3, null, (CultureInfo)(object)Class5.Default), methodBase_, (Type[])null, parameterModifier_), null, (CultureInfo)(object)Class5.Default, array2, out *(object*)null);
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) * num + num) == 0)
			{
				try
				{
					Class7 obj33 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_20 = bindingFlags;
					Class7 class41 = @class;
					BindingFlags bindingFlags_21 = bindingFlags;
					MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
					ref object[] object_11 = ref reference;
					CultureInfo cultureInfo_4 = (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_);
					Class7 class42 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj33.W(bindingFlags_20, propertyInfo_, (Type)(object)class41.j(bindingFlags_21, methodBase_4, ref object_11, parameterModifier_, cultureInfo_4, null, out *(object*)((Class7)(object)class42.j(bindingFlags, methodBase_, ref reference, null, null, (string[])(object)@class.j((BindingFlags)@class.W(bindingFlags, null, type_3, array, null), methodBase_, ref reference, (ParameterModifier[])@class.t(((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, (ParameterModifier[])(object)@class.j((BindingFlags)@class.t((BindingFlags)Class5.Default, fieldInfo_, null, cultureInfo), methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out object_3)), methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t(obj3, (Type)null, cultureInfo), out object_3), type_3, (CultureInfo)(object)Class5.Default), cultureInfo, array2, out *(object*)null), out object_3)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)(object)Class5.Default)), array, parameterModifier_);
					_ = (Class7)(object)Class5.Default;
					gClass = (GClass1)(object)Class5.Default;
					class26 = null;
				}
				finally
				{
					class10 = null;
					goto end_IL_249a;
				}
			}
			end_IL_249a:;
		}
		_ = (Qk7)(object)Class5.Default;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					Class7 class43 = @class;
					Class7 class44 = @class;
					Class7 class45 = @class;
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 obj35 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_23 = bindingFlags;
					ref object[] object_12 = ref reference;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class43.e((BindingFlags)class44.j((BindingFlags)class45.j(bindingFlags_22, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)obj35.j(bindingFlags_23, null, ref object_12, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)@class.t(null, (Type)@class.t(null, (Type)(object)@class.t((BindingFlags)Class5.Default, null, obj3, cultureInfo), cultureInfo), cultureInfo), array2, out object_3), cultureInfo, null, out object_3), null, array2, out object_3), null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out object_3), methodBase_, null, null);
				}
				while (obj3 != null);
			}
		}
		catch
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (Class6)((Class7)null).t((object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), (Type)null, (CultureInfo)null);
				}
				else if ((object)@class.t(bindingFlags, fieldInfo_, obj3, null) == null)
				{
					break;
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gClass = gClass;
					@struct = default(Struct2);
					@struct = @struct;
					class6 = class6;
				}
			}
			else
			{
				UIntPtr num12 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num12) * num == 0)
					{
						_ = (Class7)(object)Class5.Default;
						Class2 class3 = null;
					}
				}
			}
		}
		catch
		{
			Class7 class46 = @class;
			object object_13 = obj3;
			Class7 class47 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class46.t(default(BindingFlags), fieldInfo_, object_13, (CultureInfo)(object)class47.t(bindingFlags, null, null, cultureInfo));
		}
		try
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
					gClass2 = null;
					_ = (Struct2)((Class7)null).t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(obj3, type_3, cultureInfo), obj3, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default));
				}
				else
				{
					class17 = class17;
					class37 = class37;
				}
			}
			while (obj3 != null);
		}
		catch
		{
			while (obj3 != null)
			{
				while (true)
				{
					BindingFlags bindingFlags_24 = bindingFlags;
					Class7 obj38 = (Class7)(object)Class5.Default;
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_5 = (MethodBase[])(object)class48.e(bindingFlags, null, null, parameterModifier_);
					Type[] type_8 = (Type[])(object)@class.e((BindingFlags)((Class7)null).t((object)null, type_3, (CultureInfo)(object)@class.j(bindingFlags, null, ref reference, parameterModifier_, null, array2, out object_3)), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).t((BindingFlags)((Class7)null).j(bindingFlags_24, (MethodBase[])null, ref *(object[]*)obj38.e(default(BindingFlags), methodBase_5, type_8, (ParameterModifier[])(object)class49.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_3, array, parameterModifier_)), parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])null, out object_3), fieldInfo_, obj3, cultureInfo) == null)
					{
						break;
					}
					struct2 = struct2;
				}
			}
		}
		_ = (Class9)(object)Class5.Default;
		if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default == 0)
		{
			try
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_);
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)(object)class50.W(bindingFlags, propertyInfo_, type_3, array, null)).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, @class.t(obj3, null, null), (CultureInfo)(object)Class5.Default), type_3, array, parameterModifier_);
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_2ac3;
				}
				end_IL_2ac3:;
			}
			catch
			{
				_ = (Struct1)Class5.Default;
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class51;
			BindingFlags bindingFlags_26;
			do
			{
				_ = (GClass2)((Class7)(object)@class.t(bindingFlags, null, obj3, cultureInfo)).t(Class5.Default, null, cultureInfo);
				class51 = @class;
				Class7 obj41 = (Class7)(object)Class5.Default;
				Class7 class52 = @class;
				BindingFlags bindingFlags_25 = (BindingFlags)@class.e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_);
				object object_14 = obj3;
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				bindingFlags_26 = (BindingFlags)((Class7)(object)obj41.j((BindingFlags)((Class7)(object)class52.W(bindingFlags_25, null, (Type)((Class7)null).t(object_14, (Type)(object)class53.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, parameterModifier_)).t(bindingFlags, fieldInfo_, @class.t(((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj3, cultureInfo), type_3, cultureInfo), (CultureInfo)(object)Class5.Default)).e(default(BindingFlags), methodBase_, array, parameterModifier_)), array, parameterModifier_)).t(obj3, null, (CultureInfo)(object)Class5.Default), methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, array2, out *(object*)((Class7)null).j(default(BindingFlags), methodBase_, ref reference, (ParameterModifier[])(object)@class.j(default(BindingFlags), methodBase_, ref reference, null, null, null, out object_3), (CultureInfo)null, (string[])null, out *(object*)null))).e((BindingFlags)Class5.Default, methodBase_, array, null);
				bindingFlags = default(BindingFlags);
			}
			while ((object)class51.e(bindingFlags_26, (MethodBase[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj3, cultureInfo), array, null) != null);
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Class2)(object)((Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_3, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_3, array, parameterModifier_)).e((BindingFlags)@class.j(bindingFlags, methodBase_, ref reference, null, null, (string[])(object)Class5.Default, out *(object*)@class.t(((Class7)null).t(obj3, (Type)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_), cultureInfo), null, null)), null, array, null), (object)null, cultureInfo));
			}
		}
		while (obj3 != null)
		{
			UIntPtr num13 = (UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])((Class7)null).t(obj3, (Type)null, cultureInfo), parameterModifier_), null, (ParameterModifier[])(object)Class5.Default), array, parameterModifier_));
			nuint num14 = num / unchecked((nuint)default(UIntPtr));
			Class7 class54 = @class;
			bindingFlags = default(BindingFlags);
			UIntPtr num15 = (UIntPtr)class54.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)((Class7)(object)Class5.Default).t(obj3, null, null));
			UIntPtr num16 = (UIntPtr)@class.t(obj3, type_3, cultureInfo);
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num13) - unchecked(num14 / ((nuint)num15 / checked(unchecked((nuint)num16) * num - unchecked((nuint)(UIntPtr)@class.t(obj3, type_3, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, ((Class7)null).t(obj3, (Type)null, cultureInfo), null)))))) == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						class26 = class26;
					}
					else
					{
						class37 = null;
					}
				}
			}
		}
		while (obj3 != null)
		{
			try
			{
				while (obj3 != null)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).t(obj3, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, null), cultureInfo), parameterModifier_, cultureInfo, array2, out object_3);
				}
			}
			finally
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					@class = @class;
				}
				continue;
			}
		}
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class55.t(bindingFlags, null, Class5.Default, null);
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class57 = @class;
					BindingFlags bindingFlags_28 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class56.j(bindingFlags_27, (MethodBase[])(object)class57.t(bindingFlags_28, fieldInfo_, ((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])null), null), ref reference, parameterModifier_, cultureInfo, array2, out object_3);
				}
			}
			catch
			{
				class18 = (Class0)(object)Class5.Default;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				do
				{
					gClass3 = (GClass3)(object)Class5.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				try
				{
					class18 = class18;
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
				goto IL_3244;
			}
		}
		goto IL_3244;
		IL_0a72:
		_ = Class5.Default;
		while (true)
		{
			if (obj3 != null)
			{
				gClass = null;
			}
			else if ((object)@class.e(bindingFlags, methodBase_, null, parameterModifier_) == null)
			{
				break;
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)@class.t(obj3, type_3, cultureInfo), array, parameterModifier_), (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_))) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)@class.W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, parameterModifier_);
			}
		}
		else
		{
			try
			{
				try
				{
					gClass = gClass;
				}
				catch
				{
					gClass3 = null;
				}
			}
			catch
			{
				try
				{
					@struct = default(Struct2);
					@struct = @struct;
					@struct = @struct;
					_ = (GClass2)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					gClass = null;
					goto end_IL_0b8f;
				}
				end_IL_0b8f:;
			}
		}
		try
		{
			@struct = @struct;
		}
		catch
		{
			class17 = (Class9)(object)Class5.Default;
		}
		try
		{
			Class7 class58 = @class;
			BindingFlags bindingFlags_29 = bindingFlags;
			Class7 class59 = @class;
			bindingFlags = default(BindingFlags);
			Struct1 obj48 = (Struct1)class58.W(bindingFlags_29, (PropertyInfo[])(object)class59.e(bindingFlags, methodBase_, array, null), type_3, array, parameterModifier_);
			struct2 = (Struct1)Class5.Default;
			struct2 = obj48;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class37 = class37;
					class37 = class37;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Class10)(object)Class5.Default;
					}
					else
					{
						gClass = (GClass1)(object)((Class7)(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_)).e(bindingFlags, methodBase_, null, null);
					}
				}
			}
			else
			{
				Class7 class60 = @class;
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class60.e((BindingFlags)class61.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), methodBase_, array, null);
			}
		}
		finally
		{
			try
			{
				try
				{
					@class = null;
				}
				finally
				{
					class18 = class18;
					_ = (Class10)(object)Class5.Default;
					goto end_IL_0d43;
				}
				end_IL_0d43:;
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
				goto IL_0d7c;
			}
		}
		IL_043e:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			gClass4 = gClass4;
		}
		Class7 obj51 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])null, out *(object*)null);
		object object_15 = obj3;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)obj51.t(object_15, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_3, array, parameterModifier_), cultureInfo);
		_ = (Class0)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj3 != null)
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_30 = bindingFlags;
					reference = ref reference;
					_ = (GClass3)(object)((Class7)(object)((Class7)null).j(bindingFlags_30, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out object_3)).W((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, (CultureInfo)((Class7)null).t((object)null, type_3, (CultureInfo)null)), propertyInfo_, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)@class.e(bindingFlags, methodBase_, array, parameterModifier_), fieldInfo_, Class5.Default, (CultureInfo)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, array, null)).e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default)), ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, array2, out object_3), array, parameterModifier_);
					_ = (Class9)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_);
					_ = (GClass1)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj3, cultureInfo);
				}
			}
			catch
			{
				try
				{
					class18 = null;
					class18 = class18;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		while ((object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, null, obj3, cultureInfo) != null)
		{
			_ = (Struct2)Class5.Default;
		}
		qk = qk;
		qk = qk;
		_ = (Class7)(object)Class5.Default;
		_ = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type_3, null), null, parameterModifier_);
		do
		{
			UIntPtr num17 = num;
			Class7 class62 = @class;
			Class7 class63 = @class;
			BindingFlags bindingFlags_31 = bindingFlags;
			Class7 class64 = @class;
			BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
			ref object[] object_16 = ref reference;
			Class7 obj54 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_33 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
			Type type_9 = (Type)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_3), obj3, cultureInfo), (CultureInfo)null);
			bindingFlags = default(BindingFlags);
			if ((nuint)num17 / checked(unchecked((nuint)(UIntPtr)class62.t(null, type_3, (CultureInfo)(object)class63.j(bindingFlags_31, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)class64.j(bindingFlags_32, null, ref object_16, parameterModifier_, (CultureInfo)(object)obj54.W(bindingFlags_33, propertyInfo_3, type_9, (Type[])(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array2, out object_3), null), array2, out *(object*)Class5.Default), cultureInfo, array2, out object_3))) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				do
				{
					_ = (Class10)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		while ((object)Class5.Default != null);
		_ = (Class8)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		_ = (Class0)(object)Class5.Default;
		class6 = null;
		class6 = class6;
		qk = qk;
		_ = (GClass3)(object)Class5.Default;
		_ = (GClass1)(object)Class5.Default;
		while (obj3 != null)
		{
			while ((object)Class5.Default != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)@class.t(null, type_3, null);
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					class6 = class6;
				}
			}
		}
		try
		{
			Class9 obj55 = (Class9)(object)Class5.Default;
			class17 = (Class9)(object)Class5.Default;
			class17 = obj55;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					class17 = class17;
					_003CModule_003E = _003CModule_003E;
					_ = (Class7)(object)Class5.Default;
					Class7 class65 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
					string[] string_3 = (string[])(object)Class5.Default;
					Class7 class66 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					ref object[] object_17 = ref reference;
					CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					@class = (Class7)((Class7)null).t((object)class65.j(bindingFlags_34, null, ref *(object[]*)null, parameterModifier_4, null, string_3, out *(object*)class66.j(bindingFlags_35, methodBase_6, ref object_17, parameterModifier_, cultureInfo_5, (string[])(object)class67.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default), out object_3)), (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj3, null), cultureInfo);
				}
				while ((object)@class.W(bindingFlags, propertyInfo_, type_3, array, parameterModifier_) != null);
			}
			goto IL_0a72;
		}
		IL_3f5e:
		_ = (Qk7)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)null);
		class18 = (Class0)(object)Class5.Default;
		struct2 = struct2;
		if ((UIntPtr)((Class7)(object)Class5.Default).t(obj3, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			_ = Class5.Default;
		}
		Class7 class68 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class68.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out object_3) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class4 = null;
			}
			finally
			{
				Class7 class69 = @class;
				Class7 class70 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class69.e(default(BindingFlags), null, null, (ParameterModifier[])(object)class70.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_));
				goto IL_406b;
			}
		}
		goto IL_406b;
		IL_1da2:
		do
		{
			class10 = null;
		}
		while ((object)Class5.Default != null);
		if ((UIntPtr)@class.t(Class5.Default, type_3, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			gClass3 = gClass3;
		}
		Class7 class71 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)class71.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
		_ = (GClass2)(object)@class.W(bindingFlags, propertyInfo_, type_3, array, parameterModifier_);
		try
		{
			if ((UIntPtr)@class.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out object_3) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)@class.e(bindingFlags, methodBase_, null, null);
			}
		}
		finally
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				_ = (Class4)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
			}
			finally
			{
				try
				{
					_ = (GClass0)(object)@class.t(default(BindingFlags), fieldInfo_, obj3, cultureInfo);
				}
				finally
				{
					Class7 class72 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)(object)class72.e(bindingFlags, methodBase_, array, null)).t(obj3, null, (CultureInfo)(object)Class5.Default);
					goto IL_1f30;
				}
			}
		}
		IL_3dd1:
		try
		{
			try
			{
				Class7 obj57 = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, parameterModifier_, cultureInfo, array2, out *(object*)null)).W(bindingFlags, propertyInfo_, type_3, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.W(bindingFlags, propertyInfo_, (Type)((Class7)(object)Class5.Default).t(Class5.Default, type_3, cultureInfo), array, parameterModifier_), null, cultureInfo, (string[])(object)Class5.Default, out object_3), array2, out object_3));
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)obj57.W(bindingFlags, null, type_3, array, parameterModifier_);
			}
			finally
			{
				class18 = class18;
				goto end_IL_3dd3;
			}
			end_IL_3dd3:;
		}
		catch
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				@struct = default(Struct2);
			}
		}
		finally
		{
			while (obj3 != null)
			{
				Class7 class73;
				do
				{
					_ = (GClass3)(object)Class5.Default;
					class73 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class73.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out *(object*)null) != null);
			}
			goto IL_3f5e;
		}
		IL_3704:
		class6 = class6;
		while (obj3 != null)
		{
			while ((object)Class5.Default != null)
			{
				if (num == 0)
				{
					_ = (Class5)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj3, cultureInfo);
				}
			}
		}
		do
		{
			class17 = (Class9)(object)Class5.Default;
		}
		while (obj3 != null);
		gClass = gClass;
		try
		{
			try
			{
				class6 = null;
				_ = (GClass2)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array2, out *(object*)Class5.Default);
				_ = (Struct2)Class5.Default;
				gClass = gClass;
			}
			catch
			{
				try
				{
					qk = qk;
					_ = (GClass3)(object)Class5.Default;
					gClass = gClass;
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		catch
		{
			do
			{
				_ = (Class7)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				while (obj3 != null)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Struct1)Class5.Default;
				}
			}
			finally
			{
				bindingFlags = default(BindingFlags);
				qk = (Qk7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)@class.W(bindingFlags, propertyInfo_, type_3, (Type[])(object)Class5.Default, parameterModifier_), out object_3);
				goto IL_3885;
			}
		}
		IL_3374:
		_ = (Struct2)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, parameterModifier_, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), (string[])null, out object_3);
		Class7 class74 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class74.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, null, array, parameterModifier_)) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Qk7)@class.t(@class.e(bindingFlags, methodBase_, array, null), null, cultureInfo);
			}
			while (obj3 != null || (object)Class5.Default != null);
		}
		else
		{
			Class7 obj63 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)null).t(obj3, (Type)null, (CultureInfo)null), obj3, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)obj63.W(bindingFlags, null, null, (Type[])(object)Class5.Default, null);
			_ = (_003CModule_003E)(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_);
			_ = (Class2)(object)Class5.Default;
		}
		do
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass0)(object)Class5.Default;
					class4 = null;
					_ = (GClass0)(object)@class.t((BindingFlags)((Class7)null).t((object)null, type_3, cultureInfo), null, null, cultureInfo);
					class18 = null;
				}
				else
				{
					struct2 = (Struct1)Class5.Default;
				}
			}
			finally
			{
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)(object)class75.e(bindingFlags, methodBase_, null, null)).e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default);
				continue;
			}
		}
		while (obj3 != null);
		try
		{
			_ = (Class4)(object)Class5.Default;
		}
		catch
		{
			try
			{
			}
			finally
			{
				Class7 obj64 = (Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref reference, null, (CultureInfo)(object)@class.W(default(BindingFlags), (PropertyInfo[])@class.t(null, type_3, (CultureInfo)(object)Class5.Default), type_3, (Type[])(object)Class5.Default, null), (string[])@class.t(obj3, type_3, cultureInfo), out *(object*)null);
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)obj64.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj3, type_3, (CultureInfo)(object)Class5.Default), null, cultureInfo), null, parameterModifier_);
				goto end_IL_3580;
			}
			end_IL_3580:;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class37 = null;
			}
			else
			{
				class10 = null;
				Class7 class76 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)null).e((BindingFlags)class76.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_), (MethodBase[])null, array, parameterModifier_);
			}
		}
		finally
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			catch
			{
				_ = (Class8)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, null, parameterModifier_);
			}
			goto IL_3704;
		}
		IL_3356:
		try
		{
			class26 = (Class4)(object)Class5.Default;
		}
		finally
		{
			_ = (Class2)(object)Class5.Default;
			goto IL_3374;
		}
	}

	unsafe static void smethod_3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			checked
			{
				num -= unchecked((nuint)default(UIntPtr));
			}
			if (num == 0)
			{
				num = default(UIntPtr);
				nuint num2 = num / checked(num * unchecked((nuint)default(UIntPtr)));
				num = default(UIntPtr);
				nuint num3 = num;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				array = null;
				MethodBase[] methodBase_ = array;
				reference = ref reference;
				ref object[] object_ = ref reference;
				CultureInfo cultureInfo_ = (CultureInfo)(object)Class5.Default;
				array2 = null;
				@class = (Class7)(object)((Class7)null).j(bindingFlags_, methodBase_, ref object_, (ParameterModifier[])null, cultureInfo_, array2, out *(object*)Class5.Default);
				Class7 class2 = @class;
				type = type;
				Type type_ = type;
				cultureInfo = cultureInfo;
				checked
				{
					if (num2 - num3 * unchecked((nuint)(UIntPtr)class2.t(null, type_, cultureInfo)) == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
				}
			}
			else
			{
				try
				{
					obj = obj;
					_ = (Struct2)((Class7)null).t(obj, (Type)null, (CultureInfo)null);
				}
				catch
				{
					Class7 class3 = @class;
					Class7 class4 = @class;
					bindingFlags = default(BindingFlags);
					object object_2 = class4.t(bindingFlags, null, null, null);
					Type type_2 = type;
					Class7 obj2 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_2 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					ref object[] object_3 = ref reference;
					CultureInfo cultureInfo_2 = cultureInfo;
					string[] string_ = array2;
					object_4 = ref *(object*)@class.t(bindingFlags, null, obj, cultureInfo);
					_ = (Struct2)class3.t(object_2, type_2, (CultureInfo)(object)obj2.j(bindingFlags_2, methodBase_2, ref object_3, null, cultureInfo_2, string_, out object_4));
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				Class7 obj4 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
				Type type_3 = (Type)(object)Class5.Default;
				array3 = (Type[])(object)Class5.Default;
				Type[] type_4 = array3;
				array4 = array4;
				qk = (Qk7)(object)obj4.W(bindingFlags_3, propertyInfo_, type_3, type_4, array4);
				qk = null;
			}
			else if (num == 0)
			{
				class5 = null;
				class5 = class5;
				_ = (GClass3)(object)Class5.Default;
				_ = (_003CModule_003E)(object)@class.j((BindingFlags)@class.t(bindingFlags, null, Class5.Default, null), null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array2, out *(object*)Class5.Default);
				class6 = class6;
				class6 = null;
			}
		}
		class6 = null;
		_003CModule_003E obj6 = (_003CModule_003E)(object)Class5.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = obj6;
		GClass1 gClass = gClass;
		gClass = gClass;
		Struct2 @struct = @struct;
		@struct = @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass2);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (checked(num * num) == 0)
				{
					gClass = gClass;
				}
			}
			catch
			{
				gClass2 = null;
				gClass2 = gClass2;
				Struct1 obj7 = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default);
				struct2 = struct2;
				struct2 = obj7;
				class7 = class7;
				class7 = null;
			}
		}
		_ = (GClass3)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		do
		{
			if (num != 0)
			{
				Class7 class8 = @class;
				BindingFlags bindingFlags_4 = (BindingFlags)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
				Class7 obj9 = (Class7)(object)Class5.Default;
				object object_5 = Class5.Default;
				Class7 class9 = @class;
				BindingFlags bindingFlags_5 = bindingFlags;
				Class7 obj10 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, (Type[])null, array4), ref reference, array4, null, array2, out object_4);
				object object_6 = Class5.Default;
				Class7 class10 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_6 = bindingFlags;
				Class7 class11 = @class;
				BindingFlags bindingFlags_7 = bindingFlags;
				array5 = null;
				PropertyInfo[] propertyInfo_2 = array5;
				bindingFlags = default(BindingFlags);
				array6 = (FieldInfo[])(object)class11.W(bindingFlags_7, propertyInfo_2, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo), (Type[])(object)Class5.Default, null);
				gClass = (GClass1)(object)class8.W(bindingFlags_4, (PropertyInfo[])obj9.t(object_5, (Type)(object)class9.W(bindingFlags_5, (PropertyInfo[])obj10.t(object_6, (Type)(object)class10.t(bindingFlags_6, array6, null, cultureInfo), (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, null, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4)), null), type, null, array4);
			}
			else
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		while (obj != null);
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					@class = null;
				}
				goto IL_0619;
			}
		}
		try
		{
			while (obj != null)
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)null).e(bindingFlags_8, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)null, cultureInfo), ref reference, array4, (CultureInfo)(object)Class5.Default, array2, out object_4), (Type[])null, array4);
			}
		}
		catch
		{
			_ = (Class4)(object)Class5.Default;
		}
		goto IL_0619;
		IL_0c94:
		checked
		{
			if (num == 0)
			{
				if (num == 0)
				{
					do
					{
						_ = (GClass1)(object)Class5.Default;
					}
					while (obj != null);
				}
				else
				{
					@struct = @struct;
					_ = (GClass1)(object)Class5.Default;
				}
			}
			else if (unchecked((nuint)(UIntPtr)@class.t(Class5.Default, type, cultureInfo)) + num == 0)
			{
				try
				{
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class12.W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), (Type)(object)@class.t(bindingFlags, array6, null, cultureInfo), null, (ParameterModifier[])@class.t(obj, type, cultureInfo));
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			else
			{
				gClass2 = gClass2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class13);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				nuint num4 = num;
				num = default(UIntPtr);
				if (checked(num4 + num) == 0)
				{
					class13 = (Class9)(object)Class5.Default;
				}
				else
				{
					class5 = (Class10)(object)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags, array, array3, array4), array5, type, (Type[])null, array4);
				}
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class9)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
				}
			}
			finally
			{
				if (num == 0)
				{
					gClass2 = null;
					_ = (Class2)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
				}
				else
				{
					gClass3 = gClass3;
				}
				goto IL_0e5c;
			}
		}
		IL_4c12:
		do
		{
			_ = (Class10)(object)Class5.Default;
			_ = (Struct2)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array4);
			_ = (Class4)@class.t(obj, type, null);
			gClass2 = null;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class14);
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array6, @class.j(bindingFlags, array, ref reference, array4, cultureInfo, array2, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo)), cultureInfo)), type, (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)@class.e((BindingFlags)@class.W(bindingFlags, null, type, (Type[])@class.t(@class.e((BindingFlags)Class5.Default, array, array3, array4), type, null), array4), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4), (CultureInfo)null), array4) == (UIntPtr)(nuint)0u)
				{
					class14 = null;
				}
				else
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Struct2)Class5.Default;
					gClass = null;
					_ = (Class9)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		if ((nuint)(UIntPtr)Class5.Default / checked(num * num) == 0)
		{
			try
			{
				try
				{
					_ = (Struct2)Class5.Default;
					_ = (Class2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
					class6 = null;
				}
				catch
				{
					class13 = null;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t(default(BindingFlags), array6, null, cultureInfo), null, array4);
					class15 = null;
					_ = (Class9)(object)Class5.Default;
					gClass4 = (GClass0)(object)Class5.Default;
				}
			}
		}
		_ = Class5.Default;
		_ = Class5.Default;
		class6 = class6;
		return;
		IL_1e09:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		catch
		{
			Class7 obj16 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_9 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = array5;
			Class7 class16 = @class;
			BindingFlags bindingFlags_10 = bindingFlags;
			Class7 class17 = @class;
			Class7 obj17 = (Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
			BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_4 = array5;
			bindingFlags = default(BindingFlags);
			FieldInfo[] fieldInfo_ = (FieldInfo[])(object)class17.t(default(BindingFlags), (FieldInfo[])(object)obj17.W(bindingFlags_11, propertyInfo_4, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)@class.e((BindingFlags)((Class7)null).t((object)null, (Type)null, cultureInfo), null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo))).t(null, null, cultureInfo), (ParameterModifier[])null, (CultureInfo)null, array2, out object_4), null, null), obj, (CultureInfo)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)null, array3, array4));
			object object_7 = obj;
			Class7 obj18 = (Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj16.W(bindingFlags_9, propertyInfo_3, (Type)(object)class16.t(bindingFlags_10, fieldInfo_, object_7, (CultureInfo)(object)obj18.W(bindingFlags, array5, type, array3, array4)), array3, null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class10)(object)Class5.Default;
		}
		else
		{
			_ = (Class7)(object)Class5.Default;
			_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.e(bindingFlags, null, null, array4), (Type)null, array3, (ParameterModifier[])null)).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array4, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array2, out *(object*)null), array4);
			class6 = (Class4)(object)Class5.Default;
			_ = (GClass1)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
		}
		_ = (GClass2)(object)Class5.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num == 0)
			{
				while (((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo) != null)
				{
					do
					{
						_ = (Qk7)(object)Class5.Default;
					}
					while (obj != null);
				}
			}
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					BindingFlags bindingFlags_12 = bindingFlags;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])((Class7)(object)Class5.Default).t(null, null, cultureInfo);
					object object_8 = obj;
					Class7 obj20 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_13 = bindingFlags;
					Class7 obj21 = (Class7)(object)Class5.Default;
					Class7 class18 = @class;
					BindingFlags bindingFlags_14 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array6;
					object object_9 = obj;
					Class7 obj22 = (Class7)(object)((Class7)null).e(default(BindingFlags), array, (Type[])null, array4);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = (BindingFlags)obj22.W(bindingFlags, array5, type, null, null);
					Class7 obj23 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_16 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					BindingFlags bindingFlags_17 = (BindingFlags)((Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo)).e(bindingFlags, null, array3, array4);
					Class7 class19 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags_12, fieldInfo_2, object_8, (CultureInfo)(object)obj20.W(bindingFlags_13, (PropertyInfo[])(object)obj21.j((BindingFlags)class18.t(bindingFlags_14, fieldInfo_3, object_9, (CultureInfo)(object)((Class7)null).W(bindingFlags_15, (PropertyInfo[])(object)obj23.e(bindingFlags_16, methodBase_3, (Type[])(object)((Class7)null).t(bindingFlags_17, (FieldInfo[])(object)class19.j(bindingFlags, null, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)Class5.Default, out object_4), obj, (CultureInfo)null), null), type, array3, (ParameterModifier[])null)), null, ref reference, null, cultureInfo, null, out object_4), null, array3, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo)));
					_ = (Class6)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, null);
					class6 = null;
					class5 = null;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			_ = (Class2)@class.t(obj, null, cultureInfo);
			goto IL_2313;
		}
		IL_4967:
		try
		{
			try
			{
				if (num == 0)
				{
					Class7 class20 = @class;
					BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_4 = array6;
					Class7 obj24 = (Class7)@class.t(obj, type, cultureInfo);
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class20.t(bindingFlags_18, fieldInfo_4, obj24.j((BindingFlags)class21.W(bindingFlags, null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, array4), null, array4), null, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4), (CultureInfo)(object)Class5.Default, null, out *(object*)@class.e(bindingFlags, array, array3, array4)), cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_19 = bindingFlags;
					Class7 class22 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					Class7 class23 = @class;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_21 = (BindingFlags)((Class7)null).e(bindingFlags_20, (MethodBase[])((Class7)null).t((object)null, (Type)(object)class23.W((BindingFlags)((Class7)(object)class24.t(bindingFlags, array6, obj, null)).W((BindingFlags)Class5.Default, array5, null, array3, (ParameterModifier[])(object)Class5.Default), (PropertyInfo[])(object)Class5.Default, null, null, array4), (CultureInfo)null), array3, array4);
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).e(bindingFlags_19, (MethodBase[])(object)class22.W(bindingFlags_21, null, (Type)(object)class25.t(bindingFlags, null, obj, cultureInfo), null, array4), array3, array4);
				}
			}
			finally
			{
				class5 = class5;
				@struct = default(Struct2);
				goto end_IL_4968;
			}
			end_IL_4968:;
		}
		finally
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					_ = (GClass2)(object)((Class7)((Class7)null).t(obj, type, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)@class.e(bindingFlags, array, null, array4));
					gClass3 = null;
					_ = (Struct2)@class.e((BindingFlags)@class.W(bindingFlags, array5, type, array3, array4), array, null, (ParameterModifier[])(object)Class5.Default);
				}
			}
			goto IL_4c12;
		}
		IL_3e55:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 class26 = @class;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class26.t(default(BindingFlags), (FieldInfo[])(object)class27.e(bindingFlags, array, array3, array4), null, null);
			}
			catch
			{
				class6 = class6;
				Class7 class28 = @class;
				Class7 class29 = @class;
				BindingFlags bindingFlags_22 = (BindingFlags)@class.t(obj, null, null);
				MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
				ref object[] object_10 = ref *(object[]*)Class5.Default;
				Class7 class30 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_23 = (BindingFlags)class29.j(bindingFlags_22, methodBase_4, ref object_10, (ParameterModifier[])(object)class30.j(bindingFlags, null, ref *(object[]*)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null), array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), cultureInfo, null, out object_4);
				PropertyInfo[] propertyInfo_5 = array5;
				Type type_5 = type;
				Type[] type_6 = array3;
				Class7 class31 = @class;
				BindingFlags bindingFlags_24 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_25 = bindingFlags;
				MethodBase[] methodBase_6 = array;
				Class7 class33 = @class;
				BindingFlags bindingFlags_26 = (BindingFlags)@class.t(bindingFlags, null, Class5.Default, cultureInfo);
				Class7 class34 = @class;
				BindingFlags bindingFlags_27 = bindingFlags;
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				ref object[] object_11 = ref *(object[]*)class32.e(bindingFlags_25, methodBase_6, (Type[])(object)class33.e(bindingFlags_26, (MethodBase[])(object)class34.W(bindingFlags_27, (PropertyInfo[])(object)class35.e(bindingFlags, null, null, null), type, array3, array4), array3, array4), (ParameterModifier[])(object)Class5.Default);
				ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, cultureInfo, null, out object_4);
				Class7 obj25 = (Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null);
				bindingFlags = default(BindingFlags);
				qk = (Qk7)(object)class28.W(bindingFlags_23, propertyInfo_5, type_5, type_6, (ParameterModifier[])(object)class31.j(bindingFlags_24, methodBase_5, ref object_11, parameterModifier_, (CultureInfo)(object)obj25.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), array2, out object_4));
			}
		}
		do
		{
			gClass3 = gClass3;
		}
		while (obj != null);
		try
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				qk = qk;
				goto end_IL_40a0;
			}
			end_IL_40a0:;
		}
		finally
		{
			class6 = class6;
			Class7 class36 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			bindingFlags = default(BindingFlags);
			gClass4 = (GClass0)(object)class36.e(bindingFlags_28, (MethodBase[])(object)((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])null, array4), null, (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo));
			class15 = null;
			goto IL_4117;
		}
		IL_4117:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class37);
		try
		{
			try
			{
				while (obj != null)
				{
					gClass2 = gClass2;
				}
			}
			finally
			{
				if ((UIntPtr)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					class37 = class37;
				}
				else
				{
					class7 = class7;
				}
				goto end_IL_4118;
			}
			end_IL_4118:;
		}
		catch
		{
			do
			{
				if (num == 0)
				{
					class14 = class14;
				}
			}
			while (obj != null);
		}
		nuint num5 = num;
		BindingFlags bindingFlags_29 = bindingFlags;
		MethodBase[] methodBase_7 = array;
		Class7 class38 = @class;
		BindingFlags bindingFlags_30 = bindingFlags;
		Class7 obj28 = (Class7)(object)Class5.Default;
		Class7 class39 = @class;
		BindingFlags bindingFlags_31 = (BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])@class.t(obj, type, cultureInfo), ref *(object[]*)Class5.Default, null, null, null, out *(object*)((Class7)(object)Class5.Default).e(default(BindingFlags), array, array3, array4)), (string[])(object)@class.e((BindingFlags)Class5.Default, null, array3, array4), out object_4);
		PropertyInfo[] propertyInfo_6 = array5;
		Type type_7 = type;
		Class7 class40 = @class;
		Class7 class41 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (num5 + unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_29, methodBase_7, ref *(object[]*)class38.W(bindingFlags_30, (PropertyInfo[])(object)obj28.j((BindingFlags)class39.W(bindingFlags_31, propertyInfo_6, type_7, (Type[])class40.t(class41.W(bindingFlags, array5, null, array3, (ParameterModifier[])(object)@class.W(bindingFlags, array5, null, null, (ParameterModifier[])(object)Class5.Default)), type, cultureInfo), array4), (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out object_4), array, ref *(object[]*)null, null, cultureInfo, array2, out object_4), ref *(object[]*)null, array4, cultureInfo, array2, out object_4), type, array3, array4), array4, cultureInfo, array2, out object_4) / num) == 0)
			{
				class37 = class37;
			}
			while (obj != null)
			{
				try
				{
					try
					{
						qk = qk;
						_ = (_003CModule_003E)(object)Class5.Default;
					}
					catch
					{
						_ = (Class5)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default), type, array3, array4);
						@class = null;
						gClass4 = null;
						_ = (Struct2)Class5.Default;
					}
				}
				catch
				{
					_ = (GClass0)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).W(unchecked((BindingFlags)Class5.Default), (PropertyInfo[])null, (Type)null, array3, array4), ref reference, (ParameterModifier[])null, (CultureInfo)null, array2, out object_4);
				}
			}
			if (num == 0)
			{
				class14 = class14;
			}
			else
			{
				try
				{
					if (num + unchecked((nuint)(UIntPtr)@class.t(null, (Type)((Class7)@class.t(obj, type, cultureInfo)).t(obj, null, cultureInfo), null)) == 0)
					{
						class5 = class5;
					}
				}
				catch
				{
					if (num == 0)
					{
						_ = Class5.Default;
					}
				}
			}
			do
			{
				try
				{
					while (obj != null)
					{
						_ = (Class5)(object)@class.t(bindingFlags, null, obj, null);
					}
				}
				catch
				{
					while (obj != null)
					{
						_ = (Class9)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
					}
				}
			}
			while ((object)((Class7)null).W(bindingFlags, array5, (Type)null, array3, (ParameterModifier[])null) != null);
		}
		try
		{
			try
			{
				class37 = class37;
			}
			catch
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		catch
		{
			while (obj != null)
			{
				if ((UIntPtr)((Class7)null).e(bindingFlags, array, array3, array4) == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		try
		{
			checked
			{
				if ((unchecked((nuint)(UIntPtr)Class5.Default) - num - unchecked((nuint)(UIntPtr)((Class7)(object)@class.e((BindingFlags)Class5.Default, array, null, array4)).e(bindingFlags, null, array3, array4))) * num == 0)
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
						_ = (Class10)(object)Class5.Default;
					}
					finally
					{
						Class7 class42 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class5)(object)class42.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default);
						Class7 class43 = @class;
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_32 = bindingFlags;
						Class7 class44 = @class;
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_33 = bindingFlags;
						FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
						object object_12 = obj;
						Class7 class45 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class10)(object)class43.W(bindingFlags_32, null, (Type)(object)((Class7)(object)class44.t(bindingFlags_33, fieldInfo_5, object_12, (CultureInfo)(object)class45.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default))).e(bindingFlags, array, array3, null), (Type[])(object)Class5.Default, array4);
						class5 = (Class10)@class.t(obj, (Type)@class.t(obj, type, cultureInfo), cultureInfo);
						goto end_IL_4569;
					}
				}
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class13 = class13;
			}
			end_IL_4569:;
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)class46.e(bindingFlags, null, array3, array4);
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					bindingFlags = default(BindingFlags);
					class6 = (Class4)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, array4);
				}
				else
				{
					struct2 = default(Struct1);
				}
				goto end_IL_46f9;
			}
			end_IL_46f9:;
		}
		try
		{
			try
			{
				class37 = class37;
			}
			finally
			{
				_ = (Class7)(object)Class5.Default;
				goto end_IL_477e;
			}
			end_IL_477e:;
		}
		finally
		{
			if (num == 0)
			{
				Class7 class47 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)(object)class47.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)null, cultureInfo), ref reference, array4, (CultureInfo)(object)Class5.Default, array2, out *(object*)@class.j(bindingFlags, null, ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out object_4)), null, array2, out object_4))).j(bindingFlags, array, ref reference, null, null, null, out object_4);
			}
			else
			{
				_ = (_003CModule_003E)(object)@class.j((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array6, obj, cultureInfo), null, ref *(object[]*)null, null, cultureInfo, array2, out object_4);
			}
			goto IL_48b6;
		}
		IL_3d7c:
		do
		{
			try
			{
				try
				{
					_ = (Class6)((Class7)null).t(obj, type, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo));
				}
				catch
				{
					class13 = (Class9)(object)Class5.Default;
				}
			}
			catch
			{
			}
		}
		while (obj != null);
		class6 = class6;
		_ = (Qk7)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class48);
		while (obj != null)
		{
			do
			{
				class48 = null;
			}
			while ((object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default) != null || obj != null);
		}
		try
		{
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					class13 = class13;
				}
				while (obj != null);
			}
			goto IL_3e55;
		}
		IL_2cf1:
		while (obj != null)
		{
			do
			{
				struct2 = default(Struct1);
			}
			while (obj != null);
		}
		try
		{
			_ = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)Class5.Default;
			}
			goto IL_2d44;
		}
		IL_2313:
		_003CModule_003E = _003CModule_003E;
		do
		{
			class5 = class5;
		}
		while (obj != null);
		Class7 obj38 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj38.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, array4);
		class6 = class6;
		class15 = class15;
		if (num == 0)
		{
			try
			{
				_ = (Struct1)Class5.Default;
			}
			finally
			{
				if (num == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
				else
				{
					class37 = class37;
					_ = (Class2)(object)@class.j(bindingFlags, array, ref reference, array4, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, null));
				}
				goto IL_241c;
			}
		}
		do
		{
			_ = (GClass3)(object)Class5.Default;
		}
		while (obj != null);
		goto IL_241c;
		IL_241c:
		Class7 obj39 = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, cultureInfo, null, out object_4);
		BindingFlags bindingFlags_34 = bindingFlags;
		PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
		Type type_8 = (Type)(object)Class5.Default;
		Class7 class49 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_35 = bindingFlags;
		PropertyInfo[] propertyInfo_8 = array5;
		Type type_9 = type;
		Type[] type_10 = (Type[])(object)Class5.Default;
		Class7 class50 = @class;
		BindingFlags bindingFlags_36 = bindingFlags;
		Class7 class51 = @class;
		bindingFlags = default(BindingFlags);
		nuint num6 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Class7)(object)((Class7)null).e((BindingFlags)obj39.W(bindingFlags_34, propertyInfo_7, type_8, (Type[])(object)class49.W(bindingFlags_35, propertyInfo_8, type_9, type_10, (ParameterModifier[])(object)class50.e(bindingFlags_36, null, (Type[])(object)class51.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)@class.t(bindingFlags, array6, obj, null)).e(bindingFlags, null, null, array4))), null), array, (Type[])(object)Class5.Default, (ParameterModifier[])null)).e((BindingFlags)@class.W(bindingFlags, array5, null, array3, array4), array, array3, array4);
		num = default(UIntPtr);
		if (num6 / checked(num + num) == 0)
		{
			_ = (GClass1)(object)((Class7)(object)@class.t(bindingFlags, array6, @class.t((BindingFlags)Class5.Default, array6, obj, cultureInfo), (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, (Type[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, obj, cultureInfo), (Type[])null, (ParameterModifier[])null), type, array3, array4), (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
		}
		catch
		{
			do
			{
				struct2 = struct2;
				_ = (_003CModule_003E)(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, array4);
			}
			while ((object)Class5.Default != null);
		}
		gClass2 = (GClass2)(object)Class5.Default;
		while (obj != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					@struct = (Struct2)Class5.Default;
				}
			}
			catch
			{
				UIntPtr num7 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if ((nuint)num7 / num == 0)
				{
					class48 = (Class8)(object)Class5.Default;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				class7 = class7;
			}
			catch
			{
				try
				{
					@class = @class;
				}
				finally
				{
					_ = (Class8)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)@class.W(bindingFlags, array5, null, null, (ParameterModifier[])(object)Class5.Default));
					goto end_IL_26eb;
				}
				end_IL_26eb:;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array2, out *(object*)Class5.Default), (object)null, cultureInfo);
				}
			}
			else
			{
				gClass2 = gClass2;
			}
		}
		catch
		{
			try
			{
				class5 = null;
			}
			finally
			{
				num = default(UIntPtr);
				UIntPtr num8 = num;
				UIntPtr num9 = (UIntPtr)Class5.Default;
				UIntPtr num10 = num;
				UIntPtr num11 = num;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num8) - unchecked(checked(unchecked((nuint)num9) - unchecked((nuint)num10 / ((nuint)num11 / num))) / (num / (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])@class.t(null, (Type)(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, null, array3, (ParameterModifier[])(object)Class5.Default), null)).j(bindingFlags, array, ref reference, array4, cultureInfo, array2, out object_4), cultureInfo), cultureInfo, (string[])null, out *(object*)null)) * unchecked((nuint)default(UIntPtr)))))) == 0)
					{
						struct2 = struct2;
						_ = (Struct1)Class5.Default;
						Class7 class52 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Qk7)(object)class52.e(bindingFlags, array, array3, null);
					}
					goto end_IL_27b0;
				}
			}
			end_IL_27b0:;
		}
		try
		{
			BindingFlags bindingFlags_37 = bindingFlags;
			Class7 class53 = @class;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_8 = (MethodBase[])(object)class53.j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array6, obj, cultureInfo), ref *(object[]*)null, array4, null, (string[])(object)Class5.Default, out *(object*)null);
			ref object[] object_13 = ref reference;
			ParameterModifier[] parameterModifier_2 = array4;
			object object_14 = obj;
			Type type_11 = (Type)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)@class.e(bindingFlags, array, array3, array4), null);
			Class7 class54 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_38 = bindingFlags;
			FieldInfo[] fieldInfo_6 = array6;
			object object_15 = obj;
			Class7 obj44 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_39 = bindingFlags;
			MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
			Class7 obj45 = (Class7)@class.t(obj, type, cultureInfo);
			BindingFlags bindingFlags_40 = bindingFlags;
			FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
			Class7 class55 = @class;
			BindingFlags bindingFlags_41 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array2, out object_4);
			Class7 class56 = @class;
			BindingFlags bindingFlags_42 = bindingFlags;
			BindingFlags bindingFlags_43 = bindingFlags;
			Class7 class57 = @class;
			BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
			Class7 obj46 = (Class7)(object)Class5.Default;
			object object_16 = obj;
			Type type_12 = type;
			Class7 obj47 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj48 = (Class7)(object)obj47.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, null, null, out object_4);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_45 = bindingFlags;
			Class7 class58 = @class;
			BindingFlags bindingFlags_46 = bindingFlags;
			PropertyInfo[] propertyInfo_10 = array5;
			Type type_13 = (Type)(object)Class5.Default;
			Type[] type_14 = (Type[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array4, (CultureInfo)null, (string[])null, out object_4);
			Class7 class59 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj49 = (Class7)(object)class56.t(bindingFlags_42, (FieldInfo[])(object)((Class7)null).t(bindingFlags_43, (FieldInfo[])(object)class57.e(bindingFlags_44, (MethodBase[])obj46.t(object_16, type_12, (CultureInfo)(object)obj48.e(bindingFlags_45, (MethodBase[])((Class7)(object)class58.W(bindingFlags_46, propertyInfo_10, type_13, type_14, (ParameterModifier[])(object)((Class7)(object)class59.W(bindingFlags, array5, type, (Type[])(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo), array4)).t(bindingFlags, null, obj, cultureInfo))).t(obj, type, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default)), array3, (ParameterModifier[])(object)Class5.Default), obj, (CultureInfo)null), Class5.Default, null);
			bindingFlags = default(BindingFlags);
			CultureInfo cultureInfo_3 = (CultureInfo)((Class7)null).t(object_14, type_11, (CultureInfo)(object)class54.t(bindingFlags_38, fieldInfo_6, object_15, (CultureInfo)((Class7)(object)obj44.j(bindingFlags_39, methodBase_9, ref *(object[]*)null, null, null, (string[])(object)obj45.t(bindingFlags_40, fieldInfo_7, class55.W(bindingFlags_41, propertyInfo_9, (Type)(object)obj49.W(bindingFlags, null, (Type)(object)Class5.Default, null, null), null, null), null), out object_4)).t(obj, null, (CultureInfo)(object)Class5.Default)));
			string[] string_2 = array2;
			Class7 class60 = @class;
			bindingFlags = default(BindingFlags);
			UIntPtr num12 = (UIntPtr)((Class7)null).j(bindingFlags_37, methodBase_8, ref object_13, parameterModifier_2, cultureInfo_3, string_2, out *(object*)class60.t(bindingFlags, null, obj, cultureInfo));
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num12) - (num + num)) == 0)
			{
				while ((object)Class5.Default != null)
				{
					class37 = null;
					class37 = class37;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class14 = class14;
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass = null;
			}
			else
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					@class = null;
				}
			}
			goto IL_2cf1;
		}
		IL_0619:
		while (obj != null)
		{
			_ = (Class2)(object)@class.W((BindingFlags)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out object_4)).t(obj, type, cultureInfo), null, null, array3, (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				@class = @class;
				_ = (GClass1)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				goto end_IL_061f;
			}
			end_IL_061f:;
		}
		finally
		{
			_ = (Class9)(object)Class5.Default;
			goto IL_065c;
		}
		IL_1cf2:
		checked
		{
			try
			{
				while (obj != null)
				{
					if ((unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array5, type, array3, array4)) + unchecked((nuint)(UIntPtr)Class5.Default)) * num == 0)
					{
						@class = @class;
					}
					else
					{
						_ = (GClass0)(object)unchecked(((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)@class.e(bindingFlags, array, (Type[])(object)((Class7)null).e((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), type, null, array4), (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])null), null), (ParameterModifier[])null, (CultureInfo)null, (string[])null, out object_4));
					}
				}
			}
			finally
			{
				try
				{
					try
					{
						gClass4 = null;
					}
					finally
					{
						@struct = default(Struct2);
						goto end_IL_1dcb;
					}
					end_IL_1dcb:;
				}
				finally
				{
					if (num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class10)(object)Class5.Default;
					}
					goto IL_1e09;
				}
			}
		}
		IL_065c:
		_ = (Class6)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (GClass1)(object)Class5.Default;
				class14 = class14;
				class14 = class14;
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj != null);
		}
		try
		{
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass = gClass;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass4 = (GClass0)(object)Class5.Default;
					gClass4 = gClass4;
					class7 = (Class6)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
				catch
				{
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					class15 = (Class0)(object)class61.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default);
					class15 = class15;
				}
			}
			else if (num == (UIntPtr)(nuint)0u)
			{
				gClass2 = (GClass2)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo);
			}
		}
		catch
		{
			do
			{
				try
				{
					gClass4 = null;
					gClass2 = gClass2;
				}
				finally
				{
					qk = (Qk7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			try
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) == 0)
					{
						qk = qk;
					}
					else
					{
						_ = (Class2)(object)Class5.Default;
					}
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		catch
		{
			if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default != 0)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
					class14 = null;
					_ = (Struct1)Class5.Default;
					class5 = class5;
				}
				finally
				{
					class15 = null;
					class13 = class13;
					class13 = class13;
					goto end_IL_082d;
				}
			}
			while (obj != null)
			{
				class48 = (Class8)(object)Class5.Default;
				class48 = null;
			}
			end_IL_082d:;
		}
		UIntPtr num13 = (UIntPtr)@class.W(bindingFlags, array5, null, null, null);
		num = default(UIntPtr);
		if ((nuint)num13 / num == 0)
		{
			if (num == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			else
			{
				try
				{
					_ = (Class6)(object)@class.W(bindingFlags, null, type, null, null);
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			goto IL_0c94;
		}
		try
		{
			if (num == 0)
			{
				Class7 class62 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				PropertyInfo[] propertyInfo_11 = (PropertyInfo[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
				Class7 obj56 = (Class7)(object)@class.t(bindingFlags, null, obj, null);
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class62.W(bindingFlags_47, propertyInfo_11, (Type)obj56.t(class63.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), type, cultureInfo), array3, null);
				Class7 class64 = @class;
				BindingFlags bindingFlags_48 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class64.t(bindingFlags_48, (FieldInfo[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, (string[])((Class7)null).t((object)null, type, cultureInfo), out *(object*)null), @class.e(bindingFlags, array, (Type[])((Class7)(object)@class.W(bindingFlags, null, (Type)((Class7)null).t((object)null, (Type)@class.t(Class5.Default, type, null), cultureInfo), array3, array4)).t(null, type, null), array4), (CultureInfo)(object)Class5.Default);
				gClass3 = (GClass3)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				gClass3 = null;
			}
			else
			{
				gClass4 = gClass4;
			}
		}
		finally
		{
			while (obj != null)
			{
				Class7 class65 = @class;
				BindingFlags bindingFlags_49 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class66 = @class;
				BindingFlags bindingFlags_51 = bindingFlags;
				ref object[] object_17 = ref reference;
				ParameterModifier[] parameterModifier_3 = array4;
				Class7 obj57 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array4, cultureInfo, array2, out *(object*)null);
				bindingFlags = default(BindingFlags);
				FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)((Class7)null).j(bindingFlags_50, (MethodBase[])(object)class66.j(bindingFlags_51, null, ref object_17, parameterModifier_3, (CultureInfo)(object)obj57.t(bindingFlags, (FieldInfo[])@class.t(obj, null, (CultureInfo)(object)@class.W((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo), (PropertyInfo[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array5, null, array3, array4)), (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), (Type[])(object)Class5.Default, null)), obj, null), (string[])(object)Class5.Default, out *(object*)null), ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)Class5.Default, out object_4);
				object object_18 = obj;
				Class7 obj58 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class65.t(bindingFlags_49, fieldInfo_8, object_18, (CultureInfo)(object)obj58.j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, cultureInfo, array2, out object_4));
			}
			goto IL_0c94;
		}
		IL_3c38:
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class7)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])null, array4);
				}
				else
				{
					_ = (GClass1)((Class7)(object)@class.W((BindingFlags)((Class7)null).W(bindingFlags, array5, type, array3, array4), array5, type, array3, null)).t(null, type, cultureInfo);
				}
			}
			finally
			{
				do
				{
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(null, type, null), type, array3, (ParameterModifier[])null);
				}
				while ((object)Class5.Default != null);
				goto end_IL_3c39;
			}
			end_IL_3c39:;
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					qk = null;
				}
				else
				{
					_ = (GClass1)((Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo)).t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				goto IL_3d7c;
			}
		}
		IL_0e5c:
		try
		{
			try
			{
				UIntPtr num14 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				nuint num15;
				nuint num16;
				checked
				{
					num15 = unchecked((nuint)num14) + num;
					num16 = num;
				}
				UIntPtr num17 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if (checked(num15 * (num16 - unchecked((nuint)num17 / checked(num * (unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)) + unchecked((nuint)(UIntPtr)Class5.Default))))) - num) / num == 0)
				{
					struct2 = default(Struct1);
					struct2 = struct2;
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			finally
			{
				try
				{
					gClass2 = gClass2;
				}
				finally
				{
					class6 = null;
					goto end_IL_0e5d;
				}
			}
			end_IL_0e5d:;
		}
		catch
		{
			nuint num18;
			checked
			{
				num18 = num * unchecked(checked(num + num) / (nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, array3, array4));
			}
			UIntPtr num19 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			if (num18 / checked(unchecked((nuint)num19) * num) == 0)
			{
				do
				{
					gClass = null;
				}
				while (obj != null);
			}
			else
			{
				gClass4 = gClass4;
				Class7 obj59 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)Class5.Default, array, null, array4), type, (Type[])(object)Class5.Default, array4), cultureInfo, null, out *(object*)((Class7)null).t(obj, (Type)null, (CultureInfo)null)), null, array2, out object_4), (PropertyInfo[])@class.t(obj, type, cultureInfo), type, (Type[])(object)Class5.Default, (ParameterModifier[])null), (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)obj59.e(bindingFlags, array, array3, null);
				class14 = class14;
				class37 = class37;
				class37 = null;
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (Class6)(object)@class.e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])@class.t(((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array3, array4), type, cultureInfo), obj, cultureInfo));
				}
				finally
				{
					class48 = class48;
					goto end_IL_1085;
				}
				end_IL_1085:;
			}
			finally
			{
				if (num == 0)
				{
					_ = (GClass0)((Class7)(object)Class5.Default).t(@class.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
				}
				continue;
			}
		}
		while (obj != null);
		if (num == 0)
		{
			struct2 = struct2;
			_ = Class5.Default;
			_003CModule_003E = null;
			BindingFlags bindingFlags_52 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_9 = array6;
			Class7 class67 = @class;
			BindingFlags bindingFlags_53 = bindingFlags;
			Type type_15 = (Type)(object)Class5.Default;
			Type[] type_16 = array3;
			Class7 obj61 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			class6 = (Class4)(object)((Class7)null).t(bindingFlags_52, fieldInfo_9, (object)class67.t(bindingFlags_53, null, ((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type_15, type_16, (ParameterModifier[])(object)obj61.t(bindingFlags, array6, obj, cultureInfo)), null), cultureInfo);
		}
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default);
			_ = (_003CModule_003E)(object)Class5.Default;
			class14 = class14;
		}
		finally
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + num) == 0)
			{
				try
				{
					Class7 obj62 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_12 = array5;
					Class7 obj63 = (Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, null);
					BindingFlags bindingFlags_55 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_10 = array;
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj62.W(bindingFlags_54, propertyInfo_12, (Type)(object)obj63.e(bindingFlags_55, methodBase_10, (Type[])(object)class68.j(bindingFlags, null, ref reference, array4, cultureInfo, array2, out *(object*)null), array4), array3, null);
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					class6 = null;
					goto IL_13f0;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 class69 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj64 = (Class7)(object)class69.j(bindingFlags, null, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, array2, out *(object*)null);
				BindingFlags bindingFlags_56 = bindingFlags;
				PropertyInfo[] propertyInfo_13 = array5;
				Class7 class70 = @class;
				bindingFlags = default(BindingFlags);
				class48 = (Class8)(object)obj64.W(bindingFlags_56, propertyInfo_13, (Type)(object)class70.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array4), array3, null);
			}
			else
			{
				_ = (Class7)@class.t(obj, (Type)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, array4), null);
			}
			goto IL_13f0;
		}
		IL_3439:
		_ = (Class7)(object)Class5.Default;
		try
		{
			Class7 class71 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_57 = bindingFlags;
			bindingFlags = default(BindingFlags);
			class5 = (Class10)((Class7)(object)class71.t(bindingFlags_57, null, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo))).t(obj, null, (CultureInfo)(object)Class5.Default);
		}
		finally
		{
			if (checked(num + num) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class6 = class6;
				}
				else
				{
					gClass4 = gClass4;
				}
			}
			else if (num == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_3640;
		}
		IL_3640:
		while (obj != null)
		{
			try
			{
				if (num / checked(unchecked((nuint)(UIntPtr)Class5.Default) + num) == 0)
				{
					_ = (Class4)(object)Class5.Default;
					Class7 class72 = @class;
					BindingFlags bindingFlags_58 = bindingFlags;
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class72.j(bindingFlags_58, (MethodBase[])(object)class73.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, array5, type, array3, array4), type, array3, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)@class.e((BindingFlags)Class5.Default, null, null, array4), array4, null, array2, out *(object*)Class5.Default);
					class14 = class14;
					class5 = class5;
				}
				else
				{
					_ = (GClass1)(object)@class.e(bindingFlags, null, array3, null);
				}
			}
			finally
			{
				try
				{
					_ = (GClass3)(object)((Class7)(object)@class.t(bindingFlags, null, obj, cultureInfo)).j(bindingFlags, null, ref reference, array4, cultureInfo, null, out object_4);
					@class = null;
				}
				finally
				{
					struct2 = default(Struct1);
					@class = @class;
					_ = (Struct2)Class5.Default;
					continue;
				}
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class0)(object)@class.e((BindingFlags)((Class7)((Class7)(object)Class5.Default).t(Class5.Default, null, (CultureInfo)@class.t(null, type, cultureInfo))).t(null, type, null), array, (Type[])(object)Class5.Default, array4);
				}
				catch
				{
					class37 = (Class2)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			BindingFlags bindingFlags_59 = bindingFlags;
			MethodBase[] methodBase_11 = array;
			ref object[] object_19 = ref reference;
			BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_12 = array;
			ref object[] object_20 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])@class.t(@class.e(default(BindingFlags), array, null, (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, array4);
			Class7 class74 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)((Class7)null).j(bindingFlags_59, methodBase_11, ref object_19, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_60, methodBase_12, ref object_20, parameterModifier_4, (CultureInfo)(object)class74.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array4), (string[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, null), out *(object*)null), cultureInfo, array2, out object_4);
			_003CModule_003E = _003CModule_003E;
		}
		_ = (Class8)(object)Class5.Default;
		class5 = class5;
		_ = (Qk7)(object)@class.t((BindingFlags)@class.t(null, (Type)(object)Class5.Default, cultureInfo), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
		class48 = class48;
		try
		{
			do
			{
				class37 = null;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				try
				{
					class37 = (Class2)(object)Class5.Default;
				}
				finally
				{
					gClass2 = gClass2;
					goto end_IL_3871;
				}
				end_IL_3871:;
			}
			catch
			{
				try
				{
					Class7 obj66 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_61 = bindingFlags;
					Class7 class75 = @class;
					BindingFlags bindingFlags_62 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_14 = (PropertyInfo[])(object)Class5.Default;
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj66.j((BindingFlags)((Class7)null).j(bindingFlags_61, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)class75.W(bindingFlags_62, propertyInfo_14, (Type)(object)class76.t(bindingFlags, array6, obj, cultureInfo), null, array4), (CultureInfo)(object)Class5.Default, array2, out *(object*)Class5.Default), array, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, array3, array4), null, type, (Type[])(object)Class5.Default, null), cultureInfo, (string[])((Class7)@class.t(null, type, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])null))).t(null, null, (CultureInfo)(object)Class5.Default), out object_4);
					goto end_IL_3891;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					goto end_IL_3891;
				}
				end_IL_3891:;
			}
		}
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					gClass4 = null;
				}
				else
				{
					struct2 = default(Struct1);
				}
			}
			while (obj != null);
		}
		class48 = class48;
		try
		{
			_ = (Struct2)((Class7)null).W(bindingFlags, array5, (Type)null, array3, array4);
			_ = (Struct1)Class5.Default;
		}
		catch
		{
			try
			{
				_ = (GClass3)(object)((Class7)null).W((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default), array5, (Type)null, (Type[])(object)Class5.Default, array4);
				_ = (GClass0)(object)Class5.Default;
				_ = (Class2)(object)@class.W((BindingFlags)Class5.Default, null, type, array3, null);
			}
			catch
			{
				struct2 = default(Struct1);
			}
		}
		try
		{
			do
			{
				class6 = null;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_63 = bindingFlags;
					MethodBase[] methodBase_13 = array;
					ref object[] object_21 = ref reference;
					ParameterModifier[] parameterModifier_5 = array4;
					CultureInfo cultureInfo_4 = cultureInfo;
					Class7 class78 = @class;
					BindingFlags bindingFlags_64 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_14 = array;
					Type[] type_17 = array3;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_65 = bindingFlags;
					ref object[] object_22 = ref reference;
					Class7 class79 = @class;
					Class7 obj72 = (Class7)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null), null, null, array4);
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class77.j(bindingFlags_63, methodBase_13, ref object_21, parameterModifier_5, cultureInfo_4, (string[])(object)class78.e(bindingFlags_64, methodBase_14, type_17, (ParameterModifier[])((Class7)null).t((object)((Class7)null).j(bindingFlags_65, (MethodBase[])null, ref object_22, (ParameterModifier[])(object)((Class7)(object)class79.t((BindingFlags)obj72.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array4), array6, obj, cultureInfo)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, array4), (CultureInfo)null, array2, out object_4), (Type)null, cultureInfo)), out *(object*)Class5.Default);
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			goto IL_3c38;
		}
		IL_48b6:
		num = default(UIntPtr);
		if (num == 0)
		{
			while ((object)Class5.Default != null)
			{
				_ = (Struct1)Class5.Default;
			}
		}
		else
		{
			do
			{
				try
				{
					class5 = null;
				}
				catch
				{
					_003CModule_003E = null;
					_ = (Class0)(object)Class5.Default;
					_ = (Class6)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])null, out *(object*)null);
				}
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			class13 = null;
		}
		finally
		{
			if (num == 0)
			{
				class7 = null;
			}
			else
			{
				while (obj != null)
				{
					class48 = (Class8)(object)Class5.Default;
				}
			}
			goto IL_4967;
		}
		IL_2d44:
		do
		{
			try
			{
				struct2 = struct2;
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
				gClass3 = gClass3;
				Class7 class80 = @class;
				BindingFlags bindingFlags_66 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_15 = array;
				Class7 class81 = @class;
				BindingFlags bindingFlags_67 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_10 = (FieldInfo[])(object)Class5.Default;
				BindingFlags bindingFlags_68 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_11 = (FieldInfo[])(object)Class5.Default;
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj76 = (Class7)(object)((Class7)null).t((BindingFlags)class82.W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)@class.t((BindingFlags)@class.t(bindingFlags, null, null, cultureInfo), array6, null, cultureInfo), (ParameterModifier[])(object)Class5.Default), (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class80.j(bindingFlags_66, methodBase_15, ref *(object[]*)class81.t(bindingFlags_67, fieldInfo_10, ((Class7)null).t(bindingFlags_68, fieldInfo_11, (object)null, (CultureInfo)(object)obj76.W(bindingFlags, array5, null, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo))), cultureInfo), null, cultureInfo, array2, out object_4);
			}
		}
		while (obj != null || obj != null);
		_ = (GClass1)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
		while (true)
		{
			if (obj != null)
			{
				while (obj != null)
				{
					qk = null;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		_ = (Struct1)Class5.Default;
		try
		{
			if (num == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class6 = class6;
			}
		}
		catch
		{
			try
			{
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class83.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array2, out *(object*)@class.W(bindingFlags, array5, type, (Type[])@class.t(@class.W(bindingFlags, array5, type, null, null), null, (CultureInfo)(object)Class5.Default), array4)) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)((Class7)null).e(bindingFlags, array, array3, array4);
				}
			}
			catch
			{
				try
				{
					class6 = class6;
					goto end_IL_2fbb;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
					goto end_IL_2fbb;
				}
				end_IL_2fbb:;
			}
		}
		_ = (Struct2)Class5.Default;
		Class7 class84 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)class84.W(bindingFlags, array5, (Type)(object)@class.e(bindingFlags, array, null, array4), (Type[])(object)@class.e(default(BindingFlags), array, null, null), array4);
		Class7 obj81 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)obj81.W(bindingFlags, array5, (Type)(object)@class.e((BindingFlags)Class5.Default, array, array3, (ParameterModifier[])(object)@class.t(bindingFlags, array6, null, null)), array3, array4);
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
		}
		_003CModule_003E = _003CModule_003E;
		Class7 class85 = @class;
		BindingFlags bindingFlags_69 = bindingFlags;
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)class85.e(bindingFlags_69, null, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), null);
		try
		{
			while ((object)@class.t(bindingFlags, array6, null, null) != null)
			{
				_ = (Class0)(object)Class5.Default;
				class7 = class7;
				class7 = null;
				class37 = class37;
			}
		}
		finally
		{
			UIntPtr num20 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num20) + num) == 0)
			{
				Class7 obj82 = (Class7)(object)Class5.Default;
				Class7 obj83 = (Class7)(object)@class.e(bindingFlags, array, array3, array4);
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_16 = (MethodBase[])(object)((Class7)null).W((BindingFlags)((Class7)null).j(bindingFlags, array, ref reference, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), array5, (Type)null, (Type[])null, array4);
				ref object[] object_23 = ref *(object[]*)@class.e(bindingFlags, array, null, null);
				ParameterModifier[] parameterModifier_6 = array4;
				Class7 class86 = @class;
				BindingFlags bindingFlags_70 = bindingFlags;
				MethodBase[] methodBase_17 = (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, Class5.Default, cultureInfo), ref reference, null, cultureInfo, null, out object_4);
				ref object[] object_24 = ref *(object[]*)@class.e((BindingFlags)Class5.Default, null, array3, array4);
				ParameterModifier[] parameterModifier_7 = array4;
				CultureInfo cultureInfo_5 = cultureInfo;
				string[] string_3 = array2;
				Class7 obj84 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_71 = bindingFlags;
				MethodBase[] methodBase_18 = array;
				ref object[] object_25 = ref reference;
				ParameterModifier[] parameterModifier_8 = (ParameterModifier[])((Class7)null).t(obj, type, cultureInfo);
				Class7 class87 = @class;
				BindingFlags bindingFlags_72 = (BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, array3, null), ref reference, array4, (CultureInfo)(object)Class5.Default, array2, out *(object*)null);
				MethodBase[] methodBase_19 = array;
				ref object[] object_26 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_9 = array4;
				CultureInfo cultureInfo_6 = (CultureInfo)@class.t(obj, type, null);
				string[] string_4 = (string[])(object)Class5.Default;
				Class7 class88 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)obj82.W((BindingFlags)obj83.j(default(BindingFlags), methodBase_16, ref object_23, parameterModifier_6, null, (string[])(object)class86.j(bindingFlags_70, methodBase_17, ref object_24, parameterModifier_7, cultureInfo_5, string_3, out *(object*)obj84.j(bindingFlags_71, methodBase_18, ref object_25, parameterModifier_8, (CultureInfo)(object)class87.j(bindingFlags_72, methodBase_19, ref object_26, parameterModifier_9, cultureInfo_6, string_4, out *(object*)class88.t(null, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)((Class7)((Class7)null).t(obj, type, cultureInfo)).j(bindingFlags, null, ref reference, array4, (CultureInfo)((Class7)null).t(obj, type, cultureInfo), array2, out object_4), cultureInfo, array2, out *(object*)Class5.Default))), array2, out *(object*)null)), out *(object*)null), (PropertyInfo[])(object)Class5.Default, type, array3, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_3439;
		}
		IL_1433:
		class14 = class14;
		class37 = class37;
		@struct = default(Struct2);
		if (unchecked((nuint)default(UIntPtr)) / (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default) == 0)
		{
			_ = (Class8)(object)Class5.Default;
			class6 = (Class4)(object)Class5.Default;
			gClass2 = gClass2;
		}
		try
		{
		}
		catch
		{
			try
			{
				if ((UIntPtr)((Class7)null).j((BindingFlags)((Class7)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null)).W(bindingFlags, array5, null, (Type[])(object)Class5.Default, array4), array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					class6 = class6;
				}
			}
			catch
			{
				class14 = Class5.Default;
			}
		}
		checked
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num * (num * unchecked(num / (nuint)(UIntPtr)Class5.Default)) == 0)
				{
					if (num == 0)
					{
						_ = (Struct1)Class5.Default;
					}
					else
					{
						gClass4 = gClass4;
					}
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class15 = class15;
				}
				catch
				{
					gClass4 = null;
				}
			}
			else if (num == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
			}
			else
			{
				_003CModule_003E = null;
				@class = (Class7)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class9)@class.t(obj, type, cultureInfo);
				}
				finally
				{
					_003CModule_003E = null;
					goto end_IL_15c7;
				}
				end_IL_15c7:;
			}
			catch
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		do
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			catch
			{
				_ = (Qk7)@class.t(@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, array3, null), type, (CultureInfo)(object)Class5.Default);
			}
		}
		while (obj != null);
		try
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 class89 = @class;
					object object_27 = obj;
					Type type_18 = type;
					Class7 class90 = @class;
					BindingFlags bindingFlags_73 = bindingFlags;
					MethodBase[] methodBase_20 = array;
					ref object[] object_28 = ref *(object[]*)@class.t(obj, type, cultureInfo);
					CultureInfo cultureInfo_7 = cultureInfo;
					Class7 obj91 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)class89.t(object_27, type_18, (CultureInfo)(object)class90.j(bindingFlags_73, methodBase_20, ref object_28, null, cultureInfo_7, (string[])(object)obj91.W(bindingFlags, array5, type, array3, null), out object_4));
					class15 = null;
				}
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			try
			{
				class14 = null;
				class15 = class15;
				Class7 class91 = @class;
				BindingFlags bindingFlags_74 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_21 = (MethodBase[])(object)Class5.Default;
				ParameterModifier[] parameterModifier_10 = array4;
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class91.j(bindingFlags_74, methodBase_21, ref *(object[]*)null, parameterModifier_10, (CultureInfo)((Class7)(object)class92.e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, null, array3, array4), array3, null)).t(null, null, null), array2, out object_4);
			}
			catch
			{
				while (true)
				{
					class7 = class7;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_17c1;
				}
				end_IL_17c1:;
			}
		}
		while (true)
		{
			if ((object)@class.j((BindingFlags)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), null, ref reference, array4, (CultureInfo)(object)@class.e(bindingFlags, null, array3, array4), null, out *(object*)@class.t(null, (Type)@class.t(null, null, cultureInfo), (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, null, array3, null))) != null)
			{
				while (obj != null)
				{
					gClass2 = gClass2;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		gClass3 = null;
		do
		{
			_ = (GClass0)(object)Class5.Default;
		}
		while (obj != null);
		while ((object)Class5.Default != null)
		{
			do
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					Class7 class93 = @class;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass2)(object)class93.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), array4)), cultureInfo, null, out object_4);
				}
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			gClass = gClass;
		}
		finally
		{
			while (obj != null)
			{
				Class7 class94 = @class;
				BindingFlags bindingFlags_75 = (BindingFlags)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
				MethodBase[] methodBase_22 = array;
				ref object[] object_29 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_11 = array4;
				Class7 class95 = @class;
				bindingFlags = default(BindingFlags);
				qk = (Qk7)(object)((Class7)(object)class94.j(bindingFlags_75, methodBase_22, ref object_29, parameterModifier_11, (CultureInfo)(object)class95.e(bindingFlags, null, array3, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array, array3, array4)), array2, out *(object*)@class.e((BindingFlags)Class5.Default, array, array3, array4))).e((BindingFlags)Class5.Default, array, (Type[])(object)@class.t(bindingFlags, array6, obj, null), (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_1ac7;
		}
		IL_1ac7:
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass2 = (GClass2)(object)Class5.Default;
				continue;
			}
			_ = (Class8)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array4, null, null, out object_4);
			_ = (GClass0)(object)Class5.Default;
		}
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)@class.t(null, type, cultureInfo) == 0)
		{
			try
			{
				struct2 = default(Struct1);
				struct2 = struct2;
			}
			catch
			{
				while (obj != null)
				{
					Class7 class96 = @class;
					BindingFlags bindingFlags_76 = bindingFlags;
					FieldInfo[] fieldInfo_12 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class96.t(bindingFlags_76, fieldInfo_12, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4)));
				}
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (Class7)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
				Class7 class97 = @class;
				Class7 class98 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class97.t((BindingFlags)class98.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, array4));
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		else
		{
			do
			{
				qk = qk;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			try
			{
				class7 = (Class6)(object)Class5.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / num == 0)
				{
					_ = (Class9)(object)Class5.Default;
					continue;
				}
				class13 = (Class9)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				@struct = (Struct2)Class5.Default;
				continue;
			}
		}
		class13 = class13;
		try
		{
			while (obj != null)
			{
				struct2 = default(Struct1);
				struct2 = struct2;
			}
		}
		finally
		{
			try
			{
				try
				{
					@class = @class;
				}
				catch
				{
					class15 = class15;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			goto IL_1cf2;
		}
		IL_13f0:
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj != null);
			}
			goto IL_1433;
		}
	}

	unsafe static void smethod_4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		while (obj != null)
		{
			@class = @class;
			Class7 class2 = @class;
			bindingFlags = bindingFlags;
			array = (MethodBase[])(object)Class5.Default;
			MethodBase[] methodBase_ = array;
			ref object[] object_ = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
			Class7 class3 = @class;
			obj = null;
			object object_2 = obj;
			Type type_ = (Type)(object)Class5.Default;
			Class7 class4 = @class;
			object object_3 = obj;
			Class7 class5 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_ = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null);
			array2 = (Type[])(object)Class5.Default;
			Type[] type_2 = array2;
			array3 = array3;
			type = (Type)(object)class5.e(bindingFlags_, methodBase_2, type_2, array3);
			_ = (Class5)(object)class2.j(default(BindingFlags), methodBase_, ref object_, parameterModifier_, null, null, out *(object*)((Class7)null).e((BindingFlags)class3.t(object_2, type_, (CultureInfo)class4.t(object_3, type, (CultureInfo)(object)Class5.Default)), (MethodBase[])null, array2, (ParameterModifier[])(object)Class5.Default));
			Class7 obj2 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_2 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
			reference = ref reference;
			ref object[] object_4 = ref reference;
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
			cultureInfo = (CultureInfo)((Class7)null).t(obj, (Type)null, cultureInfo);
			CultureInfo cultureInfo_ = cultureInfo;
			array4 = null;
			_ = (GClass1)(object)obj2.j(bindingFlags_2, methodBase_3, ref object_4, parameterModifier_2, cultureInfo_, array4, out *(object*)null);
			class6 = class6;
			class6 = null;
			_ = (Qk7)(object)Class5.Default;
		}
		Class2 class7;
		do
		{
			class7 = null;
			class7 = null;
		}
		while ((object)Class5.Default != null);
		Class6 class9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class8);
		while (obj != null)
		{
			gClass = null;
			gClass = gClass;
			class8 = class8;
			class8 = class8;
			_ = (Qk7)(object)Class5.Default;
			class9 = (Class6)(object)Class5.Default;
			class9 = class9;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class10);
		try
		{
			_ = (Class7)(object)Class5.Default;
			gClass = (GClass2)((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)null)).t(Class5.Default, (Type)(object)Class5.Default, null);
		}
		catch
		{
			do
			{
				class10 = class10;
				class10 = class10;
			}
			while (obj != null || obj != null);
		}
		nuint num = num / checked(num * num);
		num = default(UIntPtr);
		nuint num2;
		checked
		{
			num2 = (unchecked((nuint)default(UIntPtr)) * num - num) * unchecked((nuint)(UIntPtr)Class5.Default);
		}
		UIntPtr num3 = (UIntPtr)Class5.Default;
		Class7 obj4 = (Class7)@class.t(null, null, cultureInfo);
		object object_5 = ((Class7)(object)Class5.Default).e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
		Class7 class11 = @class;
		BindingFlags bindingFlags_3 = bindingFlags;
		FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class12);
		Qk7 qk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		if (checked(num2 - unchecked((nuint)num3) * unchecked((nuint)(UIntPtr)obj4.t(object_5, (Type)(object)((Class7)(object)class11.t(bindingFlags_3, fieldInfo_, obj, cultureInfo)).W(bindingFlags, (PropertyInfo[])((Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)Class5.Default)).t(null, type, null), (Type)(object)Class5.Default, array2, null), cultureInfo))) == 0)
		{
			do
			{
				BindingFlags bindingFlags_4 = bindingFlags;
				MethodBase[] methodBase_4 = array;
				ref object[] object_6 = ref reference;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])((Class7)null).t(obj, (Type)null, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array, array2, (ParameterModifier[])(object)Class5.Default)), type, null, null);
				string[] string_ = array4;
				object_7 = ref *(object*)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
				if ((UIntPtr)((Class7)null).j(bindingFlags_4, methodBase_4, ref object_6, (ParameterModifier[])null, cultureInfo_2, string_, out object_7) != (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					gClass2 = null;
					gClass2 = gClass2;
				}
				else
				{
					_ = (Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array4, out object_7);
					qk = (Qk7)(object)Class5.Default;
					qk = null;
					class12 = null;
					class12 = class12;
				}
			}
			while ((object)Class5.Default != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
		}
		_ = (Class10)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		class8 = class8;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class12 = null;
					_ = (GClass3)@class.t(null, type, cultureInfo);
				}
				while (obj != null);
			}
			finally
			{
				class6 = class6;
				goto IL_0523;
			}
		}
		goto IL_0523;
		IL_42d5:
		_ = (Class7)(object)Class5.Default;
		@class = @class;
		_ = (Class2)(object)Class5.Default;
		GClass3 gClass3 = gClass3;
		_ = (GClass0)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, obj, cultureInfo), ref reference, (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)@class.e(default(BindingFlags), array, (Type[])(object)Class5.Default, array3));
		Class8 class13;
		try
		{
			class13 = (Class8)(object)@class.t((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), fieldInfo_, obj, cultureInfo);
		}
		finally
		{
			Class7 class14 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class14.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			else
			{
				class13 = (Class8)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
			}
			goto IL_4428;
		}
		IL_1093:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (num == 0 && num == 0 && num == 0)
		{
			_ = (Class6)(object)@class.t(bindingFlags, fieldInfo_, obj, null);
			@struct = @struct;
			class12 = class12;
		}
		try
		{
			Class7 class15 = @class;
			Class7 obj5 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_5 = bindingFlags;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_6 = (BindingFlags)((Class7)(object)obj5.t(bindingFlags_5, (FieldInfo[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo), obj, (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
			Class7 class16 = @class;
			BindingFlags bindingFlags_7 = bindingFlags;
			MethodBase[] methodBase_5 = array;
			Class7 class17 = @class;
			bindingFlags = default(BindingFlags);
			qk = (Qk7)(object)((Class7)(object)class15.t(bindingFlags_6, null, class16.e(bindingFlags_7, methodBase_5, (Type[])(object)class17.W(bindingFlags, null, type, array2, array3), null), (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, Class5.Default, cultureInfo);
		}
		catch
		{
			if (num == 0)
			{
				if ((UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)((Class7)null).t(obj, type, (CultureInfo)null)).t(bindingFlags, fieldInfo_, Class5.Default, null), null, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					class12 = (Class0)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo);
				}
			}
			else
			{
				do
				{
					_ = (Class10)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.t(bindingFlags, null, @class.t(bindingFlags, null, null, null), null), array2, array3);
				}
				while (obj != null);
			}
		}
		while (obj != null)
		{
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)@class.e(bindingFlags, array, null, array3);
			class12 = null;
			class12 = class12;
		}
		while (obj != null)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		try
		{
			Class7 obj7 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
			Class7 obj8 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Type type_3 = (Type)(object)obj8.j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, null), ref reference, null, cultureInfo, null, out object_7);
			Class7 class18 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)obj7.W(bindingFlags_8, propertyInfo_, type_3, (Type[])(object)class18.j(bindingFlags, array, ref reference, array3, null, array4, out *(object*)null), null);
		}
		finally
		{
			try
			{
				while ((object)@class.e((BindingFlags)((Class7)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)(object)Class5.Default)).t(obj, type, cultureInfo), array, null, (ParameterModifier[])(object)Class5.Default) != null)
				{
					class6 = class6;
				}
			}
			finally
			{
				object object_8 = @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default));
				Class7 class19 = @class;
				Class7 obj9 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(object_8, (Type)(object)class19.e((BindingFlags)((Class7)null).j((BindingFlags)obj9.t(bindingFlags, fieldInfo_, null, cultureInfo), (MethodBase[])@class.t(null, type, cultureInfo), ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null), cultureInfo, (string[])null, out object_7), null, array2, array3), cultureInfo) == (UIntPtr)(nuint)0u)
				{
					class8 = (Class10)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, cultureInfo));
				}
				goto IL_1543;
			}
		}
		IL_1ff0:
		class13 = (Class8)@class.t(obj, type, cultureInfo);
		_ = (GClass3)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if ((UIntPtr)((Class7)null).t((object)null, type, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)@class.t(obj, null, null);
				}
			}
		}
		else
		{
			_ = (Class7)(object)Class5.Default;
		}
		gClass2 = (GClass0)(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out object_7);
		_ = (Class0)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo);
		_ = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, array2, null))).e(bindingFlags, null, array2, array3);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					continue;
				}
			}
		}
		else
		{
			do
			{
				Class7 class20;
				checked
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - (num - num) != 0)
					{
						_ = (Struct1)Class5.Default;
						continue;
					}
					class20 = @class;
					bindingFlags = default(BindingFlags);
				}
				_ = (Class5)(object)((Class7)null).t((BindingFlags)class20.t(bindingFlags, null, ((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3), cultureInfo), (FieldInfo[])null, obj, cultureInfo);
			}
			while (obj != null);
		}
		if (checked(num - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					_ = (Struct2)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array3);
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
					_ = (Class8)(object)@class.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default);
				}
			}
			else
			{
				try
				{
					_ = (_003CModule_003E)(object)@class.e((BindingFlags)((Class7)(object)@class.W(bindingFlags, null, type, array2, array3)).e(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)@class.t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default), null, type, null, array3), null, null), array, array2, null);
					class8 = (Class10)(object)Class5.Default;
					_ = (Class5)(object)@class.W(bindingFlags, null, null, array2, array3);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		else
		{
			BindingFlags bindingFlags_9 = (BindingFlags)Class5.Default;
			Class7 obj11 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)((Class7)null).j(bindingFlags_9, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)obj11.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, null, out *(object*)Class5.Default), cultureInfo, (string[])(object)Class5.Default, out object_7);
		}
		try
		{
			if (num != 0)
			{
				while (obj != null)
				{
					class9 = null;
					_ = (Class7)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
					class6 = class6;
				}
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num * num * num) == 0)
			{
				do
				{
					gClass = gClass;
				}
				while (obj != null);
			}
			goto IL_23bd;
		}
		IL_47c6:
		class9 = class9;
		do
		{
			try
			{
				if (num == 0)
				{
					class12 = class12;
				}
				else
				{
					Class7 class21 = @class;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo);
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class21.t(default(BindingFlags), fieldInfo_2, ((Class7)(object)((Class7)(object)class22.t(bindingFlags, null, null, cultureInfo)).W(bindingFlags, null, type, array2, array3)).t(obj, null, cultureInfo), cultureInfo);
				}
			}
			catch
			{
				_ = (GClass1)(object)Class5.Default;
			}
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).e(bindingFlags, array, (Type[])null, array3) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class33);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		try
		{
			try
			{
				@struct = @struct;
			}
			finally
			{
				while (true)
				{
					Class7 class23 = @class;
					BindingFlags bindingFlags_10 = bindingFlags;
					object object_9 = ((Class7)(object)@class.e(bindingFlags, null, null, null)).t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default), (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null));
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj13 = (Class7)(object)class23.t(bindingFlags_10, fieldInfo_, object_9, (CultureInfo)(object)class24.t(bindingFlags, null, obj, (CultureInfo)(object)@class.e(bindingFlags, null, null, array3)));
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)(object)obj13.t(bindingFlags, fieldInfo_, obj, null)).e(bindingFlags, array, null, array3) != null)
					{
						class10 = class10;
						@struct = @struct;
						_ = (Qk7)(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, null, null, array4, out *(object*)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo))).W(bindingFlags, array5, type, null, array3);
						_ = (GClass3)(object)Class5.Default;
						continue;
					}
					break;
				}
				goto end_IL_48ab;
			}
			end_IL_48ab:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					_ = (Class7)(object)Class5.Default;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					Class7 class25 = @class;
					BindingFlags bindingFlags_11 = bindingFlags;
					MethodBase[] methodBase_6 = array;
					ref object[] object_10 = ref reference;
					ParameterModifier[] parameterModifier_3 = array3;
					Class7 obj14 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_12 = (BindingFlags)((Class7)(object)@class.W((BindingFlags)Class5.Default, array5, null, null, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array, (Type[])(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo), array3);
					BindingFlags bindingFlags_13 = bindingFlags;
					MethodBase[] methodBase_7 = array;
					Class7 class26 = @class;
					object object_11 = obj;
					Class7 class27 = @class;
					object object_12 = Class5.Default;
					Class7 class28 = @class;
					BindingFlags bindingFlags_14 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_8 = array;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
					Class7 class29 = @class;
					object object_13 = obj;
					bindingFlags = default(BindingFlags);
					Class7 obj15 = (Class7)(object)((Class7)null).e(bindingFlags_13, methodBase_7, (Type[])class26.t(object_11, (Type)class27.t(object_12, (Type)(object)class28.j(bindingFlags_14, methodBase_8, ref *(object[]*)null, parameterModifier_4, (CultureInfo)(object)((Class7)null).W((BindingFlags)class29.t(object_13, (Type)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null), null), array5, type, array2, (ParameterModifier[])null), null, out *(object*)((Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)@class.W((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null), null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3), array3, cultureInfo, array4, out *(object*)null)).e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default)), cultureInfo), cultureInfo), array3);
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)obj15.j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out object_7);
					Type type_4 = type;
					Class7 obj16 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_9 = array;
					ref object[] object_14 = ref reference;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					Class7 class30 = @class;
					BindingFlags bindingFlags_16 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj17 = (Class7)(object)obj14.W(bindingFlags_12, propertyInfo_2, type_4, null, (ParameterModifier[])(object)obj16.j(bindingFlags_15, methodBase_9, ref object_14, parameterModifier_5, (CultureInfo)(object)class30.W(bindingFlags_16, propertyInfo_3, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array2, array3), array2, array3), array4, out object_7));
					BindingFlags bindingFlags_17 = bindingFlags;
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_3 = (CultureInfo)((Class7)null).t((object)obj17.t((BindingFlags)((Class7)null).W(bindingFlags_17, (PropertyInfo[])null, (Type)(object)class31.t((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo), null, obj, null), (Type[])(object)Class5.Default, array3), (FieldInfo[])@class.t(obj, null, cultureInfo), null, null), type, cultureInfo);
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class25.j(bindingFlags_11, methodBase_6, ref object_10, parameterModifier_3, cultureInfo_3, (string[])(object)class32.t(bindingFlags, null, obj, cultureInfo), out object_7);
				}
				catch
				{
					class33 = null;
				}
			}
		}
		try
		{
			while ((object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null) != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class10 = class10;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array3, (CultureInfo)null, array4, out object_7);
					Type type_5 = type;
					Type[] type_6 = array2;
					BindingFlags bindingFlags_19 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array5;
					Type[] type_7 = array2;
					Class7 class34 = @class;
					bindingFlags = default(BindingFlags);
					class10 = (Class5)(object)((Class7)null).W(bindingFlags_18, propertyInfo_4, type_5, type_6, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_19, propertyInfo_5, (Type)null, type_7, (ParameterModifier[])(object)class34.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo), null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, null, null, out *(object*)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, (CultureInfo)null)))));
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			_ = (GClass1)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			return;
		}
		finally
		{
			@class = @class;
			return;
		}
		IL_08e2:
		_ = (Class7)(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array3, cultureInfo, array4, out object_7)).t((BindingFlags)Class5.Default, fieldInfo_, null, (CultureInfo)(object)Class5.Default);
		gClass = gClass;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)@class.j(default(BindingFlags), array, ref *(object[]*)null, array3, cultureInfo, null, out object_7) == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			catch
			{
				class33 = (Class9)(object)Class5.Default;
				class33 = class33;
			}
		}
		UIntPtr num4 = (UIntPtr)Class5.Default;
		UIntPtr num5 = num;
		num = default(UIntPtr);
		UIntPtr num6 = num;
		Class7 class35 = @class;
		BindingFlags bindingFlags_20 = (BindingFlags)((Class7)(object)Class5.Default).t(((Class7)null).e((BindingFlags)Class5.Default, array, array2, array3), (Type)(object)@class.j(default(BindingFlags), array, ref reference, array3, cultureInfo, array4, out *(object*)Class5.Default), null);
		MethodBase[] methodBase_10 = array;
		ref object[] object_15 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_6 = array3;
		Class7 class36 = @class;
		bindingFlags = default(BindingFlags);
		nuint num7;
		UIntPtr num8;
		checked
		{
			num7 = unchecked((nuint)num6) + unchecked((nuint)(UIntPtr)class35.j(bindingFlags_20, methodBase_10, ref object_15, parameterModifier_6, (CultureInfo)(object)class36.e(bindingFlags, array, array2, array3), (string[])(object)Class5.Default, out *(object*)null));
			num8 = num;
			num = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		if ((nuint)num4 / checked(unchecked((nuint)num5) + unchecked((nuint)default(UIntPtr)) * (num7 + unchecked((nuint)num8 / (checked(num * unchecked((nuint)(UIntPtr)Class5.Default)) / checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo)) - unchecked((nuint)(UIntPtr)Class5.Default) - num))))) == 0)
		{
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + num == 0)
				{
					try
					{
						_ = (Class7)(object)Class5.Default;
					}
					catch
					{
						gClass4 = gClass4;
						gClass4 = null;
					}
				}
			}
		}
		if ((UIntPtr)((Class7)(object)@class.W((BindingFlags)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_7), array5, type, array2, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out *(object*)null) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				@class = @class;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Class0)(object)@class.e((BindingFlags)((Class7)null).t(obj, type, cultureInfo), array, array2, (ParameterModifier[])(object)@class.j((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.t(obj, type, (CultureInfo)(object)@class.e(bindingFlags, array, array2, array3)), cultureInfo), (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, null), null, null, (Type[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), fieldInfo_, obj, null), null), ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out object_7));
			}
		}
		catch
		{
			while (obj != null)
			{
				do
				{
					Struct1 obj24 = (Struct1)Class5.Default;
					struct2 = (Struct1)Class5.Default;
					struct2 = obj24;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					class8 = (Class10)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		while (true)
		{
			if ((object)@class.t(default(BindingFlags), fieldInfo_, obj, null) != null)
			{
				nuint num9 = (nuint)(UIntPtr)@class.t(obj, type, cultureInfo) / num / (nuint)(UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if (checked(num9 - num) == 0)
				{
					class6 = class6;
				}
				else
				{
					_ = (GClass1)@class.t(obj, null, cultureInfo);
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		class9 = null;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)@class.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array5, null, array2, (ParameterModifier[])(object)Class5.Default), array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null);
		_ = (GClass2)(object)Class5.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, null)) - num == 0)
			{
				if (num == 0)
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) - num == 0)
					{
						@struct = @struct;
						@struct = @struct;
					}
					else
					{
						_ = (Struct2)unchecked(((Class7)null).t((BindingFlags)((Class7)null).t(obj, (Type)null, cultureInfo), (FieldInfo[])null, (object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array5, type, array2, array3), ((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3), cultureInfo), (CultureInfo)null));
					}
				}
				goto IL_1093;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (GClass0)(object)@class.W(bindingFlags, null, type, array2, null);
				_ = (Qk7)(object)@class.t((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, array5, null, array2, array3)).j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), obj, cultureInfo)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array3), null, obj, null);
				_003CModule_003E = _003CModule_003E;
				_ = (Struct1)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
			}
		}
		finally
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			finally
			{
				_ = (Qk7)(object)@class.e(bindingFlags, array, array2, null);
				goto IL_1093;
			}
		}
		IL_2703:
		while ((object)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, array2, array3) != null)
		{
			do
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					_ = (Struct1)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)((Class7)null).W((BindingFlags)Class5.Default, array5, type, array2, (ParameterModifier[])null), (string[])(object)Class5.Default, out object_7);
					continue;
				}
			}
			while (obj != null);
		}
		while ((object)((Class7)null).t((BindingFlags)((Class7)(object)@class.e(bindingFlags, array, null, null)).t(Class5.Default, null, (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_, obj, null)), (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo) != null)
		{
			_ = (Class10)(object)Class5.Default;
		}
		while (true)
		{
			Class7 class37 = @class;
			BindingFlags bindingFlags_21 = bindingFlags;
			MethodBase[] methodBase_11 = array;
			Class7 obj26 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_22 = bindingFlags;
			PropertyInfo[] propertyInfo_6 = array5;
			Type type_8 = (Type)(object)Class5.Default;
			BindingFlags bindingFlags_23 = bindingFlags;
			Class7 class38 = @class;
			BindingFlags bindingFlags_24 = (BindingFlags)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, array3);
			ref object[] object_16 = ref reference;
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj27 = (Class7)(object)class37.e(bindingFlags_21, methodBase_11, (Type[])(object)obj26.W(bindingFlags_22, propertyInfo_6, type_8, (Type[])(object)((Class7)null).t(bindingFlags_23, fieldInfo_, (object)class38.j(bindingFlags_24, null, ref object_16, (ParameterModifier[])(object)class39.j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e((BindingFlags)@class.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array2, null), array, array2, array3), array, (Type[])null, array3), type, array2, array3), cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)@class.e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default), array3, cultureInfo, array4, out object_7), out object_7), cultureInfo, array4, out *(object*)Class5.Default), (CultureInfo)null), null), array3);
			bindingFlags = default(BindingFlags);
			if ((object)obj27.W(bindingFlags, array5, null, array2, null) == null)
			{
				break;
			}
			while (obj != null)
			{
				_ = (Class10)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, array5, (Type)(object)((Class7)null).t((BindingFlags)((Class7)null).t(obj, type, cultureInfo), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null), null, null), obj, (CultureInfo)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, null));
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class40.W(bindingFlags, null, (Type)(object)Class5.Default, array2, array3);
				gClass2 = (GClass0)(object)Class5.Default;
			}
		}
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, cultureInfo);
					class9 = (Class6)(object)@class.e(default(BindingFlags), array, (Type[])(object)@class.e((BindingFlags)Class5.Default, null, array2, array3), null);
				}
			}
			finally
			{
				qk = qk;
				goto IL_2b1d;
			}
		}
		goto IL_2b1d;
		IL_3ff4:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Struct1)Class5.Default;
				_003CModule_003E = null;
			}
			finally
			{
				_ = (Class8)@class.t(obj, null, (CultureInfo)(object)Class5.Default);
				goto IL_4036;
			}
		}
		goto IL_4036;
		IL_36c0:
		if (num == 0)
		{
			_ = (Class5)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
		}
		try
		{
			do
			{
				_ = (Class2)(object)Class5.Default;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			_ = (Class2)(object)@class.j((BindingFlags)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_7), null, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
			gClass = null;
			goto IL_376b;
		}
		IL_376b:
		class8 = class8;
		do
		{
			Class7 class41 = @class;
			Class7 class42 = @class;
			BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_12 = (MethodBase[])(object)((Class7)null).j(default(BindingFlags), array, ref reference, array3, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), array4, out object_7);
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			ref object[] object_17 = ref *(object[]*)class43.W(bindingFlags, array5, type, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, null, out *(object*)null), obj, null), null);
			BindingFlags bindingFlags_26 = bindingFlags;
			MethodBase[] methodBase_13 = array;
			Class7 class44 = @class;
			BindingFlags bindingFlags_27 = bindingFlags;
			bindingFlags = default(BindingFlags);
			CultureInfo cultureInfo_4 = (CultureInfo)(object)((Class7)null).e(bindingFlags_26, methodBase_13, (Type[])((Class7)(object)class44.e(bindingFlags_27, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, null, array2, array3), out object_7), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])@class.t(null, type, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out object_7), (ParameterModifier[])null)), (ParameterModifier[])(object)Class5.Default))), (Type[])(object)@class.W(bindingFlags, array5, null, array2, array3), array3)).t(obj, type, cultureInfo), (ParameterModifier[])(object)@class.W(bindingFlags, array5, null, array2, array3));
			string[] string_2 = array4;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_28 = (BindingFlags)class42.j(bindingFlags_25, methodBase_12, ref object_17, null, cultureInfo_4, string_2, out *(object*)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])null, array3));
			MethodBase[] methodBase_14 = array;
			Type[] type_9 = array2;
			Class7 class45 = @class;
			BindingFlags bindingFlags_29 = bindingFlags;
			MethodBase[] methodBase_15 = array;
			Type[] type_10 = array2;
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			class13 = (Class8)(object)class41.e(bindingFlags_28, methodBase_14, type_9, (ParameterModifier[])(object)class45.e(bindingFlags_29, methodBase_15, type_10, (ParameterModifier[])(object)class46.e(bindingFlags, array, array2, null)));
		}
		while (obj != null);
		_003CModule_003E = _003CModule_003E;
		if (num == 0 && num == 0)
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		try
		{
			if (num == 0)
			{
				try
				{
					_ = (Class4)(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out object_7);
					_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, null), array2, array3);
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					_ = (Class4)(object)@class.W((BindingFlags)Class5.Default, array5, type, array2, array3);
					goto end_IL_3a90;
				}
			}
			end_IL_3a90:;
		}
		catch
		{
			try
			{
			}
			finally
			{
				while (obj != null)
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Qk7)(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)Class5.Default);
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_16 = array;
					Type[] type_11 = array2;
					BindingFlags bindingFlags_31 = bindingFlags;
					MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
					Class7 class47 = @class;
					BindingFlags bindingFlags_32 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).e(bindingFlags_30, methodBase_16, type_11, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_31, methodBase_17, ref *(object[]*)((Class7)(object)class47.W(bindingFlags_32, propertyInfo_7, (Type)(object)class48.W(bindingFlags, array5, (Type)(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null), (Type[])(object)Class5.Default, null), (Type[])((Class7)null).t((object)null, type, cultureInfo), (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out *(object*)null), array3, cultureInfo, array4, out *(object*)null));
				}
				goto end_IL_3b4a;
			}
			end_IL_3b4a:;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class8 = class8;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class49.W(bindingFlags, array5, type, array2, array3);
				}
				catch
				{
					@class = @class;
				}
			}
			else
			{
				do
				{
					gClass4 = gClass4;
				}
				while (obj != null);
			}
			goto IL_3d20;
		}
		IL_3d20:
		_ = (Struct1)Class5.Default;
		@struct = @struct;
		_ = (Class6)(object)Class5.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class9 = null;
				_ = (Class2)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)null), cultureInfo);
				_ = (Class8)(object)Class5.Default;
				@class = @class;
			}
			else
			{
				Class7 class50 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class50.t(bindingFlags, null, Class5.Default, cultureInfo);
				class10 = class10;
				_ = (Class7)(object)Class5.Default;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class13 = class13;
		}
		else
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = (Struct2)Class5.Default;
					Class7 class51 = @class;
					BindingFlags bindingFlags_33 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class51.W(bindingFlags_33, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out object_7), array3), (Type)(object)Class5.Default, array2, null);
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					class13 = null;
					goto end_IL_3ed1;
				}
				end_IL_3ed1:;
			}
			catch
			{
				try
				{
					class12 = class12;
				}
				catch
				{
					class7 = class7;
				}
			}
			goto IL_3f02;
		}
		IL_2ea8:
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		catch
		{
			try
			{
				if ((nuint)(UIntPtr)Class5.Default / (checked(unchecked((nuint)(UIntPtr)Class5.Default) - num) / unchecked((nuint)default(UIntPtr))) == 0)
				{
					class10 = null;
				}
				else
				{
					_ = (GClass2)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, null);
					class13 = class13;
					_ = (GClass2)(object)Class5.Default;
				}
			}
			finally
			{
				@class = @class;
				goto end_IL_2eb6;
			}
			end_IL_2eb6:;
		}
		_ = (GClass3)(object)Class5.Default;
		try
		{
			num = default(UIntPtr);
			if (num / num == 0)
			{
				class9 = class9;
				class6 = (Class4)(object)Class5.Default;
				class9 = null;
			}
		}
		catch
		{
			class12 = (Class0)(object)Class5.Default;
		}
		finally
		{
			Class7 obj34 = (Class7)(object)Class5.Default;
			Type type_12 = (Type)(object)((Class7)null).W((BindingFlags)@class.t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array4, out object_7), fieldInfo_, Class5.Default, null), array5, type, (Type[])(object)Class5.Default, array3);
			Class7 class52 = @class;
			BindingFlags bindingFlags_34 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array4, out *(object*)null);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)obj34.t(null, type_12, (CultureInfo)(object)class52.t(bindingFlags_34, fieldInfo_3, ((Class7)null).W(bindingFlags, array5, type, array2, array3), cultureInfo));
			goto IL_306e;
		}
		IL_4428:
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class0)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, null, out object_7);
				}
			}
			finally
			{
				try
				{
					_ = (Class5)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo);
				}
				finally
				{
					class13 = class13;
					goto end_IL_4429;
				}
			}
			end_IL_4429:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Struct2)@class.t(obj, type, (CultureInfo)((Class7)null).t((object)null, (Type)null, (CultureInfo)null));
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_449d;
				}
				end_IL_449d:;
			}
			finally
			{
				try
				{
					class7 = (Class2)(object)Class5.Default;
				}
				finally
				{
					@struct = (Struct2)Class5.Default;
					goto end_IL_449c;
				}
			}
			end_IL_449c:;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)@class.t(obj, type, null);
			}
			else
			{
				class13 = (Class8)@class.t(obj, type, (CultureInfo)(object)@class.t((BindingFlags)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])null, out object_7), null), null, @class.j(bindingFlags, array, ref reference, array3, null, array4, out object_7), (CultureInfo)(object)Class5.Default));
			}
		}
		else
		{
			gClass = gClass;
			class33 = class33;
			gClass = gClass;
		}
		try
		{
			nuint num10 = num;
			UIntPtr num11 = (UIntPtr)Class5.Default;
			bindingFlags = default(BindingFlags);
			if (checked(num10 + unchecked((nuint)num11) * unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default))) == 0)
			{
				num = default(UIntPtr);
				nuint num12 = num;
				UIntPtr num13 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				nuint num14 = num12 / checked(unchecked((nuint)num13) * num);
				num = default(UIntPtr);
				if (checked(num14 * num) == 0)
				{
					gClass = (GClass2)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array5, type, array2, null), ref reference, null, cultureInfo, array4, out *(object*)Class5.Default);
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
					_ = (Class9)(object)@class.W(bindingFlags, array5, type, null, null);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		finally
		{
			while (true)
			{
				if ((object)@class.j((BindingFlags)@class.j((BindingFlags)@class.t(null, null, cultureInfo), array, ref reference, null, cultureInfo, (string[])@class.t(@class.t(obj, type, (CultureInfo)(object)Class5.Default), type, cultureInfo), out object_7), null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out object_7) != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
			goto IL_47c6;
		}
		IL_23bd:
		class10 = class10;
		try
		{
			try
			{
				_ = Class5.Default;
			}
			catch
			{
				@class = (Class7)(object)Class5.Default;
			}
			finally
			{
				if (num == 0)
				{
					Class7 class53 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					ref object[] object_18 = ref reference;
					ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)Class5.Default;
					Class7 obj38 = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3);
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_5 = (CultureInfo)(object)obj38.t(bindingFlags, fieldInfo_, obj, null);
					Class7 class54 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class53.j(bindingFlags_35, null, ref object_18, parameterModifier_7, cultureInfo_5, (string[])(object)class54.t(bindingFlags, fieldInfo_, null, cultureInfo), out object_7);
				}
				goto end_IL_23c5;
			}
			end_IL_23c5:;
		}
		catch
		{
			while (obj != null)
			{
				UIntPtr num15 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if ((nuint)num15 / num == 0)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		while (true)
		{
			if (obj != null)
			{
				try
				{
					class33 = null;
				}
				catch
				{
					_ = Class5.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
				_ = (_003CModule_003E)(object)Class5.Default;
				qk = (Qk7)(object)@class.e(bindingFlags, array, array2, array3);
			}
			else
			{
				class13 = null;
			}
		}
		while ((object)Class5.Default != null);
		_ = (Class7)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		try
		{
			Class7 class55 = @class;
			Class7 obj41 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj42 = (Class7)class55.t(obj41.W(bindingFlags, array5, type, array2, (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)((Class7)@class.t(obj, null, (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default));
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)obj42.t(bindingFlags, null, obj, cultureInfo);
		}
		finally
		{
			try
			{
				@class = null;
			}
			finally
			{
				do
				{
					_ = (Class10)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])null, cultureInfo, array4, out object_7), ref *(object[]*)null, null, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null), (string[])(object)Class5.Default, out object_7);
				}
				while (obj != null);
				goto IL_2703;
			}
		}
		IL_0523:
		BindingFlags bindingFlags_36 = bindingFlags;
		array5 = array5;
		if ((UIntPtr)((Class7)null).W(bindingFlags_36, array5, (Type)null, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_, obj, null)) == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		UIntPtr num16 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num16) - (num - num)) == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
				Class7 class56 = @class;
				Class7 class57 = @class;
				object object_19 = Class5.Default;
				Class7 class58 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_37 = (BindingFlags)class58.e((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo), array2, array3)), array, array2, null);
				PropertyInfo[] propertyInfo_8 = array5;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class56.t((BindingFlags)class57.t(object_19, (Type)(object)((Class7)null).W(bindingFlags_37, propertyInfo_8, (Type)null, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), array3), cultureInfo), null, obj, (CultureInfo)(object)Class5.Default);
				class6 = class6;
			}
		}
		catch
		{
			try
			{
				class10 = class10;
			}
			finally
			{
				_ = (Struct1)Class5.Default;
				goto end_IL_06b1;
			}
			end_IL_06b1:;
		}
		num = default(UIntPtr);
		if (checked(num - num) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)@class.t((BindingFlags)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, null, cultureInfo)), (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
			}
			else
			{
				_ = (GClass3)(object)@class.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default);
			}
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num / checked(num - unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					gClass = gClass;
				}
				finally
				{
					Class7 class59 = @class;
					Type type_13 = type;
					Class7 obj44 = (Class7)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])null, array3);
					BindingFlags bindingFlags_38 = bindingFlags;
					Class7 obj45 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class7 = (Class2)class59.t(null, type_13, (CultureInfo)(object)obj44.t(bindingFlags_38, fieldInfo_, obj45.j(bindingFlags, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), cultureInfo));
					class8 = (Class10)(object)Class5.Default;
					@class = (Class7)@class.t(obj, type, cultureInfo);
					goto end_IL_079e;
				}
			}
			end_IL_079e:;
		}
		finally
		{
			gClass3 = (GClass3)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj, null), cultureInfo, null, out *(object*)null);
			gClass3 = null;
			goto IL_08e2;
		}
		IL_18c7:
		do
		{
			_ = (Class7)(object)Class5.Default;
			Class7 class60 = @class;
			BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_9 = array5;
			Class7 class61 = @class;
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_40 = (BindingFlags)class62.W(bindingFlags, array5, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)@class.t((BindingFlags)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, cultureInfo), array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out object_7), null, null, null));
			BindingFlags bindingFlags_41 = bindingFlags;
			Class7 class63 = @class;
			BindingFlags bindingFlags_42 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_18 = (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)@class.e(default(BindingFlags), array, null, array3));
			Type[] type_14 = array2;
			Class7 class64 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)class60.W(bindingFlags_39, propertyInfo_9, (Type)(object)class61.t(bindingFlags_40, (FieldInfo[])(object)((Class7)null).W(bindingFlags_41, (PropertyInfo[])(object)class63.e(bindingFlags_42, methodBase_18, type_14, (ParameterModifier[])(object)class64.t(bindingFlags, null, Class5.Default, null)), (Type)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), (Type[])null, (ParameterModifier[])(object)((Class7)(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, cultureInfo, array4, out object_7)).t(bindingFlags, null, obj, cultureInfo)).W(bindingFlags, null, (Type)(object)@class.e((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null), null, array2, (ParameterModifier[])(object)Class5.Default), array2, null)), obj, (CultureInfo)(object)Class5.Default), array2, array3);
			gClass2 = gClass2;
			gClass4 = gClass4;
		}
		while (obj != null);
		_003CModule_003E = _003CModule_003E;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			@struct = @struct;
		}
		else
		{
			try
			{
				struct2 = struct2;
			}
			catch
			{
				class12 = (Class0)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
			}
		}
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					@class = @class;
				}
			}
			catch
			{
				_ = (Class7)@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
			}
		}
		class6 = class6;
		gClass2 = gClass2;
		num = default(UIntPtr);
		if (num / num == 0)
		{
			_ = (Class8)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(null, null, cultureInfo), null, obj, (CultureInfo)(object)Class5.Default);
			goto IL_1d19;
		}
		try
		{
			@struct = @struct;
			_ = (_003CModule_003E)(object)((Class7)(object)@class.W(bindingFlags, array5, type, null, null)).j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_19 = (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, obj, null);
			ref object[] object_20 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_8 = array3;
			CultureInfo cultureInfo_6 = (CultureInfo)(object)Class5.Default;
			Class7 class65 = @class;
			BindingFlags bindingFlags_44 = bindingFlags;
			ref object[] object_21 = ref reference;
			ParameterModifier[] parameterModifier_9 = array3;
			Class7 obj48 = (Class7)(object)Class5.Default;
			PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)Class5.Default;
			Type[] type_15 = array2;
			bindingFlags = default(BindingFlags);
			class13 = (Class8)(object)((Class7)null).j(bindingFlags_43, methodBase_19, ref object_20, parameterModifier_8, cultureInfo_6, (string[])(object)class65.j(bindingFlags_44, null, ref object_21, parameterModifier_9, null, null, out *(object*)obj48.W(default(BindingFlags), propertyInfo_10, null, type_15, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo))), out *(object*)null);
			class13 = null;
			goto IL_1d19;
		}
		IL_4036:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class33 = (Class9)(object)Class5.Default;
		}
		_ = (Struct2)Class5.Default;
		do
		{
			_ = (Class6)(object)Class5.Default;
		}
		while ((object)Class5.Default != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((nuint)(UIntPtr)@class.j(bindingFlags, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, null, out *(object*)null) / (nuint)(UIntPtr)Class5.Default == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			else
			{
				gClass2 = null;
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Class5)(object)((Class7)null).W((BindingFlags)((Class7)null).t(obj, (Type)null, (CultureInfo)null), array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					continue;
				}
			}
		}
		try
		{
			do
			{
				try
				{
					class10 = null;
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				Class7 obj49 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)obj49.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
				class9 = class9;
				Class7 class66 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_45 = bindingFlags;
				Class7 class67 = @class;
				BindingFlags bindingFlags_46 = (BindingFlags)((Class7)null).j((BindingFlags)@class.t(obj, type, cultureInfo), array, ref reference, array3, (CultureInfo)null, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, array3), out *(object*)null);
				Class7 obj50 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo);
				BindingFlags bindingFlags_47 = bindingFlags;
				ref object[] object_22 = ref *(object[]*)Class5.Default;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class66.t(bindingFlags_45, (FieldInfo[])((Class7)(object)class67.j(bindingFlags_46, (MethodBase[])(object)obj50.j(bindingFlags_47, null, ref object_22, (ParameterModifier[])(object)class68.t(bindingFlags, null, null, null), null, array4, out object_7), ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out object_7)).t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), obj, (CultureInfo)(object)Class5.Default);
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				struct2 = struct2;
			}
			goto IL_42d5;
		}
		IL_351f:
		_ = (Class7)(object)Class5.Default;
		_ = (Class5)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && checked(num - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			do
			{
				Class7 class69 = @class;
				Class7 class70 = @class;
				BindingFlags bindingFlags_48 = bindingFlags;
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				@struct = (Struct2)class69.e((BindingFlags)class70.t(bindingFlags_48, fieldInfo_, class71.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), cultureInfo), (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])null), array2, array3);
			}
			while (((Class7)null).t(obj, (Type)null, cultureInfo) != null);
		}
		_ = (GClass1)(object)Class5.Default;
		try
		{
			while (obj != null)
			{
				_ = (Struct2)Class5.Default;
				_ = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array4, out object_7);
				struct2 = default(Struct1);
				struct2 = struct2;
			}
		}
		finally
		{
			_ = (Struct2)@class.W((BindingFlags)Class5.Default, array5, type, null, array3);
			_ = (Class8)(object)Class5.Default;
			class8 = (Class10)(object)Class5.Default;
			@struct = default(Struct2);
			goto IL_36c0;
		}
		IL_306e:
		_ = (Class5)(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array4, out *(object*)Class5.Default);
		_ = (GClass1)(object)Class5.Default;
		checked
		{
			nuint num17 = unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)(UIntPtr)Class5.Default);
			nuint num18 = unchecked((nuint)(UIntPtr)@class.W(default(BindingFlags), null, type, null, array3) / (nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj, type, null));
			num = default(UIntPtr);
			nuint num19 = num - num;
			Class7 class72 = @class;
			bindingFlags = default(BindingFlags);
			if (num17 - (num18 - unchecked(num19 / (nuint)(UIntPtr)class72.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3))) == 0)
			{
				UIntPtr num20;
				Class7 class73;
				BindingFlags bindingFlags_49;
				Class7 class74;
				BindingFlags bindingFlags_50;
				ref object[] object_23;
				Class7 class75;
				Type type_16;
				Class7 class76;
				unchecked
				{
					num20 = (UIntPtr)Class5.Default;
					class73 = @class;
					bindingFlags_49 = bindingFlags;
					class74 = @class;
					bindingFlags_50 = bindingFlags;
					object_23 = ref *(object[]*)Class5.Default;
					class75 = @class;
					type_16 = type;
					class76 = @class;
					bindingFlags = default(BindingFlags);
				}
				if (unchecked((nuint)num20) * unchecked((nuint)(UIntPtr)class73.W(bindingFlags_49, (PropertyInfo[])(object)class74.j(bindingFlags_50, null, ref object_23, (ParameterModifier[])(object)((Class7)(object)class75.W(default(BindingFlags), null, type_16, (Type[])(object)class76.e(bindingFlags, array, null, array3), array3)).e(bindingFlags, array, (Type[])(object)Class5.Default, array3), cultureInfo, null, out object_7), null, (Type[])(object)@class.W(bindingFlags, array5, null, (Type[])(object)((Class7)@class.t(null, type, cultureInfo)).e((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), (MethodBase[])(object)Class5.Default, (Type[])(object)@class.t(bindingFlags, null, Class5.Default, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default)), null), null), array3)) == 0)
				{
				}
			}
		}
		if (num == 0)
		{
			gClass = (GClass2)(object)Class5.Default;
			_ = (GClass3)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo);
			class7 = class7;
			BindingFlags bindingFlags_51 = bindingFlags;
			ref object[] object_24 = ref *(object[]*)Class5.Default;
			Class7 obj52 = (Class7)(object)@class.W(bindingFlags, array5, (Type)(object)@class.W(bindingFlags, null, type, array2, array3), array2, array3);
			bindingFlags = default(BindingFlags);
			ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)obj52.j(bindingFlags, null, ref *(object[]*)@class.t(bindingFlags, fieldInfo_, null, null), array3, (CultureInfo)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), null, out object_7);
			CultureInfo cultureInfo_7 = (CultureInfo)(object)Class5.Default;
			string[] string_3 = array4;
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)((Class7)(object)((Class7)null).j(bindingFlags_51, (MethodBase[])null, ref object_24, parameterModifier_10, cultureInfo_7, string_3, out *(object*)class77.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, null, out object_7))).j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null), ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out object_7);
		}
		_ = (Class8)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out object_7);
		struct2 = struct2;
		class13 = null;
		_ = (Class7)@class.t(obj, type, (CultureInfo)(object)Class5.Default);
		try
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class78.W(bindingFlags, array5, null, array2, array3);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class9 = null;
			}
			else if (num == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
			else
			{
				class6 = class6;
			}
			goto IL_351f;
		}
		IL_1d19:
		while ((object)Class5.Default != null)
		{
			gClass2 = gClass2;
		}
		do
		{
			try
			{
				while (obj != null)
				{
					_ = Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
					continue;
				}
				Class7 class79 = @class;
				BindingFlags bindingFlags_52 = bindingFlags;
				ref object[] object_25 = ref reference;
				ParameterModifier[] parameterModifier_11 = array3;
				Class7 class80 = @class;
				BindingFlags bindingFlags_53 = bindingFlags;
				MethodBase[] methodBase_20 = array;
				ref object[] object_26 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_12 = array3;
				CultureInfo cultureInfo_8 = cultureInfo;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class79.j(bindingFlags_52, null, ref object_25, parameterModifier_11, null, (string[])(object)class80.j(bindingFlags_53, methodBase_20, ref object_26, parameterModifier_12, cultureInfo_8, null, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)@class.j((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])@class.t(Class5.Default, type, cultureInfo), cultureInfo, (string[])(object)Class5.Default, out object_7), (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, cultureInfo), null, array4, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)((Class7)null).W(bindingFlags, array5, (Type)null, array2, array3), (CultureInfo)null)), array3), array, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default))), out object_7);
			}
		}
		while (obj != null);
		gClass = gClass;
		do
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			finally
			{
				class6 = null;
				class8 = null;
				_003CModule_003E = _003CModule_003E;
				qk = null;
				continue;
			}
		}
		while (obj != null || obj != null);
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
					_ = (Struct2)Class5.Default;
					gClass2 = gClass2;
					_ = (Struct2)Class5.Default;
				}
			}
			else
			{
				class8 = (Class10)(object)Class5.Default;
			}
		}
		while (obj != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			class10 = (Class5)(object)@class.W(bindingFlags, array5, type, array2, null);
			_ = (Class7)(object)Class5.Default;
			class13 = null;
			goto IL_1ff0;
		}
		try
		{
			_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array3);
		}
		finally
		{
			while (obj != null)
			{
				qk = null;
			}
			goto IL_1ff0;
		}
		IL_1543:
		_ = (Class9)(object)@class.e(bindingFlags, array, array2, array3);
		nuint num21;
		Class7 class81;
		checked
		{
			while (obj != null)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						class33 = class33;
					}
					else
					{
						class12 = class12;
					}
				}
				catch
				{
					do
					{
						gClass = (GClass2)(object)Class5.Default;
						gClass4 = null;
						class8 = (Class10)(object)Class5.Default;
					}
					while ((object)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default) != null);
				}
			}
			num21 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
			class81 = @class;
		}
		BindingFlags bindingFlags_54 = (BindingFlags)@class.t(obj, (Type)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), null);
		Type[] type_17 = (Type[])(object)((Class7)null).t(default(BindingFlags), fieldInfo_, obj, (CultureInfo)null);
		Class7 class82 = @class;
		bindingFlags = default(BindingFlags);
		nuint num22 = num21 / (nuint)(UIntPtr)class81.e(bindingFlags_54, null, type_17, (ParameterModifier[])(object)((Class7)(object)class82.t(bindingFlags, fieldInfo_, null, null)).j(bindingFlags, null, ref *(object[]*)@class.W(bindingFlags, array5, null, array2, null), array3, (CultureInfo)(object)Class5.Default, null, out *(object*)null));
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * (num22 + num) == 0)
			{
				if (num == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, (CultureInfo)((Class7)(object)Class5.Default).t(obj, (Type)@class.t(obj, type, cultureInfo), cultureInfo));
				}
			}
			else
			{
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class83.t(bindingFlags, fieldInfo_, Class5.Default, null);
				_ = (Class2)(object)Class5.Default;
			}
		}
		do
		{
			if (num / num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					gClass2 = null;
				}
			}
		}
		while (obj != null);
		try
		{
			while ((object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, null, array3) != null)
			{
				if (num == 0)
				{
					_ = (Struct1)@class.t((BindingFlags)Class5.Default, fieldInfo_, ((Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), cultureInfo);
					_ = (GClass0)(object)Class5.Default;
					_ = (Class6)((Class7)null).t((object)null, type, (CultureInfo)@class.t(obj, null, (CultureInfo)(object)Class5.Default));
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		finally
		{
			do
			{
				class12 = class12;
			}
			while ((object)Class5.Default != null || (object)Class5.Default != null);
			goto IL_18c7;
		}
		IL_3f02:
		_ = (GClass0)(object)Class5.Default;
		while (true)
		{
			if (obj != null)
			{
				_ = (GClass0)(object)Class5.Default;
				gClass2 = null;
				class9 = class9;
			}
			else if ((object)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])null) == null)
			{
				break;
			}
		}
		do
		{
			try
			{
				class13 = null;
			}
			finally
			{
				_ = (Class6)(object)Class5.Default;
				_ = (GClass0)(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.W(bindingFlags, null, type, array2, array3), array5, null, array2, array3);
				continue;
			}
		}
		while (obj != null || obj != null);
		try
		{
			_ = (Class7)(object)Class5.Default;
		}
		finally
		{
			try
			{
				try
				{
					class7 = class7;
				}
				catch
				{
					gClass = gClass;
				}
			}
			catch
			{
				do
				{
					struct2 = default(Struct1);
				}
				while (obj != null);
			}
			goto IL_3ff4;
		}
		IL_2b1d:
		do
		{
			gClass3 = gClass3;
		}
		while (obj != null);
		num = default(UIntPtr);
		nuint num23 = num;
		Class7 class84 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (num23 + (unchecked((nuint)(UIntPtr)class84.e(bindingFlags, array, null, null)) + num) == 0)
			{
				while (obj != null)
				{
					_ = (Class10)(object)((Class7)null).e(unchecked((BindingFlags)Class5.Default), array, array2, array3);
				}
			}
			try
			{
				class13 = (Class8)(object)Class5.Default;
			}
			catch
			{
				gClass4 = null;
			}
			try
			{
				while ((object)Class5.Default != null)
				{
					while (obj != null)
					{
						_ = (Struct2)Class5.Default;
					}
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					gClass3 = ((num != 0) ? gClass3 : ((GClass3)(object)Class5.Default));
				}
				else
				{
					num = default(UIntPtr);
					if (unchecked(num / num) * num == 0)
					{
						gClass2 = gClass2;
					}
					else
					{
						_ = (Struct2)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
					}
				}
			}
			if (num == 0)
			{
				if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
				{
					try
					{
						_ = (GClass2)(object)Class5.Default;
						_ = (Struct1)Class5.Default;
						class12 = class12;
						@struct = @struct;
					}
					finally
					{
						gClass2 = gClass2;
						goto IL_2ea8;
					}
				}
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					class13 = class13;
					goto IL_2ea8;
				}
			}
			nuint num24 = num;
			num = default(UIntPtr);
			if (num24 - num == 0)
			{
				num = default(UIntPtr);
				nuint num25 = num + unchecked((nuint)(UIntPtr)Class5.Default);
				nuint num26 = num;
				num = default(UIntPtr);
				nuint num27 = num;
				Class7 class85 = @class;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)default(UIntPtr)) + num25 * (num26 * (num27 - unchecked((nuint)(UIntPtr)class85.W(bindingFlags, array5, null, null, array3)) + (unchecked((nuint)(UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo), ((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, null, array4, out object_7)).t((BindingFlags)@class.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default), (FieldInfo[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, array4, out *(object*)null), null, cultureInfo), cultureInfo)) - unchecked(num / num) * unchecked((nuint)(UIntPtr)Class5.Default)))) * unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)null).t((BindingFlags)@class.W(bindingFlags, array5, null, null, array3), (FieldInfo[])null, obj, (CultureInfo)null) / num) == 0)
				{
					_ = (Class2)(object)unchecked(((Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array3, (CultureInfo)(object)@class.W(bindingFlags, array5, type, array2, null), array4, out object_7)).e((BindingFlags)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array, array2, array3));
				}
			}
			goto IL_2ea8;
		}
	}

	unsafe static void smethod_5()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			BindingFlags bindingFlags_12;
			PropertyInfo[] propertyInfo_2;
			Type[] type_4;
			Class7 obj5;
			BindingFlags bindingFlags_13;
			PropertyInfo[] propertyInfo_3;
			Class7 class7;
			Class7 class8;
			PropertyInfo[] propertyInfo_4;
			Type type_5;
			Class7 class9;
			BindingFlags bindingFlags_14;
			Class7 class10;
			do
			{
				@class = @class;
				Class7 class2 = @class;
				BindingFlags bindingFlags_ = bindingFlags;
				array = null;
				Type[] type_ = array;
				array2 = (ParameterModifier[])(object)Class5.Default;
				bindingFlags = (BindingFlags)((Class7)null).e(bindingFlags_, (MethodBase[])null, type_, array2);
				BindingFlags bindingFlags_2 = bindingFlags;
				obj = obj;
				object object_ = obj;
				cultureInfo = cultureInfo;
				BindingFlags bindingFlags_3 = (BindingFlags)((Class7)null).t(bindingFlags_2, (FieldInfo[])null, object_, cultureInfo);
				array3 = (MethodBase[])(object)Class5.Default;
				MethodBase[] methodBase_ = array3;
				Class7 class3 = @class;
				FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
				Class7 class4 = @class;
				BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
				Type type_2 = (Type)(object)Class5.Default;
				Type[] type_3 = array;
				Class7 obj2 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_5 = bindingFlags;
				BindingFlags bindingFlags_6 = bindingFlags;
				reference = ref *(object[]*)Class5.Default;
				ref object[] object_2 = ref reference;
				ParameterModifier[] parameterModifier_ = array2;
				CultureInfo cultureInfo_ = cultureInfo;
				array4 = null;
				array5 = (FieldInfo[])(object)((Class7)null).j(bindingFlags_6, (MethodBase[])null, ref object_2, parameterModifier_, cultureInfo_, array4, out *(object*)null);
				object object_3 = ((Class7)(object)class4.W(bindingFlags_4, propertyInfo_, type_2, type_3, (ParameterModifier[])(object)obj2.t(bindingFlags_5, array5, null, (CultureInfo)(object)Class5.Default))).e(default(BindingFlags), array3, null, null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_7 = bindingFlags;
				MethodBase[] methodBase_2 = array3;
				Class7 obj3 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_8 = bindingFlags;
				ref object[] object_4 = ref reference;
				string[] string_ = array4;
				Class7 class5 = @class;
				BindingFlags bindingFlags_9 = bindingFlags;
				Class7 obj4 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array5;
				Class7 class6 = @class;
				BindingFlags bindingFlags_11 = bindingFlags;
				MethodBase[] methodBase_3 = array3;
				ref object[] object_5 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
				CultureInfo cultureInfo_2 = cultureInfo;
				string[] string_2 = array4;
				object_6 = ref *(object*)null;
				_ = (Struct1)class2.e(bindingFlags_3, methodBase_, (Type[])(object)class3.t(default(BindingFlags), fieldInfo_, object_3, (CultureInfo)(object)((Class7)null).j((BindingFlags)((Class7)null).j(bindingFlags_7, methodBase_2, ref *(object[]*)obj3.j(bindingFlags_8, null, ref object_4, null, null, string_, out *(object*)class5.j(bindingFlags_9, null, ref *(object[]*)obj4.t(bindingFlags_10, fieldInfo_2, class6.j(bindingFlags_11, methodBase_3, ref object_5, parameterModifier_2, cultureInfo_2, string_2, out object_6), (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), array2, cultureInfo, null, out object_6)), array2, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, array3, null, array2), ref *(object[]*)@class.t((BindingFlags)@class.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), null, array, array2), array3, array, null), null, null, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null)), array2);
				bindingFlags = default(BindingFlags);
				bindingFlags_12 = bindingFlags;
				array6 = null;
				propertyInfo_2 = array6;
				type_4 = array;
				obj5 = (Class7)(object)@class.e(bindingFlags, array3, array, array2);
				bindingFlags_13 = (BindingFlags)Class5.Default;
				propertyInfo_3 = array6;
				class7 = @class;
				class8 = @class;
				propertyInfo_4 = array6;
				type_5 = (Type)(object)Class5.Default;
				class9 = @class;
				bindingFlags_14 = (BindingFlags)Class5.Default;
				class10 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).W(bindingFlags_12, propertyInfo_2, (Type)null, type_4, (ParameterModifier[])(object)obj5.W(bindingFlags_13, propertyInfo_3, (Type)(object)((Class7)(object)class7.W(default(BindingFlags), (PropertyInfo[])(object)class8.W(default(BindingFlags), propertyInfo_4, type_5, (Type[])(object)((Class7)(object)class9.W(bindingFlags_14, (PropertyInfo[])(object)class10.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), (Type)(object)@class.W(bindingFlags, null, null, array, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, array6, null, array, array2)), array, array2)).j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, array5, obj, (CultureInfo)(object)Class5.Default), ref reference, array2, null, (string[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null), out *(object*)Class5.Default), array2), null, (Type[])(object)Class5.Default, array2)).t(bindingFlags, array5, @class.t(bindingFlags, null, obj, cultureInfo), (CultureInfo)(object)Class5.Default), (Type[])((Class7)null).t(obj, (Type)(object)@class.e((BindingFlags)Class5.Default, array3, (Type[])(object)Class5.Default, null), (CultureInfo)null), array2)) != null || obj != null);
			goto IL_0605;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			Class5 obj6 = Class5.Default;
			class11 = class11;
			class11 = obj6;
		}
		catch
		{
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
			}
			catch
			{
				@struct = (Struct2)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), array2, (CultureInfo)null, array4, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, cultureInfo));
				@struct = @struct;
			}
			goto IL_0605;
		}
		IL_4b8a:
		while (obj != null)
		{
			_ = (Class10)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		try
		{
			do
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).e(bindingFlags, array3, array, array2);
				}
				catch
				{
					gClass = null;
				}
			}
			while ((object)((Class7)null).e(bindingFlags, array3, (Type[])null, array2) != null);
		}
		finally
		{
			nuint num = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num - uIntPtr * uIntPtr) / uIntPtr == 0)
			{
				try
				{
					_ = (Struct1)((Class7)(object)Class5.Default).t(@class.t(obj, type, cultureInfo), type, (CultureInfo)((Class7)null).t((object)null, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])@class.t(obj, type, (CultureInfo)(object)((Class7)(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null), array3, ref reference, array2, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array6, null, null, array2), out *(object*)Class5.Default)).t((BindingFlags)Class5.Default, array5, obj, cultureInfo)), array2), cultureInfo));
					_ = (Class2)(object)Class5.Default;
					_003CModule_003E = null;
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null);
				}
			}
			else
			{
				_ = (Class6)(object)Class5.Default;
			}
			goto IL_4d47;
		}
		IL_58df:
		Class7 obj11 = (Class7)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj, cultureInfo);
		bindingFlags = default(BindingFlags);
		UIntPtr num2 = (UIntPtr)obj11.t(bindingFlags, null, obj, (CultureInfo)(object)@class.j((BindingFlags)@class.t(Class5.Default, type, cultureInfo), array3, ref reference, null, null, array4, out *(object*)Class5.Default));
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class12);
		GClass0 gClass2;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)num2) + uIntPtr) == 0)
			{
				try
				{
					try
					{
						class12 = class12;
					}
					finally
					{
						class13 = class13;
						goto end_IL_5984;
					}
					end_IL_5984:;
				}
				finally
				{
					try
					{
						gClass2 = null;
					}
					catch
					{
						class11 = class11;
					}
					goto IL_59b0;
				}
			}
			goto IL_59b0;
		}
		IL_1292:
		while (obj != null)
		{
			gClass2 = gClass2;
		}
		try
		{
			if (uIntPtr == 0)
			{
				while ((object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, (ParameterModifier[])(object)Class5.Default), cultureInfo) != null)
				{
					Class7 obj13 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array5;
					object object_7 = @class.j(bindingFlags, array3, ref *(object[]*)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, cultureInfo, null, out object_6), array2, (CultureInfo)((Class7)(object)Class5.Default).t(obj, null, cultureInfo), (string[])(object)Class5.Default, out object_6);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_16 = bindingFlags;
					MethodBase[] methodBase_4 = array3;
					ref object[] object_8 = ref reference;
					Class7 class14 = @class;
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)((Class7)(object)class14.W((BindingFlags)class15.j(bindingFlags, array3, ref reference, array2, null, null, out object_6), array6, type, array, array2)).t(bindingFlags, null, obj, null);
					CultureInfo cultureInfo_3 = cultureInfo;
					Class7 class16 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj13.t(bindingFlags_15, fieldInfo_3, object_7, (CultureInfo)(object)((Class7)null).j(bindingFlags_16, methodBase_4, ref object_8, parameterModifier_3, cultureInfo_3, (string[])(object)class16.W((BindingFlags)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)null), null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), out *(object*)@class.W(bindingFlags, null, type, array, null)));
				}
			}
		}
		catch
		{
		}
		gClass2 = gClass2;
		try
		{
			Class7 class17 = @class;
			BindingFlags bindingFlags_17 = bindingFlags;
			MethodBase[] methodBase_5 = array3;
			Type[] type_6 = (Type[])(object)Class5.Default;
			Class7 class18 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class17.e(bindingFlags_17, methodBase_5, type_6, (ParameterModifier[])(object)class18.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)) == (UIntPtr)(nuint)0u)
			{
			}
		}
		catch
		{
			_ = (Struct1)Class5.Default;
		}
		try
		{
			if (uIntPtr != 0)
			{
				try
				{
					@struct = (Struct2)((Class7)@class.t(obj, null, cultureInfo)).t(obj, null, (CultureInfo)(object)@class.t((BindingFlags)((Class7)null).W((BindingFlags)@class.t(null, type, null), array6, (Type)null, (Type[])null, array2), array5, obj, cultureInfo));
				}
				finally
				{
					_ = (Struct2)@class.e((BindingFlags)Class5.Default, array3, array, array2);
					_ = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, null, array, array2);
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array2);
					goto end_IL_14d5;
				}
			}
			do
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				class11 = class11;
			}
			while ((object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null) != null);
			end_IL_14d5:;
		}
		finally
		{
			Class7 class19 = @class;
			BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_6 = array3;
			BindingFlags bindingFlags_19 = bindingFlags;
			MethodBase[] methodBase_7 = array3;
			BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_5 = array6;
			Class7 class20 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class7)((Class7)(object)((Class7)(object)class19.e(bindingFlags_18, methodBase_6, (Type[])(object)((Class7)(object)((Class7)null).e(bindingFlags_19, methodBase_7, (Type[])(object)((Class7)null).W(bindingFlags_20, propertyInfo_5, (Type)(object)class20.W(bindingFlags, null, type, array, array2), array, (ParameterModifier[])null), (ParameterModifier[])null)).e(bindingFlags, array3, array, array2), null)).t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default)).t(obj, type, cultureInfo);
			Class7 obj16 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			class11 = (Class5)(object)obj16.j(bindingFlags, null, ref *(object[]*)((Class7)null).t((object)null, type, cultureInfo), null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			_ = (Struct2)@class.e(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, null), array, array2);
			goto IL_1759;
		}
		IL_0605:
		Qk7 qk = qk;
		qk = null;
		_ = (Struct2)((Class7)null).W((BindingFlags)Class5.Default, array6, (Type)null, (Type[])null, array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		do
		{
			try
			{
				gClass3 = null;
				gClass3 = gClass3;
			}
			finally
			{
				_ = (Qk7)(object)Class5.Default;
				continue;
			}
		}
		while (obj != null || obj != null);
		_ = (Class6)(object)Class5.Default;
		@struct = @struct;
		@struct = @struct;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
			gClass = gClass;
		}
		else
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class21.e(bindingFlags, array3, array, null);
				}
				finally
				{
					class12 = null;
					class12 = class12;
					_ = (Class7)(object)Class5.Default;
					@struct = (Struct2)Class5.Default;
					goto IL_0705;
				}
			}
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj != null);
		}
		goto IL_0705;
		IL_3b4d:
		GClass2 gClass4 = gClass4;
		_ = (Class6)(object)Class5.Default;
		class12 = (Class8)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		_ = (Class0)(object)((Class7)(object)Class5.Default).e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default);
		class12 = null;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)@class.e(bindingFlags, null, array, array2);
				}
			}
			else
			{
				do
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass3 = null;
					bindingFlags = default(BindingFlags);
					Class7 obj17 = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array2, cultureInfo, array4, out object_6)).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, null), null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, null)), null, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_21 = (BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, null);
					FieldInfo[] fieldInfo_4 = array5;
					Class7 obj18 = (Class7)(object)Class5.Default;
					Class7 class22 = @class;
					Class7 obj19 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj20 = (Class7)(object)class22.W((BindingFlags)obj19.W(bindingFlags, array6, type, (Type[])(object)((Class7)null).t((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array3, ref *(object[]*)@class.j(bindingFlags, array3, ref reference, null, null, array4, out *(object*)null), (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array3, array, array2), (CultureInfo)@class.t(obj, null, (CultureInfo)(object)Class5.Default), array4, out *(object*)null), array4, out *(object*)null), array5, obj, (CultureInfo)(object)Class5.Default), (ParameterModifier[])((Class7)null).t(obj, (Type)null, (CultureInfo)null)), null, type, array, null);
					BindingFlags bindingFlags_22 = (BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
					Class7 obj21 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_23 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array6;
					Type type_7 = (Type)(object)@class.j(bindingFlags, null, ref reference, array2, null, null, out *(object*)@class.j((BindingFlags)((Class7)(object)@class.W((BindingFlags)Class5.Default, array6, type, (Type[])(object)((Class7)(object)@class.j(default(BindingFlags), array3, ref reference, null, null, array4, out *(object*)Class5.Default)).e((BindingFlags)Class5.Default, null, array, null), array2)).j(default(BindingFlags), array3, ref *(object[]*)null, array2, cultureInfo, null, out object_6), array3, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out object_6));
					Class7 obj22 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)obj17.t(bindingFlags_21, fieldInfo_4, obj18.W(default(BindingFlags), null, null, (Type[])(object)obj20.W(bindingFlags_22, null, (Type)(object)obj21.W((BindingFlags)((Class7)null).W(bindingFlags_23, propertyInfo_6, type_7, (Type[])null, (ParameterModifier[])(object)obj22.j(bindingFlags, array3, ref *(object[]*)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo), array2, cultureInfo, array4, out object_6)), (PropertyInfo[])(object)Class5.Default, type, null, array2), array, array2), array2), null);
				}
				while (obj != null);
			}
		}
		catch
		{
			Class7 obj23 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = bindingFlags;
			Class7 class23 = @class;
			BindingFlags bindingFlags_25 = bindingFlags;
			FieldInfo[] fieldInfo_5 = array5;
			object object_9 = obj;
			Class7 class24 = @class;
			BindingFlags bindingFlags_26 = bindingFlags;
			BindingFlags bindingFlags_27 = bindingFlags;
			PropertyInfo[] propertyInfo_7 = array6;
			Type type_8 = type;
			Type[] type_9 = array;
			Class7 class25 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)obj23.W(bindingFlags_24, (PropertyInfo[])((Class7)(object)class23.t(bindingFlags_25, fieldInfo_5, object_9, (CultureInfo)(object)class24.W(bindingFlags_26, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_27, propertyInfo_7, type_8, type_9, (ParameterModifier[])(object)class25.t(bindingFlags, array5, @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), cultureInfo)), type, array, array2))).t(null, null, null), type, array, array2);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class26);
		do
		{
			class26 = (Class0)(object)((Class7)(object)Class5.Default).j(bindingFlags, array3, ref reference, array2, cultureInfo, array4, out object_6);
		}
		while ((object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, cultureInfo) != null);
		_ = Class5.Default;
		Class7 class27 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)((Class7)null).t((object)class27.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array3, array, array2), array, null), (Type)null, (CultureInfo)(object)Class5.Default);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class30);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class28);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class29);
		try
		{
			try
			{
				try
				{
					class28 = null;
				}
				finally
				{
					class29 = class29;
					goto end_IL_417f;
				}
				end_IL_417f:;
			}
			catch
			{
				class13 = class13;
			}
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					class12 = (Class8)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2));
				}
				finally
				{
					class30 = (Class6)(object)Class5.Default;
					continue;
				}
			}
		}
		_ = (Qk7)(object)Class5.Default;
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class31.e(bindingFlags, null, null, array2);
				}
			}
			else
			{
				try
				{
					@struct = @struct;
				}
				catch
				{
					class11 = null;
					class13 = (Class2)(object)Class5.Default;
					_ = (GClass2)((Class7)(object)@class.t(bindingFlags, array5, obj, cultureInfo)).t(obj, type, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null));
				}
			}
			goto IL_4302;
		}
		IL_59b0:
		do
		{
			@struct = default(Struct2);
		}
		while (@class.t(Class5.Default, null, cultureInfo) != null);
		try
		{
			@class = null;
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					continue;
				}
			}
			goto IL_5a0e;
		}
		IL_3843:
		class30 = class30;
		gClass2 = gClass2;
		try
		{
			UIntPtr num3 = (UIntPtr)((Class7)null).e(bindingFlags, array3, (Type[])null, array2);
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num3) + uIntPtr + uIntPtr == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		finally
		{
			_ = (Class5)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, null, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)((Class7)(object)((Class7)null).W(bindingFlags, array6, (Type)null, array, (ParameterModifier[])null)).t(null, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo);
			class29 = (Class4)(object)Class5.Default;
			gClass3 = gClass3;
			goto IL_3922;
		}
		IL_26d5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class33);
		try
		{
			do
			{
				if (uIntPtr == 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					gClass = null;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				while (@class.t(obj, type, null) != null)
				{
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					class33 = (Class10)((Class7)(object)class32.e(bindingFlags, array3, (Type[])(object)Class5.Default, null)).t(null, (Type)(object)Class5.Default, cultureInfo);
					class33 = class33;
				}
			}
			goto IL_287a;
		}
		IL_287a:
		while ((object)Class5.Default != null)
		{
			_ = (Class5)@class.t(null, null, cultureInfo);
			Class7 class34 = @class;
			FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class34.t(default(BindingFlags), fieldInfo_6, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)Class5.Default, array2, (CultureInfo)null, array4, out *(object*)Class5.Default)), array, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj, null)));
			_ = (GClass0)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
			class12 = class12;
		}
		_ = Class5.Default;
		do
		{
			if (uIntPtr / uIntPtr != 0)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + uIntPtr + uIntPtr) == 0)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					class13 = class13;
					class29 = (Class4)((Class7)(object)Class5.Default).t(obj, null, null);
					class11 = null;
				}
				else
				{
					Class7 class35 = @class;
					BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass3)(object)class35.j(bindingFlags_28, null, ref *(object[]*)((Class7)(object)((Class7)null).W(bindingFlags, array6, type, array, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array2))).j((BindingFlags)((Class7)(object)@class.t((BindingFlags)((Class7)null).t((object)null, type, cultureInfo), array5, Class5.Default, cultureInfo)).j(bindingFlags, array3, ref *(object[]*)null, array2, null, array4, out object_6), null, ref *(object[]*)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, array2), null, cultureInfo, array4, out object_6), (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, null, ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(obj, type, cultureInfo));
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class30 = class30;
					continue;
				}
				qk = null;
				class33 = null;
			}
		}
		while (obj != null);
		if (uIntPtr == 0 && uIntPtr == 0)
		{
			_ = (Struct2)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null);
		}
		if (uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = null;
					class13 = null;
					class29 = class29;
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					gClass = gClass;
				}
			}
			else
			{
				try
				{
					gClass4 = gClass4;
				}
				catch
				{
					class13 = class13;
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class28 = (Class9)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array2);
			}
			catch
			{
				_ = (Struct1)Class5.Default;
				class11 = class11;
				Class7 obj30 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_29 = bindingFlags;
				FieldInfo[] fieldInfo_7 = array5;
				object object_10 = obj;
				Class7 obj31 = (Class7)(object)@class.j(default(BindingFlags), null, ref reference, null, cultureInfo, (string[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array, (ParameterModifier[])(object)Class5.Default), out object_6);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_30 = bindingFlags;
				Class7 class36 = @class;
				BindingFlags bindingFlags_31 = bindingFlags;
				MethodBase[] methodBase_8 = array3;
				Class7 class37 = @class;
				BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_8 = array6;
				Class7 class38 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_33 = bindingFlags;
				MethodBase[] methodBase_9 = array3;
				CultureInfo cultureInfo_4 = cultureInfo;
				string[] string_3 = (string[])(object)Class5.Default;
				Class7 class39 = @class;
				Class7 obj32 = (Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, array2, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])@class.t(obj, type, cultureInfo), type, (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), array, array2), null), array6, (Type)(object)Class5.Default, array, array2), out object_6);
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				object object_11 = obj30.t(bindingFlags_29, fieldInfo_7, object_10, (CultureInfo)(object)obj31.t(bindingFlags_30, (FieldInfo[])(object)class36.e(bindingFlags_31, methodBase_8, (Type[])(object)class37.t((BindingFlags)((Class7)null).W(bindingFlags_32, propertyInfo_8, (Type)(object)class38.j(bindingFlags_33, methodBase_9, ref *(object[]*)null, null, cultureInfo_4, string_3, out *(object*)class39.W((BindingFlags)((Class7)(object)obj32.W((BindingFlags)class40.W(bindingFlags, (PropertyInfo[])@class.t(obj, type, cultureInfo), type, array, array2), (PropertyInfo[])(object)Class5.Default, type, null, array2)).t(null, type, cultureInfo), null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array2)), null, obj, cultureInfo), null), obj, cultureInfo));
				Type type_10 = (Type)(object)Class5.Default;
				BindingFlags bindingFlags_34 = (BindingFlags)@class.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default);
				Class7 class41 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_35 = bindingFlags;
				PropertyInfo[] propertyInfo_9 = array6;
				Class7 class42 = @class;
				BindingFlags bindingFlags_36 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Type type_11 = (Type)(object)class42.W(bindingFlags_36, null, null, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), array2), null);
				Class7 obj33 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_37 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)@class.t(bindingFlags, null, null, cultureInfo);
				bindingFlags = default(BindingFlags);
				Class7 obj34 = (Class7)((Class7)(object)obj33.W(bindingFlags_37, propertyInfo_10, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)Class5.Default), null, (ParameterModifier[])(object)Class5.Default)).t(null, type, cultureInfo);
				BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_11 = array6;
				Type type_12 = type;
				BindingFlags bindingFlags_39 = bindingFlags;
				MethodBase[] methodBase_10 = array3;
				ref object[] object_12 = ref reference;
				Class7 obj35 = (Class7)(object)Class5.Default;
				Class7 obj36 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)((Class7)null).t(object_11, type_10, (CultureInfo)(object)((Class7)null).W(bindingFlags_34, (PropertyInfo[])(object)class41.W(bindingFlags_35, propertyInfo_9, type_11, (Type[])(object)obj34.W(bindingFlags_38, propertyInfo_11, type_12, (Type[])(object)((Class7)null).j(bindingFlags_39, methodBase_10, ref object_12, (ParameterModifier[])(object)obj35.e((BindingFlags)obj36.t(bindingFlags, null, null, cultureInfo), array3, null, array2), cultureInfo, (string[])(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), out object_6), null), array2), (Type)(object)@class.e(bindingFlags, array3, array, array2), (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)null).t(obj, type, cultureInfo)));
				_ = (_003CModule_003E)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, null, null, out *(object*)null);
			}
		}
		else
		{
			class12 = class12;
			_ = (Class7)(object)Class5.Default;
		}
		_ = (GClass3)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)@class.e(bindingFlags, array3, array, array2) != null)
			{
				do
				{
					Class7 obj38 = (Class7)(object)Class5.Default;
					FieldInfo[] fieldInfo_8 = array5;
					object object_13 = obj;
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj38.t(default(BindingFlags), fieldInfo_8, object_13, (CultureInfo)(object)class43.t(bindingFlags, array5, ((Class7)(object)Class5.Default).t(obj, type, cultureInfo), (CultureInfo)(object)Class5.Default));
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
				}
				while ((object)((Class7)null).t(bindingFlags, array5, (object)@class.W((BindingFlags)Class5.Default, array6, type, array, null), (CultureInfo)null) != null);
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class44 = @class;
					Class7 class45 = @class;
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class44.e((BindingFlags)class45.t(null, (Type)(object)class46.W(bindingFlags, null, type, null, array2), cultureInfo), array3, (Type[])(object)Class5.Default, array2);
				}
				catch
				{
					_ = (Class2)@class.t(null, (Type)(object)Class5.Default, null);
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				Class7 class47 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class47.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, (object)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null));
			}
			else
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					class29 = class29;
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					goto IL_3510;
				}
			}
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr;
			Class7 class48 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_40 = bindingFlags;
			MethodBase[] methodBase_11 = array3;
			ref object[] object_14 = ref reference;
			Class7 obj41 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_41 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])(object)@class.t(bindingFlags, null, null, cultureInfo);
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_42 = bindingFlags;
			Class7 class50 = @class;
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_13 = array3;
			BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_9 = array5;
			Class7 class51 = @class;
			bindingFlags = default(BindingFlags);
			if (checked(num4 - unchecked((nuint)(UIntPtr)class48.j((BindingFlags)((Class7)null).j(bindingFlags_40, methodBase_11, ref object_14, (ParameterModifier[])(object)obj41.e(bindingFlags_41, methodBase_12, null, (ParameterModifier[])(object)class49.W(bindingFlags_42, (PropertyInfo[])(object)class50.j(bindingFlags_43, methodBase_13, ref *(object[]*)((Class7)null).t(bindingFlags_44, fieldInfo_9, (object)class51.W((BindingFlags)((Class7)null).e(bindingFlags, array3, (Type[])null, array2), array6, type, array, array2), cultureInfo), null, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), type, array, array2)), (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array2)), array3, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_6))) == 0)
			{
				_ = (Class0)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])null, out object_6);
			}
		}
		goto IL_3510;
		IL_1759:
		class26 = class26;
		_ = (Class5)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_6);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class2)(object)Class5.Default;
		}
		else
		{
			try
			{
				if (uIntPtr == 0)
				{
					@class = @class;
					class28 = null;
				}
				else
				{
					Class7 obj42 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_45 = bindingFlags;
					FieldInfo[] fieldInfo_10 = (FieldInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, obj, cultureInfo)).W((BindingFlags)Class5.Default, array6, type, null, null), array5, obj, cultureInfo);
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 obj43 = (Class7)@class.t(null, type, null);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj42.t(bindingFlags_45, fieldInfo_10, null, (CultureInfo)(object)class52.W(bindingFlags_46, null, null, (Type[])(object)obj43.e(bindingFlags, null, null, null), array2));
					Class7 class53 = @class;
					BindingFlags bindingFlags_47 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class53.t(bindingFlags_47, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), ((Class7)(object)Class5.Default).t(null, type, cultureInfo), cultureInfo);
					_ = (Class7)(object)@class.e(bindingFlags, array3, array, array2);
					_ = (Class0)(object)@class.W((BindingFlags)Class5.Default, array6, type, null, (ParameterModifier[])(object)Class5.Default);
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)Class5.Default;
					class30 = (Class6)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array2);
					class30 = null;
					_ = (Struct1)((Class7)@class.t(obj, type, null)).t(@class.t(bindingFlags, null, obj, null), type, cultureInfo);
					class28 = null;
				}
			}
		}
		_ = Class5.Default;
		Class7 class54 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class54.e(bindingFlags, array3, (Type[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, array4, out object_6)).W(bindingFlags, array6, type, array, array2), (ParameterModifier[])@class.t(obj, null, (CultureInfo)(object)Class5.Default));
		do
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				try
				{
					class11 = Class5.Default;
				}
				finally
				{
					class11 = null;
					continue;
				}
			}
		}
		while (obj != null);
		while (true)
		{
			Class7 class55 = @class;
			Class7 class56 = @class;
			BindingFlags bindingFlags_48 = bindingFlags;
			FieldInfo[] fieldInfo_11 = (FieldInfo[])(object)Class5.Default;
			Class7 class57 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_49 = (BindingFlags)class56.t(bindingFlags_48, fieldInfo_11, class57.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null)), cultureInfo);
			Type type_13 = type;
			Type[] type_14 = array;
			Class7 obj45 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((object)class55.W(bindingFlags_49, null, type_13, type_14, (ParameterModifier[])(object)obj45.W(bindingFlags, array6, type, (Type[])(object)@class.e(bindingFlags, array3, array, array2), array2)) == null)
			{
				break;
			}
			try
			{
				class33 = null;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Class6)(object)Class5.Default;
				}
				else
				{
					class33 = class33;
				}
			}
			finally
			{
				Class7 obj47 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj47.t(bindingFlags, null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array2))) == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)@class.t(obj, null, null);
				}
				goto IL_1c4e;
			}
		}
		goto IL_1c4e;
		IL_4637:
		checked
		{
			try
			{
				try
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array, array2)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						@struct = (Struct2)Class5.Default;
					}
				}
				finally
				{
					if (uIntPtr == 0)
					{
						gClass2 = gClass2;
					}
					else
					{
						class28 = null;
					}
					goto end_IL_4638;
				}
				end_IL_4638:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass = null;
					_ = (Class10)(object)Class5.Default;
					_ = (GClass1)@class.t(obj, null, cultureInfo);
				}
				goto IL_46da;
			}
		}
		IL_46da:
		class29 = (Class4)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array2);
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr + uIntPtr == 0)
					{
						Class7 obj48 = (Class7)(object)Class5.Default;
						object object_15 = obj;
						Class7 class58 = @class;
						Class7 obj49 = (Class7)(object)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default);
						BindingFlags bindingFlags_50 = bindingFlags;
						PropertyInfo[] propertyInfo_12 = array6;
						Type type_15 = type;
						Class7 class59 = @class;
						unchecked
						{
							BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
							MethodBase[] methodBase_14 = array3;
							ref object[] object_16 = ref reference;
							ParameterModifier[] parameterModifier_4 = array2;
							bindingFlags = default(BindingFlags);
							Class7 obj50 = (Class7)obj48.t(object_15, (Type)class58.t(obj49.W(bindingFlags_50, propertyInfo_12, type_15, (Type[])(object)class59.j(bindingFlags_51, methodBase_14, ref object_16, parameterModifier_4, (CultureInfo)(object)((Class7)null).W(bindingFlags, array6, (Type)(object)((Class7)null).W(bindingFlags, array6, (Type)(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(@class.t(bindingFlags, array5, Class5.Default, cultureInfo), (Type)(object)Class5.Default, null), type, array, array2), (Type[])(object)Class5.Default, array2), array, array2), array4, out object_6), (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)Class5.Default), cultureInfo);
							Class7 class60 = @class;
							bindingFlags = default(BindingFlags);
							_ = (Class4)(object)obj50.W(default(BindingFlags), (PropertyInfo[])(object)class60.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, null, out *(object*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_6)), type, (Type[])(object)Class5.Default, array2);
						}
					}
					else
					{
						_ = (Class7)(object)Class5.Default;
					}
				}
				else if (uIntPtr * unchecked((nuint)(UIntPtr)@class.t((BindingFlags)Class5.Default, array5, obj, cultureInfo)) == 0)
				{
					gClass2 = gClass2;
				}
				else
				{
					_ = Class5.Default;
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					Class7 obj51 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_52 = bindingFlags;
					ParameterModifier[] parameterModifier_5 = array2;
					CultureInfo cultureInfo_5 = cultureInfo;
					string[] string_4 = (string[])(object)Class5.Default;
					BindingFlags bindingFlags_53 = bindingFlags;
					MethodBase[] methodBase_15 = (MethodBase[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null);
					Class7 class61 = @class;
					Class7 class62 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_16 = array3;
					Type[] type_16 = array;
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_55 = (BindingFlags)class62.e(bindingFlags_54, methodBase_16, type_16, (ParameterModifier[])(object)class63.e(bindingFlags, array3, null, (ParameterModifier[])@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)));
					object object_17 = obj;
					Class7 obj52 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)(object)obj51.j(bindingFlags_52, null, ref *(object[]*)null, parameterModifier_5, cultureInfo_5, string_4, out *(object*)((Class7)null).e(bindingFlags_53, methodBase_15, (Type[])(object)class61.t(bindingFlags_55, null, object_17, (CultureInfo)(object)obj52.e(bindingFlags, array3, array, array2)), (ParameterModifier[])null))).j(bindingFlags, array3, ref reference, null, cultureInfo, null, out *(object*)Class5.Default);
				}
				catch
				{
					@class = (Class7)(object)Class5.Default;
					_ = (Struct2)((Class7)null).t(bindingFlags, array5, obj, cultureInfo);
				}
			}
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					class28 = class28;
				}
			}
			finally
			{
				_ = (Struct1)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				goto IL_4b17;
			}
		}
		IL_0705:
		gClass2 = null;
		gClass2 = null;
		try
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_56 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_12 = (FieldInfo[])(object)((Class7)null).j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out object_6);
					object object_18 = obj;
					Class7 class64 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_57 = bindingFlags;
					PropertyInfo[] propertyInfo_13 = array6;
					type = null;
					Class7 obj54 = (Class7)(object)class64.W(bindingFlags_57, propertyInfo_13, type, array, null);
					BindingFlags bindingFlags_58 = (BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array2);
					Class7 class65 = @class;
					BindingFlags bindingFlags_59 = bindingFlags;
					Class7 obj55 = (Class7)@class.t(null, null, cultureInfo);
					object object_19 = obj;
					Type type_17 = (Type)(object)Class5.Default;
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags_56, fieldInfo_12, object_18, (CultureInfo)(object)obj54.e(bindingFlags_58, null, (Type[])(object)class65.e(bindingFlags_59, (MethodBase[])(object)((Class7)obj55.t(object_19, type_17, (CultureInfo)(object)class66.e(bindingFlags, array3, array, array2))).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])((Class7)(object)Class5.Default).t(null, type, null), out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array2)), array, array2), array2));
				}
				finally
				{
					_ = (Class4)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo);
					goto IL_08d7;
				}
			}
			goto IL_08d7;
		}
		IL_08d7:
		bindingFlags = default(BindingFlags);
		UIntPtr num5 = (UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])@class.t(obj, type, cultureInfo), cultureInfo, (string[])@class.t(Class5.Default, type, cultureInfo), out object_6), cultureInfo, (string[])(object)Class5.Default, out *(object*)null), (ParameterModifier[])(object)Class5.Default);
		uIntPtr = default(UIntPtr);
		if ((nuint)num5 / uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				class26 = class26;
				class26 = class26;
			}
			else
			{
				while (@class.t(null, type, cultureInfo) != null)
				{
					_ = (Class6)(object)@class.e((BindingFlags)@class.W(bindingFlags, array6, type, array, null), array3, null, null);
				}
			}
		}
		_ = (Class10)(object)Class5.Default;
		class33 = class33;
		class33 = class33;
		class26 = class26;
		class28 = class28;
		class28 = class28;
		class29 = class29;
		class29 = class29;
		while (obj != null)
		{
			do
			{
				Class7 class67 = @class;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class67.j((BindingFlags)class68.W(bindingFlags, array6, null, array, (ParameterModifier[])(object)Class5.Default), null, ref *(object[]*)Class5.Default, null, null, array4, out object_6);
			}
			while (obj != null || obj != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0)
			{
				try
				{
					class26 = class26;
				}
				finally
				{
					_ = (Struct2)((Class7)(object)@class.W((BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, array3, (Type[])null, array2)).W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array2, cultureInfo, null, out object_6), (Type)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array, array2), array6, type, array, array2)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, null, array2);
					goto IL_0bc4;
				}
			}
		}
		else
		{
			_ = (Class9)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default);
		}
		goto IL_0bc4;
		IL_5e41:
		try
		{
			if (uIntPtr / uIntPtr != 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = null;
				}
				else
				{
					_ = (Class6)(object)Class5.Default;
					@struct = default(Struct2);
					class33 = class33;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_003CModule_003E = null;
					BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_17 = array3;
					BindingFlags bindingFlags_61 = bindingFlags;
					Class7 class69 = @class;
					BindingFlags bindingFlags_62 = bindingFlags;
					Class7 class70 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					Class7 class71 = @class;
					bindingFlags = default(BindingFlags);
					object object_20 = ((Class7)(object)class70.t(bindingFlags_63, (FieldInfo[])(object)class71.W(bindingFlags, array6, (Type)(object)((Class7)null).e((BindingFlags)@class.j(bindingFlags, array3, ref reference, null, (CultureInfo)@class.t(null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), ref reference, (ParameterModifier[])@class.t(null, type, cultureInfo), cultureInfo, array4, out *(object*)Class5.Default), array2, (CultureInfo)null, array4, out *(object*)Class5.Default), (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array3, (Type[])null, (ParameterModifier[])(object)Class5.Default)), array4, out object_6), (MethodBase[])null, (Type[])(object)((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)@class.t(null, null, null), null, cultureInfo, array4, out object_6)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, array4, out object_6)), (ParameterModifier[])(object)Class5.Default), array, null), Class5.Default, cultureInfo)).e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t(default(BindingFlags), array5, Class5.Default, null));
					Type type_18 = type;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).e(bindingFlags_60, methodBase_17, (Type[])null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_61, (MethodBase[])(object)class69.t(bindingFlags_62, (FieldInfo[])((Class7)null).t(object_20, type_18, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)Class5.Default)), obj, cultureInfo), (Type[])(object)Class5.Default, array2));
				}
			}
		}
		if (uIntPtr == 0)
		{
			qk = qk;
		}
		try
		{
			class12 = class12;
		}
		finally
		{
			while (obj != null)
			{
				class33 = (Class10)(object)Class5.Default;
			}
			goto IL_6165;
		}
		IL_4586:
		try
		{
			_ = (Struct1)Class5.Default;
		}
		finally
		{
			_ = (Class2)((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo);
			goto IL_45ba;
		}
		IL_435b:
		_ = (Class10)(object)Class5.Default;
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				_ = (GClass0)@class.t(obj, type, cultureInfo);
				Class7 class72 = @class;
				BindingFlags bindingFlags_64 = bindingFlags;
				FieldInfo[] fieldInfo_13 = array5;
				Class7 class73 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class72.t(bindingFlags_64, fieldInfo_13, class73.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, null, array4, out *(object*)@class.t(bindingFlags, null, null, null)), (CultureInfo)((Class7)(object)@class.t((BindingFlags)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), array5, null, null)).t(obj, type, cultureInfo));
				_ = (Class2)(object)Class5.Default;
				class26 = class26;
			}
			else if (obj == null)
			{
				break;
			}
		}
		try
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = null;
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		catch
		{
		}
		if (uIntPtr != 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (GClass1)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array2);
				}
				else
				{
					_ = (GClass0)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null);
					_ = (Class8)(object)Class5.Default;
					@struct = (Struct2)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array2);
					class30 = (Class6)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				try
				{
					qk = null;
				}
				catch
				{
					class29 = (Class4)(object)Class5.Default;
				}
				goto IL_4586;
			}
		}
		goto IL_4586;
		IL_3922:
		try
		{
			if (uIntPtr == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, array2);
				}
				else
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_65 = bindingFlags;
					BindingFlags bindingFlags_66 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
					Class7 class74 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).W(bindingFlags_65, (PropertyInfo[])null, (Type)(object)((Class7)null).j(bindingFlags_66, methodBase_18, ref *(object[]*)((Class7)(object)class74.t(bindingFlags, null, obj, cultureInfo)).t(((Class7)null).W(bindingFlags, array6, type, (Type[])null, (ParameterModifier[])null), type, cultureInfo), (ParameterModifier[])null, cultureInfo, (string[])(object)@class.j(bindingFlags, null, ref *(object[]*)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo), (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo), cultureInfo, array4, out object_6), out *(object*)((Class7)null).W(bindingFlags, array6, type, array, array2)), array, array2);
					class28 = null;
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2);
				}
			}
		}
		finally
		{
			try
			{
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class75.t(bindingFlags, (FieldInfo[])(object)@class.W((BindingFlags)((Class7)null).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, array2), null, type, array, (ParameterModifier[])(object)Class5.Default), obj, null);
			}
			catch
			{
				do
				{
					_ = (GClass1)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array2, cultureInfo, null, out object_6);
				}
				while (obj != null);
			}
			goto IL_3b4d;
		}
		IL_5626:
		Class7 class76 = @class;
		Class7 class77 = @class;
		BindingFlags bindingFlags_67 = bindingFlags;
		MethodBase[] methodBase_19 = array3;
		ref object[] object_21 = ref reference;
		ParameterModifier[] parameterModifier_6 = array2;
		string[] string_5 = array4;
		Class7 obj60 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class76.t((BindingFlags)class77.j(bindingFlags_67, methodBase_19, ref object_21, parameterModifier_6, null, string_5, out *(object*)((Class7)(object)obj60.e(bindingFlags, array3, array, null)).e((BindingFlags)@class.t(obj, type, null), array3, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array6, (Type)(object)Class5.Default, array, array2))), array5, obj, cultureInfo);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					_ = (GClass3)(object)@class.W((BindingFlags)@class.e(bindingFlags, array3, array, array2), array6, type, array, array2);
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
					class28 = null;
					@struct = @struct;
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					qk = qk;
					_ = (GClass2)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).e(default(BindingFlags), array3, array, (ParameterModifier[])null)), (Type[])(object)((Class7)null).j((BindingFlags)((Class7)null).t(default(BindingFlags), array5, (object)null, (CultureInfo)null), (MethodBase[])(object)((Class7)(object)Class5.Default).W(default(BindingFlags), array6, (Type)(object)Class5.Default, array, array2), ref reference, array2, (CultureInfo)(object)Class5.Default, (string[])(object)@class.j(default(BindingFlags), array3, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)@class.W((BindingFlags)Class5.Default, array6, (Type)(object)Class5.Default, array, array2)), out object_6), array2);
					class11 = class11;
					class30 = class30;
				}
				goto IL_58df;
			}
		}
		goto IL_58df;
		IL_5a0e:
		if (uIntPtr == 0)
		{
			@class = null;
		}
		else
		{
			try
			{
				try
				{
					_ = (Class9)@class.t(Class5.Default, type, null);
				}
				catch
				{
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class78.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, array2);
				}
			}
			catch
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).e(bindingFlags, array3, array, array2);
					qk = qk;
					class26 = (Class0)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
				}
				catch
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj, cultureInfo)) == 0)
					{
						_ = (Class9)(object)Class5.Default;
						class29 = class29;
					}
					else
					{
						class26 = null;
						_ = (Struct1)Class5.Default;
					}
				}
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					Class7 class79 = @class;
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_68 = (BindingFlags)class80.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo), array3, ref *(object[]*)null, null, cultureInfo, null, out *(object*)((Class7)null).j((BindingFlags)@class.t(obj, type, cultureInfo), array3, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out object_6)), (string[])(object)Class5.Default, out *(object*)null);
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj65 = (Class7)(object)class81.W(bindingFlags, array6, type, array, array2);
					object object_22 = Class5.Default;
					Class7 obj66 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_69 = bindingFlags;
					MethodBase[] methodBase_20 = array3;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class79.j(bindingFlags_68, null, ref *(object[]*)null, (ParameterModifier[])obj65.t(object_22, (Type)(object)obj66.j(bindingFlags_69, methodBase_20, ref *(object[]*)((Class7)null).W(bindingFlags, array6, (Type)null, array, (ParameterModifier[])((Class7)null).t((object)null, type, (CultureInfo)null)), null, cultureInfo, array4, out object_6), cultureInfo), null, array4, out *(object*)null);
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					struct2 = (Struct1)((Class7)(object)@class.W((BindingFlags)Class5.Default, null, null, array, array2)).t(Class5.Default, null, cultureInfo);
				}
				else
				{
					gClass3 = gClass3;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			qk = qk;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (GClass3)(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)null).e((BindingFlags)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo), (MethodBase[])null, array, array2), (MethodBase[])(object)Class5.Default, ref reference, array2, null, array4, out object_6);
				}
				while (obj != null);
			}
			finally
			{
				while (obj != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
				goto IL_5ddb;
			}
		}
		_ = (Class6)((Class7)null).t(obj, type, (CultureInfo)null);
		goto IL_5ddb;
		IL_5ddb:
		try
		{
			class26 = null;
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
			}
		}
		_ = (Class0)(object)@class.j(bindingFlags, null, ref reference, null, null, array4, out object_6);
		struct2 = struct2;
		try
		{
			try
			{
				class28 = class28;
			}
			finally
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				goto end_IL_5e1c;
			}
			end_IL_5e1c:;
		}
		finally
		{
			goto IL_5e41;
		}
		IL_54f8:
		checked
		{
			do
			{
				nuint num6 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num6 * (unchecked((nuint)default(UIntPtr)) * uIntPtr) != 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						class26 = null;
					}
					else
					{
						@class = (Class7)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default);
					}
				}
				else
				{
					_ = (GClass3)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array2);
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == 0)
				{
					Class7 class82 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_71 = bindingFlags;
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class82.t(bindingFlags_70, null, null, (CultureInfo)(object)class83.t(bindingFlags_71, (FieldInfo[])((Class7)(object)class84.t(bindingFlags, array5, Class5.Default, null)).t(null, null, null), obj, null));
				}
				else
				{
					_ = (Class7)(object)@class.e(bindingFlags, null, array, null);
					class28 = class28;
				}
			}
			finally
			{
				_ = (GClass1)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), (Type[])null, (ParameterModifier[])@class.t(Class5.Default, null, cultureInfo));
				goto IL_5626;
			}
		}
		goto IL_5626;
		IL_1c90:
		_ = (GClass3)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array2);
		try
		{
			try
			{
				try
				{
					gClass4 = (GClass2)(object)Class5.Default;
				}
				finally
				{
					class11 = class11;
					goto end_IL_1cb3;
				}
				end_IL_1cb3:;
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(((Class7)null).W(bindingFlags, array6, type, array, (ParameterModifier[])null), null, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					class28 = null;
				}
				else
				{
					_ = (Class9)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default));
				}
				goto end_IL_1cb2;
			}
			end_IL_1cb2:;
		}
		finally
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
					class11 = class11;
					_ = (Class5)(object)@class.e(bindingFlags, array3, array, null);
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null);
			goto IL_1da7;
		}
		IL_1c4e:
		try
		{
			do
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					class12 = class12;
				}
			}
			finally
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while ((object)Class5.Default != null);
				goto IL_1c90;
			}
		}
		IL_0bc4:
		uIntPtr = default(UIntPtr);
		if (checked((uIntPtr - uIntPtr) * unchecked((nuint)(UIntPtr)@class.t(obj, type, (CultureInfo)(object)@class.t(bindingFlags, array5, @class.t(bindingFlags, array5, null, cultureInfo), cultureInfo)))) / (nuint)(UIntPtr)Class5.Default == 0 && (UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = Class5.Default;
			}
			finally
			{
				class12 = class12;
				goto IL_0c6d;
			}
		}
		goto IL_0c6d;
		IL_1da7:
		Class7 obj70 = (Class7)(object)@class.W((BindingFlags)Class5.Default, array6, type, (Type[])(object)((Class7)null).e(bindingFlags, array3, (Type[])null, array2), array2);
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj70.e(bindingFlags, array3, array, array2);
		gClass = null;
		Class7 class85;
		BindingFlags bindingFlags_72;
		Class7 class86;
		BindingFlags bindingFlags_73;
		MethodBase[] methodBase_21;
		Type[] type_19;
		Class7 class87;
		do
		{
			_ = (GClass2)(object)Class5.Default;
			class85 = @class;
			bindingFlags_72 = (BindingFlags)((Class7)null).t(((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)@class.t((BindingFlags)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array2), array5, null, null)), (Type)@class.t(((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default), type, cultureInfo), cultureInfo);
			class86 = @class;
			bindingFlags_73 = (BindingFlags)Class5.Default;
			methodBase_21 = (MethodBase[])(object)Class5.Default;
			type_19 = array;
			class87 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class85.e(bindingFlags_72, null, (Type[])(object)class86.e(bindingFlags_73, methodBase_21, type_19, (ParameterModifier[])(object)class87.t(bindingFlags, array5, null, cultureInfo)), array2) != null);
		Class7 class88 = @class;
		BindingFlags bindingFlags_74 = bindingFlags;
		FieldInfo[] fieldInfo_14 = array5;
		object object_23 = obj;
		Class7 obj71 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class88.t(bindingFlags_74, fieldInfo_14, object_23, (CultureInfo)(object)obj71.j(bindingFlags, array3, ref *(object[]*)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, null), (Type[])null, (ParameterModifier[])(object)Class5.Default)).e((BindingFlags)Class5.Default, (MethodBase[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, cultureInfo, array4, out object_6)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, null, out object_6);
				}
			}
			finally
			{
				nuint num7 = uIntPtr;
				nuint num9;
				nuint num10;
				checked
				{
					nuint num8 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					num9 = num7 + (num8 + unchecked((nuint)default(UIntPtr)) * uIntPtr);
					num10 = uIntPtr;
					uIntPtr = default(UIntPtr);
				}
				if (checked(num9 + (num10 + uIntPtr)) == 0)
				{
					Class7 obj72 = (Class7)(object)Class5.Default;
					Class7 obj73 = (Class7)(object)Class5.Default;
					Class7 class89 = @class;
					BindingFlags bindingFlags_75 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_22 = array3;
					ref object[] object_24 = ref reference;
					CultureInfo cultureInfo_6 = cultureInfo;
					string[] string_6 = array4;
					Class7 class90 = @class;
					bindingFlags = default(BindingFlags);
					object object_25 = obj73.e((BindingFlags)class89.j(bindingFlags_75, methodBase_22, ref object_24, null, cultureInfo_6, string_6, out *(object*)class90.e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default)), array3, array, null);
					Type type_20 = (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, (Type[])(object)@class.t(bindingFlags, null, ((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, cultureInfo, array4, out object_6), cultureInfo), null), array4, out *(object*)Class5.Default);
					Class7 class91 = @class;
					BindingFlags bindingFlags_76 = bindingFlags;
					PropertyInfo[] propertyInfo_14 = array6;
					Class7 obj74 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_77 = bindingFlags;
					BindingFlags bindingFlags_78 = (BindingFlags)@class.e(bindingFlags, array3, array, array2);
					MethodBase[] methodBase_23 = array3;
					Type[] type_21 = (Type[])(object)Class5.Default;
					Class7 class92 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)obj72.t(object_25, type_20, (CultureInfo)(object)class91.W(bindingFlags_76, propertyInfo_14, (Type)(object)obj74.e(bindingFlags_77, null, (Type[])((Class7)(object)((Class7)null).e(bindingFlags_78, methodBase_23, type_21, (ParameterModifier[])((Class7)(object)class92.t(bindingFlags, null, obj, cultureInfo)).t(obj, null, null))).t(Class5.Default, (Type)(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)@class.j((BindingFlags)Class5.Default, array3, ref reference, array2, null, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])((Class7)(object)Class5.Default).t(@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, null, out object_6), type, null), out object_6), out object_6), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null)), cultureInfo), (ParameterModifier[])(object)Class5.Default), array, (ParameterModifier[])(object)Class5.Default))).W((BindingFlags)Class5.Default, null, null, (Type[])(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, array2, (CultureInfo)null, (string[])null, out object_6), array2);
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
				goto IL_2379;
			}
		}
		goto IL_2379;
		IL_4b17:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				UIntPtr num11 = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num11) + uIntPtr == 0)
					{
						class30 = class30;
					}
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
					class26 = (Class0)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				goto IL_4b8a;
			}
		}
		goto IL_4b8a;
		IL_0c6d:
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					BindingFlags bindingFlags_79 = bindingFlags;
					Class7 obj75 = (Class7)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo);
					Class7 class93 = @class;
					BindingFlags bindingFlags_80 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_15 = array5;
					object object_26 = obj;
					Class7 class94 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags_79, (FieldInfo[])(object)obj75.j((BindingFlags)class93.t(bindingFlags_80, fieldInfo_15, object_26, (CultureInfo)(object)class94.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, null)), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out object_6), (object)null, cultureInfo);
				}
			}
			finally
			{
				try
				{
					gClass4 = null;
					gClass4 = gClass4;
				}
				catch
				{
					class28 = (Class9)(object)Class5.Default;
				}
				goto end_IL_0c6e;
			}
			end_IL_0c6e:;
		}
		catch
		{
			try
			{
				@struct = default(Struct2);
				@struct = @struct;
			}
			catch
			{
				try
				{
					gClass3 = gClass3;
					goto end_IL_0d83;
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
					goto end_IL_0d83;
				}
				end_IL_0d83:;
			}
		}
		try
		{
			_ = (GClass2)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, array5, obj, cultureInfo), obj, cultureInfo);
		}
		catch
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					_ = (Class7)(object)Class5.Default;
					continue;
				}
				Class7 class95 = @class;
				object object_27 = @class.e(default(BindingFlags), array3, array, (ParameterModifier[])(object)Class5.Default);
				Class7 class96 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj80 = (Class7)(object)((Class7)(object)((Class7)(object)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])null)).t(bindingFlags, array5, obj, cultureInfo)).W(bindingFlags, array6, null, (Type[])(object)Class5.Default, array2);
				BindingFlags bindingFlags_81 = (BindingFlags)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo);
				PropertyInfo[] propertyInfo_15 = (PropertyInfo[])(object)@class.t(bindingFlags, array5, null, cultureInfo);
				Type[] type_22 = array;
				Class7 obj81 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class9)class95.t(object_27, (Type)class96.t(((Class7)null).e(default(BindingFlags), (MethodBase[])(object)obj80.W(bindingFlags_81, propertyInfo_15, null, type_22, (ParameterModifier[])(object)obj81.W(bindingFlags, array6, type, array, array2)), array, (ParameterModifier[])null), type, cultureInfo), null);
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					_ = (Class8)(object)((Class7)null).W((BindingFlags)Class5.Default, array6, type, array, array2);
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					class12 = (Class8)(object)Class5.Default;
				}
				else
				{
					gClass4 = null;
				}
			}
		}
		while (obj != null)
		{
			try
			{
				try
				{
					class13 = class13;
					class13 = null;
				}
				finally
				{
					class33 = (Class10)(object)Class5.Default;
					goto end_IL_0fda;
				}
				end_IL_0fda:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				continue;
			}
		}
		gClass2 = null;
		_ = (Class8)(object)@class.j((BindingFlags)((Class7)null).t(obj, (Type)@class.t(Class5.Default, type, (CultureInfo)(object)((Class7)null).j(bindingFlags, array3, ref reference, array2, (CultureInfo)null, (string[])null, out object_6)), cultureInfo), null, ref *(object[]*)null, array2, null, array4, out *(object*)Class5.Default);
		gClass4 = gClass4;
		nuint num13;
		nuint num14;
		checked
		{
			nuint num12 = uIntPtr - (unchecked((nuint)(UIntPtr)((Class7)(object)@class.t(bindingFlags, null, obj, null)).j(bindingFlags, array3, ref *(object[]*)null, array2, cultureInfo, array4, out *(object*)Class5.Default)) - unchecked((nuint)(UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array3, (Type[])(object)Class5.Default, array2), cultureInfo, null, out object_6)));
			uIntPtr = default(UIntPtr);
			num13 = unchecked(num12 / (unchecked((nuint)default(UIntPtr)) / uIntPtr)) * uIntPtr;
			num14 = uIntPtr;
			uIntPtr = default(UIntPtr);
		}
		if (num13 / (num14 / checked(unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr / uIntPtr) * unchecked((nuint)(UIntPtr)@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default)))) == 0)
		{
			try
			{
				gClass = gClass;
				_ = (Class4)(object)Class5.Default;
				Class7 class97 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_82 = bindingFlags;
				MethodBase[] methodBase_24 = array3;
				ParameterModifier[] parameterModifier_7 = array2;
				string[] string_7 = array4;
				Class7 obj85 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class13 = (Class2)(object)class97.j(bindingFlags_82, methodBase_24, ref *(object[]*)null, parameterModifier_7, null, string_7, out *(object*)((Class7)null).j((BindingFlags)obj85.W(bindingFlags, array6, (Type)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array, array2), array3, ref reference, array2, (CultureInfo)null, (string[])null, out *(object*)null));
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class98 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class98.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null);
				}
				goto IL_1292;
			}
		}
		goto IL_1292;
		IL_45ba:
		try
		{
			while ((object)Class5.Default != null)
			{
				if (uIntPtr == 0)
				{
					Class7 class99 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class99.e(bindingFlags, null, (Type[])(object)Class5.Default, array2);
					@struct = (Struct2)Class5.Default;
					class29 = class29;
				}
				else
				{
					class30 = class30;
				}
			}
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				@class = @class;
			}
			goto IL_4637;
		}
		IL_3510:
		while ((object)Class5.Default != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (GClass2)((Class7)null).t((object)null, type, (CultureInfo)null);
				continue;
			}
			_ = (GClass1)(object)Class5.Default;
			_ = (Class2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type, array, array2), array6, (Type)(object)@class.e(bindingFlags, array3, null, null), (Type[])(object)Class5.Default, array2), (ParameterModifier[])null);
			class12 = null;
			class11 = Class5.Default;
		}
		do
		{
			IL_35bb:
			if (obj != null)
			{
				try
				{
					class12 = (Class8)(object)((Class7)(object)@class.W(bindingFlags, array6, null, array, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)@class.W(bindingFlags, null, type, null, null)).t(bindingFlags, array5, obj, cultureInfo), null, array, null))).t(bindingFlags, array5, obj, cultureInfo);
				}
				finally
				{
					class11 = class11;
					goto IL_35bb;
				}
			}
		}
		while (obj != null);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, array3, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)) == 0)
			{
				unchecked
				{
					if (default(UIntPtr) == (UIntPtr)(nuint)0u)
					{
						if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
						{
							class29 = class29;
							class26 = class26;
							_ = (Class6)(object)Class5.Default;
						}
						else
						{
							gClass2 = gClass2;
							class11 = class11;
							class33 = class33;
						}
					}
					else
					{
						while (obj != null)
						{
							_ = (Class4)(object)Class5.Default;
						}
					}
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class26 = null;
					Class7 class100 = @class;
					BindingFlags bindingFlags_83 = bindingFlags;
					Type[] type_23 = (Type[])(object)Class5.Default;
					Class7 class101 = @class;
					Class7 class102 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class100.e(bindingFlags_83, null, type_23, (ParameterModifier[])(object)class101.e(default(BindingFlags), (MethodBase[])(object)class102.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default), array, null));
				}
			}
			_ = (Qk7)@class.t(obj, type, cultureInfo);
			do
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) != 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
				else if (unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr == 0)
				{
					_ = (GClass1)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out object_6), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
			}
			while (obj != null);
		}
		try
		{
			if (uIntPtr / uIntPtr == 0)
			{
				_ = (Class7)@class.t(obj, null, cultureInfo);
			}
			else
			{
				@struct = @struct;
				gClass = gClass;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			else
			{
				_ = (GClass3)((Class7)null).t((object)null, (Type)null, cultureInfo);
			}
		}
		finally
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
				class26 = class26;
			}
			catch
			{
				_ = (Class2)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
			}
			goto IL_3843;
		}
		IL_4302:
		gClass2 = gClass2;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class103 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class103.e(bindingFlags, array3, array, null);
				}
				finally
				{
					gClass4 = (GClass2)(object)Class5.Default;
					goto end_IL_4316;
				}
				end_IL_4316:;
			}
			finally
			{
				class13 = class13;
				goto IL_435b;
			}
		}
		goto IL_435b;
		IL_4d47:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		else
		{
			class29 = null;
			_003CModule_003E = _003CModule_003E;
			qk = null;
		}
		while (obj != null)
		{
			@struct = (Struct2)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj, cultureInfo), cultureInfo, (string[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), out *(object*)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, array5, obj, null), array, array2));
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) + (uIntPtr - uIntPtr) - unchecked((nuint)(UIntPtr)@class.W((BindingFlags)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.e(bindingFlags, array3, array, null), array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array6, type, array, (ParameterModifier[])(object)Class5.Default))).j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, array, (ParameterModifier[])(object)Class5.Default), array3, ref reference, array2, (CultureInfo)null, (string[])null, out object_6), ref *(object[]*)@class.e(bindingFlags, array3, array, array2), null, null, null, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)), ref *(object[]*)Class5.Default, null, null, null, out object_6), (PropertyInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array6, (Type)(object)Class5.Default, array, array2), null, array, array2))) == 0)
			{
				try
				{
					class33 = class33;
				}
				finally
				{
					BindingFlags bindingFlags_84 = bindingFlags;
					Type type_24 = (Type)(object)Class5.Default;
					Type[] type_25 = array;
					Class7 obj88 = (Class7)(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref reference, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, (CultureInfo)(object)@class.t(bindingFlags, array5, obj, null), array4, out object_6), (string[])(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo), out object_6));
					object object_28 = Class5.Default;
					Class7 class104 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj89 = (Class7)obj88.t(object_28, (Type)(object)class104.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default), null);
					Class7 class105 = @class;
					object object_29 = @class.t(obj, type, null);
					Class7 obj90 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_85 = bindingFlags;
					Class7 class106 = @class;
					Class7 obj91 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_86 = bindingFlags;
					FieldInfo[] fieldInfo_16 = (FieldInfo[])(object)Class5.Default;
					object object_30 = @class.t(obj, type, cultureInfo);
					Class7 class107 = @class;
					BindingFlags bindingFlags_87 = (BindingFlags)@class.t(null, type, (CultureInfo)(object)Class5.Default);
					PropertyInfo[] propertyInfo_16 = (PropertyInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array2);
					Type type_26 = type;
					Type[] type_27 = array;
					Class7 obj92 = (Class7)(object)@class.e(default(BindingFlags), null, array, array2);
					bindingFlags = default(BindingFlags);
					Class7 obj93 = (Class7)(object)obj90.t(bindingFlags_85, (FieldInfo[])(object)class106.W((BindingFlags)obj91.t(bindingFlags_86, fieldInfo_16, object_30, (CultureInfo)(object)class107.W(bindingFlags_87, propertyInfo_16, type_26, type_27, (ParameterModifier[])(object)obj92.j(bindingFlags, null, ref reference, null, cultureInfo, array4, out *(object*)null))), array6, null, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo)), Class5.Default, null);
					BindingFlags bindingFlags_88 = bindingFlags;
					Class7 class108 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).W(bindingFlags_84, (PropertyInfo[])null, type_24, type_25, (ParameterModifier[])obj89.t(class105.t(object_29, null, (CultureInfo)(object)obj93.j(bindingFlags_88, (MethodBase[])(object)class108.W((BindingFlags)((Class7)null).j(bindingFlags, array3, ref *(object[]*)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])null), array2, cultureInfo, array4, out object_6), array6, type, array, null), ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), array2, (CultureInfo)(object)Class5.Default, null, out *(object*)null)), type, (CultureInfo)(object)Class5.Default));
					class33 = class33;
					struct2 = default(Struct1);
					_ = (Class0)(object)@class.W(bindingFlags, null, type, array, array2);
					continue;
				}
			}
		}
		do
		{
			gClass = gClass;
		}
		while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array2) != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = null;
					Class7 class109 = @class;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)class109.t(bindingFlags, array5, ((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out object_6), type, (Type[])null, array2), cultureInfo);
					_ = (GClass3)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					gClass3 = gClass3;
					_ = (Class2)(object)Class5.Default;
					goto IL_54f8;
				}
			}
			_ = (Struct1)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.e(bindingFlags, null, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, array5, null, null), type, (Type[])null, array2), null), array, array2);
		}
		else
		{
			gClass4 = (GClass2)(object)Class5.Default;
		}
		goto IL_54f8;
		IL_2379:
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				gClass = (GClass1)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				_ = Class5.Default;
				continue;
			}
		}
		while (obj != null);
		if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out object_6), (ParameterModifier[])@class.t(Class5.Default, null, cultureInfo)) == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
			class33 = (Class10)(object)Class5.Default;
		}
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).t(bindingFlags, array5, obj, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class30 = class30;
					class30 = class30;
					Class7 class110 = @class;
					BindingFlags bindingFlags_89 = bindingFlags;
					FieldInfo[] fieldInfo_17 = array5;
					object object_31 = obj;
					Class7 class111 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class110.t(bindingFlags_89, fieldInfo_17, object_31, (CultureInfo)(object)class111.W(bindingFlags, array6, (Type)(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, cultureInfo, null, out object_6), array, array2));
					struct2 = default(Struct1);
					struct2 = struct2;
					struct2 = default(Struct1);
					struct2 = struct2;
				}
				finally
				{
					object object_32 = obj;
					Class7 class112 = @class;
					object object_33 = Class5.Default;
					Type type_28 = type;
					Class7 obj94 = (Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_90 = bindingFlags;
					MethodBase[] methodBase_25 = array3;
					ref object[] object_34 = ref reference;
					ParameterModifier[] parameterModifier_8 = array2;
					CultureInfo cultureInfo_7 = cultureInfo;
					Class7 obj95 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)((Class7)null).t(object_32, (Type)class112.t(object_33, type_28, (CultureInfo)(object)obj94.j(bindingFlags_90, methodBase_25, ref object_34, parameterModifier_8, cultureInfo_7, (string[])(object)obj95.t(bindingFlags, array5, obj, cultureInfo), out object_6)), cultureInfo);
					goto end_IL_2464;
				}
				end_IL_2464:;
			}
			finally
			{
				try
				{
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array2);
				}
				catch
				{
					object object_35 = Class5.Default;
					Type type_29 = type;
					Class7 class113 = @class;
					BindingFlags bindingFlags_91 = bindingFlags;
					PropertyInfo[] propertyInfo_17 = (PropertyInfo[])(object)Class5.Default;
					Class7 class114 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj96 = (Class7)((Class7)null).t(object_35, type_29, (CultureInfo)(object)class113.t(bindingFlags_91, (FieldInfo[])(object)((Class7)null).W(default(BindingFlags), propertyInfo_17, (Type)(object)class114.e(bindingFlags, null, (Type[])(object)@class.j(bindingFlags, array3, ref reference, array2, null, array4, out object_6), array2), array, array2), null, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array3, null, array2)));
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj96.t(bindingFlags, array5, null, null);
				}
				goto IL_26d5;
			}
		}
		goto IL_26d5;
		IL_6165:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Class7 obj98 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)obj98.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, null, array4, out object_6);
		}
		try
		{
			while (obj != null)
			{
				do
				{
					Class7 class115 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_92 = bindingFlags;
					object object_36 = obj;
					Class7 class116 = @class;
					BindingFlags bindingFlags_93 = (BindingFlags)Class5.Default;
					ref object[] object_37 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_9 = array2;
					CultureInfo cultureInfo_8 = cultureInfo;
					Class7 class117 = @class;
					BindingFlags bindingFlags_94 = bindingFlags;
					Class7 class118 = @class;
					Class7 class119 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_95 = (BindingFlags)class119.t(bindingFlags, array5, obj, cultureInfo);
					MethodBase[] methodBase_26 = array3;
					ParameterModifier[] parameterModifier_10 = array2;
					CultureInfo cultureInfo_9 = (CultureInfo)(object)@class.e((BindingFlags)@class.e((BindingFlags)Class5.Default, array3, (Type[])@class.t(null, (Type)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), cultureInfo), null), array3, (Type[])(object)((Class7)(object)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo), (CultureInfo)(object)Class5.Default, array4, out object_6)).W(bindingFlags, array6, null, array, array2), (ParameterModifier[])(object)Class5.Default);
					Class7 obj99 = (Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class115.t(bindingFlags_92, null, object_36, (CultureInfo)(object)class116.j(bindingFlags_93, null, ref object_37, parameterModifier_9, cultureInfo_8, (string[])(object)class117.e(bindingFlags_94, null, (Type[])(object)class118.j(bindingFlags_95, methodBase_26, ref *(object[]*)null, parameterModifier_10, cultureInfo_9, (string[])(object)obj99.W(bindingFlags, array6, type, array, array2), out object_6), array2), out object_6));
				}
				while (obj != null);
			}
		}
		catch
		{
			if (checked(uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				try
				{
					class33 = class33;
					_ = (Struct2)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_6);
				}
				catch
				{
					gClass3 = (GClass3)(object)Class5.Default;
					gClass4 = (GClass2)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.t(bindingFlags, array5, null, cultureInfo)).W(bindingFlags, array6, null, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array3, array, array2)), ((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), null)), array6, (Type)(object)@class.W(bindingFlags, null, type, null, array2), (Type[])null, array2), null, array2);
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			gClass2 = gClass2;
		}
		else
		{
			@class = @class;
		}
	}

	unsafe static void smethod_6()
	{
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] methodBase_ = null;
		ref object[] reference = ref reference;
		ref object[] object_ = ref reference;
		object obj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		Class7 @class = (Class7)((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default)).t(obj, (Type)(object)Class5.Default, cultureInfo_);
		Class7 class2 = @class;
		Class7 class3 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj2 = (Class7)class2.t(class3.j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null), (Type)(object)Class5.Default, cultureInfo_);
		BindingFlags bindingFlags_2 = bindingFlags;
		Type[] array = null;
		ParameterModifier[] array2 = array2;
		BindingFlags bindingFlags_3 = (BindingFlags)((Class7)null).e(bindingFlags_2, methodBase_, array, array2);
		PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
		cultureInfo_ = (CultureInfo)(object)obj2.W(bindingFlags_3, propertyInfo_, null, null, array2);
		nuint uIntPtr = (UIntPtr)((Class7)null).j(bindingFlags_, methodBase_, ref object_, (ParameterModifier[])null, cultureInfo_, (string[])null, out *(object*)null);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		if (uIntPtr == 0)
		{
			gClass = null;
			gClass = null;
		}
		else
		{
			Class7 class4 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_4 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, null, Class5.Default, null);
			ref object[] object_2 = ref reference;
			Class7 class5 = @class;
			BindingFlags bindingFlags_5 = bindingFlags;
			array3 = array3;
			ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)((Class7)(object)class5.t(bindingFlags_5, array3, Class5.Default, cultureInfo_)).e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
			Class7 class6 = @class;
			object object_3 = obj;
			Class7 class7 = @class;
			bindingFlags = default(BindingFlags);
			Type type_ = (Type)(object)class7.e(bindingFlags, null, array, null);
			Class7 class8 = @class;
			BindingFlags bindingFlags_6 = (BindingFlags)Class5.Default;
			ParameterModifier[] parameterModifier_2 = array2;
			array4 = array4;
			_ = (Class6)(object)((Class7)(object)class4.j(bindingFlags_4, methodBase_2, ref object_2, parameterModifier_, (CultureInfo)class6.t(object_3, type_, (CultureInfo)(object)class8.j(bindingFlags_6, methodBase_, ref *(object[]*)null, parameterModifier_2, null, array4, out *(object*)((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo_)).t(obj, null, (CultureInfo)(object)Class5.Default))), array4, out *(object*)Class5.Default)).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array2);
			_ = (GClass3)(object)@class.e(bindingFlags, methodBase_, null, array2);
			_ = (GClass0)(object)Class5.Default;
			_ = (GClass2)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class9);
		while (obj != null)
		{
			if ((UIntPtr)@class.t(null, null, null) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
				continue;
			}
			try
			{
				_ = (Struct1)((Class7)(object)Class5.Default).W(bindingFlags, null, null, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, methodBase_, array, null));
				class9 = class9;
				class9 = class9;
			}
			catch
			{
				gClass = (GClass1)((Class7)(object)Class5.Default).t(obj, null, null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			gClass2 = gClass2;
			gClass2 = gClass2;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
			else
			{
				Class7 class10 = @class;
				object object_4 = Class5.Default;
				type = null;
				Struct2 obj4 = (Struct2)class10.t(object_4, type, null);
				@struct = (Struct2)@class.t(bindingFlags, array3, obj, null);
				@struct = obj4;
				gClass = gClass;
			}
			goto IL_05ee;
		}
		IL_1ee4:
		Struct1 struct2 = (Struct1)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		else if (uIntPtr == 0)
		{
			do
			{
				_ = (GClass1)(object)Class5.Default;
			}
			while (obj != null);
		}
		ref object[] object_5 = ref reference;
		ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_2 = cultureInfo_;
		Class7 class11 = @class;
		Class7 class12 = @class;
		object object_6 = obj;
		bindingFlags = default(BindingFlags);
		struct2 = (Struct1)((Class7)null).j(default(BindingFlags), methodBase_, ref object_5, parameterModifier_3, cultureInfo_2, (string[])(object)class11.t(default(BindingFlags), (FieldInfo[])class12.t(object_6, (Type)(object)((Class7)null).e(bindingFlags, methodBase_, array, array2), cultureInfo_), null, (CultureInfo)(object)Class5.Default), out *(object*)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		try
		{
			nuint num = uIntPtr;
			UIntPtr num2 = (UIntPtr)Class5.Default;
			BindingFlags bindingFlags_7 = bindingFlags;
			ref object[] object_7 = ref *(object[]*)((Class7)(object)Class5.Default).t(bindingFlags, array3, obj, (CultureInfo)(object)Class5.Default);
			ParameterModifier[] parameterModifier_4 = array2;
			CultureInfo cultureInfo_3 = cultureInfo_;
			string[] string_ = (string[])(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), type, array, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])@class.t(obj, null, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo_)), cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, null, cultureInfo_, array4, out *(object*)Class5.Default), out *(object*)null));
			bindingFlags = default(BindingFlags);
			if (checked(num + (unchecked((nuint)num2) - unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_7, methodBase_, ref object_7, parameterModifier_4, cultureInfo_3, string_, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), array2), array2))))) == 0)
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				Class7 obj6 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class9 = (Class2)(object)obj6.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, null, null, array2), null, cultureInfo_);
			}
			catch
			{
				struct2 = struct2;
			}
			finally
			{
				if ((nuint)(UIntPtr)@class.t(obj, (Type)(object)Class5.Default, null) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					Class7 obj8 = (Class7)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), propertyInfo_, type, array, (ParameterModifier[])(object)Class5.Default);
					Class7 class13 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj8.t((BindingFlags)class13.t(((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2), (Type)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, array4, out reference2), cultureInfo_), (FieldInfo[])(object)Class5.Default, Class5.Default, null);
				}
				goto end_IL_2189;
			}
			end_IL_2189:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class14);
		try
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = null;
					class14 = null;
				}
				catch
				{
					gClass = gClass;
				}
			}
			goto IL_2324;
		}
		IL_2c99:
		Class7 class15 = @class;
		Class7 class16 = @class;
		BindingFlags bindingFlags_8 = bindingFlags;
		Class7 class17 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)class15.W((BindingFlags)class16.W(bindingFlags_8, null, null, array, (ParameterModifier[])(object)class17.j(bindingFlags, methodBase_, ref reference, null, cultureInfo_, null, out reference2)), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, array2);
		Class4 class18 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class19);
		try
		{
			while ((object)Class5.Default != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class19 = (Class6)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)((Class7)null).e(bindingFlags, methodBase_, array, array2);
					goto end_IL_2d35;
				}
				end_IL_2d35:;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class18 = class18;
				}
				else
				{
					class19 = class19;
					_ = (Class8)(object)Class5.Default;
					gClass3 = null;
				}
				goto end_IL_2d34;
			}
			end_IL_2d34:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class22);
		GClass2 gClass4;
		try
		{
			Class7 class20 = @class;
			BindingFlags bindingFlags_9 = bindingFlags;
			Class7 class21 = @class;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)class20.e(bindingFlags_9, (MethodBase[])(object)class21.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj, null)), (Type[])((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out *(object*)null)).t(@class.e((BindingFlags)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, array2, cultureInfo_, (string[])((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default), out reference2), methodBase_, array, array2), type, (CultureInfo)@class.t(null, (Type)(object)((Class7)((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default)).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_)).W((BindingFlags)Class5.Default, propertyInfo_, null, array, array2), null)), null);
			_ = (Class4)(object)Class5.Default;
			_ = (Class6)(object)Class5.Default;
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					class22 = class22;
				}
			}
			goto IL_2f30;
		}
		IL_3556:
		if (uIntPtr == 0)
		{
			Class7 class23 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class23.j(bindingFlags, methodBase_, ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out reference2) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Struct1)Class5.Default;
				}
			}
		}
		try
		{
			class14 = class14;
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class9 = class9;
				}
				else
				{
					_ = (Class4)@class.t(null, null, cultureInfo_);
				}
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		try
		{
			gClass4 = gClass4;
		}
		finally
		{
			_ = (Class6)(object)Class5.Default;
			goto IL_3692;
		}
		IL_0d1d:
		Class7 obj14 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_10 = bindingFlags;
		Class7 class24 = @class;
		ref object[] object_8 = ref reference;
		Class7 class25 = @class;
		BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
		Class7 class26 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)((Class7)null).t((object)obj14.t(bindingFlags_10, (FieldInfo[])(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, (Type)null, (Type[])(object)class24.j(default(BindingFlags), methodBase_, ref object_8, (ParameterModifier[])(object)class25.e(bindingFlags_11, methodBase_, array, (ParameterModifier[])((Class7)null).t((object)class26.W(bindingFlags, propertyInfo_, null, array, null), (Type)null, cultureInfo_)), (CultureInfo)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)@class.t((BindingFlags)Class5.Default, array3, null, null), null, array2), array4, out reference2), (ParameterModifier[])(object)Class5.Default), obj, cultureInfo_), (Type)null, cultureInfo_);
		_ = (Class7)(object)Class5.Default;
		class14 = null;
		_ = (Class2)(object)@class.t((BindingFlags)@class.t(Class5.Default, type, null), null, obj, cultureInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				do
				{
					_003CModule_003E obj15 = (_003CModule_003E)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)@class.e(bindingFlags, methodBase_, array, array2)).j(bindingFlags, methodBase_, ref *(object[]*)null, array2, cultureInfo_, null, out reference2), type, null, array2);
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj15;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 obj17 = (Class7)(object)((Class7)null).W((BindingFlags)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array4, out reference2), propertyInfo_, type, array, (ParameterModifier[])(object)@class.t(bindingFlags, array3, obj, null));
					BindingFlags bindingFlags_12 = bindingFlags;
					Type type_2 = type;
					Class7 obj18 = (Class7)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_13 = bindingFlags;
					MethodBase[] methodBase_3 = (MethodBase[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array4, out reference2);
					ref object[] object_9 = ref *(object[]*)@class.t(((Class7)(object)Class5.Default).e(bindingFlags, null, array, array2), type, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type, array, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_)), null));
					Class7 obj19 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, array2);
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)obj19.e(bindingFlags, methodBase_, (Type[])@class.t(Class5.Default, type, cultureInfo_), array2);
					Class7 obj20 = (Class7)(object)@class.e(bindingFlags, methodBase_, array, array2);
					object object_10 = obj;
					Type type_3 = type;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj17.W(bindingFlags_12, null, type_2, (Type[])(object)obj18.j(bindingFlags_13, methodBase_3, ref object_9, parameterModifier_5, (CultureInfo)obj20.t(object_10, type_3, (CultureInfo)(object)((Class7)(object)class27.W(bindingFlags, propertyInfo_, null, null, array2)).W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, array2)), null, out reference2), (ParameterModifier[])@class.t(null, type, null));
					_ = (GClass0)(object)Class5.Default;
					_ = (Class4)(object)((Class7)(object)Class5.Default).t(bindingFlags, array3, obj, null);
				}
			}
			catch
			{
				try
				{
					class9 = class9;
					goto end_IL_11a1;
				}
				catch
				{
					gClass3 = gClass3;
					gClass3 = null;
					goto end_IL_11a1;
				}
				end_IL_11a1:;
			}
		}
		checked
		{
			try
			{
				nuint num3 = unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num3 - uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = (Struct2)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out reference2);
						_ = (Qk7)((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default);
						_ = (GClass0)(object)Class5.Default;
					}
					else
					{
						_ = (Class10)(object)Class5.Default;
					}
				}
			}
			catch
			{
				try
				{
					while (obj != null)
					{
						_ = (Class0)((Class7)@class.t(obj, type, cultureInfo_)).t(obj, type, null);
					}
				}
				finally
				{
					if (uIntPtr == 0)
					{
						struct2 = default(Struct1);
					}
					goto end_IL_125c;
				}
				end_IL_125c:;
			}
			while (obj != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
			uIntPtr = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class28);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					class14 = null;
				}
			}
			else
			{
				_ = Class5.Default;
				_003CModule_003E = _003CModule_003E;
				class28 = class28;
				class28 = class28;
				_ = (Class7)(object)Class5.Default;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					@class = null;
				}
			}
		}
		while ((object)Class5.Default != null);
		while (obj != null)
		{
			try
			{
				try
				{
					gClass2 = null;
				}
				finally
				{
					Class7 obj25 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_14 = (BindingFlags)@class.e(bindingFlags, null, array, array2);
					Type[] type_4 = (Type[])(object)Class5.Default;
					Class7 class29 = @class;
					Class7 obj26 = (Class7)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = (BindingFlags)((Class7)(object)obj26.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, array2)).t(bindingFlags, array3, obj, cultureInfo_);
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					Type[] type_5 = (Type[])(object)class30.j(bindingFlags, null, ref reference, array2, null, null, out reference2);
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj25.e(bindingFlags_14, null, type_4, (ParameterModifier[])(object)((Class7)(object)class29.e(bindingFlags_15, null, type_5, (ParameterModifier[])(object)class31.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null))).t(bindingFlags, array3, Class5.Default, (CultureInfo)(object)Class5.Default));
					gClass = gClass;
					_ = (Class2)((Class7)null).t((object)null, type, cultureInfo_);
					_ = (Class4)((Class7)null).t((object)null, (Type)null, cultureInfo_);
					goto end_IL_1390;
				}
				end_IL_1390:;
			}
			finally
			{
				try
				{
					class14 = class14;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					continue;
				}
			}
		}
		Class7 class32 = @class;
		BindingFlags bindingFlags_16 = bindingFlags;
		FieldInfo[] fieldInfo_ = array3;
		Class7 class33 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class32.t(bindingFlags_16, fieldInfo_, ((Class7)((Class7)null).t((object)null, (Type)(object)class33.t(bindingFlags, array3, obj, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null)), cultureInfo_)).e((BindingFlags)Class5.Default, methodBase_, null, array2), cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Class7 class34 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_17 = bindingFlags;
				Class7 class35 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
				ref object[] object_11 = ref reference;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_19 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				ref object[] object_12 = ref reference;
				ParameterModifier[] parameterModifier_6 = array2;
				CultureInfo cultureInfo_4 = cultureInfo_;
				string[] string_2 = (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo_);
				object object_13 = @class.W(bindingFlags, propertyInfo_, null, array, array2);
				Type type_6 = (Type)(object)Class5.Default;
				Class7 class36 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)((Class7)(object)class34.j(bindingFlags_17, (MethodBase[])(object)class35.j(bindingFlags_18, methodBase_4, ref object_11, null, null, null, out *(object*)((Class7)null).j(bindingFlags_19, methodBase_5, ref object_12, parameterModifier_6, cultureInfo_4, string_2, out *(object*)((Class7)null).t(object_13, type_6, (CultureInfo)(object)class36.W(bindingFlags, null, type, array, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array2)))))), ref *(object[]*)Class5.Default, array2, null, array4, out *(object*)null)).t(Class5.Default, type, cultureInfo_);
			}
			else
			{
				_ = (GClass0)(object)@class.W(bindingFlags, propertyInfo_, type, null, array2);
				@class = @class;
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				struct2 = struct2;
			}
			catch
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					Class7 class37 = @class;
					BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
					Class7 class38 = @class;
					object object_14 = obj;
					Class7 class39 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_21 = bindingFlags;
					Class7 obj28 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 class40 = @class;
					Class7 class41 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj29 = (Class7)(object)class41.j(default(BindingFlags), methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, propertyInfo_, type, array, null), ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, (string[])null, out reference2), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2);
					BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_2 = array3;
					object object_15 = obj;
					Class7 class42 = @class;
					BindingFlags bindingFlags_24 = bindingFlags;
					Type type_7 = (Type)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					ref object[] object_16 = ref *(object[]*)class40.e(default(BindingFlags), methodBase_, (Type[])(object)obj29.t(bindingFlags_23, fieldInfo_2, object_15, (CultureInfo)(object)class42.W(bindingFlags_24, propertyInfo_, type_7, (Type[])(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, array2, (CultureInfo)(object)@class.W(bindingFlags, propertyInfo_, null, null, null), (string[])(object)@class.W(bindingFlags, propertyInfo_, type, null, array2), out reference2), null)), array2);
					Class7 obj30 = (Class7)((Class7)null).t(obj, type, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class37.j(bindingFlags_20, methodBase_, ref *(object[]*)null, null, (CultureInfo)class38.t(object_14, (Type)(object)class39.e(bindingFlags_21, methodBase_, null, (ParameterModifier[])(object)obj28.j(bindingFlags_22, methodBase_, ref object_16, (ParameterModifier[])(object)obj30.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo_), (object)null, cultureInfo_), null, (Type[])(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array2)).e(bindingFlags, null, array, null), array2), cultureInfo_, array4, out *(object*)null)), cultureInfo_), null, out reference2);
					_ = (Class2)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array, (ParameterModifier[])null), array2);
					_ = (GClass3)(object)Class5.Default;
					_ = (Class10)(object)Class5.Default;
				}
				while (obj != null);
			}
			else if (uIntPtr == 0)
			{
				gClass3 = gClass3;
			}
			else
			{
				_ = (Class10)(object)Class5.Default;
				Class4 obj31 = (Class4)@class.t(obj, null, null);
				class18 = class18;
				class18 = obj31;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)@class.e(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo_), array, array2);
					_ = (GClass3)(object)@class.W(default(BindingFlags), propertyInfo_, type, null, null);
					_ = (_003CModule_003E)(object)Class5.Default;
					@struct = @struct;
				}
			}
		}
		Class7 class43 = @class;
		bindingFlags = default(BindingFlags);
		Qk7 qk;
		checked
		{
			nuint num4 = unchecked((nuint)(UIntPtr)class43.t(bindingFlags, array3, obj, cultureInfo_)) * uIntPtr + unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			UIntPtr num5 = uIntPtr;
			UIntPtr num6 = uIntPtr;
			UIntPtr num7 = unchecked((UIntPtr)Class5.Default);
			uIntPtr = default(UIntPtr);
			if (num4 - (unchecked((nuint)num5) + (unchecked((nuint)num6) + (unchecked((nuint)num7) + uIntPtr - uIntPtr))) == 0)
			{
				while (obj != null)
				{
					do
					{
						qk = (Qk7)((Class7)(object)Class5.Default).t(obj, type, cultureInfo_);
					}
					while ((object)@class.W(unchecked((BindingFlags)Class5.Default), null, null, null, (ParameterModifier[])(object)Class5.Default) != null);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class44);
		if (uIntPtr != 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
				}
			}
			else
			{
				class44 = class44;
			}
		}
		gClass2 = gClass2;
		_ = (Class7)(object)Class5.Default;
		qk = (Qk7)(object)Class5.Default;
		try
		{
		}
		finally
		{
			do
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_1c3a;
		}
		IL_05ee:
		while (obj != null)
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
				Class7 class45 = @class;
				Class7 class46 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class45.t((BindingFlags)((Class7)(object)class46.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default)).t(null, type, null), null, obj, cultureInfo_);
				Class7 obj34 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_25 = bindingFlags;
				ref object[] object_17 = ref reference;
				CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj, cultureInfo_);
				reference2 = ref reference2;
				_ = (Class7)(object)obj34.j(bindingFlags_25, methodBase_, ref object_17, null, cultureInfo_5, null, out reference2);
			}
			finally
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_26 = bindingFlags;
					Class7 obj35 = (Class7)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).e(bindingFlags_26, (MethodBase[])(object)obj35.j(bindingFlags_27, (MethodBase[])(object)class47.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.e(bindingFlags, null, null, null), array2), ref reference, null, (CultureInfo)(object)@class.e((BindingFlags)@class.W(default(BindingFlags), propertyInfo_, (Type)(object)@class.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, array2, cultureInfo_, array4, out *(object*)Class5.Default), array, (ParameterModifier[])(object)Class5.Default), methodBase_, null, (ParameterModifier[])(object)Class5.Default), array4, out *(object*)null), (Type[])null, (ParameterModifier[])null);
					_ = (GClass3)(object)@class.W(default(BindingFlags), null, type, array, array2);
				}
				catch
				{
					gClass4 = null;
					gClass4 = null;
				}
				continue;
			}
		}
		Class9 class48 = class48;
		class48 = null;
		_ = (Struct2)Class5.Default;
		Class7 class49 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)class49.e(bindingFlags, methodBase_, array, array2);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class48 = class48;
				}
			}
			goto IL_0747;
		}
		try
		{
			class14 = class14;
			class14 = class14;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Class7 class50 = @class;
				object object_18 = obj;
				Type type_8 = type;
				Class7 class51 = @class;
				bindingFlags = default(BindingFlags);
				qk = (Qk7)class50.t(object_18, type_8, (CultureInfo)(object)class51.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, array2, cultureInfo_, array4, out reference2), propertyInfo_, type, null, null), null, array2));
				qk = null;
			}
			else
			{
				gClass = gClass;
			}
			goto IL_0747;
		}
		IL_3692:
		while ((object)Class5.Default != null)
		{
			try
			{
				class28 = (Class0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_)), null, cultureInfo_), (Type)null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				@class = null;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class52 = @class;
					Class7 class53 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = (BindingFlags)class53.e(bindingFlags, null, array, array2);
					ParameterModifier[] parameterModifier_7 = array2;
					Class7 obj38 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class18 = (Class4)(object)class52.e((BindingFlags)((Class7)null).j(bindingFlags_28, methodBase_, ref *(object[]*)null, parameterModifier_7, (CultureInfo)((Class7)(object)obj38.t(bindingFlags, (FieldInfo[])@class.t(obj, type, cultureInfo_), obj, cultureInfo_)).t(obj, type, (CultureInfo)(object)Class5.Default), array4, out reference2), methodBase_, array, null);
				}
			}
			finally
			{
				goto IL_393d;
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array3, null, (CultureInfo)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out reference2))) + uIntPtr) == 0)
		{
			try
			{
				gClass3 = (GClass3)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass0)(object)Class5.Default;
				_ = (Qk7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo_));
				_ = (Class4)(object)Class5.Default;
			}
		}
		else if (uIntPtr == 0)
		{
			_ = (GClass2)(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])@class.t(null, (Type)(object)((Class7)null).t(bindingFlags, array3, obj, cultureInfo_), cultureInfo_), type, (Type[])(object)Class5.Default, array2)).t((BindingFlags)((Class7)null).j((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, (Type)null, array, (ParameterModifier[])null), type, null, array2), methodBase_, ref *(object[]*)Class5.Default, array2, (CultureInfo)null, array4, out reference2), null, @class.e(bindingFlags, methodBase_, null, array2), cultureInfo_);
		}
		else
		{
			class18 = class18;
		}
		goto IL_393d;
		IL_1e63:
		_ = (Class6)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, array, array2), (string[])(object)Class5.Default, out reference2);
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				qk = qk;
			}
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			goto IL_1ee4;
		}
		IL_3c1e:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class6)(object)((Class7)null).W(bindingFlags, propertyInfo_, type, array, array2);
				}
			}
		}
		finally
		{
			do
			{
				class14 = (Class8)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, cultureInfo_, array4, out reference2);
			}
			while (obj != null);
			goto IL_3d57;
		}
		IL_47c1:
		while (obj != null)
		{
			if (checked(unchecked((nuint)(UIntPtr)@class.t(bindingFlags, null, obj, cultureInfo_) / uIntPtr / uIntPtr) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				class22 = null;
				Class7 class54 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj41 = (Class7)(object)class54.t(bindingFlags, null, null, null);
				Class7 obj42 = (Class7)(object)Class5.Default;
				Class7 class55 = @class;
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 class56 = @class;
				object object_19 = obj;
				Class7 class57 = @class;
				BindingFlags bindingFlags_30 = bindingFlags;
				Class7 class58 = @class;
				Class7 obj43 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj44 = (Class7)(object)class57.t(bindingFlags_30, (FieldInfo[])(object)((Class7)class58.t(obj43.t(bindingFlags, array3, obj, (CultureInfo)(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo_)), type, cultureInfo_)).e(bindingFlags, null, array, array2), obj, (CultureInfo)(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_31 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
				Class7 obj45 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_32 = bindingFlags;
				MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
				Class7 class59 = @class;
				bindingFlags = default(BindingFlags);
				Type type_9 = (Type)(object)obj44.W(bindingFlags_31, propertyInfo_2, (Type)(object)obj45.j(bindingFlags_32, methodBase_6, ref *(object[]*)((Class7)(object)class59.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo_, array4, out reference2)).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), array3, Class5.Default, cultureInfo_), cultureInfo_, array4, out *(object*)@class.t(obj, (Type)(object)Class5.Default, cultureInfo_)), array2, cultureInfo_, array4, out reference2), (ParameterModifier[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null), (Type[])((Class7)null).t((object)null, type, cultureInfo_), null);
				bindingFlags = default(BindingFlags);
				Class7 obj46 = (Class7)class56.t(object_19, type_9, (CultureInfo)(object)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array3, obj, null), cultureInfo_, array4, out reference2)).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out reference2));
				BindingFlags bindingFlags_33 = bindingFlags;
				object object_20 = obj;
				Class7 class60 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)obj41.t(obj42.j((BindingFlags)class55.e(bindingFlags_29, (MethodBase[])(object)((Class7)null).W((BindingFlags)obj46.t(bindingFlags_33, null, object_20, (CultureInfo)(object)class60.e(bindingFlags, methodBase_, null, null)), (PropertyInfo[])null, (Type)(object)@class.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, array2), (Type[])(object)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out reference2)).e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])(object)Class5.Default), array, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj, cultureInfo_)), array2), array, array2), methodBase_, ref reference, null, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_), null, out *(object*)Class5.Default), null, (CultureInfo)(object)Class5.Default);
			}
		}
		_ = (GClass1)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, array2);
		_ = (GClass1)(object)Class5.Default;
		_ = (Class5)(object)@class.W(bindingFlags, null, type, array, (ParameterModifier[])(object)Class5.Default);
		try
		{
			Class7 class61 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class61.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, null), ref *(object[]*)null, array2, cultureInfo_, array4, out reference2) == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					class22 = class22;
					_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array2, null, (string[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array, (ParameterModifier[])(object)Class5.Default), out *(object*)Class5.Default);
				}
				else
				{
					class14 = class14;
				}
			}
		}
		catch
		{
			_ = (Struct2)((Class7)(object)Class5.Default).t(default(BindingFlags), array3, Class5.Default, (CultureInfo)(object)Class5.Default);
			class28 = class28;
			_ = Class5.Default;
		}
		if ((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr)) != 0)
		{
		}
		class22 = Class5.Default;
		_ = (GClass0)(object)Class5.Default;
		return;
		IL_2ab6:
		try
		{
			while (obj != null)
			{
				@struct = default(Struct2);
				@struct = @struct;
			}
		}
		catch
		{
			nuint num8 = (nuint)(UIntPtr)Class5.Default / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)));
			UIntPtr num9 = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if (checked(num8 - (unchecked((nuint)num9) - uIntPtr)) == 0)
			{
				while ((object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array2) != null)
				{
					qk = qk;
				}
			}
		}
		if (uIntPtr == 0)
		{
			class22 = (Class5)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, null, array, array2);
			class22 = class22;
		}
		if (uIntPtr == 0)
		{
			_ = (Class10)(object)((Class7)null).W((BindingFlags)@class.j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, array4, out reference2), null, ref *(object[]*)null, array2, cultureInfo_, array4, out *(object*)((Class7)null).t(obj, (Type)null, cultureInfo_)), propertyInfo_, (Type)null, (Type[])(object)Class5.Default, array2);
		}
		class48 = class48;
		try
		{
			gClass2 = null;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			goto IL_2c99;
		}
		IL_0747:
		while (obj != null)
		{
			try
			{
			}
			catch
			{
				do
				{
					@class = null;
				}
				while (obj != null);
			}
		}
		while ((object)Class5.Default != null)
		{
		}
		while (obj != null)
		{
			class19 = null;
			class19 = class19;
		}
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class62.j(bindingFlags, methodBase_, ref *(object[]*)null, array2, null, array4, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class19 = (Class6)(object)Class5.Default;
				}
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (Struct2)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo_));
					Class7 obj50 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_34 = bindingFlags;
					Type type_10 = type;
					Class7 obj51 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array2);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_35 = bindingFlags;
					ref object[] object_21 = ref reference;
					CultureInfo cultureInfo_6 = cultureInfo_;
					string[] string_3 = array4;
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)obj50.W(bindingFlags_34, propertyInfo_, type_10, (Type[])(object)obj51.j(bindingFlags_35, null, ref object_21, null, cultureInfo_6, string_3, out *(object*)class63.t(bindingFlags, array3, obj, null)), array2);
				}
				finally
				{
					Class7 obj52 = (Class7)((Class7)(object)@class.W(bindingFlags, propertyInfo_, (Type)((Class7)null).t((object)Class5.Default, type, cultureInfo_), null, array2)).t(obj, type, cultureInfo_);
					BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
					Class7 obj53 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					ref object[] object_22 = ref *(object[]*)obj53.t(bindingFlags, array3, null, cultureInfo_);
					Class7 obj54 = (Class7)@class.t(Class5.Default, type, cultureInfo_);
					object object_23 = obj;
					Class7 class64 = @class;
					BindingFlags bindingFlags_37 = bindingFlags;
					ref object[] object_24 = ref reference;
					ParameterModifier[] parameterModifier_8 = array2;
					CultureInfo cultureInfo_7 = cultureInfo_;
					Class7 class65 = @class;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])obj54.t(object_23, (Type)(object)class64.j(bindingFlags_37, methodBase_, ref object_24, parameterModifier_8, cultureInfo_7, (string[])(object)class65.W(bindingFlags, propertyInfo_, null, (Type[])@class.t(obj, type, cultureInfo_), array2), out *(object*)@class.t(obj, type, cultureInfo_)), cultureInfo_);
					CultureInfo cultureInfo_8 = (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array, array2)).t(bindingFlags, array3, Class5.Default, cultureInfo_);
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj52.j(bindingFlags_36, methodBase_, ref object_22, parameterModifier_9, cultureInfo_8, (string[])(object)class66.e(bindingFlags, methodBase_, array, (ParameterModifier[])@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default)), out reference2);
					goto end_IL_07e7;
				}
				end_IL_07e7:;
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					_ = (GClass2)(object)((Class7)null).t((BindingFlags)@class.W(bindingFlags, propertyInfo_, (Type)(object)@class.e(bindingFlags, null, null, null), null, array2), array3, obj, (CultureInfo)(object)((Class7)((Class7)null).t((object)null, type, cultureInfo_)).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, methodBase_, ref reference, null, cultureInfo_, array4, out reference2), array2));
				}
			}
		}
		while ((object)Class5.Default != null);
		_ = (GClass1)(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo_, null, out *(object*)null);
		class19 = class19;
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (Class8)(object)Class5.Default;
		Class7 class67 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class67.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, type, array, (ParameterModifier[])(object)Class5.Default)) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)Class5.Default;
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)class68.t(bindingFlags, array3, obj, cultureInfo_);
		}
		try
		{
			if ((UIntPtr)((Class7)null).t((object)Class5.Default, type, cultureInfo_) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					class44 = class44;
					class44 = null;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class69.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)@class.t(bindingFlags, null, null, cultureInfo_), (Type[])(object)Class5.Default, array2), null, array2);
				}
			}
			else
			{
				do
				{
					struct2 = struct2;
					struct2 = struct2;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_0d1d;
		}
		IL_2717:
		gClass4 = null;
		gClass = gClass;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
					gClass3 = null;
				}
			}
			else
			{
				Class7 class70 = @class;
				BindingFlags bindingFlags_38 = bindingFlags;
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				class28 = (Class0)(object)class70.t(bindingFlags_38, (FieldInfo[])(object)class71.j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)null), null, cultureInfo_);
			}
		}
		Class7 class72;
		BindingFlags bindingFlags_39;
		checked
		{
			try
			{
				gClass4 = gClass4;
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr == 0)
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
					}
					finally
					{
						_ = (Struct2)Class5.Default;
						goto end_IL_27b4;
					}
				}
				end_IL_27b4:;
			}
			_ = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, cultureInfo_, (string[])null, out reference2);
			class28 = (Class0)(object)Class5.Default;
			class72 = @class;
			bindingFlags_39 = bindingFlags;
		}
		BindingFlags bindingFlags_40 = (BindingFlags)Class5.Default;
		Class7 obj57 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)class72.e(bindingFlags_39, (MethodBase[])(object)((Class7)null).j(bindingFlags_40, (MethodBase[])(object)obj57.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, array2), ref reference, (ParameterModifier[])null, cultureInfo_, (string[])(object)((Class7)@class.t(obj, type, cultureInfo_)).W(bindingFlags, null, null, (Type[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo_), null), out reference2), array, array2);
		class18 = (Class4)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, null);
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class5)(object)((Class7)null).t((BindingFlags)Class5.Default, array3, (object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, null), (CultureInfo)((Class7)(object)@class.W(bindingFlags, propertyInfo_, type, null, array2)).t(obj, null, cultureInfo_));
			}
			else
			{
				class48 = null;
			}
		}
		gClass4 = null;
		while (obj != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					Class7 class73 = @class;
					BindingFlags bindingFlags_41 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					Class7 obj58 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class73.t(bindingFlags_41, (FieldInfo[])(object)obj58.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), obj, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					class28 = class28;
				}
				continue;
			}
		}
		do
		{
			class44 = null;
		}
		while ((object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref reference, array2, cultureInfo_, array4, out reference2) != null);
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Class5)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out reference2);
			}
			else
			{
				@struct = (Struct2)Class5.Default;
			}
		}
		finally
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_2ab6;
		}
		IL_2f30:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = Class5.Default;
				}
				while (obj != null);
			}
			finally
			{
				while (obj != null)
				{
					_ = (Struct1)@class.t(bindingFlags, array3, null, (CultureInfo)(object)Class5.Default);
				}
				goto IL_2fbf;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
			}
		}
		else
		{
			try
			{
				class22 = class22;
			}
			catch
			{
				_ = (Struct1)Class5.Default;
			}
		}
		goto IL_2fbf;
		IL_26d5:
		class19 = class19;
		try
		{
			class28 = (Class0)(object)Class5.Default;
		}
		finally
		{
			_ = (Struct1)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, array4, out *(object*)null);
			goto IL_2717;
		}
		IL_1c3a:
		if (uIntPtr == 0)
		{
			BindingFlags bindingFlags_42 = bindingFlags;
			Class7 class74 = @class;
			BindingFlags bindingFlags_43 = bindingFlags;
			FieldInfo[] fieldInfo_3 = array3;
			object object_25 = Class5.Default;
			Class7 obj61 = (Class7)(object)((Class7)(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array, array2)).j(bindingFlags, null, ref reference, array2, cultureInfo_, array4, out reference2)).t((BindingFlags)Class5.Default, array3, null, cultureInfo_);
			bindingFlags = default(BindingFlags);
			class48 = (Class9)(object)((Class7)null).e(bindingFlags_42, (MethodBase[])(object)class74.t(bindingFlags_43, fieldInfo_3, object_25, (CultureInfo)(object)obj61.e(bindingFlags, methodBase_, null, null)), (Type[])(object)Class5.Default, array2);
		}
		else
		{
			_ = (GClass0)(object)Class5.Default;
		}
		do
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			catch
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
			{
				Class7 obj64 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj64.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), cultureInfo_, array4, out *(object*)Class5.Default);
			}
			else
			{
				try
				{
					struct2 = default(Struct1);
				}
				catch
				{
					gClass2 = (GClass0)(object)Class5.Default;
				}
			}
		}
		finally
		{
			try
			{
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (GClass2)(object)Class5.Default;
					gClass4 = (GClass2)@class.t(obj, type, (CultureInfo)@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default));
				}
				goto IL_1e63;
			}
		}
		IL_2fbf:
		_ = (Struct2)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			while (obj != null)
			{
				_ = (GClass3)(object)@class.e(bindingFlags, null, array, array2);
				_ = (Class4)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, null)).t((BindingFlags)Class5.Default, array3, obj, (CultureInfo)(object)Class5.Default);
				class28 = null;
				_ = (Class4)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)Class5.Default;
				}
				else
				{
					@class = @class;
				}
			}
			while (obj != null);
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			UIntPtr num10 = (UIntPtr)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			Class7 class75 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num10) + unchecked((nuint)(UIntPtr)class75.j(bindingFlags, null, ref reference, array2, cultureInfo_, (string[])(object)Class5.Default, out reference2)) == 0)
				{
					class44 = class44;
				}
				else
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					class19 = class19;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, (ParameterModifier[])null) != null);
			}
		}
		while (obj != null);
		do
		{
			try
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
					@struct = @struct;
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class76.t(bindingFlags, null, obj, cultureInfo_);
					class28 = null;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			catch
			{
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array3, obj, (CultureInfo)null);
				_ = (Class0)(object)Class5.Default;
				@struct = default(Struct2);
			}
		}
		while (obj != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)Class5.Default;
			class18 = class18;
		}
		try
		{
			class19 = null;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = null;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((nuint)(UIntPtr)@class.e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array2), (MethodBase[])(object)Class5.Default, (Type[])@class.t(null, type, cultureInfo_), null) / uIntPtr == 0)
			{
				try
				{
					class14 = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2);
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					struct2 = default(Struct1);
					_ = (Class10)((Class7)null).t((object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array2), (Type)null, cultureInfo_);
					_ = (Class6)((Class7)(object)Class5.Default).t(Class5.Default, type, null);
					goto IL_33c5;
				}
			}
			_ = (Class8)(object)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default);
		}
		else
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					@struct = default(Struct2);
					_ = (Class4)(object)Class5.Default;
					@struct = @struct;
					goto IL_33c5;
				}
			}
			class14 = null;
		}
		goto IL_33c5;
		IL_393d:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		checked
		{
			while (obj != null)
			{
				try
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)@class.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, null)) == 0)
					{
						_ = (Class2)(object)Class5.Default;
					}
				}
				catch
				{
					while ((object)@class.W(bindingFlags, propertyInfo_, type, array, array2) != null)
					{
						gClass4 = gClass4;
					}
				}
			}
			_ = (Class4)(object)Class5.Default;
			Class7 class77 = @class;
			Type type_11 = type;
			Class7 obj71 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class77.W(default(BindingFlags), propertyInfo_, type_11, array, (ParameterModifier[])(object)obj71.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, array2));
			qk = qk;
			_003CModule_003E = (_003CModule_003E)(object)@class.W(bindingFlags, propertyInfo_, null, array, array2);
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)@class.t(bindingFlags, array3, obj, null) == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
			else
			{
				struct2 = (Struct1)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default);
			}
		}
		uIntPtr = default(UIntPtr);
		UIntPtr num11 = uIntPtr;
		UIntPtr num12 = uIntPtr;
		Class7 obj72 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_44 = (BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags, array3, (object)null, cultureInfo_)).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
		Class7 class78 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)num11) + unchecked((nuint)num12) * unchecked((nuint)(UIntPtr)obj72.j(bindingFlags_44, methodBase_, ref *(object[]*)((Class7)(object)class78.j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, array4, out reference2)).t(((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, array2), cultureInfo_, array4, out reference2), (Type)(object)Class5.Default, null), array2, cultureInfo_, array4, out *(object*)null)) == 0)
			{
				gClass4 = gClass4;
				goto IL_3c1e;
			}
			try
			{
				gClass = null;
				class18 = class18;
			}
			finally
			{
				_ = (GClass2)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo_);
				goto IL_3c1e;
			}
		}
		IL_33c5:
		do
		{
			_ = (Class10)(object)Class5.Default;
		}
		while (obj != null);
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					@class = (Class7)((Class7)null).t((object)Class5.Default, (Type)(object)@class.t(bindingFlags, null, obj, (CultureInfo)@class.t(obj, type, cultureInfo_)), (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				try
				{
					Class7 class79 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class79.e(bindingFlags, null, array, array2);
				}
				finally
				{
					@struct = @struct;
					goto end_IL_33d6;
				}
			}
			end_IL_33d6:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class22 = class22;
				}
				catch
				{
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)class80.t(bindingFlags, array3, obj, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_)), array, array2);
				}
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				gClass2 = gClass2;
				goto IL_3556;
			}
			try
			{
				class28 = class28;
				class14 = (Class8)(object)Class5.Default;
			}
			finally
			{
				gClass = gClass;
				goto IL_3556;
			}
		}
		IL_4081:
		_ = (Class4)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, array2, cultureInfo_, null, out reference2);
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * uIntPtr - unchecked((nuint)(UIntPtr)@class.W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, array2)) == 0)
			{
				BindingFlags bindingFlags_45 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_46 = bindingFlags;
				Type[] type_12 = (Type[])(object)Class5.Default;
				Class7 class81 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				unchecked
				{
					if ((UIntPtr)((Class7)((Class7)(object)((Class7)null).j(bindingFlags_45, methodBase_, ref *(object[]*)((Class7)null).e(bindingFlags_46, (MethodBase[])null, type_12, (ParameterModifier[])(object)class81.W(bindingFlags_47, (PropertyInfo[])(object)class82.t(bindingFlags, array3, obj, cultureInfo_), (Type)(object)Class5.Default, null, null)), (ParameterModifier[])null, (CultureInfo)null, array4, out reference2)).t(obj, type, null)).t(Class5.Default, type, null) == (UIntPtr)(nuint)0u)
					{
						gClass4 = (GClass2)(object)@class.j(default(BindingFlags), null, ref reference, null, cultureInfo_, null, out *(object*)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).e((BindingFlags)@class.t(obj, null, cultureInfo_), methodBase_, array, array2), (ParameterModifier[])null));
					}
					else
					{
						try
						{
							_ = (GClass3)(object)Class5.Default;
						}
						catch
						{
							_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_);
							class44 = null;
						}
					}
				}
			}
			Class7 class83 = @class;
			bindingFlags = default(BindingFlags);
			class19 = (Class6)(object)class83.W(bindingFlags, propertyInfo_, null, array, array2);
			try
			{
				nuint num13 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num13 - uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
			_ = (Qk7)(object)Class5.Default;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class48 = null;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr) == 0)
				{
					_ = (Class0)(object)Class5.Default;
					qk = qk;
					_ = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array, (ParameterModifier[])null);
					class48 = class48;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
					class22 = (Class5)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, array2, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
					gClass = null;
					@struct = default(Struct2);
				}
			}
			goto IL_47c1;
		}
		IL_2324:
		uIntPtr = default(UIntPtr);
		nuint num14 = uIntPtr;
		Class7 obj77 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_48 = bindingFlags;
		Class7 obj78 = (Class7)(object)Class5.Default;
		Class7 class84 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_49 = (BindingFlags)class84.t(bindingFlags, array3, obj, null);
		Class7 class85 = @class;
		object object_26 = @class.j(bindingFlags, methodBase_, ref reference, array2, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		Type type_13 = (Type)(object)Class5.Default;
		BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj79 = (Class7)(object)obj78.j(bindingFlags_49, (MethodBase[])class85.t(object_26, type_13, (CultureInfo)(object)((Class7)null).j(bindingFlags_50, methodBase_, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)@class.t(bindingFlags, null, Class5.Default, cultureInfo_), (ParameterModifier[])null, cultureInfo_, (string[])null, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default)), array2, cultureInfo_, (string[])null, out reference2)), ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(Class5.Default, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, propertyInfo_, type, (Type[])null, array2)));
		bindingFlags = default(BindingFlags);
		if (checked(num14 + unchecked((nuint)(UIntPtr)((Class7)null).t((BindingFlags)((Class7)null).e((BindingFlags)obj77.e(bindingFlags_48, (MethodBase[])(object)obj79.e(bindingFlags, methodBase_, array, null), array, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo_, array4, out *(object*)null)), (MethodBase[])(object)Class5.Default, (Type[])(object)@class.t(bindingFlags, null, null, null), array2), (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default))) == 0)
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
				ref object[] object_27 = ref reference;
				ParameterModifier[] parameterModifier_10 = array2;
				CultureInfo cultureInfo_9 = cultureInfo_;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_52 = bindingFlags;
				Class7 obj80 = (Class7)(object)@class.e(bindingFlags, null, array, null);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)((Class7)null).j(bindingFlags_51, methodBase_7, ref object_27, parameterModifier_10, cultureInfo_9, (string[])(object)((Class7)null).W(bindingFlags_52, (PropertyInfo[])null, (Type)null, array, (ParameterModifier[])((Class7)(object)obj80.e(bindingFlags, methodBase_, null, array2)).t(obj, type, cultureInfo_)), out *(object*)((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array, array2)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, null, null, out reference2));
				_ = (Class9)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array3, @class.t(Class5.Default, type, null), (CultureInfo)@class.t(null, type, cultureInfo_));
				class28 = class28;
			}
			finally
			{
				class48 = (Class9)(object)Class5.Default;
				goto IL_26d5;
			}
		}
		Class7 class86 = @class;
		bindingFlags = default(BindingFlags);
		class9 = (Class2)(object)class86.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
		goto IL_26d5;
		IL_3d57:
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				UIntPtr num15 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(unchecked((nuint)num15) + unchecked(uIntPtr / uIntPtr / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)(UIntPtr)((Class7)null).W((BindingFlags)@class.W(bindingFlags, propertyInfo_, type, null, array2), propertyInfo_, type, (Type[])((Class7)null).t((object)null, type, cultureInfo_), (ParameterModifier[])null))) == 0)
				{
					_ = (Class8)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
				}
			}
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			try
			{
				@struct = (Struct2)Class5.Default;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)null).t(obj, (Type)null, cultureInfo_);
					_ = (Qk7)(object)Class5.Default;
					class28 = class28;
				}
				else
				{
					class28 = (Class0)@class.t(obj, type, cultureInfo_);
				}
				goto end_IL_3d6d;
			}
			end_IL_3d6d:;
		}
		_ = (Class8)(object)Class5.Default;
		_ = (Class9)((Class7)(object)Class5.Default).t(((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array2), type, cultureInfo_);
		class44 = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj != null)
				{
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class87.e(bindingFlags, methodBase_, array, null);
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		do
		{
			try
			{
				class48 = class48;
			}
			catch
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		while (obj != null);
		_ = (Class2)(object)@class.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, array2);
		while ((object)Class5.Default != null)
		{
			while (obj != null)
			{
				if ((UIntPtr)((Class7)null).t(obj, (Type)(object)@class.e((BindingFlags)Class5.Default, methodBase_, null, (ParameterModifier[])(object)@class.W(bindingFlags, propertyInfo_, type, array, (ParameterModifier[])(object)Class5.Default)), cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
					_ = (Class8)(object)Class5.Default;
					_ = (Class6)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_)).W((BindingFlags)@class.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default), propertyInfo_, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.W(bindingFlags, propertyInfo_, type, null, null), propertyInfo_, type, null, array2), array, (ParameterModifier[])@class.t(null, type, cultureInfo_));
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					class44 = class44;
				}
			}
		}
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
			_ = (Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array, array2);
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				@struct = default(Struct2);
			}
		}
		finally
		{
			class48 = null;
			goto IL_4081;
		}
	}

	unsafe static void Zd8()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				@class = null;
				Class7 class2 = @class;
				obj = obj;
				object object_ = obj;
				type = null;
				Type type_ = type;
				cultureInfo = null;
				_ = (Struct2)class2.t(object_, type_, cultureInfo);
			}
			finally
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
				goto IL_03ef;
			}
		}
		goto IL_03ef;
		IL_21dc:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			try
			{
				Class7 class3 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_ = bindingFlags;
				MethodBase[] methodBase_ = array;
				Class7 class4 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_2 = bindingFlags;
				Type[] type_2 = array2;
				Class7 class5 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class3.e(bindingFlags_, methodBase_, null, (ParameterModifier[])(object)class4.e(bindingFlags_2, null, type_2, (ParameterModifier[])(object)class5.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_2)));
			}
			finally
			{
				_ = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, null);
				_ = (Class4)(object)Class5.Default;
				_ = (Class4)@class.t(obj, (Type)(object)Class5.Default, null);
				class6 = class6;
				goto end_IL_21dd;
			}
			end_IL_21dd:;
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)((Class7)null).t(obj, type, cultureInfo);
				gClass = gClass;
			}
			else
			{
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)((Class7)null).W(bindingFlags, array3, (Type)null, array2, array4);
			}
			goto IL_2308;
		}
		IL_03ef:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		Class0 class15;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class16);
		while (obj != null)
		{
			try
			{
				Class7 class7 = @class;
				Class7 class8 = @class;
				bindingFlags = (BindingFlags)((Class7)null).t(obj, type, cultureInfo);
				BindingFlags bindingFlags_3 = bindingFlags;
				array3 = null;
				PropertyInfo[] propertyInfo_ = array3;
				array2 = (Type[])(object)Class5.Default;
				object object_3 = class8.W(bindingFlags_3, propertyInfo_, null, array2, (ParameterModifier[])(object)Class5.Default);
				Class7 class9 = @class;
				Class7 class10 = @class;
				BindingFlags bindingFlags_4 = bindingFlags;
				array = array;
				BindingFlags bindingFlags_5 = (BindingFlags)class10.e(bindingFlags_4, array, null, (ParameterModifier[])@class.t(null, type, cultureInfo));
				ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
				CultureInfo cultureInfo_ = cultureInfo;
				string[] string_ = (string[])(object)Class5.Default;
				BindingFlags bindingFlags_6 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_7 = bindingFlags;
				MethodBase[] methodBase_2 = array;
				Type[] type_3 = array2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				MethodBase[] methodBase_3 = array;
				Class7 class11 = @class;
				Class7 class12 = @class;
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_9 = bindingFlags;
				MethodBase[] methodBase_4 = array;
				array4 = array4;
				BindingFlags bindingFlags_10 = (BindingFlags)class13.j(bindingFlags_9, methodBase_4, ref *(object[]*)null, array4, cultureInfo, null, out object_2);
				PropertyInfo[] propertyInfo_2 = array3;
				Type type_4 = type;
				object object_4 = obj;
				Class7 class14 = @class;
				BindingFlags bindingFlags_11 = bindingFlags;
				Class7 obj2 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_5 = (MethodBase[])(object)obj2.W(bindingFlags, (PropertyInfo[])@class.t(obj, type, cultureInfo), type, array2, null);
				reference = ref reference;
				ref object[] object_5 = ref *(object[]*)class11.e((BindingFlags)class12.W(bindingFlags_10, propertyInfo_2, type_4, (Type[])((Class7)null).t(object_4, (Type)(object)class14.j(bindingFlags_11, methodBase_5, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_2), (CultureInfo)(object)Class5.Default), array4), (MethodBase[])(object)Class5.Default, array2, array4);
				ParameterModifier[] parameterModifier_2 = array4;
				CultureInfo cultureInfo_2 = cultureInfo;
				array5 = (string[])(object)Class5.Default;
				object_2 = ref *(object*)((Class7)null).e(bindingFlags_6, (MethodBase[])(object)((Class7)null).e(bindingFlags_7, methodBase_2, type_3, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_8, methodBase_3, ref object_5, parameterModifier_2, cultureInfo_2, array5, out object_2)), (Type[])((Class7)null).t((object)null, type, cultureInfo), (ParameterModifier[])null);
				_ = (Struct2)class7.t(object_3, (Type)(object)class9.j(bindingFlags_5, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out object_2), (CultureInfo)(object)Class5.Default);
			}
			catch
			{
				uIntPtr = (UIntPtr)Class5.Default;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
					Class0 obj3 = (Class0)(object)Class5.Default;
					class15 = null;
					class15 = obj3;
					Class10 obj4 = (Class10)(object)Class5.Default;
					class16 = class16;
					class16 = obj4;
					continue;
				}
				Class7 class17 = @class;
				BindingFlags bindingFlags_12 = bindingFlags;
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
				CultureInfo cultureInfo_3 = cultureInfo;
				Class7 class18 = @class;
				BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_6 = array;
				Class7 obj5 = (Class7)(object)Class5.Default;
				Type type_5 = (Type)(object)Class5.Default;
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class17.j(bindingFlags_12, null, ref *(object[]*)null, parameterModifier_3, cultureInfo_3, (string[])(object)class18.e(bindingFlags_13, methodBase_6, (Type[])obj5.t(null, type_5, (CultureInfo)((Class7)null).t((object)class19.W(bindingFlags, array3, (Type)(object)Class5.Default, array2, null), type, cultureInfo)), (ParameterModifier[])(object)Class5.Default), out *(object*)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, type, array2, null));
				class16 = (Class10)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
			}
		}
		while (obj != null)
		{
		}
		Class4 class20 = (Class4)(object)@class.e(bindingFlags, null, array2, array4);
		class20 = class20;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			try
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				try
				{
					Qk7 obj7 = (Qk7)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
					qk = obj7;
				}
				finally
				{
					class15 = (Class0)(object)Class5.Default;
					goto end_IL_0428;
				}
			}
			end_IL_0428:;
		}
		finally
		{
			try
			{
				@class = @class;
			}
			catch
			{
				while (obj != null)
				{
					class16 = (Class10)(object)@class.t(bindingFlags, null, null, cultureInfo);
				}
			}
			goto IL_04aa;
		}
		IL_2308:
		_ = (Struct2)Class5.Default;
		Struct1 @struct = default(Struct1);
		Struct2 struct2;
		try
		{
			_ = (Class0)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, (ParameterModifier[])@class.t(obj, type, cultureInfo));
			struct2 = default(Struct2);
			struct2 = struct2;
		}
		finally
		{
			try
			{
				class15 = (Class0)(object)@class.W(bindingFlags, array3, type, array2, null);
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			goto IL_246c;
		}
		IL_186b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class22);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class23);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class24);
		checked
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					_ = Class5.Default;
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = bindingFlags;
					MethodBase[] methodBase_7 = array;
					Type[] type_6 = array2;
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).e(bindingFlags_14, methodBase_7, type_6, (ParameterModifier[])class21.t(null, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array4), null));
					goto end_IL_186c;
				}
				end_IL_186c:;
			}
			catch
			{
				if (uIntPtr - (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr) == 0)
				{
					class22 = class22;
				}
			}
			_ = (GClass3)(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null);
			try
			{
				class23 = class23;
			}
			catch
			{
				try
				{
					class24 = class24;
				}
				finally
				{
					try
					{
						_ = (Class10)(object)Class5.Default;
					}
					finally
					{
						_ = (Class6)(object)((Class7)@class.t(null, type, null)).e(bindingFlags, null, null, null);
						goto end_IL_193a;
					}
				}
				end_IL_193a:;
			}
			gClass2 = gClass2;
			_ = (Class10)(object)Class5.Default;
			_ = (Struct1)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)@class.W(bindingFlags, array3, type, null, array4), (Type[])(object)Class5.Default, array4);
				}
				finally
				{
					class23 = class23;
					goto end_IL_199d;
				}
			}
			while ((object)Class5.Default != null)
			{
				_ = (Class4)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_15 = bindingFlags;
				ref object[] object_6 = ref *(object[]*)((Class7)null).t(obj, type, (CultureInfo)null);
				Class7 obj12 = (Class7)((Class7)null).t((object)null, type, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])((Class7)null).t(obj, type, (CultureInfo)null), obj, (CultureInfo)(object)Class5.Default));
				bindingFlags = default(BindingFlags);
				ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)obj12.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)@class.t(bindingFlags, array6, null, cultureInfo), (FieldInfo[])null, obj, (CultureInfo)null), null, array4);
				CultureInfo cultureInfo_4 = cultureInfo;
				Class7 class25 = @class;
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_8 = array;
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).j(bindingFlags_15, (MethodBase[])null, ref object_6, parameterModifier_4, cultureInfo_4, (string[])(object)class25.e(bindingFlags_16, methodBase_8, (Type[])(object)class26.t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), null), out object_2);
			}
			end_IL_199d:;
		}
		catch
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				class6 = class6;
			}
			finally
			{
				qk = qk;
				goto end_IL_1b2d;
			}
			end_IL_1b2d:;
		}
		try
		{
			try
			{
				try
				{
					class22 = class22;
				}
				finally
				{
					_ = (Struct2)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo);
					goto end_IL_1b6a;
				}
				end_IL_1b6a:;
			}
			finally
			{
				@class = null;
				goto end_IL_1b69;
			}
			end_IL_1b69:;
		}
		finally
		{
			qk = qk;
			goto IL_1bab;
		}
		IL_04aa:
		class16 = class16;
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					class20 = class20;
					continue;
				}
			}
		}
		while (obj != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					_003CModule_003E obj14 = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj14;
					goto end_IL_04e5;
				}
				end_IL_04e5:;
			}
			finally
			{
				class22 = null;
				class22 = null;
				goto IL_0519;
			}
		}
		goto IL_0519;
		IL_4595:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					gClass2 = gClass2;
				}
				while (obj != null);
			}
			return;
		}
		catch
		{
			Class7 class27 = @class;
			BindingFlags bindingFlags_17 = (BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array4, cultureInfo, null, out *(object*)Class5.Default);
			PropertyInfo[] propertyInfo_3 = array3;
			Type[] type_7 = (Type[])(object)Class5.Default;
			Class7 class28 = @class;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)(UIntPtr)class27.W(bindingFlags_17, propertyInfo_3, null, type_7, (ParameterModifier[])(object)((Class7)(object)class28.t(bindingFlags, array6, Class5.Default, cultureInfo)).W(bindingFlags, array3, type, (Type[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, array5, out object_2), array4))) * uIntPtr) / (nuint)(UIntPtr)Class5.Default == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)Class5.Default;
			}
			return;
		}
		IL_3cb2:
		do
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		while ((object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null)).e(bindingFlags, null, array2, array4) != null);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						bindingFlags = default(BindingFlags);
						_ = (Class7)(object)((Class7)null).j(bindingFlags, array, ref *unchecked((object[]*)Class5.Default), array4, cultureInfo, (string[])null, out object_2);
					}
					else
					{
						gClass2 = gClass2;
					}
				}
				else
				{
					try
					{
						gClass = null;
						class20 = null;
					}
					catch
					{
						gClass = gClass;
					}
				}
			}
			catch
			{
				try
				{
					class15 = null;
				}
				catch
				{
					class15 = (Class0)(object)Class5.Default;
				}
			}
			_ = (GClass2)(object)Class5.Default;
			try
			{
				_ = (Qk7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Class5.Default;
				}
				else
				{
					nuint num = uIntPtr;
					UIntPtr num2 = unchecked((UIntPtr)Class5.Default);
					nuint num3 = uIntPtr + (uIntPtr - unchecked((nuint)default(UIntPtr)));
					uIntPtr = default(UIntPtr);
					if (num + (unchecked((nuint)num2) + num3 * uIntPtr) == 0)
					{
						@struct = @struct;
						_ = (Class8)(object)Class5.Default;
						_ = (GClass0)(object)unchecked(@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array5, out *(object*)null));
						qk = qk;
					}
					else
					{
						_ = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)unchecked(((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)Class5.Default, array5, out object_2))).t(bindingFlags, null, Class5.Default, null), obj, cultureInfo);
					}
				}
				goto IL_3eab;
			}
		}
		IL_3c35:
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		finally
		{
			_ = (GClass2)(object)@class.W(bindingFlags, null, type, array2, null);
			goto IL_3cb2;
		}
		IL_31b3:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					class20 = null;
				}
				catch
				{
					_ = (Struct2)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null);
				}
			}
			catch
			{
				try
				{
					@class = @class;
				}
				catch
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class0)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
				}
			}
		}
		catch
		{
			try
			{
				while ((object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])null, array4) != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				@struct = default(Struct1);
				_ = (Class0)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array4)).t((BindingFlags)Class5.Default, array6, obj, cultureInfo));
				goto end_IL_323f;
			}
			end_IL_323f:;
		}
		Class7 class29 = @class;
		Class7 obj23 = (Class7)@class.t(obj, type, (CultureInfo)(object)@class.t(bindingFlags, array6, obj, cultureInfo));
		object object_7 = obj;
		Class7 obj24 = (Class7)(object)Class5.Default;
		Class7 obj25 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default);
		BindingFlags bindingFlags_18 = (BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, (CultureInfo)(object)@class.e(bindingFlags, array, array2, (ParameterModifier[])(object)@class.W(bindingFlags, array3, type, array2, array4)), (string[])(object)Class5.Default, out *(object*)((Class7)null).t((object)null, (Type)null, cultureInfo))).t(obj, (Type)(object)Class5.Default, cultureInfo);
		MethodBase[] methodBase_9 = array;
		ref object[] object_8 = ref reference;
		ParameterModifier[] parameterModifier_5 = array4;
		CultureInfo cultureInfo_5 = cultureInfo;
		string[] string_2 = array5;
		BindingFlags bindingFlags_19 = bindingFlags;
		MethodBase[] methodBase_10 = (MethodBase[])(object)Class5.Default;
		Class7 obj26 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_20 = (BindingFlags)obj23.t(object_7, (Type)(object)obj24.j((BindingFlags)obj25.j(bindingFlags_18, methodBase_9, ref object_8, parameterModifier_5, cultureInfo_5, string_2, out *(object*)((Class7)null).j(bindingFlags_19, methodBase_10, ref *(object[]*)obj26.W((BindingFlags)((Class7)null).W(bindingFlags, array3, (Type)null, array2, array4), array3, type, array2, (ParameterModifier[])@class.t(obj, type, cultureInfo)), (ParameterModifier[])null, cultureInfo, (string[])(object)@class.W(bindingFlags, array3, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), out object_2)), array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)@class.t(default(BindingFlags), array6, obj, null), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), array, (Type[])null, (ParameterModifier[])(object)((Class7)null).e(default(BindingFlags), array, array2, array4)), null, out *(object*)@class.e(default(BindingFlags), array, array2, array4)), null, out object_2), cultureInfo);
		MethodBase[] methodBase_11 = array;
		ref object[] object_9 = ref reference;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class29.j(bindingFlags_20, methodBase_11, ref object_9, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)@class.W(bindingFlags, array3, null, null, array4), array2, (ParameterModifier[])null)).t(bindingFlags, null, obj, null), (MethodBase[])null, array2, array4), cultureInfo, array5, out object_2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 obj27 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj27.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array4);
				_ = (Qk7)(object)Class5.Default;
				@class = @class;
			}
			catch
			{
				while (obj != null)
				{
					struct2 = struct2;
				}
			}
		}
		class23 = null;
		_ = (Class7)(object)Class5.Default;
		while (obj != null || obj != null)
		{
		}
		gClass2 = gClass2;
		gClass = gClass;
		class23 = (Class5)@class.t(obj, type, cultureInfo);
		_ = (Class4)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])null);
		_ = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)@class.t(obj, null, cultureInfo), array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
		try
		{
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class30 = @class;
					Class7 obj29 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_21 = bindingFlags;
					bindingFlags = default(BindingFlags);
					class22 = (Class8)(object)class30.j((BindingFlags)obj29.t(bindingFlags_21, null, ((Class7)null).t(bindingFlags, array6, obj, cultureInfo), null), array, ref reference, array4, cultureInfo, null, out *(object*)null);
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
				goto IL_3826;
			}
		}
		IL_246c:
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class0)@class.t(obj, type, (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo));
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
			try
			{
				_ = (GClass0)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array4);
				qk = qk;
				_ = (Class4)(object)Class5.Default;
				_ = Class5.Default;
			}
			catch
			{
				class24 = class24;
				_ = (Class2)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])null, array4);
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				try
				{
					_003CModule_003E = null;
				}
				catch
				{
					_ = (Class5)(object)@class.W(bindingFlags, array3, type, null, array4);
				}
				goto IL_2526;
			}
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr / uIntPtr == 0)
			{
				_ = (GClass2)(object)Class5.Default;
			}
			else
			{
				struct2 = default(Struct2);
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass3)(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, type, cultureInfo), array2, (ParameterModifier[])null);
		}
		goto IL_2526;
		IL_0519:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			while ((object)Class5.Default != null)
			{
				Class7 obj32 = (Class7)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array4);
				bindingFlags = default(BindingFlags);
				_003CModule_003E = (_003CModule_003E)(object)obj32.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])@class.t(obj, (Type)(object)Class5.Default, null), (CultureInfo)(object)@class.e(bindingFlags, null, array2, null), array5, out object_2);
			}
		}
		finally
		{
			while ((object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array4) != null)
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
				Class7 class31 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_22 = bindingFlags;
				array6 = array6;
				_ = (Class4)(object)class31.t(bindingFlags_22, array6, Class5.Default, cultureInfo);
			}
			goto IL_061f;
		}
		IL_061f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class32);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					class24 = class24;
					class24 = null;
				}
				else
				{
					gClass2 = null;
					gClass2 = null;
					_ = (Class9)(object)Class5.Default;
					Class5 obj33 = Class5.Default;
					class23 = null;
					class23 = obj33;
				}
			}
			else if (checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				Class9 obj34 = (Class9)@class.t(obj, type, cultureInfo);
				class32 = null;
				class32 = obj34;
			}
		}
		finally
		{
			goto IL_06bc;
		}
		IL_06bc:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				qk = null;
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		do
		{
			_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, cultureInfo);
		}
		while (obj != null);
		do
		{
			try
			{
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num5 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					nuint num6 = num5 * uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num4 - (num6 - uIntPtr) + uIntPtr == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
			finally
			{
				do
				{
					Class7 class33 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class33.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array5, out *(object*)Class5.Default);
					_ = (Class2)(object)Class5.Default;
					struct2 = (Struct2)Class5.Default;
					struct2 = default(Struct2);
					_ = (Class0)(object)Class5.Default;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					Class7 class34 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)((Class7)(object)class34.e(bindingFlags, array, array2, array4)).t(@class.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out object_2), type, null);
				}
			}
			finally
			{
				goto IL_085a;
			}
		}
		goto IL_085a;
		IL_3f54:
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr - uIntPtr) == 0)
		{
			_ = (GClass1)(object)@class.j((BindingFlags)@class.W((BindingFlags)@class.W(default(BindingFlags), null, null, null, null), array3, null, null, array4), array, ref *(object[]*)((Class7)null).W(default(BindingFlags), array3, (Type)null, array2, (ParameterModifier[])null), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out object_2);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				qk = (Qk7)(object)Class5.Default;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					class32 = (Class9)(object)Class5.Default;
					goto end_IL_403c;
				}
				end_IL_403c:;
			}
			finally
			{
				try
				{
					class6 = (Class2)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
			}
		}
		_ = (Qk7)(object)Class5.Default;
		do
		{
			try
			{
				_ = (Struct2)@class.t(default(BindingFlags), array6, null, cultureInfo);
			}
			finally
			{
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class35.W(bindingFlags, array3, (Type)@class.t(obj, type, cultureInfo), (Type[])(object)Class5.Default, array4);
				continue;
			}
		}
		while ((object)Class5.Default != null);
		do
		{
			if ((UIntPtr)@class.j((BindingFlags)@class.j((BindingFlags)Class5.Default, null, ref reference, array4, (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, array5, out object_2), null, out *(object*)@class.e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, null)), null, ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out object_2) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					Class7 class36 = @class;
					Class7 class37 = @class;
					Class7 obj37 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_23 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj38 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_24 = bindingFlags;
					ref object[] object_10 = ref reference;
					ParameterModifier[] parameterModifier_6 = array4;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 obj39 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_25 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array3;
					Class7 obj40 = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, null, out object_2);
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class36.t((BindingFlags)class37.e((BindingFlags)obj37.W(bindingFlags_23, propertyInfo_4, (Type)(object)obj38.j(bindingFlags_24, null, ref object_10, parameterModifier_6, cultureInfo_6, (string[])(object)obj39.W(bindingFlags_25, propertyInfo_5, null, (Type[])(object)obj40.t(bindingFlags, array6, obj, cultureInfo), array4), out object_2), array2, array4), array, array2, array4), array6, null, cultureInfo);
				}
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			Class7 obj41 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_26 = bindingFlags;
			ref object[] object_11 = ref *(object[]*)Class5.Default;
			bindingFlags = default(BindingFlags);
			class20 = (Class4)((Class7)(object)((Class7)(object)((Class7)(object)obj41.j(bindingFlags_26, null, ref object_11, null, null, (string[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])null, out object_2), out *(object*)@class.j(bindingFlags, array, ref reference, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2))).t(bindingFlags, array6, Class5.Default, cultureInfo)).t(bindingFlags, array6, null, cultureInfo)).t(null, type, null);
		}
		finally
		{
			class6 = null;
			goto IL_43bb;
		}
		IL_43e7:
		_ = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)(object)((Class7)null).W((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t(bindingFlags, array6, obj, null), type, (Type[])null, (ParameterModifier[])null), array3, (Type)null, (Type[])null, array4), cultureInfo), array2, (ParameterModifier[])null);
		while (obj != null)
		{
			gClass2 = gClass2;
		}
		Class7 class38 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class38.W(bindingFlags, null, type, null, array4);
		@class = @class;
		_ = (GClass0)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0 && (nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default == 0)
		{
			_ = (GClass3)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		try
		{
			Class7 class39 = @class;
			BindingFlags bindingFlags_27 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)Class5.Default;
			string[] string_3 = (string[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class39.j(bindingFlags_27, methodBase_12, ref *(object[]*)null, parameterModifier_7, null, string_3, out *(object*)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)@class.e(bindingFlags, null, null, null)));
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					class15 = (Class0)@class.t(obj, type, null);
				}
				finally
				{
					gClass4 = gClass4;
					continue;
				}
			}
			goto IL_4595;
		}
		IL_3bdc:
		try
		{
		}
		finally
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array4);
				}
			}
			finally
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					goto IL_3c35;
				}
			}
		}
		IL_3826:
		if ((UIntPtr)@class.j(bindingFlags, array, ref *(object[]*)((Class7)(object)@class.j(bindingFlags, null, ref reference, null, cultureInfo, (string[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array4, (CultureInfo)null, array5, out object_2)).t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), null, Class5.Default, cultureInfo), out *(object*)null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.t(null, type, cultureInfo), array, array2, array4), null, (string[])(object)@class.t(bindingFlags, null, null, null), out *(object*)null) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					class15 = class15;
				}
				while (obj != null);
			}
		}
		while (obj != null)
		{
			class6 = null;
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 obj42 = (Class7)(object)Class5.Default;
					Type type_8 = type;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array3;
					Type type_9 = type;
					Type[] type_10 = (Type[])(object)Class5.Default;
					Class7 obj43 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class10)obj42.t(null, type_8, (CultureInfo)(object)class40.W(bindingFlags_28, propertyInfo_6, type_9, type_10, (ParameterModifier[])(object)obj43.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array4)));
				}
			}
			catch
			{
				while (obj != null)
				{
					@struct = default(Struct1);
					@struct = @struct;
				}
			}
		}
		catch
		{
			do
			{
				Class7 class41 = @class;
				Class7 class42 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_29 = (BindingFlags)class42.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array4, null, array5, out object_2), obj, null);
				MethodBase[] methodBase_13 = array;
				Class7 obj45 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)((Class7)(object)class41.e(bindingFlags_29, methodBase_13, (Type[])(object)obj45.j(bindingFlags, array, ref reference, array4, (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array4, cultureInfo, array5, out object_2), null, out object_2), array4)).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)Class5.Default);
			}
			while (obj != null);
		}
		try
		{
			do
			{
				if ((UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.t(bindingFlags, array6, obj, null), cultureInfo, array5, out object_2) == (UIntPtr)(nuint)0u)
				{
					class32 = class32;
					_ = (GClass3)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			Class7 obj47 = (Class7)(object)@class.W(default(BindingFlags), null, null, array2, (ParameterModifier[])(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)obj47.W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null), type, array2, array4);
			_ = (Class7)(object)Class5.Default;
			goto IL_3bdc;
		}
		IL_3eab:
		while (obj != null)
		{
			_ = (Class6)(object)Class5.Default;
			gClass = gClass;
		}
		try
		{
			_ = (GClass0)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array2, array4);
		}
		catch
		{
			try
			{
				class22 = class22;
				_ = (Class0)(object)@class.t(default(BindingFlags), null, Class5.Default, cultureInfo);
				qk = null;
				struct2 = struct2;
			}
			finally
			{
				@struct = @struct;
				goto end_IL_3ed3;
			}
			end_IL_3ed3:;
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					class15 = class15;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
				goto IL_3f54;
			}
		}
		IL_1bab:
		_ = (Class9)(object)((Class7)null).W(bindingFlags, array3, type, array2, (ParameterModifier[])null);
		@struct = @struct;
		@struct = default(Struct1);
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Class8)(object)@class.t(bindingFlags, array6, Class5.Default, cultureInfo);
			}
			else
			{
				qk = (Qk7)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Class9)(object)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, array2, array4);
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			while (obj != null)
			{
				class22 = ((uIntPtr != 0) ? class22 : null);
			}
		}
		catch
		{
			try
			{
				try
				{
					Class7 obj50 = (Class7)(object)@class.W(bindingFlags, null, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array4), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, null));
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj50.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)((Class7)null).W(bindingFlags, array3, type, array2, (ParameterModifier[])null), null);
				}
				finally
				{
					_ = (Class9)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array5, out *(object*)null);
					goto end_IL_1c7c;
				}
				end_IL_1c7c:;
			}
			catch
			{
				class6 = (Class2)(object)@class.t(bindingFlags, null, obj, null);
			}
		}
		try
		{
			do
			{
				_ = (Class4)@class.t(obj, null, cultureInfo);
			}
			while (obj != null || (object)Class5.Default != null);
		}
		catch
		{
			@struct = @struct;
		}
		try
		{
			class32 = (Class9)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo, array5, out *(object*)Class5.Default);
		}
		catch
		{
			do
			{
				class15 = (Class0)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		Class7 obj55 = (Class7)((Class7)null).t(obj, type, cultureInfo);
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)((Class7)(object)((Class7)(object)obj55.e(bindingFlags, null, array2, array4)).W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, array3, (Type)(object)((Class7)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array6, Class5.Default, (CultureInfo)(object)Class5.Default), array, array2, array4)).t((BindingFlags)@class.j(bindingFlags, array, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out object_2), array6, null, cultureInfo), array2, null), (Type)(object)Class5.Default, null, array4)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			struct2 = struct2;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					class22 = class22;
				}
				finally
				{
					gClass3 = gClass3;
					goto end_IL_1f53;
				}
			}
			end_IL_1f53:;
		}
		catch
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						Class7 class43 = @class;
						BindingFlags bindingFlags_30 = bindingFlags;
						MethodBase[] methodBase_14 = array;
						Type[] type_11 = (Type[])(object)Class5.Default;
						Class7 class44 = @class;
						bindingFlags = default(BindingFlags);
						_ = (GClass2)(object)class43.e(bindingFlags_30, methodBase_14, type_11, (ParameterModifier[])class44.t(((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])null, cultureInfo, array5, out *(object*)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, array2, array4)), (CultureInfo)null, (string[])null, out *(object*)null), (Type)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)Class5.Default));
						continue;
					}
					goto end_IL_1f94;
				}
				end_IL_1f94:;
			}
		}
		gClass3 = (GClass3)(object)Class5.Default;
		do
		{
			try
			{
				do
				{
					_ = (Class5)(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array6, obj, (CultureInfo)null), (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Struct1)@class.t(bindingFlags, array6, obj, cultureInfo);
				}
				continue;
			}
		}
		while (obj != null);
		Class7 class45 = @class;
		BindingFlags bindingFlags_31 = bindingFlags;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class45.W(bindingFlags_31, (PropertyInfo[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array5, out object_2), type, null, array4) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)@class.t(null, type, cultureInfo);
				}
				finally
				{
					struct2 = (Struct2)Class5.Default;
					goto end_IL_2148;
				}
				end_IL_2148:;
			}
			finally
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Class5)(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, array2, array4), null, array5, out object_2);
					class23 = class23;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_21dc;
				}
			}
		}
		goto IL_21dc;
		IL_085a:
		struct2 = struct2;
		try
		{
			class16 = class16;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					class23 = class23;
				}
			}
		}
		try
		{
			class16 = class16;
			struct2 = default(Struct2);
			struct2 = struct2;
			@class = @class;
		}
		catch
		{
			gClass = null;
			gClass = gClass;
		}
		while (obj != null)
		{
			gClass2 = null;
		}
		try
		{
			gClass3 = gClass3;
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					Class7 obj61 = (Class7)(object)((Class7)null).e(bindingFlags, array, array2, array4);
					BindingFlags bindingFlags_32 = bindingFlags;
					Class7 class46 = @class;
					Class7 obj62 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
					ref object[] object_12 = ref reference;
					Class7 class47 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_35 = bindingFlags;
					MethodBase[] methodBase_15 = array;
					Class7 class49 = @class;
					BindingFlags bindingFlags_36 = bindingFlags;
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = (BindingFlags)obj62.j(bindingFlags_33, null, ref object_12, null, (CultureInfo)(object)class47.W(bindingFlags_34, (PropertyInfo[])(object)class48.e(bindingFlags_35, methodBase_15, (Type[])(object)class49.t(bindingFlags_36, (FieldInfo[])(object)class50.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), array5, out object_2), Class5.Default, cultureInfo), null), type, array2, null), null, out *(object*)null);
					PropertyInfo[] propertyInfo_7 = array3;
					Type type_12 = type;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass2)(object)obj61.W(bindingFlags_32, (PropertyInfo[])(object)class46.W(bindingFlags_37, propertyInfo_7, type_12, (Type[])(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), array4), (Type)(object)Class5.Default, array2, null);
					gClass4 = gClass4;
					gClass3 = gClass3;
					class15 = null;
				}
				goto end_IL_08dc;
			}
			end_IL_08dc:;
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr / uIntPtr == 0)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Struct1)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, cultureInfo), cultureInfo, (string[])(object)Class5.Default, out object_2);
					_ = (GClass2)(object)Class5.Default;
					_ = (Class10)(object)@class.W(bindingFlags, null, null, array2, (ParameterModifier[])@class.t(null, null, cultureInfo));
					_ = (Qk7)(object)Class5.Default;
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Class0)(object)Class5.Default;
			}
			while (obj != null);
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					qk = (Qk7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array5, out *(object*)((Class7)(object)Class5.Default).t(obj, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)@class.W((BindingFlags)@class.W((BindingFlags)Class5.Default, null, type, array2, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array5, out object_2)), array3, type, array2, array4), (Type[])null, array4), cultureInfo));
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			if ((UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, array5, out object_2) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_38 = bindingFlags;
					MethodBase[] methodBase_16 = (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, type, array2, array4);
					Class7 obj64 = (Class7)(object)@class.e((BindingFlags)Class5.Default, array, array2, array4);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_39 = bindingFlags;
					Class7 class52 = @class;
					Class7 class53 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					Class7 obj65 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class51.e(bindingFlags_38, methodBase_16, (Type[])(object)obj64.W(bindingFlags_39, null, (Type)(object)class52.W((BindingFlags)((Class7)(object)((Class7)(object)class53.t(bindingFlags_40, (FieldInfo[])(object)obj65.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out object_2), obj, null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array4)).e(bindingFlags, array, null, array4), array3, (Type)(object)@class.t(bindingFlags, array6, ((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), (CultureInfo)(object)Class5.Default), array2, array4), null, array4), null);
					goto end_IL_0c64;
				}
			}
			end_IL_0c64:;
		}
		_ = (Class8)(object)Class5.Default;
		while (true)
		{
			if ((object)@class.e(bindingFlags, array, array2, array4) != null)
			{
				class32 = class32;
			}
			else if (obj == null)
			{
				break;
			}
		}
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (Class9)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
				struct2 = struct2;
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			catch
			{
				_003CModule_003E = null;
			}
		}
		try
		{
			try
			{
				class24 = (Class6)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), obj, (CultureInfo)(object)Class5.Default);
			}
			finally
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
				goto end_IL_0e93;
			}
			end_IL_0e93:;
		}
		finally
		{
			try
			{
				_ = (Class8)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array3, type, array2, array4), array2, array4);
			}
			finally
			{
				try
				{
					gClass3 = (GClass3)(object)Class5.Default;
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, cultureInfo);
				}
				goto IL_0f87;
			}
		}
		IL_2526:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			UIntPtr num7 = (UIntPtr)((Class7)null).j(default(BindingFlags), methodBase_17, ref *(object[]*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, null, array4), array2, array4), array4, cultureInfo, array5, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, array4));
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num7) + (unchecked((nuint)default(UIntPtr)) + uIntPtr + uIntPtr)) == 0)
			{
				_003CModule_003E = _003CModule_003E;
				class24 = (Class6)(object)Class5.Default;
				_ = (Class10)(object)@class.e(bindingFlags, array, array2, null);
			}
			else
			{
				class20 = class20;
				gClass3 = gClass3;
				class22 = (Class8)(object)@class.j((BindingFlags)((Class7)null).t((object)Class5.Default, type, cultureInfo), array, ref reference, array4, null, null, out object_2);
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr * uIntPtr + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array, ref *(object[]*)@class.t(null, type, null), array4, null, array5, out *(object*)null))) == 0)
		{
			class32 = null;
		}
		do
		{
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					Class7 obj71 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 class54 = @class;
					MethodBase[] methodBase_18 = array;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_42 = bindingFlags;
					MethodBase[] methodBase_19 = array;
					ref object[] object_13 = ref reference;
					Class7 obj72 = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)@class.t(null, type, null), array4, (CultureInfo)((Class7)null).t((object)Class5.Default, type, cultureInfo), null, out object_2);
					BindingFlags bindingFlags_43 = bindingFlags;
					Class7 obj73 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_44 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj74 = (Class7)((Class7)null).t((object)@class.j((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array4), obj, (CultureInfo)null), null, ref reference, array4, cultureInfo, null, out *(object*)Class5.Default), type, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_45 = bindingFlags;
					MethodBase[] methodBase_20 = (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref reference, array4, (CultureInfo)(object)Class5.Default, array5, out object_2);
					ref object[] object_14 = ref reference;
					ParameterModifier[] parameterModifier_8 = array4;
					CultureInfo cultureInfo_7 = cultureInfo;
					Class7 class56 = @class;
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					Type type_13 = (Type)(object)obj74.j(bindingFlags_45, methodBase_20, ref object_14, parameterModifier_8, cultureInfo_7, (string[])(object)class56.j(bindingFlags_46, null, ref *(object[]*)class57.W(bindingFlags, array3, null, (Type[])(object)Class5.Default, null), array4, cultureInfo, array5, out *(object*)@class.W(bindingFlags, array3, type, array2, array4)), out *(object*)Class5.Default);
					Type[] type_14 = (Type[])(object)((Class7)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null)).e((BindingFlags)Class5.Default, null, null, null);
					Class7 obj75 = (Class7)(object)@class.t(default(BindingFlags), array6, obj, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					ref object[] object_15 = ref *(object[]*)class55.j(bindingFlags_42, methodBase_19, ref object_13, (ParameterModifier[])(object)obj72.W(bindingFlags_43, (PropertyInfo[])(object)obj73.W(bindingFlags_44, propertyInfo_8, type_13, type_14, (ParameterModifier[])(object)obj75.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array3, (Type)(object)@class.j(bindingFlags, array, ref reference, array4, null, array5, out *(object*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, cultureInfo), null, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), out object_2)), array2, array4), cultureInfo, array5, out object_2)), null, array2, array4), (CultureInfo)@class.t(obj, null, (CultureInfo)(object)Class5.Default), array5, out object_2);
					Class7 obj76 = (Class7)(object)@class.j(default(BindingFlags), null, ref reference, (ParameterModifier[])(object)Class5.Default, null, (string[])((Class7)null).t(obj, type, cultureInfo), out *(object*)null);
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)(object)obj76.e(bindingFlags, array, null, array4)).W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, null, (ParameterModifier[])@class.t(((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null), type, null))).t(obj, type, (CultureInfo)@class.t(obj, type, cultureInfo)), array6, (object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null), cultureInfo);
					CultureInfo cultureInfo_8 = cultureInfo;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj71.W(bindingFlags_41, (PropertyInfo[])(object)class54.j(default(BindingFlags), methodBase_18, ref object_15, parameterModifier_9, cultureInfo_8, null, out *(object*)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default)), type, array2, array4);
					continue;
				}
			}
		}
		while ((object)Class5.Default != null);
		Class7 obj77 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_47 = (BindingFlags)@class.e(bindingFlags, null, array2, array4);
		PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)Class5.Default;
		Type type_15 = type;
		Class7 class58 = @class;
		Class7 obj78 = (Class7)((Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)((Class7)(object)((Class7)null).e((BindingFlags)@class.j(default(BindingFlags), null, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.t(obj, null, cultureInfo)), (MethodBase[])null, array2, array4)).e((BindingFlags)@class.t(null, type, cultureInfo), array, array2, array4), array4)).t(obj, type, (CultureInfo)(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj77.W(bindingFlags_47, propertyInfo_9, type_15, null, (ParameterModifier[])(object)class58.W((BindingFlags)((Class7)(object)obj78.e(bindingFlags, array, (Type[])(object)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, cultureInfo), array4)).t(obj, null, null), array3, type, array2, array4));
		_ = (Struct1)@class.e((BindingFlags)((Class7)(object)Class5.Default).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, null, array4), array, array2, array4);
		_ = (Class7)(object)Class5.Default;
		_ = (GClass0)(object)Class5.Default;
		_ = (Qk7)(object)Class5.Default;
		_ = (Class6)@class.t(null, type, cultureInfo);
		_ = (Class4)(object)Class5.Default;
		Class7 class59 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)class59.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default);
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class4)(object)@class.W(bindingFlags, array3, (Type)@class.t(Class5.Default, type, null), array2, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null), (MethodBase[])null, array2, array4));
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					Class7 class60 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class60.t(bindingFlags, null, obj, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)Class5.Default;
					Type type_16 = type;
					Type[] type_17 = (Type[])(object)Class5.Default;
					Class7 obj79 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_49 = bindingFlags;
					Type type_18 = type;
					Class7 class61 = @class;
					BindingFlags bindingFlags_50 = (BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])null, (ParameterModifier[])null);
					PropertyInfo[] propertyInfo_11 = array3;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)((Class7)(object)((Class7)null).W(bindingFlags_48, propertyInfo_10, type_16, type_17, (ParameterModifier[])(object)obj79.W(bindingFlags_49, null, type_18, (Type[])(object)class61.W(bindingFlags_50, propertyInfo_11, null, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), array4), array4))).e(bindingFlags, array, array2, array4);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		finally
		{
			try
			{
				Class7 class62 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class62.j(bindingFlags, array, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
			}
			catch
			{
				Class7 class63 = @class;
				BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
				ref object[] object_16 = ref *(object[]*)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, array2, array4), (object)null, (CultureInfo)null), (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, array6, obj, (CultureInfo)(object)@class.e((BindingFlags)@class.W(bindingFlags, array3, type, null, array4), array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, array3, type, null, array4)));
				Class7 obj81 = (Class7)(object)Class5.Default;
				Class7 obj82 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)obj81.t((BindingFlags)obj82.e(bindingFlags, null, array2, null), array6, null, cultureInfo);
				CultureInfo cultureInfo_9 = cultureInfo;
				BindingFlags bindingFlags_52 = bindingFlags;
				BindingFlags bindingFlags_53 = bindingFlags;
				PropertyInfo[] propertyInfo_12 = (PropertyInfo[])(object)Class5.Default;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj83 = (Class7)(object)class64.W(bindingFlags, null, type, array2, null);
				BindingFlags bindingFlags_54 = bindingFlags;
				MethodBase[] methodBase_21 = array;
				ref object[] object_17 = ref reference;
				CultureInfo cultureInfo_10 = cultureInfo;
				string[] string_4 = array5;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class63.j(bindingFlags_51, null, ref object_16, parameterModifier_10, cultureInfo_9, (string[])(object)((Class7)null).W(bindingFlags_52, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_53, propertyInfo_12, (Type)(object)obj83.j(bindingFlags_54, methodBase_21, ref object_17, null, cultureInfo_10, string_4, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array2, array4)), array2, (ParameterModifier[])null), type, array2, (ParameterModifier[])(object)Class5.Default), out *(object*)null);
			}
			goto IL_31b3;
		}
		IL_0f87:
		do
		{
			_ = (Class9)(object)Class5.Default;
		}
		while (obj != null);
		Class7 obj85 = (Class7)(object)@class.W(bindingFlags, null, type, array2, array4);
		Class7 obj86 = (Class7)(object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)obj85.W((BindingFlags)((Class7)(object)obj86.W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])@class.t(obj, null, (CultureInfo)(object)Class5.Default), null)).t(obj, type, cultureInfo), array3, null, (Type[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array4, (CultureInfo)null, array5, out *(object*)null), null);
		class15 = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_003CModule_003E = null;
			}
			while (obj != null || obj != null);
		}
		else
		{
			_ = (Class9)(object)((Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array4, null, (string[])(object)((Class7)(object)@class.e((BindingFlags)((Class7)null).t((BindingFlags)@class.t(null, null, null), array6, obj, (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo)), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default)).j(default(BindingFlags), null, ref *(object[]*)null, null, cultureInfo, null, out *(object*)null), out object_2)).e(default(BindingFlags), array, (Type[])(object)Class5.Default, array4);
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					class16 = (Class10)(object)@class.e(default(BindingFlags), null, null, array4);
				}
				while (obj != null);
			}
		}
		catch
		{
			Class2 obj87 = (Class2)((Class7)(object)((Class7)null).e(default(BindingFlags), array, (Type[])null, array4)).t(null, (Type)(object)@class.e((BindingFlags)Class5.Default, array, array2, array4), cultureInfo);
			class6 = (Class2)(object)Class5.Default;
			class6 = obj87;
		}
		Class7 class65 = @class;
		Class7 class66 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_55 = bindingFlags;
		Class7 class67 = @class;
		BindingFlags bindingFlags_56 = bindingFlags;
		MethodBase[] methodBase_22 = array;
		Class7 class68 = @class;
		BindingFlags bindingFlags_57 = bindingFlags;
		Class7 class69 = @class;
		BindingFlags bindingFlags_58 = (BindingFlags)((Class7)(object)((Class7)null).e((BindingFlags)@class.t(null, type, null), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null)).t(obj, (Type)(object)Class5.Default, (CultureInfo)@class.t(obj, null, cultureInfo));
		MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
		ref object[] object_18 = ref *(object[]*)Class5.Default;
		Class7 class70 = @class;
		bindingFlags = default(BindingFlags);
		ref object[] object_19 = ref *(object[]*)class68.t(bindingFlags_57, (FieldInfo[])(object)class69.j(bindingFlags_58, methodBase_23, ref object_18, (ParameterModifier[])(object)class70.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, array5, out object_2), (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null), array5, out *(object*)Class5.Default), Class5.Default, null);
		Class7 class71 = @class;
		Class7 class72 = @class;
		BindingFlags bindingFlags_59 = bindingFlags;
		MethodBase[] methodBase_24 = array;
		ref object[] object_20 = ref *(object[]*)((Class7)null).W(bindingFlags, array3, (Type)null, (Type[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, array2, array4), array4);
		ParameterModifier[] parameterModifier_11 = array4;
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)class67.j(bindingFlags_56, methodBase_22, ref object_19, (ParameterModifier[])class71.t(class72.j(bindingFlags_59, methodBase_24, ref object_20, parameterModifier_11, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array4, cultureInfo, (string[])null, out object_2), array5, out object_2), type, (CultureInfo)(object)Class5.Default), cultureInfo, array5, out object_2);
		Type type_19 = type;
		Type[] type_20 = (Type[])(object)Class5.Default;
		BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
		Type[] type_21 = array2;
		Class7 class73 = @class;
		BindingFlags bindingFlags_61 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null);
		MethodBase[] methodBase_25 = array;
		Class7 class74 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)class65.t(class66.W(bindingFlags_55, propertyInfo_13, type_19, type_20, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_60, (PropertyInfo[])null, (Type)null, type_21, (ParameterModifier[])(object)class73.W((BindingFlags)((Class7)null).e(bindingFlags_61, methodBase_25, (Type[])(object)((Class7)(object)class74.t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default)).e((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, array2, array4), ref *(object[]*)Class5.Default, array4, null, array5, out *(object*)null), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array, array2, array4), (ParameterModifier[])null), array3, null, array2, array4))), type, (CultureInfo)((Class7)(object)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null)).t(Class5.Default, null, (CultureInfo)(object)Class5.Default));
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
			}
		}
		else if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
		{
			bindingFlags = default(BindingFlags);
			gClass = (GClass1)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array4);
		}
		else
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			try
			{
				gClass4 = gClass4;
			}
			finally
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				goto end_IL_15e7;
			}
			end_IL_15e7:;
		}
		finally
		{
			try
			{
				while (true)
				{
					Type type_22 = (Type)(object)Class5.Default;
					Type type_23 = (Type)(object)Class5.Default;
					Class7 class75 = @class;
					bindingFlags = default(BindingFlags);
					if (((Class7)null).t((object)null, type_22, (CultureInfo)((Class7)null).t((object)null, type_23, (CultureInfo)(object)class75.W(bindingFlags, null, type, array2, null))) != null)
					{
						_ = (Class0)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Qk7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default));
					struct2 = (Struct2)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
					Class7 obj89 = (Class7)(object)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null);
					Class7 obj90 = (Class7)(object)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, (ParameterModifier[])null)).t(default(BindingFlags), array6, obj, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj89.W((BindingFlags)obj90.t(bindingFlags, array6, ((Class7)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null)).j(bindingFlags, array, ref reference, array4, cultureInfo, array5, out *(object*)null), (CultureInfo)(object)((Class7)(object)@class.W((BindingFlags)@class.e((BindingFlags)Class5.Default, array, null, array4), null, null, null, null)).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, array3, type, array2, (ParameterModifier[])null), obj, cultureInfo)), array3, type, null, array4);
					_ = (Class9)(object)Class5.Default;
					class15 = class15;
				}
				goto IL_186b;
			}
		}
		IL_43bb:
		try
		{
			qk = qk;
		}
		finally
		{
			do
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					class22 = class22;
					continue;
				}
			}
			while (obj != null);
			goto IL_43e7;
		}
	}
}
