using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using ns5;
using ns6;
using ns7;
using ns9;

namespace ns8;

[StandardModule]
internal sealed class Class9
{
	internal static Delegate smethod_0(Type type_0, Type type_1, string string_0, bool bool_0, bool bool_1)
	{
		return Delegate.CreateDelegate(type_0, type_1, string_0, bool_0, bool_1);
	}

	unsafe static void smethod_1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		try
		{
			while (obj != null)
			{
				Class7 class2 = @class;
				Class7 class3 = @class;
				cultureInfo = null;
				object object_ = class3.t(null, null, cultureInfo);
				type = null;
				Type type_ = type;
				Class7 class4 = @class;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				array = array;
				Class7 obj2 = (Class7)class2.t(object_, type_, (CultureInfo)(object)class4.e(bindingFlags_, array, (Type[])(object)Class5.Default, null));
				BindingFlags bindingFlags_2 = bindingFlags;
				array2 = array2;
				@class = (Class7)(object)obj2.t(bindingFlags_2, array2, null, cultureInfo);
				Class7 class5 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_3 = bindingFlags;
				Class7 class6 = @class;
				BindingFlags bindingFlags_4 = bindingFlags;
				MethodBase[] methodBase_ = array;
				array3 = array3;
				UIntPtr num = (UIntPtr)class5.e(bindingFlags_3, (MethodBase[])(object)class6.e(bindingFlags_4, methodBase_, array3, null), array3, null);
				num2 = default(UIntPtr);
				Class7 class10;
				BindingFlags bindingFlags_6;
				MethodBase[] methodBase_2;
				checked
				{
					num2 = unchecked((nuint)num) * unchecked(num2 / num2);
					num2 = default(UIntPtr);
					if (num2 * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						Class7 class7 = @class;
						Class7 class8 = @class;
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_5 = bindingFlags;
						array4 = array4;
						PropertyInfo[] propertyInfo_ = array4;
						array5 = array5;
						_ = (Class10)class7.t(class8.W(bindingFlags_5, propertyInfo_, null, null, array5), type, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)null));
						continue;
					}
					@struct = @struct;
					@struct = @struct;
					class9 = (Class9)(object)Class5.Default;
					class9 = null;
					class10 = @class;
					bindingFlags = default(BindingFlags);
					bindingFlags_6 = bindingFlags;
					methodBase_2 = (MethodBase[])(object)Class5.Default;
				}
				ref object[] object_2 = ref *(object[]*)Class5.Default;
				CultureInfo cultureInfo_ = cultureInfo;
				array6 = array6;
				BindingFlags bindingFlags_7 = (BindingFlags)((Class7)null).j(bindingFlags_6, methodBase_2, ref object_2, (ParameterModifier[])null, cultureInfo_, array6, out *(object*)Class5.Default);
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
				Class7 class11 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				MethodBase[] methodBase_3 = array;
				Class7 class12 = @class;
				Class7 obj3 = (Class7)(object)Class5.Default;
				obj = @class.j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array6, out *(object*)null);
				BindingFlags bindingFlags_9 = (BindingFlags)((Class7)obj3.t(obj, type, null)).t(obj, type, cultureInfo);
				MethodBase[] methodBase_4 = array;
				reference = ref *(object[]*)((Class7)null).W(bindingFlags, array4, (Type)null, array3, (ParameterModifier[])null);
				ref object[] object_3 = ref reference;
				Class7 obj4 = (Class7)(object)@class.t(bindingFlags, array2, null, null);
				BindingFlags bindingFlags_10 = bindingFlags;
				MethodBase[] methodBase_5 = array;
				ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
				string[] string_ = array6;
				reference2 = ref reference2;
				GClass0 obj5 = (GClass0)(object)class10.W(bindingFlags_7, propertyInfo_2, (Type)(object)((Class7)(object)class11.e(bindingFlags_8, methodBase_3, (Type[])(object)class12.j(bindingFlags_9, methodBase_4, ref object_3, (ParameterModifier[])(object)obj4.j(bindingFlags_10, methodBase_5, ref *(object[]*)null, parameterModifier_, cultureInfo_2, string_, out reference2), cultureInfo, array6, out *(object*)null), array5)).t(bindingFlags, null, Class5.Default, null), array3, array5);
				gClass = null;
				gClass = obj5;
			}
		}
		catch
		{
			@struct = @struct;
		}
		_ = (Class0)(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class15);
		if (num2 == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				nuint num3 = (nuint)(UIntPtr)class13.t(bindingFlags, null, obj, cultureInfo) / num2;
				num2 = default(UIntPtr);
				if (checked(num3 + (num2 - num2 + num2)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					Class0 obj7 = (Class0)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array5);
					class14 = class14;
					class14 = obj7;
					_ = (GClass2)((Class7)(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)null)).t(obj, type, cultureInfo);
					_003CModule_003E obj8 = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = null;
					_003CModule_003E = obj8;
				}
			}
		}
		else
		{
			Class5 obj9 = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.t(obj, type, cultureInfo), cultureInfo);
			class15 = class15;
			class15 = obj9;
			_ = (Class7)(object)Class5.Default;
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			try
			{
				class15 = null;
			}
			finally
			{
				_ = (Class6)@class.t(obj, type, cultureInfo);
				goto IL_04ca;
			}
		}
		_003CModule_003E = _003CModule_003E;
		goto IL_04ca;
		IL_3d1e:
		while ((object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array3, (ParameterModifier[])null) != null)
		{
			while (obj != null)
			{
				bindingFlags = default(BindingFlags);
				class14 = (Class0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), (object)null, cultureInfo);
			}
		}
		GClass2 gClass2;
		try
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass2 = (GClass2)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t((object)@class.t((BindingFlags)Class5.Default, null, Class5.Default, null), (Type)null, cultureInfo), array3, array5);
				}
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		Class8 class16 = class16;
		_ = (Class2)(object)Class5.Default;
		num2 = default(UIntPtr);
		nuint num4 = num2;
		Class7 class17 = @class;
		Class7 class18 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_11 = (BindingFlags)((Class7)(object)((Class7)(object)class18.e(bindingFlags, array, (Type[])(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out reference2), null)).t((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array6, out *(object*)null), array2, null, cultureInfo)).t(null, type, cultureInfo);
		Class7 obj11 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
		Class7 class19 = @class;
		ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_3 = cultureInfo;
		string[] string_2 = (string[])(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj12 = (Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), null, cultureInfo, null, out *(object*)null);
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_6 = (MethodBase[])(object)obj11.j(bindingFlags_12, (MethodBase[])(object)class19.j(default(BindingFlags), null, ref *(object[]*)null, parameterModifier_2, cultureInfo_3, string_2, out *(object*)obj12.W(bindingFlags, null, type, array3, null)), ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])@class.t(obj, type, cultureInfo), (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo), (string[])null, out reference2), null, cultureInfo, (string[])(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)null), out reference2);
		ref object[] object_4 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_3 = array5;
		CultureInfo cultureInfo_4 = cultureInfo;
		string[] string_3 = (string[])(object)Class5.Default;
		Class7 obj13 = (Class7)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array6, out reference2);
		object object_5 = obj;
		Class7 class20 = @class;
		bindingFlags = default(BindingFlags);
		nuint num5 = (nuint)(UIntPtr)class17.j(bindingFlags_11, methodBase_6, ref object_4, parameterModifier_3, cultureInfo_4, string_3, out *(object*)obj13.t(object_5, (Type)(object)class20.W(bindingFlags, array4, type, array3, null), (CultureInfo)(object)Class5.Default)) / num2;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class21);
		if (num4 / (num5 / num2) == 0)
		{
			class21 = class21;
		}
		else
		{
			_ = (Class6)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, (ParameterModifier[])@class.t(null, type, (CultureInfo)(object)Class5.Default));
		}
		do
		{
			_ = (Class7)(object)Class5.Default;
			_ = (Class6)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array5, (CultureInfo)null, array6, out *(object*)Class5.Default);
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class22);
		try
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, cultureInfo)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class16 = null;
				}
				finally
				{
					@struct = @struct;
					goto end_IL_4132;
				}
			}
			if (num2 == 0)
			{
				class22 = class22;
				_ = (GClass3)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, cultureInfo);
				_ = (Class4)(object)Class5.Default;
			}
			else
			{
				class16 = null;
			}
			end_IL_4132:;
		}
		catch
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					Class7 class23 = @class;
					BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = (BindingFlags)((Class7)null).W(bindingFlags_13, (PropertyInfo[])null, (Type)(object)class24.t(bindingFlags, array2, Class5.Default, null), array3, (ParameterModifier[])@class.t(null, type, null));
					PropertyInfo[] propertyInfo_3 = array4;
					Class7 obj14 = (Class7)(object)Class5.Default;
					Class7 obj15 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = (BindingFlags)obj15.e(bindingFlags, null, array3, null);
					MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
					ref object[] object_6 = ref reference;
					ParameterModifier[] parameterModifier_4 = array5;
					Class7 class25 = @class;
					BindingFlags bindingFlags_16 = bindingFlags;
					FieldInfo[] fieldInfo_ = array2;
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).t((BindingFlags)class23.W(bindingFlags_14, propertyInfo_3, (Type)(object)obj14.j(bindingFlags_15, methodBase_7, ref object_6, parameterModifier_4, (CultureInfo)(object)class25.t(bindingFlags_16, fieldInfo_, null, (CultureInfo)(object)class26.t(bindingFlags, null, obj, (CultureInfo)(object)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, null, out *(object*)null)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default))), array6, out reference2), array3, array5), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
				}
			}
			catch
			{
				class21 = (Class4)(object)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
				gClass = gClass;
				_ = (Struct2)Class5.Default;
			}
		}
		Class10 class27 = (Class10)(object)Class5.Default;
		_ = (GClass1)(object)Class5.Default;
		GClass1 gClass3;
		if (num2 == 0)
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)Class5.Default;
				}
				else
				{
					gClass3 = null;
				}
			}
			while (obj != null);
		}
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass4);
		while (obj != null)
		{
			gClass4 = gClass4;
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass2)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array5, (CultureInfo)null, array6, out *(object*)Class5.Default);
				}
				while ((object)Class5.Default != null);
			}
		}
		else
		{
			_ = (Class8)(object)Class5.Default;
		}
		if (checked(num2 + unchecked((nuint)default(UIntPtr))) == 0)
		{
			Class7 class28 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class28.e(bindingFlags, array, array3, array5) == (UIntPtr)(nuint)0u)
			{
				Class7 class29 = @class;
				Class7 class30 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)class29.t(class30.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo)), type, (CultureInfo)(object)Class5.Default);
			}
		}
		else
		{
			Class7 class31 = @class;
			BindingFlags bindingFlags_17 = bindingFlags;
			Class7 obj18 = (Class7)(object)Class5.Default;
			MethodBase[] methodBase_8 = array;
			Class7 class32 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_18 = (BindingFlags)((Class7)null).j(bindingFlags_17, (MethodBase[])null, ref *(object[]*)obj18.e(default(BindingFlags), methodBase_8, (Type[])(object)class32.e(bindingFlags, array, array3, array5), array5), array5, (CultureInfo)null, (string[])null, out *(object*)@class.j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array6, out *(object*)((Class7)null).t(obj, type, cultureInfo)), null, (string[])(object)Class5.Default, out *(object*)null));
			ref object[] object_7 = ref reference;
			ParameterModifier[] parameterModifier_5 = array5;
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class31.j(bindingFlags_18, null, ref object_7, parameterModifier_5, (CultureInfo)(object)class33.t(bindingFlags, (FieldInfo[])@class.t(obj, type, null), null, null), array6, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				catch
				{
					class9 = class9;
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		try
		{
			BindingFlags bindingFlags_19 = bindingFlags;
			FieldInfo[] fieldInfo_2 = array2;
			Class7 obj20 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_20 = (BindingFlags)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default);
			MethodBase[] methodBase_9 = array;
			Class7 class34 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_21 = bindingFlags;
			MethodBase[] methodBase_10 = (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
			Class7 class35 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)((Class7)null).t(bindingFlags_19, fieldInfo_2, (object)null, (CultureInfo)(object)obj20.e(bindingFlags_20, methodBase_9, (Type[])(object)class34.e(bindingFlags_21, methodBase_10, (Type[])(object)class35.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, null, (Type[])(object)Class5.Default, null)), array5));
			_ = Class5.Default;
			_ = Class5.Default;
			return;
		}
		catch
		{
			try
			{
				if ((UIntPtr)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
				{
					@class = (Class7)(object)Class5.Default;
				}
				return;
			}
			catch
			{
				class22 = null;
				return;
			}
		}
		IL_2138:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass3)(object)Class5.Default;
			_ = (Struct2)Class5.Default;
			gClass = null;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Struct1)Class5.Default;
					struct2 = struct2;
				}
				finally
				{
					class21 = (Class4)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					continue;
				}
			}
		}
		_ = (Class0)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)null);
		_ = (Struct2)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, array5), obj, cultureInfo);
		struct2 = struct2;
		num2 = default(UIntPtr);
		if (checked(unchecked(num2 / (nuint)(UIntPtr)Class5.Default) * (num2 * unchecked((nuint)default(UIntPtr)))) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class27 = (Class10)(object)Class5.Default;
				}
				catch
				{
					class15 = Class5.Default;
				}
			}
		}
		else
		{
			do
			{
				try
				{
					class16 = class16;
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					gClass4 = (GClass3)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		while (true)
		{
			if (obj != null)
			{
				_ = (Class6)((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default);
				_ = (Class4)(object)Class5.Default;
				_ = (Class2)(object)Class5.Default;
				gClass3 = gClass3;
			}
			else if (obj == null)
			{
				break;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			do
			{
				_ = (GClass0)(object)((Class7)null).j(bindingFlags, array, ref reference, array5, cultureInfo, array6, out reference2);
			}
			while (obj != null);
		}
		else
		{
			do
			{
				_ = (Class9)(object)Class5.Default;
			}
			while (obj != null);
		}
		try
		{
			class14 = class14;
			_003CModule_003E = _003CModule_003E;
			gClass3 = null;
		}
		finally
		{
			try
			{
				num2 = default(UIntPtr);
				nuint num6 = num2;
				num2 = default(UIntPtr);
				if (checked(num6 + num2) / (nuint)(UIntPtr)Class5.Default == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			catch
			{
				checked
				{
					if (num2 - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Class10)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array5);
						class15 = Class5.Default;
						@struct = @struct;
						_ = (Class4)(object)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])null);
					}
					else
					{
						@struct = (Struct1)Class5.Default;
					}
				}
			}
			goto IL_2425;
		}
		IL_170b:
		try
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)@class.W((BindingFlags)((Class7)(object)@class.W(bindingFlags, null, type, null, null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array5), array4, type, array3, array5);
				}
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_22 = (BindingFlags)Class5.Default;
					Class7 class36 = @class;
					BindingFlags bindingFlags_23 = (BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)@class.W(bindingFlags, null, null, null, null), array2, null, cultureInfo);
					FieldInfo[] fieldInfo_3 = array2;
					object object_8 = obj;
					Class7 obj25 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array4, null, null, null), (Type)(object)Class5.Default, array3, array5);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).t(bindingFlags_22, (FieldInfo[])(object)class36.t(bindingFlags_23, fieldInfo_3, object_8, (CultureInfo)(object)obj25.t(bindingFlags, array2, null, cultureInfo)), (object)null, cultureInfo);
				}
				catch
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (GClass3)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array5);
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			@class = (Class7)@class.t(obj, type, (CultureInfo)@class.t(null, null, null));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class37);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					@class = (Class7)(object)((Class7)(object)@class.j(bindingFlags, array, ref reference, array5, cultureInfo, null, out *(object*)null)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					class37 = class37;
				}
				catch
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					class14 = class14;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_196d;
		}
		IL_0f41:
		try
		{
			nuint num7 = num2;
			UIntPtr num8 = (UIntPtr)Class5.Default;
			num2 = default(UIntPtr);
			if (checked(num7 + (unchecked((nuint)num8) + num2)) == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					class21 = (Class4)(object)Class5.Default;
					Class7 obj32 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_24 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo);
					Type type_2 = type;
					Type[] type_3 = array3;
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)obj32.W(bindingFlags_24, propertyInfo_4, type_2, type_3, (ParameterModifier[])((Class7)(object)class38.W(bindingFlags, null, null, array3, array5)).t(Class5.Default, type, cultureInfo));
					_ = (GClass2)(object)Class5.Default;
					gClass = null;
				}
				else
				{
					BindingFlags bindingFlags_25 = bindingFlags;
					MethodBase[] methodBase_11 = array;
					ref object[] object_9 = ref reference;
					ParameterModifier[] parameterModifier_6 = array5;
					CultureInfo cultureInfo_5 = cultureInfo;
					Class7 class39 = @class;
					BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)((Class7)null).j(bindingFlags_25, methodBase_11, ref object_9, parameterModifier_6, cultureInfo_5, (string[])null, out *(object*)class39.W(bindingFlags_26, (PropertyInfo[])(object)class40.W(bindingFlags, array4, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, array3, null)), (Type)(object)Class5.Default, null, array5));
				}
			}
			else
			{
				while (obj != null)
				{
					_ = (Class6)(object)((Class7)null).e(bindingFlags, array, array3, array5);
				}
			}
		}
		catch
		{
			do
			{
				class27 = null;
			}
			while (obj != null);
		}
		try
		{
			Class7 obj34;
			Class7 class43;
			BindingFlags bindingFlags_28;
			MethodBase[] methodBase_13;
			Class7 obj35;
			do
			{
				Class7 class41 = @class;
				BindingFlags bindingFlags_27 = bindingFlags;
				MethodBase[] methodBase_12 = array;
				ref object[] object_10 = ref reference;
				ParameterModifier[] parameterModifier_7 = array5;
				Class7 class42 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)(object)class41.j(bindingFlags_27, methodBase_12, ref object_10, parameterModifier_7, null, (string[])(object)class42.e(bindingFlags, array, array3, array5), out *(object*)null)).t((BindingFlags)((Class7)null).W(bindingFlags, array4, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, null, (CultureInfo)(object)Class5.Default);
				obj34 = (Class7)(object)Class5.Default;
				class43 = @class;
				bindingFlags_28 = bindingFlags;
				methodBase_13 = array;
				obj35 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj34.W((BindingFlags)class43.e(bindingFlags_28, methodBase_13, (Type[])(object)obj35.e(bindingFlags, null, null, null), null), (PropertyInfo[])(object)Class5.Default, null, null, array5) != null);
		}
		catch
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
				class15 = null;
			}
			finally
			{
				try
				{
					class22 = null;
					class22 = class22;
					_ = (Class5)(object)@class.t(bindingFlags, array2, null, cultureInfo);
					class37 = class37;
				}
				catch
				{
					@struct = @struct;
					_ = (GClass3)(object)@class.e(bindingFlags, null, array3, array5);
				}
				goto end_IL_11fa;
			}
			end_IL_11fa:;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (Class2)(object)Class5.Default;
					class21 = class21;
					class37 = class37;
				}
				else
				{
					@struct = default(Struct1);
				}
			}
			else
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		nuint num9 = num2;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if (checked(num9 - (num2 + num2)) == 0)
		{
			Class7 class44 = @class;
			MethodBase[] methodBase_14 = array;
			Class7 class45 = @class;
			bindingFlags = default(BindingFlags);
			qk = (Qk7)(object)class44.e(default(BindingFlags), methodBase_14, (Type[])(object)class45.t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, array2, null, cultureInfo), obj, cultureInfo), (ParameterModifier[])(object)Class5.Default);
			qk = null;
		}
		else
		{
			class9 = null;
		}
		Class7 obj38 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_29 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = array4;
		Class7 class46 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_30 = bindingFlags;
		FieldInfo[] fieldInfo_4 = array2;
		object object_11 = obj;
		Class7 class47 = @class;
		BindingFlags bindingFlags_31 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = array4;
		Class7 class48 = @class;
		Class7 class49 = @class;
		object object_12 = Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_32 = bindingFlags;
		Class7 class50 = @class;
		BindingFlags bindingFlags_33 = bindingFlags;
		PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
		Class7 class51 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)obj38.W(bindingFlags_29, propertyInfo_5, null, (Type[])(object)class46.t(bindingFlags_30, fieldInfo_4, object_11, (CultureInfo)(object)((Class7)(object)class47.W(bindingFlags_31, propertyInfo_6, (Type)(object)class48.e(default(BindingFlags), (MethodBase[])class49.t(object_12, (Type)((Class7)(object)((Class7)null).t(bindingFlags_32, (FieldInfo[])(object)class50.W(bindingFlags_33, propertyInfo_7, (Type)(object)class51.t(bindingFlags, array2, Class5.Default, cultureInfo), array3, array5), (object)null, (CultureInfo)null)).t(null, null, null), null), array3, null), null, array5)).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, cultureInfo, array6, out *(object*)null), ref reference, array5, null, null, out *(object*)null)), array5);
		_ = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array6, out reference2);
		_ = (Class0)(object)Class5.Default;
		_ = (GClass0)(object)Class5.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) - num2 == 0)
			{
				if (num2 * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					try
					{
						class15 = class15;
					}
					finally
					{
						class16 = (Class8)@class.t(obj, type, cultureInfo);
						goto IL_1652;
					}
				}
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					gClass = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo);
					qk = qk;
					_ = (Qk7)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					if (num2 == 0)
					{
						_ = (Class9)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null);
					}
					else
					{
						_ = (Class0)(object)Class5.Default;
					}
				}
				catch
				{
					while ((object)Class5.Default != null)
					{
						class16 = class16;
						_ = (GClass3)(object)@class.t(bindingFlags, array2, @class.t(obj, type, (CultureInfo)(object)@class.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)Class5.Default)), cultureInfo);
						class22 = class22;
					}
				}
			}
			goto IL_1652;
		}
		IL_1652:
		gClass2 = null;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array5));
		bindingFlags = default(BindingFlags);
		class15 = (Class5)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo), cultureInfo, array6, out reference2);
		gClass2 = gClass2;
		try
		{
			while (obj != null)
			{
				gClass2 = null;
			}
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			goto IL_170b;
		}
		IL_2fe7:
		if (num2 == 0)
		{
			if (checked(num2 * num2) == 0)
			{
				struct2 = default(Struct2);
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		_ = (GClass3)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, null, array6, out *(object*)@class.W(bindingFlags, array4, null, null, (ParameterModifier[])(object)Class5.Default)), array2, (object)@class.t((BindingFlags)Class5.Default, array2, obj, null), cultureInfo);
		_ = (GClass1)(object)Class5.Default;
		checked
		{
			try
			{
				try
				{
					num2 = default(UIntPtr);
					if (num2 == 0)
					{
						_ = (Class8)(object)unchecked(@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, null, array6, out *(object*)Class5.Default));
					}
					else
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) * num2 == 0)
					{
						class14 = null;
					}
				}
			}
			catch
			{
				nuint num10 = num2;
				num2 = default(UIntPtr);
				if (num10 * (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) + num2) * num2) == 0)
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class6)(object)Class5.Default;
					}
				}
				else
				{
					do
					{
						_ = (GClass3)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
					}
					while (obj != null);
				}
			}
			do
			{
				try
				{
					_ = (Class5)(object)@class.t(default(BindingFlags), null, null, cultureInfo);
				}
				finally
				{
					gClass2 = gClass2;
					continue;
				}
			}
			while (obj != null);
			nuint num11 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default);
			num2 = default(UIntPtr);
			nuint num12 = num11 * (num2 + num2);
			Class7 obj43 = (Class7)(object)Class5.Default;
			Class7 class52 = @class;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			Class7 class53 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_34 = bindingFlags;
			MethodBase[] methodBase_15 = (MethodBase[])(object)Class5.Default;
			CultureInfo cultureInfo_6 = (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array5);
			object object_13 = obj;
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if (unchecked((nuint)default(UIntPtr)) * (num12 + unchecked((nuint)(UIntPtr)obj43.e((BindingFlags)class52.W(default(BindingFlags), propertyInfo_8, (Type)(object)class53.j((BindingFlags)((Class7)null).j(bindingFlags_34, methodBase_15, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_6, (string[])((Class7)null).t(object_13, (Type)(object)((Class7)(object)obj44.j(bindingFlags, null, ref reference, array5, cultureInfo, array6, out reference2)).e(bindingFlags, null, array3, array5), cultureInfo), out *(object*)Class5.Default), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2), (Type[])(object)Class5.Default, null), (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default))) * num2 == 0)
			{
				class14 = null;
			}
			else
			{
				gClass2 = gClass2;
			}
			while ((object)Class5.Default != null)
			{
				class22 = class22;
			}
			@struct = @struct;
		}
		try
		{
			_ = (Class0)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, obj, null);
		}
		finally
		{
			nuint num13 = num2;
			nuint num14 = num2;
			num2 = default(UIntPtr);
			if (num13 / checked(num14 + num2) == 0)
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
			}
			else
			{
				_ = (GClass0)(object)Class5.Default;
			}
			goto IL_34a4;
		}
		IL_2b88:
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class9 = class9;
			}
		}
		while ((object)Class5.Default != null);
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					Class7 class54 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class54.W(bindingFlags, array4, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array6, out reference2), cultureInfo), array3, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null));
					gClass3 = gClass3;
				}
			}
			else
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		do
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				try
				{
					class22 = class22;
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					@struct = @struct;
					_ = (GClass3)(object)@class.e(bindingFlags, null, array3, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array5, cultureInfo, (string[])(object)Class5.Default, out reference2));
					Class7 obj45 = (Class7)(object)@class.W(bindingFlags, array4, (Type)(object)((Class7)null).t((BindingFlags)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)).t(null, type, cultureInfo), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, (ParameterModifier[])(object)@class.t(bindingFlags, array2, obj, cultureInfo));
					MethodBase[] methodBase_16 = array;
					Type[] type_4 = array3;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj45.e(default(BindingFlags), methodBase_16, type_4, (ParameterModifier[])(object)class55.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(obj, (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array5, null, array6, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)Class5.Default)), (CultureInfo)(object)Class5.Default)));
					continue;
				}
			}
			try
			{
				_ = (Struct1)((Class7)(object)Class5.Default).t(default(BindingFlags), array2, null, null);
			}
			finally
			{
				class14 = class14;
				Class7 class56 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class56.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default);
				_ = (_003CModule_003E)(object)Class5.Default;
				gClass = gClass;
				continue;
			}
		}
		while (obj != null);
		Class7 class57 = @class;
		BindingFlags bindingFlags_35 = bindingFlags;
		PropertyInfo[] propertyInfo_9 = array4;
		Type type_5 = type;
		BindingFlags bindingFlags_36 = bindingFlags;
		PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(null, type, cultureInfo), array4, (Type)(object)Class5.Default, null, array5);
		Class7 class58 = @class;
		PropertyInfo[] propertyInfo_11 = array4;
		Type type_6 = type;
		Class7 class59 = @class;
		Type[] type_7 = (Type[])(object)Class5.Default;
		Class7 class60 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)class57.W(bindingFlags_35, propertyInfo_9, type_5, (Type[])(object)((Class7)null).W(bindingFlags_36, propertyInfo_10, (Type)null, (Type[])(object)class58.W(default(BindingFlags), propertyInfo_11, type_6, null, (ParameterModifier[])(object)class59.e(default(BindingFlags), null, type_7, (ParameterModifier[])(object)class60.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null))), array5), array5);
		try
		{
			gClass2 = null;
		}
		finally
		{
			while (true)
			{
				if (obj != null)
				{
					@struct = @struct;
					_ = (Struct1)Class5.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_2fe7;
		}
		IL_292e:
		class27 = class27;
		if ((UIntPtr)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass4 = gClass4;
				_ = (Class8)(object)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				@struct = @struct;
			}
			finally
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					goto IL_29be;
				}
			}
		}
		class27 = (Class10)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		goto IL_29be;
		IL_04ca:
		if (num2 == 0)
		{
			class15 = null;
		}
		try
		{
			class21 = (Class4)(object)Class5.Default;
			class21 = null;
			_ = (Struct1)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array6, out reference2);
		}
		catch
		{
			while ((object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, null, null), cultureInfo, array6, out *(object*)Class5.Default) != null)
			{
				try
				{
					@struct = @struct;
				}
				finally
				{
					class14 = (Class0)(object)Class5.Default;
					continue;
				}
			}
		}
		Class7 class61 = @class;
		bindingFlags = default(BindingFlags);
		Class10 obj48 = (Class10)(object)class61.j(bindingFlags, null, ref reference, array5, null, (string[])@class.t(null, null, cultureInfo), out *(object*)Class5.Default);
		class27 = null;
		class27 = obj48;
		try
		{
		}
		catch
		{
			do
			{
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, array, ref reference, array5, (CultureInfo)((Class7)null).t((object)null, (Type)(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.e(bindingFlags, null, array3, null), array, array3, array5), cultureInfo), (string[])null, out *(object*)null);
				_ = (GClass3)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, array3, null);
				_ = (Struct2)Class5.Default;
			}
			while (obj != null || obj != null);
		}
		try
		{
			class21 = null;
		}
		finally
		{
			try
			{
				do
				{
					gClass2 = null;
					gClass2 = gClass2;
					class14 = (Class0)(object)Class5.Default;
					class21 = null;
					class37 = class37;
				}
				while (obj != null);
			}
			catch
			{
				if (num2 / (nuint)(UIntPtr)((Class7)null).t((object)null, (Type)null, (CultureInfo)null) == 0)
				{
					gClass2 = (GClass2)(object)@class.W(bindingFlags, array4, null, array3, array5);
				}
			}
			goto IL_06f6;
		}
		IL_1a1f:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			if (num2 == 0)
			{
				try
				{
					class15 = Class5.Default;
				}
				finally
				{
					Class7 class62 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class62.e(bindingFlags, array, (Type[])(object)Class5.Default, array5);
					goto IL_1b95;
				}
			}
			try
			{
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class63.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
			}
			finally
			{
				qk = null;
				goto IL_1b95;
			}
		}
		try
		{
			_ = (Class2)(object)Class5.Default;
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				Class7 obj51 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null);
				bindingFlags = default(BindingFlags);
				Class7 obj52 = (Class7)(object)obj51.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.e(bindingFlags, array, array3, null)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), obj, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj52.W(bindingFlags, array4, type, array3, null);
			}
		}
		goto IL_1b95;
		IL_196d:
		try
		{
			if ((UIntPtr)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null))).t(null, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class16 = (Class8)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (GClass2)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				}
				finally
				{
					_ = (GClass3)(object)Class5.Default;
					continue;
				}
			}
			goto IL_1a1f;
		}
		IL_1f25:
		try
		{
			try
			{
				gClass4 = gClass4;
				_ = (Class6)(object)Class5.Default;
				BindingFlags bindingFlags_37 = bindingFlags;
				PropertyInfo[] propertyInfo_12 = array4;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj54 = (Class7)(object)class64.t(bindingFlags, array2, obj, cultureInfo);
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)null).W(bindingFlags_37, propertyInfo_12, (Type)(object)obj54.t((BindingFlags)class65.t(bindingFlags, array2, null, cultureInfo), null, obj, cultureInfo), array3, array5);
				class15 = null;
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					@class = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array3, array5);
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
				}
				goto end_IL_1f26;
			}
			end_IL_1f26:;
		}
		finally
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
				else
				{
					_ = (Class2)((Class7)null).t(obj, type, (CultureInfo)null);
				}
			}
			catch
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)@class.t(null, null, cultureInfo);
					_ = Class5.Default;
					gClass3 = gClass3;
					_ = (Qk7)(object)Class5.Default;
				}
			}
			goto IL_206e;
		}
		IL_206e:
		Class7 obj56 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)((Class7)((Class7)null).t((object)null, (Type)(object)obj56.W(bindingFlags, null, type, array3, null), (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array5))).t(null, null, cultureInfo);
		num2 = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0 && num2 == 0)
		{
			try
			{
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array5, cultureInfo, array6, out *(object*)null);
			}
			finally
			{
				_ = (GClass2)@class.t(null, null, cultureInfo);
				goto IL_2138;
			}
		}
		goto IL_2138;
		IL_06f6:
		_ = Class5.Default;
		_ = (Qk7)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, null, null, out reference2);
		do
		{
			_ = (Struct2)Class5.Default;
		}
		while ((object)@class.e((BindingFlags)Class5.Default, (MethodBase[])@class.t(null, null, cultureInfo), null, (ParameterModifier[])(object)Class5.Default) != null || obj != null);
		do
		{
			_ = (GClass2)(object)Class5.Default;
		}
		while (obj != null);
		while ((object)Class5.Default != null)
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					class14 = (Class0)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null);
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		_ = (_003CModule_003E)(object)@class.W(default(BindingFlags), array4, null, array3, array5);
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					_ = (Class0)(object)@class.j(default(BindingFlags), null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array6, out reference2);
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					class15 = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_085f;
				}
				end_IL_085f:;
			}
			finally
			{
				goto end_IL_085e;
			}
			end_IL_085e:;
		}
		do
		{
			Class7 class66 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)class66.e(bindingFlags, array, (Type[])(object)Class5.Default, array5);
		}
		while (obj != null);
		try
		{
			class14 = null;
		}
		catch
		{
			try
			{
				BindingFlags bindingFlags_38 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)null).W(bindingFlags_38, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, array2, null, null), @class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, null, null, array5)), (CultureInfo)(object)((Class7)null).e(bindingFlags, array, array3, array5)), type, array3, (ParameterModifier[])(object)Class5.Default);
			}
			finally
			{
				class21 = (Class4)(object)Class5.Default;
				goto end_IL_08b9;
			}
			end_IL_08b9:;
		}
		Class7 obj60 = (Class7)(object)Class5.Default;
		Class7 class67 = @class;
		FieldInfo[] fieldInfo_5 = array2;
		object object_14 = obj;
		Class7 class68 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj60.j((BindingFlags)class67.t(default(BindingFlags), fieldInfo_5, object_14, (CultureInfo)(object)class68.W(bindingFlags, null, (Type)(object)@class.j(bindingFlags, null, ref reference, array5, null, null, out reference2), null, array5)), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
		@struct = @struct;
		do
		{
			try
			{
				Class7 class69 = @class;
				BindingFlags bindingFlags_39 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_40 = bindingFlags;
				ref object[] object_15 = ref reference;
				CultureInfo cultureInfo_7 = cultureInfo;
				Class7 class70 = @class;
				bindingFlags = default(BindingFlags);
				if (checked(unchecked((nuint)(UIntPtr)class69.j(bindingFlags_39, (MethodBase[])(object)((Class7)null).j(bindingFlags_40, (MethodBase[])null, ref object_15, (ParameterModifier[])null, cultureInfo_7, (string[])(object)class70.j(bindingFlags, null, ref reference, null, cultureInfo, array6, out reference2), out *(object*)null), ref *(object[]*)null, array5, cultureInfo, array6, out *(object*)@class.t(@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, array5), type, cultureInfo))) - unchecked((nuint)(UIntPtr)@class.j((BindingFlags)Class5.Default, array, ref reference, array5, cultureInfo, array6, out *(object*)null))) == 0)
				{
					class37 = (Class6)(object)Class5.Default;
				}
				else
				{
					BindingFlags bindingFlags_41 = bindingFlags;
					MethodBase[] methodBase_17 = array;
					ref object[] object_16 = ref reference;
					ParameterModifier[] parameterModifier_8 = array5;
					CultureInfo cultureInfo_8 = cultureInfo;
					Class7 obj61 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out reference2);
					BindingFlags bindingFlags_42 = bindingFlags;
					FieldInfo[] fieldInfo_6 = array2;
					Class7 class71 = @class;
					BindingFlags bindingFlags_43 = bindingFlags;
					MethodBase[] methodBase_18 = array;
					Class7 obj62 = (Class7)(object)@class.e(bindingFlags, array, array3, array5);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).j(bindingFlags_41, methodBase_17, ref object_16, parameterModifier_8, cultureInfo_8, (string[])null, out *(object*)((Class7)(object)obj61.t(bindingFlags_42, fieldInfo_6, null, (CultureInfo)(object)class71.e(bindingFlags_43, methodBase_18, (Type[])(object)obj62.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null), null))).W((BindingFlags)Class5.Default, array4, type, (Type[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array5));
					_ = (GClass3)(object)@class.W(bindingFlags, array4, type, array3, (ParameterModifier[])(object)Class5.Default);
					class14 = class14;
					class15 = (Class5)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array5));
				}
			}
			finally
			{
				_ = (Class9)(object)Class5.Default;
				continue;
			}
		}
		while (@class.t(Class5.Default, null, cultureInfo) != null);
		do
		{
			Class7 obj63 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
			BindingFlags bindingFlags_44 = bindingFlags;
			Type[] type_8 = array3;
			Class7 class72 = @class;
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_19 = array;
			Class7 class73 = @class;
			BindingFlags bindingFlags_46 = bindingFlags;
			PropertyInfo[] propertyInfo_13 = array4;
			Type type_9 = type;
			Class7 obj64 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)((Class7)(object)obj63.W(bindingFlags_44, null, null, type_8, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)class72.j(bindingFlags_45, methodBase_19, ref *(object[]*)class73.W(bindingFlags_46, propertyInfo_13, type_9, null, (ParameterModifier[])(object)obj64.W(bindingFlags, null, null, array3, array5)), null, (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array5, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)(object)Class5.Default)), null, out *(object*)null), (PropertyInfo[])null, (Type)(object)Class5.Default, array3, (ParameterModifier[])null))).t(null, type, cultureInfo);
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).W(bindingFlags, array4, type, array3, array5) != null);
		do
		{
			_ = (Qk7)(object)Class5.Default;
			class16 = class16;
			class16 = class16;
			Class7 class74 = @class;
			BindingFlags bindingFlags_47 = bindingFlags;
			MethodBase[] methodBase_20 = array;
			ref object[] object_17 = ref *(object[]*)Class5.Default;
			Class7 class75 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)class74.j(bindingFlags_47, methodBase_20, ref object_17, (ParameterModifier[])(object)class75.t(bindingFlags, array2, Class5.Default, cultureInfo), null, (string[])(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, array5)).W(bindingFlags, array4, type, null, array5), out reference2);
			bindingFlags = default(BindingFlags);
			class16 = (Class8)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array3, array5);
		}
		while (obj != null);
		try
		{
			_ = (Struct2)((Class7)@class.t(Class5.Default, type, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), Class5.Default, (CultureInfo)(object)Class5.Default);
		}
		finally
		{
			gClass3 = (GClass1)(object)Class5.Default;
			goto IL_0f41;
		}
		IL_1ec8:
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					struct2 = (Struct2)((Class7)null).t(bindingFlags, array2, (object)null, cultureInfo);
					struct2 = struct2;
				}
			}
			finally
			{
				_ = (Class9)(object)Class5.Default;
				goto IL_1f25;
			}
		}
		goto IL_1f25;
		IL_34a4:
		do
		{
			_ = (Class0)(object)Class5.Default;
		}
		while (obj != null || @class.t(((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, array5), type, array3, (ParameterModifier[])null)).e(bindingFlags, null, array3, array5), type, (CultureInfo)(object)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null)).e((BindingFlags)Class5.Default, null, array3, (ParameterModifier[])(object)Class5.Default)) != null || obj != null);
		checked
		{
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					class16 = null;
					_ = (GClass3)(object)Class5.Default;
					_ = (GClass0)((Class7)(object)Class5.Default).t(obj, (Type)@class.t(null, null, cultureInfo), null);
				}
				else
				{
					nuint num15 = num2;
					Class7 obj65 = (Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])null, array5);
					bindingFlags = default(BindingFlags);
					if (num15 - unchecked((nuint)(UIntPtr)obj65.W(bindingFlags, null, type, array3, array5)) == 0)
					{
						_ = (GClass0)@class.t(obj, type, cultureInfo);
					}
				}
			}
			try
			{
				while (obj != null)
				{
					while ((object)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, null) != null)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
			catch
			{
			}
		}
		try
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (GClass1)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, cultureInfo);
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
				@struct = (Struct1)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, null, array6, out *(object*)Class5.Default);
			}
		}
		try
		{
			if ((UIntPtr)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)null) == (UIntPtr)(nuint)0u)
			{
				if (num2 == 0)
				{
					gClass2 = (GClass2)(object)Class5.Default;
				}
				else
				{
					@struct = @struct;
				}
			}
		}
		finally
		{
			_ = (GClass3)(object)Class5.Default;
			goto IL_36f8;
		}
		IL_1d6f:
		try
		{
			do
			{
				gClass4 = gClass4;
				gClass4 = gClass4;
			}
			while (obj != null || obj != null);
		}
		catch
		{
			if (num2 == 0)
			{
				try
				{
					_ = (Class8)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array3, array5);
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		try
		{
			num2 = default(UIntPtr);
			if (checked(num2 + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				if (num2 == 0)
				{
					Class7 class76 = @class;
					BindingFlags bindingFlags_48 = bindingFlags;
					FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class76.t(bindingFlags_48, fieldInfo_7, ((Class7)null).t(bindingFlags, array2, (object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array6, out *(object*)Class5.Default), cultureInfo), null);
					@struct = default(Struct1);
					@struct = @struct;
					gClass3 = gClass3;
					_ = (GClass3)(object)@class.W(bindingFlags, null, null, array3, null);
				}
			}
			else if (num2 == 0)
			{
				@struct = (Struct1)Class5.Default;
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			goto IL_1ec8;
		}
		IL_1b95:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class16 = class16;
				_003CModule_003E = (_003CModule_003E)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
			}
			catch
			{
				Class7 class77 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj70 = (Class7)(object)class77.W(bindingFlags, array4, type, array3, null);
				Class7 class78 = @class;
				BindingFlags bindingFlags_49 = bindingFlags;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj70.j((BindingFlags)class78.j(bindingFlags_49, (MethodBase[])(object)class79.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array5, cultureInfo, (string[])(object)Class5.Default, out reference2)), ref *(object[]*)null, null, cultureInfo, null, out *(object*)null), array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array6, out *(object*)null);
			}
			finally
			{
				do
				{
					class27 = null;
				}
				while (obj != null);
				goto IL_1d6f;
			}
		}
		if (checked(num2 - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			nuint num16 = num2;
			num2 = default(UIntPtr);
			if (checked(num16 + num2) / checked(unchecked((nuint)(UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)Class5.Default)) * unchecked((nuint)(UIntPtr)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, null), null, null, (ParameterModifier[])(object)Class5.Default))) == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		else if (num2 == 0)
		{
			_ = (Qk7)(object)@class.W(bindingFlags, null, null, null, array5);
		}
		goto IL_1d6f;
		IL_29be:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (Class10)(object)Class5.Default;
					class15 = null;
				}
				while ((object)((Class7)null).W(bindingFlags, array4, (Type)null, (Type[])null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array3, array5)) != null);
			}
			catch
			{
				gClass4 = null;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			if (num2 == 0)
			{
				qk = qk;
			}
		}
		else
		{
			nuint num19;
			checked
			{
				nuint num17 = unchecked((nuint)(UIntPtr)Class5.Default) * num2;
				nuint num18 = num2;
				num2 = default(UIntPtr);
				num19 = num17 - (num18 + num2) * num2;
				num2 = default(UIntPtr);
			}
			if (checked(num19 * num2) / num2 == 0)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		num2 = default(UIntPtr);
		if (checked(num2 - num2) == 0)
		{
			class22 = class22;
		}
		@class = @class;
		while ((object)((Class7)null).t((BindingFlags)@class.e(bindingFlags, array, array3, null), array2, (object)null, cultureInfo) != null)
		{
			while (obj != null)
			{
				try
				{
					_ = (Class5)@class.t(null, type, cultureInfo);
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					continue;
				}
			}
		}
		if (num2 / unchecked((nuint)default(UIntPtr)) == 0)
		{
			try
			{
				qk = null;
			}
			finally
			{
				do
				{
					_ = (GClass1)(object)@class.e((BindingFlags)Class5.Default, array, array3, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj != null);
				goto IL_2b88;
			}
		}
		goto IL_2b88;
		IL_2425:
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					class22 = class22;
				}
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
				else
				{
					object object_18 = Class5.Default;
					Class7 obj73 = (Class7)((Class7)null).t((object)@class.e(default(BindingFlags), (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo), null, (ParameterModifier[])(object)Class5.Default), type, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).t(object_18, (Type)(object)obj73.e(bindingFlags, null, array3, (ParameterModifier[])(object)@class.t(bindingFlags, array2, null, (CultureInfo)(object)Class5.Default)), cultureInfo);
				}
			}
		}
		else
		{
			Class7 class80 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class6)(object)class80.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, array6, out *(object*)null);
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				class21 = class21;
				class16 = (Class8)(object)@class.t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array5), array2, null, cultureInfo);
			}
			else
			{
				class16 = (Class8)(object)Class5.Default;
			}
		}
		catch
		{
			gClass = gClass;
		}
		while (obj != null)
		{
			try
			{
				class9 = null;
			}
			catch
			{
			}
		}
		try
		{
			_ = (Class4)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)(object)@class.t(bindingFlags, array2, obj, cultureInfo)).j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)Class5.Default, array5, null, array6, out *(object*)null), null);
			gClass4 = (GClass3)(object)((Class7)null).W(bindingFlags, array4, type, (Type[])@class.t(obj, type, null), (ParameterModifier[])(object)@class.W(bindingFlags, array4, type, null, null));
			_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, cultureInfo);
			bindingFlags = default(BindingFlags);
			class15 = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j((BindingFlags)@class.t(null, type, cultureInfo), array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, array6, out *(object*)Class5.Default), ref *(object[]*)null, array5, (CultureInfo)null, (string[])null, out reference2);
		}
		finally
		{
			class14 = class14;
			goto IL_2750;
		}
		IL_36f8:
		do
		{
			Class7 obj76 = (Class7)(object)Class5.Default;
			object object_19 = obj;
			Type type_10 = type;
			BindingFlags bindingFlags_50 = bindingFlags;
			Class7 class81 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t((BindingFlags)obj76.t(object_19, type_10, (CultureInfo)(object)((Class7)null).j(bindingFlags_50, (MethodBase[])(object)class81.t(bindingFlags, array2, obj, cultureInfo), ref reference, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array3, array5), (ParameterModifier[])null), (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array5, cultureInfo, array6, out reference2), (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)Class5.Default)).t(obj, type, cultureInfo), (ParameterModifier[])(object)@class.e(bindingFlags, array, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])((Class7)null).t((object)null, (Type)(object)@class.j((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array3, array5), array, ref *(object[]*)Class5.Default, array5, (CultureInfo)@class.t(((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default), type, null), (string[])(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)((Class7)null).j((BindingFlags)@class.e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, array5), (MethodBase[])null, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2), null, out reference2), array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, array, array3, array5), null, out reference2), out reference2), (CultureInfo)(object)Class5.Default), (object)Class5.Default, cultureInfo), array5)), out *(object*)Class5.Default)), (FieldInfo[])null, (object)Class5.Default, cultureInfo) != (UIntPtr)(nuint)0u)
			{
				class37 = class37;
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, null);
				struct2 = default(Struct2);
			}
			else
			{
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class82.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
			}
		}
		while (obj != null);
		_ = (Qk7)(object)Class5.Default;
		class27 = class27;
		num2 = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
		{
			while (true)
			{
				BindingFlags bindingFlags_51 = bindingFlags;
				MethodBase[] methodBase_21 = array;
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).e(bindingFlags_51, methodBase_21, (Type[])null, (ParameterModifier[])(object)class83.W(bindingFlags, array4, type, null, array5)) == null)
				{
					break;
				}
				Class7 obj77 = (Class7)(object)@class.j(bindingFlags, null, ref reference, array5, null, null, out *(object*)null);
				object object_20 = @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, array, ref reference, array5, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])@class.t(obj, type, null), (Type)(object)Class5.Default, array3, array5), (string[])(object)Class5.Default, out reference2), array5);
				Type type_11 = (Type)(object)Class5.Default;
				Class7 obj78 = (Class7)(object)Class5.Default;
				Class7 obj79 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class10)obj77.t(object_20, type_11, (CultureInfo)obj78.t(obj79.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.t(bindingFlags, array2, null, cultureInfo)), type, null));
			}
		}
		class27 = class27;
		try
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				_ = (GClass0)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
				goto end_IL_3b95;
			}
			end_IL_3b95:;
		}
		catch
		{
			try
			{
				_ = (Qk7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, (CultureInfo)@class.t(obj, type, null), array6, out *(object*)null);
			}
			finally
			{
				_ = Class5.Default;
				goto end_IL_3bbd;
			}
			end_IL_3bbd:;
		}
		finally
		{
			if (num2 == 0)
			{
				try
				{
					class27 = (Class10)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo)).t(bindingFlags, array2, obj, cultureInfo);
				}
				finally
				{
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class84.j(bindingFlags, null, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)(object)@class.W(bindingFlags, array4, type, array3, array5)).t(Class5.Default, null, null));
					goto IL_3d1e;
				}
			}
			goto IL_3d1e;
		}
		IL_2750:
		_ = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)@class.e(bindingFlags, array, array3, array5), array5), array2, (object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.W(bindingFlags, array4, type, array3, (ParameterModifier[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo)), null, array3, null), cultureInfo), cultureInfo);
		@class = @class;
		UIntPtr num20 = num2;
		num2 = default(UIntPtr);
		checked
		{
			nuint num21 = num2 - (num2 + (num2 + unchecked((nuint)default(UIntPtr))));
			num2 = default(UIntPtr);
			if (unchecked((nuint)num20) * unchecked(num21 / num2) == 0)
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					class9 = null;
				}
				finally
				{
					while (obj != null)
					{
						class14 = class14;
						gClass3 = gClass3;
						gClass4 = (GClass3)(object)Class5.Default;
						_ = (GClass0)(object)@class.j(bindingFlags, null, ref *unchecked((object[]*)Class5.Default), (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)Class5.Default, array6, out reference2), cultureInfo, array6, out reference2);
					}
					goto IL_292e;
				}
			}
		}
		if (num2 / num2 == 0)
		{
			class27 = class27;
			goto IL_292e;
		}
		try
		{
			struct2 = struct2;
		}
		finally
		{
			@class = (Class7)(object)Class5.Default;
			goto IL_292e;
		}
	}

	unsafe static void smethod_2()
	{
		Class5 @class = @class;
		@class = @class;
		Class7 obj = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
		Class7 class2 = null;
		Class7 class3 = class2;
		BindingFlags bindingFlags_2 = bindingFlags;
		PropertyInfo[] array = array;
		PropertyInfo[] propertyInfo_ = array;
		Type type = type;
		Type type_ = type;
		ParameterModifier[] array2 = array2;
		ref object[] object_ = ref *(object[]*)class3.W(bindingFlags_2, propertyInfo_, type_, null, array2);
		ParameterModifier[] parameterModifier_ = array2;
		CultureInfo cultureInfo_ = null;
		string[] array3 = array3;
		string[] string_ = array3;
		ref object reference = ref reference;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		if ((UIntPtr)obj.j(bindingFlags_, methodBase_, ref object_, parameterModifier_, cultureInfo_, string_, out reference) == (UIntPtr)(nuint)0u)
		{
			try
			{
				Struct2 obj2 = (Struct2)Class5.Default;
				@struct = @struct;
				@struct = obj2;
			}
			catch
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						class4 = (Class4)(object)Class5.Default;
						class4 = class4;
						Class7 class5 = class2;
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_3 = bindingFlags;
						MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
						Class7 obj4 = (Class7)(object)Class5.Default;
						Class7 obj5 = (Class7)(object)Class5.Default;
						BindingFlags bindingFlags_4 = bindingFlags;
						PropertyInfo[] propertyInfo_2 = array;
						array4 = null;
						BindingFlags bindingFlags_5 = (BindingFlags)obj5.W(bindingFlags_4, propertyInfo_2, null, array4, null);
						array5 = null;
						MethodBase[] methodBase_3 = array5;
						ParameterModifier[] parameterModifier_2 = array2;
						Class7 class6 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class0)(object)class5.j(bindingFlags_3, methodBase_2, ref *(object[]*)obj4.j(bindingFlags_5, methodBase_3, ref *(object[]*)null, parameterModifier_2, (CultureInfo)(object)class6.W(bindingFlags, array, null, null, null), array3, out reference), array2, cultureInfo_, array3, out *(object*)null);
						gClass = gClass;
						gClass = gClass;
						continue;
					}
					break;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			checked
			{
				num = unchecked(num / num) * num;
				Class7 class7 = class2;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)class7.e(bindingFlags, null, array4, null))) == 0)
				{
					do
					{
						gClass2 = null;
						gClass2 = null;
						_ = (GClass0)(object)Class5.Default;
						_ = Class5.Default;
						_ = (GClass2)(object)Class5.Default;
					}
					while (obj3 != null);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class8);
		while ((object)class2.e(bindingFlags, array5, array4, null) != null)
		{
			do
			{
				class8 = null;
				class8 = class8;
			}
			while ((object)Class5.Default != null || ((Class7)null).t((object)Class5.Default, (Type)((Class7)(object)Class5.Default).t(null, type, cultureInfo_), cultureInfo_) != null);
		}
		do
		{
			_ = (Qk7)(object)Class5.Default;
		}
		while (obj3 != null || obj3 != null);
		gClass = null;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if (num == 0)
		{
			try
			{
				while (obj3 != null)
				{
					@class = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).e(bindingFlags, array5, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass0)(object)Class5.Default;
					struct2 = default(Struct1);
				}
				goto IL_04de;
			}
		}
		Class7 class9 = class2;
		MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
		ref object[] reference2 = ref reference2;
		ref object[] object_2 = ref reference2;
		ParameterModifier[] parameterModifier_3 = array2;
		CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
		string[] string_2 = array3;
		Class7 class10 = class2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_6 = bindingFlags;
		FieldInfo[] array6 = (FieldInfo[])(object)Class5.Default;
		nuint num2;
		checked
		{
			num2 = unchecked((nuint)(UIntPtr)class9.j(default(BindingFlags), methodBase_4, ref object_2, parameterModifier_3, cultureInfo_2, string_2, out *(object*)((Class7)(object)class10.t(bindingFlags_6, array6, null, cultureInfo_)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)class2.e((BindingFlags)class2.j((BindingFlags)((Class7)null).W(bindingFlags, array, type, (Type[])null, array2), array5, ref reference2, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null), array5, null, array2)))) * (unchecked(num / num) + unchecked((nuint)default(UIntPtr)));
			num = default(UIntPtr);
		}
		nuint num3 = checked(num2 * (unchecked((nuint)default(UIntPtr)) - num)) / (nuint)(UIntPtr)Class5.Default;
		Class7 obj7 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (num3 * unchecked((nuint)(UIntPtr)obj7.t(bindingFlags, array6, null, cultureInfo_)) == 0)
			{
				_ = (Class7)(object)Class5.Default;
			}
			goto IL_04de;
		}
		IL_33c4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		do
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
				@class = null;
			}
			finally
			{
				qk = null;
				continue;
			}
		}
		while ((object)((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, array4, array2) != null || obj3 != null);
		class2 = (Class7)((Class7)null).t(obj3, type, (CultureInfo)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			try
			{
				gClass3 = gClass3;
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
				goto end_IL_3425;
			}
			end_IL_3425:;
		}
		catch
		{
			if (num == 0)
			{
				Class7 obj8 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj8.e(bindingFlags, array5, array4, array2) == (UIntPtr)(nuint)0u)
				{
					gClass4 = (GClass1)(object)Class5.Default;
				}
			}
			else
			{
				_ = (Class5)(object)((Class7)class2.t(null, type, cultureInfo_)).t((BindingFlags)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).e(bindingFlags, array5, null, array2), type, null), array6, null, cultureInfo_);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class11);
		if ((UIntPtr)class2.t(bindingFlags, array6, obj3, null) == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class11 = null;
				}
			}
		}
		gClass2 = (GClass0)(object)Class5.Default;
		_ = (Class9)(object)Class5.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + num + (num + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				Class7 class12 = class2;
				unchecked
				{
					BindingFlags bindingFlags_7 = (BindingFlags)Class5.Default;
					Class7 obj10 = (Class7)(object)((Class7)null).W(default(BindingFlags), array, (Type)(object)Class5.Default, array4, array2);
					object object_3 = obj3;
					Type type_2 = type;
					Class7 class13 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class12.t(bindingFlags_7, null, null, (CultureInfo)obj10.t(object_3, type_2, (CultureInfo)(object)((Class7)(object)class13.j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)Class5.Default, null, array3, out *(object*)null)).t(bindingFlags, array6, obj3, cultureInfo_)));
				}
			}
			else if (unchecked((nuint)(UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, array6, obj3, cultureInfo_)) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					class4 = (Class4)(object)unchecked(class2.j(bindingFlags, array5, ref *(object[]*)null, array2, cultureInfo_, array3, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_)));
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					goto IL_36a3;
				}
			}
			goto IL_36a3;
		}
		IL_1efe:
		while (obj3 != null)
		{
			Class7 obj11 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj11.e(bindingFlags, array5, null, (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
			if ((UIntPtr)class2.t(obj3, type, null) == (UIntPtr)(nuint)0u)
			{
				_ = (Class6)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
			}
		}
		catch
		{
			UIntPtr num4 = (UIntPtr)((Class7)null).W(bindingFlags, array, type, (Type[])null, array2);
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num4) * num) == 0)
			{
				while (obj3 != null)
				{
					_ = (Struct2)((Class7)(object)((Class7)((Class7)(object)class2.e((BindingFlags)Class5.Default, null, array4, array2)).t(obj3, null, null)).t(bindingFlags, array6, ((Class7)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo_)).t(null, (Type)(object)Class5.Default, cultureInfo_), (CultureInfo)(object)((Class7)null).e(bindingFlags, array5, array4, array2))).W(bindingFlags, array, type, array4, array2);
				}
			}
			else
			{
				class4 = class4;
			}
		}
		_003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class14);
		try
		{
			try
			{
				try
				{
					class11 = null;
				}
				finally
				{
					gClass = gClass;
					goto end_IL_204c;
				}
				end_IL_204c:;
			}
			catch
			{
				try
				{
					class14 = (Class6)(object)Class5.Default;
				}
				catch
				{
					class15 = class15;
					class4 = (Class4)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref reference2, array2, cultureInfo_, array3, out reference);
					class14 = class14;
					_ = (GClass3)(object)((Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])(object)Class5.Default, array2)).e(bindingFlags, array5, array4, array2);
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					gClass3 = gClass3;
				}
				while (obj3 != null);
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class7)(object)Class5.Default;
		}
		else
		{
			num = default(UIntPtr);
			if (checked(num * num * num) == 0)
			{
				try
				{
					_ = (Class6)((Class7)null).t(obj3, type, cultureInfo_);
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					goto IL_2191;
				}
			}
		}
		goto IL_2191;
		IL_08f1:
		_ = (Class0)(object)Class5.Default;
		_ = (Class0)(object)class2.e((BindingFlags)Class5.Default, array5, array4, array2);
		try
		{
			while (obj3 != null)
			{
			}
		}
		finally
		{
			while (obj3 != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class11 = class11;
					continue;
				}
				gClass3 = null;
				Class7 obj16 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj17 = (Class7)(object)obj16.W(bindingFlags, (PropertyInfo[])class2.t(obj3, type, cultureInfo_), null, null, (ParameterModifier[])(object)((Class7)class2.t(obj3, (Type)(object)Class5.Default, cultureInfo_)).W(bindingFlags, array, (Type)(object)Class5.Default, array4, null));
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				Type[] type_3 = array4;
				Class7 class16 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				MethodBase[] methodBase_6 = array5;
				ref object[] object_4 = ref reference2;
				ParameterModifier[] parameterModifier_4 = array2;
				Class7 class17 = class2;
				BindingFlags bindingFlags_9 = bindingFlags;
				BindingFlags bindingFlags_10 = bindingFlags;
				Type type_4 = (Type)(object)class2.j(bindingFlags, array5, ref reference2, null, null, array3, out reference);
				Class7 class18 = class2;
				Class7 class19 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_11 = (BindingFlags)class19.j(bindingFlags, array5, ref *(object[]*)class2.t(bindingFlags, array6, Class5.Default, cultureInfo_), array2, cultureInfo_, array3, out reference);
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)((Class7)null).t((BindingFlags)((Class7)null).e(bindingFlags, array5, array4, (ParameterModifier[])(object)Class5.Default), (FieldInfo[])null, obj3, cultureInfo_);
				Type type_5 = type;
				Type[] type_6 = (Type[])(object)Class5.Default;
				Class7 class20 = class2;
				BindingFlags bindingFlags_12 = bindingFlags;
				MethodBase[] methodBase_7 = array5;
				Type[] type_7 = array4;
				object object_5 = class2.t(Class5.Default, null, (CultureInfo)(object)Class5.Default);
				Class7 class21 = class2;
				BindingFlags bindingFlags_13 = bindingFlags;
				FieldInfo[] fieldInfo_ = array6;
				Class7 class22 = class2;
				BindingFlags bindingFlags_14 = (BindingFlags)class2.W(bindingFlags, null, type, array4, array2);
				MethodBase[] methodBase_8 = array5;
				ref object[] object_6 = ref reference2;
				ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj18 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)obj17.e(default(BindingFlags), methodBase_5, type_3, (ParameterModifier[])(object)class16.j(bindingFlags_8, methodBase_6, ref object_4, parameterModifier_4, (CultureInfo)((Class7)(object)class17.e(bindingFlags_9, (MethodBase[])(object)((Class7)null).W(bindingFlags_10, (PropertyInfo[])null, type_4, (Type[])(object)class18.W(bindingFlags_11, propertyInfo_3, type_5, type_6, (ParameterModifier[])(object)class20.e(bindingFlags_12, methodBase_7, type_7, (ParameterModifier[])((Class7)null).t(object_5, (Type)(object)class21.t(bindingFlags_13, fieldInfo_, class22.j(bindingFlags_14, methodBase_8, ref object_6, parameterModifier_5, (CultureInfo)(object)obj18.t(bindingFlags, array6, obj3, cultureInfo_), null, out reference), cultureInfo_), cultureInfo_))), array2), (Type[])(object)Class5.Default, array2)).t(class2.e(bindingFlags, null, null, array2), type, (CultureInfo)(object)class2.e((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array2, (CultureInfo)null, (string[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo_), out *(object*)null), array5, array4, array2)), array3, out *(object*)null));
				struct2 = (Struct1)((Class7)(object)Class5.Default).t(obj3, type, (CultureInfo)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)(object)class2.e((BindingFlags)class2.t(null, type, cultureInfo_), array5, array4, array2)).t(obj3, type, cultureInfo_), (Type[])null, (ParameterModifier[])(object)Class5.Default), (Type)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default), (Type[])null, array2)).t(obj3, (Type)(object)Class5.Default, null));
			}
			goto IL_0d64;
		}
		IL_07ca:
		Class7 class23 = class2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)(object)((Class7)(object)class23.e(bindingFlags, null, array4, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)(object)class2.t((BindingFlags)Class5.Default, array6, null, cultureInfo_)).t(bindingFlags, array6, obj3, cultureInfo_)))).e((BindingFlags)Class5.Default, array5, null, array2)).W((BindingFlags)((Class7)null).t(obj3, type, (CultureInfo)null), array, null, (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
		{
			struct2 = default(Struct1);
			_ = (GClass0)(object)((Class7)null).e(bindingFlags, array5, (Type[])(object)Class5.Default, array2);
		}
		try
		{
			_ = Class5.Default;
		}
		finally
		{
			class14 = class14;
			goto IL_08f1;
		}
		IL_0d64:
		if (num == 0)
		{
			_ = (Qk7)(object)((Class7)(object)((Class7)null).t((BindingFlags)class2.e(default(BindingFlags), array5, null, null), (FieldInfo[])null, obj3, cultureInfo_)).e((BindingFlags)Class5.Default, null, array4, null);
		}
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while ((object)Class5.Default != null);
		do
		{
			try
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					Class7 class24 = class2;
					Class7 class25 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)class24.t(class25.e(bindingFlags, array5, null, array2), (Type)(object)Class5.Default, cultureInfo_);
					goto end_IL_0dd0;
				}
				end_IL_0dd0:;
			}
			catch
			{
				PropertyInfo[] propertyInfo_4 = array;
				Type[] type_8 = array4;
				Class7 class26 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)((Class7)null).W(default(BindingFlags), propertyInfo_4, (Type)null, type_8, (ParameterModifier[])(object)class26.W(bindingFlags, null, null, array4, (ParameterModifier[])(object)Class5.Default));
			}
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			try
			{
				do
				{
					_ = (Class10)(object)Class5.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				try
				{
					class14 = class14;
				}
				finally
				{
					qk = qk;
					qk = qk;
					continue;
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					_ = (Class0)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, (Type[])(object)((Class7)null).t(bindingFlags, array6, (object)class2.e((BindingFlags)((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, array4, array2), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), (CultureInfo)((Class7)null).t((object)null, (Type)null, (CultureInfo)null)), null)).t(obj3, type, (CultureInfo)(object)Class5.Default);
					class2 = class2;
					class2 = class2;
					class8 = class8;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)class2.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_0fce;
		}
		IL_3b01:
		try
		{
			try
			{
				try
				{
					Class7 class27 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class27.e(bindingFlags, array5, array4, array2);
				}
				finally
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, array4, array2);
					goto end_IL_3b03;
				}
				end_IL_3b03:;
			}
			finally
			{
				_ = (GClass3)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, cultureInfo_);
				goto end_IL_3b02;
			}
			end_IL_3b02:;
		}
		catch
		{
			while (obj3 != null)
			{
				gClass = gClass;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					gClass4 = null;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					@struct = @struct;
				}
			}
		}
		_ = (GClass0)(object)Class5.Default;
		_ = (Class4)(object)Class5.Default;
		_ = (GClass2)(object)Class5.Default;
		if (num == 0)
		{
			while (obj3 != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		Class0 class28 = class28;
		try
		{
			while (obj3 != null)
			{
				do
				{
					struct2 = struct2;
				}
				while ((object)class2.j(bindingFlags, null, ref reference2, array2, cultureInfo_, array3, out *(object*)null) != null);
			}
		}
		catch
		{
			try
			{
				class4 = (Class4)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo_), array4, array2);
				_ = (Class9)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array4, array2);
			}
			catch
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
					goto end_IL_3cca;
				}
				catch
				{
					class4 = null;
					goto end_IL_3cca;
				}
				end_IL_3cca:;
			}
		}
		Class7 obj24 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj24.W(bindingFlags, array, null, (Type[])class2.t(obj3, type, (CultureInfo)(object)Class5.Default), array2) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (Class7)(object)class2.e(bindingFlags, array5, null, array2);
				}
			}
		}
		else
		{
			_ = (Class2)(object)Class5.Default;
		}
		try
		{
			_ = (Class6)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, null, (ParameterModifier[])(object)Class5.Default);
			_ = (GClass2)(object)Class5.Default;
			_ = (Class0)(object)Class5.Default;
			_ = Class5.Default;
		}
		finally
		{
			qk = qk;
			goto IL_3dcc;
		}
		IL_1805:
		_ = (Class10)class2.t(obj3, type, cultureInfo_);
		try
		{
			_ = (Class4)(object)Class5.Default;
		}
		catch
		{
			if ((UIntPtr)class2.t(bindingFlags, array6, obj3, null) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)class2.t(bindingFlags, null, obj3, cultureInfo_);
				}
				catch
				{
					Class7 class29 = class2;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					Type type_9 = type;
					Class7 obj25 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass3)(object)((Class7)(object)class29.W(bindingFlags_15, null, type_9, (Type[])(object)obj25.t(bindingFlags, (FieldInfo[])(object)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, array2, cultureInfo_, array3, out *(object*)null), Class5.Default, cultureInfo_), (ParameterModifier[])(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).t(null, type, null), array6, obj3, (CultureInfo)(object)Class5.Default))).j(bindingFlags, array5, ref reference2, array2, cultureInfo_, (string[])(object)((Class7)((Class7)null).t(obj3, (Type)null, cultureInfo_)).W((BindingFlags)class2.e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)class2.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default)), null, null, array4, (ParameterModifier[])(object)Class5.Default), out reference);
				}
			}
		}
		do
		{
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, array2) != null);
		do
		{
			_ = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, Class5.Default, cultureInfo_), ref reference2, array2, cultureInfo_, array3, out reference)).e((BindingFlags)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array4, (ParameterModifier[])(object)class2.t((BindingFlags)Class5.Default, array6, null, cultureInfo_)), array4, null), array5, array4, array2), (CultureInfo)null, array3, out reference);
		}
		while (obj3 != null);
		do
		{
			try
			{
				_ = (Class9)(object)class2.j(bindingFlags, array5, ref reference2, array2, cultureInfo_, null, out reference);
			}
			catch
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			while ((object)class2.j(bindingFlags, array5, ref *(object[]*)Class5.Default, array2, null, array3, out *(object*)class2.j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array3, out reference)) != null)
			{
				Class7 obj29 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)null);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_9 = array5;
				Class7 class30 = class2;
				Class7 class31 = class2;
				PropertyInfo[] propertyInfo_5 = array;
				Class7 obj30 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj29.j(bindingFlags_16, methodBase_9, ref *(object[]*)((Class7)(object)class30.t(default(BindingFlags), (FieldInfo[])(object)class31.j((BindingFlags)((Class7)null).W(default(BindingFlags), propertyInfo_5, (Type)(object)obj30.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)class2.j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])null, array2), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null)), (FieldInfo[])(object)class2.j(bindingFlags, (MethodBase[])(object)class2.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, (ParameterModifier[])null), array, null, null, null), ref *(object[]*)null, array2, cultureInfo_, array3, out reference), (object)null, cultureInfo_), array4, array2), (Type[])(object)Class5.Default, (ParameterModifier[])null), array5, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)class2.W((BindingFlags)class2.j(bindingFlags, array5, ref *(object[]*)Class5.Default, array2, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default), array, type, (Type[])(object)Class5.Default, null), cultureInfo_, array3, out reference), obj3, cultureInfo_)).t(bindingFlags, null, obj3, cultureInfo_), null, cultureInfo_, array3, out reference) == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		try
		{
			do
			{
				_ = (Class5)(object)class2.t((BindingFlags)((Class7)null).j(bindingFlags, array5, ref *(object[]*)class2.t((BindingFlags)((Class7)null).t((object)class2.W((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, null, null, array2), null, type, (Type[])(object)class2.W((BindingFlags)Class5.Default, array, type, array4, array2), (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo_), (FieldInfo[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo_, array3, out *(object*)Class5.Default), Class5.Default, cultureInfo_), (ParameterModifier[])null, cultureInfo_, array3, out *(object*)null), array6, null, cultureInfo_);
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			_ = (GClass2)(object)Class5.Default;
			goto IL_1efe;
		}
		IL_1622:
		try
		{
			try
			{
				class28 = null;
			}
			finally
			{
				try
				{
					_ = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_);
				}
				finally
				{
					class4 = (Class4)(object)((Class7)(object)class2.j(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, null, array4, array2), ref reference2, null, cultureInfo_, array3, out reference)).j(bindingFlags, null, ref reference2, array2, null, array3, out *(object*)null);
					goto end_IL_1623;
				}
			}
			end_IL_1623:;
		}
		finally
		{
			try
			{
				try
				{
					class11 = class11;
				}
				catch
				{
					qk = qk;
				}
			}
			catch
			{
				while (true)
				{
					Class7 obj32 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)obj32.W(bindingFlags, array, type, null, array2) != null)
					{
						_ = (GClass2)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, array2, (CultureInfo)null, array3, out *(object*)Class5.Default);
						BindingFlags bindingFlags_17 = bindingFlags;
						Class7 class32 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Struct2)((Class7)null).j(bindingFlags_17, (MethodBase[])(object)class32.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array2), array6, obj3, (CultureInfo)(object)class2.W((BindingFlags)class2.t((BindingFlags)Class5.Default, (FieldInfo[])((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, null), obj3, cultureInfo_), array, type, array4, null)), ref reference2, (ParameterModifier[])null, cultureInfo_, array3, out reference);
						_ = (Struct2)class2.W(bindingFlags, null, type, null, array2);
						continue;
					}
					break;
				}
			}
			goto IL_1805;
		}
		IL_2191:
		_003CModule_003E = _003CModule_003E;
		if (checked(num - num) == 0)
		{
			do
			{
				try
				{
					_ = (Class8)(object)class2.t((BindingFlags)Class5.Default, array6, Class5.Default, null);
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		@class = @class;
		try
		{
			if (checked(num + num) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class14 = class14;
			}
		}
		catch
		{
			try
			{
				do
				{
					class15 = class15;
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					gClass = (GClass2)(object)Class5.Default;
				}
				goto end_IL_2214;
			}
			end_IL_2214:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class33);
		while (obj3 != null)
		{
			if ((UIntPtr)class2.j(bindingFlags, array5, ref *(object[]*)null, array2, (CultureInfo)class2.t(Class5.Default, null, cultureInfo_), (string[])(object)Class5.Default, out *(object*)class2.W(bindingFlags, array, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class33 = null;
					class33 = class33;
					class14 = class14;
				}
				catch
				{
					class8 = null;
					_ = (Class10)(object)Class5.Default;
				}
				continue;
			}
			while (obj3 != null)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				class15 = class15;
				@struct = @struct;
				Class7 obj36 = (Class7)(object)Class5.Default;
				object object_7 = obj3;
				Class7 class34 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)obj36.t(object_7, (Type)(object)class34.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo_)), ref reference2, null, null, (string[])(object)Class5.Default, out reference), (CultureInfo)(object)class2.j(bindingFlags, array5, ref *(object[]*)null, array2, cultureInfo_, array3, out reference));
			}
		}
		num = default(UIntPtr);
		nuint num5 = num;
		nuint num6 = num;
		Class7 class35 = class2;
		BindingFlags bindingFlags_18 = (BindingFlags)class2.e(bindingFlags, array5, null, null);
		object object_8 = obj3;
		Class7 class36 = class2;
		bindingFlags = default(BindingFlags);
		Class7 obj37 = (Class7)(object)class35.e((BindingFlags)((Class7)null).t(bindingFlags_18, (FieldInfo[])null, object_8, (CultureInfo)(object)class36.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.e(bindingFlags, null, null, array2), (MethodBase[])(object)Class5.Default, ref reference2, array2, null, (string[])(object)Class5.Default, out reference), obj3, cultureInfo_)), array5, (Type[])(object)Class5.Default, null);
		bindingFlags = default(BindingFlags);
		if (num5 / (num6 / (nuint)(UIntPtr)((Class7)((Class7)(object)obj37.e(bindingFlags, (MethodBase[])class2.t(obj3, (Type)(object)Class5.Default, cultureInfo_), (Type[])(object)Class5.Default, array2)).t(obj3, null, (CultureInfo)(object)Class5.Default)).t(null, null, null)) == 0 && checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(Class5.Default, type, null))) == 0)
		{
			try
			{
				_ = (Struct2)((Class7)(object)class2.W(bindingFlags, array, type, array4, array2)).W((BindingFlags)Class5.Default, array, type, null, array2);
			}
			catch
			{
				gClass2 = gClass2;
				struct2 = default(Struct1);
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)((Class7)(object)Class5.Default).t(obj3, (Type)(object)class2.t(bindingFlags, null, null, cultureInfo_), null), (string[])null, out reference);
				gClass4 = (GClass1)(object)Class5.Default;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
			else
			{
				_ = (Struct2)Class5.Default;
			}
		}
		while (obj3 != null)
		{
			do
			{
				class4 = class4;
			}
			while ((object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)class2.t(obj3, (Type)(object)Class5.Default, null), array5, ref reference2, array2, cultureInfo_, array3, out reference)) != null);
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				gClass3 = (GClass3)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, array4, array2);
			}
		}
		catch
		{
			if (checked(num + num) == 0)
			{
				_ = (Class2)(object)class2.W((BindingFlags)Class5.Default, null, null, (Type[])(object)Class5.Default, array2);
			}
		}
		finally
		{
			try
			{
				try
				{
					class14 = class14;
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto end_IL_2727;
				}
				end_IL_2727:;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, null);
					Class7 obj40 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class33 = (Class9)(object)obj40.t(bindingFlags, null, obj3, null);
					_ = (Struct1)Class5.Default;
				}
				else
				{
					Class7 class37 = class2;
					Class7 obj41 = (Class7)(object)class2.W(bindingFlags, array, null, array4, array2);
					FieldInfo[] fieldInfo_2 = array6;
					Class7 class38 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj42 = (Class7)(object)obj41.t(default(BindingFlags), fieldInfo_2, null, (CultureInfo)(object)class38.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, (CultureInfo)null, (string[])null, out *(object*)null), null, type, array4, null), (string[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo_), out *(object*)Class5.Default));
					MethodBase[] methodBase_10 = array5;
					ref object[] object_9 = ref *(object[]*)((Class7)null).t((object)null, type, cultureInfo_);
					ParameterModifier[] parameterModifier_6 = array2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class37.t((BindingFlags)obj42.j(default(BindingFlags), methodBase_10, ref object_9, parameterModifier_6, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)class2.e((BindingFlags)Class5.Default, null, null, array2), ref reference2, (ParameterModifier[])null, (CultureInfo)(object)((Class7)null).W(bindingFlags, array, type, array4, array2), array3, out reference), (string[])class2.t(obj3, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array4, null), (Type[])(object)class2.t(bindingFlags, array6, class2.t(Class5.Default, type, cultureInfo_), (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), out reference), array6, obj3, cultureInfo_);
				}
			}
			goto IL_29cc;
		}
		IL_40be:
		gClass2 = (GClass0)(object)class2.e((BindingFlags)Class5.Default, array5, null, (ParameterModifier[])(object)Class5.Default);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				bindingFlags = default(BindingFlags);
				gClass4 = (GClass1)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])(object)((Class7)null).t(bindingFlags, array6, obj3, cultureInfo_), array2);
				gClass3 = (GClass3)(object)Class5.Default;
			}
		}
		while (obj3 != null)
		{
			while ((object)Class5.Default != null)
			{
			}
		}
		try
		{
			try
			{
				class2 = class2;
			}
			catch
			{
				try
				{
					_ = (Class5)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference2, null, null, null, out reference);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					class4 = class4;
				}
				while (obj3 != null);
			}
			finally
			{
				do
				{
					class8 = class8;
				}
				while (obj3 != null);
				goto end_IL_41a6;
			}
			end_IL_41a6:;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			Class7 class39 = class2;
			PropertyInfo[] propertyInfo_6 = array;
			Class7 class40 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class39.W(default(BindingFlags), propertyInfo_6, null, null, (ParameterModifier[])(object)class40.W(bindingFlags, array, (Type)(object)Class5.Default, null, null));
		}
		if (checked(num - num) == 0)
		{
			try
			{
				class2 = class2;
				gClass = (GClass2)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				Class7 class41 = class2;
				BindingFlags bindingFlags_19 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)((Class7)(object)class41.j(bindingFlags_19, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)null), ref *(object[]*)null, (ParameterModifier[])((Class7)null).t(obj3, (Type)null, (CultureInfo)null), (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)class2.W((BindingFlags)class2.j(bindingFlags, array5, ref reference2, array2, (CultureInfo)class2.t(obj3, (Type)(object)class2.W(bindingFlags, (PropertyInfo[])((Class7)((Class7)(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, null, null, out *(object*)null)).t(null, type, cultureInfo_)).t(null, null, null), (Type)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo_), array4, (ParameterModifier[])(object)Class5.Default), cultureInfo_), array3, out reference), array, (Type)(object)Class5.Default, null, null)).W(bindingFlags, null, null, (Type[])(object)Class5.Default, null), out *(object*)Class5.Default)).t(Class5.Default, type, null);
				_ = (Qk7)(object)((Class7)null).j((BindingFlags)class2.t(Class5.Default, type, null), array5, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array3, out reference);
				goto IL_440c;
			}
		}
		goto IL_440c;
		IL_04de:
		do
		{
			try
			{
				_ = (Struct1)Class5.Default;
			}
			catch
			{
				try
				{
					Class7 class42 = class2;
					BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
					Class7 obj47 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_21 = bindingFlags;
					MethodBase[] methodBase_11 = array5;
					Class7 class43 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class42.t(bindingFlags_20, null, obj47.e(bindingFlags_21, methodBase_11, (Type[])(object)class43.t(bindingFlags, array6, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array2, (CultureInfo)null, array3, out *(object*)((Class7)(object)Class5.Default).W(bindingFlags, array, null, array4, array2))), array2), (CultureInfo)(object)class2.j((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), array5, ref reference2, (ParameterModifier[])(object)Class5.Default, null, null, out reference));
				}
				finally
				{
					gClass2 = gClass2;
					goto end_IL_04ee;
				}
				end_IL_04ee:;
			}
		}
		while (obj3 != null);
		if (num == 0)
		{
			do
			{
				Class7 obj49 = (Class7)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array2), obj3, cultureInfo_);
				bindingFlags = default(BindingFlags);
				_ = (Class8)((Class7)(object)obj49.e(bindingFlags, array5, array4, array2)).t(obj3, type, null);
			}
			while (obj3 != null || obj3 != null);
		}
		else
		{
			class2 = null;
			_ = (Struct1)Class5.Default;
			Class8 obj50 = (Class8)(object)Class5.Default;
			class11 = class11;
			class11 = obj50;
			_ = (Struct2)class2.t((BindingFlags)((Class7)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, null)).t(bindingFlags, array6, obj3, (CultureInfo)(object)Class5.Default), array6, obj3, cultureInfo_);
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, array2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class14 = null;
					class14 = null;
				}
				while (obj3 != null);
			}
			catch
			{
				_ = (Struct2)((Class7)(object)class2.e(bindingFlags, array5, array4, array2)).t(default(BindingFlags), null, obj3, (CultureInfo)(object)Class5.Default);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				GClass3 obj52 = (GClass3)(object)Class5.Default;
				gClass3 = (GClass3)(object)Class5.Default;
				gClass3 = obj52;
			}
		}
		finally
		{
			gClass4 = gClass4;
			gClass4 = null;
			goto IL_07ca;
		}
		IL_36a3:
		gClass2 = gClass2;
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					@class = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)null);
				}
			}
			catch
			{
				do
				{
					class4 = (Class4)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array4, (ParameterModifier[])class2.t(obj3, type, null)), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out *(object*)class2.t((BindingFlags)((Class7)null).t(bindingFlags, array6, obj3, cultureInfo_), array6, obj3, (CultureInfo)(object)Class5.Default));
				}
				while (obj3 != null);
			}
		}
		while ((object)((Class7)null).t((BindingFlags)Class5.Default, array6, obj3, cultureInfo_) != null);
		if (num == 0)
		{
			do
			{
				try
				{
					gClass4 = gClass4;
					_ = (Qk7)(object)class2.t(default(BindingFlags), array6, obj3, cultureInfo_);
				}
				finally
				{
					Class7 class44 = class2;
					Class7 class45 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj54 = (Class7)(object)class45.W(bindingFlags, array, type, null, null);
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 obj55 = (Class7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, array4, (ParameterModifier[])(object)((Class7)null).W(default(BindingFlags), array, type, (Type[])(object)Class5.Default, (ParameterModifier[])null)), (ParameterModifier[])(object)class2.t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)class2.e(default(BindingFlags), null, (Type[])(object)Class5.Default, null)), cultureInfo_, array3, out reference);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class44.j((BindingFlags)obj54.W(bindingFlags_22, (PropertyInfo[])(object)obj55.W(bindingFlags, array, type, null, null), type, array4, array2), null, ref reference2, array2, (CultureInfo)((Class7)null).t((object)null, type, cultureInfo_), null, out reference);
					_ = (GClass0)class2.t(obj3, (Type)(object)Class5.Default, cultureInfo_);
					_ = (_003CModule_003E)(object)Class5.Default;
					class33 = class33;
					continue;
				}
			}
			while (obj3 != null);
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		try
		{
		}
		finally
		{
			if (num == 0)
			{
				do
				{
					class28 = null;
				}
				while (obj3 != null);
			}
			else
			{
				_ = (Class7)(object)class2.W(bindingFlags, array, type, array4, (ParameterModifier[])(object)Class5.Default);
				BindingFlags bindingFlags_23 = (BindingFlags)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])(object)Class5.Default, array2);
				Class7 class46 = class2;
				object object_10 = obj3;
				Class7 class47 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).j(bindingFlags_23, (MethodBase[])(object)class46.t(default(BindingFlags), null, object_10, (CultureInfo)(object)class47.e(bindingFlags, array5, array4, array2)), ref reference2, (ParameterModifier[])null, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)(object)class2.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array2), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default)).t(obj3, null, cultureInfo_), array5, (Type[])(object)Class5.Default, null), (string[])(object)Class5.Default, out *(object*)null);
				_ = (Class9)(object)Class5.Default;
			}
			goto IL_3b01;
		}
		IL_49d9:
		_ = (Struct1)class2.t(null, type, cultureInfo_);
		struct2 = default(Struct1);
		checked
		{
			Class7 class48;
			do
			{
				num = default(UIntPtr);
				if (num * unchecked((nuint)(UIntPtr)Class5.Default) * num == 0)
				{
					do
					{
						_ = (Class6)(object)Class5.Default;
						_ = (Qk7)(object)((Class7)(object)class2.t(bindingFlags, array6, obj3, (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, null, null);
					}
					while (class2.t(obj3, type, (CultureInfo)(object)Class5.Default) != null);
				}
				class48 = class2;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class48.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array4, null), obj3, cultureInfo_) != null);
			try
			{
				num = default(UIntPtr);
				if (num - num == 0)
				{
					class4 = class4;
				}
				else
				{
					class28 = null;
				}
			}
			catch
			{
				nuint num7 = num;
				num = default(UIntPtr);
				if (num7 - (unchecked((nuint)default(UIntPtr)) + num) == 0)
				{
					unchecked
					{
						try
						{
							_ = (Struct2)class2.t(bindingFlags, array6, obj3, cultureInfo_);
						}
						finally
						{
							Class7 class49 = class2;
							BindingFlags bindingFlags_24 = bindingFlags;
							Class7 class50 = class2;
							BindingFlags bindingFlags_25 = (BindingFlags)class2.t(null, null, cultureInfo_);
							Class7 obj56 = (Class7)((Class7)null).t(obj3, (Type)null, (CultureInfo)null);
							bindingFlags = default(BindingFlags);
							_003CModule_003E = (_003CModule_003E)(object)class49.W(bindingFlags_24, (PropertyInfo[])(object)class50.t(bindingFlags_25, null, obj56.W(bindingFlags, array, null, array4, array2), null), (Type)(object)((Class7)(object)class2.W((BindingFlags)class2.e((BindingFlags)Class5.Default, array5, null, array2), array, type, array4, array2)).W(bindingFlags, array, type, array4, null), null, array2);
							goto end_IL_4b11;
						}
					}
				}
				if (num * unchecked((nuint)(UIntPtr)class2.t(bindingFlags, null, Class5.Default, null)) == 0)
				{
					qk = null;
				}
				end_IL_4b11:;
			}
			if (unchecked((nuint)(UIntPtr)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)(object)Class5.Default)) - num * num == 0)
			{
				@struct = (Struct2)class2.t(bindingFlags, (FieldInfo[])(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out reference), obj3, cultureInfo_);
			}
			try
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
			}
			finally
			{
				_ = (Class6)(object)Class5.Default;
				goto IL_4e83;
			}
		}
		IL_0fce:
		class14 = class14;
		Class7 class51 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)class51.e(bindingFlags, array5, array4, null);
		checked
		{
			nuint num8 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)class2.e(bindingFlags, array5, (Type[])(object)Class5.Default, array2) / (nuint)(UIntPtr)Class5.Default);
			num = default(UIntPtr);
			if (num8 - num == 0)
			{
				gClass2 = gClass2;
			}
			_ = (GClass2)(object)Class5.Default;
			_ = Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		else if (num == 0)
		{
			_ = (GClass3)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, array2, (CultureInfo)null, (string[])null, out *(object*)class2.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array2));
		}
		else
		{
			_ = (GClass1)(object)Class5.Default;
			gClass = null;
			_ = (Class6)(object)Class5.Default;
			Class7 class52 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class52.W(bindingFlags, array, type, array4, array2);
		}
		while (obj3 != null)
		{
			if ((UIntPtr)class2.W((BindingFlags)((Class7)(object)class2.W((BindingFlags)class2.j(bindingFlags, null, ref reference2, null, cultureInfo_, array3, out *(object*)null), null, (Type)(object)Class5.Default, array4, null)).e(bindingFlags, null, array4, array2), (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
			{
				class8 = null;
			}
			else
			{
				class15 = class15;
			}
		}
		BindingFlags bindingFlags_26 = bindingFlags;
		Class7 obj58 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)((Class7)null).e(bindingFlags_26, (MethodBase[])(object)obj58.W(bindingFlags, null, (Type)(object)class2.W((BindingFlags)class2.t(Class5.Default, null, cultureInfo_), null, null, (Type[])(object)Class5.Default, array2), array4, null), array4, (ParameterModifier[])null);
		if (num == 0)
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					class8 = null;
				}
				finally
				{
					gClass3 = (GClass3)(object)Class5.Default;
					continue;
				}
			}
		}
		else
		{
			class2 = class2;
			Class7 class53 = class2;
			BindingFlags bindingFlags_27 = bindingFlags;
			MethodBase[] methodBase_12 = array5;
			Class7 class54 = class2;
			MethodBase[] methodBase_13 = array5;
			Type[] type_10 = (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, (CultureInfo)(object)Class5.Default);
			Class7 class55 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class53.j(bindingFlags_27, methodBase_12, ref *(object[]*)class54.e(default(BindingFlags), methodBase_13, type_10, (ParameterModifier[])(object)class55.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)class2.e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo_, array3, out reference), (CultureInfo)(object)Class5.Default, array3, out *(object*)class2.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)null)))), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo_), null, cultureInfo_), cultureInfo_, array3, out reference);
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + (unchecked((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)((Class7)(object)Class5.Default).W((BindingFlags)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), array, (Type)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array4, array2), null, array2)) * num + num) == 0)
				{
					try
					{
						gClass2 = gClass2;
					}
					catch
					{
						class4 = class4;
					}
				}
				else
				{
					try
					{
						gClass3 = (GClass3)(object)Class5.Default;
					}
					catch
					{
						_ = (Qk7)(object)Class5.Default;
					}
				}
			}
			catch
			{
				Class7 class56 = class2;
				bindingFlags = default(BindingFlags);
				gClass4 = (GClass1)(object)class56.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array2);
			}
			while (obj3 != null)
			{
				try
				{
					class11 = null;
				}
				finally
				{
					try
					{
						@class = @class;
					}
					catch
					{
						class28 = (Class0)(object)Class5.Default;
						class28 = null;
					}
					continue;
				}
			}
			while (obj3 != null)
			{
				if (num == 0)
				{
					num = default(UIntPtr);
					if (num + num == 0)
					{
						class2 = (Class7)(object)unchecked(((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, (ParameterModifier[])class2.t(obj3, type, null), cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, null, null), out reference));
					}
				}
			}
			try
			{
				Class7 class57 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class57.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
			}
			finally
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						gClass2 = null;
					}
				}
				catch
				{
					try
					{
						qk = null;
						class15 = (Class10)(object)Class5.Default;
						Class7 class58 = class2;
						bindingFlags = default(BindingFlags);
						_ = (GClass2)(object)class58.t(bindingFlags, array6, ((Class7)(object)Class5.Default).t(obj3, type, cultureInfo_), null);
						gClass2 = null;
					}
					catch
					{
						_ = (GClass2)(object)Class5.Default;
					}
				}
				goto IL_1622;
			}
		}
		IL_3e45:
		nuint num9;
		checked
		{
			num9 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
		}
		if (checked(num9 - num) == 0)
		{
			Class7 class59 = class2;
			BindingFlags bindingFlags_28 = bindingFlags;
			PropertyInfo[] propertyInfo_7 = array;
			Type type_11 = type;
			Class7 class60 = class2;
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)class59.W(bindingFlags_28, propertyInfo_7, type_11, null, (ParameterModifier[])(object)class60.W(bindingFlags, null, type, array4, null)) / checked(num - unchecked((nuint)default(UIntPtr))) == 0)
			{
				class4 = (Class4)(object)class2.j(bindingFlags, array5, ref *(object[]*)null, array2, cultureInfo_, array3, out *(object*)null);
			}
			else
			{
				@struct = (Struct2)((Class7)(object)Class5.Default).t(obj3, type, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array4, null));
				_ = (Class7)(object)Class5.Default;
				@class = Class5.Default;
			}
		}
		while ((object)Class5.Default != null)
		{
			class15 = (Class10)(object)class2.W((BindingFlags)Class5.Default, array, null, array4, array2);
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
				class8 = class8;
				gClass3 = (GClass3)(object)Class5.Default;
			}
		}
		class15 = (Class10)(object)Class5.Default;
		try
		{
			@class = @class;
		}
		finally
		{
			try
			{
				Class7 class61 = class2;
				Class7 class62 = class2;
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 obj65 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class61.t((BindingFlags)class62.j(bindingFlags_29, (MethodBase[])(object)obj65.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array2), ref reference2, null, cultureInfo_, null, out *(object*)null), array6, obj3, cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (Class9)(object)Class5.Default;
					_ = Class5.Default;
				}
			}
			finally
			{
				Class7 class63 = class2;
				BindingFlags bindingFlags_30 = bindingFlags;
				Class7 class64 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class63.e(bindingFlags_30, null, null, (ParameterModifier[])(object)class64.e(bindingFlags, array5, null, array2));
				goto IL_40be;
			}
		}
		IL_4e83:
		while ((object)Class5.Default != null)
		{
			try
			{
				do
				{
					gClass = null;
					_ = (GClass1)(object)Class5.Default;
					_ = (Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array2)).j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo_, (string[])(object)Class5.Default, out *(object*)class2.e((BindingFlags)Class5.Default, array5, array4, (ParameterModifier[])((Class7)null).t((object)null, type, (CultureInfo)null)));
					_ = (Class6)(object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)null, cultureInfo_);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)class2.t(null, (Type)(object)Class5.Default, cultureInfo_);
					_ = (Qk7)class2.t(class2.t(bindingFlags, null, null, cultureInfo_), type, cultureInfo_);
				}
				else
				{
					class2 = (Class7)(object)class2.j((BindingFlags)class2.t(obj3, type, null), array5, ref *(object[]*)null, array2, (CultureInfo)((Class7)null).t(obj3, (Type)null, (CultureInfo)null), null, out reference);
				}
			}
		}
		class14 = (Class6)(object)Class5.Default;
		while (class2.t(obj3, type, cultureInfo_) != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class2 = (Class7)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				class2 = class2;
				_ = (GClass2)(object)Class5.Default;
				continue;
			}
			num = default(UIntPtr);
			checked
			{
				if (num - num - num + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
				qk = qk;
				gClass4 = gClass4;
				_ = (Class7)(object)Class5.Default;
				qk = qk;
			}
		}
		return;
		IL_29cc:
		nuint num10 = num;
		num = default(UIntPtr);
		checked
		{
			if ((num10 - num - num) * num == 0)
			{
				while (obj3 != null)
				{
					num = default(UIntPtr);
					nuint num11 = num * num;
					num = default(UIntPtr);
					if (num11 - num == 0)
					{
						_ = (GClass2)(object)class2.e(unchecked((BindingFlags)((Class7)null).W(bindingFlags, array, (Type)null, array4, array2)), null, null, (ParameterModifier[])((Class7)null).t((object)((Class7)null).e(bindingFlags, array5, array4, array2), (Type)(object)Class5.Default, cultureInfo_));
					}
				}
			}
		}
		while (class2.t(obj3, type, null) != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					qk = null;
					continue;
				}
				Class7 class65 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj67 = (Class7)(object)class65.j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)((Class7)null).t(bindingFlags, array6, (object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)class2.W((BindingFlags)Class5.Default, array, (Type)(object)class2.t(bindingFlags, null, obj3, cultureInfo_), null, null)), (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)Class5.Default), ref reference2, null, null, (string[])(object)Class5.Default, out reference);
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj67.e(bindingFlags, null, array4, null);
				continue;
			}
			try
			{
				_ = (Struct1)((Class7)null).W(bindingFlags, array, (Type)null, (Type[])null, array2);
			}
			finally
			{
				_ = (Class4)(object)Class5.Default;
				class11 = class11;
				gClass2 = (GClass0)(object)Class5.Default;
				class15 = class15;
				continue;
			}
		}
		while ((object)Class5.Default != null)
		{
			if (checked(num + num) == 0 && num == 0)
			{
				_ = Class5.Default;
				class33 = class33;
				_ = Class5.Default;
				struct2 = struct2;
			}
		}
		try
		{
			while (obj3 != null)
			{
			}
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					Class7 obj68 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_31 = bindingFlags;
					ref object[] object_11 = ref *(object[]*)Class5.Default;
					CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
					Class7 class66 = class2;
					BindingFlags bindingFlags_32 = bindingFlags;
					MethodBase[] methodBase_14 = array5;
					Type[] type_12 = array4;
					Class7 class67 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)obj68.j(bindingFlags_31, null, ref object_11, null, cultureInfo_3, (string[])(object)class66.e(bindingFlags_32, methodBase_14, type_12, (ParameterModifier[])(object)class67.e((BindingFlags)((Class7)null).W(bindingFlags, array, (Type)null, array4, (ParameterModifier[])(object)Class5.Default), array5, null, array2)), out *(object*)null);
				}
				finally
				{
					class4 = (Class4)(object)Class5.Default;
					goto end_IL_2c4e;
				}
			}
			end_IL_2c4e:;
		}
		gClass3 = gClass3;
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) - num) == 0)
			{
				gClass3 = (GClass3)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				_ = (Class8)((Class7)(object)Class5.Default).t(obj3, (Type)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j((BindingFlags)class2.W((BindingFlags)Class5.Default, array, type, array4, null), (MethodBase[])(object)class2.W(bindingFlags, array, type, (Type[])(object)Class5.Default, null), ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo_, array3, out *(object*)Class5.Default), array4, null), (CultureInfo)(object)Class5.Default);
				gClass2 = gClass2;
			}
			else
			{
				gClass3 = gClass3;
			}
		}
		catch
		{
			gClass4 = null;
			Class7 obj70 = (Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)obj70.W(bindingFlags, array, (Type)class2.t(obj3, null, cultureInfo_), array4, null);
			class15 = class15;
		}
		class33 = null;
		do
		{
			try
			{
				if (num == 0)
				{
					qk = null;
				}
				else
				{
					@class = Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					gClass = (GClass2)(object)Class5.Default;
					gClass3 = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				continue;
			}
		}
		while ((object)Class5.Default != null);
		@struct = @struct;
		if (num == 0)
		{
			while (obj3 != null)
			{
				do
				{
					@class = (Class5)(object)class2.t(bindingFlags, array6, obj3, null);
					_ = (Class9)class2.t(null, null, (CultureInfo)(object)Class5.Default);
				}
				while (obj3 != null);
			}
		}
		gClass4 = gClass4;
		try
		{
			if (num / (nuint)(UIntPtr)Class5.Default == 0)
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					goto end_IL_2f1f;
				}
			}
			_ = (GClass2)(object)class2.W(bindingFlags, null, type, array4, array2);
			_ = (Struct1)Class5.Default;
			class28 = class28;
			Class7 class68 = class2;
			Class7 class69 = class2;
			BindingFlags bindingFlags_33 = bindingFlags;
			ParameterModifier[] parameterModifier_7 = array2;
			Class7 obj72 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_34 = bindingFlags;
			Type type_13 = type;
			Class7 obj73 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj74 = (Class7)(object)obj73.t(bindingFlags, array6, obj3, (CultureInfo)(object)Class5.Default);
			Class7 class70 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_35 = (BindingFlags)class70.e(bindingFlags, array5, array4, array2);
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref reference2, array2, null, (string[])(object)Class5.Default, out *(object*)class2.j(bindingFlags, array5, ref reference2, array2, cultureInfo_, array3, out reference));
			Type type_14 = type;
			BindingFlags bindingFlags_36 = bindingFlags;
			MethodBase[] methodBase_15 = (MethodBase[])(object)Class5.Default;
			Class7 class71 = class2;
			BindingFlags bindingFlags_37 = bindingFlags;
			Type[] type_15 = array4;
			Class7 class72 = class2;
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 obj75 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)class68.t(class69.j(bindingFlags_33, null, ref *(object[]*)null, parameterModifier_7, (CultureInfo)(object)obj72.W(bindingFlags_34, null, type_13, (Type[])(object)obj74.W(bindingFlags_35, propertyInfo_8, type_14, (Type[])(object)((Class7)null).e(bindingFlags_36, methodBase_15, (Type[])null, (ParameterModifier[])(object)((Class7)(object)class71.e(bindingFlags_37, null, type_15, (ParameterModifier[])(object)class72.W(bindingFlags_38, (PropertyInfo[])(object)obj75.e(bindingFlags, null, null, array2), null, (Type[])(object)Class5.Default, array2))).e(bindingFlags, null, (Type[])(object)class2.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array4, array2), (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref *(object[]*)null, array2, null, array3, out reference), array2), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)class2.e(bindingFlags, array5, null, array2))).e(bindingFlags, array5, array4, null))), (ParameterModifier[])class2.t(null, type, cultureInfo_)), array2), (string[])(object)Class5.Default, out *(object*)((Class7)null).j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj3, (CultureInfo)null), cultureInfo_, (string[])(object)Class5.Default, out reference)), (Type)class2.t(null, (Type)class2.t(obj3, type, (CultureInfo)(object)Class5.Default), null), cultureInfo_);
			end_IL_2f1f:;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass1)class2.t(null, null, cultureInfo_);
				}
				catch
				{
					@class = null;
					@class = @class;
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		_ = (Struct1)Class5.Default;
		try
		{
			try
			{
				Class7 obj78 = (Class7)(object)((Class7)null).W(bindingFlags, array, (Type)null, (Type[])(object)Class5.Default, array2);
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)obj78.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)class2.j(bindingFlags, null, ref *(object[]*)class2.t(obj3, null, (CultureInfo)(object)Class5.Default), array2, cultureInfo_, null, out *(object*)Class5.Default));
			}
			finally
			{
				while (obj3 != null)
				{
					class4 = class4;
				}
				goto end_IL_32cb;
			}
			end_IL_32cb:;
		}
		finally
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					class14 = null;
				}
			}
			catch
			{
				try
				{
					_ = (Class8)(object)((Class7)null).j(bindingFlags, array5, ref reference2, (ParameterModifier[])null, cultureInfo_, array3, out reference);
				}
				catch
				{
					gClass4 = null;
				}
			}
			goto IL_33c4;
		}
		IL_440c:
		Class7 class73 = class2;
		object object_12 = obj3;
		Type type_16 = type;
		Class7 obj81 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_16 = array5;
		Class7 class74 = class2;
		BindingFlags bindingFlags_40 = bindingFlags;
		PropertyInfo[] propertyInfo_9 = array;
		Type[] type_17 = array4;
		Class7 class75 = class2;
		BindingFlags bindingFlags_41 = (BindingFlags)((Class7)null).t(obj3, type, (CultureInfo)null);
		MethodBase[] methodBase_17 = array5;
		Class7 obj82 = (Class7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference2, array2, (CultureInfo)(object)Class5.Default, array3, out reference);
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)((Class7)class73.t(object_12, type_16, (CultureInfo)(object)obj81.j(bindingFlags_39, methodBase_16, ref *(object[]*)class74.W(bindingFlags_40, propertyInfo_9, null, type_17, (ParameterModifier[])(object)class75.j(bindingFlags_41, methodBase_17, ref *(object[]*)obj82.t(bindingFlags, array6, null, (CultureInfo)(object)Class5.Default), (ParameterModifier[])class2.t(obj3, (Type)(object)Class5.Default, null), cultureInfo_, null, out *(object*)null)), array2, null, (string[])(object)class2.j(bindingFlags, array5, ref reference2, array2, null, array3, out reference), out *(object*)null))).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, null)) - unchecked((nuint)(UIntPtr)class2.j(bindingFlags, (MethodBase[])(object)class2.j(bindingFlags, array5, ref reference2, null, null, array3, out reference), ref *(object[]*)Class5.Default, null, cultureInfo_, array3, out *(object*)null))) == 0)
		{
			Class7 obj83 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_42 = bindingFlags;
			ref object[] object_13 = ref reference2;
			ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)Class5.Default;
			string[] string_3 = array3;
			BindingFlags bindingFlags_43 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			object object_14 = class2.t(((Class7)(object)Class5.Default).j(bindingFlags, array5, ref reference2, array2, cultureInfo_, null, out reference), type, null);
			Class7 obj84 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_18 = array5;
			ref object[] object_15 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_9 = array2;
			Class7 obj85 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_19 = array5;
			Class7 obj86 = (Class7)class2.t(obj3, null, cultureInfo_);
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)obj83.j(bindingFlags_42, null, ref object_13, parameterModifier_8, cultureInfo_, string_3, out *(object*)((Class7)null).t(bindingFlags_43, fieldInfo_3, object_14, (CultureInfo)(object)obj84.e((BindingFlags)((Class7)null).j(bindingFlags_44, methodBase_18, ref object_15, parameterModifier_9, (CultureInfo)(object)obj85.j(bindingFlags_45, methodBase_19, ref *(object[]*)obj86.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)class2.W(bindingFlags, null, type, array4, null), array3, out *(object*)null), array2, cultureInfo_, array3, out reference), (string[])(object)((Class7)null).W((BindingFlags)class2.t(null, type, (CultureInfo)(object)Class5.Default), array, (Type)null, (Type[])null, array2), out reference), (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, null, null, array3, out *(object*)class2.t(null, type, cultureInfo_)), array4, array2)));
			class8 = class8;
			_ = (GClass2)((Class7)null).t((object)null, (Type)null, (CultureInfo)null);
		}
		else
		{
			try
			{
				while ((object)class2.e(bindingFlags, array5, array4, array2) != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					struct2 = struct2;
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					goto end_IL_47bb;
				}
				end_IL_47bb:;
			}
		}
		struct2 = struct2;
		_ = (_003CModule_003E)(object)Class5.Default;
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (Class8)(object)class2.j(bindingFlags, array5, ref reference2, array2, cultureInfo_, null, out reference);
				}
				catch
				{
					class8 = (Class2)(object)class2.e(bindingFlags, array5, array4, array2);
					_ = (Qk7)(object)Class5.Default;
					class28 = null;
				}
			}
			catch
			{
				do
				{
					@class = @class;
				}
				while (obj3 != null);
			}
		}
		else
		{
			try
			{
				class28 = class28;
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (Class4)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)class2.j((BindingFlags)Class5.Default, null, ref reference2, array2, cultureInfo_, array3, out reference), (Type)null, (Type[])((Class7)(object)class2.t(bindingFlags, array6, obj3, (CultureInfo)(object)Class5.Default)).t(obj3, type, null), (ParameterModifier[])null);
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					goto end_IL_48f7;
				}
			}
			end_IL_48f7:;
		}
		finally
		{
			Type type_18 = type;
			Class7 class76 = class2;
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)((Class7)null).t((object)null, type_18, (CultureInfo)(object)class76.t(bindingFlags, (FieldInfo[])class2.t(obj3, null, (CultureInfo)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null)), null, cultureInfo_)) / (nuint)(UIntPtr)Class5.Default == 0)
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
					struct2 = struct2;
				}
			}
			goto IL_49d9;
		}
		IL_3dcc:
		try
		{
			Class7 class77 = class2;
			bindingFlags = default(BindingFlags);
			class33 = (Class9)(object)class77.t(bindingFlags, null, Class5.Default, cultureInfo_);
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 class78 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class78.j(bindingFlags, array5, ref reference2, array2, cultureInfo_, array3, out reference);
			}
			goto IL_3e45;
		}
	}
}
