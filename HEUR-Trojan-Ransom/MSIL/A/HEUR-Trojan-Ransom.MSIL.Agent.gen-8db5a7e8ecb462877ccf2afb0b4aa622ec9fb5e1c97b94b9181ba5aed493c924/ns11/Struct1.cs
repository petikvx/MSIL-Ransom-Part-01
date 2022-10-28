using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using A_0024r;
using Dn7;
using Je5;
using Xt9;
using ns1;
using ns10;
using ns12;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns11;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 474)]
internal struct Struct1
{
	unsafe static void smethod_0()
	{
		Class7 @class = null;
		Class7 class2 = @class;
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		PropertyInfo[] array = array;
		PropertyInfo[] propertyInfo_ = array;
		Type type_ = (Type)(object)Class5.Default;
		_ = (GClass0)(object)class2.W(bindingFlags_, propertyInfo_, type_, null, null);
		_ = (GClass3)(object)Class5.Default;
		Class5 class3 = null;
		class3 = class3;
		Class7 class4 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)class4.W(bindingFlags, null, null, null, null);
		Type[] array2;
		object obj2;
		FieldInfo[] fieldInfo_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		ParameterModifier[] parameterModifier_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		BindingFlags bindingFlags_5;
		PropertyInfo[] propertyInfo_3;
		Class7 obj3;
		BindingFlags bindingFlags_6;
		MethodBase[] methodBase_2;
		ref object[] object_;
		Class7 obj6;
		nuint uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		do
		{
			uIntPtr = default(UIntPtr);
			Class7 class5 = @class;
			BindingFlags bindingFlags_2 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array;
			array2 = null;
			Class7 obj = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class6 = @class;
			obj2 = null;
			fieldInfo_ = (FieldInfo[])class6.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
			cultureInfo = cultureInfo;
			BindingFlags bindingFlags_4 = (BindingFlags)((Class7)null).t(bindingFlags_3, fieldInfo_, (object)null, cultureInfo);
			array3 = array3;
			MethodBase[] methodBase_ = array3;
			parameterModifier_ = null;
			CultureInfo cultureInfo_ = (CultureInfo)((Class7)null).t(obj2, type_, cultureInfo);
			string[] string_ = (string[])(object)Class5.Default;
			reference = ref reference;
			checked
			{
				nuint num = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)class5.W(bindingFlags_2, propertyInfo_2, type_, array2, (ParameterModifier[])(object)obj.j(bindingFlags_4, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out reference)));
				UIntPtr num2 = unchecked((UIntPtr)((Class7)null).W(bindingFlags, array, (Type)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, cultureInfo), array2, (ParameterModifier[])(object)Class5.Default));
				uIntPtr = default(UIntPtr);
				nuint num3 = num - (unchecked((nuint)num2) - uIntPtr) * (uIntPtr * unchecked((nuint)(UIntPtr)@class.t(bindingFlags, fieldInfo_, obj2, cultureInfo)));
				UIntPtr num4 = unchecked((UIntPtr)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo));
				uIntPtr = default(UIntPtr);
				if (num3 * unchecked((nuint)num4 / uIntPtr) - uIntPtr == 0 && unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
				{
					@struct = @struct;
					@struct = default(Struct1);
				}
				bindingFlags_5 = bindingFlags;
				propertyInfo_3 = array;
				obj3 = (Class7)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo)).t(Class5.Default, null, null);
				bindingFlags_6 = bindingFlags;
				methodBase_2 = array3;
			}
			BindingFlags bindingFlags_7 = (BindingFlags)((Class7)null).t(obj2, type_, (CultureInfo)null);
			Class7 obj4 = (Class7)((Class7)(object)@class.t(bindingFlags, fieldInfo_, obj2, cultureInfo)).t(obj2, type_, null);
			BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_3 = array3;
			object_ = ref *(object[]*)Class5.Default;
			Class7 obj5 = (Class7)(object)obj4.j(bindingFlags_8, methodBase_3, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).t(obj2, (Type)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_), cultureInfo));
			bindingFlags = default(BindingFlags);
			obj6 = (Class7)(object)((Class7)null).t(bindingFlags_7, (FieldInfo[])(object)obj5.j(bindingFlags, array3, ref object_, parameterModifier_, cultureInfo, null, out *(object*)null), (object)((Class7)(object)Class5.Default).t((BindingFlags)@class.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])@class.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), out reference)), fieldInfo_, obj2, null), (CultureInfo)(object)Class5.Default);
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).W(bindingFlags_5, propertyInfo_3, type_, array2, (ParameterModifier[])(object)obj3.e(bindingFlags_6, methodBase_2, (Type[])(object)obj6.e(bindingFlags, array3, array2, parameterModifier_), null)) != null);
		Class0 class7 = class7;
		class7 = class7;
		_ = (GClass1)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		nuint num5 = uIntPtr / uIntPtr / uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class9);
		checked
		{
			if (num5 - unchecked(uIntPtr / (nuint)(UIntPtr)Class5.Default / checked(uIntPtr - unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)@class.W(bindingFlags, array, (Type)(object)@class.t(bindingFlags, fieldInfo_, obj2, null), (Type[])(object)Class5.Default, parameterModifier_), cultureInfo, (string[])null, out reference)))) == 0)
			{
				while (obj2 != null)
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
			do
			{
				_ = (Struct2)unchecked(((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)((Class7)null).t((BindingFlags)@class.W(bindingFlags, array, type_, null, (ParameterModifier[])(object)Class5.Default), fieldInfo_, (object)Class5.Default, (CultureInfo)@class.t(obj2, type_, cultureInfo)), (CultureInfo)null));
			}
			while (obj2 != null);
			try
			{
				try
				{
					do
					{
						_ = (Class2)(object)Class5.Default;
						_ = (GClass3)@class.t(obj2, type_, cultureInfo);
					}
					while (obj2 != null);
				}
				finally
				{
					while (obj2 != null)
					{
						BindingFlags bindingFlags_9 = bindingFlags;
						MethodBase[] methodBase_4 = array3;
						ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)@class.e(bindingFlags, array3, (Type[])(object)Class5.Default, null);
						CultureInfo cultureInfo_2 = cultureInfo;
						array4 = null;
						_ = (Class9)(object)((Class7)null).j(bindingFlags_9, methodBase_4, ref object_, parameterModifier_2, cultureInfo_2, array4, out reference);
					}
					goto end_IL_041c;
				}
				end_IL_041c:;
			}
			catch
			{
				try
				{
					do
					{
						class8 = null;
						class8 = class8;
					}
					while (obj2 != null);
				}
				finally
				{
					if (uIntPtr == 0)
					{
						@struct = default(Struct1);
					}
					else
					{
						_ = (Struct2)@class.W(bindingFlags, array, type_, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null));
						gClass = gClass;
						gClass = null;
					}
					goto end_IL_0481;
				}
				end_IL_0481:;
			}
			while (obj2 != null)
			{
				try
				{
					do
					{
						class9 = null;
						class9 = null;
					}
					while (obj2 != null);
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo)) * uIntPtr == 0)
					{
						class10 = class10;
						class10 = class10;
					}
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Class7 obj8 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj9 = (Class7)(object)obj8.j(bindingFlags, array3, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference);
				Class7 class11 = @class;
				Class7 obj10 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = bindingFlags;
				Class7 class12 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_11 = (BindingFlags)obj10.e(bindingFlags_10, (MethodBase[])(object)class12.t((BindingFlags)((Class7)null).W(bindingFlags, array, type_, array2, parameterModifier_), null, null, (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, parameterModifier_);
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj11 = (Class7)(object)((Class7)(object)((Class7)(object)class13.W(bindingFlags, array, null, array2, null)).e((BindingFlags)Class5.Default, array3, array2, parameterModifier_)).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo);
				BindingFlags bindingFlags_12 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				ref object[] object_2 = ref *(object[]*)@class.t(null, type_, cultureInfo);
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array3, ref object_, (ParameterModifier[])(object)((Class7)(object)@class.W(bindingFlags, array, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null), null, array4, out reference);
				Class7 class14 = @class;
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 obj12 = (Class7)@class.t(obj2, type_, cultureInfo);
				bindingFlags = default(BindingFlags);
				ref object[] object_3 = ref *(object[]*)obj11.j(bindingFlags_12, methodBase_5, ref object_2, parameterModifier_3, (CultureInfo)(object)class14.j(bindingFlags_13, (MethodBase[])(object)obj12.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default), ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out reference), array4, out reference);
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj13 = (Class7)(object)class11.j(bindingFlags_11, null, ref object_3, (ParameterModifier[])(object)class15.j(bindingFlags, array3, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out reference), (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				BindingFlags bindingFlags_14 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = array;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)obj9.e((BindingFlags)obj13.W(bindingFlags_14, propertyInfo_4, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_), array2, parameterModifier_), array3, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				BindingFlags bindingFlags_15 = bindingFlags;
				MethodBase[] methodBase_6 = (MethodBase[])(object)@class.W(bindingFlags, array, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, parameterModifier_), null, null);
				Class7 class16 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
				Class7 class17 = @class;
				BindingFlags bindingFlags_17 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array;
				Class7 class18 = @class;
				bindingFlags = default(BindingFlags);
				class7 = (Class0)(object)((Class7)(object)((Class7)null).j(bindingFlags_15, methodBase_6, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)class16.e(bindingFlags_16, methodBase_7, (Type[])(object)class17.W(bindingFlags_17, propertyInfo_5, type_, array2, (ParameterModifier[])(object)class18.t(bindingFlags, fieldInfo_, Class5.Default, null)), parameterModifier_), array4, out reference)).W(bindingFlags, array, type_, array2, null);
			}
			else
			{
				qk = qk;
				qk = qk;
			}
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)@class.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo)) == 0)
			{
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class19.W(bindingFlags, array, (Type)(object)Class5.Default, array2, parameterModifier_);
				class7 = class7;
				qk = (Qk7)(object)Class5.Default;
			}
			_ = (Class8)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class9)(object)Class5.Default;
		}
		else
		{
			_ = (Class8)(object)@class.t((BindingFlags)@class.t((BindingFlags)Class5.Default, fieldInfo_, null, null), fieldInfo_, null, null);
		}
		_ = (Class5)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])((Class7)(object)@class.t(bindingFlags, null, obj2, cultureInfo)).t(Class5.Default, null, (CultureInfo)@class.t(obj2, type_, cultureInfo)), null, parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class21);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					class7 = class7;
					class3 = class3;
					_ = (Qk7)(object)Class5.Default;
					Class7 class20 = @class;
					bindingFlags = default(BindingFlags);
					Class6 obj15 = (Class6)(object)((Class7)(object)class20.t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_))).e((BindingFlags)Class5.Default, array3, array2, null);
					class21 = class21;
					class21 = obj15;
				}
				while (obj2 != null);
			}
			else
			{
				Class7 class22 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class22.j(bindingFlags, null, ref *(object[]*)@class.e((BindingFlags)@class.t(obj2, null, cultureInfo), array3, array2, null), parameterModifier_, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array3, array2, parameterModifier_), out *(object*)null);
			}
		}
		finally
		{
			try
			{
				if ((UIntPtr)@class.t(default(BindingFlags), fieldInfo_, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)((Class7)(object)Class5.Default).t(obj2, type_, null);
				}
				else
				{
					class8 = (Class4)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo);
			}
			goto IL_0a85;
		}
		IL_11cd:
		GClass2 gClass2;
		if ((UIntPtr)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array3, ref object_, parameterModifier_, null, array4, out reference) == (UIntPtr)(nuint)0u)
		{
			do
			{
				gClass2 = null;
				gClass2 = gClass2;
			}
			while (obj2 != null);
		}
		class3 = class3;
		_ = (Struct1)Class5.Default;
		_ = (Class10)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, null, null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array2, null);
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class2)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo);
				}
				catch
				{
					gClass = gClass;
				}
			}
		}
		else
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					_ = (GClass0)@class.t(obj2, type_, null);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class0)(object)Class5.Default;
		}
		else
		{
			try
			{
				try
				{
					Class7 class23 = @class;
					Class7 class24 = @class;
					BindingFlags bindingFlags_18 = bindingFlags;
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj18 = (Class7)(object)class24.t(bindingFlags_18, fieldInfo_, class25.e(bindingFlags, null, array2, null), cultureInfo);
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_19 = (BindingFlags)class26.j(bindingFlags, array3, ref object_, parameterModifier_, null, array4, out *(object*)null);
					MethodBase[] methodBase_8 = (MethodBase[])(object)((Class7)((Class7)null).t(obj2, type_, cultureInfo)).t(bindingFlags, null, obj2, cultureInfo);
					CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_20 = bindingFlags;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					class8 = (Class4)class23.t(null, type_, (CultureInfo)(object)obj18.j(bindingFlags_19, methodBase_8, ref object_, null, cultureInfo_3, (string[])(object)((Class7)null).e(bindingFlags_20, (MethodBase[])null, array2, (ParameterModifier[])(object)class27.W(bindingFlags, null, type_, null, parameterModifier_)), out reference));
				}
				finally
				{
					gClass3 = gClass3;
					goto end_IL_12b5;
				}
				end_IL_12b5:;
			}
			catch
			{
				do
				{
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class28.j(bindingFlags, array3, ref object_, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type_, (Type[])null, (ParameterModifier[])null), cultureInfo, array4, out *(object*)null);
				}
				while ((object)Class5.Default != null);
			}
		}
		BindingFlags bindingFlags_21 = bindingFlags;
		Class7 class29 = @class;
		BindingFlags bindingFlags_22 = bindingFlags;
		Class7 obj20 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_23 = bindingFlags;
		MethodBase[] methodBase_9 = array3;
		Class7 class30 = @class;
		BindingFlags bindingFlags_24 = bindingFlags;
		Class7 obj21 = (Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)((Class7)null).t((object)null, type_, cultureInfo), null, cultureInfo, array4, out *(object*)Class5.Default);
		Class7 class31 = @class;
		BindingFlags bindingFlags_25 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = array;
		Class7 class32 = @class;
		PropertyInfo[] propertyInfo_7 = array;
		Class7 class33 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj22 = (Class7)(object)((Class7)null).e((BindingFlags)class32.W(default(BindingFlags), propertyInfo_7, (Type)(object)class33.j(bindingFlags, null, ref object_, parameterModifier_, null, array4, out reference), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out reference)), array3, (Type[])null, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		Class7 obj23 = (Class7)(object)((Class7)null).W(bindingFlags_21, (PropertyInfo[])(object)class29.j(bindingFlags_22, (MethodBase[])(object)obj20.e(bindingFlags_23, methodBase_9, (Type[])(object)class30.j(bindingFlags_24, null, ref *(object[]*)obj21.W((BindingFlags)((Class7)null).j((BindingFlags)class31.W(bindingFlags_25, propertyInfo_6, null, (Type[])(object)obj22.W(bindingFlags, array, null, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_), (MethodBase[])null, ref *(object[]*)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, null, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference), null, (Type)(object)Class5.Default, array2, null), parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo), (string[])(object)Class5.Default, out reference), parameterModifier_), ref object_, parameterModifier_, cultureInfo, array4, out reference), type_, array2, parameterModifier_);
		BindingFlags bindingFlags_26 = bindingFlags;
		Class7 obj24 = (Class7)(object)((Class7)((Class7)(object)Class5.Default).t(obj2, null, null)).t(bindingFlags, fieldInfo_, obj2, cultureInfo);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_27 = bindingFlags;
		MethodBase[] methodBase_10 = (MethodBase[])(object)Class5.Default;
		Class7 class34 = @class;
		BindingFlags bindingFlags_28 = bindingFlags;
		Class7 class35 = @class;
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_11 = (MethodBase[])(object)obj24.j(bindingFlags_27, methodBase_10, ref *(object[]*)class34.W(bindingFlags_28, (PropertyInfo[])(object)class35.W(bindingFlags, null, null, null, null), (Type)(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, null), array2, parameterModifier_), null, cultureInfo, array4, out *(object*)Class5.Default);
		Class7 class36 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_29 = bindingFlags;
		PropertyInfo[] propertyInfo_8 = array;
		Class7 obj25 = (Class7)(object)@class.j(bindingFlags, null, ref object_, null, null, (string[])(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, null, parameterModifier_), out *(object*)Class5.Default);
		BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)obj23.e(bindingFlags_26, methodBase_11, (Type[])(object)class36.W(bindingFlags_29, propertyInfo_8, (Type)(object)obj25.j(bindingFlags_30, null, ref object_, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_), (string[])(object)Class5.Default, out *(object*)Class5.Default), null, parameterModifier_), parameterModifier_)) + unchecked((nuint)(UIntPtr)((Class7)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array3, array2, parameterModifier_))).e((BindingFlags)Class5.Default, array3, null, parameterModifier_))) == 0 && (UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)@class.t(bindingFlags, fieldInfo_, obj2, (CultureInfo)((Class7)(object)Class5.Default).t(null, type_, cultureInfo)), parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			Class7 obj26 = (Class7)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, ((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, cultureInfo), (CultureInfo)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, type_, (Type[])(object)Class5.Default, parameterModifier_)), ref *(object[]*)null, parameterModifier_, null, array4, out *(object*)null);
			BindingFlags bindingFlags_31 = bindingFlags;
			MethodBase[] methodBase_12 = (MethodBase[])@class.t(obj2, type_, null);
			ref object[] object_4 = ref *(object[]*)Class5.Default;
			CultureInfo cultureInfo_4 = cultureInfo;
			Class7 class37 = @class;
			bindingFlags = default(BindingFlags);
			class9 = (Class10)(object)obj26.j(bindingFlags_31, methodBase_12, ref object_4, parameterModifier_, cultureInfo_4, (string[])(object)class37.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, null, null), null, (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_, null, null)), out *(object*)Class5.Default);
		}
		if (checked((unchecked((nuint)(UIntPtr)Class5.Default) - (uIntPtr - unchecked((nuint)default(UIntPtr)))) * unchecked((nuint)(UIntPtr)((Class7)null).t(obj2, (Type)null, cultureInfo) / unchecked((nuint)default(UIntPtr)))) / (nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(null, (Type)(object)@class.t(bindingFlags, null, Class5.Default, null), cultureInfo), type_, (Type[])null, (ParameterModifier[])null) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (Class0)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				_ = (Struct1)((Class7)null).W(bindingFlags, array, (Type)(object)@class.e(bindingFlags, null, array2, parameterModifier_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.W(bindingFlags, array, type_, (Type[])(object)((Class7)null).W(bindingFlags, array, type_, array2, (ParameterModifier[])null), parameterModifier_), (MethodBase[])(object)@class.j(bindingFlags, array3, ref object_, parameterModifier_, cultureInfo, array4, out *(object*)null), null, (ParameterModifier[])(object)Class5.Default));
				_ = (GClass1)(object)Class5.Default;
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				class8 = (Class4)(object)Class5.Default;
			}
		}
		while (obj2 != null);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_);
				}
				else
				{
					@class = null;
				}
			}
			else
			{
				try
				{
					gClass = (GClass1)(object)@class.e(bindingFlags, array3, array2, null);
					_ = (Struct1)Class5.Default;
				}
				catch
				{
					class3 = class3;
				}
			}
		}
		_ = (Class2)(object)((Class7)null).e((BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo), array3, array2, parameterModifier_);
		if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					class10 = (Class2)(object)Class5.Default;
					continue;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Class7 class38 = @class;
			PropertyInfo[] propertyInfo_9 = array;
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			GClass0 obj28 = (GClass0)(object)((Class7)(object)class38.W(default(BindingFlags), propertyInfo_9, null, array2, (ParameterModifier[])(object)class39.e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, array3, null, parameterModifier_), (Type[])@class.t(((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo)).e(bindingFlags, array3, array2, null)), parameterModifier_))).t(bindingFlags, null, obj2, cultureInfo), null, cultureInfo), array2, parameterModifier_))).t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, null, (Type[])((Class7)null).t(obj2, (Type)null, cultureInfo), (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, parameterModifier_, (CultureInfo)null, (string[])(object)((Class7)null).W(bindingFlags, array, type_, (Type[])(object)@class.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), parameterModifier_), out reference)).e((BindingFlags)Class5.Default, array3, array2, parameterModifier_)), @class.W(bindingFlags, null, null, array2, parameterModifier_), null);
			gClass4 = gClass4;
			gClass4 = obj28;
		}
		_ = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array2, null), type_, array2, parameterModifier_);
		Class9 class40 = class40;
		try
		{
			while (obj2 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					@class = (Class7)(object)Class5.Default;
					_ = Class5.Default;
					gClass3 = gClass3;
					Class7 obj29 = (Class7)(object)@class.W((BindingFlags)Class5.Default, array, type_, null, null);
					Class7 obj30 = (Class7)@class.t(@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, null, parameterModifier_)).e(bindingFlags, null, null, null), obj2, cultureInfo), (Type)(object)((Class7)null).e(bindingFlags, array3, (Type[])null, parameterModifier_), cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_32 = bindingFlags;
					Class7 class41 = @class;
					Class7 class42 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj29.j((BindingFlags)obj30.t(bindingFlags_32, (FieldInfo[])(object)((Class7)(object)class41.j((BindingFlags)class42.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_), null, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out reference)).t((BindingFlags)Class5.Default, null, obj2, null), obj2, null), null, ref object_, null, null, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, null), out reference);
				}
			}
		}
		catch
		{
			Class7 obj31 = (Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array3, array2, parameterModifier_), ref *(object[]*)null, null, cultureInfo, array4, out reference);
			bindingFlags = default(BindingFlags);
			class8 = (Class4)(object)obj31.W(bindingFlags, null, type_, array2, null);
			_ = (Class7)(object)Class5.Default;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while ((object)((Class7)(object)Class5.Default).W(bindingFlags, array, (Type)(object)Class5.Default, null, null) != null);
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)((Class7)null).j(bindingFlags, array3, ref object_, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array3, array2, parameterModifier_), (CultureInfo)@class.t(obj2, type_, cultureInfo), array4, out reference);
				}
			}
		}
		try
		{
			do
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 class43 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)((Class7)null).t(bindingFlags_33, (FieldInfo[])(object)class43.t(bindingFlags_34, (FieldInfo[])class44.t(obj2, (Type)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(obj2, type_, cultureInfo), array2, (ParameterModifier[])null)).t(bindingFlags, fieldInfo_, null, null), (CultureInfo)(object)Class5.Default), ((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, (CultureInfo)null), null), obj2, (CultureInfo)(object)Class5.Default);
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class3 = class3;
				}
				catch
				{
					Class7 obj34 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj34.t(bindingFlags, null, @class.t(null, type_, (CultureInfo)(object)((Class7)(object)((Class7)null).e((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo), array3, array2, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array3, array2, parameterModifier_)), (CultureInfo)(object)Class5.Default);
					_ = (Struct2)Class5.Default;
					Class7 class45 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					MethodBase[] methodBase_13 = array3;
					Class7 class46 = @class;
					BindingFlags bindingFlags_36 = (BindingFlags)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj2, null);
					Class7 obj35 = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = bindingFlags;
					MethodBase[] methodBase_14 = array3;
					Class7 class47 = @class;
					BindingFlags bindingFlags_38 = (BindingFlags)((Class7)null).e((BindingFlags)((Class7)@class.t(obj2, type_, cultureInfo)).j(bindingFlags, array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out *(object*)@class.e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_)), array3, array2, parameterModifier_);
					PropertyInfo[] propertyInfo_10 = array;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class45.j(bindingFlags_35, methodBase_13, ref *(object[]*)class46.e(bindingFlags_36, (MethodBase[])(object)obj35.j(bindingFlags_37, methodBase_14, ref *(object[]*)((Class7)((Class7)(object)class47.W(bindingFlags_38, propertyInfo_10, type_, (Type[])(object)((Class7)null).W(bindingFlags, array, type_, (Type[])null, parameterModifier_), null)).t(null, (Type)(object)@class.j((BindingFlags)Class5.Default, array3, ref object_, parameterModifier_, null, null, out reference), cultureInfo)).t(obj2, (Type)(object)Class5.Default, cultureInfo), parameterModifier_, null, null, out *(object*)Class5.Default), array2, parameterModifier_), null, (CultureInfo)(object)Class5.Default, null, out reference);
					_ = (_003CModule_003E)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, array2, parameterModifier_);
				}
			}
			else
			{
				class8 = class8;
			}
		}
		_ = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_);
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, array4, out *(object*)null))) == 0)
		{
			Class7 obj38;
			BindingFlags bindingFlags_39;
			PropertyInfo[] propertyInfo_11;
			Class7 class48;
			BindingFlags bindingFlags_40;
			do
			{
				UIntPtr num6 = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)num6) * uIntPtr) != 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					class21 = class21;
				}
				obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				bindingFlags_39 = bindingFlags;
				propertyInfo_11 = array;
				class48 = @class;
				bindingFlags_40 = (BindingFlags)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj38.W(bindingFlags_39, propertyInfo_11, type_, array2, (ParameterModifier[])(object)class48.e(bindingFlags_40, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default), array2, parameterModifier_)) != null);
		}
		else
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					class7 = class7;
				}
			}
		}
		if ((nuint)(UIntPtr)@class.W(bindingFlags, null, type_, array2, parameterModifier_) / uIntPtr == 0)
		{
			do
			{
				class8 = class8;
			}
			while (obj2 != null);
		}
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			@struct = default(Struct1);
			class3 = class3;
		}
		else
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)@class.t(Class5.Default, type_, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (Class4)(object)((Class7)null).j((BindingFlags)((Class7)null).j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array4, out *(object*)null), array3, ref object_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null), cultureInfo, (string[])null, out reference);
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (Class4)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					goto end_IL_226d;
				}
				end_IL_226d:;
			}
			catch
			{
				@class = null;
			}
		}
		while (obj2 != null);
		Struct2 struct2 = struct2;
		_ = (Class2)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, array3, array2, null), ref object_, null, null, array4, out *(object*)((Class7)@class.t(((Class7)(object)Class5.Default).j(bindingFlags, array3, ref object_, parameterModifier_, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(obj2, null, null)), type_, null)).e(bindingFlags, array3, array2, null));
		gClass = null;
		try
		{
			while ((object)Class5.Default != null)
			{
				class10 = (Class2)(object)Class5.Default;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0)
			{
				do
				{
					gClass = gClass;
				}
				while ((object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(null, type_, null), fieldInfo_, null, null) != null);
			}
			else
			{
				do
				{
					class8 = class8;
				}
				while (obj2 != null);
			}
			goto IL_260a;
		}
		IL_3a64:
		try
		{
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass3)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default);
					class7 = (Class0)(object)Class5.Default;
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj42 = (Class7)(object)class49.e(bindingFlags, array3, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 obj43 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj42.t(bindingFlags_41, fieldInfo_, obj43.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, null, array4, out reference), null);
					gClass3 = gClass3;
					goto end_IL_3a6a;
				}
			}
			end_IL_3a6a:;
		}
		if (uIntPtr == 0)
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
		}
		else if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, null) == (UIntPtr)(nuint)0u)
		{
			do
			{
				qk = qk;
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			qk = null;
		}
		class7 = (Class0)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)null);
		do
		{
			try
			{
				while (obj2 != null)
				{
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class50.e(bindingFlags, null, null, parameterModifier_);
				}
			}
			finally
			{
				while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, parameterModifier_) != null)
				{
					gClass = gClass;
					class10 = null;
					_ = (Class2)@class.t(Class5.Default, null, null);
					_ = (GClass0)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj2 != null);
		UIntPtr num7 = (UIntPtr)Class5.Default;
		Class7 class51 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)num7) + unchecked((nuint)(UIntPtr)class51.j(bindingFlags, array3, ref object_, parameterModifier_, null, array4, out reference)) == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				try
				{
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					class10 = (Class2)((Class7)null).t((object)class52.j(bindingFlags, array3, ref object_, null, cultureInfo, array4, out reference), (Type)null, (CultureInfo)null);
				}
				finally
				{
					class9 = null;
					@class = @class;
					goto end_IL_3c5f;
				}
				end_IL_3c5f:;
			}
			catch
			{
				while (obj2 != null)
				{
					class40 = (Class9)(object)Class5.Default;
					_ = (_003CModule_003E)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])@class.t(obj2, null, cultureInfo), (Type)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)null), null, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		class21 = (Class6)(object)Class5.Default;
		struct2 = struct2;
		_ = (Class8)(object)Class5.Default;
		try
		{
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					Class7 class53 = @class;
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)class53.W(bindingFlags, null, (Type)(object)Class5.Default, null, null);
				}
				catch
				{
					gClass2 = gClass2;
					gClass2 = gClass2;
				}
			}
		}
		do
		{
			struct2 = default(Struct2);
			class21 = class21;
		}
		while (@class.t(obj2, type_, cultureInfo) != null);
		do
		{
			try
			{
				_ = (Class2)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default);
			}
			catch
			{
				_ = (Qk7)(object)@class.t(bindingFlags, null, null, cultureInfo);
			}
			finally
			{
				Class7 obj49 = (Class7)(object)Class5.Default;
				Class7 class54 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)obj49.t(default(BindingFlags), fieldInfo_, class54.e(bindingFlags, array3, array2, null), cultureInfo);
				continue;
			}
		}
		while (obj2 != null);
		return;
		IL_3874:
		try
		{
			_ = (GClass2)(object)Class5.Default;
			_003CModule_003E = null;
			_ = (GClass2)(object)Class5.Default;
		}
		catch
		{
			try
			{
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class55.j(bindingFlags, array3, ref *(object[]*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), null, (CultureInfo)(object)Class5.Default, null, out *(object*)@class.t(obj2, null, null));
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				goto end_IL_3890;
			}
			end_IL_3890:;
		}
		UIntPtr num8 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num8) + uIntPtr == 0)
			{
				struct2 = default(Struct2);
			}
			else
			{
				class7 = class7;
			}
		}
		struct2 = (Struct2)((Class7)null).e((BindingFlags)((Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)null)).t(@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), type_, null), array3, (Type[])null, (ParameterModifier[])null);
		try
		{
			if ((UIntPtr)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out *(object*)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, @class.W((BindingFlags)@class.t(null, type_, null), array, type_, (Type[])@class.t(obj2, type_, (CultureInfo)(object)Class5.Default), null), null), null, null, null, parameterModifier_)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					_ = (Class7)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, cultureInfo, array4, out reference);
				}
			}
		}
		finally
		{
			do
			{
				if (uIntPtr != 0)
				{
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class56.e(bindingFlags, array3, null, null);
				}
				else
				{
					qk = null;
				}
			}
			while (obj2 != null);
			goto IL_3a64;
		}
		IL_3739:
		try
		{
			Class7 obj53;
			do
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				catch
				{
					_ = (Class5)(object)@class.t((BindingFlags)Class5.Default, null, obj2, null);
				}
				bindingFlags = default(BindingFlags);
				obj53 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(null, (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), cultureInfo), type_, array2, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj53.t(bindingFlags, null, obj2, cultureInfo) != null);
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					class3 = Class5.Default;
					struct2 = struct2;
					Class7 obj54 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_42 = bindingFlags;
					PropertyInfo[] propertyInfo_12 = array;
					BindingFlags bindingFlags_43 = bindingFlags;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj54.W(bindingFlags_42, propertyInfo_12, (Type)(object)((Class7)null).t(bindingFlags_43, (FieldInfo[])(object)class57.W(bindingFlags, array, type_, null, (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default)), obj2, (CultureInfo)null), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj2 != null);
				goto IL_3874;
			}
		}
		IL_260a:
		while (obj2 != null)
		{
			Class7 class58 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_44 = bindingFlags;
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_15 = (MethodBase[])(object)Class5.Default;
			CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)null).W(bindingFlags, array, (Type)((Class7)null).t(obj2, (Type)null, cultureInfo), array2, parameterModifier_);
			string[] string_2 = (string[])(object)@class.e(bindingFlags, array3, array2, (ParameterModifier[])(object)Class5.Default);
			Class7 obj55 = (Class7)((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)Class5.Default);
			Class7 obj56 = (Class7)(object)Class5.Default;
			Class7 class59 = @class;
			bindingFlags = default(BindingFlags);
			FieldInfo[] fieldInfo_2 = (FieldInfo[])obj56.t(class59.j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)((Class7)(object)@class.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, array4, out reference)).W(bindingFlags, array, type_, null, (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default)), array4, out *(object*)null), type_, cultureInfo);
			Class7 class60 = @class;
			BindingFlags bindingFlags_46 = bindingFlags;
			PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)Class5.Default;
			Class7 class61 = @class;
			PropertyInfo[] propertyInfo_14 = array;
			Class7 obj57 = (Class7)(object)Class5.Default;
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj58 = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags_45, methodBase_15, ref object_, parameterModifier_, cultureInfo_5, string_2, out *(object*)obj55.t(default(BindingFlags), fieldInfo_2, null, (CultureInfo)(object)class60.t((BindingFlags)((Class7)null).W(bindingFlags_46, propertyInfo_13, type_, array2, (ParameterModifier[])(object)class61.W(default(BindingFlags), propertyInfo_14, type_, null, (ParameterModifier[])obj57.t(obj2, null, (CultureInfo)(object)class62.j(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array3, array2, parameterModifier_), (MethodBase[])((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)((Class7)@class.t(obj2, type_, cultureInfo)).t(obj2, (Type)(object)Class5.Default, cultureInfo)), array2, parameterModifier_), ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference)))), fieldInfo_, null, (CultureInfo)(object)@class.e(bindingFlags, array3, array2, parameterModifier_))))).e(bindingFlags, array3, null, null);
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)((Class7)(object)class58.e(bindingFlags_44, (MethodBase[])(object)obj58.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (Type[])(object)Class5.Default, parameterModifier_)).t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default);
		}
		try
		{
			_ = (GClass1)@class.t(Class5.Default, type_, cultureInfo);
		}
		catch
		{
			do
			{
				_ = (Class10)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, array2, parameterModifier_), null, (ParameterModifier[])(object)Class5.Default);
			}
			while (obj2 != null);
		}
		nuint num9 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num9 - uIntPtr) / checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
		{
			_ = (GClass0)(object)Class5.Default;
			gClass4 = null;
		}
		try
		{
			_ = Class5.Default;
		}
		finally
		{
			do
			{
				try
				{
					Class7 obj60 = (Class7)(object)@class.j(bindingFlags, null, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)((Class7)null).t(((Class7)null).t((object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array4, out *(object*)null), (Type)null, cultureInfo), type_, cultureInfo));
					bindingFlags = default(BindingFlags);
					Class7 obj61 = (Class7)(object)obj60.e(bindingFlags, array3, (Type[])@class.t(null, type_, cultureInfo), parameterModifier_);
					BindingFlags bindingFlags_47 = bindingFlags;
					MethodBase[] methodBase_16 = array3;
					string[] string_3 = array4;
					Class7 class63 = @class;
					Class7 class64 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj61.j(bindingFlags_47, methodBase_16, ref object_, parameterModifier_, null, string_3, out *(object*)class63.j((BindingFlags)class64.W(bindingFlags, array, (Type)((Class7)null).t(obj2, type_, cultureInfo), array2, parameterModifier_), array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo), out *(object*)null));
				}
				catch
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
			while (obj2 != null);
			goto IL_27b4;
		}
		IL_326d:
		while ((object)Class5.Default != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass = (GClass1)(object)@class.t(bindingFlags, null, null, cultureInfo);
			}
			else
			{
				_ = (Struct1)Class5.Default;
			}
		}
		Class7 class65 = @class;
		BindingFlags bindingFlags_48 = bindingFlags;
		MethodBase[] methodBase_17 = array3;
		bindingFlags = default(BindingFlags);
		@class = (Class7)(object)class65.j(bindingFlags_48, methodBase_17, ref object_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default), cultureInfo, array4, out *(object*)null);
		_ = (Qk7)(object)Class5.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)@class.j(bindingFlags, null, ref object_, null, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					_ = (GClass3)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					class40 = class40;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_15 = (PropertyInfo[])(object)class66.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array3, array2, (ParameterModifier[])null), ref object_, parameterModifier_, cultureInfo, array4, out *(object*)Class5.Default), array3, ref *(object[]*)null, parameterModifier_, null, array4, out reference);
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					@struct = (Struct1)((Class7)null).W(default(BindingFlags), propertyInfo_15, (Type)null, (Type[])(object)class67.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, null, cultureInfo, null, out *(object*)((Class7)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, obj2, null)).W(bindingFlags, array, null, (Type[])(object)((Class7)@class.t(Class5.Default, null, null)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, null), parameterModifier_)), parameterModifier_);
				}
			}
		}
		_ = (Class10)@class.t(null, type_, cultureInfo);
		try
		{
			Class7 class68;
			BindingFlags bindingFlags_49;
			PropertyInfo[] propertyInfo_16;
			Class7 class69;
			BindingFlags bindingFlags_50;
			Class7 obj65;
			BindingFlags bindingFlags_51;
			Class7 class70;
			BindingFlags bindingFlags_52;
			Class7 class71;
			do
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_) != (UIntPtr)(nuint)0u)
				{
					@struct = (Struct1)Class5.Default;
				}
				else
				{
					gClass = (GClass1)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, parameterModifier_, null, array4, out reference);
				}
				class68 = @class;
				bindingFlags_49 = (BindingFlags)((Class7)null).e(bindingFlags, array3, (Type[])(object)@class.W(bindingFlags, array, type_, array2, parameterModifier_), (ParameterModifier[])null);
				propertyInfo_16 = (PropertyInfo[])(object)Class5.Default;
				class69 = @class;
				bindingFlags_50 = bindingFlags;
				obj65 = (Class7)(object)((Class7)@class.t(null, null, cultureInfo)).e(bindingFlags, array3, array2, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				bindingFlags_51 = bindingFlags;
				class70 = @class;
				bindingFlags_52 = bindingFlags;
				class71 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class68.W(bindingFlags_49, propertyInfo_16, (Type)(object)class69.t(bindingFlags_50, fieldInfo_, obj2, (CultureInfo)(object)obj65.W(bindingFlags_51, (PropertyInfo[])(object)class70.t(bindingFlags_52, null, obj2, (CultureInfo)(object)class71.t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo)), type_, null, null)), array2, (ParameterModifier[])(object)Class5.Default) != null);
		}
		finally
		{
			try
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					gClass2 = null;
					goto end_IL_3572;
				}
				end_IL_3572:;
			}
			catch
			{
				nuint num10 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num10 + uIntPtr) == 0)
				{
					Class7 obj66 = (Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, parameterModifier_, null, (string[])(object)Class5.Default, out reference);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj66.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, array4, out reference);
				}
				else
				{
					class3 = class3;
				}
			}
			goto IL_35d7;
		}
		IL_2d96:
		while (obj2 != null)
		{
			try
			{
				checked
				{
					nuint num11 = uIntPtr + uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num11 * uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
			}
			finally
			{
				while (true)
				{
					Class7 class72 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)class72.t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)((Class7)null).j(bindingFlags, array3, ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])((Class7)((Class7)null).t(obj2, (Type)null, (CultureInfo)null)).t(obj2, type_, null), out *(object*)Class5.Default)) != null)
					{
						class8 = (Class4)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, (object)null, cultureInfo);
						continue;
					}
					break;
				}
				continue;
			}
		}
		do
		{
			try
			{
			}
			catch
			{
				try
				{
					gClass3 = null;
				}
				catch
				{
					_ = (Class9)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
					@class = (Class7)(object)Class5.Default;
					class40 = class40;
					gClass = null;
				}
			}
		}
		while (obj2 != null);
		if (uIntPtr == 0)
		{
			do
			{
				nuint num12 = uIntPtr;
				Class7 class73 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num13 = (UIntPtr)class73.W(bindingFlags, null, type_, null, parameterModifier_);
				nuint num14 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (num12 + unchecked((nuint)num13 / checked(num14 + uIntPtr + uIntPtr)) == 0)
					{
						class9 = (Class10)@class.t(obj2, type_, (CultureInfo)(object)Class5.Default);
					}
				}
			}
			while (obj2 != null);
		}
		if ((UIntPtr)((Class7)null).t((object)Class5.Default, type_, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			UIntPtr num15 = uIntPtr;
			UIntPtr num16 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num15) - unchecked((nuint)num16 / uIntPtr)) == 0)
			{
				if (uIntPtr == 0)
				{
					Class7 obj70 = (Class7)(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, null, parameterModifier_);
					BindingFlags bindingFlags_53 = (BindingFlags)@class.t(obj2, type_, (CultureInfo)((Class7)(object)Class5.Default).t(((Class7)null).t(bindingFlags, fieldInfo_, (object)@class.e(bindingFlags, (MethodBase[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), array2, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, null, Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.W((BindingFlags)((Class7)null).t(obj2, type_, (CultureInfo)null), null, type_, array2, parameterModifier_), array4, out reference))), (CultureInfo)null), (Type)(object)((Class7)null).W(bindingFlags, array, type_, (Type[])(object)Class5.Default, (ParameterModifier[])null), cultureInfo));
					FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
					Class7 class74 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
					Class7 class75 = @class;
					bindingFlags = default(BindingFlags);
					@class = (Class7)(object)obj70.t(bindingFlags_53, fieldInfo_3, ((Class7)(object)class74.e(bindingFlags_54, methodBase_18, (Type[])(object)class75.j(bindingFlags, array3, ref object_, null, cultureInfo, array4, out *(object*)null), parameterModifier_)).j(bindingFlags, array3, ref object_, parameterModifier_, null, array4, out reference), cultureInfo);
				}
			}
			else
			{
				try
				{
					class9 = class9;
				}
				catch
				{
					gClass4 = gClass4;
				}
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					_ = Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		nuint num17 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num17 * uIntPtr) == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					gClass3 = gClass3;
				}
			}
			else
			{
				_ = (Class6)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])((Class7)null).t(obj2, type_, cultureInfo));
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				class9 = class9;
			}
		}
		catch
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			finally
			{
				_ = (Class10)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out reference);
				goto end_IL_3075;
			}
			end_IL_3075:;
		}
		_ = (Qk7)(object)((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, array2, parameterModifier_);
		_ = (Qk7)(object)Class5.Default;
		_ = (Struct2)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, array, type_, array2, parameterModifier_), (object)null, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null);
		class21 = (Class6)(object)Class5.Default;
		_ = (Class0)(object)Class5.Default;
		checked
		{
			if (unchecked(uIntPtr / (nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
			{
				do
				{
					_ = (Class4)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
				}
				while ((object)Class5.Default != null || obj2 != null);
			}
		}
		do
		{
			_ = (Class9)((Class7)(object)@class.W(bindingFlags, array, null, array2, parameterModifier_)).t(obj2, type_, cultureInfo);
			_ = (GClass0)(object)@class.j(bindingFlags, array3, ref object_, parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), null, out *(object*)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo));
		}
		while (obj2 != null);
		class7 = class7;
		class40 = class40;
		_ = (Qk7)(object)Class5.Default;
		_ = (GClass2)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class40 = class40;
				}
			}
			else
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			class3 = class3;
			goto IL_326d;
		}
		IL_35d7:
		_ = (Class10)(object)Class5.Default;
		if (checked(uIntPtr + unchecked((nuint)default(UIntPtr))) == 0)
		{
			do
			{
				_ = (Class7)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass = gClass;
			}
			catch
			{
				BindingFlags bindingFlags_55 = bindingFlags;
				Class7 class76 = @class;
				Class7 obj74 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_56 = (BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)null);
				Class7 class77 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)null).j(bindingFlags_55, (MethodBase[])(object)class76.W((BindingFlags)obj74.t(bindingFlags_56, fieldInfo_, class77.W((BindingFlags)((Class7)null).W(bindingFlags, array, (Type)null, array2, (ParameterModifier[])null), array, type_, null, parameterModifier_), (CultureInfo)(object)((Class7)null).W(bindingFlags, array, type_, (Type[])(object)Class5.Default, parameterModifier_)), array, type_, (Type[])(object)Class5.Default, parameterModifier_), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])null, out *(object*)Class5.Default);
			}
		}
		try
		{
			class9 = class9;
		}
		finally
		{
			try
			{
				Class7 class78 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num18 = (UIntPtr)class78.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, (string[])(object)@class.e(bindingFlags, array3, array2, parameterModifier_), out reference);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num18) * uIntPtr + uIntPtr == 0)
					{
						class7 = null;
						gClass = gClass;
					}
					else
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
			}
			catch
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj2 != null);
			}
			goto IL_3739;
		}
		IL_27b4:
		Class7 obj77 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj78 = (Class7)(object)obj77.e(bindingFlags, array3, array2, null);
		BindingFlags bindingFlags_57 = bindingFlags;
		ref object[] object_5 = ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, cultureInfo);
		CultureInfo cultureInfo_6 = cultureInfo;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj78.j(bindingFlags_57, null, ref object_5, null, cultureInfo_6, (string[])(object)((Class7)null).e(bindingFlags, array3, array2, parameterModifier_), out reference) == (UIntPtr)(nuint)0u)
		{
			_ = (Qk7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), cultureInfo);
		}
		else
		{
			_ = (Class7)(object)@class.e(bindingFlags, null, (Type[])(object)@class.j(bindingFlags, null, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)@class.e((BindingFlags)@class.t(obj2, null, cultureInfo), null, null, parameterModifier_), out reference), null);
		}
		_ = (Class6)(object)Class5.Default;
		_ = (GClass0)(object)Class5.Default;
		class3 = Class5.Default;
		gClass2 = (GClass2)(object)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		qk = null;
		gClass4 = gClass4;
		while (obj2 != null)
		{
			Class7 obj79 = (Class7)(object)@class.e((BindingFlags)Class5.Default, null, null, null);
			BindingFlags bindingFlags_58 = bindingFlags;
			MethodBase[] methodBase_19 = array3;
			CultureInfo cultureInfo_7 = cultureInfo;
			Class7 obj80 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj79.j(bindingFlags_58, methodBase_19, ref object_, parameterModifier_, cultureInfo_7, (string[])(object)obj80.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_), out reference) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class79 = @class;
					BindingFlags bindingFlags_59 = bindingFlags;
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_20 = (MethodBase[])(object)class80.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					Class7 obj81 = (Class7)(object)((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, array2, parameterModifier_);
					BindingFlags bindingFlags_60 = bindingFlags;
					MethodBase[] methodBase_21 = (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array, type_, array2, parameterModifier_), array2, parameterModifier_);
					ref object[] object_6 = ref *(object[]*)Class5.Default;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_8 = (CultureInfo)(object)obj81.j(bindingFlags_60, methodBase_21, ref object_6, null, null, null, out *(object*)class81.W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_));
					string[] string_4 = array4;
					object object_7 = @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_);
					BindingFlags bindingFlags_61 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_17 = (PropertyInfo[])((Class7)(object)Class5.Default).t(Class5.Default, type_, (CultureInfo)@class.t(Class5.Default, type_, cultureInfo));
					Class7 class82 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_62 = bindingFlags;
					BindingFlags bindingFlags_63 = (BindingFlags)Class5.Default;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)((Class7)(object)class79.j(bindingFlags_59, methodBase_20, ref object_, parameterModifier_, cultureInfo_8, string_4, out *(object*)((Class7)null).t(object_7, type_, (CultureInfo)(object)((Class7)null).W(bindingFlags_61, propertyInfo_17, (Type)null, (Type[])(object)class82.W(bindingFlags_62, (PropertyInfo[])(object)((Class7)(object)((Class7)null).e(bindingFlags_63, (MethodBase[])(object)class83.W(bindingFlags, array, type_, (Type[])(object)@class.t(bindingFlags, fieldInfo_, null, cultureInfo), parameterModifier_), (Type[])((Class7)null).t(obj2, type_, cultureInfo), (ParameterModifier[])null)).t((BindingFlags)((Class7)null).j(bindingFlags, array3, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out reference), null, obj2, cultureInfo), type_, array2, parameterModifier_), (ParameterModifier[])null)))).t(null, type_, (CultureInfo)(object)Class5.Default);
				}
				catch
				{
					qk = null;
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
					_ = (Class8)(object)Class5.Default;
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
					class40 = null;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 obj84 = (Class7)(object)((Class7)null).j((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo, array4, out reference), array3, ref *(object[]*)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default), parameterModifier_, cultureInfo, (string[])null, out *(object*)@class.e((BindingFlags)Class5.Default, array3, null, parameterModifier_));
					MethodBase[] methodBase_22 = array3;
					CultureInfo cultureInfo_9 = cultureInfo;
					Class7 class84 = @class;
					Class7 class85 = @class;
					Class7 class86 = @class;
					bindingFlags = default(BindingFlags);
					object object_8 = ((Class7)null).W((BindingFlags)class86.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])null);
					Class7 class87 = @class;
					Class7 obj85 = (Class7)(object)@class.W(bindingFlags, array, null, null, parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)obj84.j(default(BindingFlags), methodBase_22, ref object_, null, cultureInfo_9, (string[])(object)class84.e((BindingFlags)class85.t(default(BindingFlags), fieldInfo_, object_8, (CultureInfo)(object)class87.W((BindingFlags)obj85.W(bindingFlags, null, type_, array2, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref object_, (ParameterModifier[])null, cultureInfo, array4, out reference)), (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_)), (MethodBase[])(object)Class5.Default, array2, parameterModifier_), out *(object*)Class5.Default);
				}
				else
				{
					class7 = class7;
				}
				goto IL_2d96;
			}
		}
		goto IL_2d96;
		IL_0a85:
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, array4, out reference);
		try
		{
			Class7 class88 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)((Class7)(object)class88.W(bindingFlags, null, type_, array2, parameterModifier_)).t(bindingFlags, fieldInfo_, obj2, null);
		}
		finally
		{
			@struct = default(Struct1);
			goto IL_0ae7;
		}
		IL_0ae7:
		try
		{
			class3 = null;
		}
		finally
		{
			class21 = class21;
			goto IL_0b33;
		}
		IL_0b33:
		while (obj2 != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class8)((Class7)null).t(obj2, type_, cultureInfo);
				}
				catch
				{
					class8 = class8;
					_ = (Class7)(object)Class5.Default;
					class40 = null;
					class40 = class40;
					gClass = gClass;
				}
			}
			else
			{
				class10 = class10;
			}
		}
		Class7 class89;
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num19 = uIntPtr;
				Class7 obj87 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_64 = bindingFlags;
				Class7 obj88 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((num19 + unchecked((nuint)(UIntPtr)obj87.W(bindingFlags_64, null, null, array2, (ParameterModifier[])(object)obj88.j(bindingFlags, null, ref object_, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, parameterModifier_), cultureInfo, array4, out reference)))) * (unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t(default(BindingFlags), null, Class5.Default, cultureInfo), (Type)null, array2, parameterModifier_))) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					do
					{
						_ = (Class0)@class.t(obj2, null, cultureInfo);
					}
					while ((object)Class5.Default != null);
				}
			}
			catch
			{
				@struct = default(Struct1);
			}
			class89 = @class;
			bindingFlags = default(BindingFlags);
		}
		class21 = (Class6)(object)class89.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo, array4, out *(object*)null);
		do
		{
			_ = (Class8)(object)Class5.Default;
		}
		while ((object)Class5.Default != null);
		if (uIntPtr / uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj2, cultureInfo);
				}
			}
			else
			{
				struct2 = default(Struct2);
			}
		}
		else
		{
			do
			{
				_ = Class5.Default;
			}
			while ((object)@class.e(default(BindingFlags), array3, array2, parameterModifier_) != null);
		}
		Class7 class90 = @class;
		BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
		Class7 obj90 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)class90.j(bindingFlags_65, null, ref *(object[]*)obj90.j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), out *(object*)null), null, null, array4, out reference);
		try
		{
			class9 = class9;
			_003CModule_003E = _003CModule_003E;
			_ = (Class2)(object)Class5.Default;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				Class7 obj91 = (Class7)(object)@class.t((BindingFlags)((Class7)null).e((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(default(BindingFlags), fieldInfo_, null, cultureInfo), parameterModifier_, cultureInfo, null, out *(object*)Class5.Default), array3, (Type[])null, (ParameterModifier[])null), (FieldInfo[])(object)Class5.Default, Class5.Default, null);
				PropertyInfo[] propertyInfo_18 = array;
				Class7 class91 = @class;
				BindingFlags bindingFlags_66 = (BindingFlags)@class.t(null, type_, cultureInfo);
				Class7 obj92 = (Class7)(object)Class5.Default;
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_67 = bindingFlags;
				MethodBase[] methodBase_23 = array3;
				ref object[] object_9 = ref *(object[]*)@class.t(obj2, (Type)(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, array, type_, array2, (ParameterModifier[])(object)Class5.Default)).W((BindingFlags)@class.t(null, null, cultureInfo), array, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, null, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array2, (ParameterModifier[])null), parameterModifier_)), (FieldInfo[])null, (object)null, cultureInfo), cultureInfo);
				Class7 class93 = @class;
				ref object[] object_10 = ref *(object[]*)Class5.Default;
				CultureInfo cultureInfo_10 = (CultureInfo)(object)Class5.Default;
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_68 = (BindingFlags)((Class7)null).j(bindingFlags_67, methodBase_23, ref object_9, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)class93.j(default(BindingFlags), null, ref object_10, parameterModifier_, cultureInfo_10, (string[])class94.t(((Class7)(object)((Class7)null).j(bindingFlags, array3, ref object_, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out reference)).t(bindingFlags, (FieldInfo[])(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)((Class7)null).j(bindingFlags, array3, ref object_, (ParameterModifier[])null, (CultureInfo)null, array4, out reference), null), obj2, cultureInfo), type_, null), out reference));
				PropertyInfo[] propertyInfo_19 = (PropertyInfo[])(object)Class5.Default;
				Type type_2 = (Type)(object)@class.e((BindingFlags)((Class7)null).j(bindingFlags, array3, ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array4, out *(object*)Class5.Default), (MethodBase[])(object)Class5.Default, null, parameterModifier_);
				Class7 class95 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj91.W(default(BindingFlags), propertyInfo_18, type_, array2, (ParameterModifier[])(object)((Class7)(object)class91.e(bindingFlags_66, (MethodBase[])(object)obj92.j((BindingFlags)((Class7)null).t((object)class92.W(bindingFlags_68, propertyInfo_19, type_2, (Type[])(object)class95.W(bindingFlags, null, type_, array2, null), (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_, obj2, null)), (Type)null, cultureInfo), array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), array2, (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, fieldInfo_, null, cultureInfo)) == (UIntPtr)(nuint)0u)
				{
					Class7 class96 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_69 = bindingFlags;
					MethodBase[] methodBase_24 = array3;
					ref object[] object_11 = ref *(object[]*)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)@class.t((BindingFlags)((Class7)null).t(obj2, type_, (CultureInfo)null), fieldInfo_, obj2, (CultureInfo)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default)));
					CultureInfo cultureInfo_11 = (CultureInfo)(object)Class5.Default;
					Class7 obj93 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class96.j(bindingFlags_69, methodBase_24, ref object_11, parameterModifier_, cultureInfo_11, (string[])(object)obj93.j(bindingFlags, null, ref object_, null, cultureInfo, array4, out *(object*)null), out *(object*)null);
				}
				else
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class7 = class7;
					Class7 obj95 = (Class7)((Class7)null).t((object)null, (Type)null, cultureInfo);
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 class97 = @class;
					BindingFlags bindingFlags_71 = bindingFlags;
					Class7 class98 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj95.t(bindingFlags_70, fieldInfo_, class97.t(bindingFlags_71, (FieldInfo[])(object)class98.e(bindingFlags, array3, array2, null), obj2, cultureInfo), null);
					class9 = class9;
				}
				catch
				{
					_ = (Struct1)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null);
					_ = (Class8)(object)Class5.Default;
					_ = (Class0)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array4, out reference);
					@class = @class;
				}
			}
		}
		else
		{
			class3 = class3;
		}
		try
		{
			try
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				class9 = null;
			}
		}
		qk = qk;
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		catch
		{
			while (obj2 != null)
			{
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					class7 = null;
					class40 = null;
					class3 = class3;
				}
				catch
				{
					@struct = (Struct1)Class5.Default;
				}
			}
			goto IL_11cd;
		}
	}

	unsafe static void smethod_1()
	{
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				obj = null;
				goto IL_01e5;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		try
		{
			@class = @class;
			@class = @class;
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = array;
			PropertyInfo[] propertyInfo_ = array;
			class2 = class2;
			Class7 class3 = class2;
			BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
			Class7 class4 = class2;
			BindingFlags bindingFlags_3 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array;
			type = (Type)(object)Class5.Default;
			array2 = (Type[])(object)class4.W(bindingFlags_3, propertyInfo_2, type, null, null);
			Type[] type_ = array2;
			array3 = array3;
			_ = (Struct1)((Class7)null).W(bindingFlags_, propertyInfo_, (Type)(object)class3.e(bindingFlags_2, null, type_, array3), array2, (ParameterModifier[])(object)Class5.Default);
		}
		finally
		{
			try
			{
				class5 = class5;
				class5 = class5;
			}
			catch
			{
				gClass = gClass;
				gClass = gClass;
				@struct = @struct;
				@struct = default(Struct1);
				Class7 class6 = class2;
				object object_ = obj;
				BindingFlags bindingFlags_4 = bindingFlags;
				array4 = (MethodBase[])(object)Class5.Default;
				Type type_2 = (Type)(object)((Class7)null).e(bindingFlags_4, array4, array2, (ParameterModifier[])null);
				cultureInfo = null;
				_ = (Class9)class6.t(object_, type_2, cultureInfo);
				BindingFlags bindingFlags_5 = (BindingFlags)class2.t(bindingFlags, null, null, null);
				reference = ref reference;
				ref object[] object_2 = ref reference;
				CultureInfo cultureInfo_ = cultureInfo;
				array5 = array5;
				string[] string_ = array5;
				reference2 = ref reference2;
				_ = (Class0)(object)((Class7)null).j(bindingFlags_5, (MethodBase[])null, ref object_2, (ParameterModifier[])null, cultureInfo_, string_, out reference2);
			}
			goto IL_01e5;
		}
		IL_1cd1:
		try
		{
			do
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)class2.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array2, array3), array4, (Type[])(object)Class5.Default, array3);
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class7)(object)Class5.Default;
				}
				while (obj != null);
			}
			goto IL_1d65;
		}
		IL_0c85:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * uIntPtr != 0)
				{
					class7 = class7;
				}
				goto IL_0d4c;
			}
			try
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					struct2 = struct2;
					class8 = class8;
					goto end_IL_0cd1;
				}
				end_IL_0cd1:;
			}
			finally
			{
				try
				{
					class5 = null;
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					qk = qk;
					_ = (Class9)(object)Class5.Default;
					class9 = class9;
					_ = (Struct1)Class5.Default;
					goto IL_0d4c;
				}
			}
		}
		IL_01e5:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Qk7)(object)Class5.Default;
				class2 = null;
			}
		}
		_ = (Class8)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default);
		Class7 class10 = class2;
		BindingFlags bindingFlags_6 = bindingFlags;
		FieldInfo[] array6 = array6;
		_ = (Class8)(object)class10.t(bindingFlags_6, array6, obj, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class11);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class9 obj4 = (Class9)(object)((Class7)null).j((BindingFlags)Class5.Default, array4, ref *(object[]*)null, (ParameterModifier[])(object)class2.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2), cultureInfo, array5, out reference2);
			class11 = class11;
			class11 = obj4;
		}
		else if (uIntPtr == 0)
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				struct2 = (Struct2)((Class7)(object)Class5.Default).t(obj, type, null);
				struct2 = struct2;
				goto IL_030f;
			}
		}
		goto IL_030f;
		IL_2a1c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class13);
		while ((object)Class5.Default != null)
		{
			try
			{
				Class7 class12 = class2;
				bindingFlags = default(BindingFlags);
				UIntPtr num = (UIntPtr)((Class7)null).t((object)class12.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), type, cultureInfo);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) + uIntPtr == 0)
					{
						class9 = class9;
					}
					else
					{
						_ = (Class8)(object)Class5.Default;
					}
				}
			}
			finally
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
					gClass2 = null;
					class13 = null;
					_ = (GClass3)(object)class2.t((BindingFlags)Class5.Default, array6, null, null);
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					continue;
				}
			}
		}
		_ = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					class13 = null;
				}
			}
			finally
			{
				try
				{
					Class7 obj5 = (Class7)(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, null, null, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					class8 = (Class0)(object)obj5.j(bindingFlags, null, ref reference, array3, cultureInfo, null, out reference2);
				}
				finally
				{
					gClass3 = gClass3;
					goto IL_2ad9;
				}
			}
		}
		goto IL_2ad9;
		IL_37bf:
		try
		{
			nuint num2 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num2 + uIntPtr) == 0)
			{
				try
				{
					_ = (_003CModule_003E)class2.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					Class7 class14 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_7 = bindingFlags;
					Class7 class15 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class14.e(bindingFlags_7, (MethodBase[])(object)class15.W(bindingFlags, null, null, array2, array3), null, array3);
				}
				finally
				{
					Class7 obj6 = (Class7)((Class7)(object)Class5.Default).t(null, type, null);
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)(object)obj6.j(bindingFlags, (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2), ref reference, array3, (CultureInfo)((Class7)null).t((object)null, type, cultureInfo), null, out *(object*)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out reference2))).t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo);
					goto end_IL_37c0;
				}
			}
			end_IL_37c0:;
		}
		catch
		{
			do
			{
				try
				{
					class2 = class2;
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		do
		{
			if (uIntPtr == 0)
			{
				Class7 class16 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				Class7 class17 = class2;
				BindingFlags bindingFlags_9 = bindingFlags;
				Class7 obj9 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class2 = (Class7)(object)class16.W(bindingFlags_8, null, null, (Type[])(object)class17.t(bindingFlags_9, null, obj9.W(bindingFlags, array, type, (Type[])(object)Class5.Default, null), cultureInfo), (ParameterModifier[])(object)class2.e(bindingFlags, array4, (Type[])(object)class2.e((BindingFlags)Class5.Default, array4, array2, (ParameterModifier[])(object)Class5.Default), null));
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			try
			{
				class5 = null;
			}
			finally
			{
				Class7 obj10 = (Class7)(object)class2.e(bindingFlags, array4, array2, array3);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)obj10.e(bindingFlags, array4, array2, array3);
				goto IL_3a73;
			}
		}
		goto IL_3a73;
		IL_1a20:
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Class0)(object)class2.t(bindingFlags, null, Class5.Default, null);
					@struct = @struct;
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					gClass2 = (GClass3)(object)Class5.Default;
					class8 = (Class0)(object)Class5.Default;
					_ = (GClass2)(object)class2.j(bindingFlags, array4, ref reference, array3, cultureInfo, array5, out *(object*)null);
					_ = (Qk7)(object)Class5.Default;
					goto end_IL_1a29;
				}
				end_IL_1a29:;
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					_ = (Struct2)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, array3);
				}
			}
		}
		else
		{
			Class7 class18 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class6)(object)class18.j(bindingFlags, array4, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)((Class7)((Class7)(object)Class5.Default).t(obj, type, null)).e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, null, Class5.Default, cultureInfo), array2, (ParameterModifier[])(object)Class5.Default), array5, out reference2);
		}
		Class7 class19 = class2;
		BindingFlags bindingFlags_10 = bindingFlags;
		MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
		ParameterModifier[] parameterModifier_ = array3;
		CultureInfo cultureInfo_2 = cultureInfo;
		ParameterModifier[] parameterModifier_2 = array3;
		Class7 class20 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class19.j(bindingFlags_10, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_2, (string[])(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)null, parameterModifier_2, (CultureInfo)(object)class20.e(bindingFlags, array4, null, (ParameterModifier[])(object)Class5.Default), (string[])null, out reference2), out *(object*)null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass3 = null;
			}
			else
			{
				try
				{
					@class = @class;
				}
				catch
				{
					struct2 = struct2;
					class7 = (Class4)(object)Class5.Default;
					Class7 class21 = class2;
					BindingFlags bindingFlags_11 = bindingFlags;
					ref object[] object_3 = ref reference;
					Class7 class22 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class21.j(bindingFlags_11, null, ref object_3, (ParameterModifier[])(object)class22.e(bindingFlags, null, array2, array3), null, null, out *(object*)Class5.Default);
					class9 = class9;
				}
			}
		}
		try
		{
			@struct = default(Struct1);
			@struct = @struct;
		}
		finally
		{
			gClass = null;
			_ = (GClass0)(object)Class5.Default;
			goto IL_1cd1;
		}
		IL_0d4c:
		while ((object)Class5.Default != null)
		{
			while (obj != null)
			{
				_ = (Struct1)Class5.Default;
				_ = (Class2)(object)Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			@class = @class;
			_ = (GClass1)((Class7)null).t(obj, (Type)null, cultureInfo);
			class8 = null;
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			while ((object)class2.e((BindingFlags)((Class7)(object)Class5.Default).t(obj, null, cultureInfo), array4, null, (ParameterModifier[])(object)class2.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array3)) != null)
			{
				while (obj != null)
				{
					_003CModule_003E = null;
					gClass2 = gClass2;
					_ = (Class8)(object)class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array4, (Type[])null, array3), null, array2, array3);
					@struct = @struct;
				}
			}
			goto IL_0e42;
		}
		IL_2926:
		try
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (Struct1)Class5.Default;
				goto end_IL_2927;
			}
			end_IL_2927:;
		}
		finally
		{
			do
			{
				try
				{
					class2 = null;
				}
				finally
				{
					_ = (GClass3)(object)Class5.Default;
					continue;
				}
			}
			while (class2.t(null, null, null) != null);
			goto IL_2a1c;
		}
		IL_0e42:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		finally
		{
			do
			{
				if ((UIntPtr)((Class7)null).e(bindingFlags, array4, (Type[])null, (ParameterModifier[])(object)Class5.Default) != (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					struct2 = default(Struct2);
				}
			}
			while ((object)class2.e(bindingFlags, array4, array2, array3) != null);
			goto IL_0eb5;
		}
		IL_030f:
		bindingFlags = default(BindingFlags);
		_ = (Struct2)((Class7)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null)).t(Class5.Default, type, cultureInfo)).e(bindingFlags, null, array2, array3);
		class2 = (Class7)(object)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				gClass2 = gClass2;
				gClass2 = gClass2;
			}
		}
		else
		{
			_ = (Class0)(object)Class5.Default;
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (GClass2)(object)((Class7)(object)Class5.Default).W((BindingFlags)class2.t(null, type, cultureInfo), (PropertyInfo[])(object)Class5.Default, type, array2, array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class23);
		checked
		{
			if (unchecked((nuint)(UIntPtr)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo)) + uIntPtr == 0)
			{
				@struct = default(Struct1);
				class23 = class23;
				class23 = null;
			}
			try
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			finally
			{
				_ = (Class6)(object)Class5.Default;
				goto IL_0464;
			}
		}
		IL_22d1:
		while (obj != null)
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			finally
			{
				class9 = null;
				continue;
			}
		}
		do
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
				gClass2 = gClass2;
			}
			catch
			{
				struct2 = default(Struct2);
				_ = (Class6)(object)Class5.Default;
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			while ((object)((Class7)(object)class2.j((BindingFlags)Class5.Default, array4, ref reference, null, (CultureInfo)(object)class2.j(bindingFlags, array4, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)Class5.Default), array5, out reference2)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3) != null)
			{
				try
				{
					class7 = class7;
				}
				finally
				{
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class24.W(bindingFlags, null, null, array2, (ParameterModifier[])(object)class2.t((BindingFlags)Class5.Default, null, null, cultureInfo));
					continue;
				}
			}
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
					gClass = (GClass1)class2.t(obj, type, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array4, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])null, out *(object*)null));
					goto end_IL_23ed;
				}
				end_IL_23ed:;
			}
			finally
			{
				while (obj != null)
				{
					Class7 obj14 = (Class7)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null);
					MethodBase[] methodBase_2 = array4;
					ref object[] object_4 = ref reference;
					ParameterModifier[] parameterModifier_3 = array3;
					CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
					string[] string_2 = array5;
					Class7 class25 = class2;
					PropertyInfo[] propertyInfo_3 = array;
					BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_3 = array4;
					Type[] type_3 = array2;
					Class7 class26 = class2;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array2, (ParameterModifier[])(object)Class5.Default);
					Class7 class27 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj15 = (Class7)(object)class25.W(default(BindingFlags), propertyInfo_3, (Type)(object)((Class7)null).e(bindingFlags_12, methodBase_3, type_3, (ParameterModifier[])(object)class26.W(default(BindingFlags), propertyInfo_4, (Type)(object)class27.e(bindingFlags, array4, array2, array3), null, array3)), null, array3);
					BindingFlags bindingFlags_13 = bindingFlags;
					Class7 class28 = class2;
					Class7 class29 = class2;
					BindingFlags bindingFlags_14 = (BindingFlags)Class5.Default;
					Class7 class30 = class2;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					Type type_4 = type;
					Type[] type_5 = array2;
					Class7 obj16 = (Class7)(object)Class5.Default;
					object object_5 = Class5.Default;
					Class7 class31 = class2;
					object object_6 = obj;
					bindingFlags = default(BindingFlags);
					Class7 obj17 = (Class7)obj16.t(object_5, null, (CultureInfo)class31.t(object_6, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array4, null, null), array2, array3), cultureInfo));
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj14.j(default(BindingFlags), methodBase_2, ref object_4, parameterModifier_3, cultureInfo_3, string_2, out *(object*)((Class7)null).e((BindingFlags)obj15.W(bindingFlags_13, (PropertyInfo[])(object)class28.t((BindingFlags)class29.j(bindingFlags_14, (MethodBase[])(object)class30.W(bindingFlags_15, null, type_4, type_5, (ParameterModifier[])(object)obj17.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)), ref reference, array3, cultureInfo, array5, out reference2), array6, obj, null), (Type)(object)Class5.Default, array2, array3), (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null));
				}
				goto end_IL_23ec;
			}
			end_IL_23ec:;
		}
		try
		{
			while (obj != null)
			{
				if (checked(uIntPtr * uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					Class7 obj19 = (Class7)(object)((Class7)class2.t(obj, null, cultureInfo)).e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3), array2, array3);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_16 = bindingFlags;
					MethodBase[] methodBase_4 = (MethodBase[])((Class7)null).t(obj, (Type)null, cultureInfo);
					Class7 class32 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).j((BindingFlags)obj19.e(bindingFlags_16, methodBase_4, (Type[])(object)class32.W(bindingFlags, array, type, array2, array3), array3), (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					gClass = null;
					_ = (Class9)(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, (Type)(object)Class5.Default, array2, array3), array2, null);
					gClass = gClass;
				}
				catch
				{
					@struct = default(Struct1);
				}
			}
			goto IL_2811;
		}
		IL_2ad9:
		checked
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_ = (GClass1)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				do
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) != 0)
					{
						_ = (Class0)(object)Class5.Default;
						continue;
					}
					class13 = class13;
					bindingFlags = default(BindingFlags);
					class7 = (Class4)(object)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, (CultureInfo)null);
					_ = (GClass2)(object)Class5.Default;
				}
				while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3) != null);
				goto IL_2b7a;
			}
		}
		IL_2f75:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class9 = class9;
				gClass4 = (GClass0)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])null, cultureInfo, array5, out reference2);
				_ = (Qk7)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					class23 = class23;
				}
			}
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)((Class7)null).t(obj, type, cultureInfo);
			}
		}
		while (obj != null);
		gClass4 = gClass4;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					_ = (Class5)(object)((Class7)null).j((BindingFlags)Class5.Default, array4, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])null, out reference2);
				}
			}
			catch
			{
				do
				{
					_ = (GClass0)(object)class2.W(bindingFlags, array, type, (Type[])(object)class2.e(bindingFlags, array4, (Type[])(object)class2.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default)), null);
				}
				while (obj != null);
			}
		}
		gClass2 = gClass2;
		qk = null;
		while (true)
		{
			if (obj != null)
			{
				qk = qk;
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		try
		{
			try
			{
				Class7 class33 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj23 = (Class7)(object)class33.W(bindingFlags, array, type, array2, (ParameterModifier[])(object)Class5.Default);
				Class7 class34 = class2;
				BindingFlags bindingFlags_17 = bindingFlags;
				Class7 obj24 = (Class7)(object)Class5.Default;
				Type type_6 = type;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj23.e((BindingFlags)class34.W(bindingFlags_17, (PropertyInfo[])obj24.t(null, type_6, (CultureInfo)((Class7)null).t((object)null, (Type)(object)((Class7)null).e(bindingFlags, array4, array2, (ParameterModifier[])null), cultureInfo)), type, array2, array3), array4, null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					_ = (Class7)(object)class2.W(bindingFlags, array, type, array2, array3);
				}
			}
			catch
			{
				Class7 obj25 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj26 = (Class7)(object)obj25.j(bindingFlags, array4, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array5, out reference2);
				BindingFlags bindingFlags_18 = bindingFlags;
				MethodBase[] methodBase_5 = array4;
				ref object[] object_7 = ref reference;
				Class7 class35 = class2;
				BindingFlags bindingFlags_19 = bindingFlags;
				MethodBase[] methodBase_6 = (MethodBase[])(object)class2.W(bindingFlags, (PropertyInfo[])class2.t(obj, type, (CultureInfo)(object)((Class7)(object)class2.t((BindingFlags)class2.j(bindingFlags, array4, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)null), null, obj, null)).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), null, null, out *(object*)null)), type, array2, array3);
				ref object[] object_8 = ref reference;
				CultureInfo cultureInfo_4 = cultureInfo;
				BindingFlags bindingFlags_20 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)class2.j((BindingFlags)class2.t(obj, type, cultureInfo), null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out reference2), out reference2);
				Class7 class36 = class2;
				BindingFlags bindingFlags_21 = bindingFlags;
				MethodBase[] methodBase_8 = array4;
				ref object[] object_9 = ref reference;
				CultureInfo cultureInfo_5 = cultureInfo;
				Class7 obj27 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj28 = (Class7)(object)class36.j(bindingFlags_21, methodBase_8, ref object_9, null, cultureInfo_5, null, out *(object*)obj27.t(bindingFlags, null, Class5.Default, cultureInfo));
				bindingFlags = default(BindingFlags);
				@class = (Class2)(object)obj26.j(bindingFlags_18, methodBase_5, ref object_7, (ParameterModifier[])(object)class35.j(bindingFlags_19, methodBase_6, ref object_8, null, cultureInfo_4, null, out *(object*)((Class7)null).e(bindingFlags_20, methodBase_7, (Type[])null, (ParameterModifier[])(object)((Class7)(object)obj28.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])class2.t(null, null, (CultureInfo)(object)Class5.Default), (object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array2, (ParameterModifier[])(object)Class5.Default), null), (CultureInfo)null), (Type[])(object)Class5.Default, array3)).t((BindingFlags)Class5.Default, array6, Class5.Default, null))), (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)((Class7)(object)((Class7)null).W((BindingFlags)class2.t(null, (Type)(object)Class5.Default, cultureInfo), array, (Type)null, array2, array3)).j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, array5, out *(object*)null), (ParameterModifier[])null), array5, out reference2);
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.e(bindingFlags, null, array2, array3), null, null);
				}
				else
				{
					struct2 = (Struct2)((Class7)(object)Class5.Default).t(null, null, cultureInfo);
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = null;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
				goto end_IL_353a;
			}
			end_IL_353a:;
		}
		_ = (Class9)(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.t(obj, type, cultureInfo), array4, ref *(object[]*)Class5.Default, array3, null, array5, out *(object*)null);
		class2 = (Class7)(object)Class5.Default;
		class5 = class5;
		class9 = null;
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				class9 = class9;
			}
		}
		try
		{
			_ = (Class8)(object)class2.t(bindingFlags, null, obj, cultureInfo);
		}
		catch
		{
			try
			{
				while (true)
				{
					Class7 class37 = class2;
					bindingFlags = default(BindingFlags);
					if ((object)class37.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, null, out *(object*)null) != null)
					{
						gClass3 = gClass3;
						class9 = Class5.Default;
						continue;
					}
					break;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		if ((nuint)(UIntPtr)class2.t(null, null, null) / (checked(uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default)) / uIntPtr) == 0)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					class7 = null;
					qk = qk;
					class2 = class2;
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		do
		{
			_ = (Qk7)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo);
		}
		while (obj != null);
		gClass = (GClass1)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				gClass2 = gClass2;
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				while (obj != null)
				{
					class9 = class9;
				}
				goto IL_37bf;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				_003CModule_003E = null;
				goto IL_37bf;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			class23 = class23;
		}
		else
		{
			class7 = class7;
		}
		goto IL_37bf;
		IL_0eb5:
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					class5 = class5;
				}
			}
			catch
			{
				gClass = null;
				_ = (GClass2)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, null);
				class11 = (Class9)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while ((object)((Class7)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type, null), array5, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)class2.t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array6, Class5.Default, null), null, Class5.Default, cultureInfo), (Type[])null, array3))).W(bindingFlags, array, type, array2, null) != null);
			}
			catch
			{
				while (true)
				{
					_ = (Class4)(object)Class5.Default;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_1005;
				}
				end_IL_1005:;
			}
		}
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
					gClass2 = gClass2;
					class13 = null;
					class13 = class13;
				}
			}
			while ((object)Class5.Default != null);
			goto IL_10b1;
		}
		try
		{
			class23 = null;
		}
		finally
		{
			try
			{
				_ = (Class5)(object)((Class7)null).t((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array6, (object)null, (CultureInfo)null);
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_10b1;
		}
		IL_10b1:
		struct2 = default(Struct2);
		_ = (GClass0)(object)Class5.Default;
		@struct = @struct;
		_003CModule_003E = null;
		try
		{
			_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
		}
		finally
		{
			try
			{
				try
				{
					class11 = class11;
					class7 = (Class4)(object)Class5.Default;
				}
				finally
				{
					class2 = class2;
					goto end_IL_1103;
				}
				end_IL_1103:;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
				goto IL_1146;
			}
		}
		IL_1865:
		try
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				_ = (Class7)(object)Class5.Default;
				goto end_IL_1866;
			}
			end_IL_1866:;
		}
		finally
		{
			do
			{
				if ((UIntPtr)class2.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) != (UIntPtr)(nuint)0u)
				{
					@class = @class;
					_ = (Class9)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
					Class7 class38 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class38.e(bindingFlags, array4, array2, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					_ = (Class2)(object)((Class7)null).e(bindingFlags, (MethodBase[])class2.t(obj, type, cultureInfo), (Type[])(object)((Class7)(object)class2.t(bindingFlags, null, null, null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3), array3);
				}
			}
			while (obj != null);
			goto IL_1983;
		}
		IL_0464:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				gClass3 = gClass3;
			}
		}
		gClass = gClass;
		_ = (Class9)(object)Class5.Default;
		GClass0 obj38 = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out reference2));
		gClass4 = gClass4;
		gClass4 = obj38;
		try
		{
			Class7 class39 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)class39.j(bindingFlags, array4, ref reference, null, cultureInfo, array5, out *(object*)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)class2.t(bindingFlags, array6, obj, cultureInfo)).W(bindingFlags, array, type, null, array3), (PropertyInfo[])((Class7)null).t(obj, type, (CultureInfo)null), type, array2, array3));
			@struct = default(Struct1);
			@struct = @struct;
			gClass = gClass;
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		catch
		{
			do
			{
				class23 = class23;
			}
			while (obj != null);
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				BindingFlags bindingFlags_22;
				FieldInfo[] fieldInfo_;
				do
				{
					_ = (Class2)(object)class2.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array3);
					bindingFlags_22 = bindingFlags;
					fieldInfo_ = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).t(bindingFlags_22, fieldInfo_, (object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, array3), cultureInfo) != null);
			}
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					@class = @class;
				}
			}
			finally
			{
				Class7 class40 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class40.e(bindingFlags, (MethodBase[])(object)((Class7)class2.t(obj, null, null)).t((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array5, out reference2), null, null, cultureInfo), array2, array3);
				goto end_IL_0642;
			}
			end_IL_0642:;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					Class7 obj41 = (Class7)(object)Class5.Default;
					object object_10 = obj;
					Class7 class41 = class2;
					bindingFlags = default(BindingFlags);
					@class = (Class2)obj41.t(object_10, (Type)(object)class41.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3), null);
					continue;
				}
			}
			while (obj != null);
		}
		do
		{
			BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_9 = array4;
			Type[] type_7 = array2;
			Class7 class42 = class2;
			BindingFlags bindingFlags_24 = bindingFlags;
			Class7 obj43 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)((Class7)null).e(bindingFlags_23, methodBase_9, type_7, (ParameterModifier[])(object)class42.W(bindingFlags_24, (PropertyInfo[])(object)obj43.e(bindingFlags, null, array2, array3), null, array2, (ParameterModifier[])(object)Class5.Default))).j(bindingFlags, (MethodBase[])(object)class2.t((BindingFlags)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(Class5.Default, type, (CultureInfo)(object)((Class7)null).W(bindingFlags, array, type, (Type[])null, array3)), Class5.Default, null), cultureInfo, array5, out reference2), array6, null, cultureInfo), ref *(object[]*)null, array3, cultureInfo, null, out reference2) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class5 = (Class10)(object)Class5.Default;
				}
				catch
				{
					Qk7 obj44 = (Qk7)(object)Class5.Default;
					qk = qk;
					qk = obj44;
					@class = null;
					_ = (Class9)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.e((BindingFlags)Class5.Default, null, array2, null), array2, (ParameterModifier[])(object)Class5.Default);
					@class = (Class2)(object)Class5.Default;
				}
			}
		}
		while (obj != null);
		_ = (Class10)(object)Class5.Default;
		class9 = class9;
		class9 = null;
		class9 = null;
		Class7 class43 = class2;
		bindingFlags = default(BindingFlags);
		Class7 obj46 = (Class7)(object)class43.e(bindingFlags, (MethodBase[])(object)class2.j(bindingFlags, (MethodBase[])(object)class2.W((BindingFlags)class2.W((BindingFlags)Class5.Default, array, null, array2, array3), array, null, null, null), ref *(object[]*)null, array3, (CultureInfo)(object)class2.W(bindingFlags, null, type, array2, (ParameterModifier[])(object)Class5.Default), array5, out reference2), array2, array3);
		BindingFlags bindingFlags_25 = bindingFlags;
		MethodBase[] methodBase_10 = array4;
		BindingFlags bindingFlags_26 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = array;
		Type[] type_8 = array2;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj46.j(bindingFlags_25, methodBase_10, ref *(object[]*)((Class7)null).W(bindingFlags_26, propertyInfo_5, (Type)null, type_8, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type, (Type[])null, array3)), (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array4, array2, (ParameterModifier[])null), null, null, out *(object*)null);
		class11 = null;
		checked
		{
			do
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
					{
						@struct = @struct;
					}
				}
				catch
				{
				}
			}
			while ((object)class2.e(bindingFlags, array4, null, null) != null);
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (GClass1)(object)Class5.Default;
				}
				else if ((object)((Class7)(object)class2.j(bindingFlags, array4, ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)class2.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array3))).W(bindingFlags, array, type, array2, array3) == null)
				{
					break;
				}
			}
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					@class = (Class2)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo);
				}
			}
			catch
			{
				while (true)
				{
					if ((object)Class5.Default != null)
					{
						Class7 class44 = class2;
						BindingFlags bindingFlags_27 = bindingFlags;
						MethodBase[] methodBase_11 = (MethodBase[])(object)Class5.Default;
						ParameterModifier[] parameterModifier_4 = array3;
						Class7 class45 = class2;
						Class7 obj48 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default);
						BindingFlags bindingFlags_28 = bindingFlags;
						ref object[] object_11 = ref reference;
						Class7 class46 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class7)(object)class44.j(bindingFlags_27, methodBase_11, ref *(object[]*)null, parameterModifier_4, (CultureInfo)(object)class45.t((BindingFlags)obj48.j(bindingFlags_28, null, ref object_11, (ParameterModifier[])(object)class46.t(bindingFlags, array6, obj, cultureInfo), (CultureInfo)class2.t(obj, type, cultureInfo), (string[])(object)Class5.Default, out reference2), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, out reference2);
						continue;
					}
					goto end_IL_0b36;
				}
				end_IL_0b36:;
			}
		}
		try
		{
			Class0 obj51 = (Class0)(object)Class5.Default;
			class8 = class8;
			class8 = obj51;
			qk = qk;
			class7 = (Class4)(object)Class5.Default;
			class7 = class7;
			_ = (GClass0)class2.t(obj, null, cultureInfo);
		}
		finally
		{
			while (obj != null)
			{
				class8 = class8;
			}
			goto IL_0c85;
		}
		IL_2811:
		do
		{
			_ = (Class0)(object)Class5.Default;
		}
		while (obj != null);
		_ = (Class6)(object)class2.j(bindingFlags, null, ref reference, array3, null, array5, out reference2);
		_ = (Class9)(object)Class5.Default;
		gClass2 = (GClass3)(object)Class5.Default;
		_003CModule_003E = null;
		_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo);
		try
		{
			class9 = Class5.Default;
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (Class7)(object)class2.e((BindingFlags)class2.t(bindingFlags, array6, ((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, array3), (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3);
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			goto IL_2926;
		}
		IL_407c:
		class9 = Class5.Default;
		try
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
				_ = (Class4)(object)class2.e(bindingFlags, array4, array2, array3);
				class5 = class5;
			}
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		_ = (Class4)(object)((Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array3)).W((BindingFlags)Class5.Default, null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, (string[])null, out *(object*)Class5.Default), null, null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
				Class7 obj55 = (Class7)(object)((Class7)null).e(default(BindingFlags), array4, array2, array3);
				bindingFlags = default(BindingFlags);
				class7 = (Class4)(object)obj55.W(bindingFlags, null, null, array2, (ParameterModifier[])(object)class2.W((BindingFlags)Class5.Default, null, type, null, array3));
				gClass = gClass;
				class8 = class8;
			}
		}
		try
		{
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				_ = (Class6)(object)Class5.Default;
			}
			else
			{
				_ = (Class7)(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo);
			}
		}
		catch
		{
			try
			{
				do
				{
					class8 = (Class0)(object)Class5.Default;
				}
				while ((object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W((BindingFlags)((Class7)null).t(obj, type, cultureInfo), (PropertyInfo[])(object)Class5.Default, (Type)class2.t(obj, type, cultureInfo), array2, array3), (object)null, (CultureInfo)null) != null);
			}
			finally
			{
				try
				{
					class7 = null;
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
				goto end_IL_427b;
			}
			end_IL_427b:;
		}
		class11 = (Class9)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)class2.j(bindingFlags, null, ref reference, array3, cultureInfo, array5, out reference2)).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), ref reference, null, null, array5, out *(object*)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null));
		if (uIntPtr == 0)
		{
			checked
			{
				do
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * (uIntPtr - uIntPtr) == 0)
					{
						struct2 = struct2;
					}
				}
				while ((object)class2.j(bindingFlags, array4, ref reference, null, cultureInfo, null, out reference2) != null);
			}
		}
		else
		{
			Class7 class47 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)((Class7)null).e((BindingFlags)class47.t(bindingFlags, array6, Class5.Default, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null))).j((BindingFlags)class2.t(null, null, null), (MethodBase[])(object)class2.t((BindingFlags)Class5.Default, array6, obj, null), ref *(object[]*)null, array3, cultureInfo, null, out reference2) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					qk = qk;
				}
			}
			else
			{
				UIntPtr num3 = (UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)class2.W(bindingFlags, array, null, (Type[])(object)Class5.Default, array3), type, array2, array3);
				uIntPtr = default(UIntPtr);
				if ((nuint)num3 / uIntPtr == 0)
				{
					class8 = null;
				}
			}
		}
		do
		{
			try
			{
				UIntPtr num4 = (UIntPtr)class2.W(bindingFlags, array, type, null, null);
				uIntPtr = default(UIntPtr);
				if ((nuint)num4 / uIntPtr == 0)
				{
					gClass4 = gClass4;
					_ = (Struct2)Class5.Default;
					_ = (GClass2)(object)((Class7)null).e((BindingFlags)Class5.Default, array4, (Type[])null, (ParameterModifier[])(object)class2.j(bindingFlags, null, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out reference2));
					@class = null;
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
					Class7 obj58 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj58.W(bindingFlags, array, null, array2, null);
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			Class7 obj60 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj60.W(bindingFlags, null, type, null, array3) == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					_ = (Class10)(object)Class5.Default;
					class7 = class7;
					class23 = (Class6)(object)Class5.Default;
				}
				else
				{
					class2 = class2;
				}
			}
			else
			{
				try
				{
					_ = (GClass3)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
				}
				catch
				{
					qk = qk;
					object object_12 = obj;
					Class7 obj61 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_29 = (BindingFlags)Class5.Default;
					Class7 class48 = class2;
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_12 = array4;
					Class7 class49 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_31 = bindingFlags;
					Class7 obj62 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)((Class7)null).t(object_12, (Type)(object)((Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)obj61.e(bindingFlags_29, (MethodBase[])(object)class48.e(bindingFlags_30, methodBase_12, (Type[])(object)class49.j(bindingFlags_31, (MethodBase[])(object)obj62.W(bindingFlags, array, (Type)(object)Class5.Default, null, array3), ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null), array2, array3))).e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo)), cultureInfo);
					_ = (GClass0)(object)class2.j((BindingFlags)class2.t(obj, type, cultureInfo), null, ref *(object[]*)((Class7)(object)Class5.Default).t(obj, type, cultureInfo), (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, (Type[])(object)Class5.Default, null), (ParameterModifier[])null), cultureInfo, array5, out *(object*)null);
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = Class5.Default;
				}
			}
		}
		Class7 class50 = class2;
		BindingFlags bindingFlags_32 = bindingFlags;
		MethodBase[] methodBase_13 = array4;
		Class7 obj65 = (Class7)(object)class2.e(bindingFlags, array4, null, (ParameterModifier[])class2.t(null, type, null));
		BindingFlags bindingFlags_33 = bindingFlags;
		MethodBase[] methodBase_14 = array4;
		Type[] type_9 = array2;
		Class7 obj66 = (Class7)(object)class2.j(default(BindingFlags), array4, ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)Class5.Default);
		MethodBase[] methodBase_15 = (MethodBase[])(object)Class5.Default;
		ref object[] object_13 = ref reference;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)class50.e(bindingFlags_32, methodBase_13, (Type[])(object)obj65.e(bindingFlags_33, methodBase_14, type_9, (ParameterModifier[])(object)obj66.j(default(BindingFlags), methodBase_15, ref object_13, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null), array5, out reference2)), array3);
		try
		{
			try
			{
				class8 = (Class0)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, cultureInfo);
			}
			catch
			{
				class11 = class11;
				struct2 = struct2;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					class8 = (Class0)(object)((Class7)null).j(bindingFlags, array4, ref reference, array3, cultureInfo, array5, out *(object*)null);
				}
				else
				{
					Class7 class51 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_34 = bindingFlags;
					FieldInfo[] fieldInfo_2 = array6;
					BindingFlags bindingFlags_35 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array, type, array2, array3), null, array2, null);
					BindingFlags bindingFlags_36 = bindingFlags;
					MethodBase[] methodBase_16 = array4;
					ref object[] object_14 = ref reference;
					Class7 obj68 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)((Class7)null).j((BindingFlags)class51.t(bindingFlags_34, fieldInfo_2, ((Class7)null).t((BindingFlags)((Class7)null).t(bindingFlags_35, (FieldInfo[])(object)((Class7)null).j(bindingFlags_36, methodBase_16, ref object_14, (ParameterModifier[])null, (CultureInfo)(object)obj68.j(bindingFlags, array4, ref *(object[]*)Class5.Default, array3, cultureInfo, null, out reference2), (string[])class2.t(obj, type, null), out *(object*)Class5.Default), (object)null, (CultureInfo)null), (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array3, null, (string[])(object)class2.j(default(BindingFlags), array4, ref *(object[]*)Class5.Default, array3, null, array5, out reference2), out reference2), (object)null, (CultureInfo)class2.t(null, type, (CultureInfo)class2.t(obj, type, cultureInfo))), null), array4, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])null, out *(object*)((Class7)(object)Class5.Default).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null));
				}
				goto end_IL_493d;
			}
			end_IL_493d:;
		}
		finally
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = (GClass2)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (Class2)(object)Class5.Default;
				goto IL_4bf7;
			}
		}
		IL_1146:
		try
		{
		}
		catch
		{
		}
		_ = (Class7)(object)Class5.Default;
		while (true)
		{
			if (obj != null)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_37 = bindingFlags;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_17 = (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null);
					ref object[] object_15 = ref reference;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
					ref object[] object_16 = ref reference;
					ParameterModifier[] parameterModifier_6 = array3;
					CultureInfo cultureInfo_6 = cultureInfo;
					string[] string_3 = array5;
					Class7 class52 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).j(bindingFlags_37, methodBase_17, ref object_15, parameterModifier_5, (CultureInfo)(object)((Class7)null).j(bindingFlags_38, (MethodBase[])null, ref object_16, parameterModifier_6, cultureInfo_6, string_3, out *(object*)class52.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default)), (string[])null, out *(object*)null);
				}
				catch
				{
					_ = Class5.Default;
				}
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				do
				{
					_ = (Struct1)Class5.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				@struct = default(Struct1);
			}
		}
		if (uIntPtr == 0)
		{
			class11 = class11;
		}
		else
		{
			qk = qk;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class5)(object)((Class7)null).W(bindingFlags, array, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, null, array5, out reference2));
				}
				catch
				{
					_ = (Struct1)class2.W(bindingFlags, array, type, array2, null);
					class5 = (Class10)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Class7 obj72 = (Class7)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo);
				Class7 class53 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_39 = bindingFlags;
				Type type_10 = type;
				Type[] type_11 = (Type[])(object)Class5.Default;
				Class7 class54 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)obj72.W((BindingFlags)class53.W(bindingFlags_39, null, type_10, type_11, (ParameterModifier[])(object)class54.e(bindingFlags, null, (Type[])(object)Class5.Default, null)), array, type, array2, array3);
			}
		}
		finally
		{
			Class7 class55;
			do
			{
				_ = (Qk7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)class2.t(bindingFlags, null, Class5.Default, cultureInfo), (CultureInfo)null, (string[])null, out reference2)).t(bindingFlags, array6, obj, cultureInfo);
				class55 = class2;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class55.e(bindingFlags, array4, (Type[])(object)Class5.Default, (ParameterModifier[])class2.t(obj, null, null)) != null);
			goto IL_14b2;
		}
		IL_14b2:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				_ = (GClass1)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, array2, array3);
				class2 = null;
				_ = Class5.Default;
				_ = (Class4)(object)Class5.Default;
				goto IL_1510;
			}
		}
		while (obj != null)
		{
		}
		goto IL_1510;
		IL_4bf7:
		do
		{
			Class7 class56 = class2;
			bindingFlags = default(BindingFlags);
			UIntPtr num5 = (UIntPtr)class56.e(bindingFlags, null, null, array3);
			uIntPtr = default(UIntPtr);
			nuint num6 = uIntPtr / uIntPtr;
			UIntPtr num7 = (UIntPtr)((Class7)null).t(((Class7)(object)Class5.Default).t(obj, type, null), type, cultureInfo);
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) - unchecked(num6 / checked(unchecked((nuint)num7) - (unchecked((nuint)default(UIntPtr)) + uIntPtr))) == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Class4)(object)Class5.Default;
						continue;
					}
					@struct = default(Struct1);
					_003CModule_003E = null;
				}
			}
		}
		while (obj != null);
		do
		{
			_ = (Class6)(object)Class5.Default;
			_ = (Struct2)class2.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3);
			_ = (GClass2)class2.t(null, null, cultureInfo);
		}
		while (obj != null);
		_ = (Class6)(object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, null), Class5.Default, (CultureInfo)(object)Class5.Default);
		while ((object)Class5.Default != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					gClass2 = gClass2;
				}
				while (obj != null);
				continue;
			}
		}
		uIntPtr = default(UIntPtr);
		UIntPtr num8 = uIntPtr;
		UIntPtr num9 = uIntPtr;
		uIntPtr = default(UIntPtr);
		UIntPtr num10 = uIntPtr;
		UIntPtr num11 = uIntPtr;
		BindingFlags bindingFlags_40 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = array;
		Type type_12 = type;
		Type[] type_13 = array2;
		bindingFlags = default(BindingFlags);
		checked
		{
			nuint num12 = unchecked((nuint)num10) + unchecked(checked(unchecked((nuint)num11) + unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags_40, propertyInfo_6, type_12, type_13, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array4, array2, (ParameterModifier[])null))) * (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))))) / (nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo));
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num8) - unchecked((nuint)num9) * (num12 + unchecked(uIntPtr / uIntPtr)) == 0)
			{
				_ = (GClass3)(object)class2.t(bindingFlags, array6, null, null);
			}
			else
			{
				@struct = (Struct1)Class5.Default;
			}
			return;
		}
		IL_1983:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_1984;
				}
			}
			if (uIntPtr == 0)
			{
				class2 = null;
			}
			else
			{
				class7 = class7;
			}
			end_IL_1984:;
		}
		finally
		{
			try
			{
				do
				{
					gClass4 = gClass4;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				class13 = (Class8)(object)Class5.Default;
				Class7 class57 = class2;
				bindingFlags = default(BindingFlags);
				class7 = (Class4)(object)class57.W(bindingFlags, array, type, array2, null);
			}
			goto IL_1a20;
		}
		IL_3a73:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)class2.t((BindingFlags)((Class7)null).t((BindingFlags)class2.e(bindingFlags, array4, array2, null), array6, obj, cultureInfo), (FieldInfo[])(object)class2.e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, null, Class5.Default, null), array2, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3)), ((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array4, ref reference, null, (CultureInfo)(object)Class5.Default, null, out reference2)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo)).t(null, type, null), cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)class2.t(obj, (Type)(object)Class5.Default, null);
				}
			}
			while (obj != null);
		}
		_ = (Class9)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
		gClass2 = gClass2;
		@struct = default(Struct1);
		gClass2 = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = Class5.Default;
		}
		else
		{
			do
			{
				try
				{
					gClass3 = gClass3;
				}
				catch
				{
					gClass3 = gClass3;
				}
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					gClass = gClass;
					_ = (Qk7)(object)Class5.Default;
					goto IL_3c9c;
				}
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		goto IL_3c9c;
		IL_3c9c:
		try
		{
			class7 = class7;
			class23 = null;
			class13 = null;
			@class = null;
		}
		finally
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
				_ = (Struct2)Class5.Default;
				goto IL_3cd9;
			}
		}
		IL_1510:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])(object)class2.j((BindingFlags)Class5.Default, array4, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)null).t((object)Class5.Default, type, cultureInfo), cultureInfo, (string[])(object)Class5.Default, out reference2)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class5 = null;
				}
				finally
				{
					class23 = class23;
					goto IL_1865;
				}
			}
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
				{
					_ = (Class7)((Class7)null).t((object)null, type, cultureInfo);
				}
				else
				{
					_ = Class5.Default;
				}
			}
		}
		else
		{
			BindingFlags bindingFlags_41 = (BindingFlags)class2.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, (string[])(object)class2.e(bindingFlags, array4, array2, (ParameterModifier[])(object)Class5.Default), out reference2), (ParameterModifier[])(object)Class5.Default);
			BindingFlags bindingFlags_42 = bindingFlags;
			Class7 class58 = class2;
			object object_17 = obj;
			Class7 obj75 = (Class7)(object)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)class2.e((BindingFlags)Class5.Default, array4, array2, array3), type, null, null)).W((BindingFlags)class2.t(obj, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array4, array2, array3), (Type)(object)((Class7)null).j((BindingFlags)Class5.Default, array4, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), (Type[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array3)), array, type, array2, array3)).t(bindingFlags, array6, obj, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags_41, (FieldInfo[])(object)((Class7)null).j(bindingFlags_42, (MethodBase[])class58.t(object_17, (Type)((Class7)(object)((Class7)(object)obj75.j(bindingFlags, array4, ref reference, (ParameterModifier[])class2.t(null, type, null), (CultureInfo)(object)Class5.Default, array5, out *(object*)class2.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo))).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default)).t(obj, null, cultureInfo), cultureInfo), ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array5, out reference2), (object)Class5.Default, (CultureInfo)null) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class11 = (Class9)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		goto IL_1865;
		IL_3cd9:
		_ = (GClass1)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Struct1)Class5.Default;
			}
			while (obj != null);
		}
		_ = (Class6)(object)Class5.Default;
		try
		{
			try
			{
				try
				{
					@struct = (Struct1)Class5.Default;
				}
				finally
				{
					Class7 class59 = class2;
					BindingFlags bindingFlags_43 = bindingFlags;
					MethodBase[] methodBase_18 = array4;
					Class7 class60 = class2;
					BindingFlags bindingFlags_44 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array6;
					object object_18 = ((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3);
					Class7 class61 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_45 = bindingFlags;
					Class7 class62 = class2;
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 class63 = class2;
					Class7 class64 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class59.j(bindingFlags_43, methodBase_18, ref *(object[]*)null, (ParameterModifier[])(object)class60.t(bindingFlags_44, fieldInfo_3, object_18, (CultureInfo)(object)class61.t(bindingFlags_45, (FieldInfo[])(object)class62.j(bindingFlags_46, null, ref *(object[]*)class63.t(class64.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null), null, (CultureInfo)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3)), array3, cultureInfo, null, out *(object*)null), null, null)), null, null, out *(object*)Class5.Default);
					Class7 class65 = class2;
					Class7 class66 = class2;
					BindingFlags bindingFlags_47 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = array;
					Type type_14 = (Type)(object)Class5.Default;
					Class7 class67 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = (BindingFlags)class66.W(bindingFlags_47, propertyInfo_7, type_14, (Type[])(object)class67.j(bindingFlags, (MethodBase[])class2.t(Class5.Default, (Type)(object)Class5.Default, null), ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2), null);
					MethodBase[] methodBase_19 = array4;
					ParameterModifier[] parameterModifier_7 = array3;
					Class7 class68 = class2;
					Class7 class69 = class2;
					object object_19 = obj;
					Class7 obj76 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class65.j(bindingFlags_48, methodBase_19, ref *(object[]*)null, parameterModifier_7, (CultureInfo)(object)class68.e((BindingFlags)class69.t(object_19, null, (CultureInfo)(object)((Class7)(object)obj76.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)class2.j(bindingFlags, null, ref reference, array3, cultureInfo, array5, out reference2), (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, array6, null, cultureInfo)), array4, array2, array3), null, out reference2);
					gClass3 = gClass3;
					class7 = class7;
					goto end_IL_3d11;
				}
				end_IL_3d11:;
			}
			finally
			{
				class9 = class9;
				_ = (Struct1)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
				goto end_IL_3d10;
			}
			end_IL_3d10:;
		}
		finally
		{
			do
			{
				if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) == 0)
				{
					gClass4 = (GClass0)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])class2.t(obj, null, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)class2.e(bindingFlags, array4, (Type[])(object)Class5.Default, null), ref reference, array3, cultureInfo, null, out *(object*)null)), obj, (CultureInfo)(object)Class5.Default);
				}
			}
			while (((Class7)(object)Class5.Default).t(obj, null, cultureInfo) != null);
			goto IL_407c;
		}
		IL_2b7a:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass3)(object)class2.W((BindingFlags)Class5.Default, array, null, null, array3);
				}
				finally
				{
					class5 = (Class10)(object)Class5.Default;
					goto end_IL_2b7b;
				}
			}
			end_IL_2b7b:;
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = gClass;
				}
				finally
				{
					class23 = class23;
					@struct = default(Struct1);
					goto end_IL_2bc5;
				}
			}
			try
			{
				struct2 = default(Struct2);
				struct2 = struct2;
				gClass2 = null;
				class7 = null;
				_ = (Class10)(object)Class5.Default;
			}
			catch
			{
				qk = (Qk7)class2.t(obj, type, (CultureInfo)(object)Class5.Default);
			}
			end_IL_2bc5:;
		}
		Class7 obj79 = (Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), array, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default)).W(default(BindingFlags), array, null, (Type[])(object)Class5.Default, array3);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)(object)((Class7)null).t((BindingFlags)obj79.W(bindingFlags, array, (Type)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)class2.t(bindingFlags, array6, obj, cultureInfo), null, cultureInfo), null, array3), array6, (object)Class5.Default, cultureInfo)).e((BindingFlags)class2.W(bindingFlags, null, (Type)(object)Class5.Default, null, array3), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)class2.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference2)) == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass3)class2.t(obj, type, null);
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		Class7 obj81 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj81.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)class2.e(bindingFlags, null, array2, array3), (ParameterModifier[])null, cultureInfo, array5, out *(object*)null), (Type[])(object)Class5.Default, array3) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					class2 = class2;
					struct2 = (Struct2)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
					goto end_IL_2e56;
				}
				end_IL_2e56:;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass3 = null;
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
				class11 = (Class9)(object)Class5.Default;
				_ = (Struct2)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo);
			}
			catch
			{
				@class = (Class2)(object)Class5.Default;
			}
			finally
			{
				try
				{
					_ = (Qk7)(object)class2.e(bindingFlags, array4, (Type[])class2.t(Class5.Default, type, cultureInfo), null);
				}
				finally
				{
					class7 = class7;
					_ = (GClass3)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo);
					class11 = (Class9)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
					goto IL_2f75;
				}
			}
		}
		IL_1d65:
		if (uIntPtr == 0)
		{
			gClass = gClass;
		}
		else
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					Class7 class70 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj84 = (Class7)(object)class70.t(bindingFlags, null, obj, cultureInfo);
					BindingFlags bindingFlags_49 = bindingFlags;
					ref object[] object_20 = ref reference;
					Class7 obj85 = (Class7)(object)Class5.Default;
					Class7 class71 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_50 = bindingFlags;
					Class7 obj86 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])class2.t(obj, type, (CultureInfo)(object)Class5.Default), array3);
					MethodBase[] methodBase_20 = array4;
					Type[] type_15 = array2;
					Class7 class72 = class2;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)obj85.W((BindingFlags)class71.t(bindingFlags_50, (FieldInfo[])(object)obj86.e(default(BindingFlags), methodBase_20, type_15, (ParameterModifier[])(object)class72.e(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, array, type, array2, array3), array2, null)), null, (CultureInfo)(object)class2.W(default(BindingFlags), array, null, (Type[])class2.t(obj, null, null), (ParameterModifier[])(object)Class5.Default)), null, type, array2, null);
					CultureInfo cultureInfo_7 = cultureInfo;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)(object)obj84.j(bindingFlags_49, null, ref object_20, parameterModifier_8, cultureInfo_7, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).e((BindingFlags)Class5.Default, array4, array2, array3), obj, cultureInfo), out *(object*)Class5.Default)).e(bindingFlags, null, array2, array3);
				}
			}
			else
			{
				class2 = class2;
			}
		}
		while (obj != null)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj, type, cultureInfo)) * unchecked((nuint)(UIntPtr)class2.W(bindingFlags, array, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)class2.t(obj, type, (CultureInfo)(object)((Class7)(object)class2.W((BindingFlags)Class5.Default, array, null, (Type[])(object)Class5.Default, array3)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null)), array6, ((Class7)null).t(obj, type, cultureInfo), null), null, null)) == 0)
				{
					@class = @class;
					continue;
				}
				uIntPtr = default(UIntPtr);
			}
			if (uIntPtr / uIntPtr == 0)
			{
				_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				Class7 class73 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class73.t(bindingFlags, array6, obj, cultureInfo);
				class5 = class5;
			}
			else
			{
				_ = (GClass1)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)((Class7)null).j(bindingFlags, array4, ref reference, (ParameterModifier[])null, (CultureInfo)null, array5, out reference2), array3);
				_ = (Class4)(object)class2.j(bindingFlags, array4, ref reference, array3, cultureInfo, array5, out *(object*)Class5.Default);
				@struct = @struct;
				class11 = null;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					@struct = default(Struct1);
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					struct2 = (Struct2)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, null, type, array2, (ParameterModifier[])(object)Class5.Default), ((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3), null);
				}
			}
		}
		finally
		{
			Class7 class74 = class2;
			BindingFlags bindingFlags_51 = bindingFlags;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			Class7 obj88 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])(object)class2.W(bindingFlags, null, type, array2, array3));
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class74.W(bindingFlags_51, propertyInfo_8, (Type)(object)((Class7)null).j((BindingFlags)obj88.e(bindingFlags, array4, array2, array3), array4, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, (string[])null, out reference2), array2, array3) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			else if (checked(uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				_ = (Class10)(object)Class5.Default;
			}
			goto IL_22d1;
		}
	}

	unsafe static void smethod_2()
	{
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		if (uIntPtr == 0)
		{
			try
			{
				@struct = @struct;
				@struct = @struct;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					@class = @class;
					@class = @class;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
		}
		catch
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_ = bindingFlags;
				Class7 class3 = class2;
				cultureInfo = cultureInfo;
				Class9 obj3 = (Class9)(object)((Class7)null).j(bindingFlags_, methodBase_, ref object_, (ParameterModifier[])class3.t(obj2, type_, cultureInfo), (CultureInfo)null, string_, out object_2);
				class4 = class4;
				class4 = obj3;
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
			}
			finally
			{
				class4 = (Class9)(object)class2.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
				class4 = class4;
				goto end_IL_003f;
			}
			end_IL_003f:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] fieldInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		try
		{
			_ = (Struct2)Class5.Default;
			Class7 class5 = class2;
			BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
			Class7 obj6 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class6 = class2;
			Class7 class7 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_4 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)class5.W(bindingFlags_2, propertyInfo_, type_, (Type[])(object)obj6.t(bindingFlags_3, (FieldInfo[])(object)class6.e((BindingFlags)class7.j(bindingFlags_4, methodBase_2, ref object_, parameterModifier_, null, (string[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, (CultureInfo)(object)Class5.Default), out *(object*)Class5.Default), null, (Type[])(object)Class5.Default, parameterModifier_), obj2, cultureInfo), (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).t(obj2, null, (CultureInfo)(object)Class5.Default), null, type_, array, (ParameterModifier[])(object)class2.t((BindingFlags)Class5.Default, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default)));
		}
		finally
		{
			checked
			{
				try
				{
					try
					{
						class2 = class2;
					}
					finally
					{
						gClass = null;
						gClass = gClass;
						goto end_IL_022a;
					}
					end_IL_022a:;
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, null)) - uIntPtr == 0)
					{
						@struct = @struct;
					}
					else
					{
						_ = (Class0)((Class7)null).t((object)null, type_, cultureInfo);
					}
				}
				goto IL_02b5;
			}
		}
		IL_3a4b:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class8);
		if (uIntPtr == 0)
		{
			Class7 obj8 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			class8 = (Class6)(object)obj8.j(bindingFlags, methodBase_, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out object_2);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class9);
		try
		{
			if (uIntPtr / checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
			{
				class9 = (Class10)(object)((Class7)(object)Class5.Default).W((BindingFlags)class2.t((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, type_, array, parameterModifier_), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), null, type_, (Type[])(object)Class5.Default, parameterModifier_);
			}
		}
		catch
		{
			while (obj2 != null)
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class10);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					class10 = (Class4)(object)Class5.Default;
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						class10 = null;
					}
					else
					{
						gClass2 = gClass2;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class12);
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo)) == (UIntPtr)(nuint)0u)
		{
			UIntPtr num = (UIntPtr)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref object_, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)class2.t(obj2, type_, null));
			BindingFlags bindingFlags_5 = (BindingFlags)Class5.Default;
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])class2.t(null, type_, null);
			Class7 class11 = class2;
			bindingFlags = default(BindingFlags);
			if ((nuint)num / (nuint)(UIntPtr)((Class7)null).j(bindingFlags_5, methodBase_, ref object_, parameterModifier_2, (CultureInfo)(object)class11.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, string_, out object_2), (string[])null, out object_2) == 0)
			{
				if (uIntPtr == 0)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			else
			{
				do
				{
					class12 = null;
				}
				while ((object)Class5.Default != null);
			}
		}
		else
		{
			_ = (GClass3)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				Class7 class13;
				do
				{
					gClass3 = (GClass0)(object)Class5.Default;
					class13 = class2;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class13.t(bindingFlags, fieldInfo_, obj2, cultureInfo) != null);
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class14);
		_003CModule_003E _003CModule_003E;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - (uIntPtr + (uIntPtr - uIntPtr)) == 0)
			{
				try
				{
					if (uIntPtr == 0)
					{
						_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					}
					else
					{
						class14 = null;
					}
				}
				finally
				{
					class2 = class2;
					goto IL_3d6b;
				}
			}
			goto IL_3d6b;
		}
		IL_20dd:
		try
		{
			class14 = class14;
			_ = (Struct2)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
		}
		catch
		{
			if (uIntPtr == 0)
			{
			}
		}
		do
		{
			try
			{
				Class7 class15;
				do
				{
					@class = @class;
					class15 = class2;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class15.W(bindingFlags, null, (Type)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_, parameterModifier_, cultureInfo, string_, out *(object*)null), array, parameterModifier_) != null);
			}
			finally
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					Class7 obj12 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_6 = bindingFlags;
					Class7 obj13 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_7 = bindingFlags;
					Class7 class16 = class2;
					Class7 class17 = class2;
					BindingFlags bindingFlags_8 = (BindingFlags)class2.j((BindingFlags)class2.W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default), null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
					Class7 class18 = class2;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_3 = (MethodBase[])(object)class18.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
					ref object[] object_3 = ref *(object[]*)Class5.Default;
					CultureInfo cultureInfo_ = (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out object_2);
					Class7 obj14 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj12.W(bindingFlags_6, (PropertyInfo[])((Class7)null).t((object)obj13.e(bindingFlags_7, (MethodBase[])class16.t(class17.j(bindingFlags_8, methodBase_3, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)obj14.j(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), ref object_, null, null, (string[])(object)Class5.Default, out object_2), out object_2), type_, cultureInfo), null, null), type_, (CultureInfo)(object)class2.j((BindingFlags)Class5.Default, null, ref object_, parameterModifier_, cultureInfo, string_, out object_2)), (Type)(object)Class5.Default, array, parameterModifier_);
				}
				continue;
			}
		}
		while (obj2 != null);
		checked
		{
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)(UIntPtr)((Class7)null).t(default(BindingFlags), fieldInfo_, obj2, cultureInfo) / (nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)) != 0)
				{
				}
			}
			else
			{
				do
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					catch
					{
						class14 = class14;
					}
				}
				while (obj2 != null);
			}
			_ = (GClass2)(object)Class5.Default;
		}
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					Class7 obj17 = (Class7)class2.t(obj2, type_, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_9 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
					Class7 obj18 = (Class7)((Class7)null).t(obj2, (Type)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref object_, parameterModifier_, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, cultureInfo), out *(object*)null), cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj17.j(bindingFlags_9, methodBase_4, ref *(object[]*)obj18.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, null), (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)class2.e(bindingFlags, null, (Type[])class2.t(obj2, type_, (CultureInfo)(object)class2.t(bindingFlags, fieldInfo_, obj2, cultureInfo)), parameterModifier_), (CultureInfo)null, string_, out object_2), out *(object*)class2.t(obj2, type_, cultureInfo));
				}
				while (obj2 != null);
			}
			else
			{
				Class7 class19 = class2;
				bindingFlags = default(BindingFlags);
				@struct = (Struct1)class19.t(((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null), type_, cultureInfo);
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			while (obj2 != null)
			{
				_ = (Class0)(object)class2.W((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2), null, type_, null, parameterModifier_);
			}
		}
		catch
		{
			_ = (Class9)(object)class2.e(bindingFlags, null, null, null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		try
		{
			do
			{
				@struct = @struct;
				class8 = class8;
			}
			while (obj2 != null || obj2 != null);
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					class9 = class9;
					gClass4 = gClass4;
					_ = (Class6)(object)Class5.Default;
					goto end_IL_2667;
				}
			}
			try
			{
				class9 = class9;
			}
			catch
			{
				gClass2 = gClass2;
			}
			end_IL_2667:;
		}
		_ = (_003CModule_003E)(object)class2.e((BindingFlags)((Class7)null).t((object)Class5.Default, type_, cultureInfo), methodBase_, (Type[])(object)Class5.Default, parameterModifier_);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class20);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				do
				{
					class20 = class20;
				}
				while (obj2 != null);
			}
		}
		try
		{
			try
			{
				try
				{
					Class7 class21 = class2;
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class22 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_11 = bindingFlags;
					Type type_2 = (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, (ParameterModifier[])null);
					Class7 class23 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_12 = bindingFlags;
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class21.j(bindingFlags_10, null, ref *(object[]*)class22.W(bindingFlags_11, null, type_2, array, (ParameterModifier[])(object)class23.W(bindingFlags_12, (PropertyInfo[])(object)class24.t(bindingFlags, (FieldInfo[])class2.t(null, type_, cultureInfo), null, null), type_, array, null)), null, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (Type[])(object)((Class7)(object)class2.e((BindingFlags)Class5.Default, methodBase_, null, parameterModifier_)).e(bindingFlags, methodBase_, null, parameterModifier_), null), string_, out *(object*)Class5.Default);
				}
				finally
				{
					class8 = (Class6)(object)Class5.Default;
					goto end_IL_2735;
				}
				end_IL_2735:;
			}
			catch
			{
				class10 = null;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				_ = (Qk7)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo);
				_ = (Class8)(object)((Class7)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, array, null);
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default == 0)
		{
			try
			{
				gClass4 = null;
			}
			finally
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null);
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
				goto IL_295e;
			}
		}
		try
		{
			class10 = class10;
		}
		catch
		{
			_ = (Class9)(object)Class5.Default;
		}
		goto IL_295e;
		IL_36b2:
		while (obj2 != null)
		{
			_ = (Class8)(object)Class5.Default;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Struct1)Class5.Default;
					@class = (Class2)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default);
					_ = (GClass3)(object)Class5.Default;
					class12 = null;
				}
				catch
				{
					class2 = class2;
				}
			}
		}
		finally
		{
			do
			{
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 class25 = class2;
				bindingFlags = default(BindingFlags);
				class14 = (Class8)(object)((Class7)null).W(bindingFlags_13, (PropertyInfo[])(object)class25.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), type_, array, (ParameterModifier[])(object)Class5.Default);
			}
			while (obj2 != null);
			goto IL_377f;
		}
		IL_02b5:
		while (obj2 != null)
		{
			try
			{
				@struct = @struct;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		_ = (Class8)(object)Class5.Default;
		_ = (Class6)(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(default(BindingFlags), fieldInfo_, (object)null, cultureInfo), null, (ParameterModifier[])(object)class2.j(default(BindingFlags), methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2));
		_ = (Class2)(object)Class5.Default;
		Class7 class26 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)class26.W(bindingFlags, null, null, null, (ParameterModifier[])(object)Class5.Default);
		try
		{
			UIntPtr num2 = (UIntPtr)Class5.Default;
			Class7 class27 = class2;
			BindingFlags bindingFlags_14 = bindingFlags;
			Class7 obj28 = (Class7)class2.t(Class5.Default, type_, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((nuint)num2 / (nuint)(UIntPtr)class27.W(bindingFlags_14, (PropertyInfo[])(object)((Class7)(object)obj28.t(bindingFlags, null, null, (CultureInfo)class2.t(null, type_, null))).j((BindingFlags)Class5.Default, methodBase_, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null), out *(object*)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo)), type_, (Type[])(object)Class5.Default, null) == 0)
			{
				@class = null;
			}
		}
		catch
		{
			Class7 class28 = class2;
			Class7 class29 = class2;
			bindingFlags = default(BindingFlags);
			Class0 obj29 = (Class0)class28.t(class29.e(bindingFlags, methodBase_, array, null), null, cultureInfo);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_15 = bindingFlags;
			Class7 class30 = class2;
			bindingFlags = default(BindingFlags);
			Type[] type_3 = (Type[])(object)class30.t(bindingFlags, null, obj2, cultureInfo);
			Class7 class31 = class2;
			BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default);
			object object_4 = class2.e((BindingFlags)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, null, out object_2), methodBase_, array, null);
			Class7 class32 = class2;
			BindingFlags bindingFlags_17 = bindingFlags;
			MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
			Class7 class33 = class2;
			bindingFlags = default(BindingFlags);
			Class7 obj30 = (Class7)(object)class33.j(bindingFlags, (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, methodBase_, ref object_, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)class2.W((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, parameterModifier_), (PropertyInfo[])(object)class2.t(bindingFlags, null, null, cultureInfo), (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default));
			Class7 class34 = class2;
			bindingFlags = default(BindingFlags);
			class20 = (Class0)(object)((Class7)null).W(bindingFlags_15, (PropertyInfo[])null, type_, type_3, (ParameterModifier[])(object)class31.t(bindingFlags_16, fieldInfo_2, object_4, (CultureInfo)class32.t(((Class7)null).j(bindingFlags_17, methodBase_5, ref *(object[]*)obj30.t((BindingFlags)class34.e(bindingFlags, methodBase_, (Type[])((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_)), parameterModifier_), null, obj2, null), (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2), type_, cultureInfo)));
			class20 = obj29;
			_ = (Struct2)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array, null));
			_ = (GClass0)(object)Class5.Default;
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (Class7)(object)Class5.Default;
			}
			goto IL_0755;
		}
		IL_377f:
		_ = (Class5)(object)((Class7)(object)class2.t(bindingFlags, null, obj2, null)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_), type_, null, null);
		_ = (GClass2)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_), (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null));
		do
		{
			_ = (Class9)(object)((Class7)(object)class2.j(bindingFlags, methodBase_, ref object_, null, (CultureInfo)(object)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo), null, (string[])(object)Class5.Default, out object_2), string_, out object_2)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, parameterModifier_, cultureInfo, string_, out object_2);
		}
		while (obj2 != null);
		gClass = gClass;
		try
		{
			try
			{
				while (obj2 != null)
				{
					class4 = null;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class14 = class14;
				}
				else
				{
					gClass4 = gClass4;
					gClass = null;
					gClass = null;
				}
				goto end_IL_38bb;
			}
			end_IL_38bb:;
		}
		finally
		{
			while (obj2 != null)
			{
				do
				{
					class4 = class4;
				}
				while (obj2 != null);
			}
			goto IL_3915;
		}
		IL_0755:
		do
		{
			try
			{
				struct2 = struct2;
				struct2 = struct2;
			}
			catch
			{
				while (obj2 != null)
				{
					Class7 class35 = class2;
					Type type_4 = (Type)(object)class2.t(bindingFlags, fieldInfo_, null, cultureInfo);
					Class7 class36 = class2;
					BindingFlags bindingFlags_18 = (BindingFlags)class2.j(default(BindingFlags), methodBase_, ref object_, null, null, string_, out *(object*)null);
					Class7 obj33 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
					Class7 class37 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_20 = bindingFlags;
					object object_5 = class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null), type_, null, parameterModifier_);
					Class7 class38 = class2;
					Class7 class39 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_21 = (BindingFlags)class39.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), null, out *(object*)Class5.Default);
					Class7 class40 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)class35.t(null, type_4, (CultureInfo)(object)class36.j(bindingFlags_18, null, ref *(object[]*)((Class7)null).t((object)obj33.W(bindingFlags_19, propertyInfo_, (Type)(object)class37.t(bindingFlags_20, fieldInfo_, object_5, (CultureInfo)(object)class38.j(bindingFlags_21, methodBase_, ref object_, null, (CultureInfo)(object)((Class7)(object)class40.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)null)).t(bindingFlags, fieldInfo_, obj2, cultureInfo), string_, out *(object*)null)), (Type[])(object)Class5.Default, (ParameterModifier[])(object)class2.e(bindingFlags, null, array, null)), type_, cultureInfo), parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_2));
					_ = (Struct1)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo);
					Class7 class41 = class2;
					bindingFlags = default(BindingFlags);
					Class4 obj34 = (Class4)(object)class41.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default);
					class10 = class10;
					class10 = obj34;
					class8 = (Class6)(object)((Class7)(object)class2.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)class2.t(bindingFlags, fieldInfo_, obj2, null), (string[])(object)class2.t(bindingFlags, fieldInfo_, obj2, cultureInfo), out *(object*)null)).t(bindingFlags, fieldInfo_, obj2, cultureInfo);
					class8 = null;
				}
			}
		}
		while ((object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out object_2) != null);
		try
		{
			_ = (Class6)class2.t(obj2, null, cultureInfo);
			gClass2 = (GClass1)(object)Class5.Default;
			gClass2 = gClass2;
			class20 = (Class0)(object)class2.j(bindingFlags, null, ref object_, null, cultureInfo, string_, out object_2);
		}
		finally
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					@struct = default(Struct1);
				}
			}
			goto IL_0afd;
		}
		IL_5940:
		while (obj2 != null)
		{
			class14 = class14;
			@class = null;
		}
		do
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class20 = null;
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
					_ = (Class8)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj2 != null);
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			BindingFlags bindingFlags_22 = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_23 = bindingFlags;
			Class7 obj37 = (Class7)class2.t(obj2, null, cultureInfo);
			BindingFlags bindingFlags_24 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags_22, propertyInfo_, (Type)(object)((Class7)null).e(bindingFlags_23, (MethodBase[])(object)obj37.e(bindingFlags_24, methodBase_, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)class2.t(null, type_, cultureInfo), array, (ParameterModifier[])null), null), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_)).e((BindingFlags)Class5.Default, (MethodBase[])(object)class2.t(bindingFlags, null, null, null), array, parameterModifier_)), array, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				class8 = null;
				@class = (Class2)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
			}
			else
			{
				_ = (Class10)((Class7)null).t((object)null, type_, cultureInfo);
			}
			return;
		}
		finally
		{
			try
			{
				@class = null;
				return;
			}
			finally
			{
				_ = (Class7)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, string_, out *(object*)Class5.Default);
				return;
			}
		}
		IL_552a:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					continue;
				}
				_ = (Struct1)Class5.Default;
				_ = (Class10)(object)Class5.Default;
				@struct = @struct;
			}
			while (obj2 != null);
		}
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class4 = null;
				}
			}
			finally
			{
				try
				{
					class8 = null;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
					_ = (Class0)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				goto end_IL_5582;
			}
			end_IL_5582:;
		}
		catch
		{
			do
			{
				_ = (Struct1)class2.t(obj2, null, (CultureInfo)(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_));
				_ = (GClass3)(object)Class5.Default;
				_ = (Class9)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, string_, out object_2), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)class2.t((BindingFlags)class2.t(obj2, (Type)(object)Class5.Default, cultureInfo), fieldInfo_, null, cultureInfo), out object_2);
				_ = (Class4)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
			}
			while ((object)Class5.Default != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				_ = Class5.Default;
			}
			else
			{
				Class7 class42 = class2;
				BindingFlags bindingFlags_25 = bindingFlags;
				Class7 class43 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)((Class7)(object)class42.W(bindingFlags_25, null, type_, (Type[])(object)class43.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, null, null, out object_2), (ParameterModifier[])((Class7)(object)class2.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)((Class7)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)).t(obj2, type_, null)).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo, string_, out *(object*)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])class2.t(obj2, type_, (CultureInfo)(object)Class5.Default))))).t(obj2, type_, cultureInfo))).t(obj2, type_, cultureInfo);
			}
		}
		else
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass2 = null;
				}
			}
			while (obj2 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Qk7)(object)Class5.Default;
		}
		else
		{
			_ = Class5.Default;
		}
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_, (ParameterModifier[])null, cultureInfo, (string[])null, out object_2);
					_ = (Qk7)(object)Class5.Default;
				}
			}
			finally
			{
				goto end_IL_5880;
			}
			end_IL_5880:;
		}
		finally
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					class2 = null;
				}
			}
			goto IL_58d9;
		}
		IL_0afd:
		Class7 obj40 = (Class7)(object)class2.j(bindingFlags, (MethodBase[])class2.t(obj2, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)class2.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo, string_, out *(object*)((Class7)null).j((BindingFlags)((Class7)null).t(obj2, type_, (CultureInfo)null), methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_, out object_2)), parameterModifier_, cultureInfo, string_, out *(object*)null);
		Type type_5 = (Type)(object)Class5.Default;
		BindingFlags bindingFlags_26 = bindingFlags;
		Class7 obj41 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)class2.t(default(BindingFlags), null, obj2, (CultureInfo)(object)Class5.Default), (object)null, cultureInfo);
		MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
		Class7 obj42 = (Class7)((Class7)null).t(obj2, type_, cultureInfo);
		bindingFlags = default(BindingFlags);
		_ = (Class5)obj40.t(null, type_5, (CultureInfo)(object)((Class7)null).j(bindingFlags_26, methodBase_, ref object_, (ParameterModifier[])(object)obj41.j(default(BindingFlags), methodBase_6, ref *(object[]*)obj42.t(bindingFlags, fieldInfo_, null, null), parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])null, out object_2)), (CultureInfo)null, (string[])null, out *(object*)null));
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				Class7 class44 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class44.t(bindingFlags, fieldInfo_, obj2, cultureInfo);
			}
			catch
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					@struct = @struct;
					goto end_IL_0cd6;
				}
				end_IL_0cd6:;
			}
		}
		else if ((UIntPtr)class2.W(bindingFlags, propertyInfo_, null, array, (ParameterModifier[])((Class7)((Class7)(object)Class5.Default).t(null, null, cultureInfo)).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)class2.j(bindingFlags, methodBase_, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)class2.t((BindingFlags)class2.j(bindingFlags, methodBase_, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out object_2), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), parameterModifier_)))) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)class2.e(bindingFlags, methodBase_, null, parameterModifier_);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		while ((object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, null, array, null)) != null)
		{
			qk = qk;
			qk = qk;
			class12 = null;
			class12 = class12;
			Class7 obj44 = (Class7)(object)Class5.Default;
			Class7 class45 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)obj44.W((BindingFlags)class45.W(bindingFlags, propertyInfo_, null, array, parameterModifier_), null, type_, array, parameterModifier_);
			class12 = class12;
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					class12 = (Class5)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, parameterModifier_);
				}
				catch
				{
					struct2 = default(Struct2);
					struct2 = struct2;
				}
			}
		}
		catch
		{
			do
			{
				gClass4 = gClass4;
				gClass4 = gClass4;
			}
			while (obj2 != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					Class7 class46 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class46.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_), null, obj2, cultureInfo);
				}
				while (obj2 != null);
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (GClass2)class2.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)class2.t(bindingFlags, null, null, cultureInfo));
				}
			}
		}
		else
		{
			do
			{
				_ = (GClass2)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_2), parameterModifier_, null, string_, out *(object*)null)).e(bindingFlags, methodBase_, array, null), string_, out object_2);
			}
			while ((object)Class5.Default != null || ((Class7)null).t((object)null, type_, cultureInfo) != null);
		}
		try
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Class5)(object)class2.e(bindingFlags, methodBase_, (Type[])(object)class2.e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, methodBase_, array, null), (Type[])class2.t(obj2, (Type)(object)class2.W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)Class5.Default)), null), (ParameterModifier[])class2.t(obj2, null, cultureInfo)), parameterModifier_);
					_ = (Class2)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, null, null);
				}
				finally
				{
					@struct = default(Struct1);
					@struct = @struct;
					goto end_IL_106e;
				}
				end_IL_106e:;
			}
			catch
			{
				do
				{
					Class7 class47 = class2;
					BindingFlags bindingFlags_27 = bindingFlags;
					BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
					Class7 class48 = class2;
					Class7 obj48 = (Class7)(object)class2.t((BindingFlags)Class5.Default, fieldInfo_, obj2, null);
					bindingFlags = default(BindingFlags);
					Type type_6 = (Type)(object)((Class7)null).W(bindingFlags_27, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_28, propertyInfo_, type_, (Type[])(object)((Class7)(object)class48.t((BindingFlags)obj48.e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_), (Type[])class2.t(obj2, type_, null), parameterModifier_), fieldInfo_, null, null)).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_), type_, array, parameterModifier_);
					Class7 class49 = class2;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass2)class47.t(null, type_6, (CultureInfo)(object)class49.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out object_2));
				}
				while ((object)Class5.Default != null);
			}
		}
		catch
		{
			do
			{
				_ = (GClass1)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		if (uIntPtr == 0)
		{
			UIntPtr num3 = (UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)null, (CultureInfo)class2.t(null, (Type)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, cultureInfo)), cultureInfo));
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num3) - uIntPtr == 0)
				{
					if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
					{
						_ = (Qk7)(object)((Class7)(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_)).t(bindingFlags, fieldInfo_, obj2, null);
					}
				}
				else
				{
					UIntPtr num4 = unchecked((UIntPtr)class2.t(null, type_, cultureInfo));
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num4) - uIntPtr == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
				}
			}
		}
		gClass4 = (GClass2)(object)Class5.Default;
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				class20 = (Class0)(object)Class5.Default;
			}
		}
		_ = (Class10)(object)Class5.Default;
		_ = (Qk7)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		try
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class9 = (Class10)(object)Class5.Default;
					class9 = class9;
				}
				else
				{
					gClass4 = (GClass2)(object)Class5.Default;
				}
			}
		}
		catch
		{
			class4 = class4;
		}
		_ = (Class0)(object)Class5.Default;
		try
		{
			gClass = gClass;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				catch
				{
					_ = (Class8)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null);
				}
			}
			else if (uIntPtr == 0)
			{
				_ = (Class9)(object)Class5.Default;
			}
			else
			{
				class2 = class2;
			}
		}
		try
		{
			nuint num5 = (nuint)(UIntPtr)class2.t((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, string_, out object_2), fieldInfo_, obj2, (CultureInfo)(object)Class5.Default) / (nuint)(UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_, obj2, cultureInfo);
			uIntPtr = default(UIntPtr);
			if (checked(num5 + (uIntPtr - uIntPtr)) == 0)
			{
				_ = (Class2)(object)Class5.Default;
			}
			else
			{
				_ = (GClass1)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
		}
		finally
		{
			_ = (Class10)(object)Class5.Default;
			goto IL_159e;
		}
		IL_51e7:
		struct2 = struct2;
		try
		{
			if (uIntPtr == 0)
			{
				do
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_29 = bindingFlags;
					Class7 class50 = class2;
					BindingFlags bindingFlags_30 = bindingFlags;
					Class7 obj55 = (Class7)(object)Class5.Default;
					Class7 class51 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj56 = (Class7)(object)((Class7)null).t(bindingFlags_29, fieldInfo_, obj2, (CultureInfo)(object)class50.t(bindingFlags_30, fieldInfo_, obj55.e((BindingFlags)class51.j(bindingFlags, methodBase_, ref object_, null, null, string_, out object_2), (MethodBase[])(object)class2.j(bindingFlags, methodBase_, ref object_, parameterModifier_, (CultureInfo)((Class7)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)).t(obj2, type_, (CultureInfo)(object)Class5.Default)).t(Class5.Default, type_, null), string_, out *(object*)null), array, parameterModifier_), cultureInfo));
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj56.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])(object)class2.t((BindingFlags)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), fieldInfo_, null, cultureInfo), (CultureInfo)((Class7)null).t(obj2, (Type)(object)((Class7)(object)class2.j((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)class2.t(bindingFlags, fieldInfo_, Class5.Default, null), obj2, cultureInfo), ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, string_, out object_2), ref object_, (ParameterModifier[])(object)class2.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), cultureInfo, (string[])class2.t(null, type_, cultureInfo), out *(object*)null), ref object_, parameterModifier_, cultureInfo, string_, out object_2)).j(bindingFlags, methodBase_, ref object_, parameterModifier_, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default), (string[])((Class7)null).t(obj2, (Type)null, cultureInfo), out *(object*)null), cultureInfo), string_, out *(object*)Class5.Default);
					class10 = null;
					_ = (Class9)(object)Class5.Default;
					_ = Class5.Default;
				}
				while (obj2 != null);
			}
			else if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		finally
		{
			try
			{
				do
				{
					gClass3 = gClass3;
				}
				while (obj2 != null);
			}
			catch
			{
				@class = @class;
			}
			goto IL_552a;
		}
		IL_1a4c:
		do
		{
			_ = (GClass0)class2.t(obj2, null, null);
		}
		while (obj2 != null);
		while (true)
		{
			if (obj2 != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass1)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default)).e(bindingFlags, (MethodBase[])(object)class2.W((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)Class5.Default), (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), null, parameterModifier_);
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		catch
		{
			qk = qk;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0 && checked(unchecked((nuint)(UIntPtr)class2.t(obj2, type_, cultureInfo)) + uIntPtr) == 0)
			{
				Class7 obj59 = (Class7)(object)class2.e(default(BindingFlags), methodBase_, array, null);
				Class7 class52 = class2;
				Class7 class53 = class2;
				Class7 class54 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class6)obj59.t(class52.e((BindingFlags)class53.t((BindingFlags)class54.t((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])class2.t(obj2, type_, cultureInfo), (CultureInfo)null, string_, out object_2), null, Class5.Default, cultureInfo), null, Class5.Default, null), (MethodBase[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, (ParameterModifier[])(object)Class5.Default), array, null), null, (CultureInfo)(object)Class5.Default);
			}
		}
		else if ((UIntPtr)class2.t(bindingFlags, fieldInfo_, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				@struct = (Struct1)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, Class5.Default, null)).W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_)).t(bindingFlags, fieldInfo_, ((Class7)null).t((object)class2.W(bindingFlags, (PropertyInfo[])class2.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), type_, array, parameterModifier_), type_, cultureInfo), (CultureInfo)(object)Class5.Default);
			}
			finally
			{
				class12 = class12;
				goto IL_1d56;
			}
		}
		goto IL_1d56;
		IL_4efa:
		checked
		{
			nuint num6 = unchecked((nuint)default(UIntPtr)) - unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)));
			nuint num7 = unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default)) + (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)));
			uIntPtr = default(UIntPtr);
			if (num6 * (num7 + uIntPtr) == 0)
			{
				Class7 class55 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class55.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, string_, out *unchecked((object*)Class5.Default));
			}
			else
			{
				_ = (Qk7)(object)unchecked(((Class7)class2.t(null, (Type)(object)class2.j((BindingFlags)Class5.Default, methodBase_, ref object_, parameterModifier_, cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)Class5.Default), out *(object*)null), (CultureInfo)(object)Class5.Default)).W((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)class2.e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), propertyInfo_, type_, array, parameterModifier_), propertyInfo_, type_, array, parameterModifier_));
			}
			try
			{
				try
				{
					class14 = (Class8)class2.t(obj2, type_, cultureInfo);
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					_ = (GClass0)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					_ = Class5.Default;
					goto end_IL_50bc;
				}
				end_IL_50bc:;
			}
			catch
			{
				do
				{
					class4 = class4;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					try
					{
						_ = (Struct2)class2.W(bindingFlags, propertyInfo_, null, array, parameterModifier_);
					}
					catch
					{
						_ = (Class0)(object)Class5.Default;
						@struct = @struct;
						gClass2 = gClass2;
					}
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr == 0)
					{
						Class7 class56 = class2;
						bindingFlags = default(BindingFlags);
						class12 = (Class5)(object)class56.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
						class8 = null;
						class14 = class14;
					}
					else
					{
						gClass2 = (GClass1)(object)Class5.Default;
					}
				}
				goto IL_51e7;
			}
		}
		IL_1d56:
		if (uIntPtr == 0)
		{
			try
			{
				if ((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)class2.t(null, type_, null), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo) / uIntPtr == 0)
				{
					class8 = null;
					_ = Class5.Default;
					bindingFlags = default(BindingFlags);
					class12 = (Class5)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, parameterModifier_);
					class9 = class9;
				}
			}
			catch
			{
				do
				{
					class12 = null;
				}
				while (obj2 != null);
			}
		}
		_ = (Class6)(object)class2.W(bindingFlags, null, type_, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_));
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				@struct = @struct;
			}
			else
			{
				_ = (GClass0)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), null);
			}
		}
		finally
		{
			try
			{
				do
				{
					gClass3 = (GClass0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				if (uIntPtr == 0)
				{
					Class7 class57 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class57.W(bindingFlags, (PropertyInfo[])class2.t(null, type_, null), null, array, parameterModifier_);
				}
			}
			goto IL_1ed8;
		}
		IL_58d9:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			class2 = class2;
			goto IL_5940;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
				{
					class9 = null;
				}
			}
			finally
			{
				struct2 = default(Struct2);
				struct2 = (Struct2)Class5.Default;
				class9 = null;
				goto IL_5940;
			}
		}
		IL_2e35:
		do
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
				_ = (Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo)).e((BindingFlags)class2.t(obj2, type_, cultureInfo), (MethodBase[])(object)Class5.Default, array, parameterModifier_);
				class9 = class9;
			}
			else
			{
				while (obj2 != null)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		while (obj2 != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				gClass3 = gClass3;
			}
			while (obj2 != null);
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class4 = null;
				_ = (GClass3)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				class20 = (Class0)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null), (CultureInfo)null);
					continue;
				}
				Class7 class58 = class2;
				Class7 class59 = class2;
				Class7 obj66 = (Class7)(object)class2.t(bindingFlags, fieldInfo_, null, null);
				BindingFlags bindingFlags_31 = bindingFlags;
				Class7 obj67 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_32 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
				BindingFlags bindingFlags_33 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class58.j((BindingFlags)class59.j((BindingFlags)obj66.t(bindingFlags_31, fieldInfo_, obj2, (CultureInfo)(object)obj67.j(bindingFlags_32, methodBase_7, ref *(object[]*)((Class7)null).W(bindingFlags_33, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, (ParameterModifier[])null), array, (ParameterModifier[])(object)Class5.Default), (Type)null, array, parameterModifier_), parameterModifier_, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), fieldInfo_, obj2, cultureInfo), string_, out *(object*)Class5.Default)), methodBase_, ref object_, null, cultureInfo, null, out *(object*)null), null, ref *(object[]*)null, parameterModifier_, cultureInfo, string_, out object_2);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)class2.W(bindingFlags, null, null, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_, (CultureInfo)null, string_, out object_2)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)class2.e(bindingFlags, null, (Type[])(object)class2.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_), parameterModifier_), null, (Type[])class2.t(obj2, null, cultureInfo), parameterModifier_);
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, string_, out *(object*)class2.t(obj2, null, cultureInfo));
				continue;
			}
			BindingFlags bindingFlags_34 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
			Class7 class60 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_35 = bindingFlags;
			Class7 obj68 = (Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
			Class7 class61 = class2;
			BindingFlags bindingFlags_36 = bindingFlags;
			Class7 class62 = class2;
			Class7 obj69 = (Class7)(object)class2.e(bindingFlags, null, null, parameterModifier_);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_37 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_, (ParameterModifier[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)((Class7)null).t((object)Class5.Default, type_, cultureInfo), (Type[])(object)Class5.Default, parameterModifier_), null, array, parameterModifier_), null, string_, out object_2)).W(default(BindingFlags), propertyInfo_, null, array, (ParameterModifier[])class2.t(null, null, null));
			Class7 class63 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 class64 = class2;
			BindingFlags bindingFlags_39 = bindingFlags;
			ref object[] object_6 = ref *(object[]*)class2.j((BindingFlags)Class5.Default, null, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out object_2);
			CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
			Class7 class65 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_40 = bindingFlags;
			FieldInfo[] fieldInfo_4 = (FieldInfo[])((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])null, parameterModifier_)).t(obj2, null, (CultureInfo)(object)Class5.Default);
			Class7 obj70 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).W(bindingFlags_34, propertyInfo_2, (Type)(object)class60.W(bindingFlags_35, null, null, null, (ParameterModifier[])obj68.t(obj2, null, (CultureInfo)(object)class61.j(bindingFlags_36, methodBase_, ref *(object[]*)null, null, null, (string[])(object)((Class7)class62.t(((Class7)null).t((object)obj69.t(bindingFlags_37, fieldInfo_3, class63.j(bindingFlags_38, methodBase_, ref *(object[]*)class64.j(bindingFlags_39, null, ref object_6, parameterModifier_, cultureInfo_2, (string[])(object)((Class7)null).t((BindingFlags)class65.t(bindingFlags_40, fieldInfo_4, null, (CultureInfo)(object)obj70.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, null, cultureInfo, string_, out *(object*)Class5.Default)), (FieldInfo[])null, (object)null, cultureInfo), out *(object*)null), parameterModifier_, null, string_, out object_2), cultureInfo), (Type)(object)Class5.Default, cultureInfo), null, cultureInfo)).e(bindingFlags, null, null, parameterModifier_), out object_2))), array, parameterModifier_) == null)
			{
				break;
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					gClass = gClass;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
					class20 = class20;
					Class7 class66 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class66.t(((Class7)null).j(bindingFlags, methodBase_, ref object_, parameterModifier_, (CultureInfo)(object)class2.W((BindingFlags)Class5.Default, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default), (string[])(object)Class5.Default, out object_2), type_, (CultureInfo)(object)class2.j(bindingFlags, null, ref object_, parameterModifier_, null, string_, out *(object*)class2.t((BindingFlags)Class5.Default, fieldInfo_, ((Class7)null).t(obj2, type_, (CultureInfo)null), cultureInfo)));
				}
			}
		}
		do
		{
			_ = (Class4)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, parameterModifier_);
		}
		while (obj2 != null);
		class4 = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default);
		gClass4 = gClass4;
		try
		{
			_ = (Struct2)Class5.Default;
			qk = null;
			gClass3 = gClass3;
		}
		catch
		{
			_ = (Struct1)((Class7)null).t(obj2, type_, (CultureInfo)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_));
			_ = (Class8)(object)Class5.Default;
			_ = (Class4)(object)class2.t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo);
		}
		finally
		{
			try
			{
				struct2 = struct2;
				@struct = @struct;
				Class7 obj73 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj73.t(bindingFlags, fieldInfo_, obj2, cultureInfo);
			}
			catch
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				_ = (Class0)(object)class2.t((BindingFlags)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo), fieldInfo_, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_, parameterModifier_, null, string_, out object_2));
				goto IL_36b2;
			}
		}
		IL_159e:
		while (true)
		{
			if (obj2 != null)
			{
				gClass4 = null;
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, null, string_, out object_2), out object_2);
			}
			else
			{
				class10 = null;
			}
		}
		else
		{
			do
			{
				_ = (Class4)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		if (checked(unchecked((nuint)(UIntPtr)class2.j((BindingFlags)Class5.Default, methodBase_, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2)) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			while (obj2 != null)
			{
				Class7 obj75 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				gClass = (GClass3)(object)obj75.e(bindingFlags, methodBase_, null, null);
				_ = (_003CModule_003E)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, array, parameterModifier_)).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo);
				Class7 obj76 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_41 = bindingFlags;
				Class7 obj77 = (Class7)(object)((Class7)(object)class2.t(default(BindingFlags), null, null, cultureInfo)).t((BindingFlags)Class5.Default, fieldInfo_, obj2, cultureInfo);
				bindingFlags = default(BindingFlags);
				Class7 obj78 = (Class7)(object)((Class7)null).W(default(BindingFlags), propertyInfo_, (Type)null, (Type[])(object)obj77.t(bindingFlags, (FieldInfo[])class2.t(null, type_, null), Class5.Default, null), (ParameterModifier[])null);
				BindingFlags bindingFlags_42 = (BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
				Class7 class67 = class2;
				Class7 class68 = class2;
				BindingFlags bindingFlags_43 = bindingFlags;
				BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
				BindingFlags bindingFlags_45 = (BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])class2.t(obj2, type_, cultureInfo)));
				Type[] type_7 = (Type[])(object)Class5.Default;
				Class7 class69 = class2;
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags_45, propertyInfo_, type_, type_7, (ParameterModifier[])(object)class69.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_));
				Class7 class70 = class2;
				BindingFlags bindingFlags_46 = (BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), (Type[])null, (ParameterModifier[])null);
				Class7 class71 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj79 = (Class7)(object)obj76.W(bindingFlags_41, propertyInfo_, type_, (Type[])(object)obj78.j(bindingFlags_42, null, ref *(object[]*)null, parameterModifier_, null, string_, out *(object*)class67.t(null, null, (CultureInfo)(object)class68.W(bindingFlags_43, propertyInfo_, type_, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_44, propertyInfo_3, type_, (Type[])(object)class70.j(bindingFlags_46, null, ref *(object[]*)class71.e(bindingFlags, methodBase_, null, parameterModifier_), parameterModifier_, null, (string[])(object)((Class7)(object)Class5.Default).e((BindingFlags)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_), null, null, (ParameterModifier[])(object)Class5.Default), out object_2), parameterModifier_)))), null);
				bindingFlags = default(BindingFlags);
				gClass = (GClass3)(object)obj79.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, null, string_, out object_2);
			}
		}
		try
		{
			while (((Class7)((Class7)null).t(obj2, type_, (CultureInfo)null)).t(null, type_, cultureInfo) != null)
			{
				_ = Class5.Default;
			}
		}
		catch
		{
			try
			{
				@class = @class;
			}
			finally
			{
				_ = (Class0)(object)Class5.Default;
				goto end_IL_19e7;
			}
			end_IL_19e7:;
		}
		finally
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
				_ = (Class10)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_);
			}
			catch
			{
				while (obj2 != null)
				{
					class20 = class20;
				}
			}
			goto IL_1a4c;
		}
		IL_2d56:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				class9 = class9;
			}
			catch
			{
				qk = null;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class9 = null;
				}
				goto IL_2e35;
			}
		}
		goto IL_2e35;
		IL_3915:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
					qk = qk;
					_ = (Class7)(object)Class5.Default;
					Class7 obj83 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj83.t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, (PropertyInfo[])class2.t(obj2, type_, cultureInfo), type_, array, null), null, null);
				}
				else
				{
					class12 = null;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			class9 = (Class10)(object)Class5.Default;
			class10 = class10;
			class10 = null;
			goto IL_3a4b;
		}
		try
		{
			struct2 = struct2;
		}
		catch
		{
			_ = (GClass2)(object)class2.j(default(BindingFlags), methodBase_, ref object_, parameterModifier_, null, string_, out object_2);
		}
		finally
		{
			Class7 class72 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class72.t(bindingFlags, null, obj2, cultureInfo);
			goto IL_3a4b;
		}
		IL_1ed8:
		try
		{
			do
			{
				Class7 class73 = class2;
				bindingFlags = default(BindingFlags);
				class14 = (Class8)(object)class73.e(bindingFlags, null, null, parameterModifier_);
				class14 = null;
			}
			while (obj2 != null || obj2 != null);
		}
		catch
		{
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class9)((Class7)null).t((object)Class5.Default, type_, (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)class2.t(bindingFlags, fieldInfo_, obj2, cultureInfo)));
			}
			else
			{
				do
				{
					_ = (Qk7)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		catch
		{
			while (obj2 != null)
			{
			}
		}
		checked
		{
			do
			{
				try
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
					}
					finally
					{
						qk = null;
						goto end_IL_1fac;
					}
					end_IL_1fac:;
				}
				finally
				{
					nuint num8 = uIntPtr;
					UIntPtr num9 = unchecked((UIntPtr)class2.e((BindingFlags)((Class7)class2.t(obj2, type_, null)).t(obj2, (Type)(object)Class5.Default, cultureInfo), (MethodBase[])(object)Class5.Default, null, null));
					uIntPtr = default(UIntPtr);
					if (num8 * (unchecked((nuint)num9) * uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default)) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						qk = null;
					}
					else
					{
						class2 = null;
					}
					continue;
				}
			}
			while ((object)Class5.Default != null);
			qk = qk;
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) * (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					try
					{
						Class7 class74 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class4)(object)class74.t(bindingFlags, null, Class5.Default, cultureInfo);
					}
					catch
					{
						_ = Class5.Default;
					}
					goto IL_20dd;
				}
			}
			goto IL_20dd;
		}
		IL_295e:
		do
		{
			_003CModule_003E = null;
			_003CModule_003E = null;
		}
		while (obj2 != null);
		try
		{
			do
			{
				try
				{
					_ = (Struct2)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					@class = @class;
				}
				finally
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo), null, cultureInfo, string_, out *(object*)null);
					Class7 obj88 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
					Class7 class75 = class2;
					BindingFlags bindingFlags_48 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_49 = (BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])null, (ParameterModifier[])null);
					Class7 obj89 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_50 = bindingFlags;
					Class7 class76 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj90 = (Class7)((Class7)((Class7)(object)obj88.W(bindingFlags_47, propertyInfo_4, type_, (Type[])(object)class75.t(bindingFlags_48, (FieldInfo[])(object)((Class7)null).W(bindingFlags_49, propertyInfo_, (Type)(object)obj89.t(bindingFlags_50, (FieldInfo[])((Class7)(object)class76.j(bindingFlags, (MethodBase[])(object)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)((Class7)(object)Class5.Default).t(null, type_, null), array, null), ref object_, parameterModifier_, cultureInfo, string_, out *(object*)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, Class5.Default, (CultureInfo)(object)Class5.Default))).t(obj2, type_, cultureInfo), obj2, null), array, parameterModifier_), ((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo), cultureInfo), parameterModifier_)).t(obj2, type_, cultureInfo)).t(obj2, type_, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					FieldInfo[] fieldInfo_5 = (FieldInfo[])((Class7)(object)Class5.Default).t(class2.t(obj2, type_, cultureInfo), type_, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj90.t(bindingFlags_51, fieldInfo_5, ((Class7)null).t(bindingFlags_52, (FieldInfo[])null, obj2, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.W(bindingFlags, null, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (string[])null, out object_2)), cultureInfo);
					continue;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
				try
				{
					gClass = gClass;
					_ = (Class9)class2.t(obj2, type_, null);
				}
				catch
				{
					gClass3 = gClass3;
				}
			}
			catch
			{
				try
				{
					_ = (Struct1)class2.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, string_, out object_2);
					qk = qk;
					_ = (Class10)(object)Class5.Default;
					_ = (Class6)(object)class2.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)class2.j(bindingFlags, methodBase_, ref object_, parameterModifier_, cultureInfo, string_, out object_2), (CultureInfo)(object)Class5.Default), array, parameterModifier_);
				}
				catch
				{
					gClass2 = null;
					class8 = class8;
				}
			}
			goto IL_2d56;
		}
		IL_3d6b:
		gClass2 = gClass2;
		_ = (Struct2)class2.e(bindingFlags, null, null, parameterModifier_);
		try
		{
			if ((UIntPtr)class2.t(bindingFlags, fieldInfo_, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				class10 = class10;
			}
		}
		catch
		{
			@struct = default(Struct1);
			struct2 = struct2;
		}
		qk = qk;
		try
		{
			try
			{
				class9 = (Class10)(object)Class5.Default;
			}
			finally
			{
				while (obj2 != null)
				{
					BindingFlags bindingFlags_53 = bindingFlags;
					Class7 class77 = class2;
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 class78 = class2;
					BindingFlags bindingFlags_55 = bindingFlags;
					Type[] type_8 = (Type[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_56 = bindingFlags;
					Class7 obj95 = (Class7)(object)Class5.Default;
					Class7 obj96 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_57 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj97 = (Class7)(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, string_, out object_2);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).t(bindingFlags_53, fieldInfo_, (object)null, (CultureInfo)(object)class77.W(bindingFlags_54, null, (Type)(object)class78.e(bindingFlags_55, methodBase_, type_8, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_56, (MethodBase[])null, ref object_, (ParameterModifier[])((Class7)(object)obj95.W((BindingFlags)obj96.W(bindingFlags_57, propertyInfo_5, type_, (Type[])(object)((Class7)(object)obj97.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)((Class7)null).t((object)class2.W(bindingFlags, (PropertyInfo[])(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo, string_, out *(object*)null), type_, null, parameterModifier_), type_, cultureInfo), (Type[])(object)Class5.Default, null), parameterModifier_), null, null, null, null)).t(obj2, (Type)(object)Class5.Default, cultureInfo), cultureInfo, string_, out object_2)), null, (ParameterModifier[])(object)Class5.Default));
				}
				goto end_IL_3ddb;
			}
			end_IL_3ddb:;
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
		}
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					@struct = @struct;
					continue;
				}
			}
			while ((object)class2.t((BindingFlags)Class5.Default, fieldInfo_, null, (CultureInfo)(object)Class5.Default) != null);
		}
		else if (uIntPtr == 0)
		{
			do
			{
				_ = (Class2)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		else
		{
			_ = (Struct2)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
		}
		do
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class10 = (Class4)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					gClass = (GClass3)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		try
		{
			_ = (Class0)(object)((Class7)((Class7)null).t((object)class2.e(bindingFlags, methodBase_, (Type[])(object)class2.t(bindingFlags, null, obj2, cultureInfo), (ParameterModifier[])(object)Class5.Default), type_, (CultureInfo)(object)Class5.Default)).j(bindingFlags, methodBase_, ref object_, null, cultureInfo, string_, out object_2);
		}
		catch
		{
			@class = null;
			_ = (Class4)class2.t(obj2, type_, null);
			qk = null;
		}
		@class = null;
		while (obj2 != null)
		{
			try
			{
				do
				{
					qk = (Qk7)(object)class2.j((BindingFlags)Class5.Default, methodBase_, ref object_, null, null, string_, out object_2);
				}
				while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, (ParameterModifier[])null) != null);
			}
			finally
			{
				qk = null;
				continue;
			}
		}
		do
		{
			try
			{
				Class7 class80;
				BindingFlags bindingFlags_58;
				Class7 obj101;
				BindingFlags bindingFlags_59;
				PropertyInfo[] propertyInfo_6;
				BindingFlags bindingFlags_60;
				Type[] type_9;
				Class7 obj102;
				BindingFlags bindingFlags_61;
				MethodBase[] methodBase_8;
				CultureInfo cultureInfo_3;
				string[] string_2;
				do
				{
					Class7 class79 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class79.e(bindingFlags, methodBase_, null, null);
					class80 = class2;
					bindingFlags_58 = bindingFlags;
					obj101 = (Class7)(object)Class5.Default;
					bindingFlags_59 = (BindingFlags)Class5.Default;
					propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
					bindingFlags_60 = bindingFlags;
					type_9 = (Type[])(object)Class5.Default;
					obj102 = (Class7)(object)Class5.Default;
					bindingFlags_61 = bindingFlags;
					methodBase_8 = (MethodBase[])class2.t(null, type_, cultureInfo);
					cultureInfo_3 = cultureInfo;
					string_2 = (string[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class80.j(bindingFlags_58, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)obj101.W(bindingFlags_59, propertyInfo_6, null, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_60, (MethodBase[])null, type_9, (ParameterModifier[])(object)obj102.j(bindingFlags_61, methodBase_8, ref object_, parameterModifier_, cultureInfo_3, string_2, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])class2.t(obj2, type_, cultureInfo), type_, array, (ParameterModifier[])null)))), cultureInfo, string_, out object_2) != null);
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
					{
						class9 = class9;
						continue;
					}
					class2 = null;
					_ = (Class8)(object)((Class7)class2.t(obj2, null, cultureInfo)).W(bindingFlags, propertyInfo_, type_, null, parameterModifier_);
					continue;
				}
			}
		}
		while (obj2 != null);
		@struct = @struct;
		_ = (Qk7)(object)Class5.Default;
		try
		{
			_ = (Qk7)(object)((Class7)(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_)).t(bindingFlags, fieldInfo_, null, null);
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					class20 = class20;
				}
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (class2.t(null, (Type)(object)Class5.Default, cultureInfo) != null)
				{
					_ = (Class5)(object)class2.j((BindingFlags)Class5.Default, methodBase_, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				}
			}
			else
			{
				try
				{
					gClass = gClass;
				}
				catch
				{
					BindingFlags bindingFlags_62 = bindingFlags;
					CultureInfo cultureInfo_4 = (CultureInfo)(object)Class5.Default;
					Class7 obj105 = (Class7)((Class7)null).t((object)Class5.Default, (Type)(object)class2.W((BindingFlags)class2.e(bindingFlags, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), (ParameterModifier[])(object)class2.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_)), propertyInfo_, null, null, null), (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)class2.W(bindingFlags, propertyInfo_, type_, null, null), type_, (Type[])null, (ParameterModifier[])null));
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass2)(object)((Class7)null).j(bindingFlags_62, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_4, (string[])(object)obj105.j((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, cultureInfo), methodBase_, ref *(object[]*)class2.e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, (ParameterModifier[])(object)((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2), methodBase_, null, null)).e(bindingFlags, methodBase_, array, parameterModifier_), null, null, out *(object*)Class5.Default), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)), parameterModifier_, cultureInfo, null, out object_2), out object_2);
				}
			}
		}
		catch
		{
			try
			{
				_ = (GClass2)(object)class2.W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, null);
			}
			catch
			{
				if (uIntPtr == 0)
				{
					class12 = null;
				}
				else
				{
					_ = (Class10)(object)class2.t(bindingFlags, null, obj2, cultureInfo);
				}
			}
		}
		while (obj2 != null)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (GClass3)(object)((Class7)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)).j(bindingFlags, methodBase_, ref object_, null, cultureInfo, string_, out *(object*)null);
					struct2 = struct2;
				}
				while (obj2 != null);
			}
		}
		if ((UIntPtr)((Class7)null).e(bindingFlags, methodBase_, array, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			while ((object)((Class7)null).j((BindingFlags)class2.t(obj2, null, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)null, (string[])null, out *(object*)null) != null)
			{
				@class = @class;
			}
		}
		if ((UIntPtr)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class4 = class4;
			}
			catch
			{
				try
				{
					_ = Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					goto end_IL_4753;
				}
				end_IL_4753:;
			}
		}
		else
		{
			try
			{
			}
			catch
			{
				qk = (Qk7)(object)Class5.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					gClass4 = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (Class6)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)class2.e(bindingFlags, methodBase_, array, parameterModifier_));
				}
			}
		}
		else
		{
			class8 = class8;
			qk = (Qk7)(object)Class5.Default;
			_ = (Class10)(object)class2.e(bindingFlags, null, null, null);
			class14 = (Class8)(object)Class5.Default;
		}
		while (obj2 != null)
		{
			while (true)
			{
				Class7 class81 = class2;
				BindingFlags bindingFlags_63 = bindingFlags;
				Class7 class82 = class2;
				Class7 class83 = class2;
				bindingFlags = default(BindingFlags);
				if ((object)class81.e(bindingFlags_63, (MethodBase[])(object)((Class7)class82.t(obj2, (Type)(object)class83.W(bindingFlags, propertyInfo_, null, array, parameterModifier_), null)).j(bindingFlags, null, ref object_, parameterModifier_, null, (string[])class2.t(obj2, type_, cultureInfo), out *(object*)null), array, (ParameterModifier[])class2.t(obj2, (Type)(object)class2.t(bindingFlags, fieldInfo_, null, cultureInfo), cultureInfo)) == null)
				{
					break;
				}
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)Class5.Default;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class12 = class12;
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (Class6)class2.t(obj2, type_, cultureInfo);
					gClass = gClass;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					class14 = null;
				}
			}
		}
		gClass3 = (GClass0)(object)Class5.Default;
		class9 = class9;
		_ = (Class2)(object)Class5.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		try
		{
			gClass4 = null;
		}
		catch
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)class2.t(Class5.Default, type_, (CultureInfo)(object)((Class7)class2.t(class2.e(bindingFlags, methodBase_, array, parameterModifier_), type_, cultureInfo)).e((BindingFlags)class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)class2.e((BindingFlags)class2.j((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_)).t(((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, cultureInfo), methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, string_, out object_2), (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, methodBase_, array, null), (Type[])(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, null), parameterModifier_), (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type_, (CultureInfo)(object)Class5.Default))).t(bindingFlags, null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)), (Type)(object)class2.e(bindingFlags, methodBase_, null, parameterModifier_), array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj2, cultureInfo)), null, array, parameterModifier_));
				}
				else
				{
					class2 = class2;
				}
			}
			while (obj2 != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				_ = (Class7)(object)Class5.Default;
				Class7 class84 = class2;
				BindingFlags bindingFlags_64 = bindingFlags;
				BindingFlags bindingFlags_65 = bindingFlags;
				Class7 class85 = class2;
				bindingFlags = default(BindingFlags);
				object object_7 = ((Class7)(object)class85.e(bindingFlags, null, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.e(bindingFlags, (MethodBase[])(object)class2.j(default(BindingFlags), methodBase_, ref object_, null, (CultureInfo)((Class7)null).t((object)Class5.Default, type_, cultureInfo), null, out *(object*)null), (Type[])((Class7)null).t(obj2, type_, (CultureInfo)null), (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type_, null, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)Class5.Default, null, cultureInfo, string_, out *(object*)null))).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).j(default(BindingFlags), methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)null), obj2, cultureInfo);
				Class7 obj113 = (Class7)(object)Class5.Default;
				Class7 class86 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class84.t(bindingFlags_64, (FieldInfo[])(object)((Class7)null).t(bindingFlags_65, fieldInfo_, object_7, (CultureInfo)obj113.t(null, (Type)(object)((Class7)(object)class86.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), cultureInfo)), obj2, cultureInfo);
				class10 = class10;
			}
			goto IL_4efa;
		}
		try
		{
			while (true)
			{
				Class7 obj115 = (Class7)(object)class2.j(bindingFlags, methodBase_, ref object_, parameterModifier_, cultureInfo, string_, out *(object*)null);
				bindingFlags = default(BindingFlags);
				if ((object)obj115.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default) != null)
				{
					gClass3 = gClass3;
					@class = @class;
					_ = (Struct1)Class5.Default;
					_ = (_003CModule_003E)(object)class2.e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
					continue;
				}
				break;
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class4 = (Class9)(object)Class5.Default;
			}
			else
			{
				qk = (Qk7)(object)Class5.Default;
			}
			goto IL_4efa;
		}
	}

	unsafe static void smethod_3()
	{
		try
		{
			_ = (Class4)(object)Class5.Default;
		}
		finally
		{
			goto IL_000f;
		}
		IL_000f:
		_ = (Class6)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class8)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, parameterModifier_);
			@class = @class;
			gClass = gClass;
			gClass = gClass;
			Class4 obj2 = (Class4)((Class7)null).t(obj, (Type)(object)@class.e(bindingFlags, methodBase_, array, null), cultureInfo_);
			class2 = (Class4)(object)Class5.Default;
			class2 = obj2;
		}
		else
		{
			_ = (Class9)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array, (ParameterModifier[])(object)Class5.Default);
			BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
			Class7 obj3 = (Class7)((Class7)null).t((object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), type_, (CultureInfo)(object)Class5.Default);
			Class7 class3 = @class;
			Class7 class4 = @class;
			BindingFlags bindingFlags_2 = bindingFlags;
			Type[] type_2 = (Type[])(object)Class5.Default;
			Class7 obj4 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Type[] type_3 = (Type[])(object)obj3.e((BindingFlags)class3.t(obj, (Type)(object)class4.e(bindingFlags_2, null, type_2, (ParameterModifier[])(object)obj4.t(bindingFlags, null, null, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, null), (object)null, cultureInfo_))), cultureInfo_), methodBase_, null, null);
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class5 = @class;
			BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
			array2 = (FieldInfo[])(object)((Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default)).W(bindingFlags, propertyInfo_, type_, null, null);
			_ = (Struct1)((Class7)null).e(bindingFlags_, (MethodBase[])null, type_3, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_3, propertyInfo_, type_, (Type[])(object)class5.t(bindingFlags_4, array2, Class5.Default, cultureInfo_), parameterModifier_));
		}
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (Class9)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null), (ParameterModifier[])null);
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					Struct1 obj5 = (Struct1)Class5.Default;
					Class7 obj6 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_5 = bindingFlags;
					ref object[] object_ = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					Class7 obj7 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj8 = (Class7)(object)obj6.W((BindingFlags)((Class7)null).j(bindingFlags_5, methodBase_, ref object_, parameterModifier_2, (CultureInfo)(object)obj7.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), (string[])@class.t(obj, type_, cultureInfo_), out object_2), null, type_, array, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					Class7 obj9 = (Class7)(object)Class5.Default;
					Class7 class6 = @class;
					Class7 class7 = @class;
					BindingFlags bindingFlags_7 = bindingFlags;
					Class7 obj10 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj11 = (Class7)(object)((Class7)null).t(bindingFlags_7, (FieldInfo[])(object)obj10.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, parameterModifier_), obj, cultureInfo_);
					Class7 class8 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					Class7 obj12 = (Class7)(object)Class5.Default;
					Class7 class9 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_9 = (BindingFlags)obj11.t((BindingFlags)class8.j(bindingFlags_8, methodBase_, ref object_3, null, (CultureInfo)(object)obj12.e((BindingFlags)class9.t(bindingFlags, null, Class5.Default, cultureInfo_), methodBase_, array, parameterModifier_), string_, out *(object*)Class5.Default), array2, obj, null);
					Class7 obj13 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj14 = (Class7)(object)obj8.j(bindingFlags_6, methodBase_, ref *(object[]*)obj9.W((BindingFlags)class6.W((BindingFlags)class7.W(bindingFlags_9, propertyInfo_, null, (Type[])(object)obj13.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_), null, type_, (Type[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_), null), propertyInfo_, type_, null, parameterModifier_), parameterModifier_, null, (string[])(object)Class5.Default, out object_2);
					bindingFlags = default(BindingFlags);
					@struct = (Struct1)obj14.e(bindingFlags, methodBase_, array, parameterModifier_);
					@struct = obj5;
					goto end_IL_0257;
				}
				end_IL_0257:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
				}
				goto IL_0572;
			}
		}
		goto IL_0572;
		IL_1101:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class11);
		try
		{
			try
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, (Type[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array, null), (ParameterModifier[])((Class7)null).t(obj, type_, (CultureInfo)(object)Class5.Default)) == (UIntPtr)(nuint)0u)
				{
					Class7 class10 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class10.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_);
				}
			}
			finally
			{
				try
				{
					class11 = class11;
				}
				finally
				{
					class12 = (Class10)(object)@class.t((BindingFlags)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_), array2, Class5.Default, cultureInfo_);
					goto end_IL_1102;
				}
			}
			end_IL_1102:;
		}
		finally
		{
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)class13.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo_), cultureInfo_)).e(default(BindingFlags), null, array, parameterModifier_), array, (ParameterModifier[])(object)((Class7)null).W(default(BindingFlags), propertyInfo_, type_, (Type[])null, (ParameterModifier[])null));
			goto IL_1298;
		}
		IL_0d14:
		while (obj != null)
		{
			do
			{
				class12 = (Class10)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		Class7 obj15 = (Class7)(object)@class.e((BindingFlags)((Class7)null).t((object)null, type_, cultureInfo_), null, array, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)obj15.W(bindingFlags, null, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)) + num) == 0)
		{
			_ = (GClass3)(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_);
		}
		else
		{
			while (obj != null)
			{
				Class7 class14 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = bindingFlags;
				MethodBase[] methodBase_2 = (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				Class7 obj16 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, type_, (CultureInfo)(object)Class5.Default), type_, null, parameterModifier_);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class14.e(bindingFlags_10, methodBase_2, (Type[])(object)obj16.j(bindingFlags, null, ref object_3, parameterModifier_, null, null, out object_2), parameterModifier_) == (UIntPtr)(nuint)0u)
				{
					_ = Class5.Default;
				}
			}
		}
		_ = (Class10)(object)Class5.Default;
		while (obj != null)
		{
			try
			{
				_ = (Class8)((Class7)null).t((object)null, (Type)null, (CultureInfo)null);
			}
			finally
			{
				gClass = (GClass2)(object)Class5.Default;
				continue;
			}
		}
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (GClass2)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, cultureInfo_);
				}
				else
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
			finally
			{
				gClass = gClass;
				_ = (Class10)((Class7)null).t(obj, type_, (CultureInfo)(object)Class5.Default);
				goto end_IL_0e93;
			}
			end_IL_0e93:;
		}
		catch
		{
			do
			{
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class15.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, array, parameterModifier_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class16);
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (checked(num + num) / num / checked(unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, parameterModifier_))) == 0)
				{
					_ = (Struct1)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)@class.t(bindingFlags, array2, obj, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type_, cultureInfo_), array, parameterModifier_)), out object_2)).e(bindingFlags, methodBase_, null, parameterModifier_);
				}
				else
				{
					class16 = (Class9)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])(object)@class.j(bindingFlags, (MethodBase[])@class.t(obj, type_, cultureInfo_), ref object_3, null, null, null, out *(object*)null), out object_2);
					class16 = class16;
				}
			}
			finally
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					gClass2 = (GClass1)(object)Class5.Default;
					class16 = class16;
					class11 = class11;
					class11 = class11;
					_ = (GClass3)(object)Class5.Default;
					goto IL_1101;
				}
			}
		}
		goto IL_1101;
		IL_2a8f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj != null)
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (_003CModule_003E)(object)((Class7)null).W(default(BindingFlags), propertyInfo_, type_, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					_ = (Struct1)Class5.Default;
					_003CModule_003E = null;
				}
			}
			finally
			{
				_ = (Class2)(object)Class5.Default;
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class17);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					class17 = null;
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
			_003CModule_003E = _003CModule_003E;
		}
		_ = (Struct1)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while ((object)Class5.Default != null)
				{
					gClass3 = (GClass3)(object)Class5.Default;
				}
				continue;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass2 = gClass2;
			}
		}
		_ = (Qk7)((Class7)null).t((object)@class.e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default)), type_, cultureInfo_);
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
		class11 = null;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array2, (object)null, cultureInfo_), null, parameterModifier_);
					_ = (_003CModule_003E)@class.t(obj, type_, null);
					_ = (_003CModule_003E)(object)Class5.Default;
					class17 = (Class6)(object)Class5.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				nuint num2;
				Class7 class18;
				checked
				{
					num2 = unchecked((nuint)default(UIntPtr)) - (num + num);
					class18 = @class;
				}
				BindingFlags bindingFlags_11 = (BindingFlags)((Class7)@class.t(obj, null, null)).W((BindingFlags)@class.W(bindingFlags, propertyInfo_, type_, null, (ParameterModifier[])(object)Class5.Default), null, type_, (Type[])(object)Class5.Default, parameterModifier_);
				Class7 obj19 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_12 = (BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2);
				Class7 obj20 = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, Class5.Default, cultureInfo_);
				BindingFlags bindingFlags_13 = bindingFlags;
				Class7 class19 = @class;
				BindingFlags bindingFlags_14 = bindingFlags;
				FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
				Class7 class20 = @class;
				BindingFlags bindingFlags_15 = (BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref object_3, parameterModifier_, cultureInfo_, string_, out object_2), null, parameterModifier_);
				Class7 class21 = @class;
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo_);
				Class7 class22 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_16 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array2;
				Class7 class23 = @class;
				BindingFlags bindingFlags_17 = (BindingFlags)@class.e(bindingFlags, methodBase_, null, parameterModifier_);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_18 = bindingFlags;
				Class7 class24 = @class;
				BindingFlags bindingFlags_19 = bindingFlags;
				MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref object_3, parameterModifier_, (CultureInfo)(object)((Class7)null).W((BindingFlags)@class.e(bindingFlags, methodBase_, array, parameterModifier_), propertyInfo_, (Type)null, (Type[])(object)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo_)).W(default(BindingFlags), null, (Type)(object)((Class7)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array, parameterModifier_)).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)Class5.Default, parameterModifier_), array, (ParameterModifier[])(object)@class.e(default(BindingFlags), methodBase_, array, null)), parameterModifier_), string_, out object_2), ref object_3, parameterModifier_, null, null, out *(object*)null);
				bindingFlags = default(BindingFlags);
				string[] string_2 = (string[])(object)class22.t(bindingFlags_16, fieldInfo_2, null, (CultureInfo)(object)class23.W(bindingFlags_17, propertyInfo_, type_, (Type[])(object)((Class7)null).W(bindingFlags_18, (PropertyInfo[])(object)((Class7)(object)((Class7)(object)class24.j(bindingFlags_19, methodBase_3, ref *(object[]*)null, null, cultureInfo_2, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.W(bindingFlags, propertyInfo_, type_, null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)@class.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default), methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])null, out *(object*)null))).e((BindingFlags)@class.t(bindingFlags, array2, ((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, array2, obj, cultureInfo_)), cultureInfo_), methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (object)null, cultureInfo_), out *(object*)null)).e(bindingFlags, null, array, parameterModifier_)).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), type_, (Type[])null, (ParameterModifier[])null), parameterModifier_));
				Class7 class25 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_20 = (BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags_14, fieldInfo_, obj, (CultureInfo)(object)class20.j(bindingFlags_15, methodBase_, ref *(object[]*)class21.j(default(BindingFlags), methodBase_, ref *(object[]*)null, parameterModifier_3, cultureInfo_, string_2, out *(object*)class25.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_)), null, cultureInfo_, null, out *(object*)Class5.Default))).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.j(bindingFlags, methodBase_, ref object_3, parameterModifier_, null, string_, out object_2), (Type)(object)Class5.Default, null, null)).j(default(BindingFlags), methodBase_, ref object_3, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out object_2), obj, cultureInfo_);
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)(object)class26.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out object_2)).t(bindingFlags, null, Class5.Default, cultureInfo_);
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_21 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)@class.j(bindingFlags, methodBase_, ref object_3, parameterModifier_, cultureInfo_, string_, out object_2);
				BindingFlags bindingFlags_22 = bindingFlags;
				Class7 class28 = @class;
				BindingFlags bindingFlags_23 = bindingFlags;
				MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
				Class7 class29 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_24 = (BindingFlags)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags, array2, (object)Class5.Default, cultureInfo_)).e(bindingFlags, null, array, parameterModifier_), array2, (object)Class5.Default, (CultureInfo)null);
				Class7 obj21 = (Class7)(object)Class5.Default;
				Class7 class30 = @class;
				BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				Type[] type_4 = (Type[])(object)((Class7)null).j(bindingFlags_22, (MethodBase[])null, ref object_3, (ParameterModifier[])null, cultureInfo_, (string[])null, out *(object*)class28.e(bindingFlags_23, methodBase_4, (Type[])(object)class29.j(bindingFlags_24, (MethodBase[])(object)obj21.W((BindingFlags)class30.j(bindingFlags_25, methodBase_, ref object_3, parameterModifier_, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(obj, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, (Type)null, (Type[])null, (ParameterModifier[])null), null), (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, parameterModifier_)).j((BindingFlags)@class.W(bindingFlags, propertyInfo_, type_, (Type[])(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, parameterModifier_), null), (MethodBase[])((Class7)null).t((object)null, type_, (CultureInfo)null), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, string_, out *(object*)@class.t(bindingFlags, null, obj, cultureInfo_)), (Type[])null, parameterModifier_), string_, out *(object*)Class5.Default), null, (Type)@class.t(obj, (Type)(object)Class5.Default, null), array, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, (ParameterModifier[])null, cultureInfo_, (string[])(object)((Class7)null).W((BindingFlags)@class.t(null, null, cultureInfo_), (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])null), out *(object*)null)), ref *(object[]*)null, parameterModifier_, null, string_, out object_2), parameterModifier_));
				Class7 class31 = @class;
				object object_4 = Class5.Default;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				if (num2 / checked(unchecked((nuint)(UIntPtr)class18.e(bindingFlags_11, methodBase_, null, (ParameterModifier[])(object)obj19.e(bindingFlags_12, methodBase_, (Type[])(object)obj20.W(bindingFlags_13, null, (Type)(object)class19.t(bindingFlags_20, fieldInfo_3, class27.W(bindingFlags_21, propertyInfo_2, type_, type_4, (ParameterModifier[])class31.t(object_4, (Type)(object)class32.t(bindingFlags, array2, obj, cultureInfo_), (CultureInfo)(object)Class5.Default)), cultureInfo_), array, null), (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, null)))) + num - num) == 0)
				{
					_ = (Class8)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				}
				goto IL_3579;
			}
		}
		goto IL_3579;
		IL_1701:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class35);
		if ((UIntPtr)@class.W(bindingFlags, propertyInfo_, null, array, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			Class7 class33 = @class;
			BindingFlags bindingFlags_26 = bindingFlags;
			Class7 class34 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_27 = bindingFlags;
			Type[] type_5 = (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, parameterModifier_);
			Class7 obj22 = (Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])((Class7)null).t(obj, type_, cultureInfo_), out object_2);
			BindingFlags bindingFlags_28 = bindingFlags;
			ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)((Class7)null).t((object)@class.e((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t((object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, null)), type_, (CultureInfo)null), array, parameterModifier_), type_, cultureInfo_), null, parameterModifier_);
			CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
			Class7 obj23 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)class33.e(bindingFlags_26, (MethodBase[])(object)class34.e(bindingFlags_27, null, type_5, (ParameterModifier[])(object)obj22.j(bindingFlags_28, null, ref *(object[]*)null, parameterModifier_4, cultureInfo_3, null, out *(object*)obj23.t(bindingFlags, null, obj, null))), array, (ParameterModifier[])(object)Class5.Default);
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
				_ = (Class9)(object)Class5.Default;
				class35 = class35;
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		else
		{
			class12 = class12;
		}
		class11 = (Class2)(object)Class5.Default;
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
					class16 = class16;
				}
				else
				{
					_ = (Class9)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out *(object*)Class5.Default);
				}
			}
		}
		num = default(UIntPtr);
		nuint num3 = num;
		BindingFlags bindingFlags_29 = bindingFlags;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class36);
		checked
		{
			if (unchecked(num3 / (nuint)(UIntPtr)((Class7)null).j(bindingFlags_29, (MethodBase[])null, ref object_3, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null), out *(object*)null)) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default), (Type[])(object)((Class7)null).j((BindingFlags)((Class7)(object)((Class7)null).W((BindingFlags)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), (PropertyInfo[])(object)Class5.Default, type_, (Type[])null, (ParameterModifier[])(object)@class.W((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])null), (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, null))).t(bindingFlags, array2, Class5.Default, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2), (ParameterModifier[])null)) == 0)
			{
				do
				{
					@struct = default(Struct1);
				}
				while (obj != null);
			}
			else
			{
				while (true)
				{
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])null, out *unchecked((object*)null)) != null)
					{
						class36 = class36;
						continue;
					}
					break;
				}
			}
			while (obj != null)
			{
				nuint num4 = num;
				num = default(UIntPtr);
				if (num4 + num == 0)
				{
					while (obj != null)
					{
						@struct = @struct;
					}
				}
			}
			if (num == 0)
			{
				while (obj != null)
				{
					gClass4 = gClass4;
				}
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			class12 = class12;
			_ = (Class4)(object)Class5.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				while (obj != null)
				{
					gClass3 = gClass3;
				}
			}
			goto IL_1b99;
		}
		IL_0572:
		if (num == 0)
		{
			GClass1 obj25 = (GClass1)(object)Class5.Default;
			gClass2 = gClass2;
			gClass2 = obj25;
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Class9)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])@class.t(@class.e(bindingFlags, methodBase_, null, parameterModifier_), type_, cultureInfo_), array, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo_));
				_ = (Class9)(object)Class5.Default;
			}
		}
		else
		{
			do
			{
				gClass2 = gClass2;
				class12 = class12;
				class12 = class12;
				Class7 class37 = @class;
				BindingFlags bindingFlags_30 = (BindingFlags)@class.t(bindingFlags, null, obj, null);
				Class7 class38 = @class;
				MethodBase[] methodBase_5 = (MethodBase[])@class.t(obj, type_, cultureInfo_);
				Class7 class39 = @class;
				bindingFlags = default(BindingFlags);
				class2 = (Class4)(object)class37.j(bindingFlags_30, methodBase_, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)class38.e(default(BindingFlags), methodBase_5, array, (ParameterModifier[])(object)class39.e(bindingFlags, (MethodBase[])@class.t(@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)@class.e(bindingFlags, null, null, parameterModifier_)), type_, (CultureInfo)(object)@class.t(bindingFlags, null, null, cultureInfo_)), array, parameterModifier_)), out *(object*)null);
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class40);
		do
		{
			class40 = class40;
			class40 = null;
		}
		while (obj != null);
		try
		{
			BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_32 = bindingFlags;
			Class7 class42 = @class;
			BindingFlags bindingFlags_33 = bindingFlags;
			Class7 obj26 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)null).j(bindingFlags_31, (MethodBase[])null, ref *(object[]*)((Class7)null).t(obj, (Type)(object)class41.t(bindingFlags_32, null, obj, (CultureInfo)(object)class42.e(bindingFlags_33, null, array, (ParameterModifier[])(object)obj26.e(bindingFlags, methodBase_, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_), parameterModifier_))), cultureInfo_), (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null), out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref object_3, parameterModifier_, cultureInfo_, string_, out object_2), cultureInfo_, string_, out *(object*)null), obj, cultureInfo_));
		}
		catch
		{
			do
			{
				class2 = null;
			}
			while (obj != null || obj != null);
		}
		UIntPtr num5 = (UIntPtr)Class5.Default;
		Class7 obj28 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj29 = (Class7)(object)obj28.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)(object)Class5.Default).e((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)@class.t(null, null, null), array, (ParameterModifier[])null)).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2), methodBase_, null, parameterModifier_), cultureInfo_);
		BindingFlags bindingFlags_34 = bindingFlags;
		ref object[] object_5 = ref *(object[]*)((Class7)null).t((object)null, type_, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_3, parameterModifier_, cultureInfo_, (string[])null, out *(object*)@class.t((BindingFlags)Class5.Default, array2, null, null)));
		Class7 obj30 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_35 = bindingFlags;
		Class7 class43 = @class;
		Class7 obj31 = (Class7)(object)Class5.Default;
		object object_6 = Class5.Default;
		Class7 class44 = @class;
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)num5) + unchecked((nuint)(UIntPtr)obj29.j(bindingFlags_34, methodBase_, ref object_5, (ParameterModifier[])(object)((Class7)(object)obj30.e(bindingFlags_35, methodBase_, array, (ParameterModifier[])class43.t(obj, (Type)obj31.t(object_6, (Type)(object)class44.W(bindingFlags, propertyInfo_, type_, null, null), cultureInfo_), cultureInfo_))).W((BindingFlags)Class5.Default, propertyInfo_, type_, array, null), null, null, out object_2))) == 0)
		{
			UIntPtr num6 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			if ((nuint)num6 / num == 0)
			{
				if (num == 0)
				{
					_ = Class5.Default;
				}
			}
			else
			{
				try
				{
					_ = (Class8)(object)((Class7)(object)@class.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, null);
				}
				catch
				{
					Class7 obj32 = (Class7)(object)@class.t(bindingFlags, array2, null, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj32.W(bindingFlags, propertyInfo_, type_, null, null);
				}
			}
		}
		else
		{
			while (true)
			{
				Class7 obj34 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_36 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
				Type type_6 = (Type)(object)Class5.Default;
				Class7 class45 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)obj34.W(bindingFlags_36, propertyInfo_3, type_6, (Type[])(object)class45.W(bindingFlags, null, (Type)(object)Class5.Default, array, parameterModifier_), (ParameterModifier[])(object)Class5.Default) == null)
				{
					break;
				}
				BindingFlags bindingFlags_37 = (BindingFlags)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default);
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(Class5.Default, null, null), obj, cultureInfo_);
				Class7 class46 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)((Class7)null).W(bindingFlags_37, propertyInfo_4, (Type)(object)class46.t(bindingFlags, array2, obj, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, parameterModifier_)), array, (ParameterModifier[])null);
			}
		}
		try
		{
			if (checked(num * num) == 0)
			{
				try
				{
					_ = (Class9)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type_, array, parameterModifier_), parameterModifier_, cultureInfo_, null, out *(object*)null), (ParameterModifier[])null);
					_ = (Class4)(object)@class.t((BindingFlags)@class.t(bindingFlags, null, null, null), array2, obj, null);
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_0c2e;
				}
			}
			end_IL_0c2e:;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass2 = null;
			}
			goto IL_0d14;
		}
		IL_3c6c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				try
				{
					qk = null;
				}
				catch
				{
					class12 = class12;
				}
			}
		}
		else
		{
			try
			{
				if (num == 0)
				{
					_ = (Class10)(object)Class5.Default;
					_ = (Class8)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_);
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class47.e(bindingFlags, (MethodBase[])@class.t(obj, null, cultureInfo_), array, parameterModifier_);
					gClass3 = gClass3;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					qk = (Qk7)(object)@class.e(bindingFlags, null, array, null);
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		if (num == 0)
		{
			@class = @class;
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					gClass3 = (GClass3)(object)Class5.Default;
					continue;
				}
				_ = (Class0)(object)Class5.Default;
				_ = (_003CModule_003E)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_);
			}
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					@struct = default(Struct1);
					@struct = @struct;
				}
				else
				{
					class16 = null;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (GClass2)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, null, array, parameterModifier_);
				}
			}
		}
		catch
		{
			UIntPtr num7 = (UIntPtr)Class5.Default;
			Class7 obj38 = (Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, parameterModifier_);
			bindingFlags = default(BindingFlags);
			if ((nuint)num7 / (nuint)(UIntPtr)obj38.j(bindingFlags, methodBase_, ref object_3, (ParameterModifier[])(object)Class5.Default, null, string_, out object_2) == 0)
			{
				do
				{
					_ = (Class6)(object)Class5.Default;
				}
				while (obj != null);
			}
			else if (checked(unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
			}
		}
		while (obj != null)
		{
			if (num == 0)
			{
				class12 = null;
				_ = (GClass0)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
			}
			else
			{
				Class7 class48 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class48.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, null, out *(object*)Class5.Default);
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				_003CModule_003E = null;
			}
			catch
			{
			}
		}
		_ = (GClass2)(object)((Class7)null).e((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref object_3, (ParameterModifier[])null, cultureInfo_, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_3, parameterModifier_, cultureInfo_, string_, out *(object*)null), out *(object*)null), methodBase_, array, parameterModifier_);
		try
		{
			class40 = null;
		}
		catch
		{
			class36 = class36;
		}
		if (num == 0)
		{
			do
			{
				try
				{
					gClass2 = null;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			do
			{
				nuint num8 = checked(num + num);
				Class7 class49 = @class;
				Class7 class50 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_38 = bindingFlags;
				Class7 class51 = @class;
				BindingFlags bindingFlags_39 = bindingFlags;
				Class7 obj43 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_40 = bindingFlags;
				Class7 obj44 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_41 = bindingFlags;
				FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
				Class7 class52 = @class;
				BindingFlags bindingFlags_42 = bindingFlags;
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				nuint num9 = num8 / (nuint)(UIntPtr)((Class7)null).W(default(BindingFlags), propertyInfo_, (Type)(object)((Class7)(object)class49.t(default(BindingFlags), null, class50.j(bindingFlags_38, (MethodBase[])(object)class51.W(bindingFlags_39, (PropertyInfo[])(object)obj43.W(bindingFlags_40, propertyInfo_, type_, null, (ParameterModifier[])(object)obj44.W((BindingFlags)((Class7)null).t(bindingFlags_41, fieldInfo_4, (object)class52.j(bindingFlags_42, methodBase_, ref *(object[]*)class53.t(bindingFlags, null, null, cultureInfo_), (ParameterModifier[])((Class7)(object)Class5.Default).t(@class.t(bindingFlags, null, Class5.Default, cultureInfo_), (Type)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, null), type_, array, parameterModifier_), null), cultureInfo_, string_, out object_2), (CultureInfo)null), propertyInfo_, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null)), type_, array, parameterModifier_), ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out *(object*)null), cultureInfo_)).e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default), (Type[])null, (ParameterModifier[])(object)Class5.Default);
				num = default(UIntPtr);
				if (checked(num9 - num) != 0)
				{
					class16 = null;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		try
		{
			try
			{
				while ((object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, parameterModifier_) != null)
				{
					class17 = class17;
				}
			}
			finally
			{
				class40 = class40;
				goto end_IL_4223;
			}
			end_IL_4223:;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				class36 = Class5.Default;
			}
			else
			{
				class40 = class40;
			}
			goto IL_428d;
		}
		IL_4384:
		_ = (Class8)(object)Class5.Default;
		Class7 class54 = @class;
		FieldInfo[] fieldInfo_5 = (FieldInfo[])@class.t(obj, null, null);
		Class7 obj45 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		object object_7 = ((Class7)null).t(default(BindingFlags), fieldInfo_5, obj, (CultureInfo)(object)obj45.W((BindingFlags)((Class7)null).t((object)null, type_, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo_)), propertyInfo_, type_, array, (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out object_2)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_3, parameterModifier_, null, null, out *(object*)Class5.Default)));
		Class7 obj46 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)class54.t(object_7, (Type)(object)obj46.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)@class.t(bindingFlags, array2, obj, cultureInfo_)), cultureInfo_);
		_ = (Class0)(object)Class5.Default;
		class40 = class40;
		if (num == 0)
		{
			try
			{
				Class7 class55;
				BindingFlags bindingFlags_43;
				ParameterModifier[] parameterModifier_5;
				Class7 class56;
				do
				{
					_ = (Class8)(object)Class5.Default;
					class55 = @class;
					bindingFlags = default(BindingFlags);
					bindingFlags_43 = bindingFlags;
					parameterModifier_5 = (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, array, null);
					class56 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class55.j(bindingFlags_43, methodBase_, ref object_3, parameterModifier_5, (CultureInfo)(object)class56.W(bindingFlags, null, null, null, parameterModifier_), string_, out *(object*)Class5.Default) != null);
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)((Class7)((Class7)null).t(obj, type_, cultureInfo_)).t(obj, type_, null), array, (ParameterModifier[])(object)Class5.Default);
				}
				goto IL_45c6;
			}
		}
		goto IL_45c6;
		IL_1e37:
		do
		{
			if (num == 0)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		try
		{
			do
			{
				try
				{
					struct2 = struct2;
				}
				finally
				{
					_ = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array2, obj, cultureInfo_), ref *(object[]*)@class.t(Class5.Default, null, cultureInfo_), parameterModifier_, cultureInfo_, (string[])null, out object_2);
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			checked
			{
				if (num + unchecked((nuint)default(UIntPtr)) != 0)
				{
					try
					{
						_ = (Qk7)(object)Class5.Default;
					}
					finally
					{
						gClass = gClass;
						goto end_IL_1ead;
					}
				}
				_ = (Class9)(object)Class5.Default;
			}
			end_IL_1ead:;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class9)((Class7)null).t(obj, type_, cultureInfo_);
				}
			}
		}
		_ = (Class10)(object)@class.W((BindingFlags)Class5.Default, null, null, array, (ParameterModifier[])(object)Class5.Default);
		qk = qk;
		qk = qk;
		gClass4 = gClass4;
		_ = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, null, cultureInfo_);
		_ = (Class6)(object)Class5.Default;
		Class7 class57 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)class57.t(bindingFlags, array2, obj, cultureInfo_);
		if (num == 0)
		{
			while ((object)Class5.Default != null)
			{
				while (obj != null)
				{
					_ = (Class9)(object)Class5.Default;
					qk = qk;
					class2 = class2;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		if (num == 0)
		{
			while (obj != null)
			{
				qk = qk;
			}
		}
		else
		{
			num = default(UIntPtr);
			if (checked(num - unchecked(num / checked(num * unchecked((nuint)(UIntPtr)Class5.Default)))) == 0)
			{
				gClass4 = null;
			}
			else
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)@class.t(bindingFlags, array2, obj, cultureInfo_), out object_2);
				}
				catch
				{
					Class7 class58 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class58.t(bindingFlags, array2, obj, null);
				}
			}
		}
		while (obj != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class40 = class40;
					class36 = class36;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					gClass = gClass;
					_ = (GClass0)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj50 = (Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, string_, out *(object*)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)((Class7)null).t(obj, (Type)null, cultureInfo_)));
					BindingFlags bindingFlags_44 = (BindingFlags)@class.e(bindingFlags, methodBase_, array, parameterModifier_);
					Class7 class59 = @class;
					BindingFlags bindingFlags_45 = bindingFlags;
					FieldInfo[] fieldInfo_6 = array2;
					Class7 class60 = @class;
					BindingFlags bindingFlags_46 = (BindingFlags)@class.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2);
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					string[] string_3 = (string[])(object)class60.e(bindingFlags_46, null, (Type[])(object)class61.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_3, null, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)(object)Class5.Default).t(obj, type_, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null))), null);
					Class7 obj51 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.e(default(BindingFlags), methodBase_, null, parameterModifier_), type_, (Type[])(object)Class5.Default, parameterModifier_);
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass3)(object)obj50.j(bindingFlags_44, (MethodBase[])(object)class59.t(bindingFlags_45, fieldInfo_6, obj, (CultureInfo)(object)((Class7)null).j(default(BindingFlags), methodBase_, ref object_3, parameterModifier_, (CultureInfo)null, string_3, out *(object*)obj51.W(bindingFlags, propertyInfo_, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, parameterModifier_)).j(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, null), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)null), null, (ParameterModifier[])(object)@class.t(bindingFlags, array2, obj, (CultureInfo)((Class7)null).t((object)null, type_, (CultureInfo)null))))), ref object_3, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2);
					Class7 obj52 = (Class7)(object)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null)).W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					Class7 obj53 = (Class7)(object)obj52.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
					Class7 class62 = @class;
					BindingFlags bindingFlags_47 = bindingFlags;
					FieldInfo[] fieldInfo_7 = array2;
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)null).t((object)null, (Type)null, (CultureInfo)obj53.t(null, (Type)(object)class62.t(bindingFlags_47, fieldInfo_7, class63.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null), cultureInfo_));
				}
				continue;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num / num == 0)
			{
				if (num == 0)
				{
					_ = (Class4)(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_);
				}
				else
				{
					_ = (GClass2)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_);
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = (Qk7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_), (ParameterModifier[])null);
				}
				while ((object)((Class7)(object)Class5.Default).e((BindingFlags)@class.e((BindingFlags)Class5.Default, methodBase_, array, null), null, array, parameterModifier_) != null);
			}
		}
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
					_ = (GClass0)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2);
					gClass4 = gClass4;
					goto end_IL_25c9;
				}
				end_IL_25c9:;
			}
			catch
			{
				Class7 obj54 = (Class7)(object)Class5.Default;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj54.t(class64.e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, methodBase_, array, parameterModifier_), null, (ParameterModifier[])(object)Class5.Default), type_, null) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
		}
		while ((object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, cultureInfo_) != null);
		try
		{
		}
		finally
		{
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			goto IL_26da;
		}
		IL_428d:
		if (num == 0)
		{
			do
			{
				try
				{
					BindingFlags bindingFlags_48 = (BindingFlags)Class5.Default;
					Class7 class65 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)((Class7)null).j(bindingFlags_48, (MethodBase[])(object)((Class7)(object)class65.e(bindingFlags, methodBase_, array, parameterModifier_)).e(bindingFlags, methodBase_, null, parameterModifier_), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2);
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
			goto IL_4384;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Qk7)((Class7)(object)Class5.Default).t(obj, type_, (CultureInfo)@class.t(null, (Type)((Class7)null).t((object)Class5.Default, type_, cultureInfo_), cultureInfo_));
			}
		}
		finally
		{
			gClass4 = null;
			goto IL_4384;
		}
		IL_4659:
		_ = (Class2)(object)Class5.Default;
		while (true)
		{
			Class7 class66 = @class;
			Class7 class67 = @class;
			BindingFlags bindingFlags_49 = bindingFlags;
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)class68.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo_)), null, null);
			Type type_7 = (Type)(object)@class.e((BindingFlags)Class5.Default, null, null, parameterModifier_);
			bindingFlags = default(BindingFlags);
			if ((object)class66.t((BindingFlags)class67.W(bindingFlags_49, propertyInfo_5, type_7, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo_)), null, null, cultureInfo_) == null)
			{
				break;
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)@class.t(bindingFlags, array2, obj, cultureInfo_);
			}
		}
		if (num == 0)
		{
			_ = (Struct1)@class.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, cultureInfo_, (string[])null, out object_2), string_, out object_2);
			_ = (Struct2)Class5.Default;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			else
			{
				gClass = gClass;
			}
		}
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		catch
		{
			if (num == 0 && num == 0)
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		try
		{
			BindingFlags bindingFlags_50 = bindingFlags;
			Type type_8 = (Type)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj57 = (Class7)(object)((Class7)null).W(bindingFlags_50, propertyInfo_, type_8, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null), parameterModifier_);
			BindingFlags bindingFlags_51 = bindingFlags;
			Class7 class69 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_52 = bindingFlags;
			Class7 class70 = @class;
			BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_8 = array2;
			Class7 class71 = @class;
			Class7 class72 = @class;
			bindingFlags = default(BindingFlags);
			CultureInfo cultureInfo_4 = (CultureInfo)(object)class69.e(bindingFlags_52, (MethodBase[])(object)class70.t(bindingFlags_53, fieldInfo_8, class71.W((BindingFlags)class72.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default), null, type_, null, null), cultureInfo_), null, parameterModifier_);
			Class7 class73 = @class;
			Class7 class74 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_54 = bindingFlags;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj57.j(bindingFlags_51, methodBase_, ref object_3, null, cultureInfo_4, string_, out *(object*)class73.e((BindingFlags)class74.W((BindingFlags)((Class7)null).W(bindingFlags_54, (PropertyInfo[])null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, cultureInfo_, string_, out *(object*)null), ref object_3, parameterModifier_, (CultureInfo)(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, parameterModifier_)).W(bindingFlags, null, null, null, null), (string[])null, out object_2), array, (ParameterModifier[])null), propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_), methodBase_, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), parameterModifier_)) == (UIntPtr)(nuint)0u)
			{
				struct2 = default(Struct2);
				struct2 = struct2;
			}
			else if (num / checked(num + unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])(object)@class.e((BindingFlags)@class.j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_3, null, null, string_, out *(object*)Class5.Default), null, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)@class.W((BindingFlags)@class.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), null, type_, (Type[])(object)Class5.Default, parameterModifier_), out object_2), methodBase_, array, null), (ParameterModifier[])(object)Class5.Default))) == 0)
			{
				_ = (Class0)((Class7)null).t((object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_), (Type)null, (CultureInfo)(object)Class5.Default);
			}
		}
		catch
		{
			class40 = class40;
		}
		while (obj != null)
		{
			if (num == 0)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
					class17 = class17;
				}
				finally
				{
					_ = (Class10)(object)@class.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out object_2);
					continue;
				}
			}
			Class7 class75 = @class;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct2)class75.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out *(object*)null);
		}
		class17 = null;
		_ = (Class7)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		class2 = class2;
		qk = qk;
		try
		{
			Class7 class76 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class76.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)@class.e((BindingFlags)Class5.Default, methodBase_, array, null), propertyInfo_, type_, array, parameterModifier_), type_, array, null);
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					class17 = (Class6)@class.t(null, null, (CultureInfo)(object)Class5.Default);
				}
				finally
				{
					gClass = gClass;
					goto end_IL_4c44;
				}
			}
			gClass = (GClass2)(object)Class5.Default;
			end_IL_4c44:;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)class77.W((BindingFlags)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, (ParameterModifier[])null), propertyInfo_, type_, array, null) == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 class78 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_55 = bindingFlags;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class78.W(bindingFlags_55, (PropertyInfo[])(object)class79.W(bindingFlags, propertyInfo_, null, null, parameterModifier_), null, (Type[])(object)Class5.Default, parameterModifier_);
			}
			catch
			{
				_ = Class5.Default;
			}
		}
		_ = (Class8)(object)Class5.Default;
		_ = (GClass2)(object)Class5.Default;
		while (obj != null)
		{
			while (true)
			{
				Class7 class80 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class80.j(bindingFlags, null, ref *(object[]*)@class.e(bindingFlags, null, null, parameterModifier_), null, cultureInfo_, null, out *(object*)null) != null)
				{
					try
					{
						@struct = (Struct1)Class5.Default;
					}
					finally
					{
						_ = (Class8)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default);
						_ = (Class7)(object)@class.W(bindingFlags, propertyInfo_, type_, null, parameterModifier_);
						_ = (GClass0)(object)@class.e(bindingFlags, methodBase_, array, parameterModifier_);
						continue;
					}
				}
				break;
			}
		}
		do
		{
			try
			{
				class2 = class2;
			}
			catch
			{
				@class = @class;
			}
		}
		while ((object)Class5.Default != null);
		while (obj != null)
		{
			_ = (Class7)(object)@class.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			class36 = class36;
			Class7 class81 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)class81.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_);
			_ = (Class6)(object)Class5.Default;
		}
		checked
		{
			Class7 class82;
			do
			{
				num = default(UIntPtr);
				if (num - unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_)) == 0 && num - num == 0)
				{
					class17 = (Class6)(object)Class5.Default;
					qk = null;
					class16 = null;
					_ = (_003CModule_003E)((Class7)(object)Class5.Default).t(obj, null, cultureInfo_);
				}
				class82 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class82.t(bindingFlags, array2, obj, (CultureInfo)((Class7)null).t(obj, (Type)null, (CultureInfo)null)) != null);
		}
		try
		{
			while (((Class7)null).t((object)null, type_, cultureInfo_) != null)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (Struct2)Class5.Default;
					_ = (GClass1)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, null, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(null, type_, null)), out object_2);
					_ = (Class8)(object)((Class7)null).t((BindingFlags)Class5.Default, array2, (object)null, cultureInfo_);
				}
				catch
				{
					Class7 obj62 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj62.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)@class.e(bindingFlags, null, array, parameterModifier_), null);
				}
			}
			while (obj != null);
		}
		checked
		{
			if (num != 0)
			{
				try
				{
				}
				catch
				{
					if (unchecked(checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						@class = @class;
					}
				}
			}
			num = default(UIntPtr);
		}
		if (num / ((nuint)(UIntPtr)@class.e(bindingFlags, null, null, parameterModifier_) / (nuint)(UIntPtr)((Class7)null).t(obj, type_, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, parameterModifier_))) == 0)
		{
			nuint num10 = num;
			num = default(UIntPtr);
			if (num10 / num == 0)
			{
				class2 = null;
				struct2 = struct2;
			}
			else
			{
				do
				{
					_ = (Class6)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			class2 = class2;
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class2 = null;
				}
				else
				{
					class2 = (Class4)(object)Class5.Default;
				}
			}
			catch
			{
				if (num == 0)
				{
					gClass2 = null;
				}
			}
		}
		catch
		{
			try
			{
				gClass = gClass;
				qk = (Qk7)(object)Class5.Default;
				@struct = @struct;
				qk = qk;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
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
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			try
			{
				gClass3 = null;
				gClass = gClass;
				class40 = null;
			}
			catch
			{
				while ((object)@class.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default) != null)
				{
					@struct = (Struct1)Class5.Default;
				}
			}
		}
		@struct = @struct;
		class12 = class12;
		Class7 class83 = @class;
		Class7 obj70 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj71 = (Class7)(object)obj70.t(bindingFlags, array2, obj, (CultureInfo)(object)((Class7)@class.t(obj, type_, cultureInfo_)).t(bindingFlags, array2, obj, cultureInfo_));
		BindingFlags bindingFlags_56 = bindingFlags;
		FieldInfo[] fieldInfo_9 = array2;
		Class7 class84 = @class;
		bindingFlags = default(BindingFlags);
		class36 = (Class5)class83.t(obj71.t(bindingFlags_56, fieldInfo_9, obj, (CultureInfo)(object)class84.W((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, parameterModifier_), propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array, parameterModifier_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), null, (CultureInfo)(object)Class5.Default);
		class17 = class17;
		Class7 class85 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_57 = bindingFlags;
		ref object[] object_8 = ref *(object[]*)((Class7)(object)((Class7)null).t(bindingFlags, array2, ((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_)).t(obj, type_, cultureInfo_), (CultureInfo)null)).e(default(BindingFlags), methodBase_, array, null);
		Class7 obj72 = (Class7)(object)@class.W((BindingFlags)Class5.Default, null, type_, array, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_58 = bindingFlags;
		ref object[] object_9 = ref *(object[]*)Class5.Default;
		Class7 class86 = @class;
		BindingFlags bindingFlags_59 = bindingFlags;
		Class7 obj73 = (Class7)(object)((Class7)((Class7)(object)Class5.Default).t(null, type_, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array, (ParameterModifier[])@class.t(@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, array, parameterModifier_), null, cultureInfo_)), array, (ParameterModifier[])(object)Class5.Default))).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).W(default(BindingFlags), null, null, null, parameterModifier_), (MethodBase[])null, ref object_3, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2), null, type_, array, null), (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)obj72.j(bindingFlags_58, methodBase_, ref object_9, (ParameterModifier[])(object)class86.e(bindingFlags_59, (MethodBase[])(object)((Class7)(object)obj73.t(bindingFlags, array2, null, cultureInfo_)).t(bindingFlags, array2, null, cultureInfo_), null, parameterModifier_), cultureInfo_, string_, out object_2);
		bindingFlags = default(BindingFlags);
		Class7 obj74 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo_, (string[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo_, null, out object_2), out *(object*)Class5.Default), obj, (CultureInfo)null);
		BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
		Type type_9 = (Type)(object)Class5.Default;
		Class7 class87 = @class;
		BindingFlags bindingFlags_61 = bindingFlags;
		MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
		Class7 class88 = @class;
		BindingFlags bindingFlags_62 = bindingFlags;
		CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
		Class7 class89 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj75 = (Class7)(object)obj74.W(bindingFlags_60, propertyInfo_, type_9, (Type[])(object)class87.j(bindingFlags_61, methodBase_6, ref *(object[]*)null, (ParameterModifier[])(object)class88.e((BindingFlags)((Class7)null).j(bindingFlags_62, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_5, string_, out *(object*)class89.e(bindingFlags, methodBase_, null, null)), methodBase_, array, parameterModifier_), cultureInfo_, string_, out *(object*)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)((Class7)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), propertyInfo_, type_, array, parameterModifier_)).e((BindingFlags)@class.e(default(BindingFlags), null, array, parameterModifier_), methodBase_, array, parameterModifier_), (ParameterModifier[])null)), (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		@struct = (Struct1)((Class7)(object)class85.j(bindingFlags_57, methodBase_, ref object_8, parameterModifier_6, null, string_, out *(object*)obj75.t(bindingFlags, array2, null, cultureInfo_))).t(bindingFlags, array2, obj, null);
		class16 = (Class9)(object)@class.j(bindingFlags, null, ref object_3, parameterModifier_, cultureInfo_, null, out *(object*)Class5.Default);
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				do
				{
					try
					{
						_ = (Class5)(object)@class.t(unchecked((BindingFlags)@class.t(obj, (Type)(object)Class5.Default, null)), null, Class5.Default, cultureInfo_);
					}
					catch
					{
						_ = Class5.Default;
					}
				}
				while (obj != null);
			}
			else
			{
				num = default(UIntPtr);
				if (num - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(default(BindingFlags), array2, null, cultureInfo_)) == 0 && unchecked((nuint)(UIntPtr)Class5.Default) - num == 0)
				{
					qk = (Qk7)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		Class7 class90;
		BindingFlags bindingFlags_63;
		FieldInfo[] fieldInfo_10;
		Class7 class91;
		do
		{
			struct2 = default(Struct2);
			class90 = @class;
			bindingFlags_63 = (BindingFlags)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null);
			fieldInfo_10 = array2;
			class91 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class90.t(bindingFlags_63, fieldInfo_10, null, (CultureInfo)(object)class91.e(bindingFlags, null, null, parameterModifier_)) != null);
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
					Class7 class92 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_64 = bindingFlags;
					FieldInfo[] fieldInfo_11 = (FieldInfo[])(object)@class.t((BindingFlags)@class.t(bindingFlags, array2, obj, cultureInfo_), null, obj, null);
					Class7 class93 = @class;
					BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class92.t(bindingFlags_64, fieldInfo_11, class93.e(bindingFlags_65, null, array, (ParameterModifier[])(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null)).W(bindingFlags, propertyInfo_, type_, array, parameterModifier_)), null);
				}
			}
			return;
		}
		finally
		{
			while (obj != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
					continue;
				}
				_ = (Struct1)@class.W(bindingFlags, propertyInfo_, null, array, null);
				_ = (Class7)(object)Class5.Default;
				_ = (Class5)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)((Class7)((Class7)null).t(obj, type_, cultureInfo_)).t(obj, (Type)(object)Class5.Default, cultureInfo_), parameterModifier_, cultureInfo_, null, out *(object*)null);
			}
			return;
		}
		IL_133b:
		try
		{
			class11 = (Class2)(object)Class5.Default;
		}
		catch
		{
			class16 = null;
		}
		Class7 class94 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class94.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default) != (UIntPtr)(nuint)0u)
		{
		}
		Class7 class95 = @class;
		BindingFlags bindingFlags_66 = bindingFlags;
		FieldInfo[] fieldInfo_12 = (FieldInfo[])@class.t(obj, (Type)((Class7)null).t((object)null, type_, (CultureInfo)(object)Class5.Default), (CultureInfo)@class.t(obj, type_, null));
		Class7 class96 = @class;
		BindingFlags bindingFlags_67 = bindingFlags;
		BindingFlags bindingFlags_68 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
		Class7 obj78 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_69 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class95.t(bindingFlags_66, fieldInfo_12, obj, (CultureInfo)(object)((Class7)(object)class96.e(bindingFlags_67, methodBase_, (Type[])(object)((Class7)null).W(bindingFlags_68, propertyInfo_6, (Type)(object)obj78.W(bindingFlags_69, (PropertyInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])@class.t(obj, type_, cultureInfo_), out object_2), null, null, (ParameterModifier[])(object)Class5.Default), (Type[])null, parameterModifier_), parameterModifier_)).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, cultureInfo_, null, out object_2)) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					class35 = class35;
					class35 = class35;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass2 = gClass2;
			}
			finally
			{
				do
				{
					_ = (Qk7)((Class7)null).t((object)Class5.Default, type_, cultureInfo_);
					Class7 class97 = @class;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass0)(object)class97.j(bindingFlags, methodBase_, ref *(object[]*)@class.W(bindingFlags, propertyInfo_, type_, (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_, (CultureInfo)(object)Class5.Default, null, out object_2);
					gClass4 = gClass4;
					Class7 class98 = @class;
					BindingFlags bindingFlags_70 = bindingFlags;
					MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
					BindingFlags bindingFlags_71 = bindingFlags;
					ref object[] object_10 = ref *(object[]*)Class5.Default;
					Class7 class99 = @class;
					BindingFlags bindingFlags_72 = bindingFlags;
					string[] string_4 = (string[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class98.j(bindingFlags_70, methodBase_7, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)((Class7)null).j(bindingFlags_71, methodBase_, ref object_10, parameterModifier_, cultureInfo_, (string[])null, out *(object*)class99.j(bindingFlags_72, methodBase_, ref object_3, parameterModifier_, cultureInfo_, string_4, out *(object*)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default), array, parameterModifier_))));
				}
				while ((object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default) != null);
				goto IL_1701;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			Class7 obj79 = (Class7)(object)@class.e((BindingFlags)@class.e(bindingFlags, methodBase_, array, parameterModifier_), methodBase_, array, parameterModifier_);
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj79.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_);
		}
		goto IL_1701;
		IL_35ac:
		_ = (GClass1)(object)Class5.Default;
		class16 = null;
		if (num == 0)
		{
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		else
		{
			while (obj != null)
			{
			}
		}
		while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_)) != null)
		{
			try
			{
				while (obj != null)
				{
					gClass3 = null;
				}
			}
			finally
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
					class2 = (Class4)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, null, null, out object_2);
					class36 = null;
					@class = (Class7)(object)Class5.Default;
				}
				while (@class.t(obj, (Type)(object)Class5.Default, cultureInfo_) != null);
				continue;
			}
		}
		checked
		{
			do
			{
				nuint num11 = num;
				num = default(UIntPtr);
				if (num11 + unchecked(num / (nuint)(UIntPtr)Class5.Default) != 0)
				{
					if (num == 0)
					{
						bindingFlags = default(BindingFlags);
						_ = (Class2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null));
						_ = (Class8)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
						struct2 = (Struct2)Class5.Default;
					}
				}
				else
				{
					gClass3 = gClass3;
					@struct = default(Struct1);
				}
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				nuint num12 = num / num;
				num = default(UIntPtr);
				checked
				{
					nuint num13 = num12 + unchecked(num / num) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
					bindingFlags = default(BindingFlags);
					UIntPtr num14 = unchecked((UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t((object)null, (Type)@class.t(null, type_, cultureInfo_), (CultureInfo)(object)Class5.Default), array, parameterModifier_));
					num = default(UIntPtr);
					nuint num15 = num13 - unchecked((nuint)num14) * num;
					nuint num16 = num;
					num = default(UIntPtr);
					if (unchecked(checked(num15 * (num16 + num)) / num) * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
					else
					{
						_ = (Class10)(object)Class5.Default;
					}
				}
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		else
		{
			while (obj != null)
			{
				while (obj != null)
				{
					struct2 = struct2;
				}
			}
		}
		_ = (Class10)(object)@class.e(bindingFlags, methodBase_, array, parameterModifier_);
		_ = (GClass3)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			Class7 class100 = @class;
			BindingFlags bindingFlags_73 = (BindingFlags)Class5.Default;
			Class7 class101 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)class100.e(bindingFlags_73, (MethodBase[])(object)((Class7)null).e((BindingFlags)class101.W(bindingFlags, (PropertyInfo[])((Class7)(object)Class5.Default).t(obj, type_, null), type_, null, (ParameterModifier[])((Class7)null).t((object)Class5.Default, type_, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type_, cultureInfo_))), methodBase_, (Type[])(object)Class5.Default, parameterModifier_), array, null);
		}
		else
		{
			try
			{
				try
				{
					_ = (GClass1)(object)@class.t(bindingFlags, array2, obj, cultureInfo_);
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass4 = gClass4;
					gClass = gClass;
				}
			}
			catch
			{
				qk = (((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, (CultureInfo)((Class7)null).t((object)Class5.Default, type_, cultureInfo_)) != (UIntPtr)(nuint)0u) ? qk : qk);
			}
		}
		do
		{
			try
			{
				Class7 class102 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class102.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_, type_, array, (ParameterModifier[])(object)@class.t(bindingFlags, array2, obj, cultureInfo_)), (Type[])(object)@class.t(bindingFlags, (FieldInfo[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_), obj, cultureInfo_), (ParameterModifier[])(object)Class5.Default), null, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).e((BindingFlags)@class.W(bindingFlags, propertyInfo_, type_, array, parameterModifier_), methodBase_, null, parameterModifier_)), out object_2);
			}
			catch
			{
				_ = (Class6)(object)((Class7)null).W(bindingFlags, propertyInfo_, type_, array, (ParameterModifier[])null);
				_ = (Struct2)Class5.Default;
				_003CModule_003E = _003CModule_003E;
			}
		}
		while (obj != null);
		_ = (GClass0)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])@class.t(null, null, (CultureInfo)@class.t(obj, null, (CultureInfo)@class.t(obj, null, (CultureInfo)(object)Class5.Default))), null, null, out object_2);
		try
		{
			if ((UIntPtr)@class.t(null, type_, cultureInfo_) == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			else if (num == 0)
			{
				_ = (GClass2)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out object_2);
				class16 = class16;
			}
		}
		finally
		{
			goto IL_3c6c;
		}
		IL_26da:
		class12 = null;
		gClass = (GClass2)(object)Class5.Default;
		if ((UIntPtr)@class.t(bindingFlags, array2, @class.j((BindingFlags)Class5.Default, (MethodBase[])@class.t(obj, type_, cultureInfo_), ref object_3, parameterModifier_, cultureInfo_, null, out *(object*)null), cultureInfo_) != (UIntPtr)(nuint)0u)
		{
			@struct = ((num != 0) ? @struct : ((Struct1)Class5.Default));
		}
		else if ((UIntPtr)@class.e(bindingFlags, null, (Type[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), parameterModifier_, cultureInfo_, string_, out *(object*)null), array, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type_, (Type[])(object)@class.t(bindingFlags, null, obj, null), (ParameterModifier[])(object)Class5.Default)), parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class2 = class2;
			}
			catch
			{
				class2 = class2;
			}
		}
		gClass = gClass;
		_ = (GClass0)(object)@class.t((BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null), (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default), obj, null);
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num != 0)
				{
					class35 = class35;
					continue;
				}
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				finally
				{
					Class7 class103 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class103.e(bindingFlags, methodBase_, null, parameterModifier_);
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)@class.t((BindingFlags)@class.W((BindingFlags)Class5.Default, null, type_, (Type[])((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), parameterModifier_), null, obj, cultureInfo_), out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				do
				{
					@class = @class;
				}
				while (@class.t(obj, type_, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null)) != null);
			}
			else
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		finally
		{
			_ = (Struct2)Class5.Default;
			_ = (GClass2)(object)@class.j(bindingFlags, methodBase_, ref object_3, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)Class5.Default);
			_ = Class5.Default;
			goto IL_2a8f;
		}
		IL_1298:
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				if (num + unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) != 0)
				{
					try
					{
						_ = (GClass3)(object)Class5.Default;
					}
					finally
					{
						class17 = class17;
						goto IL_133b;
					}
				}
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			else if (unchecked((nuint)(UIntPtr)Class5.Default) + num == 0)
			{
				while (((Class7)null).t(obj, type_, cultureInfo_) != null)
				{
					class36 = class36;
					class36 = class36;
					class36 = class36;
				}
			}
			goto IL_133b;
		}
		IL_1b99:
		num = default(UIntPtr);
		if (num == 0)
		{
			while (obj != null)
			{
				try
				{
					Class7 obj86 = (Class7)@class.t(Class5.Default, type_, null);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj86.W(bindingFlags, propertyInfo_, null, array, parameterModifier_);
					class2 = class2;
					_ = (Class0)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array2, obj, cultureInfo_), (Type[])null, parameterModifier_), string_, out object_2)).t(obj, type_, cultureInfo_), array, parameterModifier_);
					continue;
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - num == 0)
					{
						struct2 = struct2;
						struct2 = default(Struct2);
						struct2 = struct2;
					}
					else
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
			}
		}
		finally
		{
			try
			{
				class16 = null;
			}
			catch
			{
				bindingFlags = default(BindingFlags);
				Class7 obj87 = (Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_3, parameterModifier_, (CultureInfo)null, string_, out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_74 = bindingFlags;
				Class7 obj88 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, (ParameterModifier[])(object)Class5.Default);
				Class7 class104 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)obj87.j(bindingFlags_74, (MethodBase[])(object)obj88.e((BindingFlags)class104.t(bindingFlags, array2, @class.t(null, (Type)(object)@class.t(bindingFlags, null, obj, cultureInfo_), null), cultureInfo_), methodBase_, null, null), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out object_2);
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass1)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
				}
				goto IL_1e37;
			}
		}
		IL_45c6:
		class40 = null;
		try
		{
			num = default(UIntPtr);
			nuint num17 = num;
			num = default(UIntPtr);
			if (checked(num17 - num) == 0)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				class40 = class40;
			}
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				if (num == 0)
				{
					_ = (GClass3)(object)Class5.Default;
					struct2 = default(Struct2);
					_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_);
					_ = (GClass1)(object)Class5.Default;
				}
			}
			goto IL_4659;
		}
		IL_3579:
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
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
				}
				else
				{
					class16 = null;
				}
				goto IL_35ac;
			}
		}
	}

	unsafe static void p_00249A()
	{
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			try
			{
				while (true)
				{
					@class = @class;
					Class7 class2 = @class;
					obj = Class5.Default;
					object object_ = obj;
					type = type;
					if (class2.t(object_, type, null) != null)
					{
						_ = (GClass1)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			finally
			{
				try
				{
					gClass = gClass;
					gClass = gClass;
				}
				catch
				{
					bindingFlags = bindingFlags;
					PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
					Type type_ = type;
					Type[] type_2 = (Type[])(object)Class5.Default;
					array = array;
					_ = (Class2)(object)((Class7)null).W(default(BindingFlags), propertyInfo_, type_, type_2, array);
				}
				goto IL_00f4;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		while ((object)Class5.Default != null)
		{
			do
			{
				qk = qk;
				qk = qk;
			}
			while (obj != null);
		}
		goto IL_00f4;
		IL_3959:
		Class9 class3 = (Class9)(object)Class5.Default;
		_ = (Struct2)Class5.Default;
		MethodBase[] methodBase_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		_ = (Class0)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array2, null);
		Class0 class4 = null;
		Class7 class5 = @class;
		Class7 class6 = @class;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_2);
		_ = (Class4)(object)class5.j((BindingFlags)class6.W(bindingFlags, null, (Type)(object)Class5.Default, null, array), (MethodBase[])(object)@class.W(bindingFlags, null, type, array2, array), ref reference, array, null, (string[])(object)@class.W((BindingFlags)@class.W((BindingFlags)Class5.Default, array3, type, array2, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, array2, null)), array3, null, null, array), out object_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		if ((UIntPtr)((Class7)null).t(obj, type, (CultureInfo)null) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, null, null);
					_ = (Struct2)((Class7)(object)@class.W(bindingFlags, array3, null, null, array)).j(bindingFlags, null, ref *(object[]*)Class5.Default, array, null, null, out object_2);
					gClass2 = (GClass1)(object)@class.e((BindingFlags)Class5.Default, methodBase_, array2, null);
				}
				goto IL_3bbe;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		try
		{
			try
			{
				Class7 class7 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)(object)class7.W(bindingFlags, null, type, array2, array)).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out object_2);
			}
			finally
			{
				gClass2 = gClass2;
				goto end_IL_3b18;
			}
			end_IL_3b18:;
		}
		catch
		{
			_ = (Class0)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.t(Class5.Default, type, cultureInfo), array5, obj, null);
		}
		goto IL_3bbe;
		IL_54d2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			UIntPtr num = (UIntPtr)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, null, (ParameterModifier[])(object)Class5.Default);
			uIntPtr = default(UIntPtr);
			nuint num2 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((nuint)num / checked(num2 * uIntPtr) == 0)
			{
				while (obj != null)
				{
					Class7 obj4 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					ref object[] object_3 = ref reference;
					ParameterModifier[] parameterModifier_ = array;
					Class7 obj5 = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, null, null, (ParameterModifier[])@class.t(obj, type, cultureInfo));
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = (BindingFlags)obj5.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
					Class7 class8 = @class;
					Class7 class9 = @class;
					bindingFlags = default(BindingFlags);
					object object_4 = class9.W(bindingFlags, array3, null, array2, null);
					Type type_3 = type;
					Class7 class10 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
					BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
					ref object[] object_5 = ref reference;
					Class7 obj6 = (Class7)(object)@class.W(bindingFlags, null, null, array2, array);
					BindingFlags bindingFlags_5 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)@class.j(bindingFlags, methodBase_, ref reference, null, (CultureInfo)(object)Class5.Default, null, out object_2);
					Class7 class11 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)obj4.W((BindingFlags)((Class7)null).j(bindingFlags_, methodBase_2, ref object_3, parameterModifier_, (CultureInfo)(object)((Class7)null).t(bindingFlags_2, (FieldInfo[])null, class8.t(object_4, type_3, (CultureInfo)(object)((Class7)(object)class10.W(bindingFlags_3, propertyInfo_2, (Type)(object)((Class7)null).j(bindingFlags_4, methodBase_, ref object_5, (ParameterModifier[])(object)obj6.W(bindingFlags_5, propertyInfo_3, (Type)(object)class11.t(bindingFlags, array5, null, cultureInfo), null, array), cultureInfo, (string[])null, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(((Class7)null).t(obj, type, (CultureInfo)null), type, null), type, array2, array)), (Type[])(object)@class.t(bindingFlags, null, null, cultureInfo), array)).t(bindingFlags, null, Class5.Default, cultureInfo)), cultureInfo), (string[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, array), out *(object*)null), array3, type, (Type[])@class.t(obj, type, null), null);
				}
			}
			else
			{
				@struct = @struct;
			}
		}
		finally
		{
			checked
			{
				nuint num3 = uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default);
				UIntPtr num4 = unchecked((UIntPtr)Class5.Default);
				nuint num5 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (num3 + (unchecked((nuint)num4) + (num5 - uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default))) == 0)
				{
					try
					{
						class12 = class12;
					}
					catch
					{
						_ = (GClass1)(object)Class5.Default;
					}
				}
				goto IL_5818;
			}
		}
		IL_00f4:
		class3 = null;
		class3 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class16);
		try
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					Class7 class13 = @class;
					BindingFlags bindingFlags_7 = bindingFlags;
					MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
					Class7 class14 = @class;
					object object_6 = Class5.Default;
					Type type_4 = (Type)(object)Class5.Default;
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					Class7 obj8 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_9 = bindingFlags;
					array3 = array3;
					PropertyInfo[] propertyInfo_4 = array3;
					Type type_5 = type;
					array2 = array2;
					ref object[] object_7 = ref *(object[]*)obj8.W(bindingFlags_9, propertyInfo_4, type_5, array2, array);
					ParameterModifier[] parameterModifier_2 = array;
					cultureInfo = (CultureInfo)@class.t(obj, null, null);
					CultureInfo cultureInfo_ = cultureInfo;
					string[] string_ = (string[])(object)Class5.Default;
					object_2 = ref *(object*)null;
					reference = ref *(object[]*)class14.t(object_6, type_4, (CultureInfo)(object)class15.j(bindingFlags_8, null, ref object_7, parameterModifier_2, cultureInfo_, string_, out object_2));
					ref object[] object_8 = ref reference;
					array4 = array4;
					MethodBase[] methodBase_4 = (MethodBase[])(object)class13.j(bindingFlags_7, methodBase_3, ref object_8, null, null, array4, out object_2);
					Type[] type_6 = array2;
					BindingFlags bindingFlags_10 = bindingFlags;
					array5 = array5;
					class16 = (Class8)(object)((Class7)(object)((Class7)null).e(bindingFlags_6, methodBase_4, type_6, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_10, array5, (object)null, cultureInfo))).t(bindingFlags, null, Class5.Default, cultureInfo);
					class16 = class16;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					goto end_IL_00ff;
				}
				end_IL_00ff:;
			}
			catch
			{
				@struct = default(Struct2);
				@struct = @struct;
				@struct = default(Struct2);
				@struct = @struct;
			}
		}
		catch
		{
			_ = (GClass3)(object)Class5.Default;
		}
		Class7 class17 = @class;
		BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
		Class7 class18 = @class;
		Class7 class19 = @class;
		bindingFlags = default(BindingFlags);
		Class5 obj11 = (Class5)(object)class17.W(bindingFlags_11, (PropertyInfo[])(object)class18.j(default(BindingFlags), (MethodBase[])(object)class19.t(bindingFlags, array5, @class.t((BindingFlags)Class5.Default, array5, null, null), (CultureInfo)((Class7)null).t(obj, type, cultureInfo)), ref reference, array, cultureInfo, array4, out object_2), type, array2, array);
		Class5 class20 = null;
		class20 = obj11;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		try
		{
			while (obj != null)
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
		}
		catch
		{
			do
			{
				@struct = @struct;
			}
			while ((object)@class.t(bindingFlags, array5, obj, cultureInfo) != null);
		}
		class4 = class4;
		class4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class21);
		try
		{
			Class10 obj13 = (Class10)(object)Class5.Default;
			class21 = class21;
			class21 = obj13;
			class16 = class16;
		}
		finally
		{
			try
			{
				Class6 obj14 = (Class6)(object)Class5.Default;
				class12 = (Class6)(object)Class5.Default;
				class12 = obj14;
				gClass4 = null;
				gClass4 = gClass4;
			}
			catch
			{
				_ = (_003CModule_003E)(object)@class.j(default(BindingFlags), null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out object_2);
			}
			goto IL_0421;
		}
		IL_1252:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Qk7)@class.t(obj, type, cultureInfo);
		}
		else
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				try
				{
					gClass4 = (GClass3)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array), array5, obj, (CultureInfo)(object)Class5.Default), null, array2, null);
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					goto end_IL_1290;
				}
				end_IL_1290:;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class22 = @class;
					Class7 class23 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class22.W((BindingFlags)class23.W(bindingFlags, array3, type, null, array), array3, type, null, array);
					_ = (GClass2)@class.t(obj, type, (CultureInfo)(object)Class5.Default);
					Class7 obj17 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj17.j(bindingFlags, methodBase_, ref reference, null, (CultureInfo)(object)Class5.Default, null, out object_2);
					gClass = (GClass2)((Class7)null).t(obj, type, cultureInfo);
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			catch
			{
				gClass3 = null;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass2)(object)@class.e(bindingFlags, methodBase_, (Type[])(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t(obj, type, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)@class.t(bindingFlags, array5, null, null), (string[])(object)Class5.Default, out object_2)), ref reference, array, cultureInfo, array4, out object_2), (ParameterModifier[])(object)((Class7)(object)((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)null)).j(bindingFlags, methodBase_, ref reference, array, cultureInfo, array4, out object_2)).t((BindingFlags)Class5.Default, array5, obj, cultureInfo));
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		finally
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Struct2)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_1521;
		}
		IL_1f49:
		try
		{
			while (obj != null)
			{
				if ((UIntPtr)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out object_2) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
					continue;
				}
				Class7 class24 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class24.t(bindingFlags, array5, @class.j(bindingFlags, methodBase_, ref *(object[]*)null, array, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), cultureInfo);
				gClass = gClass;
				_ = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array, (CultureInfo)null, (string[])(object)Class5.Default, out object_2);
				gClass2 = gClass2;
			}
		}
		finally
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.e(bindingFlags, null, array2, array);
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			goto IL_206c;
		}
		IL_0421:
		Class7 class25 = @class;
		BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
		Class7 class26 = @class;
		object object_9 = obj;
		Class7 class27 = @class;
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_5 = (MethodBase[])class26.t(object_9, null, (CultureInfo)(object)class27.t(bindingFlags, array5, obj, cultureInfo));
		ref object[] object_10 = ref reference;
		ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
		Class7 class28 = @class;
		Class7 obj23 = (Class7)(object)@class.t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default);
		MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
		ref object[] object_11 = ref reference;
		ParameterModifier[] parameterModifier_4 = array;
		Class7 class29 = @class;
		bindingFlags = default(BindingFlags);
		CultureInfo cultureInfo_3 = (CultureInfo)(object)class29.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)@class.t(null, type, cultureInfo));
		Class7 obj24 = (Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
		BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
		methodBase_ = (MethodBase[])(object)Class5.Default;
		_ = (Class10)(object)class25.j(bindingFlags_12, methodBase_5, ref object_10, parameterModifier_3, cultureInfo_2, null, out *(object*)class28.j((BindingFlags)obj23.j(default(BindingFlags), methodBase_6, ref object_11, parameterModifier_4, cultureInfo_3, (string[])(object)((Class7)(object)obj24.e(bindingFlags_13, methodBase_, null, (ParameterModifier[])@class.t(obj, type, null))).e(bindingFlags, null, (Type[])(object)Class5.Default, array), out *(object*)null), methodBase_, ref *(object[]*)null, array, null, null, out object_2));
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			qk = null;
		}
		else
		{
			_ = (Class8)(object)Class5.Default;
			Class7 class30 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class30.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])@class.t(null, type, (CultureInfo)(object)Class5.Default), cultureInfo, null, out *(object*)Class5.Default);
			Class7 obj25 = (Class7)(object)@class.W(bindingFlags, array3, type, array2, array);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)obj25.t(bindingFlags, array5, obj, cultureInfo);
		}
		class20 = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array, cultureInfo, (string[])(object)@class.W(bindingFlags, null, type, array2, array), out object_2);
		class4 = class4;
		Class4 class31;
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class31 = (Class4)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null);
					class31 = class31;
				}
				else
				{
					@struct = @struct;
				}
			}
			finally
			{
				try
				{
					class12 = class12;
				}
				catch
				{
					gClass4 = gClass4;
				}
				goto end_IL_06be;
			}
			end_IL_06be:;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					class12 = null;
				}
				finally
				{
					gClass = gClass;
					class12 = class12;
					_ = (Class9)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, (ParameterModifier[])(object)((Class7)(object)@class.j(bindingFlags, methodBase_, ref reference, null, cultureInfo, null, out object_2)).W(bindingFlags, array3, type, null, null))).t((BindingFlags)Class5.Default, array5, obj, cultureInfo);
					goto end_IL_0719;
				}
			}
			end_IL_0719:;
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			catch
			{
				_ = (Class4)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, array);
				_ = (Class10)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				UIntPtr num6 = uIntPtr;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				nuint num7;
				Class7 class33;
				checked
				{
					num7 = unchecked((nuint)num6) - unchecked((nuint)(UIntPtr)((Class7)(object)class32.W(bindingFlags, array3, type, null, null)).t(bindingFlags, array5, obj, null));
					class33 = @class;
					bindingFlags = default(BindingFlags);
				}
				if (num7 / (nuint)(UIntPtr)class33.e(bindingFlags, null, array2, null) == 0)
				{
					Struct1 obj29 = (Struct1)Class5.Default;
					struct2 = struct2;
					struct2 = obj29;
				}
				else
				{
					struct2 = struct2;
				}
				goto IL_089a;
			}
		}
		goto IL_089a;
		IL_4f06:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Class7)@class.t(obj, type, cultureInfo);
			goto IL_4f5d;
		}
		try
		{
			while (obj != null)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				class20 = class20;
			}
			goto IL_4f5d;
		}
		IL_2fe6:
		_ = (GClass2)(object)Class5.Default;
		UIntPtr num8 = (UIntPtr)@class.e(bindingFlags, methodBase_, null, array);
		uIntPtr = default(UIntPtr);
		if ((nuint)num8 / uIntPtr == 0)
		{
			if ((nuint)(UIntPtr)Class5.Default / uIntPtr != 0)
			{
				try
				{
					gClass3 = null;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					goto IL_30c4;
				}
			}
			_ = (Struct1)Class5.Default;
		}
		else
		{
			class16 = (Class8)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo), array);
			_ = (Struct1)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array);
			@class = @class;
		}
		goto IL_30c4;
		IL_206c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class34);
		do
		{
			try
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					class34 = null;
				}
			}
			catch
			{
				try
				{
					class34 = null;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		while (obj != null);
		@class = @class;
		_ = (GClass1)(object)Class5.Default;
		try
		{
			try
			{
				gClass3 = null;
			}
			catch
			{
				_ = (Class4)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out object_2);
			}
		}
		catch
		{
			_ = (Qk7)(object)Class5.Default;
			class34 = class34;
			Class7 obj34 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj35 = (Class7)(object)obj34.e(bindingFlags, methodBase_, null, null);
			BindingFlags bindingFlags_14 = bindingFlags;
			Class7 class35 = @class;
			BindingFlags bindingFlags_15 = bindingFlags;
			PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)@class.e(default(BindingFlags), methodBase_, array2, array);
			Class7 class36 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_16 = bindingFlags;
			ref object[] object_12 = ref reference;
			ParameterModifier[] parameterModifier_5 = array;
			Class7 class37 = @class;
			BindingFlags bindingFlags_17 = (BindingFlags)@class.e((BindingFlags)Class5.Default, methodBase_, array2, array);
			Class7 class38 = @class;
			object object_13 = obj;
			Class7 obj36 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_18 = bindingFlags;
			BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_6 = array3;
			Type[] type_7 = array2;
			Class7 class39 = @class;
			BindingFlags bindingFlags_20 = (BindingFlags)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])((Class7)null).t((object)((Class7)null).j(default(BindingFlags), methodBase_, ref *(object[]*)@class.W((BindingFlags)@class.t(Class5.Default, type, null), array3, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array2, array), (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)null), type, (CultureInfo)null), out *(object*)@class.t(null, (Type)(object)Class5.Default, cultureInfo));
			Class7 class40 = @class;
			BindingFlags bindingFlags_21 = (BindingFlags)@class.j((BindingFlags)((Class7)null).e(default(BindingFlags), methodBase_, (Type[])null, array), methodBase_, ref *(object[]*)null, array, cultureInfo, array4, out object_2);
			FieldInfo[] fieldInfo_ = array5;
			Class7 class41 = @class;
			Type type_8 = type;
			PropertyInfo[] propertyInfo_7 = array3;
			bindingFlags = default(BindingFlags);
			Class7 obj37 = (Class7)class38.t(object_13, (Type)(object)obj36.W(bindingFlags_18, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_19, propertyInfo_6, (Type)null, type_7, (ParameterModifier[])(object)class39.t((BindingFlags)((Class7)null).j(bindingFlags_20, (MethodBase[])(object)class40.t(bindingFlags_21, fieldInfo_, class41.t(null, type_8, (CultureInfo)(object)((Class7)null).W(default(BindingFlags), propertyInfo_7, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null), array2, array)), (CultureInfo)(object)Class5.Default), ref reference, array, cultureInfo, array4, out *(object*)Class5.Default), (FieldInfo[])(object)((Class7)null).W((BindingFlags)Class5.Default, array3, type, (Type[])@class.t(Class5.Default, (Type)((Class7)@class.t(null, (Type)(object)Class5.Default, cultureInfo)).t(null, (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])((Class7)@class.t(null, (Type)(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default), cultureInfo)).t(obj, (Type)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array4, out *(object*)Class5.Default), cultureInfo), null, (CultureInfo)(object)Class5.Default), cultureInfo), null), array), obj, cultureInfo)), type, null, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, null, array)), cultureInfo);
			bindingFlags = default(BindingFlags);
			Class7 obj38 = (Class7)((Class7)(object)obj35.W(bindingFlags_14, null, (Type)(object)class35.W(bindingFlags_15, propertyInfo_5, (Type)(object)((Class7)(object)class36.j(bindingFlags_16, methodBase_, ref object_12, parameterModifier_5, (CultureInfo)(object)class37.t(bindingFlags_17, null, obj37.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array), cultureInfo), (string[])(object)Class5.Default, out *(object*)@class.j(bindingFlags, methodBase_, ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array, cultureInfo, array4, out object_2), array, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, array, cultureInfo, array4, out *(object*)null), out object_2))).e(bindingFlags, methodBase_, array2, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo)), null, (ParameterModifier[])(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, array2, array)), array2, array)).t(obj, (Type)(object)Class5.Default, cultureInfo);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_22 = bindingFlags;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			Type type_9 = type;
			BindingFlags bindingFlags_23 = bindingFlags;
			Type type_10 = (Type)(object)((Class7)null).W(bindingFlags, array3, type, (Type[])null, (ParameterModifier[])(object)Class5.Default);
			Type[] type_11 = array2;
			Class7 obj39 = (Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
			object object_14 = obj;
			Class7 class42 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)obj38.W(bindingFlags_22, propertyInfo_8, type_9, (Type[])(object)((Class7)null).W(bindingFlags_23, (PropertyInfo[])null, type_10, type_11, (ParameterModifier[])(object)((Class7)obj39.t(object_14, null, (CultureInfo)(object)class42.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null))).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array)), (ParameterModifier[])(object)Class5.Default);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
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
				UIntPtr num9 = uIntPtr;
				Class7 class43 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num10 = (UIntPtr)class43.t(bindingFlags, array5, null, null);
				uIntPtr = default(UIntPtr);
				nuint num12;
				nuint num13;
				checked
				{
					nuint num11 = unchecked((nuint)num9) * (unchecked((nuint)num10) - (unchecked(checked(uIntPtr * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, array5, obj, (CultureInfo)(object)Class5.Default), ref reference, (ParameterModifier[])(object)Class5.Default, null, array4, out object_2))) / uIntPtr) - uIntPtr));
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					num12 = num11 - unchecked((nuint)(UIntPtr)class44.j(bindingFlags, methodBase_, ref *(object[]*)((Class7)(object)Class5.Default).W(bindingFlags, array3, type, (Type[])(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), null, (ParameterModifier[])(object)Class5.Default)).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array2, array), array), null, cultureInfo, null, out *(object*)null));
					num13 = uIntPtr;
				}
				nuint num14 = uIntPtr / unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				checked
				{
					nuint num15 = num12 + unchecked(num13 / (num14 / uIntPtr));
					bindingFlags = default(BindingFlags);
					if (unchecked(num15 / checked(unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, array)) - unchecked((nuint)(UIntPtr)@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, array3, type, array2, array))))) * uIntPtr == 0)
					{
						_003CModule_003E = null;
					}
					else
					{
						_ = (Class8)@class.t(obj, type, (CultureInfo)(object)Class5.Default);
						_ = (Struct1)Class5.Default;
						gClass3 = gClass3;
						_ = Class5.Default;
					}
				}
			}
		}
		else
		{
			class31 = null;
		}
		_ = (GClass2)(object)Class5.Default;
		class16 = (Class8)(object)Class5.Default;
		_ = (GClass1)(object)Class5.Default;
		gClass4 = gClass4;
		do
		{
			_ = (Struct2)((Class7)null).W(bindingFlags, array3, type, (Type[])@class.t(((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, array, null, array4, out *(object*)@class.e(bindingFlags, null, null, array)), (MethodBase[])null, array2, array), null, (CultureInfo)((Class7)null).t(obj, type, cultureInfo)), array);
		}
		while (obj != null);
		if ((UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, array), obj, (CultureInfo)(object)Class5.Default)).e(bindingFlags, methodBase_, array2, null), @class.e(bindingFlags, null, (Type[])(object)Class5.Default, array), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			Class7 class45 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class45.t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				try
				{
					@class = (Class7)(object)Class5.Default;
				}
				catch
				{
					class16 = class16;
				}
			}
		}
		do
		{
			class21 = null;
			_ = (Class8)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null);
		}
		while (obj != null);
		_ = (Class8)(object)Class5.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr - uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
				{
					@struct = @struct;
				}
			}
		}
		finally
		{
			if ((UIntPtr)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
			}
			goto IL_2c3a;
		}
		IL_5e4f:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass4 = gClass4;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).W(bindingFlags, array3, null, array2, array);
				}
				finally
				{
					class31 = class31;
					goto end_IL_5e6e;
				}
				end_IL_5e6e:;
			}
			finally
			{
				Class7 class46 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_24 = bindingFlags;
				Class7 class47 = @class;
				BindingFlags bindingFlags_25 = bindingFlags;
				Class7 obj42 = (Class7)(object)@class.t((BindingFlags)Class5.Default, array5, obj, null);
				BindingFlags bindingFlags_26 = (BindingFlags)((Class7)null).j((BindingFlags)@class.t(Class5.Default, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array, cultureInfo, null, out object_2)).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo), methodBase_, ref reference, array, cultureInfo, array4, out *(object*)Class5.Default);
				Class7 obj43 = (Class7)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), methodBase_, array2, array);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class46.e(bindingFlags_24, methodBase_, (Type[])(object)class47.j(bindingFlags_25, (MethodBase[])(object)((Class7)(object)obj42.j(bindingFlags_26, (MethodBase[])(object)obj43.e(bindingFlags, methodBase_, array2, array), ref reference, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out object_2)).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null), type, null, null), ref reference, array, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array), (string[])(object)Class5.Default, out *(object*)((Class7)(object)@class.e(bindingFlags, methodBase_, null, array)).j((BindingFlags)Class5.Default, null, ref reference, null, null, (string[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), out object_2)), array);
				goto IL_60da;
			}
		}
		IL_1521:
		if (uIntPtr == 0)
		{
			try
			{
				nuint num16 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num17 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num18 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num16 - unchecked(num17 / (num18 / uIntPtr))) == 0)
				{
					_ = (Struct1)Class5.Default;
				}
				else
				{
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					ref object[] object_15 = ref reference;
					CultureInfo cultureInfo_4 = cultureInfo;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)((Class7)(object)((Class7)null).t((BindingFlags)@class.t(bindingFlags, array5, null, null), array5, obj, (CultureInfo)null)).t(bindingFlags, array5, obj, cultureInfo);
					object object_16 = @class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
					Class7 obj44 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_29 = bindingFlags;
					MethodBase[] methodBase_7 = (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array3, null, (Type[])(object)Class5.Default, array), type, array2, array), null, null, array), ref reference, array, null, array4, out *(object*)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, null));
					ParameterModifier[] parameterModifier_6 = array;
					CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
					Class7 class49 = @class;
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class48.j(bindingFlags_27, methodBase_, ref object_15, null, cultureInfo_4, (string[])(object)((Class7)null).t(bindingFlags_28, fieldInfo_2, object_16, (CultureInfo)(object)obj44.j(bindingFlags_29, methodBase_7, ref *(object[]*)null, parameterModifier_6, cultureInfo_5, (string[])class49.t(class50.t(bindingFlags, null, Class5.Default, null), type, null), out object_2)), out *(object*)@class.W(bindingFlags, array3, type, null, array));
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)@class.t(bindingFlags, array5, obj, (CultureInfo)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)Class5.Default));
				}
				goto IL_1795;
			}
		}
		goto IL_1795;
		IL_089a:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					continue;
				}
			}
			goto IL_0902;
		}
		try
		{
			_003CModule_003E = null;
		}
		catch
		{
			_ = (Class10)(object)Class5.Default;
		}
		finally
		{
			do
			{
				gClass = gClass;
			}
			while (((Class7)null).t(obj, type, cultureInfo) != null);
			goto IL_0902;
		}
		IL_5818:
		try
		{
			nuint num19 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num19 * uIntPtr) / uIntPtr == 0)
			{
				do
				{
					gClass3 = gClass3;
				}
				while (obj != null);
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					@struct = default(Struct2);
				}
			}
			finally
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
				goto end_IL_5860;
			}
			end_IL_5860:;
		}
		do
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)((Class7)null).t((BindingFlags)@class.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)Class5.Default, null, out object_2), (FieldInfo[])null, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class51.W(bindingFlags, array3, null, (Type[])(object)Class5.Default, null);
				}
				else
				{
					class20 = class20;
				}
			}
		}
		while (obj != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Class7)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo);
				}
				else
				{
					_ = (Class9)((Class7)null).t((object)null, type, (CultureInfo)@class.t(null, type, (CultureInfo)(object)Class5.Default));
				}
				goto IL_59b0;
			}
		}
		goto IL_59b0;
		IL_51ce:
		try
		{
			while (obj != null)
			{
				class16 = null;
			}
		}
		catch
		{
			class4 = (Class0)((Class7)(object)Class5.Default).t(obj, null, cultureInfo);
			_ = Class5.Default;
			_ = (GClass3)(object)Class5.Default;
			Class7 obj47 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
			Type[] type_12 = array2;
			Class7 obj48 = (Class7)(object)Class5.Default;
			object object_17 = obj;
			Type type_13 = (Type)(object)Class5.Default;
			Class7 obj49 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array, (CultureInfo)(object)Class5.Default, array4, out *(object*)((Class7)null).t(obj, type, (CultureInfo)null));
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)obj47.e(bindingFlags_30, methodBase_, type_12, (ParameterModifier[])obj48.t(object_17, type_13, (CultureInfo)(object)((Class7)(object)obj49.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, array4, out *(object*)Class5.Default)).t(bindingFlags, null, obj, null)));
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class4)((Class7)null).t((object)null, (Type)null, (CultureInfo)null);
				}
				finally
				{
					class4 = (Class0)(object)Class5.Default;
					goto IL_5311;
				}
			}
			gClass4 = gClass4;
			goto IL_5311;
		}
		IL_1795:
		try
		{
			_003CModule_003E = _003CModule_003E;
			class20 = null;
			gClass3 = gClass3;
		}
		catch
		{
			while (obj != null)
			{
				if ((UIntPtr)@class.t(obj, type, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		try
		{
			_ = (Class8)(object)@class.t(bindingFlags, array5, obj, null);
		}
		finally
		{
			class16 = null;
			goto IL_1812;
		}
		IL_0902:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = Class5.Default;
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class16 = class16;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			_ = (Class9)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array);
		}
		bindingFlags = default(BindingFlags);
		_ = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo);
		class31 = null;
		gClass4 = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Struct1)Class5.Default;
		}
		try
		{
			gClass2 = null;
			gClass2 = null;
		}
		finally
		{
			do
			{
				gClass4 = gClass4;
			}
			while (obj != null);
			goto IL_09f2;
		}
		IL_1812:
		try
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				_ = (Class9)(object)@class.e(bindingFlags, null, null, array);
				_ = (Class4)(object)@class.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), array4, out object_2);
				_ = (Class10)(object)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				do
				{
					class31 = (Class4)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
				goto end_IL_1813;
			}
			end_IL_1813:;
		}
		catch
		{
			UIntPtr num20 = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if ((nuint)num20 / uIntPtr == 0 && checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, array2, array)).j(bindingFlags, methodBase_, ref reference, null, cultureInfo, array4, out object_2)).t(bindingFlags, null, obj, null);
			}
		}
		if (uIntPtr == 0)
		{
			Class7 obj56 = (Class7)(object)((Class7)(object)@class.W(bindingFlags, array3, type, null, array)).j(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, type, array2, array), ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array2, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_2);
			BindingFlags bindingFlags_31 = (BindingFlags)@class.W(default(BindingFlags), array3, null, array2, array);
			PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)Class5.Default;
			Class7 obj57 = (Class7)((Class7)null).t(obj, type, cultureInfo);
			object object_18 = obj;
			Class7 class52 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj56.W(bindingFlags_31, propertyInfo_9, (Type)obj57.t(object_18, null, (CultureInfo)(object)class52.t(bindingFlags, (FieldInfo[])(object)((Class7)@class.t(obj, null, cultureInfo)).t(bindingFlags, array5, obj, null), obj, cultureInfo)), array2, array) == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					gClass2 = null;
				}
			}
		}
		try
		{
			_ = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array), ref *(object[]*)@class.e(bindingFlags, methodBase_, array2, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo)), array, (CultureInfo)(object)@class.e(bindingFlags, methodBase_, array2, null), array4, out object_2);
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					gClass3 = null;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
		}
		try
		{
			gClass3 = gClass3;
		}
		catch
		{
			try
			{
				class31 = null;
			}
			catch
			{
				class20 = class20;
			}
		}
		_ = (Class0)(object)@class.W((BindingFlags)@class.t(obj, null, cultureInfo), (PropertyInfo[])(object)@class.t(bindingFlags, array5, obj, cultureInfo), (Type)(object)@class.j(bindingFlags, methodBase_, ref reference, array, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), array2, array);
		_ = (Class0)@class.t(obj, null, cultureInfo);
		BindingFlags bindingFlags_32 = (BindingFlags)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo);
		BindingFlags bindingFlags_33 = (BindingFlags)@class.W((BindingFlags)Class5.Default, array3, type, (Type[])(object)Class5.Default, null);
		bindingFlags = default(BindingFlags);
		_ = (Struct2)((Class7)null).t(bindingFlags_32, (FieldInfo[])((Class7)((Class7)(object)((Class7)null).W(bindingFlags_33, (PropertyInfo[])null, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, array), array2, array)).t(null, type, cultureInfo)).t(Class5.Default, null, cultureInfo), obj, (CultureInfo)(object)Class5.Default);
		qk = qk;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 class53 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class53.t(bindingFlags, null, obj, cultureInfo);
				}
			}
			catch
			{
				do
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_34 = bindingFlags;
					Class7 obj62 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_35 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array5;
					object object_19 = ((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])@class.t(null, null, null), null, null, array);
					Class7 class54 = @class;
					Class7 class55 = @class;
					Class7 obj63 = (Class7)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, array, (CultureInfo)(object)Class5.Default, null, out object_2);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).W(bindingFlags_34, (PropertyInfo[])(object)obj62.t(bindingFlags_35, fieldInfo_3, object_19, (CultureInfo)(object)class54.t((BindingFlags)class55.t(null, (Type)(object)obj63.e(bindingFlags, null, array2, null), null), array5, obj, cultureInfo)), type, (Type[])null, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj != null);
			}
		}
		else
		{
			class4 = class4;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 class56 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class56.e(bindingFlags, null, array2, array) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array2, array);
				}
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
					@struct = (Struct2)Class5.Default;
					class16 = class16;
					_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, array3, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				}
				else
				{
					class4 = (Class0)(object)Class5.Default;
				}
				goto IL_1f49;
			}
		}
		goto IL_1f49;
		IL_59b0:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		finally
		{
			gClass3 = gClass3;
			goto IL_59fb;
		}
		IL_489c:
		try
		{
			uIntPtr = default(UIntPtr);
			UIntPtr num21 = uIntPtr;
			UIntPtr num22 = uIntPtr;
			object object_20 = obj;
			Type type_14 = type;
			bindingFlags = default(BindingFlags);
			UIntPtr num23 = (UIntPtr)((Class7)null).t(object_20, type_14, (CultureInfo)(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo));
			bindingFlags = default(BindingFlags);
			if ((nuint)num21 / checked(unchecked((nuint)num22) - unchecked((nuint)num23) * unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array2, array), type, array2, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)@class.j((BindingFlags)@class.t((BindingFlags)Class5.Default, array5, obj, cultureInfo), methodBase_, ref reference, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)@class.t(obj, (Type)(object)Class5.Default, cultureInfo)), cultureInfo, null, out object_2), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out *(object*)null)))) == 0)
			{
				Class7 obj65 = (Class7)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null);
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)(UIntPtr)obj65.W(bindingFlags, array3, null, array2, array)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
				}
			}
			else
			{
				do
				{
					_ = (GClass0)@class.t(Class5.Default, null, null);
				}
				while ((object)Class5.Default != null);
			}
		}
		finally
		{
			do
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_4a8e;
		}
		IL_3513:
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) + unchecked(uIntPtr / (nuint)(UIntPtr)@class.W(bindingFlags, null, null, array2, array)) == 0)
				{
					_ = (Struct1)Class5.Default;
				}
			}
			while (obj != null);
		}
		_ = (Class10)(object)((Class7)null).t((BindingFlags)((Class7)null).t(@class.t(null, null, cultureInfo), type, cultureInfo), array5, obj, (CultureInfo)null);
		bindingFlags = default(BindingFlags);
		@struct = (Struct2)((Class7)null).e(bindingFlags, methodBase_, array2, array);
		_ = (Qk7)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
			_ = (Qk7)(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array2, array)).t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)Class5.Default);
		}
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			Class7 obj67 = (Class7)(object)((Class7)@class.t(obj, null, cultureInfo)).e(bindingFlags, methodBase_, null, array);
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj67.W(bindingFlags, null, null, array2, (ParameterModifier[])(object)Class5.Default);
		}
		else
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(obj, type, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass3 = (GClass0)(object)Class5.Default;
				}
				catch
				{
					class3 = null;
					@struct = default(Struct2);
					_003CModule_003E = null;
				}
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = gClass2;
					Class7 class57 = @class;
					BindingFlags bindingFlags_36 = (BindingFlags)@class.t(bindingFlags, array5, obj, cultureInfo);
					Type[] type_15 = (Type[])(object)((Class7)null).j((BindingFlags)@class.t(obj, type, cultureInfo), (MethodBase[])null, ref *(object[]*)null, array, (CultureInfo)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo), (string[])null, out object_2);
					Class7 obj69 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class57.e(bindingFlags_36, null, type_15, (ParameterModifier[])(object)obj69.e(bindingFlags, null, array2, array));
					gClass2 = gClass2;
				}
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array, (CultureInfo)null, array4, out object_2), type, cultureInfo), ref *(object[]*)Class5.Default, null, (CultureInfo)((Class7)null).t(obj, (Type)null, (CultureInfo)null), array4, out *(object*)null) == (UIntPtr)(nuint)0u)
				{
					class21 = (Class10)@class.t(null, type, cultureInfo);
				}
				goto end_IL_36c0;
			}
			end_IL_36c0:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 obj70 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_37 = bindingFlags;
					ref object[] object_21 = ref reference;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 class58 = @class;
					BindingFlags bindingFlags_38 = (BindingFlags)((Class7)(object)Class5.Default).t(default(BindingFlags), null, obj, cultureInfo);
					PropertyInfo[] propertyInfo_10 = array3;
					Type type_16 = type;
					Type[] type_17 = array2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj70.j(bindingFlags_37, methodBase_, ref object_21, null, cultureInfo_6, (string[])(object)class58.e(bindingFlags_38, (MethodBase[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(default(BindingFlags), propertyInfo_10, type_16, type_17, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default)), (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null), array2, (ParameterModifier[])(object)Class5.Default), out *(object*)null);
					_ = (Class8)(object)((Class7)null).W(bindingFlags, array3, (Type)null, (Type[])(object)Class5.Default, array);
					qk = qk;
				}
				finally
				{
					class21 = class21;
					goto IL_3959;
				}
			}
			goto IL_3959;
		}
		IL_3400:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 class59 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)class59.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array, cultureInfo, array4, out object_2);
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			goto IL_3513;
		}
		try
		{
			gClass3 = gClass3;
			Class7 obj71 = (Class7)(object)@class.e(bindingFlags, null, null, array);
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)obj71.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
		}
		finally
		{
			_ = (Class9)(object)Class5.Default;
			goto IL_3513;
		}
		IL_09f2:
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					try
					{
						gClass = gClass;
					}
					finally
					{
						qk = qk;
						goto end_IL_0a0e;
					}
					end_IL_0a0e:;
				}
				finally
				{
					do
					{
						_ = (GClass3)(object)Class5.Default;
					}
					while ((object)Class5.Default != null);
					goto IL_0a3f;
				}
			}
			goto IL_0a3f;
		}
		IL_60da:
		_ = (Struct2)Class5.Default;
		@class = @class;
		return;
		IL_0a3f:
		nuint num24 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num24 + unchecked(checked(unchecked(uIntPtr / checked(unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, null, array2, array)) - uIntPtr)) * unchecked((nuint)(UIntPtr)((Class7)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array)), array5, obj, cultureInfo)).W((BindingFlags)Class5.Default, null, null, array2, null))) / uIntPtr) != 0)
			{
			}
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					do
					{
						@class = @class;
					}
					while (obj != null);
				}
			}
			while (obj != null)
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						Class7 class60 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Struct1)class60.e(bindingFlags, null, array2, array);
					}
					else
					{
						gClass2 = gClass2;
					}
				}
			}
		}
		try
		{
			nuint num25 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num25 / uIntPtr == 0)
			{
				gClass3 = null;
			}
		}
		finally
		{
			do
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					@class = null;
					_ = (_003CModule_003E)(object)@class.t(bindingFlags, null, ((Class7)null).t(bindingFlags, array5, obj, cultureInfo), cultureInfo);
					Class7 class61 = @class;
					BindingFlags bindingFlags_39 = bindingFlags;
					Class7 class62 = @class;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)class62.t(bindingFlags, array5, null, cultureInfo);
					Type type_18 = (Type)(object)@class.t(bindingFlags, null, @class.j(bindingFlags, methodBase_, ref reference, array, null, array4, out object_2), cultureInfo);
					bindingFlags = default(BindingFlags);
					ref object[] object_22 = ref *(object[]*)((Class7)null).W(default(BindingFlags), propertyInfo_11, type_18, (Type[])null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo));
					Class7 class63 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array5;
					Class7 obj72 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, (ParameterModifier[])null);
					Class7 class64 = @class;
					object object_23 = ((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array, cultureInfo, (string[])null, out object_2);
					Class7 obj73 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class20 = (Class5)(object)class61.j(bindingFlags_39, methodBase_, ref object_22, (ParameterModifier[])(object)class63.t(bindingFlags_40, fieldInfo_4, obj72.t(null, (Type)class64.t(object_23, (Type)(object)obj73.e(bindingFlags, null, (Type[])(object)Class5.Default, null), cultureInfo), (CultureInfo)(object)Class5.Default), (CultureInfo)(object)@class.W(bindingFlags, array3, null, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array, null, (string[])(object)Class5.Default, out object_2)))), cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo));
					class21 = null;
					continue;
				}
			}
			while ((object)Class5.Default != null);
			goto IL_0de8;
		}
		IL_30c4:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				qk = (Qk7)(object)Class5.Default;
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				qk = (Qk7)(object)@class.W(bindingFlags, array3, type, array2, (ParameterModifier[])((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array2, (ParameterModifier[])(object)Class5.Default)).t(null, null, null));
			}
		}
		finally
		{
			while (true)
			{
				if (obj != null)
				{
					class31 = (Class4)@class.t(obj, type, null);
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_3174;
		}
		IL_4a8e:
		class20 = (Class5)@class.t(Class5.Default, type, null);
		_ = (Class2)(object)@class.e(bindingFlags, methodBase_, null, null);
		@struct = @struct;
		class4 = null;
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Struct2)((Class7)null).t(obj, type, (CultureInfo)((Class7)(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo)).t(obj, type, cultureInfo));
				}
			}
			finally
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
					Class7 class65 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class65.W(bindingFlags, array3, null, array2, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					class31 = class31;
					goto end_IL_4ad5;
				}
			}
			end_IL_4ad5:;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array3, null, array2, (ParameterModifier[])(object)Class5.Default)) * (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr)))) == 0)
			{
				Class7 class66 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class66.j(bindingFlags, null, ref *(object[]*)null, array, cultureInfo, array4, out object_2);
			}
			else
			{
				while (obj != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				qk = null;
				_ = (Struct1)@class.t(Class5.Default, type, cultureInfo);
			}
			else if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)@class.W((BindingFlags)@class.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default), array3, type, (Type[])(object)Class5.Default, array) == 0)
			{
				_ = (Class8)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (Class2)(object)((Class7)null).t(bindingFlags, array5, (object)((Class7)null).W((BindingFlags)Class5.Default, array3, type, (Type[])(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), array), cultureInfo);
		}
		_ = (GClass0)(object)@class.W((BindingFlags)Class5.Default, null, null, array2, null);
		try
		{
			BindingFlags bindingFlags_41 = bindingFlags;
			Class7 obj76 = (Class7)(object)@class.j(bindingFlags, null, ref reference, array, cultureInfo, (string[])(object)Class5.Default, out object_2);
			Class7 obj77 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_42 = bindingFlags;
			FieldInfo[] fieldInfo_5 = array5;
			Class7 class67 = @class;
			BindingFlags bindingFlags_43 = (BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array4, out *(object*)null);
			Class7 obj78 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_44 = bindingFlags;
			ref object[] object_24 = ref reference;
			object object_25 = obj;
			BindingFlags bindingFlags_45 = bindingFlags;
			Type[] type_19 = array2;
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)((Class7)null).t(bindingFlags_41, (FieldInfo[])null, (object)((Class7)(object)obj76.j((BindingFlags)obj77.t(bindingFlags_42, fieldInfo_5, class67.e(bindingFlags_43, (MethodBase[])(object)obj78.j(bindingFlags_44, null, ref object_24, (ParameterModifier[])((Class7)null).t(object_25, (Type)(object)((Class7)null).e(bindingFlags_45, (MethodBase[])null, type_19, (ParameterModifier[])(object)class68.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, array)), cultureInfo), cultureInfo, array4, out *(object*)Class5.Default), array2, (ParameterModifier[])(object)Class5.Default), null), null, ref reference, array, null, null, out object_2)).W((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array2, array), array3, type, (Type[])(object)Class5.Default, array), (CultureInfo)null)).j(bindingFlags, null, ref reference, array, cultureInfo, array4, out object_2) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					qk = qk;
				}
			}
			else
			{
				_ = (Class8)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array);
			}
		}
		finally
		{
			_ = (GClass3)(object)@class.W(bindingFlags, array3, null, null, array);
			goto IL_4f06;
		}
		IL_5311:
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		finally
		{
			try
			{
				try
				{
					Class7 obj79 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					Class7 obj80 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_12 = (PropertyInfo[])class69.t(null, null, (CultureInfo)(object)((Class7)null).j(bindingFlags_47, methodBase_, ref *(object[]*)obj80.W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array, cultureInfo, (string[])(object)((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(obj, type, null), type, array2, array), (MethodBase[])(object)Class5.Default, array2, array)).t(bindingFlags, array5, obj, null), out object_2));
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass0)(object)obj79.W(bindingFlags_46, propertyInfo_12, (Type)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array), array2, array);
				}
				finally
				{
					@struct = @struct;
					goto end_IL_5323;
				}
				end_IL_5323:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					class4 = (Class0)@class.t(((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), (Type)(object)Class5.Default, cultureInfo);
				}
			}
			goto IL_54d2;
		}
		IL_59fb:
		while (true)
		{
			if (obj != null)
			{
				_ = (Class6)(object)Class5.Default;
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				nuint num26 = uIntPtr;
				Class7 class70 = @class;
				BindingFlags bindingFlags_48 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_49 = bindingFlags;
				ref object[] object_26 = ref *(object[]*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				ParameterModifier[] parameterModifier_7 = array;
				CultureInfo cultureInfo_7 = cultureInfo;
				string[] string_2 = array4;
				Class7 obj82 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if (checked(num26 + unchecked((nuint)(UIntPtr)class70.e(bindingFlags_48, methodBase_8, null, (ParameterModifier[])(object)((Class7)(object)class71.j(bindingFlags_49, null, ref object_26, parameterModifier_7, cultureInfo_7, string_2, out *(object*)obj82.W(bindingFlags, null, type, array2, array))).j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref reference, null, null, array4, out object_2), methodBase_, ref reference, array, cultureInfo, array4, out object_2)))) == 0)
				{
					Class7 class72 = @class;
					BindingFlags bindingFlags_50 = (BindingFlags)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)(object)@class.W(bindingFlags, array3, type, array2, (ParameterModifier[])(object)Class5.Default));
					ref object[] object_27 = ref reference;
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj83 = (Class7)(object)class73.t(bindingFlags, array5, obj, null);
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)obj83.t(bindingFlags, array5, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					ref object[] object_28 = ref *(object[]*)@class.e(bindingFlags, methodBase_, array2, array);
					ParameterModifier[] parameterModifier_9 = array;
					CultureInfo cultureInfo_8 = cultureInfo;
					string[] string_3 = array4;
					Class7 class74 = @class;
					BindingFlags bindingFlags_52 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class72.j(bindingFlags_50, methodBase_, ref object_27, parameterModifier_8, (CultureInfo)(object)((Class7)null).j(bindingFlags_51, (MethodBase[])null, ref object_28, parameterModifier_9, cultureInfo_8, string_3, out *(object*)class74.t(bindingFlags_52, null, ((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)null).j((BindingFlags)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, array2, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array, cultureInfo, array4, out *(object*)null), array, cultureInfo, (string[])null, out object_2), cultureInfo)), array4, out object_2);
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (GClass2)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)@class.e((BindingFlags)Class5.Default, methodBase_, array2, (ParameterModifier[])(object)Class5.Default), cultureInfo);
					Class7 class75 = @class;
					Class7 obj84 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class31 = (Class4)class75.t(null, (Type)(object)obj84.t(bindingFlags, array5, obj, cultureInfo), (CultureInfo)(object)@class.t(bindingFlags, null, obj, cultureInfo));
				}
			}
		}
		try
		{
			Class7 obj86 = (Class7)((Class7)null).t((object)null, type, cultureInfo);
			BindingFlags bindingFlags_53 = (BindingFlags)@class.e(bindingFlags, methodBase_, array2, array);
			ref object[] object_29 = ref reference;
			ParameterModifier[] parameterModifier_10 = array;
			CultureInfo cultureInfo_9 = cultureInfo;
			string[] string_4 = array4;
			Class7 obj87 = (Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
			Class7 class76 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj86.j(bindingFlags_53, methodBase_, ref object_29, parameterModifier_10, cultureInfo_9, string_4, out *(object*)((Class7)((Class7)null).t((object)obj87.e((BindingFlags)class76.t(bindingFlags, array5, obj, cultureInfo), null, null, null), type, (CultureInfo)null)).e((BindingFlags)Class5.Default, methodBase_, array2, array));
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				while (obj != null)
				{
					struct2 = default(Struct1);
					class3 = class3;
				}
			}
			goto IL_5e4f;
		}
		IL_3174:
		try
		{
			while (obj != null)
			{
				_ = (Class8)(object)Class5.Default;
				Class7 class77 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)(object)class77.W(bindingFlags, null, type, (Type[])((Class7)null).t(obj, (Type)null, cultureInfo), array)).e(bindingFlags, methodBase_, array2, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array, cultureInfo, (string[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array3, type, array2, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, methodBase_, ref reference, array, cultureInfo, null, out object_2)), out *(object*)null));
				_ = (Qk7)@class.t(obj, type, cultureInfo);
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				@struct = (Struct2)Class5.Default;
				qk = qk;
				Class7 class78 = @class;
				bindingFlags = default(BindingFlags);
				class31 = (Class4)(object)class78.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null);
				_ = (Class9)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, array4, out *(object*)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, (Type)(object)Class5.Default, array2, array), array2, array));
			}
			else
			{
				Class7 class79 = @class;
				BindingFlags bindingFlags_54 = bindingFlags;
				MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
				ref object[] object_30 = ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array4, out object_2);
				ParameterModifier[] parameterModifier_11 = array;
				CultureInfo cultureInfo_10 = (CultureInfo)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo);
				string[] string_5 = array4;
				bindingFlags = default(BindingFlags);
				class4 = (Class0)((Class7)(object)class79.j(bindingFlags_54, methodBase_9, ref object_30, parameterModifier_11, cultureInfo_10, string_5, out *(object*)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])null))).t(null, null, (CultureInfo)(object)Class5.Default);
			}
			goto IL_3400;
		}
		IL_0de8:
		if (uIntPtr == 0)
		{
			try
			{
				while (true)
				{
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)class80.e(bindingFlags, methodBase_, null, null) != null)
					{
						_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
						continue;
					}
					break;
				}
			}
			finally
			{
				_ = (Class0)(object)@class.W(bindingFlags, array3, null, array2, array);
				goto IL_0f52;
			}
		}
		do
		{
			try
			{
				Class7 class81 = @class;
				object object_31 = obj;
				Type type_20 = type;
				BindingFlags bindingFlags_55 = (BindingFlags)@class.t(null, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, obj, cultureInfo), cultureInfo);
				Class7 class82 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class81.t(object_31, type_20, (CultureInfo)(object)((Class7)null).e(bindingFlags_55, (MethodBase[])(object)class82.j(bindingFlags, methodBase_, ref reference, array, cultureInfo, array4, out object_2), array2, (ParameterModifier[])null));
			}
			finally
			{
				_ = (Class4)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null), cultureInfo);
				continue;
			}
		}
		while (obj != null);
		goto IL_0f52;
		IL_2c3a:
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 obj88 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj88.W(bindingFlags, array3, type, array2, null);
				}
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			Class7 obj91;
			BindingFlags bindingFlags_57;
			do
			{
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					qk = null;
				}
				else
				{
					Class7 class83 = @class;
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_56 = bindingFlags;
					FieldInfo[] fieldInfo_6 = array5;
					Class7 obj89 = (Class7)(object)@class.t(bindingFlags, null, obj, cultureInfo);
					bindingFlags = default(BindingFlags);
					Class7 obj90 = (Class7)(object)obj89.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out object_2);
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class83.W((BindingFlags)class84.t(bindingFlags_56, fieldInfo_6, obj90.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo), null, null, null, (ParameterModifier[])(object)Class5.Default);
				}
				obj91 = (Class7)(object)Class5.Default;
				bindingFlags_57 = bindingFlags;
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj91.e(bindingFlags_57, (MethodBase[])(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), null, null) != null);
		}
		catch
		{
			Class7 class85 = @class;
			BindingFlags bindingFlags_58 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, array);
			Class7 class86 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)class85.e(bindingFlags_58, (MethodBase[])(object)class86.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array), null, type, null, null), array2, array);
			class20 = class20;
		}
		@class = null;
		_ = (Class0)(object)Class5.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class87.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array);
					class16 = class16;
					gClass2 = gClass2;
					class20 = null;
				}
				catch
				{
					class16 = class16;
				}
			}
			while (obj != null);
		}
		_ = (Struct1)Class5.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (GClass3)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null);
			_ = (Class2)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
			class3 = class3;
			goto IL_2fe6;
		}
		try
		{
			_ = (Class6)(object)@class.e(bindingFlags, null, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(default(BindingFlags), array5, obj, (CultureInfo)(object)Class5.Default), null, null, out object_2));
		}
		finally
		{
			do
			{
				Class7 obj94 = (Class7)(object)Class5.Default;
				ref object[] object_32 = ref reference;
				bindingFlags = default(BindingFlags);
				class16 = (Class8)(object)obj94.j(default(BindingFlags), null, ref object_32, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), null, (string[])(object)Class5.Default, out *(object*)@class.t(Class5.Default, type, cultureInfo));
			}
			while (@class.t(@class.t(obj, null, cultureInfo), (Type)(object)Class5.Default, cultureInfo) != null);
			goto IL_2fe6;
		}
		IL_3bbe:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class4)(object)((Class7)null).e(bindingFlags, methodBase_, array2, (ParameterModifier[])null);
					Class7 class88 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class88.W(bindingFlags, null, type, array2, null);
					@struct = @struct;
				}
				catch
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				BindingFlags bindingFlags_59 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_7 = array5;
				Class7 class89 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj96 = (Class7)(object)((Class7)null).t(bindingFlags_59, fieldInfo_7, (object)class89.W(bindingFlags, array3, null, null, null), cultureInfo);
				BindingFlags bindingFlags_60 = bindingFlags;
				PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)@class.t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)Class5.Default);
				Type type_21 = type;
				Type[] type_22 = array2;
				Class7 class90 = @class;
				FieldInfo[] fieldInfo_8 = (FieldInfo[])@class.t(null, type, null);
				Class7 obj97 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((nuint)(UIntPtr)((Class7)((Class7)null).t((object)obj96.W(bindingFlags_60, propertyInfo_13, type_21, type_22, (ParameterModifier[])(object)class90.t(default(BindingFlags), fieldInfo_8, obj97.t(bindingFlags, null, Class5.Default, cultureInfo), cultureInfo)), (Type)null, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array3, type, array2, array) / checked(unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo)) + unchecked((nuint)default(UIntPtr))) == 0)
				{
					class31 = class31;
				}
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				qk = null;
			}
		}
		try
		{
			_ = Class5.Default;
		}
		catch
		{
			Class7 obj99 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, null);
			BindingFlags bindingFlags_61 = (BindingFlags)@class.t(null, (Type)(object)Class5.Default, null);
			MethodBase[] methodBase_10 = (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null);
			ref object[] object_33 = ref reference;
			ParameterModifier[] parameterModifier_12 = array;
			Class7 class91 = @class;
			Class7 obj100 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj101 = (Class7)class91.t(obj100.W(bindingFlags, array3, type, array2, null), (Type)(object)@class.W(bindingFlags, null, type, null, null), cultureInfo);
			BindingFlags bindingFlags_62 = (BindingFlags)Class5.Default;
			Class7 obj102 = (Class7)(object)@class.e(bindingFlags, methodBase_, array2, array);
			bindingFlags = default(BindingFlags);
			nuint num27;
			checked
			{
				num27 = unchecked((nuint)(UIntPtr)obj99.j(bindingFlags_61, methodBase_10, ref object_33, parameterModifier_12, null, null, out *(object*)obj101.t(bindingFlags_62, (FieldInfo[])(object)obj102.W(bindingFlags, null, type, array2, array), obj, null))) * unchecked((nuint)(UIntPtr)((Class7)@class.t(obj, type, cultureInfo)).W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default));
				uIntPtr = default(UIntPtr);
			}
			if (checked(num27 * uIntPtr) / uIntPtr == 0)
			{
				try
				{
					object object_34 = obj;
					Class7 obj103 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_63 = bindingFlags;
					ref object[] object_35 = ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, array, cultureInfo, (string[])(object)@class.e(bindingFlags, methodBase_, array2, null), out object_2), obj, cultureInfo);
					ParameterModifier[] parameterModifier_13 = array;
					Class7 class92 = @class;
					BindingFlags bindingFlags_64 = (BindingFlags)Class5.Default;
					Class7 class93 = @class;
					BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
					Class7 class94 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)null).t(object_34, (Type)(object)obj103.j(bindingFlags_63, methodBase_, ref object_35, parameterModifier_13, null, null, out *(object*)class92.W(bindingFlags_64, (PropertyInfo[])(object)class93.W(bindingFlags_65, (PropertyInfo[])(object)class94.j(bindingFlags, (MethodBase[])((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array)).t(obj, (Type)(object)Class5.Default, cultureInfo), ref reference, null, cultureInfo, array4, out *(object*)Class5.Default), (Type)(object)((Class7)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, array), (FieldInfo[])(object)Class5.Default, obj, cultureInfo)).t((BindingFlags)Class5.Default, null, obj, (CultureInfo)(object)Class5.Default), null, (ParameterModifier[])(object)Class5.Default), type, (Type[])(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array, (CultureInfo)null, array4, out object_2), array)), (CultureInfo)null);
					_ = (Class6)(object)Class5.Default;
					class12 = class12;
				}
				catch
				{
					class20 = class20;
				}
			}
		}
		Class7 class95 = @class;
		BindingFlags bindingFlags_66 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)class95.t(bindingFlags_66, null, ((Class7)null).t(bindingFlags, array5, obj, cultureInfo), null);
		try
		{
			try
			{
				class20 = class20;
			}
			finally
			{
				_ = (Qk7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, array, null, null, out *(object*)null);
				goto end_IL_4164;
			}
			end_IL_4164:;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					class12 = null;
				}
				finally
				{
					@class = (Class7)(object)Class5.Default;
					_ = (GClass1)(object)((Class7)((Class7)(object)@class.W(bindingFlags, array3, null, array2, array)).t(obj, null, cultureInfo)).t(bindingFlags, (FieldInfo[])((Class7)null).t(obj, type, (CultureInfo)null), null, (CultureInfo)(object)Class5.Default);
					Class7 class96 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class96.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default);
					continue;
				}
			}
		}
		try
		{
			Class7 class97 = @class;
			BindingFlags bindingFlags_67 = (BindingFlags)@class.j(bindingFlags, methodBase_, ref reference, array, cultureInfo, array4, out *(object*)@class.t(obj, type, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default)));
			ref object[] object_36 = ref reference;
			ParameterModifier[] parameterModifier_14 = array;
			Class7 class98 = @class;
			bindingFlags = default(BindingFlags);
			CultureInfo cultureInfo_11 = (CultureInfo)(object)((Class7)(object)class98.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj, null), (CultureInfo)(object)Class5.Default, array4, out object_2)).j((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array4, out object_2)).j(bindingFlags, methodBase_, ref *(object[]*)null, array, null, null, out object_2), null, ref reference, array, cultureInfo, array4, out *(object*)null);
			Class7 class99 = @class;
			BindingFlags bindingFlags_68 = (BindingFlags)Class5.Default;
			ref object[] object_37 = ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, array);
			ParameterModifier[] parameterModifier_15 = (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, array2, null);
			CultureInfo cultureInfo_12 = cultureInfo;
			BindingFlags bindingFlags_69 = bindingFlags;
			Class7 class100 = @class;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct1)((Class7)null).e((BindingFlags)class97.j(bindingFlags_67, methodBase_, ref object_36, parameterModifier_14, cultureInfo_11, null, out *(object*)((Class7)null).t((BindingFlags)class99.j(bindingFlags_68, methodBase_, ref object_37, parameterModifier_15, cultureInfo_12, (string[])(object)((Class7)null).t(bindingFlags_69, (FieldInfo[])class100.t(((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), cultureInfo, array4, out *(object*)null), null, null), (object)null, cultureInfo), out object_2), (FieldInfo[])null, obj, (CultureInfo)null)), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class9)(object)Class5.Default;
				BindingFlags bindingFlags_70 = bindingFlags;
				ref object[] object_38 = ref reference;
				ParameterModifier[] parameterModifier_16 = (ParameterModifier[])(object)Class5.Default;
				Class7 class101 = @class;
				BindingFlags bindingFlags_71 = (BindingFlags)Class5.Default;
				Type type_23 = type;
				Class7 class102 = @class;
				object object_39 = obj;
				BindingFlags bindingFlags_72 = (BindingFlags)@class.t(obj, type, cultureInfo);
				ParameterModifier[] parameterModifier_17 = (ParameterModifier[])((Class7)(object)((Class7)(object)@class.W(bindingFlags, array3, null, null, array)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null)).t(obj, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo);
				bindingFlags = default(BindingFlags);
				Class7 obj107 = (Class7)(object)((Class7)null).j(bindingFlags_70, methodBase_, ref object_38, parameterModifier_16, (CultureInfo)class101.t(((Class7)null).W(bindingFlags_71, (PropertyInfo[])null, type_23, (Type[])class102.t(object_39, (Type)(object)((Class7)null).j(bindingFlags_72, (MethodBase[])null, ref *(object[]*)null, parameterModifier_17, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), (object)((Class7)(object)@class.W((BindingFlags)Class5.Default, array3, type, array2, array)).e(bindingFlags, null, array2, array), cultureInfo), array4, out object_2), (CultureInfo)(object)@class.W((BindingFlags)@class.t(Class5.Default, type, cultureInfo), (PropertyInfo[])(object)Class5.Default, type, null, array)), (ParameterModifier[])(object)Class5.Default), type, (CultureInfo)(object)Class5.Default), array4, out object_2);
				BindingFlags bindingFlags_73 = (BindingFlags)@class.t(null, type, null);
				Class7 class103 = @class;
				bindingFlags = default(BindingFlags);
				class12 = (Class6)(object)obj107.t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).j(bindingFlags_73, (MethodBase[])(object)class103.e(bindingFlags, null, array2, array), ref *(object[]*)null, array, cultureInfo, array4, out object_2), obj, cultureInfo);
				gClass2 = (GClass1)(object)Class5.Default;
			}
			else
			{
				gClass3 = (GClass0)(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array, cultureInfo, null, out object_2), array3, null, array2, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, array3, type, (Type[])(object)Class5.Default, null));
			}
		}
		_ = (Struct1)Class5.Default;
		try
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
				gClass2 = null;
				_ = (Class6)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo, null, out object_2);
			}
			catch
			{
				gClass = gClass;
			}
			finally
			{
				class20 = null;
				goto end_IL_477a;
			}
			end_IL_477a:;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 obj110 = (Class7)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, array2, (ParameterModifier[])(object)Class5.Default));
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj110.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
				}
				else
				{
					_ = (Qk7)(object)@class.W((BindingFlags)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), array3, null, array2, array);
				}
			}
			catch
			{
				@class = (Class7)(object)Class5.Default;
			}
			goto IL_489c;
		}
		IL_4f5d:
		qk = qk;
		try
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					class21 = (Class10)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					_ = (Class2)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, array);
					continue;
				}
			}
		}
		catch
		{
			try
			{
				Class7 obj112;
				BindingFlags bindingFlags_74;
				do
				{
					Class7 class104 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class104.W(bindingFlags, array3, type, null, array);
					obj112 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					bindingFlags_74 = bindingFlags;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).e((BindingFlags)obj112.W(bindingFlags_74, null, (Type)(object)((Class7)null).W(bindingFlags, array3, type, (Type[])(object)@class.W((BindingFlags)@class.W(bindingFlags, null, (Type)(object)@class.W((BindingFlags)@class.t(obj, type, cultureInfo), array3, null, array2, null), null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, null)), array3, type, array2, array), (ParameterModifier[])null), array2, null), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array) != null);
			}
			finally
			{
				qk = (Qk7)(object)Class5.Default;
				goto end_IL_4fca;
			}
			end_IL_4fca:;
		}
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - (uIntPtr + uIntPtr)) == 0)
			{
				while (obj != null)
				{
					class20 = Class5.Default;
				}
			}
			else
			{
				do
				{
					gClass4 = null;
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					gClass3 = gClass3;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class2)(object)@class.j(bindingFlags, methodBase_, ref reference, null, (CultureInfo)((Class7)null).t(obj, (Type)null, (CultureInfo)null), null, out *(object*)null);
				}
			}
			goto IL_51ce;
		}
		IL_0f52:
		_ = (Class8)(object)Class5.Default;
		try
		{
			if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				Class7 obj114 = (Class7)(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out object_2), (string[])(object)Class5.Default, out *(object*)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null)), null, ref reference, array, (CultureInfo)(object)Class5.Default, array4, out object_2);
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)obj114.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)null).t(obj, (Type)(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), (CultureInfo)(object)Class5.Default));
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class34 = class34;
					class34 = class34;
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					goto IL_10ec;
				}
			}
			goto IL_10ec;
		}
		IL_10ec:
		gClass3 = gClass3;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					Class7 class105 = @class;
					BindingFlags bindingFlags_75 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_9 = array5;
					object object_40 = ((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array);
					Class7 class106 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class105.t(bindingFlags_75, fieldInfo_9, object_40, (CultureInfo)(object)class106.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array));
				}
				while (obj != null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					_ = Class5.Default;
					class12 = class12;
					_ = (Class5)((Class7)null).t(obj, type, cultureInfo);
				}
				goto IL_1252;
			}
		}
		try
		{
			try
			{
				gClass4 = null;
			}
			finally
			{
				_ = (Class2)(object)Class5.Default;
				goto end_IL_11c1;
			}
			end_IL_11c1:;
		}
		catch
		{
			try
			{
				_ = (Class9)(object)@class.e(default(BindingFlags), methodBase_, array2, null);
			}
			finally
			{
				Class7 obj115 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)obj115.t(bindingFlags, array5, obj, (CultureInfo)(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array));
				goto end_IL_11d8;
			}
			end_IL_11d8:;
		}
		goto IL_1252;
	}

	unsafe static void smethod_4()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (checked(unchecked((nuint)default(UIntPtr)) + uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			while (true)
			{
				Class7 obj = (Class7)(object)Class5.Default;
				bindingFlags = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
				type = null;
				Type type_ = type;
				array = array;
				BindingFlags bindingFlags_ = (BindingFlags)((Class7)null).W(default(BindingFlags), propertyInfo_, type_, array, (ParameterModifier[])(object)Class5.Default);
				array2 = array2;
				Class7 obj2 = (Class7)(object)obj.W(bindingFlags_, array2, null, array, null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_2 = bindingFlags;
				obj3 = obj3;
				object object_ = obj3;
				Class7 class2 = @class;
				object object_2 = obj3;
				Type type_2 = type;
				cultureInfo = cultureInfo;
				@class = (Class7)((Class7)null).t(object_, (Type)null, (CultureInfo)class2.t(object_2, type_2, cultureInfo));
				Class7 class3 = @class;
				BindingFlags bindingFlags_3 = bindingFlags;
				array3 = null;
				MethodBase[] methodBase_ = array3;
				reference = ref *(object[]*)null;
				ref object[] object_3 = ref reference;
				array4 = array4;
				ParameterModifier[] parameterModifier_ = array4;
				CultureInfo cultureInfo_ = cultureInfo;
				Class7 class4 = @class;
				BindingFlags bindingFlags_4 = bindingFlags;
				array5 = null;
				if ((object)obj2.t(bindingFlags_2, (FieldInfo[])(object)class3.j(bindingFlags_3, methodBase_, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)class4.t(bindingFlags_4, array5, @class.e(bindingFlags, array3, (Type[])(object)Class5.Default, null), null), out *(object*)Class5.Default), ((Class7)null).t(bindingFlags, array5, (object)((Class7)null).e(default(BindingFlags), array3, array, (ParameterModifier[])(object)Class5.Default), cultureInfo), cultureInfo) != null)
				{
					qk = qk;
					qk = null;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (GClass0)(object)@class.e(bindingFlags, array3, null, null);
				}
				finally
				{
					class5 = null;
					class5 = null;
					Class5 obj4 = Class5.Default;
					class6 = class6;
					class6 = obj4;
					_ = (GClass0)(object)Class5.Default;
					@class = null;
					goto IL_0263;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				gClass = gClass;
				gClass = gClass;
			}
		}
		goto IL_0263;
		IL_10c6:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class8);
		while (obj3 != null)
		{
			try
			{
				_ = (Class8)(object)@class.e(bindingFlags, array3, array, array4);
			}
			catch
			{
				Class7 obj5 = (Class7)(object)Class5.Default;
				Class7 class7 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_5 = bindingFlags;
				Class7 obj6 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj5.j((BindingFlags)class7.j(bindingFlags_5, (MethodBase[])(object)((Class7)null).e((BindingFlags)obj6.t(bindingFlags, array5, obj3, null), (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, array3, (Type[])null, (ParameterModifier[])null), (Type[])null, array4), ref reference, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), cultureInfo, array6, out *(object*)null), null, ref reference, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj3, null), cultureInfo, null, out object_4);
				class8 = class8;
				_ = (GClass0)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j((BindingFlags)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo), array3, ref reference, null, null, array6, out object_4), (Type[])null, (ParameterModifier[])null);
			}
			finally
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
				}
				while ((object)@class.j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array5, obj3, null), ref reference, null, cultureInfo, array6, out object_4) != null);
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				_ = (Class2)(object)Class5.Default;
				continue;
			}
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			_ = (Struct2)((Class7)(object)Class5.Default).W(bindingFlags, null, null, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])@class.t(((Class7)(object)Class5.Default).j(bindingFlags, array3, ref reference, null, cultureInfo, array6, out *(object*)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array4, (CultureInfo)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, array3, null, array4)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, (CultureInfo)null), obj3, cultureInfo), (string[])(object)Class5.Default, out object_4)), type, cultureInfo), type, null, array4), null);
			_ = (_003CModule_003E)(object)Class5.Default;
			_ = (GClass3)((Class7)null).t((object)null, type, cultureInfo);
		}
		while (obj3 != null || obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		GClass2 gClass3;
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 class9 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class9.e(bindingFlags, array3, array, array4);
				}
			}
			catch
			{
				do
				{
					gClass2 = gClass2;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			try
			{
				try
				{
					gClass3 = null;
				}
				catch
				{
					gClass3 = gClass3;
					class10 = (Class4)(object)Class5.Default;
					gClass2 = gClass2;
				}
			}
			catch
			{
				class8 = class8;
			}
		}
		_ = (Class2)(object)Class5.Default;
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				@class = @class;
			}
		}
		finally
		{
			class5 = class5;
			goto IL_12e4;
		}
		IL_4e51:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class13);
		try
		{
			do
			{
				try
				{
					_ = (Struct1)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass0)((Class7)null).t(obj3, (Type)null, cultureInfo);
					Class7 class11 = @class;
					BindingFlags bindingFlags_6 = bindingFlags;
					MethodBase[] methodBase_2 = (MethodBase[])(object)((Class7)(object)@class.t(bindingFlags, null, null, cultureInfo)).e(default(BindingFlags), null, array, (ParameterModifier[])(object)Class5.Default);
					ref object[] object_5 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_2 = array4;
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)(object)class11.j(bindingFlags_6, methodBase_2, ref object_5, parameterModifier_2, null, (string[])(object)((Class7)(object)class12.j(bindingFlags, array3, ref reference, null, null, array6, out object_4)).W(bindingFlags, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, (Type[])@class.t(obj3, (Type)(object)Class5.Default, cultureInfo), null)), out *(object*)null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array4));
					continue;
				}
			}
			while (obj3 != null);
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
			gClass2 = gClass2;
			class13 = class13;
			Class7 class14 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)class14.W(bindingFlags, null, type, array, (ParameterModifier[])(object)((Class7)((Class7)null).t(obj3, type, (CultureInfo)null)).t(bindingFlags, null, obj3, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t(obj3, (Type)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array4, cultureInfo, (string[])@class.t(obj3, null, cultureInfo), out object_4), cultureInfo), ref *(object[]*)@class.t(bindingFlags, null, obj3, null), (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_4)));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class15);
		try
		{
			try
			{
				gClass2 = null;
			}
			finally
			{
				try
				{
					@struct = @struct;
				}
				catch
				{
					class5 = (Class9)(object)Class5.Default;
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null);
				}
				goto end_IL_50a9;
			}
			end_IL_50a9:;
		}
		catch
		{
			if (uIntPtr != 0)
			{
				try
				{
					class5 = class5;
				}
				finally
				{
					class10 = class10;
					_ = (Class4)(object)Class5.Default;
					qk = (Qk7)(object)Class5.Default;
					goto end_IL_50e8;
				}
			}
			class15 = class15;
			end_IL_50e8:;
		}
		try
		{
			Class7 class16 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_7 = bindingFlags;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class16.j(bindingFlags_7, (MethodBase[])((Class7)(object)((Class7)null).j(bindingFlags, array3, ref reference, array4, (CultureInfo)null, (string[])null, out object_4)).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				class15 = class15;
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
		}
		checked
		{
			while (obj3 != null)
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)) == 0)
				{
					do
					{
						class5 = class5;
					}
					while ((object)Class5.Default != null);
				}
			}
		}
		Class6 class17 = (Class6)(object)((Class7)null).W((BindingFlags)@class.e(bindingFlags, null, array, null), (PropertyInfo[])(object)Class5.Default, type, array, (ParameterModifier[])null);
		Struct2 struct2;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class6)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
			@struct = (Struct1)Class5.Default;
			qk = qk;
		}
		else
		{
			struct2 = (Struct2)Class5.Default;
		}
		try
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			return;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class15 = class15;
					return;
				}
				finally
				{
					class6 = class6;
					return;
				}
			}
			return;
		}
		IL_2608:
		if (uIntPtr == 0)
		{
			@class = @class;
		}
		try
		{
			try
			{
				do
				{
					@struct = default(Struct1);
					@struct = @struct;
				}
				while (obj3 != null);
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (GClass1)(object)Class5.Default;
				}
				goto end_IL_2617;
			}
			end_IL_2617:;
		}
		catch
		{
			_ = (Class2)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, null, (string[])(object)((Class7)null).W((BindingFlags)Class5.Default, array2, type, (Type[])(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array, array4), array3, (Type[])(object)Class5.Default, array4), cultureInfo, array6, out *(object*)Class5.Default), array4), out object_4);
		}
		gClass = gClass;
		_ = (Class10)(object)Class5.Default;
		Class7 class18 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_8 = bindingFlags;
		PropertyInfo[] propertyInfo_2 = array2;
		Type type_3 = type;
		Class7 obj18 = (Class7)(object)Class5.Default;
		Class7 obj19 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_9 = bindingFlags;
		Class7 obj20 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_10 = bindingFlags;
		FieldInfo[] fieldInfo_ = array5;
		object object_6 = obj3;
		BindingFlags bindingFlags_11 = bindingFlags;
		ref object[] object_7 = ref *(object[]*)Class5.Default;
		Class7 obj21 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class10)(object)class18.W(bindingFlags_8, propertyInfo_2, type_3, null, (ParameterModifier[])(object)obj18.j((BindingFlags)obj19.t(bindingFlags_9, null, obj20.t(bindingFlags_10, fieldInfo_, object_6, (CultureInfo)(object)((Class7)null).j(bindingFlags_11, (MethodBase[])null, ref object_7, (ParameterModifier[])null, (CultureInfo)(object)obj21.j(bindingFlags, array3, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out object_4), (string[])null, out object_4)), cultureInfo), null, ref reference, array4, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(null, (Type)(object)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)null), null)));
		_ = (Class6)(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)Class5.Default);
		_ = (Class4)(object)@class.W(bindingFlags, null, null, null, null);
		class6 = class6;
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class9)(object)Class5.Default;
				}
				while (obj3 != null);
			}
			else
			{
				_ = (GClass2)(object)@class.t(bindingFlags, array5, null, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, array4, cultureInfo, array6, out *(object*)null));
			}
		}
		while (obj3 != null);
		BindingFlags bindingFlags_12 = bindingFlags;
		MethodBase[] methodBase_3 = (MethodBase[])(object)@class.e(bindingFlags, array3, (Type[])(object)@class.t(bindingFlags, array5, null, cultureInfo), (ParameterModifier[])(object)Class5.Default);
		Class7 class19 = @class;
		BindingFlags bindingFlags_13 = (BindingFlags)@class.t(bindingFlags, array5, obj3, cultureInfo);
		PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)@class.W(bindingFlags, array2, null, array, array4);
		bindingFlags = default(BindingFlags);
		checked
		{
			nuint num = unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags_12, methodBase_3, (Type[])(object)class19.W(bindingFlags_13, propertyInfo_3, (Type)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null)).j((BindingFlags)Class5.Default, null, ref reference, array4, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, array, (ParameterModifier[])(object)Class5.Default), cultureInfo), null, out *(object*)Class5.Default), null, (ParameterModifier[])(object)Class5.Default), array4)) + uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((num - uIntPtr - uIntPtr) * (unchecked((nuint)(UIntPtr)@class.t(@class.t(bindingFlags, array5, @class.t(null, null, cultureInfo), null), type, cultureInfo)) + uIntPtr) == 0)
			{
				Class7 class20 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class20.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
			}
			try
			{
				while (obj3 != null)
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						class17 = class17;
					}
					else
					{
						class10 = (Class4)(object)Class5.Default;
					}
				}
			}
			catch
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj3 != null || (object)Class5.Default != null);
			}
			if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				while (obj3 != null)
				{
					try
					{
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_14 = bindingFlags;
						bindingFlags = default(BindingFlags);
						PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array4);
						Class7 class21 = @class;
						bindingFlags = default(BindingFlags);
						class8 = (Class8)(object)((Class7)null).W(bindingFlags_14, propertyInfo_4, (Type)(object)((Class7)(object)class21.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out object_4)).W(bindingFlags, null, null, (Type[])(object)Class5.Default, array4), array, array4);
					}
					catch
					{
						_ = (GClass0)(object)@class.e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default);
						_ = (Class10)(object)Class5.Default;
						_ = (Class10)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						_ = (Class7)(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo);
					}
				}
			}
		}
		if ((UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])@class.t(Class5.Default, null, cultureInfo), (object)null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			do
			{
				class10 = (Class4)(object)Class5.Default;
			}
			while (obj3 != null || obj3 != null);
		}
		else
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
				struct2 = (Struct2)@class.W(bindingFlags, null, type, null, array4);
				gClass = gClass;
				_ = (Class9)(object)@class.t((BindingFlags)((Class7)null).t(obj3, (Type)null, (CultureInfo)null), null, @class.t((BindingFlags)Class5.Default, array5, Class5.Default, cultureInfo), null);
			}
			catch
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
				}
				catch
				{
					class8 = (Class8)(object)Class5.Default;
				}
			}
		}
		try
		{
			do
			{
				if ((UIntPtr)@class.t(bindingFlags, null, @class.W((BindingFlags)@class.e(bindingFlags, array3, (Type[])(object)Class5.Default, null), array2, type, array, array4), cultureInfo) == (UIntPtr)(nuint)0u)
				{
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)((Class7)(object)class22.t(bindingFlags, array5, obj3, null)).t(null, type, cultureInfo);
				}
			}
			while (obj3 != null);
		}
		finally
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
			goto IL_2e3c;
		}
		IL_2eaa:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass4 = null;
			}
		}
		finally
		{
			while (obj3 != null)
			{
				try
				{
					class17 = class17;
				}
				catch
				{
					Class7 class23 = @class;
					MethodBase[] methodBase_4 = array3;
					ParameterModifier[] parameterModifier_3 = array4;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass2)(object)class23.j(default(BindingFlags), methodBase_4, ref *(object[]*)null, parameterModifier_3, (CultureInfo)(object)((Class7)(object)class24.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, (Type[])(object)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array3, (Type[])null, (ParameterModifier[])null)), array4), ref reference, null, (CultureInfo)((Class7)null).t((object)null, type, cultureInfo), null, out object_4)).W(bindingFlags, array2, type, array, (ParameterModifier[])(object)Class5.Default), (string[])(object)((Class7)@class.t(null, null, cultureInfo)).W(bindingFlags, array2, null, null, null), out object_4);
				}
			}
			goto IL_2fea;
		}
		IL_2fea:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				_ = (Struct2)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		_ = (Class4)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj3, (CultureInfo)(object)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)((Class7)(object)Class5.Default).t(obj3, (Type)(object)Class5.Default, null)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class26);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Qk7)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			else
			{
				try
				{
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class25.e(bindingFlags, array3, array, null);
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
					gClass2 = null;
					class26 = class26;
				}
			}
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					Class7 obj28 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_15 = bindingFlags;
					MethodBase[] methodBase_5 = array3;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj28.j(bindingFlags_15, methodBase_5, ref *(object[]*)null, null, (CultureInfo)(object)class27.e(bindingFlags, null, array, array4), (string[])(object)Class5.Default, out object_4);
				}
			}
			finally
			{
				if ((UIntPtr)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W((BindingFlags)@class.t(obj3, type, null), array2, type, array, array4), out object_4) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
				goto IL_31c0;
			}
		}
		IL_1f1d:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj3 != null)
			{
				try
				{
					gClass4 = gClass4;
					gClass4 = gClass4;
				}
				catch
				{
					Class7 class28 = @class;
					object object_8 = Class5.Default;
					Type type_4 = type;
					Class7 obj29 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_6 = array3;
					Class7 class29 = @class;
					object object_9 = obj3;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)class28.t(object_8, type_4, (CultureInfo)(object)obj29.e(bindingFlags_16, methodBase_6, (Type[])class29.t(object_9, (Type)(object)class30.W(bindingFlags, null, type, array, null), null), array4));
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				Class7 obj31 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj31.t(bindingFlags, null, obj3, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					@class = null;
					continue;
				}
				class17 = class17;
				gClass4 = gClass4;
				class15 = (Class2)(object)Class5.Default;
			}
		}
		gClass4 = gClass4;
		_003CModule_003E = (_003CModule_003E)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)Class5.Default, array4, (CultureInfo)null, (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4), out object_4);
		_ = (Class2)(object)Class5.Default;
		_ = (_003CModule_003E)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class7)((Class7)(object)((Class7)null).e(bindingFlags, array3, array, array4)).t(null, type, null);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					Class7 obj32 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_17 = bindingFlags;
					Class7 obj33 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj34 = (Class7)(object)obj33.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])(object)Class5.Default), array4, (CultureInfo)(object)Class5.Default, array6, out object_4);
					BindingFlags bindingFlags_18 = (BindingFlags)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out object_4);
					bindingFlags = default(BindingFlags);
					_ = (GClass0)((Class7)(object)obj32.t(bindingFlags_17, (FieldInfo[])(object)obj34.t(bindingFlags_18, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo), Class5.Default, cultureInfo), obj3, cultureInfo)).t(obj3, type, cultureInfo);
				}
			}
		}
		catch
		{
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				finally
				{
					class13 = class13;
					goto end_IL_2213;
				}
			}
			try
			{
				class15 = null;
				_ = (Struct2)Class5.Default;
				_ = (Class8)(object)@class.j((BindingFlags)((Class7)null).e(bindingFlags, array3, (Type[])(object)Class5.Default, (ParameterModifier[])null), array3, ref *(object[]*)null, array4, null, array6, out object_4);
			}
			finally
			{
				_ = Class5.Default;
				gClass = gClass;
				goto end_IL_2213;
			}
			end_IL_2213:;
		}
		if (checked(uIntPtr - uIntPtr) == 0)
		{
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj3 != null);
		}
		class6 = class6;
		try
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
					_ = (Class10)(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array4);
					_ = (Class6)(object)((Class7)null).W(bindingFlags, array2, (Type)((Class7)null).t(obj3, type, cultureInfo), (Type[])null, array4);
				}
				finally
				{
					struct2 = struct2;
					goto end_IL_22c3;
				}
			}
			try
			{
				qk = qk;
			}
			catch
			{
				_ = (Class8)(object)Class5.Default;
			}
			end_IL_22c3:;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class13 = null;
			}
		}
		_ = (Class10)(object)Class5.Default;
		Class7 class31 = @class;
		ref object[] object_10 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_4 = (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, null);
		Class7 class32 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)((Class7)(object)class31.j(default(BindingFlags), null, ref object_10, parameterModifier_4, null, (string[])(object)((Class7)(object)class32.W(bindingFlags, array2, type, null, array4)).e(bindingFlags, null, null, array4), out object_4)).t(bindingFlags, array5, obj3, cultureInfo);
		class13 = class13;
		try
		{
			BindingFlags bindingFlags_19 = bindingFlags;
			MethodBase[] methodBase_7 = array3;
			ref object[] object_11 = ref reference;
			CultureInfo cultureInfo_2 = cultureInfo;
			string[] string_ = array6;
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				nuint num2 = unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_19, methodBase_7, ref object_11, (ParameterModifier[])null, cultureInfo_2, string_, out *(object*)class33.e(bindingFlags, null, (Type[])(object)Class5.Default, array4))) - unchecked((nuint)(UIntPtr)Class5.Default);
				Class7 class34 = @class;
				bindingFlags = default(BindingFlags);
				if (unchecked(num2 / (nuint)(UIntPtr)class34.e(bindingFlags, (MethodBase[])@class.t(null, type, (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, array4)) + uIntPtr == 0)
				{
					_ = (GClass0)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array4));
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					class15 = class15;
					_ = (GClass3)(object)Class5.Default;
				}
				catch
				{
					Class7 class35 = @class;
					Class7 class36 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)((Class7)(object)class35.W((BindingFlags)class36.t(bindingFlags, array5, Class5.Default, (CultureInfo)@class.t(Class5.Default, type, cultureInfo)), array2, null, null, null)).t(@class.W(bindingFlags, array2, type, array, (ParameterModifier[])(object)Class5.Default), null, null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
				}
			}
			goto IL_2608;
		}
		IL_4ce9:
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr * (uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default))) == 0)
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			finally
			{
				while (true)
				{
					Class7 class37 = @class;
					Class7 class38 = @class;
					Class7 class39 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
					object object_12 = obj3;
					Class7 class40 = @class;
					BindingFlags bindingFlags_21 = bindingFlags;
					MethodBase[] methodBase_8 = (MethodBase[])(object)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])null);
					Type[] type_5 = array;
					Class7 class41 = @class;
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)(object)class37.j((BindingFlags)class38.t(class39.t(bindingFlags_20, fieldInfo_2, object_12, (CultureInfo)(object)class40.e(bindingFlags_21, methodBase_8, type_5, (ParameterModifier[])(object)class41.e(bindingFlags, null, (Type[])(object)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])@class.t(obj3, type, null), cultureInfo, array6, out *(object*)null), null))), type, cultureInfo), array3, ref reference, array4, null, (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array4), out object_4)).t((BindingFlags)@class.t(obj3, null, cultureInfo), array5, obj3, null) == null)
					{
						break;
					}
					struct2 = struct2;
				}
				goto IL_4e51;
			}
		}
		goto IL_4e51;
		IL_0263:
		_ = (Struct1)((Class7)null).t((object)null, type, cultureInfo);
		Class7 class42 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class42.W(bindingFlags, null, type, null, null) == (UIntPtr)(nuint)0u && (UIntPtr)@class.t(null, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				Class6 obj40 = (Class6)(object)Class5.Default;
				BindingFlags bindingFlags_22 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_9 = array3;
				Class7 class43 = @class;
				Class7 obj41 = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4);
				BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)null).t(default(BindingFlags), array5, (object)null, cultureInfo);
				Class7 class44 = @class;
				bindingFlags = default(BindingFlags);
				object object_13 = class44.j(bindingFlags, null, ref reference, array4, null, null, out *(object*)null);
				Class7 class45 = @class;
				BindingFlags bindingFlags_24 = bindingFlags;
				MethodBase[] methodBase_10 = array3;
				CultureInfo cultureInfo_3 = cultureInfo;
				array6 = array6;
				class17 = (Class6)(object)((Class7)null).j(bindingFlags_22, methodBase_9, ref *(object[]*)class43.e((BindingFlags)obj41.t(bindingFlags_23, fieldInfo_3, object_13, (CultureInfo)(object)class45.j(bindingFlags_24, methodBase_10, ref *(object[]*)null, null, cultureInfo_3, array6, out *(object*)Class5.Default)), array3, array, array4), array4, (CultureInfo)null, array6, out *(object*)null);
				class17 = obj40;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				@class = @class;
				Class4 obj43 = (Class4)(object)Class5.Default;
				class10 = class10;
				class10 = obj43;
			}
		}
		finally
		{
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)obj44.t(bindingFlags, array5, null, cultureInfo))) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
					gClass3 = null;
				}
			}
			else
			{
				do
				{
					class8 = class8;
					class8 = null;
				}
				while (obj3 != null);
			}
			goto IL_0465;
		}
		IL_0d58:
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (Class9)(object)@class.j(bindingFlags, array3, ref reference, array4, null, array6, out object_4);
				continue;
			}
			try
			{
				_ = (Class6)@class.t(obj3, type, null);
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			Class7 obj46;
			do
			{
				_ = (GClass3)@class.t(obj3, (Type)(object)Class5.Default, cultureInfo);
				obj46 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj46.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array5, obj3, (CultureInfo)@class.t(obj3, type, cultureInfo)), (Type)(object)Class5.Default, array, null) != null);
		}
		do
		{
			if ((UIntPtr)@class.t(((Class7)null).t(obj3, type, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		while (obj3 != null);
		if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
		}
		class17 = (Class6)(object)Class5.Default;
		try
		{
			_ = (GClass1)(object)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					qk = qk;
					goto end_IL_0ead;
				}
				end_IL_0ead:;
			}
			finally
			{
				struct2 = default(Struct2);
				@struct = default(Struct1);
				class8 = null;
				_ = (Class2)(object)@class.e(bindingFlags, array3, array, null);
				goto IL_10c6;
			}
		}
		IL_2e3c:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				class13 = null;
			}
			finally
			{
				class15 = class15;
				goto IL_2e63;
			}
		}
		goto IL_2e63;
		IL_2e63:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			finally
			{
				_ = (Class9)(object)Class5.Default;
				goto IL_2eaa;
			}
		}
		class8 = class8;
		@class = @class;
		class15 = null;
		gClass4 = gClass4;
		goto IL_2eaa;
		IL_0465:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					@struct = @struct;
					@struct = @struct;
					@struct = (Struct1)Class5.Default;
					struct2 = default(Struct2);
					_ = (GClass3)(object)((Class7)null).e(bindingFlags, array3, array, array4);
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
			while (obj3 != null);
		}
		gClass2 = gClass2;
		gClass2 = null;
		if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)((Class7)@class.t(obj3, (Type)(object)Class5.Default, null)).t(null, null, null)) + uIntPtr)) == 0)
		{
			class13 = class13;
			class13 = class13;
			_ = (Class2)(object)Class5.Default;
			gClass2 = gClass2;
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		else if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				class26 = (Class10)(object)Class5.Default;
				class26 = class26;
			}
			else
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		else
		{
			do
			{
				_ = (Struct1)Class5.Default;
			}
			while ((object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array4, null, array6, out *(object*)null) != null);
		}
		while (obj3 != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					struct2 = default(Struct2);
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		do
		{
			gClass = gClass;
		}
		while (obj3 != null);
		try
		{
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					class6 = class6;
				}
			}
		}
		if (uIntPtr == 0)
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass1)@class.t(Class5.Default, type, cultureInfo);
			}
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			_ = (Class10)(object)Class5.Default;
		}
		do
		{
			qk = (Qk7)(object)Class5.Default;
		}
		while (obj3 != null);
		gClass3 = null;
		@class = (Class7)(object)Class5.Default;
		Class7 class46 = @class;
		BindingFlags bindingFlags_25 = bindingFlags;
		MethodBase[] methodBase_11 = array3;
		Type[] type_6 = array;
		Class7 class47 = @class;
		Class7 class48 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)((Class7)null).t((BindingFlags)class46.e(bindingFlags_25, methodBase_11, type_6, (ParameterModifier[])class47.t(null, (Type)(object)class48.e(bindingFlags, null, (Type[])(object)Class5.Default, array4), null)), array5, (object)null, (CultureInfo)null);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					_ = (GClass0)(object)Class5.Default;
					_ = (Class4)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo);
					class5 = null;
				}
			}
			else
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				while (obj3 != null);
			}
		}
		else
		{
			do
			{
				if ((UIntPtr)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					Class7 class49 = @class;
					BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_12 = array3;
					Class7 class50 = @class;
					object object_14 = Class5.Default;
					Class7 class51 = @class;
					BindingFlags bindingFlags_27 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_13 = (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, null, ((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, (ParameterModifier[])@class.t(null, type, null), (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array5, obj3, (CultureInfo)(object)Class5.Default), array6, out *(object*)((Class7)null).t((BindingFlags)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo), (FieldInfo[])@class.t(obj3, null, cultureInfo), (object)((Class7)(object)Class5.Default).t(bindingFlags, array5, @class.e(bindingFlags, array3, null, array4), cultureInfo), cultureInfo)), null);
					ParameterModifier[] parameterModifier_5 = array4;
					string[] string_2 = array6;
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					object_4 = ref *(object*)class52.j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, cultureInfo, array6, out *(object*)null);
					_ = (Class5)(object)class49.e(bindingFlags_26, methodBase_12, (Type[])class50.t(object_14, null, (CultureInfo)(object)class51.j(bindingFlags_27, methodBase_13, ref *(object[]*)null, parameterModifier_5, null, string_2, out object_4)), null);
				}
			}
			while (obj3 != null);
		}
		while (true)
		{
			if (obj3 != null)
			{
				while (obj3 != null)
				{
					_ = (GClass0)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
					Class7 class53 = @class;
					Class7 class54 = @class;
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_14 = array3;
					ParameterModifier[] parameterModifier_6 = array4;
					Class7 class55 = @class;
					MethodBase[] methodBase_15 = array3;
					ref object[] object_15 = ref reference;
					Class7 obj50 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class53.W((BindingFlags)((Class7)(object)class54.j(bindingFlags_28, methodBase_14, ref *(object[]*)null, parameterModifier_6, null, (string[])(object)class55.j(default(BindingFlags), methodBase_15, ref object_15, (ParameterModifier[])(object)obj50.t(bindingFlags, (FieldInfo[])(object)@class.e((BindingFlags)Class5.Default, array3, array, (ParameterModifier[])(object)Class5.Default), obj3, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), null, array6, out *(object*)null), out *(object*)null)).t(null, type, cultureInfo), array2, type, array, (ParameterModifier[])(object)@class.e(bindingFlags, null, array, array4));
					class15 = class15;
					class15 = class15;
				}
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		_003CModule_003E = _003CModule_003E;
		try
		{
			class8 = (Class8)(object)Class5.Default;
			class5 = class5;
		}
		catch
		{
			_ = (Class4)(object)Class5.Default;
		}
		try
		{
		}
		finally
		{
			try
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, obj3, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					gClass = (GClass3)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					Class7 class56 = @class;
					BindingFlags bindingFlags_29 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, array4);
					MethodBase[] methodBase_16 = array3;
					ParameterModifier[] parameterModifier_7 = array4;
					CultureInfo cultureInfo_4 = cultureInfo;
					string[] string_3 = (string[])(object)Class5.Default;
					Class7 obj52 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class56.j(bindingFlags_29, methodBase_16, ref *(object[]*)null, parameterModifier_7, cultureInfo_4, string_3, out *(object*)((Class7)null).W((BindingFlags)obj52.t(bindingFlags, array5, obj3, cultureInfo), array2, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default));
				}
				while (obj3 != null);
				goto IL_0c27;
			}
		}
		IL_12e4:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					qk = qk;
					class26 = class26;
					_ = (Class7)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null);
					gClass = (GClass3)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				Class7 class57 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_30 = bindingFlags;
				Class7 class58 = @class;
				Type type_7 = type;
				Class7 class59 = @class;
				BindingFlags bindingFlags_31 = bindingFlags;
				object object_16 = obj3;
				Class7 obj53 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, @class.e(bindingFlags, null, (Type[])(object)@class.W(bindingFlags, null, type, null, null), (ParameterModifier[])(object)Class5.Default), cultureInfo);
				BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
				Class7 obj54 = (Class7)(object)Class5.Default;
				object object_17 = obj3;
				Class7 class60 = @class;
				BindingFlags bindingFlags_33 = (BindingFlags)((Class7)null).j((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array6, out *(object*)null), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out object_4);
				PropertyInfo[] propertyInfo_5 = array2;
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_34 = (BindingFlags)class61.e(bindingFlags, array3, array, array4);
				FieldInfo[] fieldInfo_4 = array5;
				object object_18 = obj3;
				Class7 obj55 = (Class7)((Class7)(object)((Class7)@class.t(obj3, type, cultureInfo)).t((BindingFlags)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, null, null, null, out *(object*)null), (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)(object)((Class7)null).W(bindingFlags, array2, type, array, (ParameterModifier[])null))).t(obj3, (Type)(object)Class5.Default, cultureInfo);
				BindingFlags bindingFlags_35 = bindingFlags;
				Class7 class62 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj56 = (Class7)(object)obj55.j(bindingFlags_35, (MethodBase[])(object)class62.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array4, (CultureInfo)null, array6, out *(object*)@class.e(bindingFlags, null, array, null)), (CultureInfo)(object)Class5.Default), ref *(object[]*)null, array4, null, (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null), (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array3, ref reference, array4, cultureInfo, (string[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array4, cultureInfo, (string[])null, out object_4), out *(object*)null), array6, out *(object*)((Class7)null).e(bindingFlags, array3, array, array4)), out object_4);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class57.W(bindingFlags_30, (PropertyInfo[])class58.t(null, type_7, (CultureInfo)(object)class59.t(bindingFlags_31, null, object_16, (CultureInfo)(object)obj53.W(bindingFlags_32, (PropertyInfo[])obj54.t(object_17, (Type)(object)class60.W(bindingFlags_33, propertyInfo_5, (Type)(object)((Class7)null).t(bindingFlags_34, fieldInfo_4, object_18, (CultureInfo)(object)obj56.W(bindingFlags, array2, type, array, array4)), array, array4), (CultureInfo)(object)Class5.Default), (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), (Type[])(object)@class.e((BindingFlags)Class5.Default, array3, array, array4), array4))), type, null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default)) == (UIntPtr)(nuint)0u)
				{
					qk = qk;
				}
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class8 = (Class8)(object)Class5.Default;
					Class7 obj57 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])((Class7)null).t(obj3, type, (CultureInfo)null), ref *(object[]*)Class5.Default, array4, cultureInfo, array6, out object_4);
					BindingFlags bindingFlags_36 = (BindingFlags)@class.e(default(BindingFlags), (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
					MethodBase[] methodBase_17 = array3;
					Class7 obj58 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)((Class7)null).t((object)null, (Type)(object)obj57.j(bindingFlags_36, methodBase_17, ref *(object[]*)obj58.t(bindingFlags, (FieldInfo[])((Class7)null).t(obj3, (Type)(object)@class.W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), cultureInfo), obj3, cultureInfo), array4, null, array6, out object_4), (CultureInfo)null);
					_ = (Struct2)Class5.Default;
				}
				goto end_IL_133c;
			}
			end_IL_133c:;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class17 = class17;
			}
			catch
			{
				do
				{
					gClass2 = (GClass1)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class6 = Class5.Default;
			_ = (_003CModule_003E)(object)Class5.Default;
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_37 = bindingFlags;
			MethodBase[] methodBase_18 = array3;
			ParameterModifier[] parameterModifier_8 = (ParameterModifier[])((Class7)null).t((object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, array3, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_4), obj3, null), (Type[])(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), null, array, null), null, out *(object*)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(null, (Type)(object)@class.e((BindingFlags)@class.t(((Class7)(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, type, array, (ParameterModifier[])@class.t(obj3, null, cultureInfo))).j((BindingFlags)Class5.Default, array3, ref reference, array4, null, array6, out object_4), (Type)(object)Class5.Default, cultureInfo), array3, array, null), cultureInfo), array4, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null), out object_4)), array4), (Type)null, cultureInfo);
			CultureInfo cultureInfo_5 = cultureInfo;
			Class7 class64 = @class;
			PropertyInfo[] propertyInfo_6 = array2;
			Class7 class65 = @class;
			FieldInfo[] fieldInfo_5 = array5;
			Class7 class66 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class63.j(bindingFlags_37, methodBase_18, ref *(object[]*)null, parameterModifier_8, cultureInfo_5, (string[])(object)class64.W(default(BindingFlags), propertyInfo_6, null, (Type[])(object)class65.t(default(BindingFlags), fieldInfo_5, null, (CultureInfo)(object)class66.j(bindingFlags, null, ref reference, array4, null, array6, out object_4)), array4), out object_4);
			@struct = default(Struct1);
		}
		_ = (Qk7)((Class7)null).t((object)null, type, cultureInfo);
		try
		{
			try
			{
				class13 = class13;
				Class7 class67 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class67.W(bindingFlags, array2, (Type)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, (CultureInfo)null), null, null);
				_ = (Class9)(object)@class.e(bindingFlags, null, array, array4);
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			class17 = (Class6)((Class7)null).t((object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, null, null, null, null), obj3, (CultureInfo)null), (Type)null, cultureInfo);
			_ = (Class8)(object)Class5.Default;
			_ = (Class0)(object)Class5.Default;
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			Class7 class68 = @class;
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 class69 = @class;
			MethodBase[] methodBase_19 = array3;
			Class7 class70 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_39 = bindingFlags;
			BindingFlags bindingFlags_40 = bindingFlags;
			Class7 obj63 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array4);
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class68.W(bindingFlags_38, null, (Type)(object)class69.e(default(BindingFlags), methodBase_19, (Type[])((Class7)null).t((object)class70.j(bindingFlags_39, (MethodBase[])(object)((Class7)null).e(bindingFlags_40, (MethodBase[])(object)obj63.j(bindingFlags, null, ref *(object[]*)@class.t((BindingFlags)Class5.Default, array5, obj3, null), (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array4), cultureInfo, (string[])@class.t(obj3, (Type)(object)Class5.Default, cultureInfo), out object_4), (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default)), ref *(object[]*)Class5.Default, array4, (CultureInfo)@class.t(obj3, type, cultureInfo), null, out *(object*)((Class7)(object)@class.e(bindingFlags, array3, array, null)).W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])((Class7)(object)Class5.Default).t(obj3, type, null), array4)), type, cultureInfo), null), array, array4);
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)((Class7)null).e(bindingFlags, array3, array, array4);
			qk = qk;
		}
		else
		{
			if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default != 0)
			{
				try
				{
					class5 = (Class9)(object)Class5.Default;
				}
				finally
				{
					class26 = class26;
					class15 = null;
					goto IL_1f1d;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
			}
			else
			{
				_ = (Class10)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)@class.W(bindingFlags, array2, type, null, array4)).t(bindingFlags, array5, obj3, cultureInfo), ref reference, array4, (CultureInfo)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, null, null, array6, out object_4), array6, out *(object*)null);
			}
		}
		goto IL_1f1d;
		IL_4a7f:
		if ((nuint)(UIntPtr)((Class7)null).t(obj3, (Type)null, cultureInfo) / uIntPtr == 0)
		{
			Class7 obj64;
			BindingFlags bindingFlags_41;
			MethodBase[] methodBase_20;
			Class7 obj65;
			do
			{
				gClass = gClass;
				obj64 = (Class7)(object)@class.W((BindingFlags)Class5.Default, array2, type, array, array4);
				bindingFlags_41 = bindingFlags;
				methodBase_20 = array3;
				obj65 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj64.j(bindingFlags_41, methodBase_20, ref *(object[]*)null, (ParameterModifier[])(object)obj65.W(bindingFlags, (PropertyInfo[])(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)null).W((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])(object)Class5.Default), array2, type, (Type[])null, array4), out *(object*)null), type, (Type[])(object)Class5.Default, array4), (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array4)), out *(object*)null) != null);
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_42 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null);
				Type type_8 = type;
				Class7 class72 = @class;
				bindingFlags = default(BindingFlags);
				class10 = (Class4)(object)class71.W(bindingFlags_42, propertyInfo_7, type_8, null, (ParameterModifier[])(object)class72.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_4));
			}
			else
			{
				gClass = null;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (GClass3)((Class7)(object)Class5.Default).t(obj3, (Type)(object)Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (GClass3)(object)@class.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array4);
					goto end_IL_4c6f;
				}
				end_IL_4c6f:;
			}
			catch
			{
				_ = (_003CModule_003E)@class.t(Class5.Default, null, cultureInfo);
			}
			goto IL_4ce9;
		}
		IL_31c0:
		gClass4 = null;
		class15 = null;
		class15 = null;
		gClass2 = (GClass1)(object)@class.e((BindingFlags)Class5.Default, array3, array, array4);
		Class7 class73;
		checked
		{
			while ((object)Class5.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
				{
					while (obj3 != null)
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
			}
			gClass = gClass;
			bindingFlags = default(BindingFlags);
			_ = (Class8)(object)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)(object)@class.t(bindingFlags, array5, obj3, cultureInfo));
			class73 = @class;
			bindingFlags = default(BindingFlags);
		}
		_ = (Struct2)class73.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])((Class7)null).t((object)null, type, cultureInfo), out object_4);
		_ = (Class0)(object)Class5.Default;
		try
		{
			try
			{
				@struct = @struct;
			}
			catch
			{
				gClass3 = null;
			}
			finally
			{
				gClass4 = (GClass0)(object)Class5.Default;
				goto end_IL_32cc;
			}
			end_IL_32cc:;
		}
		catch
		{
			_003CModule_003E = null;
		}
		_ = (Qk7)(object)@class.j(bindingFlags, array3, ref reference, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)@class.W(bindingFlags, null, type, null, array4), (MethodBase[])null, array, array4), cultureInfo, array6, out object_4);
		try
		{
			try
			{
				Class7 class74 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)(object)class74.j(bindingFlags, array3, ref reference, null, cultureInfo, (string[])(object)@class.t(bindingFlags, array5, obj3, cultureInfo), out *(object*)Class5.Default)).t(obj3, type, cultureInfo);
			}
			finally
			{
				Class7 class75 = @class;
				BindingFlags bindingFlags_43 = bindingFlags;
				Class7 class76 = @class;
				BindingFlags bindingFlags_44 = bindingFlags;
				BindingFlags bindingFlags_45 = (BindingFlags)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default);
				Class7 class77 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj69 = (Class7)(object)class76.W(bindingFlags_44, (PropertyInfo[])(object)((Class7)null).e(bindingFlags_45, (MethodBase[])null, (Type[])(object)class77.t(bindingFlags, array5, obj3, (CultureInfo)(object)Class5.Default), array4), (Type)(object)Class5.Default, array, array4);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)class75.t(bindingFlags_43, null, obj69.j(bindingFlags, array3, ref *(object[]*)null, array4, cultureInfo, array6, out object_4), cultureInfo)).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)null).t(obj3, (Type)@class.t(obj3, type, cultureInfo), cultureInfo), null, array6, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, cultureInfo)) == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)@class.t((BindingFlags)@class.j(bindingFlags, array3, ref *(object[]*)@class.j(bindingFlags, array3, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array6, out object_4), (ParameterModifier[])(object)Class5.Default, null, array6, out object_4), array5, obj3, cultureInfo);
					_ = (GClass2)(object)Class5.Default;
					gClass4 = gClass4;
					Class7 obj70 = (Class7)((Class7)null).t(obj3, type, (CultureInfo)null);
					BindingFlags bindingFlags_46 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)@class.j(bindingFlags, array3, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null);
					Type type_9 = type;
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj70.W(bindingFlags_46, propertyInfo_8, type_9, (Type[])(object)class78.t(bindingFlags, array5, obj3, (CultureInfo)(object)@class.t(bindingFlags, array5, null, cultureInfo)), array4);
				}
				goto end_IL_3353;
			}
			end_IL_3353:;
		}
		catch
		{
			try
			{
				try
				{
					class17 = class17;
				}
				finally
				{
					_ = (Class6)(object)@class.W(bindingFlags, array2, null, array, (ParameterModifier[])@class.t(obj3, type, cultureInfo));
					goto end_IL_3615;
				}
				end_IL_3615:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					class13 = class13;
				}
				else
				{
					gClass2 = gClass2;
				}
				goto end_IL_3614;
			}
			end_IL_3614:;
		}
		gClass2 = (GClass1)(object)Class5.Default;
		while (true)
		{
			if (obj3 != null)
			{
				if (uIntPtr == 0)
				{
					Class7 class79 = @class;
					BindingFlags bindingFlags_47 = bindingFlags;
					MethodBase[] methodBase_21 = array3;
					Type[] type_10 = array;
					BindingFlags bindingFlags_48 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					Class7 obj72 = (Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array4);
					BindingFlags bindingFlags_49 = bindingFlags;
					FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref reference, null, null, null, out *(object*)null));
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass0)(object)((Class7)(object)class79.e(bindingFlags_47, methodBase_21, type_10, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_48, fieldInfo_6, (object)obj72.t(bindingFlags_49, fieldInfo_7, class80.W(bindingFlags, array2, type, array, array4), cultureInfo), (CultureInfo)(object)Class5.Default))).e((BindingFlags)Class5.Default, null, array, array4);
				}
			}
			else if (obj3 == null)
			{
				break;
			}
		}
		_ = (Class10)(object)Class5.Default;
		try
		{
			if ((UIntPtr)@class.t(Class5.Default, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class26 = (Class10)(object)Class5.Default;
				}
				finally
				{
					gClass2 = (GClass1)(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo);
					goto end_IL_37ac;
				}
			}
			_ = (Class7)(object)Class5.Default;
			end_IL_37ac:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					class26 = (Class10)(object)Class5.Default;
				}
			}
			goto IL_3881;
		}
		IL_0c27:
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class26 = class26;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class81.W(bindingFlags, array2, type, array, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, Class5.Default, cultureInfo));
					_ = (GClass3)@class.t(obj3, type, cultureInfo);
				}
			}
			finally
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(obj3, null, cultureInfo)) - uIntPtr == 0)
					{
						class13 = class13;
					}
				}
				while (obj3 != null);
				goto IL_0d58;
			}
		}
		IL_3881:
		while (obj3 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)Class5.Default);
			}
			else
			{
				@class = @class;
			}
		}
		Class7 class82 = @class;
		Class7 class83 = @class;
		Class7 obj73 = (Class7)@class.t(obj3, null, cultureInfo);
		Class7 class84 = @class;
		Class7 class85 = @class;
		Class7 obj74 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_50 = (BindingFlags)((Class7)(object)class83.e((BindingFlags)obj73.W((BindingFlags)class84.t(class85.j((BindingFlags)obj74.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default), array3, ref *(object[]*)null, array4, cultureInfo, null, out *(object*)Class5.Default), type, cultureInfo), array2, type, (Type[])(object)Class5.Default, array4), array3, array, (ParameterModifier[])(object)Class5.Default)).t(obj3, type, cultureInfo);
		MethodBase[] methodBase_22 = array3;
		ref object[] object_19 = ref reference;
		ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array5, obj3, (CultureInfo)(object)@class.W(bindingFlags, null, type, array, null));
		CultureInfo cultureInfo_6 = cultureInfo;
		Class7 class86 = @class;
		BindingFlags bindingFlags_51 = (BindingFlags)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, array4, (CultureInfo)null, array6, out object_4);
		MethodBase[] methodBase_23 = array3;
		Class7 class87 = @class;
		bindingFlags = default(BindingFlags);
		if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)class82.j(bindingFlags_50, methodBase_22, ref object_19, parameterModifier_9, cultureInfo_6, (string[])(object)((Class7)null).j((BindingFlags)class86.j(bindingFlags_51, methodBase_23, ref *(object[]*)class87.t((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(null, null, cultureInfo), obj3, (CultureInfo)((Class7)null).t(obj3, type, cultureInfo)), (FieldInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, null), obj3, cultureInfo), array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array6, out object_4), out *(object*)null))) == 0)
		{
			try
			{
				try
				{
					gClass2 = gClass2;
					struct2 = struct2;
					struct2 = (Struct2)Class5.Default;
					class10 = class10;
				}
				catch
				{
					class6 = (Class5)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
					Class7 class88 = @class;
					BindingFlags bindingFlags_52 = (BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, (Type[])(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj3, cultureInfo));
					ref object[] object_20 = ref reference;
					Class7 class89 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)(object)class88.j(bindingFlags_52, null, ref object_20, (ParameterModifier[])(object)class89.j(bindingFlags, array3, ref *(object[]*)null, array4, cultureInfo, null, out object_4), (CultureInfo)(object)Class5.Default, array6, out *(object*)null)).t(bindingFlags, array5, ((Class7)null).t((object)Class5.Default, type, cultureInfo), cultureInfo);
				}
			}
			catch
			{
				try
				{
					qk = qk;
				}
				catch
				{
					struct2 = default(Struct2);
				}
			}
		}
		else
		{
			_ = (Struct1)Class5.Default;
			gClass = null;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				class5 = class5;
			}
			else
			{
				class10 = class10;
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				while (obj3 != null)
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					finally
					{
						_ = (Struct2)Class5.Default;
						continue;
					}
				}
			}
			else
			{
				_ = (GClass0)(object)Class5.Default;
			}
			if (unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array2, type, array, array4)) * unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, array3, array, array4)) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						class6 = null;
					}
					catch
					{
						_ = (GClass2)(object)Class5.Default;
					}
				}
			}
			else
			{
				class5 = null;
			}
		}
		if (uIntPtr == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			qk = null;
			Class7 obj79 = (Class7)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo);
			BindingFlags bindingFlags_53 = bindingFlags;
			Class7 class90 = @class;
			BindingFlags bindingFlags_54 = bindingFlags;
			Class7 class91 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)obj79.t(bindingFlags_53, (FieldInfo[])(object)class90.W(bindingFlags_54, (PropertyInfo[])(object)class91.t(bindingFlags, array5, Class5.Default, null), type, array, array4), obj3, cultureInfo);
			_ = (Class0)(object)Class5.Default;
			_ = (GClass1)(object)Class5.Default;
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				qk = null;
			}
			catch
			{
				try
				{
					class8 = class8;
				}
				catch
				{
					class5 = (Class9)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array2, (Type)(object)Class5.Default, null, array4), array, array4);
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			while ((object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array4, cultureInfo, array6, out *(object*)null) != null)
			{
				do
				{
					gClass2 = gClass2;
				}
				while ((object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array4, cultureInfo, null, out object_4) != null);
			}
		}
		_ = (Class10)(object)Class5.Default;
		class8 = class8;
		_ = (Struct1)Class5.Default;
		do
		{
			if (uIntPtr == 0)
			{
				while ((object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo) != null)
				{
					@struct = (Struct1)@class.t(obj3, null, cultureInfo);
				}
			}
		}
		while ((object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j(bindingFlags, array3, ref reference, array4, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array4), null, out object_4), ref *(object[]*)@class.e((BindingFlags)@class.t(bindingFlags, array5, obj3, cultureInfo), array3, (Type[])(object)Class5.Default, null), array4, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), (string[])(object)Class5.Default, out *(object*)Class5.Default) != null);
		while (obj3 != null)
		{
			try
			{
				class17 = class17;
				gClass4 = gClass4;
				class17 = null;
				class26 = null;
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				continue;
			}
		}
		Class7 obj82 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array3, ref reference, null, cultureInfo, array6, out object_4);
		Type type_11 = type;
		Class7 class92 = @class;
		BindingFlags bindingFlags_55 = (BindingFlags)@class.e(bindingFlags, array3, (Type[])(object)Class5.Default, array4);
		MethodBase[] methodBase_24 = array3;
		bindingFlags = default(BindingFlags);
		ref object[] object_21 = ref *(object[]*)((Class7)null).W(bindingFlags, array2, (Type)null, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, null));
		ParameterModifier[] parameterModifier_10 = array4;
		Class7 class93 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class4)obj82.t(null, type_11, (CultureInfo)(object)class92.j(bindingFlags_55, methodBase_24, ref object_21, parameterModifier_10, (CultureInfo)(object)class93.t(bindingFlags, array5, null, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array4, cultureInfo, (string[])null, out *(object*)null)), null, out *(object*)null));
		_ = (Class5)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, array4), cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.t(null, (Type)(object)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])null), (CultureInfo)((Class7)(object)@class.j(default(BindingFlags), array3, ref *(object[]*)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(null, type, null), null, null), array4, cultureInfo, array6, out *(object*)null)).t(null, null, null)));
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, array4), ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)Class5.Default, out object_4);
		_ = (GClass1)(object)@class.t(bindingFlags, null, obj3, cultureInfo);
		checked
		{
			do
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) != 0)
				{
					class17 = class17;
					continue;
				}
				_ = (Struct1)Class5.Default;
				gClass = (GClass3)(object)Class5.Default;
			}
			while (obj3 != null || obj3 != null);
			while (obj3 != null)
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
					{
						_ = (Class6)(object)Class5.Default;
						continue;
					}
					gClass2 = gClass2;
					_ = (Class0)(object)Class5.Default;
					gClass2 = null;
					class10 = null;
				}
				else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			uIntPtr = default(UIntPtr);
		}
		if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
		{
			gClass3 = gClass3;
		}
		try
		{
			while (obj3 != null)
			{
				gClass = null;
			}
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, (CultureInfo)(object)Class5.Default);
				}
			}
			catch
			{
			}
			goto IL_4407;
		}
		IL_4407:
		Class7 class94 = @class;
		BindingFlags bindingFlags_56 = (BindingFlags)((Class7)null).e(bindingFlags, array3, array, array4);
		MethodBase[] methodBase_25 = (MethodBase[])(object)((Class7)null).j(default(BindingFlags), array3, ref reference, array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_4);
		Type[] type_12 = array;
		Class7 class95 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class94.e(bindingFlags_56, methodBase_25, type_12, (ParameterModifier[])(object)class95.t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), array, array4), null, cultureInfo)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			catch
			{
				do
				{
					_ = (GClass3)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default), @class.t(null, null, null), cultureInfo);
				}
				while ((object)Class5.Default != null);
			}
		}
		do
		{
			_ = (Class4)(object)Class5.Default;
		}
		while (obj3 != null);
		_ = (Class9)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num3 - uIntPtr) == 0)
				{
					gClass = gClass;
				}
				else
				{
					gClass2 = gClass2;
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
				continue;
			}
		}
		class6 = class6;
		_ = (Class10)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array6, out *(object*)null);
		if (uIntPtr == 0)
		{
			try
			{
				class10 = class10;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class8 = null;
				}
			}
		}
		if (uIntPtr == 0)
		{
			Class7 class96 = @class;
			bindingFlags = default(BindingFlags);
			_003CModule_003E = (_003CModule_003E)(object)class96.e(bindingFlags, array3, array, array4);
		}
		else
		{
			class5 = (Class9)(object)Class5.Default;
		}
		while (obj3 != null)
		{
			_ = (GClass2)(object)@class.e((BindingFlags)Class5.Default, array3, (Type[])(object)Class5.Default, null);
			class13 = class13;
		}
		if (uIntPtr == 0)
		{
			nuint num4;
			checked
			{
				num4 = unchecked((nuint)(UIntPtr)((Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)null)).t(obj3, type, cultureInfo)) - unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
			}
			if (num4 / uIntPtr == 0)
			{
				do
				{
					Class7 class97 = @class;
					Class7 class98 = @class;
					BindingFlags bindingFlags_57 = bindingFlags;
					MethodBase[] methodBase_26 = array3;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class97.e((BindingFlags)class98.e(bindingFlags_57, methodBase_26, (Type[])(object)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array3, null, array4)), null), null, array, array4);
					_ = (Qk7)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		else
		{
			try
			{
				while (obj3 != null)
				{
					Class7 class99 = @class;
					BindingFlags bindingFlags_58 = bindingFlags;
					BindingFlags bindingFlags_59 = bindingFlags;
					MethodBase[] methodBase_27 = array3;
					object object_22 = obj3;
					Type type_13 = type;
					Class7 obj86 = (Class7)@class.t(obj3, type, cultureInfo);
					BindingFlags bindingFlags_60 = bindingFlags;
					Class7 class100 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_61 = (BindingFlags)((Class7)null).t(object_22, type_13, (CultureInfo)(object)obj86.t(bindingFlags_60, (FieldInfo[])(object)((Class7)(object)((Class7)(object)class100.j((BindingFlags)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])null), array3, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).e(bindingFlags, array3, array, array4), array3, array, null), cultureInfo))).W(bindingFlags, array2, type, array, array4)).t(bindingFlags, null, obj3, cultureInfo), obj3, cultureInfo));
					Class7 obj87 = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj3, cultureInfo), array2, type, array, array4), null, cultureInfo, array6, out *(object*)null);
					BindingFlags bindingFlags_62 = (BindingFlags)((Class7)null).e(bindingFlags, array3, (Type[])null, array4);
					Class7 class101 = @class;
					bindingFlags = default(BindingFlags);
					class6 = (Class5)(object)class99.t(bindingFlags_58, null, ((Class7)null).e(bindingFlags_59, methodBase_27, (Type[])(object)((Class7)null).j(bindingFlags_61, (MethodBase[])(object)obj87.W(bindingFlags_62, null, (Type)(object)class101.t(bindingFlags, null, Class5.Default, null), null, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)null, array4, (CultureInfo)null, (string[])null, out object_4), (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, array5, obj3, cultureInfo), array, null), (CultureInfo)null, (string[])null, out object_4)), (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, null));
				}
			}
			catch
			{
				class26 = (Class10)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.j((BindingFlags)Class5.Default, array3, ref reference, null, null, array6, out object_4), array4);
			}
		}
		try
		{
		}
		finally
		{
			if (uIntPtr == 0)
			{
			}
			goto IL_4a7f;
		}
	}
}
