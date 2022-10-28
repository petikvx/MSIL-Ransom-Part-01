using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using A_0024r;
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

namespace ns9;

public class GClass3
{
	internal static byte[] smethod_0(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}

	unsafe static void smethod_1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			_ = (Struct1)Class5.Default;
		}
		catch
		{
			_ = (Class9)(object)Class5.Default;
		}
		finally
		{
			num = (UIntPtr)Class5.Default;
			if (num == 0)
			{
				_ = (Class4)(object)Class5.Default;
			}
			else
			{
				Class7 class2;
				BindingFlags bindingFlags_4;
				CultureInfo cultureInfo_;
				string[] string_;
				Class7 obj4;
				Class7 class4;
				BindingFlags bindingFlags_5;
				Type[] type_;
				Class7 obj5;
				BindingFlags bindingFlags_6;
				MethodBase[] methodBase_;
				ParameterModifier[] parameterModifier_;
				CultureInfo cultureInfo_2;
				string[] string_2;
				do
				{
					bindingFlags = (BindingFlags)Class5.Default;
					BindingFlags bindingFlags_ = bindingFlags;
					BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_ = array;
					obj2 = obj2;
					object object_ = obj2;
					cultureInfo = null;
					array = (FieldInfo[])(object)((Class7)null).t(bindingFlags_2, fieldInfo_, object_, cultureInfo);
					_ = (Class7)(object)((Class7)null).t(bindingFlags_, array, (object)null, (CultureInfo)null);
					GClass2 obj3 = (GClass2)(object)Class5.Default;
					gClass = gClass;
					gClass = obj3;
					@class = @class;
					class2 = @class;
					Class7 class3 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					type = type;
					bindingFlags_4 = (BindingFlags)class3.W(bindingFlags_3, null, type, (Type[])(object)Class5.Default, null);
					cultureInfo_ = cultureInfo;
					array2 = null;
					string_ = array2;
					obj4 = (Class7)(object)Class5.Default;
					class4 = @class;
					bindingFlags_5 = (BindingFlags)@class.t(obj2, type, null);
					array3 = (Type[])(object)Class5.Default;
					type_ = array3;
					obj5 = (Class7)(object)Class5.Default;
					bindingFlags_6 = bindingFlags;
					Class7 class5 = @class;
					BindingFlags bindingFlags_7 = bindingFlags;
					FieldInfo[] fieldInfo_2 = array;
					Class7 class6 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = (BindingFlags)((Class7)null).t(bindingFlags_7, fieldInfo_2, (object)((Class7)(object)class6.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), cultureInfo);
					PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
					Type type_2 = type;
					Type[] type_3 = (Type[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)Class5.Default);
					array4 = (ParameterModifier[])(object)Class5.Default;
					methodBase_ = (MethodBase[])(object)class5.W(bindingFlags_8, propertyInfo_, type_2, type_3, array4);
					parameterModifier_ = array4;
					cultureInfo_2 = cultureInfo;
					string_2 = array2;
					reference = ref reference;
				}
				while ((object)class2.j(bindingFlags_4, null, ref *(object[]*)null, null, cultureInfo_, string_, out *(object*)obj4.t((BindingFlags)class4.e(bindingFlags_5, null, type_, (ParameterModifier[])(object)obj5.j(bindingFlags_6, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_2, string_2, out reference)), null, null, null)) != null);
			}
			goto IL_0248;
		}
		IL_0248:
		Class10 class7 = class7;
		class7 = class7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class9);
		if (num == 0)
		{
			do
			{
				Class7 class8 = @class;
				bindingFlags = default(BindingFlags);
				Class5 obj6 = (Class5)(object)class8.e(bindingFlags, null, array3, null);
				class9 = class9;
				class9 = obj6;
			}
			while ((object)@class.e(bindingFlags, null, array3, array4) != null);
		}
		_ = (Class10)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class10);
		if (num == 0)
		{
			do
			{
				try
				{
					gClass = null;
				}
				finally
				{
					qk = qk;
					qk = qk;
					_ = (Class4)(object)@class.W(bindingFlags, null, null, array3, array4);
					class7 = class7;
					class10 = class10;
					class10 = class10;
					continue;
				}
			}
			while ((object)@class.e(bindingFlags, null, array3, array4) != null);
			goto IL_0477;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class11);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class11 = class11;
				class11 = null;
				_ = (GClass2)(object)Class5.Default;
			}
		}
		finally
		{
			try
			{
				BindingFlags bindingFlags_9 = bindingFlags;
				array5 = null;
				MethodBase[] methodBase_2 = array5;
				reference2 = ref reference2;
				ref object[] object_2 = ref reference2;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
				string[] string_3 = (string[])(object)Class5.Default;
				Class7 obj7 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = (BindingFlags)((Class7)null).j(bindingFlags_9, methodBase_2, ref object_2, parameterModifier_2, (CultureInfo)null, string_3, out *(object*)obj7.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default));
				MethodBase[] methodBase_3 = (MethodBase[])(object)@class.t(bindingFlags, null, null, null);
				Class7 class12 = @class;
				BindingFlags bindingFlags_11 = bindingFlags;
				Class7 class13 = @class;
				Type type_4 = type;
				bindingFlags = default(BindingFlags);
				ref object[] object_3 = ref *(object[]*)class12.W(bindingFlags_11, (PropertyInfo[])class13.t(null, type_4, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo)), (Type)(object)Class5.Default, array3, null);
				CultureInfo cultureInfo_3 = cultureInfo;
				Class7 class14 = @class;
				BindingFlags bindingFlags_12 = bindingFlags;
				array6 = array6;
				qk = (Qk7)(object)((Class7)null).j(bindingFlags_10, methodBase_3, ref object_3, (ParameterModifier[])null, cultureInfo_3, (string[])(object)class14.W(bindingFlags_12, array6, null, array3, null), out *(object*)null);
			}
			finally
			{
				class7 = null;
				goto IL_0477;
			}
		}
		IL_2d6a:
		qk = (Qk7)(object)Class5.Default;
		if (num == 0)
		{
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
		}
		else if ((UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				_ = (Struct2)Class5.Default;
			}
			else
			{
				class11 = (Class9)(object)Class5.Default;
			}
		}
		else if ((UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, array3, null) == (UIntPtr)(nuint)0u)
		{
			Class7 class15 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_13 = (BindingFlags)((Class7)null).t(bindingFlags, array, (object)null, (CultureInfo)null);
			PropertyInfo[] propertyInfo_2 = array6;
			Type type_5 = type;
			Type[] type_6 = (Type[])(object)Class5.Default;
			Class7 class16 = @class;
			BindingFlags bindingFlags_14 = (BindingFlags)@class.j((BindingFlags)Class5.Default, array5, ref reference2, null, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).t((object)null, type, (CultureInfo)null));
			FieldInfo[] fieldInfo_3 = array;
			object object_4 = obj2;
			Class7 class17 = @class;
			BindingFlags bindingFlags_15 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class15.W(bindingFlags_13, propertyInfo_2, type_5, type_6, (ParameterModifier[])(object)class16.t(bindingFlags_14, fieldInfo_3, object_4, (CultureInfo)(object)class17.j(bindingFlags_15, (MethodBase[])(object)((Class7)null).e(bindingFlags, array5, array3, array4), ref reference2, array4, (CultureInfo)(object)@class.t(bindingFlags, null, obj2, null), null, out *(object*)@class.t(null, type, cultureInfo))));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class18);
		if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null) == (UIntPtr)(nuint)0u)
		{
			class18 = (Class0)(object)@class.W(bindingFlags, array6, type, array3, array4);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		try
		{
			if ((UIntPtr)@class.e((BindingFlags)Class5.Default, array5, array3, array4) == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass2 = (GClass3)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			else if (num / num == 0)
			{
				class19 = (Class6)(object)Class5.Default;
			}
			else
			{
				_ = Class5.Default;
			}
		}
		catch
		{
			nuint num2 = num;
			num = default(UIntPtr);
			if (checked(num2 * num) == 0)
			{
				try
				{
					Class7 class20 = @class;
					object object_5 = obj2;
					Type type_7 = type;
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)class20.t(object_5, type_7, (CultureInfo)(object)class21.W(bindingFlags, array6, type, array3, null));
				}
				catch
				{
					_ = (_003CModule_003E)(object)((Class7)(object)((Class7)null).j(bindingFlags, array5, ref reference2, array4, cultureInfo, array2, out reference)).t((BindingFlags)Class5.Default, array, null, null);
				}
			}
		}
		qk = qk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		while (obj2 != null)
		{
			try
			{
				gClass2 = null;
			}
			finally
			{
				if (num == 0)
				{
					gClass = (GClass2)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)((Class7)null).W(bindingFlags, array6, (Type)null, (Type[])null, (ParameterModifier[])null);
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		catch
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array6, null, array3, null);
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					gClass3 = null;
					goto end_IL_3125;
				}
				catch
				{
					_ = (Class9)(object)Class5.Default;
					goto end_IL_3125;
				}
				end_IL_3125:;
			}
		}
		try
		{
			try
			{
				qk = qk;
			}
			finally
			{
				gClass3 = gClass3;
				goto end_IL_3140;
			}
			end_IL_3140:;
		}
		finally
		{
			if (num == 0)
			{
				_ = (GClass2)(object)Class5.Default;
			}
			else
			{
				try
				{
					class18 = class18;
				}
				catch
				{
					_ = (Struct1)@class.j(bindingFlags, array5, ref reference2, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
				}
			}
			goto IL_3274;
		}
		IL_18a9:
		while (obj2 != null)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)@class.W(bindingFlags, null, null, array3, array4);
				}
			}
			finally
			{
				gClass3 = gClass3;
				continue;
			}
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				class9 = null;
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		if (num == 0)
		{
			try
			{
				do
				{
					class18 = class18;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					Class7 obj14 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_4 = array5;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj14.j(bindingFlags_16, methodBase_4, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), null, cultureInfo, null, out reference);
					goto IL_193e;
				}
			}
		}
		goto IL_193e;
		IL_2a9a:
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				_ = (Class0)(object)@class.e((BindingFlags)Class5.Default, array5, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), array4);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		while (true)
		{
			if (obj2 != null)
			{
				UIntPtr num3 = (UIntPtr)((Class7)null).t((BindingFlags)((Class7)null).e(bindingFlags, array5, (Type[])null, array4), array, (object)@class.t(bindingFlags, null, Class5.Default, cultureInfo), cultureInfo);
				num = default(UIntPtr);
				if ((nuint)num3 / num == 0)
				{
					struct2 = (Struct1)@class.j(bindingFlags, array5, ref reference2, array4, cultureInfo, null, out *(object*)@class.e(bindingFlags, array5, null, array4));
				}
			}
			else if (((Class7)null).t(obj2, type, cultureInfo) == null)
			{
				break;
			}
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		do
		{
			if (num == 0)
			{
				UIntPtr num4 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				checked
				{
					qk = ((unchecked((nuint)num4) - num + num != 0) ? null : qk);
				}
			}
		}
		while ((object)Class5.Default != null);
		if ((UIntPtr)@class.j(bindingFlags, array5, ref *(object[]*)null, null, (CultureInfo)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array4), (string[])(object)Class5.Default, out reference) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					class18 = (Class0)(object)((Class7)@class.t(obj2, type, cultureInfo)).t(bindingFlags, array, obj2, cultureInfo);
				}
			}
			finally
			{
				if (num == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo);
				}
				else
				{
					class19 = null;
				}
				goto IL_2c88;
			}
		}
		do
		{
			class10 = null;
		}
		while (obj2 != null);
		goto IL_2c88;
		IL_2c88:
		_ = (Struct2)@class.t(obj2, type, cultureInfo);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				class7 = (Class10)(object)Class5.Default;
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				if (num == 0)
				{
					class18 = class18;
				}
				else
				{
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class22.e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)@class.e(bindingFlags, null, array3, (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo)), array5, null, (ParameterModifier[])(object)Class5.Default), null, (ParameterModifier[])(object)@class.e(bindingFlags, null, array3, null));
				}
				goto IL_2d6a;
			}
		}
		goto IL_2d6a;
		IL_2215:
		_ = (Class9)(object)Class5.Default;
		if ((UIntPtr)@class.e(bindingFlags, array5, array3, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			Class7 class23 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class23.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null);
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			gClass = (GClass2)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class24);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Qk7)(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo);
				}
				while ((object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, (ParameterModifier[])null) != null);
			}
			finally
			{
				while (obj2 != null)
				{
					class24 = class24;
				}
				goto IL_22de;
			}
		}
		goto IL_22de;
		IL_0477:
		while (obj2 != null)
		{
			_ = (Struct2)Class5.Default;
		}
		Class7 class25 = @class;
		Class7 class26 = @class;
		Class7 class27 = @class;
		BindingFlags bindingFlags_17 = bindingFlags;
		MethodBase[] methodBase_5 = array5;
		Type[] type_8 = array3;
		Class7 obj16 = (Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo);
		BindingFlags bindingFlags_18 = bindingFlags;
		Class7 class28 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class25.j((BindingFlags)class26.t(class27.e(bindingFlags_17, methodBase_5, type_8, (ParameterModifier[])(object)obj16.t(bindingFlags_18, (FieldInfo[])(object)class28.t(bindingFlags, null, null, cultureInfo), obj2, cultureInfo)), type, cultureInfo), null, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)@class.W(bindingFlags, array6, type, (Type[])(object)Class5.Default, null), array2, out *(object*)null);
		class10 = class10;
		try
		{
			_ = (GClass1)(object)@class.W((BindingFlags)Class5.Default, array6, (Type)((Class7)(object)Class5.Default).t(obj2, (Type)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, null, (Type[])((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)Class5.Default), array4), cultureInfo), null, array4);
		}
		finally
		{
			if (checked(num - unchecked((nuint)default(UIntPtr))) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
					gClass3 = null;
				}
			}
			else
			{
				_ = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4), (FieldInfo[])(object)Class5.Default, obj2, null), type, (Type[])@class.t(Class5.Default, type, null), array4);
				class18 = null;
				class18 = null;
				_ = (Class2)(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)null, (CultureInfo)null)).t(bindingFlags, (FieldInfo[])@class.t(null, type, null), obj2, null);
			}
			goto IL_06dd;
		}
		IL_348e:
		do
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				class19 = class19;
				continue;
			}
			_ = (Class4)(object)((Class7)@class.t(obj2, type, cultureInfo)).W((BindingFlags)Class5.Default, array6, type, array3, null);
			bindingFlags = default(BindingFlags);
			class19 = (Class6)(object)((Class7)null).t(bindingFlags, array, (object)null, (CultureInfo)null);
		}
		while (obj2 != null || obj2 != null);
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					_ = Class5.Default;
				}
			}
			else if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)((Class7)null).e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, array4);
			}
			else
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					class18 = class18;
				}
				else
				{
					_ = (Class10)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])@class.t(obj2, type, (CultureInfo)(object)Class5.Default), array3, (ParameterModifier[])(object)Class5.Default);
				}
			}
			finally
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				catch
				{
					class18 = class18;
				}
				goto end_IL_34fe;
			}
			end_IL_34fe:;
		}
		try
		{
			do
			{
				try
				{
					@class = null;
				}
				finally
				{
					class11 = class11;
					continue;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					_ = (GClass3)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo)).t((BindingFlags)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out reference), array, Class5.Default, cultureInfo);
					gClass = gClass;
					class10 = null;
				}
				finally
				{
					_ = (Qk7)(object)@class.W(bindingFlags, array6, null, array3, (ParameterModifier[])(object)Class5.Default);
					goto end_IL_3591;
				}
			}
			end_IL_3591:;
		}
		class7 = class7;
		class7 = class7;
		Class7 class29 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)class29.W(bindingFlags, array6, type, null, null);
		gClass2 = (GClass3)(object)Class5.Default;
		num = default(UIntPtr);
		nuint num6;
		Class7 obj21;
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num == 0)
			{
				_ = (GClass1)(object)@class.W(bindingFlags, array6, type, (Type[])(object)Class5.Default, array4);
				class9 = class9;
				@struct = @struct;
			}
			nuint num5 = num;
			num = default(UIntPtr);
			if (num5 - num == 0 && unchecked(num / num) == 0)
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (((Class7)null).t((object)Class5.Default, type, (CultureInfo)null) != null);
			}
			num6 = num - (num + num * num);
			obj21 = (Class7)@class.t(@class.t(bindingFlags, null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array3, null)), null, cultureInfo);
		}
		BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_6 = array5;
		ref object[] object_6 = ref reference2;
		Class7 class30 = @class;
		BindingFlags bindingFlags_20 = bindingFlags;
		Class7 class31 = @class;
		bindingFlags = default(BindingFlags);
		ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)class30.t(bindingFlags_20, (FieldInfo[])(object)class31.t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W(default(BindingFlags), array6, type, array3, array4), null, cultureInfo), obj2, cultureInfo), null, (CultureInfo)(object)@class.W((BindingFlags)@class.e(default(BindingFlags), array5, null, null), (PropertyInfo[])(object)Class5.Default, type, null, null));
		string[] string_4 = array2;
		bindingFlags = default(BindingFlags);
		if (checked(num6 - unchecked((nuint)(UIntPtr)obj21.j(bindingFlags_19, methodBase_6, ref object_6, parameterModifier_3, null, string_4, out *(object*)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array2, out *(object*)Class5.Default)))) == 0)
		{
			class24 = null;
		}
		else if (num == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
			}
			else
			{
				qk = qk;
			}
		}
		else
		{
			gClass2 = gClass2;
		}
		if ((UIntPtr)@class.t(null, null, null) == (UIntPtr)(nuint)0u)
		{
			Class7 class33;
			do
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					Class7 class32 = @class;
					MethodBase[] methodBase_7 = array5;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class32.e(default(BindingFlags), methodBase_7, (Type[])(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array2, out reference), (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array4));
				}
				class33 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class33.W(bindingFlags, array6, type, array3, null) != null);
		}
		class11 = class11;
		UIntPtr num7 = (UIntPtr)((Class7)(object)Class5.Default).t(null, type, null);
		Class7 class34 = @class;
		BindingFlags bindingFlags_21 = bindingFlags;
		MethodBase[] methodBase_8 = array5;
		ref object[] object_7 = ref reference2;
		CultureInfo cultureInfo_4 = cultureInfo;
		string[] string_5 = array2;
		Class7 obj23 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_22 = bindingFlags;
		PropertyInfo[] propertyInfo_3 = array6;
		Type[] type_9 = array3;
		Class7 obj24 = (Class7)((Class7)(object)Class5.Default).t(null, null, null);
		bindingFlags = default(BindingFlags);
		Class7 obj25 = (Class7)(object)class34.j(bindingFlags_21, methodBase_8, ref object_7, null, cultureInfo_4, string_5, out *(object*)obj23.W(bindingFlags_22, propertyInfo_3, null, type_9, (ParameterModifier[])((Class7)(object)((Class7)(object)obj24.t(bindingFlags, array, obj2, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference2, array4, cultureInfo, (string[])null, out reference), array6, (Type)(object)Class5.Default, array3, null)))).j((BindingFlags)((Class7)null).t(obj2, type, cultureInfo), null, ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference)).t(obj2, type, cultureInfo)));
		BindingFlags bindingFlags_23 = bindingFlags;
		ref object[] object_8 = ref reference2;
		ParameterModifier[] parameterModifier_4 = array4;
		CultureInfo cultureInfo_5 = cultureInfo;
		string[] string_6 = array2;
		Class7 class35 = @class;
		Class7 class36 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)num7) - unchecked((nuint)(UIntPtr)obj25.j(bindingFlags_23, null, ref object_8, parameterModifier_4, cultureInfo_5, string_6, out *(object*)class35.t((BindingFlags)((Class7)(object)class36.W(bindingFlags, array6, type, array3, array4)).t(obj2, type, cultureInfo), array, ((Class7)null).W((BindingFlags)Class5.Default, array6, type, array3, (ParameterModifier[])(object)Class5.Default), cultureInfo)) / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				if (unchecked((UIntPtr)@class.t(bindingFlags, array, null, null) == (UIntPtr)(nuint)0u))
				{
					class24 = (Class2)(object)@class.W(bindingFlags, array6, type, array3, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array4));
				}
			}
			else if (unchecked((nuint)(UIntPtr)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)) + num == 0)
			{
				class19 = class19;
				gClass3 = (GClass0)(object)Class5.Default;
			}
			else
			{
				Class7 class37 = @class;
				BindingFlags bindingFlags_24 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = array6;
				Type[] type_10 = array3;
				Class7 class38 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class37.W(bindingFlags_24, propertyInfo_4, null, type_10, (ParameterModifier[])(object)class38.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null));
			}
			try
			{
				try
				{
					qk = qk;
				}
				catch
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Class7)(object)Class5.Default;
						_ = (GClass2)(object)Class5.Default;
						class9 = class9;
					}
				}
			}
			catch
			{
				try
				{
					do
					{
						_ = (_003CModule_003E)(object)Class5.Default;
						class9 = null;
					}
					while (obj2 != null);
				}
				finally
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					finally
					{
						gClass3 = (GClass0)(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
						gClass = gClass;
						gClass = null;
						goto end_IL_3cb3;
					}
				}
				end_IL_3cb3:;
			}
		}
		while ((object)Class5.Default != null)
		{
			while ((object)Class5.Default != null)
			{
				@struct = @struct;
				Class7 obj28 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, cultureInfo);
				Class7 class39 = @class;
				bindingFlags = default(BindingFlags);
				qk = (Qk7)(object)obj28.t((BindingFlags)class39.t(bindingFlags, array, null, cultureInfo), array, obj2, cultureInfo);
				_ = (Class4)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
			}
		}
		if (num != 0)
		{
			return;
		}
		while (true)
		{
			if (obj2 != null)
			{
				_ = (Class5)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, null, null, (ParameterModifier[])@class.t(obj2, type, cultureInfo))).t(bindingFlags, null, obj2, cultureInfo);
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		return;
		IL_06dd:
		_ = (Class4)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, (string[])null, out reference)).e(bindingFlags, array5, null, (ParameterModifier[])@class.t(obj2, type, null));
		}
		_ = (GClass1)(object)Class5.Default;
		while (obj2 != null)
		{
			try
			{
				do
				{
					_ = (Class6)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), out reference);
				}
				while (obj2 != null);
			}
			catch
			{
				while (obj2 != null)
				{
					Class7 obj29 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj29.t(bindingFlags, array, obj2, cultureInfo);
					@class = @class;
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if (num == 0)
			{
				class18 = class18;
			}
			else
			{
				_ = (Class0)(object)((Class7)null).e((BindingFlags)Class5.Default, array5, array3, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				Struct2 obj31 = (Struct2)((Class7)null).W(bindingFlags, array6, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				@struct = default(Struct2);
				@struct = obj31;
				_ = (GClass2)(object)@class.e(bindingFlags, array5, (Type[])(object)Class5.Default, array4);
				class11 = null;
			}
		}
		_ = (_003CModule_003E)(object)@class.e(bindingFlags, null, array3, array4);
		try
		{
			if ((UIntPtr)@class.W(bindingFlags, array6, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array3, null), array3, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		finally
		{
			checked
			{
				if (num == 0)
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * num == 0)
					{
						struct2 = struct2;
						_ = (Qk7)(object)Class5.Default;
						_ = (Class7)(object)Class5.Default;
						Class7 class40 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class6)(object)class40.W(bindingFlags, array6, type, array3, (ParameterModifier[])(object)Class5.Default);
					}
					else
					{
						@struct = @struct;
					}
				}
				goto IL_09b0;
			}
		}
		IL_1f23:
		_003CModule_003E _003CModule_003E;
		try
		{
			try
			{
				_ = (Struct2)@class.t(bindingFlags, array, obj2, cultureInfo);
				class11 = (Class9)(object)Class5.Default;
				class18 = class18;
				class9 = (Class5)@class.t(null, type, cultureInfo);
			}
			finally
			{
				class19 = class19;
				goto end_IL_1f25;
			}
			end_IL_1f25:;
		}
		catch
		{
			checked
			{
				if (num * unchecked((nuint)default(UIntPtr)) == 0)
				{
					qk = null;
				}
				else
				{
					_003CModule_003E = null;
				}
			}
		}
		finally
		{
			try
			{
				while (true)
				{
					Class7 obj33 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, null, array4);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_25 = bindingFlags;
					bindingFlags = default(BindingFlags);
					if ((object)obj33.W(bindingFlags_25, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo), null, null, (ParameterModifier[])(object)Class5.Default) != null)
					{
						_ = (Class0)(object)@class.t((BindingFlags)Class5.Default, null, obj2, null);
						continue;
					}
					break;
				}
			}
			finally
			{
				class10 = (Class4)(object)@class.W((BindingFlags)@class.e(bindingFlags, array5, null, array4), array6, type, null, array4);
				goto IL_2082;
			}
		}
		IL_193e:
		try
		{
			try
			{
				checked
				{
					if (num - (unchecked((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default) + num) == 0)
					{
						Class7 class41 = @class;
						bindingFlags = default(BindingFlags);
						struct2 = (Struct1)class41.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
					}
					else
					{
						gClass3 = (GClass0)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
					}
				}
			}
			catch
			{
				if (num == 0)
				{
					Class7 class42 = @class;
					BindingFlags bindingFlags_26 = bindingFlags;
					MethodBase[] methodBase_9 = array5;
					Class7 class43 = @class;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class42.e(bindingFlags_26, methodBase_9, (Type[])(object)class43.W(default(BindingFlags), (PropertyInfo[])(object)class44.e(bindingFlags, null, null, null), type, array3, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W((BindingFlags)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default), array6, null, array3, null), obj2, (CultureInfo)null)), (ParameterModifier[])(object)Class5.Default);
					_ = (Qk7)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, array5, ref reference2, array4, cultureInfo, null, out *(object*)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, (string[])null, out reference)), ref *(object[]*)null, array4, null, array2, out reference);
					_ = (Class0)(object)Class5.Default;
					@struct = @struct;
				}
			}
		}
		catch
		{
			do
			{
				_ = (Class9)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			class9 = null;
		}
		else
		{
			class10 = null;
		}
		Class7 class45 = @class;
		Class7 class46 = @class;
		Type type_11 = type;
		Class7 obj36 = (Class7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref reference2, array4, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null);
		Class7 class47 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_27 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)@class.e(bindingFlags, array5, array3, (ParameterModifier[])(object)Class5.Default);
		Type type_12 = (Type)(object)Class5.Default;
		Class7 class48 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_28 = (BindingFlags)class46.t(null, type_11, (CultureInfo)(object)((Class7)(object)obj36.e((BindingFlags)class47.W(bindingFlags_27, propertyInfo_5, type_12, null, (ParameterModifier[])(object)((Class7)(object)class48.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array5, null, array4), null, null)).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default)), array5, array3, array4)).e(bindingFlags, array5, null, array4));
		PropertyInfo[] propertyInfo_6 = array6;
		Type type_13 = (Type)(object)Class5.Default;
		Class7 class49 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)class45.W(bindingFlags_28, propertyInfo_6, type_13, null, (ParameterModifier[])(object)class49.e(bindingFlags, null, array3, null));
		while (obj2 != null)
		{
			_ = (Class0)(object)Class5.Default;
		}
		@class = @class;
		_ = (Struct2)Class5.Default;
		_ = (Class8)(object)Class5.Default;
		gClass3 = (GClass0)(object)Class5.Default;
		class24 = (Class2)(object)((Class7)null).j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array5, null, array4), cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) * num == 0)
			{
				do
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).e(unchecked((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array6, null, array3, array4), array3, array4)), null, null, null);
				}
				while ((object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo) != null);
				goto IL_1f23;
			}
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					Class7 class50 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class50.e(bindingFlags, array5, array3, array4);
				}
			}
			finally
			{
				if (num * (num * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					class11 = null;
					@struct = @struct;
					_ = (Qk7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, null, (ParameterModifier[])@class.t(null, type, null));
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (GClass1)(object)unchecked(((Class7)null).W((BindingFlags)Class5.Default, array6, type, (Type[])((Class7)(object)@class.j((BindingFlags)@class.j((BindingFlags)Class5.Default, array5, ref reference2, array4, cultureInfo, null, out *(object*)null), null, ref reference2, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)((Class7)null).t((object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array4), type, cultureInfo)).t(null, type, null))).t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null));
				}
				goto IL_1f23;
			}
		}
		IL_22de:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		try
		{
			@class = null;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class19 = class19;
				}
				finally
				{
					gClass4 = gClass4;
					goto end_IL_22e6;
				}
			}
			end_IL_22e6:;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)@class.t(null, null, cultureInfo);
		}
		while (obj2 != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_29 = bindingFlags;
					FieldInfo[] fieldInfo_4 = array;
					Class7 obj38 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo));
					bindingFlags = default(BindingFlags);
					class7 = (Class10)(object)((Class7)null).t(bindingFlags_29, fieldInfo_4, (object)obj38.t(bindingFlags, null, Class5.Default, cultureInfo), cultureInfo);
					_ = (Class10)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj2, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default), Class5.Default, null);
				}
				finally
				{
					class24 = (Class2)((Class7)((Class7)null).t(obj2, type, (CultureInfo)(object)Class5.Default)).t(null, (Type)(object)@class.t(bindingFlags, array, obj2, null), cultureInfo);
					continue;
				}
			}
			if (num == (UIntPtr)(nuint)0u)
			{
				gClass4 = gClass4;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			finally
			{
				qk = qk;
				goto IL_24b0;
			}
		}
		goto IL_24b0;
		IL_12e5:
		class18 = class18;
		try
		{
			_ = (GClass2)(object)Class5.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)@class.t(bindingFlags, null, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
					class18 = class18;
					_ = (Class5)(object)@class.t((BindingFlags)@class.t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo), array, null, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					class24 = class24;
					class24 = class24;
				}
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
					Class7 obj39 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array6, (Type)((Class7)null).t((object)null, (Type)null, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default), (Type)(object)@class.t(bindingFlags, null, null, cultureInfo), (Type[])null, (ParameterModifier[])null);
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)obj39.t(bindingFlags, null, obj2, cultureInfo);
				}
				goto IL_141f;
			}
		}
		IL_3274:
		while ((object)Class5.Default != null)
		{
			class7 = class7;
			Class7 class51 = @class;
			object object_9 = obj2;
			Class7 obj40 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, null));
			Class7 class52 = @class;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)class51.t(object_9, (Type)obj40.t(null, (Type)(object)class52.j(bindingFlags, null, ref *(object[]*)@class.t(bindingFlags, null, Class5.Default, cultureInfo), (ParameterModifier[])(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo), cultureInfo, null, out reference), cultureInfo), null);
		}
		Class7 obj41 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_30 = bindingFlags;
		MethodBase[] methodBase_10 = array5;
		Type[] type_14 = array3;
		BindingFlags bindingFlags_31 = bindingFlags;
		PropertyInfo[] propertyInfo_7 = array6;
		Type type_15 = type;
		Class7 class53 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)obj41.e(bindingFlags_30, methodBase_10, type_14, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_31, propertyInfo_7, type_15, (Type[])(object)class53.W(bindingFlags, array6, type, array3, null), array4));
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class18 = class18;
					class9 = class9;
					qk = qk;
				}
				catch
				{
					_ = (Struct1)@class.e((BindingFlags)((Class7)null).W(bindingFlags, array6, (Type)(object)@class.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default), array3, (ParameterModifier[])(object)Class5.Default), array5, array3, null);
				}
			}
		}
		while (obj2 != null);
		try
		{
			try
			{
				while (@class.t(null, type, cultureInfo) != null)
				{
					gClass4 = gClass4;
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])((Class7)null).t(obj2, type, (CultureInfo)null), array3, array4);
				}
			}
			finally
			{
				while (obj2 != null)
				{
					class24 = class24;
				}
				goto end_IL_3382;
			}
			end_IL_3382:;
		}
		finally
		{
			_ = (Class7)((Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)null)).t(null, (Type)(object)Class5.Default, null);
			goto IL_348e;
		}
		IL_17e8:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
		}
		@struct = @struct;
		try
		{
			do
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				catch
				{
					_ = (Class2)(object)((Class7)(object)((Class7)null).W(bindingFlags, array6, (Type)null, (Type[])null, (ParameterModifier[])null)).t(bindingFlags, array, obj2, (CultureInfo)(object)Class5.Default);
					_ = (GClass2)(object)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
			}
			catch
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_18a9;
		}
		IL_24b0:
		_ = (Class0)(object)Class5.Default;
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 obj45 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)obj45.W(bindingFlags, null, null, array3, (ParameterModifier[])((Class7)null).t((object)null, type, (CultureInfo)null));
				class11 = null;
				gClass2 = (GClass3)(object)Class5.Default;
			}
		}
		while ((object)Class5.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class54);
		try
		{
			Class7 class55;
			do
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					class54 = class54;
				}
				class55 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class55.j(bindingFlags, array5, ref reference2, array4, (CultureInfo)(object)Class5.Default, array2, out *(object*)Class5.Default) != null);
		}
		catch
		{
			do
			{
				try
				{
					class19 = class19;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		while (obj2 != null)
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)@class.e(bindingFlags, array5, null, (ParameterModifier[])(object)Class5.Default) / checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr)))) - unchecked((nuint)(UIntPtr)@class.t(null, type, (CultureInfo)@class.t(obj2, null, cultureInfo)))) == 0)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
				}
				else
				{
					bindingFlags = default(BindingFlags);
					Class7 obj48 = (Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])(object)@class.e((BindingFlags)@class.W(bindingFlags, array6, type, array3, array4), array5, null, null), array4);
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj48.e(bindingFlags, array5, array3, array4);
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)@class.W((BindingFlags)@class.e(bindingFlags, array5, array3, array4), (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.W(bindingFlags, array6, type, null, array4), array3, null);
				}
				continue;
			}
		}
		Class7 class56;
		do
		{
			IL_27fd:
			if (obj2 != null)
			{
				try
				{
					class9 = null;
				}
				finally
				{
					_ = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array6, (Type)null, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, null, cultureInfo));
					class18 = null;
					goto IL_27fd;
				}
			}
			class56 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class56.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])@class.t(@class.t(Class5.Default, null, null), type, cultureInfo), out reference) != null);
		_ = (GClass3)@class.t(Class5.Default, type, null);
		qk = qk;
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num * unchecked(checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo)).j(bindingFlags, array5, ref reference2, null, null, array2, out reference), type, null, null))) / checked(unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(obj2, null, null), array3, array4)) * unchecked((nuint)(UIntPtr)@class.t((BindingFlags)Class5.Default, array, Class5.Default, cultureInfo)))) == 0)
				{
					try
					{
						_ = (Struct2)((Class7)null).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					}
					finally
					{
						qk = qk;
						continue;
					}
				}
			}
			while (obj2 != null);
			try
			{
				UIntPtr num8 = unchecked((UIntPtr)Class5.Default);
				num = default(UIntPtr);
				if (unchecked((nuint)num8) * num == 0)
				{
					Class7 obj49 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if (unchecked((UIntPtr)obj49.e(bindingFlags, array5, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, null)) == (UIntPtr)(nuint)0u))
					{
						_003CModule_003E = _003CModule_003E;
					}
					else
					{
						class54 = null;
					}
				}
				else
				{
					_ = (Class2)@class.t(null, type, (CultureInfo)((Class7)(object)Class5.Default).t(null, type, null));
					_ = (GClass0)(object)Class5.Default;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					try
					{
						_ = Class5.Default;
					}
					finally
					{
						_ = (Struct1)@class.e(bindingFlags, array5, array3, array4);
						continue;
					}
				}
				goto IL_2a9a;
			}
		}
		IL_141f:
		try
		{
			try
			{
				BindingFlags bindingFlags_32 = bindingFlags;
				MethodBase[] methodBase_11 = array5;
				Class7 class57 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_33 = bindingFlags;
				BindingFlags bindingFlags_34 = (BindingFlags)Class5.Default;
				Class7 obj50 = (Class7)(object)@class.W(bindingFlags, array6, null, null, array4);
				BindingFlags bindingFlags_35 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array;
				Class7 obj51 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_36 = bindingFlags;
				MethodBase[] methodBase_12 = array5;
				BindingFlags bindingFlags_37 = bindingFlags;
				Class7 class58 = @class;
				Class7 class59 = @class;
				BindingFlags bindingFlags_38 = bindingFlags;
				MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
				Type[] type_16 = array3;
				Class7 class60 = @class;
				Class7 obj52 = (Class7)((Class7)null).t(obj2, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				object object_10 = obj51.j(bindingFlags_36, methodBase_12, ref *(object[]*)((Class7)((Class7)(object)((Class7)null).W(bindingFlags_37, (PropertyInfo[])(object)class58.j((BindingFlags)class59.e(bindingFlags_38, methodBase_13, type_16, (ParameterModifier[])(object)class60.t((BindingFlags)obj52.e(bindingFlags, array5, array3, (ParameterModifier[])(object)@class.j(bindingFlags, array5, ref *(object[]*)Class5.Default, array4, cultureInfo, array2, out *(object*)null)), array, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4))), array5, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference), type, array3, array4)).t(obj2, type, cultureInfo)).t(null, type, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference));
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_39 = (BindingFlags)class61.e(bindingFlags, array5, null, array4);
				Class7 class62 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).e(bindingFlags_32, methodBase_11, (Type[])null, (ParameterModifier[])(object)class57.e(bindingFlags_33, (MethodBase[])(object)((Class7)null).t(bindingFlags_34, (FieldInfo[])(object)obj50.t(bindingFlags_35, fieldInfo_5, object_10, (CultureInfo)(object)((Class7)null).j(bindingFlags_39, (MethodBase[])(object)class62.t(bindingFlags, array, Class5.Default, cultureInfo), ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])null, out reference)), (object)null, (CultureInfo)null), array3, array4));
			}
			finally
			{
				Class7 class63 = @class;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				class18 = (Class0)(object)((Class7)(object)class63.j((BindingFlags)((Class7)(object)((Class7)null).t((BindingFlags)class64.t(bindingFlags, array, obj2, cultureInfo), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)).W(bindingFlags, null, null, array3, array4), (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default), ref reference2, null, cultureInfo, array2, out reference)).e(bindingFlags, array5, array3, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo));
				goto end_IL_1420;
			}
			end_IL_1420:;
		}
		catch
		{
			try
			{
				Class8 obj53 = (Class8)((Class7)(object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, (ParameterModifier[])(object)Class5.Default)).t(obj2, null, cultureInfo);
				class54 = class54;
				class54 = obj53;
			}
			catch
			{
				while (true)
				{
					_ = (Class10)(object)Class5.Default;
					if (obj2 != null)
					{
						continue;
					}
					goto end_IL_17c2;
				}
				end_IL_17c2:;
			}
		}
		try
		{
		}
		finally
		{
			_ = (GClass2)(object)Class5.Default;
			goto IL_17e8;
		}
		IL_09b0:
		try
		{
			UIntPtr num9 = (UIntPtr)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default);
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num9) + num == 0)
				{
					try
					{
						gClass3 = null;
					}
					catch
					{
						class19 = class19;
						class19 = null;
					}
				}
				else
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Struct2)@class.t(bindingFlags, null, obj2, null);
					}
					else
					{
						_ = (Class6)(object)Class5.Default;
						_ = (Class9)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, array4);
					}
				}
			}
		}
		catch
		{
			_ = (Class4)(object)Class5.Default;
		}
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_40 = bindingFlags;
		Class7 class65 = @class;
		BindingFlags bindingFlags_41 = bindingFlags;
		PropertyInfo[] propertyInfo_8 = array6;
		Type type_17 = (Type)(object)Class5.Default;
		Class7 class66 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_42 = bindingFlags;
		Class7 class67 = @class;
		Class7 obj58 = (Class7)(object)@class.W(bindingFlags, array6, type, array3, (ParameterModifier[])(object)Class5.Default);
		MethodBase[] methodBase_14 = array5;
		Type[] type_18 = array3;
		Class7 class68 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)((Class7)null).t(bindingFlags_40, (FieldInfo[])null, (object)class65.W(bindingFlags_41, propertyInfo_8, type_17, (Type[])(object)class66.e(bindingFlags_42, (MethodBase[])(object)class67.j((BindingFlags)obj58.e(default(BindingFlags), methodBase_14, type_18, (ParameterModifier[])(object)class68.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array4)), array5, ref reference2, null, (CultureInfo)(object)Class5.Default, null, out reference), null, null), array4), cultureInfo);
		while (obj2 != null)
		{
			do
			{
				Class7 obj59 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj59.e(bindingFlags, array5, (Type[])(object)Class5.Default, array4);
			}
			while (obj2 != null);
		}
		@class = @class;
		BindingFlags bindingFlags_43 = bindingFlags;
		MethodBase[] methodBase_15 = (MethodBase[])(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null)).e((BindingFlags)@class.e(bindingFlags, array5, null, (ParameterModifier[])(object)@class.t(bindingFlags, array, null, null)), null, array3, array4);
		Type[] type_19 = array3;
		Class7 class69 = @class;
		BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_16 = array5;
		Class7 class70 = @class;
		BindingFlags bindingFlags_45 = bindingFlags;
		FieldInfo[] fieldInfo_6 = array;
		object object_11 = obj2;
		Class7 class71 = @class;
		Class7 obj60 = (Class7)(object)Class5.Default;
		object object_12 = @class.t(bindingFlags, array, Class5.Default, null);
		Type type_20 = type;
		Class7 class72 = @class;
		MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
		ref object[] object_13 = ref reference2;
		ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_46 = (BindingFlags)((Class7)obj60.t(object_12, type_20, (CultureInfo)(object)class72.j(default(BindingFlags), methodBase_17, ref object_13, parameterModifier_5, (CultureInfo)(object)((Class7)null).j(bindingFlags, array5, ref reference2, array4, (CultureInfo)null, array2, out *(object*)Class5.Default), array2, out reference))).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array3, array4);
		PropertyInfo[] propertyInfo_9 = array6;
		Class7 class73 = @class;
		bindingFlags = default(BindingFlags);
		_003CModule_003E = (_003CModule_003E)(object)((Class7)null).e(bindingFlags_43, methodBase_15, type_19, (ParameterModifier[])(object)class69.j(bindingFlags_44, methodBase_16, ref *(object[]*)class70.t(bindingFlags_45, fieldInfo_6, object_11, (CultureInfo)(object)class71.W(bindingFlags_46, propertyInfo_9, (Type)(object)class73.W(bindingFlags, array6, null, (Type[])(object)Class5.Default, null), (Type[])(object)Class5.Default, array4)), array4, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default));
		_003CModule_003E = null;
		do
		{
			gClass3 = gClass3;
		}
		while (obj2 != null);
		while (obj2 != null)
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Struct2)((Class7)null).e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					@struct = (Struct2)@class.t(bindingFlags, array, obj2, cultureInfo);
				}
				continue;
			}
			Class7 class74 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class74.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)(object)@class.e((BindingFlags)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)), array5, (Type[])(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference2, null, null, null, out reference), array5, array3, array4), null));
			}
		}
		_ = (Class2)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])null);
		_ = (GClass3)(object)Class5.Default;
		while (true)
		{
			BindingFlags bindingFlags_47 = bindingFlags;
			MethodBase[] methodBase_18 = array5;
			ref object[] object_14 = ref *(object[]*)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array3, null);
			Class7 obj61 = (Class7)((Class7)(object)@class.W((BindingFlags)@class.t((BindingFlags)Class5.Default, null, obj2, cultureInfo), array6, (Type)(object)@class.t((BindingFlags)Class5.Default, null, obj2, null), array3, array4)).t(((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo), (Type)(object)Class5.Default, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).j(bindingFlags_47, methodBase_18, ref object_14, (ParameterModifier[])(object)obj61.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array2, out reference), (CultureInfo)null, (string[])null, out reference) == null)
			{
				break;
			}
			try
			{
				gClass2 = gClass2;
				gClass2 = gClass2;
			}
			catch
			{
				class11 = class11;
			}
		}
		try
		{
			try
			{
				try
				{
					class19 = (Class6)(object)@class.e((BindingFlags)Class5.Default, array5, null, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					gClass2 = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref reference2, array4, cultureInfo, null, out reference);
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class7 = class7;
				}
				else
				{
					_003CModule_003E = null;
					Class7 obj64 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_48 = bindingFlags;
					Class7 class75 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj64.t(bindingFlags_48, (FieldInfo[])(object)class75.t(bindingFlags, array, obj2, cultureInfo), obj2, cultureInfo);
				}
			}
		}
		catch
		{
			try
			{
			}
			catch
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		try
		{
			while (obj2 != null)
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, array2, out *(object*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array3, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array6, type, null, array4), ref *(object[]*)Class5.Default, array4, null, array2, out *(object*)null))) == (UIntPtr)(nuint)0u)
				{
					Class7 class76 = @class;
					BindingFlags bindingFlags_49 = (BindingFlags)Class5.Default;
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj68 = (Class7)(object)class77.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)@class.t(bindingFlags, array, Class5.Default, null), array6, type, (Type[])null, (ParameterModifier[])null));
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class76.e(bindingFlags_49, null, (Type[])(object)((Class7)(object)obj68.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null)).e(bindingFlags, null, array3, (ParameterModifier[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo)), array4);
				}
			}
		}
		finally
		{
			qk = null;
			goto IL_12e5;
		}
		IL_2082:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				BindingFlags bindingFlags_50 = bindingFlags;
				MethodBase[] methodBase_19 = array5;
				Class7 class78 = @class;
				PropertyInfo[] propertyInfo_10 = array6;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)null).e(bindingFlags_50, methodBase_19, (Type[])null, (ParameterModifier[])(object)class78.W(default(BindingFlags), propertyInfo_10, null, null, (ParameterModifier[])(object)class79.W(bindingFlags, null, null, null, array4)));
			}
			while ((object)Class5.Default != null);
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 class80 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class80.W(bindingFlags, array6, (Type)(object)Class5.Default, array3, null) == null)
				{
					break;
				}
				class11 = class11;
			}
		}
		class54 = class54;
		class24 = class24;
		_ = (Class6)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo);
		class7 = null;
		class18 = null;
		_ = (Class10)(object)Class5.Default;
		gClass4 = gClass4;
		gClass4 = gClass4;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class10 = class10;
			}
			finally
			{
				if ((UIntPtr)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(null, type, cultureInfo), array3, (ParameterModifier[])(object)Class5.Default);
				}
				goto IL_2215;
			}
		}
		goto IL_2215;
	}

	unsafe static void smethod_2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		CultureInfo cultureInfo_;
		Type[] array3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		string[] string_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		BindingFlags bindingFlags;
		while (true)
		{
			Class7 class2 = @class;
			BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
			reference = ref reference;
			ref object[] object_ = ref reference;
			Class7 class3 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_2 = bindingFlags;
			array = array;
			MethodBase[] methodBase_ = array;
			BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
			array2 = array2;
			FieldInfo[] fieldInfo_ = array2;
			obj = obj;
			object object_2 = obj;
			cultureInfo_ = (CultureInfo)(object)Class5.Default;
			array3 = (Type[])(object)((Class7)null).t(bindingFlags_3, fieldInfo_, object_2, cultureInfo_);
			Class7 obj2 = (Class7)(object)class3.e(bindingFlags_2, methodBase_, array3, (ParameterModifier[])(object)Class5.Default);
			BindingFlags bindingFlags_4 = bindingFlags;
			array4 = array4;
			PropertyInfo[] propertyInfo_ = array4;
			Type type_ = type;
			array5 = array5;
			type = (Type)(object)obj2.W(bindingFlags_4, propertyInfo_, type_, array3, array5);
			ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, array3, array5), array, array3, array5);
			CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
			string_ = (string[])(object)Class5.Default;
			@class = (Class7)(object)class2.j(bindingFlags_, null, ref object_, parameterModifier_, cultureInfo_2, string_, out *(object*)null);
			if ((object)@class.W(bindingFlags, null, null, null, array5) == null)
			{
				break;
			}
			_ = (Qk7)(object)Class5.Default;
		}
		Qk7 qk;
		do
		{
			qk = (Qk7)(object)@class.t(bindingFlags, array2, null, cultureInfo_);
			qk = qk;
		}
		while ((object)Class5.Default != null);
		_ = (Class7)(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)null);
		_ = (Class8)(object)((Class7)null).t(bindingFlags, array2, (object)null, (CultureInfo)(object)Class5.Default);
		Class4 class4 = (Class4)(object)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array3, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array, (Type[])((Class7)null).t((object)null, (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array5), (CultureInfo)null), array5);
		class4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class6);
		nuint num;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				checked
				{
					num = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Class5.Default) + unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)));
				}
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					@class = null;
					bindingFlags = default(BindingFlags);
					Struct1 obj3 = (Struct1)((Class7)null).e(bindingFlags, array, array3, array5);
					@struct = @struct;
					@struct = obj3;
					_ = (Class8)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			Class7 class5 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)class5.e(bindingFlags, array, array3, array5)).W(bindingFlags, array4, type, null, array5) == (UIntPtr)(nuint)0u)
			{
				if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)@class.t(obj, type, null))) == 0)
				{
					Class2 obj4 = (Class2)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo_);
					class6 = class6;
					class6 = obj4;
				}
				else
				{
					BindingFlags bindingFlags_5 = bindingFlags;
					ref object[] object_3 = ref reference;
					object_4 = ref *(object*)Class5.Default;
					_ = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags_5, (MethodBase[])null, ref object_3, (ParameterModifier[])null, cultureInfo_, (string[])null, out object_4)).W(bindingFlags, array4, type, array3, array5);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class7);
		try
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			catch
			{
				try
				{
					class6 = null;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
					_ = (Class10)@class.t(null, type, cultureInfo_);
				}
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					Class7 obj7 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj7.W(bindingFlags, array4, type, array3, (ParameterModifier[])(object)Class5.Default);
				}
			}
			catch
			{
				try
				{
					@class = @class;
					goto end_IL_046e;
				}
				finally
				{
					class7 = null;
					class7 = class7;
					goto end_IL_046e;
				}
				end_IL_046e:;
			}
		}
		@class = @class;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class0)(object)Class5.Default;
		}
		Class8 class8 = class8;
		class8 = null;
		Class7 class9 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)class9.j(bindingFlags, array, ref reference, array5, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, null), (string[])(object)Class5.Default, out *(object*)null);
		Struct2 struct2 = default(Struct2);
		Class5 class10 = class10;
		class10 = class10;
		num = default(UIntPtr);
		_003CModule_003E _003CModule_003E;
		checked
		{
			nuint num2 = num + num;
			num = default(UIntPtr);
			if (num2 * num == 0 && num == 0)
			{
				try
				{
					class6 = (Class2)(object)@class.t(unchecked((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, null)), (FieldInfo[])((Class7)(object)Class5.Default).t(obj, type, null), obj, cultureInfo_);
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			nuint num3 = num;
			nuint num4 = num;
			num = default(UIntPtr);
			if ((num3 - unchecked(num4 / num)) * num == 0)
			{
				while (obj != null)
				{
					if (unchecked((UIntPtr)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u))
					{
						@class = (Class7)(object)Class5.Default;
					}
				}
				goto IL_0636;
			}
			try
			{
				_003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				goto IL_0636;
			}
		}
		IL_1701:
		do
		{
			class4 = (Class4)(object)Class5.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		try
		{
			_ = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null);
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				gClass = gClass;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			BindingFlags bindingFlags_6 = (BindingFlags)Class5.Default;
			Class7 class11 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)(object)((Class7)null).W(bindingFlags_6, (PropertyInfo[])(object)((Class7)(object)class11.W(bindingFlags, null, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array5))).e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), (Type)null, array3, array5)).W(bindingFlags, array4, null, null, (ParameterModifier[])(object)Class5.Default);
			Class7 class12 = @class;
			BindingFlags bindingFlags_7 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
			Type type_2 = type;
			Class7 class13 = @class;
			BindingFlags bindingFlags_8 = bindingFlags;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj12 = (Class7)(object)class13.t(bindingFlags_8, fieldInfo_2, ((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, array5), array5), cultureInfo_);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_9 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = array4;
			BindingFlags bindingFlags_10 = bindingFlags;
			MethodBase[] methodBase_2 = array;
			ref object[] object_5 = ref reference;
			CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			Class7 obj13 = (Class7)(object)obj12.W(bindingFlags_9, propertyInfo_3, null, (Type[])(object)((Class7)null).j(bindingFlags_10, methodBase_2, ref object_5, (ParameterModifier[])null, cultureInfo_3, string_, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array5)), array5);
			BindingFlags bindingFlags_11 = (BindingFlags)((Class7)null).t(bindingFlags, array2, obj, cultureInfo_);
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class12.W(bindingFlags_7, propertyInfo_2, type_2, (Type[])(object)obj13.t(bindingFlags_11, null, ((Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null)).t(bindingFlags, array2, Class5.Default, cultureInfo_), cultureInfo_), array5);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class16);
		GClass2 gClass2;
		Class0 class15;
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num + num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					try
					{
						class6 = null;
					}
					finally
					{
						qk = qk;
						continue;
					}
				}
			}
			while (obj != null);
			if (num == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (Class8)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_);
				}
			}
			else
			{
				do
				{
					if (num * num != 0)
					{
						Class7 class14 = @class;
						BindingFlags bindingFlags_12 = unchecked((BindingFlags)Class5.Default);
						PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
						Class7 obj14 = (Class7)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						_ = (Class0)(object)class14.W(bindingFlags_12, propertyInfo_4, (Type)((Class7)(object)obj14.t(bindingFlags, null, @class.t(obj, type, cultureInfo_), (CultureInfo)(object)Class5.Default)).t(obj, type, null), array3, (ParameterModifier[])(object)Class5.Default);
						_ = (Struct2)Class5.Default;
						class10 = Class5.Default;
						_ = (Class0)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)@class.W(bindingFlags, null, type, array3, array5));
					}
					else
					{
						class15 = (Class0)(object)Class5.Default;
					}
				}
				while (obj != null);
			}
			gClass = null;
			gClass = gClass;
			_ = (Class8)(object)Class5.Default;
			try
			{
				class8 = class8;
			}
			catch
			{
				if (num == 0)
				{
					while (obj != null)
					{
						class16 = class16;
					}
				}
			}
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					nuint num5 = num;
					num = default(UIntPtr);
					nuint num6 = num5 - num * (num - unchecked((nuint)default(UIntPtr)));
					num = default(UIntPtr);
					if (num6 - (unchecked(unchecked((nuint)default(UIntPtr)) / num) - num) == 0)
					{
						gClass2 = gClass2;
					}
				}
			}
			while (obj != null);
			try
			{
			}
			catch
			{
				do
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
				while (@class.t(null, (Type)(object)Class5.Default, null) != null);
			}
			do
			{
				class4 = class4;
				_ = (Class6)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null);
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
			try
			{
				class10 = null;
			}
			catch
			{
				do
				{
					class8 = class8;
					qk = qk;
				}
				while ((object)Class5.Default != null);
			}
			try
			{
				_ = (Struct1)Class5.Default;
				_ = Class5.Default;
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				class15 = null;
				_ = (Class9)(object)Class5.Default;
				goto IL_1c95;
			}
		}
		IL_2993:
		do
		{
			try
			{
				_003CModule_003E = null;
			}
			finally
			{
				Class7 obj18 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class7 = (Class6)(object)obj18.j(bindingFlags, null, ref *(object[]*)null, array5, null, string_, out object_4);
				continue;
			}
		}
		while (obj != null || (object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo_, string_, out object_4) != null);
		_ = (Class5)(object)@class.t(default(BindingFlags), array2, obj, cultureInfo_);
		Class7 obj19 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		struct2 = (Struct2)obj19.t(bindingFlags, array2, obj, null);
		GClass1 gClass3;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					gClass3 = null;
				}
			}
			finally
			{
				_ = (Struct1)Class5.Default;
				goto IL_2a97;
			}
		}
		goto IL_2a97;
		IL_165d:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					class16 = null;
					class16 = class16;
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto IL_1701;
				}
			}
		}
		else
		{
			_ = (Struct1)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo_)).j(bindingFlags, null, ref reference, array5, cultureInfo_, null, out *(object*)Class5.Default), null);
		}
		goto IL_1701;
		IL_36fc:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && num == 0)
		{
			_ = (_003CModule_003E)(object)((Class7)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo_, string_, out object_4)).e(bindingFlags, array, (Type[])(object)Class5.Default, array5);
		}
		bindingFlags = default(BindingFlags);
		GClass0 gClass4 = (GClass0)(object)((Class7)(object)((Class7)null).W(bindingFlags, array4, (Type)@class.t(obj, type, cultureInfo_), array3, (ParameterModifier[])null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, null);
		_ = (Class0)(object)Class5.Default;
		_ = (Class9)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					struct2 = default(Struct2);
				}
			}
			else
			{
				while ((object)@class.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)null).t(obj, type, cultureInfo_), null, (string[])(object)Class5.Default, out object_4), string_, out *(object*)null) != null)
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class17);
		if (num == 0)
		{
			try
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					struct2 = struct2;
					goto end_IL_38ab;
				}
				end_IL_38ab:;
			}
			finally
			{
				do
				{
					class17 = class17;
				}
				while (obj != null);
				goto IL_390b;
			}
		}
		goto IL_390b;
		IL_1f88:
		gClass = gClass;
		checked
		{
			if (unchecked((nuint)(UIntPtr)@class.t(((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, null, null, string_, out *(object*)null), null, null)) * unchecked((nuint)(UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null)) == 0)
			{
				class4 = null;
			}
			do
			{
				qk = qk;
			}
			while (obj != null);
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					struct2 = struct2;
					class4 = class4;
					goto end_IL_2048;
				}
				end_IL_2048:;
			}
		}
		else
		{
			_ = (Class5)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array5, (CultureInfo)(object)Class5.Default, (string[])(object)@class.t(bindingFlags, array2, obj, null), out *(object*)Class5.Default);
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
					_ = (GClass3)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
				}
			}
			catch
			{
				try
				{
					_ = (GClass2)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array3, array5);
				}
				catch
				{
					class15 = class15;
				}
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
				while (true)
				{
					if ((object)Class5.Default != null)
					{
						_ = (Class0)(object)Class5.Default;
						continue;
					}
					goto end_IL_2127;
				}
				end_IL_2127:;
			}
		}
		_ = (Qk7)(object)Class5.Default;
		class16 = class16;
		while (obj != null)
		{
			_ = (Class5)(object)@class.e(bindingFlags, array, array3, null);
		}
		Class7 class18 = @class;
		Class7 class19 = @class;
		FieldInfo[] fieldInfo_3 = array2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class18.t(((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)class19.t(default(BindingFlags), fieldInfo_3, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo_)), obj, (CultureInfo)(object)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, array4, (Type)null, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array5, (CultureInfo)(object)Class5.Default, string_, out object_4), (ParameterModifier[])null), (MethodBase[])null, ref *(object[]*)@class.t((BindingFlags)Class5.Default, array2, null, cultureInfo_), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_, out *(object*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array5))), type, null) == (UIntPtr)(nuint)0u)
		{
			_ = (Class7)(object)Class5.Default;
		}
		if ((UIntPtr)@class.t(obj, type, null) == (UIntPtr)(nuint)0u)
		{
			Class7 class20;
			BindingFlags bindingFlags_13;
			ref object[] object_6;
			ParameterModifier[] parameterModifier_2;
			CultureInfo cultureInfo_4;
			Class7 obj26;
			BindingFlags bindingFlags_14;
			ref object[] object_7;
			BindingFlags bindingFlags_15;
			Class7 obj27;
			do
			{
				_003CModule_003E = _003CModule_003E;
				class20 = @class;
				bindingFlags = default(BindingFlags);
				bindingFlags_13 = bindingFlags;
				object_6 = ref reference;
				parameterModifier_2 = array5;
				cultureInfo_4 = (CultureInfo)(object)Class5.Default;
				obj26 = (Class7)(object)Class5.Default;
				bindingFlags_14 = bindingFlags;
				object_7 = ref reference;
				bindingFlags_15 = (BindingFlags)((Class7)null).t((object)null, (Type)null, cultureInfo_);
				obj27 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class20.j(bindingFlags_13, null, ref object_6, parameterModifier_2, cultureInfo_4, (string[])(object)obj26.j(bindingFlags_14, null, ref object_7, null, (CultureInfo)(object)((Class7)null).e(bindingFlags_15, (MethodBase[])null, (Type[])(object)obj27.W(bindingFlags, null, type, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array5), null), (ParameterModifier[])null), null, out *(object*)Class5.Default), out object_4) != null);
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)@class.t(obj, (Type)(object)Class5.Default, cultureInfo_);
		}
		else
		{
			Class7 class21 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class21.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
			class10 = class10;
			_ = (Class10)@class.t(obj, type, cultureInfo_);
			class7 = (Class6)(object)@class.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
		}
		else
		{
			try
			{
				UIntPtr num7 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)num7) * num - num) == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
					else
					{
						_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					}
				}
			}
			catch
			{
				class17 = class17;
			}
		}
		class7 = class7;
		do
		{
			try
			{
				try
				{
					gClass3 = null;
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					goto end_IL_24bf;
				}
				end_IL_24bf:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
				}
				continue;
			}
		}
		while (obj != null);
		do
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Class7 obj29 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj29.e(bindingFlags, array, array3, array5);
				}
			}
			finally
			{
				do
				{
					gClass4 = gClass4;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		class4 = class4;
		_ = (Class7)(object)Class5.Default;
		class8 = class8;
		Class7 class22;
		do
		{
			BindingFlags bindingFlags_16 = bindingFlags;
			MethodBase[] methodBase_3 = array;
			ref object[] object_8 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_3 = array5;
			CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
			Class7 obj30 = (Class7)(object)Class5.Default;
			Class7 obj31 = (Class7)((Class7)null).t(obj, type, cultureInfo_);
			bindingFlags = default(BindingFlags);
			Class7 obj32 = (Class7)obj30.t(obj31.e(bindingFlags, null, array3, array5), (Type)(object)Class5.Default, null);
			BindingFlags bindingFlags_17 = bindingFlags;
			ParameterModifier[] parameterModifier_4 = array5;
			Class7 obj33 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(bindingFlags_16, methodBase_3, ref object_8, parameterModifier_3, cultureInfo_5, string_, out *(object*)obj32.j(bindingFlags_17, null, ref *(object[]*)null, parameterModifier_4, (CultureInfo)(object)obj33.e(bindingFlags, array, null, (ParameterModifier[])@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), string_, out object_4)) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)((Class7)null).W(bindingFlags, array4, type, array3, array5);
				}
			}
			class22 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class22.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)@class.t(Class5.Default, null, null), array, array3, array5), null, (string[])(object)Class5.Default, out object_4) != null);
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				gClass2 = null;
				_ = (Class10)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo_, null, out *(object*)null);
				_ = (GClass2)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Class4)(object)@class.e((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_), (Type)(object)Class5.Default, null, null)), array, array3, null);
			}
			catch
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					Class7 obj35 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj35.W(bindingFlags, array4, type, array3, array5);
				}
				goto end_IL_2744;
			}
			end_IL_2744:;
		}
		try
		{
			do
			{
				if ((UIntPtr)@class.t(obj, null, null) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)@class.t(bindingFlags, null, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array3, (ParameterModifier[])((Class7)(object)Class5.Default).t(@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, array5, cultureInfo_, string_, out *(object*)Class5.Default), type, null)));
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				class4 = (Class4)(object)Class5.Default;
			}
			catch
			{
				if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type, array3, (ParameterModifier[])(object)Class5.Default))) == 0)
				{
					_ = (Class8)(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, cultureInfo_), (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo_, string_, out *(object*)Class5.Default);
					class4 = class4;
					class8 = class8;
				}
			}
			goto IL_2993;
		}
		IL_1c95:
		checked
		{
			try
			{
				class10 = null;
				_ = (Qk7)(object)Class5.Default;
			}
			catch
			{
				num = default(UIntPtr);
				nuint num8 = num;
				Class7 obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if (num8 + unchecked((nuint)(UIntPtr)obj38.W(bindingFlags, array4, (Type)(object)Class5.Default, array3, array5)) == 0)
				{
					@struct = @struct;
				}
				else
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						class10 = null;
					}
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Struct2)@class.W(bindingFlags, array4, type, null, array5);
			}
			while (obj != null);
			goto IL_1d8b;
		}
		try
		{
			struct2 = default(Struct2);
			struct2 = struct2;
		}
		finally
		{
			while (@class.t(Class5.Default, null, cultureInfo_) != null)
			{
				_ = (Class9)(object)Class5.Default;
			}
			goto IL_1d8b;
		}
		IL_2a97:
		try
		{
			try
			{
				try
				{
					gClass = gClass;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					goto end_IL_2a99;
				}
				end_IL_2a99:;
			}
			catch
			{
			}
		}
		catch
		{
			_ = (Qk7)((Class7)null).t(obj, type, (CultureInfo)null);
		}
		num = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + num) == 0)
		{
			do
			{
				Class7 class23 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class23.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo_, string_, out *(object*)null);
				Class7 class24 = @class;
				BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array3, null);
				Class7 class25 = @class;
				BindingFlags bindingFlags_19 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_20 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array4;
				Class7 class26 = @class;
				BindingFlags bindingFlags_21 = bindingFlags;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class24.t(bindingFlags_18, fieldInfo_4, ((Class7)(object)class25.j(bindingFlags_19, (MethodBase[])(object)((Class7)null).W(bindingFlags_20, propertyInfo_5, (Type)(object)((Class7)(object)class26.t(bindingFlags_21, null, class27.j(bindingFlags, array, ref reference, (ParameterModifier[])@class.t(obj, type, null), cultureInfo_, string_, out object_4), cultureInfo_)).W(bindingFlags, array4, (Type)(object)Class5.Default, null, null), array3, array5), ref *(object[]*)((Class7)null).j(bindingFlags, array, ref *(object[]*)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, null, string_, out object_4), array5, cultureInfo_, string_, out object_4), null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out object_4))).j(bindingFlags, array, ref reference, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null), cultureInfo_);
			}
			while (((Class7)(object)Class5.Default).t(null, type, (CultureInfo)@class.t(obj, type, null)) != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == 0)
				{
					struct2 = struct2;
				}
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
				Class7 class28 = @class;
				BindingFlags bindingFlags_22 = bindingFlags;
				MethodBase[] methodBase_4 = array;
				ref object[] object_9 = ref reference;
				ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
				Class7 class29 = @class;
				BindingFlags bindingFlags_23 = bindingFlags;
				Class7 obj42 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_24 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
				ref object[] object_10 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj43 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)Class5.Default, out object_4);
				bindingFlags = default(BindingFlags);
				gClass4 = (GClass0)(object)((Class7)null).e((BindingFlags)class28.j(bindingFlags_22, methodBase_4, ref object_9, parameterModifier_5, cultureInfo_, (string[])(object)class29.e(bindingFlags_23, (MethodBase[])(object)obj42.j(bindingFlags_24, methodBase_5, ref object_10, parameterModifier_6, cultureInfo_, (string[])(object)obj43.e(bindingFlags, array, array3, null), out object_4), array3, array5), out object_4), array, (Type[])(object)Class5.Default, array5);
			}
		}
		_ = (GClass2)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array5, cultureInfo_, (string[])(object)Class5.Default, out object_4);
		_ = (Class7)(object)@class.e((BindingFlags)Class5.Default, array, array3, null);
		gClass2 = gClass2;
		Class7 class30 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)class30.t(bindingFlags, array2, null, cultureInfo_);
		class10 = class10;
		if (num == 0)
		{
			UIntPtr num9 = (UIntPtr)Class5.Default;
			UIntPtr num10 = (UIntPtr)((Class7)null).e(bindingFlags, array, array3, (ParameterModifier[])null);
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num9) + unchecked(checked(unchecked((nuint)num10) - num) / (nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array5)) == 0)
				{
					while (obj != null)
					{
						Class7 class31 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class9)(object)class31.W(bindingFlags, array4, type, array3, null);
					}
				}
				else
				{
					while ((object)Class5.Default != null)
					{
						struct2 = struct2;
					}
				}
			}
		}
		if (num == 0)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		try
		{
			while ((object)((Class7)(object)Class5.Default).e(bindingFlags, array, array3, array5) != null)
			{
				qk = (Qk7)(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo_);
			}
		}
		catch
		{
			while (obj != null)
			{
			}
		}
		_ = (_003CModule_003E)(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null);
		if (num == 0)
		{
			_ = (Class7)(object)Class5.Default;
		}
		try
		{
			if ((UIntPtr)@class.e(bindingFlags, array, null, null) == (UIntPtr)(nuint)0u)
			{
				nuint num12;
				nuint num13;
				checked
				{
					nuint num11 = unchecked((nuint)(UIntPtr)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array3, (ParameterModifier[])null)) + unchecked((nuint)(UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null));
					num = default(UIntPtr);
					num12 = num11 * num;
					num13 = num;
				}
				UIntPtr num14 = (UIntPtr)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array2, obj, null), null, null);
				num = default(UIntPtr);
				nuint num15 = num12 / (checked(num13 + unchecked((nuint)num14) * num) / num / num);
				num = default(UIntPtr);
				if (checked(num15 - num) == 0)
				{
					gClass2 = null;
				}
				else
				{
					class16 = (Class10)(object)Class5.Default;
				}
			}
		}
		catch
		{
			_ = (Class5)(object)@class.t(bindingFlags, null, null, cultureInfo_);
		}
		if ((UIntPtr)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, @class.t(bindingFlags, array2, ((Class7)null).t((object)null, (Type)null, cultureInfo_), null), cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			gClass4 = (GClass0)(object)Class5.Default;
		}
		else
		{
			gClass = gClass;
			_ = (Qk7)(object)Class5.Default;
			@struct = @struct;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo_, (string[])null, out object_4);
		}
		do
		{
			try
			{
				gClass3 = null;
			}
			finally
			{
				_ = (Qk7)(object)Class5.Default;
				continue;
			}
		}
		while (obj != null);
		try
		{
			do
			{
				Class7 class32 = @class;
				BindingFlags bindingFlags_25 = bindingFlags;
				MethodBase[] methodBase_6 = array;
				ref object[] object_11 = ref *(object[]*)Class5.Default;
				Class7 class33 = @class;
				BindingFlags bindingFlags_26 = bindingFlags;
				MethodBase[] methodBase_7 = (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, cultureInfo_, null, out *(object*)null);
				ref object[] object_12 = ref reference;
				ParameterModifier[] parameterModifier_7 = array5;
				Class7 class34 = @class;
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_27 = (BindingFlags)class35.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])((Class7)@class.t(null, null, null)).t(obj, (Type)(object)((Class7)(object)@class.j((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, array4, (Type)((Class7)(object)@class.W(bindingFlags, array4, type, array3, (ParameterModifier[])(object)Class5.Default)).t(obj, null, null), array3, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, (Type)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.W((BindingFlags)Class5.Default, array4, null, null, null), (Type[])(object)Class5.Default, (ParameterModifier[])null)).t(bindingFlags, null, obj, cultureInfo_), null))), array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_), (CultureInfo)(object)Class5.Default), null);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class32.j(bindingFlags_25, methodBase_6, ref object_11, (ParameterModifier[])((Class7)null).t((object)class33.j(bindingFlags_26, methodBase_7, ref object_12, parameterModifier_7, null, null, out *(object*)class34.t(bindingFlags_27, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array5), obj, (CultureInfo)(object)Class5.Default)), type, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null)), cultureInfo_, null, out object_4) != (UIntPtr)(nuint)0u)
				{
					class16 = class16;
					continue;
				}
				_ = (Class4)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
				BindingFlags bindingFlags_28 = (BindingFlags)@class.W((BindingFlags)Class5.Default, null, null, array3, null);
				MethodBase[] methodBase_8 = array;
				CultureInfo cultureInfo_6 = (CultureInfo)((Class7)@class.t(((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])null), null, null)).t(Class5.Default, type, (CultureInfo)(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null));
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).j(bindingFlags_28, methodBase_8, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_6, string_, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])@class.t(obj, null, cultureInfo_)));
			}
			while ((object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array3, array5) != null);
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class4 = null;
					_ = (Class6)(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.j(bindingFlags, array, ref reference, array5, cultureInfo_, (string[])(object)Class5.Default, out object_4), null, type, (Type[])(object)Class5.Default, array5);
					qk = qk;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					goto end_IL_35a0;
				}
			}
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				_ = (Struct2)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo_, (string[])(object)Class5.Default, out object_4);
				goto end_IL_35a0;
			}
			end_IL_35a0:;
		}
		_ = (Struct2)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null), array4, (Type)null, (Type[])null, array5);
		class15 = class15;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class36 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class36.W(bindingFlags, array4, null, array3, null);
					class6 = class6;
					_ = (GClass2)(object)Class5.Default;
					class10 = class10;
				}
				catch
				{
					qk = qk;
				}
			}
		}
		finally
		{
			gClass4 = null;
			goto IL_36fc;
		}
		IL_1d8b:
		if (num == 0 && num == 0)
		{
			try
			{
				gClass4 = null;
			}
			finally
			{
				_ = (Class0)(object)Class5.Default;
				goto IL_1dab;
			}
		}
		goto IL_1dab;
		IL_1dab:
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked(num / checked(unchecked((nuint)(UIntPtr)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default)) - unchecked((nuint)default(UIntPtr)))) != 0)
			{
				gClass3 = gClass3;
			}
			try
			{
				bindingFlags = default(BindingFlags);
				class4 = (Class4)(object)((Class7)null).W(bindingFlags, array4, type, array3, (ParameterModifier[])null);
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
				}
			}
			class4 = class4;
		}
		try
		{
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					class8 = null;
				}
				finally
				{
					class15 = null;
					_ = (Class9)@class.t(obj, null, (CultureInfo)(object)Class5.Default);
					Class7 obj50 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj50.e(bindingFlags, array, array3, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, array2, null, null), null, array3, array5));
					_ = (Class4)@class.t(obj, type, cultureInfo_);
					continue;
				}
			}
		}
		while ((object)@class.W((BindingFlags)Class5.Default, null, type, null, null) != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class6 = class6;
					_ = (Struct2)Class5.Default;
					qk = qk;
				}
				while ((object)Class5.Default != null);
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				_ = (Class6)(object)Class5.Default;
			}
			goto IL_1f88;
		}
		IL_390b:
		checked
		{
			do
			{
				if (num * unchecked((nuint)(UIntPtr)Class5.Default) != 0)
				{
					do
					{
						qk = null;
					}
					while (obj != null);
					continue;
				}
				try
				{
					gClass = null;
				}
				catch
				{
					gClass = gClass;
					gClass2 = null;
					gClass3 = null;
				}
			}
			while ((object)Class5.Default != null);
			return;
		}
		IL_11ce:
		if (num == 0 && (UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, obj, cultureInfo_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				@struct = @struct;
				gClass3 = gClass3;
				class10 = class10;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)(object)((Class7)null).t(bindingFlags, array2, (object)Class5.Default, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array4, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				_ = (Class4)((Class7)(object)Class5.Default).t(obj, type, null);
			}
		}
		while ((object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array3, array5) != null)
		{
			do
			{
				try
				{
					class6 = null;
				}
				catch
				{
					gClass = null;
					@class = @class;
					qk = (Qk7)(object)@class.j(bindingFlags, array, ref reference, array5, null, (string[])(object)Class5.Default, out *(object*)null);
				}
			}
			while (obj != null);
		}
		class10 = null;
		gClass2 = null;
		gClass2 = gClass2;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				class7 = class7;
			}
			else
			{
				class17 = null;
				class17 = null;
				_ = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 class37 = @class;
				BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_9 = (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, null, (Type[])(object)Class5.Default, array5));
				Class7 class38 = @class;
				object object_13 = obj;
				Type type_3 = type;
				BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
				object object_14 = obj;
				Class7 class39 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)null).W(bindingFlags_29, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])(object)class37.e(bindingFlags_30, methodBase_9, (Type[])class38.t(object_13, type_3, (CultureInfo)(object)((Class7)null).t(bindingFlags_31, fieldInfo_5, object_14, (CultureInfo)(object)((Class7)(object)class39.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null))), null));
				class10 = class10;
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (GClass1)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array5, cultureInfo_, string_, out *(object*)null);
				}
				finally
				{
					struct2 = struct2;
					goto end_IL_1470;
				}
				end_IL_1470:;
			}
			catch
			{
				num = default(UIntPtr);
				checked
				{
					if (num - unchecked((nuint)(UIntPtr)Class5.Default) - num == 0)
					{
						@class = @class;
					}
					else
					{
						class17 = class17;
						gClass = gClass;
						gClass3 = (GClass1)(object)Class5.Default;
					}
				}
			}
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class0)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_), (CultureInfo)@class.t(null, null, cultureInfo_), (string[])((Class7)null).t(obj, (Type)(object)((Class7)null).j((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array2, (object)null, (CultureInfo)null), array, ref reference, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)@class.W((BindingFlags)Class5.Default, array4, type, null, array5)), cultureInfo_), out object_4);
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
				if (num == 0)
				{
					qk = qk;
					class8 = class8;
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				gClass4 = (GClass0)(object)@class.e(bindingFlags, array, array3, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_165d;
		}
		IL_0636:
		do
		{
			gClass3 = null;
			gClass3 = null;
			_ = (GClass0)(object)Class5.Default;
		}
		while (obj != null);
		try
		{
			try
			{
				gClass3 = null;
			}
			finally
			{
				_ = (GClass2)@class.t(obj, type, (CultureInfo)((Class7)null).t((object)null, (Type)null, cultureInfo_));
				BindingFlags bindingFlags_32 = bindingFlags;
				Class7 obj58 = (Class7)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array5);
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				GClass3 obj59 = (GClass3)(object)((Class7)null).e(bindingFlags_32, (MethodBase[])null, (Type[])(object)obj58.e((BindingFlags)class40.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])null), array2, Class5.Default, cultureInfo_), (MethodBase[])(object)Class5.Default, array3, array5), array5);
				gClass = gClass;
				gClass = obj59;
				class8 = class8;
				goto end_IL_0652;
			}
			end_IL_0652:;
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)@class.j(bindingFlags, array, ref reference, null, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)(object)Class5.Default).t(((Class7)null).t(obj, type, (CultureInfo)null), null, cultureInfo_));
			}
			else
			{
				_ = (Struct2)Class5.Default;
			}
		}
		UIntPtr num16 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num16) * (num + (num - num))) == 0)
		{
			gClass3 = (GClass1)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null);
			_ = (Class7)(object)Class5.Default;
			Class7 class41 = @class;
			BindingFlags bindingFlags_33 = bindingFlags;
			bindingFlags = default(BindingFlags);
			ref object[] object_15 = ref *(object[]*)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)@class.e(bindingFlags, array, array3, array5), cultureInfo_), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out object_4)).W(bindingFlags, null, null, array3, (ParameterModifier[])(object)Class5.Default), (Type[])null, array5);
			ParameterModifier[] parameterModifier_8 = array5;
			Class7 obj61 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)(object)class41.j(bindingFlags_33, null, ref object_15, parameterModifier_8, cultureInfo_, string_, out *(object*)obj61.t(bindingFlags, array2, null, cultureInfo_))).t(bindingFlags, null, obj, null);
			_ = (Struct1)Class5.Default;
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				Class7 class42 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class42.W(bindingFlags, array4, null, (Type[])(object)Class5.Default, array5) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					class15 = null;
					class15 = class15;
				}
			}
			finally
			{
				do
				{
					gClass3 = (GClass1)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
				continue;
			}
		}
		struct2 = default(Struct2);
		do
		{
			_ = (Class2)(object)((Class7)null).t(bindingFlags, array2, ((Class7)(object)Class5.Default).t(obj, type, null), (CultureInfo)null);
		}
		while (obj != null);
		if (num == 0)
		{
			try
			{
				_ = (GClass3)(object)((Class7)null).e(bindingFlags, array, array3, array5);
				Class7 obj62 = (Class7)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, (CultureInfo)null, string_, out object_4);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj62.t(bindingFlags, null, obj, (CultureInfo)@class.t(Class5.Default, (Type)(object)@class.t(bindingFlags, array2, obj, null), null));
				class8 = class8;
			}
			catch
			{
				qk = qk;
			}
		}
		else
		{
			try
			{
				Class7 obj64 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if (checked(unchecked((nuint)(UIntPtr)obj64.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default)) - num) == 0)
				{
					_ = (Struct1)@class.W((BindingFlags)Class5.Default, array4, type, array3, array5);
					gClass4 = (GClass0)(object)@class.t((BindingFlags)Class5.Default, array2, @class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null), null);
					gClass4 = gClass4;
					_ = (GClass0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array5, null, string_, out *(object*)Class5.Default), (Type)(object)Class5.Default, (Type[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_), array5);
					Class7 class43 = @class;
					BindingFlags bindingFlags_34 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_6 = array2;
					object object_16 = obj;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class43.t(bindingFlags_34, fieldInfo_6, object_16, (CultureInfo)(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)null));
				}
				else
				{
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class44.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])(object)Class5.Default);
				}
			}
			catch
			{
				do
				{
					Class7 class45 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class45.W(bindingFlags, null, type, array3, null);
				}
				while ((object)Class5.Default != null);
			}
		}
		while (obj != null)
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			finally
			{
				gClass4 = null;
				struct2 = struct2;
				continue;
			}
		}
		if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default == 0)
		{
			while (obj != null)
			{
				struct2 = default(Struct2);
			}
		}
		if (num == 0)
		{
			if ((UIntPtr)((Class7)null).t(obj, type, (CultureInfo)null) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			else
			{
				do
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_35 = bindingFlags;
					FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
					object object_17 = Class5.Default;
					Class7 obj66 = (Class7)@class.t(null, type, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.t(@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array5)), type, cultureInfo_), array, ref reference, null, cultureInfo_, string_, out *(object*)Class5.Default));
					BindingFlags bindingFlags_36 = (BindingFlags)@class.t(Class5.Default, type, cultureInfo_);
					PropertyInfo[] propertyInfo_6 = array4;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)((Class7)null).t(bindingFlags_35, fieldInfo_7, object_17, (CultureInfo)(object)obj66.W(bindingFlags_36, propertyInfo_6, null, array3, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo_, (string[])null, out object_4)));
				}
				while ((object)((Class7)null).W(bindingFlags, array4, type, array3, (ParameterModifier[])null) != null);
			}
		}
		if ((UIntPtr)((Class7)null).W(bindingFlags, array4, type, (Type[])(object)Class5.Default, array5) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					gClass = null;
					_ = (GClass1)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)((Class7)@class.t(null, type, cultureInfo_)).W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array3, null), null, string_, out *(object*)null));
				}
				while (obj != null);
			}
			else
			{
				while (obj != null)
				{
					Class7 obj67 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_);
					bindingFlags = default(BindingFlags);
					Class7 obj68 = (Class7)(object)obj67.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, array3, array5), null, string_, out *(object*)null);
					ref object[] object_18 = ref reference;
					ParameterModifier[] parameterModifier_9 = array5;
					Class7 obj69 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj68.j(default(BindingFlags), null, ref object_18, parameterModifier_9, (CultureInfo)(object)obj69.j(bindingFlags, array, ref *(object[]*)null, array5, null, string_, out object_4), (string[])(object)Class5.Default, out *(object*)null);
				}
			}
		}
		else
		{
			_ = (Class9)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array5);
		}
		_ = (Class4)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, null, array5);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Struct1)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, array5), array5);
			}
			while (obj != null);
		}
		_ = (Class2)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
		}
		try
		{
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class46.W(bindingFlags, null, (Type)(object)@class.t(bindingFlags, null, obj, cultureInfo_), array3, (ParameterModifier[])(object)Class5.Default);
		}
		catch
		{
			class10 = class10;
		}
		try
		{
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			_ = (Class10)(object)Class5.Default;
			Class7 class47 = @class;
			Class7 class48 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class6)(object)class47.j((BindingFlags)class48.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null), (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array5), out object_4);
			@struct = @struct;
			goto IL_11ce;
		}
	}
}
