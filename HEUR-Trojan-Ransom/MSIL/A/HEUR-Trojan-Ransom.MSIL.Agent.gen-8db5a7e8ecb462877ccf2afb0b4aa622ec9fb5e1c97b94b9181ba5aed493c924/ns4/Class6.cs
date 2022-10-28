using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using A_0024r;
using Dn7;
using Je5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xt9;
using ns1;
using ns10;
using ns11;
using ns12;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns4;

[StandardModule]
[HideModuleName]
internal sealed class Class6
{
	[HelpKeyword("My.Settings")]
	internal static Class5 m => Class5.Default;

	unsafe static void smethod_0()
	{
		Class6 @class = @class;
		@class = @class;
		_ = (Class4)(object)Class5.Default;
		_ = (Struct2)Class5.Default;
		object obj = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
		}
		finally
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)Class5.Default;
					class2 = class2;
					class2 = null;
					qk = null;
					qk = qk;
					_ = (Class7)(object)Class5.Default;
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					@struct = (Struct1)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
				}
				goto IL_00bd;
			}
		}
		IL_00bd:
		UIntPtr num = (UIntPtr)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class3);
		Class7 class4 = class3;
		BindingFlags bindingFlags_ = bindingFlags;
		Class7 class5 = class3;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_2 = bindingFlags;
		FieldInfo[] array2 = array2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		UIntPtr num2 = (UIntPtr)class4.e(bindingFlags_, (MethodBase[])(object)class5.t(bindingFlags_2, array2, obj, cultureInfo_), null, parameterModifier_);
		Class7 class6 = class3;
		BindingFlags bindingFlags_3 = bindingFlags;
		ref object[] object_ = ref *(object[]*)null;
		bindingFlags = default(BindingFlags);
		UIntPtr num3 = (UIntPtr)class6.j(bindingFlags_3, methodBase_, ref object_, parameterModifier_, cultureInfo_, null, out *(object*)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, ((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null), cultureInfo_)).t((BindingFlags)Class5.Default, null, null, cultureInfo_));
		nuint uIntPtr = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		nuint num4 = (nuint)num / checked(unchecked((nuint)num2) * (unchecked((nuint)num3) * uIntPtr) + uIntPtr);
		UIntPtr num5 = (UIntPtr)Class5.Default;
		nuint num6;
		checked
		{
			num6 = unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr));
		}
		UIntPtr num7 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		if (checked(num4 - unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)num5 / checked(num6 - (unchecked((nuint)num7) + uIntPtr))) - uIntPtr))) == 0)
		{
			try
			{
				while (obj != null)
				{
					Class7 class7 = class3;
					BindingFlags bindingFlags_4 = bindingFlags;
					Class7 class8 = class3;
					BindingFlags bindingFlags_5 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_ = (FieldInfo[])((Class7)null).t((object)null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, parameterModifier_), cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class7.e(bindingFlags_4, methodBase_, (Type[])(object)class8.t(bindingFlags_5, fieldInfo_, ((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, parameterModifier_), null), null);
				}
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
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					_ = (Class10)class3.t(Class5.Default, type_, (CultureInfo)((Class7)null).t((object)((Class7)(object)class3.W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, (Type[])class3.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), parameterModifier_)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)class3.t(null, (Type)(object)((Class7)null).t(bindingFlags, array2, (object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), (CultureInfo)(object)Class5.Default)), (Type)(object)class3.t(bindingFlags, null, Class5.Default, cultureInfo_), (CultureInfo)null));
				}
			}
			catch
			{
				try
				{
					GClass3 obj4 = (GClass3)(object)Class5.Default;
					gClass2 = gClass2;
					gClass2 = obj4;
				}
				catch
				{
					qk = null;
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_6 = bindingFlags;
					Class7 class9 = class3;
					Type type_2 = (Type)(object)Class5.Default;
					Class7 class10 = class3;
					BindingFlags bindingFlags_7 = bindingFlags;
					Class7 obj5 = (Class7)(object)class3.t(bindingFlags, null, null, null);
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)obj5.t(bindingFlags, null, Class5.Default, cultureInfo_);
					array3 = null;
					_ = (Struct1)((Class7)null).e(bindingFlags_6, (MethodBase[])null, (Type[])null, (ParameterModifier[])class9.t(obj, type_2, (CultureInfo)(object)class10.j(bindingFlags_7, methodBase_, ref object_, parameterModifier_2, cultureInfo_, array3, out *(object*)null)));
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class12);
		try
		{
			do
			{
				try
				{
					gClass = null;
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					class11 = (Class8)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, null, parameterModifier_));
				}
				finally
				{
					class2 = (Class9)class3.t(Class5.Default, (Type)(object)class3.W(bindingFlags, propertyInfo_, (Type)(object)class3.t(bindingFlags, null, null, null), array, parameterModifier_), cultureInfo_);
					_ = (Struct1)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					gClass3 = gClass3;
					goto IL_05cb;
				}
			}
			while (obj != null)
			{
				class12 = null;
				class12 = null;
			}
			goto IL_05cb;
		}
		IL_238c:
		_ = (GClass1)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_2);
		if (uIntPtr == 0)
		{
			Class7 class13 = class3;
			Class7 obj8 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			BindingFlags bindingFlags_9 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
			Class7 obj9 = (Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_);
			Class7 class14 = class3;
			BindingFlags bindingFlags_10 = bindingFlags;
			Type type_3 = (Type)(object)Class5.Default;
			Type[] type_4 = (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null);
			Class7 obj10 = (Class7)(object)class3.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class13.t(obj8.j(bindingFlags_8, (MethodBase[])((Class7)null).t(obj, (Type)(object)((Class7)null).j(bindingFlags_9, methodBase_2, ref object_, parameterModifier_, cultureInfo_, (string[])null, out *(object*)((Class7)null).t((BindingFlags)obj9.t((BindingFlags)class14.W(bindingFlags_10, propertyInfo_, type_3, type_4, (ParameterModifier[])obj10.t(obj, type_, (CultureInfo)(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default))), null, obj, null), array2, obj, (CultureInfo)class3.t(class3.t(bindingFlags, array2, obj, cultureInfo_), (Type)(object)class3.t((BindingFlags)Class5.Default, array2, null, cultureInfo_), cultureInfo_))), cultureInfo_), ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, null, out object_2), (Type)(object)Class5.Default, cultureInfo_);
		}
		else
		{
			try
			{
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					@struct = (Struct1)Class5.Default;
				}
			}
			catch
			{
				Class7 class15 = class3;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class15.t(bindingFlags, array2, class3.e((BindingFlags)class3.W(bindingFlags, null, type_, null, parameterModifier_), (MethodBase[])(object)Class5.Default, array, null), cultureInfo_);
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				catch
				{
					class12 = (Class0)(object)class3.W(bindingFlags, propertyInfo_, type_, (Type[])(object)class3.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)class3.t(obj, (Type)(object)Class5.Default, null), (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2)).e((BindingFlags)Class5.Default, null, array, parameterModifier_), (Type)(object)class3.t(bindingFlags, array2, obj, cultureInfo_), array, (ParameterModifier[])null), cultureInfo_), null);
				}
			}
			catch
			{
				do
				{
					BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
					CultureInfo cultureInfo_2 = (CultureInfo)(object)class3.W(bindingFlags, null, null, array, parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)((Class7)null).j(bindingFlags_11, (MethodBase[])null, ref object_, parameterModifier_, cultureInfo_2, (string[])(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_), out *(object*)Class5.Default);
				}
				while ((object)Class5.Default != null);
			}
		}
		while ((object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class3.t(bindingFlags, array2, ((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, type_, array, null), cultureInfo_), (Type[])(object)Class5.Default, (ParameterModifier[])null) != null);
		uIntPtr = default(UIntPtr);
		UIntPtr num8 = uIntPtr;
		Class7 class16 = class3;
		BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
		Class7 obj14 = (Class7)(object)class3.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj, cultureInfo_), (string[])(object)class3.e(default(BindingFlags), methodBase_, null, parameterModifier_), out object_2);
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class17);
		checked
		{
			if (unchecked((nuint)num8) * unchecked((nuint)(UIntPtr)class16.j(bindingFlags_12, methodBase_, ref *(object[]*)obj14.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)class3.W((BindingFlags)class3.t(obj, null, cultureInfo_), null, type_, array, null)), (ParameterModifier[])class3.t(Class5.Default, type_, null), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2)) == 0)
			{
				while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_) != null)
				{
					do
					{
						qk = null;
					}
					while (obj != null);
				}
			}
			else
			{
				qk = qk;
				class17 = class17;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class18);
		try
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					class18 = class18;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					_ = (_003CModule_003E)(object)class3.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo_, array3, out object_2);
					_ = (Class4)(object)Class5.Default;
					goto end_IL_2948;
				}
			}
			_ = (Class6)(object)class3.W((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, array, parameterModifier_), propertyInfo_, null, array, parameterModifier_);
			end_IL_2948:;
		}
		finally
		{
			try
			{
				_ = (Class2)(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo_);
			}
			finally
			{
				while ((object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_) != null)
				{
					class11 = class11;
				}
				goto IL_2a43;
			}
		}
		IL_2a43:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			do
			{
				@class = @class;
			}
			while ((object)Class5.Default != null);
		}
		catch
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
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)(object)Class5.Default).t(obj, type_, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					_003CModule_003E = null;
					_ = (GClass2)class3.t(obj, type_, null);
				}
				goto end_IL_2a5b;
			}
			end_IL_2a5b:;
		}
		do
		{
			@class = @class;
		}
		while (obj != null || obj != null);
		UIntPtr num9 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class19);
		checked
		{
			if (unchecked((nuint)num9) - uIntPtr * uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					class19 = class19;
				}
				else
				{
					while ((object)Class5.Default != null)
					{
						class12 = class12;
					}
				}
			}
			else
			{
				class18 = null;
			}
			_ = Class5.Default;
		}
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)class3.t(obj, type_, (CultureInfo)(object)class3.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, null, out object_2)) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				Class7 class20 = class3;
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 class21 = class3;
				BindingFlags bindingFlags_14 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_3 = (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_);
				ref object[] object_3 = ref *(object[]*)class3.j(bindingFlags, null, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out object_2);
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class20.e(bindingFlags_13, (MethodBase[])(object)class21.j(bindingFlags_14, methodBase_3, ref object_3, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array2, (object)class3.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo_), cultureInfo_), cultureInfo_, array3, out *(object*)null), null, parameterModifier_);
			}
		}
		try
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					Class7 class22 = class3;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class22.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
					goto end_IL_2c5c;
				}
				end_IL_2c5c:;
			}
			finally
			{
				Class7 class23 = class3;
				BindingFlags bindingFlags_15 = bindingFlags;
				Class7 obj16 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Type type_5 = (Type)(object)obj16.e(bindingFlags, null, (Type[])(object)((Class7)null).t(bindingFlags, array2, (object)Class5.Default, (CultureInfo)null), null);
				Class7 class24 = class3;
				bindingFlags = default(BindingFlags);
				@class = (Class6)(object)class23.W(bindingFlags_15, null, type_5, null, (ParameterModifier[])(object)class24.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null));
				goto end_IL_2c5b;
			}
			end_IL_2c5b:;
		}
		finally
		{
			_ = (Struct2)Class5.Default;
			goto IL_2d37;
		}
		IL_4621:
		GClass2 gClass4;
		try
		{
			_ = (GClass2)(object)class3.W((BindingFlags)Class5.Default, propertyInfo_, null, array, null);
		}
		finally
		{
			_ = (Class2)(object)Class5.Default;
			Class7 class25 = class3;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class25.t(bindingFlags, array2, obj, cultureInfo_);
			gClass4 = null;
			goto IL_4682;
		}
		IL_05cb:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)class3.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)class3.j(bindingFlags, methodBase_, ref object_, (ParameterModifier[])(object)class3.t((BindingFlags)Class5.Default, (FieldInfo[])(object)class3.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)class3.t((BindingFlags)class3.t(bindingFlags, array2, ((Class7)null).t(obj, type_, (CultureInfo)(object)Class5.Default), cultureInfo_), null, null, cultureInfo_)), obj, (CultureInfo)(object)Class5.Default), cultureInfo_, array3, out *(object*)null);
					@struct = @struct;
					_ = (GClass1)(object)Class5.Default;
				}
			}
			finally
			{
				class11 = null;
				goto IL_073b;
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)class3.t(bindingFlags, array2, null, cultureInfo_);
		}
		finally
		{
			try
			{
				class3 = class3;
			}
			catch
			{
				class12 = null;
			}
			goto IL_073b;
		}
		IL_4444:
		do
		{
			IL_4444_2:
			if (obj != null)
			{
				try
				{
					gClass2 = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto IL_4444_2;
				}
			}
		}
		while (obj != null);
		_ = (GClass0)((Class7)null).t(obj, type_, cultureInfo_);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class8)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo_);
					_ = (Struct2)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_);
					class3 = class3;
				}
				while ((object)((Class7)((Class7)(object)Class5.Default).t(obj, null, cultureInfo_)).e(bindingFlags, methodBase_, null, parameterModifier_) != null);
			}
		}
		while (((Class7)null).t((object)null, type_, cultureInfo_) != null);
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
			}
			else
			{
				gClass = gClass;
			}
		}
		while ((object)Class5.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			if ((UIntPtr)class3.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, null) == (UIntPtr)(nuint)0u)
			{
				Class7 class26;
				do
				{
					class17 = class17;
					qk = qk;
					struct2 = default(Struct2);
					class26 = class3;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class26.j(bindingFlags, methodBase_, ref object_, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_), null, out object_2) != null);
			}
			goto IL_4621;
		}
		IL_0f51:
		_ = (Class4)(object)Class5.Default;
		try
		{
			if (uIntPtr == 0)
			{
				while ((object)Class5.Default != null)
				{
					class12 = class12;
				}
			}
			else
			{
				struct2 = struct2;
				struct2 = default(Struct2);
				struct2 = struct2;
			}
		}
		catch
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			try
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
					_ = (Class6)(object)class3.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
					_003CModule_003E = null;
					_003CModule_003E = null;
				}
				catch
				{
					class2 = class2;
				}
			}
			catch
			{
				try
				{
					gClass2 = null;
				}
				finally
				{
					_ = (GClass0)(object)class3.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
					goto end_IL_0fee;
				}
				end_IL_0fee:;
			}
		}
		catch
		{
			_ = (Struct1)class3.t(Class5.Default, null, cultureInfo_);
		}
		_ = (Class10)((Class7)(object)Class5.Default).t(((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)class3.t(obj, type_, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)class3.W(bindingFlags, propertyInfo_, null, array, null)), type_, null);
		while ((object)Class5.Default != null)
		{
		}
		while (obj != null)
		{
			_ = (Struct2)Class5.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			gClass2 = gClass2;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class2 = class2;
				}
				while ((object)Class5.Default != null);
			}
		}
		catch
		{
		}
		_ = (Class8)(object)Class5.Default;
		_ = (GClass0)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Class7 class27 = class3;
			BindingFlags bindingFlags_16 = bindingFlags;
			ref object[] object_4 = ref *(object[]*)Class5.Default;
			Class7 class28 = class3;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class27.j(bindingFlags_16, null, ref object_4, (ParameterModifier[])(object)class28.e(bindingFlags, methodBase_, array, parameterModifier_), null, array3, out object_2) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)class3.W(bindingFlags, (PropertyInfo[])class3.t(null, (Type)(object)Class5.Default, cultureInfo_), type_, array, null) == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, parameterModifier_);
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Class7 class29 = class3;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class29.W(bindingFlags, propertyInfo_, null, null, null);
			}
			else
			{
				qk = qk;
			}
		}
		else
		{
			do
			{
				try
				{
					class19 = class19;
				}
				finally
				{
					class12 = class12;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			_ = (GClass2)(object)Class5.Default;
		}
		catch
		{
			_ = (Class10)class3.t(obj, null, cultureInfo_);
		}
		while (true)
		{
			if (obj != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class18 = class18;
					class18 = class18;
				}
				else
				{
					@struct = (Struct1)Class5.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])class3.t(obj, type_, null), ref object_, parameterModifier_, cultureInfo_, (string[])null, out object_2) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					UIntPtr num10 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num10 / uIntPtr) * uIntPtr == 0)
					{
						_ = (Class10)(object)Class5.Default;
					}
				}
				catch
				{
					qk = qk;
				}
			}
		}
		else
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)((Class7)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)).t(null, (Type)(object)Class5.Default, cultureInfo_)).t(null, type_, null);
				}
			}
			catch
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					@struct = @struct;
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])(object)class3.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, null), array, (ParameterModifier[])null);
					_ = (Class8)class3.t(class3.e(bindingFlags, null, array, null), null, null);
					goto end_IL_1378;
				}
				end_IL_1378:;
			}
		}
		Class7 class30;
		BindingFlags bindingFlags_17;
		Class7 obj26;
		do
		{
			class3 = class3;
			class30 = class3;
			bindingFlags_17 = bindingFlags;
			obj26 = (Class7)(object)class3.e(bindingFlags, null, array, null);
			bindingFlags = default(BindingFlags);
		}
		while ((object)class30.W((BindingFlags)((Class7)null).W(bindingFlags_17, propertyInfo_, type_, (Type[])(object)obj26.W(bindingFlags, propertyInfo_, (Type)(object)class3.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, cultureInfo_), methodBase_, null, parameterModifier_), array, parameterModifier_), parameterModifier_), propertyInfo_, type_, null, null) != null);
		uIntPtr = default(UIntPtr);
		nuint num11 = checked(uIntPtr + uIntPtr);
		BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
		Class7 obj27 = (Class7)(object)Class5.Default;
		Class7 obj28 = (Class7)(object)class3.t(bindingFlags, array2, obj, cultureInfo_);
		Class7 class31 = class3;
		bindingFlags = default(BindingFlags);
		if (checked(num11 * (unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags_18, (FieldInfo[])obj27.t(obj28.j((BindingFlags)class31.j(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).t(obj, type_, null), (PropertyInfo[])null, type_, array, parameterModifier_), ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out object_2), methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)class3.e(bindingFlags, null, array, parameterModifier_), cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default), null, cultureInfo_), (object)null, (CultureInfo)null)) * uIntPtr * uIntPtr)) == 0)
		{
			while ((object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)Class5.Default, parameterModifier_) != null)
			{
				while ((object)class3.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null) != null)
				{
					@class = null;
					_ = (Class4)(object)Class5.Default;
					@struct = @struct;
				}
			}
		}
		class18 = (Class10)(object)class3.W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out object_2));
		_ = (GClass0)(object)Class5.Default;
		gClass4 = null;
		gClass4 = gClass4;
		try
		{
			_ = (Struct2)Class5.Default;
			_ = (GClass3)(object)Class5.Default;
		}
		catch
		{
			class11 = class11;
			class17 = null;
			class17 = null;
		}
		_ = (Struct1)Class5.Default;
		Class7 class32 = class3;
		Class7 class33 = class3;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)class32.j(default(BindingFlags), null, ref *(object[]*)class33.W(bindingFlags, null, (Type)(object)class3.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type_, array, parameterModifier_), obj, cultureInfo_), array, parameterModifier_), null, cultureInfo_, array3, out *(object*)null);
		qk = qk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class34);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Class7)(object)Class5.Default;
				}
				else
				{
					class12 = class12;
				}
			}
			else
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		catch
		{
			class34 = (Class2)(object)Class5.Default;
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class17 = class17;
					continue;
				}
				Class7 class35 = class3;
				Class7 obj31 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_19 = bindingFlags;
				Class7 class36 = class3;
				BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
				Class7 obj32 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_4 = (MethodBase[])(object)obj32.j(bindingFlags, methodBase_, ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)null);
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
				BindingFlags bindingFlags_21 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				Class7 class37 = class3;
				bindingFlags = default(BindingFlags);
				CultureInfo cultureInfo_3 = (CultureInfo)((Class7)(object)((Class7)null).e(bindingFlags_21, methodBase_5, (Type[])(object)class37.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)class3.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo_, null, out *(object*)((Class7)(object)class3.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_)).t(bindingFlags, array2, Class5.Default, null))), parameterModifier_)).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_);
				string[] string_ = array3;
				BindingFlags bindingFlags_22 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Class7 obj33 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)class35.t(obj, (Type)((Class7)(object)obj31.W(bindingFlags_19, null, (Type)(object)class36.j(bindingFlags_20, methodBase_4, ref *(object[]*)null, parameterModifier_3, cultureInfo_3, string_, out *(object*)((Class7)null).W(bindingFlags_22, propertyInfo_, type_, array, (ParameterModifier[])(object)obj33.e(bindingFlags, methodBase_, array, parameterModifier_))), array, null)).t(Class5.Default, null, cultureInfo_), cultureInfo_);
			}
			catch
			{
				if (uIntPtr == 0)
				{
					gClass2 = gClass2;
				}
				else
				{
					@class = null;
				}
			}
		}
		while (obj != null);
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				checked
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, cultureInfo_)) == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
					else
					{
						Class7 class38 = class3;
						bindingFlags = default(BindingFlags);
						_ = (GClass2)(object)class38.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null);
						_ = (Struct2)Class5.Default;
					}
				}
			}
			finally
			{
				try
				{
					_ = (Class8)(object)class3.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)class3.W(bindingFlags, propertyInfo_, null, null, parameterModifier_), parameterModifier_);
				}
				catch
				{
					Class7 obj35 = (Class7)(object)class3.e(bindingFlags, (MethodBase[])(object)class3.t((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)class3.e(bindingFlags, null, null, parameterModifier_), parameterModifier_, (CultureInfo)null, (string[])null, out object_2), array2, null, null), (Type[])(object)Class5.Default, parameterModifier_);
					bindingFlags = default(BindingFlags);
					class34 = (Class2)(object)obj35.e(bindingFlags, methodBase_, array, parameterModifier_);
				}
				continue;
			}
		}
		while (obj != null);
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				class11 = class11;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			else
			{
				bindingFlags = default(BindingFlags);
				Class7 obj37 = (Class7)((Class7)(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)null)).t(Class5.Default, type_, cultureInfo_);
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj37.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)class3.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)class3.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2)).j((BindingFlags)class3.j((BindingFlags)Class5.Default, (MethodBase[])class3.t(obj, type_, (CultureInfo)(object)class3.W((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)class3.j((BindingFlags)Class5.Default, null, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)class3.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null)), (ParameterModifier[])null, cultureInfo_, array3, out *(object*)null), null, (Type)(object)class3.j(bindingFlags, null, ref object_, null, (CultureInfo)(object)Class5.Default, null, out object_2), array, parameterModifier_)), ref object_, null, cultureInfo_, array3, out *(object*)Class5.Default), (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])class3.t(obj, type_, (CultureInfo)(object)Class5.Default), ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2), null, (string[])(object)Class5.Default, out object_2)));
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				_003CModule_003E = _003CModule_003E;
				_ = (Class4)(object)Class5.Default;
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (GClass3)(object)((Class7)null).e((BindingFlags)((Class7)null).t(obj, type_, cultureInfo_), methodBase_, (Type[])(object)Class5.Default, parameterModifier_);
		}
		while (obj != null)
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				_ = (Class6)class3.t(obj, type_, null);
				continue;
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class34 = null;
				}
				catch
				{
					@class = (Class6)(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_);
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		class34 = class34;
		if (uIntPtr == 0)
		{
			do
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			while (obj != null);
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass2 = gClass2;
					_ = (Class8)(object)Class5.Default;
					_ = (GClass3)(object)class3.e(bindingFlags, methodBase_, null, parameterModifier_);
					qk = null;
				}
			}
			finally
			{
				try
				{
					class34 = class34;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
				goto end_IL_1ed2;
			}
			end_IL_1ed2:;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					@struct = (Struct1)Class5.Default;
				}
			}
			finally
			{
				class18 = class18;
				goto IL_1f5c;
			}
		}
		IL_073b:
		while ((object)Class5.Default != null)
		{
			try
			{
				try
				{
					class12 = class12;
				}
				catch
				{
					gClass3 = (GClass0)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			class12 = class12;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					Class7 obj45 = (Class7)(object)class3.e((BindingFlags)Class5.Default, (MethodBase[])(object)class3.t((BindingFlags)class3.t(bindingFlags, null, obj, cultureInfo_), null, obj, (CultureInfo)(object)Class5.Default), array, parameterModifier_);
					BindingFlags bindingFlags_23 = (BindingFlags)class3.t(bindingFlags, array2, null, null);
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)class3.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])class3.t(obj, type_, cultureInfo_), (Type[])null, parameterModifier_), null, parameterModifier_);
					string[] string_2 = array3;
					object_2 = ref *(object*)null;
					_ = (Class2)(object)((Class7)(object)obj45.j(bindingFlags_23, null, ref *(object[]*)null, parameterModifier_4, cultureInfo_, string_2, out object_2)).t(bindingFlags, null, Class5.Default, cultureInfo_);
				}
				finally
				{
					@struct = (Struct1)Class5.Default;
					continue;
				}
			}
			goto IL_0874;
		}
		IL_3cb8:
		class11 = class11;
		try
		{
			Class7 class39 = class3;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)class39.t(bindingFlags, array2, obj, cultureInfo_);
		}
		catch
		{
			try
			{
				Class7 obj46 = (Class7)((Class7)null).t((object)null, type_, (CultureInfo)null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_24 = bindingFlags;
				Class7 class40 = class3;
				BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
				Class7 class41 = class3;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).W((BindingFlags)obj46.e(bindingFlags_24, null, (Type[])(object)class40.j(bindingFlags_25, methodBase_, ref object_, parameterModifier_, (CultureInfo)(object)class41.e(bindingFlags, null, array, parameterModifier_), array3, out *(object*)null), parameterModifier_), propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		@struct = @struct;
		try
		{
			_ = (Qk7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])null, cultureInfo_, (string[])null, out object_2);
		}
		catch
		{
			try
			{
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						_ = (Class5)(object)class3.t((BindingFlags)((Class7)((Class7)(object)Class5.Default).t(obj, null, null)).t(obj, type_, cultureInfo_), (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])null)), obj, null);
						continue;
					}
					goto end_IL_3dda;
				}
				end_IL_3dda:;
			}
		}
		_ = (Class7)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class18 = (Class10)(object)Class5.Default;
				}
				catch
				{
					class19 = null;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_4444;
		}
		try
		{
			try
			{
				gClass4 = gClass4;
				_ = (Class2)(object)Class5.Default;
			}
			finally
			{
				Class7 class42 = class3;
				BindingFlags bindingFlags_26 = bindingFlags;
				Class7 class43 = class3;
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)((Class7)(object)class43.e(bindingFlags, null, array, (ParameterModifier[])(object)class3.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default))).W(bindingFlags, propertyInfo_, (Type)(object)class3.t(bindingFlags, array2, obj, (CultureInfo)class3.t(obj, type_, null)), null, null);
				Type[] type_6 = (Type[])(object)Class5.Default;
				BindingFlags bindingFlags_27 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class42.W(bindingFlags_26, propertyInfo_2, type_, type_6, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_27, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_), ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)null));
				goto end_IL_3ed1;
			}
			end_IL_3ed1:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				Class7 class44 = class3;
				Class7 class45 = class3;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
				BindingFlags bindingFlags_28 = (BindingFlags)class3.t(default(BindingFlags), null, ((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo_), cultureInfo_);
				FieldInfo[] fieldInfo_2 = array2;
				object object_5 = Class5.Default;
				Class7 obj52 = (Class7)(object)Class5.Default;
				Class7 obj53 = (Class7)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), methodBase_, array, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				Class7 obj54 = (Class7)(object)((Class7)null).t(bindingFlags_28, fieldInfo_2, object_5, (CultureInfo)(object)((Class7)obj52.t(obj, type_, (CultureInfo)(object)obj53.e(bindingFlags, (MethodBase[])(object)class3.t(bindingFlags, null, obj, cultureInfo_), array, parameterModifier_))).e(bindingFlags, methodBase_, (Type[])(object)class3.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo_, array3, out object_2), parameterModifier_));
				Class7 class46 = class3;
				bindingFlags = default(BindingFlags);
				object object_6 = ((Class7)(object)((Class7)null).W((BindingFlags)class46.e(bindingFlags, null, null, (ParameterModifier[])(object)class3.t((BindingFlags)Class5.Default, array2, obj, null)), (PropertyInfo[])null, type_, (Type[])null, parameterModifier_)).W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_);
				Class7 class47 = class3;
				BindingFlags bindingFlags_29 = bindingFlags;
				MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Type type_7 = (Type)(object)class47.j(bindingFlags_29, methodBase_6, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)(object)Class5.Default).W(bindingFlags, null, null, (Type[])((Class7)null).t((object)null, type_, cultureInfo_), parameterModifier_), parameterModifier_, (CultureInfo)(object)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)((Class7)(object)Class5.Default).t(null, type_, null), null, (ParameterModifier[])(object)Class5.Default), (string[])(object)class3.e(bindingFlags, methodBase_, array, null), out *(object*)null), out *(object*)Class5.Default);
				Class7 class48 = class3;
				bindingFlags = default(BindingFlags);
				Class7 obj55 = (Class7)(object)((Class7)(object)class48.W(bindingFlags, propertyInfo_, null, array, parameterModifier_)).e(bindingFlags, null, array, null);
				BindingFlags bindingFlags_30 = bindingFlags;
				Class7 obj56 = (Class7)((Class7)null).t(obj, type_, cultureInfo_);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)(object)class44.j((BindingFlags)class45.W(default(BindingFlags), propertyInfo_3, null, (Type[])(object)((Class7)null).j(default(BindingFlags), (MethodBase[])obj54.t(object_6, type_7, (CultureInfo)(object)obj55.t(bindingFlags_30, null, obj56.t(bindingFlags, null, class3.W((BindingFlags)((Class7)null).t((object)Class5.Default, type_, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo_)), (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), cultureInfo_), (CultureInfo)(object)Class5.Default)), ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out *(object*)null), parameterModifier_), methodBase_, ref *(object[]*)Class5.Default, null, null, array3, out object_2)).W(bindingFlags, propertyInfo_, type_, null, null);
				_ = (Class2)(object)Class5.Default;
			}
			goto IL_4444;
		}
		IL_0874:
		MethodBase[] methodBase_7 = (MethodBase[])(object)class3.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_);
		Class7 class49 = class3;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_31 = bindingFlags;
		Class7 obj57 = (Class7)(object)Class5.Default;
		Class7 obj58 = (Class7)(object)class3.t(bindingFlags, (FieldInfo[])(object)class3.t((BindingFlags)((Class7)(object)Class5.Default).t(null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), null), array2, obj, cultureInfo_), null, cultureInfo_);
		bindingFlags = default(BindingFlags);
		Type[] type_8 = (Type[])(object)((Class7)(object)obj57.t((BindingFlags)obj58.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null), array2, class3.t(obj, type_, cultureInfo_), cultureInfo_)).e(bindingFlags, null, null, parameterModifier_);
		Class7 class50 = class3;
		bindingFlags = default(BindingFlags);
		Type[] type_9 = (Type[])class49.t(null, (Type)(object)((Class7)null).W(bindingFlags_31, propertyInfo_, (Type)null, type_8, (ParameterModifier[])(object)class50.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)class3.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (ParameterModifier[])(object)class3.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_), cultureInfo_, array3, out object_2)), (CultureInfo)(object)Class5.Default);
		Class7 class51 = class3;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)((Class7)null).e(default(BindingFlags), methodBase_7, type_9, (ParameterModifier[])(object)((Class7)(object)class51.j(bindingFlags, null, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)null)).e((BindingFlags)class3.t(null, type_, (CultureInfo)(object)Class5.Default), methodBase_, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo_)));
		try
		{
			UIntPtr num12 = (UIntPtr)((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_);
			uIntPtr = default(UIntPtr);
			checked
			{
				if ((unchecked((nuint)num12) + uIntPtr) * uIntPtr == 0)
				{
					_ = (Class4)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, parameterModifier_);
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / (nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_) == 0)
			{
				while ((object)class3.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, null, (string[])(object)Class5.Default, out object_2) != null)
				{
					Class4 obj59 = (Class4)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, type_, (Type[])null, (ParameterModifier[])null);
					class19 = (Class4)(object)class3.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, array3, out object_2);
					class19 = obj59;
				}
			}
		}
		if (uIntPtr == 0)
		{
			BindingFlags bindingFlags_32;
			Class7 class52;
			BindingFlags bindingFlags_33;
			Type type_10;
			Class7 obj61;
			BindingFlags bindingFlags_34;
			BindingFlags bindingFlags_35;
			Class7 class54;
			do
			{
				if ((UIntPtr)((Class7)null).t((object)Class5.Default, type_, cultureInfo_) != (UIntPtr)(nuint)0u)
				{
					class3 = class3;
				}
				else
				{
					_ = (Class5)(object)class3.e((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), methodBase_, (Type[])(object)Class5.Default, null);
				}
				bindingFlags_32 = bindingFlags;
				class52 = class3;
				bindingFlags_33 = bindingFlags;
				Class7 class53 = class3;
				bindingFlags = default(BindingFlags);
				type_10 = (Type)(object)class53.j(bindingFlags, methodBase_, ref object_, null, cultureInfo_, array3, out *(object*)Class5.Default);
				obj61 = (Class7)class3.t(obj, type_, cultureInfo_);
				bindingFlags_34 = bindingFlags;
				bindingFlags_35 = (BindingFlags)Class5.Default;
				class54 = class3;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).j(bindingFlags_32, methodBase_, ref *(object[]*)class52.W(bindingFlags_33, propertyInfo_, type_10, array, (ParameterModifier[])(object)obj61.e(bindingFlags_34, (MethodBase[])(object)((Class7)null).e(bindingFlags_35, (MethodBase[])null, (Type[])(object)class54.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_), (ParameterModifier[])(object)Class5.Default), (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)class3.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null), cultureInfo_), (ParameterModifier[])(object)Class5.Default)), (ParameterModifier[])null, cultureInfo_, (string[])(object)class3.t(bindingFlags, array2, obj, cultureInfo_), out *(object*)Class5.Default) != null);
		}
		else
		{
			Class7 class55 = class3;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class55.t(bindingFlags, (FieldInfo[])((Class7)(object)class3.e(bindingFlags, null, null, parameterModifier_)).t(obj, type_, cultureInfo_), obj, cultureInfo_);
		}
		_ = (GClass3)class3.t(class3.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), type_, (CultureInfo)(object)Class5.Default);
		try
		{
			if (checked(uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				nuint num13 = uIntPtr;
				UIntPtr num14 = (UIntPtr)Class5.Default;
				Class7 class56 = class3;
				bindingFlags = default(BindingFlags);
				UIntPtr num15 = (UIntPtr)class56.W(bindingFlags, null, null, array, (ParameterModifier[])(object)Class5.Default);
				uIntPtr = default(UIntPtr);
				if (num13 / checked(unchecked((nuint)num14 / ((nuint)num15 / uIntPtr)) + unchecked(uIntPtr / checked(unchecked((nuint)(UIntPtr)Class5.Default) - (uIntPtr + uIntPtr)))) == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					Class7 class57 = class3;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class57.e(bindingFlags, methodBase_, array, parameterModifier_);
				}
			}
		}
		finally
		{
			try
			{
				do
				{
					class12 = null;
				}
				while ((object)class3.W((BindingFlags)Class5.Default, null, type_, array, null) != null);
			}
			finally
			{
				class19 = class19;
				goto IL_0f51;
			}
		}
		IL_1f5c:
		_ = (GClass0)(object)Class5.Default;
		while ((object)class3.j(bindingFlags, (MethodBase[])(object)class3.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), ref object_, parameterModifier_, cultureInfo_, array3, out object_2) != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			else if ((UIntPtr)class3.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out object_2) == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		try
		{
			do
			{
				class12 = null;
			}
			while (obj != null || obj != null);
		}
		catch
		{
			do
			{
				if (uIntPtr != 0)
				{
					qk = null;
					_ = (Class9)(object)class3.W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default);
					_ = (Class4)(object)class3.j(bindingFlags, methodBase_, ref object_, null, cultureInfo_, array3, out object_2);
					qk = qk;
				}
				else
				{
					_ = (Class6)(object)((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])null, out *(object*)null), methodBase_, array, parameterModifier_)).e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default);
				}
			}
			while ((object)Class5.Default != null);
		}
		while (obj != null)
		{
			struct2 = (Struct2)class3.t(obj, type_, cultureInfo_);
			_ = (Class8)(object)Class5.Default;
			Class7 obj63 = (Class7)class3.t(class3.W((BindingFlags)Class5.Default, null, type_, (Type[])(object)class3.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out object_2), parameterModifier_), type_, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_));
			BindingFlags bindingFlags_36 = bindingFlags;
			FieldInfo[] fieldInfo_3 = array2;
			Class7 class58 = class3;
			BindingFlags bindingFlags_37 = bindingFlags;
			Class7 obj64 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, cultureInfo_);
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)obj63.t(bindingFlags_36, fieldInfo_3, null, (CultureInfo)(object)class58.j(bindingFlags_37, (MethodBase[])(object)obj64.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)class3.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, parameterModifier_), cultureInfo_, (string[])(object)class3.W((BindingFlags)Class5.Default, null, type_, null, parameterModifier_), out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, null)), ref object_, null, (CultureInfo)(object)Class5.Default, array3, out object_2));
		}
		gClass2 = gClass2;
		_ = (Class8)(object)Class5.Default;
		_ = (Class8)(object)class3.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2);
		_ = (GClass3)(object)class3.t(bindingFlags, null, null, null);
		class2 = class2;
		class2 = class2;
		_ = (GClass3)(object)Class5.Default;
		class18 = class18;
		try
		{
			_ = (GClass3)(object)Class5.Default;
			_ = (GClass3)(object)Class5.Default;
			class3 = null;
		}
		finally
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (GClass1)(object)Class5.Default;
				}
				goto IL_238c;
			}
		}
		IL_2d37:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		else
		{
			_ = (GClass0)(object)Class5.Default;
			_ = (Class8)class3.t(null, null, (CultureInfo)(object)class3.t(bindingFlags, null, null, cultureInfo_));
			Class7 class59 = class3;
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 class60 = class3;
			BindingFlags bindingFlags_39 = bindingFlags;
			Class7 obj65 = (Class7)(object)((Class7)(object)class3.e(bindingFlags, null, null, parameterModifier_)).W(default(BindingFlags), propertyInfo_, null, array, null);
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class59.e(bindingFlags_38, null, (Type[])(object)class60.W(bindingFlags_39, (PropertyInfo[])(object)obj65.W((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])null, (ParameterModifier[])(object)Class5.Default), propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default), type_, null, null), parameterModifier_);
		}
		Class7 obj66 = (Class7)(object)Class5.Default;
		Class7 obj67 = (Class7)(object)Class5.Default;
		Class7 obj68 = (Class7)(object)Class5.Default;
		Class7 class61 = class3;
		BindingFlags bindingFlags_40 = bindingFlags;
		Class7 obj69 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_41 = (BindingFlags)class3.j((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t(obj, (Type)null, cultureInfo_), ref object_, parameterModifier_, null, array3, out *(object*)null);
		Class7 obj70 = (Class7)(object)((Class7)null).t(default(BindingFlags), array2, obj, (CultureInfo)null);
		bindingFlags = default(BindingFlags);
		Class7 obj71 = (Class7)obj67.t(obj, type_, (CultureInfo)obj68.t(obj, (Type)class61.t(((Class7)null).j(bindingFlags_40, (MethodBase[])((Class7)null).t((object)null, (Type)(object)obj69.W(bindingFlags_41, propertyInfo_, type_, null, (ParameterModifier[])(object)obj70.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_))), cultureInfo_), ref object_, parameterModifier_, cultureInfo_, (string[])null, out *(object*)Class5.Default), (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), cultureInfo_));
		BindingFlags bindingFlags_42 = (BindingFlags)Class5.Default;
		Class7 class62 = class3;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj66.t(obj, null, (CultureInfo)(object)((Class7)null).t((BindingFlags)obj71.j(bindingFlags_42, (MethodBase[])(object)((Class7)(object)((Class7)null).t((BindingFlags)class62.e(bindingFlags, methodBase_, (Type[])(object)class3.e((BindingFlags)Class5.Default, (MethodBase[])class3.t(obj, (Type)(object)Class5.Default, cultureInfo_), array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), (Type)null, (Type[])null, (ParameterModifier[])null), parameterModifier_, (CultureInfo)null, (string[])null, out object_2), array, parameterModifier_)), parameterModifier_), array2, (object)null, cultureInfo_)).W((BindingFlags)Class5.Default, propertyInfo_, type_, null, parameterModifier_), ref object_, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)class3.W(bindingFlags, (PropertyInfo[])(object)class3.W(bindingFlags, propertyInfo_, type_, array, null), (Type)(object)Class5.Default, null, parameterModifier_), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])null, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default, null, out object_2), array2, obj, cultureInfo_)) == (UIntPtr)(nuint)0u)
		{
			struct2 = default(Struct2);
		}
		class2 = class2;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 class63 = class3;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class63.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
			}
		}
		catch
		{
			do
			{
				_ = (Class2)(object)Class5.Default;
				class2 = null;
				_ = (GClass1)(object)Class5.Default;
			}
			while (obj != null);
		}
		UIntPtr num16 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)num16) + uIntPtr) == 0)
		{
			if ((UIntPtr)class3.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array3, out object_2) == (UIntPtr)(nuint)0u)
			{
				class11 = class11;
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					Class7 obj73 = (Class7)(object)Class5.Default;
					Class7 class64 = class3;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)obj73.t(null, null, (CultureInfo)(object)class64.t(bindingFlags, null, null, cultureInfo_))).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, (CultureInfo)class3.t(null, null, (CultureInfo)(object)class3.t((BindingFlags)class3.e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])(object)class3.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default)), array2, null, cultureInfo_)))));
				}
			}
			catch
			{
				class12 = null;
			}
		}
		while (obj != null)
		{
			_ = (Qk7)(object)Class5.Default;
		}
		try
		{
			while (obj != null)
			{
				gClass4 = gClass4;
				_ = (Class2)(object)class3.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out object_2);
				_ = (Class0)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				class18 = (Class10)(object)Class5.Default;
			}
			finally
			{
				_ = (Class4)(object)class3.e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
				_ = (Class4)(object)Class5.Default;
				gClass3 = gClass3;
				goto end_IL_33c0;
			}
			end_IL_33c0:;
		}
		Class7 obj76 = (Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)obj76.W(bindingFlags, null, type_, null, parameterModifier_);
		Class7 class65;
		BindingFlags bindingFlags_43;
		Class7 class66;
		BindingFlags bindingFlags_44;
		Class7 obj78;
		BindingFlags bindingFlags_45;
		Class7 class67;
		Class7 obj79;
		BindingFlags bindingFlags_46;
		Class7 obj80;
		Type type_11;
		Class7 class68;
		Class7 class69;
		checked
		{
			while (obj != null)
			{
				nuint num17 = uIntPtr * uIntPtr;
				nuint num18 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num17 + num18 * (uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr) == 0)
				{
					try
					{
						class34 = null;
						_ = (GClass1)(object)class3.W(bindingFlags, propertyInfo_, null, array, parameterModifier_);
						_ = (Class8)(object)Class5.Default;
					}
					catch
					{
						gClass2 = gClass2;
						_ = (Class5)(object)unchecked(((Class7)(object)Class5.Default).W(bindingFlags, null, type_, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])null, parameterModifier_), (ParameterModifier[])(object)class3.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, cultureInfo_), null, cultureInfo_)));
						struct2 = struct2;
						@class = (Class6)(object)Class5.Default;
					}
				}
			}
			class65 = class3;
			bindingFlags = default(BindingFlags);
			bindingFlags_43 = bindingFlags;
			class66 = class3;
			bindingFlags_44 = bindingFlags;
			obj78 = (Class7)(object)Class5.Default;
			bindingFlags_45 = bindingFlags;
			class67 = class3;
			obj79 = (Class7)(object)Class5.Default;
			bindingFlags_46 = bindingFlags;
			obj80 = (Class7)(object)Class5.Default;
			type_11 = (Type)(object)class3.t(bindingFlags, array2, null, cultureInfo_);
			class68 = class3;
			class69 = class3;
			bindingFlags = default(BindingFlags);
		}
		PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)obj78.W(bindingFlags_45, (PropertyInfo[])class67.t(obj79.e(bindingFlags_46, (MethodBase[])obj80.t(obj, type_11, (CultureInfo)(object)class68.j(default(BindingFlags), (MethodBase[])(object)((Class7)(object)class69.e(bindingFlags, methodBase_, null, parameterModifier_)).e(bindingFlags, methodBase_, array, parameterModifier_), ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, null, out object_2)), null, parameterModifier_), null, cultureInfo_), type_, array, parameterModifier_);
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)class65.t(bindingFlags_43, (FieldInfo[])(object)class66.W(bindingFlags_44, propertyInfo_4, type_, (Type[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out object_2), parameterModifier_), null, null);
		if (uIntPtr == 0)
		{
			Class7 obj81 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj81.t(bindingFlags, array2, obj, null);
		}
		gClass4 = null;
		if (uIntPtr == 0)
		{
			@class = (Class6)(object)class3.t(bindingFlags, (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out object_2), obj, cultureInfo_);
		}
		else
		{
			try
			{
				_ = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo_, (string[])null, out object_2), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out object_2);
			}
			catch
			{
				do
				{
					@class = null;
				}
				while ((object)Class5.Default != null);
			}
		}
		BindingFlags bindingFlags_47 = (BindingFlags)Class5.Default;
		Type type_12 = (Type)class3.t(obj, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null)));
		Class7 obj83 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).W(bindingFlags_47, propertyInfo_, type_12, array, (ParameterModifier[])(object)obj83.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class11 = class11;
			}
			catch
			{
				gClass4 = gClass4;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
		}
		try
		{
			do
			{
				_ = (Qk7)(object)Class5.Default;
			}
			while (obj != null);
		}
		catch
		{
			BindingFlags bindingFlags_48 = bindingFlags;
			FieldInfo[] fieldInfo_4 = array2;
			Class7 class70 = class3;
			bindingFlags = default(BindingFlags);
			Class7 obj85 = (Class7)(object)class70.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)class3.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_), (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_), null);
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)((Class7)null).t(bindingFlags_48, fieldInfo_4, (object)obj85.e((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null), methodBase_, array, null), cultureInfo_);
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				try
				{
					@class = @class;
					_ = (Class4)(object)class3.e(bindingFlags, methodBase_, array, parameterModifier_);
					_ = (Class7)(object)Class5.Default;
					class3 = class3;
				}
				catch
				{
					_ = (GClass3)(object)Class5.Default;
					Class7 obj87 = (Class7)(object)class3.W((BindingFlags)Class5.Default, null, null, (Type[])(object)Class5.Default, null);
					Class7 class71 = class3;
					BindingFlags bindingFlags_49 = bindingFlags;
					Type type_13 = (Type)(object)((Class7)null).e((BindingFlags)class3.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, array3, out *(object*)((Class7)null).W(bindingFlags, propertyInfo_, (Type)class3.t(obj, null, (CultureInfo)(object)Class5.Default), (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), parameterModifier_)), (MethodBase[])(object)class3.t(bindingFlags, array2, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).e((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo_), methodBase_, (Type[])((Class7)null).t((object)null, type_, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), methodBase_, array, parameterModifier_)), (Type[])null, (ParameterModifier[])(object)Class5.Default);
					Class7 class72 = class3;
					BindingFlags bindingFlags_50 = bindingFlags;
					Class7 class73 = class3;
					BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
					Class7 class74 = class3;
					Class7 class75 = class3;
					bindingFlags = default(BindingFlags);
					Type type_14 = (Type)(object)class74.e(default(BindingFlags), methodBase_, (Type[])(object)class75.t(bindingFlags, array2, obj, null), parameterModifier_);
					Class7 class76 = class3;
					Class7 obj88 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, null);
					BindingFlags bindingFlags_52 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class9)obj87.t(obj, (Type)(object)class71.W(bindingFlags_49, propertyInfo_, type_13, array, (ParameterModifier[])(object)class72.j(bindingFlags_50, null, ref object_, null, (CultureInfo)(object)class73.W(bindingFlags_51, null, type_14, (Type[])(object)class76.W((BindingFlags)obj88.j(bindingFlags_52, (MethodBase[])(object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_), ref *(object[]*)Class5.Default, null, cultureInfo_, array3, out *(object*)null), propertyInfo_, type_, array, parameterModifier_), null), null, out object_2)), cultureInfo_);
					class2 = class2;
					_ = (Class6)(object)Class5.Default;
				}
			}
			else if ((object)class3.e(bindingFlags, methodBase_, null, parameterModifier_) == null)
			{
				break;
			}
		}
		try
		{
			gClass4 = gClass4;
		}
		finally
		{
			while (obj != null)
			{
				class3 = class3;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null);
				_ = (Struct2)Class5.Default;
			}
			goto IL_3cb8;
		}
		IL_4682:
		if (uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = null;
				}
				else
				{
					class2 = class2;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (Class0)(object)class3.t(bindingFlags, array2, null, cultureInfo_);
				}
			}
		}
		else
		{
			nuint num19;
			checked
			{
				num19 = uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr;
				uIntPtr = default(UIntPtr);
			}
			if (checked(num19 - uIntPtr) / (nuint)(UIntPtr)class3.t(obj, (Type)(object)Class5.Default, cultureInfo_) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class77 = class3;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class77.j(bindingFlags, methodBase_, ref object_, parameterModifier_, null, array3, out object_2);
				}
				else
				{
					qk = (Qk7)((Class7)null).t((object)Class5.Default, (Type)(object)class3.t(bindingFlags, array2, null, cultureInfo_), (CultureInfo)null);
				}
			}
		}
		_ = (GClass1)((Class7)null).t((object)null, type_, (CultureInfo)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, (ParameterModifier[])null));
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)class3.W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)class3.W((BindingFlags)Class5.Default, propertyInfo_, type_, null, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
			else
			{
				do
				{
					_ = (Class9)(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo_);
				}
				while ((object)((Class7)null).j(bindingFlags, methodBase_, ref object_, parameterModifier_, (CultureInfo)null, array3, out *(object*)null) != null);
			}
		}
		else
		{
			_ = (Class7)((Class7)null).t((object)null, type_, (CultureInfo)(object)Class5.Default);
			class34 = class34;
			_ = (Class10)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo_);
		}
		Class7 class78 = class3;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class78.W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default);
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				Class7 class79;
				BindingFlags bindingFlags_53;
				Class7 obj91;
				do
				{
					@class = @class;
					class79 = class3;
					bindingFlags_53 = (BindingFlags)class3.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
					obj91 = (Class7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null);
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)(object)class79.e(bindingFlags_53, methodBase_, array, (ParameterModifier[])(object)obj91.e(bindingFlags, methodBase_, array, parameterModifier_))).t((BindingFlags)Class5.Default, null, obj, (CultureInfo)(object)Class5.Default) != null);
			}
		}
		else
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					Class7 class80 = class3;
					Class7 class81 = class3;
					bindingFlags = default(BindingFlags);
					_ = (Class6)((Class7)null).t((object)null, (Type)class80.t(null, (Type)(object)((Class7)(object)class81.t(bindingFlags, array2, obj, cultureInfo_)).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)null), cultureInfo_), cultureInfo_);
				}
			}
			while (obj != null);
		}
		do
		{
			class12 = null;
		}
		while (obj != null);
		if (uIntPtr != 0)
		{
			return;
		}
		do
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				class3 = class3;
				continue;
			}
		}
		while ((object)Class5.Default != null);
	}

	unsafe static void smethod_1()
	{
		Class7 @class = (Class7)(object)Class5.Default;
		Class7 class2 = @class;
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
		Type[] array = array;
		GClass3 obj = (GClass3)(object)class2.e(bindingFlags_, methodBase_, array, null);
		GClass3 gClass = null;
		gClass = obj;
		Class9 class3 = class3;
		class3 = class3;
		GClass2 gClass2 = (GClass2)(object)Class5.Default;
		gClass2 = null;
		Class10 class4 = null;
		class4 = class4;
		Class2 class5 = (Class2)(object)Class5.Default;
		class5 = null;
		Class7 class6 = @class;
		BindingFlags bindingFlags_2 = bindingFlags;
		MethodBase[] array2 = array2;
		MethodBase[] methodBase_2 = array2;
		Class7 class7 = @class;
		BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		ref object[] object_ = ref reference;
		ParameterModifier[] array3 = array3;
		ParameterModifier[] parameterModifier_ = array3;
		string[] string_ = null;
		Class7 obj2 = (Class7)(object)class7.j(bindingFlags_3, null, ref object_, parameterModifier_, null, string_, out *(object*)null);
		BindingFlags bindingFlags_4 = bindingFlags;
		Class7 class8 = @class;
		bindingFlags = default(BindingFlags);
		reference = ref *(object[]*)obj2.t(bindingFlags_4, (FieldInfo[])(object)class8.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), null, null);
		ref object[] object_2 = ref reference;
		ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_ = (CultureInfo)(object)Class5.Default;
		ref object object_3 = ref *(object*)null;
		_ = (GClass0)(object)class6.j(bindingFlags_2, methodBase_2, ref object_2, parameterModifier_2, cultureInfo_, string_, out object_3);
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					class9 = null;
					class9 = class9;
				}
				finally
				{
					Class7 class10 = @class;
					BindingFlags bindingFlags_5 = bindingFlags;
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
					obj3 = null;
					object object_4 = obj3;
					cultureInfo = (CultureInfo)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					_ = (GClass2)(object)class10.t(bindingFlags_5, fieldInfo_, object_4, cultureInfo);
					_ = (Struct2)Class5.Default;
					type = type;
					_ = (_003CModule_003E)((Class7)null).t((object)null, type, (CultureInfo)null);
					goto IL_0253;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class2)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)Class5.Default);
				@struct = @struct;
				@struct = @struct;
				_ = (Class6)(object)Class5.Default;
			}
			else
			{
				gClass2 = null;
			}
		}
		goto IL_0253;
		IL_474f:
		while (obj3 != null)
		{
			do
			{
				gClass2 = gClass2;
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			gClass2 = null;
		}
		catch
		{
			while (obj3 != null)
			{
				class9 = (Class4)(object)Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class11);
		try
		{
			if ((UIntPtr)@class.t(null, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
					{
						class5 = class5;
					}
				}
			}
			else
			{
				try
				{
					class11 = class11;
				}
				catch
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj3 != null);
			}
			catch
			{
				while (true)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).e(bindingFlags, array2, array, array3), (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), (CultureInfo)(object)Class5.Default);
					@class = @class;
					class3 = class3;
					qk = null;
					if (obj3 != null)
					{
						continue;
					}
					goto end_IL_47e0;
				}
				end_IL_47e0:;
			}
		}
		Class7 class12 = @class;
		MethodBase[] methodBase_3 = (MethodBase[])(object)((Class7)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null)).t(default(BindingFlags), (FieldInfo[])(object)@class.j(default(BindingFlags), null, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out object_3), Class5.Default, null);
		Class7 class13 = @class;
		bindingFlags = default(BindingFlags);
		UIntPtr num = (UIntPtr)class12.e(default(BindingFlags), methodBase_3, (Type[])(object)class13.e(bindingFlags, null, (Type[])(object)Class5.Default, array3), null);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if (checked(unchecked((nuint)num) + (uIntPtr - uIntPtr)) == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				_ = (Class10)(object)Class5.Default;
				@struct = (Struct2)@class.W((BindingFlags)Class5.Default, array4, null, (Type[])(object)@class.j((BindingFlags)Class5.Default, array2, ref reference, array3, cultureInfo, null, out *(object*)null), array3);
				gClass2 = (GClass2)(object)Class5.Default;
			}
		}
		else
		{
			struct2 = (Struct1)Class5.Default;
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			try
			{
				BindingFlags bindingFlags_6 = bindingFlags;
				MethodBase[] methodBase_4 = (MethodBase[])((Class7)null).t((object)null, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)null).j(bindingFlags_6, methodBase_4, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, array4, type, array, array3), (object)null, cultureInfo), array3, cultureInfo, string_, out object_3);
			}
			catch
			{
				_ = Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class14);
		if (uIntPtr / uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					_ = (GClass2)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null);
					goto IL_4ac3;
				}
			}
			_ = (Class7)(object)Class5.Default;
			_ = (GClass2)(object)Class5.Default;
		}
		else
		{
			class14 = class14;
		}
		goto IL_4ac3;
		IL_24e7:
		_ = (Class6)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		try
		{
			while ((object)@class.t(bindingFlags, null, obj3, null) != null)
			{
				do
				{
					class4 = null;
					_ = (GClass0)(object)@class.e(bindingFlags, array2, null, array3);
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, (ParameterModifier[])(object)Class5.Default), ref reference, null, null, string_, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + (uIntPtr - uIntPtr)) == 0)
				{
					_ = (Class2)(object)@class.t(bindingFlags, array5, obj3, cultureInfo);
				}
			}
		}
		do
		{
			_ = (Class7)(object)@class.t((BindingFlags)@class.e(bindingFlags, array2, null, (ParameterModifier[])(object)Class5.Default), null, null, cultureInfo);
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		try
		{
			while (obj3 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 obj11 = (Class7)(object)@class.t((BindingFlags)Class5.Default, array5, Class5.Default, null);
					BindingFlags bindingFlags_7 = bindingFlags;
					PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
					Class7 obj12 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj11.W(bindingFlags_7, propertyInfo_, (Type)(object)obj12.j(bindingFlags, array2, ref reference, null, (CultureInfo)(object)Class5.Default, null, out object_3), null, array3);
				}
				else
				{
					_ = (Struct2)@class.W(bindingFlags, array4, type, null, array3);
					_ = (Struct1)@class.t(bindingFlags, null, ((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array3), null, null), (FieldInfo[])@class.t(null, type, cultureInfo), obj3, (CultureInfo)(object)Class5.Default), obj3, cultureInfo), cultureInfo);
					gClass4 = null;
					class4 = (Class10)@class.t(obj3, null, cultureInfo);
				}
			}
		}
		finally
		{
			while ((object)@class.t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default) != null)
			{
				class9 = class9;
			}
			goto IL_281d;
		}
		IL_5143:
		try
		{
			try
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					BindingFlags bindingFlags_9 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class15.W(bindingFlags_8, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_9, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])((Class7)@class.t(@class.t(obj3, type, cultureInfo), null, (CultureInfo)@class.t(obj3, (Type)(object)Class5.Default, null))).t(null, type, (CultureInfo)(object)Class5.Default), array3), (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array, (ParameterModifier[])(object)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default)), array, (ParameterModifier[])null), type, array, array3);
					goto end_IL_5145;
				}
				end_IL_5145:;
			}
			finally
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
				}
				catch
				{
					_ = (Class7)(object)@class.W((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array2, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out object_3), array4, type, (Type[])(object)Class5.Default, array3);
				}
				goto end_IL_5144;
			}
			end_IL_5144:;
		}
		catch
		{
			do
			{
				_ = (_003CModule_003E)(object)@class.e(bindingFlags, array2, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])null), (ParameterModifier[])@class.t(null, type, cultureInfo));
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class16);
		do
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class16 = Class5.Default;
				}
			}
			catch
			{
			}
		}
		while ((object)@class.t((BindingFlags)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, (Type[])@class.t(null, null, cultureInfo), null), array5, Class5.Default, (CultureInfo)(object)Class5.Default) != null);
		try
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					@class = null;
					gClass = gClass;
					class9 = null;
					gClass2 = null;
				}
			}
			while (obj3 != null);
		}
		finally
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)@class.t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					class11 = (Class8)((Class7)null).t((object)null, (Type)(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, string_, out *(object*)null), (CultureInfo)null);
					class14 = class14;
				}
			}
			while ((object)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default) != null);
			goto IL_548d;
		}
		IL_1a2b:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					struct2 = default(Struct1);
					struct2 = struct2;
					goto end_IL_1a3e;
				}
				end_IL_1a3e:;
			}
			catch
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags, array2, array, array3), (PropertyInfo[])@class.t(obj3, type, null), type, array, array3);
				}
			}
		}
		try
		{
			while (obj3 != null)
			{
				gClass4 = null;
			}
		}
		catch
		{
			try
			{
				class9 = null;
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class14 = (Class6)((Class7)(object)Class5.Default).t(obj3, null, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					Class7 class17 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj18 = (Class7)(object)((Class7)(object)class17.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array2, null, null);
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj18.e(bindingFlags_10, (MethodBase[])(object)class18.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array4, type, array, (ParameterModifier[])(object)Class5.Default), array, (ParameterModifier[])(object)Class5.Default), null, array3);
					class5 = class5;
					@class = @class;
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		_ = (Class7)(object)Class5.Default;
		try
		{
			try
			{
				_003CModule_003E = null;
			}
			catch
			{
				Class7 obj21 = (Class7)(object)@class.t(default(BindingFlags), array5, obj3, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj21.e(bindingFlags, array2, (Type[])(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).t(@class.t(obj3, null, null), (Type)null, cultureInfo), array3, cultureInfo, string_, out object_3), array3);
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class3 = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
				goto end_IL_1bec;
			}
			end_IL_1bec:;
		}
		finally
		{
			Class7 class19 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class19.j(bindingFlags, array2, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, string_, out object_3) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class14 = (Class6)(object)Class5.Default;
				}
				catch
				{
					class14 = class14;
					_ = (GClass2)(object)Class5.Default;
					class4 = null;
					class5 = null;
				}
			}
			else
			{
				do
				{
					gClass = gClass;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_1d34;
		}
		IL_23b1:
		if (checked(unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array5, null, cultureInfo)) - uIntPtr) == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class3 = null;
					@class = @class;
					gClass = (GClass3)(object)Class5.Default;
				}
				else
				{
					class9 = null;
				}
			}
			finally
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])(object)Class5.Default) != null);
				goto IL_24e7;
			}
		}
		do
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)null) != (UIntPtr)(nuint)0u)
			{
				gClass4 = gClass4;
			}
			else
			{
				@class = (Class7)(object)@class.W((BindingFlags)Class5.Default, array4, type, array, (ParameterModifier[])((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.t(null, null, cultureInfo), array2, array, array3)).t(obj3, null, null));
			}
		}
		while (obj3 != null);
		goto IL_24e7;
		IL_0253:
		Class7 class20 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_11 = bindingFlags;
		MethodBase[] methodBase_5 = array2;
		ref object[] object_5 = ref reference;
		Class7 obj24 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_12 = bindingFlags;
		array4 = array4;
		Class0 class21;
		checked
		{
			if (unchecked((nuint)(UIntPtr)class20.j(bindingFlags_11, methodBase_5, ref object_5, (ParameterModifier[])(object)obj24.W(bindingFlags_12, array4, null, (Type[])((Class7)null).t(obj3, type, (CultureInfo)null), array3), cultureInfo, (string[])((Class7)(object)Class5.Default).t(obj3, null, null), out object_3)) * (uIntPtr - uIntPtr * (unchecked(uIntPtr / checked((uIntPtr - uIntPtr) * uIntPtr)) + uIntPtr)) == 0)
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				catch
				{
					class21 = (Class0)(object)Class5.Default;
					class21 = class21;
				}
				goto IL_0355;
			}
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			finally
			{
				try
				{
					Class5 obj26 = Class5.Default;
					class16 = null;
					class16 = obj26;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
				goto IL_0355;
			}
		}
		IL_1d34:
		try
		{
			while (obj3 != null)
			{
				try
				{
					struct2 = default(Struct1);
					struct2 = struct2;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		catch
		{
			while (@class.t(null, type, null) != null)
			{
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)null).W(bindingFlags, array4, type, (Type[])(object)Class5.Default, array3);
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				_ = (Class8)(object)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)(object)Class5.Default);
				_ = (Class7)(object)Class5.Default;
				_ = (Class9)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, null, array3)).t(null, (Type)(object)Class5.Default, cultureInfo);
			}
			while (obj3 != null);
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				Class7 obj30 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj30.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array3);
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					class21 = class21;
				}
				finally
				{
					struct2 = default(Struct1);
					struct2 = struct2;
					_ = (Struct1)Class5.Default;
					goto end_IL_1e79;
				}
			}
			uIntPtr = default(UIntPtr);
			checked
			{
				if ((uIntPtr - uIntPtr) * unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, array4, (Type)(object)((Class7)null).e(bindingFlags, array2, (Type[])null, array3), (Type[])null, array3)) == 0)
				{
					_ = (Struct1)Class5.Default;
				}
			}
			end_IL_1e79:;
		}
		catch
		{
			if (uIntPtr == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
				gClass2 = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, array3);
				class21 = class21;
				class5 = class5;
			}
		}
		@class = null;
		_003CModule_003E = null;
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
		{
			checked
			{
				while (obj3 != null)
				{
					nuint num2 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num2 * uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array5, Class5.Default, null), (Type[])null, (ParameterModifier[])null)) == 0)
					{
						gClass = gClass;
					}
				}
			}
		}
		gClass = (GClass3)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, array3);
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		finally
		{
			_ = (GClass0)(object)Class5.Default;
			goto IL_203c;
		}
		IL_38b0:
		do
		{
			nuint num3 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num3 / uIntPtr == 0)
			{
				try
				{
					struct2 = (Struct1)Class5.Default;
				}
				finally
				{
					gClass = null;
					continue;
				}
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					class4 = class4;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			_ = (Struct1)Class5.Default;
			class5 = class5;
			_ = (Class8)(object)Class5.Default;
		}
		nuint num4 = uIntPtr;
		checked
		{
			nuint num5 = uIntPtr - uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 * (num5 * uIntPtr) == 0)
			{
				try
				{
					class3 = class3;
				}
				finally
				{
					class16 = class16;
					goto IL_393c;
				}
			}
			goto IL_393c;
		}
		IL_0355:
		try
		{
			_ = (Struct1)Class5.Default;
			qk = qk;
			qk = qk;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (GClass2)(object)@class.e(bindingFlags, array2, array, null);
				}
				finally
				{
					Class7 class22 = @class;
					Class7 obj33 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_13 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					ref object[] object_6 = ref reference;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = bindingFlags;
					array5 = array5;
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)((Class7)null).t(bindingFlags_14, array5, obj3, (CultureInfo)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default));
					Class7 class23 = @class;
					BindingFlags bindingFlags_15 = bindingFlags;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class22.t((BindingFlags)((Class7)(object)obj33.j(bindingFlags_13, methodBase_6, ref object_6, parameterModifier_3, (CultureInfo)(object)class23.j(bindingFlags_15, (MethodBase[])(object)class24.e(bindingFlags, null, array, null), ref reference, array3, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array5, obj3, (CultureInfo)(object)Class5.Default), array3, cultureInfo, string_, out object_3), null, out *(object*)null), null, out object_3)).t(obj3, (Type)(object)Class5.Default, cultureInfo), array5, null, null);
					goto IL_04ee;
				}
			}
			goto IL_04ee;
		}
		IL_04ee:
		while (true)
		{
			if (obj3 != null)
			{
				_ = (Struct2)Class5.Default;
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		class21 = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			UIntPtr num6 = uIntPtr;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_16 = bindingFlags;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			Class7 class25 = @class;
			BindingFlags bindingFlags_17 = (BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default);
			BindingFlags bindingFlags_18 = (BindingFlags)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)null);
			MethodBase[] methodBase_8 = array2;
			ref object[] object_7 = ref reference;
			Class7 class26 = @class;
			BindingFlags bindingFlags_19 = (BindingFlags)((Class7)(object)Class5.Default).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, string_, out object_3);
			Class7 class27 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num6) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags_16, methodBase_7, (Type[])(object)class25.W(bindingFlags_17, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_18, methodBase_8, ref object_7, (ParameterModifier[])(object)class26.e(bindingFlags_19, (MethodBase[])(object)class27.t(bindingFlags, (FieldInfo[])((Class7)null).t((object)null, type, (CultureInfo)null), obj3, cultureInfo), array, array3), cultureInfo, (string[])null, out *(object*)Class5.Default), type, null, array3), (ParameterModifier[])null)) == 0)
				{
					try
					{
						class14 = class14;
						class14 = class14;
						_ = (Class4)(object)Class5.Default;
						_ = (Class7)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo);
						struct2 = default(Struct1);
						struct2 = struct2;
						struct2 = struct2;
					}
					finally
					{
						@class = @class;
						goto IL_06a4;
					}
				}
			}
		}
		goto IL_06a4;
		IL_2ed9:
		nuint num7 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num7 * uIntPtr) == 0)
		{
			UIntPtr num8 = (UIntPtr)Class5.Default;
			Class7 class28 = @class;
			bindingFlags = default(BindingFlags);
			if ((nuint)num8 / checked(unchecked((nuint)(UIntPtr)class28.j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, string_, out object_3)) + uIntPtr) == 0)
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					class9 = null;
				}
			}
			else
			{
				Class7 class29;
				do
				{
					_ = (Class9)(object)Class5.Default;
					class29 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class29.j(bindingFlags, null, ref reference, array3, null, (string[])(object)Class5.Default, out *(object*)null) != null);
			}
		}
		try
		{
			do
			{
				Class7 obj35 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array3)).j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, null, out object_3), null, cultureInfo);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_20 = bindingFlags;
				Class7 obj36 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_21 = (BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, cultureInfo);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_22 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = array4;
				Class7 class30 = @class;
				BindingFlags bindingFlags_23 = (BindingFlags)@class.t(obj3, null, cultureInfo);
				Class7 class31 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num9 = (UIntPtr)obj35.t(bindingFlags_20, (FieldInfo[])(object)obj36.W(bindingFlags_21, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_22, propertyInfo_2, (Type)(object)class30.t(bindingFlags_23, null, null, (CultureInfo)(object)class31.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, null), out *(object*)null)), (Type[])null, array3), (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), obj3, null);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num9) + uIntPtr != 0)
					{
						_ = (Class10)(object)Class5.Default;
					}
					else
					{
						_ = Class5.Default;
					}
				}
			}
			while (obj3 != null);
		}
		catch
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class4 = null;
				}
			}
			while (((Class7)(object)Class5.Default).t(obj3, type, cultureInfo) != null);
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				_ = (Struct1)Class5.Default;
				class14 = null;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					qk = qk;
				}
			}
		}
		while (obj3 != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					gClass3 = gClass3;
				}
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					@struct = @struct;
					_ = (Class6)(object)Class5.Default;
					struct2 = (Struct1)@class.t(bindingFlags, null, null, null);
				}
				else
				{
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class32.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		catch
		{
			_ = (Struct1)Class5.Default;
			_ = (Class4)(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, null, (Type[])(object)Class5.Default, array3);
			class4 = null;
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)class33.W(bindingFlags, array4, type, array, array3);
		}
		class5 = null;
		try
		{
			_ = Class5.Default;
			gClass = (GClass3)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)((Class7)((Class7)null).t((object)Class5.Default, type, cultureInfo)).e((BindingFlags)@class.e(bindingFlags, null, array, null), (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), string_, out *(object*)Class5.Default);
			gClass3 = null;
		}
		catch
		{
			while (true)
			{
				if (obj3 != null)
				{
					Class7 obj40 = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array, (ParameterModifier[])null);
					BindingFlags bindingFlags_24 = bindingFlags;
					MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
					Class7 obj41 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_25 = bindingFlags;
					MethodBase[] methodBase_10 = (MethodBase[])(object)Class5.Default;
					ref object[] object_8 = ref reference;
					ParameterModifier[] parameterModifier_4 = array3;
					CultureInfo cultureInfo_2 = cultureInfo;
					Class7 class34 = @class;
					BindingFlags bindingFlags_26 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array3);
					Class7 class35 = @class;
					BindingFlags bindingFlags_27 = bindingFlags;
					MethodBase[] methodBase_11 = (MethodBase[])(object)@class.t(bindingFlags, null, @class.t(((Class7)null).e(bindingFlags, array2, array, (ParameterModifier[])null), type, cultureInfo), null);
					ref object[] object_9 = ref *(object[]*)Class5.Default;
					Class7 obj42 = (Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, array3);
					bindingFlags = default(BindingFlags);
					Class7 obj43 = (Class7)(object)obj40.j(bindingFlags_24, methodBase_9, ref *(object[]*)obj41.j(bindingFlags_25, methodBase_10, ref object_8, parameterModifier_4, cultureInfo_2, string_, out *(object*)class34.e((BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags_26, (FieldInfo[])(object)class35.j(bindingFlags_27, methodBase_11, ref object_9, (ParameterModifier[])(object)obj42.e(bindingFlags, null, array, array3), (CultureInfo)(object)Class5.Default, string_, out *(object*)@class.t(((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), type, null)), obj3, (CultureInfo)null)).W(bindingFlags, array4, type, array, array3), array2, null, null)), (ParameterModifier[])(object)@class.t(default(BindingFlags), array5, obj3, cultureInfo), (CultureInfo)(object)Class5.Default, null, out *(object*)null);
					bindingFlags = default(BindingFlags);
					_ = (GClass2)obj43.t(((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj3, cultureInfo)), null, cultureInfo);
					class9 = class9;
					class21 = (Class0)(object)Class5.Default;
					qk = null;
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		@struct = @struct;
		try
		{
			_ = (Struct1)Class5.Default;
			gClass2 = gClass2;
			class11 = null;
			@struct = default(Struct2);
		}
		finally
		{
			class9 = class9;
			goto IL_3627;
		}
		IL_4ac3:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (((Class7)null).t((object)Class5.Default, type, cultureInfo) != null)
			{
				do
				{
					class5 = (Class2)@class.t(obj3, (Type)(object)Class5.Default, null);
					_ = (GClass1)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				while (obj3 != null);
			}
			goto IL_4baf;
		}
		try
		{
			_ = (Class10)@class.t(Class5.Default, null, (CultureInfo)(object)@class.t(bindingFlags, null, obj3, cultureInfo));
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)@class.e(bindingFlags, null, array, array3);
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (Struct1)Class5.Default;
			}
			goto IL_4baf;
		}
		IL_203c:
		try
		{
			try
			{
				Class7 class36 = @class;
				Class7 class37 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class36.t((BindingFlags)class37.e(bindingFlags, array2, (Type[])((Class7)null).t(obj3, type, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, null, string_, out object_3)), array5, null, cultureInfo);
			}
			catch
			{
				_ = (GClass0)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
			}
		}
		catch
		{
			_ = (Struct1)Class5.Default;
		}
		try
		{
			_ = (Class0)(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, null, string_, out object_3);
			_ = (Class8)(object)@class.t(bindingFlags, null, obj3, cultureInfo);
			gClass4 = gClass4;
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, array3) == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass2 = gClass2;
				}
				while ((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, string_, out object_3) != null);
			}
			else
			{
				@struct = @struct;
			}
			goto IL_22f4;
		}
		IL_1335:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				if ((UIntPtr)((Class7)null).W(bindingFlags, array4, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_3)) == (UIntPtr)(nuint)0u)
				{
					class5 = class5;
					@class = @class;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + uIntPtr) == 0)
		{
			while (obj3 != null)
			{
				_ = (_003CModule_003E)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (GClass0)(object)((Class7)@class.t(obj3, (Type)@class.t(null, type, null), null)).W((BindingFlags)@class.W(bindingFlags, array4, type, array, array3), null, null, null, null);
					gClass2 = gClass2;
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		if ((UIntPtr)((Class7)(object)((Class7)null).j((BindingFlags)@class.W(bindingFlags, array4, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)Class5.Default)).e(bindingFlags, array2, null, null) == (UIntPtr)(nuint)0u)
		{
			@class = @class;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					Class7 obj47 = (Class7)(object)Class5.Default;
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)obj47.t(class38.j(bindingFlags, array2, ref *(object[]*)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])@class.t(null, type, null), out object_3), array3, cultureInfo, null, out object_3), type, cultureInfo);
					BindingFlags bindingFlags_28 = bindingFlags;
					object object_10 = obj3;
					Class7 class39 = @class;
					object object_11 = obj3;
					Class7 obj48 = (Class7)(object)@class.t((BindingFlags)@class.t(null, (Type)(object)Class5.Default, null), array5, obj3, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags_28, (FieldInfo[])null, object_10, (CultureInfo)class39.t(object_11, (Type)(object)((Class7)null).W((BindingFlags)obj48.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3), (PropertyInfo[])null, type, array, array3), (CultureInfo)@class.t(((Class7)null).t((BindingFlags)@class.j(bindingFlags, array2, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out object_3), (FieldInfo[])null, obj3, cultureInfo), type, cultureInfo)));
				}
			}
		}
		try
		{
			class21 = class21;
		}
		catch
		{
			gClass4 = (GClass1)(object)Class5.Default;
			gClass4 = null;
		}
		@class = @class;
		class9 = class9;
		if (uIntPtr / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			qk = qk;
			_ = (GClass0)(object)Class5.Default;
		}
		@class = @class;
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				try
				{
					gClass = (GClass3)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo)).t((BindingFlags)@class.j(bindingFlags, array2, ref *(object[]*)((Class7)(object)Class5.Default).e((BindingFlags)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, null), array2, null, array3), null, cultureInfo, string_, out object_3), array5, obj3, null);
				}
				finally
				{
					gClass = null;
					struct2 = (Struct1)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, string_, out object_3);
					gClass = (GClass3)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo), array2, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array3, null, string_, out object_3));
					Class7 class40 = @class;
					MethodBase[] methodBase_12 = array2;
					Class7 obj51 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_29 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
					object object_12 = obj3;
					Class7 class41 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class40.j(default(BindingFlags), methodBase_12, ref *(object[]*)null, (ParameterModifier[])(object)obj51.t(bindingFlags_29, fieldInfo_2, object_12, (CultureInfo)(object)class41.e(bindingFlags, null, null, null)), cultureInfo, null, out *(object*)null);
					continue;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Qk7)(object)@class.t(bindingFlags, array5, Class5.Default, null);
		}
		else
		{
			class16 = class16;
		}
		do
		{
			try
			{
				class16 = class16;
			}
			finally
			{
				try
				{
					gClass3 = null;
				}
				finally
				{
					class3 = (Class9)(object)Class5.Default;
					class5 = null;
					@class = (Class7)(object)Class5.Default;
					continue;
				}
			}
		}
		while ((object)@class.t((BindingFlags)Class5.Default, array5, null, (CultureInfo)(object)@class.W(bindingFlags, array4, null, array, (ParameterModifier[])(object)Class5.Default)) != null);
		while (obj3 != null)
		{
			_ = Class5.Default;
			gClass = gClass;
			_ = (Class4)(object)@class.t(bindingFlags, array5, null, null);
		}
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		finally
		{
			while (@class.t(obj3, null, (CultureInfo)(object)Class5.Default) != null)
			{
			}
			goto IL_1a2b;
		}
		IL_06a4:
		@struct = @struct;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
			catch
			{
				while (obj3 != null)
				{
					gClass2 = gClass2;
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				class4 = null;
			}
		}
		do
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				@class = null;
			}
			else
			{
				class9 = class9;
			}
		}
		while (obj3 != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj3 != null || (object)Class5.Default != null);
		}
		else
		{
			if ((UIntPtr)@class.e(bindingFlags, null, null, null) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass3)(object)@class.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null);
				}
				finally
				{
					class14 = class14;
					goto IL_081b;
				}
			}
			try
			{
				_ = (Class8)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array, null);
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (Class9)@class.t(obj3, type, cultureInfo);
			}
		}
		goto IL_081b;
		IL_3db8:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					class4 = class4;
				}
				catch
				{
					Class7 class42 = @class;
					Class7 obj54 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_13 = array2;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_3 = cultureInfo;
					Class7 obj55 = (Class7)(object)Class5.Default;
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_31 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array5;
					Class7 obj56 = (Class7)(object)Class5.Default;
					object object_13 = obj3;
					Type type_ = type;
					Class7 class44 = @class;
					BindingFlags bindingFlags_32 = bindingFlags;
					MethodBase[] methodBase_14 = array2;
					Class7 class45 = @class;
					BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
					ref object[] object_14 = ref *(object[]*)@class.j((BindingFlags)Class5.Default, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out object_3);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_34 = (BindingFlags)((Class7)null).j(bindingFlags_33, (MethodBase[])null, ref object_14, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, array, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null), array3, cultureInfo, (string[])null, out object_3), (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)((Class7)null).W(bindingFlags, array4, type, array, (ParameterModifier[])(object)Class5.Default));
					MethodBase[] methodBase_15 = array2;
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_35 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array5;
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_36 = (BindingFlags)class43.t(bindingFlags_31, fieldInfo_3, obj56.t(object_13, type_, (CultureInfo)(object)class44.e(bindingFlags_32, methodBase_14, null, (ParameterModifier[])(object)((Class7)(object)class45.e(bindingFlags_34, methodBase_15, (Type[])(object)class46.t(bindingFlags_35, fieldInfo_4, class47.t(bindingFlags, array5, obj3, null), cultureInfo), array3)).W(bindingFlags, array4, null, null, null))), cultureInfo);
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = bindingFlags;
					MethodBase[] methodBase_16 = array2;
					ref object[] object_15 = ref reference;
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class42.j((BindingFlags)obj54.j(bindingFlags_30, methodBase_13, ref *(object[]*)null, parameterModifier_5, cultureInfo_3, (string[])(object)obj55.e(bindingFlags_36, null, (Type[])(object)class48.j(bindingFlags_37, methodBase_16, ref object_15, (ParameterModifier[])(object)class49.W(bindingFlags, array4, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), null, string_, out object_3), array3), out object_3), array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default);
				}
			}
		}
		finally
		{
			class14 = null;
			goto IL_4082;
		}
		IL_4c69:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)@class.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					gClass2 = gClass2;
				}
			}
		}
		else
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					class16 = null;
					class9 = (Class4)(object)Class5.Default;
					class9 = class9;
					gClass4 = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (Class7)(object)@class.W(bindingFlags, array4, type, null, array3);
				}
			}
		}
		while (obj3 != null);
		if (uIntPtr == 0)
		{
			class11 = class11;
		}
		while ((object)Class5.Default != null)
		{
			class11 = class11;
			class3 = null;
			@class = @class;
		}
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class3 = class3;
					@class = (Class7)(object)Class5.Default;
				}
				else
				{
					_ = (Struct1)((Class7)(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_, out *(object*)null)).e(bindingFlags, array2, (Type[])(object)Class5.Default, array3);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			UIntPtr num10 = (UIntPtr)Class5.Default;
			nuint num11 = uIntPtr;
			Class7 obj62 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)num10) - unchecked(num11 / (nuint)(UIntPtr)obj62.e(bindingFlags, null, (Type[])(object)Class5.Default, null))) == 0)
			{
				try
				{
					gClass4 = null;
				}
				catch
				{
					struct2 = default(Struct1);
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					@struct = (Struct2)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)@class.e((BindingFlags)@class.t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default), array2, null, null), array3, null, string_, out *(object*)null);
				}
				else
				{
					gClass3 = null;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class5 = class5;
				gClass4 = null;
				bindingFlags = default(BindingFlags);
				class21 = (Class0)(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array, array3);
			}
			catch
			{
				Class7 class50 = @class;
				BindingFlags bindingFlags_38 = bindingFlags;
				MethodBase[] methodBase_17 = (MethodBase[])((Class7)null).t((object)null, type, (CultureInfo)null);
				ref object[] object_16 = ref reference;
				Class7 class51 = @class;
				BindingFlags bindingFlags_39 = bindingFlags;
				Class7 obj64 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class16 = (Class5)(object)class50.j(bindingFlags_38, methodBase_17, ref object_16, (ParameterModifier[])(object)class51.j(bindingFlags_39, (MethodBase[])(object)obj64.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, null, out object_3), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, string_, out *(object*)null), cultureInfo, string_, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj3, null));
			}
			finally
			{
				_ = (Class9)(object)Class5.Default;
				goto IL_5061;
			}
		}
		goto IL_5061;
		IL_4baf:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)Class5.Default, cultureInfo);
				}
				else
				{
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class52.t(bindingFlags, null, Class5.Default, cultureInfo);
				}
			}
			goto IL_4c69;
		}
		try
		{
			class11 = class11;
		}
		catch
		{
			_ = Class5.Default;
		}
		finally
		{
			while (obj3 != null)
			{
				gClass2 = gClass2;
			}
			goto IL_4c69;
		}
		IL_3627:
		try
		{
			nuint num12 = uIntPtr;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (num12 + (uIntPtr - unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)Class5.Default))) == 0)
				{
					try
					{
						class11 = class11;
					}
					finally
					{
						class11 = (Class8)(object)Class5.Default;
						goto end_IL_3628;
					}
				}
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class53.e(bindingFlags, array2, array, array3);
			}
			end_IL_3628:;
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Struct1)((Class7)null).t((object)@class.e(bindingFlags, array2, array, array3), (Type)null, (CultureInfo)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(default(BindingFlags), array2, ref reference, array3, cultureInfo, string_, out object_3), array, (ParameterModifier[])(object)Class5.Default));
				}
				finally
				{
					class3 = class3;
					goto end_IL_36b0;
				}
			}
			end_IL_36b0:;
		}
		checked
		{
			if (uIntPtr + uIntPtr == 0)
			{
				do
				{
					if (uIntPtr != 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
					else
					{
						_ = (Class7)(object)Class5.Default;
					}
				}
				while (obj3 != null);
			}
			try
			{
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
			}
			_ = (Class9)(object)Class5.Default;
			if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
			{
				if (uIntPtr == 0)
				{
					class5 = null;
				}
				else if (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
					class21 = null;
					_ = (GClass1)(object)Class5.Default;
					_ = (Qk7)(object)@class.t(default(BindingFlags), array5, Class5.Default, cultureInfo);
				}
				goto IL_38b0;
			}
			try
			{
				try
				{
					@class = null;
				}
				finally
				{
					@struct = (Struct2)Class5.Default;
					class14 = class14;
					struct2 = struct2;
					class5 = class5;
					goto end_IL_384f;
				}
				end_IL_384f:;
			}
			finally
			{
				class4 = class4;
				goto IL_38b0;
			}
		}
		IL_4082:
		try
		{
			if (uIntPtr / uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					Class7 class54 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
					ref object[] object_17 = ref reference;
					ParameterModifier[] parameterModifier_6 = array3;
					string[] string_2 = (string[])((Class7)null).t((object)null, (Type)null, cultureInfo);
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class54.j(bindingFlags_40, methodBase_18, ref object_17, parameterModifier_6, null, string_2, out *(object*)class55.t(bindingFlags_41, (FieldInfo[])((Class7)null).t((object)class56.e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array2, array, (ParameterModifier[])(object)Class5.Default), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), type, cultureInfo), Class5.Default, null));
				}
				else
				{
					_ = (GClass3)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, array3, cultureInfo, string_, out *(object*)Class5.Default);
				}
			}
		}
		finally
		{
			UIntPtr num13 = (UIntPtr)Class5.Default;
			nuint num14 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num15 = uIntPtr / (nuint)(UIntPtr)((Class7)null).t((object)((Class7)null).e(bindingFlags, array2, array, array3), (Type)null, cultureInfo);
			Class7 class57 = @class;
			Class7 class58 = @class;
			Type type_2 = type;
			Type[] type_3 = array;
			Class7 obj69 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			checked
			{
				nuint num16 = num14 - unchecked(num15 / (nuint)(UIntPtr)class57.j(default(BindingFlags), (MethodBase[])(object)class58.W(default(BindingFlags), null, type_2, type_3, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)obj69.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null), (FieldInfo[])null, (object)Class5.Default, cultureInfo)), ref reference, null, null, null, out *(object*)null)) - uIntPtr;
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)num13) * unchecked(checked(num16 * unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) - uIntPtr) / uIntPtr) == 0)
				{
					Class7 class59 = @class;
					unchecked
					{
						BindingFlags bindingFlags_42 = (BindingFlags)Class5.Default;
						FieldInfo[] fieldInfo_5 = array5;
						object object_18 = ((Class7)null).t((object)null, type, cultureInfo);
						Class7 class60 = @class;
						BindingFlags bindingFlags_43 = (BindingFlags)Class5.Default;
						PropertyInfo[] propertyInfo_3 = array4;
						Type type_4 = type;
						Type[] type_5 = array;
						bindingFlags = default(BindingFlags);
						Class7 obj70 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)(object)@class.t(bindingFlags, array5, @class.j(bindingFlags, array2, ref *(object[]*)@class.j((BindingFlags)((Class7)(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, null, null, out *(object*)((Class7)(object)@class.W(bindingFlags, null, (Type)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, array3), array, null)).t(null, type, (CultureInfo)(object)@class.j(bindingFlags, array2, ref reference, array3, cultureInfo, null, out object_3)))).e((BindingFlags)Class5.Default, array2, array, null), (MethodBase[])(object)@class.t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, null, array3), null, null), array5, null, cultureInfo), ref reference, null, cultureInfo, null, out object_3), array3, null, null, out *(object*)@class.j(bindingFlags, array2, ref *(object[]*)@class.t(bindingFlags, array5, obj3, null), null, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)null, (string[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, array3), out *(object*)Class5.Default), string_, out *(object*)null)), cultureInfo)).W(default(BindingFlags), array4, null, array, array3), ref reference, (ParameterModifier[])null, cultureInfo, string_, out *(object*)@class.t(obj3, type, null));
						bindingFlags = default(BindingFlags);
						@struct = (Struct2)class59.t(bindingFlags_42, fieldInfo_5, object_18, (CultureInfo)(object)class60.W(bindingFlags_43, propertyInfo_3, type_4, type_5, (ParameterModifier[])(object)obj70.j(bindingFlags, (MethodBase[])@class.t(obj3, null, null), ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null)));
					}
				}
				goto IL_4591;
			}
		}
		IL_393c:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass3 = gClass3;
				class3 = class3;
				Class7 class61 = @class;
				Class7 class62 = @class;
				BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_19 = array2;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)(object)((Class7)class61.t(((Class7)(object)class62.j(bindingFlags_44, methodBase_19, ref *(object[]*)((Class7)null).W(bindingFlags, array4, type, array, (ParameterModifier[])null), null, cultureInfo, null, out object_3)).t(obj3, null, cultureInfo), (Type)(object)Class5.Default, null)).t((BindingFlags)@class.W(bindingFlags, null, null, array, null), array5, null, cultureInfo)).W(default(BindingFlags), array4, type, (Type[])(object)Class5.Default, null);
			}
		}
		finally
		{
			Class7 obj71 = (Class7)(object)((Class7)null).e(default(BindingFlags), array2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj71.j((BindingFlags)class63.j((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, array3), null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out object_3), null, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				gClass2 = (GClass2)(object)Class5.Default;
				_ = (GClass2)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null);
				Class7 obj72 = (Class7)(object)Class5.Default;
				Class7 class64 = @class;
				BindingFlags bindingFlags_45 = bindingFlags;
				ref object[] object_19 = ref reference;
				Class7 class65 = @class;
				BindingFlags bindingFlags_46 = bindingFlags;
				MethodBase[] methodBase_20 = array2;
				Class7 obj73 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj74 = (Class7)(object)((Class7)null).j(bindingFlags_45, (MethodBase[])null, ref object_19, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)class65.j(bindingFlags_46, methodBase_20, ref *(object[]*)obj73.t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default), null, cultureInfo), array3, (CultureInfo)(object)Class5.Default, string_, out *(object*)null));
				Class7 class66 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				MethodBase[] methodBase_21 = array2;
				Class7 obj75 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_48 = bindingFlags;
				MethodBase[] methodBase_22 = array2;
				ref object[] object_20 = ref reference;
				ParameterModifier[] parameterModifier_7 = array3;
				CultureInfo cultureInfo_4 = cultureInfo;
				string[] string_3 = (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo), array, array3);
				Class7 obj76 = (Class7)(object)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo);
				BindingFlags bindingFlags_49 = (BindingFlags)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default), array5, null, cultureInfo);
				Class7 obj77 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)(object)obj72.j((BindingFlags)class64.e((BindingFlags)obj74.t(class66.e(bindingFlags_47, methodBase_21, (Type[])(object)obj75.j(bindingFlags_48, methodBase_22, ref object_20, parameterModifier_7, cultureInfo_4, string_3, out *(object*)obj76.j(bindingFlags_49, (MethodBase[])(object)obj77.e(bindingFlags, array2, (Type[])(object)@class.t(bindingFlags, array5, obj3, cultureInfo), (ParameterModifier[])(object)Class5.Default), ref reference, array3, null, string_, out *(object*)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).j(bindingFlags, array2, ref *(object[]*)null, array3, (CultureInfo)null, (string[])null, out object_3), null, cultureInfo, null, out object_3)))), null), (Type)(object)Class5.Default, null), array2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array2, ref reference, array3, cultureInfo, null, out *(object*)null)).W(bindingFlags, array4, null, array, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_3db8;
		}
		IL_22f4:
		while (obj3 != null)
		{
			object object_21 = obj3;
			Type type_6 = (Type)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W((BindingFlags)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)null, array, array3), (PropertyInfo[])null, (Type)(object)Class5.Default, array, (ParameterModifier[])null), obj3, cultureInfo)).t(obj3, type, null);
			Class7 class67 = @class;
			BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
			Type[] type_7 = array;
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			_003CModule_003E = (_003CModule_003E)((Class7)null).t(object_21, type_6, (CultureInfo)(object)class67.e(bindingFlags_50, methodBase_23, type_7, (ParameterModifier[])(object)class68.e(bindingFlags, array2, array, null)));
			gClass3 = (GClass0)(object)Class5.Default;
			_ = (Class2)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, null), array2, array, array3);
		}
		try
		{
			do
			{
				_ = (Qk7)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			while ((object)((Class7)((Class7)null).t(obj3, type, cultureInfo)).W((BindingFlags)Class5.Default, null, (Type)@class.t(obj3, type, null), array, array3) != null)
			{
				if ((UIntPtr)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)null, array3, cultureInfo, string_, out object_3) == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
			}
			goto IL_23b1;
		}
		IL_5061:
		Class7 obj78 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)obj78.t(bindingFlags, array5, null, cultureInfo);
		_ = (Qk7)(object)Class5.Default;
		try
		{
			if (uIntPtr / uIntPtr == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					class9 = class9;
				}
			}
			else
			{
				try
				{
					@class = @class;
				}
				catch
				{
					class4 = (Class10)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array3);
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					class14 = class14;
					_ = (GClass2)(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo);
					_ = Class5.Default;
				}
				finally
				{
					class14 = null;
					goto IL_5143;
				}
			}
			goto IL_5143;
		}
		IL_4591:
		while (obj3 != null)
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				gClass4 = gClass4;
			}
		}
		else
		{
			_ = (Class0)(object)Class5.Default;
		}
		Class7 obj82;
		BindingFlags bindingFlags_51;
		Class7 class69;
		BindingFlags bindingFlags_52;
		MethodBase[] methodBase_24;
		FieldInfo[] fieldInfo_6;
		Class7 class70;
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).e(bindingFlags, array2, array, (ParameterModifier[])null);
				}
				catch
				{
					class21 = class21;
				}
			}
			else
			{
				try
				{
					_ = Class5.Default;
				}
				catch
				{
					_ = (GClass1)((Class7)null).t(obj3, type, cultureInfo);
				}
			}
			obj82 = (Class7)(object)Class5.Default;
			bindingFlags_51 = (BindingFlags)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
			class69 = @class;
			bindingFlags_52 = bindingFlags;
			methodBase_24 = (MethodBase[])(object)Class5.Default;
			fieldInfo_6 = array5;
			class70 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj82.t(bindingFlags_51, (FieldInfo[])(object)class69.e(bindingFlags_52, methodBase_24, (Type[])((Class7)(object)((Class7)null).t(default(BindingFlags), fieldInfo_6, ((Class7)(object)class70.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, cultureInfo, string_, out object_3)).t(obj3, type, cultureInfo), cultureInfo)).t(Class5.Default, null, null), (ParameterModifier[])(object)Class5.Default), obj3, cultureInfo) != null);
		try
		{
			struct2 = struct2;
		}
		finally
		{
			try
			{
				@struct = default(Struct2);
			}
			finally
			{
				qk = qk;
				goto IL_474f;
			}
		}
		IL_29db:
		try
		{
			try
			{
				class21 = null;
			}
			finally
			{
				Class7 obj83 = (Class7)(object)@class.t(bindingFlags, null, obj3, (CultureInfo)(object)Class5.Default);
				BindingFlags bindingFlags_53 = bindingFlags;
				ref object[] object_22 = ref *(object[]*)@class.t(obj3, type, cultureInfo);
				ParameterModifier[] parameterModifier_8 = array3;
				CultureInfo cultureInfo_5 = cultureInfo;
				bindingFlags = default(BindingFlags);
				_003CModule_003E = (_003CModule_003E)(object)obj83.j(bindingFlags_53, null, ref object_22, parameterModifier_8, cultureInfo_5, (string[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)((Class7)(object)@class.e(bindingFlags, (MethodBase[])((Class7)null).t(obj3, type, cultureInfo), (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)((Class7)null).W(bindingFlags, array4, (Type)null, (Type[])null, array3), array5, obj3, cultureInfo), array, null), (ParameterModifier[])(object)Class5.Default)).t(null, type, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array3))).W(bindingFlags, null, null, (Type[])(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), null), type, array, array3), out *(object*)null);
				goto end_IL_29dc;
			}
			end_IL_29dc:;
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class71 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_25 = (MethodBase[])(object)((Class7)null).e((BindingFlags)((Class7)null).e(bindingFlags, array2, array, (ParameterModifier[])null), (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null), array, (ParameterModifier[])(object)Class5.Default);
					Class7 class72 = @class;
					BindingFlags bindingFlags_55 = bindingFlags;
					FieldInfo[] fieldInfo_7 = array5;
					Class7 class73 = @class;
					Class7 obj84 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, array3);
					BindingFlags bindingFlags_56 = bindingFlags;
					Class7 obj85 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)((Class7)null).t((BindingFlags)obj85.W(bindingFlags, array4, null, null, array3), array5, (object)null, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref *(object[]*)null, null, null, string_, out object_3));
					Class7 class74 = @class;
					object object_23 = obj3;
					Class7 obj86 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					object object_24 = class73.j((BindingFlags)obj84.t(bindingFlags_56, fieldInfo_8, ((Class7)class74.t(object_23, null, (CultureInfo)(object)obj86.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null))).t((BindingFlags)@class.e(bindingFlags, array2, array, array3), null, null, (CultureInfo)((Class7)null).t(obj3, type, (CultureInfo)(object)Class5.Default)), (CultureInfo)(object)((Class7)(object)@class.e((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, array4, type, array, (ParameterModifier[])(object)Class5.Default), array2, null, array3)).j(bindingFlags, null, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)), array2, ref reference, array3, (CultureInfo)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, (string[])null, out *(object*)((Class7)(object)Class5.Default).t(Class5.Default, type, (CultureInfo)@class.t(Class5.Default, null, null)))).e((BindingFlags)Class5.Default, array2, null, null), null, out *(object*)null);
					Class7 obj87 = (Class7)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class71.j(bindingFlags_54, methodBase_25, ref *(object[]*)class72.t(bindingFlags_55, fieldInfo_7, object_24, (CultureInfo)(object)obj87.j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)((Class7)null).j(bindingFlags, array2, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array4, (Type)(object)Class5.Default, array, array3), out *(object*)null), string_, out object_3)), array3, cultureInfo, string_, out *(object*)null);
				}
				else
				{
					@class = null;
				}
			}
			finally
			{
				try
				{
					_ = (GClass2)((Class7)null).t((object)null, type, cultureInfo);
				}
				finally
				{
					@struct = @struct;
					goto IL_2ed9;
				}
			}
		}
		IL_548d:
		_ = (Qk7)(object)Class5.Default;
		try
		{
			class16 = class16;
			return;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
				return;
			}
			_ = (Struct1)@class.t(obj3, null, cultureInfo);
			_ = (Qk7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3);
			return;
		}
		IL_281d:
		while (obj3 != null)
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else if ((object)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, array, array3) == null)
				{
					break;
				}
			}
		}
		Class7 class75;
		checked
		{
			try
			{
				gClass2 = (GClass2)(object)Class5.Default;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					nuint num17 = uIntPtr - unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (num17 + uIntPtr == 0)
					{
						gClass4 = null;
						_ = (Class0)(object)Class5.Default;
						gClass2 = gClass2;
					}
				}
			}
			_ = (Struct1)Class5.Default;
			class75 = @class;
			bindingFlags = default(BindingFlags);
		}
		_ = (Class4)(object)class75.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t((BindingFlags)((Class7)null).t((object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, null, out object_3), null, null, out object_3), (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null), type, cultureInfo), (FieldInfo[])(object)@class.e(bindingFlags, null, array, array3), obj3, cultureInfo));
		_ = (Class0)(object)Class5.Default;
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			try
			{
				gClass4 = (GClass1)(object)Class5.Default;
			}
			catch
			{
				gClass4 = null;
				_ = (Class0)((Class7)null).t((object)@class.e((BindingFlags)Class5.Default, null, array, array3), type, cultureInfo);
			}
		}
		finally
		{
			try
			{
			}
			catch
			{
				class9 = class9;
				class4 = null;
				gClass4 = gClass4;
			}
			goto IL_29db;
		}
		IL_081b:
		while (obj3 != null)
		{
			do
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
			while (obj3 != null);
		}
		try
		{
			class4 = null;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass1)(object)@class.j((BindingFlags)((Class7)null).t(obj3, type, (CultureInfo)null), array2, ref *(object[]*)Class5.Default, array3, null, string_, out *(object*)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, array2, ref reference, null, (CultureInfo)(object)Class5.Default, string_, out *(object*)null)));
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					class5 = class5;
					class11 = (Class8)(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)@class.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null, string_, out object_3));
					class11 = class11;
					class21 = class21;
					goto end_IL_082b;
				}
			}
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
			}
			end_IL_082b:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)((Class7)null).W((BindingFlags)Class5.Default, array4, type, (Type[])null, (ParameterModifier[])null);
		}
		_ = (Struct2)((Class7)null).W(default(BindingFlags), array4, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
		Type type_8 = type;
		BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_4 = array4;
		Type type_9 = type;
		Class7 class76 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_58 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = array4;
		Type type_10 = type;
		Type[] type_11 = array;
		BindingFlags bindingFlags_59 = bindingFlags;
		Type type_12 = type;
		Class7 class77 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)((Class7)((Class7)null).t((object)null, type_8, (CultureInfo)(object)((Class7)null).W(bindingFlags_57, propertyInfo_4, type_9, (Type[])(object)class76.W(bindingFlags_58, propertyInfo_5, type_10, type_11, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_59, (PropertyInfo[])null, type_12, (Type[])(object)class77.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, null, cultureInfo)), array3)), array3))).t(obj3, type, null);
		class21 = null;
		Class7 class78 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)class78.e(bindingFlags, array2, null, array3);
		gClass = gClass;
		_ = (Struct2)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
		try
		{
			_ = (Qk7)(object)Class5.Default;
			_ = (GClass0)(object)@class.t((BindingFlags)Class5.Default, array5, Class5.Default, cultureInfo);
			Class7 class79 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj95 = (Class7)(object)class79.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, null, array3), array, (ParameterModifier[])((Class7)(object)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array5, obj3, cultureInfo), (CultureInfo)(object)@class.W((BindingFlags)((Class7)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo)).t(obj3, type, null), array4, type, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), (ParameterModifier[])(object)@class.j((BindingFlags)((Class7)null).j(bindingFlags, array2, ref reference, array3, cultureInfo, (string[])(object)((Class7)((Class7)null).t((object)null, type, (CultureInfo)null)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_3), out *(object*)null), array2, ref reference, array3, null, string_, out *(object*)null)), null, out object_3)).t(obj3, type, null)), (MethodBase[])(object)@class.e(bindingFlags, array2, array, null), ref reference, array3, (CultureInfo)(object)Class5.Default, string_, out *(object*)Class5.Default);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)((Class7)(object)obj95.e(bindingFlags, array2, array, array3)).t((BindingFlags)Class5.Default, null, obj3, (CultureInfo)(object)Class5.Default);
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 class80 = @class;
				Class7 class81 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)((Class7)(object)class80.j(default(BindingFlags), null, ref *(object[]*)class81.t(bindingFlags, array5, obj3, cultureInfo), array3, cultureInfo, string_, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, array2, array, array3))).e(bindingFlags, array2, (Type[])(object)Class5.Default, null);
				_ = (Class6)(object)Class5.Default;
				qk = null;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class10)(object)Class5.Default;
		}
		else
		{
			class14 = class14;
			BindingFlags bindingFlags_60 = bindingFlags;
			ParameterModifier[] parameterModifier_9 = array3;
			CultureInfo cultureInfo_6 = (CultureInfo)(object)Class5.Default;
			Class7 obj97 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)((Class7)null).j(bindingFlags_60, (MethodBase[])null, ref *(object[]*)null, parameterModifier_9, cultureInfo_6, (string[])null, out *(object*)obj97.W(bindingFlags, array4, null, null, array3));
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					_003CModule_003E = null;
					gClass2 = gClass2;
					_ = (GClass1)(object)@class.e(bindingFlags, array2, array, array3);
					_ = (_003CModule_003E)(object)Class5.Default;
					continue;
				}
			}
		}
		Class7 class82 = @class;
		Class7 class83 = @class;
		BindingFlags bindingFlags_61 = bindingFlags;
		Type type_13 = type;
		BindingFlags bindingFlags_62 = (BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null);
		Class7 class84 = @class;
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)class84.t(bindingFlags, null, obj3, cultureInfo);
		Class7 obj98 = (Class7)(object)@class.W((BindingFlags)((Class7)((Class7)null).t(obj3, type, cultureInfo)).t(bindingFlags, array5, Class5.Default, cultureInfo), (PropertyInfo[])(object)((Class7)@class.t(obj3, type, (CultureInfo)(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), null, ref *(object[]*)null, null, cultureInfo, string_, out object_3))).e(default(BindingFlags), array2, array, null), (Type)@class.t(obj3, (Type)((Class7)null).t((object)null, (Type)null, cultureInfo), cultureInfo), null, null);
		MethodBase[] methodBase_26 = array2;
		ParameterModifier[] parameterModifier_10 = array3;
		Class7 class85 = @class;
		BindingFlags bindingFlags_63 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_27 = (MethodBase[])(object)Class5.Default;
		ref object[] object_25 = ref reference;
		ParameterModifier[] parameterModifier_11 = array3;
		Class7 obj99 = (Class7)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null);
		Class7 class86 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_64 = (BindingFlags)((Class7)(object)class86.e(bindingFlags, null, array, null)).e(bindingFlags, null, null, null);
		MethodBase[] methodBase_28 = (MethodBase[])(object)Class5.Default;
		Type[] type_14 = array;
		Class7 class87 = @class;
		Class7 class88 = @class;
		bindingFlags = default(BindingFlags);
		CultureInfo cultureInfo_7 = (CultureInfo)(object)class85.j(bindingFlags_63, methodBase_27, ref object_25, parameterModifier_11, (CultureInfo)(object)((Class7)(object)obj99.e(bindingFlags_64, methodBase_28, type_14, (ParameterModifier[])(object)class87.j((BindingFlags)class88.j(bindingFlags, null, ref *(object[]*)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, array5, null, cultureInfo)).W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, array5, obj3, null), null, null, array3), (string[])(object)Class5.Default, out object_3), array3, null, string_, out *(object*)Class5.Default), array2, ref *(object[]*)null, array3, cultureInfo, string_, out object_3))).t((BindingFlags)Class5.Default, array5, ((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default), null), string_, out *(object*)Class5.Default);
		Class7 class89 = @class;
		FieldInfo[] fieldInfo_9 = (FieldInfo[])(object)Class5.Default;
		Class7 obj100 = (Class7)(object)Class5.Default;
		MethodBase[] methodBase_29 = array2;
		ref object[] object_26 = ref reference;
		CultureInfo cultureInfo_8 = cultureInfo;
		Class7 class90 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)class82.t(class83.W(bindingFlags_61, null, type_13, (Type[])(object)((Class7)null).W(bindingFlags_62, propertyInfo_6, (Type)(object)obj98.j(default(BindingFlags), methodBase_26, ref *(object[]*)null, parameterModifier_10, cultureInfo_7, string_, out *(object*)class89.t(default(BindingFlags), fieldInfo_9, null, (CultureInfo)(object)obj100.j(default(BindingFlags), methodBase_29, ref object_26, null, cultureInfo_8, null, out *(object*)((Class7)(object)class90.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)).W(bindingFlags, null, type, array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array3))))), array, (ParameterModifier[])null), array3), null, cultureInfo);
		class3 = class3;
		try
		{
			try
			{
				do
				{
					_003CModule_003E = (_003CModule_003E)@class.t(obj3, (Type)(object)Class5.Default, null);
				}
				while (obj3 != null);
			}
			finally
			{
				while (((Class7)null).t((object)null, type, cultureInfo) != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				goto end_IL_12d8;
			}
			end_IL_12d8:;
		}
		finally
		{
			struct2 = struct2;
			goto IL_1335;
		}
	}

	unsafe static void smethod_2()
	{
		GClass0 obj = (GClass0)(object)Class5.Default;
		GClass0 gClass = gClass;
		gClass = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = bindingFlags;
					array = null;
					MethodBase[] methodBase_ = array;
					Class7 class2 = @class;
					BindingFlags bindingFlags_3 = bindingFlags;
					array2 = null;
					PropertyInfo[] propertyInfo_ = array2;
					Class7 class3 = @class;
					BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
					Class7 class4 = @class;
					MethodBase[] methodBase_2 = array;
					string[] string_ = (string[])(object)Class5.Default;
					object_ = ref *(object*)null;
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)class4.j(default(BindingFlags), methodBase_2, ref *(object[]*)null, null, null, string_, out object_);
					object object_2 = obj2;
					cultureInfo = cultureInfo;
					Type type_ = (Type)(object)class3.t(bindingFlags_4, fieldInfo_, object_2, cultureInfo);
					array3 = array3;
					MethodBase[] methodBase_3 = (MethodBase[])(object)((Class7)null).e(bindingFlags_2, methodBase_, (Type[])(object)class2.W(bindingFlags_3, propertyInfo_, type_, null, array3), array3);
					ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_ = cultureInfo;
					array4 = array4;
					_ = (Struct1)((Class7)null).j(bindingFlags_, methodBase_3, ref *(object[]*)null, parameterModifier_, cultureInfo_, array4, out object_);
					goto end_IL_0016;
				}
			}
			while ((object)Class5.Default != null)
			{
				@class = @class;
				Class7 class5 = @class;
				bindingFlags = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_5 = bindingFlags;
				FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
				obj2 = obj2;
				_ = (_003CModule_003E)(object)class5.t(bindingFlags_5, fieldInfo_2, obj2, null);
			}
			end_IL_0016:;
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, array2, (Type)null, (Type[])(object)Class5.Default, array3) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class6 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_7 = bindingFlags;
					reference = ref reference;
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)((Class7)(object)((Class7)null).j(bindingFlags_7, (MethodBase[])null, ref reference, array3, cultureInfo, array4, out object_)).j((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, null, null, array4, out object_), (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array4, out object_);
					type = null;
					Class0 obj3 = (Class0)(object)class6.W(bindingFlags_6, propertyInfo_2, type, (Type[])(object)Class5.Default, array3);
					class7 = class7;
					class7 = obj3;
				}
				finally
				{
					_ = (Class0)(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out object_);
					goto IL_0314;
				}
			}
			Class7 class8 = @class;
			BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
			array5 = null;
			if ((UIntPtr)class8.t(bindingFlags_8, array5, ((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), null) == (UIntPtr)(nuint)0u)
			{
				class9 = class9;
				class9 = class9;
			}
			else
			{
				_ = (Qk7)(object)@class.t(bindingFlags, null, obj2, cultureInfo);
			}
			goto IL_0314;
		}
		IL_0314:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array6);
		do
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_9 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = array2;
				Type type_2 = type;
				Class7 class10 = @class;
				object object_3 = obj2;
				Type type_3 = type;
				Class7 obj4 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = bindingFlags;
				Class7 class11 = @class;
				bindingFlags = default(BindingFlags);
				array6 = (Type[])class10.t(object_3, type_3, (CultureInfo)(object)obj4.j(bindingFlags_10, (MethodBase[])(object)class11.e(bindingFlags, null, (Type[])(object)Class5.Default, array3), ref reference, array3, cultureInfo, null, out *(object*)null));
				if ((UIntPtr)((Class7)null).W(bindingFlags_9, propertyInfo_3, type_2, array6, array3) == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
			}
			finally
			{
				_ = (Class9)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
				continue;
			}
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		while ((object)Class5.Default != null)
		{
			qk = qk;
			qk = qk;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			while (obj2 != null)
			{
				do
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
				_ = Class5.Default;
				@class = @class;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
				goto IL_04d1;
			}
		}
		IL_2c76:
		Class4 class12 = class12;
		_ = (Struct2)Class5.Default;
		GClass1 gClass2 = null;
		Class8 class13 = class13;
		class7 = (Class0)@class.t(Class5.Default, type, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class18);
		GClass2 gClass3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			while (obj2 != null)
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 + num == 0)
				{
					gClass3 = null;
				}
			}
			try
			{
				class7 = (Class0)(object)Class5.Default;
				gClass3 = null;
			}
			catch
			{
				nuint num3 = num * unchecked(num / num);
				nuint num4 = unchecked((nuint)(UIntPtr)((Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, null, cultureInfo, array4, out object_)).t(null, null, null)) * (unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo)) - unchecked((nuint)default(UIntPtr)));
				UIntPtr num5 = unchecked((UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, array3));
				num = default(UIntPtr);
				nuint num6 = num4 * (unchecked((nuint)num5) * num);
				nuint num7 = num;
				nuint num8 = unchecked(num / num) * num * unchecked((nuint)(UIntPtr)Class5.Default);
				Class7 obj5 = (Class7)@class.t(obj2, type, null);
				Class7 class14 = @class;
				bindingFlags = default(BindingFlags);
				FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)(object)((Class7)(object)class14.t(bindingFlags, array5, null, cultureInfo)).W(bindingFlags, array2, type, null, array3)).e(bindingFlags, array, array6, array3);
				object object_4 = obj2;
				Class7 class15 = @class;
				MethodBase[] methodBase_4 = array;
				MethodBase[] methodBase_5 = array;
				Class7 class16 = @class;
				Type type_4 = type;
				Class7 class17 = @class;
				bindingFlags = default(BindingFlags);
				if (num3 - (num6 - unchecked(num7 / checked(num8 + unchecked((nuint)(UIntPtr)((Class7)(object)obj5.t(default(BindingFlags), fieldInfo_3, object_4, (CultureInfo)(object)class15.j(default(BindingFlags), methodBase_4, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)((Class7)(object)((Class7)null).j(default(BindingFlags), methodBase_5, ref *(object[]*)((Class7)class16.t(null, type_4, (CultureInfo)(object)class17.j(bindingFlags, array, ref reference, array3, cultureInfo, null, out *(object*)null))).t(obj2, type, null), array3, (CultureInfo)null, array4, out object_)).t(obj2, null, cultureInfo)).W((BindingFlags)Class5.Default, array2, null, null, array3), (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, Class5.Default, cultureInfo)), array4, out *(object*)null))).t(null, type, cultureInfo))))) == 0)
				{
					num = default(UIntPtr);
					unchecked
					{
						if (num == 0)
						{
							gClass3 = (GClass2)(object)@class.e(bindingFlags, array, (Type[])(object)@class.j((BindingFlags)Class5.Default, array, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out object_), array3);
							_ = (Qk7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, array4, out object_);
						}
						else
						{
							class18 = class18;
						}
					}
				}
			}
			gClass4 = gClass4;
		}
		do
		{
			if (num != 0)
			{
				try
				{
					Class7 obj7 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)(object)obj7.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.W((BindingFlags)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)null).t(obj2, type, cultureInfo), cultureInfo), null, null, null, array3), (CultureInfo)(object)Class5.Default, array4, out object_)).t((BindingFlags)Class5.Default, array5, obj2, null);
				}
				catch
				{
					gClass3 = null;
				}
			}
			else
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
					gClass3 = gClass3;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		while (obj2 != null);
		Class2 class19;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class19 = (Class2)(object)Class5.Default;
			}
			catch
			{
				@class = @class;
			}
		}
		gClass4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class20);
		checked
		{
			while ((object)Class5.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) - num == 0)
					{
						gClass = gClass;
						continue;
					}
					_ = Class5.Default;
					_ = (Class8)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, array6, array3);
					@class = null;
					gClass2 = gClass2;
				}
			}
			_ = (Class0)(object)Class5.Default;
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gClass = gClass;
					_ = (GClass1)(object)((Class7)null).e(unchecked((BindingFlags)@class.t(bindingFlags, null, obj2, cultureInfo)), (MethodBase[])null, array6, array3);
				}
			}
			try
			{
				do
				{
					class20 = class20;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Class6)(object)Class5.Default;
						Class7 class21 = @class;
						bindingFlags = default(BindingFlags);
						_ = (_003CModule_003E)(object)((Class7)(object)class21.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, array6, (ParameterModifier[])(object)@class.e(bindingFlags, array, array6, array3));
					}
					else
					{
						class9 = class9;
					}
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			do
			{
				if (unchecked((nuint)(UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, array, array6, array3)) + num != 0)
				{
					_ = (Struct2)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out *unchecked((object*)Class5.Default));
				}
			}
			while ((object)Class5.Default != null);
		}
		do
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class12 = null;
				}
			}
			catch
			{
				_ = Class5.Default;
			}
		}
		while (obj2 != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (Class10)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class22);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)@class.t(bindingFlags, null, null, null);
					_ = (Class9)(object)Class5.Default;
					class22 = class22;
				}
			}
			else
			{
				do
				{
					_ = (Struct1)((Class7)null).t((BindingFlags)@class.t(obj2, null, cultureInfo), array5, obj2, (CultureInfo)null);
				}
				while (obj2 != null);
			}
		}
		catch
		{
			_ = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, null, array3);
			_ = (Qk7)(object)Class5.Default;
			@struct = @struct;
		}
		UIntPtr num9 = num;
		num = default(UIntPtr);
		if ((nuint)num9 / num == 0)
		{
			_ = (Class7)(object)Class5.Default;
		}
		else
		{
			try
			{
				class22 = class22;
				gClass = gClass;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class23 = @class;
					BindingFlags bindingFlags_11 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array5;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class23.t(bindingFlags_11, fieldInfo_4, class24.W(bindingFlags, array2, null, (Type[])((Class7)null).t(obj2, type, (CultureInfo)null), array3), cultureInfo);
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				do
				{
					class19 = null;
				}
				while (obj2 != null);
			}
			finally
			{
				do
				{
					BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
					ref object[] object_5 = ref *(object[]*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array6, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_13 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = array2;
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj16 = (Class7)(object)((Class7)null).j(bindingFlags_12, (MethodBase[])null, ref object_5, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags_13, propertyInfo_4, (Type)(object)class25.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array6, null), array6, array3), array, array6, array3), cultureInfo, (string[])(object)@class.j(bindingFlags, array, ref reference, array3, null, array4, out object_), out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = bindingFlags;
					ref object[] object_6 = ref reference;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					Class7 class26 = @class;
					Class7 obj17 = (Class7)(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_), (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), ref reference, array3, cultureInfo, (string[])null, out object_);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj16.j(bindingFlags_14, null, ref object_6, parameterModifier_2, (CultureInfo)class26.t(obj17.W(bindingFlags, null, null, array6, array3), null, cultureInfo), array4, out *(object*)null);
				}
				while (obj2 != null);
				goto IL_36c0;
			}
		}
		goto IL_36c0;
		IL_42c0:
		do
		{
			_ = (GClass3)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
		}
		while (obj2 != null);
		@struct = (Struct2)Class5.Default;
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class27.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null), array6, null), ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				class7 = class7;
			}
		}
		while (obj2 != null || obj2 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			class13 = class13;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (Class10)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3);
					gClass3 = gClass3;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					Class7 obj18 = (Class7)(object)Class5.Default;
					object object_7 = @class.W((BindingFlags)((Class7)null).t(obj2, type, cultureInfo), null, type, null, null);
					Class7 class28 = @class;
					BindingFlags bindingFlags_15 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array2;
					BindingFlags bindingFlags_16 = (BindingFlags)((Class7)null).e((BindingFlags)((Class7)(object)@class.j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)@class.t(bindingFlags, array5, obj2, cultureInfo), array4, out *(object*)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)@class.e((BindingFlags)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, array6, (ParameterModifier[])(object)Class5.Default), null, array6, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(default(BindingFlags), array, null, array3))).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3), null, cultureInfo))).t((BindingFlags)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), array5, obj2, null), (MethodBase[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), (Type[])(object)@class.j(default(BindingFlags), array, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out object_), (ParameterModifier[])(object)Class5.Default);
					Class7 class29 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)obj18.t(object_7, (Type)(object)class28.W(bindingFlags_15, propertyInfo_5, (Type)(object)((Class7)null).j(bindingFlags_16, (MethodBase[])(object)class29.t(bindingFlags, array5, obj2, cultureInfo), ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null, array3), null);
				}
			}
			else
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class19 = class19;
				_ = (Class9)(object)Class5.Default;
				_ = (Struct2)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
			}
			else
			{
				while ((object)@class.t(bindingFlags, null, Class5.Default, cultureInfo) != null)
				{
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])null);
				}
			}
		}
		catch
		{
			if ((UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, null, type, (Type[])((Class7)@class.t(obj2, (Type)(object)Class5.Default, null)).t(obj2, null, cultureInfo), array3), ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array4, out object_) == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked(num / unchecked((nuint)default(UIntPtr)))) == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		class22 = class22;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_17 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)@class.W((BindingFlags)@class.e(bindingFlags, array, array6, array3), array2, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, null)).t(bindingFlags, array5, null, cultureInfo), null, array3);
					BindingFlags bindingFlags_18 = bindingFlags;
					MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
					Class7 obj21 = (Class7)(object)Class5.Default;
					Type type_5 = type;
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class30.e(bindingFlags_17, methodBase_6, (Type[])(object)((Class7)null).e(bindingFlags_18, methodBase_7, (Type[])null, (ParameterModifier[])obj21.t(null, type_5, (CultureInfo)(object)((Class7)null).e((BindingFlags)class31.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), (MethodBase[])null, (Type[])(object)Class5.Default, array3))), array3);
				}
				finally
				{
					gClass2 = gClass2;
					gClass4 = null;
					_ = (Struct2)Class5.Default;
					goto end_IL_4793;
				}
				end_IL_4793:;
			}
			finally
			{
				do
				{
					qk = null;
					_ = (Struct2)@class.j(bindingFlags, array, ref *(object[]*)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), null, (CultureInfo)(object)Class5.Default, null, out object_);
					class7 = (Class0)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
				goto IL_4925;
			}
		}
		goto IL_4925;
		IL_1f13:
		_ = (Class6)(object)Class5.Default;
		try
		{
			if (num == 0)
			{
				try
				{
					gClass2 = null;
				}
				finally
				{
					@struct = @struct;
					qk = qk;
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class32.t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, null, null, cultureInfo), obj2, (CultureInfo)(object)Class5.Default);
					class9 = (Class9)(object)Class5.Default;
					goto end_IL_1f1e;
				}
			}
			try
			{
				_ = (GClass0)(object)((Class7)null).e((BindingFlags)((Class7)(object)((Class7)(object)@class.e(bindingFlags, null, null, array3)).j((BindingFlags)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, type, array6, array3), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, (CultureInfo)(object)@class.W(default(BindingFlags), array2, null, null, null), array4, out object_)).t(null, (Type)(object)Class5.Default, cultureInfo), array, (Type[])null, (ParameterModifier[])(object)Class5.Default);
				class9 = (Class9)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj2, cultureInfo);
			}
			catch
			{
				_ = (Class4)@class.t(null, type, cultureInfo);
				_ = (Class9)(object)Class5.Default;
				class9 = class9;
			}
			end_IL_1f1e:;
		}
		finally
		{
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)class33.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj2, null, (CultureInfo)((Class7)(object)Class5.Default).t(@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, (object)@class.j(bindingFlags, array, ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out object_), (CultureInfo)null), null, array4, out object_), type, cultureInfo)), array6, array3);
			goto IL_2166;
		}
		IL_04d1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		while ((object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null) != null)
		{
			num = num;
			if (num == 0)
			{
				class18 = class18;
				class18 = null;
				continue;
			}
			Struct1 obj23 = (Struct1)Class5.Default;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct1)((Class7)null).W(bindingFlags, array2, type, (Type[])null, array3);
			struct2 = obj23;
		}
		try
		{
			class22 = class22;
			class22 = class22;
		}
		catch
		{
			nuint num10 = num;
			num = default(UIntPtr);
			if (checked(num10 - num) == 0)
			{
				UIntPtr num11 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if ((nuint)num11 / num == 0)
				{
					qk = qk;
				}
			}
			else
			{
				Class7 class34 = @class;
				BindingFlags bindingFlags_19 = bindingFlags;
				Class7 obj24 = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)(object)@class.t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)Class5.Default), (Type[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, (CultureInfo)null, array4, out object_), (ParameterModifier[])null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_20 = bindingFlags;
				Class7 obj25 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_21 = bindingFlags;
				MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class34.e(bindingFlags_19, (MethodBase[])(object)obj24.j(bindingFlags_20, (MethodBase[])(object)obj25.e(bindingFlags_21, methodBase_8, null, (ParameterModifier[])(object)class35.j(bindingFlags, array, ref *(object[]*)null, array3, null, array4, out object_)), ref reference, array3, cultureInfo, array4, out *(object*)@class.j(bindingFlags, array, ref reference, null, cultureInfo, array4, out *(object*)null)), array6, array3);
				_ = (Class9)(object)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, array6, array3);
				Class7 class36 = @class;
				object object_8 = obj2;
				Class7 obj26 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_22 = (BindingFlags)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.W(bindingFlags, null, null, array6, (ParameterModifier[])(object)Class5.Default));
				Class7 class37 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class36.t(default(BindingFlags), null, object_8, (CultureInfo)(object)obj26.j(bindingFlags_22, (MethodBase[])(object)class37.t(bindingFlags, array5, obj2, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null));
			}
		}
		while (obj2 != null)
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				class20 = null;
				class20 = class20;
			}
		}
		while (obj2 != null)
		{
			nuint num12 = num;
			num = default(UIntPtr);
			if (checked(num12 * num) == 0)
			{
				@struct = (Struct2)Class5.Default;
				@struct = default(Struct2);
			}
		}
		try
		{
			_ = (Class0)(object)Class5.Default;
			_ = (_003CModule_003E)(object)@class.t(bindingFlags, array5, obj2, cultureInfo);
		}
		catch
		{
			Class7 class38 = @class;
			BindingFlags bindingFlags_23 = bindingFlags;
			FieldInfo[] fieldInfo_5 = array5;
			object object_9 = @class.t(null, (Type)(object)Class5.Default, null);
			Class7 class39 = @class;
			BindingFlags bindingFlags_24 = bindingFlags;
			MethodBase[] methodBase_9 = array;
			ref object[] object_10 = ref *(object[]*)@class.e(bindingFlags, array, array6, array3);
			ParameterModifier[] parameterModifier_3 = array3;
			CultureInfo cultureInfo_2 = cultureInfo;
			string[] string_2 = (string[])@class.t(obj2, null, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class38.t(bindingFlags_23, fieldInfo_5, object_9, (CultureInfo)(object)class39.j(bindingFlags_24, methodBase_9, ref object_10, parameterModifier_3, cultureInfo_2, string_2, out *(object*)((Class7)null).W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3)));
		}
		if (num == 0)
		{
			@struct = @struct;
		}
		nuint num13 = num;
		num = default(UIntPtr);
		checked
		{
			if (num13 + num == 0)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				catch
				{
					class9 = (Class9)(object)@class.t(bindingFlags, null, obj2, null);
				}
				finally
				{
					nuint num14 = num;
					num = default(UIntPtr);
					nuint num15 = num - num;
					Class7 class40 = @class;
					FieldInfo[] fieldInfo_6 = array5;
					Class7 class41 = @class;
					MethodBase[] methodBase_10 = array;
					ref object[] object_11 = ref *unchecked((object[]*)@class.t(obj2, type, null));
					Class7 class42 = @class;
					bindingFlags = default(BindingFlags);
					if (num14 - unchecked(num15 / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)class40.t(default(BindingFlags), fieldInfo_6, class41.j(default(BindingFlags), methodBase_10, ref object_11, (ParameterModifier[])(object)class42.e(bindingFlags, null, array6, null), cultureInfo, null, out object_), null)))) == 0)
					{
						_ = (Class6)(object)Class5.Default;
					}
					else
					{
						_ = (Struct1)Class5.Default;
						_ = (GClass3)(object)@class.e(bindingFlags, array, array6, (ParameterModifier[])(object)@class.t(default(BindingFlags), null, null, null));
						bindingFlags = default(BindingFlags);
						_ = (Qk7)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, (CultureInfo)(object)((Class7)null).t(unchecked((BindingFlags)Class5.Default), (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo), (string[])null, out object_);
						gClass2 = gClass2;
						gClass2 = gClass2;
					}
					goto IL_0a5a;
				}
			}
			goto IL_0a5a;
		}
		IL_37dd:
		while (obj2 != null)
		{
			try
			{
				while ((object)@class.e(bindingFlags, null, array6, null) != null)
				{
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class43.j(bindingFlags, array, ref reference, array3, cultureInfo, null, out *(object*)null);
				}
			}
			catch
			{
				Class7 class44 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class44.e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, (CultureInfo)null, (string[])null, out object_), (Type[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array3, null, (string[])(object)Class5.Default, out *(object*)null), array3);
			}
		}
		while (obj2 != null)
		{
			try
			{
				do
				{
					class9 = null;
				}
				while (obj2 != null);
			}
			finally
			{
				_ = (Class9)(object)@class.W(bindingFlags, null, type, array6, array3);
				continue;
			}
		}
		while (obj2 != null)
		{
		}
		if ((UIntPtr)@class.t((BindingFlags)Class5.Default, array5, ((Class7)null).e(bindingFlags, (MethodBase[])null, array6, array3), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		try
		{
			try
			{
				@class = null;
			}
			catch
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		catch
		{
			class12 = class12;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
			}
			finally
			{
				while (obj2 != null)
				{
					Class7 class45 = @class;
					object object_12 = obj2;
					Class7 class46 = @class;
					BindingFlags bindingFlags_25 = bindingFlags;
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)class45.t(object_12, null, (CultureInfo)(object)class46.W(bindingFlags_25, null, (Type)(object)((Class7)(object)class47.W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)@class.j(bindingFlags, null, ref reference, array3, null, array4, out *(object*)Class5.Default)))).W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3), array6, null));
				}
				goto IL_39b4;
			}
		}
		UIntPtr num16 = (UIntPtr)Class5.Default;
		nuint num17 = num;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num16) * (num17 * num) == 0)
			{
				struct2 = struct2;
			}
			goto IL_39b4;
		}
		IL_21bb:
		Class7 obj34 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj34.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out object_);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		else
		{
			while (obj2 != null)
			{
				while ((object)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)@class.t(bindingFlags, null, obj2, cultureInfo)), (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, null), ref reference, null, cultureInfo, (string[])(object)Class5.Default, out object_) != null)
				{
					Class7 class48 = @class;
					Class7 class49 = @class;
					BindingFlags bindingFlags_26 = (BindingFlags)@class.j((BindingFlags)Class5.Default, null, ref reference, null, cultureInfo, array4, out *(object*)null);
					MethodBase[] methodBase_11 = array;
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)class48.t(null, (Type)(object)class49.e(bindingFlags_26, methodBase_11, (Type[])(object)class50.j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), ref reference, array3, cultureInfo, array4, out object_), array3), cultureInfo);
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					gClass4 = null;
				}
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			do
			{
				try
				{
					class18 = class18;
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					num = default(UIntPtr);
					if (num * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = Class5.Default;
					}
				}
			}
			catch
			{
				_ = (Struct2)Class5.Default;
				@struct = default(Struct2);
			}
		}
		try
		{
			@class = null;
		}
		catch
		{
			do
			{
				try
				{
					_ = (GClass0)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, null, array3), array, array6, null);
				}
				catch
				{
					_ = (Struct1)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		try
		{
			if (num == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)@class.t(bindingFlags, array5, obj2, null);
				}
			}
			else
			{
				try
				{
					gClass = null;
				}
				catch
				{
					_ = (Struct1)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array3)).e(bindingFlags, null, null, null);
				}
			}
		}
		catch
		{
			try
			{
				_ = (Class7)(object)((Class7)@class.t(null, null, cultureInfo)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)Class5.Default);
				_ = (Class9)(object)Class5.Default;
				class9 = (Class9)(object)Class5.Default;
				class18 = (Class6)((Class7)null).t((object)null, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array3)).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null), cultureInfo);
			}
			finally
			{
				class18 = class18;
				goto end_IL_24f2;
			}
			end_IL_24f2:;
		}
		do
		{
			_ = (Class2)(object)Class5.Default;
		}
		while ((object)Class5.Default != null);
		try
		{
			while (((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo) != null)
			{
				@class = (Class7)(object)Class5.Default;
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Struct2)((Class7)null).t(obj2, type, cultureInfo);
				}
			}
			finally
			{
				_ = (GClass2)(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out object_);
				goto IL_2684;
			}
		}
		IL_3e1d:
		do
		{
			Class7 class51 = @class;
			Class7 obj42 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_27 = bindingFlags;
			MethodBase[] methodBase_12 = array;
			ParameterModifier[] parameterModifier_4 = array3;
			CultureInfo cultureInfo_3 = cultureInfo;
			string[] string_3 = array4;
			Class7 class52 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
			object object_13 = @class.W(bindingFlags, null, type, array6, array3);
			Class7 obj43 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
			MethodBase[] methodBase_13 = array;
			ref object[] object_14 = ref reference;
			ParameterModifier[] parameterModifier_5 = array3;
			Class7 class53 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class51.j(default(BindingFlags), (MethodBase[])(object)obj42.j(bindingFlags_27, methodBase_12, ref *(object[]*)null, parameterModifier_4, cultureInfo_3, string_3, out *(object*)class52.t(bindingFlags_28, fieldInfo_7, object_13, (CultureInfo)(object)obj43.j(default(BindingFlags), methodBase_13, ref object_14, parameterModifier_5, null, (string[])(object)class53.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), out *(object*)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(@class.j(bindingFlags, array, ref reference, array3, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])null), (Type[])(object)Class5.Default, array3), array4, out object_), null, null), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out *(object*)null), array6, array3)))), ref *(object[]*)null, null, null, array4, out object_), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, array4, out *(object*)@class.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, array4, out object_)), out *(object*)null);
		}
		while (obj2 != null);
		Class7 obj44 = (Class7)(object)Class5.Default;
		Class7 class54 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)(UIntPtr)obj44.e((BindingFlags)class54.j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out object_), null, array6, null)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				if (num == 0)
				{
					try
					{
						class13 = (Class8)(object)Class5.Default;
					}
					finally
					{
						Class7 class55 = @class;
						object object_15 = obj2;
						Class7 class56 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class4)class55.t(object_15, (Type)(object)class56.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), null);
						goto IL_42c0;
					}
				}
				do
				{
					qk = null;
				}
				while ((object)Class5.Default != null);
			}
			else
			{
				nuint num18 = num;
				Class7 class57 = @class;
				BindingFlags bindingFlags_29 = bindingFlags;
				PropertyInfo[] propertyInfo_6 = array2;
				Type type_6 = type;
				Type[] type_7 = array6;
				Class7 obj45 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_30 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = array2;
				Type type_8 = type;
				Class7 obj46 = (Class7)(object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
				BindingFlags bindingFlags_31 = bindingFlags;
				Class7 class58 = @class;
				bindingFlags = default(BindingFlags);
				nuint num19 = num18 * unchecked((nuint)(UIntPtr)class57.W(bindingFlags_29, propertyInfo_6, type_6, type_7, (ParameterModifier[])(object)obj45.W(bindingFlags_30, propertyInfo_7, type_8, (Type[])(object)obj46.j(bindingFlags_31, (MethodBase[])(object)class58.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, array4, out object_), ref *(object[]*)null, null, cultureInfo, array4, out *(object*)Class5.Default), null)));
				nuint num20 = num;
				num = default(UIntPtr);
				if (num19 * (num20 * unchecked(num / num)) == 0)
				{
					if (num == 0)
					{
						_ = (Struct1)Class5.Default;
					}
					else
					{
						class12 = class12;
					}
				}
				else
				{
					unchecked
					{
						Class7 obj47 = (Class7)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)@class.t(null, type, (CultureInfo)(object)Class5.Default), array3, cultureInfo, array4, out object_);
						bindingFlags = default(BindingFlags);
						if ((UIntPtr)obj47.W(bindingFlags, null, type, null, array3) == (UIntPtr)(nuint)0u)
						{
							class13 = class13;
						}
						else
						{
							gClass4 = (GClass3)(object)Class5.Default;
						}
					}
				}
			}
			goto IL_42c0;
		}
		IL_4925:
		gClass2 = gClass2;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				class13 = class13;
			}
		}
		gClass3 = gClass3;
		_ = (Class9)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array4, out object_);
		try
		{
			do
			{
				Class7 class59 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class59.e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, array3);
				class18 = null;
				_ = (Struct1)Class5.Default;
			}
			while (obj2 != null);
		}
		catch
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					Class7 class60 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class60.W(bindingFlags, null, type, null, array3);
				}
			}
		}
		gClass2 = gClass2;
		_ = (_003CModule_003E)(object)Class5.Default;
		Class7 obj49 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_32 = bindingFlags;
		FieldInfo[] fieldInfo_8 = array5;
		object object_16 = obj2;
		Class7 class61 = @class;
		BindingFlags bindingFlags_33 = bindingFlags;
		Class7 obj50 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_34 = bindingFlags;
		Type[] type_9 = array6;
		Class7 class62 = @class;
		BindingFlags bindingFlags_35 = bindingFlags;
		MethodBase[] methodBase_14 = array;
		ref object[] object_17 = ref reference;
		ParameterModifier[] parameterModifier_6 = array3;
		Class7 class63 = @class;
		bindingFlags = default(BindingFlags);
		qk = (Qk7)(object)obj49.t(bindingFlags_32, fieldInfo_8, object_16, (CultureInfo)(object)class61.t(bindingFlags_33, (FieldInfo[])(object)obj50.e(bindingFlags_34, null, type_9, (ParameterModifier[])(object)class62.j(bindingFlags_35, methodBase_14, ref object_17, parameterModifier_6, (CultureInfo)(object)class63.e(bindingFlags, array, null, null), array4, out *(object*)null)), Class5.Default, cultureInfo));
		_ = (GClass2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array6, (ParameterModifier[])null);
		_ = (Class0)(object)@class.e(bindingFlags, null, array6, array3);
		class19 = null;
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		finally
		{
			class18 = null;
			goto IL_4b59;
		}
		IL_36c0:
		_003CModule_003E = _003CModule_003E;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		finally
		{
			try
			{
				do
				{
					struct2 = struct2;
				}
				while (obj2 != null);
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
				}
			}
			goto IL_37dd;
		}
		IL_0f3f:
		try
		{
			try
			{
				do
				{
					class22 = class22;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					Class8 obj52 = (Class8)(object)Class5.Default;
					class13 = class13;
					class13 = obj52;
					class9 = class9;
				}
				catch
				{
					class7 = class7;
				}
				goto end_IL_0f40;
			}
			end_IL_0f40:;
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			class19 = (Class2)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)@class.e((BindingFlags)Class5.Default, array, array6, array3), type, cultureInfo), type, (Type[])null, array3)).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_);
			class19 = class19;
			goto IL_1020;
		}
		IL_39b4:
		@class = @class;
		while (obj2 != null)
		{
			try
			{
				do
				{
					Class7 class64 = @class;
					BindingFlags bindingFlags_36 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class64.e(bindingFlags_36, null, (Type[])(object)((Class7)null).e(bindingFlags, array, array6, array3), array3);
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					struct2 = struct2;
				}
				finally
				{
					_ = (Class10)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, cultureInfo);
					continue;
				}
			}
		}
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (Struct1)((Class7)null).e(bindingFlags, array, array6, array3);
		}
		catch
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
					class22 = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		class22 = class22;
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			_ = (Class0)(object)((Class7)(object)Class5.Default).t(default(BindingFlags), array5, obj2, cultureInfo);
			Class7 obj55 = (Class7)(object)@class.W(default(BindingFlags), array2, null, null, array3);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_37 = bindingFlags;
			MethodBase[] methodBase_15 = array;
			ref object[] object_18 = ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array5, obj2, cultureInfo);
			Class7 obj56 = (Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array6, null), (CultureInfo)(object)Class5.Default, array4, out object_);
			Class7 class65 = @class;
			BindingFlags bindingFlags_38 = bindingFlags;
			FieldInfo[] fieldInfo_9 = array5;
			object object_19 = obj2;
			Class7 class66 = @class;
			BindingFlags bindingFlags_39 = bindingFlags;
			MethodBase[] methodBase_16 = array;
			MethodBase[] methodBase_17 = array;
			ref object[] object_20 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_7 = array3;
			MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)obj56.j((BindingFlags)class65.t(bindingFlags_38, fieldInfo_9, object_19, (CultureInfo)(object)class66.e(bindingFlags_39, methodBase_16, (Type[])(object)((Class7)null).j(default(BindingFlags), methodBase_17, ref object_20, parameterModifier_7, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), methodBase_18, (Type[])(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo), (ParameterModifier[])null), (string[])(object)Class5.Default, out *(object*)@class.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, null, out object_)), (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null))), null, ref *(object[]*)null, array3, cultureInfo, array4, out object_);
			CultureInfo cultureInfo_4 = (CultureInfo)(object)Class5.Default;
			Class7 class67 = @class;
			BindingFlags bindingFlags_40 = bindingFlags;
			Class7 class68 = @class;
			BindingFlags bindingFlags_41 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_19 = array;
			ref object[] object_21 = ref reference;
			ParameterModifier[] parameterModifier_9 = (ParameterModifier[])@class.t(obj2, (Type)(object)@class.e(default(BindingFlags), array, array6, array3), cultureInfo);
			Class7 obj57 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			gClass2 = (GClass1)(object)obj55.j(bindingFlags_37, methodBase_15, ref object_18, parameterModifier_8, cultureInfo_4, (string[])(object)class67.W(bindingFlags_40, null, null, (Type[])(object)class68.j(bindingFlags_41, methodBase_19, ref object_21, parameterModifier_9, (CultureInfo)(object)obj57.W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default), (string[])@class.t(null, type, (CultureInfo)(object)Class5.Default), out object_), (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array6, (ParameterModifier[])(object)Class5.Default)), out *(object*)@class.t(bindingFlags, array5, null, null));
			goto IL_3e1d;
		}
		IL_1020:
		@class = (Class7)(object)Class5.Default;
		checked
		{
			while (obj2 != null)
			{
				nuint num21 = num;
				nuint num22 = num;
				Class7 class69 = @class;
				object object_22 = obj2;
				Class7 class70 = @class;
				FieldInfo[] fieldInfo_10 = (FieldInfo[])(object)Class5.Default;
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				if (num21 + (unchecked(num22 / checked(unchecked((nuint)(UIntPtr)class69.t(object_22, null, (CultureInfo)(object)class70.t(default(BindingFlags), fieldInfo_10, class71.W(bindingFlags, null, (Type)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out object_), (Type[])(object)Class5.Default, null), (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, null, type, array6, array3)))) - num)) + num) == 0)
				{
					unchecked
					{
						try
						{
							_ = (Class10)(object)@class.W(bindingFlags, array2, type, array6, array3);
							BindingFlags bindingFlags_42 = bindingFlags;
							MethodBase[] methodBase_20 = array;
							BindingFlags bindingFlags_43 = bindingFlags;
							PropertyInfo[] propertyInfo_8 = array2;
							Type type_10 = type;
							Class7 class72 = @class;
							bindingFlags = default(BindingFlags);
							BindingFlags bindingFlags_44 = bindingFlags;
							PropertyInfo[] propertyInfo_9 = array2;
							Class7 class73 = @class;
							bindingFlags = default(BindingFlags);
							BindingFlags bindingFlags_45 = (BindingFlags)((Class7)null).e(bindingFlags_42, methodBase_20, (Type[])(object)((Class7)null).W(bindingFlags_43, propertyInfo_8, type_10, (Type[])(object)class72.W(bindingFlags_44, propertyInfo_9, (Type)(object)class73.W(bindingFlags, array2, type, array6, array3), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])null);
							Class7 obj58 = (Class7)@class.t(obj2, null, (CultureInfo)(object)@class.t(bindingFlags, null, obj2, null));
							BindingFlags bindingFlags_46 = bindingFlags;
							Class7 obj59 = (Class7)(object)Class5.Default;
							Class7 class74 = @class;
							Class7 class75 = @class;
							BindingFlags bindingFlags_47 = bindingFlags;
							PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)Class5.Default);
							Class7 class76 = @class;
							BindingFlags bindingFlags_48 = bindingFlags;
							MethodBase[] methodBase_21 = array;
							ref object[] object_23 = ref *(object[]*)((Class7)(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo)).e((BindingFlags)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)null), array, array6, null);
							ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
							bindingFlags = default(BindingFlags);
							Type type_11 = (Type)(object)class74.e((BindingFlags)((Class7)(object)((Class7)null).W((BindingFlags)class75.W(bindingFlags_47, propertyInfo_10, (Type)(object)class76.j(bindingFlags_48, methodBase_21, ref object_23, parameterModifier_10, null, (string[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3), out *(object*)Class5.Default), null, (ParameterModifier[])(object)Class5.Default), array2, type, array6, array3)).e(bindingFlags, null, array6, array3), array, array6, null);
							bindingFlags = default(BindingFlags);
							_ = (Class4)(object)((Class7)(object)((Class7)null).e(bindingFlags_45, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)obj58.e(bindingFlags_46, (MethodBase[])obj59.t(null, type_11, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, cultureInfo), obj2, (CultureInfo)null)), null, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)))).t(bindingFlags, (FieldInfo[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array2, type, array6, null), ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out object_), (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null), obj2, null);
							_003CModule_003E = null;
						}
						catch
						{
							_ = (Struct1)Class5.Default;
						}
					}
				}
				else
				{
					nuint num23 = num * (num * num);
					num = default(UIntPtr);
					if (num23 + num == 0)
					{
						_003CModule_003E = _003CModule_003E;
						continue;
					}
					gClass4 = gClass4;
					gClass4 = null;
				}
			}
			gClass2 = (GClass1)(object)Class5.Default;
			class18 = (Class6)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass2 = gClass2;
			class20 = (Class10)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class77.e(bindingFlags, array, array6, array3);
				}
				catch
				{
					_ = (Class9)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, null, (Type[])(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo), (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array5, obj2, cultureInfo));
					@class = (Class7)(object)Class5.Default;
				}
			}
		}
		gClass3 = null;
		_ = (Class5)((Class7)null).t(obj2, type, (CultureInfo)null);
		if ((UIntPtr)@class.t(obj2, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)Class5.Default;
		}
		do
		{
			class20 = null;
			class7 = null;
			_ = (GClass1)(object)Class5.Default;
		}
		while (obj2 != null);
		class18 = class18;
		_ = (GClass3)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, array6, null);
		class22 = class22;
		class18 = class18;
		_ = (Struct1)Class5.Default;
		try
		{
			try
			{
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gClass4 = gClass4;
				}
			}
		}
		catch
		{
			Class7 obj63 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_49 = bindingFlags;
			MethodBase[] methodBase_22 = array;
			Class7 class78 = @class;
			BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_11 = array2;
			Type[] type_12 = array6;
			Class7 obj64 = (Class7)(object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, null, cultureInfo));
			BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
			Class7 class79 = @class;
			bindingFlags = default(BindingFlags);
			ref object[] object_24 = ref *(object[]*)class78.W(bindingFlags_50, propertyInfo_11, null, type_12, (ParameterModifier[])(object)obj64.t(bindingFlags_51, null, class79.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])@class.t(Class5.Default, type, (CultureInfo)(object)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array3, (CultureInfo)@class.t(obj2, (Type)(object)Class5.Default, null), null, out object_)).W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default)).e(default(BindingFlags), array, array6, (ParameterModifier[])(object)Class5.Default)), array3), (CultureInfo)(object)Class5.Default));
			Class7 class80 = @class;
			bindingFlags = default(BindingFlags);
			gClass4 = (GClass3)(object)obj63.j(bindingFlags_49, methodBase_22, ref object_24, (ParameterModifier[])(object)class80.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, array4, out *(object*)@class.j((BindingFlags)Class5.Default, null, ref reference, array3, cultureInfo, array4, out *(object*)((Class7)null).W(bindingFlags, array2, type, (Type[])null, (ParameterModifier[])null))), cultureInfo, array4, out object_);
		}
		if (checked(num - unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
			}
			finally
			{
				try
				{
					_ = (Struct2)@class.W((BindingFlags)Class5.Default, null, (Type)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)@class.t(((Class7)(object)@class.t((BindingFlags)Class5.Default, array5, null, null)).t(Class5.Default, type, cultureInfo), null, cultureInfo)), array6, array3);
				}
				catch
				{
					class7 = class7;
				}
				goto IL_191a;
			}
		}
		goto IL_191a;
		IL_0a5a:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass = gClass;
			}
			catch
			{
				gClass = gClass;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class20 = class20;
				}
				goto IL_0b6c;
			}
		}
		while (obj2 != null)
		{
			try
			{
				class7 = class7;
			}
			finally
			{
				BindingFlags bindingFlags_52 = (BindingFlags)((Class7)null).t(obj2, type, cultureInfo);
				MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
				ref object[] object_25 = ref reference;
				ParameterModifier[] parameterModifier_11 = array3;
				Class7 class81 = @class;
				BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_24 = array;
				Type[] type_13 = array6;
				Type type_14 = (Type)(object)Class5.Default;
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				@struct = (Struct2)((Class7)null).j(bindingFlags_52, methodBase_23, ref object_25, parameterModifier_11, (CultureInfo)(object)class81.e(bindingFlags_53, methodBase_24, type_13, (ParameterModifier[])((Class7)null).t((object)null, type_14, (CultureInfo)(object)class82.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, null, out *(object*)Class5.Default))), (string[])null, out *(object*)null);
				continue;
			}
		}
		goto IL_0b6c;
		IL_191a:
		do
		{
			@struct = @struct;
		}
		while (obj2 != null || obj2 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			class22 = class22;
		}
		while ((object)Class5.Default != null)
		{
			if (num == 0)
			{
				try
				{
					class18 = class18;
				}
				catch
				{
					class7 = class7;
					class13 = class13;
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class20 = class20;
				class12 = null;
				class12 = class12;
				class18 = (Class6)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
				gClass2 = gClass2;
			}
			catch
			{
				Class7 obj69 = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, array5, obj2, cultureInfo), obj2, (CultureInfo)(object)Class5.Default), null, type, array6, array3);
				MethodBase[] methodBase_25 = array;
				Class7 obj70 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_54 = (BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj69.W((BindingFlags)((Class7)null).j(default(BindingFlags), methodBase_25, ref *(object[]*)obj70.e(bindingFlags_54, (MethodBase[])(object)((Class7)null).e(bindingFlags, array, array6, (ParameterModifier[])(object)@class.e(bindingFlags, null, null, array3)), array6, array3), array3, cultureInfo, array4, out object_), array2, (Type)(object)Class5.Default, array6, array3);
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * num == 0)
				{
					while (obj2 != null)
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
			}
		}
		do
		{
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_55 = bindingFlags;
			Class7 class83 = @class;
			BindingFlags bindingFlags_56 = bindingFlags;
			FieldInfo[] fieldInfo_11 = array5;
			Class7 class84 = @class;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_26 = (MethodBase[])(object)class83.t(bindingFlags_56, fieldInfo_11, ((Class7)(object)class84.t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array2, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), array6, array3), (CultureInfo)(object)Class5.Default);
			ref object[] object_26 = ref reference;
			ParameterModifier[] parameterModifier_12 = array3;
			CultureInfo cultureInfo_5 = cultureInfo;
			string[] string_4 = array4;
			Class7 obj73 = (Class7)(object)Class5.Default;
			Class7 class85 = @class;
			BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
			object object_27 = obj2;
			Class7 class86 = @class;
			BindingFlags bindingFlags_58 = bindingFlags;
			Class7 class87 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)((Class7)null).j(bindingFlags_55, methodBase_26, ref object_26, parameterModifier_12, cultureInfo_5, string_4, out *(object*)obj73.j((BindingFlags)class85.t(bindingFlags_57, null, object_27, (CultureInfo)(object)class86.W(bindingFlags_58, (PropertyInfo[])(object)class87.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), (Type[])(object)Class5.Default, null), null, array4, out object_), (Type)(object)@class.e((BindingFlags)Class5.Default, array, array6, null), array6, (ParameterModifier[])(object)@class.W(bindingFlags, array2, type, null, array3))), (MethodBase[])(object)Class5.Default, ref reference, array3, null, array4, out *(object*)null));
		}
		while (obj2 != null);
		do
		{
			if (num != 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)((Class7)null).W((BindingFlags)Class5.Default, array2, type, array6, (ParameterModifier[])null);
					_ = (Class9)(object)Class5.Default;
				}
			}
			else
			{
				gClass2 = null;
			}
		}
		while (obj2 != null);
		try
		{
			class20 = null;
		}
		catch
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				try
				{
					class22 = Class5.Default;
				}
				catch
				{
					qk = qk;
				}
				goto end_IL_1d08;
			}
			end_IL_1d08:;
		}
		num = default(UIntPtr);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, Class5.Default, cultureInfo)) == 0)
			{
				nuint num24 = num;
				num = default(UIntPtr);
				if (num24 - num != 0)
				{
					try
					{
						class13 = null;
					}
					finally
					{
						_ = (Struct2)Class5.Default;
						Class7 class88 = @class;
						Class7 class89 = @class;
						MethodBase[] methodBase_27 = array;
						unchecked
						{
							Class7 obj76 = (Class7)(object)@class.e((BindingFlags)Class5.Default, null, array6, null);
							bindingFlags = default(BindingFlags);
							Class7 obj77 = (Class7)(object)obj76.j(default(BindingFlags), (MethodBase[])((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, null), array3)).t(obj2, type, cultureInfo), ref reference, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array5, @class.t(bindingFlags, array5, null, cultureInfo), cultureInfo), null, array4, out object_);
							bindingFlags = default(BindingFlags);
							_ = (Struct2)class88.e((BindingFlags)class89.j(default(BindingFlags), methodBase_27, ref *(object[]*)null, (ParameterModifier[])(object)obj77.t(bindingFlags, array5, obj2, cultureInfo), cultureInfo, array4, out *(object*)Class5.Default), array, array6, array3);
							class7 = null;
							goto IL_1f13;
						}
					}
				}
			}
			else
			{
				_ = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array6, null);
			}
			goto IL_1f13;
		}
		IL_4b59:
		_ = (Class10)((Class7)((Class7)null).t(obj2, type, cultureInfo)).t(Class5.Default, type, cultureInfo);
		try
		{
			try
			{
				gClass3 = null;
				return;
			}
			finally
			{
				class12 = class12;
				return;
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class12 = null;
					return;
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					return;
				}
			}
			try
			{
				struct2 = struct2;
				return;
			}
			finally
			{
				@struct = @struct;
				return;
			}
		}
		IL_0b6c:
		while ((object)Class5.Default != null)
		{
			_ = (Class8)(object)Class5.Default;
		}
		_ = (Class7)(object)Class5.Default;
		_ = (_003CModule_003E)(object)@class.t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo);
		_ = (Class9)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
			Class7 class90 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)class90.e(bindingFlags, array, array6, null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			else
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					class22 = class22;
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		while (obj2 != null)
		{
			nuint num25 = num / num;
			nuint num26 = num;
			num = default(UIntPtr);
			checked
			{
				if (num25 * (num26 * num + unchecked((nuint)(UIntPtr)((Class7)(object)((Class7)(object)@class.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out *(object*)@class.W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out object_))))) == 0)
				{
					while (obj2 != null)
					{
						_ = (Class2)(object)Class5.Default;
						gClass = gClass;
						class9 = class9;
						_ = (Class8)(object)@class.e(bindingFlags, null, array6, null);
					}
				}
				else
				{
					try
					{
						gClass = null;
					}
					catch
					{
						class18 = class18;
					}
				}
			}
		}
		try
		{
			try
			{
				class7 = class7;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)@class.W(bindingFlags, null, type, array6, null);
				}
			}
		}
		catch
		{
		}
		Class7 obj83 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)obj83.W(bindingFlags, (PropertyInfo[])@class.t(obj2, type, null), (Type)(object)@class.t(bindingFlags, null, ((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), cultureInfo), array6, array3);
		_ = (GClass1)(object)Class5.Default;
		@struct = default(Struct2);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				checked
				{
					nuint num27 = unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)@class.W(default(BindingFlags), null, null, array6, null));
					nuint num28 = num;
					num = default(UIntPtr);
					if (num27 + num28 * num == 0)
					{
						_ = (Class10)(object)((Class7)null).e(unchecked((BindingFlags)Class5.Default), array, (Type[])null, array3);
					}
				}
			}
			finally
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					@struct = (Struct2)@class.t(default(BindingFlags), array5, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, null, cultureInfo));
					_ = (GClass2)(object)Class5.Default;
					goto IL_0f3f;
				}
			}
		}
		goto IL_0f3f;
		IL_2166:
		if (num == 0)
		{
			_ = (GClass2)(object)@class.t(default(BindingFlags), array5, Class5.Default, cultureInfo);
			goto IL_21bb;
		}
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		finally
		{
			while (obj2 != null)
			{
				class19 = null;
			}
			goto IL_21bb;
		}
		IL_2684:
		_ = (Class7)@class.t(Class5.Default, type, cultureInfo);
		Class7 obj84 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_59 = bindingFlags;
		MethodBase[] methodBase_28 = array;
		Class7 class91 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj84.j(bindingFlags_59, methodBase_28, ref *(object[]*)class91.t(bindingFlags, array5, obj2, cultureInfo), array3, cultureInfo, array4, out *(object*)null) == (UIntPtr)(nuint)0u && checked(num * num) == 0 && (UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, null, type, (Type[])@class.t(null, type, (CultureInfo)(object)@class.e(bindingFlags, array, null, (ParameterModifier[])@class.t(Class5.Default, type, cultureInfo))), null) == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) * num == 0)
			{
				class18 = class18;
			}
			else
			{
				while (obj2 != null)
				{
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				do
				{
					class9 = class9;
					class20 = class20;
					_ = (Class2)@class.t(Class5.Default, (Type)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), (CultureInfo)(object)@class.W((BindingFlags)@class.t(bindingFlags, array5, null, cultureInfo), (PropertyInfo[])(object)((Class7)((Class7)null).t((object)Class5.Default, type, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), type, null, array3));
				}
				while (obj2 != null);
			}
			finally
			{
				if (num == 0)
				{
					_ = (Class4)(object)@class.j(bindingFlags, null, ref reference, array3, (CultureInfo)((Class7)null).t((object)Class5.Default, type, cultureInfo), array4, out *(object*)Class5.Default);
				}
				continue;
			}
		}
		do
		{
			_ = (Struct1)Class5.Default;
		}
		while (obj2 != null);
		object object_28 = @class.e(bindingFlags, null, null, array3);
		Class7 class92 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)((Class7)null).t(object_28, (Type)(object)class92.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), cultureInfo);
		_ = (GClass2)(object)Class5.Default;
		while (obj2 != null)
		{
			while (true)
			{
				Class7 obj85 = (Class7)(object)@class.W(bindingFlags, array2, type, null, array3);
				BindingFlags bindingFlags_60 = (BindingFlags)@class.t(null, type, null);
				Class7 class93 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)obj85.t(bindingFlags_60, (FieldInfo[])(object)class93.e(bindingFlags, array, array6, null), obj2, cultureInfo) != null)
				{
					try
					{
						class12 = null;
					}
					catch
					{
						_ = (Struct1)Class5.Default;
					}
					continue;
				}
				break;
			}
		}
		Class7 obj87 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_61 = bindingFlags;
		BindingFlags bindingFlags_62 = bindingFlags;
		ParameterModifier[] parameterModifier_13 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_6 = cultureInfo;
		BindingFlags bindingFlags_63 = bindingFlags;
		BindingFlags bindingFlags_64 = bindingFlags;
		ParameterModifier[] parameterModifier_14 = array3;
		CultureInfo cultureInfo_7 = cultureInfo;
		string[] string_5 = (string[])(object)Class5.Default;
		Class7 class94 = @class;
		bindingFlags = default(BindingFlags);
		@class = (Class7)(object)obj87.W(bindingFlags_61, null, (Type)(object)((Class7)null).j(bindingFlags_62, (MethodBase[])null, ref *(object[]*)null, parameterModifier_13, cultureInfo_6, (string[])(object)((Class7)null).e(bindingFlags_63, (MethodBase[])(object)((Class7)null).j(bindingFlags_64, (MethodBase[])null, ref *(object[]*)null, parameterModifier_14, cultureInfo_7, string_5, out *(object*)class94.W(bindingFlags, array2, type, array6, array3)), array6, (ParameterModifier[])(object)Class5.Default), out *(object*)Class5.Default), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
		try
		{
			checked
			{
				if (num * (unchecked((nuint)(UIntPtr)Class5.Default) + (unchecked((nuint)(UIntPtr)Class5.Default) + num + unchecked((nuint)(UIntPtr)@class.e((BindingFlags)@class.t(obj2, null, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3)))) == 0)
				{
					try
					{
						class12 = null;
					}
					finally
					{
						_ = (Class7)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array6, array3)).W(bindingFlags, array2, type, null, array3);
						goto end_IL_2a9b;
					}
				}
			}
			end_IL_2a9b:;
		}
		finally
		{
			try
			{
				class20 = class20;
				_ = (Class6)(object)Class5.Default;
				_ = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, array4, out object_);
			}
			catch
			{
				Class7 class95 = @class;
				BindingFlags bindingFlags_65 = bindingFlags;
				MethodBase[] methodBase_29 = array;
				ref object[] object_29 = ref reference;
				ParameterModifier[] parameterModifier_15 = (ParameterModifier[])((Class7)null).t((object)@class.W(bindingFlags, array2, null, null, array3), type, cultureInfo);
				Class7 class96 = @class;
				Class7 obj88 = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)null, array6, array3);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class95.j(bindingFlags_65, methodBase_29, ref object_29, parameterModifier_15, (CultureInfo)(object)class96.t(default(BindingFlags), null, null, (CultureInfo)(object)((Class7)null).t((BindingFlags)obj88.t(bindingFlags, array5, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, null, array6, null)), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)), array4, out object_);
			}
			goto IL_2c76;
		}
	}

	unsafe static void smethod_3()
	{
		Class7 @class = @class;
		Class7 class2 = @class;
		Class7 class3 = @class;
		BindingFlags bindingFlags = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		PropertyInfo[] propertyInfo_ = null;
		Class7 class4 = @class;
		BindingFlags bindingFlags_2 = bindingFlags;
		Class7 class5 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_3 = bindingFlags;
		MethodBase[] array = array;
		MethodBase[] methodBase_ = array;
		Type[] array2 = array2;
		Type type_ = (Type)(object)class5.e(bindingFlags_3, methodBase_, array2, null);
		Class7 obj = (Class7)(object)class4.W(bindingFlags_2, propertyInfo_, type_, null, null);
		BindingFlags bindingFlags_4 = bindingFlags;
		FieldInfo[] fieldInfo_ = null;
		object obj2 = obj2;
		Type type_2 = (Type)(object)((Class7)null).t(bindingFlags_4, fieldInfo_, obj2, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null));
		CultureInfo cultureInfo_ = null;
		BindingFlags bindingFlags_5 = (BindingFlags)class3.W(bindingFlags_, propertyInfo_, (Type)obj.t(null, type_2, cultureInfo_), array2, (ParameterModifier[])(object)Class5.Default);
		Type[] type_3 = array2;
		BindingFlags bindingFlags_6 = bindingFlags;
		MethodBase[] methodBase_2 = array;
		ref object[] object_ = ref *(object[]*)null;
		ParameterModifier[] parameterModifier_ = null;
		ref object object_2 = ref *(object*)null;
		_ = (Class10)(object)class2.e(bindingFlags_5, null, type_3, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_6, methodBase_2, ref object_, parameterModifier_, cultureInfo_, (string[])null, out object_2));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		try
		{
			_ = (Class2)(object)((Class7)null).e((BindingFlags)@class.W(bindingFlags, propertyInfo_, null, null, parameterModifier_), array, (Type[])(object)@class.W(bindingFlags, null, type_, null, parameterModifier_), parameterModifier_);
		}
		finally
		{
			try
			{
				Class7 class6 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class6.e(bindingFlags, array, (Type[])(object)@class.e(bindingFlags, array, null, parameterModifier_), null);
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					gClass = null;
					gClass = gClass;
				}
			}
			goto IL_01e5;
		}
		IL_01e5:
		GClass1 gClass2;
		Class2 class7;
		do
		{
			class7 = (Class2)(object)Class5.Default;
			class7 = class7;
			Class7 obj4 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj4.W(bindingFlags, propertyInfo_, type_, array2, (ParameterModifier[])(object)Class5.Default);
			gClass2 = (GClass1)(object)Class5.Default;
			gClass2 = null;
		}
		while (obj2 != null);
		@class = @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class12);
		try
		{
			do
			{
				try
				{
					class8 = class8;
					class8 = null;
					_ = (GClass0)(object)Class5.Default;
					Class7 class9 = @class;
					BindingFlags bindingFlags_7 = (BindingFlags)@class.t(obj2, type_, null);
					MethodBase[] methodBase_3 = array;
					Class7 obj5 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_4 = array;
					ref object[] object_3 = ref *(object[]*)@class.t(bindingFlags, fieldInfo_, obj2, cultureInfo_);
					Class7 obj6 = (Class7)(object)((Class7)(object)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_), (MethodBase[])null, ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, cultureInfo_), (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)Class5.Default)).W((BindingFlags)Class5.Default, null, type_, (Type[])(object)Class5.Default, parameterModifier_);
					Type type_4 = (Type)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					array3 = (string[])(object)obj5.j(bindingFlags_8, methodBase_4, ref object_3, (ParameterModifier[])obj6.t(null, type_4, (CultureInfo)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, cultureInfo_)), cultureInfo_, array3, out object_2);
					class10 = (Class6)(object)class9.j(bindingFlags_7, methodBase_3, ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)null);
					class10 = class10;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					class11 = class11;
					class11 = null;
					class12 = class12;
					class12 = class12;
					class8 = null;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			goto IL_0406;
		}
		IL_164c:
		Qk7 qk = qk;
		while (obj2 != null)
		{
			qk = qk;
		}
		Class7 class13 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class13.W(bindingFlags, null, type_, (Type[])(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo_), parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			_ = (Class0)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if (num == 0)
		{
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref object_, parameterModifier_, cultureInfo_, array3, out object_2), (Type)null, array2, (ParameterModifier[])@class.t(obj2, type_, cultureInfo_)), (FieldInfo[])null, obj2, (CultureInfo)null);
			_ = (GClass1)(object)Class5.Default;
			goto IL_1775;
		}
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		finally
		{
			_ = (Class8)((Class7)null).t((object)Class5.Default, type_, cultureInfo_);
			goto IL_1775;
		}
		IL_0406:
		_ = (Class5)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, array2, parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		try
		{
			num = num;
			num = default(UIntPtr);
			checked
			{
				if (num * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					try
					{
						@class = (Class7)(object)((Class7)null).j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2);
					}
					catch
					{
						_ = (Class9)(object)Class5.Default;
					}
				}
			}
		}
		finally
		{
			try
			{
				@struct = @struct;
				@struct = default(Struct1);
				@struct = @struct;
			}
			catch
			{
				_ = (Class10)(object)Class5.Default;
			}
			finally
			{
				nuint num2 = num;
				Class7 class14 = @class;
				BindingFlags bindingFlags_9 = bindingFlags;
				BindingFlags bindingFlags_10 = bindingFlags;
				Class7 obj10 = (Class7)(object)@class.W(bindingFlags, null, type_, (Type[])(object)Class5.Default, null);
				bindingFlags = default(BindingFlags);
				if (checked(num2 - unchecked((nuint)(UIntPtr)class14.W(bindingFlags_9, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_10, (MethodBase[])(object)obj10.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), ref object_, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default), (Type)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array2, null))) / (nuint)(UIntPtr)Class5.Default == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					_ = (Class9)(object)@class.t(bindingFlags, fieldInfo_, obj2, cultureInfo_);
				}
				goto IL_05c6;
			}
		}
		IL_05c6:
		if (num == 0)
		{
			while (obj2 != null)
			{
				if (num == 0)
				{
					Class7 class15 = @class;
					BindingFlags bindingFlags_11 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, fieldInfo_, null, null), type_, null, parameterModifier_);
					Type[] type_5 = array2;
					bindingFlags = default(BindingFlags);
					gClass = (GClass0)(object)class15.e(bindingFlags_11, null, type_5, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref object_, parameterModifier_, (CultureInfo)null, (string[])null, out object_2));
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class20);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class17);
		try
		{
			try
			{
				Class7 class16 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class16.j(bindingFlags, array, ref object_, null, cultureInfo_, (string[])(object)Class5.Default, out object_2);
				class17 = null;
				class17 = class17;
			}
			finally
			{
				num = default(UIntPtr);
				nuint num3 = num;
				Class7 class18 = @class;
				Class7 obj11 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_12 = (BindingFlags)((Class7)null).W((BindingFlags)obj11.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_), (PropertyInfo[])null, (Type)null, array2, parameterModifier_);
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				Class7 obj12 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				nuint num4;
				nuint num6;
				checked
				{
					num4 = unchecked((nuint)(UIntPtr)class18.e(bindingFlags_12, methodBase_5, (Type[])(object)obj12.W(bindingFlags_13, (PropertyInfo[])(object)((Class7)null).W((BindingFlags)class19.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default), (PropertyInfo[])null, (Type)null, (Type[])null, parameterModifier_), type_, (Type[])(object)Class5.Default, null), parameterModifier_)) * unchecked((nuint)(UIntPtr)Class5.Default);
					nuint num5 = num;
					num = default(UIntPtr);
					num6 = num5 - num;
					num = default(UIntPtr);
				}
				if (num3 / checked(num4 - (num6 + num)) == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					gClass2 = null;
				}
				goto end_IL_066c;
			}
			end_IL_066c:;
		}
		catch
		{
			do
			{
				class20 = class20;
				class20 = class20;
			}
			while ((object)@class.W(bindingFlags, null, type_, array2, parameterModifier_) != null || obj2 != null);
		}
		while (obj2 != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			if ((nuint)(UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_) / num == 0)
			{
				while (obj2 != null)
				{
					GClass3 obj14 = (GClass3)(object)Class5.Default;
					gClass3 = gClass3;
					gClass3 = obj14;
				}
			}
			else
			{
				try
				{
					gClass = null;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					gClass2 = gClass2;
					_ = Class5.Default;
					Class7 class21 = @class;
					object object_4 = obj2;
					Class7 obj16 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class11 = (Class9)class21.t(object_4, (Type)(object)obj16.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_), array2, null), (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_14 = (BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.j((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array2, parameterModifier_), (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo_, array3, out object_2)), ref *(object[]*)null, null, cultureInfo_, null, out object_2), propertyInfo_, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_);
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).j(bindingFlags_14, methodBase_6, ref object_, parameterModifier_, (CultureInfo)(object)class22.W((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])null, (ParameterModifier[])null), null, (Type)(object)Class5.Default, null, null), array3, out *(object*)Class5.Default);
				}
				finally
				{
					class12 = null;
					goto IL_0a45;
				}
			}
			goto IL_0a45;
		}
		IL_2f69:
		try
		{
			qk = (Qk7)(object)Class5.Default;
		}
		catch
		{
			@struct = (Struct1)Class5.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_15 = bindingFlags;
			Class7 obj18 = (Class7)((Class7)null).t(obj2, type_, cultureInfo_);
			BindingFlags bindingFlags_16 = bindingFlags;
			Class7 class23 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)null).W(bindingFlags_15, propertyInfo_, (Type)(object)obj18.j(bindingFlags_16, null, ref *(object[]*)null, (ParameterModifier[])(object)class23.W(bindingFlags, propertyInfo_, (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, null, array3, out *(object*)null), array2, null), cultureInfo_, null, out *(object*)null), (Type[])null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array2, parameterModifier_));
			@class = @class;
			_003CModule_003E = null;
		}
		else
		{
			UIntPtr num7 = (UIntPtr)@class.t(bindingFlags, null, Class5.Default, cultureInfo_);
			Class7 class24 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num7) - unchecked((nuint)(UIntPtr)class24.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)null)), out *(object*)null)) == 0)
				{
					do
					{
						gClass = (GClass0)(object)Class5.Default;
					}
					while (obj2 != null);
				}
			}
		}
		class12 = null;
		_ = (Class7)(object)Class5.Default;
		qk = qk;
		_ = (Qk7)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
		do
		{
			Class7 obj19 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj19.W(bindingFlags, null, null, (Type[])(object)@class.W(bindingFlags, propertyInfo_, null, array2, null), null);
		}
		while (obj2 != null);
		do
		{
			gClass2 = null;
		}
		while ((object)Class5.Default != null);
		while (obj2 != null)
		{
			while (true)
			{
				Class7 class25 = @class;
				BindingFlags bindingFlags_17 = bindingFlags;
				MethodBase[] methodBase_7 = array;
				bindingFlags = default(BindingFlags);
				if ((object)class25.e(bindingFlags_17, methodBase_7, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo_, (string[])null, out *(object*)Class5.Default), (ParameterModifier[])(object)Class5.Default) != null)
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					catch
					{
						Class7 class26 = @class;
						bindingFlags = default(BindingFlags);
						_ = (GClass2)(object)class26.t(bindingFlags, fieldInfo_, null, (CultureInfo)((Class7)(object)Class5.Default).t(Class5.Default, type_, null));
					}
					continue;
				}
				break;
			}
		}
		UIntPtr num8 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num8) + (num + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo_, array3, out object_2)))) == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (num / num == 0)
				{
					class20 = class20;
				}
			}
			else
			{
				try
				{
					Class7 obj21 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_18 = (BindingFlags)((Class7)(object)Class5.Default).t(((Class7)null).j(bindingFlags, array, ref *(object[]*)((Class7)@class.t(null, null, null)).t(bindingFlags, null, obj2, cultureInfo_), (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out object_2), cultureInfo_, (string[])null, out object_2), type_, cultureInfo_);
					MethodBase[] methodBase_8 = array;
					bindingFlags = default(BindingFlags);
					ref object[] object_5 = ref *(object[]*)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])null);
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj21.j(bindingFlags_18, methodBase_8, ref object_5, parameterModifier_, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])@class.t(null, (Type)(object)Class5.Default, cultureInfo_), (ParameterModifier[])null), type_, array2, (ParameterModifier[])null), array3, out *(object*)null);
					_ = (GClass1)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, cultureInfo_);
					_ = (Class6)(object)Class5.Default;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class27.t(bindingFlags, fieldInfo_, obj2, cultureInfo_);
				}
				catch
				{
					_ = (Class8)@class.t(null, (Type)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_), cultureInfo_);
				}
			}
			goto IL_34fd;
		}
		try
		{
			while (obj2 != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		finally
		{
			_ = (Class2)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo_);
			_ = (Class9)(object)Class5.Default;
			_ = (Class5)(object)@class.e((BindingFlags)Class5.Default, array, null, parameterModifier_);
			goto IL_34fd;
		}
		IL_429d:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Struct1)Class5.Default;
		}
		else if ((UIntPtr)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				@struct = @struct;
				_ = (GClass3)(object)((Class7)(object)@class.t(bindingFlags, fieldInfo_, obj2, null)).e(bindingFlags, null, array2, parameterModifier_);
				_ = (Class4)(object)Class5.Default;
				class7 = (Class2)(object)Class5.Default;
				goto IL_434f;
			}
		}
		goto IL_434f;
		IL_49a0:
		if (num == 0)
		{
			Class7 obj23 = (Class7)(object)@class.W(bindingFlags, propertyInfo_, null, array2, parameterModifier_);
			Class7 class28 = @class;
			Class7 class29 = @class;
			Class7 class30 = @class;
			BindingFlags bindingFlags_19 = (BindingFlags)((Class7)(object)Class5.Default).e(default(BindingFlags), array, array2, null);
			Class7 class31 = @class;
			BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
			Class7 class32 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_21 = (BindingFlags)class29.W(default(BindingFlags), propertyInfo_, null, (Type[])(object)class30.e(bindingFlags_19, (MethodBase[])(object)((Class7)(object)((Class7)(object)class31.e(bindingFlags_20, null, (Type[])(object)class32.t(bindingFlags, fieldInfo_, @class.W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null), type_, array2, (ParameterModifier[])(object)Class5.Default), cultureInfo_), (ParameterModifier[])(object)@class.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, null))).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, null, array3, out *(object*)null), null, parameterModifier_), parameterModifier_);
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)obj23.W((BindingFlags)class28.t(bindingFlags_21, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_), obj2, null), propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_);
		}
		num = default(UIntPtr);
		Class7 obj24;
		BindingFlags bindingFlags_22;
		checked
		{
			if (num + unchecked(num / num) == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
			obj24 = (Class7)(object)@class.e(bindingFlags, array, null, null);
			bindingFlags_22 = bindingFlags;
		}
		ref object[] object_6 = ref *(object[]*)Class5.Default;
		Class7 obj25 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_23 = bindingFlags;
		PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
		Class7 obj26 = (Class7)(object)@class.e((BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_)).j(bindingFlags, array, ref object_, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null), null, array2, parameterModifier_);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj24.j(bindingFlags_22, null, ref object_6, (ParameterModifier[])(object)obj25.W(bindingFlags_23, propertyInfo_2, (Type)(object)obj26.W(bindingFlags, null, type_, array2, (ParameterModifier[])((Class7)null).t(obj2, type_, (CultureInfo)null)), array2, parameterModifier_), cultureInfo_, (string[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)null).t(obj2, type_, cultureInfo_)), out object_2) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (GClass3)(object)@class.W(bindingFlags, null, type_, null, null);
				}
				catch
				{
					class12 = (Class10)(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, null, out object_2);
				}
			}
		}
		class8 = null;
		do
		{
			try
			{
				try
				{
					gClass = null;
				}
				finally
				{
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array2, (ParameterModifier[])null);
					goto end_IL_4d49;
				}
				end_IL_4d49:;
			}
			catch
			{
				Class7 class33 = @class;
				BindingFlags bindingFlags_24 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class33.t(bindingFlags_24, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, parameterModifier_), obj2, (CultureInfo)(object)((Class7)null).j((BindingFlags)@class.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, array3, out object_2), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, array3, out object_2));
			}
		}
		while ((object)@class.j(bindingFlags, null, ref object_, parameterModifier_, null, array3, out object_2) != null);
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		finally
		{
			if (checked(num + num * num) == 0)
			{
				Class7 class34 = @class;
				BindingFlags bindingFlags_25 = bindingFlags;
				Class7 class35 = @class;
				Class7 class36 = @class;
				Class7 obj29 = (Class7)(object)Class5.Default;
				Class7 obj30 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)(object)((Class7)null).W((BindingFlags)class34.t(bindingFlags_25, null, class35.t(class36.W((BindingFlags)obj29.j(default(BindingFlags), (MethodBase[])(object)obj30.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_), ref *(object[]*)null, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, null, null), (CultureInfo)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo_), null, out *(object*)null), null, type_, null, parameterModifier_), (Type)(object)Class5.Default, cultureInfo_), (CultureInfo)(object)Class5.Default), propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])@class.t(Class5.Default, type_, null), parameterModifier_), array2, parameterModifier_)).t((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, null), fieldInfo_, obj2, cultureInfo_);
			}
			else
			{
				try
				{
					class12 = null;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			goto IL_500c;
		}
		IL_4416:
		try
		{
			try
			{
				do
				{
					class17 = class17;
					_ = (Struct1)((Class7)(object)Class5.Default).t(null, null, cultureInfo_);
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					gClass3 = gClass3;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (Class8)@class.t(obj2, type_, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_));
				}
				finally
				{
					_ = (Class8)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, @class.j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, null, null, out object_2)).t(obj2, type_, null), array3, out *(object*)null), cultureInfo_);
					continue;
				}
			}
			while (obj2 != null);
		}
		qk = (Qk7)(object)Class5.Default;
		do
		{
			_ = (Class8)(object)Class5.Default;
		}
		while (obj2 != null);
		_ = (_003CModule_003E)(object)@class.e(bindingFlags, array, null, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		while (obj2 != null)
		{
			try
			{
				struct2 = struct2;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					Class7 class37 = @class;
					BindingFlags bindingFlags_26 = bindingFlags;
					Class7 obj35 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class38 = @class;
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_9 = array;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					string[] string_ = array3;
					Class7 class39 = @class;
					bindingFlags = default(BindingFlags);
					class7 = (Class2)(object)class37.W(bindingFlags_26, propertyInfo_, type_, (Type[])(object)obj35.j(bindingFlags_27, null, ref object_, parameterModifier_, (CultureInfo)(object)class38.j(bindingFlags_28, methodBase_9, ref object_, parameterModifier_2, null, string_, out *(object*)class39.e(bindingFlags, array, array2, parameterModifier_)), null, out *(object*)Class5.Default), parameterModifier_);
				}
				continue;
			}
		}
		if (num == 0)
		{
			@struct = @struct;
		}
		else
		{
			Class7 class40 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class40.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)@class.j(bindingFlags, array, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out object_2), (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)@class.t(null, type_, null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])@class.t(obj2, null, cultureInfo_)), (ParameterModifier[])((Class7)null).t(obj2, type_, cultureInfo_), cultureInfo_, array3, out *(object*)null), null, null, null, out object_2), null, ref *(object[]*)Class5.Default, null, null, array3, out *(object*)@class.t(bindingFlags, null, null, cultureInfo_)));
		}
		if ((UIntPtr)((Class7)null).t(obj2, type_, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			gClass2 = (GClass1)(object)Class5.Default;
		}
		finally
		{
			while (obj2 != null)
			{
				Class7 class41;
				BindingFlags bindingFlags_29;
				Class7 class42;
				BindingFlags bindingFlags_30;
				FieldInfo[] fieldInfo_2;
				Class7 class43;
				BindingFlags bindingFlags_31;
				Class7 obj37;
				Class7 obj38;
				do
				{
					_ = (Class4)@class.t(((Class7)null).e(bindingFlags, array, array2, parameterModifier_), null, cultureInfo_);
					class41 = @class;
					bindingFlags_29 = (BindingFlags)@class.t((BindingFlags)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo_), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_);
					class42 = @class;
					bindingFlags_30 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array2, (ParameterModifier[])null);
					fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
					class43 = @class;
					bindingFlags_31 = bindingFlags;
					obj37 = (Class7)(object)Class5.Default;
					obj38 = (Class7)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_);
					bindingFlags = default(BindingFlags);
				}
				while ((object)class41.t(bindingFlags_29, null, class42.t(bindingFlags_30, fieldInfo_2, null, (CultureInfo)(object)class43.W(bindingFlags_31, propertyInfo_, (Type)(object)obj37.j((BindingFlags)((Class7)null).t((object)obj38.W(bindingFlags, null, type_, null, null), type_, cultureInfo_), null, ref *(object[]*)@class.t(null, type_, cultureInfo_), null, cultureInfo_, (string[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out *(object*)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, parameterModifier_)), out object_2), array2, null)), cultureInfo_) != null);
			}
			goto IL_49a0;
		}
		IL_2a65:
		try
		{
			class17 = class17;
		}
		finally
		{
			while ((object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(@class.e((BindingFlags)Class5.Default, array, array2, null), (Type)(object)Class5.Default, cultureInfo_), obj2, cultureInfo_) != null)
			{
				do
				{
					class7 = class7;
				}
				while (obj2 != null);
			}
			goto IL_2ae2;
		}
		IL_500c:
		while (obj2 != null)
		{
			_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null);
			gClass3 = null;
			class20 = null;
		}
		class12 = (Class10)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, null, null, null);
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Struct1)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, null, array3, out object_2);
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					continue;
				}
			}
		}
		GClass2 gClass4 = (GClass2)@class.t(Class5.Default, type_, (CultureInfo)(object)@class.W(default(BindingFlags), (PropertyInfo[])@class.t(Class5.Default, null, cultureInfo_), type_, array2, (ParameterModifier[])(object)Class5.Default));
		struct2 = (Struct2)Class5.Default;
		gClass4 = gClass4;
		@class = null;
		if (num == 0)
		{
			_ = (GClass1)(object)Class5.Default;
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class44);
		try
		{
			do
			{
				_ = (Struct2)@class.W((BindingFlags)@class.t(obj2, (Type)(object)Class5.Default, null), (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default);
			}
			while ((object)Class5.Default != null);
			return;
		}
		finally
		{
			class44 = null;
			return;
		}
		IL_279a:
		try
		{
			if (num == 0)
			{
				_ = (Class2)(object)Class5.Default;
				_ = (Class0)(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, type_, array2, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array2, parameterModifier_))).e(bindingFlags, array, array2, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, null, (string[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, null, (Type[])(object)Class5.Default, null), out *(object*)null));
			}
			else
			{
				qk = null;
			}
		}
		catch
		{
			do
			{
				class11 = (Class9)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					gClass4 = (GClass2)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type_, array2, parameterModifier_);
				}
				finally
				{
					gClass2 = null;
					gClass3 = gClass3;
					_ = (Class2)@class.t(Class5.Default, (Type)(object)@class.e((BindingFlags)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_), array, (Type[])(object)Class5.Default, null), (CultureInfo)(object)@class.W(bindingFlags, null, null, (Type[])((Class7)null).t(obj2, (Type)null, (CultureInfo)null), parameterModifier_));
					gClass4 = (GClass2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, parameterModifier_, (CultureInfo)null, array3, out object_2);
					goto end_IL_2895;
				}
				end_IL_2895:;
			}
			finally
			{
				if (num == 0)
				{
					_ = (Class5)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, null, (Type[])@class.t(Class5.Default, type_, cultureInfo_), null);
				}
				goto IL_2a65;
			}
		}
		if ((UIntPtr)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array2, parameterModifier_)).t(obj2, null, cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				@class = (Class7)(object)Class5.Default;
				_ = (Class2)(object)((Class7)@class.t(null, (Type)(object)Class5.Default, null)).j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out *(object*)null);
				_ = (GClass1)(object)Class5.Default;
			}
			else
			{
				class44 = (Class0)(object)Class5.Default;
			}
		}
		goto IL_2a65;
		IL_0a45:
		try
		{
			if (num / checked(unchecked((nuint)(UIntPtr)((Class7)null).t((object)null, (Type)null, (CultureInfo)null)) * num + unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (GClass0)(object)Class5.Default;
				class7 = null;
			}
			else
			{
				_ = (Struct1)Class5.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
			}
			finally
			{
				class8 = null;
				goto end_IL_0a9e;
			}
			end_IL_0a9e:;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class8)(object)Class5.Default;
				class20 = null;
				@struct = @struct;
			}
			goto IL_0ae1;
		}
		IL_0ae1:
		try
		{
			do
			{
				gClass2 = gClass2;
				_ = (GClass3)(object)Class5.Default;
				Struct2 obj41 = (Struct2)Class5.Default;
				struct2 = struct2;
				struct2 = obj41;
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					class17 = (Class4)(object)Class5.Default;
					@class = null;
				}
				else
				{
					class17 = class17;
				}
			}
			finally
			{
				try
				{
					gClass2 = (GClass1)(object)Class5.Default;
				}
				catch
				{
					class44 = null;
					class44 = null;
				}
				goto end_IL_0b1d;
			}
			end_IL_0b1d:;
		}
		while (obj2 != null)
		{
			_ = (Qk7)(object)Class5.Default;
			qk = qk;
			qk = qk;
			@class = @class;
			Class7 class45 = @class;
			BindingFlags bindingFlags_32 = (BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, obj2, cultureInfo_);
			Class7 class46 = @class;
			BindingFlags bindingFlags_33 = bindingFlags;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_34 = bindingFlags;
			Type[] type_6 = array2;
			Class7 class47 = @class;
			BindingFlags bindingFlags_35 = bindingFlags;
			Class7 class48 = @class;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)class46.e(bindingFlags_33, null, (Type[])(object)((Class7)null).e(bindingFlags_34, (MethodBase[])null, type_6, (ParameterModifier[])(object)class47.W(bindingFlags_35, (PropertyInfo[])(object)class48.j(bindingFlags, null, ref object_, parameterModifier_, null, array3, out object_2), type_, array2, parameterModifier_)), parameterModifier_);
			Class7 class49 = @class;
			BindingFlags bindingFlags_36 = bindingFlags;
			MethodBase[] methodBase_10 = array;
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)class45.W(bindingFlags_32, propertyInfo_3, (Type)(object)class49.e(bindingFlags_36, methodBase_10, (Type[])(object)obj44.W(bindingFlags, propertyInfo_, type_, array2, null), (ParameterModifier[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, null)), (Type[])(object)Class5.Default, null);
		}
		while (obj2 != null)
		{
			try
			{
				try
				{
					Class7 obj45 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out object_2)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, type_, (Type[])(object)Class5.Default, (ParameterModifier[])null)).e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo_), array, array2, parameterModifier_), obj2, cultureInfo_), ref *(object[]*)@class.t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null, (CultureInfo)null, array3, out *(object*)Class5.Default);
					object object_7 = obj2;
					bindingFlags = default(BindingFlags);
					_ = (Class6)obj45.t(object_7, type_, (CultureInfo)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array2, parameterModifier_));
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = bindingFlags;
					object object_8 = Class5.Default;
					Class7 obj46 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_38 = bindingFlags;
					Class7 class50 = @class;
					object object_9 = obj2;
					object object_10 = obj2;
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj47 = (Class7)(object)((Class7)null).t(bindingFlags_37, fieldInfo_, object_8, (CultureInfo)(object)obj46.W(bindingFlags_38, propertyInfo_, type_, (Type[])class50.t(object_9, (Type)((Class7)null).t(object_10, (Type)(object)class51.e(bindingFlags, array, array2, parameterModifier_), cultureInfo_), cultureInfo_), null));
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_39 = bindingFlags;
					Type type_7 = (Type)(object)Class5.Default;
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_40 = bindingFlags;
					MethodBase[] methodBase_11 = array;
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type_, (CultureInfo)(object)Class5.Default);
					Class7 class53 = @class;
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 class54 = @class;
					BindingFlags bindingFlags_42 = bindingFlags;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_12 = (MethodBase[])(object)class54.j(bindingFlags_42, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out *(object*)class55.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_));
					Type[] type_8 = array2;
					Class7 class56 = @class;
					BindingFlags bindingFlags_43 = bindingFlags;
					object object_11 = obj2;
					Class7 obj48 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_44 = bindingFlags;
					bindingFlags = default(BindingFlags);
					Class7 obj49 = (Class7)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref object_, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)null), (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					Class7 obj50 = (Class7)(object)obj48.j(bindingFlags_44, null, ref *(object[]*)obj49.t(bindingFlags, fieldInfo_, Class5.Default, null), null, cultureInfo_, array3, out object_2);
					BindingFlags bindingFlags_45 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_13 = array;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					class20 = (Class5)(object)obj47.W(bindingFlags_39, propertyInfo_, type_7, (Type[])(object)((Class7)(object)class52.j(bindingFlags_40, methodBase_11, ref object_, parameterModifier_3, cultureInfo_, (string[])(object)class53.e(bindingFlags_41, methodBase_12, type_8, (ParameterModifier[])(object)class56.t(bindingFlags_43, fieldInfo_, object_11, (CultureInfo)(object)obj50.e(bindingFlags_45, methodBase_13, (Type[])(object)class57.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_), parameterModifier_))), out *(object*)null)).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])null, (CultureInfo)null, array3, out object_2)).t(Class5.Default, type_, cultureInfo_)), parameterModifier_);
					Class7 class58 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class58.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_);
				}
				catch
				{
					_ = Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class20 = class20;
				}
				else
				{
					_ = (Class0)@class.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array, ref object_, parameterModifier_, cultureInfo_, null, out object_2));
				}
			}
		}
		class11 = class11;
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)((Class7)null).e(bindingFlags, array, (Type[])(object)@class.e((BindingFlags)Class5.Default, null, null, parameterModifier_), parameterModifier_) != null)
			{
				try
				{
					class20 = class20;
					class17 = null;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 obj53 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array2, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_47 = bindingFlags;
					MethodBase[] methodBase_14 = array;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t(bindingFlags_46, (FieldInfo[])(object)obj53.j(bindingFlags_47, methodBase_14, ref object_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)null), null, array3, out *(object*)null), (object)null, (CultureInfo)(object)Class5.Default);
					class44 = null;
					_ = (Struct2)@class.W(bindingFlags, null, type_, null, null);
					Class7 class59 = @class;
					BindingFlags bindingFlags_48 = bindingFlags;
					MethodBase[] methodBase_15 = array;
					Class7 class60 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class59.e(bindingFlags_48, methodBase_15, (Type[])(object)class60.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), parameterModifier_);
					continue;
				}
			}
		}
		else
		{
			_ = (Class6)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, type_, array2, (ParameterModifier[])(object)Class5.Default);
		}
		class11 = (Class9)(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t((object)null, (Type)null, cultureInfo_), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2);
		try
		{
			do
			{
				if (num != (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)Class5.Default;
				}
				else
				{
					class7 = class7;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		try
		{
			while (@class.t(obj2, type_, cultureInfo_) != null)
			{
				Class7 obj55 = (Class7)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type_, array2, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, cultureInfo_));
				bindingFlags = default(BindingFlags);
				gClass = (GClass0)(object)((Class7)(object)obj55.t(bindingFlags, fieldInfo_, obj2, cultureInfo_)).j((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array2, parameterModifier_), null, null, array2, parameterModifier_), array, ref object_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default), cultureInfo_, null, out *(object*)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2));
			}
		}
		finally
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			while (obj2 != null);
			goto IL_14f8;
		}
		IL_1a7d:
		_ = (Struct1)Class5.Default;
		do
		{
			try
			{
				class7 = class7;
			}
			finally
			{
				if ((UIntPtr)((Class7)null).t((object)null, (Type)null, cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
					continue;
				}
				BindingFlags bindingFlags_49 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_16 = array;
				Class7 obj56 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 obj57 = (Class7)@class.t(null, null, cultureInfo_);
				bindingFlags = default(BindingFlags);
				_ = (Struct2)((Class7)null).e(bindingFlags_49, methodBase_16, (Type[])(object)obj56.W(bindingFlags_50, propertyInfo_, (Type)(object)obj57.W(bindingFlags, propertyInfo_, null, array2, parameterModifier_), array2, (ParameterModifier[])@class.t(obj2, (Type)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, array3, out object_2), cultureInfo_)), parameterModifier_);
				continue;
			}
		}
		while (obj2 != null);
		while ((object)Class5.Default != null)
		{
			if (checked(num + num) == 0)
			{
				try
				{
					class17 = null;
				}
				finally
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
					@struct = @struct;
					class20 = Class5.Default;
					continue;
				}
			}
		}
		try
		{
			@struct = @struct;
		}
		finally
		{
			try
			{
				try
				{
					class17 = class17;
				}
				catch
				{
					gClass2 = gClass2;
				}
			}
			catch
			{
				_003CModule_003E = null;
			}
			goto IL_1c02;
		}
		IL_434f:
		try
		{
			while ((object)Class5.Default != null)
			{
				while (obj2 != null)
				{
					_ = (Class10)(object)@class.e(bindingFlags, array, array2, parameterModifier_);
				}
			}
		}
		finally
		{
			class44 = class44;
			goto IL_4390;
		}
		IL_1775:
		if (num == 0)
		{
			if (num == 0)
			{
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = bindingFlags;
				Class7 class62 = @class;
				BindingFlags bindingFlags_52 = bindingFlags;
				MethodBase[] methodBase_17 = array;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
				string[] string_2 = array3;
				Class7 class63 = @class;
				MethodBase[] methodBase_18 = array;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num9 = (UIntPtr)class61.t(bindingFlags_51, (FieldInfo[])(object)class62.j(bindingFlags_52, methodBase_17, ref object_, parameterModifier_, cultureInfo_2, string_2, out *(object*)class63.e(default(BindingFlags), methodBase_18, (Type[])(object)class64.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_), null)), obj2, cultureInfo_);
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num9 / num) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class7)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, parameterModifier_);
					}
					else
					{
						_003CModule_003E = _003CModule_003E;
						gClass4 = null;
						gClass4 = gClass4;
					}
				}
			}
		}
		else
		{
			class20 = (Class5)((Class7)null).t(obj2, type_, cultureInfo_);
		}
		try
		{
			while (true)
			{
				if (obj2 != null)
				{
					class12 = class12;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		finally
		{
			_ = (_003CModule_003E)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).j((BindingFlags)@class.t(null, type_, cultureInfo_), array, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_, array3, out object_2), array2, null);
			goto IL_190d;
		}
		IL_1c02:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref object_, null, cultureInfo_, array3, out object_2);
			}
			catch
			{
				try
				{
					_ = (Class7)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).t(null, null, cultureInfo_), (FieldInfo[])null, obj2, (CultureInfo)null);
				}
				catch
				{
					_ = (GClass2)(object)Class5.Default;
					class12 = class12;
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		else if (num / num == 0)
		{
			class10 = class10;
		}
		else
		{
			gClass3 = (GClass3)(object)@class.e(bindingFlags, array, null, null);
		}
		@class = @class;
		@class = null;
		gClass4 = gClass4;
		while (true)
		{
			if (obj2 != null)
			{
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class65.j(bindingFlags, array, ref object_, parameterModifier_, null, null, out object_2);
			}
			else if (obj2 == null && obj2 == null)
			{
				break;
			}
		}
		if (num == 0)
		{
			try
			{
				class8 = (Class8)(object)Class5.Default;
			}
			finally
			{
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)((Class7)null).t(obj2, (Type)null, cultureInfo_));
				goto IL_1d73;
			}
		}
		goto IL_1d73;
		IL_4390:
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = (Class10)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				@class = null;
			}
		}
		else
		{
			if (num == 0)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					gClass2 = (GClass1)(object)((Class7)(object)@class.e(bindingFlags, null, null, null)).W((BindingFlags)Class5.Default, null, type_, array2, parameterModifier_);
					goto IL_4416;
				}
			}
			do
			{
				class17 = null;
			}
			while (obj2 != null);
		}
		goto IL_4416;
		IL_1d73:
		nuint num10 = num;
		num = default(UIntPtr);
		if (checked(num10 * num + num) == 0 && num == 0)
		{
			try
			{
				_ = (Struct1)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null);
			}
			catch
			{
				class12 = class12;
				class20 = class20;
				_ = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out object_2);
			}
		}
		try
		{
			try
			{
				do
				{
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, type_, (CultureInfo)null), (Type)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, null, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, type_, array2, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo_, null, out *(object*)null), (Type[])(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, null), parameterModifier_), array3, out *(object*)null), array2, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					gClass3 = gClass3;
				}
				catch
				{
					Class7 class66 = @class;
					BindingFlags bindingFlags_53 = bindingFlags;
					MethodBase[] methodBase_19 = array;
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class66.e(bindingFlags_53, methodBase_19, (Type[])(object)class67.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(null, type_, cultureInfo_), Class5.Default, cultureInfo_), (ParameterModifier[])((Class7)null).t((object)null, type_, (CultureInfo)(object)Class5.Default));
				}
			}
		}
		catch
		{
			Class7 class68;
			do
			{
				try
				{
					gClass2 = null;
				}
				catch
				{
					_ = (Class2)(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array3, out object_2);
				}
				class68 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class68.W(bindingFlags, propertyInfo_, type_, array2, (ParameterModifier[])(object)((Class7)(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)Class5.Default), propertyInfo_, type_, (Type[])@class.t(Class5.Default, null, cultureInfo_), parameterModifier_)).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, null, null, null), type_, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)null).t(@class.t(null, type_, null), (Type)null, (CultureInfo)null))) != null);
		}
		gClass4 = gClass4;
		_ = (GClass3)(object)((Class7)@class.t(Class5.Default, type_, null)).t((BindingFlags)@class.W((BindingFlags)Class5.Default, propertyInfo_, type_, null, parameterModifier_), (FieldInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, null, array3, out object_2), Class5.Default, cultureInfo_);
		class12 = (Class10)(object)Class5.Default;
		_ = (GClass2)(object)Class5.Default;
		do
		{
			try
			{
				while (obj2 != null)
				{
					_ = (GClass1)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, (CultureInfo)@class.t(Class5.Default, (Type)(object)@class.e(bindingFlags, null, array2, parameterModifier_), cultureInfo_), array3, out object_2);
				}
			}
			finally
			{
				nuint num11 = num;
				Class7 class69 = @class;
				MethodBase[] methodBase_20 = array;
				object object_12 = Class5.Default;
				Class7 class70 = @class;
				bindingFlags = default(BindingFlags);
				checked
				{
					nuint num12 = num11 - unchecked((nuint)(UIntPtr)class69.j(default(BindingFlags), methodBase_20, ref object_, parameterModifier_, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), fieldInfo_, object_12, (CultureInfo)(object)class70.e(bindingFlags, array, (Type[])@class.t(null, type_, null), null)), (string[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, parameterModifier_), out *(object*)null));
					num = default(UIntPtr);
					if (num12 + num == 0)
					{
						@struct = default(Struct1);
					}
					else
					{
						class17 = class17;
					}
					continue;
				}
			}
		}
		while ((object)Class5.Default != null);
		while (obj2 != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while ((object)Class5.Default != null)
				{
					_ = (GClass2)@class.t(((Class7)((Class7)null).t(obj2, type_, cultureInfo_)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default), (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, null, array2, null), (CultureInfo)(object)Class5.Default);
				}
			}
		}
		try
		{
			class17 = class17;
		}
		catch
		{
			try
			{
				class12 = (Class10)(object)Class5.Default;
			}
			finally
			{
				if (num == 0)
				{
					gClass2 = gClass2;
				}
				goto end_IL_237d;
			}
			end_IL_237d:;
		}
		_ = (Struct1)((Class7)(object)Class5.Default).t(null, (Type)(object)@class.t(bindingFlags, null, obj2, cultureInfo_), cultureInfo_);
		if ((UIntPtr)@class.t((BindingFlags)@class.e(bindingFlags, array, null, null), null, obj2, cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			Class7 class71 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)(UIntPtr)class71.e(bindingFlags, array, array2, parameterModifier_)) + num == 0)
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
					}
					catch
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
				else
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						gClass2 = null;
					}
				}
			}
		}
		else
		{
			try
			{
				_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_);
			}
			catch
			{
				if ((UIntPtr)@class.t((BindingFlags)@class.W((BindingFlags)@class.e((BindingFlags)Class5.Default, null, array2, parameterModifier_), (PropertyInfo[])(object)Class5.Default, type_, array2, null), null, obj2, (CultureInfo)@class.t(@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, null, out object_2), (Type)((Class7)null).t((object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, cultureInfo_), type_, (CultureInfo)(object)Class5.Default), null)) == (UIntPtr)(nuint)0u)
				{
					Class7 class72 = @class;
					Class7 class73 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 class74 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)class72.t(class73.t(((Class7)null).t(bindingFlags_54, (FieldInfo[])(object)class74.e(bindingFlags, null, array2, parameterModifier_), obj2, cultureInfo_), null, (CultureInfo)(object)Class5.Default), type_, cultureInfo_)).W(bindingFlags, null, type_, (Type[])(object)@class.t(bindingFlags, null, null, null), null);
					_ = (GClass2)@class.t(((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, array2, parameterModifier_), (Type)(object)Class5.Default, (CultureInfo)@class.t(null, type_, cultureInfo_));
					_ = (Class8)(object)Class5.Default;
					struct2 = struct2;
				}
				else
				{
					class12 = (Class10)(object)Class5.Default;
				}
			}
		}
		try
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					_ = (Class4)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, parameterModifier_);
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					Class7 obj71 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj72 = (Class7)(object)obj71.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo_);
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)obj72.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array3, out object_2);
				}
			}
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class6)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
			}
			goto IL_279a;
		}
		IL_34fd:
		do
		{
			class17 = (Class4)(object)Class5.Default;
		}
		while (obj2 != null);
		Class7 class75 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_55 = bindingFlags;
		MethodBase[] methodBase_21 = array;
		Type[] type_9 = (Type[])(object)((Class7)null).e(bindingFlags, array, array2, parameterModifier_);
		BindingFlags bindingFlags_56 = (BindingFlags)Class5.Default;
		Class7 class76 = @class;
		bindingFlags = default(BindingFlags);
		@class = (Class7)(object)class75.e(bindingFlags_55, methodBase_21, type_9, (ParameterModifier[])(object)((Class7)(object)((Class7)null).t(bindingFlags_56, fieldInfo_, (object)class76.e(bindingFlags, array, null, parameterModifier_), cultureInfo_)).e(bindingFlags, array, null, parameterModifier_));
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class12 = null;
		}
		_ = (Class8)(object)@class.W(default(BindingFlags), propertyInfo_, type_, array2, null);
		while (true)
		{
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_57 = bindingFlags;
			ref object[] object_13 = ref *(object[]*)@class.j(bindingFlags, null, ref object_, null, null, null, out object_2);
			Class7 class78 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class77.j(bindingFlags_57, null, ref object_13, null, cultureInfo_, (string[])(object)class78.W(bindingFlags, null, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)null)), out object_2) == null)
			{
				break;
			}
			class11 = (Class9)(object)Class5.Default;
		}
		gClass4 = gClass4;
		while (obj2 != null)
		{
			class10 = class10;
		}
		try
		{
			do
			{
				try
				{
					Class7 obj75 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_58 = bindingFlags;
					Class7 obj76 = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_59 = (BindingFlags)Class5.Default;
					BindingFlags bindingFlags_60 = (BindingFlags)@class.e(bindingFlags, array, array2, parameterModifier_);
					object object_14 = obj2;
					Class7 class79 = @class;
					BindingFlags bindingFlags_61 = bindingFlags;
					MethodBase[] methodBase_22 = array;
					ref object[] object_15 = ref *(object[]*)@class.t(Class5.Default, type_, (CultureInfo)(object)Class5.Default);
					Class7 obj77 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj78 = (Class7)(object)obj76.W(bindingFlags_59, propertyInfo_, null, (Type[])(object)((Class7)null).t(bindingFlags_60, (FieldInfo[])null, object_14, (CultureInfo)(object)class79.j(bindingFlags_61, methodBase_22, ref object_15, parameterModifier_, (CultureInfo)(object)obj77.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo_, array3, out object_2), null, out *(object*)null)), null);
					bindingFlags = default(BindingFlags);
					Class7 obj79 = (Class7)((Class7)obj78.t(((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, null, out object_2), parameterModifier_), type_, (CultureInfo)(object)Class5.Default)).t(obj2, null, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)(object)obj75.j(bindingFlags_58, (MethodBase[])(object)obj79.t(bindingFlags, fieldInfo_, obj2, null), ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out object_2)).t(null, type_, cultureInfo_);
				}
				finally
				{
					gClass2 = null;
					goto IL_386b;
				}
				IL_386b:
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])null, parameterModifier_)).t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_)) != null);
		}
		catch
		{
			gClass = (GClass0)(object)Class5.Default;
			class11 = null;
			@class = null;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Class7)null).t((object)null, (Type)@class.t(obj2, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, array2, parameterModifier_)), array2, null), cultureInfo_), cultureInfo_) == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
			}
		}
		else
		{
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					class8 = class8;
				}
			}
			while (obj2 != null);
		}
		gClass4 = gClass4;
		try
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				class11 = null;
				_ = (Struct1)Class5.Default;
				_ = (Struct1)Class5.Default;
				struct2 = struct2;
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, parameterModifier_);
		}
		_ = (GClass3)(object)Class5.Default;
		_ = (Class6)(object)Class5.Default;
		while (obj2 != null)
		{
			Class7 class80 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class80.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
		}
		_ = (Class10)((Class7)null).t(obj2, type_, (CultureInfo)null);
		class10 = class10;
		gClass4 = gClass4;
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (Qk7)(object)Class5.Default;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class17 = class17;
				Class7 class81 = @class;
				BindingFlags bindingFlags_62 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Class7 obj83 = (Class7)(object)class81.t(bindingFlags_62, (FieldInfo[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)((Class7)null).e(bindingFlags, array, array2, parameterModifier_), parameterModifier_, cultureInfo_, (string[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, null), obj2, cultureInfo_), out object_2), null, cultureInfo_);
				BindingFlags bindingFlags_63 = bindingFlags;
				MethodBase[] methodBase_23 = array;
				Class7 class82 = @class;
				BindingFlags bindingFlags_64 = bindingFlags;
				Type[] type_10 = array2;
				Class7 class83 = @class;
				object object_16 = obj2;
				Class7 obj84 = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).j(default(BindingFlags), null, ref *(object[]*)null, null, cultureInfo_, array3, out *(object*)null)).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, null, array3, out *(object*)null), (string[])(object)Class5.Default, out *(object*)null), out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj83.j(bindingFlags_63, methodBase_23, ref *(object[]*)((Class7)null).e((BindingFlags)class82.W(bindingFlags_64, propertyInfo_, null, type_10, (ParameterModifier[])class83.t(object_16, (Type)(object)obj84.W(bindingFlags, propertyInfo_, null, null, parameterModifier_), cultureInfo_)), array, array2, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default)), parameterModifier_, cultureInfo_, array3, out object_2);
			}
		}
		catch
		{
			Class7 class84 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_65 = bindingFlags;
			Class7 obj85 = (Class7)(object)((Class7)(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, parameterModifier_)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, parameterModifier_), null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo_), array3, out *(object*)Class5.Default), parameterModifier_);
			object object_17 = obj2;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class84.W(bindingFlags_65, (PropertyInfo[])obj85.t(object_17, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null), cultureInfo_), type_, array2, null);
		}
		try
		{
			_ = (Struct2)Class5.Default;
		}
		catch
		{
			do
			{
				if ((UIntPtr)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null) != (UIntPtr)(nuint)0u)
				{
					class11 = null;
					class11 = class11;
				}
				else
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked(num / num) == 0)
					{
						_ = (GClass3)(object)Class5.Default;
						class17 = class17;
						_ = (Class7)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo_);
						gClass4 = null;
					}
					else
					{
						Class7 class85 = @class;
						bindingFlags = default(BindingFlags);
						class12 = (Class10)(object)class85.W(bindingFlags, null, type_, (Type[])((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)@class.t(obj2, null, cultureInfo_)), null);
					}
					goto IL_3eda;
				}
			}
		}
		goto IL_3eda;
		IL_2ae2:
		Class7 class86 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class86.t(bindingFlags, null, obj2, cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass3)((Class7)null).t((object)Class5.Default, type_, cultureInfo_);
		}
		else if (num == 0)
		{
			_ = (Class4)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)Class5.Default), obj2, (CultureInfo)(object)Class5.Default);
		}
		try
		{
			Class7 class87 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)class87.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out object_2);
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			goto IL_2bbd;
		}
		IL_14f8:
		num = default(UIntPtr);
		if (num == 0)
		{
			gClass = null;
		}
		else
		{
			@class = @class;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class88 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_66 = bindingFlags;
					Type[] type_11 = (Type[])(object)Class5.Default;
					Class7 class89 = @class;
					BindingFlags bindingFlags_67 = bindingFlags;
					Class7 obj88 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_68 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_69 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class88.W(bindingFlags_66, propertyInfo_, type_, type_11, (ParameterModifier[])(object)class89.j(bindingFlags_67, null, ref *(object[]*)obj88.e(bindingFlags_68, (MethodBase[])(object)((Class7)null).W(bindingFlags_69, propertyInfo_, type_, (Type[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out object_2), parameterModifier_), null, parameterModifier_), (ParameterModifier[])(object)Class5.Default, cultureInfo_, array3, out *(object*)Class5.Default));
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_1518;
				}
			}
			end_IL_1518:;
		}
		finally
		{
			do
			{
				class20 = (Class5)(object)((Class7)(object)@class.W(bindingFlags, propertyInfo_, type_, array2, null)).t(bindingFlags, fieldInfo_, null, cultureInfo_);
			}
			while (obj2 != null);
			goto IL_164c;
		}
		IL_3eda:
		_ = (Class10)(object)Class5.Default;
		while ((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, (ParameterModifier[])null, cultureInfo_, (string[])null, out object_2) != null)
		{
		}
		num = default(UIntPtr);
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				do
				{
					try
					{
						class12 = class12;
						class20 = class20;
						class8 = class8;
					}
					catch
					{
						_ = (Class6)(object)Class5.Default;
					}
				}
				while (obj2 != null);
				goto IL_429d;
			}
		}
		try
		{
			_ = (Class9)(object)@class.t(bindingFlags, null, ((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)((Class7)null).t((object)@class.t((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])((Class7)(object)Class5.Default).t(obj2, (Type)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), cultureInfo_), type_, array2, parameterModifier_), null, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2), fieldInfo_, obj2, (CultureInfo)(object)Class5.Default), (Type)null, (CultureInfo)null))), cultureInfo_);
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Struct1)@class.W(bindingFlags, null, type_, (Type[])(object)Class5.Default, parameterModifier_);
			}
			else
			{
				Class7 class90 = @class;
				BindingFlags bindingFlags_70 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref object_, null, cultureInfo_, array3, out *(object*)null)).e((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array, ref object_, parameterModifier_, cultureInfo_, array3, out *(object*)null), array, array2, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)@class.t(null, null, null), null, (CultureInfo)(object)Class5.Default, array3, out *(object*)Class5.Default));
				Class7 class91 = @class;
				BindingFlags bindingFlags_71 = (BindingFlags)((Class7)null).j(default(BindingFlags), array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, array3, out object_2);
				MethodBase[] methodBase_24 = array;
				ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)(object)class90.W(bindingFlags_70, propertyInfo_4, type_, (Type[])(object)class91.j(bindingFlags_71, methodBase_24, ref object_, parameterModifier_4, cultureInfo_, (string[])(object)((Class7)(object)class92.e(bindingFlags, array, array2, (ParameterModifier[])@class.t(obj2, type_, cultureInfo_))).e((BindingFlags)@class.t(obj2, type_, null), array, (Type[])@class.t(obj2, (Type)@class.t(null, type_, cultureInfo_), (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), out object_2), parameterModifier_)).t(bindingFlags, fieldInfo_, obj2, cultureInfo_);
				@class = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null);
				gClass = gClass;
			}
			goto IL_429d;
		}
		IL_190d:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 obj90 = (Class7)((Class7)null).t(obj2, (Type)null, cultureInfo_);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj90.e(bindingFlags, array, array2, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
				Class7 class93 = @class;
				BindingFlags bindingFlags_72 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class93.t(bindingFlags_72, (FieldInfo[])(object)((Class7)null).j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj2, cultureInfo_), out *(object*)null), null, (CultureInfo)(object)Class5.Default);
				struct2 = default(Struct2);
				class17 = class17;
			}
			else
			{
				class10 = class10;
			}
		}
		checked
		{
			try
			{
				class44 = class44;
			}
			finally
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) + num == 0)
					{
						Class7 obj91 = (Class7)@class.t(null, type_, (CultureInfo)@class.t(null, type_, cultureInfo_));
						bindingFlags = default(BindingFlags);
						_ = (GClass2)(object)obj91.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_);
					}
				}
				while ((object)Class5.Default != null);
				goto IL_1a7d;
			}
		}
		IL_2bbd:
		while ((object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)@class.W(bindingFlags, propertyInfo_, null, array2, parameterModifier_), (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null), array2, parameterModifier_) != null)
		{
			if (num == 0)
			{
				class17 = (Class4)(object)Class5.Default;
			}
		}
		while (obj2 != null)
		{
			try
			{
				try
				{
					class7 = class7;
				}
				catch
				{
					gClass = (GClass0)(object)Class5.Default;
				}
			}
			catch
			{
				while (obj2 != null)
				{
					gClass4 = gClass4;
				}
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default == 0)
		{
			while (obj2 != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class20 = class20;
				}
				else
				{
					gClass = gClass;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			gClass4 = gClass4;
		}
		else
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
				class12 = null;
			}
			catch
			{
				_ = (Class2)(object)@class.t(bindingFlags, null, null, cultureInfo_);
			}
		}
		_ = (Struct2)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo_);
		try
		{
			try
			{
				class44 = class44;
				gClass3 = null;
				@struct = (Struct1)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array3, out object_2);
				@struct = @struct;
			}
			finally
			{
				_ = (Class10)(object)@class.e(bindingFlags, array, array2, parameterModifier_);
				goto end_IL_2d03;
			}
			end_IL_2d03:;
		}
		catch
		{
			try
			{
				_ = (Class4)(object)@class.t((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, (ParameterModifier[])(object)Class5.Default), fieldInfo_, obj2, (CultureInfo)(object)@class.e((BindingFlags)((Class7)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo_)).t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)@class.W((BindingFlags)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out *(object*)@class.t(obj2, type_, cultureInfo_)), null, type_, array2, null)), null, array2, parameterModifier_));
			}
			catch
			{
				@struct = @struct;
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class94.e(bindingFlags, array, array2, parameterModifier_);
				class7 = (Class2)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
			}
		}
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
						_ = (_003CModule_003E)(object)Class5.Default;
						gClass4 = gClass4;
					}
					finally
					{
						_ = (Struct1)Class5.Default;
						goto end_IL_2e99;
					}
				}
				end_IL_2e99:;
			}
			finally
			{
				if (num * unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (obj2 != null)
					{
						class12 = null;
						class20 = class20;
						class10 = (Class6)@class.t(@class.W(bindingFlags, (PropertyInfo[])@class.t(Class5.Default, type_, null), type_, null, parameterModifier_), (Type)(object)Class5.Default, cultureInfo_);
					}
				}
				else
				{
					class17 = class17;
				}
				goto IL_2f69;
			}
		}
	}

	unsafe static void smethod_4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		while ((object)Class5.Default != null)
		{
			@class = @class;
			Class7 class2 = @class;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = array;
			_ = (GClass0)(object)class2.e(bindingFlags_, array, (Type[])(object)Class5.Default, null);
			qk = qk;
			qk = qk;
			Class8 obj = (Class8)(object)Class5.Default;
			Class7 class3 = @class;
			BindingFlags bindingFlags_2 = bindingFlags;
			MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
			array2 = (ParameterModifier[])(object)Class5.Default;
			class4 = (Class8)(object)class3.e(bindingFlags_2, methodBase_, null, array2);
			class4 = obj;
			gClass = gClass;
			gClass = null;
		}
		_ = (Struct1)Class5.Default;
		_ = (Class8)(object)Class5.Default;
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass2);
		if (uIntPtr == 0)
		{
			GClass2 obj2 = (GClass2)(object)Class5.Default;
			gClass2 = gClass2;
			gClass2 = obj2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		Class6 class5;
		do
		{
			class5 = null;
			class5 = null;
			obj3 = obj3;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_5);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					Class7 class6 = @class;
					object object_ = obj3;
					Class7 class7 = @class;
					BindingFlags bindingFlags_3 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					array3 = (Type[])(object)@class.t(bindingFlags, null, Class5.Default, null);
					type = (Type)(object)class7.e(bindingFlags_3, methodBase_2, array3, null);
					_ = (Qk7)class6.t(object_, type, null);
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			while (obj3 != null);
		}
		else
		{
			Class7 obj4 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_3 = array;
			reference = ref reference;
			ref object[] object_2 = ref reference;
			ParameterModifier[] parameterModifier_ = array2;
			Class7 class8 = @class;
			object object_3 = obj3;
			cultureInfo = null;
			string[] string_ = (string[])class8.t(object_3, null, cultureInfo);
			MethodBase[] methodBase_4 = array;
			ref object[] object_4 = ref reference;
			ParameterModifier[] parameterModifier_2 = array2;
			CultureInfo cultureInfo_ = cultureInfo;
			array4 = null;
			string[] string_2 = array4;
			object_5 = ref *(object*)Class5.Default;
			Class7 obj5 = (Class7)(object)obj4.j(bindingFlags_4, methodBase_3, ref object_2, parameterModifier_, null, string_, out *(object*)((Class7)null).j(default(BindingFlags), methodBase_4, ref object_4, parameterModifier_2, cultureInfo_, string_2, out object_5));
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)obj5.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, null, type, array3, array2), type, array3, (ParameterModifier[])(object)Class5.Default);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class9);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					Class2 obj6 = (Class2)(object)Class5.Default;
					class9 = class9;
					class9 = obj6;
				}
				while (obj3 != null);
			}
			else
			{
				gClass2 = (GClass2)(object)Class5.Default;
				_ = (Class9)(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null);
				Class7 class10 = @class;
				BindingFlags bindingFlags_5 = bindingFlags;
				array5 = (PropertyInfo[])@class.t(obj3, null, cultureInfo);
				_ = (Struct1)class10.W(bindingFlags_5, array5, type, array3, (ParameterModifier[])(object)Class5.Default);
				_ = (Qk7)(object)Class5.Default;
			}
		}
		class5 = class5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class14);
		try
		{
			do
			{
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num - uIntPtr - uIntPtr) != 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
					_003CModule_003E = null;
					continue;
				}
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_6 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])@class.t(obj3, null, cultureInfo);
				ref object[] object_6 = ref reference;
				ParameterModifier[] parameterModifier_3 = array2;
				CultureInfo cultureInfo_2 = cultureInfo;
				string[] string_3 = array4;
				Class7 obj7 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_7 = bindingFlags;
				Class7 class11 = @class;
				BindingFlags bindingFlags_8 = bindingFlags;
				array6 = null;
				FieldInfo[] fieldInfo_ = array6;
				object object_7 = @class.j(bindingFlags, array, ref reference, null, cultureInfo, array4, out *(object*)Class5.Default);
				Class7 class12 = @class;
				BindingFlags bindingFlags_9 = bindingFlags;
				Class7 obj8 = (Class7)(object)Class5.Default;
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)null).j(bindingFlags_6, methodBase_5, ref object_6, parameterModifier_3, cultureInfo_2, string_3, out *(object*)obj7.j(bindingFlags_7, (MethodBase[])(object)class11.t(bindingFlags_8, fieldInfo_, object_7, (CultureInfo)(object)class12.t(bindingFlags_9, null, obj8.t(class13.t(bindingFlags, null, obj3, cultureInfo), (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array2, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), null, out *(object*)null), cultureInfo), cultureInfo)), ref *(object[]*)null, null, cultureInfo, null, out *(object*)null));
			}
			while (obj3 != null);
		}
		catch
		{
			try
			{
				_ = (GClass3)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out object_5);
			}
			finally
			{
				try
				{
					Class5 obj9 = Class5.Default;
					class14 = class14;
					class14 = obj9;
				}
				catch
				{
					Class0 obj10 = (Class0)(object)Class5.Default;
					class15 = class15;
					class15 = obj10;
				}
				goto end_IL_04e8;
			}
			end_IL_04e8:;
		}
		BindingFlags bindingFlags_10 = (BindingFlags)Class5.Default;
		Class7 class16 = @class;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		if ((UIntPtr)((Class7)null).e(bindingFlags_10, (MethodBase[])(object)class16.e(bindingFlags, null, array3, array2), array3, array2) == (UIntPtr)(nuint)0u)
		{
			nuint num2 = checked(uIntPtr - uIntPtr);
			UIntPtr num3 = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr;
			checked
			{
				nuint num5 = uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default);
				uIntPtr = default(UIntPtr);
				nuint num6 = unchecked((nuint)num3) + num4 * (num5 - uIntPtr - uIntPtr);
				uIntPtr = default(UIntPtr);
				if (num2 + (unchecked((nuint)default(UIntPtr)) - (num6 - uIntPtr)) == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					Class7 class17 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class17.t(((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array2), null, null);
				}
			}
		}
		else
		{
			try
			{
				do
				{
					@struct = @struct;
					@struct = @struct;
				}
				while (obj3 != null);
			}
			catch
			{
				try
				{
					class4 = class4;
				}
				catch
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		_003CModule_003E = _003CModule_003E;
		do
		{
			_ = (Struct1)((Class7)(object)Class5.Default).t(null, type, null);
			_ = (Class0)(object)@class.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default);
			_ = (Struct2)Class5.Default;
		}
		while ((object)Class5.Default != null);
		Class9 class18 = class18;
		Class7 class19 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_11 = bindingFlags;
		Class7 class20 = @class;
		BindingFlags bindingFlags_12 = bindingFlags;
		MethodBase[] methodBase_6 = array;
		Class7 obj15 = (Class7)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, array, array3, array2)).e(bindingFlags, array, array3, (ParameterModifier[])(object)@class.W(bindingFlags, array5, type, (Type[])(object)((Class7)null).t(bindingFlags, array6, (object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)((Class7)null).e((BindingFlags)@class.e((BindingFlags)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default), (MethodBase[])null, (Type[])(object)Class5.Default, array2), type, array3, array2), (CultureInfo)(object)Class5.Default), array2));
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)((Class7)(object)class19.t(bindingFlags_11, (FieldInfo[])(object)((Class7)(object)((Class7)null).e((BindingFlags)class20.e(bindingFlags_12, methodBase_6, (Type[])(object)obj15.e(bindingFlags, null, array3, array2), array2), array, array3, array2)).e(bindingFlags, null, null, array2), @class.t(Class5.Default, type, cultureInfo), cultureInfo)).j(default(BindingFlags), null, ref reference, null, cultureInfo, (string[])(object)@class.t((BindingFlags)((Class7)null).j(default(BindingFlags), array, ref reference, array2, cultureInfo, array4, out object_5), array6, obj3, cultureInfo), out *(object*)Class5.Default);
		_003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			_ = (GClass3)(object)Class5.Default;
			_003CModule_003E = _003CModule_003E;
			_ = (GClass3)(object)Class5.Default;
		}
		catch
		{
			GClass3 obj16 = (GClass3)(object)@class.j(default(BindingFlags), array, ref reference, array2, cultureInfo, null, out *(object*)Class5.Default);
			gClass3 = gClass3;
			gClass3 = obj16;
		}
		finally
		{
			gClass2 = gClass2;
			goto IL_0955;
		}
		IL_2118:
		bindingFlags = default(BindingFlags);
		qk = (Qk7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(obj3, type, cultureInfo), array3, array2), ref reference, array2, (CultureInfo)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)).t(((Class7)(object)Class5.Default).t(null, (Type)(object)((Class7)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo)).t(bindingFlags, array6, obj3, null), cultureInfo), type, cultureInfo), (string[])(object)Class5.Default, out object_5)).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class10)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)null), (string[])null, out *(object*)null);
			}
			catch
			{
				_ = (GClass0)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo);
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				try
				{
					class5 = (Class6)(object)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_22c5;
				}
				end_IL_22c5:;
			}
			finally
			{
				continue;
			}
		}
		_ = (Class8)(object)Class5.Default;
		while (obj3 != null)
		{
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					_ = (Struct2)((Class7)null).t((object)null, type, cultureInfo);
					goto end_IL_2301;
				}
				end_IL_2301:;
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				continue;
			}
		}
		_ = (Class4)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj3 != null)
				{
					class4 = (Class8)(object)Class5.Default;
					continue;
				}
				Class7 class21 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class21.t(bindingFlags, array6, obj3, cultureInfo) == null)
				{
					break;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		GClass0 gClass4;
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			Class7 class22 = @class;
			bindingFlags = default(BindingFlags);
			gClass4 = (GClass0)(object)class22.j(bindingFlags, array, ref reference, array2, null, array4, out *(object*)null);
		}
		try
		{
			_ = (Class6)(object)@class.W((BindingFlags)((Class7)null).t(obj3, (Type)null, (CultureInfo)(object)Class5.Default), array5, type, (Type[])(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null), array2);
		}
		catch
		{
			@struct = (Struct1)((Class7)null).t(bindingFlags, array6, obj3, cultureInfo);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class23);
		checked
		{
			try
			{
				_ = (Struct1)Class5.Default;
			}
			finally
			{
				try
				{
					if (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						qk = qk;
					}
					else
					{
						class23 = null;
					}
				}
				finally
				{
					goto IL_2493;
				}
			}
		}
		IL_0fa7:
		class15 = class15;
		class18 = class18;
		Class7 class24 = @class;
		BindingFlags bindingFlags_13 = bindingFlags;
		PropertyInfo[] propertyInfo_ = array5;
		Type type_ = type;
		MethodBase[] methodBase_7 = array;
		Type[] type_2 = (Type[])@class.t(obj3, (Type)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo), (CultureInfo)(object)Class5.Default);
		Class7 class25 = @class;
		Class7 class26 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)class24.W(bindingFlags_13, propertyInfo_, type_, (Type[])(object)((Class7)null).e(default(BindingFlags), methodBase_7, type_2, (ParameterModifier[])(object)class25.t((BindingFlags)class26.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array6, obj3, (CultureInfo)(object)Class5.Default)), (ParameterModifier[])(object)Class5.Default);
		@class = @class;
		_ = (Class6)@class.t(obj3, type, cultureInfo);
		while (obj3 != null)
		{
		}
		try
		{
			_ = (Class8)(object)Class5.Default;
		}
		finally
		{
			try
			{
			}
			finally
			{
				_ = (Qk7)(object)@class.j(bindingFlags, array, ref reference, array2, cultureInfo, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array2)).e(bindingFlags, null, (Type[])(object)Class5.Default, array2), ref *(object[]*)null, null, null, array4, out object_5), out object_5);
				goto IL_1145;
			}
		}
		IL_2f6e:
		try
		{
		}
		finally
		{
			while (true)
			{
				Class7 obj20 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, array3, array2);
				Class7 obj21 = (Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				if ((object)obj20.j(default(BindingFlags), (MethodBase[])(object)obj21.W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, array, array3, null), (Type)(object)Class5.Default, null, (ParameterModifier[])(object)((Class7)((Class7)null).t(obj3, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, null, out object_5), (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo), null, cultureInfo))).t(bindingFlags, array6, obj3, (CultureInfo)(object)Class5.Default)), ref reference, array2, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null), out object_5) != null)
				{
					try
					{
						_ = (GClass3)(object)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, array3, array2);
						@class = null;
						@class = null;
						Class7 class27 = @class;
						BindingFlags bindingFlags_14 = bindingFlags;
						Class7 class28 = @class;
						bindingFlags = default(BindingFlags);
						MethodBase[] methodBase_8 = (MethodBase[])(object)class28.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, null, (string[])(object)Class5.Default, out object_5);
						ref object[] object_8 = ref *(object[]*)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, (string[])(object)Class5.Default, out object_5);
						Class7 class29 = @class;
						BindingFlags bindingFlags_15 = bindingFlags;
						Class7 class30 = @class;
						BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
						MethodBase[] methodBase_9 = array;
						Class7 class31 = @class;
						bindingFlags = default(BindingFlags);
						MethodBase[] methodBase_10 = (MethodBase[])(object)class30.j(bindingFlags_16, methodBase_9, ref *(object[]*)class31.t(bindingFlags, null, obj3, (CultureInfo)(object)Class5.Default), array2, cultureInfo, null, out object_5);
						Type[] type_3 = array3;
						Class7 class32 = @class;
						bindingFlags = default(BindingFlags);
						ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)class29.e(bindingFlags_15, methodBase_10, type_3, (ParameterModifier[])(object)class32.W(bindingFlags, array5, type, array3, array2));
						CultureInfo cultureInfo_3 = (CultureInfo)(object)((Class7)(object)((Class7)((Class7)null).t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])@class.t(obj3, (Type)(object)Class5.Default, cultureInfo), ref reference, array2, cultureInfo, array4, out *(object*)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array3, array2)), cultureInfo, array4, out *(object*)@class.t(bindingFlags, array6, null, null))).W((BindingFlags)Class5.Default, array5, null, null, null);
						string[] string_4 = array4;
						Class7 obj22 = (Class7)(object)@class.e(bindingFlags, array, array3, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out *(object*)null));
						bindingFlags = default(BindingFlags);
						_ = (_003CModule_003E)((Class7)(object)class27.j(bindingFlags_14, methodBase_8, ref object_8, parameterModifier_4, cultureInfo_3, string_4, out *(object*)obj22.j(bindingFlags, array, ref reference, array2, null, array4, out *(object*)Class5.Default))).t(obj3, type, null);
					}
					catch
					{
						_ = (Class4)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					}
					continue;
				}
				break;
			}
			goto IL_33ca;
		}
		IL_3d70:
		if (uIntPtr == 0)
		{
			qk = qk;
		}
		else
		{
			_ = (Class9)(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo, array4, out object_5);
			_ = (GClass2)(object)Class5.Default;
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Class10)(object)@class.W(bindingFlags, array5, type, array3, array2);
					_ = (Class5)(object)@class.W(bindingFlags, null, type, array3, array2);
					_ = (Class4)(object)Class5.Default;
					_ = (Struct1)@class.e(bindingFlags, array, null, (ParameterModifier[])((Class7)null).t((object)null, (Type)((Class7)null).t((object)((Class7)null).W((BindingFlags)Class5.Default, array5, type, (Type[])null, (ParameterModifier[])null), (Type)null, cultureInfo), cultureInfo));
				}
				finally
				{
					gClass3 = null;
					_ = (Struct2)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
					continue;
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					gClass4 = null;
				}
			}
			goto IL_3ebd;
		}
		IL_451d:
		do
		{
			UIntPtr num7 = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num7) + uIntPtr * unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array2))) != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass = null;
					continue;
				}
				Class7 obj24 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)(object)obj24.e(bindingFlags, array, array3, array2)).W((BindingFlags)Class5.Default, null, type, null, null);
			}
			else
			{
				while (obj3 != null)
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null);
		do
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					gClass4 = gClass4;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				class5 = null;
				class15 = null;
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class36);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (_003CModule_003E)(object)((Class7)@class.t(obj3, type, null)).t(bindingFlags, null, null, cultureInfo);
				}
			}
			else if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)@class.t(@class.W(bindingFlags, null, null, array3, null), type, cultureInfo);
			}
			else
			{
				Class7 obj26 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)((Class7)null).e(bindingFlags, array, (Type[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array2), array2), (CultureInfo)null);
				BindingFlags bindingFlags_17 = bindingFlags;
				Class7 class33 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array6;
				object object_9 = obj3;
				Class7 class34 = @class;
				BindingFlags bindingFlags_19 = bindingFlags;
				FieldInfo[] fieldInfo_3 = array6;
				object object_10 = obj3;
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				class36 = (Class10)(object)obj26.j(bindingFlags_17, (MethodBase[])(object)class33.t(bindingFlags_18, fieldInfo_2, object_9, (CultureInfo)(object)class34.t(bindingFlags_19, fieldInfo_3, object_10, (CultureInfo)(object)class35.j(bindingFlags, null, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(obj3, type, cultureInfo)))), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, array, array3, array2), array4, out object_5);
			}
		}
		finally
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					_ = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
				}
			}
			goto IL_4763;
		}
		IL_15b8:
		try
		{
			while (obj3 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		catch
		{
			@class = @class;
		}
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
					class36 = class36;
				}
			}
			catch
			{
				gClass2 = null;
			}
		}
		catch
		{
			Class7 class37 = @class;
			object object_11 = obj3;
			Type type_4 = type;
			Class7 class38 = @class;
			Class7 class39 = @class;
			BindingFlags bindingFlags_20 = bindingFlags;
			Class7 class40 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class37.t(object_11, type_4, (CultureInfo)(object)class38.j((BindingFlags)class39.t(bindingFlags_20, null, class40.j(bindingFlags, array, ref reference, array2, null, null, out *(object*)null), null), array, ref reference, null, null, null, out object_5)) == (UIntPtr)(nuint)0u)
			{
				class5 = (Class6)(object)Class5.Default;
			}
			else
			{
				@struct = @struct;
				Class7 obj30 = (Class7)(object)Class5.Default;
				Class7 obj31 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array2), obj3, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null));
				bindingFlags = default(BindingFlags);
				class4 = (Class8)obj30.t(null, (Type)(object)((Class7)(object)((Class7)null).e((BindingFlags)obj31.t(bindingFlags, array6, @class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), null), array, (Type[])null, array2)).t((BindingFlags)@class.e((BindingFlags)@class.j((BindingFlags)@class.t(@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default), type, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, null, Class5.Default, null), cultureInfo, array4, out object_5), null, null, (ParameterModifier[])@class.t(null, type, cultureInfo)), array6, obj3, cultureInfo), null);
				_ = (GClass3)(object)Class5.Default;
				@struct = @struct;
			}
		}
		try
		{
			while ((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)null) != null)
			{
				class15 = null;
			}
		}
		catch
		{
			_ = (GClass3)(object)Class5.Default;
			class18 = class18;
			_ = (Struct2)Class5.Default;
			qk = qk;
		}
		while ((object)Class5.Default != null)
		{
			while (obj3 != null)
			{
				try
				{
					class14 = (Class5)(object)@class.t(default(BindingFlags), null, obj3, cultureInfo);
				}
				finally
				{
					@struct = default(Struct1);
					continue;
				}
			}
		}
		do
		{
			class36 = null;
		}
		while (@class.t(obj3, (Type)(object)Class5.Default, cultureInfo) != null || obj3 != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		_ = (Class8)(object)((Class7)null).j(default(BindingFlags), array, ref *(object[]*)null, array2, cultureInfo, array4, out object_5);
		do
		{
			_ = (Class4)(object)Class5.Default;
		}
		while (obj3 != null);
		try
		{
			_ = (GClass1)(object)Class5.Default;
			Class7 obj34 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj34.j(bindingFlags, array, ref reference, array2, (CultureInfo)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)@class.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)@class.t(bindingFlags, array6, null, cultureInfo), (ParameterModifier[])null), array, ref reference, null, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), array, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(default(BindingFlags), array, array3, null)), array4, out *(object*)Class5.Default), (CultureInfo)null, (string[])null, out *(object*)Class5.Default), (string[])(object)Class5.Default, out *(object*)null);
			_ = (Class7)(object)Class5.Default;
			class9 = null;
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
		}
		Class7 class42;
		BindingFlags bindingFlags_21;
		Class7 class43;
		BindingFlags bindingFlags_22;
		Class7 class44;
		BindingFlags bindingFlags_23;
		PropertyInfo[] propertyInfo_2;
		Class7 class45;
		Class7 class46;
		BindingFlags bindingFlags_24;
		FieldInfo[] fieldInfo_4;
		Class7 class47;
		do
		{
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)((Class7)(object)class41.t(bindingFlags, array6, null, null)).t(bindingFlags, null, null, cultureInfo);
			class42 = @class;
			bindingFlags_21 = bindingFlags;
			class43 = @class;
			bindingFlags = default(BindingFlags);
			bindingFlags_22 = bindingFlags;
			class44 = @class;
			bindingFlags_23 = bindingFlags;
			propertyInfo_2 = array5;
			class45 = @class;
			class46 = @class;
			bindingFlags_24 = (BindingFlags)Class5.Default;
			fieldInfo_4 = (FieldInfo[])(object)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, array3, array2);
			class47 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class42.j(bindingFlags_21, null, ref *(object[]*)class43.j(bindingFlags_22, (MethodBase[])(object)class44.W(bindingFlags_23, propertyInfo_2, (Type)(object)class45.e((BindingFlags)class46.t(bindingFlags_24, fieldInfo_4, class47.t(bindingFlags, array6, obj3, null), null), array, array3, null), array3, (ParameterModifier[])(object)Class5.Default), ref reference, null, cultureInfo, null, out object_5), array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)null) != null);
		try
		{
			if (uIntPtr != 0)
			{
				try
				{
					class23 = null;
					class23 = class23;
				}
				finally
				{
					gClass4 = null;
					gClass = null;
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_1bd8;
				}
			}
			try
			{
				Class7 obj36 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_25 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array6;
				object object_12 = obj3;
				Class7 obj37 = (Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj3, null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array2), array, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out object_5);
				Class7 class48 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj36.t(bindingFlags_25, fieldInfo_5, object_12, (CultureInfo)(object)obj37.e((BindingFlags)class48.e(bindingFlags, array, array3, array2), (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array2, cultureInfo, (string[])(object)((Class7)null).j((BindingFlags)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(bindingFlags, array6, ((Class7)(object)Class5.Default).W(bindingFlags, null, type, array3, array2), cultureInfo)), array, ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), out object_5), array2, cultureInfo, array4, out *(object*)null), array3, (ParameterModifier[])(object)Class5.Default));
			}
			catch
			{
				_ = (Class8)(object)Class5.Default;
			}
			end_IL_1bd8:;
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					gClass4 = null;
				}
				else
				{
					Class7 class49 = @class;
					BindingFlags bindingFlags_26 = bindingFlags;
					MethodBase[] methodBase_11 = array;
					ref object[] object_13 = ref reference;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, (ParameterModifier[])null);
					CultureInfo cultureInfo_4 = cultureInfo;
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class49.j(bindingFlags_26, methodBase_11, ref object_13, parameterModifier_5, cultureInfo_4, (string[])(object)((Class7)null).j(bindingFlags_27, (MethodBase[])(object)class50.t(bindingFlags, array6, obj3, cultureInfo), ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null), (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array2, null, (string[])(object)Class5.Default, out *(object*)null), out *(object*)Class5.Default), out object_5);
				}
			}
			finally
			{
				do
				{
					class14 = null;
				}
				while ((object)Class5.Default != null);
				goto end_IL_1dc8;
			}
			end_IL_1dc8:;
		}
		do
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		while (obj3 != null);
		_ = (Class8)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
				_ = (Class10)(object)@class.t((BindingFlags)Class5.Default, array6, Class5.Default, cultureInfo);
				_ = (Qk7)(object)Class5.Default;
			}
		}
		checked
		{
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					do
					{
						class4 = class4;
					}
					while (obj3 != null);
				}
			}
			else
			{
				@class = null;
			}
			_ = (Class6)(object)@class.t(bindingFlags, array6, obj3, cultureInfo);
		}
		try
		{
			while (obj3 != null)
			{
			}
		}
		finally
		{
			Class7 obj41 = (Class7)(object)Class5.Default;
			Class7 class51 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])(object)Class5.Default;
			Class7 class52 = @class;
			Type type_5 = type;
			Class7 obj42 = (Class7)(object)Class5.Default;
			object object_14 = @class.t(obj3, type, (CultureInfo)(object)((Class7)null).t((BindingFlags)@class.t(Class5.Default, type, (CultureInfo)(object)@class.e(default(BindingFlags), null, array3, array2)), array6, obj3, cultureInfo));
			Class7 class53 = @class;
			bindingFlags = default(BindingFlags);
			gClass4 = (GClass0)(object)obj41.W((BindingFlags)class51.j(bindingFlags_28, methodBase_12, ref *(object[]*)class52.t(null, type_5, (CultureInfo)obj42.t(object_14, (Type)(object)class53.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])(object)Class5.Default), cultureInfo, array4, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default)), null, cultureInfo, array4, out object_5), array5, type, (Type[])(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array2), null);
			goto IL_2118;
		}
		IL_4763:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class8)(object)Class5.Default;
			class5 = null;
			_ = (Struct2)Class5.Default;
		}
		else
		{
			_ = (Class6)(object)Class5.Default;
		}
		return;
		IL_3443:
		Class7 class54 = @class;
		BindingFlags bindingFlags_29 = bindingFlags;
		Class7 obj43 = (Class7)(object)@class.W(bindingFlags, array5, type, null, array2);
		BindingFlags bindingFlags_30 = bindingFlags;
		MethodBase[] methodBase_13 = array;
		ref object[] object_15 = ref reference;
		ParameterModifier[] parameterModifier_6 = array2;
		Class7 class55 = @class;
		BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
		Class7 obj44 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)class54.j(bindingFlags_29, (MethodBase[])(object)obj43.j(bindingFlags_30, methodBase_13, ref object_15, parameterModifier_6, (CultureInfo)((Class7)null).t((object)class55.W(bindingFlags_31, propertyInfo_3, (Type)(object)obj44.t(bindingFlags, array6, null, cultureInfo), array3, array2), type, (CultureInfo)(object)@class.W(bindingFlags, array5, type, array3, array2)), array4, out object_5), ref *(object[]*)null, null, null, array4, out object_5);
		class18 = null;
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		nuint num8;
		checked
		{
			num8 = unchecked(checked(unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr) / (nuint)(UIntPtr)Class5.Default) * uIntPtr;
			uIntPtr = default(UIntPtr);
		}
		if (num8 / uIntPtr == 0)
		{
			@struct = default(Struct1);
		}
		else if (uIntPtr == 0)
		{
			Class7 obj45 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj45.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(obj3, (Type)(object)Class5.Default, null), array2, null, array4, out *(object*)Class5.Default);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 class56 = @class;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class56.j((BindingFlags)class57.e(bindingFlags, array, array3, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, cultureInfo, array4, out object_5);
				}
				else
				{
					BindingFlags bindingFlags_32 = bindingFlags;
					Class7 class58 = @class;
					BindingFlags bindingFlags_33 = bindingFlags;
					BindingFlags bindingFlags_34 = bindingFlags;
					ref object[] object_16 = ref reference;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)null).j(bindingFlags, array, ref reference, array2, cultureInfo, array4, out object_5);
					string[] string_5 = array4;
					Class7 class59 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_14 = (MethodBase[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array6, obj3, (CultureInfo)null)).e((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array2), (MethodBase[])(object)Class5.Default, null, null);
					ref object[] object_17 = ref *(object[]*)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array2, (CultureInfo)null, (string[])null, out *(object*)null);
					ParameterModifier[] parameterModifier_7 = array2;
					CultureInfo cultureInfo_6 = cultureInfo;
					string[] string_6 = array4;
					Class7 obj46 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])@class.t(null, null, cultureInfo), (Type[])(object)Class5.Default, null), null, null, null);
					BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_15 = (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, null, (Type[])(object)Class5.Default, array2);
					ref object[] object_18 = ref reference;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = (BindingFlags)((Class7)null).j(bindingFlags_34, (MethodBase[])null, ref object_16, (ParameterModifier[])null, cultureInfo_5, string_5, out *(object*)class59.j(bindingFlags_35, methodBase_14, ref object_17, parameterModifier_7, cultureInfo_6, string_6, out *(object*)obj46.j(bindingFlags_36, methodBase_15, ref object_18, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)@class.t(bindingFlags, array6, obj3, null), array2), array4, out *(object*)null)));
					MethodBase[] methodBase_16 = array;
					ref object[] object_19 = ref reference;
					Class7 class60 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)(object)((Class7)null).t(bindingFlags_32, (FieldInfo[])(object)class58.e(bindingFlags_33, null, (Type[])(object)((Class7)null).j(bindingFlags_37, methodBase_16, ref object_19, (ParameterModifier[])null, (CultureInfo)(object)class60.t(bindingFlags, null, null, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])@class.t(obj3, type, null), null, array2)), array4, out *(object*)@class.j(bindingFlags, null, ref reference, array2, (CultureInfo)(object)Class5.Default, array4, out *(object*)null)), null), obj3, (CultureInfo)null)).t(null, type, cultureInfo);
				}
			}
			catch
			{
				do
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		do
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, array, array3, array2)).W(bindingFlags, null, type, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo));
				}
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		while ((object)Class5.Default != null);
		_ = (Class5)(object)((Class7)(object)@class.W(bindingFlags, null, null, null, array2)).e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
		_003CModule_003E = null;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
		}
		while (obj3 != null)
		{
			gClass4 = gClass4;
		}
		if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class15 = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
					class18 = class18;
					_ = (Class4)(object)((Class7)(object)((Class7)@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default)).t((BindingFlags)Class5.Default, null, null, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array, (Type[])((Class7)null).t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null))).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null);
				}
			}
			catch
			{
				try
				{
					_003CModule_003E = null;
					class5 = null;
					class14 = null;
				}
				finally
				{
					_ = (Struct1)((Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)Class5.Default), array2)).t(obj3, (Type)(object)((Class7)@class.t(obj3, type, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array2, cultureInfo, array4, out object_5))).e(bindingFlags, array, null, array2), null), cultureInfo)).j(bindingFlags, array, ref *(object[]*)null, null, null, null, out object_5);
					goto end_IL_3ac0;
				}
				end_IL_3ac0:;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 class61 = @class;
					BindingFlags bindingFlags_38 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)@class.W(default(BindingFlags), null, null, null, array2);
					Type type_6 = type;
					object object_20 = Class5.Default;
					Type type_7 = (Type)(object)Class5.Default;
					object object_21 = Class5.Default;
					Class7 obj50 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class61.W(bindingFlags_38, propertyInfo_4, type_6, null, (ParameterModifier[])((Class7)null).t(object_20, type_7, (CultureInfo)((Class7)null).t(object_21, (Type)(object)obj50.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array2), (CultureInfo)null)));
				}
				else
				{
					_ = (Class6)(object)Class5.Default;
					class36 = class36;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
			{
				try
				{
					do
					{
						Class7 class62 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class6)(object)class62.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					}
					while ((object)@class.e(bindingFlags, array, null, array2) != null);
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						@struct = default(Struct1);
						_ = (Qk7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array2);
						class15 = class15;
						gClass3 = gClass3;
					}
					goto IL_3d70;
				}
			}
			goto IL_3d70;
		}
		IL_33ca:
		struct2 = struct2;
		_ = (Class8)@class.t(obj3, null, cultureInfo);
		_ = (GClass1)(object)Class5.Default;
		gClass3 = gClass3;
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			try
			{
				class18 = class18;
			}
			finally
			{
				try
				{
					_ = (Class2)@class.t(obj3, type, cultureInfo);
				}
				finally
				{
					gClass4 = null;
					goto IL_3443;
				}
			}
		}
		goto IL_3443;
		IL_3ebd:
		class23 = class23;
		try
		{
			try
			{
				Class7 class63 = @class;
				BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_5 = array5;
				Type type_8 = (Type)(object)Class5.Default;
				Type[] type_9 = array3;
				bindingFlags = default(BindingFlags);
				checked
				{
					if ((unchecked((nuint)(UIntPtr)class63.W(bindingFlags_39, propertyInfo_5, type_8, type_9, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)null))) + uIntPtr) * uIntPtr == 0)
					{
						_ = (Struct1)Class5.Default;
					}
				}
			}
			catch
			{
				Class7 class64 = @class;
				Type type_10 = type;
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)class64.t(null, type_10, (CultureInfo)(object)((Class7)(object)class65.j(bindingFlags, null, ref reference, array2, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_5)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo));
			}
		}
		catch
		{
			while (obj3 != null)
			{
				while ((object)Class5.Default != null)
				{
					struct2 = (Struct2)Class5.Default;
				}
			}
		}
		class36 = class36;
		if (uIntPtr == 0)
		{
			while (obj3 != null)
			{
				try
				{
					Class7 class66 = @class;
					Class7 class67 = @class;
					Type type_11 = type;
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class66.e((BindingFlags)((Class7)class67.t(null, type_11, (CultureInfo)(object)class68.W(bindingFlags, array5, type, array3, array2))).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array2), null, array3, array2);
				}
				finally
				{
					Class7 class69 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					Class7 class70 = @class;
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 class71 = @class;
					Class7 class72 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_42 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array5;
					Class7 obj53 = (Class7)(object)Class5.Default;
					object object_22 = ((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])null, array2);
					Type type_12 = (Type)(object)Class5.Default;
					Class7 class73 = @class;
					BindingFlags bindingFlags_43 = bindingFlags;
					Type type_13 = type;
					Type[] type_14 = array3;
					Class7 class74 = @class;
					BindingFlags bindingFlags_44 = bindingFlags;
					Class7 class75 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_45 = bindingFlags;
					MethodBase[] methodBase_17 = array;
					ref object[] object_23 = ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)null, (CultureInfo)null);
					CultureInfo cultureInfo_7 = (CultureInfo)(object)Class5.Default;
					Class7 obj54 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_46 = bindingFlags;
					Type type_15 = type;
					Class7 class76 = @class;
					BindingFlags bindingFlags_47 = bindingFlags;
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = bindingFlags;
					Type[] type_16 = array3;
					Class7 class78 = @class;
					BindingFlags bindingFlags_49 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class69.j((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags_40, (MethodBase[])(object)class70.j(bindingFlags_41, (MethodBase[])(object)class71.e((BindingFlags)class72.W(bindingFlags_42, propertyInfo_6, (Type)(object)((Class7)obj53.t(object_22, type_12, (CultureInfo)(object)class73.W(bindingFlags_43, null, type_13, type_14, (ParameterModifier[])(object)class74.t(bindingFlags_44, (FieldInfo[])(object)class75.j(bindingFlags_45, methodBase_17, ref object_23, null, cultureInfo_7, (string[])(object)obj54.W(bindingFlags_46, null, type_15, (Type[])(object)class76.e(bindingFlags_47, (MethodBase[])(object)class77.W(bindingFlags_48, null, null, type_16, (ParameterModifier[])class78.t(((Class7)null).t(bindingFlags_49, fieldInfo_6, (object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])null), (CultureInfo)null), type, cultureInfo)), array3, array2), null), out *(object*)null), ((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array2), cultureInfo, (string[])null, out object_5), cultureInfo)))).e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)Class5.Default), array3, array2), null, array3, array2), ref reference, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), ref reference, array2, cultureInfo, array4, out object_5)).W(bindingFlags, array5, type, null, array2), array, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj3, null), cultureInfo, array4, out object_5);
					continue;
				}
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Class7)(object)Class5.Default;
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
				_ = (Class2)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				struct2 = (Struct2)Class5.Default;
				class23 = class23;
				_ = (Class10)(object)Class5.Default;
				@class = @class;
			}
		}
		finally
		{
			do
			{
				_ = (Qk7)(object)Class5.Default;
			}
			while (obj3 != null || (object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e((BindingFlags)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, null, cultureInfo, null, out object_5), null, array3, array2), null, out object_5) != null);
			goto IL_451d;
		}
		IL_1145:
		do
		{
			class4 = class4;
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		while (true)
		{
			if (obj3 != null)
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj3 != null);
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		_ = (Struct1)Class5.Default;
		@class = null;
		_ = (Class10)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		Class7 obj57 = (Class7)(object)Class5.Default;
		object object_24 = obj3;
		Class7 class79 = @class;
		BindingFlags bindingFlags_50 = bindingFlags;
		Class7 obj58 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)obj58.W(bindingFlags, null, null, array3, array2);
		BindingFlags bindingFlags_51 = bindingFlags;
		MethodBase[] methodBase_18 = (MethodBase[])(object)@class.W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)Class5.Default);
		Type[] type_17 = (Type[])(object)Class5.Default;
		Class7 obj59 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_52 = (BindingFlags)((Class7)(object)@class.t(default(BindingFlags), array6, obj3, cultureInfo)).j(default(BindingFlags), array, ref reference, null, cultureInfo, array4, out object_5);
		FieldInfo[] fieldInfo_8 = array6;
		Class7 obj60 = (Class7)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo);
		bindingFlags = default(BindingFlags);
		gClass = (GClass1)obj57.t(object_24, (Type)(object)class79.t(bindingFlags_50, fieldInfo_7, null, (CultureInfo)(object)((Class7)null).e(bindingFlags_51, methodBase_18, type_17, (ParameterModifier[])(object)obj59.t(bindingFlags_52, fieldInfo_8, obj60.t(bindingFlags, array6, obj3, null), cultureInfo))), cultureInfo);
		_ = (Struct1)Class5.Default;
		class9 = class9;
		gClass2 = null;
		gClass4 = null;
		try
		{
			_ = (Class10)(object)Class5.Default;
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				if (uIntPtr == 0)
				{
					class4 = null;
				}
				else
				{
					_ = (Struct2)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array2, (CultureInfo)((Class7)null).t(obj3, type, cultureInfo), array4, out *(object*)null);
				}
			}
		}
		while (obj3 != null)
		{
			try
			{
				_ = (Struct1)((Class7)(object)((Class7)null).W(bindingFlags, array5, type, array3, (ParameterModifier[])(object)Class5.Default)).t(obj3, null, cultureInfo);
				Class7 class80 = @class;
				Class7 class81 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_53 = (BindingFlags)class81.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, array4, out object_5);
				PropertyInfo[] propertyInfo_7 = array5;
				Type type_18 = (Type)(object)Class5.Default;
				Class7 class82 = @class;
				BindingFlags bindingFlags_54 = bindingFlags;
				MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
				Type[] type_19 = array3;
				Class7 class83 = @class;
				BindingFlags bindingFlags_55 = (BindingFlags)((Class7)null).e((BindingFlags)@class.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)@class.t(bindingFlags, array6, obj3, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default);
				FieldInfo[] fieldInfo_9 = array6;
				Class7 class84 = @class;
				BindingFlags bindingFlags_56 = bindingFlags;
				Class7 class85 = @class;
				bindingFlags = default(BindingFlags);
				@class = (Class7)(object)class80.W(bindingFlags_53, propertyInfo_7, type_18, (Type[])(object)class82.e(bindingFlags_54, methodBase_19, type_19, (ParameterModifier[])(object)class83.t(bindingFlags_55, fieldInfo_9, class84.W(bindingFlags_56, (PropertyInfo[])(object)class85.e(bindingFlags, array, array3, null), type, array3, array2), null)), (ParameterModifier[])(object)Class5.Default);
			}
			finally
			{
				Class7 class86 = @class;
				BindingFlags bindingFlags_57 = bindingFlags;
				MethodBase[] methodBase_20 = (MethodBase[])@class.t(obj3, (Type)(object)Class5.Default, cultureInfo);
				Type[] type_20 = array3;
				bindingFlags = default(BindingFlags);
				class23 = (Class4)(object)class86.e(bindingFlags_57, methodBase_20, type_20, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)@class.t(bindingFlags, null, obj3, cultureInfo), array2));
				continue;
			}
		}
		try
		{
			do
			{
				class14 = class14;
			}
			while ((object)Class5.Default != null || obj3 != null);
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			goto IL_15b8;
		}
		IL_2493:
		_003CModule_003E = (_003CModule_003E)(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo);
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Struct2)Class5.Default;
					gClass4 = gClass4;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_58 = bindingFlags;
					MethodBase[] methodBase_21 = (MethodBase[])(object)@class.j((BindingFlags)@class.t(obj3, null, null), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out object_5);
					Class7 obj62 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_59 = bindingFlags;
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)class87.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj3, type, null), array3, (ParameterModifier[])(object)Class5.Default);
					Type type_21 = type;
					Type[] type_22 = (Type[])(object)Class5.Default;
					Class7 obj63 = (Class7)(object)Class5.Default;
					Class7 obj64 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_60 = bindingFlags;
					Type type_23 = type;
					Class7 class88 = @class;
					BindingFlags bindingFlags_61 = bindingFlags;
					MethodBase[] methodBase_22 = (MethodBase[])((Class7)(object)Class5.Default).t(@class.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, array2), type, cultureInfo);
					ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo);
					CultureInfo cultureInfo_8 = (CultureInfo)(object)Class5.Default;
					Class7 class89 = @class;
					BindingFlags bindingFlags_62 = bindingFlags;
					FieldInfo[] fieldInfo_10 = array6;
					object object_25 = obj3;
					Class7 class90 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					Class7 class91 = @class;
					Class7 class92 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_23 = (MethodBase[])(object)class91.t((BindingFlags)class92.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array2), null, Class5.Default, cultureInfo);
					ref object[] object_26 = ref reference;
					Class7 obj65 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_64 = bindingFlags;
					Class7 class93 = @class;
					bindingFlags = default(BindingFlags);
					ref object[] object_27 = ref *(object[]*)class93.t(bindingFlags, null, Class5.Default, cultureInfo);
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_9 = cultureInfo;
					string[] string_7 = array4;
					Class7 class94 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj66 = (Class7)(object)class89.t(bindingFlags_62, fieldInfo_10, object_25, (CultureInfo)(object)((Class7)(object)class90.j(bindingFlags_63, methodBase_23, ref object_26, (ParameterModifier[])(object)obj65.j(bindingFlags_64, null, ref object_27, parameterModifier_9, cultureInfo_9, string_7, out *(object*)class94.t(bindingFlags, null, obj3, cultureInfo)), cultureInfo, array4, out *(object*)null)).t(bindingFlags, null, obj3, cultureInfo));
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_65 = (BindingFlags)obj64.W(bindingFlags_60, null, type_23, null, (ParameterModifier[])(object)((Class7)(object)class88.j(bindingFlags_61, methodBase_22, ref *(object[]*)null, parameterModifier_8, cultureInfo_8, (string[])(object)obj66.e(bindingFlags, array, array3, null), out object_5)).e((BindingFlags)Class5.Default, array, array3, (ParameterModifier[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.e(bindingFlags, array, array3, array2), @class.j((BindingFlags)@class.e((BindingFlags)Class5.Default, null, array3, null), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null), (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_5))).e((BindingFlags)Class5.Default, null, null, array2)));
					MethodBase[] methodBase_24 = array;
					Class7 class95 = @class;
					Class7 class96 = @class;
					Class7 obj67 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj68 = (Class7)(object)obj67.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, array4, out object_5);
					Class7 obj69 = (Class7)(object)@class.W(bindingFlags, array5, null, (Type[])(object)Class5.Default, array2);
					object object_28 = obj3;
					Class7 class97 = @class;
					BindingFlags bindingFlags_66 = bindingFlags;
					FieldInfo[] fieldInfo_11 = array6;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_67 = (BindingFlags)obj68.t(obj69.t(object_28, (Type)(object)class97.t(bindingFlags_66, fieldInfo_11, ((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array3, array2), cultureInfo), null), type, cultureInfo);
					ref object[] object_29 = ref *(object[]*)Class5.Default;
					string[] string_8 = array4;
					Class7 obj70 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					object object_30 = ((Class7)null).e(bindingFlags_58, methodBase_21, (Type[])null, (ParameterModifier[])(object)obj62.W(bindingFlags_59, propertyInfo_8, type_21, type_22, (ParameterModifier[])(object)obj63.j(bindingFlags_65, methodBase_24, ref *(object[]*)class95.e((BindingFlags)class96.j(bindingFlags_67, null, ref object_29, null, null, string_8, out *(object*)obj70.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, null, null, out object_5)), array, array3, array2), array2, null, (string[])(object)Class5.Default, out object_5)));
					Class7 obj71 = (Class7)@class.t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj3, cultureInfo), cultureInfo, array4, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default)));
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)((Class7)null).t(object_30, (Type)(object)obj71.W(bindingFlags, null, null, array3, array2), (CultureInfo)null)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array2, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj3, cultureInfo));
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
					_ = (Class0)(object)@class.W(bindingFlags, array5, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array2, null, array4, out object_5), null, array2);
				}
				goto end_IL_24b8;
			}
			end_IL_24b8:;
		}
		catch
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_68 = (BindingFlags)Class5.Default;
					Class7 class98 = @class;
					BindingFlags bindingFlags_69 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])@class.t(Class5.Default, (Type)(object)Class5.Default, null), array2);
					MethodBase[] methodBase_25 = array;
					Class7 class99 = @class;
					bindingFlags = default(BindingFlags);
					object object_31 = ((Class7)(object)((Class7)null).e(bindingFlags_69, methodBase_25, (Type[])(object)class99.t(bindingFlags, array6, @class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo, array4, out *(object*)Class5.Default), obj3, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null)), null), array2)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_70 = bindingFlags;
					MethodBase[] methodBase_26 = (MethodBase[])(object)Class5.Default;
					CultureInfo cultureInfo_10 = (CultureInfo)(object)Class5.Default;
					Class7 obj72 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_71 = bindingFlags;
					ref object[] object_32 = ref reference;
					ParameterModifier[] parameterModifier_10 = (ParameterModifier[])((Class7)(object)Class5.Default).t(((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, cultureInfo, array4, out *(object*)null), type, cultureInfo);
					CultureInfo cultureInfo_11 = cultureInfo;
					Class7 class100 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).W(bindingFlags_68, (PropertyInfo[])null, (Type)class98.t(object_31, null, (CultureInfo)(object)((Class7)null).j(bindingFlags_70, methodBase_26, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_10, (string[])null, out *(object*)obj72.j(bindingFlags_71, null, ref object_32, parameterModifier_10, cultureInfo_11, (string[])(object)class100.e(bindingFlags, array, array3, null), out object_5))), array3, (ParameterModifier[])(object)@class.e(bindingFlags, null, array3, array2));
				}
				finally
				{
					class14 = class14;
					goto end_IL_2b2e;
				}
				end_IL_2b2e:;
			}
			catch
			{
				Class7 class101 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class101.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)((Class7)null).t(obj3, type, cultureInfo));
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)Class5.Default;
			_ = (Struct2)Class5.Default;
		}
		else
		{
			_ = (GClass1)(object)Class5.Default;
		}
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		finally
		{
			_ = (Class9)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, cultureInfo, (string[])null, out object_5);
			Class7 obj75 = (Class7)(object)Class5.Default;
			Class7 class102 = @class;
			BindingFlags bindingFlags_72 = bindingFlags;
			Class7 class103 = @class;
			Class7 class104 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_73 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = array5;
			Class7 class105 = @class;
			object object_33 = ((Class7)(object)@class.e((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)null), (MethodBase[])(object)Class5.Default, null, array2)).t(obj3, type, null);
			Type type_24 = type;
			Class7 class106 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class7)((Class7)(object)((Class7)obj75.t(class102.t(bindingFlags_72, (FieldInfo[])(object)class103.W((BindingFlags)class104.W(bindingFlags_73, propertyInfo_9, (Type)class105.t(object_33, type_24, (CultureInfo)(object)class106.t(bindingFlags, array6, null, null)), array3, array2), array5, type, array3, null), obj3, cultureInfo), type, null)).W((BindingFlags)@class.W(bindingFlags, array5, type, array3, array2), null, type, array3, array2)).t(obj3, (Type)(object)((Class7)null).W(bindingFlags, array5, type, array3, array2), (CultureInfo)(object)Class5.Default);
			class14 = class14;
			_ = (GClass0)(object)Class5.Default;
			goto IL_2f6e;
		}
		IL_0955:
		Class7 class107 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)class107.W(bindingFlags, array5, type, array3, null);
		class14 = class14;
		GClass0 obj76 = (GClass0)(object)Class5.Default;
		gClass4 = (GClass0)(object)Class5.Default;
		gClass4 = obj76;
		class5 = class5;
		gClass = null;
		checked
		{
			nuint num9 = (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default)) * uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default);
			uIntPtr = default(UIntPtr);
			if (num9 - (uIntPtr - (unchecked((nuint)(UIntPtr)@class.W((BindingFlags)Class5.Default, array5, type, null, (ParameterModifier[])(object)Class5.Default)) - uIntPtr)) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						struct2 = struct2;
						struct2 = struct2;
					}
					catch
					{
						Class7 obj77 = (Class7)@class.t(obj3, (Type)(object)@class.e(default(BindingFlags), null, (Type[])((Class7)null).t((object)((Class7)(object)Class5.Default).t(default(BindingFlags), null, obj3, null), type, cultureInfo), array2), null);
						bindingFlags = default(BindingFlags);
						_ = (Qk7)(object)obj77.W(bindingFlags, array5, null, array3, array2);
					}
				}
				else if (uIntPtr == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			_ = (Struct1)Class5.Default;
			if (uIntPtr == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		try
		{
			Class7 class108 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class108.e(bindingFlags, array, array3, array2) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				nuint num10 = uIntPtr;
				nuint num11;
				Class7 obj79;
				checked
				{
					num11 = unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default);
					Class7 class109 = @class;
					bindingFlags = default(BindingFlags);
					obj79 = (Class7)(object)class109.W(bindingFlags, array5, null, null, null);
					bindingFlags = default(BindingFlags);
				}
				if (num10 / checked(num11 * unchecked((nuint)(UIntPtr)obj79.W(bindingFlags, array5, type, array3, null))) == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default)) != 0)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
					struct2 = struct2;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					goto end_IL_0ba5;
				}
			}
			class5 = (Class6)(object)Class5.Default;
			end_IL_0ba5:;
		}
		try
		{
			if (uIntPtr == 0)
			{
				struct2 = default(Struct2);
				struct2 = struct2;
			}
			else
			{
				try
				{
					class18 = null;
					class36 = class36;
					class36 = class36;
					class36 = class36;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				while (true)
				{
					if (obj3 != null)
					{
						_003CModule_003E = _003CModule_003E;
						continue;
					}
					goto end_IL_0c76;
				}
				end_IL_0c76:;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (@class.t(null, type, cultureInfo) != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					Class7 obj84 = (Class7)(object)Class5.Default;
					Class7 class110 = @class;
					bindingFlags = default(BindingFlags);
					class23 = (Class4)(object)obj84.e((BindingFlags)class110.t(bindingFlags, null, obj3, cultureInfo), array, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array, array3, (ParameterModifier[])(object)Class5.Default));
					class23 = class23;
					_ = (GClass1)@class.t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					class14 = null;
					qk = qk;
				}
			}
		}
		while (obj3 != null)
		{
		}
		class5 = class5;
		class9 = null;
		class5 = null;
		_ = (Class8)((Class7)(object)Class5.Default).t(null, type, null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class9)(object)Class5.Default;
		}
		UIntPtr num12 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num12) * uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			else
			{
				_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array2);
			}
			_ = (GClass3)(object)Class5.Default;
		}
		try
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)@class.e((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array6, obj3, (CultureInfo)(object)@class.W((BindingFlags)@class.t(obj3, type, null), (PropertyInfo[])(object)Class5.Default, type, array3, array2))), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array2) == (UIntPtr)(nuint)0u)
				{
					class23 = class23;
				}
			}
			else
			{
				do
				{
					Class7 class111 = @class;
					Class7 class112 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class111.e((BindingFlags)class112.t(bindingFlags, array6, ((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array2), (CultureInfo)(object)Class5.Default), null, array3, array2);
					class15 = class15;
					gClass4 = null;
					qk = qk;
				}
				while (obj3 != null);
			}
		}
		finally
		{
			_ = (Qk7)(object)Class5.Default;
			goto IL_0fa7;
		}
	}

	unsafe static void smethod_5()
	{
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (num == 0)
		{
			try
			{
				BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
				array = null;
				PropertyInfo[] propertyInfo_ = array;
				array2 = null;
				_ = (GClass2)(object)((Class7)null).W(bindingFlags_, propertyInfo_, (Type)null, (Type[])null, array2);
			}
			catch
			{
				nuint num2 = num;
				nuint num3 = num;
				num = default(UIntPtr);
				if (checked(num2 - num3 * num) == 0)
				{
					@struct = (Struct2)Class5.Default;
					@struct = default(Struct2);
				}
				else
				{
					@class = null;
					Class7 class2 = @class;
					bindingFlags = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = bindingFlags;
					array3 = null;
					_ = (GClass1)(object)class2.e(bindingFlags_2, array3, (Type[])(object)Class5.Default, array2);
				}
			}
		}
		else if (num == 0)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj2 = obj2;
				if (obj2 != null)
				{
					try
					{
						_ = (Qk7)(object)Class5.Default;
					}
					catch
					{
						Struct1 obj3 = (Struct1)Class5.Default;
						struct2 = struct2;
						struct2 = obj3;
					}
					continue;
				}
				break;
			}
		}
		else
		{
			Class7 obj5 = (Class7)(object)Class5.Default;
			Class7 class3 = @class;
			BindingFlags bindingFlags_3 = bindingFlags;
			BindingFlags bindingFlags_4 = bindingFlags;
			array4 = null;
			Type[] type_ = (Type[])(object)((Class7)null).e(bindingFlags_4, (MethodBase[])null, array4, array2);
			BindingFlags bindingFlags_5 = (BindingFlags)Class5.Default;
			cultureInfo = cultureInfo;
			if ((UIntPtr)obj5.t(class3.e(bindingFlags_3, null, type_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_5, (FieldInfo[])null, (object)null, cultureInfo)), null, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array2)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = (GClass1)(object)Class5.Default;
					gClass = gClass;
				}
				finally
				{
					gClass2 = gClass2;
					gClass2 = null;
					goto IL_015a;
				}
			}
		}
		goto IL_015a;
		IL_0a99:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj2 != null)
		{
			try
			{
				_003CModule_003E = null;
			}
			catch
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				do
				{
					@struct = default(Struct2);
				}
				while (obj2 != null);
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class4);
		if ((UIntPtr)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array3, ref reference, array2, cultureInfo, array5, out object_), (MethodBase[])@class.t(((Class7)null).W(bindingFlags, array, (Type)null, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(obj2, type, cultureInfo), (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null), (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, array, (Type)null, array4, (ParameterModifier[])(object)Class5.Default)), (Type)(object)Class5.Default, null), array4, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, null)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == 0)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, (ParameterModifier[])(object)Class5.Default);
				}
			}
			catch
			{
				_ = (GClass2)(object)Class5.Default;
				class4 = class4;
				_ = (GClass1)(object)Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class5);
		checked
		{
			try
			{
			}
			finally
			{
				try
				{
					bindingFlags = default(BindingFlags);
					if (unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null)) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						class5 = null;
						_ = (Class2)(object)Class5.Default;
						_ = (Class4)(object)Class5.Default;
						gClass3 = (GClass2)(object)Class5.Default;
					}
				}
				finally
				{
					goto IL_0c12;
				}
			}
		}
		IL_0ebd:
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class7);
		if ((UIntPtr)((Class7)null).e(bindingFlags, array3, array4, array2) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class6 = null;
				}
				else
				{
					class7 = class7;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class8);
		try
		{
			if (num == 0)
			{
				try
				{
					@struct = default(Struct2);
					@struct = @struct;
				}
				finally
				{
					class8 = null;
					goto end_IL_0efa;
				}
			}
			end_IL_0efa:;
		}
		catch
		{
			num = default(UIntPtr);
			nuint num4 = num;
			Class7 obj8 = (Class7)(object)Class5.Default;
			Type type_2 = type;
			Class7 obj9 = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array, (Type)null, (Type[])((Class7)null).t(obj2, type, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array3, (Type[])(object)Class5.Default, (ParameterModifier[])null)), array2);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_6 = bindingFlags;
			MethodBase[] methodBase_ = (MethodBase[])(object)((Class7)(object)@class.t(bindingFlags, array6, obj2, cultureInfo)).j((BindingFlags)Class5.Default, null, ref *(object[]*)((Class7)null).W(default(BindingFlags), array, type, array4, (ParameterModifier[])(object)Class5.Default), array2, cultureInfo, null, out *(object*)null);
			Class7 class9 = @class;
			Type[] type_3 = (Type[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj10 = (Class7)(object)obj9.e(bindingFlags_6, methodBase_, (Type[])(object)class9.t((BindingFlags)((Class7)null).e(default(BindingFlags), (MethodBase[])null, type_3, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)@class.e(bindingFlags, null, null, array2)).j(bindingFlags, (MethodBase[])@class.t(obj2, type, cultureInfo), ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out object_), out object_)), null, null, (CultureInfo)(object)@class.W(default(BindingFlags), array, type, array4, null)), array2);
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num4 - unchecked((nuint)(UIntPtr)obj8.t(null, type_2, (CultureInfo)(object)obj10.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo))) == 0)
				{
					class10 = class10;
				}
			}
		}
		Class8 class11 = class11;
		while ((object)Class5.Default != null)
		{
			try
			{
				while (obj2 != null)
				{
					class5 = class5;
				}
			}
			catch
			{
				do
				{
					class11 = class11;
				}
				while (obj2 != null);
			}
		}
		Class5 class12;
		while (obj2 != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass3 = gClass3;
				continue;
			}
			_ = (Qk7)(object)Class5.Default;
			_ = (GClass1)(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, array2, cultureInfo, (string[])(object)Class5.Default, out object_);
			class12 = null;
			gClass2 = null;
		}
		try
		{
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), type, null, null))) - num) == 0)
			{
				_ = (Class9)(object)@class.e((BindingFlags)Class5.Default, array3, (Type[])@class.t(null, null, cultureInfo), (ParameterModifier[])(object)@class.W(bindingFlags, null, (Type)(object)@class.j(bindingFlags, array3, ref reference, array2, (CultureInfo)(object)Class5.Default, array5, out object_), array4, null));
			}
		}
		finally
		{
			Class7 obj13 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_7 = bindingFlags;
			MethodBase[] methodBase_2 = array3;
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)obj13.e(bindingFlags_7, methodBase_2, (Type[])(object)class13.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null), array2);
			goto IL_1263;
		}
		IL_2e3d:
		while ((object)Class5.Default != null)
		{
			while (obj2 != null)
			{
				if (num == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		_ = (Class2)(object)Class5.Default;
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					Class7 obj14 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array3, array4, null);
					Class7 class14 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj14.t((BindingFlags)class14.t(bindingFlags, null, obj2, null), array6, ((Class7)null).t(obj2, (Type)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)Class5.Default, array2, (CultureInfo)null, array5, out *(object*)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array4, (ParameterModifier[])(object)Class5.Default), null, array5, out object_)), cultureInfo), cultureInfo);
				}
			}
			finally
			{
				_ = (GClass3)(object)@class.W(bindingFlags, array, type, array4, array2);
				continue;
			}
		}
		while ((object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, null) != null);
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass1)(object)((Class7)null).e(bindingFlags, array3, array4, (ParameterModifier[])(object)Class5.Default);
				_ = (Class9)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, null);
			}
		}
		while (obj2 != null);
		_ = (Class4)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		_ = (Class5)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array2)).j(default(BindingFlags), array3, ref reference, array2, (CultureInfo)(object)Class5.Default, array5, out *(object*)null), obj2, cultureInfo)).t(Class5.Default, type, (CultureInfo)(object)Class5.Default);
		Class7 obj16 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		gClass = (GClass1)(object)((Class7)obj16.t(((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo), null, (CultureInfo)(object)Class5.Default)).j((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array4, array2), (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, array5, out object_);
		nuint num5 = num;
		num = default(UIntPtr);
		if (checked(num5 - num) == 0)
		{
			UIntPtr num6 = (UIntPtr)Class5.Default;
			UIntPtr num7 = (UIntPtr)Class5.Default;
			nuint num11;
			checked
			{
				nuint num8 = unchecked((nuint)(UIntPtr)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null)).t(bindingFlags, null, null, cultureInfo)) + unchecked((nuint)(UIntPtr)@class.e(bindingFlags, null, array4, array2)) - unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, null, null, array2));
				Class7 obj17 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_8 = bindingFlags;
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				nuint num9 = (unchecked((nuint)num7) + unchecked(num8 / (nuint)(UIntPtr)obj17.j(bindingFlags_8, (MethodBase[])(object)class15.W(bindingFlags, null, type, null, array2), ref reference, (ParameterModifier[])(object)Class5.Default, null, array5, out object_))) * (num - num);
				UIntPtr num10 = unchecked((UIntPtr)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null));
				num = default(UIntPtr);
				num11 = unchecked((nuint)num6) + (num9 * (unchecked((nuint)num10 / num) - num) + unchecked(num / (nuint)(UIntPtr)Class5.Default));
				num = default(UIntPtr);
			}
			if (checked(num11 * (unchecked((nuint)default(UIntPtr)) + num + unchecked((nuint)(UIntPtr)Class5.Default))) / num == 0)
			{
				_ = (GClass2)(object)Class5.Default;
			}
			else
			{
				class8 = class8;
			}
		}
		class6 = null;
		do
		{
			IL_327b:
			if (obj2 != null)
			{
				try
				{
					class8 = class8;
				}
				finally
				{
					Class7 class16 = @class;
					BindingFlags bindingFlags_9 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = array;
					Type type_4 = type;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).j((BindingFlags)class16.W(bindingFlags_9, propertyInfo_2, type_4, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, null, null, array2)), (MethodBase[])null, ref reference, array2, (CultureInfo)null, array5, out *(object*)((Class7)null).t(obj2, type, cultureInfo));
					goto IL_327b;
				}
			}
		}
		while (obj2 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			while (true)
			{
				if ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)null)).t(Class5.Default, type, cultureInfo), type, array4, array2) != null)
				{
					Class7 obj18 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, @class.j(bindingFlags, array3, ref reference, null, cultureInfo, array5, out *(object*)null), cultureInfo);
					BindingFlags bindingFlags_10 = bindingFlags;
					FieldInfo[] fieldInfo_ = array6;
					object object_2 = obj2;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)obj18.t((BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags_10, fieldInfo_, object_2, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null))).t(Class5.Default, type, cultureInfo), array6, obj2, (CultureInfo)(object)Class5.Default);
					_ = (Class9)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, (Type[])((Class7)null).t((object)null, type, cultureInfo), array2);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		else
		{
			_ = (Struct2)((Class7)(object)Class5.Default).t(obj2, type, null);
		}
		if (num == 0)
		{
			Class7 obj19 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)obj19.t(bindingFlags, array6, null, cultureInfo);
		}
		else
		{
			while (obj2 != null)
			{
				gClass = gClass;
			}
		}
		do
		{
			class12 = class12;
		}
		while (obj2 != null || obj2 != null);
		do
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				nuint num12 = num;
				Class7 class17 = @class;
				BindingFlags bindingFlags_11 = bindingFlags;
				Class7 class18 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj20 = (Class7)(object)class17.j(bindingFlags_11, (MethodBase[])(object)class18.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), cultureInfo, array5, out object_), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_);
				BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
				Type[] type_5 = array4;
				Class7 class19 = @class;
				BindingFlags bindingFlags_13 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array6;
				Class7 class20 = @class;
				Class7 class21 = @class;
				Class7 class22 = @class;
				bindingFlags = default(BindingFlags);
				if (num12 / (nuint)(UIntPtr)obj20.e(bindingFlags_12, null, type_5, (ParameterModifier[])(object)class19.t(bindingFlags_13, fieldInfo_2, class20.j((BindingFlags)((Class7)(object)class21.W((BindingFlags)class22.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), array, (Type)(object)Class5.Default, array4, array2)).j(bindingFlags, array3, ref reference, array2, (CultureInfo)(object)@class.t(bindingFlags, null, obj2, null), array5, out object_), array3, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out object_), cultureInfo)) == 0)
				{
					class7 = null;
				}
			}
		}
		while (obj2 != null);
		_ = (Class4)(object)Class5.Default;
		try
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class6 = class6;
				}
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			class8 = class8;
			goto IL_3573;
		}
		IL_3c26:
		while (obj2 != null)
		{
		}
		return;
		IL_2932:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				try
				{
					class6 = class6;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
					struct2 = default(Struct1);
				}
				goto IL_29eb;
			}
		}
		if (num == 0)
		{
			try
			{
				gClass3 = null;
			}
			catch
			{
				_ = (Class6)@class.t(obj2, null, null);
			}
		}
		goto IL_29eb;
		IL_39b2:
		class11 = class11;
		gClass2 = (GClass0)(object)Class5.Default;
		while (obj2 != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					class8 = (Class0)(object)@class.t((BindingFlags)Class5.Default, array6, obj2, null);
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					class7 = class7;
					struct2 = struct2;
					continue;
				}
			}
		}
		if (num == 0)
		{
			do
			{
				try
				{
					class6 = (Class9)(object)Class5.Default;
				}
				catch
				{
					_ = (Class7)((Class7)@class.t(obj2, type, cultureInfo)).t(((Class7)null).e(bindingFlags, array3, array4, (ParameterModifier[])null), type, cultureInfo);
				}
			}
			while (obj2 != null);
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array4, (ParameterModifier[])null);
				}
				finally
				{
					@struct = @struct;
					continue;
				}
			}
		}
		try
		{
			Class7 class23 = @class;
			Class7 class24 = @class;
			Class7 obj25 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_14 = (BindingFlags)class24.e((BindingFlags)obj25.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)@class.t(null, (Type)(object)Class5.Default, null)), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			Class7 class25 = @class;
			BindingFlags bindingFlags_15 = (BindingFlags)@class.t((BindingFlags)Class5.Default, array6, obj2, cultureInfo);
			Class7 class26 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj26 = (Class7)(object)class26.t(bindingFlags, array6, obj2, cultureInfo);
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)(UIntPtr)class23.t(bindingFlags_14, (FieldInfo[])(object)class25.t(bindingFlags_15, null, obj26.e(bindingFlags, array3, null, array2), cultureInfo), null, null)) - num == 0)
				{
					_ = (Class5)(object)((Class7)(object)@class.t(bindingFlags, array6, obj2, null)).t(bindingFlags, array6, null, null);
				}
			}
		}
		finally
		{
			goto IL_3b8b;
		}
		IL_0c12:
		do
		{
			class5 = class5;
		}
		while (obj2 != null);
		while ((object)Class5.Default != null)
		{
			class11 = class11;
		}
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)@class.t(null, null, null)) * unchecked((nuint)(UIntPtr)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)null)) == 0)
				{
					while (obj2 != null)
					{
						@struct = @struct;
						_ = (Class9)@class.t(obj2, null, cultureInfo);
						class6 = class6;
						class6 = class6;
					}
				}
			}
			while ((object)Class5.Default != null);
			nuint num13 = num;
			num = default(UIntPtr);
			if (num13 * (unchecked((nuint)default(UIntPtr)) + num) == 0)
			{
				ParameterModifier[] parameterModifier_ = array2;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)unchecked(((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo), (string[])(object)Class5.Default, out *(object*)null));
			}
			else if (num == 0)
			{
				while (obj2 != null)
				{
					gClass3 = (GClass2)(object)Class5.Default;
				}
			}
		}
		do
		{
			_ = (Class4)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, array, type, array4, array2), type, array4, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, cultureInfo))).t(obj2, (Type)(object)Class5.Default, cultureInfo);
		}
		while ((object)Class5.Default != null);
		while ((object)Class5.Default != null)
		{
			while (obj2 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass0)(object)@class.W(bindingFlags, null, type, array4, null);
					continue;
				}
				_ = (Class4)(object)Class5.Default;
				class8 = class8;
			}
		}
		_ = (Class2)(object)@class.W((BindingFlags)Class5.Default, null, type, array4, null);
		gClass3 = gClass3;
		@class = @class;
		_ = (GClass1)(object)((Class7)null).e(bindingFlags, array3, array4, array2);
		_ = (GClass1)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default);
		_ = (Class10)((Class7)(object)Class5.Default).t(obj2, (Type)(object)@class.j(default(BindingFlags), array3, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_), (CultureInfo)(object)Class5.Default);
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		catch
		{
			class7 = class7;
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@class = null;
				}
				else
				{
					gClass2 = (GClass0)(object)Class5.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		while ((object)Class5.Default != null)
		{
		}
		class5 = null;
		try
		{
			gClass = null;
		}
		finally
		{
			nuint num14 = num;
			nuint num15 = num;
			nuint num16 = num;
			num = default(UIntPtr);
			if (num14 / (num15 / checked(num16 + num)) == 0)
			{
				_ = (GClass0)(object)Class5.Default;
			}
			else
			{
				struct2 = struct2;
			}
			goto IL_0ebd;
		}
		IL_1eea:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					Class7 obj28 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)obj28.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)@class.e(bindingFlags, array3, array4, array2), (ParameterModifier[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, array6, obj2, cultureInfo)).W(bindingFlags, null, type, array4, null));
				}
			}
		}
		catch
		{
			_ = (Struct1)Class5.Default;
		}
		try
		{
			_ = (Class8)(object)Class5.Default;
		}
		finally
		{
			goto IL_1f91;
		}
		IL_015a:
		try
		{
			try
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass0)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo);
					goto end_IL_015c;
				}
				end_IL_015c:;
			}
			finally
			{
				Class7 class27 = @class;
				BindingFlags bindingFlags_16 = bindingFlags;
				array6 = null;
				Class7 obj31 = (Class7)(object)class27.t(bindingFlags_16, array6, obj2, null);
				Class7 obj32 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_17 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = array;
				type = type;
				BindingFlags bindingFlags_18 = (BindingFlags)obj32.W(bindingFlags_17, propertyInfo_3, type, array4, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default));
				MethodBase[] methodBase_3 = array3;
				ParameterModifier[] parameterModifier_2 = array2;
				CultureInfo cultureInfo_ = cultureInfo;
				string[] string_ = (string[])(object)((Class7)null).W((BindingFlags)Class5.Default, array, (Type)null, array4, array2);
				object_ = ref *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, (ParameterModifier[])null);
				_ = (Class9)(object)obj31.j(bindingFlags_18, methodBase_3, ref *(object[]*)null, parameterModifier_2, cultureInfo_, string_, out object_);
				goto end_IL_015b;
			}
			end_IL_015b:;
		}
		finally
		{
			if (num == 0)
			{
				while ((object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, cultureInfo) != null)
				{
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_19 = bindingFlags;
					MethodBase[] methodBase_4 = array3;
					reference = ref *(object[]*)@class.t(Class5.Default, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, null), (CultureInfo)(object)Class5.Default);
					Class4 obj33 = (Class4)(object)((Class7)null).e((BindingFlags)class28.j(bindingFlags_19, methodBase_4, ref reference, null, cultureInfo, null, out *(object*)Class5.Default), array3, array4, (ParameterModifier[])null);
					class5 = null;
					class5 = obj33;
					Class7 class29 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class29.W(bindingFlags, array, type, array4, null);
					Class7 class30 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					MethodBase[] methodBase_5 = array3;
					ref object[] object_3 = ref reference;
					Class7 obj34 = (Class7)(object)@class.e(bindingFlags, array3, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, (Type[])(object)Class5.Default, array2));
					BindingFlags bindingFlags_21 = bindingFlags;
					ref object[] object_4 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_3 = array2;
					array5 = array5;
					_ = (Qk7)(object)class30.W((BindingFlags)((Class7)null).j(bindingFlags_20, methodBase_5, ref object_3, (ParameterModifier[])(object)obj34.j(bindingFlags_21, null, ref object_4, parameterModifier_3, null, array5, out *(object*)null), cultureInfo, (string[])(object)Class5.Default, out object_), array, (Type)(object)Class5.Default, null, null);
				}
			}
			goto IL_037d;
		}
		IL_037d:
		nuint num17 = num;
		num = default(UIntPtr);
		if (checked(num17 - num) == 0)
		{
			_ = (GClass3)(object)@class.t(bindingFlags, null, null, cultureInfo);
			@class = @class;
			class12 = Class5.Default;
			class12 = class12;
			bindingFlags = default(BindingFlags);
			class12 = (Class5)(object)((Class7)null).e(bindingFlags, array3, (Type[])(object)@class.t(bindingFlags, null, obj2, null), (ParameterModifier[])null);
			goto IL_046c;
		}
		try
		{
			try
			{
				_ = (GClass1)(object)((Class7)null).W(bindingFlags, array, type, (Type[])null, (ParameterModifier[])(object)Class5.Default);
			}
			finally
			{
				Class7 class31 = @class;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class31.j((BindingFlags)class32.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, array6, Class5.Default, cultureInfo)), array3, ref reference, array2, cultureInfo, array5, out object_);
				goto end_IL_03e3;
			}
			end_IL_03e3:;
		}
		finally
		{
			try
			{
				gClass = null;
			}
			finally
			{
				class8 = class8;
				class8 = null;
				goto IL_046c;
			}
		}
		IL_17f4:
		UIntPtr num18 = num;
		num = default(UIntPtr);
		if ((nuint)num18 / checked(unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - num)) == 0)
		{
			try
			{
				Class7 class33 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class33.e(bindingFlags, array3, array4, array2);
				gClass = (GClass1)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, array2), array, type, null, (ParameterModifier[])(object)Class5.Default), out *(object*)Class5.Default);
				class4 = null;
				_ = (Class4)(object)@class.W(default(BindingFlags), array, type, null, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					_ = (Class8)(object)@class.t((BindingFlags)Class5.Default, array6, Class5.Default, cultureInfo);
					goto end_IL_18c1;
				}
				end_IL_18c1:;
			}
		}
		else
		{
			_ = (Class8)(object)Class5.Default;
		}
		Qk7 qk = qk;
		qk = qk;
		_ = (Class6)(object)((Class7)(object)@class.j(default(BindingFlags), array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)Class5.Default)).t(default(BindingFlags), (FieldInfo[])(object)@class.W((BindingFlags)Class5.Default, array, type, null, null), obj2, null);
		class5 = class5;
		if (num == 0)
		{
			_ = (Class9)(object)Class5.Default;
		}
		while (obj2 != null)
		{
			if (num == 0)
			{
				try
				{
					_ = (Class5)((Class7)null).t((object)null, type, (CultureInfo)null);
				}
				catch
				{
					BindingFlags bindingFlags_22 = (BindingFlags)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, null, (CultureInfo)(object)Class5.Default, array5, out object_);
					Class7 class34 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags_22, (FieldInfo[])(object)class34.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), obj2, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array, type, array4, array2)).t(bindingFlags, null, @class.W((BindingFlags)Class5.Default, array, type, array4, array2), (CultureInfo)(object)Class5.Default);
				}
			}
		}
		do
		{
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)((Class7)(object)((Class7)null).W(bindingFlags, array, (Type)null, array4, array2)).t(bindingFlags, array6, null, cultureInfo);
		}
		while ((object)Class5.Default != null || obj2 != null);
		try
		{
			try
			{
				num = default(UIntPtr);
				if (checked(num + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					class7 = (Class6)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, null, out *(object*)null), array5, out *(object*)Class5.Default));
				}
			}
			catch
			{
				if (num == 0)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		catch
		{
			do
			{
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num19 = (UIntPtr)((Class7)(object)((Class7)(object)class35.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array3, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_)).W(bindingFlags, array, null, null, (ParameterModifier[])(object)Class5.Default);
				Class7 obj38 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array2, (CultureInfo)null, array5, out *(object*)@class.t(Class5.Default, type, (CultureInfo)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array2)).t(Class5.Default, null, cultureInfo)));
				BindingFlags bindingFlags_23 = bindingFlags;
				Class7 obj39 = (Class7)(object)Class5.Default;
				object object_5 = obj2;
				Type type_6 = type;
				Class7 class36 = @class;
				Class7 obj40 = (Class7)(object)@class.j(default(BindingFlags), array3, ref *(object[]*)null, array2, null, array5, out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				if (checked(unchecked((nuint)num19) - unchecked((nuint)(UIntPtr)obj38.t(bindingFlags_23, (FieldInfo[])(object)obj39.e(default(BindingFlags), (MethodBase[])((Class7)null).t(object_5, type_6, (CultureInfo)(object)class36.t((BindingFlags)obj40.t((BindingFlags)((Class7)null).W(bindingFlags, array, type, array4, (ParameterModifier[])(object)Class5.Default), array6, null, cultureInfo), null, obj2, cultureInfo)), array4, (ParameterModifier[])(object)Class5.Default), obj2, cultureInfo))) != 0)
				{
					Class7 class37 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class37.j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array6, obj2, cultureInfo), ref *(object[]*)null, (ParameterModifier[])((Class7)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)((Class7)null).t(obj2, (Type)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), cultureInfo), null, ref *(object[]*)null, null, null, null, out *(object*)Class5.Default))).t(Class5.Default, type, cultureInfo), (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
				}
				else
				{
					qk = (Qk7)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)@class.t(bindingFlags, null, null, null), null, null, array5, out object_);
				}
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Struct1)Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				try
				{
					_ = (Class5)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, null, array4, null), (Type[])null, array2);
				}
				catch
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).e(bindingFlags, array3, null, array2);
				}
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				while (obj2 != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
				goto IL_1eea;
			}
			try
			{
				_ = (GClass3)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, null, null), ref reference, (ParameterModifier[])@class.t(Class5.Default, type, (CultureInfo)(object)((Class7)(object)@class.e(bindingFlags, array3, array4, array2)).j(bindingFlags, array3, ref reference, array2, cultureInfo, null, out object_)), cultureInfo, array5, out object_);
				class7 = null;
				class12 = (Class5)(object)@class.W((BindingFlags)Class5.Default, array, (Type)(object)Class5.Default, array4, array2);
			}
			finally
			{
				class5 = null;
				class7 = class7;
				gClass = gClass;
				@struct = @struct;
				goto IL_1eea;
			}
		}
		IL_29eb:
		while (obj2 != null)
		{
			_ = (Struct2)@class.e(bindingFlags, (MethodBase[])((Class7)null).t(obj2, (Type)null, (CultureInfo)null), (Type[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, (CultureInfo)(object)@class.W(bindingFlags, array, type, (Type[])(object)Class5.Default, null), array5, out *(object*)@class.t(null, null, null)), (ParameterModifier[])(object)Class5.Default);
		}
		_ = (GClass1)(object)Class5.Default;
		_ = (Class8)(object)Class5.Default;
		Class7 obj44;
		BindingFlags bindingFlags_24;
		ref object[] object_6;
		ParameterModifier[] parameterModifier_4;
		Class7 obj45;
		BindingFlags bindingFlags_25;
		FieldInfo[] fieldInfo_3;
		object object_7;
		Class7 obj46;
		object object_8;
		Class7 class39;
		do
		{
			try
			{
				class10 = null;
			}
			catch
			{
				_ = (Class6)(object)@class.e(bindingFlags, array3, array4, array2);
				_ = (GClass1)(object)Class5.Default;
			}
			obj44 = (Class7)(object)Class5.Default;
			bindingFlags_24 = bindingFlags;
			Class7 class38 = @class;
			bindingFlags = default(BindingFlags);
			object_6 = ref *(object[]*)class38.j(bindingFlags, array3, ref *(object[]*)null, array2, cultureInfo, array5, out *(object*)null);
			parameterModifier_4 = array2;
			obj45 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, array6, obj2, (CultureInfo)null);
			bindingFlags_25 = (BindingFlags)((Class7)((Class7)(object)@class.e(bindingFlags, array3, null, array2)).t(Class5.Default, (Type)(object)Class5.Default, null)).t(@class.j(default(BindingFlags), array3, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(default(BindingFlags), array6, null, (CultureInfo)(object)Class5.Default), cultureInfo, array5, out *(object*)null), type, cultureInfo);
			fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			object_7 = obj2;
			obj46 = (Class7)(object)Class5.Default;
			object_8 = obj2;
			class39 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj44.j(bindingFlags_24, null, ref object_6, parameterModifier_4, (CultureInfo)(object)obj45.t(bindingFlags_25, fieldInfo_3, object_7, (CultureInfo)obj46.t(object_8, (Type)(object)class39.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj2, type, cultureInfo), obj2, null), array2), null)), null, out object_) != null);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					class10 = class10;
					class12 = null;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)((Class7)null).t(((Class7)(object)class40.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default)).t(@class.W(bindingFlags, array, null, null, array2), null, null), (Type)null, cultureInfo);
				}
			}
			else
			{
				while (obj2 != null)
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
		}
		finally
		{
			goto IL_2bfe;
		}
		IL_046c:
		try
		{
			while (obj2 != null)
			{
				try
				{
					Class10 obj47 = (Class10)(object)Class5.Default;
					class10 = class10;
					class10 = obj47;
				}
				finally
				{
					Class7 obj48 = (Class7)(object)Class5.Default;
					Class7 obj49 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_26 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					ref object[] object_9 = ref reference;
					ParameterModifier[] parameterModifier_5 = array2;
					CultureInfo cultureInfo_2 = cultureInfo;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class41 = @class;
					object object_10 = obj2;
					Class7 class42 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					Class7 class43 = @class;
					BindingFlags bindingFlags_29 = bindingFlags;
					BindingFlags bindingFlags_30 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj48.j((BindingFlags)obj49.j(bindingFlags_26, methodBase_6, ref object_9, parameterModifier_5, cultureInfo_2, (string[])(object)((Class7)null).t(bindingFlags_27, (FieldInfo[])class41.t(object_10, (Type)(object)class42.j(bindingFlags_28, (MethodBase[])(object)class43.t(bindingFlags_29, (FieldInfo[])(object)((Class7)null).W(bindingFlags_30, propertyInfo_4, (Type)(object)class44.t(bindingFlags, array6, obj2, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array3, array4, array2), (Type[])null, array2)), (Type[])null, array2), Class5.Default, cultureInfo), ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)@class.t(null, type, cultureInfo), array4, array2), obj2, (CultureInfo)(object)Class5.Default)).j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, cultureInfo, array5, out *(object*)null), out *(object*)Class5.Default), cultureInfo), obj2, cultureInfo), out object_), (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), ref reference, array2, (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
					continue;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				goto end_IL_0653;
			}
			end_IL_0653:;
		}
		do
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				class11 = class11;
				class11 = null;
			}
		}
		while (obj2 != null);
		_ = (GClass2)(object)@class.e((BindingFlags)@class.t(obj2, type, null), (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), array4, (ParameterModifier[])(object)Class5.Default);
		while (obj2 != null)
		{
			try
			{
				_ = (Class8)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array2);
			}
			finally
			{
				if (num == 0)
				{
					Class7 obj51 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).e(bindingFlags, array3, array4, (ParameterModifier[])(object)Class5.Default), (object)((Class7)(object)((Class7)(object)@class.e(bindingFlags, array3, array4, null)).W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, array, null, array4, array2), null, array4, array2)).e(bindingFlags, null, array4, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array6, obj2, null)), cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj51.e(bindingFlags, null, null, null);
					gClass2 = gClass2;
					struct2 = (Struct1)((Class7)null).t(obj2, (Type)null, (CultureInfo)null);
				}
				else
				{
					_ = (Struct2)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null);
				}
				continue;
			}
		}
		try
		{
			if (num == 0)
			{
				gClass3 = null;
				gClass3 = gClass3;
			}
		}
		catch
		{
			try
			{
				class5 = null;
				class4 = null;
				class4 = class4;
			}
			finally
			{
				struct2 = struct2;
				class7 = null;
				goto end_IL_0828;
			}
			end_IL_0828:;
		}
		finally
		{
			Class7 obj53 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)obj53.t(bindingFlags, (FieldInfo[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), obj2, cultureInfo);
			goto IL_0888;
		}
		IL_2d51:
		checked
		{
			try
			{
				nuint num20 = num;
				num = default(UIntPtr);
				nuint num21 = num20 * num;
				num = default(UIntPtr);
				if (num21 - num != 0)
				{
					@class = null;
				}
			}
			catch
			{
				try
				{
					try
					{
						class12 = Class5.Default;
					}
					catch
					{
						_ = (GClass3)(object)Class5.Default;
					}
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class0)(object)@class.t(bindingFlags, null, obj2, cultureInfo);
				}
			}
			finally
			{
				try
				{
					_ = (Struct2)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, cultureInfo, null, out object_);
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Class4)(object)@class.t(bindingFlags, array6, Class5.Default, null);
				}
				goto end_IL_2d9f;
			}
			end_IL_2d9f:;
		}
		finally
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			else
			{
				while (obj2 != null)
				{
					@struct = @struct;
				}
			}
			goto IL_2e3d;
		}
		IL_1f91:
		class12 = null;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo)) == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
			class8 = null;
			class5 = null;
			_ = (Class0)(object)Class5.Default;
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)((Class7)null).t(bindingFlags, array6, obj2, cultureInfo);
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)@class.t(bindingFlags, array6, obj2, null);
				}
			}
			finally
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass0)((Class7)(object)Class5.Default).t(obj2, (Type)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, array4, null), cultureInfo);
					goto end_IL_1ffc;
				}
			}
			end_IL_1ffc:;
		}
		while (obj2 != null)
		{
			try
			{
				class4 = (Class2)(object)Class5.Default;
			}
			finally
			{
				_ = (Class5)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, null, null, out object_);
				continue;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array4, null) == (UIntPtr)(nuint)0u)
				{
					class11 = null;
				}
				else
				{
					Class7 class45 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)((Class7)(object)class45.W(bindingFlags, array, null, null, array2)).t(obj2, (Type)@class.t(null, null, (CultureInfo)((Class7)null).t((object)Class5.Default, type, cultureInfo)), (CultureInfo)(object)Class5.Default);
				}
			}
			else
			{
				try
				{
					_ = (Struct1)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.W(bindingFlags, array, type, null, (ParameterModifier[])((Class7)null).t(obj2, (Type)null, cultureInfo)), array4, array2);
				}
				catch
				{
					class11 = null;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					@class = @class;
					Class7 class46 = @class;
					Class7 obj60 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_31 = bindingFlags;
					MethodBase[] methodBase_7 = array3;
					ref object[] object_11 = ref reference;
					ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)@class.e(bindingFlags, array3, null, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj2, cultureInfo));
					Class7 obj61 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass = (GClass1)(object)class46.j((BindingFlags)obj60.j(bindingFlags_31, methodBase_7, ref object_11, parameterModifier_6, null, null, out *(object*)obj61.e(bindingFlags, array3, (Type[])(object)@class.t((BindingFlags)Class5.Default, null, obj2, cultureInfo), (ParameterModifier[])@class.t(obj2, (Type)(object)Class5.Default, null))), array3, ref reference, array2, cultureInfo, array5, out object_);
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					class12 = (Class5)(object)((Class7)null).W(bindingFlags, array, type, array4, (ParameterModifier[])null);
				}
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
				class10 = class10;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (_003CModule_003E)@class.t(obj2, (Type)@class.t(null, type, cultureInfo), cultureInfo);
			}
		}
		while ((object)@class.W(bindingFlags, array, (Type)((Class7)(object)Class5.Default).t(Class5.Default, type, (CultureInfo)(object)((Class7)null).e(bindingFlags, array3, array4, (ParameterModifier[])null)), array4, array2) != null)
		{
			try
			{
				nuint num22 = num;
				Class7 class47 = @class;
				BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_4 = array6;
				Class7 class48 = @class;
				Class7 class49 = @class;
				BindingFlags bindingFlags_33 = bindingFlags;
				Class7 obj65 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_34 = bindingFlags;
				MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
				ref object[] object_12 = ref reference;
				ParameterModifier[] parameterModifier_7 = array2;
				Class7 obj66 = (Class7)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t((BindingFlags)Class5.Default, null, obj2, (CultureInfo)(object)Class5.Default), array2, null, null, out *(object*)null), cultureInfo, array5, out *(object*)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default), Class5.Default, null))).j(bindingFlags, array3, ref reference, array2, cultureInfo, array5, out object_), obj2, (CultureInfo)null), ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.t((BindingFlags)((Class7)null).W(bindingFlags, array, (Type)null, array4, array2), null, null, cultureInfo), cultureInfo, array5, out object_), type, null);
				bindingFlags = default(BindingFlags);
				UIntPtr num23 = (UIntPtr)((Class7)(object)class47.t(bindingFlags_32, fieldInfo_4, class48.t((BindingFlags)((Class7)null).t((object)class49.j(bindingFlags_33, (MethodBase[])(object)obj65.j(bindingFlags_34, methodBase_8, ref object_12, parameterModifier_7, (CultureInfo)(object)obj66.W(bindingFlags, array, (Type)(object)Class5.Default, array4, array2), array5, out *(object*)null), ref *(object[]*)null, array2, cultureInfo, array5, out *(object*)@class.W((BindingFlags)@class.t(obj2, type, cultureInfo), (PropertyInfo[])@class.t(@class.t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo), type, (CultureInfo)((Class7)null).t(obj2, (Type)null, cultureInfo)), type, null, array2)), type, (CultureInfo)(object)Class5.Default), null, obj2, cultureInfo), null)).t(((Class7)@class.t(Class5.Default, null, cultureInfo)).t(bindingFlags, array6, Class5.Default, cultureInfo), type, cultureInfo);
				num = default(UIntPtr);
				nuint num24 = num22 / ((nuint)num23 / num);
				Class7 class50 = @class;
				Class7 class51 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj67 = (Class7)(object)((Class7)(object)class51.j(bindingFlags, null, ref reference, null, (CultureInfo)((Class7)null).t(obj2, (Type)null, cultureInfo), null, out *(object*)@class.t(obj2, (Type)(object)@class.e(bindingFlags, array3, (Type[])(object)((Class7)null).t(bindingFlags, array6, obj2, cultureInfo), array2), (CultureInfo)(object)Class5.Default))).t(bindingFlags, null, null, null);
				BindingFlags bindingFlags_35 = bindingFlags;
				Type type_7 = (Type)(object)Class5.Default;
				Class7 obj68 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if (num24 / (nuint)(UIntPtr)class50.e((BindingFlags)obj67.W(bindingFlags_35, null, type_7, (Type[])(object)obj68.j((BindingFlags)((Class7)null).e(bindingFlags, array3, (Type[])null, array2), array3, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)Class5.Default, null, out object_), array2), array3, array4, array2) == 0)
				{
					@class = @class;
					continue;
				}
				object object_13 = Class5.Default;
				Type type_8 = type;
				Class7 class52 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)((Class7)null).t(object_13, type_8, (CultureInfo)(object)class52.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null));
			}
			catch
			{
				class5 = class5;
			}
		}
		gClass = gClass;
		Class7 obj70 = (Class7)(object)Class5.Default;
		Class7 class53 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class8)obj70.t(class53.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, null, (Type)@class.t(obj2, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)@class.t(obj2, (Type)(object)@class.W(bindingFlags, array, type, array4, array2), cultureInfo), array4, (ParameterModifier[])(object)Class5.Default), cultureInfo), array4, array2), type, array4, null), type, null);
		class7 = (Class6)(object)Class5.Default;
		if ((UIntPtr)@class.W(bindingFlags, array, null, null, null) == (UIntPtr)(nuint)0u)
		{
			Class7 obj71 = (Class7)(object)@class.W(default(BindingFlags), array, (Type)(object)Class5.Default, null, null);
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj71.t(bindingFlags, array6, obj2, null);
		}
		else
		{
			checked
			{
				try
				{
					while ((object)Class5.Default != null)
					{
						class4 = class4;
						qk = (Qk7)(object)Class5.Default;
						_ = (Struct1)Class5.Default;
						class12 = class12;
					}
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (GClass3)(object)@class.e(bindingFlags, array3, null, array2);
					}
				}
			}
		}
		class12 = class12;
		do
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					@struct = default(Struct2);
					@struct = @struct;
				}
			}
			finally
			{
				UIntPtr num25 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)num25) + num) == 0)
				{
					@struct = @struct;
				}
				continue;
			}
		}
		while (obj2 != null);
		try
		{
			try
			{
				try
				{
					@class = @class;
				}
				finally
				{
					class4 = class4;
					goto end_IL_2879;
				}
				end_IL_2879:;
			}
			catch
			{
				if (num == 0)
				{
					_ = (GClass2)((Class7)(object)Class5.Default).t(null, (Type)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), cultureInfo);
					Class7 class54 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class54.e(bindingFlags, array3, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, (CultureInfo)(object)Class5.Default));
				}
			}
		}
		catch
		{
		}
		try
		{
			if (num == 0)
			{
				while ((object)Class5.Default != null)
				{
					class11 = null;
				}
			}
		}
		finally
		{
			try
			{
				class6 = class6;
			}
			catch
			{
				class8 = (Class0)(object)Class5.Default;
			}
			goto IL_2932;
		}
		IL_3573:
		try
		{
			if ((UIntPtr)@class.t((BindingFlags)Class5.Default, null, @class.W(bindingFlags, null, type, array4, null), cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		catch
		{
			gClass3 = gClass3;
		}
		Class7 class55 = @class;
		BindingFlags bindingFlags_36 = bindingFlags;
		MethodBase[] methodBase_9 = (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, array4, array2);
		ref object[] object_14 = ref *(object[]*)Class5.Default;
		Class7 class56 = @class;
		BindingFlags bindingFlags_37 = (BindingFlags)Class5.Default;
		Class7 class57 = @class;
		BindingFlags bindingFlags_38 = bindingFlags;
		Class7 class58 = @class;
		bindingFlags = default(BindingFlags);
		FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)((Class7)(object)class58.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, null, out object_)).j(bindingFlags, array3, ref reference, null, cultureInfo, null, out *(object*)Class5.Default);
		object object_15 = ((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, null, type, array4, array2), cultureInfo, array5, out object_);
		Class7 obj77 = (Class7)(object)Class5.Default;
		Class7 obj78 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)class55.j(bindingFlags_36, methodBase_9, ref object_14, null, (CultureInfo)(object)class56.W(bindingFlags_37, (PropertyInfo[])(object)class57.t(bindingFlags_38, fieldInfo_5, object_15, (CultureInfo)(object)obj77.W((BindingFlags)obj78.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array2), array, null, array4, array2)), (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default), (string[])(object)Class5.Default, out object_);
		_ = (Struct1)@class.t(bindingFlags, array6, obj2, (CultureInfo)(object)@class.W(bindingFlags, array, type, array4, array2));
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, null, null, array4, null)) + unchecked((nuint)(UIntPtr)Class5.Default) + (num - unchecked((nuint)default(UIntPtr))) == 0)
				{
					do
					{
						class4 = (Class2)(object)Class5.Default;
					}
					while (obj2 != null);
				}
			}
			catch
			{
				try
				{
					@struct = @struct;
				}
				catch
				{
					try
					{
						_ = (Class6)(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2);
						_ = (Class2)(object)Class5.Default;
						class8 = (Class0)(object)@class.W(bindingFlags, array, type, null, null);
						qk = qk;
						goto end_IL_377a;
					}
					finally
					{
						Class7 class59 = @class;
						object object_16 = obj2;
						Class7 obj79 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(default(BindingFlags), array, type, array4, (ParameterModifier[])(object)Class5.Default), null, null);
						bindingFlags = default(BindingFlags);
						_ = (GClass2)class59.t(object_16, null, (CultureInfo)(object)obj79.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array2));
						_ = (Class8)(object)Class5.Default;
						goto end_IL_377a;
					}
					end_IL_377a:;
				}
			}
			while ((object)Class5.Default != null)
			{
				_ = (Class4)(object)Class5.Default;
			}
			_ = (Class0)((Class7)null).t((object)null, (Type)(object)((Class7)null).W(bindingFlags, array, type, array4, (ParameterModifier[])null), (CultureInfo)(object)Class5.Default);
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - num == 0)
			{
				unchecked
				{
					while (true)
					{
						if (obj2 != null)
						{
							BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
							Class7 class60 = @class;
							BindingFlags bindingFlags_40 = bindingFlags;
							PropertyInfo[] propertyInfo_5 = array;
							bindingFlags = default(BindingFlags);
							_ = (Qk7)(object)((Class7)null).W(bindingFlags_39, (PropertyInfo[])null, (Type)(object)class60.W(bindingFlags_40, propertyInfo_5, (Type)(object)((Class7)null).j(bindingFlags, array3, ref reference, array2, cultureInfo, (string[])null, out *(object*)null), array4, array2), (Type[])((Class7)(object)Class5.Default).t(obj2, null, cultureInfo), (ParameterModifier[])(object)Class5.Default);
							_ = (GClass1)(object)Class5.Default;
						}
						else if (obj2 == null)
						{
							break;
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
						class11 = class11;
					}
					finally
					{
						_ = (Class6)(object)@class.e(bindingFlags, array3, array4, array2);
						goto end_IL_3920;
					}
					end_IL_3920:;
				}
				catch
				{
					gClass3 = gClass3;
					@struct = (Struct2)Class5.Default;
					_ = (Class2)(object)Class5.Default;
				}
			}
			while (obj2 != null)
			{
				class7 = class7;
			}
			Class7 class61 = @class;
			bindingFlags = default(BindingFlags);
			if ((unchecked((nuint)(UIntPtr)class61.W(bindingFlags, null, type, array4, array2)) + unchecked((nuint)(UIntPtr)Class5.Default)) * num == 0)
			{
				try
				{
					if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
					{
						class4 = null;
					}
				}
				finally
				{
					do
					{
						class5 = null;
					}
					while ((object)Class5.Default != null);
					goto IL_39b2;
				}
			}
			goto IL_39b2;
		}
		IL_2bfe:
		gClass = (GClass1)(object)Class5.Default;
		_ = (Class6)(object)Class5.Default;
		do
		{
			_ = (Class8)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
		}
		while (obj2 != null || obj2 != null);
		do
		{
			@struct = @struct;
		}
		while ((object)Class5.Default != null);
		try
		{
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_41 = bindingFlags;
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_42 = bindingFlags;
			MethodBase[] methodBase_10 = array3;
			Class7 class64 = @class;
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_11 = array3;
			ref object[] object_17 = ref reference;
			ParameterModifier[] parameterModifier_8 = array2;
			Class7 class65 = @class;
			BindingFlags bindingFlags_44 = bindingFlags;
			PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)@class.e(bindingFlags, array3, array4, array2);
			Class7 class66 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)class62.j(bindingFlags_41, (MethodBase[])(object)class63.e(bindingFlags_42, methodBase_10, (Type[])(object)class64.j(bindingFlags_43, methodBase_11, ref object_17, parameterModifier_8, (CultureInfo)(object)class65.W(bindingFlags_44, propertyInfo_6, (Type)(object)class66.W(bindingFlags, array, type, (Type[])(object)Class5.Default, array2), array4, array2), array5, out object_), array2), ref *(object[]*)@class.e((BindingFlags)((Class7)null).e((BindingFlags)@class.t(null, (Type)(object)Class5.Default, null), array3, (Type[])(object)((Class7)null).W(bindingFlags, array, type, array4, array2), (ParameterModifier[])null), array3, array4, null), array2, cultureInfo, array5, out *(object*)Class5.Default);
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				qk = (Qk7)(object)Class5.Default;
			}
			goto IL_2d51;
		}
		IL_3b8b:
		if (num == 0)
		{
			_ = (GClass0)(object)((Class7)null).W(bindingFlags, array, type, array4, array2);
		}
		try
		{
			_ = (Class6)(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])@class.t(obj2, type, cultureInfo), cultureInfo, null, out *(object*)null);
			qk = (Qk7)(object)((Class7)null).t((BindingFlags)@class.e(bindingFlags, array3, null, null), array6, (object)null, (CultureInfo)null);
			gClass = gClass;
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)((Class7)null).W(default(BindingFlags), array, type, array4, (ParameterModifier[])null);
			}
			goto IL_3c26;
		}
		IL_1263:
		if (checked(num - num) == 0)
		{
			struct2 = (Struct1)Class5.Default;
		}
		else
		{
			Class7 class67 = @class;
			bindingFlags = default(BindingFlags);
			class12 = (Class5)(object)class67.e(bindingFlags, array3, null, null);
		}
		class11 = null;
		gClass = gClass;
		_ = (Struct2)@class.t((BindingFlags)Class5.Default, array6, null, cultureInfo);
		class12 = (Class5)(object)((Class7)null).t(bindingFlags, array6, obj2, cultureInfo);
		class5 = null;
		class12 = null;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				Class7 obj83 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_45 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array6;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)obj83.t(bindingFlags_45, fieldInfo_6, null, (CultureInfo)(object)class68.j(bindingFlags, array3, ref reference, null, null, array5, out *(object*)Class5.Default));
			}
		}
		catch
		{
			_ = (Class10)(object)Class5.Default;
		}
		class11 = class11;
		class7 = (Class6)(object)Class5.Default;
		gClass3 = gClass3;
		if ((nuint)(UIntPtr)Class5.Default / num == 0)
		{
			Class7 class69 = @class;
			Class7 class70 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class69.W((BindingFlags)class70.t(((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)Class5.Default), null, type, array4, null);
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 class71 = @class;
				BindingFlags bindingFlags_46 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
				Type type_9 = type;
				Class7 class72 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				FieldInfo[] fieldInfo_7 = array6;
				Class7 obj85 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)@class.t(null, (Type)((Class7)@class.t(@class.t(default(BindingFlags), array6, null, null), null, cultureInfo)).t(Class5.Default, null, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)Class5.Default), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), null, array4, (ParameterModifier[])(object)Class5.Default);
				object object_18 = obj2;
				Type type_10 = type;
				bindingFlags = default(BindingFlags);
				if ((object)class71.W(bindingFlags_46, propertyInfo_7, type_9, (Type[])(object)class72.t(bindingFlags_47, fieldInfo_7, obj85.t(object_18, type_10, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, cultureInfo, array5, out object_)), cultureInfo), array2) == null)
				{
					break;
				}
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				_ = (Qk7)(object)@class.j((BindingFlags)@class.e(bindingFlags, null, array4, null), array3, ref reference, null, cultureInfo, null, out object_);
			}
			finally
			{
				try
				{
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = bindingFlags;
					Class7 class74 = @class;
					Class7 class75 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_49 = bindingFlags;
					Class7 obj87 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_12 = (MethodBase[])(object)class74.t((BindingFlags)class75.t(bindingFlags_49, (FieldInfo[])(object)obj87.e(bindingFlags, array3, (Type[])(object)Class5.Default, array2), null, null), array6, obj2, cultureInfo);
					Type[] type_11 = array4;
					Class7 class76 = @class;
					BindingFlags bindingFlags_50 = (BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
					MethodBase[] methodBase_13 = array3;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					Class7 class77 = @class;
					object object_19 = obj2;
					Class7 class78 = @class;
					object object_20 = obj2;
					Class7 class79 = @class;
					object object_21 = obj2;
					Type type_12 = type;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					Class7 obj88 = (Class7)((Class7)null).t(obj2, type, (CultureInfo)(object)@class.j((BindingFlags)((Class7)null).e(bindingFlags, array3, array4, (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref reference, null, cultureInfo, array5, out object_)), array3, ref *(object[]*)null, array2, cultureInfo, array5, out *(object*)Class5.Default));
					BindingFlags bindingFlags_53 = (BindingFlags)((Class7)((Class7)(object)Class5.Default).t(obj2, type, null)).t(obj2, type, (CultureInfo)(object)Class5.Default);
					Class7 class80 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_14 = array3;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class73.e(bindingFlags_48, methodBase_12, type_11, (ParameterModifier[])(object)class76.e(bindingFlags_50, methodBase_13, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_51, (MethodBase[])class77.t(object_19, (Type)class78.t(object_20, (Type)class79.t(object_21, type_12, (CultureInfo)(object)((Class7)null).e(bindingFlags_52, (MethodBase[])(object)obj88.W(bindingFlags_53, null, (Type)(object)class80.j(bindingFlags_54, methodBase_14, ref *(object[]*)class81.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), array2, cultureInfo, array5, out object_), null, (ParameterModifier[])(object)@class.e(bindingFlags, array3, array4, array2)), (Type[])null, array2)), null), null), array4, (ParameterModifier[])null)));
				}
				finally
				{
					_ = (Class2)@class.t(obj2, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])((Class7)@class.t(obj2, (Type)(object)Class5.Default, null)).t(obj2, type, cultureInfo), type, array4, (ParameterModifier[])(object)((Class7)(object)((Class7)null).e(bindingFlags, array3, (Type[])((Class7)@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default)).t(obj2, null, cultureInfo), array2)).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)((Class7)null).t((object)null, type, (CultureInfo)null)).e(bindingFlags, array3, null, (ParameterModifier[])(object)@class.t((BindingFlags)@class.t(bindingFlags, array6, obj2, cultureInfo), array6, obj2, null)), (Type[])(object)Class5.Default, null)), cultureInfo);
					goto end_IL_14c4;
				}
			}
			end_IL_14c4:;
		}
		finally
		{
			do
			{
				_ = (Class8)@class.t(Class5.Default, type, cultureInfo);
			}
			while ((object)Class5.Default != null);
			goto IL_17f4;
		}
		IL_0888:
		_ = (Qk7)(object)Class5.Default;
		_ = (_003CModule_003E)(object)Class5.Default;
		nuint num26 = checked(num * num);
		BindingFlags bindingFlags_55 = bindingFlags;
		MethodBase[] methodBase_15 = array3;
		ref object[] object_22 = ref *(object[]*)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(null, type, cultureInfo));
		ParameterModifier[] parameterModifier_9 = array2;
		Class7 obj89 = (Class7)(object)Class5.Default;
		object object_23 = @class.t((BindingFlags)Class5.Default, array6, null, cultureInfo);
		Class7 obj90 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array4, null);
		BindingFlags bindingFlags_56 = (BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), array3, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, (string[])(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array2, null, null, out object_), out *(object*)Class5.Default);
		Type[] type_13 = array4;
		Class7 class82 = @class;
		BindingFlags bindingFlags_57 = bindingFlags;
		MethodBase[] methodBase_16 = array3;
		ref object[] object_24 = ref *(object[]*)((Class7)null).e((BindingFlags)Class5.Default, array3, array4, array2);
		ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if (checked(num26 * unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_55, methodBase_15, ref object_22, parameterModifier_9, (CultureInfo)obj89.t(object_23, (Type)(object)obj90.e(bindingFlags_56, null, type_13, (ParameterModifier[])(object)class82.j(bindingFlags_57, methodBase_16, ref object_24, parameterModifier_10, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default), null, out object_)), cultureInfo), (string[])(object)Class5.Default, out *(object*)null))) == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class7 = (Class6)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Struct1)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
					_ = Class5.Default;
					goto IL_0a99;
				}
			}
		}
		goto IL_0a99;
	}

	unsafe static void smethod_6()
	{
		Class7 @class = null;
		Class7 class2 = @class;
		BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_ = null;
		Class7 class3 = @class;
		Type type_ = null;
		CultureInfo cultureInfo = cultureInfo;
		ref object[] object_ = ref *(object[]*)class3.t(null, type_, cultureInfo);
		CultureInfo cultureInfo_ = (CultureInfo)(object)Class5.Default;
		Class7 class4 = @class;
		BindingFlags bindingFlags = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_2 = (BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo);
		FieldInfo[] array = array;
		FieldInfo[] fieldInfo_ = array;
		object obj = Class5.Default;
		string[] string_ = (string[])(object)class4.t(bindingFlags_2, fieldInfo_, obj, cultureInfo);
		@class = (Class7)(object)class2.j(bindingFlags_, methodBase_, ref object_, null, cultureInfo_, string_, out *(object*)null);
		nuint uIntPtr = (UIntPtr)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class5);
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
					class5 = class5;
					class5 = class5;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			@struct = @struct;
			@struct = default(Struct2);
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class6);
		while (obj != null)
		{
			class6 = class6;
			class6 = class6;
			@class = null;
			Class4 obj3 = (Class4)(object)Class5.Default;
			class7 = class7;
			class7 = obj3;
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class8 = @class;
			Class7 obj4 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			array2 = (PropertyInfo[])class8.t(((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)obj4.t(bindingFlags, array, obj, (CultureInfo)(object)Class5.Default), obj, cultureInfo), null, (CultureInfo)(object)Class5.Default);
			PropertyInfo[] propertyInfo_ = array2;
			Class7 class9 = @class;
			BindingFlags bindingFlags_4 = bindingFlags;
			Class7 class10 = @class;
			BindingFlags bindingFlags_5 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array2;
			Class7 class11 = @class;
			BindingFlags bindingFlags_6 = bindingFlags;
			BindingFlags bindingFlags_7 = bindingFlags;
			array3 = array3;
			Type[] type_2 = array3;
			Class7 class12 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = array2;
			Type[] type_3 = array3;
			array4 = array4;
			_ = (Class9)(object)((Class7)null).W(bindingFlags_3, propertyInfo_, (Type)(object)class9.e(bindingFlags_4, (MethodBase[])(object)class10.W(bindingFlags_5, propertyInfo_2, type_, null, (ParameterModifier[])(object)class11.t(bindingFlags_6, (FieldInfo[])(object)((Class7)null).e(bindingFlags_7, methodBase_, type_2, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)class12.W(bindingFlags_8, propertyInfo_3, null, type_3, array4), (FieldInfo[])null, obj, cultureInfo)), obj, cultureInfo)), array3, null), (Type[])null, array4);
		}
		BindingFlags bindingFlags_9 = bindingFlags;
		FieldInfo[] fieldInfo_2 = array;
		Class7 class13 = @class;
		ref object[] object_2 = ref *(object[]*)@class.t((BindingFlags)Class5.Default, null, null, (CultureInfo)(object)Class5.Default);
		ParameterModifier[] parameterModifier_ = array4;
		Class7 class14 = @class;
		BindingFlags bindingFlags_10 = (BindingFlags)Class5.Default;
		Class7 class15 = @class;
		Class7 class16 = @class;
		bindingFlags = default(BindingFlags);
		string[] string_2 = (string[])(object)class14.e(bindingFlags_10, (MethodBase[])class15.t(obj, (Type)(object)((Class7)(object)class16.t(bindingFlags, array, null, cultureInfo)).j(bindingFlags, null, ref *(object[]*)null, array4, null, null, out *(object*)null), null), (Type[])(object)Class5.Default, array4);
		ref object reference = ref reference;
		UIntPtr num = (UIntPtr)((Class7)null).t(bindingFlags_9, fieldInfo_2, (object)class13.j(default(BindingFlags), null, ref object_2, parameterModifier_, null, string_2, out reference), cultureInfo);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		if (checked(unchecked((nuint)num) * uIntPtr) == 0)
		{
			GClass0 obj5 = (GClass0)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null);
			gClass = (GClass0)(object)Class5.Default;
			gClass = obj5;
			Class7 obj6 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj6.e(bindingFlags, methodBase_, null, array4);
			_ = (Class5)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out reference);
			_ = (GClass0)(object)Class5.Default;
		}
		else if (uIntPtr != 0)
		{
			try
			{
				class5 = (Class9)(object)Class5.Default;
			}
			catch
			{
				gClass2 = null;
				gClass2 = gClass2;
			}
		}
		_ = (GClass2)(object)Class5.Default;
		Class7 obj8 = (Class7)@class.t(null, type_, null);
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)obj8.e(bindingFlags, methodBase_, (Type[])(object)@class.e(bindingFlags, methodBase_, array3, array4), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, null));
		_ = (GClass0)(object)((Class7)null).t(bindingFlags, array, obj, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class17);
		while ((object)Class5.Default != null)
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					class17 = (Class8)(object)Class5.Default;
					class17 = class17;
				}
				else
				{
					class6 = class6;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((nuint)(UIntPtr)@class.t(Class5.Default, type_, null) / (nuint)(UIntPtr)Class5.Default == 0)
				{
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)class18.t(bindingFlags, array, obj, null);
					qk = qk;
				}
			}
			finally
			{
				class19 = class19;
				class19 = class19;
				goto IL_073e;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		try
		{
			if ((UIntPtr)((Class7)null).t((object)Class5.Default, type_, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				Class7 class20 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class20.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)null);
				class19 = class19;
				_ = (Class8)(object)Class5.Default;
				qk = qk;
			}
		}
		finally
		{
			BindingFlags bindingFlags_11 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
			reference2 = ref reference2;
			nuint num2 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Class7)null).j(bindingFlags_11, methodBase_2, ref reference2, array4, (CultureInfo)null, string_, out reference);
			checked
			{
				nuint num3 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (num2 - (num3 + (unchecked(uIntPtr / (nuint)(UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)Class5.Default)) * uIntPtr - unchecked((nuint)default(UIntPtr)))) == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (Struct2)@class.t(bindingFlags, array, obj, null);
					qk = (Qk7)@class.t(Class5.Default, type_, cultureInfo);
				}
				goto IL_073e;
			}
		}
		IL_177e:
		_ = (Class7)(object)Class5.Default;
		class19 = (Class10)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass3);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass3 = (GClass1)(object)@class.e(bindingFlags, null, array3, array4);
				}
				catch
				{
					Class7 class21 = @class;
					ref object[] object_3 = ref reference2;
					ParameterModifier[] parameterModifier_2 = array4;
					Class7 class22 = @class;
					Class7 class23 = @class;
					BindingFlags bindingFlags_12 = (BindingFlags)((Class7)null).t(((Class7)null).t((object)null, (Type)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array3, array4), cultureInfo), (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, obj, (CultureInfo)(object)Class5.Default));
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class21.j(default(BindingFlags), methodBase_, ref object_3, parameterModifier_2, null, (string[])(object)((Class7)(object)class22.e((BindingFlags)class23.e(bindingFlags_12, (MethodBase[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)null), null, array4), null, array3, array4)).W(bindingFlags, array2, type_, array3, null), out reference);
				}
				goto IL_1b4d;
			}
			try
			{
				_003CModule_003E = _003CModule_003E;
				Class7 class24 = @class;
				bindingFlags = default(BindingFlags);
				gClass3 = (GClass1)(object)((Class7)null).W((BindingFlags)class24.W(bindingFlags, array2, null, array3, array4), (PropertyInfo[])null, type_, array3, array4);
			}
			finally
			{
				class17 = null;
				_ = (Struct2)Class5.Default;
				qk = qk;
				_ = (Struct1)((Class7)(object)Class5.Default).t(obj, type_, null);
				goto IL_1b4d;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class29);
		try
		{
			try
			{
				Class7 class25 = @class;
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				object object_4 = class26.W(bindingFlags, array2, type_, array3, null);
				Class7 obj10 = (Class7)((Class7)null).t((object)null, type_, cultureInfo);
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 class28 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)class25.t(object_4, type_, (CultureInfo)obj10.t(obj, type_, (CultureInfo)(object)class27.j(bindingFlags_13, null, ref *(object[]*)((Class7)(object)class28.j(bindingFlags, methodBase_, ref reference2, array4, (CultureInfo)(object)Class5.Default, null, out reference)).t(obj, type_, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out *(object*)Class5.Default)));
			}
			finally
			{
				class7 = class7;
				class29 = (Class0)@class.t(Class5.Default, (Type)(object)Class5.Default, null);
				class29 = class29;
				goto end_IL_19ab;
			}
			end_IL_19ab:;
		}
		finally
		{
			do
			{
				_ = (GClass1)(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)null, array3, array4);
				_ = (Class6)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
				_ = (Class4)(object)@class.j(bindingFlags, methodBase_, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
			}
			while (obj != null);
			goto IL_1b4d;
		}
		IL_3753:
		try
		{
			class6 = null;
		}
		catch
		{
			do
			{
				try
				{
					gClass = null;
				}
				finally
				{
					_ = (Class0)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array4);
					continue;
				}
			}
			while (obj != null);
		}
		Class7 class30 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)class30.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array4);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		if (uIntPtr == 0)
		{
			class6 = (Class2)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.t(bindingFlags, array, Class5.Default, null)).t(obj, null, cultureInfo), obj, null);
		}
		else
		{
			gClass4 = (GClass2)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class31);
		if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr) == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class31 = null;
				}
				else
				{
					class29 = null;
				}
			}
			catch
			{
				class31 = class31;
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					gClass4 = gClass4;
					class5 = class5;
					_ = (Class2)(object)@class.W(default(BindingFlags), null, (Type)(object)Class5.Default, array3, array4);
				}
				finally
				{
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class32.W(bindingFlags, array2, (Type)(object)Class5.Default, null, array4);
					_ = (GClass1)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, null, (Type[])(object)Class5.Default, array4);
					continue;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			goto IL_392b;
		}
		IL_08a6:
		while (obj != null)
		{
			try
			{
				_ = (Struct1)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)@class.t(null, null, cultureInfo)).e(bindingFlags, methodBase_, array3, array4));
			}
			finally
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
				class7 = null;
				continue;
			}
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					qk = null;
				}
				finally
				{
					@class = null;
					gClass = gClass;
					class7 = class7;
					_ = (Class9)(object)Class5.Default;
					continue;
				}
			}
		}
		try
		{
			if (uIntPtr == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				qk = qk;
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Struct1)@class.t((BindingFlags)Class5.Default, array, null, (CultureInfo)(object)Class5.Default);
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					BindingFlags bindingFlags_14 = bindingFlags;
					ref object[] object_5 = ref reference2;
					ParameterModifier[] parameterModifier_3 = array4;
					CultureInfo cultureInfo_2 = cultureInfo;
					Class7 obj13 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_15 = (BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array3, array4);
					PropertyInfo[] propertyInfo_4 = array2;
					Type type_4 = (Type)(object)Class5.Default;
					Type[] type_5 = array3;
					BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
					Type[] type_6 = (Type[])@class.t(obj, type_, null);
					Class7 obj14 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).j(bindingFlags_14, methodBase_, ref object_5, parameterModifier_3, cultureInfo_2, string_, out *(object*)obj13.W(bindingFlags_15, propertyInfo_4, type_4, type_5, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_16, (MethodBase[])null, type_6, (ParameterModifier[])(object)obj14.j(bindingFlags, null, ref reference2, array4, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default))));
					goto end_IL_093a;
				}
				finally
				{
					qk = qk;
					_ = (GClass1)(object)Class5.Default;
					class17 = null;
					goto end_IL_093a;
				}
				end_IL_093a:;
			}
		}
		_ = (Class7)(object)Class5.Default;
		Class7 class33 = @class;
		BindingFlags bindingFlags_17 = bindingFlags;
		Class7 class34 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)class33.e(bindingFlags_17, methodBase_, (Type[])(object)class34.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)@class.e(default(BindingFlags), methodBase_, null, array4)));
		class19 = class19;
		_ = (Class10)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class35);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)((Class7)(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, null, null)).W((BindingFlags)Class5.Default, array2, type_, null, (ParameterModifier[])(object)Class5.Default);
			}
			else
			{
				struct2 = struct2;
				struct2 = struct2;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					class17 = null;
				}
				catch
				{
					class35 = class35;
				}
			}
		}
		Class7 obj19 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)obj19.t(bindingFlags, null, ((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)null)).t(obj, type_, cultureInfo), cultureInfo);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					class31 = class31;
					class31 = null;
					Class7 class36 = @class;
					BindingFlags bindingFlags_18 = (BindingFlags)((Class7)(object)@class.e(bindingFlags, methodBase_, array3, array4)).t(obj, type_, null);
					MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
					ref object[] object_6 = ref *(object[]*)Class5.Default;
					BindingFlags bindingFlags_19 = bindingFlags;
					Class7 obj20 = (Class7)(object)@class.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_20 = bindingFlags;
					Class7 obj21 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_21 = (BindingFlags)@class.t(obj, null, cultureInfo);
					Class7 obj22 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)class36.j(bindingFlags_18, methodBase_3, ref object_6, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_19, (MethodBase[])(object)obj20.j(bindingFlags_20, (MethodBase[])(object)obj21.e(bindingFlags_21, null, (Type[])(object)obj22.t(bindingFlags, null, obj, cultureInfo), null), ref *(object[]*)null, array4, cultureInfo, null, out *(object*)null), (Type[])null, array4), cultureInfo, null, out reference);
				}
				finally
				{
					gClass4 = null;
					gClass4 = null;
					_ = (Class0)(object)Class5.Default;
					_ = (Class0)(object)Class5.Default;
					goto end_IL_0baf;
				}
			}
			end_IL_0baf:;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				while (obj != null)
				{
					_ = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type_, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, array3, array4)));
				}
			}
			goto IL_0d68;
		}
		IL_415a:
		do
		{
			try
			{
				_ = (Class4)((Class7)null).t((object)null, type_, (CultureInfo)(object)@class.W((BindingFlags)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)@class.t(Class5.Default, (Type)(object)((Class7)null).t(bindingFlags, array, (object)null, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default)), array4, cultureInfo, (string[])null, out reference), null, null)).t(bindingFlags, null, null, cultureInfo), (PropertyInfo[])(object)Class5.Default, type_, null, array4));
			}
			catch
			{
				try
				{
					class31 = class31;
				}
				catch
				{
					Class7 obj23 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 class37 = @class;
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_23 = bindingFlags;
					ref object[] object_7 = ref reference2;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_3 = cultureInfo;
					Class7 class39 = @class;
					BindingFlags bindingFlags_24 = (BindingFlags)@class.j(bindingFlags, methodBase_, ref *(object[]*)@class.t(@class.t(obj, type_, cultureInfo), null, (CultureInfo)@class.t(((Class7)@class.t(null, null, null)).j(bindingFlags, methodBase_, ref reference2, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null, null)), array4, cultureInfo, string_, out reference);
					Class7 obj24 = (Class7)(object)@class.t(bindingFlags, array, obj, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_25 = bindingFlags;
					ref object[] object_8 = ref reference2;
					BindingFlags bindingFlags_26 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array2;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					class35 = (Class5)(object)obj23.j(bindingFlags_22, (MethodBase[])(object)class37.e((BindingFlags)class38.j(bindingFlags_23, methodBase_, ref object_7, parameterModifier_4, cultureInfo_3, null, out *(object*)class39.W(bindingFlags_24, (PropertyInfo[])(object)obj24.j(bindingFlags_25, methodBase_, ref object_8, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_26, propertyInfo_5, type_, (Type[])null, (ParameterModifier[])(object)((Class7)(object)class40.t(bindingFlags, array, obj, (CultureInfo)(object)Class5.Default)).j(bindingFlags, null, ref reference2, array4, cultureInfo, null, out *(object*)null)), cultureInfo, string_, out *(object*)null), null, null, array4)), methodBase_, (Type[])(object)Class5.Default, array4), ref reference2, array4, cultureInfo, null, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.t(obj, type_, null), cultureInfo));
				}
			}
		}
		while (obj != null);
		do
		{
			if (uIntPtr != 0)
			{
				class5 = class5;
				_ = (_003CModule_003E)(object)Class5.Default;
				class29 = (Class0)(object)Class5.Default;
				continue;
			}
			Class7 class41 = @class;
			Class7 class42 = @class;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_4 = (MethodBase[])(object)class42.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array4), type_, array3, array4);
			Type[] type_7 = array3;
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class41.e(default(BindingFlags), methodBase_4, type_7, (ParameterModifier[])(object)class43.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo), null)) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, methodBase_, ref reference2, array4, cultureInfo, null, out *(object*)null), array3, array4), null, null, (CultureInfo)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default));
			}
			else
			{
				struct2 = struct2;
			}
		}
		while ((object)Class5.Default != null);
		if (uIntPtr == 0)
		{
			_ = (Class0)(object)Class5.Default;
		}
		while (obj != null)
		{
			nuint num4 = uIntPtr / uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / uIntPtr == 0)
			{
				try
				{
					_ = (Qk7)((Class7)(object)Class5.Default).t(obj, (Type)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo), null);
					_ = (GClass3)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).W(bindingFlags, array2, type_, (Type[])null, array4);
					gClass = null;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
			_ = (Class0)(object)Class5.Default;
			_ = (Class2)(object)Class5.Default;
		}
		class29 = null;
		try
		{
			try
			{
				_ = (_003CModule_003E)@class.t(null, (Type)(object)Class5.Default, null);
			}
			finally
			{
				try
				{
					Class7 obj27 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array2;
					bindingFlags = default(BindingFlags);
					class35 = (Class5)(object)((Class7)null).W((BindingFlags)obj27.W(bindingFlags_27, propertyInfo_6, (Type)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo), null, array4), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array3, array4);
				}
				finally
				{
					@class = null;
					goto end_IL_46ba;
				}
			}
			end_IL_46ba:;
		}
		catch
		{
			try
			{
				UIntPtr num5 = (UIntPtr)Class5.Default;
				Class7 class44 = @class;
				Class7 class45 = @class;
				FieldInfo[] fieldInfo_3 = array;
				Class7 class46 = @class;
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)num5) - unchecked((nuint)(UIntPtr)class44.j((BindingFlags)class45.t(default(BindingFlags), fieldInfo_3, class46.e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), (MethodBase[])(object)((Class7)null).W(bindingFlags, array2, type_, array3, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array3, array4), null, null, null, out reference)) * unchecked((nuint)(UIntPtr)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)null, array3, array4)) == 0)
					{
						class5 = class5;
						class5 = (Class9)(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, array3, array4);
						_ = (Struct2)Class5.Default;
						_ = (GClass3)(object)@class.t(default(BindingFlags), null, null, (CultureInfo)(object)Class5.Default);
					}
					else
					{
						_ = (Struct2)Class5.Default;
					}
				}
			}
			finally
			{
				Type type_8 = (Type)(object)Class5.Default;
				Class7 class47 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_28 = bindingFlags;
				Class7 obj28 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), array3, (ParameterModifier[])null);
				Class7 class48 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).W((BindingFlags)((Class7)null).t((object)null, type_8, (CultureInfo)(object)((Class7)null).t((BindingFlags)class47.j(bindingFlags_28, methodBase_, ref *(object[]*)null, null, null, (string[])(object)obj28.t(default(BindingFlags), null, obj, (CultureInfo)(object)class48.t(bindingFlags, array, Class5.Default, cultureInfo)), out *(object*)null), (FieldInfo[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t(((Class7)null).t((object)@class.e(bindingFlags, methodBase_, array3, array4), type_, cultureInfo), (Type)((Class7)null).t(obj, (Type)null, (CultureInfo)null), (CultureInfo)null), null, (ParameterModifier[])(object)Class5.Default), (object)null, cultureInfo)), array2, (Type)null, array3, (ParameterModifier[])(object)@class.t(bindingFlags, array, obj, cultureInfo));
				class5 = class5;
				_ = (Struct1)Class5.Default;
				class17 = (Class8)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out *(object*)null));
				goto end_IL_4764;
			}
			end_IL_4764:;
		}
		_ = (GClass1)(object)Class5.Default;
		if ((UIntPtr)@class.t(obj, type_, null) == (UIntPtr)(nuint)0u)
		{
			gClass4 = null;
			@struct = default(Struct2);
		}
		else
		{
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class49.e(bindingFlags, null, (Type[])(object)@class.t((BindingFlags)Class5.Default, array, obj, null), (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
			do
			{
				qk = qk;
			}
			while (obj != null);
		}
		catch
		{
			qk = qk;
		}
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				try
				{
					gClass = null;
				}
				catch
				{
					_ = Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			catch
			{
				gClass3 = (GClass1)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array4);
			}
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				class17 = null;
			}
		}
		if ((UIntPtr)@class.e((BindingFlags)Class5.Default, methodBase_, array3, null) == (UIntPtr)(nuint)0u)
		{
			gClass3 = gClass3;
		}
		while (obj != null)
		{
			while (obj != null)
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
		}
		qk = null;
		class19 = class19;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Class7 class50 = @class;
			BindingFlags bindingFlags_29 = bindingFlags;
			MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
			ref object[] object_9 = ref *(object[]*)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array, obj, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default);
			ParameterModifier[] parameterModifier_5 = array4;
			Class7 obj34 = (Class7)@class.t(obj, type_, null);
			bindingFlags = default(BindingFlags);
			UIntPtr num6 = (UIntPtr)class50.j(bindingFlags_29, methodBase_5, ref object_9, parameterModifier_5, (CultureInfo)(object)obj34.t((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array3, (ParameterModifier[])null), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), string_, out reference);
			nuint num7 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((nuint)num6 / checked(num7 + uIntPtr * unchecked((nuint)(UIntPtr)((Class7)null).t(obj, (Type)(object)((Class7)null).e(bindingFlags, methodBase_, array3, array4), (CultureInfo)null))) == 0)
			{
				class35 = null;
			}
		}
		else
		{
			Class7 class51 = @class;
			Class7 class52 = @class;
			PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
			Class7 obj35 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj36 = (Class7)(object)obj35.t(bindingFlags, array, obj, null);
			BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
			ParameterModifier[] parameterModifier_6 = array4;
			CultureInfo cultureInfo_4 = (CultureInfo)(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo)).e((BindingFlags)Class5.Default, null, (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null);
			Class7 obj37 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_31 = bindingFlags;
			Type[] type_9 = (Type[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj38 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array2, type_, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)).t(null, type_, (CultureInfo)(object)Class5.Default)), cultureInfo, string_, out *(object*)((Class7)null).t(obj, type_, cultureInfo)), ref reference2, array4, cultureInfo, (string[])null, out reference);
			Class7 class53 = @class;
			BindingFlags bindingFlags_32 = bindingFlags;
			Class7 obj39 = (Class7)(object)@class.t(default(BindingFlags), array, null, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)class51.W((BindingFlags)class52.W(default(BindingFlags), propertyInfo_7, (Type)(object)obj36.j(bindingFlags_30, methodBase_, ref *(object[]*)null, parameterModifier_6, cultureInfo_4, null, out *(object*)obj37.t(null, (Type)(object)((Class7)(object)((Class7)null).e(bindingFlags_31, methodBase_, type_9, (ParameterModifier[])(object)obj38.e((BindingFlags)class53.j(bindingFlags_32, null, ref *(object[]*)obj39.j(bindingFlags, methodBase_, ref reference2, array4, (CultureInfo)(object)((Class7)null).W(bindingFlags, array2, (Type)null, array3, array4), string_, out reference), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null), methodBase_, array3, null))).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference), cultureInfo)), array3, (ParameterModifier[])(object)@class.t(bindingFlags, array, obj, cultureInfo)), array2, (Type)((Class7)null).t(obj, (Type)null, cultureInfo), (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, array, (object)null, (CultureInfo)(object)Class5.Default), array4);
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					struct2 = (Struct1)Class5.Default;
				}
			}
			finally
			{
				do
				{
					Class7 class54 = @class;
					object object_10 = ((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out reference);
					Class7 class55 = @class;
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)class54.t(object_10, (Type)class55.t(class56.e(bindingFlags, methodBase_, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type_, null, array4), (ParameterModifier[])(object)Class5.Default), type_, cultureInfo), (CultureInfo)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)Class5.Default), cultureInfo, null, out reference));
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)Class5.Default;
			class31 = null;
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			_ = (Class8)((Class7)(object)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, null, null)).t(@class.t(default(BindingFlags), array, obj, cultureInfo), type_, null);
		}
		else
		{
			qk = null;
		}
		do
		{
			try
			{
				while ((object)@class.t((BindingFlags)Class5.Default, array, null, null) != null)
				{
					class17 = class17;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		while (obj != null);
		while ((object)Class5.Default != null)
		{
			if (uIntPtr == 0 && (UIntPtr)@class.t(default(BindingFlags), array, obj, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		class6 = class6;
		return;
		IL_201e:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				struct2 = default(Struct1);
				struct2 = struct2;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)@class.t(obj, type_, cultureInfo));
				}
				goto end_IL_204f;
			}
			end_IL_204f:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class57 = @class;
					Class7 obj42 = (Class7)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_33 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array;
					Class7 class58 = @class;
					Class7 class59 = @class;
					Class7 class60 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = array2;
					bindingFlags = default(BindingFlags);
					object object_11 = class58.t((BindingFlags)class59.e((BindingFlags)class60.W(bindingFlags_34, propertyInfo_8, null, (Type[])(object)((Class7)null).W(bindingFlags, array2, type_, array3, (ParameterModifier[])null), array4), methodBase_, array3, array4), array, Class5.Default, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, array, (object)null, (CultureInfo)@class.t(@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, array4), null, (CultureInfo)@class.t(obj, type_, cultureInfo))));
					Class7 obj43 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_35 = bindingFlags;
					ref object[] object_12 = ref reference2;
					BindingFlags bindingFlags_36 = (BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)((Class7)null).t(bindingFlags, array, obj, cultureInfo), out *(object*)null);
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = (BindingFlags)((Class7)(object)obj42.t(bindingFlags_33, fieldInfo_4, object_11, (CultureInfo)(object)((Class7)((Class7)(object)obj43.j(bindingFlags_35, null, ref object_12, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_36, (MethodBase[])(object)class61.W(bindingFlags, array2, (Type)(object)Class5.Default, null, array4), array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default, string_, out *(object*)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4), ref reference2, array4, cultureInfo, null, out reference))).t(Class5.Default, type_, cultureInfo)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array4))).W(bindingFlags, array2, null, array3, null);
					ref object[] object_13 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_7 = array4;
					BindingFlags bindingFlags_38 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_39 = bindingFlags;
					Type[] type_10 = (Type[])(object)Class5.Default;
					Class7 obj44 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj45 = (Class7)(object)obj44.W(bindingFlags, array2, type_, null, null);
					Class7 class62 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					FieldInfo[] fieldInfo_5 = array;
					Class7 obj46 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class57.j(bindingFlags_37, methodBase_, ref object_13, parameterModifier_7, (CultureInfo)(object)((Class7)null).e(bindingFlags_38, (MethodBase[])(object)((Class7)null).e(bindingFlags_39, methodBase_, type_10, (ParameterModifier[])(object)obj45.W((BindingFlags)class62.t(bindingFlags_40, fieldInfo_5, obj46.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), cultureInfo), null, null, array3, null)), array3, (ParameterModifier[])null), null, out reference);
					class6 = null;
					class29 = class29;
					_ = (GClass2)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default)).t(Class5.Default, null, (CultureInfo)(object)Class5.Default);
				}
				finally
				{
					_ = (Class9)(object)@class.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
					goto end_IL_20b9;
				}
				end_IL_20b9:;
			}
			catch
			{
				_ = (Class5)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)((Class7)@class.t(((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo), null, cultureInfo)).t(@class.W(bindingFlags, null, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), type_, cultureInfo)).t(bindingFlags, array, obj, null), array4);
			}
		}
		do
		{
			try
			{
				while (obj != null)
				{
					class31 = class31;
					@class = (Class7)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (GClass2)(object)@class.j(bindingFlags, null, ref reference2, null, cultureInfo, string_, out reference);
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class7)(object)Class5.Default;
					class35 = null;
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class63.t(bindingFlags, null, null, cultureInfo);
					class29 = class29;
				}
			}
			finally
			{
				do
				{
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj != null);
				goto end_IL_2575;
			}
			end_IL_2575:;
		}
		finally
		{
			class5 = class5;
			goto IL_261c;
		}
		IL_2aa2:
		_ = (Struct2)Class5.Default;
		while (obj != null)
		{
			_ = (Qk7)(object)Class5.Default;
			class29 = class29;
			class7 = class7;
			_ = (Qk7)(object)Class5.Default;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				nuint num8 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				nuint num9 = num8 * uIntPtr - uIntPtr;
				uIntPtr = default(UIntPtr);
				if (unchecked(num9 / checked(unchecked((nuint)default(UIntPtr)) + uIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
				{
					try
					{
						_ = (GClass3)(object)unchecked(@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference));
					}
					catch
					{
						_ = (Class8)(object)Class5.Default;
					}
				}
			}
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class7)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array, obj, cultureInfo), array4, cultureInfo, string_, out *(object*)((Class7)null).t(bindingFlags, array, obj, cultureInfo));
				Class7 obj50 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj50.j(bindingFlags, methodBase_, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out reference);
				_ = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo);
			}
		}
		try
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					nuint num10 = uIntPtr;
					nuint num11 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num10 + num11 * uIntPtr * (uIntPtr * unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, array, obj, cultureInfo))) == 0)
					{
						@class = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])null);
					}
				}
				finally
				{
					do
					{
						_ = (Class2)(object)Class5.Default;
					}
					while (obj != null);
					goto end_IL_2c80;
				}
			}
			end_IL_2c80:;
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass3 = gClass3;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					BindingFlags bindingFlags_41 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).t(bindingFlags_41, (FieldInfo[])null, (object)null, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array4, (CultureInfo)null, (string[])null, out *(object*)Class5.Default));
				}
				goto end_IL_2cf8;
			}
			end_IL_2cf8:;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					qk = qk;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Class8)@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default));
					class7 = class7;
				}
				goto end_IL_2d70;
			}
			end_IL_2d70:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			goto IL_2e1d;
		}
		IL_0d68:
		_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, array2, type_, (Type[])(object)Class5.Default, (ParameterModifier[])null);
		do
		{
			Class7 class64 = @class;
			BindingFlags bindingFlags_42 = bindingFlags;
			Class7 class65 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)class64.t(bindingFlags_42, (FieldInfo[])(object)class65.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])null, array4), type_, array3, array4)), obj, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo));
		}
		while (obj != null);
		UIntPtr num12 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if ((nuint)num12 / checked(uIntPtr - uIntPtr) == 0)
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
			}
			finally
			{
				try
				{
					_ = (Struct1)Class5.Default;
					_ = (Class7)@class.t(((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, null);
				}
				catch
				{
					class7 = null;
					gClass = gClass;
				}
				goto IL_0ea4;
			}
		}
		goto IL_0ea4;
		IL_327b:
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					gClass = null;
					class31 = null;
					gClass4 = gClass4;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			_ = (Class7)(object)Class5.Default;
		}
		qk = null;
		do
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
				}
			}
			finally
			{
				class19 = class19;
				continue;
			}
		}
		while (obj != null);
		while (obj != null)
		{
			Class7 obj56 = (Class7)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array4);
			Class7 class66 = @class;
			bindingFlags = default(BindingFlags);
			UIntPtr num13 = (UIntPtr)obj56.e(default(BindingFlags), (MethodBase[])(object)class66.j(bindingFlags, (MethodBase[])((Class7)(object)((Class7)(object)@class.t((BindingFlags)@class.t(Class5.Default, type_, null), array, obj, null)).e(bindingFlags, methodBase_, array3, null)).t(obj, null, (CultureInfo)(object)Class5.Default), ref reference2, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null, array4);
			UIntPtr num14 = (UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array4), ref reference2, array4, null, string_, out reference);
			nuint num15 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((nuint)num13 / ((nuint)num14 / (num15 / uIntPtr)) == 0)
			{
				if (uIntPtr == 0)
				{
					bindingFlags = default(BindingFlags);
					class5 = (Class9)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null);
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		try
		{
			_ = (Class0)(object)Class5.Default;
			class19 = class19;
			class31 = null;
		}
		finally
		{
			gClass2 = null;
			Class7 obj57 = (Class7)(object)@class.W(bindingFlags, null, type_, array3, array4);
			BindingFlags bindingFlags_43 = bindingFlags;
			Class7 class67 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj57.e(bindingFlags_43, (MethodBase[])(object)class67.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default), array3, array4);
			goto IL_3524;
		}
		IL_3524:
		try
		{
			_ = (GClass3)(object)Class5.Default;
			gClass4 = gClass4;
			_ = (Class7)(object)@class.t((BindingFlags)Class5.Default, array, null, null);
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class6 = null;
			}
			goto IL_3589;
		}
		IL_0ea4:
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out reference)).t(obj, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, null, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), type_, array3, array4) == 0)
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class68.e(bindingFlags, methodBase_, array3, array4);
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		try
		{
			gClass = (GClass0)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
		}
		catch
		{
			try
			{
				class31 = class31;
			}
			catch
			{
				class5 = null;
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (true)
				{
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)(object)class69.t(bindingFlags, null, obj, null)).t((BindingFlags)Class5.Default, null, null, cultureInfo) != null)
					{
						class31 = (Class6)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			else
			{
				try
				{
					_ = Class5.Default;
				}
				catch
				{
					_ = (GClass2)((Class7)null).t(obj, type_, (CultureInfo)null);
					_ = Class5.Default;
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_44 = bindingFlags;
					Class7 obj60 = (Class7)(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_45 = (BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).e(default(BindingFlags), methodBase_, array3, (ParameterModifier[])(object)Class5.Default), methodBase_, array3, array4);
					ref object[] object_14 = ref reference2;
					ParameterModifier[] parameterModifier_8 = array4;
					CultureInfo cultureInfo_5 = cultureInfo;
					Class7 obj61 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_46 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					ref object[] object_15 = ref reference2;
					Class7 obj62 = (Class7)(object)((Class7)(object)@class.W(bindingFlags, array2, (Type)(object)@class.t((BindingFlags)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), null, obj, cultureInfo), array3, array4)).e(default(BindingFlags), methodBase_, array3, array4);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class70.j(bindingFlags_44, methodBase_, ref *(object[]*)obj60.j(bindingFlags_45, methodBase_, ref object_14, parameterModifier_8, cultureInfo_5, string_, out *(object*)obj61.j(bindingFlags_46, methodBase_6, ref object_15, (ParameterModifier[])(object)obj62.W(bindingFlags, array2, null, array3, array4), (CultureInfo)(object)Class5.Default, string_, out *(object*)null)), null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				}
			}
			goto IL_1208;
		}
		IL_261c:
		while ((object)Class5.Default != null)
		{
			if ((UIntPtr)@class.t(bindingFlags, array, null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
			}
		}
		try
		{
			class6 = null;
			_ = (Class0)(object)Class5.Default;
			_ = (Class5)(object)@class.t(bindingFlags, array, ((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array3, array4), cultureInfo);
		}
		catch
		{
			@class = (Class7)(object)@class.e(bindingFlags, null, array3, null);
		}
		@class = @class;
		_ = (Qk7)(object)Class5.Default;
		_ = (Class6)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)@class.W((BindingFlags)Class5.Default, array2, type_, null, array4), (CultureInfo)(object)Class5.Default);
		_ = (Class4)(object)@class.t((BindingFlags)@class.t(bindingFlags, array, null, null), array, obj, cultureInfo);
		Class7 obj65 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_47 = bindingFlags;
		FieldInfo[] fieldInfo_6 = array;
		Class7 class71 = @class;
		bindingFlags = default(BindingFlags);
		qk = (Qk7)(object)((Class7)null).e((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)obj65.t(bindingFlags_47, fieldInfo_6, class71.e(bindingFlags, methodBase_, null, array4), null)), methodBase_, array3, (ParameterModifier[])(object)Class5.Default);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass4 = gClass4;
			}
		}
		finally
		{
			class29 = class29;
			goto IL_27ce;
		}
		IL_1b4d:
		class19 = (Class10)(object)Class5.Default;
		_ = (Class5)(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(obj, type_, null), type_, array3, array4);
		if (uIntPtr == 0)
		{
			class19 = class19;
			goto IL_1cc3;
		}
		try
		{
			Class7 class72 = @class;
			BindingFlags bindingFlags_48 = (BindingFlags)Class5.Default;
			Class7 obj66 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_49 = bindingFlags;
			Class7 obj67 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])null, out *(object*)null);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class72.t(bindingFlags_48, (FieldInfo[])(object)obj66.e((BindingFlags)((Class7)(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags_49, (PropertyInfo[])(object)obj67.W(bindingFlags, array2, (Type)(object)Class5.Default, array3, array4), (Type)null, array3, array4), (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])null)).t(bindingFlags, array, null, cultureInfo), methodBase_, (Type[])@class.t(obj, type_, (CultureInfo)(object)Class5.Default), null), obj, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				class31 = class31;
			}
		}
		finally
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			goto IL_1cc3;
		}
		IL_27ce:
		try
		{
			try
			{
				_ = (Class4)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null);
				_ = (Class6)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
				_ = (GClass3)@class.t(obj, type_, null);
			}
			catch
			{
				if ((UIntPtr)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])((Class7)(object)Class5.Default).t(obj, null, cultureInfo), (Type)(object)Class5.Default, null, array4) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class8)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array4, cultureInfo, string_, out *(object*)Class5.Default);
				}
				while (obj != null);
			}
			catch
			{
				if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					Class7 obj70 = (Class7)@class.t(@class.j(bindingFlags, methodBase_, ref reference2, null, cultureInfo, string_, out reference), type_, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference2, array4, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array, obj, (CultureInfo)(object)Class5.Default), string_, out reference));
					bindingFlags = default(BindingFlags);
					Class7 obj71 = (Class7)(object)obj70.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
					BindingFlags bindingFlags_50 = bindingFlags;
					Type[] type_11 = (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, cultureInfo), obj, null);
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj71.e(bindingFlags_50, null, type_11, (ParameterModifier[])(object)class73.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null));
				}
			}
		}
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (GClass3)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, string_, out reference);
			}
		}
		catch
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
				gClass4 = gClass4;
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				qk = qk;
				goto end_IL_2a66;
			}
			end_IL_2a66:;
		}
		finally
		{
			_ = (Class9)(object)Class5.Default;
			goto IL_2aa2;
		}
		IL_392b:
		checked
		{
			if (uIntPtr != 0 || unchecked((nuint)(UIntPtr)((Class7)null).t(obj, type_, cultureInfo)) * unchecked(uIntPtr / (nuint)(UIntPtr)@class.e(default(BindingFlags), methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)) != 0)
			{
			}
			bindingFlags = default(BindingFlags);
			Class7 obj75 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array4);
			BindingFlags bindingFlags_51 = bindingFlags;
			Class7 obj76 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_52 = bindingFlags;
			FieldInfo[] fieldInfo_7 = (FieldInfo[])((Class7)(object)@class.t(default(BindingFlags), array, obj, cultureInfo)).t(obj, null, cultureInfo);
			Class7 obj77 = (Class7)(object)Class5.Default;
			FieldInfo[] fieldInfo_8 = array;
			Class7 class74 = @class;
			bindingFlags = default(BindingFlags);
			@class = (Class7)(object)obj75.W(bindingFlags_51, (PropertyInfo[])(object)obj76.t(bindingFlags_52, fieldInfo_7, obj77.t(default(BindingFlags), fieldInfo_8, null, (CultureInfo)(object)class74.t(bindingFlags, (FieldInfo[])(object)((Class7)((Class7)null).t(obj, type_, (CultureInfo)null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4), obj, (CultureInfo)((Class7)null).t((object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)@class.t(unchecked((BindingFlags)Class5.Default), null, Class5.Default, cultureInfo)), (Type)null, cultureInfo))), (CultureInfo)(object)Class5.Default), type_, array3, null);
			Class7 class75 = @class;
			BindingFlags bindingFlags_53 = bindingFlags;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			ref object[] object_16 = ref reference2;
			Class7 class76 = @class;
			bindingFlags = default(BindingFlags);
			if (unchecked((nuint)(UIntPtr)class75.j(bindingFlags_53, methodBase_7, ref object_16, null, (CultureInfo)(object)class76.t(bindingFlags, array, obj, cultureInfo), string_, out reference)) * unchecked((nuint)(UIntPtr)@class.W((BindingFlags)@class.e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, array2, type_, array3, null), obj, (CultureInfo)null), methodBase_, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out *(object*)Class5.Default), null), array2, type_, array3, (ParameterModifier[])(object)Class5.Default) / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					try
					{
						class6 = class6;
						struct2 = struct2;
						_ = (Class4)@class.t(Class5.Default, type_, cultureInfo);
						bindingFlags = default(BindingFlags);
						_ = (Struct2)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo);
					}
					catch
					{
						gClass = gClass;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (GClass0)@class.t(null, null, (CultureInfo)(object)Class5.Default);
					}
				}
			}
			class7 = class7;
		}
		try
		{
			try
			{
				class5 = class5;
			}
			catch
			{
				gClass2 = gClass2;
			}
		}
		catch
		{
			try
			{
				class6 = class6;
			}
			catch
			{
				@struct = (Struct2)@class.W(bindingFlags, array2, null, array3, array4);
			}
			finally
			{
				Class7 obj82 = (Class7)(object)((Class7)(object)@class.W(bindingFlags, array2, (Type)(object)@class.W(bindingFlags, null, type_, null, array4), array3, array4)).e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)@class.e((BindingFlags)@class.e(bindingFlags, null, (Type[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), null), null, array3, (ParameterModifier[])(object)Class5.Default));
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)obj82.W(bindingFlags, null, type_, null, null)).e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
					qk = qk;
					gClass4 = (GClass2)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, null, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), out reference);
					_ = (Struct2)@class.e((BindingFlags)@class.W(bindingFlags, array2, type_, null, null), methodBase_, (Type[])(object)Class5.Default, array4);
				}
				else
				{
					class29 = null;
				}
				goto end_IL_3ca2;
			}
			end_IL_3ca2:;
		}
		class31 = class31;
		_ = (Qk7)(object)@class.e(bindingFlags, methodBase_, array3, array4);
		while (obj != null)
		{
		}
		do
		{
			class31 = class31;
		}
		while (obj != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)@class.t(obj, (Type)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)@class.W(bindingFlags, array2, (Type)(object)Class5.Default, array3, array4), null, string_, out *(object*)null), null)) - unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4)) - uIntPtr == 0)
			{
				nuint num16 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num17 = unchecked((nuint)default(UIntPtr)) + uIntPtr;
				nuint num18 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num16 * (num17 * (num18 * uIntPtr - unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array2, null, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, null, array3, null))))) + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, null)) == 0)
				{
					_003CModule_003E = _003CModule_003E;
					class19 = class19;
				}
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
			}
			_ = (GClass0)(object)Class5.Default;
		}
		if (uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class29 = class29;
				}
			}
			finally
			{
				try
				{
					class19 = class19;
					class5 = (Class9)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, null, cultureInfo);
					class7 = class7;
				}
				catch
				{
					_ = (Class9)(object)@class.e((BindingFlags)Class5.Default, null, array3, null);
					class35 = class35;
					_ = (Struct1)Class5.Default;
				}
				goto IL_415a;
			}
		}
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 obj85 = (Class7)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)@class.t(bindingFlags, null, obj, null), cultureInfo)).e(default(BindingFlags), methodBase_, null, array4)).t(((Class7)(object)Class5.Default).t(obj, null, cultureInfo), type_, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)obj85.j(bindingFlags, methodBase_, ref reference2, array4, null, (string[])((Class7)(object)Class5.Default).t(obj, null, cultureInfo), out *(object*)null);
			}
		}
		goto IL_415a;
		IL_2e1d:
		while (obj != null)
		{
			_ = (Class4)(object)@class.e(bindingFlags, null, array3, null);
		}
		try
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@class = null;
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					class6 = class6;
				}
			}
		}
		catch
		{
			BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_55 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_9 = array;
			Class7 class77 = @class;
			BindingFlags bindingFlags_56 = bindingFlags;
			Class7 class78 = @class;
			BindingFlags bindingFlags_57 = (BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type_, null, null);
			MethodBase[] methodBase_8 = (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4);
			ParameterModifier[] parameterModifier_9 = array4;
			CultureInfo cultureInfo_6 = cultureInfo;
			Class7 class79 = @class;
			BindingFlags bindingFlags_58 = bindingFlags;
			Class7 class80 = @class;
			BindingFlags bindingFlags_59 = bindingFlags;
			MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
			ref object[] object_17 = ref reference2;
			Class7 class81 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)((Class7)null).e(bindingFlags_54, (MethodBase[])(object)((Class7)null).t(bindingFlags_55, fieldInfo_9, obj, (CultureInfo)(object)class77.e(bindingFlags_56, (MethodBase[])(object)class78.j(bindingFlags_57, methodBase_8, ref *(object[]*)null, parameterModifier_9, cultureInfo_6, (string[])(object)class79.j(bindingFlags_58, methodBase_, ref *(object[]*)class80.j(bindingFlags_59, methodBase_9, ref object_17, null, null, (string[])((Class7)(object)class81.j(bindingFlags, methodBase_, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out reference)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)), out reference), null, null, null, out reference), out reference), (Type[])(object)Class5.Default, null)), (Type[])null, (ParameterModifier[])(object)Class5.Default);
		}
		Class7 class82 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class82.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array4, null, string_, out *(object*)((Class7)null).W(bindingFlags, array2, type_, (Type[])(object)Class5.Default, array4)) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					@class = null;
				}
				finally
				{
					class35 = class35;
					continue;
				}
			}
		}
		else
		{
			try
			{
				do
				{
					class19 = (Class10)@class.t(null, null, (CultureInfo)(object)Class5.Default);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				gClass = gClass;
			}
		}
		nuint num19 = uIntPtr;
		nuint num20 = uIntPtr;
		BindingFlags bindingFlags_60 = bindingFlags;
		ref object[] object_18 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_10 = array4;
		CultureInfo cultureInfo_7 = (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, null, null), ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, null));
		Class7 class83 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_61 = (BindingFlags)((Class7)null).j(bindingFlags_60, methodBase_, ref object_18, parameterModifier_10, cultureInfo_7, string_, out *(object*)((Class7)null).t((BindingFlags)((Class7)(object)class83.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference2, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)Class5.Default), type_, array3, null)).e(bindingFlags, methodBase_, array3, (ParameterModifier[])(object)((Class7)((Class7)null).t(obj, type_, cultureInfo)).W(bindingFlags, array2, null, null, array4)), array, obj, (CultureInfo)null));
		bindingFlags = default(BindingFlags);
		nuint num21;
		checked
		{
			num21 = num19 - (num20 - unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags_61, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array, obj, cultureInfo), (object)Class5.Default, cultureInfo)));
			uIntPtr = default(UIntPtr);
		}
		if (num21 / uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class29 = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			finally
			{
				do
				{
					gClass3 = (GClass1)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
				while (obj != null);
				goto IL_327b;
			}
		}
		goto IL_327b;
		IL_073e:
		uIntPtr = default(UIntPtr);
		if (uIntPtr / uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (GClass0)((Class7)null).t((object)null, type_, cultureInfo);
				_ = (Struct1)Class5.Default;
				@class = @class;
			}
			goto IL_08a6;
		}
		checked
		{
			try
			{
				class35 = class35;
				class35 = null;
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) - (unchecked((nuint)(UIntPtr)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference2, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference)) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					gClass3 = gClass3;
					gClass3 = null;
					class19 = (Class10)(object)Class5.Default;
				}
				goto IL_08a6;
			}
		}
		IL_1208:
		struct2 = default(Struct1);
		gClass3 = (GClass1)(object)Class5.Default;
		_ = (Class2)(object)((Class7)null).e(bindingFlags, methodBase_, array3, array4);
		uIntPtr = default(UIntPtr);
		Class7 class84;
		checked
		{
			if (uIntPtr + uIntPtr == 0)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).W(bindingFlags, array2, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
			else if (unchecked((nuint)(UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, array, obj, cultureInfo)) - unchecked((nuint)default(UIntPtr)) == 0)
			{
				class31 = null;
				_003CModule_003E = (_003CModule_003E)((Class7)null).t(obj, type_, cultureInfo);
				_ = (GClass0)(object)Class5.Default;
				_ = (Class10)(object)Class5.Default;
			}
			do
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type_, null, array4);
				}
			}
			while ((object)Class5.Default != null);
			class84 = @class;
		}
		BindingFlags bindingFlags_62 = (BindingFlags)Class5.Default;
		ref object[] object_19 = ref reference2;
		ParameterModifier[] parameterModifier_11 = array4;
		CultureInfo cultureInfo_8 = cultureInfo;
		Class7 class85 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)class84.j(bindingFlags_62, methodBase_, ref object_19, parameterModifier_11, cultureInfo_8, (string[])(object)class85.t(bindingFlags, array, obj, cultureInfo), out reference);
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Class10)@class.t(Class5.Default, type_, (CultureInfo)(object)Class5.Default);
					gClass4 = (GClass2)(object)Class5.Default;
					gClass2 = gClass2;
				}
				finally
				{
					Class7 class86 = @class;
					BindingFlags bindingFlags_63 = (BindingFlags)Class5.Default;
					ref object[] object_20 = ref *(object[]*)((Class7)(object)@class.W(bindingFlags, null, type_, array3, null)).j(bindingFlags, methodBase_, ref *(object[]*)@class.j(bindingFlags, methodBase_, ref *(object[]*)@class.t(Class5.Default, type_, null), (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, array2, type_, array3, (ParameterModifier[])null), cultureInfo, null, out reference), (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_64 = bindingFlags;
					FieldInfo[] fieldInfo_10 = array;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class86.j(bindingFlags_63, methodBase_, ref object_20, (ParameterModifier[])(object)class87.t(bindingFlags_64, fieldInfo_10, obj, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref reference2, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null)), (CultureInfo)(object)Class5.Default, string_, out *(object*)Class5.Default);
					continue;
				}
			}
		}
		catch
		{
			if ((UIntPtr)@class.j(bindingFlags, null, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out reference) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo);
				gClass = (GClass0)(object)Class5.Default;
				class6 = null;
				gClass3 = null;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class5)(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array2, null, (Type[])@class.t(obj, type_, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out reference);
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					BindingFlags bindingFlags_65 = bindingFlags;
					ref object[] object_21 = ref *(object[]*)@class.e((BindingFlags)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default);
					Class7 class88 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).j(bindingFlags_65, methodBase_, ref object_21, (ParameterModifier[])(object)class88.W(bindingFlags, array2, null, array3, array4), (CultureInfo)(object)Class5.Default, string_, out reference);
				}
			}
		}
		while (obj != null)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		while (obj != null)
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			catch
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		_ = (Struct2)Class5.Default;
		_ = (Struct1)Class5.Default;
		checked
		{
			nuint num22 = unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4)) - unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (num22 - uIntPtr == 0)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				finally
				{
					do
					{
						gClass2 = null;
					}
					while ((object)Class5.Default != null);
					goto IL_177e;
				}
			}
			gClass2 = gClass2;
			goto IL_177e;
		}
		IL_1cc3:
		class6 = null;
		try
		{
			do
			{
				class29 = (Class0)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, null, cultureInfo);
			}
			while (obj != null);
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				object object_22 = ((Class7)null).t((object)null, type_, cultureInfo);
				Class7 class89 = @class;
				Class7 class90 = @class;
				Class7 class91 = @class;
				BindingFlags bindingFlags_66 = bindingFlags;
				FieldInfo[] fieldInfo_11 = (FieldInfo[])(object)Class5.Default;
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(object_22, type_, (CultureInfo)(object)class89.W((BindingFlags)class90.t((BindingFlags)class91.t(bindingFlags_66, fieldInfo_11, class92.j(bindingFlags, methodBase_, ref *(object[]*)null, array4, cultureInfo, string_, out *(object*)null), (CultureInfo)(object)((Class7)((Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo)).t(obj, type_, cultureInfo)).j(bindingFlags, methodBase_, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference)), null, obj, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref reference2, array4, cultureInfo, (string[])null, out reference)), array2, (Type)(object)Class5.Default, array3, array4)) == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		checked
		{
			do
			{
				nuint num23 = uIntPtr;
				Class7 class93 = @class;
				BindingFlags bindingFlags_67 = bindingFlags;
				bindingFlags = default(BindingFlags);
				if (num23 * (unchecked((nuint)(UIntPtr)class93.e(bindingFlags_67, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4), null, array4)) + unchecked((nuint)(UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default))) * uIntPtr == 0)
				{
					@struct = @struct;
				}
			}
			while (obj != null || obj != null);
			gClass2 = gClass2;
			while (obj != null)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					_ = (Struct1)((Class7)(object)@class.t(bindingFlags, array, null, cultureInfo)).t(obj, type_, cultureInfo);
					struct2 = default(Struct1);
					struct2 = struct2;
				}
				finally
				{
					class31 = class31;
					continue;
				}
			}
			if (uIntPtr == 0)
			{
				try
				{
					try
					{
						_ = (Struct2)Class5.Default;
					}
					finally
					{
						class19 = class19;
						class5 = null;
						_ = (Class6)(object)@class.t(bindingFlags, array, obj, null);
						goto end_IL_1f66;
					}
					end_IL_1f66:;
				}
				finally
				{
					_ = (Qk7)(object)@class.t(bindingFlags, null, obj, cultureInfo);
					goto IL_201e;
				}
			}
		}
		if ((UIntPtr)((Class7)null).t(((Class7)(object)Class5.Default).t(obj, type_, cultureInfo), (Type)@class.t(null, type_, null), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				goto IL_201e;
			}
		}
		goto IL_201e;
		IL_3589:
		while (obj != null)
		{
			do
			{
				_ = (Qk7)(object)Class5.Default;
			}
			while (obj != null || obj != null);
		}
		try
		{
			gClass2 = null;
		}
		finally
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (checked(unchecked(checked(unchecked((nuint)default(UIntPtr)) - uIntPtr - unchecked((nuint)(UIntPtr)((Class7)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out *(object*)null)).t(null, (Type)(object)Class5.Default, null))) / (nuint)(UIntPtr)Class5.Default) * uIntPtr * unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr)) != 0)
				{
					class31 = null;
					continue;
				}
				gClass2 = gClass2;
				_ = (Class2)(object)Class5.Default;
				gClass4 = (GClass2)(object)((Class7)null).t((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out reference), (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array4, cultureInfo, string_, out *(object*)Class5.Default), obj, cultureInfo);
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class94.t((BindingFlags)((Class7)null).W(bindingFlags, array2, type_, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), array, null, cultureInfo);
			}
			while (obj != null);
			goto IL_3753;
		}
	}

	unsafe static void smethod_7()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			gClass = gClass;
			gClass = null;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					@class = null;
					Class7 class2 = @class;
					bindingFlags = bindingFlags;
					BindingFlags bindingFlags_ = bindingFlags;
					array = array;
					FieldInfo[] fieldInfo_ = array;
					Class7 class3 = @class;
					BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
					array2 = array2;
					Type[] type_ = array2;
					Class7 obj = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					obj2 = null;
					object object_ = obj2;
					cultureInfo = null;
					_ = (Class10)(object)class2.t(bindingFlags_, fieldInfo_, class3.e(bindingFlags_2, null, type_, (ParameterModifier[])(object)obj.t(bindingFlags_3, null, object_, cultureInfo)), cultureInfo);
					goto end_IL_000a;
				}
				end_IL_000a:;
			}
			catch
			{
				num = num;
				num = default(UIntPtr);
				if (num == 0)
				{
					object object_2 = obj2;
					type = type;
					_ = (Class4)((Class7)null).t(object_2, type, cultureInfo);
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class6);
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class4 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_4 = bindingFlags;
					array3 = (PropertyInfo[])(object)Class5.Default;
					_ = (Class2)(object)class4.W(bindingFlags_4, array3, type, null, (ParameterModifier[])@class.t(obj2, type, null));
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
					Class7 class5 = @class;
					BindingFlags bindingFlags_5 = bindingFlags;
					Type[] type_2 = array2;
					Class7 obj5 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class6 obj6 = (Class6)(object)class5.e(bindingFlags_5, null, type_2, (ParameterModifier[])(object)obj5.t(bindingFlags, array, obj2, cultureInfo));
					class6 = class6;
					class6 = obj6;
					_ = (Class6)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		while (obj2 != null)
		{
			do
			{
				BindingFlags bindingFlags_6 = bindingFlags;
				reference = ref reference;
				gClass2 = (GClass1)(object)((Class7)(object)((Class7)null).j(bindingFlags_6, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)).t(bindingFlags, null, null, cultureInfo);
				gClass2 = null;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			while (obj2 != null || (object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class7);
		try
		{
			if (num == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			checked
			{
				try
				{
					if (num == 0)
					{
						_ = (GClass2)(object)Class5.Default;
					}
				}
				catch
				{
					nuint num2 = num;
					num = default(UIntPtr);
					if (num2 * (unchecked(num / num) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
					{
						class7 = null;
						class7 = null;
					}
				}
			}
		}
		@class = (Class7)(object)Class5.Default;
		Class7 class8 = @class;
		Class7 class9 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_7 = bindingFlags;
		MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
		Type[] type_3 = array2;
		ParameterModifier[] array4 = array4;
		_ = (Class5)class8.t(class9.e(bindingFlags_7, methodBase_, type_3, array4), type, cultureInfo);
		GClass0 gClass3 = gClass3;
		gClass3 = gClass3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			try
			{
				Class7 class10 = @class;
				BindingFlags bindingFlags_8 = bindingFlags;
				array5 = array5;
				if ((UIntPtr)class10.j(bindingFlags_8, array5, ref *(object[]*)null, array4, null, null, out *(object*)null) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					gClass2 = gClass2;
				}
			}
			finally
			{
				gClass4 = (GClass2)(object)@class.e((BindingFlags)Class5.Default, null, null, array4);
				gClass4 = gClass4;
				goto end_IL_0252;
			}
			end_IL_0252:;
		}
		finally
		{
			try
			{
				try
				{
					@struct = @struct;
					@struct = @struct;
				}
				finally
				{
					class11 = (Class0)(object)Class5.Default;
					class11 = class11;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_9 = bindingFlags;
					PropertyInfo[] propertyInfo_ = array3;
					Class7 class12 = @class;
					BindingFlags bindingFlags_10 = bindingFlags;
					MethodBase[] methodBase_2 = array5;
					Class7 obj10 = (Class7)(object)Class5.Default;
					Class7 obj11 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_11 = bindingFlags;
					MethodBase[] methodBase_3 = array5;
					ref object[] object_3 = ref reference;
					CultureInfo cultureInfo_ = cultureInfo;
					array6 = array6;
					string[] string_ = array6;
					object_4 = ref *(object*)Class5.Default;
					_ = (Class6)(object)((Class7)null).W(bindingFlags_9, propertyInfo_, (Type)(object)((Class7)(object)class12.j(bindingFlags_10, methodBase_2, ref *(object[]*)obj10.t(obj11.j(bindingFlags_11, methodBase_3, ref object_3, null, cultureInfo_, string_, out object_4), type, cultureInfo), null, cultureInfo, array6, out object_4)).e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, array4), (Type[])null, (ParameterModifier[])null);
					goto end_IL_02a7;
				}
				end_IL_02a7:;
			}
			catch
			{
				while (obj2 != null)
				{
					gClass4 = gClass4;
				}
			}
			goto IL_0370;
		}
		IL_19e0:
		try
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
					_ = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)@class.j(bindingFlags, array5, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, array6, out object_4));
					Class7 class13 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_12 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = array3;
					Type type_4 = type;
					Class7 class14 = @class;
					BindingFlags bindingFlags_13 = (BindingFlags)((Class7)null).t(obj2, (Type)null, (CultureInfo)null);
					BindingFlags bindingFlags_14 = bindingFlags;
					ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
					Class7 class15 = @class;
					object object_5 = obj2;
					bindingFlags = default(BindingFlags);
					Type type_5 = (Type)((Class7)(object)((Class7)null).W(bindingFlags_12, propertyInfo_2, type_4, (Type[])null, (ParameterModifier[])(object)class14.e(bindingFlags_13, (MethodBase[])(object)((Class7)null).j(bindingFlags_14, (MethodBase[])null, ref *(object[]*)null, parameterModifier_, (CultureInfo)class15.t(object_5, (Type)(object)((Class7)null).j(bindingFlags, array5, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)Class5.Default), cultureInfo), array6, out object_4), null, array4))).t(obj2, type, (CultureInfo)@class.t(obj2, type, (CultureInfo)(object)Class5.Default));
					bindingFlags = default(BindingFlags);
					_ = (GClass1)class13.t(null, type_5, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo));
					_ = (GClass0)(object)@class.W(bindingFlags, null, type, null, null);
				}
				catch
				{
					@class = (Class7)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, (ParameterModifier[])@class.t(obj2, type, null), null, null, out object_4));
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = (_003CModule_003E)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, array4, (CultureInfo)null, array6, out *(object*)null);
			}
			else
			{
				try
				{
					_ = (GClass1)(object)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo), array3, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, array5, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)Class5.Default, null, out object_4), (Type[])(object)Class5.Default, array4);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
			goto IL_1c36;
		}
		IL_30c9:
		Qk7 qk = qk;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class17);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class16);
		checked
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref reference, null, null, (string[])(object)Class5.Default, out object_4)) == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					while (obj2 != null)
					{
						class16 = class16;
						class17 = class17;
					}
				}
			}
		}
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (Class5)(object)((Class7)null).W(bindingFlags, array3, (Type)null, array2, array4);
				}
				else
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array4, (CultureInfo)null, (string[])null, out *(object*)Class5.Default);
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				try
				{
					Class7 class18 = @class;
					object object_6 = obj2;
					Class7 class19 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = bindingFlags;
					MethodBase[] methodBase_4 = array5;
					ParameterModifier[] parameterModifier_2 = array4;
					CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
					Class7 obj15 = (Class7)(object)((Class7)(object)@class.e(bindingFlags, null, null, array4)).e((BindingFlags)((Class7)null).e(bindingFlags, array5, array2, array4), (MethodBase[])(object)@class.e(bindingFlags, null, array2, array4), array2, null);
					bindingFlags = default(BindingFlags);
					_ = (GClass3)((Class7)class18.t(object_6, (Type)(object)class19.j(bindingFlags_15, methodBase_4, ref *(object[]*)null, parameterModifier_2, cultureInfo_2, (string[])(object)obj15.e(bindingFlags, array5, (Type[])(object)Class5.Default, null), out object_4), cultureInfo)).t(null, type, null);
				}
				catch
				{
					class17 = class17;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class10)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)@class.j(bindingFlags, array5, ref *(object[]*)null, array4, cultureInfo, array6, out object_4), null, ((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, array4), (CultureInfo)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, cultureInfo)), type, array2, array4);
				}
				catch
				{
					_ = (Class9)(object)Class5.Default;
					_ = (Class7)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					Class7 obj18 = (Class7)(object)Class5.Default;
					Class7 class20 = @class;
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)obj18.W((BindingFlags)class20.t((BindingFlags)class21.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array5, array2, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, type, cultureInfo))), array, null, cultureInfo), array3, type, null, array4);
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					qk = null;
				}
			}
		}
		try
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + (num - num) == 0)
				{
					do
					{
						qk = (Qk7)((Class7)null).t(obj2, (Type)null, cultureInfo);
					}
					while (obj2 != null);
				}
			}
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array6, out *(object*)Class5.Default);
		}
		try
		{
			try
			{
				Class7 class22 = @class;
				BindingFlags bindingFlags_16 = (BindingFlags)@class.t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array4, null, array6, out object_4), array, obj2, cultureInfo);
				Class7 class23 = @class;
				BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_3 = array3;
				Class7 class24 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class22.t(bindingFlags_16, (FieldInfo[])(object)class23.W(bindingFlags_17, propertyInfo_3, (Type)(object)class24.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null), array2, array4), obj2, cultureInfo);
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array5, array2, array4) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
				}
				goto end_IL_33d3;
			}
			end_IL_33d3:;
		}
		catch
		{
			checked
			{
				do
				{
					num = default(UIntPtr);
					if (num + unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, array5, ref reference, array4, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)null).W(bindingFlags, array3, type, (Type[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo)), out *(object*)null), type, array2, array4)) == 0)
					{
						@struct = default(Struct2);
					}
				}
				while (obj2 != null);
			}
		}
		_ = (Class10)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
		Class5 class27;
		if (num == 0)
		{
			if (checked(num * unchecked((nuint)(UIntPtr)((Class7)null).t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null), array, obj2, (CultureInfo)null))) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class5)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, type, (Type[])(object)Class5.Default, array4);
				}
			}
			else
			{
				Class7 class25 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)@class.j((BindingFlags)@class.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), array5, ref reference, array4, null, array6, out object_4);
				object object_7 = obj2;
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class25.t(bindingFlags_18, fieldInfo_2, object_7, (CultureInfo)(object)class26.j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo), ref *(object[]*)null, null, null, null, out object_4)) == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					gClass4 = gClass4;
					_ = (Struct2)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array6, out *(object*)null)).j((BindingFlags)Class5.Default, null, ref reference, array4, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array5, array2, array4), null, out object_4), array4, null, null, out *(object*)@class.e((BindingFlags)Class5.Default, array5, array2, null)), (object)null, cultureInfo);
					gClass3 = gClass3;
				}
			}
		}
		else
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class27 = class27;
					gClass = null;
					class6 = class6;
					class11 = null;
				}
			}
			while (obj2 != null);
		}
		try
		{
			_ = (Class10)(object)Class5.Default;
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
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null);
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class28.j(bindingFlags, array5, ref *(object[]*)null, null, null, null, out *(object*)null);
					goto end_IL_372c;
				}
				end_IL_372c:;
			}
			finally
			{
				while (obj2 != null)
				{
					@class = @class;
				}
				goto IL_37a4;
			}
		}
		IL_1fb6:
		@struct = default(Struct2);
		_ = (Class8)(object)Class5.Default;
		if ((UIntPtr)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array3, type, array2, (ParameterModifier[])null)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array4) == (UIntPtr)(nuint)0u)
		{
			_ = (Class9)(object)@class.e(bindingFlags, array5, array2, array4);
		}
		class27 = null;
		if (num != (UIntPtr)(nuint)0u)
		{
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			class6 = class6;
		}
		else
		{
			_ = (GClass2)(object)Class5.Default;
		}
		_003CModule_003E = _003CModule_003E;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					Class7 class29 = @class;
					bindingFlags = default(BindingFlags);
					gClass = (GClass3)(object)class29.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t(obj2, (Type)@class.t(obj2, type, cultureInfo), cultureInfo), cultureInfo, array6, out *(object*)null);
					gClass = gClass;
					bindingFlags = default(BindingFlags);
					Class7 obj24 = (Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)null)).e(bindingFlags, array5, array2, null);
					BindingFlags bindingFlags_19 = bindingFlags;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj24.j(bindingFlags_19, (MethodBase[])(object)class30.e(bindingFlags, null, null, array4), ref *(object[]*)null, array4, cultureInfo, (string[])(object)@class.e((BindingFlags)Class5.Default, array5, array2, null), out *(object*)null);
				}
				finally
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo);
					continue;
				}
			}
			while (obj2 != null);
		}
		else
		{
			try
			{
				if ((UIntPtr)((Class7)null).W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])null, array4) == (UIntPtr)(nuint)0u)
				{
					_ = Class5.Default;
					_ = (Class8)(object)Class5.Default;
					_ = (Class8)(object)((Class7)null).t((BindingFlags)Class5.Default, array, (object)Class5.Default, cultureInfo);
				}
				else
				{
					_ = (_003CModule_003E)@class.t(obj2, null, cultureInfo);
				}
			}
			catch
			{
				do
				{
					_ = (GClass3)(object)@class.e(bindingFlags, array5, (Type[])(object)Class5.Default, array4);
				}
				while ((object)Class5.Default != null);
			}
		}
		BindingFlags bindingFlags_20 = bindingFlags;
		object object_8 = @class.t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, null, null);
		Class7 obj26 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_21 = (BindingFlags)Class5.Default;
		ref object[] object_9 = ref *(object[]*)Class5.Default;
		Class7 obj27 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_22 = bindingFlags;
		MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
		BindingFlags bindingFlags_23 = (BindingFlags)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default);
		BindingFlags bindingFlags_24 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_6 = array5;
		Class7 class31 = @class;
		BindingFlags bindingFlags_25 = bindingFlags;
		Class7 class32 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj28 = (Class7)(object)obj26.j(bindingFlags_21, null, ref object_9, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)obj27.j(bindingFlags_22, methodBase_5, ref *(object[]*)((Class7)null).j(bindingFlags_23, (MethodBase[])(object)((Class7)null).e(bindingFlags_24, methodBase_6, (Type[])(object)class31.j(bindingFlags_25, (MethodBase[])(object)class32.t(bindingFlags, array, obj2, null), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), array6, out *(object*)null), (ParameterModifier[])@class.t(obj2, type, null)), ref reference, array4, cultureInfo, (string[])null, out *(object*)null), array4, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array3, null, array2, array4), out object_4), (MethodBase[])(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array6, out object_4), null, array6, out *(object*)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo));
		Class7 class33 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).t(bindingFlags_20, (FieldInfo[])null, object_8, (CultureInfo)(object)obj28.j(default(BindingFlags), null, ref *(object[]*)class33.W(bindingFlags, array3, type, array2, null), null, cultureInfo, (string[])(object)Class5.Default, out object_4)) == (UIntPtr)(nuint)0u)
		{
			_ = (Class7)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)null);
		}
		do
		{
			_ = (Struct1)Class5.Default;
		}
		while ((object)Class5.Default != null);
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				Class7 class34 = @class;
				Class7 class35 = @class;
				BindingFlags bindingFlags_26 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
				Type type_6 = type;
				Type[] type_7 = array2;
				Class7 class36 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_27 = (BindingFlags)class35.W(bindingFlags_26, propertyInfo_4, type_6, type_7, (ParameterModifier[])(object)class36.e(bindingFlags, null, array2, null));
				MethodBase[] methodBase_7 = (MethodBase[])((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)null).t(obj2, type, cultureInfo), type, array2, (ParameterModifier[])null));
				Class7 class37 = @class;
				MethodBase[] methodBase_8 = (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null);
				Class7 class38 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class34.j(bindingFlags_27, methodBase_7, ref *(object[]*)class37.j(default(BindingFlags), methodBase_8, ref *(object[]*)class38.t(bindingFlags, null, obj2, null), array4, cultureInfo, (string[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)@class.t(obj2, (Type)@class.t(null, null, (CultureInfo)(object)Class5.Default), (CultureInfo)@class.t(@class.W(bindingFlags, array3, null, (Type[])(object)@class.e(bindingFlags, array5, null, array4), null), type, cultureInfo)), (Type[])null, array4), out *(object*)null), array4, cultureInfo, array6, out object_4);
			}
		}
		while (obj2 != null);
		Class7 class39 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class39.t(bindingFlags, array, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)@class.e((BindingFlags)Class5.Default, array5, array2, array4) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
			finally
			{
				try
				{
					class6 = class6;
				}
				finally
				{
					class6 = null;
					_ = (Qk7)((Class7)null).t(obj2, (Type)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, null, type, null, array4), type, array2, null)), cultureInfo);
					Class7 class40 = @class;
					MethodBase[] methodBase_9 = array5;
					bindingFlags = default(BindingFlags);
					Class7 obj29 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, (ParameterModifier[])null), ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)(object)class40.e(default(BindingFlags), methodBase_9, (Type[])(object)obj29.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array4), (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, null, cultureInfo, array6, out *(object*)null), array6, out *(object*)Class5.Default))).W(bindingFlags, array3, type, array2, array4);
					goto IL_268b;
				}
			}
		}
		goto IL_268b;
		IL_1f49:
		try
		{
			while (obj2 != null)
			{
				try
				{
					gClass3 = (GClass0)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass1)((Class7)null).t(obj2, type, (CultureInfo)null);
				}
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					class11 = null;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass4 = gClass4;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Class10)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				goto IL_1fb6;
			}
		}
		goto IL_1fb6;
		IL_37a4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			nuint num3 = num / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)));
			num = default(UIntPtr);
			checked
			{
				if (num3 + num == 0)
				{
					if (num * unchecked((nuint)(UIntPtr)@class.e(bindingFlags, null, null, array4)) == 0)
					{
						_ = (Class7)(object)Class5.Default;
					}
					else
					{
						@struct = @struct;
						struct2 = default(Struct1);
						struct2 = struct2;
						unchecked
						{
							_ = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, null, (string[])(object)@class.t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), out object_4);
							_ = (Class8)(object)@class.e((BindingFlags)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, null), null, array2, array4);
						}
					}
				}
			}
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
		}
		gClass3 = null;
		class16 = (Class2)(object)Class5.Default;
		BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
		object object_10 = @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)@class.W((BindingFlags)@class.W(bindingFlags, array3, type, (Type[])(object)Class5.Default, array4), null, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, null, type, null, array4), obj2, null), array2, (ParameterModifier[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)null)));
		Class7 class41 = @class;
		BindingFlags bindingFlags_29 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_10 = array5;
		Type[] type_8 = (Type[])(object)Class5.Default;
		Class7 class42 = @class;
		BindingFlags bindingFlags_30 = bindingFlags;
		ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
		string[] string_2 = (string[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.W((BindingFlags)Class5.Default, null, null, (Type[])(object)Class5.Default, array4), (MethodBase[])(object)@class.j(bindingFlags, null, ref reference, null, null, array6, out object_4), null, array4);
		Class7 obj33 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_31 = bindingFlags;
		MethodBase[] methodBase_11 = array5;
		CultureInfo cultureInfo_3 = cultureInfo;
		string[] string_3 = (string[])(object)Class5.Default;
		BindingFlags bindingFlags_32 = bindingFlags;
		FieldInfo[] fieldInfo_3 = array;
		object object_11 = ((Class7)null).W(default(BindingFlags), array3, type, array2, array4);
		Class7 class43 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)((Class7)null).t(bindingFlags_28, (FieldInfo[])null, object_10, (CultureInfo)(object)class41.e(bindingFlags_29, methodBase_10, type_8, (ParameterModifier[])(object)class42.j(bindingFlags_30, null, ref *(object[]*)null, parameterModifier_3, null, string_2, out *(object*)obj33.j(bindingFlags_31, methodBase_11, ref *(object[]*)null, null, cultureInfo_3, string_3, out *(object*)((Class7)null).t(bindingFlags_32, fieldInfo_3, object_11, (CultureInfo)(object)class43.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null))))));
		struct2 = struct2;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj2, null);
		}
		_ = (Class4)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Struct1)((Class7)null).e((BindingFlags)((Class7)null).j((BindingFlags)((Class7)(object)@class.j(bindingFlags, array5, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)null).W(bindingFlags, array3, (Type)null, array2, array4), out *(object*)null)).t(bindingFlags, array, obj2, cultureInfo), (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.t(null, type, cultureInfo), array5, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)((Class7)null).W((BindingFlags)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)null), (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)Class5.Default), array6, out *(object*)null), ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out object_4), (MethodBase[])null, array2, (ParameterModifier[])null);
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)((Class7)null).W(bindingFlags, array3, type, array2, array4);
					goto IL_3b6b;
				}
			}
			gClass = null;
		}
		else
		{
			do
			{
				try
				{
					class17 = class17;
				}
				finally
				{
					class7 = (Class10)(object)Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		goto IL_3b6b;
		IL_0370:
		_ = (Class7)(object)Class5.Default;
		_ = (GClass0)(object)((Class7)null).t((BindingFlags)@class.t(bindingFlags, array, obj2, cultureInfo), (FieldInfo[])(object)((Class7)(object)@class.e(bindingFlags, null, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array2, (ParameterModifier[])null), null)).t(default(BindingFlags), array, obj2, null), (object)null, (CultureInfo)(object)@class.e(default(BindingFlags), null, array2, (ParameterModifier[])(object)Class5.Default));
		class6 = class6;
		@class = @class;
		if (num == 0)
		{
			do
			{
				try
				{
					class27 = null;
					class27 = null;
				}
				finally
				{
					_ = (GClass2)(object)((Class7)null).W(default(BindingFlags), array3, (Type)null, array2, array4);
					continue;
				}
			}
			while (obj2 != null);
		}
		else
		{
			_ = (Class6)(object)Class5.Default;
		}
		Class7 class44 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj34 = (Class7)(object)class44.W(bindingFlags, array3, null, array2, (ParameterModifier[])(object)Class5.Default);
		BindingFlags bindingFlags_33 = bindingFlags;
		bindingFlags = default(BindingFlags);
		Class9 class45 = (Class9)(object)obj34.t(bindingFlags_33, (FieldInfo[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo)).e(bindingFlags, array5, array2, array4), obj2, (CultureInfo)(object)Class5.Default);
		class45 = class45;
		_ = (Class10)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array4);
		gClass3 = gClass3;
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		try
		{
			gClass = gClass;
		}
		finally
		{
			Class7 class46 = @class;
			BindingFlags bindingFlags_34 = bindingFlags;
			PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, array6, out *(object*)Class5.Default);
			Type type_9 = type;
			Type[] type_10 = array2;
			Class7 class47 = @class;
			Class7 class48 = @class;
			Type[] type_11 = array2;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, (ParameterModifier[])null);
			Type type_12 = type;
			Class7 class49 = @class;
			BindingFlags bindingFlags_35 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)Class5.Default, array4);
			ref object[] object_12 = ref reference;
			ParameterModifier[] parameterModifier_4 = array4;
			Class7 obj35 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			gClass2 = (GClass1)(object)class46.W(bindingFlags_34, propertyInfo_5, type_9, type_10, (ParameterModifier[])class47.t(class48.W(default(BindingFlags), null, null, type_11, (ParameterModifier[])(object)((Class7)null).W(default(BindingFlags), propertyInfo_6, type_12, (Type[])(object)class49.j(bindingFlags_35, methodBase_12, ref object_12, parameterModifier_4, null, (string[])(object)obj35.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, array3, (Type)null, array2, (ParameterModifier[])(object)@class.W((BindingFlags)@class.W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array, (object)null, cultureInfo), (PropertyInfo[])(object)Class5.Default, null, null, array4), (PropertyInfo[])(object)Class5.Default, type, null, null)), null, cultureInfo), out object_4), array4)), null, cultureInfo));
			_ = (Class0)(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, null, out object_4);
			goto IL_0636;
		}
		IL_2e48:
		try
		{
			Class7 class50 = @class;
			object object_13 = obj2;
			Class7 class51 = @class;
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)((Class7)class50.t(object_13, (Type)(object)class51.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array5, (Type[])null, array4), null, (string[])(object)Class5.Default, out *(object*)null), (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo))).e(bindingFlags, array5, null, array4) / num == 0)
			{
				qk = qk;
			}
		}
		catch
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					class6 = class6;
				}
				finally
				{
					_ = (Class9)((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default);
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass = gClass;
					gClass3 = gClass3;
					goto end_IL_2ebe;
				}
			}
			end_IL_2ebe:;
		}
		UIntPtr num4 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		if ((nuint)num4 / num == 0)
		{
			do
			{
				try
				{
					qk = null;
				}
				catch
				{
					_ = (GClass0)(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_4);
				}
			}
			while ((object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array4) != null);
		}
		while (obj2 != null)
		{
			Class7 class52 = @class;
			Class7 obj38 = (Class7)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), null, array2, array4);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class52.e((BindingFlags)obj38.j(bindingFlags, array5, ref reference, null, null, array6, out object_4), null, array2, array4);
		}
		if (num == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				class11 = null;
			}
			while (obj2 != null);
		}
		if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)@class.e((BindingFlags)Class5.Default, array5, null, null)).t((BindingFlags)@class.t(null, type, cultureInfo), array, obj2, cultureInfo)) - unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array5, ref *(object[]*)Class5.Default, array4, cultureInfo, null, out object_4))) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Qk7)(object)Class5.Default;
		}
		gClass = (GClass3)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class27 = null;
				}
				finally
				{
					_ = (Class9)@class.t(Class5.Default, type, (CultureInfo)(object)@class.e(bindingFlags, array5, array2, null));
					goto IL_30c9;
				}
			}
			try
			{
				gClass4 = gClass4;
			}
			catch
			{
				_ = (Class5)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, array4);
			}
		}
		goto IL_30c9;
		IL_268b:
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class7 = (Class10)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out object_4);
				}
				catch
				{
					_ = (Class10)(object)@class.W(bindingFlags, array3, null, (Type[])(object)((Class7)(object)Class5.Default).e(default(BindingFlags), null, array2, null), array4);
					class11 = null;
					gClass2 = (GClass1)(object)Class5.Default;
				}
			}
		}
		else if (checked(num + num) == 0)
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				struct2 = struct2;
			}
		}
		while (true)
		{
			Class7 obj42 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((object)obj42.t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default) != null)
			{
				_ = Class5.Default;
			}
			else if (obj2 == null && obj2 == null)
			{
				break;
			}
		}
		Class7 class53 = @class;
		BindingFlags bindingFlags_36 = bindingFlags;
		Class7 class54 = @class;
		FieldInfo[] fieldInfo_4 = array;
		Class7 class55 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class53.j(bindingFlags_36, null, ref *(object[]*)class54.e(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(default(BindingFlags), fieldInfo_4, (object)null, (CultureInfo)(object)class55.W(bindingFlags, null, type, array2, array4)), array2, null), (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)@class.t(bindingFlags, array, null, cultureInfo), out *(object*)null);
		while (obj2 != null)
		{
			try
			{
				while (obj2 != null)
				{
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass1)(object)class56.e(bindingFlags, array5, (Type[])@class.t(Class5.Default, (Type)(object)@class.W(bindingFlags, array3, type, array2, null), cultureInfo), (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array5, ref reference, array4, (CultureInfo)(object)Class5.Default, array6, out *(object*)@class.W(bindingFlags, array3, type, array2, null)));
					class16 = class16;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (checked(num * num) == 0)
				{
					qk = (Qk7)(object)@class.W((BindingFlags)@class.t(bindingFlags, null, obj2, null), (PropertyInfo[])(object)Class5.Default, type, array2, array4);
				}
				continue;
			}
		}
		Class7 class57 = @class;
		BindingFlags bindingFlags_37 = bindingFlags;
		Class7 class58 = @class;
		Class7 obj43 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)((Class7)(object)class58.j((BindingFlags)obj43.W(bindingFlags, array3, type, null, array4), null, ref reference, null, cultureInfo, null, out object_4)).j(bindingFlags, array5, ref reference, null, (CultureInfo)(object)@class.t(bindingFlags, array, obj2, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null)), null, out *(object*)null);
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class57.W(bindingFlags_37, propertyInfo_7, null, (Type[])(object)((Class7)null).e(bindingFlags, array5, (Type[])null, (ParameterModifier[])(object)Class5.Default), array4);
		while (obj2 != null)
		{
			qk = (Qk7)(object)Class5.Default;
			class11 = class11;
			gClass2 = (GClass1)(object)Class5.Default;
			_ = (GClass3)(object)Class5.Default;
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				@struct = (Struct2)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)((Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])null, array4)).t(obj2, type, null);
				class7 = class7;
				@class = @class;
			}
		}
		catch
		{
			_ = (Class9)(object)((Class7)(object)Class5.Default).W(bindingFlags, array3, type, array2, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default));
		}
		nuint num5 = num;
		num = default(UIntPtr);
		if (checked(num5 - num) == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					Class7 class59 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class59.t(bindingFlags, array, Class5.Default, cultureInfo);
					_ = (Class10)(object)Class5.Default;
					_ = (Class10)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				if (num / checked(unchecked((nuint)(UIntPtr)Class5.Default) - num) == 0)
				{
					class7 = null;
				}
				else
				{
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, array3, (Type)null, array2, array4)).e(bindingFlags, array5, array2, array4);
					class11 = class11;
					_ = (_003CModule_003E)(object)Class5.Default;
					class45 = class45;
				}
			}
		}
		else
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			class16 = class16;
			_ = (Class0)@class.t(@class.e((BindingFlags)@class.j((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out object_4), null, ref reference, array4, (CultureInfo)(object)Class5.Default, (string[])@class.t(obj2, (Type)((Class7)@class.t(null, null, null)).t(obj2, null, cultureInfo), null), out object_4), null, array2, null), (Type)(object)Class5.Default, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), null, array2, (ParameterModifier[])(object)Class5.Default));
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class27 = class27;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				try
				{
					class45 = class45;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = gClass;
					gClass3 = null;
					Class7 class60 = @class;
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					class11 = (Class0)class60.t(class61.e(bindingFlags, array5, array2, null), type, cultureInfo);
					Class7 class62 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class62.e(bindingFlags, array5, array2, null);
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		finally
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					gClass = gClass;
					_ = (Class4)(object)Class5.Default;
					_ = (Qk7)(object)@class.t(bindingFlags, array, obj2, cultureInfo);
					class17 = class17;
				}
			}
			goto IL_2c52;
		}
		IL_3b6b:
		try
		{
			while (obj2 != null)
			{
				try
				{
					@class = null;
					_ = (Class6)(object)@class.j((BindingFlags)@class.e(bindingFlags, array5, null, array4), array5, ref *(object[]*)Class5.Default, array4, cultureInfo, array6, out *(object*)Class5.Default);
				}
				catch
				{
					_ = (GClass1)(object)((Class7)@class.t(obj2, type, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null))).e(bindingFlags, array5, null, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, array5, ref reference, (ParameterModifier[])null, cultureInfo, array6, out object_4);
					gClass = null;
					continue;
				}
			}
		}
		_ = (Class4)(object)((Class7)null).W((BindingFlags)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo), array3, (Type)null, array2, (ParameterModifier[])(object)@class.j(bindingFlags, array5, ref *(object[]*)@class.e((BindingFlags)Class5.Default, array5, null, array4), array4, null, array6, out object_4));
		try
		{
			if ((UIntPtr)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, null, array4) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class11 = class11;
				}
				while (obj2 != null);
			}
			else
			{
				@class = (Class7)(object)Class5.Default;
				class6 = class6;
				qk = qk;
			}
			return;
		}
		finally
		{
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			gClass4 = (GClass2)(object)class63.j(bindingFlags, array5, ref reference, array4, cultureInfo, (string[])(object)((Class7)(object)@class.W(bindingFlags, array3, type, array2, array4)).t((BindingFlags)@class.t(null, type, cultureInfo), array, ((Class7)null).W(bindingFlags, array3, type, (Type[])null, array4), (CultureInfo)(object)((Class7)null).e(default(BindingFlags), array5, (Type[])null, array4)), out *(object*)null);
			return;
		}
		IL_1c36:
		Class7 obj51 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)obj51.W(bindingFlags, array3, null, null, array4);
		Class7 obj52 = (Class7)@class.t(obj2, (Type)(object)@class.t(bindingFlags, array, obj2, null), (CultureInfo)(object)Class5.Default);
		Class7 obj53 = (Class7)(object)@class.t(bindingFlags, array, obj2, null);
		bindingFlags = default(BindingFlags);
		gClass2 = (GClass1)(object)obj52.e((BindingFlags)((Class7)(object)obj53.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array4)).j(bindingFlags, array5, ref reference, array4, cultureInfo, null, out *(object*)null), array5, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array3, type, array2, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default);
		_ = (Class8)(object)Class5.Default;
		_ = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, null, array2, array4);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					struct2 = (Struct1)Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				_ = (Class5)(object)@class.j((BindingFlags)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)Class5.Default), array5, ref *(object[]*)Class5.Default, array4, null, null, out object_4);
				class11 = class11;
				_ = (Struct1)Class5.Default;
			}
		}
		if (num == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)class64.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)((Class7)((Class7)null).t((object)null, type, (CultureInfo)null)).t(bindingFlags, array, null, cultureInfo));
			}
		}
		@struct = @struct;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (Class9)(object)Class5.Default;
				gClass2 = null;
				_ = (Class8)(object)Class5.Default;
			}
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				@class = @class;
				Class7 obj54 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class11 = (Class0)((Class7)(object)((Class7)(object)obj54.j(bindingFlags, array5, ref reference, array4, cultureInfo, array6, out *(object*)null)).j(bindingFlags, array5, ref *(object[]*)@class.t(bindingFlags, array, Class5.Default, cultureInfo), array4, cultureInfo, (string[])(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref reference, array4, (CultureInfo)(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)Class5.Default), (string[])null, out object_4), out object_4)).t(obj2, type, cultureInfo);
				class7 = null;
				_ = (Class2)(object)Class5.Default;
			}
		}
		while (obj2 != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class16 = class16;
				}
				finally
				{
					_ = Class5.Default;
					goto IL_1f49;
				}
			}
		}
		goto IL_1f49;
		IL_0636:
		nuint num6 = num / unchecked((nuint)default(UIntPtr));
		Class7 obj55 = (Class7)(object)Class5.Default;
		Class7 class65 = @class;
		bindingFlags = default(BindingFlags);
		if (num6 / (nuint)(UIntPtr)obj55.t(((Class7)(object)class65.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), type, null, array4)).j((BindingFlags)((Class7)null).W(bindingFlags, array3, (Type)null, array2, (ParameterModifier[])null), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, null, array6, out object_4), type, null) == 0 && checked(unchecked((nuint)(UIntPtr)@class.t(obj2, type, null) / (nuint)(UIntPtr)Class5.Default) + (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)default(UIntPtr)))) == 0)
		{
			do
			{
				Class2 obj56 = (Class2)(object)Class5.Default;
				class16 = class16;
				class16 = obj56;
			}
			while (obj2 != null);
		}
		_ = (Class9)(object)Class5.Default;
		_ = (GClass3)(object)((Class7)null).W(bindingFlags, array3, (Type)null, (Type[])@class.t(Class5.Default, (Type)(object)@class.W((BindingFlags)@class.t(default(BindingFlags), array, obj2, cultureInfo), null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), cultureInfo), (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, null, null, null));
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		_ = (Struct2)Class5.Default;
		num = default(UIntPtr);
		nuint num7 = checked(num + num);
		Class7 class66 = @class;
		BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_13 = array5;
		ref object[] object_14 = ref reference;
		ParameterModifier[] parameterModifier_5 = array4;
		CultureInfo cultureInfo_4 = cultureInfo;
		Class7 class67 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			nuint num8 = unchecked((nuint)(UIntPtr)class66.j(bindingFlags_38, methodBase_13, ref object_14, parameterModifier_5, cultureInfo_4, (string[])(object)class67.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array4, cultureInfo, array6, out object_4), out *(object*)Class5.Default)) + num;
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) * (num7 - unchecked(num8 / num)) == 0)
			{
				unchecked
				{
					try
					{
						do
						{
							Class7 class68 = @class;
							bindingFlags = default(BindingFlags);
							_ = (Class7)(object)class68.j(bindingFlags, null, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
							bindingFlags = default(BindingFlags);
						}
						while ((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null) != null);
					}
					catch
					{
						if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
						{
							class45 = class45;
						}
					}
				}
			}
			_003CModule_003E = null;
			_ = (Class0)(object)Class5.Default;
			class7 = class7;
			try
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					finally
					{
						_003CModule_003E = null;
						goto end_IL_0894;
					}
				}
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					_ = (Class10)(object)Class5.Default;
				}
				end_IL_0894:;
			}
			catch
			{
				try
				{
					try
					{
						_ = (GClass2)@class.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					}
					finally
					{
						Class7 class69 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class8)(object)class69.t(bindingFlags, array, obj2, cultureInfo);
						goto end_IL_08d1;
					}
					end_IL_08d1:;
				}
				finally
				{
					if (num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class6)(object)Class5.Default;
					}
					else
					{
						_ = (Class7)(object)Class5.Default;
					}
					goto end_IL_08d0;
				}
				end_IL_08d0:;
			}
			_ = (Struct2)@class.t(Class5.Default, type, cultureInfo);
			_ = (GClass1)(object)Class5.Default;
			_ = (Class7)(object)Class5.Default;
			_003CModule_003E = null;
			try
			{
				num = default(UIntPtr);
				if (unchecked(num / num) + num == 0)
				{
				}
			}
			catch
			{
				_ = (Struct1)unchecked(((Class7)((Class7)(object)Class5.Default).t(obj2, (Type)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)@class.e(bindingFlags, array5, array2, array4))).t(bindingFlags, (FieldInfo[])@class.t(obj2, null, null), null, cultureInfo), null), cultureInfo)).W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, (Type[])(object)@class.W((BindingFlags)Class5.Default, null, type, null, null), (ParameterModifier[])(object)Class5.Default));
			}
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					do
					{
						_ = (Class6)(object)@class.e(bindingFlags, array5, array2, array4);
						_ = (Class7)(object)Class5.Default;
						gClass3 = gClass3;
					}
					while (obj2 != null);
				}
			}
			while (obj2 != null);
		}
		try
		{
			try
			{
			}
			catch
			{
				try
				{
					Class4 obj61 = (Class4)(object)((Class7)@class.t(obj2, null, (CultureInfo)(object)Class5.Default)).j(bindingFlags, array5, ref reference, null, cultureInfo, null, out object_4);
					class17 = class17;
					class17 = obj61;
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class9)(object)@class.j(bindingFlags, array5, ref reference, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)@class.j((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.j(bindingFlags, null, ref reference, array4, cultureInfo, array6, out *(object*)((Class7)null).t(obj2, type, cultureInfo)), (object)null, cultureInfo), (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, (ParameterModifier[])null), ref *(object[]*)null, null, null, (string[])@class.t(obj2, type, null), out *(object*)null), out object_4);
				}
				catch
				{
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class70.j(bindingFlags, array5, ref reference, array4, null, array6, out *(object*)null);
					_ = Class5.Default;
					Class7 obj64 = (Class7)(object)@class.W((BindingFlags)@class.W((BindingFlags)@class.j((BindingFlags)@class.t(bindingFlags, array, obj2, cultureInfo), null, ref *(object[]*)null, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, cultureInfo, array6, out object_4), null, array6, out *(object*)Class5.Default), array3, null, array2, array4), null, type, array2, (ParameterModifier[])(object)Class5.Default);
					object object_15 = obj2;
					Class7 obj65 = (Class7)(object)@class.e((BindingFlags)Class5.Default, null, array2, array4);
					BindingFlags bindingFlags_39 = bindingFlags;
					MethodBase[] methodBase_14 = array5;
					ref object[] object_16 = ref reference;
					ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array2, array4);
					bindingFlags = default(BindingFlags);
					_ = (Qk7)obj64.t(object_15, null, (CultureInfo)(object)obj65.j(bindingFlags_39, methodBase_14, ref object_16, parameterModifier_6, (CultureInfo)(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)@class.t(bindingFlags, array, null, null), array4, (CultureInfo)null, array6, out object_4), null, out *(object*)Class5.Default));
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class17 = null;
					class7 = class7;
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					class16 = null;
					class16 = (Class2)(object)Class5.Default;
				}
			}
		}
		else
		{
			try
			{
				_ = (Class7)(object)@class.W((BindingFlags)Class5.Default, array3, type, null, array4);
			}
			catch
			{
				try
				{
					class45 = class45;
					_ = (GClass0)(object)((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, array2, null)), array, obj2, (CultureInfo)null);
				}
				catch
				{
					_ = (Struct2)@class.t(obj2, null, cultureInfo);
				}
			}
		}
		checked
		{
			while ((object)Class5.Default != null)
			{
				if (num * unchecked((nuint)(UIntPtr)Class5.Default) + (num * unchecked((nuint)(UIntPtr)Class5.Default) + num) == 0)
				{
					while ((object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo) != null)
					{
						Class7 class71 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class2)(object)class71.t(bindingFlags, array, null, null);
					}
				}
			}
			class6 = null;
		}
		do
		{
			_ = (Class10)(object)Class5.Default;
		}
		while ((object)@class.e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, null) != null);
		try
		{
			try
			{
				do
				{
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo);
				}
				while (obj2 != null);
			}
			finally
			{
				if (num == 0)
				{
					_ = Class5.Default;
				}
				else
				{
					class45 = class45;
				}
				goto end_IL_0e3c;
			}
			end_IL_0e3c:;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, array4)) - unchecked((nuint)(UIntPtr)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null))) == 0)
			{
				do
				{
					Class7 class72 = @class;
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_40 = (BindingFlags)class73.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array4);
					BindingFlags bindingFlags_41 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = array3;
					Type type_13 = type;
					BindingFlags bindingFlags_42 = bindingFlags;
					MethodBase[] methodBase_15 = array5;
					Class7 class74 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj71 = (Class7)(object)class74.t(bindingFlags, array, @class.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default), cultureInfo);
					BindingFlags bindingFlags_43 = bindingFlags;
					CultureInfo cultureInfo_5 = (CultureInfo)((Class7)null).t(obj2, type, cultureInfo);
					string[] string_4 = (string[])(object)Class5.Default;
					Class7 class75 = @class;
					BindingFlags bindingFlags_44 = (BindingFlags)@class.t(default(BindingFlags), array, obj2, cultureInfo);
					PropertyInfo[] propertyInfo_9 = array3;
					Class7 obj72 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)((Class7)null).t((object)class72.W(bindingFlags_40, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_41, propertyInfo_8, type_13, (Type[])(object)((Class7)null).e(bindingFlags_42, methodBase_15, (Type[])(object)obj71.j(bindingFlags_43, null, ref *(object[]*)null, null, cultureInfo_5, string_4, out *(object*)((Class7)(object)class75.W(bindingFlags_44, propertyInfo_9, null, (Type[])(object)obj72.W(bindingFlags, array3, null, array2, array4), array4)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)), array4), (ParameterModifier[])(object)Class5.Default), type, null, null), type, cultureInfo);
					_ = (Qk7)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		_ = (Struct1)Class5.Default;
		_ = (Struct2)Class5.Default;
		_ = (Class0)(object)Class5.Default;
		_ = (GClass0)((Class7)null).t(obj2, (Type)(object)@class.t(bindingFlags, array, null, cultureInfo), cultureInfo);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			UIntPtr num9 = (UIntPtr)@class.t(obj2, type, cultureInfo);
			Class7 class76 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj74 = (Class7)(object)class76.t(bindingFlags, array, null, null);
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_16 = array5;
			ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)@class.W(default(BindingFlags), array3, type, null, array4);
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)num9) * unchecked((nuint)(UIntPtr)obj74.j(bindingFlags_45, methodBase_16, ref *(object[]*)null, parameterModifier_7, (CultureInfo)(object)class77.t(bindingFlags, array, obj2, null), (string[])(object)@class.e(bindingFlags, array5, array2, array4), out *(object*)@class.t(obj2, type, cultureInfo)))) == 0)
			{
				while (obj2 != null)
				{
					Class7 class78 = @class;
					BindingFlags bindingFlags_46 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = array3;
					Class7 class79 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj75 = (Class7)(object)class79.W(bindingFlags, array3, null, array2, array4);
					BindingFlags bindingFlags_47 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_11 = array3;
					Class7 class80 = @class;
					BindingFlags bindingFlags_48 = (BindingFlags)@class.W((BindingFlags)Class5.Default, array3, type, (Type[])(object)@class.W(bindingFlags, array3, type, array2, null), array4);
					PropertyInfo[] propertyInfo_12 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj76 = (Class7)(object)Class5.Default;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_49 = bindingFlags;
					MethodBase[] methodBase_17 = array5;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 class82 = @class;
					BindingFlags bindingFlags_50 = bindingFlags;
					MethodBase[] methodBase_18 = array5;
					ParameterModifier[] parameterModifier_8 = array4;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj77 = (Class7)(object)((Class7)null).t((BindingFlags)class82.j(bindingFlags_50, methodBase_18, ref *(object[]*)null, parameterModifier_8, null, (string[])(object)class83.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)((Class7)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.e(bindingFlags, array5, (Type[])(object)@class.t(default(BindingFlags), array, null, null), (ParameterModifier[])(object)Class5.Default), null, array6, out object_4)), out object_4), array, obj2, (CultureInfo)null);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class78.W(bindingFlags_46, propertyInfo_10, null, (Type[])(object)obj75.W(bindingFlags_47, propertyInfo_11, (Type)(object)class80.W(bindingFlags_48, propertyInfo_12, (Type)(object)obj76.t(default(BindingFlags), null, null, (CultureInfo)(object)class81.j(bindingFlags_49, methodBase_17, ref *(object[]*)null, null, cultureInfo_6, (string[])(object)obj77.W(bindingFlags, null, type, array2, null), out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, array5, null, null))), array2, null), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array2, null)), array4);
					_ = (GClass1)@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
				}
			}
			else
			{
				while (@class.t(null, null, cultureInfo) != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		_ = (Struct1)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array4, cultureInfo, array6, out object_4);
		try
		{
			do
			{
				_ = (Class4)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			while ((object)Class5.Default != null || (object)Class5.Default != null);
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 obj78 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj78.t(bindingFlags, null, obj2, null);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
					Class7 obj79 = (Class7)(object)@class.j(bindingFlags, array5, ref *(object[]*)null, null, null, array6, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class84.e(bindingFlags_51, methodBase_19, (Type[])(object)obj79.W(bindingFlags, array3, null, (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array5, array2, array4), (Type[])(object)Class5.Default, array4), null), (ParameterModifier[])((Class7)(object)Class5.Default).t(Class5.Default, null, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.t((BindingFlags)((Class7)(object)@class.t(bindingFlags, array, obj2, (CultureInfo)((Class7)(object)((Class7)null).e(default(BindingFlags), array5, array2, array4)).t(obj2, null, cultureInfo))).t(obj2, type, cultureInfo), null, obj2, cultureInfo), (MethodBase[])(object)Class5.Default, null, null), obj2, cultureInfo)));
					Class7 class85 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class85.t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			class7 = null;
		}
		if (checked(num * num) == 0)
		{
			do
			{
				Struct1 obj82 = (Struct1)Class5.Default;
				struct2 = struct2;
				struct2 = obj82;
			}
			while ((object)@class.e(bindingFlags, array5, array2, array4) != null);
		}
		try
		{
			while (obj2 != null)
			{
				try
				{
					@struct = @struct;
					gClass2 = null;
				}
				finally
				{
					Class7 class86 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class86.e(bindingFlags_52, (MethodBase[])(object)((Class7)(object)class87.e(bindingFlags, array5, null, (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, null, obj2, cultureInfo), array2, array4);
					continue;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null), array2, array4) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj2 != null);
				goto end_IL_1598;
			}
			end_IL_1598:;
		}
		Class7 obj84;
		BindingFlags bindingFlags_53;
		MethodBase[] methodBase_20;
		ref object[] object_17;
		ParameterModifier[] parameterModifier_9;
		Class7 obj90;
		BindingFlags bindingFlags_65;
		MethodBase[] methodBase_23;
		Class7 class100;
		do
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			obj84 = (Class7)(object)Class5.Default;
			bindingFlags_53 = bindingFlags;
			bindingFlags = default(BindingFlags);
			methodBase_20 = (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, type, (Type[])null, (ParameterModifier[])(object)@class.W(bindingFlags, null, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])null, array4), array2, null));
			object_17 = ref reference;
			Class7 class88 = @class;
			Class7 class89 = @class;
			BindingFlags bindingFlags_54 = (BindingFlags)@class.t(null, type, cultureInfo);
			Class7 class90 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_55 = bindingFlags;
			Class7 class91 = @class;
			BindingFlags bindingFlags_56 = bindingFlags;
			MethodBase[] methodBase_21 = array5;
			Class7 class92 = @class;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)class91.j(bindingFlags_56, methodBase_21, ref *(object[]*)null, (ParameterModifier[])(object)class92.e(bindingFlags, array5, array2, array4), cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			Class7 class93 = @class;
			BindingFlags bindingFlags_57 = (BindingFlags)((Class7)null).e(bindingFlags, array5, array2, array4);
			Class7 class94 = @class;
			BindingFlags bindingFlags_58 = bindingFlags;
			FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
			Class7 class95 = @class;
			BindingFlags bindingFlags_59 = bindingFlags;
			Class7 class96 = @class;
			BindingFlags bindingFlags_60 = (BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t(bindingFlags, array, obj2, null), null, (Type[])(object)Class5.Default, array4);
			FieldInfo[] fieldInfo_6 = array;
			Class7 class97 = @class;
			BindingFlags bindingFlags_61 = bindingFlags;
			PropertyInfo[] propertyInfo_14 = array3;
			Type type_14 = type;
			Class7 class98 = @class;
			Class7 obj85 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_62 = (BindingFlags)obj85.t(bindingFlags, array, obj2, null);
			Class7 obj86 = (Class7)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
			Class7 obj87 = (Class7)((Class7)null).t(obj2, type, cultureInfo);
			Class7 obj88 = (Class7)(object)@class.W(bindingFlags, array3, type, (Type[])(object)Class5.Default, array4);
			bindingFlags = default(BindingFlags);
			Class7 obj89 = (Class7)(object)class94.t(bindingFlags_58, fieldInfo_5, class95.j(bindingFlags_59, null, ref *(object[]*)((Class7)(object)class96.t(bindingFlags_60, fieldInfo_6, class97.W(bindingFlags_61, propertyInfo_14, type_14, (Type[])(object)class98.t(bindingFlags_62, (FieldInfo[])(object)obj86.e((BindingFlags)obj87.t(obj88.t(bindingFlags, null, null, cultureInfo), null, (CultureInfo)((Class7)null).t(obj2, (Type)(object)((Class7)null).e((BindingFlags)Class5.Default, array5, array2, array4), cultureInfo)), array5, null, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null)), obj2, (CultureInfo)(object)Class5.Default), null), cultureInfo)).W((BindingFlags)@class.t(null, type, (CultureInfo)(object)@class.W(bindingFlags, null, null, array2, array4)), array3, type, array2, array4), array4, cultureInfo, array6, out *(object*)null), null);
			BindingFlags bindingFlags_63 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_22 = array5;
			BindingFlags bindingFlags_64 = bindingFlags;
			Class7 class99 = @class;
			bindingFlags = default(BindingFlags);
			parameterModifier_9 = (ParameterModifier[])class88.t(null, (Type)(object)class89.j(bindingFlags_54, (MethodBase[])(object)class90.W(bindingFlags_55, propertyInfo_13, (Type)(object)class93.t(bindingFlags_57, (FieldInfo[])(object)obj89.j(bindingFlags_63, methodBase_22, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)null).e(bindingFlags_64, (MethodBase[])(object)((Class7)(object)class99.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)Class5.Default)).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)null), array2, (ParameterModifier[])null), array6, out *(object*)null), Class5.Default, null), null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array5, (Type[])null, (ParameterModifier[])(object)@class.e(bindingFlags, null, array2, array4))), ref *(object[]*)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default), null, cultureInfo, array6, out object_4), cultureInfo);
			obj90 = (Class7)(object)Class5.Default;
			bindingFlags_65 = (BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array5, null, array4);
			methodBase_23 = array5;
			class100 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj84.j(bindingFlags_53, methodBase_20, ref object_17, parameterModifier_9, (CultureInfo)(object)obj90.j(bindingFlags_65, methodBase_23, ref *(object[]*)null, (ParameterModifier[])(object)class100.W(bindingFlags, array3, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array5, array2, array4)), null, array6, out object_4), null, out object_4) != null);
		while (obj2 != null)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			gClass = null;
		}
		finally
		{
			gClass3 = (GClass0)(object)Class5.Default;
			goto IL_19e0;
		}
		IL_2c52:
		if ((UIntPtr)@class.t(obj2, type, (CultureInfo)@class.t(null, null, cultureInfo)) == (UIntPtr)(nuint)0u)
		{
			_ = (Class10)(object)Class5.Default;
		}
		class6 = null;
		_ = (Class9)(object)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		do
		{
			num = default(UIntPtr);
			if (num == 0 && (UIntPtr)@class.j((BindingFlags)((Class7)null).j((BindingFlags)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out object_4), null, ref reference, array4, (CultureInfo)(object)Class5.Default, null, out object_4) == (UIntPtr)(nuint)0u)
			{
				_ = (Class8)(object)@class.e(default(BindingFlags), null, null, array4);
			}
		}
		while ((object)Class5.Default != null);
		gClass4 = (GClass2)(object)Class5.Default;
		Class7 obj91 = (Class7)(object)@class.e(default(BindingFlags), null, null, null);
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)obj91.j(bindingFlags, array5, ref reference, array4, (CultureInfo)(object)Class5.Default, array6, out *(object*)null);
		do
		{
			gClass3 = null;
		}
		while (obj2 != null);
		qk = (Qk7)(object)((Class7)null).t((BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
		_ = (Class2)(object)Class5.Default;
		try
		{
			Class7 obj92 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_66 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)obj92.j(bindingFlags_66, (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, type, array2, (ParameterModifier[])null), ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)Class5.Default);
		}
		catch
		{
			_ = (Struct1)Class5.Default;
		}
		_ = (GClass3)(object)Class5.Default;
		try
		{
			nuint num10 = num;
			num = default(UIntPtr);
			nuint num11 = num;
			num = default(UIntPtr);
			if (checked(num10 + (num11 - num)) == 0)
			{
				class11 = (Class0)(object)Class5.Default;
			}
		}
		finally
		{
			qk = null;
			goto IL_2e48;
		}
	}
}
