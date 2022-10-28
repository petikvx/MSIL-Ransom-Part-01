using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dn7;
using Je5;
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
using ns8;
using ns9;

namespace A_0024r;

internal abstract class Class7
{
	public abstract FieldInfo t(BindingFlags bindingFlags_0, FieldInfo[] fieldInfo_0, object object_0, CultureInfo cultureInfo_0);

	public abstract MethodBase j(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, ref object[] object_0, ParameterModifier[] parameterModifier_0, CultureInfo cultureInfo_0, string[] string_0, out object object_1);

	public abstract object t(object object_0, Type type_0, CultureInfo cultureInfo_0);

	public abstract void B(ref object[] object_0, object object_1);

	public abstract MethodBase e(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0);

	public abstract PropertyInfo W(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0);

	internal static AppDomain smethod_0()
	{
		return AppDomain.CurrentDomain;
	}

	unsafe static void Xc7()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		Class2 class2;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				class2 = (Class2)(object)Class5.Default;
				class2 = class2;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Class6)(object)Class5.Default;
			}
			else
			{
				while (true)
				{
					Class7 class3 = @class;
					BindingFlags bindingFlags_ = bindingFlags;
					Class7 class4 = @class;
					Class7 class5 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)class3.W(bindingFlags_, null, type_, (Type[])(object)class4.t(default(BindingFlags), null, class5.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), (CultureInfo)@class.t(obj, type_, (CultureInfo)(object)Class5.Default)), parameterModifier_) == null)
					{
						break;
					}
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] fieldInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class7);
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (Struct2)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_, string_, out *(object*)null), (string[])(object)Class5.Default, out object_);
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					class6 = Class5.Default;
					class6 = class6;
				}
				finally
				{
					Class6 obj2 = (Class6)@class.t(null, type_, null);
					class7 = null;
					class7 = obj2;
					goto end_IL_018e;
				}
				end_IL_018e:;
			}
		}
		else
		{
			Class7 class8 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class8.t(bindingFlags, fieldInfo_, obj, cultureInfo_);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			@class = @class;
		}
		_ = (GClass1)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
			if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
			{
				_ = (Class7)(object)@class.t(bindingFlags, null, obj, null);
				_ = (Class8)(object)Class5.Default;
				@class = @class;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class9);
		if (uIntPtr == 0)
		{
			class9 = null;
			class9 = class9;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Class2)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		_ = (Class8)(object)Class5.Default;
		Class7 class10 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)class10.W(bindingFlags, propertyInfo_, null, array, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			class11 = class11;
			class11 = class11;
		}
		catch
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class12);
		do
		{
			try
			{
				_003CModule_003E = null;
			}
			finally
			{
				class12 = class12;
				class12 = null;
				continue;
			}
		}
		while ((object)Class5.Default != null || obj != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class11 = class11;
				}
				catch
				{
					_ = (GClass3)((Class7)null).t((object)null, type_, cultureInfo_);
				}
			}
			else
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_ = (Class7)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		_ = (Class7)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] object_2);
		try
		{
			try
			{
				_ = (Class2)(object)@class.e((BindingFlags)@class.W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_), null, array, null);
			}
			finally
			{
				_ = (Class2)(object)@class.j(bindingFlags, methodBase_, ref object_2, parameterModifier_, (CultureInfo)((Class7)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, string_, out *(object*)((Class7)(object)Class5.Default).j(default(BindingFlags), methodBase_, ref object_2, parameterModifier_, cultureInfo_, null, out object_))).t(obj, type_, null), string_, out *(object*)null);
				goto end_IL_0392;
			}
			end_IL_0392:;
		}
		catch
		{
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)((Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)class13.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, (CultureInfo)null), (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_2, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_), null, type_, (Type[])(object)Class5.Default, null)), cultureInfo_, (string[])null, out object_), (ParameterModifier[])(object)Class5.Default))).t(null, (Type)(object)Class5.Default, cultureInfo_);
		}
		finally
		{
			Class7 class14 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_2 = bindingFlags;
			Class7 class15 = @class;
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 obj8 = (Class7)((Class7)null).t((object)Class5.Default, type_, cultureInfo_);
			BindingFlags bindingFlags_4 = bindingFlags;
			Class7 class16 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class14.W(bindingFlags_2, (PropertyInfo[])(object)class15.W(bindingFlags_3, (PropertyInfo[])(object)obj8.e(bindingFlags_4, (MethodBase[])(object)class16.e(bindingFlags, null, array, parameterModifier_), (Type[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_), parameterModifier_), type_, array, parameterModifier_), (Type)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_), null, parameterModifier_);
			_ = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj, cultureInfo_);
			goto IL_0671;
		}
		IL_421b:
		GClass2 gClass;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class19);
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
				{
					Class7 class17 = @class;
					Class7 class18 = @class;
					Class7 obj9 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class17.W(default(BindingFlags), null, type_, (Type[])(object)class18.j((BindingFlags)obj9.e(bindingFlags, methodBase_, array, parameterModifier_), null, ref object_2, parameterModifier_, cultureInfo_, string_, out *(object*)Class5.Default), parameterModifier_);
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					class19 = class19;
					_ = (GClass2)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo_);
					_ = (Class10)(object)Class5.Default;
				}
				continue;
			}
			try
			{
				_ = (Class0)(object)@class.W((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null), propertyInfo_, type_, array, parameterModifier_);
				gClass = null;
				gClass = gClass;
				@class = null;
			}
			finally
			{
				_ = (Qk7)(object)Class5.Default;
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class20);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class8)(object)Class5.Default;
			}
			else
			{
				gClass2 = (GClass1)(object)Class5.Default;
			}
		}
		catch
		{
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				class20 = class20;
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				@class = @class;
				gClass2 = null;
				_ = (Class6)(object)Class5.Default;
				Class7 class21 = @class;
				Class7 class22 = @class;
				Class7 obj11 = (Class7)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, (Type)null, array, parameterModifier_)).j(bindingFlags, methodBase_, ref object_2, null, null, string_, out object_);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)class21.t(null, type_, (CultureInfo)(object)class22.W((BindingFlags)obj11.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, string_, out *(object*)Class5.Default), propertyInfo_, (Type)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, null, null), array, parameterModifier_), array, null));
			}
		}
		while (obj != null);
		try
		{
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (uIntPtr == 0)
		{
			do
			{
				if (uIntPtr != 0)
				{
					@struct = (Struct2)Class5.Default;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		do
		{
			_ = (Class8)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo_);
		}
		while (obj != null);
		do
		{
			_ = (Class2)(object)Class5.Default;
		}
		while (obj != null);
		while (true)
		{
			if (obj != null)
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
			}
			else if (obj == null)
			{
				break;
			}
		}
		_ = (GClass3)((Class7)(object)@class.j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, parameterModifier_), out object_)).t(obj, null, cultureInfo_);
		GClass3 gClass3 = gClass3;
		@class = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, parameterModifier_), array, parameterModifier_);
		_ = (Class6)(object)Class5.Default;
		_ = (Class0)(object)Class5.Default;
		Class7 obj13 = (Class7)(object)@class.t(bindingFlags, null, obj, null);
		Class7 class23 = @class;
		BindingFlags bindingFlags_5 = bindingFlags;
		BindingFlags bindingFlags_6 = bindingFlags;
		Class7 class24 = @class;
		BindingFlags bindingFlags_7 = (BindingFlags)((Class7)null).t(obj, type_, (CultureInfo)null);
		Class7 class25 = @class;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if ((UIntPtr)((Class7)(object)obj13.W((BindingFlags)class23.e(bindingFlags_5, (MethodBase[])(object)((Class7)null).W(bindingFlags_6, propertyInfo_, (Type)(object)((Class7)(object)class24.W(bindingFlags_7, (PropertyInfo[])(object)class25.t(bindingFlags, null, null, cultureInfo_), type_, null, null)).t(bindingFlags, fieldInfo_, null, cultureInfo_), array, (ParameterModifier[])(object)Class5.Default), null, null), null, null, null, parameterModifier_)).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, (CultureInfo)(object)Class5.Default), (ParameterModifier[])((Class7)null).t(obj, type_, (CultureInfo)null));
			}
			catch
			{
				struct2 = struct2;
			}
		}
		_ = (Class6)(object)Class5.Default;
		_ = (Class10)(object)Class5.Default;
		class6 = class6;
		gClass = gClass;
		_ = (Class2)@class.t(null, type_, cultureInfo_);
		_ = (Struct2)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Class7 class26;
			do
			{
				class6 = (Class5)(object)@class.W(bindingFlags, propertyInfo_, type_, (Type[])(object)@class.t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_), fieldInfo_, null, null), parameterModifier_);
				class26 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class26.j(bindingFlags, methodBase_, ref object_2, null, null, null, out *(object*)null) != null || obj != null);
		}
		else
		{
			do
			{
				try
				{
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class27.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, null, (string[])(object)Class5.Default, out object_);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
			while ((object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_)).t(bindingFlags, fieldInfo_, @class.t(obj, (Type)(object)@class.t(bindingFlags, null, obj, null), cultureInfo_), (CultureInfo)(object)((Class7)((Class7)null).t(obj, (Type)null, cultureInfo_)).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_)) != null);
		}
		class20 = class20;
		class6 = class6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			if ((UIntPtr)@class.e(bindingFlags, null, null, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (GClass1)(object)Class5.Default;
					qk = qk;
					_ = (Class0)(object)Class5.Default;
					@class = @class;
				}
			}
		}
		finally
		{
			try
			{
				gClass = null;
				class19 = null;
				_ = (GClass3)(object)Class5.Default;
				gClass2 = null;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
					gClass3 = gClass3;
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			goto IL_493b;
		}
		IL_493b:
		do
		{
			Class7 class28 = @class;
			BindingFlags bindingFlags_8 = bindingFlags;
			object object_3 = @class.t(obj, type_, null);
			Class7 class29 = @class;
			Class7 class30 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_9 = bindingFlags;
			BindingFlags bindingFlags_10 = (BindingFlags)Class5.Default;
			Class7 obj17 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, parameterModifier_);
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)class28.t(bindingFlags_8, fieldInfo_, object_3, (CultureInfo)(object)class29.j((BindingFlags)class30.W(bindingFlags_9, propertyInfo_, null, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_10, (PropertyInfo[])null, (Type)(object)obj17.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)(object)@class.t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default), array, (ParameterModifier[])(object)Class5.Default), (object)null, cultureInfo_), ref object_2, parameterModifier_, cultureInfo_, string_, out object_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), (MethodBase[])(object)Class5.Default, ref object_2, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)null)) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					@class = null;
					class7 = (Class6)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
				}
				catch
				{
					class11 = class11;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		try
		{
			gClass4 = gClass4;
			return;
		}
		catch
		{
			gClass2 = null;
			return;
		}
		IL_21c6:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					gClass = gClass;
					continue;
				}
			}
		}
		else
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)Class5.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		try
		{
			try
			{
			}
			finally
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					gClass3 = gClass3;
					_ = (Class4)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
					gClass3 = null;
					goto end_IL_2213;
				}
			}
			end_IL_2213:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num - uIntPtr) == 0)
				{
					_ = (Class4)(object)((Class7)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_)).e((BindingFlags)@class.t(obj, type_, null), null, (Type[])(object)((Class7)null).t((BindingFlags)((Class7)((Class7)null).t(obj, type_, cultureInfo_)).W(default(BindingFlags), propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_), (FieldInfo[])@class.t(obj, type_, cultureInfo_), obj, (CultureInfo)null), parameterModifier_);
					class9 = null;
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_11 = bindingFlags;
					Class7 class32 = @class;
					BindingFlags bindingFlags_12 = bindingFlags;
					Class7 class33 = @class;
					Class7 class34 = @class;
					BindingFlags bindingFlags_13 = bindingFlags;
					Class7 class35 = @class;
					Class7 obj20 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class31.j(bindingFlags_11, null, ref *(object[]*)class32.j(bindingFlags_12, null, ref object_2, parameterModifier_, cultureInfo_, (string[])(object)class33.j((BindingFlags)class34.e(bindingFlags_13, methodBase_, null, (ParameterModifier[])(object)class35.e((BindingFlags)obj20.e(bindingFlags, methodBase_, array, parameterModifier_), methodBase_, array, null)), methodBase_, ref *(object[]*)null, parameterModifier_, null, string_, out object_), out object_), parameterModifier_, (CultureInfo)(object)@class.e(bindingFlags, methodBase_, array, null), string_, out object_);
					class11 = class11;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			else
			{
				class11 = class11;
			}
		}
		if ((UIntPtr)@class.e(bindingFlags, methodBase_, null, parameterModifier_) == (UIntPtr)(nuint)0u && uIntPtr == 0)
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			finally
			{
				_ = (Struct1)Class5.Default;
				@class = null;
				class2 = class2;
				goto IL_24b5;
			}
		}
		goto IL_24b5;
		IL_2098:
		if ((UIntPtr)@class.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_), (FieldInfo[])(object)Class5.Default, obj, null) == (UIntPtr)(nuint)0u)
		{
			class12 = null;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (checked(uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					Class7 class36 = @class;
					BindingFlags bindingFlags_14 = bindingFlags;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					Class7 class37 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class36.j(bindingFlags_14, methodBase_2, ref *(object[]*)null, (ParameterModifier[])(object)class37.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_), null, string_, out object_);
				}
			}
			finally
			{
				do
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (GClass2)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_2, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)Class5.Default)).t(obj, type_, cultureInfo_);
					class2 = null;
					_ = (Class0)(object)Class5.Default;
				}
				while (obj != null);
				goto IL_21c6;
			}
		}
		goto IL_21c6;
		IL_1f6a:
		try
		{
			try
			{
				while (@class.t(obj, type_, cultureInfo_) != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				do
				{
					_ = (Class5)((Class7)null).t((object)null, type_, (CultureInfo)null);
				}
				while (obj != null);
				goto end_IL_1f6b;
			}
			end_IL_1f6b:;
		}
		catch
		{
			_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref object_2, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])@class.t(obj, type_, cultureInfo_), cultureInfo_, null, out *(object*)Class5.Default), cultureInfo_, (string[])(object)Class5.Default, out *(object*)null);
		}
		try
		{
			_ = (Qk7)((Class7)null).t(obj, type_, cultureInfo_);
		}
		finally
		{
			nuint num2 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num2 * uIntPtr) == 0)
			{
				do
				{
					gClass3 = (GClass3)((Class7)null).t(obj, type_, (CultureInfo)null);
				}
				while ((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out object_) != null);
			}
			goto IL_2098;
		}
		IL_1464:
		try
		{
			try
			{
				Class7 class38 = @class;
				BindingFlags bindingFlags_15 = bindingFlags;
				Class7 class39 = @class;
				BindingFlags bindingFlags_16 = bindingFlags;
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class38.j(bindingFlags_15, methodBase_, ref object_2, (ParameterModifier[])(object)class39.e(bindingFlags_16, null, (Type[])(object)((Class7)(object)class40.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, null), ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out *(object*)null)).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(null, (Type)(object)Class5.Default, cultureInfo_), (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null), parameterModifier_), cultureInfo_, string_, out object_);
			}
			catch
			{
				class9 = class9;
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				try
				{
					class12 = class12;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
				goto end_IL_1465;
			}
			end_IL_1465:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				qk = null;
				gClass2 = null;
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				qk = (Qk7)(object)Class5.Default;
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
			}
			goto IL_15ab;
		}
		IL_15ab:
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		_ = (GClass2)(object)Class5.Default;
		while (true)
		{
			BindingFlags bindingFlags_17 = bindingFlags;
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj25 = (Class7)(object)((Class7)(object)class41.W(bindingFlags, null, null, array, null)).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, null, null, string_, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_));
			BindingFlags bindingFlags_18 = (BindingFlags)((Class7)null).W((BindingFlags)@class.t(bindingFlags, null, null, cultureInfo_), propertyInfo_, (Type)(object)@class.e(bindingFlags, methodBase_, array, parameterModifier_), array, parameterModifier_);
			bindingFlags = default(BindingFlags);
			Class7 obj26 = (Class7)(object)((Class7)null).W(bindingFlags_17, propertyInfo_, (Type)((Class7)null).t(obj, (Type)(object)obj25.j(bindingFlags_18, null, ref *(object[]*)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, string_, out object_), parameterModifier_, cultureInfo_, string_, out object_), (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_), (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), cultureInfo_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			Class7 class42 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)obj26.j((BindingFlags)((Class7)((Class7)null).t((object)class42.t(bindingFlags, fieldInfo_, obj, null), (Type)null, cultureInfo_)).t(Class5.Default, null, (CultureInfo)(object)@class.W(bindingFlags, propertyInfo_, null, array, null)), null, ref object_2, null, null, (string[])((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_)).t(obj, (Type)(object)Class5.Default, cultureInfo_), out object_) == null)
			{
				break;
			}
			try
			{
				class9 = class9;
			}
			catch
			{
				class12 = null;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = default(Struct2);
				}
				continue;
			}
		}
		do
		{
			@class = (Class7)@class.t(obj, type_, null);
		}
		while ((object)Class5.Default != null);
		try
		{
			do
			{
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])((Class7)@class.t(((Class7)(object)((Class7)null).e((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), (MethodBase[])null, array, parameterModifier_)).t(null, null, cultureInfo_), type_, cultureInfo_)).t(null, (Type)(object)Class5.Default, null), cultureInfo_, (string[])null, out object_);
			}
			while (obj != null);
		}
		catch
		{
			class2 = null;
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				while (obj != null)
				{
					_ = (Qk7)(object)Class5.Default;
					gClass2 = (GClass1)(object)Class5.Default;
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass3)(object)class43.j(bindingFlags, null, ref object_2, parameterModifier_, (CultureInfo)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_)), (string[])(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null)).j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, null, out *(object*)null), out *(object*)null);
					gClass3 = gClass3;
				}
			}
		}
		catch
		{
			class7 = class7;
			struct2 = default(Struct1);
			gClass4 = (GClass0)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
			_ = (_003CModule_003E)(object)@class.W(bindingFlags, propertyInfo_, null, null, parameterModifier_);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					@struct = @struct;
				}
			}
		}
		try
		{
			do
			{
				try
				{
					class19 = class19;
				}
				finally
				{
					class19 = (Class9)@class.t(Class5.Default, null, cultureInfo_);
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			if ((UIntPtr)@class.t(Class5.Default, type_, (CultureInfo)((Class7)null).t(obj, type_, (CultureInfo)null)) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
			}
			else if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
			{
				_ = (GClass0)(object)Class5.Default;
			}
			goto IL_1b13;
		}
		IL_1401:
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Class10)(object)@class.e(bindingFlags, methodBase_, null, parameterModifier_);
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					goto end_IL_140d;
				}
				end_IL_140d:;
			}
			finally
			{
				class12 = class12;
				gClass = null;
				gClass = gClass;
				class9 = class9;
				class9 = class9;
				goto IL_1464;
			}
		}
		IL_2dbc:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		finally
		{
			BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
			Class7 class44 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags_19, fieldInfo_, (object)class44.W(bindingFlags, null, type_, null, parameterModifier_), cultureInfo_) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class20 = null;
				}
				else
				{
					_ = (Class6)((Class7)null).t(obj, (Type)(object)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])null, parameterModifier_)).W(bindingFlags, propertyInfo_, type_, array, null), (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null));
					Class7 obj31 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class11 = (Class0)(object)obj31.t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)(object)Class5.Default);
					_ = (Class9)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)@class.t(default(BindingFlags), null, obj, cultureInfo_));
					_ = (Struct2)Class5.Default;
				}
			}
			else
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				catch
				{
					_ = Class5.Default;
				}
			}
			goto IL_2f4a;
		}
		IL_1deb:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				try
				{
					class9 = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					goto end_IL_1dec;
				}
			}
			end_IL_1dec:;
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			_ = (Class10)(object)Class5.Default;
			goto IL_1e38;
		}
		IL_2914:
		_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, (CultureInfo)null), array, (ParameterModifier[])(object)Class5.Default);
		while (obj != null)
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					_ = (Struct1)@class.e((BindingFlags)Class5.Default, (MethodBase[])@class.t(obj, type_, cultureInfo_), array, parameterModifier_);
				}
			}
		}
		Class7 class45 = @class;
		Class7 class46 = @class;
		Class7 class47 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)class45.t(class46.j(default(BindingFlags), null, ref object_2, parameterModifier_, null, (string[])(object)class47.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)@class.e(bindingFlags, null, null, null), (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)@class.e((BindingFlags)Class5.Default, methodBase_, array, null), (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_)), (string[])null, out object_)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), fieldInfo_, null, null), null, parameterModifier_), out object_), null, cultureInfo_);
		Class7 class48 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)class48.e(bindingFlags, methodBase_, (Type[])@class.t(null, type_, (CultureInfo)(object)Class5.Default), null);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					@struct = @struct;
				}
			}
		}
		finally
		{
			_ = (Class2)@class.t(obj, type_, cultureInfo_);
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_2ba7;
		}
		IL_2f4a:
		Class7 class49 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class49.j((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_), methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out object_);
		class9 = class9;
		@class = @class;
		gClass2 = null;
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (Qk7)(object)@class.W(bindingFlags, null, null, null, parameterModifier_);
				_ = (_003CModule_003E)(object)Class5.Default;
				struct2 = struct2;
			}
		}
		catch
		{
			try
			{
				_ = (Struct2)@class.W(bindingFlags, propertyInfo_, null, array, parameterModifier_);
			}
			catch
			{
				UIntPtr num3 = (UIntPtr)@class.j((BindingFlags)Class5.Default, methodBase_, ref object_2, null, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)num3) - uIntPtr * unchecked((nuint)(UIntPtr)@class.W((BindingFlags)Class5.Default, null, null, array, parameterModifier_))) == 0)
					{
						_ = (GClass0)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
						_ = Class5.Default;
					}
				}
			}
		}
		if ((UIntPtr)@class.t(bindingFlags, null, Class5.Default, null) == (UIntPtr)(nuint)0u)
		{
			class9 = class9;
		}
		try
		{
			try
			{
				UIntPtr num4 = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				if (checked(unchecked((nuint)num4) + uIntPtr) == 0)
				{
					_ = (Struct1)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])@class.t(null, null, null), out object_);
				}
				else
				{
					_ = (Class8)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				class2 = class2;
				class19 = class19;
				gClass = gClass;
				goto end_IL_30ef;
			}
			end_IL_30ef:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					Class7 obj36 = (Class7)((Class7)null).t(obj, type_, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj36.e(bindingFlags, methodBase_, array, parameterModifier_);
				}
				catch
				{
					qk = qk;
					_ = (_003CModule_003E)((Class7)null).t((object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_), (Type)null, cultureInfo_);
					@struct = @struct;
				}
			}
		}
		if (uIntPtr == 0 && (UIntPtr)@class.j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, null, string_, out object_) == (UIntPtr)(nuint)0u)
		{
			do
			{
				Class7 class50 = @class;
				Class7 obj39 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class50.t(default(BindingFlags), (FieldInfo[])(object)obj39.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, null), ((Class7)null).t((object)null, (Type)(object)@class.W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out object_)), cultureInfo_);
				Class7 class51 = @class;
				BindingFlags bindingFlags_20 = bindingFlags;
				BindingFlags bindingFlags_21 = bindingFlags;
				Class7 class52 = @class;
				BindingFlags bindingFlags_22 = (BindingFlags)Class5.Default;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out object_);
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_23 = bindingFlags;
				Class7 class54 = @class;
				BindingFlags bindingFlags_24 = bindingFlags;
				Class7 class55 = @class;
				BindingFlags bindingFlags_25 = bindingFlags;
				FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
				Class7 obj40 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_26 = (BindingFlags)class52.j(bindingFlags_22, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_2, (string[])(object)class53.j(bindingFlags_23, methodBase_, ref *(object[]*)class54.W(bindingFlags_24, propertyInfo_, (Type)(object)class55.t(bindingFlags_25, fieldInfo_2, obj40.t(((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)@class.W((BindingFlags)Class5.Default, null, type_, array, parameterModifier_), (ParameterModifier[])null), (Type)@class.t(obj, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_2, parameterModifier_, cultureInfo_, string_, out *(object*)null)), cultureInfo_), cultureInfo_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), parameterModifier_, cultureInfo_, null, out *(object*)null), out *(object*)Class5.Default);
				Type type_2 = (Type)(object)Class5.Default;
				Class7 class56 = @class;
				BindingFlags bindingFlags_27 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj, null);
				Type type_3 = (Type)(object)Class5.Default;
				Class7 obj41 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class51.e(bindingFlags_20, null, (Type[])(object)((Class7)(object)((Class7)null).W(bindingFlags_21, propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags_26, propertyInfo_, type_2, array, (ParameterModifier[])(object)((Class7)(object)class56.W(bindingFlags_27, propertyInfo_2, type_3, (Type[])(object)obj41.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)null), parameterModifier_)).W((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), (PropertyInfo[])@class.t(obj, null, cultureInfo_), type_, array, parameterModifier_)), (Type[])(object)Class5.Default, (ParameterModifier[])null)).W(bindingFlags, (PropertyInfo[])(object)@class.j((BindingFlags)@class.t(null, (Type)(object)((Class7)(object)((Class7)@class.t(obj, type_, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null))).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_), (CultureInfo)(object)Class5.Default), null, ref object_2, (ParameterModifier[])(object)@class.j(default(BindingFlags), methodBase_, ref object_2, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), cultureInfo_, string_, out object_), null, (string[])(object)Class5.Default, out *(object*)null), null, array, null), null);
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)null) != null);
		}
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				nuint num5 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num5 - uIntPtr) == 0)
				{
					_ = (Class6)(object)Class5.Default;
					class6 = class6;
					gClass2 = null;
				}
			}
			else
			{
				do
				{
					_ = (Class4)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, parameterModifier_, null, null, out object_);
				}
				while (obj != null);
			}
		}
		while (obj != null);
		if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])@class.t(obj, type_, null), parameterModifier_), null, array, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					_ = (Class6)(object)@class.t((BindingFlags)@class.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array, parameterModifier_), null, parameterModifier_), fieldInfo_, null, null);
					goto end_IL_37b8;
				}
				end_IL_37b8:;
			}
			catch
			{
				struct2 = (Struct1)Class5.Default;
			}
		}
		gClass3 = null;
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class19 = class19;
				}
			}
			finally
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					class12 = class12;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					Class7 class58 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)(object)class57.W(bindingFlags_28, propertyInfo_, (Type)(object)class58.e(bindingFlags, null, array, parameterModifier_), null, null)).e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, parameterModifier_);
					Class7 class59 = @class;
					bindingFlags = default(BindingFlags);
					class9 = (Class8)(object)class59.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, cultureInfo_), (Type[])(object)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null)), (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					gClass2 = gClass2;
				}
				continue;
			}
		}
		_ = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
		try
		{
			BindingFlags bindingFlags_29 = bindingFlags;
			Class7 class60 = @class;
			BindingFlags bindingFlags_30 = (BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)Class5.Default, cultureInfo_);
			Type[] type_4 = (Type[])(object)Class5.Default;
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags_29, (FieldInfo[])null, ((Class7)(object)class60.W(bindingFlags_30, propertyInfo_, type_, type_4, (ParameterModifier[])(object)obj44.t(bindingFlags, fieldInfo_, null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_)))).t(null, type_, cultureInfo_), (CultureInfo)null) == (UIntPtr)(nuint)0u && uIntPtr == 0)
			{
				class2 = class2;
			}
		}
		catch
		{
			Class7 class61 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_31 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])@class.t(obj, type_, cultureInfo_);
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)@class.t(obj, type_, cultureInfo_), (MethodBase[])(object)Class5.Default, ref object_2, parameterModifier_, cultureInfo_, string_, out object_), null, (Type[])(object)Class5.Default, null), null, ref *(object[]*)Class5.Default, (ParameterModifier[])@class.t(null, (Type)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), null), cultureInfo_, string_, out *(object*)Class5.Default);
			BindingFlags bindingFlags_32 = bindingFlags;
			Class7 obj45 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, null));
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_33 = bindingFlags;
			Class7 class62 = @class;
			BindingFlags bindingFlags_34 = bindingFlags;
			BindingFlags bindingFlags_35 = (BindingFlags)Class5.Default;
			Class7 class63 = @class;
			BindingFlags bindingFlags_36 = bindingFlags;
			MethodBase[] methodBase_4 = (MethodBase[])(object)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, null, (ParameterModifier[])((Class7)null).t((object)null, type_, (CultureInfo)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default))));
			bindingFlags = default(BindingFlags);
			ref object[] object_4 = ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.W(default(BindingFlags), propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_), ref object_2, parameterModifier_, (CultureInfo)null, string_, out object_), obj, cultureInfo_);
			ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
			string[] string_2 = (string[])(object)@class.t(default(BindingFlags), null, null, cultureInfo_);
			Class7 class64 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class61.j(bindingFlags_31, methodBase_3, ref object_2, parameterModifier_2, null, (string[])(object)((Class7)null).t(bindingFlags_32, (FieldInfo[])null, (object)null, (CultureInfo)(object)obj45.t(bindingFlags_33, (FieldInfo[])(object)class62.W(bindingFlags_34, propertyInfo_, type_, (Type[])(object)((Class7)null).t(bindingFlags_35, (FieldInfo[])(object)class63.j(bindingFlags_36, methodBase_4, ref object_4, parameterModifier_3, null, string_2, out *(object*)class64.e((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), (MethodBase[])((Class7)null).t((object)@class.t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_), methodBase_, array, parameterModifier_)), type_, cultureInfo_), array, parameterModifier_)), (object)null, (CultureInfo)(object)Class5.Default), parameterModifier_), null, cultureInfo_)), out object_) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class6)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj, (CultureInfo)(object)Class5.Default);
				}
				catch
				{
					_ = (Class7)@class.t(null, type_, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		gClass3 = null;
		uIntPtr = default(UIntPtr);
		checked
		{
			nuint num6 = unchecked(uIntPtr / uIntPtr) + unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (unchecked(num6 / uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - unchecked((nuint)(UIntPtr)((Class7)((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, null, (ParameterModifier[])((Class7)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_)).t(Class5.Default, type_, (CultureInfo)(object)Class5.Default))) == 0)
				{
					while (true)
					{
						bindingFlags = default(BindingFlags);
						if ((object)((Class7)null).j(bindingFlags, methodBase_, ref *unchecked((object[]*)@class.t(obj, type_, null)), parameterModifier_, cultureInfo_, string_, out object_) != null)
						{
							class9 = class9;
							continue;
						}
						break;
					}
				}
				else
				{
					while ((object)Class5.Default != null)
					{
						Class7 obj48 = (Class7)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						_ = (GClass3)(object)obj48.e(bindingFlags, methodBase_, null, null);
						class7 = null;
					}
				}
			}
			class11 = class11;
			gClass2 = gClass2;
			class12 = class12;
			class6 = null;
			gClass = gClass;
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class10)(object)@class.W(bindingFlags, null, type_, array, null);
				}
				finally
				{
					try
					{
						class20 = null;
					}
					finally
					{
						gClass2 = (GClass1)(object)Class5.Default;
						goto IL_3fc7;
					}
				}
			}
			goto IL_3fc7;
		}
		IL_0671:
		do
		{
			UIntPtr num7 = (UIntPtr)Class5.Default;
			Class7 class65 = @class;
			BindingFlags bindingFlags_37 = bindingFlags;
			Class7 class66 = @class;
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 obj49 = (Class7)(object)@class.e((BindingFlags)@class.e(bindingFlags, methodBase_, array, null), null, array, null);
			Class7 obj50 = (Class7)(object)Class5.Default;
			Class7 obj51 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_39 = bindingFlags;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num7) + unchecked((nuint)(UIntPtr)class65.j(bindingFlags_37, (MethodBase[])(object)class66.W(bindingFlags_38, null, (Type)(object)obj49.t((BindingFlags)obj50.t(obj51.t(null, (Type)(object)((Class7)null).t(bindingFlags_39, (FieldInfo[])(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null)).t(bindingFlags, fieldInfo_, obj, cultureInfo_), (object)null, (CultureInfo)null), null), type_, null), fieldInfo_, obj, cultureInfo_), (Type[])(object)Class5.Default, null), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_), null, null, array, null), obj, cultureInfo_), string_, out *(object*)null)) != 0)
				{
					@class = @class;
					continue;
				}
				gClass4 = gClass4;
				gClass4 = null;
			}
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				struct2 = struct2;
				Class7 class67 = @class;
				bindingFlags = default(BindingFlags);
				Class10 obj52 = (Class10)(object)class67.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, parameterModifier_);
				class20 = class20;
				class20 = obj52;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)class68.t(obj, type_, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_));
				_ = (Class10)@class.t(null, type_, null);
			}
			finally
			{
				class2 = null;
				goto IL_089a;
			}
		}
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		goto IL_089a;
		IL_1258:
		_003CModule_003E = _003CModule_003E;
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 obj53 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj53.t(bindingFlags, fieldInfo_, null, cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_))), (object)Class5.Default, cultureInfo_);
					_ = (Class7)(object)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, cultureInfo_)).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, null, out object_)).t((BindingFlags)@class.e((BindingFlags)Class5.Default, methodBase_, null, parameterModifier_), fieldInfo_, obj, cultureInfo_);
				}
				else
				{
					Class9 obj54 = (Class9)(object)Class5.Default;
					class19 = null;
					class19 = obj54;
				}
			}
		}
		while (obj != null);
		while (obj != null)
		{
			_ = (Struct1)@class.e(bindingFlags, null, array, parameterModifier_);
		}
		try
		{
			class12 = null;
		}
		finally
		{
			@struct = @struct;
			@struct = @struct;
			goto IL_1401;
		}
		IL_3fc7:
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				qk = null;
				_ = (Class9)(object)Class5.Default;
			}
			else if ((UIntPtr)((Class7)null).W((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])((Class7)(object)Class5.Default).t(null, type_, cultureInfo_), type_, array, (ParameterModifier[])(object)Class5.Default), (PropertyInfo[])null, type_, (Type[])@class.t(null, type_, cultureInfo_), parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				struct2 = (Struct1)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
			}
			else
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		finally
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			goto IL_421b;
		}
		IL_1d49:
		try
		{
			nuint num8 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num9 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num10 = checked(num9 * uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num8 / (num10 / (uIntPtr / (nuint)(UIntPtr)Class5.Default)) == 0)
			{
				@struct = @struct;
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (Class0)(object)@class.j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out object_);
				}
				finally
				{
					class12 = null;
					gClass2 = gClass2;
					class6 = Class5.Default;
					continue;
				}
			}
			goto IL_1deb;
		}
		IL_1e38:
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			try
			{
				if ((UIntPtr)@class.j(bindingFlags, methodBase_, ref object_2, parameterModifier_, cultureInfo_, string_, out *(object*)@class.t(bindingFlags, null, ((Class7)@class.t(@class.t(obj, type_, cultureInfo_), type_, (CultureInfo)(object)Class5.Default)).j((BindingFlags)Class5.Default, null, ref object_2, (ParameterModifier[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array, null), null, (string[])(object)Class5.Default, out *(object*)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_)), cultureInfo_)) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
			finally
			{
				try
				{
					_ = (Class8)(object)@class.e(bindingFlags, null, null, parameterModifier_);
				}
				catch
				{
					gClass3 = (GClass3)(object)Class5.Default;
				}
				goto IL_1f6a;
			}
		}
		IL_24b5:
		while (obj != null)
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				class9 = null;
			}
		}
		try
		{
			try
			{
				_ = (Class6)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])null, parameterModifier_);
			}
			finally
			{
				goto end_IL_24bb;
			}
			end_IL_24bb:;
		}
		catch
		{
			Class7 obj56 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj56.j(bindingFlags, methodBase_, ref object_2, parameterModifier_, null, null, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class11 = class11;
				}
				catch
				{
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class69.e(bindingFlags, methodBase_, array, null);
				}
			}
		}
		_ = Class5.Default;
		Class7 class70;
		BindingFlags bindingFlags_40;
		Class7 obj59;
		Type type_6;
		Class7 obj60;
		BindingFlags bindingFlags_43;
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class6 = Class5.Default;
				}
				finally
				{
					qk = qk;
					goto IL_2579;
				}
			}
			goto IL_2579;
			IL_2579:
			class70 = @class;
			bindingFlags_40 = bindingFlags;
			obj59 = (Class7)((Class7)(object)Class5.Default).t(obj, null, cultureInfo_);
			Class7 class71 = @class;
			BindingFlags bindingFlags_41 = bindingFlags;
			BindingFlags bindingFlags_42 = bindingFlags;
			Type type_5 = (Type)(object)@class.t(bindingFlags, fieldInfo_, null, null);
			Class7 class72 = @class;
			bindingFlags = default(BindingFlags);
			type_6 = (Type)(object)class71.j(bindingFlags_41, null, ref *(object[]*)((Class7)null).W(bindingFlags_42, propertyInfo_, type_5, (Type[])(object)class72.W(bindingFlags, propertyInfo_, null, array, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])null), parameterModifier_, cultureInfo_, string_, out *(object*)null);
			obj60 = (Class7)(object)Class5.Default;
			bindingFlags_43 = bindingFlags;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class70.e(bindingFlags_40, (MethodBase[])obj59.t(obj, type_6, (CultureInfo)(object)((Class7)(object)obj60.j(bindingFlags_43, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo_, (string[])(object)Class5.Default, out object_), ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)@class.t(obj, null, cultureInfo_), (string[])(object)Class5.Default, out *(object*)Class5.Default)).e(bindingFlags, methodBase_, null, parameterModifier_)), null, (ParameterModifier[])(object)Class5.Default) != null);
		try
		{
			_ = (GClass2)(object)Class5.Default;
		}
		catch
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					Class7 class73 = @class;
					Class7 class74 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class73.W((BindingFlags)class74.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_2, null, cultureInfo_, (string[])(object)Class5.Default, out object_), null, null, (Type[])(object)Class5.Default, null);
				}
				else
				{
					class19 = (Class9)(object)Class5.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr != 0)
		{
		}
		_ = Class5.Default;
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					BindingFlags bindingFlags_44 = bindingFlags;
					Class7 obj62 = (Class7)(object)Class5.Default;
					Class7 class75 = @class;
					Class7 obj63 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_45 = (BindingFlags)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo_);
					MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).j(bindingFlags_44, (MethodBase[])null, ref object_2, parameterModifier_, (CultureInfo)null, (string[])null, out *(object*)obj62.j(default(BindingFlags), methodBase_, ref *(object[]*)null, null, (CultureInfo)(object)class75.W((BindingFlags)obj63.e(bindingFlags_45, methodBase_5, array, (ParameterModifier[])(object)class76.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, parameterModifier_), null, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out *(object*)null))), (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_)), string_, out *(object*)null));
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		try
		{
			do
			{
				class19 = (Class9)(object)Class5.Default;
			}
			while (obj != null);
		}
		finally
		{
			gClass2 = null;
			goto IL_2914;
		}
		IL_2ba7:
		while (obj != null)
		{
			if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
			{
				@class = @class;
			}
			else
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		do
		{
			try
			{
				Class7 class77;
				BindingFlags bindingFlags_46;
				ref object[] object_5;
				Class7 class78;
				Class7 class79;
				BindingFlags bindingFlags_47;
				Class7 class80;
				do
				{
					class19 = class19;
					class77 = @class;
					bindingFlags_46 = bindingFlags;
					object_5 = ref *(object[]*)Class5.Default;
					class78 = @class;
					class79 = @class;
					bindingFlags_47 = bindingFlags;
					class80 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class77.j(bindingFlags_46, methodBase_, ref object_5, parameterModifier_, (CultureInfo)class78.t(obj, type_, (CultureInfo)(object)class79.t(bindingFlags_47, null, class80.t(bindingFlags, null, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_)), (CultureInfo)(object)Class5.Default)), string_, out object_) != null);
			}
			catch
			{
				try
				{
					_ = Class5.Default;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
					_ = (Class9)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null)).j(bindingFlags, methodBase_, ref object_2, null, cultureInfo_, string_, out object_);
					_ = (GClass0)(object)@class.e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)((Class7)null).t((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_), fieldInfo_, obj, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		while ((object)Class5.Default != null);
		nuint num11 = uIntPtr;
		UIntPtr num12 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num11 - unchecked((nuint)num12 / checked(unchecked(uIntPtr / checked(unchecked((nuint)(UIntPtr)@class.t(default(BindingFlags), fieldInfo_, obj, cultureInfo_) / (nuint)(UIntPtr)Class5.Default) - uIntPtr)) + uIntPtr)) == 0 && uIntPtr == 0)
			{
				qk = qk;
			}
			try
			{
			}
			finally
			{
				goto IL_2dbc;
			}
		}
		IL_089a:
		qk = qk;
		qk = qk;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				Class7 class81 = @class;
				BindingFlags bindingFlags_48 = bindingFlags;
				BindingFlags bindingFlags_49 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_2, parameterModifier_, cultureInfo_, string_, out object_);
				Class7 class82 = @class;
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = (BindingFlags)((Class7)null).W(bindingFlags_50, propertyInfo_, (Type)(object)class83.e(bindingFlags, methodBase_, array, null), array, parameterModifier_);
				MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
				Class7 class84 = @class;
				BindingFlags bindingFlags_52 = (BindingFlags)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null);
				Class7 class85 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_53 = bindingFlags;
				BindingFlags bindingFlags_54 = bindingFlags;
				ref object[] object_6 = ref *(object[]*)@class.t(obj, null, cultureInfo_);
				Class7 class86 = @class;
				bindingFlags = default(BindingFlags);
				Type type_7 = (Type)(object)class82.e(bindingFlags_51, methodBase_6, (Type[])(object)class84.j(bindingFlags_52, methodBase_, ref *(object[]*)class85.t(bindingFlags_53, (FieldInfo[])(object)((Class7)null).j(bindingFlags_54, methodBase_, ref object_6, (ParameterModifier[])(object)((Class7)(object)class86.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null)).t(bindingFlags, fieldInfo_, obj, cultureInfo_), cultureInfo_, string_, out object_), obj, null), parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)((Class7)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out object_)).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_)), parameterModifier_);
				BindingFlags bindingFlags_55 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
				Type type_8 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class81.j(bindingFlags_48, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)((Class7)null).W(bindingFlags_49, propertyInfo_3, type_7, (Type[])(object)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags_55, propertyInfo_4, type_8, array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_)), methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_, out object_), parameterModifier_), out object_);
			}
			else
			{
				_ = (Struct1)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
			}
		}
		BindingFlags bindingFlags_56 = bindingFlags;
		Class7 class87 = @class;
		BindingFlags bindingFlags_57 = bindingFlags;
		ref object[] object_7 = ref *(object[]*)Class5.Default;
		Class7 class88 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj66 = (Class7)(object)class87.j(bindingFlags_57, null, ref object_7, parameterModifier_, null, string_, out *(object*)class88.e(bindingFlags, (MethodBase[])@class.t(obj, type_, (CultureInfo)(object)Class5.Default), array, parameterModifier_));
		BindingFlags bindingFlags_58 = (BindingFlags)Class5.Default;
		Class7 obj67 = (Class7)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type_, null, (ParameterModifier[])(object)Class5.Default);
		BindingFlags bindingFlags_59 = bindingFlags;
		ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
		Class7 class89 = @class;
		Class7 obj68 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj69 = (Class7)(object)((Class7)(object)obj68.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)@class.t(null, type_, (CultureInfo)(object)Class5.Default))).t(bindingFlags, null, obj, cultureInfo_);
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)obj66.j(bindingFlags_58, null, ref object_2, null, (CultureInfo)(object)obj67.j(bindingFlags_59, null, ref object_2, parameterModifier_4, cultureInfo_, null, out *(object*)class89.e((BindingFlags)obj69.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, null, out object_), methodBase_, null, parameterModifier_)), null, out object_);
		Type type_9 = (Type)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)Class5.Default);
		Type[] type_10 = (Type[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)@class.j(default(BindingFlags), null, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)((Class7)null).t((BindingFlags)@class.W(default(BindingFlags), propertyInfo_, type_, array, parameterModifier_), (FieldInfo[])null, @class.t(obj, null, (CultureInfo)(object)Class5.Default), cultureInfo_)), out object_), ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out object_);
		Class7 obj70 = (Class7)(object)Class5.Default;
		Class7 class90 = @class;
		Class7 class91 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj71 = (Class7)(object)class91.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_60 = (BindingFlags)class90.e(default(BindingFlags), methodBase_, null, (ParameterModifier[])((Class7)null).t((object)obj71.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), array, parameterModifier_), (Type)null, cultureInfo_));
		ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, parameterModifier_);
		string[] string_3 = (string[])(object)Class5.Default;
		Class7 class92 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags_56, propertyInfo_5, type_9, type_10, (ParameterModifier[])(object)obj70.W((BindingFlags)((Class7)null).j(bindingFlags_60, methodBase_, ref object_2, parameterModifier_5, cultureInfo_, string_3, out *(object*)class92.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)), (PropertyInfo[])(object)@class.t((BindingFlags)((Class7)null).t(obj, type_, cultureInfo_), fieldInfo_, Class5.Default, null), type_, (Type[])(object)Class5.Default, parameterModifier_));
		class2 = null;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass2 = null;
					_ = (Struct1)Class5.Default;
					Class7 class93 = @class;
					BindingFlags bindingFlags_61 = bindingFlags;
					MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
					ref object[] object_8 = ref *(object[]*)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_);
					Class7 obj72 = (Class7)(object)Class5.Default;
					Class7 obj73 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)(object)class93.j(bindingFlags_61, methodBase_7, ref object_8, parameterModifier_, (CultureInfo)obj72.t(obj73.t(bindingFlags, fieldInfo_, obj, cultureInfo_), type_, null), string_, out *(object*)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default))).t(null, type_, (CultureInfo)(object)Class5.Default);
				}
				finally
				{
					_ = (Class10)(object)@class.j(bindingFlags, methodBase_, ref object_2, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)null);
					goto end_IL_0fd0;
				}
			}
			_ = (GClass3)(object)Class5.Default;
			end_IL_0fd0:;
		}
		catch
		{
			while (obj != null)
			{
				do
				{
					class11 = (Class0)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_);
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		catch
		{
			if ((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (Class7)(object)((Class7)null).t(default(BindingFlags), fieldInfo_, (object)Class5.Default, (CultureInfo)null);
			}
		}
		checked
		{
			try
			{
				do
				{
					gClass4 = gClass4;
				}
				while (obj != null);
			}
			finally
			{
				nuint num13 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				if (num13 * unchecked((nuint)(UIntPtr)class94.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, obj, cultureInfo_), null, parameterModifier_)) == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					_ = (Qk7)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_)).t(bindingFlags, null, obj, cultureInfo_);
				}
				goto IL_1258;
			}
		}
		IL_1b13:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Class7 class95 = @class;
				BindingFlags bindingFlags_62 = bindingFlags;
				bindingFlags = default(BindingFlags);
				gClass = (GClass2)(object)class95.j(bindingFlags_62, null, ref *(object[]*)((Class7)null).t(obj, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null), (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, null)).W(bindingFlags, propertyInfo_, null, array, parameterModifier_)), parameterModifier_, null, string_, out object_);
			}
			else
			{
				class9 = (Class8)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo_);
			}
		}
		catch
		{
			try
			{
				qk = null;
			}
			finally
			{
				gClass4 = gClass4;
				goto end_IL_1bee;
			}
			end_IL_1bee:;
		}
		while (obj != null)
		{
			try
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
					gClass4 = gClass4;
					qk = (Qk7)((Class7)null).t((object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref object_2, parameterModifier_, cultureInfo_, (string[])null, out *(object*)null), (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])null, out *(object*)null), null, (CultureInfo)(object)@class.e(bindingFlags, methodBase_, array, parameterModifier_)), type_, cultureInfo_);
					class11 = class11;
				}
				finally
				{
					gClass = null;
					goto end_IL_1c06;
				}
				end_IL_1c06:;
			}
			finally
			{
				try
				{
					gClass2 = gClass2;
				}
				finally
				{
					class19 = class19;
					continue;
				}
			}
		}
		checked
		{
			try
			{
				gClass = gClass;
			}
			finally
			{
				nuint num14 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num14 + (unchecked((nuint)default(UIntPtr)) + (uIntPtr - uIntPtr)) == 0)
				{
					while (obj != null)
					{
						_ = (Class10)(object)Class5.Default;
						gClass2 = (GClass1)(object)Class5.Default;
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
				goto IL_1d49;
			}
		}
	}

	unsafe static void smethod_1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 @class);
		BindingFlags bindingFlags;
		try
		{
			_ = (Class4)(object)Class5.Default;
			bindingFlags = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_ = bindingFlags;
			obj = obj;
			object object_ = obj;
			cultureInfo = null;
			_ = (Class10)(object)((Class7)null).t(bindingFlags_, (FieldInfo[])null, object_, cultureInfo);
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			@class = @class;
			@class = @class;
			class2 = class2;
			Class7 class3 = class2;
			Class7 class4 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_2 = bindingFlags;
			array = array;
			MethodBase[] methodBase_ = array;
			reference = ref reference;
			ref object[] object_2 = ref reference;
			CultureInfo cultureInfo_ = cultureInfo;
			Class7 obj2 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_3 = bindingFlags;
			array2 = array2;
			type = (Type)(object)class4.j(bindingFlags_2, methodBase_, ref object_2, null, cultureInfo_, (string[])(object)obj2.t(bindingFlags_3, array2, obj, null), out *(object*)Class5.Default);
			BindingFlags bindingFlags_4 = (BindingFlags)((Class7)null).t((object)null, type, cultureInfo);
			array3 = array3;
			_ = (GClass0)(object)class3.e(bindingFlags_4, null, array3, (ParameterModifier[])(object)Class5.Default);
		}
		@class = @class;
		_ = (Class8)class2.t(null, null, cultureInfo);
		Class7 class5 = class2;
		object object_3 = Class5.Default;
		Type type_ = type;
		Class7 class6 = class2;
		BindingFlags bindingFlags_5 = bindingFlags;
		Type[] type_2 = (Type[])(object)Class5.Default;
		Class7 class7 = class2;
		BindingFlags bindingFlags_6 = (BindingFlags)Class5.Default;
		PropertyInfo[] array4 = array4;
		Class7 obj4 = (Class7)(object)class6.W(bindingFlags_5, null, null, type_2, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)class7.W(bindingFlags_6, array4, null, (Type[])(object)Class5.Default, null), array, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo), cultureInfo, (string[])class2.t(null, (Type)(object)class2.W((BindingFlags)Class5.Default, array4, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), cultureInfo), out *(object*)Class5.Default));
		BindingFlags bindingFlags_7 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_2 = array;
		ref object[] object_4 = ref reference;
		ParameterModifier[] parameterModifier_ = null;
		CultureInfo cultureInfo_2 = cultureInfo;
		ref object object_5 = ref *(object*)null;
		Qk7 qk = (Qk7)class5.t(object_3, type_, (CultureInfo)(object)obj4.j(bindingFlags_7, methodBase_2, ref object_4, parameterModifier_, cultureInfo_2, null, out object_5));
		qk = qk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			Class7 obj5 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj5.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default);
		}
		catch
		{
			Class7 obj6;
			BindingFlags bindingFlags_8;
			MethodBase[] methodBase_3;
			CultureInfo cultureInfo_3;
			do
			{
				checked
				{
					num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)class2.e((BindingFlags)Class5.Default, null, array3, parameterModifier_));
					if (num == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
					obj6 = (Class7)(object)Class5.Default;
					bindingFlags_8 = bindingFlags;
					methodBase_3 = array;
					cultureInfo_3 = cultureInfo;
					array5 = array5;
				}
			}
			while ((object)obj6.j(bindingFlags_8, methodBase_3, ref *(object[]*)null, parameterModifier_, cultureInfo_3, array5, out object_5) != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		if (num == 0)
		{
			gClass = gClass;
			gClass = null;
		}
		while (obj != null)
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num / num == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array3, (ParameterModifier[])null);
				}
			}
		}
		Struct1 @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj != null)
		{
			@struct = (Struct1)Class5.Default;
			@struct = @struct;
			qk = qk;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class8);
		if (num == (UIntPtr)(nuint)0u)
		{
			class8 = null;
			class8 = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class9);
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				Class7 obj8 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)obj8.j(bindingFlags, null, ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out object_5);
			}
			else
			{
				do
				{
					class9 = (Class0)(object)class2.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_5);
					class9 = class9;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
			}
			finally
			{
				gClass = null;
				goto end_IL_045a;
			}
			end_IL_045a:;
		}
		_ = (Class0)(object)Class5.Default;
		try
		{
			do
			{
				class9 = class9;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					goto end_IL_0486;
				}
				end_IL_0486:;
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						_ = (Qk7)(object)Class5.Default;
						Class7 class10 = class2;
						BindingFlags bindingFlags_9 = bindingFlags;
						Class7 class11 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class5)(object)class10.e(bindingFlags_9, (MethodBase[])(object)class11.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo, array5, out object_5), array3, parameterModifier_);
						continue;
					}
					goto end_IL_04cf;
				}
				end_IL_04cf:;
			}
		}
		_ = (Class2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, parameterModifier_);
		@struct = default(Struct1);
		Class5 class12 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class15);
		try
		{
			while (obj != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		finally
		{
			UIntPtr num2 = (UIntPtr)Class5.Default;
			UIntPtr num3 = (UIntPtr)Class5.Default;
			UIntPtr num4 = (UIntPtr)Class5.Default;
			UIntPtr num5 = num;
			UIntPtr num6 = (UIntPtr)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, parameterModifier_);
			Class7 obj12 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null);
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
			Class7 class13 = class2;
			bindingFlags = default(BindingFlags);
			nuint num7 = (nuint)num2 / checked(unchecked((nuint)num3) * (unchecked((nuint)num4) - unchecked((nuint)num5 / ((nuint)num6 / (nuint)(UIntPtr)obj12.j(default(BindingFlags), null, ref *(object[]*)null, parameterModifier_2, (CultureInfo)(object)((Class7)(object)class13.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.e(bindingFlags, array, array3, null), array5, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, parameterModifier_))).W((BindingFlags)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null), array4, (Type)((Class7)null).t(obj, type, cultureInfo), array3, null), (string[])(object)Class5.Default, out *(object*)Class5.Default)))));
			num = default(UIntPtr);
			if (num7 / checked(num - num) == 0)
			{
				gClass = null;
			}
			else
			{
				gClass2 = (GClass1)(object)Class5.Default;
				gClass2 = gClass2;
				GClass0 obj13 = (GClass0)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, parameterModifier_);
				Class7 class14 = class2;
				bindingFlags = default(BindingFlags);
				gClass3 = (GClass0)(object)class14.t(bindingFlags, array2, class2.t((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), null, obj, cultureInfo), obj, null), array2, obj, cultureInfo), cultureInfo);
				gClass3 = obj13;
				class15 = null;
				class15 = null;
				Class7 class16 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class16.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default);
			}
			goto IL_0803;
		}
		IL_3cb4:
		_ = (Class5)class2.t(class2.W(bindingFlags, array4, type, array3, null), type, (CultureInfo)class2.t(Class5.Default, type, null));
		if (num == 0)
		{
			qk = qk;
		}
		else
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class17);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		checked
		{
			do
			{
				try
				{
					_ = (Class2)(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default));
				}
				catch
				{
					nuint num8 = num * unchecked((nuint)(UIntPtr)class2.t(null, type, cultureInfo));
					num = default(UIntPtr);
					nuint num9 = num8 * num;
					nuint num10 = num;
					num = default(UIntPtr);
					if (num9 + (num10 + num) == 0)
					{
						_ = (GClass0)class2.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)unchecked(class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out object_5)));
						continue;
					}
					_ = (Qk7)(object)Class5.Default;
					@class = (Class10)(object)Class5.Default;
					_ = Class5.Default;
					struct2 = struct2;
				}
			}
			while (class2.t(obj, type, null) != null);
			_ = (Class9)(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)(object)((Class7)null).W(unchecked((BindingFlags)Class5.Default), array4, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default));
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					try
					{
						_ = (Class7)(object)Class5.Default;
					}
					finally
					{
						class17 = null;
						goto end_IL_3ec3;
					}
					end_IL_3ec3:;
				}
				catch
				{
					num = default(UIntPtr);
					nuint num11 = (num + num) * unchecked((nuint)default(UIntPtr));
					UIntPtr num12;
					nuint num13;
					unchecked
					{
						num12 = (UIntPtr)((Class7)null).t(bindingFlags, array2, (object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), out object_5), array2, obj, (CultureInfo)null), (CultureInfo)(object)Class5.Default);
						Class7 class18 = class2;
						bindingFlags = default(BindingFlags);
						num13 = (nuint)(UIntPtr)class18.W(bindingFlags, array4, type, (Type[])(object)Class5.Default, parameterModifier_) / checked(unchecked((nuint)(UIntPtr)class2.t(obj, null, cultureInfo)) + unchecked((nuint)default(UIntPtr)));
						num = default(UIntPtr);
					}
					if (num11 - (unchecked((nuint)num12) - (num13 * (num - num) - num)) == 0)
					{
						_ = (GClass2)(object)Class5.Default;
					}
				}
			}
			_ = (Class10)(object)Class5.Default;
		}
		try
		{
			if (num == 0 && checked(num + num) / (nuint)(UIntPtr)Class5.Default == 0)
			{
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)null).W(bindingFlags, array4, type, array3, (ParameterModifier[])null);
			}
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)class2.t(bindingFlags, null, obj, cultureInfo);
				}
				catch
				{
					_ = (Struct2)((Class7)(object)Class5.Default).t(obj, null, null);
				}
				goto IL_40b2;
			}
		}
		IL_20a4:
		if (num != 0)
		{
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)((Class7)null).W(bindingFlags, array4, type, array3, parameterModifier_);
		}
		while (obj != null)
		{
			try
			{
				gClass3 = gClass3;
				_ = (GClass0)class2.t(obj, null, null);
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				continue;
			}
		}
		checked
		{
			try
			{
				gClass2 = null;
			}
			finally
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) + num == 0)
					{
						bindingFlags = default(BindingFlags);
						_ = (GClass0)(object)((Class7)null).e(bindingFlags, array, (Type[])null, parameterModifier_);
					}
				}
				while ((object)class2.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)class2.W(bindingFlags, array4, null, array3, null), cultureInfo, array5, out object_5) != null);
				goto IL_2197;
			}
		}
		IL_3b57:
		_ = (Class0)((Class7)null).t((object)null, type, cultureInfo);
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass4);
		try
		{
			try
			{
				@struct = @struct;
			}
			finally
			{
				if (num == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				goto end_IL_3b7a;
			}
			end_IL_3b7a:;
		}
		finally
		{
			try
			{
				gClass4 = gClass4;
			}
			finally
			{
				_ = (Qk7)(object)Class5.Default;
				goto IL_3bb4;
			}
		}
		IL_1631:
		while (obj != null)
		{
			if (num == 0)
			{
				_ = (Class7)class2.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
				continue;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = Class5.Default;
			}
			else
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		_ = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])null, out *(object*)null);
		MethodBase[] methodBase_4 = array;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)((Class7)null).e(default(BindingFlags), methodBase_4, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, parameterModifier_, (CultureInfo)null, array5, out *(object*)class2.e(bindingFlags, array, null, parameterModifier_)), parameterModifier_);
		try
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		finally
		{
			if (num == 0)
			{
				do
				{
					class12 = (Class5)(object)class2.e((BindingFlags)((Class7)null).t(obj, type, cultureInfo), array, array3, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array4, type, (Type[])(object)Class5.Default, parameterModifier_));
				}
				while (obj != null);
			}
			goto IL_1725;
		}
		IL_0e7c:
		_ = (Class10)(object)Class5.Default;
		try
		{
			try
			{
				gClass4 = gClass4;
			}
			finally
			{
				try
				{
					Class7 class19 = class2;
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class20 = class2;
					bindingFlags = default(BindingFlags);
					Class2 obj18 = (Class2)(object)class19.e(bindingFlags_10, (MethodBase[])(object)class20.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), array3, parameterModifier_);
					class17 = class17;
					class17 = obj18;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, parameterModifier_);
				}
				catch
				{
					Class7 class21 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class21.e(bindingFlags, null, array3, null);
				}
				goto end_IL_0e87;
			}
			end_IL_0e87:;
		}
		finally
		{
			gClass4 = gClass4;
			class15 = class15;
			_ = (Qk7)class2.t(obj, (Type)(object)Class5.Default, cultureInfo);
			gClass4 = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, parameterModifier_, cultureInfo, array5, out *(object*)null);
			goto IL_0fa1;
		}
		IL_0fa1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class22);
		try
		{
			while ((object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, parameterModifier_) != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
					class22 = class22;
					class15 = class15;
				}
				else
				{
					Class7 class23 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class23.e(bindingFlags, null, array3, parameterModifier_);
				}
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					gClass4 = (GClass3)(object)Class5.Default;
				}
				else
				{
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null);
				}
			}
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Struct1)((Class7)null).e((BindingFlags)class2.t(obj, (Type)class2.t(Class5.Default, null, cultureInfo), (CultureInfo)(object)Class5.Default), array, array3, (ParameterModifier[])null);
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_1066;
				}
			}
			end_IL_1066:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass4 = gClass4;
				_ = (GClass3)((Class7)null).t((object)null, (Type)null, cultureInfo);
			}
			else if ((UIntPtr)((Class7)(object)class2.j((BindingFlags)Class5.Default, null, ref reference, parameterModifier_, null, array5, out object_5)).e(bindingFlags, array, array3, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)Class5.Default;
			}
		}
		gClass3 = gClass3;
		_ = (Struct1)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * num == 0)
					{
						gClass = (GClass2)(object)Class5.Default;
					}
					continue;
				}
				try
				{
					gClass2 = gClass2;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					continue;
				}
			}
			while ((object)class2.e(unchecked((BindingFlags)Class5.Default), array, array3, null) != null);
			if (num + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array, ref reference, parameterModifier_, (CultureInfo)(object)class2.e((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, null), (MethodBase[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, parameterModifier_), array3, (ParameterModifier[])(object)Class5.Default), array5, out *(object*)Class5.Default)) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
				}
				finally
				{
					try
					{
						_ = (Struct1)Class5.Default;
					}
					finally
					{
						_003CModule_003E = null;
						goto IL_12d0;
					}
				}
			}
			goto IL_12d0;
		}
		IL_2197:
		@struct = (Struct1)class2.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class24);
		try
		{
			if (num == 0)
			{
				if (num == 0)
				{
					class24 = class24;
				}
				else
				{
					class12 = null;
				}
			}
			else
			{
				_ = Class5.Default;
			}
		}
		catch
		{
			class24 = (Class8)(object)Class5.Default;
		}
		do
		{
			num = default(UIntPtr);
			checked
			{
				if (num != 0)
				{
					num = default(UIntPtr);
					if (num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						class24 = (Class8)(object)Class5.Default;
					}
					else
					{
						@struct = default(Struct1);
					}
					continue;
				}
			}
			try
			{
				_ = (Struct1)Class5.Default;
			}
			catch
			{
				class12 = Class5.Default;
				gClass3 = gClass3;
				Class7 class25 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)(object)class25.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, array5, out *(object*)null)).j(bindingFlags, null, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array5, out *(object*)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default));
			}
		}
		while (obj != null);
		if (num == 0)
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				goto IL_24a5;
			}
		}
		try
		{
			gClass = null;
			Class7 class26 = class2;
			BindingFlags bindingFlags_11 = bindingFlags;
			FieldInfo[] fieldInfo_ = array2;
			Class7 class27 = class2;
			Class7 class28 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_12 = bindingFlags;
			Class7 obj24 = (Class7)(object)Class5.Default;
			Class7 class29 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_13 = bindingFlags;
			MethodBase[] methodBase_5 = array;
			BindingFlags bindingFlags_14 = (BindingFlags)Class5.Default;
			Class7 class30 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class26.t(bindingFlags_11, fieldInfo_, null, (CultureInfo)(object)class27.t((BindingFlags)class28.W(bindingFlags_12, null, (Type)(object)obj24.e((BindingFlags)class29.e(bindingFlags_13, methodBase_5, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_14, (FieldInfo[])(object)class30.t(bindingFlags, null, obj, cultureInfo), (object)Class5.Default, (CultureInfo)null)), (MethodBase[])class2.t(null, (Type)(object)class2.W(bindingFlags, null, type, array3, null), cultureInfo), array3, parameterModifier_), null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null), (object)class2.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null)), null, obj, cultureInfo));
			_ = (GClass0)(object)Class5.Default;
		}
		finally
		{
			_ = (Class7)(object)Class5.Default;
			goto IL_24a5;
		}
		IL_1725:
		try
		{
			try
			{
				do
				{
					gClass3 = null;
				}
				while (obj != null);
			}
			catch
			{
				while (true)
				{
					Class7 class31 = class2;
					object object_6 = obj;
					Class7 obj25 = (Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, null, array5, out object_5), array3, parameterModifier_);
					object object_7 = obj;
					Type type_3 = type;
					Class7 class32 = class2;
					bindingFlags = default(BindingFlags);
					if (class31.t(object_6, null, (CultureInfo)obj25.t(object_7, type_3, (CultureInfo)((Class7)(object)class32.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default)).t(null, (Type)(object)class2.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null), null))) != null)
					{
						class9 = class9;
						_ = Class5.Default;
						BindingFlags bindingFlags_15 = bindingFlags;
						Class7 class33 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Struct1)((Class7)null).j(bindingFlags_15, (MethodBase[])(object)class33.e(bindingFlags, array, null, (ParameterModifier[])(object)((Class7)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.t((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)class2.t(bindingFlags, array2, null, (CultureInfo)(object)Class5.Default), cultureInfo), array2, obj, (CultureInfo)(object)Class5.Default), Class5.Default, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default)), ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array5, out object_5);
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					qk = qk;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_1917;
				}
				end_IL_1917:;
			}
			finally
			{
				do
				{
					class22 = class22;
					_ = (_003CModule_003E)(object)class2.e((BindingFlags)class2.t(obj, type, cultureInfo), array, (Type[])(object)Class5.Default, null);
					_ = (Class2)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, parameterModifier_, cultureInfo, array5, out object_5);
					_ = (Class4)(object)class2.t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, parameterModifier_), null, Class5.Default, null);
				}
				while (obj != null);
				goto end_IL_1916;
			}
			end_IL_1916:;
		}
		if ((nuint)(UIntPtr)class2.t(bindingFlags, array2, obj, cultureInfo) / checked(num - num) == 0)
		{
			Class7 obj28 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_16 = bindingFlags;
			Class7 obj29 = (Class7)(object)Class5.Default;
			object object_8 = obj;
			Class7 class34 = class2;
			bindingFlags = default(BindingFlags);
			class22 = (Class4)(object)obj28.e(bindingFlags_16, null, (Type[])((Class7)obj29.t(object_8, (Type)(object)class34.e(bindingFlags, array, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, parameterModifier_), null), cultureInfo)).t(class2.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_5), type, (CultureInfo)(object)Class5.Default), (ParameterModifier[])class2.t(obj, type, (CultureInfo)(object)class2.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)Class5.Default)));
			@struct = default(Struct1);
			_ = Class5.Default;
		}
		else
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)((Class7)null).t(obj, type, cultureInfo);
					class17 = null;
					class22 = (Class4)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		try
		{
			@class = @class;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class4)(object)((Class7)null).t((BindingFlags)Class5.Default, array2, (object)((Class7)(object)Class5.Default).W(default(BindingFlags), array4, null, array3, null), (CultureInfo)class2.t(obj, type, cultureInfo));
				}
			}
			else
			{
				class12 = (Class5)(object)class2.e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, parameterModifier_));
			}
		}
		nuint num14;
		nuint num15;
		nuint num17;
		checked
		{
			num14 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
			num = default(UIntPtr);
			num15 = num;
			nuint num16 = num;
			Class7 class35 = class2;
			Class7 class36 = class2;
			Class7 class37 = class2;
			bindingFlags = default(BindingFlags);
			num17 = unchecked(num16 / (nuint)(UIntPtr)class35.e(default(BindingFlags), (MethodBase[])class36.t(class37.W(bindingFlags, null, type, null, parameterModifier_), null, cultureInfo), null, parameterModifier_)) - (num + unchecked((nuint)(UIntPtr)((Class7)(object)class2.W(bindingFlags, array4, type, array3, parameterModifier_)).t(Class5.Default, type, null)));
		}
		UIntPtr num18 = (UIntPtr)Class5.Default;
		Class7 class38 = class2;
		BindingFlags bindingFlags_17 = bindingFlags;
		Class7 obj31 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		nuint num19 = unchecked((nuint)default(UIntPtr)) / ((nuint)num18 / (nuint)(UIntPtr)class38.W(bindingFlags_17, null, (Type)(object)obj31.W(bindingFlags, array4, (Type)(object)Class5.Default, array3, (ParameterModifier[])((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)null)).t(obj, type, null)), array3, (ParameterModifier[])(object)class2.W(bindingFlags, array4, type, array3, parameterModifier_)));
		num = default(UIntPtr);
		nuint num20;
		checked
		{
			num20 = unchecked((nuint)default(UIntPtr)) + (num15 - (num17 - (unchecked((nuint)default(UIntPtr)) + (num19 + num) + num)));
			num = default(UIntPtr);
		}
		if (checked(num14 - unchecked(unchecked((nuint)default(UIntPtr)) / checked(num20 + num))) == 0)
		{
			Class7 class39;
			BindingFlags bindingFlags_18;
			MethodBase[] methodBase_6;
			ref object[] object_9;
			Class7 class40;
			do
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
				}
				class39 = class2;
				bindingFlags_18 = (BindingFlags)((Class7)(object)class2.t(bindingFlags, null, obj, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)class2.e(default(BindingFlags), array, array3, parameterModifier_), null, null);
				methodBase_6 = array;
				object_9 = ref reference;
				class40 = class2;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)(object)class39.j(bindingFlags_18, methodBase_6, ref object_9, null, (CultureInfo)class40.t(null, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default)), array5, out *(object*)null)).t(bindingFlags, array2, null, cultureInfo) != null);
		}
		else
		{
			do
			{
				try
				{
					Class7 obj33 = (Class7)(object)Class5.Default;
					Class7 class41 = class2;
					BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
					Class7 class42 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj33.j((BindingFlags)class41.e(bindingFlags_19, (MethodBase[])(object)class42.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_5), array3, parameterModifier_), array, ref *(object[]*)class2.t(Class5.Default, type, null), parameterModifier_, cultureInfo, null, out *(object*)null);
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					class17 = class17;
					class2 = class2;
					continue;
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)(object)Class5.Default);
				goto IL_2000;
			}
		}
		goto IL_2000;
		IL_2000:
		if (num == 0)
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			finally
			{
				_ = (Struct2)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out object_5);
				goto IL_20a4;
			}
		}
		UIntPtr num21 = (UIntPtr)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, parameterModifier_);
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num21) - num == 0)
			{
				try
				{
					class22 = class22;
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto IL_20a4;
				}
			}
			do
			{
				qk = null;
			}
			while (obj != null);
			goto IL_20a4;
		}
		IL_40b2:
		BindingFlags bindingFlags_20;
		Class7 class43;
		CultureInfo cultureInfo_4;
		string[] string_;
		Class7 class44;
		do
		{
			try
			{
				_ = (GClass2)((Class7)(object)class2.t((BindingFlags)class2.W((BindingFlags)Class5.Default, array4, null, array3, parameterModifier_), array2, obj, cultureInfo)).t(null, type, null);
			}
			catch
			{
				try
				{
					class24 = class24;
				}
				catch
				{
					gClass = (GClass2)(object)Class5.Default;
				}
			}
			bindingFlags_20 = bindingFlags;
			class43 = class2;
			cultureInfo_4 = cultureInfo;
			string_ = array5;
			class44 = class2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).W(bindingFlags_20, (PropertyInfo[])(object)class43.j(default(BindingFlags), null, ref *(object[]*)null, parameterModifier_, cultureInfo_4, string_, out *(object*)class44.j(bindingFlags, array, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out object_5)), type, array3, parameterModifier_) != null);
		class8 = class8;
		try
		{
			gClass = null;
		}
		finally
		{
			goto IL_41b7;
		}
		IL_0803:
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		class2 = null;
		try
		{
			if ((UIntPtr)class2.j((BindingFlags)class2.W(bindingFlags, array4, type, null, parameterModifier_), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out object_5) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)Class5.Default;
				class9 = class9;
				qk = null;
				class12 = class12;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num * num) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class45 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class45.j(bindingFlags, null, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
				}
				else
				{
					gClass4 = null;
					gClass4 = gClass4;
				}
			}
			goto IL_08ee;
		}
		IL_2bf7:
		try
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)class2.t(bindingFlags, array2, null, cultureInfo);
				}
				else
				{
					qk = qk;
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
					_ = (GClass1)(object)Class5.Default;
					goto end_IL_2c2d;
				}
				end_IL_2c2d:;
			}
		}
		catch
		{
			class17 = null;
		}
		Class7 obj38 = (Class7)(object)((Class7)(object)((Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null)).e(bindingFlags, array, array3, parameterModifier_)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)obj38.j(bindingFlags, array, ref reference, parameterModifier_, cultureInfo, (string[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, parameterModifier_), parameterModifier_), out *(object*)Class5.Default);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		}
		while (obj != null)
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			catch
			{
				gClass = gClass;
				_ = (GClass2)(object)Class5.Default;
				_ = (Class4)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, null)).e(bindingFlags, array, array3, null);
				}
				continue;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class8 = (Class9)(object)Class5.Default;
				}
				else
				{
					qk = (Qk7)(object)Class5.Default;
				}
				goto IL_2e29;
			}
		}
		goto IL_2e29;
		IL_08ee:
		if (num == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					@class = @class;
				}
				finally
				{
					gClass2 = gClass2;
					goto IL_0948;
				}
			}
			Class8 obj40 = (Class8)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, null, parameterModifier_);
			class24 = class24;
			class24 = obj40;
		}
		goto IL_0948;
		IL_267e:
		do
		{
			IL_267e_2:
			if ((object)Class5.Default != null)
			{
				try
				{
					BindingFlags bindingFlags_21 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_7 = array;
					Class7 obj41 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 class46 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).e(bindingFlags_21, methodBase_7, (Type[])null, (ParameterModifier[])(object)obj41.e(bindingFlags_22, (MethodBase[])(object)class46.j(bindingFlags, null, ref *(object[]*)class2.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), parameterModifier_, null, null, out object_5), array3, null));
				}
				finally
				{
					_ = (Class2)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
					goto IL_267e_2;
				}
			}
		}
		while ((object)Class5.Default != null);
		_ = (GClass0)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
		Class7 class47 = class2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_23 = bindingFlags;
		object object_10 = obj;
		Class7 obj42 = (Class7)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array5, out object_5);
		BindingFlags bindingFlags_24 = bindingFlags;
		MethodBase[] methodBase_8 = (MethodBase[])class2.t(Class5.Default, null, (CultureInfo)(object)Class5.Default);
		ref object[] object_11 = ref *(object[]*)Class5.Default;
		Class7 class48 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)class47.t(bindingFlags_23, null, object_10, (CultureInfo)(object)obj42.j(bindingFlags_24, methodBase_8, ref object_11, null, null, (string[])((Class7)(object)class48.j(bindingFlags, array, ref reference, parameterModifier_, null, array5, out object_5)).t(null, (Type)(object)Class5.Default, cultureInfo), out *(object*)class2.t(((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, parameterModifier_, (CultureInfo)null, array5, out object_5), null, cultureInfo)));
		do
		{
			nuint num22 = num;
			num = default(UIntPtr);
			checked
			{
				if (num22 - num + (num - num) - unchecked((nuint)(UIntPtr)Class5.Default) != 0)
				{
					while (obj != null)
					{
						_ = (Class2)((Class7)null).t(obj, type, cultureInfo);
					}
				}
				else
				{
					gClass3 = gClass3;
				}
				bindingFlags = default(BindingFlags);
			}
		}
		while (((Class7)(object)((Class7)null).e(bindingFlags, array, array3, parameterModifier_)).t(obj, null, (CultureInfo)(object)((Class7)(object)class2.e(bindingFlags, array, (Type[])(object)class2.W(bindingFlags, array4, (Type)(object)class2.j(bindingFlags, array, ref reference, parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), array3, parameterModifier_), null)).W((BindingFlags)Class5.Default, null, (Type)(object)class2.W(bindingFlags, array4, type, null, parameterModifier_), (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default), parameterModifier_)) != null);
		_ = Class5.Default;
		while (true)
		{
			if (obj != null)
			{
				gClass = (GClass2)class2.t(null, type, (CultureInfo)(object)Class5.Default);
			}
			else if (obj == null && (object)Class5.Default == null)
			{
				break;
			}
		}
		try
		{
			Class7 class49 = class2;
			BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_ = array4;
			Type type_4 = type;
			Class7 obj43 = (Class7)(object)class2.W(bindingFlags, array4, type, array3, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)class2.t(obj, type, (CultureInfo)(object)((Class7)null).j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.t((BindingFlags)Class5.Default, array2, obj, cultureInfo), (Type[])null, (ParameterModifier[])null), array, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null)), (FieldInfo[])null, (object)null, (CultureInfo)(object)Class5.Default));
			object object_12 = obj;
			Class7 class50 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_26 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array4;
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)((Class7)null).W((BindingFlags)class49.W(bindingFlags_25, propertyInfo_, type_4, (Type[])obj43.t(object_12, (Type)(object)class50.W(bindingFlags_26, propertyInfo_2, (Type)(object)obj44.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), (Type[])(object)class2.W(bindingFlags, array4, null, (Type[])(object)Class5.Default, parameterModifier_), (ParameterModifier[])(object)Class5.Default), cultureInfo), parameterModifier_), array4, type, array3, parameterModifier_);
		}
		finally
		{
			try
			{
				do
				{
					_ = (Class6)(object)Class5.Default;
				}
				while (obj != null);
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)((Class7)((Class7)(object)Class5.Default).t(obj, type, null)).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
			}
			goto IL_2b3b;
		}
		IL_2e29:
		do
		{
			class9 = class9;
		}
		while ((object)class2.e(bindingFlags, array, (Type[])class2.t(obj, null, cultureInfo), null) != null);
		gClass4 = gClass4;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, array, ref reference, parameterModifier_, cultureInfo, array5, out *(object*)null);
			}
			while (obj != null);
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				qk = (Qk7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, parameterModifier_);
			}
			finally
			{
				_ = Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				struct2 = struct2;
				object object_13 = obj;
				Class7 class51 = class2;
				BindingFlags bindingFlags_27 = (BindingFlags)Class5.Default;
				BindingFlags bindingFlags_28 = (BindingFlags)((Class7)null).W(bindingFlags, array4, type, array3, (ParameterModifier[])null);
				MethodBase[] methodBase_9 = array;
				CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
				string[] string_2 = array5;
				Class7 obj46 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 class52 = class2;
				bindingFlags = default(BindingFlags);
				gClass = (GClass2)((Class7)null).t(object_13, (Type)(object)class51.W(bindingFlags_27, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_28, methodBase_9, ref *(object[]*)null, parameterModifier_, cultureInfo_5, string_2, out *(object*)obj46.W(bindingFlags_29, null, (Type)(object)class52.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_), array3, parameterModifier_)), null, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null);
				goto IL_2fdc;
			}
		}
		goto IL_2fdc;
		IL_2b73:
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class5)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_)).t(null, type, cultureInfo);
			}
			else
			{
				_ = (Class9)(object)Class5.Default;
			}
			goto IL_2bf7;
		}
		try
		{
			gClass2 = gClass2;
		}
		finally
		{
			_ = (Class10)(object)Class5.Default;
			goto IL_2bf7;
		}
		IL_0948:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			gClass2 = null;
		}
		else
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					Class7 class53 = class2;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass1)(object)class53.j(bindingFlags, null, ref reference, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
					@class = null;
					goto IL_0a12;
				}
			}
			Class7 class54 = class2;
			bindingFlags = default(BindingFlags);
			class22 = (Class4)(object)class54.t(bindingFlags, array2, obj, (CultureInfo)(object)class2.t(bindingFlags, array2, obj, cultureInfo));
			class22 = class22;
			_ = Class5.Default;
			_003CModule_003E = null;
		}
		goto IL_0a12;
		IL_3bb4:
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					class17 = class17;
					goto end_IL_3bc8;
				}
				end_IL_3bc8:;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = gClass2;
				}
				goto IL_3c5f;
			}
		}
		try
		{
			do
			{
				class2 = (Class7)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class15 = (Class6)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, parameterModifier_);
				@struct = default(Struct1);
			}
			goto IL_3c5f;
		}
		IL_12d0:
		try
		{
			if ((UIntPtr)class2.t(bindingFlags, array2, obj, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)class2.e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, null, array3, parameterModifier_), array3, (ParameterModifier[])(object)Class5.Default);
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class8 = class8;
			}
			goto IL_146c;
		}
		IL_146c:
		while (((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default) != null)
		{
			if (num != 0)
			{
				continue;
			}
			while (true)
			{
				BindingFlags bindingFlags_30 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array2;
				Class7 obj47 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)(object)((Class7)null).t(bindingFlags_30, fieldInfo_2, (object)obj47.W(bindingFlags, (PropertyInfo[])(object)class2.t((BindingFlags)((Class7)(object)((Class7)(object)class2.t((BindingFlags)Class5.Default, null, null, cultureInfo)).e(bindingFlags, array, array3, (ParameterModifier[])((Class7)null).t(obj, type, cultureInfo))).e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, array, null, parameterModifier_), null, parameterModifier_), null, null, cultureInfo), null, array3, parameterModifier_), (CultureInfo)null)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array3, null) == null)
				{
					break;
				}
				_ = (Class9)class2.t(null, (Type)(object)Class5.Default, cultureInfo);
			}
		}
		if (num == 0 && (nuint)(UIntPtr)Class5.Default / checked(unchecked((nuint)(UIntPtr)Class5.Default) * num * unchecked((nuint)(UIntPtr)class2.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo))) == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Class2)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, parameterModifier_);
			}
		}
		try
		{
			if (num == 0)
			{
				gClass = gClass;
			}
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				struct2 = (Struct2)Class5.Default;
				struct2 = struct2;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				@struct = default(Struct1);
			}
		}
		catch
		{
			if (num == 0)
			{
				gClass3 = gClass3;
			}
			else
			{
				_ = (Class8)((Class7)null).t((object)Class5.Default, type, cultureInfo);
				class15 = null;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class15 = (Class6)((Class7)null).t(obj, type, cultureInfo);
			}
			else
			{
				gClass = gClass;
			}
			goto IL_1631;
		}
		IL_41b7:
		if (num == 0)
		{
			do
			{
				class22 = (Class4)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class8 = null;
					Class7 class55 = class2;
					BindingFlags bindingFlags_31 = bindingFlags;
					Class7 class56 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj50 = (Class7)(object)class56.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, parameterModifier_);
					BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
					Class7 obj51 = (Class7)(object)((Class7)(object)((Class7)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo)).e(bindingFlags, null, array3, parameterModifier_)).e(bindingFlags, array, null, null);
					Class7 obj52 = (Class7)(object)Class5.Default;
					Class7 class57 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).W((BindingFlags)class55.e(bindingFlags_31, (MethodBase[])(object)obj50.t((BindingFlags)((Class7)null).W(bindingFlags_32, (PropertyInfo[])(object)obj51.j((BindingFlags)obj52.t(class57.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), parameterModifier_), null, cultureInfo), array, ref reference, null, cultureInfo, null, out *(object*)class2.W((BindingFlags)Class5.Default, null, null, array3, parameterModifier_)), (Type)(object)Class5.Default, array3, (ParameterModifier[])null), (FieldInfo[])(object)class2.W(bindingFlags, null, null, null, null), Class5.Default, cultureInfo), null, (ParameterModifier[])(object)Class5.Default), array4, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					@struct = @struct;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Struct1)class2.t(obj, null, cultureInfo);
				}
			}
		}
		struct2 = default(Struct2);
		while (obj != null)
		{
			if (num == 0)
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		_ = (Class7)((Class7)null).t((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])null), (Type)class2.t(obj, (Type)(object)Class5.Default, cultureInfo), (CultureInfo)null);
		while (obj != null)
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
				gClass2 = gClass2;
				class24 = class24;
				gClass3 = gClass3;
			}
			catch
			{
				while (obj != null)
				{
					_003CModule_003E = null;
				}
			}
		}
		while (obj != null)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			@class = null;
			return;
		}
		finally
		{
			_ = (_003CModule_003E)(object)class2.e(bindingFlags, null, array3, null);
			return;
		}
		IL_0a12:
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_10 = array;
				Class7 class58 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)((Class7)null).j(bindingFlags_33, methodBase_10, ref *(object[]*)class58.t(bindingFlags, null, obj, cultureInfo), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default), (CultureInfo)null, (string[])(object)Class5.Default, out object_5);
				_ = (Class4)(object)Class5.Default;
				gClass2 = gClass2;
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			class9 = class9;
		}
		try
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		}
		finally
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
				}
			}
			goto IL_0aed;
		}
		IL_3c5f:
		qk = qk;
		while (obj != null)
		{
			if (num == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		try
		{
			class22 = class22;
		}
		finally
		{
			try
			{
				do
				{
					class22 = null;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					class12 = class12;
				}
				catch
				{
					struct2 = struct2;
				}
				goto IL_3cb4;
			}
		}
		IL_3393:
		do
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (GClass1)(object)class2.t(bindingFlags, array2, obj, null);
				}
				catch
				{
					class8 = (Class9)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			gClass4 = (GClass3)(object)Class5.Default;
			_ = (Class7)class2.t(obj, null, null);
			class2 = class2;
		}
		catch
		{
			class12 = class12;
		}
		num = default(UIntPtr);
		if (num / num == 0)
		{
			_ = (Struct2)Class5.Default;
			class2 = null;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class22 = (Class4)(object)Class5.Default;
				}
				catch
				{
					Class7 class59 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class59.j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)(object)class2.t(bindingFlags, null, null, cultureInfo)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)(object)Class5.Default), ref reference, null, cultureInfo, null, out object_5), array5, out object_5);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)class2.t(obj, (Type)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default), cultureInfo);
		}
		else
		{
			_ = (GClass0)(object)class2.W(bindingFlags, array4, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, null, cultureInfo), (Type[])(object)Class5.Default, parameterModifier_);
		}
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			finally
			{
				if (num == 0)
				{
					class2 = class2;
				}
				goto end_IL_35a6;
			}
			end_IL_35a6:;
		}
		catch
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (Class9)(object)class2.t((BindingFlags)Class5.Default, array2, obj, cultureInfo);
					class17 = class17;
					_ = (Class10)(object)class2.e(bindingFlags, array, array3, parameterModifier_);
					Class7 class60 = class2;
					BindingFlags bindingFlags_34 = bindingFlags;
					FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
					Class7 obj59 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class60.t(bindingFlags_34, fieldInfo_3, obj59.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo, array5, out *(object*)Class5.Default), cultureInfo);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		Class7 obj61 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_35 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		class2 = (Class7)(object)obj61.e(bindingFlags_35, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, parameterModifier_, cultureInfo, array5, out *(object*)null), array3, (ParameterModifier[])(object)Class5.Default);
		if (num == 0)
		{
			_ = (Class6)(object)Class5.Default;
		}
		num = default(UIntPtr);
		if (num / num == 0)
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
			}
			catch
			{
				try
				{
					@struct = @struct;
					_ = (Class8)(object)Class5.Default;
					@struct = default(Struct1);
					@struct = @struct;
					@class = @class;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					goto end_IL_372d;
				}
				end_IL_372d:;
			}
		}
		while (obj != null)
		{
			try
			{
				class17 = class17;
			}
			finally
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
					gClass2 = gClass2;
					_ = (Qk7)(object)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_);
					class17 = class17;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)((Class7)null).e(bindingFlags, array, array3, parameterModifier_);
				continue;
			}
			try
			{
				class9 = (Class0)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, array5, out *(object*)Class5.Default);
			}
			catch
			{
				@class = @class;
				class15 = class15;
			}
		}
		try
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)((Class7)(object)class2.t((BindingFlags)class2.t(obj, (Type)(object)class2.e(bindingFlags, null, null, parameterModifier_), null), null, null, cultureInfo)).e((BindingFlags)class2.W(bindingFlags, array4, null, array3, parameterModifier_), (MethodBase[])(object)Class5.Default, array3, null)) * unchecked((nuint)(UIntPtr)class2.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default)) == 0)
				{
					try
					{
						_ = Class5.Default;
					}
					finally
					{
						gClass4 = (GClass3)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, array5, out object_5);
						goto end_IL_383f;
					}
				}
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass2 = (GClass1)(object)Class5.Default;
			}
			else
			{
				_ = (Class6)class2.t(null, (Type)(object)Class5.Default, cultureInfo);
			}
			end_IL_383f:;
		}
		finally
		{
			try
			{
				struct2 = struct2;
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				do
				{
					class22 = null;
					Class7 class61 = class2;
					Class7 class62 = class2;
					BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_11 = (MethodBase[])(object)((Class7)(object)class2.t(default(BindingFlags), array2, obj, (CultureInfo)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null))).t(default(BindingFlags), array2, obj, (CultureInfo)(object)class2.j(default(BindingFlags), array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)Class5.Default)));
					Type[] type_5 = array3;
					Class7 class63 = class2;
					MethodBase[] methodBase_12 = array;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class61.W(default(BindingFlags), (PropertyInfo[])(object)((Class7)(object)class62.e(bindingFlags_36, methodBase_11, type_5, (ParameterModifier[])(object)class63.j(default(BindingFlags), methodBase_12, ref *(object[]*)((Class7)null).j(bindingFlags, array, ref reference, parameterModifier_, cultureInfo, array5, out *(object*)class2.j(bindingFlags, array, ref reference, parameterModifier_, cultureInfo, null, out object_5)), parameterModifier_, null, (string[])(object)Class5.Default, out object_5))).W(bindingFlags, array4, null, array3, null), type, array3, parameterModifier_);
					_003CModule_003E = _003CModule_003E;
				}
				while ((object)Class5.Default != null);
				goto IL_3b57;
			}
		}
		IL_2b3b:
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		finally
		{
			try
			{
				struct2 = default(Struct2);
				struct2 = struct2;
			}
			catch
			{
				while (obj != null)
				{
					class24 = class24;
				}
			}
			goto IL_2b73;
		}
		IL_0aed:
		try
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, array4, type, (Type[])null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass4 = null;
				}
				while (obj != null);
			}
		}
		finally
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, null, array5, out object_5);
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (Class4)(object)Class5.Default;
				}
				goto IL_0b82;
			}
		}
		IL_0b82:
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		catch
		{
			Class7 class64 = class2;
			BindingFlags bindingFlags_37 = (BindingFlags)Class5.Default;
			Class7 class65 = class2;
			Class7 class66 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class64.j(bindingFlags_37, (MethodBase[])(object)class65.W((BindingFlags)class66.W(bindingFlags, null, null, array3, parameterModifier_), array4, type, array3, null), ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, array5, out object_5) == (UIntPtr)(nuint)0u)
			{
				try
				{
					@class = (Class10)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
					gClass4 = null;
					_ = (Qk7)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, null, null, out object_5);
				}
				catch
				{
					class15 = class15;
				}
			}
		}
		do
		{
			if ((UIntPtr)class2.t(obj, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				Class7 obj68 = (Class7)(object)Class5.Default;
				Class7 class67 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj68.j(default(BindingFlags), (MethodBase[])(object)class67.e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])(object)Class5.Default), array, (Type[])((Class7)(object)((Class7)((Class7)(object)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default)).t(Class5.Default, (Type)(object)Class5.Default, null)).W(bindingFlags, array4, type, array3, parameterModifier_)).t(null, null, (CultureInfo)(object)Class5.Default), parameterModifier_), ref reference, parameterModifier_, cultureInfo, array5, out *(object*)null);
			}
		}
		while (obj != null);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
				Class7 class68 = class2;
				BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_3 = array4;
				Type type_6 = (Type)(object)Class5.Default;
				Class7 class69 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class68.W(bindingFlags_38, propertyInfo_3, type_6, (Type[])(object)class69.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_), null);
				gClass4 = (GClass3)(object)class2.j((BindingFlags)((Class7)null).t(obj, type, cultureInfo), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array5, out *(object*)null);
				class8 = null;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				goto IL_0e7c;
			}
		}
		while ((object)Class5.Default != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				class15 = null;
				class22 = class22;
				@class = (Class10)(object)Class5.Default;
				class12 = class12;
			}
		}
		goto IL_0e7c;
		IL_24a5:
		try
		{
			while (true)
			{
				Class7 class70 = class2;
				bindingFlags = default(BindingFlags);
				if ((object)class70.W(bindingFlags, array4, type, (Type[])(object)Class5.Default, null) != null)
				{
					while ((object)Class5.Default != null)
					{
						struct2 = struct2;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			try
			{
				gClass4 = gClass4;
			}
			catch
			{
				class17 = class17;
			}
			finally
			{
				try
				{
					Class7 class71 = class2;
					Class7 class72 = class2;
					BindingFlags bindingFlags_39 = (BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null);
					ref object[] object_14 = ref reference;
					Class7 class73 = class2;
					Type type_7 = type;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class71.j((BindingFlags)class72.j(bindingFlags_39, null, ref object_14, (ParameterModifier[])class73.t(null, type_7, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])null)), cultureInfo, null, out *(object*)null), array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
				}
				finally
				{
					_ = (GClass3)(object)Class5.Default;
					goto IL_267e;
				}
			}
		}
		IL_2fdc:
		Class7 obj70 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_40 = bindingFlags;
		MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
		Class7 class74 = class2;
		BindingFlags bindingFlags_41 = bindingFlags;
		Class7 class75 = class2;
		BindingFlags bindingFlags_42 = bindingFlags;
		MethodBase[] methodBase_14 = (MethodBase[])class2.t(obj, type, cultureInfo);
		string[] string_3 = array5;
		Class7 obj71 = (Class7)(object)class2.j(default(BindingFlags), array, ref reference, null, cultureInfo, array5, out object_5);
		bindingFlags = default(BindingFlags);
		Class7 obj72 = (Class7)(object)class74.j(bindingFlags_41, (MethodBase[])(object)class75.j(bindingFlags_42, methodBase_14, ref *(object[]*)null, parameterModifier_, null, string_3, out *(object*)obj71.W(bindingFlags, array4, type, (Type[])class2.t(obj, type, (CultureInfo)(object)class2.t(bindingFlags, array2, class2.t((BindingFlags)Class5.Default, array2, obj, null), cultureInfo)), parameterModifier_)), ref reference, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_5);
		BindingFlags bindingFlags_43 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
		Class7 class76 = class2;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)obj70.j(bindingFlags_40, methodBase_13, ref *(object[]*)obj72.W(bindingFlags_43, propertyInfo_4, (Type)(object)class76.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default), array3, parameterModifier_), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null), null, out object_5);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			Class7 class77 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class77.W(bindingFlags, (PropertyInfo[])(object)class2.W(bindingFlags, array4, type, array3, (ParameterModifier[])(object)class2.t((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array4, null, array3, parameterModifier_)).t(Class5.Default, type, cultureInfo), (FieldInfo[])(object)class2.t(bindingFlags, array2, null, cultureInfo), obj, (CultureInfo)(object)Class5.Default)), (Type)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				catch
				{
					class22 = class22;
				}
			}
			else
			{
				while (((Class7)null).t((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, (ParameterModifier[])null), (Type)null, cultureInfo) != null)
				{
					gClass4 = gClass4;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					class22 = class22;
					_ = (Struct2)((Class7)null).t((object)Class5.Default, type, cultureInfo);
				}
				else
				{
					class2 = null;
				}
			}
		}
		qk = qk;
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		finally
		{
			try
			{
				_ = (Struct2)Class5.Default;
				_ = (Class10)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, null);
			}
			catch
			{
				do
				{
					class24 = null;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_3393;
		}
	}

	unsafe static void Xa9()
	{
		GClass3 gClass = gClass;
		gClass = gClass;
		nuint num = default(UIntPtr);
		num = checked(num - num);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class25);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (num == 0)
		{
			Class7 obj = (Class7)(object)Class5.Default;
			Class7 class2 = @class;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = null;
			FieldInfo[] fieldInfo_ = array;
			obj2 = null;
			BindingFlags bindingFlags_2 = (BindingFlags)class2.t(bindingFlags_, fieldInfo_, obj2, null);
			Class7 class3 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class4 = @class;
			BindingFlags bindingFlags_4 = bindingFlags;
			array2 = array2;
			MethodBase[] methodBase_ = array2;
			Class7 class5 = @class;
			BindingFlags bindingFlags_5 = bindingFlags;
			ref object[] object_ = ref reference;
			CultureInfo cultureInfo_ = (CultureInfo)(object)Class5.Default;
			array3 = array3;
			Class7 obj3 = (Class7)(object)class5.j(bindingFlags_5, null, ref object_, null, cultureInfo_, array3, out *(object*)Class5.Default);
			BindingFlags bindingFlags_6 = bindingFlags;
			PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
			type = type;
			Type type_ = type;
			BindingFlags bindingFlags_7 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_2 = array2;
			ref object[] object_2 = ref reference;
			cultureInfo = cultureInfo;
			array4 = (Type[])(object)((Class7)null).j(bindingFlags_7, methodBase_2, ref object_2, (ParameterModifier[])null, cultureInfo, array3, out *(object*)null);
			Type[] type_2 = array4;
			Class7 class6 = @class;
			BindingFlags bindingFlags_8 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
			ref object[] object_3 = ref reference;
			ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
			CultureInfo cultureInfo_2 = cultureInfo;
			string[] string_ = (string[])@class.t(obj2, (Type)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, (ParameterModifier[])@class.t(obj2, null, null)), null);
			BindingFlags bindingFlags_9 = bindingFlags;
			MethodBase[] methodBase_4 = array2;
			ref object[] object_4 = ref reference;
			array5 = array5;
			ParameterModifier[] parameterModifier_2 = array5;
			Class7 class7 = @class;
			BindingFlags bindingFlags_10 = (BindingFlags)Class5.Default;
			array6 = (PropertyInfo[])(object)Class5.Default;
			PropertyInfo[] propertyInfo_2 = array6;
			Class7 class8 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_11 = bindingFlags;
			Class7 class9 = @class;
			BindingFlags bindingFlags_12 = bindingFlags;
			MethodBase[] methodBase_5 = (MethodBase[])(object)@class.t(bindingFlags, array, obj2, null);
			CultureInfo cultureInfo_3 = cultureInfo;
			string[] string_2 = array3;
			reference2 = ref reference2;
			CultureInfo cultureInfo_4 = (CultureInfo)(object)class7.W(bindingFlags_10, propertyInfo_2, null, (Type[])(object)class8.t(bindingFlags_11, (FieldInfo[])(object)class9.j(bindingFlags_12, methodBase_5, ref *(object[]*)null, null, cultureInfo_3, string_2, out reference2), obj2, cultureInfo), (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, (Type)(object)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out reference2), (CultureInfo)(object)Class5.Default));
			Class7 class10 = @class;
			Class7 class11 = @class;
			BindingFlags bindingFlags_13 = bindingFlags;
			object object_5 = Class5.Default;
			Class7 class12 = @class;
			BindingFlags bindingFlags_14 = bindingFlags;
			MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
			ParameterModifier[] parameterModifier_3 = array5;
			CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
			string[] string_3 = array3;
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			reference = ref *(object[]*)obj3.W(bindingFlags_6, propertyInfo_, type_, type_2, (ParameterModifier[])(object)class6.j(bindingFlags_8, methodBase_3, ref object_3, parameterModifier_, cultureInfo_2, string_, out *(object*)((Class7)null).j(bindingFlags_9, methodBase_4, ref object_4, parameterModifier_2, cultureInfo_4, (string[])(object)class10.t((BindingFlags)class11.t(bindingFlags_13, null, object_5, (CultureInfo)(object)((Class7)(object)class12.j(bindingFlags_14, methodBase_6, ref *(object[]*)null, parameterModifier_3, cultureInfo_5, string_3, out *(object*)class13.t(bindingFlags, array, obj2, cultureInfo))).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])@class.t(null, type, cultureInfo), cultureInfo, null, out reference2)), array, obj2, cultureInfo), out *(object*)((Class7)@class.t(@class.t(obj2, type, cultureInfo), type, null)).t(default(BindingFlags), array, obj2, null))));
			ref object[] object_6 = ref reference;
			ParameterModifier[] parameterModifier_4 = array5;
			Class7 obj4 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
			Class7 obj5 = (Class7)(object)@class.W((BindingFlags)Class5.Default, null, null, array4, array5);
			bindingFlags = default(BindingFlags);
			@class = (Class7)(object)obj.t(bindingFlags_2, (FieldInfo[])(object)class3.t(bindingFlags_3, (FieldInfo[])(object)class4.j(bindingFlags_4, methodBase_, ref object_6, parameterModifier_4, (CultureInfo)(object)((Class7)(object)obj4.j(bindingFlags_15, (MethodBase[])(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, (Type)(object)obj5.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)null, null, null, null, out reference2)).j(bindingFlags, null, ref *(object[]*)null, array5, null, null, out reference2), array3, out reference2), null, cultureInfo), obj2, (CultureInfo)(object)Class5.Default);
			Class7 obj6 = (Class7)(object)@class.j(bindingFlags, array2, ref reference, array5, null, array3, out *(object*)((Class7)null).W(bindingFlags, array6, (Type)null, array4, (ParameterModifier[])(object)Class5.Default));
			BindingFlags bindingFlags_16 = bindingFlags;
			ref object[] object_7 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_5 = array5;
			string[] string_4 = array3;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_17 = bindingFlags;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			Class7 class14 = @class;
			BindingFlags bindingFlags_18 = bindingFlags;
			Type type_3 = type;
			Class7 class15 = @class;
			BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
			Class7 obj7 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
			Class7 obj8 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_21 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_9 = array2;
			ref object[] object_8 = ref reference;
			BindingFlags bindingFlags_22 = bindingFlags;
			Class7 class16 = @class;
			BindingFlags bindingFlags_23 = bindingFlags;
			MethodBase[] methodBase_10 = array2;
			Type[] type_4 = array4;
			Class7 class17 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = bindingFlags;
			Class7 class18 = @class;
			BindingFlags bindingFlags_25 = (BindingFlags)@class.e((BindingFlags)@class.j(bindingFlags, array2, ref *(object[]*)null, array5, cultureInfo, array3, out reference2), array2, null, (ParameterModifier[])(object)Class5.Default);
			MethodBase[] methodBase_11 = array2;
			ref object[] object_9 = ref *(object[]*)@class.e(default(BindingFlags), array2, array4, (ParameterModifier[])(object)@class.e(default(BindingFlags), array2, array4, array5));
			Class7 class19 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_26 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])(object)Class5.Default;
			ref object[] object_10 = ref reference;
			ParameterModifier[] parameterModifier_6 = array5;
			CultureInfo cultureInfo_6 = (CultureInfo)(object)Class5.Default;
			Class7 obj9 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_27 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)@class.t(obj2, null, cultureInfo), array2, ref reference, array5, cultureInfo, (string[])@class.t(obj2, type, null), out reference2), (Type[])null, array5), null)).j(bindingFlags, array2, ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference2);
			object object_11 = obj2;
			Class7 class20 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			BindingFlags bindingFlags_29 = bindingFlags;
			Class7 class21 = @class;
			BindingFlags bindingFlags_30 = bindingFlags;
			Type type_5 = (Type)(object)@class.t((BindingFlags)Class5.Default, null, @class.W((BindingFlags)Class5.Default, array6, type, array4, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default);
			BindingFlags bindingFlags_31 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			Class7 class22 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj10 = (Class7)(object)((Class7)null).j(bindingFlags_29, (MethodBase[])(object)class21.W(bindingFlags_30, null, type_5, (Type[])(object)((Class7)null).j(bindingFlags_31, (MethodBase[])(object)((Class7)null).t(default(BindingFlags), fieldInfo_3, (object)class22.j(bindingFlags, array2, ref reference, null, (CultureInfo)@class.t(obj2, null, cultureInfo), (string[])@class.t(Class5.Default, type, cultureInfo), out *(object*)null), (CultureInfo)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo)), ref reference, array5, (CultureInfo)null, (string[])null, out *(object*)Class5.Default), array5), ref reference, (ParameterModifier[])null, cultureInfo, array3, out reference2);
			Class7 class23 = @class;
			PropertyInfo[] propertyInfo_3 = array6;
			Class7 class24 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)obj6.j(bindingFlags_16, null, ref object_7, parameterModifier_5, null, string_4, out *(object*)((Class7)null).e(bindingFlags_17, methodBase_7, (Type[])(object)class14.W(bindingFlags_18, null, type_3, null, (ParameterModifier[])((Class7)(object)class15.W(bindingFlags_19, (PropertyInfo[])(object)obj7.e(bindingFlags_20, methodBase_8, (Type[])(object)obj8.j(bindingFlags_21, methodBase_9, ref object_8, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_22, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])(object)class16.e((BindingFlags)((Class7)null).e(bindingFlags_23, methodBase_10, type_4, (ParameterModifier[])(object)class17.j(bindingFlags_24, null, ref *(object[]*)class18.j(bindingFlags_25, methodBase_11, ref object_9, (ParameterModifier[])(object)class19.j(bindingFlags_26, methodBase_12, ref object_10, parameterModifier_6, cultureInfo_6, (string[])(object)obj9.t(bindingFlags_27, fieldInfo_2, object_11, (CultureInfo)(object)class20.t(bindingFlags_28, null, obj10.e((BindingFlags)class23.W(default(BindingFlags), propertyInfo_3, (Type)(object)class24.j(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array4, array5), ref *(object[]*)null, null, cultureInfo, array3, out *(object*)Class5.Default), array4, null), array2, (Type[])(object)Class5.Default, null), cultureInfo)), out *(object*)Class5.Default), null, array3, out reference2), array5, (CultureInfo)(object)@class.e(bindingFlags, null, array4, array5), null, out *(object*)Class5.Default)), (MethodBase[])(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array5), null, array5)), cultureInfo, (string[])(object)Class5.Default, out reference2), null), null, array4, array5)).t(null, type, (CultureInfo)(object)Class5.Default)), array5));
		}
		else
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			catch
			{
				if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					class25 = class25;
					class25 = class25;
					@struct = default(Struct1);
					@struct = default(Struct1);
					struct2 = struct2;
					struct2 = struct2;
				}
				else
				{
					_ = (Class5)(object)((Class7)null).j(bindingFlags, array2, ref reference, array5, (CultureInfo)null, array3, out reference2);
					_ = (GClass2)(object)Class5.Default;
					Qk7 qk = qk;
					qk = qk;
				}
			}
		}
		_ = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)@class.W(default(BindingFlags), array6, null, null, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)((Class7)null).t((object)null, (Type)null, cultureInfo), null, null, array3, out reference2);
		struct2 = struct2;
		_ = (Qk7)@class.t(obj2, null, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, (CultureInfo)null));
		Class0 class26 = (Class0)@class.t(obj2, (Type)(object)@class.t(default(BindingFlags), null, null, cultureInfo), cultureInfo);
		class26 = class26;
		Class7 class27 = @class;
		bindingFlags = default(BindingFlags);
		@class = (Class7)(object)class27.j(bindingFlags, array2, ref reference, null, cultureInfo, null, out reference2);
		_ = (Qk7)((Class7)(object)@class.t(bindingFlags, array, obj2, null)).t(obj2, null, null);
		if (checked(num - num) == 0)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		class25 = (Class2)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class29);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass2);
		if (num == 0)
		{
			while (obj2 != null)
			{
				GClass2 obj12 = (GClass2)(object)@class.W(default(BindingFlags), null, null, array4, array5);
				gClass2 = null;
				gClass2 = obj12;
				bindingFlags = default(BindingFlags);
				Class7 obj13 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array5);
				BindingFlags bindingFlags_32 = bindingFlags;
				Class7 obj14 = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_4 = array6;
				bindingFlags = default(BindingFlags);
				Type type_6 = (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
				Type[] type_7 = (Type[])(object)Class5.Default;
				Class7 class28 = @class;
				BindingFlags bindingFlags_34 = bindingFlags;
				bindingFlags = default(BindingFlags);
				class25 = (Class2)(object)obj13.W((BindingFlags)((Class7)null).j(bindingFlags_32, (MethodBase[])null, ref *(object[]*)obj14.W(bindingFlags_33, propertyInfo_4, type_6, type_7, (ParameterModifier[])(object)((Class7)(object)class28.j(bindingFlags_34, (MethodBase[])(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, array, obj2, null), null, array3, out *(object*)null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, (ParameterModifier[])(object)Class5.Default)), (ParameterModifier[])null, cultureInfo, array3, out reference2), array6, type, (Type[])@class.t(null, type, cultureInfo), null);
			}
		}
		else
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class8 obj15 = (Class8)(object)Class5.Default;
					class29 = class29;
					class29 = obj15;
				}
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class30);
		while (obj2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class30 = class30;
				class30 = class30;
			}
			else
			{
				while (obj2 != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		UIntPtr num2 = (UIntPtr)((Class7)(object)@class.W(bindingFlags, null, type, array4, array5)).j((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array5, null, null, out reference2);
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) * num - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, null, type, array4, array5)) == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
			else if (num == 0)
			{
				try
				{
					_ = (Class7)(object)@class.W(bindingFlags, array6, null, null, null);
				}
				catch
				{
					gClass = (GClass3)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class33);
		GClass0 gClass3;
		try
		{
			gClass3 = (GClass0)(object)Class5.Default;
			gClass3 = gClass3;
			_ = (Class5)(object)((Class7)((Class7)(object)Class5.Default).t(obj2, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, null, null), (Type[])(object)Class5.Default, (ParameterModifier[])null))).j(bindingFlags, array2, ref reference, null, cultureInfo, (string[])((Class7)null).t(obj2, (Type)null, cultureInfo), out *(object*)null);
		}
		catch
		{
			while (true)
			{
				Class7 class31 = @class;
				BindingFlags bindingFlags_35 = bindingFlags;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)((Class7)null).t((object)class31.j((BindingFlags)((Class7)null).j(bindingFlags_35, (MethodBase[])(object)class32.j(bindingFlags, array2, ref reference, array5, null, array3, out reference2), ref reference, array5, cultureInfo, array3, out reference2), array2, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out reference2), (Type)(object)Class5.Default, cultureInfo)).W(bindingFlags, array6, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default) != null)
				{
					Class6 obj17 = (Class6)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null);
					bindingFlags = default(BindingFlags);
					class33 = (Class6)(object)((Class7)null).W(bindingFlags, array6, (Type)(object)@class.W(bindingFlags, array6, type, array4, array5), (Type[])null, array5);
					class33 = obj17;
					continue;
				}
				break;
			}
		}
		finally
		{
			if (num == 0)
			{
				class30 = class30;
			}
			goto IL_11b7;
		}
		IL_3588:
		try
		{
			try
			{
				while (true)
				{
					Class7 obj19 = (Class7)(object)@class.t(bindingFlags, null, obj2, cultureInfo);
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)(object)obj19.W(bindingFlags, null, null, array4, (ParameterModifier[])@class.t(Class5.Default, null, cultureInfo))).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, null, type, array4, null), ref reference, array5, (CultureInfo)(object)Class5.Default, array3, out reference2), array4, null) != null)
					{
						Qk7 qk = (Qk7)(object)Class5.Default;
						Class7 obj20 = (Class7)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)Class5.Default);
						BindingFlags bindingFlags_36 = bindingFlags;
						bindingFlags = default(BindingFlags);
						_ = (Class7)(object)obj20.e(bindingFlags_36, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), (Type[])(object)Class5.Default, array5);
						struct2 = (Struct2)((Class7)null).t(obj2, type, cultureInfo);
						_ = (Class6)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					Class7 class34 = @class;
					BindingFlags bindingFlags_37 = bindingFlags;
					Class7 obj21 = (Class7)(object)Class5.Default;
					Class7 class35 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class34.e(bindingFlags_37, (MethodBase[])obj21.t(class35.t(bindingFlags, null, null, cultureInfo), (Type)(object)Class5.Default, cultureInfo), (Type[])(object)Class5.Default, array5);
				}
				goto end_IL_3589;
			}
			end_IL_3589:;
		}
		finally
		{
			Class7 class36 = @class;
			Class7 class37 = @class;
			bindingFlags = default(BindingFlags);
			object object_12 = ((Class7)(object)class37.e(bindingFlags, null, (Type[])(object)Class5.Default, array5)).e(bindingFlags, null, array4, array5);
			Class7 obj22 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_38 = bindingFlags;
			PropertyInfo[] propertyInfo_5 = array6;
			Type type_8 = type;
			MethodBase[] methodBase_13 = array2;
			ref object[] object_13 = ref reference;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)class36.t(object_12, null, (CultureInfo)((Class7)(object)((Class7)(object)obj22.W(bindingFlags_38, propertyInfo_5, type_8, (Type[])(object)((Class7)(object)((Class7)null).j(default(BindingFlags), methodBase_13, ref object_13, (ParameterModifier[])null, (CultureInfo)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo), (string[])(object)Class5.Default, out *(object*)null)).e(bindingFlags, array2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array5)).e((BindingFlags)Class5.Default, array2, array4, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array, null, (CultureInfo)(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array5, (CultureInfo)(object)Class5.Default, array3, out *(object*)null)))).t(obj2, null, cultureInfo))).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array5) == (UIntPtr)(nuint)0u)
			{
				UIntPtr num3 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if (checked(unchecked((nuint)num3) - num) == 0)
				{
					Class7 class38 = @class;
					Class7 class39 = @class;
					BindingFlags bindingFlags_39 = bindingFlags;
					Class7 class40 = @class;
					Class7 class41 = @class;
					Class7 class42 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					object object_14 = obj2;
					Class7 class43 = @class;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_41 = (BindingFlags)class41.e((BindingFlags)class42.t(bindingFlags_40, null, object_14, (CultureInfo)(object)class43.e((BindingFlags)class44.W(bindingFlags, array6, type, array4, null), null, array4, (ParameterModifier[])(object)Class5.Default)), (MethodBase[])(object)@class.W(bindingFlags, array6, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, null), (CultureInfo)(object)Class5.Default)), null, array5);
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class38.j((BindingFlags)class39.W(bindingFlags_39, (PropertyInfo[])(object)class40.e(bindingFlags_41, (MethodBase[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo)).e((BindingFlags)Class5.Default, null, array4, (ParameterModifier[])(object)Class5.Default), array4, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default), array2, ref reference, array5, null, array3, out *(object*)null);
				}
			}
			else
			{
				do
				{
					_ = (Class6)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo)).t(obj2, type, cultureInfo);
					Class7 obj23 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_42 = bindingFlags;
					FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
					Class7 obj24 = (Class7)(object)Class5.Default;
					Class7 class45 = @class;
					bindingFlags = default(BindingFlags);
					ref object[] object_15 = ref *(object[]*)class45.W(bindingFlags, null, (Type)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo), (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array2, null, null), Class5.Default, null), array5);
					ParameterModifier[] parameterModifier_7 = array5;
					Class7 obj25 = (Class7)(object)Class5.Default;
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj23.t(bindingFlags_42, fieldInfo_4, obj24.j(default(BindingFlags), null, ref object_15, parameterModifier_7, (CultureInfo)(object)obj25.e((BindingFlags)class46.W(bindingFlags, array6, type, array4, array5), array2, array4, array5), array3, out reference2), null);
					_ = (Class5)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, null, array5);
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					class26 = (Class0)(object)class47.j(bindingFlags, array2, ref reference, array5, cultureInfo, array3, out reference2);
				}
				while (obj2 != null);
			}
			goto IL_3c32;
		}
		IL_50ea:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class48);
		try
		{
			try
			{
				_ = (Struct1)Class5.Default;
				struct2 = (Struct2)((Class7)(object)Class5.Default).t(obj2, (Type)(object)@class.e(bindingFlags, null, array4, (ParameterModifier[])(object)Class5.Default), cultureInfo);
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass1)(object)Class5.Default;
				}
				else
				{
					class48 = null;
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = Class5.Default;
				}
				finally
				{
					class25 = null;
					goto end_IL_5170;
				}
				end_IL_5170:;
			}
			catch
			{
				@struct = @struct;
			}
		}
		do
		{
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class49.j(bindingFlags, array2, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array6, (Type)(object)Class5.Default, array4, array5), out reference2) != (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				checked
				{
					if (num + unchecked(num / num) == 0)
					{
						_ = (Qk7)@class.t(Class5.Default, type, null);
						@struct = default(Struct1);
					}
				}
			}
			else if (num == 0)
			{
				gClass = (GClass3)(object)Class5.Default;
				_ = (Class7)(object)Class5.Default;
				_ = (Class6)(object)@class.t(bindingFlags, array, obj2, null);
			}
			else
			{
				class29 = class29;
			}
		}
		while (obj2 != null);
		class29 = class29;
		Class7 obj30;
		BindingFlags bindingFlags_43;
		ref object[] object_16;
		ParameterModifier[] parameterModifier_8;
		CultureInfo cultureInfo_7;
		string[] string_5;
		BindingFlags bindingFlags_44;
		Class7 class53;
		Class7 class54;
		object object_17;
		BindingFlags bindingFlags_45;
		do
		{
			try
			{
				@struct = @struct;
			}
			catch
			{
				Class7 class50 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class50.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(obj2, type, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj2, cultureInfo)), (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array5), null);
			}
			Class7 class51 = @class;
			Class7 class52 = @class;
			bindingFlags = default(BindingFlags);
			obj30 = (Class7)(object)((Class7)(object)class51.e(default(BindingFlags), null, (Type[])((Class7)null).t((object)class52.j(bindingFlags, array2, ref reference, array5, cultureInfo, array3, out *(object*)Class5.Default), type, (CultureInfo)(object)Class5.Default), null)).e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, null, array4, null), array4, null);
			bindingFlags_43 = bindingFlags;
			object_16 = ref reference;
			parameterModifier_8 = (ParameterModifier[])(object)Class5.Default;
			cultureInfo_7 = cultureInfo;
			string_5 = array3;
			bindingFlags_44 = (BindingFlags)@class.t(bindingFlags, array, null, cultureInfo);
			class53 = @class;
			class54 = @class;
			object_17 = obj2;
			bindingFlags_45 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj30.j(bindingFlags_43, null, ref object_16, parameterModifier_8, cultureInfo_7, string_5, out *(object*)((Class7)null).t(bindingFlags_44, (FieldInfo[])(object)class53.W((BindingFlags)class54.t(object_17, (Type)(object)((Class7)null).W(bindingFlags_45, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array5), (Type)(object)Class5.Default, array4, (ParameterModifier[])null), cultureInfo), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, null), (object)null, (CultureInfo)(object)@class.W(bindingFlags, array6, type, array4, (ParameterModifier[])(object)Class5.Default))) != null);
		class29 = class29;
		try
		{
			try
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass2)(object)((Class7)(object)((Class7)((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo)).e((BindingFlags)Class5.Default, (MethodBase[])@class.t(((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), array2, array4, (ParameterModifier[])(object)Class5.Default), type, cultureInfo), (Type[])(object)@class.e(bindingFlags, array2, array4, null), null)).t(bindingFlags, array, obj2, (CultureInfo)(object)((Class7)null).W((BindingFlags)Class5.Default, array6, (Type)null, (Type[])(object)Class5.Default, array5));
				}
			}
			catch
			{
				_ = (GClass2)(object)@class.W(bindingFlags, array6, type, array4, null);
			}
		}
		catch
		{
			_ = (Class9)(object)((Class7)null).W(bindingFlags, array6, type, array4, (ParameterModifier[])null);
		}
		Class7 obj34 = (Class7)(object)@class.e(bindingFlags, array2, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array3, out reference2), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj2, cultureInfo));
		BindingFlags bindingFlags_46 = bindingFlags;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)obj34.t(null, (Type)(object)((Class7)null).t((BindingFlags)((Class7)null).j(bindingFlags_46, (MethodBase[])null, ref *(object[]*)((Class7)null).e(bindingFlags, array2, array4, array5), (ParameterModifier[])(object)Class5.Default, (CultureInfo)@class.t(Class5.Default, (Type)(object)Class5.Default, null), array3, out reference2), (FieldInfo[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), obj2, cultureInfo), null);
		class48 = (Class10)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)null), (object)null, cultureInfo)).j((BindingFlags)@class.j((BindingFlags)Class5.Default, array2, ref reference, null, null, array3, out reference2), array2, ref reference, array5, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, cultureInfo)).j((BindingFlags)Class5.Default, array2, ref reference, null, cultureInfo, array3, out *(object*)Class5.Default)).W((BindingFlags)Class5.Default, array6, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array5), obj2, null), null, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, null), out *(object*)Class5.Default), array3, out *(object*)@class.t(null, type, cultureInfo)), (CultureInfo)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array5, cultureInfo, array3, out *(object*)null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array5));
		try
		{
			while (true)
			{
				if (obj2 != null)
				{
					_ = (Qk7)(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), (PropertyInfo[])@class.t(obj2, null, cultureInfo), null, null, null);
					gClass = gClass;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (checked(num + num) == 0)
		{
			do
			{
				if (num == 0)
				{
					@struct = @struct;
					_ = (GClass1)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			while (obj2 != null);
			goto IL_5b33;
		}
		try
		{
			BindingFlags bindingFlags_47 = (BindingFlags)((Class7)null).j(bindingFlags, array2, ref reference, array5, cultureInfo, (string[])(object)@class.j(bindingFlags, array2, ref *(object[]*)null, array5, (CultureInfo)(object)Class5.Default, array3, out reference2), out reference2);
			FieldInfo[] fieldInfo_5 = array;
			object object_18 = obj2;
			BindingFlags bindingFlags_48 = (BindingFlags)@class.e(bindingFlags, array2, null, array5);
			Class7 class55 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags_47, fieldInfo_5, object_18, (CultureInfo)(object)((Class7)null).W(bindingFlags_48, (PropertyInfo[])null, (Type)null, (Type[])(object)class55.W(bindingFlags, array6, type, (Type[])(object)@class.t((BindingFlags)@class.W((BindingFlags)Class5.Default, array6, (Type)(object)Class5.Default, null, array5), array, Class5.Default, null), array5), array5)) == (UIntPtr)(nuint)0u)
			{
				gClass3 = null;
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_003CModule_003E = (_003CModule_003E)(object)@class.W(bindingFlags, null, null, null, array5);
			}
			goto IL_5b33;
		}
		IL_4b1d:
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
			class29 = class29;
		}
		class33 = class33;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class57);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class56);
		try
		{
			class30 = class30;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class56 = Class5.Default;
				}
				catch
				{
					class57 = class57;
				}
			}
		}
		do
		{
			_ = (Struct2)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array3, out *(object*)null);
		}
		while (obj2 != null);
		try
		{
			class26 = class26;
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				while (obj2 != null)
				{
					Qk7 qk = (Qk7)(object)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array3, out reference2), cultureInfo, (string[])(object)Class5.Default, out reference2);
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			nuint num4 = num;
			num = default(UIntPtr);
			if (checked(num4 - num) == 0)
			{
				try
				{
					class25 = class25;
				}
				catch
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			else
			{
				_ = (Struct1)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo));
			}
		}
		catch
		{
			if (num == 0)
			{
				Class7 obj40 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_49 = bindingFlags;
				FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
				object object_19 = obj2;
				Class7 obj41 = (Class7)(object)Class5.Default;
				Class7 class58 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)obj40.t(bindingFlags_49, fieldInfo_6, object_19, (CultureInfo)(object)((Class7)(object)obj41.j((BindingFlags)class58.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, null), array2, ref reference, array5, null, array3, out reference2)).t(bindingFlags, array, obj2, null));
			}
		}
		num = default(UIntPtr);
		if (checked(num + num) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, array5)) == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo);
				}
				else
				{
					struct2 = struct2;
				}
			}
			else
			{
				gClass3 = gClass3;
			}
		}
		while ((object)Class5.Default != null)
		{
			do
			{
				class30 = null;
			}
			while (obj2 != null);
		}
		UIntPtr num5 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		checked
		{
			nuint num6 = unchecked((nuint)default(UIntPtr)) - unchecked(checked(unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)num5) + num)) / checked(num + num));
			num = default(UIntPtr);
			if (num6 - num == 0)
			{
				try
				{
					try
					{
						_ = (Class9)(object)@class.W(default(BindingFlags), array6, type, (Type[])(object)Class5.Default, null);
					}
					finally
					{
						struct2 = struct2;
						goto end_IL_4e85;
					}
					end_IL_4e85:;
				}
				catch
				{
					try
					{
						_ = (Class4)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, (object)null, cultureInfo);
					}
					finally
					{
						_ = (Class10)(object)unchecked(@class.j((BindingFlags)@class.t(@class.t(null, type, cultureInfo), null, null), array2, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out *(object*)null));
						goto end_IL_4ec7;
					}
					end_IL_4ec7:;
				}
			}
			else
			{
				_ = (Qk7)(object)((Class7)null).e(bindingFlags, array2, array4, (ParameterModifier[])null);
			}
			class25 = class25;
			Class7 class59 = @class;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)class59.j(bindingFlags, null, ref reference, array5, cultureInfo, array3, out reference2);
		}
		try
		{
			try
			{
				class29 = class29;
			}
			catch
			{
				_ = (Class0)(object)@class.j(bindingFlags, array2, ref *(object[]*)((Class7)null).t(obj2, (Type)null, cultureInfo), array5, cultureInfo, array3, out *(object*)Class5.Default);
				_ = (Struct1)@class.W(bindingFlags, array6, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)@class.e(bindingFlags, null, null, array5));
			}
			finally
			{
				_ = (Struct2)@class.t(bindingFlags, array, ((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, obj2, cultureInfo), type, null, array5)).t((BindingFlags)Class5.Default, array, obj2, null), array4, (ParameterModifier[])null), (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array2, array4, array5));
				goto end_IL_4f92;
			}
			end_IL_4f92:;
		}
		finally
		{
			if (num == 0)
			{
				class56 = null;
			}
			goto IL_50ea;
		}
		IL_34f0:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		try
		{
			nuint num7 = num;
			Class7 class60 = @class;
			bindingFlags = default(BindingFlags);
			if (num7 / (nuint)(UIntPtr)class60.t(bindingFlags, null, obj2, cultureInfo) == 0)
			{
				gClass4 = null;
			}
			else
			{
				nuint num8 = num;
				num = default(UIntPtr);
				if (num8 / num == 0)
				{
					_ = (Class4)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj2, type, null), null, cultureInfo)).t(bindingFlags, null, null, cultureInfo);
				}
			}
		}
		finally
		{
			gClass4 = gClass4;
			goto IL_3588;
		}
		IL_1a89:
		do
		{
			try
			{
				do
				{
					_ = (Class4)@class.t(obj2, null, cultureInfo);
					class29 = null;
					class57 = class57;
				}
				while (obj2 != null);
			}
			finally
			{
				class30 = null;
				continue;
			}
		}
		while (obj2 != null);
		do
		{
			object object_20 = obj2;
			BindingFlags bindingFlags_50 = bindingFlags;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_14 = (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
			ref object[] object_21 = ref reference;
			Class7 class61 = @class;
			BindingFlags bindingFlags_51 = (BindingFlags)@class.j((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, array6, type, array4, (ParameterModifier[])null), array2, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
			PropertyInfo[] propertyInfo_6 = array6;
			Type type_9 = type;
			Type[] type_10 = (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array5);
			BindingFlags bindingFlags_52 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_15 = (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array5), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			ref object[] object_22 = ref *(object[]*)@class.t(obj2, type, cultureInfo);
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			ParameterModifier[] parameterModifier_9 = (ParameterModifier[])class61.t(((Class7)null).W(bindingFlags_51, propertyInfo_6, type_9, type_10, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_52, methodBase_15, ref object_22, (ParameterModifier[])null, (CultureInfo)(object)class62.j(bindingFlags, array2, ref reference, array5, cultureInfo, array3, out *(object*)null), (string[])null, out *(object*)@class.t(bindingFlags, array, null, cultureInfo))), null, (CultureInfo)(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)@class.t(default(BindingFlags), null, Class5.Default, null), type, array4, null));
			Class7 class63 = @class;
			BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
			ref object[] object_23 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_10 = array5;
			Class7 class64 = @class;
			BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_16 = (MethodBase[])(object)Class5.Default;
			ref object[] object_24 = ref reference;
			Class7 class65 = @class;
			PropertyInfo[] propertyInfo_7 = array6;
			Type type_11 = type;
			Class7 class66 = @class;
			bindingFlags = default(BindingFlags);
			class29 = (Class8)(object)((Class7)((Class7)null).t(object_20, (Type)(object)((Class7)null).j(bindingFlags_50, methodBase_14, ref object_21, parameterModifier_9, (CultureInfo)(object)class63.W((BindingFlags)((Class7)null).j(bindingFlags_53, (MethodBase[])null, ref object_23, parameterModifier_10, (CultureInfo)(object)((Class7)(object)class64.j(bindingFlags_54, methodBase_16, ref object_24, (ParameterModifier[])(object)class65.t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).W(default(BindingFlags), propertyInfo_7, type_11, (Type[])(object)class66.e(bindingFlags, array2, (Type[])(object)Class5.Default, null), (ParameterModifier[])null), null, null), cultureInfo, array3, out reference2)).t(bindingFlags, null, null, cultureInfo), array3, out reference2), null, type, array4, null), (string[])null, out reference2), (CultureInfo)null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2);
		}
		while (obj2 != null);
		try
		{
			do
			{
				try
				{
					gClass3 = (GClass0)(object)Class5.Default;
				}
				finally
				{
					_ = (Class10)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W((BindingFlags)Class5.Default, array6, (Type)null, (Type[])null, array5), type, (Type[])(object)Class5.Default, array5);
					_ = (Struct2)Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			try
			{
				while (true)
				{
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)class67.W(bindingFlags, array6, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo), (Type[])(object)((Class7)@class.t(obj2, type, null)).W(bindingFlags, array6, null, null, null), array5) != null)
					{
						gClass3 = null;
						continue;
					}
					break;
				}
			}
			catch
			{
				try
				{
					class29 = class29;
					goto end_IL_1ee7;
				}
				finally
				{
					Class7 obj45 = (Class7)(object)@class.e(bindingFlags, (MethodBase[])@class.t(obj2, null, cultureInfo), (Type[])(object)Class5.Default, array5);
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj45.t((BindingFlags)((Class7)(object)class68.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, array, obj2, cultureInfo), (ParameterModifier[])null), array3, out *(object*)null)).e(bindingFlags, array2, array4, (ParameterModifier[])(object)((Class7)(object)@class.j(bindingFlags, array2, ref reference, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)null)).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default)), null, null, cultureInfo);
					goto end_IL_1ee7;
				}
				end_IL_1ee7:;
			}
		}
		while (true)
		{
			Class7 class69 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class69.t(bindingFlags, null, obj2, cultureInfo) != null)
			{
				_ = (Class8)(object)@class.j((BindingFlags)@class.t(obj2, null, (CultureInfo)(object)Class5.Default), array2, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)@class.e(bindingFlags, array2, (Type[])(object)@class.t(bindingFlags, array, null, (CultureInfo)(object)@class.e(default(BindingFlags), array2, array4, array5)), (ParameterModifier[])(object)Class5.Default), out *(object*)((Class7)(object)Class5.Default).t(null, type, null));
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		if (num == (UIntPtr)(nuint)0u && (UIntPtr)((Class7)(object)Class5.Default).t(null, null, cultureInfo) == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			struct2 = default(Struct2);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class26 = class26;
			goto IL_231f;
		}
		try
		{
			_ = (GClass1)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, (Type[])@class.t(null, type, null), array5);
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
			else
			{
				_ = (Class2)(object)Class5.Default;
			}
			goto IL_231f;
		}
		IL_5bd1:
		class25 = null;
		class30 = class30;
		class25 = class25;
		try
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				goto end_IL_5be6;
			}
			end_IL_5be6:;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array5);
					continue;
				}
				Class7 class70 = @class;
				bindingFlags = default(BindingFlags);
				class48 = (Class10)(object)class70.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array5);
			}
			while (obj2 != null);
		}
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num * unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array6, null, null, null) / num) != 0)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null || (object)Class5.Default != null);
			while (true)
			{
				Class7 class71 = @class;
				BindingFlags bindingFlags_55 = bindingFlags;
				Class7 class72 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class71.j(bindingFlags_55, (MethodBase[])(object)class72.t(bindingFlags, null, obj2, cultureInfo), ref *unchecked((object[]*)Class5.Default), array5, cultureInfo, (string[])(object)Class5.Default, out reference2) == null)
				{
					break;
				}
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - num * unchecked(num / (nuint)(UIntPtr)Class5.Default) == 0)
				{
					_ = (GClass1)@class.t(null, null, cultureInfo);
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class25 = class25;
				}
				catch
				{
					class56 = null;
					_ = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					class29 = null;
				}
			}
			else
			{
				try
				{
					class57 = class57;
				}
				catch
				{
					class26 = (Class0)(object)@class.j(default(BindingFlags), array2, ref reference, array5, cultureInfo, array3, out *(object*)null);
					_ = (Qk7)(object)Class5.Default;
					@struct = @struct;
				}
			}
		}
		finally
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				goto IL_5e36;
			}
		}
		IL_46fc:
		try
		{
			while (obj2 != null)
			{
				class57 = class57;
				@class = @class;
				_ = (Class6)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				_ = (GClass3)(object)@class.e(default(BindingFlags), array2, null, null);
				goto end_IL_4724;
			}
			end_IL_4724:;
		}
		finally
		{
			class29 = class29;
			goto IL_4765;
		}
		IL_5e36:
		_ = (Struct1)Class5.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + num == 0)
			{
				while (obj2 != null)
				{
					do
					{
						@struct = default(Struct1);
					}
					while ((object)Class5.Default != null);
				}
			}
			while (obj2 != null)
			{
				gClass4 = null;
			}
		}
		try
		{
			return;
		}
		catch
		{
			if (num == 0 && (nuint)(UIntPtr)Class5.Default / num == 0)
			{
				@struct = default(Struct1);
			}
			return;
		}
		IL_4765:
		_ = (Class2)(object)@class.j((BindingFlags)Class5.Default, array2, ref reference, array5, null, (string[])(object)Class5.Default, out *(object*)null);
		_ = (Class10)(object)Class5.Default;
		try
		{
			gClass3 = null;
		}
		catch
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					class56 = null;
					goto end_IL_47c8;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_47c8;
				}
				end_IL_47c8:;
			}
		}
		do
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).e(bindingFlags, array2, array4, array5) != (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
				@struct = @struct;
				gClass = gClass;
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass2)@class.t(null, type, cultureInfo);
			}
			else
			{
				class48 = class48;
			}
		}
		while (obj2 != null);
		while (obj2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class6)((Class7)null).t(((Class7)(object)@class.W((BindingFlags)@class.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array6, null, null, array5), out *(object*)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags, array6, type, array4, (ParameterModifier[])null), (MethodBase[])null, (Type[])null, array5)), null, type, array4, array5)).t(Class5.Default, null, (CultureInfo)(object)Class5.Default), type, cultureInfo);
				}
				while ((object)@class.t(bindingFlags, array, obj2, cultureInfo) != null);
			}
			else
			{
				do
				{
					struct2 = default(Struct2);
				}
				while (obj2 != null);
			}
		}
		while (true)
		{
			Class7 obj55 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_56 = bindingFlags;
			MethodBase[] methodBase_17 = (MethodBase[])(object)@class.j(bindingFlags, array2, ref *(object[]*)null, null, null, array3, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, (ParameterModifier[])(object)Class5.Default));
			Class7 obj56 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
			Class7 obj57 = (Class7)(object)@class.e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			if ((object)obj55.e(bindingFlags_56, methodBase_17, (Type[])(object)obj56.j(bindingFlags_57, (MethodBase[])(object)obj57.W(bindingFlags, array6, type, null, array5), ref reference, null, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj2, cultureInfo), array3, out *(object*)null), null) == null)
			{
				break;
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				catch
				{
					_ = (Qk7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, null, null, (string[])@class.t(obj2, null, cultureInfo), out *(object*)Class5.Default);
				}
			}
		}
		try
		{
			gClass3 = gClass3;
		}
		finally
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class25 = class25;
				}
			}
			while (obj2 != null);
			goto IL_4b1d;
		}
		IL_4058:
		num = default(UIntPtr);
		if (num == 0)
		{
			class48 = null;
			gClass2 = gClass2;
			class25 = class25;
		}
		_ = (Class0)(object)Class5.Default;
		Class7 obj59 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_58 = (BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, null, out *(object*)null), out *(object*)null), out reference2);
		FieldInfo[] fieldInfo_7 = array;
		object object_25 = ((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, null, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj2, cultureInfo), null), obj2, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array6, null, (Type[])(object)Class5.Default, null);
		Class7 class73 = @class;
		BindingFlags bindingFlags_59 = bindingFlags;
		Type[] type_12 = (Type[])(object)@class.W((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, array, obj2, null)).W(default(BindingFlags), array6, type, (Type[])(object)@class.t((BindingFlags)@class.t(obj2, type, cultureInfo), array, Class5.Default, null), array5)), type, array4, array5)).e((BindingFlags)Class5.Default, array2, null, array5), array6, null, array4, array5);
		Class7 class74 = @class;
		object object_26 = Class5.Default;
		Type type_13 = type;
		FieldInfo[] fieldInfo_8 = array;
		object object_27 = obj2;
		Class7 class75 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)obj59.t(bindingFlags_58, fieldInfo_7, object_25, (CultureInfo)(object)class73.e(bindingFlags_59, null, type_12, (ParameterModifier[])class74.t(object_26, type_13, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), fieldInfo_8, object_27, (CultureInfo)(object)((Class7)(object)((Class7)(object)class75.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null)).W(bindingFlags, array6, type, array4, null)).t(bindingFlags, array, obj2, null)))));
		while (obj2 != null)
		{
			do
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		while (obj2 != null)
		{
			_ = (Struct2)Class5.Default;
			BindingFlags bindingFlags_60 = bindingFlags;
			FieldInfo[] fieldInfo_9 = (FieldInfo[])(object)Class5.Default;
			Class7 class76 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)((Class7)null).t(bindingFlags_60, fieldInfo_9, (object)class76.e(bindingFlags, array2, array4, array5), cultureInfo);
		}
		try
		{
			try
			{
				class30 = null;
			}
			catch
			{
				Qk7 qk = null;
				_ = (Struct1)Class5.Default;
			}
		}
		catch
		{
			gClass2 = gClass2;
		}
		class25 = class25;
		if ((nuint)(UIntPtr)((Class7)null).t(obj2, (Type)(object)@class.W(bindingFlags, array6, type, array4, array5), cultureInfo) / num == 0)
		{
			BindingFlags bindingFlags_61 = bindingFlags;
			ref object[] object_28 = ref reference;
			ParameterModifier[] parameterModifier_11 = array5;
			Class7 obj62 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_62 = (BindingFlags)Class5.Default;
			Class7 obj63 = (Class7)(object)@class.W(bindingFlags, array6, null, array4, array5);
			BindingFlags bindingFlags_63 = bindingFlags;
			PropertyInfo[] propertyInfo_8 = array6;
			Type type_14 = (Type)(object)Class5.Default;
			Class7 class77 = @class;
			BindingFlags bindingFlags_64 = bindingFlags;
			Class7 class78 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)(object)((Class7)null).j(bindingFlags_61, (MethodBase[])null, ref object_28, parameterModifier_11, (CultureInfo)null, (string[])(object)obj62.W(bindingFlags_62, (PropertyInfo[])(object)obj63.W(bindingFlags_63, propertyInfo_8, type_14, (Type[])(object)class77.t(bindingFlags_64, (FieldInfo[])(object)class78.e(bindingFlags, null, array4, null), Class5.Default, (CultureInfo)(object)Class5.Default), null), (Type)(object)Class5.Default, null, array5), out reference2)).t((BindingFlags)@class.W((BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo), (PropertyInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)@class.t(obj2, type, cultureInfo)).e(bindingFlags, array2, null, array5), null, type, array4, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array2, array4, array5), null, array4, (ParameterModifier[])(object)Class5.Default), array, obj2, cultureInfo);
		}
		while (obj2 != null)
		{
			struct2 = struct2;
		}
		nuint num9 = num;
		UIntPtr num10 = (UIntPtr)@class.e((BindingFlags)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo), array2, null, null);
		num = default(UIntPtr);
		checked
		{
			nuint num11 = num9 * unchecked((nuint)num10 / num);
			nuint num12 = num;
			num = default(UIntPtr);
			if (num11 + num12 * (num + num) == 0)
			{
				do
				{
					gClass4 = gClass4;
				}
				while (obj2 != null || obj2 != null);
			}
			if (num == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
			try
			{
				try
				{
					try
					{
						_ = (GClass2)(object)@class.e(bindingFlags, null, null, array5);
					}
					finally
					{
						class30 = class30;
						goto end_IL_4636;
					}
					end_IL_4636:;
				}
				finally
				{
					try
					{
						_ = Class5.Default;
					}
					finally
					{
						_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo);
						goto end_IL_4635;
					}
				}
				end_IL_4635:;
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				_ = (Class10)((Class7)((Class7)(object)((Class7)(object)Class5.Default).t(default(BindingFlags), null, obj2, null)).t(Class5.Default, type, cultureInfo)).t(obj2, type, cultureInfo);
				goto IL_46fc;
			}
		}
		IL_231f:
		do
		{
			num = default(UIntPtr);
			if (num != (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)((Class7)null).t(obj2, type, cultureInfo);
				}
			}
			else
			{
				bindingFlags = default(BindingFlags);
				Class7 obj64 = (Class7)(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, array5, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)@class.t(bindingFlags, array, obj2, null), null, array5), array3, out *(object*)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null));
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj64.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.e((BindingFlags)Class5.Default, array2, array4, (ParameterModifier[])(object)@class.t(bindingFlags, array, null, (CultureInfo)@class.t(obj2, type, null)))).t(obj2, null, (CultureInfo)(object)Class5.Default), null, cultureInfo);
			}
		}
		while (obj2 != null);
		if (num == (UIntPtr)(nuint)0u)
		{
			class48 = class48;
			class48 = class48;
		}
		_ = (GClass0)(object)Class5.Default;
		try
		{
			num = default(UIntPtr);
			if (checked(num * ((num * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) * unchecked((nuint)(UIntPtr)Class5.Default))) == 0)
			{
				Class7 class79 = @class;
				BindingFlags bindingFlags_65 = bindingFlags;
				BindingFlags bindingFlags_66 = bindingFlags;
				FieldInfo[] fieldInfo_10 = array;
				object object_29 = obj2;
				Class7 class80 = @class;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_18 = (MethodBase[])(object)((Class7)null).t(bindingFlags_66, fieldInfo_10, object_29, (CultureInfo)(object)class80.t(bindingFlags, null, null, cultureInfo));
				ParameterModifier[] parameterModifier_12 = (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, array4, array5);
				Class7 class81 = @class;
				BindingFlags bindingFlags_67 = bindingFlags;
				ref object[] object_30 = ref reference;
				CultureInfo cultureInfo_8 = (CultureInfo)(object)Class5.Default;
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class79.j(bindingFlags_65, methodBase_18, ref *(object[]*)null, parameterModifier_12, (CultureInfo)(object)class81.j(bindingFlags_67, null, ref object_30, null, cultureInfo_8, (string[])(object)class82.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)Class5.Default, array3, out reference2), out *(object*)null), (string[])((Class7)(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)@class.W(bindingFlags, array6, null, array4, array5), cultureInfo, array3, out *(object*)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, array2, array4, (ParameterModifier[])null)).e(bindingFlags, array2, array4, null), null, null, array4, array5))).t(Class5.Default, null, cultureInfo), out *(object*)null);
				struct2 = struct2;
			}
		}
		catch
		{
			BindingFlags bindingFlags_68 = (BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo);
			MethodBase[] methodBase_19 = array2;
			ref object[] object_31 = ref reference;
			string[] string_6 = array3;
			Class7 obj65 = (Class7)(object)@class.j((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)((Class7)@class.t(obj2, type, (CultureInfo)(object)Class5.Default)).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo), cultureInfo, array3, out *(object*)@class.t(null, null, cultureInfo))), null, null), array2, ref reference, array5, null, null, out *(object*)null);
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)((Class7)null).j(bindingFlags_68, methodBase_19, ref object_31, (ParameterModifier[])null, (CultureInfo)null, string_6, out *(object*)obj65.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array5, null, null, out *(object*)null)) / unchecked((nuint)default(UIntPtr)) != 0)
			{
				try
				{
					Qk7 qk = null;
				}
				finally
				{
					gClass3 = null;
					goto end_IL_2511;
				}
			}
			class56 = class56;
			end_IL_2511:;
		}
		try
		{
			class30 = (Class4)(object)Class5.Default;
		}
		finally
		{
			while (@class.t(null, type, cultureInfo) != null)
			{
				try
				{
					gClass2 = null;
				}
				catch
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			goto IL_2698;
		}
		IL_3c32:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class56 = class56;
		}
		if (num == 0)
		{
			do
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (Struct2)((Class7)null).t((BindingFlags)((Class7)null).W((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, array3, out *(object*)@class.e(bindingFlags, array2, array4, null)), array6, type, (Type[])null, (ParameterModifier[])null), (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default);
				_ = (GClass3)(object)Class5.Default;
				gClass4 = (GClass1)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array2, null, array5);
			}
			while ((object)Class5.Default != null || obj2 != null);
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					continue;
				}
			}
		}
		try
		{
			class26 = class26;
		}
		finally
		{
			goto IL_3fe5;
		}
		IL_2698:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class29 = null;
				}
			}
			while (obj2 != null);
		}
		_ = (Class10)(object)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array5)).t(bindingFlags, array, obj2, null);
		try
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					_ = (Class9)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					_ = Class5.Default;
					gClass3 = (GClass0)(object)Class5.Default;
					gClass3 = (GClass0)(object)Class5.Default;
					gClass2 = gClass2;
					continue;
				}
				Class7 obj68 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				Class7 class83 = @class;
				object object_32 = obj2;
				Class7 obj69 = (Class7)(object)Class5.Default;
				Class7 class84 = @class;
				BindingFlags bindingFlags_69 = (BindingFlags)Class5.Default;
				Class7 class85 = @class;
				Class7 class86 = @class;
				Type type_15 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)obj68.W((BindingFlags)class83.t(default(BindingFlags), null, object_32, (CultureInfo)(object)obj69.e((BindingFlags)class84.t(bindingFlags_69, null, class85.t((BindingFlags)class86.t(null, type_15, (CultureInfo)(object)((Class7)null).e(bindingFlags, array2, array4, array5)), null, obj2, cultureInfo), (CultureInfo)(object)@class.e(bindingFlags, null, null, array5)), null, (Type[])(object)Class5.Default, array5)), array6, type, array4, null);
			}
			while (obj2 != null);
			goto IL_2893;
		}
		IL_3fe5:
		while (obj2 != null)
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
				Class7 class87 = @class;
				Class7 class88 = @class;
				BindingFlags bindingFlags_70 = bindingFlags;
				Class7 obj70 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_71 = bindingFlags;
				object object_33 = obj2;
				Class7 class89 = @class;
				BindingFlags bindingFlags_72 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_73 = bindingFlags;
				MethodBase[] methodBase_20 = (MethodBase[])(object)Class5.Default;
				Type[] type_16 = (Type[])((Class7)null).t(((Class7)(object)((Class7)(object)@class.e(bindingFlags, array2, (Type[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null)).j(bindingFlags, array2, ref *(object[]*)null, array5, cultureInfo, null, out reference2), null, obj2, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, array, obj2, null)).t(null, null, null), type, (CultureInfo)(object)Class5.Default);
				Class7 obj71 = (Class7)(object)Class5.Default;
				Type type_17 = (Type)(object)@class.W((BindingFlags)Class5.Default, array6, type, null, null);
				Class7 class90 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj72 = (Class7)(object)obj70.t(bindingFlags_71, null, object_33, (CultureInfo)(object)class89.e(bindingFlags_72, (MethodBase[])(object)((Class7)null).e(bindingFlags_73, methodBase_20, type_16, (ParameterModifier[])obj71.t(null, type_17, (CultureInfo)(object)class90.t(bindingFlags, array, obj2, null))), array4, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array6, type, array4, array5), type, array4, (ParameterModifier[])null)));
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_74 = bindingFlags;
				ref object[] object_34 = ref reference;
				ParameterModifier[] parameterModifier_13 = array5;
				CultureInfo cultureInfo_9 = (CultureInfo)(object)Class5.Default;
				Class7 class91 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class87.e((BindingFlags)class88.j(bindingFlags_70, (MethodBase[])(object)obj72.j(bindingFlags_74, null, ref object_34, parameterModifier_13, cultureInfo_9, (string[])(object)class91.j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, null, array3, out *(object*)null), ref reference, array5, null, array3, out reference2), out *(object*)Class5.Default), ref *(object[]*)Class5.Default, null, null, array3, out *(object*)null), null, array4, array5);
				gClass3 = gClass3;
			}
			finally
			{
				while (obj2 != null)
				{
					class33 = null;
				}
				continue;
			}
		}
		while (obj2 != null)
		{
			struct2 = struct2;
		}
		try
		{
			_ = (Class10)(object)((Class7)null).e((BindingFlags)Class5.Default, array2, (Type[])null, (ParameterModifier[])(object)Class5.Default);
		}
		finally
		{
			do
			{
				try
				{
					class25 = null;
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					gClass2 = null;
					gClass2 = null;
					continue;
				}
			}
			while (obj2 != null);
			goto IL_4058;
		}
		IL_5b33:
		_ = (_003CModule_003E)(object)Class5.Default;
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					struct2 = default(Struct2);
				}
			}
			finally
			{
				Qk7 qk = (Qk7)(object)Class5.Default;
				goto end_IL_5b3e;
			}
			end_IL_5b3e:;
		}
		catch
		{
			while (true)
			{
				if (obj2 != null)
				{
					_ = (Class9)(object)@class.W(bindingFlags, array6, type, null, (ParameterModifier[])(object)Class5.Default);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		try
		{
		}
		catch
		{
			while (obj2 != null)
			{
				class26 = class26;
			}
		}
		finally
		{
			_ = (Class9)(object)Class5.Default;
			goto IL_5bd1;
		}
		IL_2893:
		try
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (Class0)(object)Class5.Default;
					continue;
				}
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class92.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default) == null)
				{
					break;
				}
			}
		}
		catch
		{
			do
			{
				Class7 class93 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class93.e(bindingFlags, array2, null, array5) != (UIntPtr)(nuint)0u)
				{
					class26 = class26;
				}
				else
				{
					class30 = null;
				}
			}
			while (obj2 != null);
		}
		_ = (Struct2)Class5.Default;
		class57 = class57;
		try
		{
			try
			{
				if (checked(num * num) == 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					Class7 class94 = @class;
					object object_35 = ((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
					Type type_18 = type;
					Class7 obj76 = (Class7)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo);
					Class7 class95 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).j((BindingFlags)class94.t(object_35, type_18, (CultureInfo)(object)obj76.e((BindingFlags)class95.t(bindingFlags, null, obj2, cultureInfo), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array5)), (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass2)(object)((Class7)null).e(bindingFlags, array2, (Type[])@class.t(Class5.Default, type, cultureInfo), array5);
				}
			}
			finally
			{
				do
				{
					Class7 obj77 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_75 = bindingFlags;
					FieldInfo[] fieldInfo_11 = array;
					Class7 class96 = @class;
					Class7 class97 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_76 = (BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, array6, type, array4, array5)).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null);
					Class7 class98 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj78 = (Class7)(object)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags_76, (MethodBase[])(object)((Class7)null).t((BindingFlags)((Class7)(object)class98.t(bindingFlags, array, obj2, (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, array, Class5.Default, null)).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default))).t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default), array, obj2, cultureInfo), (Type[])null, array5), (PropertyInfo[])null, type, array4, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_77 = (BindingFlags)obj78.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array6, null, array4, null), type, array4, array5);
					FieldInfo[] fieldInfo_12 = array;
					Class7 class99 = @class;
					BindingFlags bindingFlags_78 = (BindingFlags)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo);
					MethodBase[] methodBase_21 = array2;
					BindingFlags bindingFlags_79 = bindingFlags;
					MethodBase[] methodBase_22 = (MethodBase[])(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj2, type, null), Class5.Default, null)).t(bindingFlags, null, obj2, cultureInfo);
					ref object[] object_36 = ref *(object[]*)@class.t(obj2, null, cultureInfo);
					Class7 obj79 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					ref object[] object_37 = ref *(object[]*)((Class7)null).j(bindingFlags_79, methodBase_22, ref object_36, (ParameterModifier[])(object)obj79.W(bindingFlags, array6, type, null, (ParameterModifier[])(object)Class5.Default), cultureInfo, array3, out *(object*)@class.t(obj2, type, cultureInfo));
					Class7 obj80 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_80 = (BindingFlags)Class5.Default;
					Type[] type_19 = array4;
					Class7 class100 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj81 = (Class7)(object)class100.e(bindingFlags, array2, (Type[])(object)Class5.Default, null);
					bindingFlags = default(BindingFlags);
					object object_38 = class99.j(bindingFlags_78, methodBase_21, ref object_37, null, null, (string[])(object)((Class7)(object)obj80.e(bindingFlags_80, null, type_19, (ParameterModifier[])(object)obj81.e(bindingFlags, array2, array4, null))).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array3, out *(object*)null), out reference2);
					Class7 class101 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj82 = (Class7)(object)class101.t(bindingFlags, array, null, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_81 = bindingFlags;
					MethodBase[] methodBase_23 = array2;
					ref object[] object_39 = ref *(object[]*)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, array5, cultureInfo, array3, out reference2);
					CultureInfo cultureInfo_10 = cultureInfo;
					string[] string_7 = array3;
					Class7 class102 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_82 = bindingFlags;
					Class7 obj83 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_83 = bindingFlags;
					Class7 class103 = @class;
					bindingFlags = default(BindingFlags);
					ref object[] object_40 = ref *(object[]*)obj83.t((BindingFlags)((Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags_83, (MethodBase[])(object)class103.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array2, ref *(object[]*)Class5.Default, array5, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), array3, out reference2), ref reference, (ParameterModifier[])null, (CultureInfo)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, null), array3, out *(object*)Class5.Default)).W((BindingFlags)Class5.Default, array6, null, null, null)).W(bindingFlags, array6, (Type)(object)Class5.Default, array4, null), null, obj2, null);
					Class7 class104 = @class;
					BindingFlags bindingFlags_84 = (BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array, obj2, (CultureInfo)null);
					FieldInfo[] fieldInfo_13 = array;
					object object_41 = ((Class7)(object)@class.W(bindingFlags, array6, type, array4, array5)).W(bindingFlags, array6, type, array4, array5);
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj77.t(bindingFlags_75, fieldInfo_11, class96.W((BindingFlags)class97.t(bindingFlags_77, fieldInfo_12, object_38, (CultureInfo)(object)obj82.j(bindingFlags_81, methodBase_23, ref object_39, null, cultureInfo_10, string_7, out *(object*)class102.j(bindingFlags_82, null, ref object_40, (ParameterModifier[])(object)class104.t(bindingFlags_84, fieldInfo_13, object_41, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])((Class7)null).t(obj2, type, cultureInfo), null, cultureInfo), array5)), cultureInfo, null, out reference2))), array6, type, (Type[])(object)Class5.Default, array5), (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo));
				}
				while (obj2 != null);
				goto end_IL_2935;
			}
			end_IL_2935:;
		}
		catch
		{
			_ = (Class0)(object)Class5.Default;
			class30 = (Class4)(object)@class.W(bindingFlags, null, null, array4, array5);
			class56 = Class5.Default;
		}
		Class7 class105 = @class;
		Class7 class106 = @class;
		Class7 class107 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_85 = (BindingFlags)class106.t((BindingFlags)((Class7)(object)((Class7)(object)class107.e(bindingFlags, array2, array4, array5)).t(bindingFlags, array, obj2, null)).j(default(BindingFlags), null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)Class5.Default), null, Class5.Default, (CultureInfo)(object)Class5.Default);
		MethodBase[] methodBase_24 = array2;
		Class7 class108 = @class;
		bindingFlags = default(BindingFlags);
		gClass3 = (GClass0)(object)class105.e(bindingFlags_85, methodBase_24, (Type[])(object)class108.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array5), null);
		_ = (GClass3)((Class7)null).t(obj2, type, cultureInfo);
		class26 = class26;
		gClass3 = null;
		Class7 class109 = @class;
		BindingFlags bindingFlags_86 = bindingFlags;
		MethodBase[] methodBase_25 = array2;
		ref object[] object_42 = ref *(object[]*)@class.t(bindingFlags, null, Class5.Default, null);
		ParameterModifier[] parameterModifier_14 = array5;
		Class7 obj85 = (Class7)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo);
		bindingFlags = default(BindingFlags);
		_003CModule_003E = (_003CModule_003E)((Class7)(object)class109.j(bindingFlags_86, methodBase_25, ref object_42, parameterModifier_14, (CultureInfo)(object)obj85.e(bindingFlags, null, array4, array5), array3, out reference2)).t(Class5.Default, type, cultureInfo);
		gClass4 = gClass4;
		if ((UIntPtr)((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					@struct = @struct;
				}
				finally
				{
					_003CModule_003E = null;
					continue;
				}
			}
		}
		else
		{
			BindingFlags bindingFlags_87 = (BindingFlags)@class.j((BindingFlags)@class.W(bindingFlags, array6, (Type)@class.t(Class5.Default, type, null), (Type[])(object)@class.W(bindingFlags, array6, null, array4, array5), array5), array2, ref *(object[]*)null, null, cultureInfo, array3, out *(object*)null);
			ref object[] object_43 = ref *(object[]*)((Class7)null).t((object)null, type, (CultureInfo)(object)@class.t(default(BindingFlags), null, Class5.Default, cultureInfo));
			ParameterModifier[] parameterModifier_15 = array5;
			string[] string_8 = array3;
			Class7 class110 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(bindingFlags_87, (MethodBase[])null, ref object_43, parameterModifier_15, (CultureInfo)null, string_8, out *(object*)class110.j((BindingFlags)((Class7)null).e(bindingFlags, array2, (Type[])null, array5), array2, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array, null, null), cultureInfo, array3, out *(object*)null)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass3)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo);
				}
				catch
				{
					_ = Class5.Default;
					_ = (Class2)(object)Class5.Default;
					class33 = (Class6)(object)@class.W(bindingFlags, null, type, null, array5);
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_88 = bindingFlags;
					MethodBase[] methodBase_26 = (MethodBase[])(object)Class5.Default;
					ref object[] object_44 = ref reference;
					ParameterModifier[] parameterModifier_16 = array5;
					string[] string_9 = (string[])(object)Class5.Default;
					Class7 class111 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).j(bindingFlags_88, methodBase_26, ref object_44, parameterModifier_16, (CultureInfo)null, string_9, out *(object*)class111.j(bindingFlags, array2, ref reference, null, cultureInfo, array3, out *(object*)Class5.Default));
					gClass4 = null;
				}
			}
			finally
			{
				do
				{
					class56 = class56;
				}
				while (obj2 != null);
				goto end_IL_340c;
			}
			end_IL_340c:;
		}
		finally
		{
			if (num == 0)
			{
				gClass4 = gClass4;
				gClass4 = gClass4;
				gClass = gClass;
				class25 = null;
			}
			else
			{
				_ = (Class9)(object)Class5.Default;
				gClass = (GClass3)((Class7)null).t((object)null, (Type)null, cultureInfo);
				_ = (Class8)(object)Class5.Default;
			}
			goto IL_34f0;
		}
		IL_11b7:
		_ = (Class8)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, array5);
		_ = (Qk7)(object)Class5.Default;
		try
		{
			while (true)
			{
				Class7 obj87 = (Class7)(object)Class5.Default;
				Class7 class112 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_89 = (BindingFlags)class112.W(bindingFlags, null, type, array4, array5);
				MethodBase[] methodBase_27 = array2;
				ref object[] object_45 = ref reference;
				Class7 class113 = @class;
				BindingFlags bindingFlags_90 = bindingFlags;
				BindingFlags bindingFlags_91 = (BindingFlags)Class5.Default;
				Class7 obj88 = (Class7)(object)Class5.Default;
				ref object[] object_46 = ref reference;
				ParameterModifier[] parameterModifier_17 = array5;
				Class7 class114 = @class;
				Class7 class115 = @class;
				BindingFlags bindingFlags_92 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				CultureInfo cultureInfo_11 = (CultureInfo)(object)class114.j((BindingFlags)class115.W(bindingFlags_92, null, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), array4, null), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2);
				Class7 obj89 = (Class7)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo);
				BindingFlags bindingFlags_93 = bindingFlags;
				Class7 class116 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)obj87.j(bindingFlags_89, methodBase_27, ref object_45, (ParameterModifier[])((Class7)(object)class113.j(bindingFlags_90, (MethodBase[])(object)((Class7)null).t(bindingFlags_91, (FieldInfo[])null, (object)obj88.j(default(BindingFlags), null, ref object_46, parameterModifier_17, cultureInfo_11, (string[])(object)obj89.e(bindingFlags_93, null, (Type[])(object)class116.W(bindingFlags, array6, type, null, array5), (ParameterModifier[])(object)Class5.Default), out *(object*)null), cultureInfo), ref reference, array5, null, array3, out *(object*)null)).t(null, type, cultureInfo), null, (string[])(object)Class5.Default, out reference2) != null)
				{
					GClass1 obj90 = (GClass1)(object)((Class7)null).j((BindingFlags)@class.j((BindingFlags)((Class7)null).W(default(BindingFlags), array6, type, (Type[])null, (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, array3, out reference2), array2, ref *(object[]*)null, array5, cultureInfo, (string[])(object)Class5.Default, out reference2);
					gClass4 = gClass4;
					gClass4 = obj90;
				}
				else if (((Class7)null).t((object)null, type, cultureInfo) == null)
				{
					break;
				}
			}
		}
		catch
		{
			Class7 class117 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)class117.j(bindingFlags, array2, ref *(object[]*)@class.j((BindingFlags)Class5.Default, array2, ref reference, array5, (CultureInfo)(object)Class5.Default, array3, out reference2), null, (CultureInfo)(object)Class5.Default, null, out *(object*)null)).t(null, null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class57 = (Class9)(object)((Class7)null).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, array5);
					class57 = class57;
					Class7 obj91 = (Class7)(object)Class5.Default;
					Class7 class118 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj91.W((BindingFlags)class118.t(bindingFlags, null, obj2, cultureInfo), array6, type, (Type[])(object)Class5.Default, array5);
					_ = (Class2)(object)Class5.Default;
					@class = @class;
				}
				finally
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array5, cultureInfo, array3, out reference2);
					goto end_IL_1447;
				}
			}
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				goto end_IL_1447;
			}
			end_IL_1447:;
		}
		_ = (Struct2)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, array2, array4, array5), type, array4, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])@class.t(null, null, null), null, array5)) != null)
			{
				do
				{
					struct2 = (Struct2)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
		}
		try
		{
			Class7 class119 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class119.W(bindingFlags, array6, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)null, array5, null, array3, out reference2), ref reference, null, null, (string[])(object)Class5.Default, out *(object*)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, null)));
		}
		catch
		{
			if (num == 0)
			{
				if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					class33 = (Class6)(object)Class5.Default;
				}
				else
				{
					_ = (Qk7)(object)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo);
					Class7 class120 = @class;
					Class7 class121 = @class;
					BindingFlags bindingFlags_94 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_28 = array2;
					ParameterModifier[] parameterModifier_18 = array5;
					CultureInfo cultureInfo_12 = cultureInfo;
					Class7 class122 = @class;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass1)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class120.e((BindingFlags)class121.j(bindingFlags_94, methodBase_28, ref *(object[]*)null, parameterModifier_18, cultureInfo_12, (string[])(object)class122.j(bindingFlags, array2, ref *(object[]*)Class5.Default, null, null, (string[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array4, array5), out *(object*)null), out reference2), array2, array4, null), ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out reference2);
				}
			}
		}
		num = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked(num / (nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo))) == 0)
		{
			struct2 = struct2;
			_ = (Struct1)@class.t(obj2, null, cultureInfo);
			gClass = null;
			Class7 obj94 = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array4, (ParameterModifier[])null);
			BindingFlags bindingFlags_95 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = array6;
			Class7 class123 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj94.W(bindingFlags_95, propertyInfo_9, null, (Type[])((Class7)(object)class123.t(bindingFlags, null, null, cultureInfo)).t(obj2, null, cultureInfo), array5);
		}
		if (num == 0)
		{
			class56 = (Class5)(object)@class.W(bindingFlags, array6, type, array4, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array2, array4, array5));
			class56 = null;
		}
		else
		{
			class26 = class26;
		}
		Class7 class124 = @class;
		Class7 class125 = @class;
		bindingFlags = default(BindingFlags);
		_003CModule_003E obj95 = (_003CModule_003E)(object)class124.e((BindingFlags)class125.e(bindingFlags, array2, array4, array5), array2, (Type[])(object)Class5.Default, array5);
		_003CModule_003E = _003CModule_003E;
		_003CModule_003E = obj95;
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj2 != null);
		try
		{
		}
		finally
		{
			try
			{
				gClass3 = null;
			}
			finally
			{
				try
				{
					@struct = @struct;
					_ = (GClass0)(object)Class5.Default;
					_ = (GClass2)@class.t(null, null, cultureInfo);
				}
				catch
				{
					_ = (Class4)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
					Class7 obj96 = (Class7)@class.t(obj2, type, null);
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj96.e(bindingFlags, null, array4, (ParameterModifier[])(object)Class5.Default);
				}
				goto IL_1a89;
			}
		}
	}

	unsafe static void smethod_2()
	{
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] methodBase_ = null;
		ParameterModifier[] array = array;
		ParameterModifier[] parameterModifier_ = array;
		CultureInfo cultureInfo_ = (CultureInfo)(object)Class5.Default;
		ref object object_ = ref *(object*)null;
		UIntPtr num = (UIntPtr)((Class7)null).j(bindingFlags_, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])null, out object_);
		nuint num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		checked
		{
			num2 *= num2;
			num2 = default(UIntPtr);
			if (unchecked((nuint)num) * num2 == 0)
			{
				try
				{
					num2 = default(UIntPtr);
					nuint num3 = num2;
					@class = @class;
					if (num3 + (unchecked((nuint)(UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null)) - num2) == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
					else
					{
						BindingFlags bindingFlags_2 = bindingFlags;
						array2 = array2;
						PropertyInfo[] propertyInfo_ = array2;
						type = (Type)(object)Class5.Default;
						Type type_ = type;
						array3 = (Type[])(object)Class5.Default;
						_ = (Class9)(object)((Class7)null).W(bindingFlags_2, propertyInfo_, type_, array3, (ParameterModifier[])(object)Class5.Default);
					}
				}
				finally
				{
					if (num2 == 0)
					{
						Struct1 obj = (Struct1)Class5.Default;
						@struct = (Struct1)Class5.Default;
						@struct = obj;
					}
					else
					{
						_ = (Class4)(object)Class5.Default;
					}
					goto IL_0149;
				}
			}
			goto IL_0149;
		}
		IL_40c5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])@class.t(obj2, (Type)(object)Class5.Default, null), Class5.Default, null) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		Class10 class2;
		Class9 class3;
		checked
		{
			try
			{
			}
			catch
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, array)) != 0)
					{
						class2 = (Class10)(object)Class5.Default;
					}
					else
					{
						class3 = class3;
					}
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Class7)null).t(((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo_), type, (CultureInfo)null) == 0)
		{
			try
			{
				gClass = (GClass2)(object)Class5.Default;
				Class7 obj4 = (Class7)(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array), null, ref *(object[]*)null, array, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj4.e(bindingFlags, methodBase_, array3, null);
			}
			finally
			{
				goto IL_4254;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		while ((object)Class5.Default != null)
		{
			gClass2 = gClass2;
		}
		goto IL_4254;
		IL_0149:
		Class7 obj5 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)obj5.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null) == (UIntPtr)(nuint)0u)
		{
			do
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_3 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
				Class7 class4 = @class;
				BindingFlags bindingFlags_4 = bindingFlags;
				obj2 = Class5.Default;
				_003CModule_003E = (_003CModule_003E)(object)((Class7)null).W(bindingFlags_3, propertyInfo_2, (Type)(object)class4.e(bindingFlags_4, (MethodBase[])((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo_), array3, array), array3, (ParameterModifier[])null);
				_003CModule_003E = _003CModule_003E;
			}
			while (obj2 != null || (object)Class5.Default != null);
		}
		if (checked(num2 * num2 - num2) == 0)
		{
			Class7 class5 = @class;
			BindingFlags bindingFlags_5 = bindingFlags;
			ref object[] object_2 = ref *(object[]*)Class5.Default;
			array4 = null;
			_ = (GClass1)(object)class5.j(bindingFlags_5, methodBase_, ref object_2, null, cultureInfo_, array4, out *(object*)null);
		}
		_ = (Class7)(object)Class5.Default;
		Struct2 struct2 = (Struct2)Class5.Default;
		struct2 = struct2;
		@class = @class;
		struct2 = struct2;
		@class = @class;
		GClass3 gClass3;
		do
		{
			gClass3 = (GClass3)(object)Class5.Default;
			gClass3 = gClass3;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class7);
		if (num2 / num2 == 0)
		{
			Class7 obj6 = (Class7)(object)Class5.Default;
			array5 = array5;
			_ = (Class5)(object)obj6.t(default(BindingFlags), array5, obj2, null);
		}
		else
		{
			num2 = default(UIntPtr);
			checked
			{
				if (num2 + num2 == 0)
				{
					nuint num4 = num2 + unchecked((nuint)default(UIntPtr));
					Class7 obj7 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_6 = bindingFlags;
					FieldInfo[] fieldInfo_ = (FieldInfo[])@class.t(null, null, cultureInfo_);
					object object_3 = Class5.Default;
					Class7 obj8 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_7 = bindingFlags;
					reference = ref reference;
					if (num4 + unchecked((nuint)(UIntPtr)obj7.t(bindingFlags_6, fieldInfo_, object_3, (CultureInfo)(object)obj8.j(bindingFlags_7, null, ref reference, array, cultureInfo_, array4, out *(object*)null))) == 0)
					{
						Class6 obj9 = (Class6)(object)Class5.Default;
						class6 = null;
						class6 = obj9;
					}
					else
					{
						gClass4 = gClass4;
						gClass4 = gClass4;
					}
				}
				else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					gClass3 = gClass3;
				}
				else
				{
					class7 = class7;
					class7 = class7;
				}
			}
		}
		bindingFlags = default(BindingFlags);
		nuint num5 = (nuint)(UIntPtr)((Class7)(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null)).t(obj2, type, cultureInfo_) / (nuint)(UIntPtr)Class5.Default;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class8);
		if (num5 / num2 == 0 && num2 == 0)
		{
			class8 = null;
			class8 = class8;
			@struct = @struct;
		}
		@class = @class;
		do
		{
			try
			{
				while (obj2 != null)
				{
					class6 = class6;
				}
			}
			finally
			{
				continue;
			}
		}
		while (obj2 != null);
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			while (obj2 != null)
			{
				GClass2 obj10 = (GClass2)(object)Class5.Default;
				gClass = null;
				gClass = obj10;
			}
		}
		do
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					_ = (GClass2)@class.t(@class.t(bindingFlags, array5, obj2, cultureInfo_), type, null);
				}
			}
		}
		while (obj2 != null);
		class2 = null;
		class2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class23);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if (num2 == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class9 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					ref object[] object_4 = ref reference;
					ParameterModifier[] parameterModifier_2 = array;
					Class7 class10 = @class;
					BindingFlags bindingFlags_9 = bindingFlags;
					Class7 obj12 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_10 = bindingFlags;
					BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					Type type_2 = type;
					Type[] type_3 = array3;
					Class7 class11 = @class;
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj13 = (Class7)class11.t(null, (Type)(object)class12.j(bindingFlags, methodBase_, ref *(object[]*)@class.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)Class5.Default), array, cultureInfo_, array4, out object_), null);
					Class7 obj14 = (Class7)(object)@class.e(bindingFlags, null, array3, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_12 = bindingFlags;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_3 = array;
					Class7 class13 = @class;
					BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
					Class7 class14 = @class;
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = bindingFlags;
					Class7 class16 = @class;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					ref object[] object_5 = ref reference;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, (CultureInfo)(object)Class5.Default);
					Class7 class17 = @class;
					BindingFlags bindingFlags_16 = bindingFlags;
					ref object[] object_6 = ref reference;
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_2 = (CultureInfo)(object)class17.j(bindingFlags_16, methodBase_, ref object_6, null, cultureInfo_, (string[])(object)class18.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null), array4, out *(object*)null), null, null, null), out *(object*)null);
					Class7 obj15 = (Class7)@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)null);
					Type type_4 = type;
					Class7 class19 = @class;
					BindingFlags bindingFlags_18 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array2;
					Type type_5 = (Type)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)@class.e(bindingFlags, methodBase_, array3, array), array, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_19 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array2;
					Type type_6 = type;
					BindingFlags bindingFlags_20 = bindingFlags;
					FieldInfo[] fieldInfo_2 = array5;
					Class7 obj16 = (Class7)(object)@class.e(bindingFlags, methodBase_, null, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_21 = (BindingFlags)class15.t(bindingFlags_14, (FieldInfo[])(object)((Class7)((Class7)(object)class16.j(bindingFlags_15, methodBase_, ref object_5, parameterModifier_4, cultureInfo_2, (string[])(object)obj15.W(bindingFlags_17, propertyInfo_4, type_4, (Type[])(object)class19.W(bindingFlags_18, propertyInfo_5, type_5, (Type[])(object)((Class7)null).W(bindingFlags_19, propertyInfo_6, type_6, (Type[])(object)((Class7)null).t(bindingFlags_20, fieldInfo_2, (object)obj16.j(bindingFlags, methodBase_, ref reference, null, null, array4, out object_), cultureInfo_), array), null), array), out *(object*)null)).t(obj2, type, (CultureInfo)(object)Class5.Default)).e((BindingFlags)@class.t(bindingFlags, array5, obj2, cultureInfo_), methodBase_, array3, array), ((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_), null);
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_3 = (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default);
					Class7 class20 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_4 = (MethodBase[])(object)class14.j((BindingFlags)((Class7)null).e(bindingFlags_21, methodBase_3, (Type[])(object)class20.t(bindingFlags, array5, @class.W((BindingFlags)Class5.Default, array2, null, array3, null), (CultureInfo)@class.t(obj2, type, cultureInfo_)), array), (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, cultureInfo_, array4, out *(object*)Class5.Default), ref reference, array, null, array4, out object_);
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_22 = (BindingFlags)obj14.j(bindingFlags_12, methodBase_2, ref *(object[]*)null, parameterModifier_3, (CultureInfo)(object)class13.j(bindingFlags_13, methodBase_4, ref *(object[]*)class21.j(bindingFlags, null, ref reference, array, cultureInfo_, (string[])(object)Class5.Default, out *(object*)@class.j((BindingFlags)@class.t(obj2, null, cultureInfo_), methodBase_, ref reference, array, cultureInfo_, array4, out object_)), (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)Class5.Default), null, out object_);
					Type[] type_7 = (Type[])(object)((Class7)null).W((BindingFlags)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_), (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class9.j(bindingFlags_8, methodBase_, ref object_4, parameterModifier_2, cultureInfo_, (string[])(object)class10.e(bindingFlags_9, methodBase_, (Type[])obj12.t(((Class7)null).e(bindingFlags_10, methodBase_, (Type[])null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_11, propertyInfo_3, type_2, type_3, (ParameterModifier[])(object)obj13.e(bindingFlags_22, methodBase_, type_7, (ParameterModifier[])(object)class22.t(bindingFlags, array5, obj2, null)))), type, (CultureInfo)((Class7)null).t(obj2, type, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default))), array), out *(object*)Class5.Default);
				}
				else
				{
					Class5 obj17 = Class5.Default;
					class23 = class23;
					class23 = obj17;
				}
			}
			catch
			{
				gClass4 = gClass4;
			}
		}
		else
		{
			try
			{
				class6 = class6;
			}
			catch
			{
				try
				{
					qk = null;
					qk = null;
					BindingFlags bindingFlags_23 = (BindingFlags)((Class7)(object)Class5.Default).t(null, null, null);
					Class7 class24 = @class;
					BindingFlags bindingFlags_24 = bindingFlags;
					Type type_8 = (Type)(object)Class5.Default;
					Class7 class25 = @class;
					BindingFlags bindingFlags_25 = bindingFlags;
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags_23, (FieldInfo[])null, (object)((Class7)(object)class24.W(bindingFlags_24, null, type_8, (Type[])(object)class25.e(bindingFlags_25, (MethodBase[])(object)class26.W(bindingFlags, array2, null, array3, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null)).t(obj2, null, (CultureInfo)(object)Class5.Default), null, (ParameterModifier[])(object)Class5.Default)), null, array), array)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, null, array), type, array3, null), cultureInfo_);
				}
				catch
				{
					Class7 obj19 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)((Class7)(object)obj19.t(bindingFlags, array5, null, cultureInfo_)).t(obj2, (Type)(object)Class5.Default, cultureInfo_);
					_003CModule_003E = _003CModule_003E;
					gClass3 = gClass3;
				}
			}
		}
		_ = (GClass0)(object)Class5.Default;
		try
		{
			_ = (GClass0)@class.t(obj2, null, (CultureInfo)(object)Class5.Default);
		}
		catch
		{
			do
			{
				class7 = (Class8)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		class2 = class2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class27);
		if (checked(unchecked((nuint)(UIntPtr)Class5.Default / num2) + num2) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					GClass0 obj23 = (GClass0)@class.t(obj2, type, cultureInfo_);
					gClass2 = gClass2;
					gClass2 = obj23;
					_ = (Class6)(object)Class5.Default;
				}
				else
				{
					gClass4 = gClass4;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					@struct = default(Struct1);
					object object_7 = obj2;
					Type type_9 = type;
					bindingFlags = default(BindingFlags);
					_ = (Class5)((Class7)null).t(object_7, type_9, (CultureInfo)(object)((Class7)null).W(bindingFlags, array2, type, array3, array));
					_ = (Class8)(object)((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array3, null)).e(bindingFlags, null, null, null);
					class27 = class27;
					class27 = class27;
				}
				goto IL_0e7b;
			}
		}
		goto IL_0e7b;
		IL_245a:
		_ = (_003CModule_003E)(object)Class5.Default;
		Class7 class28 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)((Class7)(object)class28.j(bindingFlags, null, ref reference, array, null, null, out *(object*)null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).t(@class.t(obj2, type, null), type, cultureInfo_), (PropertyInfo[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array3, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, null, array), null, (CultureInfo)(object)Class5.Default, null, out object_);
		gClass4 = null;
		class3 = class3;
		gClass = gClass;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class31);
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					qk = (Qk7)(object)Class5.Default;
					Class7 class29 = @class;
					BindingFlags bindingFlags_26 = bindingFlags;
					MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					class8 = (Class2)(object)class29.e(bindingFlags_26, methodBase_5, (Type[])(object)class30.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), (ParameterModifier[])(object)@class.t(bindingFlags, array5, null, cultureInfo_));
					_ = (Class0)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, cultureInfo_);
					_ = (Class9)(object)@class.t(bindingFlags, array5, null, null);
					goto end_IL_254b;
				}
				end_IL_254b:;
			}
			catch
			{
				try
				{
					class31 = class31;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, array3, array);
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					class27 = class27;
					goto end_IL_2621;
				}
				end_IL_2621:;
			}
		}
		do
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
				class23 = (Class5)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, methodBase_, null, array);
			}
			finally
			{
				num2 = default(UIntPtr);
				if (checked(num2 + num2) == 0)
				{
					@struct = @struct;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					class31 = class31;
				}
				continue;
			}
		}
		while (obj2 != null);
		class31 = class31;
		_ = (GClass3)((Class7)(object)Class5.Default).t(obj2, (Type)(object)((Class7)null).e(bindingFlags, methodBase_, array3, (ParameterModifier[])null), cultureInfo_);
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
				class23 = class23;
				_ = Class5.Default;
			}
			catch
			{
				class23 = null;
			}
			finally
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
				}
				while (obj2 != null);
				goto IL_2796;
			}
		}
		goto IL_2796;
		IL_4e96:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 obj26;
			do
			{
				obj26 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default);
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj26.e(bindingFlags, null, null, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, null, array)) != null);
		}
		else
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					ref object[] object_8 = ref reference;
					ParameterModifier[] parameterModifier_5 = array;
					string[] string_ = (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo_, array4, out object_), ref reference, array, cultureInfo_, array4, out *(object*)@class.j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)null), null, cultureInfo_, (string[])((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), out object_)), type, array3, array);
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)null).j(bindingFlags_27, (MethodBase[])null, ref object_8, parameterModifier_5, cultureInfo_, string_, out *(object*)class32.e(bindingFlags, methodBase_, array3, array));
				}
				finally
				{
					class31 = null;
					goto end_IL_4f1f;
				}
				end_IL_4f1f:;
			}
			catch
			{
				class2 = (Class10)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
			}
		}
		while (obj2 != null)
		{
		}
		while (obj2 != null)
		{
			_ = (Class4)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			@class = (Class7)(object)class33.j(bindingFlags, methodBase_, ref reference, null, null, array4, out *(object*)null);
			Class7 obj28 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_28 = bindingFlags;
			Class7 obj29 = (Class7)(object)Class5.Default;
			Class7 class34 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj28.e(bindingFlags_28, methodBase_, (Type[])obj29.t(((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)class34.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, null), obj2, (CultureInfo)null), type, (CultureInfo)(object)Class5.Default), array);
			@struct = @struct;
			_ = (Struct2)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, array);
		}
		try
		{
			do
			{
				_003CModule_003E = null;
				gClass3 = gClass3;
				struct2 = struct2;
			}
			while (((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo_) != null || (object)Class5.Default != null);
		}
		catch
		{
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			class3 = class3;
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				struct2 = (Struct2)Class5.Default;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = gClass;
					return;
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)(object)Class5.Default);
					_ = (Struct2)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array3, array), array3, null);
					return;
				}
			}
			return;
		}
		catch
		{
			_ = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, (Type[])(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, (object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, null, array), cultureInfo_), array);
			return;
		}
		IL_43a1:
		_ = (GClass0)(object)Class5.Default;
		if (num2 == 0)
		{
			Class7 class35 = @class;
			BindingFlags bindingFlags_29 = bindingFlags;
			PropertyInfo[] propertyInfo_7 = array2;
			Type type_10 = (Type)(object)Class5.Default;
			BindingFlags bindingFlags_30 = bindingFlags;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			Type type_11 = type;
			Class7 class36 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class35.W(bindingFlags_29, propertyInfo_7, type_10, (Type[])(object)((Class7)null).W(bindingFlags_30, propertyInfo_8, type_11, (Type[])(object)class36.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])null), array) == (UIntPtr)(nuint)0u)
			{
				gClass4 = (GClass1)@class.t(null, (Type)(object)Class5.Default, cultureInfo_);
			}
			else
			{
				do
				{
					class3 = class3;
					gClass = gClass;
				}
				while (obj2 != null);
			}
		}
		else
		{
			do
			{
				_ = (GClass1)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array);
			}
			while ((object)@class.W(bindingFlags, array2, type, array3, array) != null);
		}
		do
		{
			try
			{
				do
				{
					class3 = null;
					gClass4 = gClass4;
					class27 = class27;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					class7 = class7;
					continue;
				}
			}
		}
		while (obj2 != null);
		try
		{
			struct2 = default(Struct2);
			struct2 = struct2;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass2)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			goto IL_4516;
		}
		IL_1f0d:
		try
		{
			if (num2 == 0)
			{
				gClass2 = null;
			}
		}
		finally
		{
			Class9 obj33 = (Class9)(object)Class5.Default;
			class3 = null;
			class3 = obj33;
			goto IL_1f30;
		}
		IL_2107:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					class6 = class6;
				}
			}
			while ((object)@class.t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)@class.t(bindingFlags, array5, null, cultureInfo_), array5, null, null), obj2, cultureInfo_) != null);
			goto IL_245a;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class7 = null;
				_ = (GClass0)(object)((Class7)null).e((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, null, ref reference, null, null, (string[])(object)Class5.Default, out object_), obj2, null), methodBase_, array3, (ParameterModifier[])null);
			}
		}
		finally
		{
			Class7 obj35 = (Class7)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo_);
			BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
			Class7 class37 = @class;
			BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_6 = (MethodBase[])(object)((Class7)null).e((BindingFlags)class37.j(bindingFlags_32, methodBase_, ref *(object[]*)((Class7)null).e(bindingFlags, methodBase_, array3, (ParameterModifier[])null), array, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])(object)Class5.Default), array4, out *(object*)null), methodBase_, (Type[])null, (ParameterModifier[])(object)@class.W(bindingFlags, array2, type, null, array));
			ref object[] object_9 = ref reference;
			Class7 obj36 = (Class7)(object)@class.t(bindingFlags, array5, obj2, (CultureInfo)(object)Class5.Default);
			BindingFlags bindingFlags_33 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = array2;
			Type type_12 = type;
			Class7 class38 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj35.j(bindingFlags_31, methodBase_6, ref object_9, (ParameterModifier[])(object)obj36.W(bindingFlags_33, propertyInfo_9, type_12, (Type[])(object)class38.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array5, obj2, (CultureInfo)(object)Class5.Default), null, out object_), (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_)), (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])(object)@class.e((BindingFlags)@class.t(null, (Type)(object)Class5.Default, null), methodBase_, array3, array), (ParameterModifier[])(object)@class.e(bindingFlags, null, null, array))).t(Class5.Default, type, cultureInfo_), obj2, (CultureInfo)(object)Class5.Default)).t(default(BindingFlags), null, null, null), (string[])(object)Class5.Default, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				@class = @class;
				class3 = class3;
			}
			goto IL_245a;
		}
		IL_14ee:
		_ = (Struct1)((Class7)@class.t(obj2, null, (CultureInfo)(object)@class.t(bindingFlags, array5, null, null))).t(null, null, (CultureInfo)(object)((Class7)(object)@class.t((BindingFlags)@class.t(bindingFlags, array5, null, null), null, null, cultureInfo_)).W(bindingFlags, array2, type, array3, array));
		_ = Class5.Default;
		class31 = class31;
		_ = (GClass1)(object)Class5.Default;
		class27 = (Class4)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					Class7 class39 = @class;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass1)(object)class39.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, (CultureInfo)((Class7)null).t((object)null, (Type)null, cultureInfo_))).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array2, (Type)null, array3, (ParameterModifier[])null), cultureInfo_, array4, out object_), (MethodBase[])@class.t(((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null), array)).t(null, (Type)(object)Class5.Default, cultureInfo_), (Type)(object)Class5.Default, cultureInfo_), ref reference, array, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, array, (CultureInfo)null, (string[])null, out object_), (string[])(object)Class5.Default, out object_), null, array), null));
				}
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					class23 = null;
				}
				else
				{
					Class7 class40 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class40.e(bindingFlags_34, methodBase_, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array));
				}
			}
		}
		while (true)
		{
			if (obj2 != null)
			{
				try
				{
					_ = (Class7)(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_);
				}
				catch
				{
					qk = null;
				}
				continue;
			}
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class41.W(bindingFlags, null, type, array3, null) == null)
			{
				break;
			}
		}
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					gClass4 = gClass4;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).W((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array, (CultureInfo)null, (string[])(object)Class5.Default, out object_), (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, array);
					_ = (Struct2)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				_ = (Class9)(object)@class.e(bindingFlags, null, array3, null);
				goto IL_189d;
			}
		}
		goto IL_189d;
		IL_30b9:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class31 = class31;
		}
		while (true)
		{
			BindingFlags bindingFlags_35 = bindingFlags;
			Class7 class42 = @class;
			BindingFlags bindingFlags_36 = (BindingFlags)@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
			Class7 obj40 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, (CultureInfo)null);
			BindingFlags bindingFlags_37 = bindingFlags;
			Class7 obj41 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).W(bindingFlags_35, (PropertyInfo[])(object)class42.e(bindingFlags_36, null, (Type[])(object)obj40.e(bindingFlags_37, methodBase_, (Type[])(object)obj41.e(bindingFlags, methodBase_, null, null), array), array), type, (Type[])null, (ParameterModifier[])null) != null)
			{
				while (obj2 != null)
				{
					qk = null;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		try
		{
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) - (num2 - num2)) == 0)
			{
				do
				{
					Class7 class43 = @class;
					BindingFlags bindingFlags_38 = bindingFlags;
					ref object[] object_10 = ref reference;
					ParameterModifier[] parameterModifier_6 = array;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class43.j(bindingFlags_38, methodBase_, ref object_10, parameterModifier_6, (CultureInfo)(object)((Class7)(object)class44.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)@class.t(obj2, type, (CultureInfo)(object)Class5.Default), (FieldInfo[])null, obj2, (CultureInfo)null), (CultureInfo)null, array4, out *(object*)null)).e(bindingFlags, methodBase_, (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array3, array), array), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default))).e(bindingFlags, null, array3, array), null, out *(object*)Class5.Default);
				}
				while (obj2 != null);
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)Class5.Default;
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (Struct2)Class5.Default;
				class23 = null;
			}
		}
		catch
		{
			class31 = null;
		}
		num2 = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
		{
			try
			{
				@class = @class;
			}
			catch
			{
				do
				{
					class23 = (Class5)(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out object_);
					_ = (GClass3)(object)Class5.Default;
					_ = (Class2)(object)@class.e(bindingFlags, methodBase_, array3, array);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null);
				}
				while (obj2 != null);
			}
		}
		try
		{
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, (CultureInfo)(object)Class5.Default), cultureInfo_, array4, out object_) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, type, array3, array);
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					class2 = class2;
				}
				catch
				{
					class23 = null;
				}
				goto IL_3475;
			}
		}
		IL_0e7b:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = null;
			}
			finally
			{
				do
				{
					class2 = null;
				}
				while ((object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, array) != null);
				goto IL_0ebf;
			}
		}
		goto IL_0ebf;
		IL_3475:
		if (num2 == 0)
		{
			Class7 class45 = @class;
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class45.t((BindingFlags)class46.j(bindingFlags, methodBase_, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_), (FieldInfo[])(object)Class5.Default, ((Class7)null).j((BindingFlags)@class.t(bindingFlags, null, ((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array3, array), cultureInfo_), (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out *(object*)@class.t(obj2, type, cultureInfo_)), (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				if (num2 == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class47.t(bindingFlags, array5, obj2, cultureInfo_);
					Class7 obj45 = (Class7)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, array, cultureInfo_, array4, out object_);
					bindingFlags = default(BindingFlags);
					Class7 obj46 = (Class7)(object)obj45.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array);
					Class7 class48 = @class;
					BindingFlags bindingFlags_39 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = array2;
					object object_11 = obj2;
					BindingFlags bindingFlags_40 = bindingFlags;
					ref object[] object_12 = ref reference;
					ParameterModifier[] parameterModifier_7 = array;
					Class7 obj47 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj46.j((BindingFlags)class48.W(bindingFlags_39, propertyInfo_10, (Type)((Class7)null).t(object_11, (Type)(object)((Class7)null).j(bindingFlags_40, methodBase_, ref object_12, parameterModifier_7, (CultureInfo)(object)((Class7)null).j((BindingFlags)obj47.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)null), null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null)), (string[])null, out *(object*)null), cultureInfo_), null, null), methodBase_, ref *(object[]*)@class.t(bindingFlags, null, Class5.Default, null), array, cultureInfo_, array4, out *(object*)null);
					Class7 obj48 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_41 = bindingFlags;
					PropertyInfo[] propertyInfo_11 = array2;
					Type type_13 = (Type)(object)((Class7)(object)@class.W(bindingFlags, array2, null, (Type[])(object)Class5.Default, array)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, null, array4, out *(object*)@class.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default)));
					Class7 class49 = @class;
					Class7 class50 = @class;
					object object_13 = obj2;
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj48.W(bindingFlags_41, propertyInfo_11, type_13, (Type[])((Class7)(object)class49.j((BindingFlags)class50.t(default(BindingFlags), null, object_13, (CultureInfo)(object)class51.t(bindingFlags, array5, null, (CultureInfo)(object)Class5.Default)), methodBase_, ref reference, array, (CultureInfo)(object)Class5.Default, null, out *(object*)null)).t(obj2, null, cultureInfo_), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)null));
				}
			}
		}
		Class7 obj49 = (Class7)(object)Class5.Default;
		Class7 class52 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)obj49.j((BindingFlags)class52.e(bindingFlags, null, array3, null), methodBase_, ref *(object[]*)@class.t(obj2, (Type)((Class7)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, null, null, null)).t(Class5.Default, type, cultureInfo_)).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, methodBase_, array3, null)), cultureInfo_), array, cultureInfo_, null, out *(object*)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_));
		_ = (GClass1)(object)Class5.Default;
		class23 = class23;
		_ = (Class9)(object)Class5.Default;
		@class = (Class7)(object)Class5.Default;
		do
		{
			try
			{
				try
				{
					gClass3 = null;
				}
				catch
				{
					Class7 class53 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_42 = bindingFlags;
					PropertyInfo[] propertyInfo_12 = array2;
					Type[] type_14 = (Type[])(object)Class5.Default;
					Class7 obj50 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_43 = bindingFlags;
					Class7 obj51 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj52 = (Class7)(object)class53.W(bindingFlags_42, propertyInfo_12, null, type_14, (ParameterModifier[])((Class7)(object)obj50.e(bindingFlags_43, null, (Type[])(object)obj51.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, (ParameterModifier[])(object)Class5.Default), array)).t(obj2, type, cultureInfo_));
					BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_13 = array2;
					Class7 obj53 = (Class7)@class.t(obj2, type, null);
					bindingFlags = default(BindingFlags);
					struct2 = (Struct2)obj52.W(bindingFlags_44, propertyInfo_13, null, (Type[])(object)obj53.W(bindingFlags, array2, type, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, (Type[])(object)Class5.Default, null)), null);
				}
			}
			catch
			{
				if (num2 == 0)
				{
					_003CModule_003E = _003CModule_003E;
					class6 = class6;
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					qk = qk;
				}
			}
		}
		while (obj2 != null);
		checked
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					class23 = class23;
				}
			}
			catch
			{
				nuint num6 = num2;
				nuint num7 = num2 + num2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_45 = bindingFlags;
				Class7 class54 = @class;
				BindingFlags bindingFlags_46 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				if (num6 * (num7 - (unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags_45, (PropertyInfo[])(object)class54.j(bindingFlags_46, methodBase_7, ref *(object[]*)class55.t((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array3, array), (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, array), Class5.Default, cultureInfo_), array, null, (string[])(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)((Class7)null).e(bindingFlags, methodBase_, array3, array), array)).t(obj2, null, cultureInfo_), methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array), Class5.Default, null), cultureInfo_, array4, out object_), out *(object*)null), (Type)(object)Class5.Default, array3, array)) + unchecked((nuint)(UIntPtr)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, array2, type, (Type[])(object)@class.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default)), null)).t(bindingFlags, null, @class.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_)))).t((BindingFlags)Class5.Default, array5, obj2, null)))) == 0)
				{
					try
					{
						_ = (Qk7)(object)((Class7)(object)Class5.Default).t(unchecked((BindingFlags)Class5.Default), array5, Class5.Default, (CultureInfo)(object)Class5.Default);
						_ = (GClass2)@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
						gClass = null;
					}
					catch
					{
						_ = (Class10)(object)Class5.Default;
					}
				}
			}
			num2 = default(UIntPtr);
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Class9)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				try
				{
					Class7 obj58 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					ref object[] object_14 = ref reference;
					ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj58.j(bindingFlags_47, null, ref object_14, parameterModifier_8, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, array, cultureInfo_, (string[])null, out *(object*)null), null, out *(object*)Class5.Default);
				}
				catch
				{
					_ = (GClass2)@class.t(null, null, null);
					BindingFlags bindingFlags_48 = bindingFlags;
					object object_15 = obj2;
					Class7 class56 = @class;
					BindingFlags bindingFlags_49 = bindingFlags;
					ref object[] object_16 = ref reference;
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)Class5.Default;
					Type[] type_15 = (Type[])(object)@class.t((BindingFlags)Class5.Default, null, obj2, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)((Class7)null).t(bindingFlags_48, (FieldInfo[])null, object_15, (CultureInfo)(object)class56.j(bindingFlags_49, null, ref object_16, parameterModifier_9, cultureInfo_, (string[])(object)((Class7)(object)((Class7)null).e(default(BindingFlags), methodBase_, type_15, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array, cultureInfo_, array4, out *(object*)Class5.Default))).j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_), ref reference, null, cultureInfo_, null, out object_), out object_));
				}
				goto IL_3f74;
			}
		}
		goto IL_3f74;
		IL_0ebf:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Class7)(object)((Class7)((Class7)null).t(obj2, type, (CultureInfo)null)).W(bindingFlags, array2, type, array3, array)).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out object_) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo_);
				}
				else
				{
					_ = (Class4)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					struct2 = struct2;
					_ = (GClass1)(object)Class5.Default;
					gClass2 = gClass2;
				}
			}
			else
			{
				_ = (Class5)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out *(object*)Class5.Default);
			}
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_);
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			Class7 obj61 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_50 = bindingFlags;
			Class7 class57 = @class;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_8 = (MethodBase[])(object)class57.j(bindingFlags, null, ref *(object[]*)Class5.Default, array, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null);
			BindingFlags bindingFlags_51 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)obj61.e(bindingFlags_50, methodBase_8, (Type[])(object)((Class7)null).W(bindingFlags_51, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default), (Type)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), array3, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.e(bindingFlags, methodBase_, array3, array), (CultureInfo)(object)@class.j(bindingFlags, methodBase_, ref reference, array, null, null, out object_)));
		}
		else
		{
			Class7 class58;
			Class7 class59;
			do
			{
				_ = (Qk7)(object)@class.j(default(BindingFlags), methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)null);
				class58 = @class;
				class59 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class58.j((BindingFlags)class59.W(bindingFlags, array2, null, (Type[])(object)Class5.Default, array), null, ref *(object[]*)null, array, null, array4, out *(object*)null) != null);
		}
		try
		{
			while (obj2 != null)
			{
				try
				{
					Class7 class60 = @class;
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					object object_17 = obj2;
					BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_14 = array2;
					Type type_16 = type;
					Class7 obj62 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)class60.t(((Class7)((Class7)(object)class61.t(bindingFlags_52, null, object_17, (CultureInfo)(object)((Class7)null).W(bindingFlags_53, propertyInfo_14, type_16, (Type[])null, (ParameterModifier[])(object)obj62.e(bindingFlags, methodBase_, array3, array)))).t(null, type, cultureInfo_)).t(bindingFlags, array5, ((Class7)null).t(obj2, type, (CultureInfo)null), null), type, null);
				}
				catch
				{
					gClass3 = null;
				}
			}
		}
		finally
		{
			try
			{
				do
				{
					@struct = @struct;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					class31 = class31;
					class31 = class31;
				}
				catch
				{
					gClass = gClass;
				}
			}
			goto IL_12e5;
		}
		IL_1f30:
		try
		{
			if (num2 == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 obj66 = (Class7)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array3, null);
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj66.W(bindingFlags, array2, type, null, null);
				}
			}
			else
			{
				try
				{
					Class7 class62 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class62.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					class8 = (Class2)(object)((Class7)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, null))).t(bindingFlags, array5, @class.W(bindingFlags, null, null, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.t(bindingFlags, array5, obj2, cultureInfo_), (MethodBase[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, null, out object_), array3, array)), cultureInfo_);
				}
			}
		}
		finally
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)@class.W(bindingFlags, null, type, array3, null);
					gClass4 = (GClass1)(object)Class5.Default;
					_ = (Class6)(object)@class.e(bindingFlags, methodBase_, array3, array);
				}
			}
			catch
			{
				do
				{
					class31 = (Class0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			goto IL_2107;
		}
		IL_19de:
		if ((UIntPtr)@class.W(bindingFlags, array2, null, array3, array) == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, cultureInfo_), (Type[])null, (ParameterModifier[])null);
				}
			}
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				Class7 obj69;
				BindingFlags bindingFlags_54;
				Class7 class64;
				BindingFlags bindingFlags_55;
				FieldInfo[] fieldInfo_3;
				Class7 class65;
				do
				{
					_ = (Class4)(object)Class5.Default;
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					obj69 = (Class7)(object)class63.e(bindingFlags, null, array3, array);
					bindingFlags_54 = bindingFlags;
					class64 = @class;
					bindingFlags_55 = bindingFlags;
					fieldInfo_3 = (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array3, array);
					class65 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)obj69.t(bindingFlags_54, (FieldInfo[])(object)class64.t(bindingFlags_55, fieldInfo_3, class65.j(bindingFlags, methodBase_, ref reference, array, cultureInfo_, array4, out object_), cultureInfo_), null, null) != null);
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = (GClass2)(object)((Class7)(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)null)).j(bindingFlags, null, ref reference, null, cultureInfo_, (string[])(object)Class5.Default, out object_);
				}
				finally
				{
					class8 = (Class2)((Class7)null).t(obj2, (Type)null, (CultureInfo)null);
					goto IL_1b8a;
				}
			}
			gClass3 = gClass3;
			goto IL_1b8a;
		}
		IL_189d:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
			}
		}
		try
		{
			_ = (Class9)(object)Class5.Default;
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (GClass2)(object)Class5.Default;
				Class7 class66 = @class;
				Class7 class67 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj70 = (Class7)(object)class67.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, array), out *(object*)null);
				BindingFlags bindingFlags_56 = (BindingFlags)Class5.Default;
				Class7 obj71 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj72 = (Class7)(object)obj70.t(bindingFlags_56, null, obj71.W(bindingFlags, array2, (Type)(object)Class5.Default, array3, null), cultureInfo_);
				BindingFlags bindingFlags_57 = bindingFlags;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)class66.e((BindingFlags)obj72.e(bindingFlags_57, null, null, (ParameterModifier[])(object)class68.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array)), methodBase_, array3, array);
			}
			goto IL_19de;
		}
		IL_1ded:
		try
		{
			_ = Class5.Default;
		}
		catch
		{
			Class7 class69 = @class;
			Class7 obj73 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_58 = bindingFlags;
			Class7 obj74 = (Class7)(object)@class.e(bindingFlags, null, array3, array);
			bindingFlags = default(BindingFlags);
			class7 = (Class8)class69.t(obj73.e(bindingFlags_58, null, null, (ParameterModifier[])(object)obj74.j(bindingFlags, methodBase_, ref reference, array, null, array4, out *(object*)@class.t(Class5.Default, null, cultureInfo_))), null, (CultureInfo)(object)Class5.Default);
		}
		num2 = default(UIntPtr);
		if (checked(num2 + num2) == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					class8 = class8;
				}
				finally
				{
					class27 = class27;
					goto IL_1f0d;
				}
			}
		}
		else
		{
			_ = (_003CModule_003E)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		}
		goto IL_1f0d;
		IL_12e5:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class27 = null;
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				@class = null;
			}
			while (obj2 != null);
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			while ((object)@class.W((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array3, (ParameterModifier[])(object)Class5.Default), array2, type, null, array) != null)
			{
				Class7 obj76 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class23 = (Class5)(object)obj76.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null), type, null, array);
			}
		}
		else
		{
			Class7 class70 = @class;
			BindingFlags bindingFlags_59 = bindingFlags;
			FieldInfo[] fieldInfo_4 = array5;
			Class7 class71 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t((BindingFlags)class70.t(bindingFlags_59, fieldInfo_4, null, (CultureInfo)(object)((Class7)null).j((BindingFlags)class71.j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)@class.t(obj2, type, (CultureInfo)(object)Class5.Default), array5, obj2, cultureInfo_), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out object_), methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array4, out object_)), (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)@class.t(Class5.Default, type, (CultureInfo)@class.t(((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)@class.t(obj2, null, null)), (Type)(object)Class5.Default, cultureInfo_))) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = Class5.Default;
				}
				finally
				{
					gClass4 = gClass4;
					goto IL_14ee;
				}
			}
		}
		goto IL_14ee;
		IL_3f74:
		UIntPtr num8 = num2;
		num2 = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num8) - num2 == 0)
			{
				while ((object)Class5.Default != null)
				{
					try
					{
						class23 = class23;
						class23 = (Class5)(object)@class.W(bindingFlags, null, type, array3, array);
						_ = (GClass2)(object)Class5.Default;
						_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					}
					finally
					{
						_ = (Class2)(object)Class5.Default;
						continue;
					}
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				try
				{
					class31 = class31;
					class31 = null;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					goto IL_4021;
				}
			}
			@struct = @struct;
		}
		goto IL_4021;
		IL_4254:
		gClass3 = gClass3;
		_ = (Qk7)(object)Class5.Default;
		class31 = class31;
		@struct = default(Struct1);
		try
		{
			class31 = class31;
		}
		catch
		{
			_ = (Class10)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class2)(object)Class5.Default;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class6 = class6;
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)Class5.Default;
			}
			else
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		finally
		{
			checked
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
					gClass = null;
					gClass = null;
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						class6 = null;
					}
					else
					{
						@struct = default(Struct1);
					}
					goto IL_4341;
				}
			}
		}
		IL_4c60:
		while ((object)@class.e(bindingFlags, methodBase_, null, array) != null)
		{
			do
			{
				_ = (Class8)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		if (num2 == 0)
		{
			try
			{
				if (num2 == 0)
				{
					class8 = class8;
					class31 = (Class0)(object)Class5.Default;
					BindingFlags bindingFlags_60 = bindingFlags;
					Class7 class72 = @class;
					BindingFlags bindingFlags_61 = bindingFlags;
					ref object[] object_18 = ref reference;
					ParameterModifier[] parameterModifier_10 = array;
					Class7 obj79 = (Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)null);
					BindingFlags bindingFlags_62 = (BindingFlags)@class.t(obj2, type, cultureInfo_);
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)null).e(bindingFlags_60, (MethodBase[])(object)class72.j(bindingFlags_61, methodBase_, ref object_18, parameterModifier_10, (CultureInfo)(object)obj79.j(bindingFlags_62, methodBase_, ref *(object[]*)class73.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array), array, null, array4, out *(object*)null), null, out object_), (Type[])(object)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), methodBase_, array3, (ParameterModifier[])null), array);
					class7 = class7;
				}
				else
				{
					class23 = (Class5)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, array4, out *(object*)null);
					gClass = gClass;
				}
			}
			finally
			{
				_ = (Class4)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array);
				Class7 class74 = @class;
				FieldInfo[] fieldInfo_5 = array5;
				object object_19 = obj2;
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				class27 = (Class4)(object)class74.t(default(BindingFlags), fieldInfo_5, object_19, (CultureInfo)(object)class75.W(bindingFlags, array2, type, null, array));
				_ = (Class8)(object)Class5.Default;
				class27 = class27;
				goto IL_4e96;
			}
		}
		do
		{
			try
			{
				gClass = (GClass2)(object)Class5.Default;
			}
			finally
			{
				class6 = class6;
				continue;
			}
		}
		while ((object)Class5.Default != null);
		goto IL_4e96;
		IL_47be:
		num2 = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					class8 = class8;
				}
				catch
				{
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class76.e(bindingFlags, null, array3, array);
				}
			}
			else
			{
				do
				{
					_ = Class5.Default;
				}
				while (obj2 != null);
			}
		}
		else
		{
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj81 = (Class7)(object)class77.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)@class.j(bindingFlags, methodBase_, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out object_), (Type[])((Class7)@class.t(obj2, type, cultureInfo_)).t(null, (Type)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array3, (ParameterModifier[])null), cultureInfo_, (string[])(object)Class5.Default, out object_), (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, array2, null, (Type[])(object)@class.W(bindingFlags, array2, type, array3, null), array), obj2, cultureInfo_);
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj81.e(bindingFlags, null, array3, null);
			_ = (Class2)(object)Class5.Default;
		}
		while (obj2 != null)
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		}
		while ((object)Class5.Default != null)
		{
			UIntPtr num9 = (UIntPtr)Class5.Default;
			nuint num10 = num2;
			Class7 class78 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_63 = bindingFlags;
			ParameterModifier[] parameterModifier_11 = (ParameterModifier[])(object)Class5.Default;
			string[] string_2 = array4;
			Class7 class79 = @class;
			BindingFlags bindingFlags_64 = bindingFlags;
			Class7 obj82 = (Class7)(object)Class5.Default;
			Class7 class80 = @class;
			BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)num9) - unchecked(num10 / ((nuint)(UIntPtr)class78.j(bindingFlags_63, methodBase_, ref *(object[]*)null, parameterModifier_11, cultureInfo_, string_2, out *(object*)class79.j(bindingFlags_64, null, ref *(object[]*)obj82.t(class80.t(bindingFlags_65, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])(object)Class5.Default), obj2, cultureInfo_), type, cultureInfo_), (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out *(object*)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo_))) / num2))) == 0)
			{
				Class7 class81 = @class;
				BindingFlags bindingFlags_66 = bindingFlags;
				Class7 obj83 = (Class7)(object)Class5.Default;
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class81.e(bindingFlags_66, methodBase_, (Type[])(object)obj83.e((BindingFlags)class82.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)Class5.Default, array4, out object_), null, null, array), array) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (GClass1)@class.t(Class5.Default, type, cultureInfo_);
				}
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, null) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (GClass3)(object)((Class7)(object)@class.e(bindingFlags, methodBase_, array3, null)).t(bindingFlags, array5, Class5.Default, cultureInfo_);
				}
				finally
				{
					class7 = class7;
					continue;
				}
			}
			while (obj2 != null);
		}
		_ = (Struct2)Class5.Default;
		checked
		{
			nuint num11 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array, cultureInfo_, array4, out object_));
			num2 = default(UIntPtr);
			if (num11 * num2 == 0)
			{
				try
				{
					num2 = default(UIntPtr);
					if (num2 == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					class8 = class8;
					goto IL_4c60;
				}
			}
			goto IL_4c60;
		}
		IL_4516:
		_ = (GClass1)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array3, null);
		do
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				try
				{
					class6 = class6;
				}
				catch
				{
					class23 = class23;
					qk = (Qk7)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, obj2, (CultureInfo)(object)Class5.Default);
					class3 = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
				}
			}
			else if (checked(num2 - unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array5, null, null))) == 0)
			{
				_ = (Class4)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, array, null, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj2, (CultureInfo)(object)((Class7)((Class7)null).t((object)null, type, (CultureInfo)null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null)), out object_);
				_ = (GClass1)(object)Class5.Default;
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).j((BindingFlags)((Class7)(object)class83.j(bindingFlags, (MethodBase[])((Class7)null).t(obj2, type, cultureInfo_), ref *(object[]*)null, null, cultureInfo_, array4, out object_)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), (MethodBase[])null, ref *(object[]*)null, array, (CultureInfo)null, (string[])null, out *(object*)null);
			}
		}
		while ((object)Class5.Default != null);
		checked
		{
			do
			{
				try
				{
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)class84.t(bindingFlags, null, null, cultureInfo_);
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						gClass = gClass;
					}
					continue;
				}
			}
			while (obj2 != null);
		}
		class3 = (Class9)@class.t(obj2, null, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo_));
		class31 = class31;
		qk = null;
		try
		{
			Class7 class85 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)class85.t(bindingFlags, array5, null, cultureInfo_);
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			goto IL_47be;
		}
		IL_4021:
		try
		{
			_ = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null);
			Class7 class86 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class86.e(bindingFlags, null, null, (ParameterModifier[])((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array), null, array)).t(obj2, type, cultureInfo_));
			struct2 = struct2;
		}
		finally
		{
			goto IL_40c5;
		}
		IL_1b8a:
		try
		{
			_ = (GClass1)(object)((Class7)null).W(default(BindingFlags), array2, (Type)null, (Type[])null, array);
		}
		catch
		{
			try
			{
				class8 = class8;
			}
			catch
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)@class.j(default(BindingFlags), null, ref reference, null, cultureInfo_, array4, out *(object*)null);
				}
			}
		}
		class31 = (Class0)(object)Class5.Default;
		Class7 class87;
		Class7 class88;
		do
		{
			class87 = @class;
			class88 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class87.t(default(BindingFlags), (FieldInfo[])(object)class88.W(bindingFlags, null, type, null, array), obj2, null) != null);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				while ((object)Class5.Default != null)
				{
					do
					{
						_ = (Class10)(object)Class5.Default;
					}
					while (obj2 != null);
				}
			}
			else
			{
				class6 = class6;
			}
		}
		try
		{
			class31 = class31;
			object object_20 = obj2;
			BindingFlags bindingFlags_67 = bindingFlags;
			Class7 class89 = @class;
			BindingFlags bindingFlags_68 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)((Class7)null).t(object_20, (Type)(object)((Class7)null).j(bindingFlags_67, (MethodBase[])(object)class89.j(bindingFlags_68, methodBase_, ref *(object[]*)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array3, (ParameterModifier[])null)).e((BindingFlags)Class5.Default, null, array3, (ParameterModifier[])(object)Class5.Default), null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null), ref *(object[]*)null, array, cultureInfo_, array4, out object_), (CultureInfo)(object)Class5.Default);
			gClass2 = null;
		}
		finally
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_69 = bindingFlags;
				PropertyInfo[] propertyInfo_15 = (PropertyInfo[])(object)Class5.Default;
				Class7 class90 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)null).W(bindingFlags_69, propertyInfo_15, (Type)(object)((Class7)null).e((BindingFlags)class90.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array4, out object_), (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default), (Type[])(object)Class5.Default, array);
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class31 = null;
				}
				else
				{
					class8 = null;
				}
			}
			goto IL_1ded;
		}
		IL_2796:
		@class = @class;
		class3 = class3;
		class2 = class2;
		_ = (_003CModule_003E)(object)Class5.Default;
		class23 = class23;
		do
		{
			try
			{
				while (obj2 != null)
				{
					_ = Class5.Default;
				}
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
					continue;
				}
				_ = (Struct2)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array, cultureInfo_, (string[])null, out *(object*)null);
				class7 = class7;
				_ = (Class9)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref reference, (ParameterModifier[])@class.t(obj2, type, cultureInfo_), null, null, out object_);
				_ = (Struct2)Class5.Default;
			}
		}
		while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default) != null);
		do
		{
			if (num2 != (UIntPtr)(nuint)0u)
			{
				try
				{
					class27 = class27;
				}
				catch
				{
					_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, array, cultureInfo_, (string[])(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array), null, ref reference, array, cultureInfo_, array4, out *(object*)null), out *(object*)((Class7)null).j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array), (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])null, out *(object*)null)), (CultureInfo)(object)@class.W(bindingFlags, array2, type, null, null), array4, out *(object*)null);
				}
				continue;
			}
			try
			{
				qk = qk;
			}
			finally
			{
				gClass3 = gClass3;
				continue;
			}
		}
		while (obj2 != null);
		UIntPtr num12 = (UIntPtr)Class5.Default;
		num2 = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)num12) + (unchecked((nuint)default(UIntPtr)) + num2)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			try
			{
				try
				{
					@struct = default(Struct1);
					@struct = @struct;
					_ = (GClass3)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array);
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					Class7 class91 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_70 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, array);
					Class7 class92 = @class;
					Class7 obj90 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_71 = bindingFlags;
					MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
					ref object[] object_21 = ref reference;
					Class7 class93 = @class;
					BindingFlags bindingFlags_72 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					Class7 class94 = @class;
					BindingFlags bindingFlags_73 = bindingFlags;
					Type type_17 = (Type)(object)Class5.Default;
					Type[] type_18 = array3;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_74 = (BindingFlags)obj90.j(bindingFlags_71, methodBase_9, ref object_21, (ParameterModifier[])(object)class93.t(bindingFlags_72, fieldInfo_6, class94.W(bindingFlags_73, null, type_17, type_18, (ParameterModifier[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_)).j(bindingFlags, null, ref reference, array, null, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo_), out object_)), null), null, (string[])(object)Class5.Default, out object_);
					Type[] type_19 = array3;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_75 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class91.e(bindingFlags_70, methodBase_, (Type[])(object)class92.e(bindingFlags_74, methodBase_, type_19, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_75, methodBase_, (Type[])(object)((Class7)null).e(bindingFlags, methodBase_, array3, array), (ParameterModifier[])@class.t(obj2, (Type)(object)@class.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, null, cultureInfo_, null, out *(object*)Class5.Default)), cultureInfo_))), null);
					_ = (GClass2)(object)Class5.Default;
					_ = (GClass2)@class.t(null, type, cultureInfo_);
				}
			}
			catch
			{
				while (obj2 != null)
				{
					@struct = default(Struct1);
				}
			}
		}
		try
		{
			if (num2 == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null);
				}
				else
				{
					class7 = (Class8)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		catch
		{
			Class7 class95 = @class;
			BindingFlags bindingFlags_76 = bindingFlags;
			MethodBase[] methodBase_10 = (MethodBase[])(object)Class5.Default;
			ref object[] object_22 = ref *(object[]*)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo_);
			ParameterModifier[] parameterModifier_12 = array;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class95.j(bindingFlags_76, methodBase_10, ref object_22, parameterModifier_12, cultureInfo_, (string[])(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo_), out object_);
		}
		gClass2 = (GClass0)(object)@class.j(bindingFlags, methodBase_, ref reference, array, cultureInfo_, null, out object_);
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					gClass3 = gClass3;
					gClass2 = null;
					_ = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				class3 = null;
				_ = Class5.Default;
				@class = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, array);
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				do
				{
					class23 = class23;
				}
				while (obj2 != null);
			}
			finally
			{
				struct2 = struct2;
				goto end_IL_2d89;
			}
			end_IL_2d89:;
		}
		class31 = class31;
		try
		{
			while (true)
			{
				Class7 class96 = @class;
				BindingFlags bindingFlags_77 = bindingFlags;
				Class7 class97 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class96.t(bindingFlags_77, (FieldInfo[])(object)class97.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_), obj2, null) != null)
				{
					try
					{
						_ = (Class7)(object)((Class7)(object)@class.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj2, (CultureInfo)(object)Class5.Default))).W(bindingFlags, array2, type, array3, null);
					}
					finally
					{
						struct2 = default(Struct2);
						struct2 = struct2;
						continue;
					}
				}
				break;
			}
		}
		catch
		{
			gClass2 = (GClass0)(object)Class5.Default;
			_ = (Qk7)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, null, null, array4, out object_);
		}
		qk = null;
		try
		{
			do
			{
				try
				{
					Class7 class98 = @class;
					BindingFlags bindingFlags_78 = bindingFlags;
					ref object[] object_23 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_13 = array;
					bindingFlags = default(BindingFlags);
					class6 = (Class6)(object)class98.j(bindingFlags_78, null, ref object_23, parameterModifier_13, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, (ParameterModifier[])null), array4, out object_);
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
					Class7 obj97 = (Class7)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj97.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo_);
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			class8 = class8;
			_ = (Class4)(object)Class5.Default;
			qk = null;
			Class7 obj98 = (Class7)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)(object)Class5.Default)).e((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array3, (ParameterModifier[])null), array2, type, array3, (ParameterModifier[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, null, obj2, cultureInfo_)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_)), (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default)).t(obj2, type, cultureInfo_);
			Class7 obj99 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)obj98.t((BindingFlags)obj99.e(bindingFlags, null, null, (ParameterModifier[])@class.t(obj2, type, cultureInfo_)), array5, null, null);
			goto IL_30b9;
		}
		IL_4341:
		num2 = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * num2 == 0)
			{
				class31 = null;
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					try
					{
						_ = (Class2)(object)Class5.Default;
						_ = (GClass3)(object)Class5.Default;
						_ = (Class6)(object)Class5.Default;
					}
					finally
					{
						gClass4 = null;
						goto IL_43a1;
					}
				}
			}
			goto IL_43a1;
		}
	}
}
