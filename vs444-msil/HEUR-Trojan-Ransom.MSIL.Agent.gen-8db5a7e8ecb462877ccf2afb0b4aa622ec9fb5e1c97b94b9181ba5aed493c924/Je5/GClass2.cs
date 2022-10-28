using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using A_0024r;
using Dn7;
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

namespace Je5;

public class GClass2
{
	internal static byte[] smethod_0(byte[] byte_0)
	{
		byte[] o = GClass0.O;
		byte[] byte_ = o;
		using Aes aes = smethod_2();
		if (aes == null)
		{
			return new byte[0];
		}
		smethod_1(aes, o, byte_);
		ICryptoTransform icryptoTransform_ = aes.CreateDecryptor(aes.Key, aes.IV);
		return GClass3.smethod_0(byte_0, icryptoTransform_);
	}

	internal static void smethod_1(Aes aes_0, byte[] byte_0, byte[] byte_1)
	{
		aes_0.Key = byte_0;
		aes_0.IV = byte_1;
		aes_0.Mode = CipherMode.CBC;
		aes_0.Padding = PaddingMode.None;
	}

	internal static Aes smethod_2()
	{
		return Aes.Create("AES");
	}

	unsafe static void smethod_3()
	{
		Class6 @class = @class;
		@class = @class;
		_ = (Class0)(object)Class5.Default;
		_ = (Qk7)(object)Class5.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		object obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		MethodBase[] methodBase_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array4);
		ref object[] object_4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		BindingFlags bindingFlags;
		while (true)
		{
			Class7 obj = (Class7)(object)Class5.Default;
			Class7 obj2 = (Class7)(object)Class5.Default;
			obj3 = null;
			Type type_ = type;
			cultureInfo = cultureInfo;
			object object_ = obj2.t(obj3, type_, cultureInfo);
			class2 = class2;
			Class7 class3 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_ = bindingFlags;
			BindingFlags bindingFlags_2 = bindingFlags;
			array = array;
			Class7 obj4 = (Class7)(object)((Class7)null).t(bindingFlags_2, array, obj3, cultureInfo);
			BindingFlags bindingFlags_3 = bindingFlags;
			methodBase_ = (MethodBase[])(object)Class5.Default;
			Type[] type_2 = array2;
			Class7 class4 = class2;
			BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
			Class7 class5 = class2;
			BindingFlags bindingFlags_5 = (BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), obj3, cultureInfo);
			ref object[] object_2 = ref *(object[]*)Class5.Default;
			array3 = array3;
			MethodBase[] methodBase_2 = (MethodBase[])(object)class5.j(bindingFlags_5, methodBase_, ref object_2, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			Class7 class6 = class2;
			BindingFlags bindingFlags_6 = bindingFlags;
			FieldInfo[] fieldInfo_ = array;
			Class7 class7 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_7 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
			Class7 class8 = class2;
			BindingFlags bindingFlags_8 = bindingFlags;
			Type type_3 = type;
			Type[] type_4 = array2;
			Class7 class9 = class2;
			BindingFlags bindingFlags_9 = bindingFlags;
			Type type_5 = type;
			Class7 class10 = class2;
			BindingFlags bindingFlags_10 = (BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type, null, array3);
			Class7 class11 = class2;
			bindingFlags = default(BindingFlags);
			ref object[] object_3 = ref *(object[]*)class6.t((BindingFlags)((Class7)null).t(bindingFlags_6, fieldInfo_, (object)class7.e(bindingFlags_7, methodBase_3, (Type[])(object)class8.W(bindingFlags_8, null, type_3, type_4, (ParameterModifier[])(object)class9.W(bindingFlags_9, null, type_5, null, (ParameterModifier[])((Class7)(object)class10.e(bindingFlags_10, (MethodBase[])(object)((Class7)(object)class11.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo)).t(bindingFlags, array, obj3, cultureInfo), array2, array3)).t(obj3, type, (CultureInfo)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.t(bindingFlags, array, ((Class7)null).W(bindingFlags, array4, type, array2, array3), null), obj3, cultureInfo)))), null), (CultureInfo)(object)Class5.Default), (FieldInfo[])class2.t(obj3, null, cultureInfo), obj3, (CultureInfo)(object)Class5.Default);
			CultureInfo cultureInfo_ = cultureInfo;
			Class7 class12 = class2;
			BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_ = array4;
			Type type_6 = (Type)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null);
			Class7 class13 = class2;
			BindingFlags bindingFlags_12 = bindingFlags;
			MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
			object_4 = ref *(object[]*)null;
			CultureInfo cultureInfo_2 = cultureInfo;
			string[] string_ = array5;
			reference = ref reference;
			array5 = (string[])(object)class12.W(bindingFlags_11, propertyInfo_, type_6, (Type[])(object)((Class7)(object)class13.j(bindingFlags_12, methodBase_4, ref object_4, null, cultureInfo_2, string_, out reference)).t(bindingFlags, array, obj3, (CultureInfo)(object)Class5.Default), null);
			Type type_7 = (Type)(object)class3.t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).t(bindingFlags_, (FieldInfo[])((Class7)null).t((object)obj4.e(bindingFlags_3, methodBase_, type_2, (ParameterModifier[])(object)class4.j(bindingFlags_4, methodBase_2, ref object_3, null, cultureInfo_, array5, out *(object*)null)), (Type)null, cultureInfo), obj3, cultureInfo), obj3, cultureInfo);
			Class7 class14 = class2;
			BindingFlags bindingFlags_13 = bindingFlags;
			Type[] type_8 = array2;
			Class7 class15 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_14 = bindingFlags;
			Type[] type_9 = array2;
			Class7 obj5 = (Class7)(object)class2.e(bindingFlags, methodBase_, array2, null);
			bindingFlags = default(BindingFlags);
			if (obj.t(object_, type_7, (CultureInfo)(object)class14.e(bindingFlags_13, methodBase_, type_8, (ParameterModifier[])(object)class15.e(bindingFlags_14, methodBase_, type_9, (ParameterModifier[])(object)obj5.e(bindingFlags, methodBase_, null, array3)))) == null)
			{
				break;
			}
			Class7 obj6 = (Class7)(object)Class5.Default;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_15 = bindingFlags;
			BindingFlags bindingFlags_16 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array4;
			array2 = array2;
			array4 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags_16, propertyInfo_2, (Type)null, array2, (ParameterModifier[])null);
			PropertyInfo[] propertyInfo_3 = array4;
			type = type;
			_003CModule_003E = (_003CModule_003E)(object)obj6.W(bindingFlags_15, propertyInfo_3, type, array2, null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		UIntPtr num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		GClass3 gClass;
		try
		{
		}
		finally
		{
			try
			{
				gClass = null;
				gClass = gClass;
			}
			catch
			{
				class2 = class2;
				qk = qk;
				qk = qk;
			}
			finally
			{
				num = (UIntPtr)class2.t(obj3, type, cultureInfo);
				if (num == 0)
				{
					@struct = @struct;
					@struct = @struct;
				}
				else
				{
					_ = (Class0)(object)class2.j(bindingFlags, methodBase_, ref object_4, null, cultureInfo, null, out reference);
					Class7 class16 = class2;
					Class7 class17 = class2;
					BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_4 = array4;
					Type type_10 = type;
					Type[] type_11 = (Type[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class16.W((BindingFlags)class17.W(bindingFlags_17, propertyInfo_4, type_10, type_11, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)Class5.Default)), array4, (Type)(object)Class5.Default, array2, array3);
				}
				goto IL_05d4;
			}
		}
		IL_47a0:
		_ = (GClass2)(object)Class5.Default;
		try
		{
			_ = (Class9)(object)Class5.Default;
			return;
		}
		catch
		{
			try
			{
				@class = null;
				return;
			}
			catch
			{
				@class = @class;
				qk = qk;
				_ = (Class0)(object)class2.j((BindingFlags)((Class7)((Class7)null).t(obj3, type, cultureInfo)).j((BindingFlags)Class5.Default, methodBase_, ref object_4, null, null, array5, out *(object*)Class5.Default), methodBase_, ref object_4, array3, null, (string[])(object)((Class7)(object)class2.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default)).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), out reference);
				Class7 class18 = class2;
				Class7 obj8 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)((Class7)(object)class18.j(default(BindingFlags), (MethodBase[])((Class7)(object)obj8.W(bindingFlags, null, type, array2, array3)).t(null, null, null), ref *(object[]*)null, array3, cultureInfo, null, out reference)).t(bindingFlags, array, obj3, cultureInfo);
				return;
			}
		}
		IL_10c8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class19);
		while (obj3 != null)
		{
			class19 = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					Class7 class20 = class2;
					bindingFlags = default(BindingFlags);
					Struct1 obj11 = (Struct1)class20.W(bindingFlags, array4, (Type)(object)class2.e(bindingFlags, methodBase_, array2, array3), array2, (ParameterModifier[])(object)Class5.Default);
					struct2 = struct2;
					struct2 = obj11;
				}
				finally
				{
					_ = (Class0)(object)((Class7)class2.t(Class5.Default, (Type)class2.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), cultureInfo)).e(bindingFlags, null, null, null);
					continue;
				}
			}
			while (obj3 != null);
		}
		else
		{
			gClass2 = gClass2;
		}
		Class7 class21 = class2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class21.W(bindingFlags, (PropertyInfo[])(object)class2.W(bindingFlags, array4, (Type)(object)Class5.Default, array2, (ParameterModifier[])class2.t(obj3, type, cultureInfo)), type, array2, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class28);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class22);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class29);
		if (num == 0)
		{
			try
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
				}
				catch
				{
					class22 = class22;
				}
			}
			catch
			{
				do
				{
					BindingFlags bindingFlags_18 = (BindingFlags)class2.t(obj3, type, cultureInfo);
					Class7 class23 = class2;
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).j(bindingFlags_18, (MethodBase[])(object)class23.e(default(BindingFlags), null, (Type[])(object)class24.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default), null), ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array5, out reference);
				}
				while (obj3 != null);
			}
		}
		else
		{
			Class7 obj14 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_19 = bindingFlags;
			MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
			Type[] type_12 = (Type[])(object)Class5.Default;
			Class7 obj15 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_20 = (BindingFlags)class2.W(bindingFlags, array4, type, null, null);
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_6 = (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, cultureInfo, (string[])null, out reference);
			ParameterModifier[] parameterModifier_ = array3;
			CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
			Class7 class25 = class2;
			BindingFlags bindingFlags_21 = bindingFlags;
			ParameterModifier[] parameterModifier_2 = array3;
			Class7 class26 = class2;
			bindingFlags = default(BindingFlags);
			Class7 obj16 = (Class7)(object)class25.j(bindingFlags_21, methodBase_, ref object_4, parameterModifier_2, null, (string[])(object)class26.W(bindingFlags, array4, type, array2, array3), out reference);
			BindingFlags bindingFlags_22 = bindingFlags;
			ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)class2.W(bindingFlags, array4, type, array2, array3);
			Class7 class27 = class2;
			BindingFlags bindingFlags_23 = (BindingFlags)class2.t(obj3, (Type)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default);
			object object_5 = class2.t((BindingFlags)((Class7)null).t(obj3, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, obj3, cultureInfo);
			Class7 obj17 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W((BindingFlags)obj14.e(bindingFlags_19, methodBase_5, type_12, (ParameterModifier[])(object)obj15.j(bindingFlags_20, methodBase_6, ref object_4, parameterModifier_, cultureInfo_3, (string[])(object)obj16.j(bindingFlags_22, null, ref object_4, parameterModifier_3, (CultureInfo)(object)class27.t(bindingFlags_23, null, object_5, (CultureInfo)(object)obj17.t(bindingFlags, array, null, null)), array5, out *(object*)Class5.Default), out *(object*)null)), (PropertyInfo[])(object)class2.j(bindingFlags, null, ref object_4, array3, null, array5, out reference), (Type)(object)Class5.Default, (Type[])null, array3) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(obj3, (Type)(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
				{
					class28 = null;
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			else
			{
				try
				{
					class29 = class29;
					class28 = null;
				}
				catch
				{
					BindingFlags bindingFlags_24 = (BindingFlags)Class5.Default;
					Type[] type_13 = array2;
					BindingFlags bindingFlags_25 = bindingFlags;
					ParameterModifier[] parameterModifier_4 = array3;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)((Class7)null).e(bindingFlags_24, methodBase_, type_13, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_25, methodBase_, ref *(object[]*)null, parameterModifier_4, (CultureInfo)null, (string[])(object)((Class7)null).W(bindingFlags, array4, (Type)(object)class2.t((BindingFlags)class2.t(bindingFlags, null, obj3, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref object_4, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference)), array, ((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])null, (ParameterModifier[])(object)class2.W(bindingFlags, array4, type, null, array3)), null), (Type[])null, (ParameterModifier[])null), out reference));
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class30);
		if (num == 0)
		{
			_ = (GClass0)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
		}
		else
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = Class5.Default;
				}
				finally
				{
					struct2 = struct2;
					goto IL_175b;
				}
			}
			_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_4, array3, (CultureInfo)null, (string[])(object)Class5.Default, out reference), (Type[])(object)((Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, array, obj3, (CultureInfo)null)).W(default(BindingFlags), array4, null, array2, array3), array3);
			class30 = class30;
			class30 = class30;
			_ = (Class0)(object)Class5.Default;
			_ = (Struct1)Class5.Default;
		}
		goto IL_175b;
		IL_05d4:
		_ = (Class2)(object)Class5.Default;
		try
		{
			do
			{
				try
				{
					_ = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, Class5.Default, cultureInfo);
					gClass2 = gClass2;
				}
				finally
				{
					_003CModule_003E = null;
					continue;
				}
			}
			while (obj3 != null);
		}
		finally
		{
			qk = null;
			goto IL_062c;
		}
		IL_062c:
		Class8 obj19 = (Class8)(object)Class5.Default;
		class29 = class29;
		class29 = obj19;
		GClass2 gClass3 = gClass3;
		gClass3 = gClass3;
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (Class4)(object)class2.j(bindingFlags, methodBase_, ref object_4, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref object_4, array3, cultureInfo, (string[])null, out reference), (CultureInfo)(object)Class5.Default, null, out reference);
		if ((UIntPtr)class2.t(obj3, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class29 = class29;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				UIntPtr num2 = (UIntPtr)((Class7)null).W((BindingFlags)class2.j(bindingFlags, null, ref object_4, array3, cultureInfo, null, out reference), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, (ParameterModifier[])null);
				Class7 class31 = class2;
				BindingFlags bindingFlags_26 = (BindingFlags)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array5, out reference)).W(bindingFlags, array4, type, array2, array3), out reference), array3, null, (string[])(object)Class5.Default, out reference), null, cultureInfo);
				ParameterModifier[] parameterModifier_5 = array3;
				CultureInfo cultureInfo_4 = (CultureInfo)(object)Class5.Default;
				string[] string_2 = (string[])(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array3), array4, type, (Type[])null, (ParameterModifier[])null);
				Class7 class32 = class2;
				BindingFlags bindingFlags_27 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Class7 obj20 = (Class7)(object)class31.j(bindingFlags_26, methodBase_, ref object_4, parameterModifier_5, cultureInfo_4, string_2, out *(object*)class32.W(bindingFlags_27, (PropertyInfo[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array, obj3, (CultureInfo)null)).t((BindingFlags)Class5.Default, array, obj3, cultureInfo), (Type)(object)class2.j(bindingFlags, (MethodBase[])(object)class2.W((BindingFlags)Class5.Default, array4, type, (Type[])(object)Class5.Default, null), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null), (Type[])(object)Class5.Default, null));
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)num2 / checked(unchecked((nuint)(UIntPtr)obj20.W(bindingFlags, array4, type, array2, null)) * num)) + unchecked((nuint)(UIntPtr)class2.t(bindingFlags, array, obj3, cultureInfo)) == 0)
					{
						@struct = @struct;
					}
				}
			}
		}
		_ = (Class8)(object)Class5.Default;
		_ = (Struct2)class2.t(bindingFlags, array, Class5.Default, cultureInfo);
		UIntPtr num3 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class39);
		checked
		{
			if (unchecked((nuint)num3) - num == 0)
			{
				Class7 class33 = class2;
				unchecked
				{
					BindingFlags bindingFlags_28 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default);
					FieldInfo[] fieldInfo_2 = array;
					Class7 class34 = class2;
					BindingFlags bindingFlags_29 = bindingFlags;
					Class7 class35 = class2;
					BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
					ref object[] object_6 = ref *(object[]*)Class5.Default;
					Class7 class36 = class2;
					Class7 class37 = class2;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_7 = (MethodBase[])(object)((Class7)(object)class37.t(bindingFlags, array, obj3, cultureInfo)).W(bindingFlags, array4, type, array2, null);
					BindingFlags bindingFlags_31 = bindingFlags;
					CultureInfo cultureInfo_5 = cultureInfo;
					Class7 class38 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class33.t((BindingFlags)((Class7)null).t(bindingFlags_28, fieldInfo_2, (object)class34.W(bindingFlags_29, (PropertyInfo[])(object)class35.j(bindingFlags_30, methodBase_, ref object_6, (ParameterModifier[])(object)class36.e(default(BindingFlags), methodBase_7, (Type[])(object)((Class7)null).j(bindingFlags_31, methodBase_, ref object_4, (ParameterModifier[])null, cultureInfo_5, (string[])(object)class38.j(bindingFlags, null, ref object_4, array3, cultureInfo, array5, out reference), out reference), null), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference), (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array3)), array, class2.e(bindingFlags, null, array2, array3), cultureInfo);
				}
			}
			do
			{
				if (num + (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array3)) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null);
			_ = (GClass1)(object)Class5.Default;
			while ((object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo) != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
			try
			{
				_ = (Struct1)class2.t(bindingFlags, null, obj3, (CultureInfo)(object)Class5.Default);
			}
			finally
			{
				try
				{
					class39 = class39;
					class39 = class39;
				}
				finally
				{
					try
					{
						_ = (GClass0)(object)Class5.Default;
						_ = (Class0)(object)Class5.Default;
					}
					finally
					{
						_ = (Struct1)Class5.Default;
						goto IL_0c58;
					}
				}
			}
		}
		IL_3949:
		UIntPtr num4 = num;
		num = default(UIntPtr);
		if ((nuint)num4 / num == 0)
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					Class7 class40 = class2;
					bindingFlags = default(BindingFlags);
					class28 = (Class4)(object)class40.W(bindingFlags, array4, type, array2, null);
				}
				else
				{
					gClass3 = gClass3;
					class19 = class19;
					gClass2 = null;
				}
			}
			while (obj3 != null);
		}
		Class7 obj22 = (Class7)class2.t(null, null, null);
		BindingFlags bindingFlags_32 = (BindingFlags)class2.W(bindingFlags, array4, null, array2, array3);
		ParameterModifier[] parameterModifier_6 = array3;
		Class7 class41 = class2;
		bindingFlags = default(BindingFlags);
		class29 = (Class8)(object)obj22.j(bindingFlags_32, methodBase_, ref object_4, parameterModifier_6, null, (string[])(object)class41.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out reference), out reference), (string[])(object)Class5.Default, out *(object*)null), out reference);
		try
		{
			_ = (Class9)(object)Class5.Default;
		}
		catch
		{
			if (num == 0)
			{
				@struct = @struct;
			}
		}
		finally
		{
			if (num == 0)
			{
				do
				{
					Class7 obj24 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj24.j(bindingFlags, methodBase_, ref object_4, array3, null, null, out *(object*)Class5.Default);
				}
				while (obj3 != null);
			}
			else
			{
				class19 = class19;
				@struct = default(Struct2);
				gClass = gClass;
				object object_7 = Class5.Default;
				Class7 class42 = class2;
				BindingFlags bindingFlags_33 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
				Class7 class43 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)((Class7)null).t(object_7, (Type)(object)class42.e(bindingFlags_33, methodBase_8, (Type[])(object)class43.t(bindingFlags, null, null, null), array3), (CultureInfo)null);
			}
			goto IL_3ba1;
		}
		IL_38f1:
		GClass0 gClass4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class44);
		try
		{
			_ = (Class9)(object)Class5.Default;
		}
		finally
		{
			try
			{
				class44 = class44;
				gClass4 = gClass4;
				class28 = null;
				class19 = (Class0)(object)Class5.Default;
			}
			finally
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					class19 = null;
					goto IL_3949;
				}
			}
		}
		IL_1f2f:
		Class7 class45 = class2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).t((object)null, (Type)(object)class45.W(bindingFlags, array4, type, array2, null), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			_ = (Class6)(object)Class5.Default;
			_ = (Class7)(object)Class5.Default;
		}
		else
		{
			_ = (Class0)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_4, (ParameterModifier[])null, cultureInfo, array5, out reference)).W(bindingFlags, array4, (Type)(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default), methodBase_, null, array3), methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, array3), cultureInfo, array5, out reference), array2, array3);
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass4 = (GClass0)(object)Class5.Default;
				gClass4 = gClass4;
			}
			else
			{
				Class7 class46 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)class46.t(((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])class2.t(null, type, cultureInfo), (Type[])null, array3)).W(bindingFlags, array4, type, null, array3), (Type)(object)class2.e(bindingFlags, null, (Type[])(object)class2.e((BindingFlags)Class5.Default, null, null, array3), array3), null)).t(bindingFlags, array, Class5.Default, cultureInfo);
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
				gClass2 = gClass2;
				class28 = null;
				struct2 = default(Struct1);
				struct2 = struct2;
				_ = (Class10)(object)Class5.Default;
				goto end_IL_212a;
			}
			end_IL_212a:;
		}
		finally
		{
			Class7 class47 = class2;
			BindingFlags bindingFlags_34 = bindingFlags;
			Class7 class48 = class2;
			BindingFlags bindingFlags_35 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_9 = (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, methodBase_, array2, null), (Type[])(object)Class5.Default, array3);
			ParameterModifier[] parameterModifier_7 = array3;
			bindingFlags = default(BindingFlags);
			ref object[] object_8 = ref *(object[]*)class48.j(bindingFlags_35, methodBase_9, ref *(object[]*)null, parameterModifier_7, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_4, (ParameterModifier[])null, (CultureInfo)null, array5, out *(object*)null), array5, out reference);
			ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)class2.e(bindingFlags, null, array2, array3);
			CultureInfo cultureInfo_6 = cultureInfo;
			string[] string_3 = (string[])(object)Class5.Default;
			BindingFlags bindingFlags_36 = bindingFlags;
			Class7 obj26 = (Class7)(object)Class5.Default;
			Class7 class49 = class2;
			Class7 obj27 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			ref object[] object_9 = ref *(object[]*)obj26.t(default(BindingFlags), null, obj3, (CultureInfo)(object)((Class7)class49.t(obj27.e(bindingFlags, methodBase_, array2, array3), type, cultureInfo)).e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default));
			Class7 class50 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class6)((Class7)(object)((Class7)null).e((BindingFlags)class47.j(bindingFlags_34, methodBase_, ref object_8, parameterModifier_8, cultureInfo_6, string_3, out *(object*)((Class7)null).j(bindingFlags_36, methodBase_, ref object_9, (ParameterModifier[])(object)class50.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, null), (CultureInfo)(object)class2.e(bindingFlags, methodBase_, array2, array3), (string[])(object)Class5.Default, out reference)), (MethodBase[])null, array2, array3)).t(obj3, type, null);
			_ = (Class7)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array3);
			goto IL_23ab;
		}
		IL_1de0:
		_ = (Class8)(object)Class5.Default;
		while (obj3 != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					class30 = null;
				}
				while (obj3 != null);
				continue;
			}
			try
			{
				_ = (Class7)(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, null, array5, out *(object*)null);
			}
			catch
			{
				class39 = class39;
			}
		}
		try
		{
			class39 = class39;
		}
		finally
		{
			try
			{
				struct2 = default(Struct1);
				struct2 = struct2;
			}
			finally
			{
				while (true)
				{
					Class7 obj29 = (Class7)(object)class2.t(bindingFlags, array, null, cultureInfo);
					BindingFlags bindingFlags_37 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_5 = array4;
					Type type_14 = (Type)(object)Class5.Default;
					Class7 class51 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_38 = bindingFlags;
					Type[] type_15 = array2;
					BindingFlags bindingFlags_39 = bindingFlags;
					Class7 obj30 = (Class7)class2.t(obj3, type, cultureInfo);
					bindingFlags = default(BindingFlags);
					if ((object)obj29.W(bindingFlags_37, propertyInfo_5, type_14, null, (ParameterModifier[])(object)class51.W(bindingFlags_38, null, null, type_15, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_39, (PropertyInfo[])(object)obj30.e(bindingFlags, null, array2, array3), type, array2, (ParameterModifier[])null))) != null)
					{
						class22 = null;
						continue;
					}
					break;
				}
				goto IL_1f2f;
			}
		}
		IL_2eeb:
		try
		{
			try
			{
				gClass = gClass;
			}
			finally
			{
				gClass2 = (GClass1)(object)Class5.Default;
				goto end_IL_2eec;
			}
			end_IL_2eec:;
		}
		finally
		{
			if (num == 0)
			{
				if (checked(num * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array4, (Type)((Class7)(object)Class5.Default).t(null, type, null), array2, (ParameterModifier[])(object)Class5.Default))) == 0)
				{
					class29 = null;
					_ = (Class10)((Class7)null).t(obj3, type, cultureInfo);
					Class7 obj31 = (Class7)(object)class2.W((BindingFlags)class2.j(bindingFlags, methodBase_, ref *(object[]*)class2.t(obj3, type, (CultureInfo)(object)class2.j((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default), array, obj3, cultureInfo), methodBase_, ref object_4, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference)), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out *(object*)null), array4, null, array2, array3);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj31.W(bindingFlags, array4, null, null, null);
					_ = (GClass1)(object)Class5.Default;
				}
				else
				{
					_ = (Class8)(object)((Class7)((Class7)null).t(obj3, type, cultureInfo)).W(bindingFlags, array4, type, null, array3);
				}
			}
			else if (num == 0)
			{
				struct2 = default(Struct1);
			}
			goto IL_30c5;
		}
		IL_2d51:
		_ = (Class10)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, null);
		while (obj3 != null)
		{
			_ = (Struct1)Class5.Default;
			_ = (GClass3)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref object_4, array3, (CultureInfo)(object)Class5.Default, (string[])class2.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), out reference);
			_ = (Class8)(object)Class5.Default;
		}
		_ = (GClass1)(object)Class5.Default;
		_ = (Class8)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo);
		try
		{
			if (num / checked(num * num) == 0)
			{
				checked
				{
					if (num + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						bindingFlags = default(BindingFlags);
						_ = (GClass3)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array3);
						_ = (Class6)(object)class2.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default);
						@class = @class;
						class30 = class30;
					}
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		finally
		{
			while (obj3 != null)
			{
				_ = (GClass2)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)null, array3, cultureInfo, array5, out reference);
			}
			goto IL_2eeb;
		}
		IL_1a27:
		try
		{
			try
			{
				class28 = class28;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class52 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_40 = bindingFlags;
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])class2.t(null, type, cultureInfo);
					CultureInfo cultureInfo_7 = (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, methodBase_, array2, array3);
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class52.j(bindingFlags_40, methodBase_, ref *(object[]*)null, parameterModifier_9, cultureInfo_7, (string[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3), out reference);
				}
				else
				{
					qk = qk;
					_ = (Class4)(object)Class5.Default;
					class28 = class28;
					gClass3 = gClass3;
				}
			}
		}
		catch
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			while ((object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo) != null);
		}
		_ = (Struct1)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, (ParameterModifier[])null);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				try
				{
					Class7 class53 = class2;
					bindingFlags = default(BindingFlags);
					class19 = (Class0)(object)class53.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)class2.e(bindingFlags, methodBase_, array2, array3), (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_1b7d;
				}
				end_IL_1b7d:;
			}
			catch
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
					gClass = null;
					Class7 class54 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class54.t(bindingFlags, array, obj3, cultureInfo);
				}
				finally
				{
					BindingFlags bindingFlags_41 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)((Class7)null).t(bindingFlags_41, fieldInfo_3, (object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null);
					goto end_IL_1be5;
				}
				end_IL_1be5:;
			}
		}
		try
		{
			while (obj3 != null)
			{
				num = default(UIntPtr);
				nuint num5 = num;
				num = default(UIntPtr);
				if (num5 / num == 0)
				{
					BindingFlags bindingFlags_42 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_10 = (MethodBase[])class2.t(null, type, cultureInfo);
					Class7 class55 = class2;
					Class7 class56 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_43 = (BindingFlags)class56.W(bindingFlags, array4, type, array2, (ParameterModifier[])(object)class2.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)class2.t(obj3, (Type)(object)Class5.Default, cultureInfo)).e(bindingFlags, null, null, array3), cultureInfo, array5, out *(object*)null));
					MethodBase[] methodBase_11 = (MethodBase[])(object)Class5.Default;
					CultureInfo cultureInfo_8 = cultureInfo;
					Class7 class57 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_44 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
					FieldInfo[] fieldInfo_4 = array;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).e(bindingFlags_42, methodBase_10, (Type[])null, (ParameterModifier[])(object)class55.j(bindingFlags_43, methodBase_11, ref object_4, null, cultureInfo_8, (string[])(object)class57.t(bindingFlags_44, fieldInfo_4, ((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array3), cultureInfo), out reference));
				}
				else
				{
					class29 = class29;
				}
			}
		}
		finally
		{
			gClass3 = gClass3;
			goto IL_1de0;
		}
		IL_253f:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				class22 = null;
				gClass = gClass;
			}
			catch
			{
				Class7 class58 = class2;
				Class7 obj35 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_45 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array;
				Class7 class59 = class2;
				BindingFlags bindingFlags_46 = bindingFlags;
				CultureInfo cultureInfo_9 = cultureInfo;
				Class7 obj36 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_47 = bindingFlags;
				Class7 class60 = class2;
				BindingFlags bindingFlags_48 = bindingFlags;
				Type[] type_16 = array2;
				Class7 class61 = class2;
				Class7 obj37 = (Class7)(object)class2.t(bindingFlags, null, class2.t((BindingFlags)Class5.Default, array, null, null), null);
				bindingFlags = default(BindingFlags);
				class44 = (Class9)class58.t(obj3, (Type)(object)obj35.t(bindingFlags_45, fieldInfo_5, class59.j(bindingFlags_46, null, ref *(object[]*)null, null, cultureInfo_9, null, out *(object*)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)obj36.e((BindingFlags)((Class7)null).W(bindingFlags_47, (PropertyInfo[])((Class7)(object)((Class7)null).t((BindingFlags)class60.e(bindingFlags_48, methodBase_, type_16, (ParameterModifier[])class61.t(obj37.t(obj3, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3), (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, null)), (Type)(object)Class5.Default, cultureInfo)), array, obj3, cultureInfo)).t(obj3, type, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, (ParameterModifier[])(object)class2.e((BindingFlags)Class5.Default, methodBase_, array2, array3))), type, (Type[])null, array3), methodBase_, null, array3), array3, cultureInfo, array5, out *(object*)Class5.Default)), (CultureInfo)(object)Class5.Default), cultureInfo);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (GClass3)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref object_4, array3, cultureInfo, (string[])(object)class2.W((BindingFlags)class2.t(obj3, (Type)(object)Class5.Default, cultureInfo), null, (Type)(object)Class5.Default, array2, null), out *(object*)null);
				_ = (Class8)((Class7)(object)Class5.Default).t(obj3, type, null);
			}
		}
		catch
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				class2 = class2;
				goto end_IL_27e4;
			}
			end_IL_27e4:;
		}
		if (num == 0)
		{
			gClass = gClass;
		}
		else
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Struct1)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)((Class7)(object)Class5.Default).t(obj3, type, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out reference);
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
		}
		_ = (Class6)(object)Class5.Default;
		_ = (Class4)(object)class2.e((BindingFlags)class2.W(bindingFlags, array4, (Type)(object)Class5.Default, array2, null), methodBase_, null, null);
		_003CModule_003E = _003CModule_003E;
		_ = (Struct2)((Class7)(object)Class5.Default).j(bindingFlags, null, ref object_4, (ParameterModifier[])(object)class2.W(bindingFlags, null, type, null, array3), cultureInfo, array5, out *(object*)null);
		gClass4 = null;
		do
		{
			try
			{
				gClass3 = gClass3;
				class30 = class30;
				_ = (Struct2)Class5.Default;
				class2 = (Class7)(object)Class5.Default;
			}
			finally
			{
				Class7 obj40 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)obj40.j(bindingFlags, methodBase_, ref object_4, (ParameterModifier[])((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)).t(obj3, null, cultureInfo), null, array5, out reference);
				continue;
			}
		}
		while (obj3 != null || (object)Class5.Default != null);
		if (num == 0)
		{
		}
		while ((object)Class5.Default != null)
		{
			while (obj3 != null)
			{
				qk = (Qk7)(object)Class5.Default;
			}
		}
		if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * num) == 0)
		{
			if ((UIntPtr)((Class7)null).e((BindingFlags)class2.t(null, type, cultureInfo), (MethodBase[])(object)class2.W(bindingFlags, array4, type, null, array3), array2, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
			{
				struct2 = (Struct1)Class5.Default;
			}
			else
			{
				_ = (GClass3)(object)class2.t((BindingFlags)class2.t(obj3, null, cultureInfo), array, obj3, (CultureInfo)(object)Class5.Default);
			}
		}
		if (num == 0)
		{
			try
			{
				_ = (GClass1)((Class7)null).t(obj3, (Type)null, cultureInfo);
			}
			catch
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		else
		{
			while (obj3 != null)
			{
				do
				{
					bindingFlags = default(BindingFlags);
					class22 = (Class2)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), ref object_4, array3, cultureInfo, array5, out reference);
				}
				while (obj3 != null);
			}
		}
		if (num == 0)
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
				Class7 obj42 = (Class7)(object)Class5.Default;
				Class7 obj43 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_49 = bindingFlags;
				Class7 obj44 = (Class7)(object)((Class7)((Class7)(object)Class5.Default).t(obj3, (Type)class2.t(obj3, type, null), (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, null, cultureInfo), null, null, null, out *(object*)null))).e(bindingFlags, methodBase_, array2, array3);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj42.W((BindingFlags)obj43.e(bindingFlags_49, (MethodBase[])(object)obj44.W(bindingFlags, null, type, null, null), null, null), array4, (Type)(object)Class5.Default, array2, null);
			}
			finally
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				catch
				{
					class19 = null;
				}
				goto IL_2c3f;
			}
		}
		goto IL_2c3f;
		IL_3ba1:
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)class2.j(default(BindingFlags), null, ref object_4, null, null, array5, out reference) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class62 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)((Class7)null).t(obj3, (Type)class62.t(obj3, (Type)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array3, (CultureInfo)null, array5, out *(object*)class2.e((BindingFlags)class2.t(Class5.Default, type, null), methodBase_, (Type[])(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])class2.t(null, type, cultureInfo), (Type)(object)Class5.Default, array2, array3)).j(default(BindingFlags), methodBase_, ref object_4, null, cultureInfo, array5, out reference), array3)), (CultureInfo)(object)Class5.Default), cultureInfo);
				}
				catch
				{
					gClass = (GClass3)(object)Class5.Default;
				}
			}
		}
		else if (num == 0)
		{
			try
			{
				@class = (Class6)(object)Class5.Default;
				class2 = (Class7)(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, null, out *(object*)null);
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
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
				_ = (Struct2)Class5.Default;
			}
			catch
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		Class7 class63 = class2;
		bindingFlags = default(BindingFlags);
		class39 = (Class10)(object)class63.e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, methodBase_, null, null), array2, array3);
		try
		{
			class28 = class28;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
				}
				else
				{
					@class = @class;
				}
			}
		}
		finally
		{
			while (obj3 != null)
			{
				if (num == 0)
				{
					Class7 class64 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class64.e(bindingFlags, null, array2, array3);
				}
				else
				{
					class30 = class30;
				}
			}
			goto IL_3e62;
		}
		IL_0c58:
		do
		{
			try
			{
				try
				{
					class2 = (Class7)(object)Class5.Default;
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).W(bindingFlags, array4, (Type)((Class7)null).t((object)null, type, cultureInfo), (Type[])null, (ParameterModifier[])null);
					_ = (GClass2)(object)Class5.Default;
					class39 = class39;
				}
			}
			catch
			{
				try
				{
					class22 = class22;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
					Class9 obj52 = (Class9)(object)Class5.Default;
					class44 = class44;
					class44 = obj52;
					goto end_IL_0cb5;
				}
				end_IL_0cb5:;
			}
		}
		while ((object)Class5.Default != null);
		while (obj3 != null)
		{
			try
			{
				Class7 obj54 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)obj54.W(bindingFlags, null, type, (Type[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array2, array3)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array3), null)).j(bindingFlags, null, ref object_4, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					gClass2 = null;
				}
			}
			catch
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				catch
				{
					Class7 class65 = class2;
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)class65.W(bindingFlags, array4, null, array2, array3);
				}
			}
		}
		_ = (GClass0)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array2, array3);
		do
		{
			try
			{
				try
				{
					gClass2 = gClass2;
					qk = null;
					Class7 class66 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class66.t(bindingFlags, array, obj3, cultureInfo);
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_0e30;
				}
				end_IL_0e30:;
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj3 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			qk = null;
		}
		checked
		{
			if (num - (unchecked((nuint)(UIntPtr)Class5.Default) + num - unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				while ((object)((Class7)null).e(bindingFlags, methodBase_, array2, array3) != null)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			else
			{
				while (obj3 != null)
				{
					do
					{
						_ = (GClass2)(object)Class5.Default;
					}
					while (obj3 != null);
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Class10)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default);
			}
			while (obj3 != null || obj3 != null);
		}
		else
		{
			class19 = class19;
			class19 = class19;
		}
		_ = (GClass0)(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), null, out reference);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class22 = (Class2)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					class22 = null;
				}
			}
		}
		else
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
				class28 = (Class4)(object)Class5.Default;
				class28 = class28;
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Class7 class67 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)((Class7)(object)class67.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, null)).t(class2.t(null, type, cultureInfo), null, (CultureInfo)(object)Class5.Default);
				}
				else
				{
					@class = @class;
				}
			}
		}
		try
		{
		}
		finally
		{
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			goto IL_10c8;
		}
		IL_30c5:
		if (checked(num + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			try
			{
				class22 = class22;
				_ = (Class6)(object)Class5.Default;
			}
			catch
			{
				UIntPtr num6 = (UIntPtr)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				num = default(UIntPtr);
				if ((nuint)num6 / num == 0)
				{
					class19 = class19;
				}
			}
		}
		else
		{
			try
			{
				num = default(UIntPtr);
				if (num / num == 0)
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Class8)(object)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array2, array3);
					qk = (Qk7)(object)Class5.Default;
					_ = Class5.Default;
				}
				else
				{
					_ = (Qk7)(object)class2.e(bindingFlags, null, array2, array3);
				}
			}
			catch
			{
				nuint num7 = num / unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (num7 / num == 0)
				{
					Class7 class68 = class2;
					BindingFlags bindingFlags_50 = bindingFlags;
					FieldInfo[] fieldInfo_6 = array;
					Class7 class69 = class2;
					BindingFlags bindingFlags_51 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array4;
					Type type_17 = type;
					Class7 class70 = class2;
					BindingFlags bindingFlags_52 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_7 = array;
					object object_10 = class2.W(bindingFlags, null, null, array2, array3);
					BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
					Class7 class71 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj60 = (Class7)((Class7)(object)class68.t(bindingFlags_50, fieldInfo_6, class69.W(bindingFlags_51, propertyInfo_6, type_17, (Type[])(object)class70.t(bindingFlags_52, fieldInfo_7, object_10, (CultureInfo)(object)((Class7)null).W(bindingFlags_53, (PropertyInfo[])(object)class71.t(bindingFlags, null, obj3, (CultureInfo)(object)Class5.Default), (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_, ref object_4, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3), array5, out *(object*)null)), array2, (ParameterModifier[])(object)Class5.Default)), null), null)).t(obj3, type, cultureInfo);
					BindingFlags bindingFlags_54 = (BindingFlags)class2.t(((Class7)(object)Class5.Default).e((BindingFlags)class2.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, null, array3), null, array2, null), type, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj60.t(bindingFlags_54, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, array3), null, cultureInfo);
				}
			}
		}
		@class = @class;
		class22 = (Class2)((Class7)null).t(obj3, type, (CultureInfo)null);
		try
		{
			gClass2 = gClass2;
		}
		catch
		{
			struct2 = struct2;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class72 = class2;
			BindingFlags bindingFlags_55 = bindingFlags;
			BindingFlags bindingFlags_56 = bindingFlags;
			ParameterModifier[] parameterModifier_10 = array3;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)((Class7)(object)((Class7)(object)class72.e(bindingFlags_55, methodBase_, (Type[])(object)((Class7)(object)((Class7)null).j(bindingFlags_56, (MethodBase[])null, ref *(object[]*)null, parameterModifier_10, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_, array2, array3), (string[])null, out *(object*)null)).j(bindingFlags, methodBase_, ref object_4, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), array3)).W((BindingFlags)Class5.Default, array4, null, null, null)).t((BindingFlags)Class5.Default, null, null, (CultureInfo)(object)Class5.Default)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_4, array3, (CultureInfo)(object)Class5.Default, array5, out *(object*)class2.e((BindingFlags)Class5.Default, methodBase_, array2, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj3, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)class2.t(null, type, cultureInfo), null, out reference), cultureInfo))) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)(object)class2.e(bindingFlags, methodBase_, array2, array3);
			}
			else
			{
				gClass2 = gClass2;
			}
		}
		class30 = class30;
		_ = (GClass0)(object)Class5.Default;
		gClass = null;
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		catch
		{
			class22 = class22;
		}
		while (obj3 != null)
		{
			try
			{
				class2 = null;
			}
			finally
			{
				try
				{
					class30 = class30;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
		}
		_ = (Class6)class2.t(Class5.Default, null, cultureInfo);
		if (num == 0 && checked(num - num) == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass = (GClass3)(object)((Class7)class2.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)class2.e((BindingFlags)class2.W(bindingFlags, array4, type, array2, array3), methodBase_, (Type[])(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_4, array3, null, array5, out reference), array3))).t(bindingFlags, null, obj3, cultureInfo);
			}
			else
			{
				class28 = null;
			}
		}
		while (obj3 != null)
		{
			try
			{
			}
			catch
			{
				do
				{
					gClass4 = null;
				}
				while (obj3 != null);
			}
		}
		try
		{
			try
			{
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (Qk7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])class2.t(class2.t(null, type, (CultureInfo)(object)Class5.Default), type, cultureInfo), ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				}
				goto end_IL_36e4;
			}
			end_IL_36e4:;
		}
		catch
		{
			try
			{
				try
				{
					class28 = class28;
				}
				finally
				{
					_ = Class5.Default;
					goto end_IL_3770;
				}
				end_IL_3770:;
			}
			catch
			{
				gClass = gClass;
			}
		}
		@class = @class;
		class19 = class19;
		if ((UIntPtr)class2.t(null, type, null) == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
			}
		}
		else
		{
			UIntPtr num8 = (UIntPtr)((Class7)null).W(bindingFlags, array4, type, (Type[])null, array3);
			nuint num9 = num;
			Class7 class73 = class2;
			BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
			Class7 class74 = class2;
			BindingFlags bindingFlags_58 = (BindingFlags)class2.W(bindingFlags, null, type, array2, array3);
			Class7 class75 = class2;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num8) + (num9 + unchecked((nuint)(UIntPtr)class73.e(bindingFlags_57, (MethodBase[])((Class7)(object)class74.e(bindingFlags_58, (MethodBase[])(object)class75.t(bindingFlags, null, null, null), (Type[])class2.t(Class5.Default, type, cultureInfo), array3)).t(obj3, null, cultureInfo), array2, array3))) == 0)
				{
					while (obj3 != null)
					{
						class2 = class2;
					}
				}
				else if (num == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					qk = null;
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		while (obj3 != null)
		{
			gClass4 = gClass4;
		}
		try
		{
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
			goto IL_38f1;
		}
		IL_2c3f:
		try
		{
			if ((UIntPtr)class2.j(bindingFlags, null, ref object_4, (ParameterModifier[])(object)((Class7)(object)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, null, null, out *(object*)class2.j(bindingFlags, methodBase_, ref object_4, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), out *(object*)null))), cultureInfo, null, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (Class8)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
				@struct = @struct;
			}
		}
		finally
		{
			goto IL_2d51;
		}
		IL_175b:
		try
		{
		}
		catch
		{
			while (obj3 != null)
			{
				if (num == 0)
				{
					@class = @class;
				}
				else
				{
					class19 = (Class0)(object)class2.e((BindingFlags)class2.t(obj3, null, cultureInfo), (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, null, ref object_4, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), null, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		gClass2 = null;
		do
		{
			Class7 class76 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class76.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_4, null, cultureInfo, null, out reference) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)((Class7)null).t(obj3, (Type)null, cultureInfo);
			}
		}
		while (obj3 != null || obj3 != null);
		gClass = (GClass3)(object)class2.t(bindingFlags, array, obj3, (CultureInfo)(object)class2.t(bindingFlags, array, obj3, (CultureInfo)(object)Class5.Default));
		do
		{
			try
			{
				try
				{
					class28 = class28;
				}
				finally
				{
					class29 = null;
					goto end_IL_1884;
				}
				end_IL_1884:;
			}
			finally
			{
				_ = (GClass0)(object)class2.e(bindingFlags, methodBase_, array2, (ParameterModifier[])(object)Class5.Default);
				continue;
			}
		}
		while (obj3 != null);
		try
		{
			if (num == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		catch
		{
			while (true)
			{
				Class7 obj68 = (Class7)(object)((Class7)null).t(default(BindingFlags), array, (object)null, (CultureInfo)(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				if ((object)obj68.t(bindingFlags, null, null, cultureInfo) != null)
				{
					if (num == 0)
					{
						_003CModule_003E = null;
					}
					continue;
				}
				break;
			}
		}
		try
		{
			do
			{
				nuint num10;
				checked
				{
					num10 = unchecked((nuint)(UIntPtr)Class5.Default) * num * unchecked((nuint)(UIntPtr)Class5.Default);
					num = default(UIntPtr);
				}
				if (num10 / num != 0)
				{
					Class7 class77 = class2;
					BindingFlags bindingFlags_59 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
					Type type_18 = (Type)(object)Class5.Default;
					Class7 class78 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class77.W(bindingFlags_59, propertyInfo_7, type_18, (Type[])(object)class78.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default), array3);
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while ((object)class2.t((BindingFlags)Class5.Default, array, null, cultureInfo) != null);
		}
		finally
		{
			try
			{
				while (obj3 != null)
				{
					class28 = class28;
				}
			}
			catch
			{
				if (num / num == 0)
				{
					class29 = class29;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			goto IL_1a27;
		}
		IL_23ab:
		try
		{
			do
			{
				class2 = class2;
			}
			while (obj3 != null);
		}
		catch
		{
			if (num == 0)
			{
				_ = (GClass1)(object)Class5.Default;
			}
		}
		finally
		{
			while (true)
			{
				Class7 class79 = class2;
				Class7 class80 = class2;
				BindingFlags bindingFlags_60 = (BindingFlags)((Class7)((Class7)null).t(obj3, (Type)null, cultureInfo)).W(bindingFlags, array4, type, null, array3);
				bindingFlags = default(BindingFlags);
				if ((object)class79.t((BindingFlags)class80.j(bindingFlags_60, methodBase_, ref object_4, null, (CultureInfo)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array2, (ParameterModifier[])null)).t(obj3, null, cultureInfo), (string[])(object)Class5.Default, out *(object*)Class5.Default), (FieldInfo[])(object)Class5.Default, class2.e(bindingFlags, methodBase_, (Type[])class2.t(obj3, type, cultureInfo), (ParameterModifier[])(object)class2.j(bindingFlags, methodBase_, ref object_4, null, cultureInfo, array5, out *(object*)Class5.Default)), cultureInfo) != null)
				{
					_ = (Class8)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])((Class7)(object)Class5.Default).t(null, null, cultureInfo), type, array2, array3)).t(bindingFlags, array, null, cultureInfo);
					continue;
				}
				break;
			}
			goto IL_253f;
		}
		IL_3e62:
		checked
		{
			try
			{
				try
				{
					do
					{
						@struct = @struct;
					}
					while (obj3 != null);
				}
				catch
				{
					nuint num11 = num;
					num = default(UIntPtr);
					if (num11 - num == 0)
					{
						_ = (Class10)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					}
				}
			}
			catch
			{
				Class7 class81 = class2;
				Class7 class82 = class2;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)(UIntPtr)class81.t(null, null, (CultureInfo)(object)class82.j(bindingFlags, methodBase_, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null))) * num != 0)
				{
					try
					{
						gClass4 = (GClass0)(object)unchecked(((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref object_4, null, null, (string[])(object)Class5.Default, out *(object*)class2.t(bindingFlags, array, obj3, cultureInfo))));
					}
					finally
					{
						struct2 = struct2;
						goto end_IL_3eb1;
					}
				}
				class44 = null;
				end_IL_3eb1:;
			}
			try
			{
				struct2 = struct2;
			}
			catch
			{
				@class = (Class6)class2.t(null, null, null);
			}
			while (obj3 != null)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					if (num == 0)
					{
						_ = (Class10)(object)Class5.Default;
					}
					else
					{
						class30 = class30;
					}
					continue;
				}
			}
			if (num + unchecked((nuint)(UIntPtr)class2.t(bindingFlags, array, obj3, null)) == 0)
			{
				do
				{
					if (default(UIntPtr) != unchecked((UIntPtr)(nuint)0u))
					{
						_ = Class5.Default;
						_ = (GClass3)(object)Class5.Default;
						_ = (GClass1)class2.t(((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, null)).e(bindingFlags, methodBase_, null, array3), type, cultureInfo);
					}
					else
					{
						_ = (GClass0)(object)((Class7)(object)class2.e(bindingFlags, (MethodBase[])class2.t(Class5.Default, null, cultureInfo), array2, array3)).e(bindingFlags, methodBase_, null, array3);
						_ = (Struct1)Class5.Default;
					}
				}
				while (obj3 != null);
			}
			try
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W((BindingFlags)class2.W((BindingFlags)Class5.Default, null, type, array2, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)), array4, type, array2, null)) - unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_, ref object_4, array3, cultureInfo, null, out *(object*)Class5.Default)))) == 0)
					{
						@class = @class;
						_ = (GClass0)(object)Class5.Default;
						class29 = class29;
						gClass2 = gClass2;
					}
					else
					{
						gClass2 = gClass2;
						class19 = class19;
						class30 = class30;
						_ = (Struct2)Class5.Default;
					}
				}
			}
			finally
			{
				UIntPtr num12 = unchecked((UIntPtr)Class5.Default);
				Class7 class83 = class2;
				BindingFlags bindingFlags_61 = bindingFlags;
				Class7 obj75 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_62 = bindingFlags;
				ParameterModifier[] parameterModifier_11 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj76 = (Class7)(object)class2.t(bindingFlags, array, obj3, null);
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)num12) * unchecked((nuint)(UIntPtr)class83.e(bindingFlags_61, (MethodBase[])(object)obj75.t((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags_62, methodBase_, ref *(object[]*)null, parameterModifier_11, (CultureInfo)(object)obj76.t(bindingFlags, (FieldInfo[])class2.t(null, (Type)(object)Class5.Default, cultureInfo), obj3, cultureInfo), (string[])null, out reference)).j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, null, array3)), null, out reference), null, null, (CultureInfo)(object)class2.W((BindingFlags)class2.t(bindingFlags, array, obj3, cultureInfo), array4, type, array2, null)), null, array3)) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					unchecked
					{
						try
						{
							bindingFlags = default(BindingFlags);
							BindingFlags bindingFlags_63 = bindingFlags;
							Class7 class84 = class2;
							BindingFlags bindingFlags_64 = bindingFlags;
							MethodBase[] methodBase_12 = (MethodBase[])(object)Class5.Default;
							Class7 obj77 = (Class7)(object)class2.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array3);
							object object_11 = class2.e((BindingFlags)Class5.Default, methodBase_, null, array3);
							bindingFlags = default(BindingFlags);
							BindingFlags bindingFlags_65 = bindingFlags;
							Class7 class85 = class2;
							bindingFlags = default(BindingFlags);
							Class7 obj78 = (Class7)(object)class84.e(bindingFlags_64, methodBase_12, (Type[])obj77.t(object_11, (Type)(object)((Class7)null).t(bindingFlags_65, (FieldInfo[])null, (object)class85.W(bindingFlags, array4, type, null, array3), cultureInfo), cultureInfo), array3);
							bindingFlags = default(BindingFlags);
							MethodBase[] methodBase_13 = (MethodBase[])(object)obj78.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null);
							ref object[] object_12 = ref *(object[]*)Class5.Default;
							ParameterModifier[] parameterModifier_12 = array3;
							Class7 class86 = class2;
							bindingFlags = default(BindingFlags);
							BindingFlags bindingFlags_66 = bindingFlags;
							ref object[] object_13 = ref *(object[]*)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])(object)((Class7)null).W(bindingFlags, array4, type, array2, array3), out *(object*)class2.e(bindingFlags, null, array2, array3)), (Type[])(object)class2.e((BindingFlags)((Class7)null).t(obj3, type, cultureInfo), methodBase_, array2, null), array3);
							Class7 class87 = class2;
							BindingFlags bindingFlags_67 = bindingFlags;
							Class7 obj79 = (Class7)class2.t(obj3, null, (CultureInfo)(object)Class5.Default);
							BindingFlags bindingFlags_68 = (BindingFlags)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference);
							PropertyInfo[] propertyInfo_8 = array4;
							Class7 class88 = class2;
							bindingFlags = default(BindingFlags);
							_003CModule_003E = (_003CModule_003E)(object)((Class7)null).j(bindingFlags_63, methodBase_13, ref object_12, parameterModifier_12, (CultureInfo)(object)class86.j(bindingFlags_66, methodBase_, ref object_13, (ParameterModifier[])((Class7)(object)class87.j(bindingFlags_67, methodBase_, ref *(object[]*)obj79.W(bindingFlags_68, propertyInfo_8, (Type)(object)class88.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo), array2, array3), array3, null, (string[])(object)Class5.Default, out *(object*)null)).t(obj3, (Type)(object)class2.j(bindingFlags, methodBase_, ref *(object[]*)null, array3, cultureInfo, null, out reference), null), null, array5, out *(object*)null), (string[])null, out *(object*)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null));
						}
						catch
						{
							class39 = class39;
						}
					}
				}
				else
				{
					gClass3 = gClass3;
				}
				goto IL_4687;
			}
		}
		IL_4687:
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				class28 = class28;
			}
			else
			{
				class39 = null;
			}
		}
		while ((object)Class5.Default != null);
		qk = (Qk7)(object)Class5.Default;
		while ((object)Class5.Default != null)
		{
			while (obj3 != null)
			{
			}
		}
		try
		{
			_ = (Qk7)(object)Class5.Default;
		}
		catch
		{
			Class7 obj81;
			Class7 class89;
			do
			{
				class19 = class19;
				gClass = null;
				obj81 = (Class7)(object)Class5.Default;
				class89 = class2;
				bindingFlags = default(BindingFlags);
			}
			while (((Class7)(object)obj81.W((BindingFlags)class89.W(bindingFlags, array4, (Type)((Class7)null).t(obj3, type, (CultureInfo)null), (Type[])(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, null, array5, out reference), array3), null, (Type)(object)Class5.Default, array2, null)).t(Class5.Default, (Type)(object)class2.e(bindingFlags, null, null, null), null) != null);
		}
		finally
		{
			class19 = (Class0)(object)Class5.Default;
			goto IL_47a0;
		}
	}

	unsafe static void smethod_4()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class3);
		if (uIntPtr == 0)
		{
			try
			{
				gClass = gClass;
				gClass = null;
				obj = null;
			}
			catch
			{
				try
				{
					@class = @class;
					Class7 class2 = @class;
					bindingFlags = (BindingFlags)Class5.Default;
					_ = (Class6)(object)class2.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					Qk7 obj2 = (Qk7)(object)Class5.Default;
					qk = qk;
					qk = obj2;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					class3 = class3;
					class3 = class3;
					@class = @class;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class4);
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					GClass2 obj5 = (GClass2)(object)Class5.Default;
					gClass2 = gClass2;
					gClass2 = obj5;
					@struct = @struct;
					@struct = default(Struct1);
					@struct = @struct;
					class4 = class4;
					class4 = null;
				}
				catch
				{
					class5 = class5;
					class5 = null;
				}
			}
		}
		finally
		{
			_ = (Class10)(object)Class5.Default;
			goto IL_0105;
		}
		IL_5526:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
			Class7 class6 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class6.t(bindingFlags, null, null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass3 = (GClass3)(object)Class5.Default;
					gClass = gClass;
				}
				finally
				{
					_ = (Struct2)Class5.Default;
					goto end_IL_5527;
				}
			}
			end_IL_5527:;
		}
		finally
		{
			_ = (GClass3)(object)((Class7)null).t(bindingFlags, array, obj, (CultureInfo)null);
			goto IL_558d;
		}
		IL_374b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_);
		PropertyInfo[] propertyInfo_2;
		try
		{
			_ = (Class4)(object)Class5.Default;
			class4 = class4;
			BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
			Class7 obj7 = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, obj, null);
			BindingFlags bindingFlags_2 = (BindingFlags)@class.t(Class5.Default, type, cultureInfo);
			BindingFlags bindingFlags_3 = bindingFlags;
			PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array3, array4), (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])null, cultureInfo, array5, out *(object*)null), (CultureInfo)(object)Class5.Default, (string[])null, out object_);
			Class7 class7 = @class;
			Class7 obj8 = (Class7)(object)Class5.Default;
			Class7 class8 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj9 = (Class7)((Class7)(object)((Class7)null).W(bindingFlags_3, propertyInfo_, (Type)(object)((Class7)(object)class7.j((BindingFlags)obj8.t(class8.W(bindingFlags, null, type, array3, null), type, null), array2, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_2, type, (Type[])null, (ParameterModifier[])null), null, null, out object_)).e(bindingFlags, null, null, array4), (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(null, null, cultureInfo))).t(obj, type, null);
			bindingFlags = default(BindingFlags);
			FieldInfo[] fieldInfo_ = (FieldInfo[])(object)obj7.W(bindingFlags_2, propertyInfo_2, (Type)(object)obj9.W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, null, @class.t(obj, type, cultureInfo), (CultureInfo)(object)Class5.Default), type, array3, (ParameterModifier[])(object)Class5.Default), array3, array4);
			Class7 class9 = @class;
			BindingFlags bindingFlags_4 = bindingFlags;
			Type type_ = type;
			Type[] type_2 = array3;
			Class7 class10 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)null).t(bindingFlags_, fieldInfo_, (object)class9.W(bindingFlags_4, propertyInfo_2, type_, type_2, (ParameterModifier[])(object)class10.t(bindingFlags, array, obj, null)), cultureInfo);
			class5 = class5;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					class5 = class5;
				}
				catch
				{
					_ = (Qk7)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		try
		{
			class11 = class11;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				struct2 = struct2;
				_ = (Class10)(object)Class5.Default;
				@class = @class;
				_ = (Qk7)(object)Class5.Default;
			}
			goto IL_3a37;
		}
		IL_0105:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class15);
		try
		{
			do
			{
				Class7 class12 = @class;
				BindingFlags bindingFlags_5 = (BindingFlags)Class5.Default;
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_6 = bindingFlags;
				Class7 class14 = @class;
				BindingFlags bindingFlags_7 = bindingFlags;
				object object_2 = obj;
				cultureInfo = cultureInfo;
				MethodBase[] methodBase_ = (MethodBase[])(object)class14.t(bindingFlags_7, null, object_2, cultureInfo);
				ref object[] object_3 = ref *(object[]*)Class5.Default;
				array4 = null;
				ParameterModifier[] parameterModifier_ = array4;
				CultureInfo cultureInfo_ = cultureInfo;
				string[] string_ = (string[])(object)Class5.Default;
				object_ = ref *(object*)null;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)class13.j(bindingFlags_6, methodBase_, ref object_3, parameterModifier_, cultureInfo_, string_, out object_);
				type = null;
				_ = (Class2)(object)class12.W(bindingFlags_5, propertyInfo_3, type, (Type[])(object)Class5.Default, array4);
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_8 = bindingFlags;
				array3 = array3;
				Struct2 obj12 = (Struct2)((Class7)null).W(bindingFlags_8, (PropertyInfo[])null, (Type)null, array3, (ParameterModifier[])null);
				struct2 = default(Struct2);
				struct2 = struct2;
				struct2 = obj12;
				class15 = class15;
				class15 = null;
				class15 = null;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					qk = qk;
				}
				goto end_IL_01ab;
			}
			end_IL_01ab:;
		}
		Class7 class16 = @class;
		BindingFlags bindingFlags_9 = bindingFlags;
		propertyInfo_2 = null;
		_ = (Struct1)class16.W(bindingFlags_9, propertyInfo_2, null, array3, null);
		Class8 class17;
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			catch
			{
				class17 = (Class8)@class.t(obj, type, (CultureInfo)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array3, array4));
				class17 = null;
			}
		}
		while (obj != null);
		struct2 = struct2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class21);
		try
		{
			while (obj != null)
			{
				try
				{
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_10 = bindingFlags;
					array = null;
					Class7 obj15 = (Class7)(object)((Class7)null).W((BindingFlags)class18.t(bindingFlags_10, array, obj, cultureInfo), propertyInfo_2, (Type)null, array3, array4);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_11 = bindingFlags;
					array2 = array2;
					MethodBase[] methodBase_2 = array2;
					ParameterModifier[] parameterModifier_2 = array4;
					array5 = array5;
					_ = (Class9)(object)obj15.j(bindingFlags_11, methodBase_2, ref *(object[]*)null, parameterModifier_2, null, array5, out object_);
				}
				catch
				{
					qk = qk;
					Class7 class19 = @class;
					BindingFlags bindingFlags_12 = bindingFlags;
					Class7 class20 = @class;
					BindingFlags bindingFlags_13 = bindingFlags;
					BindingFlags bindingFlags_14 = bindingFlags;
					MethodBase[] methodBase_3 = array2;
					reference = ref *(object[]*)null;
					GClass1 obj16 = (GClass1)(object)class19.W(bindingFlags_12, (PropertyInfo[])(object)class20.t(bindingFlags_13, (FieldInfo[])(object)((Class7)null).j(bindingFlags_14, methodBase_3, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out object_), obj, (CultureInfo)(object)@class.W((BindingFlags)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, (ParameterModifier[])@class.t(null, (Type)@class.t(obj, type, null), cultureInfo)), propertyInfo_2, null, array3, array4)), null, null, null);
					gClass4 = null;
					gClass4 = obj16;
					_ = (Class5)(object)@class.t(bindingFlags, array, null, cultureInfo);
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (GClass2)(object)@class.t(bindingFlags, array, obj, cultureInfo);
				}
				finally
				{
					@struct = @struct;
					class21 = class21;
					class21 = null;
					gClass2 = gClass2;
					goto end_IL_0428;
				}
			}
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked(uIntPtr / checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, null, cultureInfo, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, (CultureInfo)(object)Class5.Default, array5, out *(object*)null), out object_)) + uIntPtr)) == 0)
				{
					class21 = class21;
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			end_IL_0428:;
		}
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)@class.e(bindingFlags, null, null, null)) == 0)
			{
				try
				{
					try
					{
						@struct = @struct;
						gClass2 = gClass2;
						_ = (Struct2)Class5.Default;
					}
					finally
					{
						class11 = (Class0)(object)Class5.Default;
						class11 = class11;
						goto end_IL_0518;
					}
					end_IL_0518:;
				}
				finally
				{
					try
					{
						class11 = class11;
					}
					finally
					{
						class3 = class3;
						goto IL_0572;
					}
				}
			}
			_ = (Class6)(object)Class5.Default;
			goto IL_0572;
		}
		IL_3291:
		_ = (Struct1)Class5.Default;
		do
		{
			try
			{
				do
				{
					_ = (GClass1)@class.t(obj, type, cultureInfo);
					_ = (Struct1)Class5.Default;
					gClass4 = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
			}
			finally
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				class4 = class4;
			}
		}
		catch
		{
			while (obj != null)
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		if ((UIntPtr)((Class7)null).W(bindingFlags, propertyInfo_2, (Type)null, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, null, null, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null))), array4) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class21 = null;
			}
			finally
			{
				qk = qk;
				goto IL_33c4;
			}
		}
		goto IL_33c4;
		IL_1826:
		checked
		{
			while (obj != null)
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array4), (Type)(object)Class5.Default, array3, array4)) == 0)
				{
					Class7 obj20 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj21 = (Class7)(object)((Class7)(object)obj20.W(bindingFlags, propertyInfo_2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null)).W(bindingFlags, propertyInfo_2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array4);
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj21.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo), obj, null);
					_ = (Class0)(object)Class5.Default;
					@class = @class;
					class17 = (Class8)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null);
				}
				else
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
					{
						class21 = class21;
					}
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
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
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array4);
				}
			}
		}
		do
		{
			try
			{
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)@class.W((BindingFlags)@class.e(bindingFlags, null, array3, null), null, type, array3, array4)).j((BindingFlags)@class.W(bindingFlags, propertyInfo_2, type, null, (ParameterModifier[])(object)Class5.Default), array2, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), (CultureInfo)(object)Class5.Default, null, out object_) == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, (Type[])(object)@class.t(bindingFlags, array, obj, cultureInfo), array4);
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			struct2 = struct2;
		}
		catch
		{
			_ = (Class7)(object)@class.t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])((Class7)null).t(obj, (Type)(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array4, cultureInfo, array5, out *(object*)null), cultureInfo), obj, (CultureInfo)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)Class5.Default)), array, @class.t(obj, (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4), cultureInfo), (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, null));
			_ = (Class6)(object)Class5.Default;
		}
		try
		{
			_ = (Class8)(object)Class5.Default;
			_ = (Class0)(object)Class5.Default;
			class3 = class3;
			_ = (Struct2)Class5.Default;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class3 = class3;
				}
			}
			else
			{
				do
				{
					bindingFlags = default(BindingFlags);
					Class7 obj24 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array4, (CultureInfo)null, array5, out object_);
					object object_4 = Class5.Default;
					Class7 class22 = @class;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)@class.j(bindingFlags, array2, ref reference, array4, null, (string[])(object)@class.t(bindingFlags, array, null, cultureInfo), out object_);
					BindingFlags bindingFlags_16 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_17 = bindingFlags;
					Class7 class23 = @class;
					BindingFlags bindingFlags_18 = bindingFlags;
					MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
					ref object[] object_5 = ref reference;
					Class7 obj25 = (Class7)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_19 = bindingFlags;
					Class7 class24 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					Class7 obj26 = (Class7)@class.t(obj, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					Class7 obj27 = (Class7)((Class7)obj24.t(object_4, (Type)(object)class22.W(bindingFlags_15, propertyInfo_4, (Type)(object)((Class7)null).W(bindingFlags_16, (PropertyInfo[])null, (Type)(object)((Class7)null).t(bindingFlags_17, (FieldInfo[])(object)class23.j(bindingFlags_18, methodBase_4, ref object_5, (ParameterModifier[])(object)obj25.j(bindingFlags_19, (MethodBase[])(object)class24.W(bindingFlags_20, (PropertyInfo[])(object)obj26.e((BindingFlags)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo), null, (Type[])(object)Class5.Default, null), null, null, (ParameterModifier[])(object)@class.W(bindingFlags, null, null, array3, null)), ref *(object[]*)null, array4, (CultureInfo)(object)Class5.Default, null, out object_), cultureInfo, null, out *(object*)null), (object)null, (CultureInfo)null), array3, (ParameterModifier[])(object)Class5.Default), array3, null), (CultureInfo)(object)Class5.Default)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_21 = bindingFlags;
					Class7 class25 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)(object)obj27.e(bindingFlags_21, null, (Type[])(object)class25.e(bindingFlags, array2, null, array4), null)).W(bindingFlags, propertyInfo_2, type, array3, array4);
					gClass3 = gClass3;
				}
				while (obj != null);
			}
			goto IL_1d4f;
		}
		IL_4bdb:
		checked
		{
			while (obj != null)
			{
				try
				{
					try
					{
						_ = (Struct2)Class5.Default;
					}
					finally
					{
						_ = (GClass1)(object)@class.W(default(BindingFlags), propertyInfo_2, (Type)(object)Class5.Default, array3, array4);
						gClass3 = null;
						goto end_IL_4b34;
					}
					end_IL_4b34:;
				}
				finally
				{
					Class7 class26 = @class;
					object object_6 = obj;
					Type type_3 = type;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					if (unchecked((nuint)(UIntPtr)class26.t(object_6, type_3, (CultureInfo)(object)class27.W(bindingFlags, propertyInfo_2, type, array3, array4))) - uIntPtr == 0)
					{
						struct2 = default(Struct2);
					}
					continue;
				}
			}
			class3 = class3;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class8)(object)@class.t(bindingFlags, array, obj, cultureInfo);
				}
			}
			else
			{
				do
				{
					_ = (Struct1)@class.e(bindingFlags, array2, array3, array4);
				}
				while (obj != null);
			}
		}
		finally
		{
			Class7 obj28 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)obj28.t(bindingFlags, null, obj, cultureInfo);
			goto IL_4c76;
		}
		IL_5867:
		if (uIntPtr == 0)
		{
			gClass = gClass;
		}
		try
		{
			_ = (_003CModule_003E)(object)((Class7)null).t((BindingFlags)Class5.Default, array, obj, (CultureInfo)null);
		}
		catch
		{
			if ((UIntPtr)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (Class5)(object)((Class7)(object)((Class7)((Class7)@class.t(obj, null, cultureInfo)).t(obj, type, cultureInfo)).W(bindingFlags, null, type, array3, null)).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, array2, (Type[])(object)Class5.Default, array4), cultureInfo, array5, out object_);
				class3 = (Class6)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				UIntPtr num = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num / uIntPtr == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		if (uIntPtr == 0 && unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			gClass3 = (GClass3)(object)@class.W(bindingFlags, propertyInfo_2, type, array3, null);
			_003CModule_003E = _003CModule_003E;
			gClass4 = gClass4;
		}
		return;
		IL_0fc9:
		try
		{
			do
			{
				_ = (GClass3)(object)@class.e(bindingFlags, array2, array3, array4);
				_ = (Class6)(object)@class.t(bindingFlags, array, null, cultureInfo);
				class15 = null;
			}
			while (obj != null);
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && (UIntPtr)@class.t(obj, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array4);
				Class7 obj30 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_2, type, (Type[])(object)@class.t(bindingFlags, array, obj, cultureInfo), array4);
				bindingFlags = default(BindingFlags);
				gClass2 = (GClass2)(object)obj30.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default)).e(bindingFlags, array2, null, array4), @class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, (string[])(object)@class.W(bindingFlags, null, type, array3, (ParameterModifier[])(object)Class5.Default), out object_)), cultureInfo);
				gClass = gClass;
			}
		}
		try
		{
			@struct = default(Struct1);
			_ = Class5.Default;
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					class5 = class5;
				}
				catch
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			goto IL_11f7;
		}
		IL_36cc:
		while (obj != null)
		{
			do
			{
				try
				{
					_ = (_003CModule_003E)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, null, null, array5, out object_)).t(obj, type, cultureInfo);
				}
				finally
				{
					_ = Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		try
		{
			while (obj != null)
			{
				class15 = (Class4)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
			}
		}
		finally
		{
			Class7 class28 = @class;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
			object object_7 = obj;
			Class7 class29 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)class28.t(default(BindingFlags), fieldInfo_2, object_7, (CultureInfo)(object)class29.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default));
			goto IL_374b;
		}
		IL_11f7:
		while (obj != null)
		{
			_ = (Class0)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Struct1)Class5.Default;
			}
			while (obj != null);
		}
		Class7 class31;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class30);
		checked
		{
			if (unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, array4, null, null, out object_), type, null)) - uIntPtr == 0)
			{
				@struct = default(Struct1);
			}
			else if (uIntPtr == 0 && uIntPtr == 0)
			{
				class30 = class30;
			}
			while (obj != null)
			{
				while (obj != null)
				{
					class11 = class11;
					class3 = class3;
					_ = (GClass2)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), (ParameterModifier[])(object)Class5.Default);
				}
			}
			_ = (Class4)(object)Class5.Default;
			class21 = null;
			while ((object)@class.t(bindingFlags, array, null, null) != null)
			{
				while ((object)Class5.Default != null)
				{
					do
					{
						gClass2 = null;
					}
					while (obj != null);
				}
			}
			class30 = class30;
			@struct = default(Struct1);
			class31 = @class;
			bindingFlags = default(BindingFlags);
		}
		_ = (Class0)(object)class31.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.t((BindingFlags)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array4), null, null, (CultureInfo)((Class7)((Class7)null).t(obj, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_2, (Type)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo), (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array, null, cultureInfo), (ParameterModifier[])null), cultureInfo)).t(null, (Type)(object)Class5.Default, cultureInfo))).t(((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, (ParameterModifier[])null)).e(bindingFlags, array2, (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)@class.t(null, (Type)(object)Class5.Default, cultureInfo), (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), out object_), array3, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)@class.W((BindingFlags)((Class7)@class.t(obj, (Type)(object)@class.W(bindingFlags, null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), null, array4), array3, null), null)).j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, null, out object_), null, type, (Type[])(object)Class5.Default, array4), (FieldInfo[])((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_2, (Type)null, array3, array4)).t(Class5.Default, (Type)@class.t(obj, null, cultureInfo), cultureInfo), obj, cultureInfo), Class5.Default, (CultureInfo)(object)Class5.Default), (Type)null, array3, array4)), (ParameterModifier[])(object)@class.t(bindingFlags, array, obj, cultureInfo)), (Type)(object)Class5.Default, cultureInfo), obj, null);
		try
		{
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class8)(object)@class.e(bindingFlags, null, array3, array4);
			}
			else
			{
				do
				{
					Class7 class32 = @class;
					MethodBase[] methodBase_5 = array2;
					ParameterModifier[] parameterModifier_3 = array4;
					Class7 class33 = @class;
					bindingFlags = default(BindingFlags);
					class11 = (Class0)(object)class32.j(default(BindingFlags), methodBase_5, ref *(object[]*)null, parameterModifier_3, (CultureInfo)(object)class33.W(bindingFlags, propertyInfo_2, type, array3, null), null, out *(object*)null);
				}
				while (obj != null);
			}
			goto IL_1826;
		}
		IL_0572:
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					class30 = null;
					class30 = null;
					qk = qk;
					_ = (GClass2)(object)@class.t(bindingFlags, array, obj, null);
					Class7 class34 = @class;
					bindingFlags = default(BindingFlags);
					class30 = (Class10)(object)class34.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array4);
				}
				finally
				{
					@class = @class;
					gClass4 = null;
					goto end_IL_057b;
				}
				end_IL_057b:;
			}
			catch
			{
				while (obj != null)
				{
					class17 = (Class8)(object)Class5.Default;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					qk = null;
				}
				finally
				{
					@class = @class;
					continue;
				}
			}
		}
		_ = (Class9)(object)Class5.Default;
		_ = Class5.Default;
		_ = (Class2)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Class10)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null);
					gClass = null;
					class15 = class15;
				}
				catch
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, cultureInfo);
				}
			}
			while (obj != null);
			goto IL_0a87;
		}
		try
		{
			_ = (Class4)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, null, (ParameterModifier[])(object)Class5.Default);
		}
		finally
		{
			Class7 class35 = @class;
			BindingFlags bindingFlags_22 = bindingFlags;
			Class7 obj35 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_23 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			object object_8 = ((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array2, ref reference, array4, cultureInfo, (string[])(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array5, out *(object*)null)).t(bindingFlags, null, obj, cultureInfo), out object_), null, null, null), type, array3, null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)@class.t((BindingFlags)((Class7)null).t(obj, type, cultureInfo), array, obj, cultureInfo), array4, cultureInfo, array5, out object_), (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
			Class7 class36 = @class;
			BindingFlags bindingFlags_24 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_2, null, array3, array4));
			MethodBase[] methodBase_6 = array2;
			ref object[] object_9 = ref *(object[]*)((Class7)(object)@class.t(default(BindingFlags), (FieldInfo[])@class.t(obj, type, (CultureInfo)(object)Class5.Default), obj, cultureInfo)).t(obj, type, (CultureInfo)(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			class11 = (Class0)(object)class35.W(bindingFlags_22, null, (Type)(object)obj35.t(bindingFlags_23, fieldInfo_3, object_8, (CultureInfo)(object)class36.j(bindingFlags_24, methodBase_6, ref object_9, null, null, null, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(obj, type, null), array3, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array2, (Type[])(object)Class5.Default, array4)))), array3, null);
			goto IL_0a87;
		}
		IL_3cc0:
		Class7 class38;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					@class = (Class7)@class.t(obj, type, cultureInfo);
					@struct = (Struct1)Class5.Default;
					Class7 class37 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class37.W(bindingFlags, null, type, null, array4);
					_ = (Class10)(object)@class.t(bindingFlags, null, null, cultureInfo);
				}
			}
			else
			{
				try
				{
					class21 = (Class2)((Class7)null).t(obj, (Type)null, (CultureInfo)null);
				}
				catch
				{
					@class = null;
				}
			}
			class38 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class38.t(bindingFlags, array, null, null) != null);
		try
		{
			BindingFlags bindingFlags_25 = bindingFlags;
			Class7 class39 = @class;
			object object_10 = obj;
			Type type_4 = (Type)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
			Class7 class40 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_26 = bindingFlags;
			ref object[] object_11 = ref reference;
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			_003CModule_003E = (_003CModule_003E)(object)((Class7)null).e(bindingFlags_25, (MethodBase[])class39.t(object_10, type_4, (CultureInfo)(object)((Class7)null).e((BindingFlags)class40.j(bindingFlags_26, null, ref object_11, (ParameterModifier[])((Class7)null).t((object)class41.e(bindingFlags, array2, (Type[])(object)((Class7)null).t(bindingFlags, array, obj, (CultureInfo)null), array4), type, cultureInfo), null, (string[])(object)Class5.Default, out object_), (MethodBase[])null, (Type[])null, array4)), array3, (ParameterModifier[])null);
		}
		catch
		{
			_ = (Class9)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = Class5.Default;
				}
				while (obj != null);
			}
			goto IL_3df8;
		}
		IL_1fb6:
		while (obj != null)
		{
		}
		try
		{
			qk = null;
			class4 = class4;
			_ = (Class10)(object)@class.e(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), (Type[])(object)Class5.Default, null);
			struct2 = struct2;
		}
		catch
		{
			while (obj != null)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				struct2 = struct2;
			}
		}
		while ((object)@class.t(bindingFlags, array, null, (CultureInfo)(object)@class.W(bindingFlags, propertyInfo_2, type, null, null)) != null);
		Class7 class42 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			nuint num2 = unchecked((nuint)(UIntPtr)class42.W(bindingFlags, propertyInfo_2, type, null, null)) + unchecked((nuint)(UIntPtr)Class5.Default);
			uIntPtr = default(UIntPtr);
			if (num2 - uIntPtr == 0)
			{
				try
				{
					class21 = (Class2)(object)Class5.Default;
				}
				catch
				{
					Class7 obj39 = (Class7)@class.t(obj, type, cultureInfo);
					bindingFlags = default(BindingFlags);
					class11 = (Class0)(object)obj39.W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, array2, ref *unchecked((object[]*)Class5.Default), array4, cultureInfo, array5, out object_), (Type)(object)@class.W(bindingFlags, propertyInfo_2, type, (Type[])(object)((Class7)null).W(bindingFlags, propertyInfo_2, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null), array3, (ParameterModifier[])(object)Class5.Default);
					gClass2 = null;
					class21 = (Class2)(object)Class5.Default;
				}
			}
			else
			{
				nuint num3 = uIntPtr;
				UIntPtr num4 = unchecked((UIntPtr)Class5.Default);
				uIntPtr = default(UIntPtr);
				nuint num5 = uIntPtr * uIntPtr + uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num6;
				nuint num7;
				unchecked
				{
					num6 = num3 / checked(unchecked((nuint)num4) + (unchecked((nuint)default(UIntPtr)) + unchecked(num5 / (unchecked((nuint)default(UIntPtr)) / uIntPtr))));
					num7 = uIntPtr;
					uIntPtr = default(UIntPtr);
				}
				if (num6 + unchecked(num7 / uIntPtr) == 0)
				{
					qk = qk;
				}
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4)) == (UIntPtr)(nuint)0u)
		{
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj41 = (Class7)(object)class43.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array4, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array2, ref *(object[]*)Class5.Default, array4, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, array4), array5, out *(object*)Class5.Default), out object_);
			BindingFlags bindingFlags_27 = bindingFlags;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			ref object[] object_12 = ref *(object[]*)@class.e((BindingFlags)Class5.Default, null, null, array4);
			CultureInfo cultureInfo_2 = (CultureInfo)@class.t(null, (Type)(object)Class5.Default, null);
			string[] string_2 = array5;
			Class7 class44 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_28 = bindingFlags;
			Class7 class45 = @class;
			object object_13 = obj;
			Type type_5 = type;
			Class7 obj42 = (Class7)(object)((Class7)null).e(bindingFlags, array2, array3, array4);
			bindingFlags = default(BindingFlags);
			Class7 obj43 = (Class7)(object)obj42.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)(object)@class.t(bindingFlags, null, obj, cultureInfo)).t(((Class7)null).t(obj, (Type)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null), (CultureInfo)null), type, cultureInfo), array3, (ParameterModifier[])((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.t(bindingFlags, array, obj, (CultureInfo)(object)Class5.Default), array5, out *(object*)Class5.Default)).t(obj, type, cultureInfo)), cultureInfo, array5, out object_);
			BindingFlags bindingFlags_29 = bindingFlags;
			Class7 class46 = @class;
			BindingFlags bindingFlags_30 = bindingFlags;
			MethodBase[] methodBase_8 = array2;
			Type[] type_6 = array3;
			Class7 class47 = @class;
			object object_14 = Class5.Default;
			Type type_7 = type;
			Class7 class48 = @class;
			BindingFlags bindingFlags_31 = bindingFlags;
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj44 = (Class7)class45.t(object_13, type_5, (CultureInfo)(object)obj43.e(bindingFlags_29, null, (Type[])((Class7)(object)class46.e(bindingFlags_30, methodBase_8, type_6, (ParameterModifier[])class47.t(object_14, type_7, (CultureInfo)(object)class48.j(bindingFlags_31, (MethodBase[])(object)class49.j(bindingFlags, array2, ref reference, null, (CultureInfo)(object)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array4, cultureInfo, null, out object_), null, out *(object*)@class.e(bindingFlags, null, array3, null)), ref reference, array4, cultureInfo, array5, out *(object*)null)))).t(obj, (Type)(object)((Class7)null).W(default(BindingFlags), propertyInfo_2, (Type)(object)Class5.Default, array3, (ParameterModifier[])null), cultureInfo), array4));
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)obj41.j(bindingFlags_27, methodBase_7, ref object_12, null, cultureInfo_2, string_2, out *(object*)class44.e(bindingFlags_28, null, (Type[])(object)obj44.t(bindingFlags, array, obj, cultureInfo), (ParameterModifier[])(object)Class5.Default));
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				UIntPtr num8 = (UIntPtr)((Class7)null).W((BindingFlags)@class.t(obj, (Type)(object)Class5.Default, null), (PropertyInfo[])((Class7)null).t(obj, type, cultureInfo), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				uIntPtr = default(UIntPtr);
				if (checked(unchecked((nuint)num8) - uIntPtr) == 0)
				{
					BindingFlags bindingFlags_32 = bindingFlags;
					MethodBase[] methodBase_9 = array2;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_3 = cultureInfo;
					string[] string_3 = (string[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).W((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags_32, methodBase_9, ref *(object[]*)null, parameterModifier_4, cultureInfo_3, string_3, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).j((BindingFlags)Class5.Default, array2, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null), (Type[])(object)Class5.Default, (ParameterModifier[])null))).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4), propertyInfo_2, (Type)(object)Class5.Default, array3, array4);
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			else if ((UIntPtr)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.e(bindingFlags, array2, array3, (ParameterModifier[])(object)Class5.Default), (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
			{
				class15 = (Class4)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4);
			}
		}
		try
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)@class.t(obj, null, null)) - uIntPtr) == 0)
				{
					gClass2 = gClass2;
				}
				else
				{
					_ = (GClass1)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, obj, cultureInfo), ref reference, array4, null, (string[])@class.t(Class5.Default, null, cultureInfo), out *(object*)null);
				}
			}
			catch
			{
				Class7 class50 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class50.e(bindingFlags, array2, null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					class15 = class15;
				}
				else
				{
					_ = (Class6)@class.t(obj, null, null);
				}
			}
		}
		catch
		{
			while (obj != null)
			{
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)@class.j((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_2, type, (Type[])(object)Class5.Default, array4), array2, ref *(object[]*)null, array4, cultureInfo, null, out *(object*)Class5.Default)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					if (unchecked((UIntPtr)((Class7)null).t((object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_2, null, array3, null), (Type)null, cultureInfo) == (UIntPtr)(nuint)0u))
					{
						_ = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array3, null);
						_ = (Class2)(object)Class5.Default;
					}
					else
					{
						_ = (Struct2)Class5.Default;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + (unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array2, ref *(object[]*)null, array4, cultureInfo, array5, out object_)) - uIntPtr) == 0)
					{
						Class7 class51 = @class;
						BindingFlags bindingFlags_33 = bindingFlags;
						MethodBase[] methodBase_10 = array2;
						Class7 class52 = @class;
						BindingFlags bindingFlags_34 = unchecked((BindingFlags)Class5.Default);
						MethodBase[] methodBase_11 = array2;
						bindingFlags = default(BindingFlags);
						@struct = (Struct1)class51.e(bindingFlags_33, methodBase_10, (Type[])(object)class52.e(bindingFlags_34, methodBase_11, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, propertyInfo_2, type, array3, array4)), (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default)).W(bindingFlags, null, (Type)(object)((Class7)((Class7)null).t(obj, (Type)null, cultureInfo)).W(bindingFlags, (PropertyInfo[])@class.t(Class5.Default, null, cultureInfo), type, array3, null), null, array4), null, null, array4));
					}
				}
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array2, array3, array4)) + uIntPtr == 0)
				{
					_ = (GClass3)(object)((Class7)null).t(unchecked((BindingFlags)Class5.Default), array, (object)Class5.Default, (CultureInfo)null);
				}
			}
			finally
			{
				struct2 = (Struct2)((Class7)null).t(obj, (Type)((Class7)(object)Class5.Default).t(null, null, null), cultureInfo);
				goto IL_2afb;
			}
		}
		IL_1d4f:
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				class21 = class21;
				_ = (_003CModule_003E)(object)Class5.Default;
				class15 = null;
				Class7 class53 = @class;
				BindingFlags bindingFlags_35 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
				BindingFlags bindingFlags_36 = bindingFlags;
				Class7 class54 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj48 = (Class7)(object)class53.W(bindingFlags_35, propertyInfo_5, (Type)(object)((Class7)null).j(bindingFlags_36, (MethodBase[])(object)class54.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out object_), ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out object_), null, array4);
				BindingFlags bindingFlags_37 = bindingFlags;
				FieldInfo[] fieldInfo_4 = array;
				object object_15 = ((Class7)(object)Class5.Default).t(null, type, cultureInfo);
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)((Class7)(object)obj48.t(bindingFlags_37, fieldInfo_4, object_15, (CultureInfo)(object)class55.t(bindingFlags, array, null, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)(object)@class.e(bindingFlags, null, array3, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null)))).j(bindingFlags, array2, ref reference, array4, cultureInfo, (string[])(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array4), out object_);
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					gClass2 = gClass2;
				}
			}
		}
		while (obj != null)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			while (obj != null)
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			_ = (Qk7)(object)@class.W(bindingFlags, null, null, (Type[])(object)((Class7)null).W(bindingFlags, propertyInfo_2, (Type)(object)Class5.Default, array3, array4), (ParameterModifier[])(object)((Class7)null).t((BindingFlags)@class.t(obj, type, null), array, obj, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, null, obj, null)));
			goto IL_1fb6;
		}
		IL_3a37:
		try
		{
			while (obj != null)
			{
				while (@class.t(null, null, cultureInfo) != null)
				{
					class4 = class4;
					_ = (_003CModule_003E)(object)Class5.Default;
					struct2 = (Struct2)Class5.Default;
				}
			}
		}
		catch
		{
			class5 = Class5.Default;
		}
		while (obj != null)
		{
			do
			{
				class4 = class4;
				@class = @class;
				_ = (Qk7)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
			}
			while ((object)Class5.Default != null);
		}
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
		}
		try
		{
			try
			{
				_ = (GClass3)@class.t(Class5.Default, type, cultureInfo);
			}
			finally
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
					gClass3 = gClass3;
				}
				catch
				{
					_ = (Struct1)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					gClass4 = null;
				}
				goto end_IL_3ad9;
			}
			end_IL_3ad9:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo)).W(bindingFlags, null, type, (Type[])(object)((Class7)null).t(default(BindingFlags), array, (object)null, (CultureInfo)(object)Class5.Default), array4);
					@class = null;
				}
				else
				{
					class4 = (Class9)(object)Class5.Default;
				}
				goto IL_3cc0;
			}
			try
			{
				_ = (Struct1)Class5.Default;
			}
			finally
			{
				gClass4 = (GClass1)(object)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo);
				goto IL_3cc0;
			}
		}
		IL_558d:
		if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)@class.t(obj, (Type)(object)Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
					_ = (Qk7)(object)Class5.Default;
					_ = (Class8)((Class7)null).t(obj, type, cultureInfo);
					_ = (Class2)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_55e4;
				}
				end_IL_55e4:;
			}
			catch
			{
				try
				{
					gClass2 = gClass2;
					qk = (Qk7)(object)Class5.Default;
				}
				catch
				{
					_ = (Class0)(object)((Class7)null).W(bindingFlags, propertyInfo_2, (Type)null, array3, array4);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					_ = (Struct1)Class5.Default;
				}
				else
				{
					class4 = null;
				}
			}
			while (obj != null);
		}
		else
		{
			gClass = gClass;
		}
		class17 = class17;
		class5 = class5;
		while (obj != null)
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		do
		{
			try
			{
				@struct = (Struct1)Class5.Default;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class8)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				try
				{
					@struct = @struct;
					_ = (GClass3)(object)@class.W(bindingFlags, propertyInfo_2, type, null, null);
					Class7 class56 = @class;
					BindingFlags bindingFlags_38 = bindingFlags;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)class56.e(bindingFlags_38, (MethodBase[])(object)class57.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, null, cultureInfo), null, array5, out *(object*)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_2, type, null, array4)), (Type[])(object)Class5.Default, array4);
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_5753;
				}
				end_IL_5753:;
			}
			finally
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
				goto end_IL_5752;
			}
			end_IL_5752:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					class5 = Class5.Default;
				}
				catch
				{
					@struct = @struct;
				}
			}
			else
			{
				gClass = null;
			}
			goto IL_5867;
		}
		IL_4790:
		gClass2 = (GClass2)(object)((Class7)(object)((Class7)@class.t(null, null, cultureInfo)).W((BindingFlags)Class5.Default, propertyInfo_2, (Type)(object)((Class7)null).j(default(BindingFlags), array2, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_), null, array4)).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo), ref reference, array4, cultureInfo, array5, out *(object*)null), out *(object*)Class5.Default);
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
					@struct = (Struct1)Class5.Default;
					goto end_IL_487d;
				}
				end_IL_487d:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class3 = (Class6)(object)Class5.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class30 = class30;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					class17 = class17;
				}
				catch
				{
					gClass3 = gClass3;
				}
			}
		}
		UIntPtr num9 = uIntPtr;
		Class7 class58 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_39 = bindingFlags;
		Class7 class59 = @class;
		BindingFlags bindingFlags_40 = bindingFlags;
		MethodBase[] methodBase_12 = array2;
		Type[] type_8 = array3;
		Class7 class60 = @class;
		bindingFlags = default(BindingFlags);
		UIntPtr num10 = (UIntPtr)((Class7)(object)class58.e(bindingFlags_39, null, (Type[])(object)class59.e(bindingFlags_40, methodBase_12, type_8, (ParameterModifier[])(object)class60.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default)), (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4))).t(obj, null, cultureInfo);
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num9) * (unchecked((nuint)num10) * uIntPtr) == 0)
			{
				class5 = class5;
			}
			do
			{
				try
				{
					while ((object)Class5.Default != null)
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
				catch
				{
					if (uIntPtr == 0)
					{
						gClass4 = gClass4;
					}
					else
					{
						qk = (Qk7)(object)Class5.Default;
					}
				}
			}
			while (obj != null);
			try
			{
				struct2 = struct2;
			}
			catch
			{
				while (true)
				{
					Class7 class61 = @class;
					BindingFlags bindingFlags_41 = bindingFlags;
					bindingFlags = default(BindingFlags);
					if ((object)class61.W(bindingFlags_41, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null), (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, (ParameterModifier[])null), array3, null) != null)
					{
						if (uIntPtr == 0)
						{
							class4 = null;
						}
						continue;
					}
					break;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				nuint num11 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num11 + uIntPtr == 0)
				{
					try
					{
						_ = (GClass1)(object)Class5.Default;
					}
					finally
					{
						_ = (Class7)(object)@class.W(unchecked((BindingFlags)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null)), null, type, null, array4);
						goto IL_4bdb;
					}
				}
			}
			else
			{
				while (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
					class3 = (Class6)(object)Class5.Default;
					class11 = class11;
				}
			}
			goto IL_4bdb;
		}
		IL_4c76:
		try
		{
			try
			{
				Class7 class62 = @class;
				BindingFlags bindingFlags_42 = bindingFlags;
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_43 = bindingFlags;
				Class7 class64 = @class;
				object object_16 = @class.e((BindingFlags)Class5.Default, null, array3, null);
				Type type_9 = type;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_13 = (MethodBase[])(object)((Class7)(object)((Class7)(object)class63.W(bindingFlags_43, propertyInfo_2, (Type)class64.t(object_16, type_9, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4)), array3, (ParameterModifier[])(object)@class.e(bindingFlags, array2, array3, array4))).W(bindingFlags, null, (Type)(object)Class5.Default, null, null)).W(bindingFlags, null, type, (Type[])(object)((Class7)(object)@class.W(bindingFlags, propertyInfo_2, type, (Type[])(object)Class5.Default, array4)).j(bindingFlags, array2, ref *(object[]*)null, array4, cultureInfo, (string[])(object)((Class7)null).e((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, null, out *(object*)null), array2, array3, array4), out *(object*)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo)), array4);
				ref object[] object_17 = ref reference;
				CultureInfo cultureInfo_4 = cultureInfo;
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)((Class7)(object)class62.j(bindingFlags_42, methodBase_13, ref object_17, null, cultureInfo_4, null, out *(object*)class65.e(bindingFlags, null, array3, array4))).t(obj, type, cultureInfo);
			}
			finally
			{
				try
				{
					gClass = gClass;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
				}
				goto end_IL_4c77;
			}
			end_IL_4c77:;
		}
		finally
		{
			class5 = class5;
			goto IL_4e62;
		}
		IL_33c4:
		_003CModule_003E = _003CModule_003E;
		try
		{
			while (obj != null)
			{
				try
				{
					struct2 = struct2;
				}
				catch
				{
					gClass4 = gClass4;
				}
			}
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (Qk7)(object)Class5.Default;
					gClass2 = null;
					class5 = class5;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					BindingFlags bindingFlags_44 = bindingFlags;
					MethodBase[] methodBase_14 = (MethodBase[])(object)Class5.Default;
					ref object[] object_18 = ref reference;
					Class7 obj63 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).j(bindingFlags_44, methodBase_14, ref object_18, (ParameterModifier[])(object)obj63.W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, array, obj, null), null, null, null), cultureInfo, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null), out object_);
				}
				goto IL_34b8;
			}
		}
		IL_0a87:
		do
		{
			object object_19 = obj;
			Class7 class66 = @class;
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_15 = (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_);
			Type[] type_10 = array3;
			Class7 class67 = @class;
			BindingFlags bindingFlags_46 = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_47 = bindingFlags;
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			Type[] type_11 = (Type[])(object)class68.t(bindingFlags, null, obj, null);
			Class7 class69 = @class;
			BindingFlags bindingFlags_48 = bindingFlags;
			ref object[] object_20 = ref *(object[]*)((Class7)null).t(obj, type, cultureInfo);
			ParameterModifier[] parameterModifier_5 = array4;
			CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
			Class7 class70 = @class;
			BindingFlags bindingFlags_49 = bindingFlags;
			MethodBase[] methodBase_16 = array2;
			ref object[] object_21 = ref reference;
			Class7 class71 = @class;
			bindingFlags = default(BindingFlags);
			ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)class71.j(bindingFlags, array2, ref *(object[]*)null, array4, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.j(default(BindingFlags), array2, ref reference, null, null, array5, out object_), cultureInfo, array5, out object_), array5, out *(object*)Class5.Default);
			Class7 obj64 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(object_19, (Type)null, (CultureInfo)(object)class66.e(bindingFlags_45, methodBase_15, type_10, (ParameterModifier[])(object)class67.W(bindingFlags_46, null, (Type)(object)((Class7)null).e(bindingFlags_47, (MethodBase[])null, type_11, (ParameterModifier[])(object)class69.j(bindingFlags_48, null, ref object_20, parameterModifier_5, cultureInfo_5, (string[])(object)class70.j(bindingFlags_49, methodBase_16, ref object_21, parameterModifier_6, null, (string[])(object)((Class7)null).W((BindingFlags)obj64.W(bindingFlags, propertyInfo_2, type, null, null), (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array4), out object_), out *(object*)null)), null, null))) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					qk = (Qk7)(object)((Class7)null).t(bindingFlags, array, obj, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default));
					_ = (GClass2)(object)Class5.Default;
					BindingFlags bindingFlags_50 = bindingFlags;
					Type type_12 = type;
					Class7 class72 = @class;
					BindingFlags bindingFlags_51 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					struct2 = (Struct2)((Class7)null).W(bindingFlags_50, (PropertyInfo[])null, type_12, (Type[])null, (ParameterModifier[])(object)class72.W(bindingFlags_51, propertyInfo_6, null, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)@class.e(bindingFlags, array2, array3, array4), array4, (CultureInfo)null, array5, out *(object*)Class5.Default)));
					@class = @class;
				}
				else
				{
					gClass4 = gClass4;
					qk = qk;
					gClass3 = gClass3;
					gClass3 = gClass3;
				}
			}
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Class7 class76;
			do
			{
				Class7 class73 = @class;
				BindingFlags bindingFlags_52 = bindingFlags;
				Class7 class74 = @class;
				BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
				BindingFlags bindingFlags_54 = bindingFlags;
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				class30 = (Class10)(object)class73.e(bindingFlags_52, null, (Type[])(object)class74.W(bindingFlags_53, propertyInfo_2, (Type)(object)((Class7)null).j(bindingFlags_54, (MethodBase[])null, ref *(object[]*)((Class7)(object)class75.t(bindingFlags, null, obj, null)).t(bindingFlags, array, obj, null), array4, (CultureInfo)null, (string[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo), out *(object*)null), null, null), array4);
				class76 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class76.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array3, array4), type, null, null) != null || obj != null);
		}
		_ = (Class0)(object)Class5.Default;
		_ = (Class6)(object)Class5.Default;
		checked
		{
			while (obj != null)
			{
				try
				{
					Class7 class77 = @class;
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					if (unchecked((nuint)(UIntPtr)((Class7)class77.t(class78.j(bindingFlags, null, ref *(object[]*)null, array4, cultureInfo, array5, out *(object*)null), type, null)).t(obj, (Type)(object)Class5.Default, cultureInfo)) * uIntPtr == 0)
					{
						_ = (GClass2)(object)@class.j(bindingFlags, array2, ref reference, array4, null, array5, out object_);
						_ = (Struct1)@class.t(null, null, null);
					}
					else
					{
						class4 = class4;
					}
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						@class = @class;
					}
					else
					{
						gClass2 = gClass2;
					}
					continue;
				}
			}
			try
			{
				_ = (Class8)(object)Class5.Default;
				_ = (Struct1)Class5.Default;
				_ = (Class10)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
			class30 = class30;
			class17 = null;
			class21 = null;
			_ = (GClass0)(object)Class5.Default;
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					Class7 class79 = @class;
					BindingFlags bindingFlags_55 = bindingFlags;
					MethodBase[] methodBase_17 = array2;
					Class7 obj66 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_56 = bindingFlags;
					Class7 class80 = @class;
					Type type_13 = type;
					Class7 obj67 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)((Class7)null).t((object)class79.e(bindingFlags_55, methodBase_17, (Type[])(object)obj66.W(bindingFlags_56, propertyInfo_2, null, (Type[])class80.t(null, type_13, (CultureInfo)(object)obj67.e(bindingFlags, array2, null, null)), array4), null), type, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4));
				}
			}
			finally
			{
				class21 = class21;
				_ = (GClass1)(object)Class5.Default;
				goto IL_0fc9;
			}
		}
		goto IL_0fc9;
		IL_34b8:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
				else
				{
					Class7 class81 = @class;
					object object_22 = obj;
					Class7 class82 = @class;
					BindingFlags bindingFlags_57 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = (PropertyInfo[])((Class7)null).t((object)Class5.Default, type, cultureInfo);
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj68 = (Class7)((Class7)(object)class83.W(bindingFlags, propertyInfo_2, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null))).t(Class5.Default, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class2)class81.t(object_22, null, (CultureInfo)(object)class82.W(bindingFlags_57, propertyInfo_7, (Type)(object)obj68.W(bindingFlags, null, type, (Type[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, array4)), null, array4));
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				finally
				{
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class84.W(bindingFlags, null, (Type)((Class7)(object)Class5.Default).t(null, type, cultureInfo), (Type[])(object)Class5.Default, array4);
					continue;
				}
			}
			goto IL_36cc;
		}
		IL_4ee1:
		try
		{
			do
			{
				struct2 = default(Struct2);
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class4)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4) != null);
			}
			catch
			{
				try
				{
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, (ParameterModifier[])(object)Class5.Default);
					goto end_IL_4f36;
				}
				catch
				{
					class3 = null;
					goto end_IL_4f36;
				}
				end_IL_4f36:;
			}
		}
		try
		{
			Class7 class85 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class85.j(bindingFlags, array2, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				class30 = (Class10)(object)Class5.Default;
				_ = (Class0)(object)Class5.Default;
				@class = null;
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass = null;
			}
			else
			{
				class17 = null;
				Class7 class86 = @class;
				BindingFlags bindingFlags_58 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array;
				Class7 class87 = @class;
				BindingFlags bindingFlags_59 = bindingFlags;
				MethodBase[] methodBase_18 = array2;
				ref object[] object_23 = ref reference;
				ParameterModifier[] parameterModifier_7 = array4;
				Class7 obj72 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)class86.t(null, (Type)(object)((Class7)null).t(bindingFlags_58, fieldInfo_5, (object)((Class7)null).t((BindingFlags)((Class7)(object)class87.j(bindingFlags_59, methodBase_18, ref object_23, parameterModifier_7, (CultureInfo)(object)obj72.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, array4, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo)), ref reference, (ParameterModifier[])@class.t(obj, type, (CultureInfo)(object)Class5.Default), cultureInfo, null, out *(object*)null), array5, out object_)).t(((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), null, (CultureInfo)(object)Class5.Default), array, obj, (CultureInfo)null), (CultureInfo)(object)Class5.Default), cultureInfo);
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_60 = bindingFlags;
					Class7 class88 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).t(bindingFlags_60, (FieldInfo[])null, (object)class88.j(bindingFlags, array2, ref reference, array4, cultureInfo, array5, out object_), (CultureInfo)((Class7)null).t((object)Class5.Default, type, cultureInfo));
				}
				finally
				{
					qk = (Qk7)(object)@class.t(bindingFlags, null, obj, cultureInfo);
					class4 = null;
					goto IL_51b6;
				}
			}
			_ = (Class10)(object)Class5.Default;
			goto IL_51b6;
		}
		IL_3df8:
		if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array3, null))) == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
				Class7 obj76;
				do
				{
					_ = (Class10)(object)Class5.Default;
					Class7 obj73 = (Class7)(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, propertyInfo_2, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_2, null, array3, array4)), null, null), propertyInfo_2, type, array3, array4);
					BindingFlags bindingFlags_61 = bindingFlags;
					MethodBase[] methodBase_19 = array2;
					Class7 class89 = @class;
					BindingFlags bindingFlags_62 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					Class7 class90 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					Class7 class91 = @class;
					BindingFlags bindingFlags_64 = (BindingFlags)@class.t((BindingFlags)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)((Class7)null).t((BindingFlags)@class.W((BindingFlags)@class.W((BindingFlags)Class5.Default, null, null, array3, null), null, type, null, array4), (FieldInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])@class.t(obj, null, cultureInfo), (ParameterModifier[])(object)Class5.Default), ref *(object[]*)Class5.Default, array4, cultureInfo, array5, out object_)), obj, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array4)), null, null, null, out *(object*)((Class7)null).t(obj, (Type)null, (CultureInfo)null)), (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, array, null, null), null, null);
					MethodBase[] methodBase_20 = (MethodBase[])(object)@class.t(bindingFlags, array, ((Class7)@class.t(null, null, null)).W(bindingFlags, propertyInfo_2, type, (Type[])(object)Class5.Default, array4), (CultureInfo)(object)Class5.Default);
					ref object[] object_24 = ref reference;
					Class7 class92 = @class;
					BindingFlags bindingFlags_65 = bindingFlags;
					Type[] type_14 = array3;
					Class7 obj74 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_66 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)@class.W((BindingFlags)@class.j(bindingFlags, array2, ref *(object[]*)null, array4, cultureInfo, array5, out *(object*)Class5.Default), propertyInfo_2, (Type)(object)Class5.Default, array3, array4);
					BindingFlags bindingFlags_67 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_7 = array;
					object object_25 = obj;
					BindingFlags bindingFlags_68 = bindingFlags;
					MethodBase[] methodBase_21 = array2;
					Class7 class93 = @class;
					BindingFlags bindingFlags_69 = bindingFlags;
					MethodBase[] methodBase_22 = array2;
					ref object[] object_26 = ref reference;
					ParameterModifier[] parameterModifier_8 = array4;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 class94 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj75 = (Class7)(object)class92.e(bindingFlags_65, null, type_14, (ParameterModifier[])(object)obj74.W(bindingFlags_66, propertyInfo_8, (Type)(object)((Class7)null).t(bindingFlags_67, fieldInfo_7, object_25, (CultureInfo)(object)((Class7)null).j(bindingFlags_68, methodBase_21, ref *(object[]*)class93.j(bindingFlags_69, methodBase_22, ref object_26, parameterModifier_8, cultureInfo_6, (string[])(object)((Class7)null).W((BindingFlags)class94.W(bindingFlags, null, (Type)(object)@class.e(bindingFlags, array2, array3, null), null, array4), propertyInfo_2, type, array3, array4), out object_), (ParameterModifier[])null, (CultureInfo)null, array5, out object_)), array3, null));
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 class95 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj73.j(bindingFlags_61, methodBase_19, ref *(object[]*)class89.t(bindingFlags_62, fieldInfo_6, null, (CultureInfo)(object)class90.e(bindingFlags_63, null, (Type[])(object)class91.j(bindingFlags_64, methodBase_20, ref object_24, (ParameterModifier[])(object)obj75.t(bindingFlags_70, null, null, (CultureInfo)((Class7)(object)class95.W(bindingFlags, propertyInfo_2, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)@class.e(bindingFlags, array2, array3, array4)).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, null, array5, out object_), propertyInfo_2, type, array3, array4), null, array4)).t(null, type, (CultureInfo)(object)((Class7)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, null)).j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, array5, out object_))), (CultureInfo)((Class7)null).t((object)null, type, cultureInfo), array5, out *(object*)((Class7)null).t(obj, type, (CultureInfo)null)), (ParameterModifier[])((Class7)null).t((object)@class.W(default(BindingFlags), null, type, null, array4), (Type)null, (CultureInfo)null))), null, cultureInfo, (string[])(object)Class5.Default, out object_);
					obj76 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				while ((object)obj76.j(bindingFlags, array2, ref reference, array4, null, (string[])(object)Class5.Default, out object_) != null);
			}
		}
		try
		{
			gClass2 = gClass2;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				class3 = class3;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass2)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, array2, ref reference, array4, null, array5, out object_), null, array5, out object_);
				Class7 class96 = @class;
				object object_27 = Class5.Default;
				Type type_15 = type;
				Class7 obj79 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_71 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)((Class7)null).W((BindingFlags)class96.t(object_27, type_15, (CultureInfo)(object)obj79.W(bindingFlags_71, null, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array3, array4), array3, null)), (PropertyInfo[])(object)Class5.Default, type, array3, array4);
				gClass = gClass;
			}
			catch
			{
				gClass4 = gClass4;
			}
		}
		try
		{
			gClass2 = gClass2;
		}
		catch
		{
			try
			{
				struct2 = (Struct2)Class5.Default;
			}
			finally
			{
				class30 = (Class10)(object)Class5.Default;
				goto end_IL_44f8;
			}
			end_IL_44f8:;
		}
		while (true)
		{
			if (obj != null)
			{
				while ((object)@class.W(bindingFlags, null, type, null, null) != null)
				{
					Class7 class97 = @class;
					Class7 class98 = @class;
					BindingFlags bindingFlags_72 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_8 = array;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class97.W((BindingFlags)class98.t(bindingFlags_72, fieldInfo_8, ((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array, obj, (CultureInfo)(object)Class5.Default), (Type)null, (Type[])null, (ParameterModifier[])((Class7)null).t(obj, type, cultureInfo)), array, (object)null, cultureInfo), cultureInfo), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default);
					class3 = (Class6)(object)Class5.Default;
					@class = null;
					gClass = gClass;
				}
			}
			else
			{
				BindingFlags bindingFlags_73 = (BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, array2, array3, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, propertyInfo_2, (Type)(object)Class5.Default, array3, (ParameterModifier[])(object)Class5.Default);
				MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
				Type[] type_16 = (Type[])(object)@class.t((BindingFlags)Class5.Default, null, obj, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array3, null));
				Class7 class99 = @class;
				Class7 obj82 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_2, type, array3, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).e(bindingFlags_73, methodBase_23, type_16, (ParameterModifier[])(object)class99.t((BindingFlags)((Class7)(object)obj82.t(bindingFlags, array, ((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), array3, array4), null)).e(bindingFlags, array2, array3, (ParameterModifier[])(object)Class5.Default), array, obj, cultureInfo)) == null)
				{
					break;
				}
			}
		}
		try
		{
			class11 = null;
		}
		finally
		{
			do
			{
				class17 = class17;
			}
			while (obj != null);
			goto IL_4790;
		}
		IL_4e62:
		while (obj != null)
		{
			gClass = gClass;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					while ((object)Class5.Default != null)
					{
						gClass3 = gClass3;
					}
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr == 0)
					{
						class30 = (Class10)(object)Class5.Default;
					}
					else
					{
						_ = (GClass2)(object)Class5.Default;
					}
				}
				goto IL_4ee1;
			}
		}
		IL_2eba:
		uIntPtr = default(UIntPtr);
		nuint num12;
		nuint num13;
		checked
		{
			num12 = uIntPtr - uIntPtr;
			uIntPtr = default(UIntPtr);
			num13 = uIntPtr * uIntPtr;
		}
		nuint num14 = checked(unchecked((nuint)default(UIntPtr)) + unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default)) / (nuint)(UIntPtr)Class5.Default;
		Class7 class100 = @class;
		bindingFlags = default(BindingFlags);
		nuint num15;
		checked
		{
			num15 = num14 * unchecked((nuint)(UIntPtr)class100.t(bindingFlags, null, Class5.Default, cultureInfo));
			uIntPtr = default(UIntPtr);
		}
		if (checked(num12 + num13 * unchecked(num15 / checked(uIntPtr * uIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
					class11 = null;
					class17 = class17;
				}
				else
				{
					class4 = (Class9)@class.t(obj, type, null);
				}
			}
		}
		else if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, array2, array3, null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_74 = bindingFlags;
				ref object[] object_28 = ref *(object[]*)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)null).j(bindingFlags_74, (MethodBase[])null, ref object_28, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array3, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array4, null, array5, out *(object*)null)), (CultureInfo)(object)@class.W(bindingFlags, null, null, null, array4), (string[])null, out *(object*)null);
			}
			catch
			{
				BindingFlags bindingFlags_75 = (BindingFlags)((Class7)null).j(bindingFlags, array2, ref *(object[]*)null, array4, cultureInfo, (string[])(object)Class5.Default, out object_);
				Class7 obj83 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_76 = bindingFlags;
				Class7 obj84 = (Class7)(object)((Class7)null).t(default(BindingFlags), array, (object)null, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).e(bindingFlags_75, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)obj83.e(bindingFlags_76, (MethodBase[])(object)obj84.e(bindingFlags, array2, array3, array4), (Type[])(object)Class5.Default, array4));
				@struct = @struct;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			checked
			{
				if ((unchecked((nuint)(UIntPtr)@class.t(obj, type, cultureInfo)) - unchecked(uIntPtr / uIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					struct2 = struct2;
				}
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class8)(object)Class5.Default;
		}
		do
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			_ = (GClass3)(object)Class5.Default;
			_ = (Class4)(object)Class5.Default;
		}
		while (obj != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)@class.j(bindingFlags, array2, ref *(object[]*)@class.W(bindingFlags, propertyInfo_2, type, array3, array4), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out *(object*)((Class7)(object)Class5.Default).t(obj, type, cultureInfo)), (CultureInfo)null);
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr != 0)
			{
				nuint num16 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num16 + (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default)) != 0)
				{
					try
					{
						gClass2 = null;
					}
					finally
					{
						gClass4 = gClass4;
						goto IL_3291;
					}
				}
				_ = (GClass2)(object)Class5.Default;
			}
			goto IL_3291;
		}
		IL_2afb:
		do
		{
			class21 = class21;
		}
		while (obj != null || obj != null);
		while (obj != null)
		{
			do
			{
				try
				{
					@struct = @struct;
				}
				catch
				{
					class3 = class3;
					class21 = class21;
					_ = (Class10)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		while (obj != null)
		{
			try
			{
				while (true)
				{
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array4) != null)
					{
						_ = (GClass1)(object)Class5.Default;
						gClass = gClass;
						class15 = class15;
						continue;
					}
					break;
				}
			}
			catch
			{
				nuint num17 = uIntPtr;
				nuint num18 = checked(unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array4, cultureInfo, array5, out object_))) / uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num17 / checked(num18 + uIntPtr - uIntPtr) == 0)
				{
					class11 = class11;
				}
				else
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			class5 = class5;
		}
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)((Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo)).e(bindingFlags, array2, array3, array4);
				}
				else
				{
					@class = @class;
				}
			}
		}
		while ((object)Class5.Default != null);
		class3 = class3;
		_ = (Class10)(object)@class.t(bindingFlags, array, obj, cultureInfo);
		try
		{
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
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				class21 = null;
			}
			finally
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					_ = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array3, array4);
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (Struct2)@class.t(null, null, (CultureInfo)@class.t(obj, type, cultureInfo));
					_ = (_003CModule_003E)(object)@class.W(bindingFlags, propertyInfo_2, (Type)(object)Class5.Default, array3, null);
					goto end_IL_2cf0;
				}
			}
			end_IL_2cf0:;
		}
		try
		{
			class30 = (Class10)(object)Class5.Default;
		}
		finally
		{
			if (checked(unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)((Class7)null).t(bindingFlags, array, obj, cultureInfo) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = gClass2;
					Class7 class101 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class101.t(bindingFlags, null, obj, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, null, array5, out *(object*)null), array3, array4));
				}
				else
				{
					gClass3 = null;
				}
			}
			else
			{
				try
				{
					_ = (Class10)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo);
				}
				catch
				{
					_ = (Class2)(object)((Class7)null).W(bindingFlags, propertyInfo_2, (Type)null, (Type[])null, array4);
				}
			}
			goto IL_2eba;
		}
		IL_51b6:
		if ((UIntPtr)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class4 = null;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass4 = null;
					_ = (Class7)(object)Class5.Default;
					@class = null;
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					_ = Class5.Default;
				}
				goto IL_5526;
			}
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
			BindingFlags bindingFlags_77 = (BindingFlags)Class5.Default;
			Class7 class102 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_78 = bindingFlags;
			MethodBase[] methodBase_24 = array2;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct2)((Class7)(object)((Class7)null).t(bindingFlags_77, (FieldInfo[])(object)class102.j(bindingFlags_78, methodBase_24, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), ref reference, array4, (CultureInfo)null, array5, out *(object*)Class5.Default), null, null, array5, out object_), obj, cultureInfo)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), obj, null), (Type[])(object)@class.j(bindingFlags, null, ref reference, array4, cultureInfo, null, out *(object*)null), null), (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default), Class5.Default, cultureInfo);
			class3 = (Class6)(object)@class.t(bindingFlags, null, obj, cultureInfo);
		}
		catch
		{
			try
			{
				Class7 obj91 = (Class7)(object)Class5.Default;
				Class7 obj92 = (Class7)@class.t(@class.t((BindingFlags)Class5.Default, array, obj, null), type, (CultureInfo)(object)Class5.Default);
				BindingFlags bindingFlags_79 = bindingFlags;
				MethodBase[] methodBase_25 = array2;
				Class7 class103 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj93 = (Class7)(object)class103.e(bindingFlags, null, (Type[])(object)Class5.Default, array4);
				BindingFlags bindingFlags_80 = bindingFlags;
				Type[] type_17 = array3;
				Class7 obj94 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, null, cultureInfo), array3, (ParameterModifier[])@class.t(obj, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.e(bindingFlags, array2, null, array4), cultureInfo), cultureInfo));
				bindingFlags = default(BindingFlags);
				_ = (Struct2)obj91.t(((Class7)(object)obj92.e(bindingFlags_79, methodBase_25, (Type[])(object)obj93.W(bindingFlags_80, null, null, type_17, (ParameterModifier[])(object)obj94.e(bindingFlags, null, array3, array4)), array4)).t((BindingFlags)@class.e((BindingFlags)Class5.Default, null, array3, null), (FieldInfo[])(object)Class5.Default, null, cultureInfo), type, null);
			}
			finally
			{
				class17 = class17;
				goto end_IL_5397;
			}
			end_IL_5397:;
		}
		goto IL_5526;
	}

	unsafe static void p_00240()
	{
		_ = (Qk7)(object)Class5.Default;
		_ = (GClass2)(object)Class5.Default;
		Class7 @class = null;
		Class7 class2 = @class;
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		Type type = type;
		Type type_ = type;
		Type[] array = null;
		_ = (Class9)(object)class2.W(bindingFlags_, null, type_, array, null);
		Class7 class3 = @class;
		BindingFlags bindingFlags_2 = bindingFlags;
		ParameterModifier[] parameterModifier_ = null;
		BindingFlags bindingFlags_3 = (BindingFlags)((Class7)null).W(bindingFlags_2, (PropertyInfo[])null, (Type)null, array, parameterModifier_);
		FieldInfo[] array2 = array2;
		FieldInfo[] fieldInfo_ = array2;
		object obj = Class5.Default;
		CultureInfo cultureInfo = cultureInfo;
		_ = (_003CModule_003E)(object)class3.t(bindingFlags_3, fieldInfo_, obj, cultureInfo);
		Class9 class4 = class4;
		class4 = class4;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class5 = @class;
					BindingFlags bindingFlags_4 = bindingFlags;
					array3 = array3;
					MethodBase[] methodBase_ = array3;
					Class7 class6 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_5 = bindingFlags;
					MethodBase[] methodBase_2 = array3;
					Class7 class7 = @class;
					BindingFlags bindingFlags_6 = bindingFlags;
					MethodBase[] methodBase_3 = array3;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, type, cultureInfo), array, parameterModifier_), parameterModifier_)).t(default(BindingFlags), null, obj, cultureInfo);
					array4 = null;
					string[] string_ = array4;
					reference = ref reference;
					_ = (Class8)(object)class5.e(bindingFlags_4, methodBase_, (Type[])(object)class6.e(bindingFlags_5, methodBase_2, (Type[])(object)class7.j(bindingFlags_6, methodBase_3, ref *(object[]*)null, parameterModifier_2, null, string_, out reference), parameterModifier_), parameterModifier_);
				}
				catch
				{
					class4 = (Class9)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, null, null);
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)@class.t(obj, type, (CultureInfo)(object)Class5.Default);
			}
		}
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		_003CModule_003E = null;
		bindingFlags = default(BindingFlags);
		GClass2 obj3 = (GClass2)(object)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default);
		GClass2 gClass = (GClass2)(object)Class5.Default;
		gClass = obj3;
		_ = (Class4)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			Class7 class8 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_7 = bindingFlags;
			Class7 class9 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			MethodBase[] methodBase_4 = array3;
			Class7 obj4 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_9 = (BindingFlags)@class.t(obj, type, cultureInfo);
			Class7 class10 = @class;
			BindingFlags bindingFlags_10 = bindingFlags;
			array5 = (PropertyInfo[])(object)Class5.Default;
			_ = (Struct2)class8.e(bindingFlags_7, (MethodBase[])(object)class9.e(bindingFlags_8, methodBase_4, (Type[])(object)obj4.W(bindingFlags_9, null, (Type)class10.t(obj, (Type)(object)((Class7)null).W(bindingFlags_10, array5, type, (Type[])null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), null, parameterModifier_), parameterModifier_), array, parameterModifier_);
		}
		catch
		{
			try
			{
				@struct = (Struct2)Class5.Default;
				@struct = @struct;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = null;
					class11 = class11;
					class11 = class11;
					Class7 class12 = @class;
					BindingFlags bindingFlags_11 = bindingFlags;
					MethodBase[] methodBase_5 = (MethodBase[])(object)((Class7)(object)Class5.Default).W(default(BindingFlags), array5, type, (Type[])(object)Class5.Default, null);
					reference2 = ref reference2;
					_ = (Class0)(object)class12.j(bindingFlags_11, methodBase_5, ref reference2, parameterModifier_, cultureInfo, array4, out *(object*)null);
				}
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (Class9)(object)@class.t((BindingFlags)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, null, null, out reference), array2, Class5.Default, cultureInfo);
			}
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)((Class7)null).W(bindingFlags, array5, type, array, (ParameterModifier[])(object)Class5.Default);
			goto IL_048c;
		}
		IL_479b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					qk = (Qk7)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array2, null, cultureInfo), array, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj != null);
			}
		}
		_ = (Class7)(object)@class.t(bindingFlags, array2, Class5.Default, cultureInfo);
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				BindingFlags bindingFlags_12 = bindingFlags;
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_13 = bindingFlags;
				PropertyInfo[] propertyInfo_ = array5;
				Type type_2 = type;
				Class7 class14 = @class;
				BindingFlags bindingFlags_14 = bindingFlags;
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_6 = (MethodBase[])class13.t(obj, (Type)(object)((Class7)null).W(bindingFlags_13, propertyInfo_, type_2, array, (ParameterModifier[])(object)((Class7)(object)class14.W(bindingFlags_14, null, (Type)(object)class15.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default), null, null)).W((BindingFlags)Class5.Default, (PropertyInfo[])@class.t(obj, null, cultureInfo), (Type)(object)Class5.Default, array, null)), (CultureInfo)(object)@class.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default));
				BindingFlags bindingFlags_15 = bindingFlags;
				MethodBase[] methodBase_7 = array3;
				Class7 class16 = @class;
				Type type_3 = type;
				Class7 class17 = @class;
				Class7 class18 = @class;
				PropertyInfo[] propertyInfo_2 = array5;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)((Class7)null).j(bindingFlags_12, methodBase_6, ref *(object[]*)((Class7)null).e(bindingFlags_15, methodBase_7, (Type[])class16.t(obj, type_3, (CultureInfo)(object)class17.t((BindingFlags)class18.W(default(BindingFlags), propertyInfo_2, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, array2, obj, null), array4, out reference), array, parameterModifier_), (FieldInfo[])(object)Class5.Default, obj, cultureInfo)), parameterModifier_), (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference);
				continue;
			}
			try
			{
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
				Class7 obj7 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
				Class7 class20 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				Class7 class21 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_19 = bindingFlags;
				object object_ = Class5.Default;
				Class7 class22 = @class;
				BindingFlags bindingFlags_20 = bindingFlags;
				Class7 class23 = @class;
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)class23.t(bindingFlags, null, obj, cultureInfo);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_21 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = array5;
				Type type_4 = type;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)(object)class19.e(bindingFlags_16, methodBase_8, null, (ParameterModifier[])(object)obj7.e(bindingFlags_17, (MethodBase[])(object)class20.t(bindingFlags_18, (FieldInfo[])(object)class21.t(bindingFlags_19, null, object_, (CultureInfo)(object)class22.W(bindingFlags_20, propertyInfo_3, (Type)(object)((Class7)null).W(bindingFlags_21, propertyInfo_4, type_4, array, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out reference), (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null)), array, (ParameterModifier[])(object)Class5.Default)), Class5.Default, (CultureInfo)(object)Class5.Default), null, (ParameterModifier[])(object)Class5.Default))).W(bindingFlags, null, type, (Type[])(object)@class.W((BindingFlags)Class5.Default, array5, null, (Type[])(object)Class5.Default, null), (ParameterModifier[])(object)Class5.Default);
			}
			finally
			{
				_ = (Class5)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default);
				continue;
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class24);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					try
					{
						_ = (Class6)((Class7)null).t((object)null, type, cultureInfo);
					}
					finally
					{
						_ = (Class8)((Class7)(object)Class5.Default).t(null, type, null);
						_ = (Qk7)@class.t(null, null, (CultureInfo)(object)Class5.Default);
						class24 = class24;
						_ = (Class4)(object)Class5.Default;
						goto IL_4db4;
					}
				}
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto IL_4db4;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			try
			{
				_ = (Struct2)Class5.Default;
				Class7 class25 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class25.j(bindingFlags, array3, ref reference2, null, cultureInfo, array4, out *(object*)Class5.Default);
				class11 = null;
				Class7 class26 = @class;
				BindingFlags bindingFlags_22 = bindingFlags;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class26.e(bindingFlags_22, (MethodBase[])(object)class27.e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default), null, parameterModifier_);
			}
			finally
			{
				gClass2 = null;
				goto end_IL_4c8e;
			}
			end_IL_4c8e:;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					Class7 class28 = @class;
					BindingFlags bindingFlags_23 = bindingFlags;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
					object object_2 = Class5.Default;
					Class7 obj8 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					struct2 = (Struct1)class28.t(bindingFlags_23, fieldInfo_2, object_2, (CultureInfo)(object)obj8.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo));
				}
				goto IL_4db4;
			}
		}
		IL_42e8:
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		catch
		{
			_ = (Struct2)@class.j((BindingFlags)((Class7)null).j(bindingFlags, array3, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), parameterModifier_), array4, out *(object*)null), null, ref *(object[]*)null, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, null), cultureInfo, null, out *(object*)null);
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				class11 = class11;
			}
			goto IL_43a5;
		}
		IL_33ab:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			Class7 class29 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class29.e(bindingFlags, array3, null, parameterModifier_);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class34);
		try
		{
			gClass3 = gClass3;
			Class7 class30 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = bindingFlags;
			MethodBase[] methodBase_9 = array3;
			BindingFlags bindingFlags_25 = bindingFlags;
			Class7 class31 = @class;
			BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_10 = (MethodBase[])(object)@class.e(bindingFlags, array3, null, parameterModifier_);
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class30.j(bindingFlags_24, methodBase_9, ref *(object[]*)((Class7)null).e(bindingFlags_25, (MethodBase[])(object)class31.e(bindingFlags_26, methodBase_10, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), parameterModifier_), (Type[])null, parameterModifier_), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, null, type, (Type[])(object)Class5.Default, parameterModifier_), null, out *(object*)@class.t(Class5.Default, (Type)(object)@class.t(bindingFlags, null, obj, null), null));
			_ = (GClass3)(object)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array4, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array, (ParameterModifier[])null))).e((BindingFlags)((Class7)null).j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array4, out reference), (MethodBase[])(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo), (Type[])@class.t(((Class7)null).t(bindingFlags, array2, (object)null, cultureInfo), type, cultureInfo), (ParameterModifier[])(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			_ = (Struct2)((Class7)null).e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
					struct2 = default(Struct1);
					_ = (Class7)(object)Class5.Default;
					Class7 class32 = @class;
					BindingFlags bindingFlags_27 = bindingFlags;
					ref object[] object_3 = ref reference2;
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_ = cultureInfo;
					Class7 class33 = @class;
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_11 = array3;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array4, out reference);
					CultureInfo cultureInfo_2 = (CultureInfo)@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default);
					string[] string_2 = array4;
					BindingFlags bindingFlags_29 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array2;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class32.j(bindingFlags_27, null, ref object_3, parameterModifier_3, cultureInfo_, null, out *(object*)class33.j(bindingFlags_28, methodBase_11, ref *(object[]*)null, parameterModifier_4, cultureInfo_2, string_2, out *(object*)((Class7)null).t((BindingFlags)((Class7)null).t(bindingFlags_29, fieldInfo_3, (object)null, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, array, (ParameterModifier[])null)), array2, (object)Class5.Default, (CultureInfo)null)));
				}
			}
			catch
			{
				try
				{
					class34 = class34;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			goto IL_37ba;
		}
		IL_2eb3:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		Class7 class35 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).t(obj, (Type)(object)class35.j(bindingFlags, array3, ref reference2, null, cultureInfo, (string[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_), out *(object*)null), (CultureInfo)null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (_003CModule_003E)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
			}
			finally
			{
				do
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_);
				}
				while (((Class7)null).t(obj, (Type)null, cultureInfo) != null);
				goto IL_2fab;
			}
		}
		goto IL_2fab;
		IL_3e23:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class36);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class36 = class36;
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo), (CultureInfo)null, array4, out *(object*)null)).j((BindingFlags)Class5.Default, array3, ref *(object[]*)Class5.Default, null, null, array4, out reference);
			}
			else
			{
				_ = (Struct1)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, parameterModifier_)).t(bindingFlags, array2, obj, null), parameterModifier_), (ParameterModifier[])(object)Class5.Default);
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)@class.j(bindingFlags, array3, ref *(object[]*)Class5.Default, null, null, array4, out *(object*)Class5.Default);
				}
				goto IL_4090;
			}
			try
			{
				_ = (Class0)(object)@class.t(bindingFlags, null, null, null);
			}
			finally
			{
				_ = (GClass3)(object)((Class7)(object)@class.W((BindingFlags)@class.t(bindingFlags, array2, null, (CultureInfo)@class.t(obj, type, cultureInfo)), array5, type, array, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, null, ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, null, null, null, out reference), null, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				goto IL_4090;
			}
		}
		IL_29f2:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class37);
		if (uIntPtr == 0)
		{
			_ = (Struct1)((Class7)(object)Class5.Default).W((BindingFlags)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default), array5, type, array, parameterModifier_);
			gClass2 = gClass2;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					gClass = gClass;
				}
				finally
				{
					class37 = class37;
					goto IL_2a77;
				}
			}
		}
		goto IL_2a77;
		IL_048c:
		GClass1 gClass4 = gClass4;
		gClass4 = null;
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class11 = class11;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class38);
		try
		{
			class38 = (Class8)(object)@class.j(bindingFlags, array3, ref *(object[]*)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null);
			class38 = class38;
		}
		finally
		{
			_ = (Class6)(object)Class5.Default;
			goto IL_051e;
		}
		IL_43a5:
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default)) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && (nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
		{
			gClass4 = null;
		}
		while (true)
		{
			BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).t(bindingFlags_30, (FieldInfo[])null, (object)null, (CultureInfo)(object)class39.t(bindingFlags, null, null, null)) == null)
			{
				break;
			}
			try
			{
				qk = qk;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)Class5.Default;
					class37 = class37;
				}
			}
		}
		do
		{
			try
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_31 = bindingFlags;
					MethodBase[] methodBase_12 = array3;
					ref object[] object_4 = ref *(object[]*)Class5.Default;
					Class7 obj15 = (Class7)(object)((Class7)(object)@class.t(bindingFlags, array2, null, cultureInfo)).j(bindingFlags, array3, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
					bindingFlags = default(BindingFlags);
					Class7 obj16 = (Class7)(object)obj15.W(bindingFlags, array5, null, array, parameterModifier_);
					BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_3 = (CultureInfo)(object)obj16.t(bindingFlags_32, (FieldInfo[])(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)@class.e(bindingFlags, null, array, parameterModifier_), (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)@class.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default)), null, null);
					string[] string_3 = array4;
					Class7 class40 = @class;
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 obj17 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_34 = bindingFlags;
					MethodBase[] methodBase_13 = array3;
					ref object[] object_5 = ref reference2;
					Class7 class41 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_35 = bindingFlags;
					Class7 class42 = @class;
					BindingFlags bindingFlags_36 = bindingFlags;
					MethodBase[] methodBase_14 = array3;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)(object)((Class7)null).j(bindingFlags_31, methodBase_12, ref object_4, parameterModifier_, cultureInfo_3, string_3, out *(object*)((Class7)(object)class40.j(bindingFlags_33, (MethodBase[])(object)obj17.j(bindingFlags_34, methodBase_13, ref object_5, parameterModifier_, (CultureInfo)(object)class41.W(bindingFlags_35, (PropertyInfo[])(object)((Class7)(object)class42.j(bindingFlags_36, methodBase_14, ref *(object[]*)null, parameterModifier_5, (CultureInfo)(object)class43.t(bindingFlags, array2, null, cultureInfo), array4, out *(object*)null)).t(bindingFlags, null, null, null), null, (Type[])(object)@class.e((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_), (MethodBase[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo), array, null), parameterModifier_), array4, out reference), ref *(object[]*)@class.W(bindingFlags, array5, null, array, (ParameterModifier[])(object)@class.t((BindingFlags)@class.W(bindingFlags, array5, type, array, null), array2, null, cultureInfo)), (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference)).t(bindingFlags, array2, null, cultureInfo))).t(obj, null, null);
				}
				catch
				{
					qk = qk;
				}
			}
		}
		while (obj != null);
		try
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				class36 = class36;
				goto end_IL_4718;
			}
			end_IL_4718:;
		}
		catch
		{
			do
			{
				_ = (Class6)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])null, parameterModifier_);
				_ = (GClass2)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
				else
				{
					gClass2 = gClass2;
				}
			}
			goto IL_479b;
		}
		IL_1b15:
		try
		{
			_ = (Class10)(object)Class5.Default;
		}
		finally
		{
			class38 = class38;
			goto IL_1b2d;
		}
		IL_051e:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			class36 = class36;
			class36 = null;
			class37 = class37;
			class37 = null;
		}
		while (obj != null)
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					_ = (Class6)(object)Class5.Default;
					continue;
				}
				@struct = @struct;
				_ = (Struct2)Class5.Default;
				BindingFlags bindingFlags_37 = bindingFlags;
				MethodBase[] methodBase_15 = array3;
				ref object[] object_6 = ref *(object[]*)((Class7)(object)((Class7)null).j(bindingFlags, array3, ref reference2, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)Class5.Default)).j(default(BindingFlags), array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out reference);
				Class7 class44 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags_37, methodBase_15, ref object_6, (ParameterModifier[])(object)class44.e(bindingFlags, null, null, parameterModifier_), (CultureInfo)null, (string[])null, out reference);
				qk = qk;
				qk = null;
			}
		}
		while (obj != null)
		{
			while (true)
			{
				Class7 class45 = @class;
				BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((object)class45.t(bindingFlags_38, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_), obj, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_)) == null)
				{
					break;
				}
				if (uIntPtr == 0)
				{
					gClass4 = null;
				}
			}
		}
		Class7 class46;
		BindingFlags bindingFlags_39;
		MethodBase[] methodBase_16;
		ref object[] object_7;
		BindingFlags bindingFlags_40;
		MethodBase[] methodBase_17;
		ref object[] object_8;
		Class7 obj21;
		BindingFlags bindingFlags_41;
		FieldInfo[] fieldInfo_4;
		BindingFlags bindingFlags_44;
		ref object[] object_9;
		CultureInfo cultureInfo_4;
		Class7 obj25;
		do
		{
			_ = (Class0)(object)@class.e(bindingFlags, array3, array, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, null));
			class46 = @class;
			bindingFlags_39 = bindingFlags;
			methodBase_16 = (MethodBase[])(object)Class5.Default;
			object_7 = ref reference2;
			bindingFlags_40 = bindingFlags;
			methodBase_17 = array3;
			object_8 = ref reference2;
			obj21 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), (object)null, (CultureInfo)(object)@class.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default)));
			bindingFlags_41 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_42 = bindingFlags;
			MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
			Class7 obj22 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, array, null);
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
			Class7 obj23 = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, null, (CultureInfo)(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			Class7 obj24 = (Class7)(object)((Class7)null).e(bindingFlags_42, methodBase_18, array, (ParameterModifier[])(object)obj22.j((BindingFlags)((Class7)null).j(bindingFlags_43, methodBase_19, ref *(object[]*)obj23.t(bindingFlags, array2, null, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_)), (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array4, out reference), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out *(object*)null));
			bindingFlags = default(BindingFlags);
			fieldInfo_4 = (FieldInfo[])(object)obj24.W(bindingFlags, array5, type, array, parameterModifier_);
			bindingFlags_44 = bindingFlags;
			object_9 = ref reference2;
			cultureInfo_4 = cultureInfo;
			obj25 = (Class7)((Class7)(object)Class5.Default).t(Class5.Default, null, null);
			bindingFlags = default(BindingFlags);
		}
		while ((object)class46.j(bindingFlags_39, methodBase_16, ref object_7, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_40, methodBase_17, ref object_8, (ParameterModifier[])(object)obj21.t(bindingFlags_41, fieldInfo_4, ((Class7)null).j(bindingFlags_44, (MethodBase[])null, ref object_9, (ParameterModifier[])null, cultureInfo_4, (string[])null, out *(object*)obj25.W(bindingFlags, array5, (Type)(object)Class5.Default, array, null)), (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, parameterModifier_)), (CultureInfo)(object)Class5.Default, (string[])@class.t(null, null, null), out *(object*)Class5.Default), cultureInfo, (string[])(object)Class5.Default, out *(object*)null) != null);
		try
		{
			checked
			{
				do
				{
					nuint num = uIntPtr;
					uIntPtr = default(UIntPtr);
					if ((num - (uIntPtr - unchecked((nuint)(UIntPtr)@class.e((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)@class.t(bindingFlags, array2, null, cultureInfo), out *(object*)@class.t((BindingFlags)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.t(bindingFlags, null, @class.W((BindingFlags)Class5.Default, array5, null, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array5, type, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, array, parameterModifier_), parameterModifier_), null), cultureInfo), null, (CultureInfo)(object)Class5.Default), (FieldInfo[])(object)Class5.Default, obj, cultureInfo))).t(@class.t(bindingFlags, array2, Class5.Default, cultureInfo), type, cultureInfo), array3, null, null)))) * (uIntPtr + uIntPtr) == 0)
					{
						class4 = class4;
					}
				}
				while ((object)Class5.Default != null);
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class7)(object)((Class7)null).e((BindingFlags)((Class7)null).t((object)null, type, cultureInfo), array3, array, parameterModifier_);
				}
				while (obj != null);
			}
			catch
			{
				while (true)
				{
					_ = (GClass0)(object)@class.t((BindingFlags)((Class7)(object)@class.j((BindingFlags)((Class7)@class.t(null, type, (CultureInfo)((Class7)(object)Class5.Default).t(null, type, cultureInfo))).t((BindingFlags)Class5.Default, array2, obj, null), null, ref *(object[]*)((Class7)null).t(bindingFlags, array2, (object)Class5.Default, cultureInfo), (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)Class5.Default)).t(bindingFlags, null, null, cultureInfo), null, null, (CultureInfo)(object)Class5.Default);
					if (obj != null)
					{
						continue;
					}
					goto end_IL_0b5e;
				}
				end_IL_0b5e:;
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					Class7 class47 = @class;
					BindingFlags bindingFlags_45 = bindingFlags;
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class47.t(bindingFlags_45, (FieldInfo[])(object)class48.t(bindingFlags, array2, obj, cultureInfo), Class5.Default, null);
				}
				catch
				{
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					class4 = (Class9)(object)class49.e(bindingFlags, null, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array3, null, parameterModifier_));
				}
			}
			catch
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					Class7 class50 = @class;
					BindingFlags bindingFlags_46 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_20 = array3;
					ref object[] object_10 = ref *(object[]*)@class.t(bindingFlags, array2, obj, (CultureInfo)(object)Class5.Default);
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class50.j(bindingFlags_46, methodBase_20, ref object_10, parameterModifier_, (CultureInfo)(object)class51.t(bindingFlags, array2, @class.t(obj, type, cultureInfo), (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)@class.j(bindingFlags, array3, ref reference2, parameterModifier_, cultureInfo, (string[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), ref reference2, parameterModifier_, cultureInfo, (string[])null, out *(object*)null), out *(object*)null))), null, out *(object*)@class.t(obj, null, null));
					goto end_IL_0ccb;
				}
				end_IL_0ccb:;
			}
		}
		else
		{
			_ = (Class9)(object)Class5.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			qk = (Qk7)(object)Class5.Default;
		}
		gClass3 = gClass3;
		gClass3 = gClass3;
		_ = (GClass3)(object)@class.t(bindingFlags, array2, obj, null);
		_ = (Class0)(object)Class5.Default;
		Class7 obj30 = (Class7)(object)Class5.Default;
		Class7 obj31 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)obj30.t(null, (Type)(object)obj31.W(bindingFlags, null, null, null, parameterModifier_), cultureInfo);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr != 0)
			{
				try
				{
					_ = (GClass2)@class.t(Class5.Default, null, cultureInfo);
				}
				finally
				{
					gClass2 = gClass2;
					goto IL_0f95;
				}
			}
			try
			{
				gClass2 = (GClass3)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.e((BindingFlags)Class5.Default, array3, array, null), (ParameterModifier[])null, (CultureInfo)null, array4, out reference);
				gClass2 = gClass2;
			}
			catch
			{
				_ = (GClass1)(object)Class5.Default;
				Struct1 obj32 = (Struct1)((Class7)null).t((BindingFlags)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null), array2, obj, cultureInfo);
				struct2 = struct2;
				struct2 = obj32;
				gClass2 = gClass2;
				class11 = class11;
			}
		}
		goto IL_0f95;
		IL_11b6:
		if (uIntPtr == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 obj34 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)(object)obj34.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_), obj, cultureInfo)).t(bindingFlags, array2, null, cultureInfo);
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class52.t(bindingFlags, array2, obj, (CultureInfo)(object)@class.W(bindingFlags, null, type, null, null));
					_ = (GClass3)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
				}
				else
				{
					gClass4 = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				Class7 class53 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				Type[] type_5 = (Type[])(object)Class5.Default;
				Class7 class54 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj36 = (Class7)(object)((Class7)(object)class54.t(bindingFlags, array2, obj, cultureInfo)).t(bindingFlags, array2, obj, cultureInfo);
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class53.W(bindingFlags_47, null, null, type_5, (ParameterModifier[])(object)obj36.e(default(BindingFlags), null, null, (ParameterModifier[])(object)class55.t(bindingFlags, array2, null, cultureInfo)));
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class56);
		checked
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
				@class = @class;
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				class56 = class56;
				class56 = class56;
			}
			finally
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						gClass4 = gClass4;
					}
					goto IL_14d4;
				}
			}
		}
		IL_5049:
		try
		{
			try
			{
				try
				{
					Class7 obj38 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = bindingFlags;
					MethodBase[] methodBase_21 = array3;
					Class7 class57 = @class;
					BindingFlags bindingFlags_49 = bindingFlags;
					MethodBase[] methodBase_22 = array3;
					Class7 obj39 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, parameterModifier_);
					BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
					ref object[] object_11 = ref reference2;
					Class7 class58 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj40 = (Class7)(object)class57.e(bindingFlags_49, methodBase_22, (Type[])(object)obj39.j(bindingFlags_50, null, ref object_11, parameterModifier_, (CultureInfo)(object)class58.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)((Class7)null).t(obj, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo)).W((BindingFlags)((Class7)null).W((BindingFlags)((Class7)null).j((BindingFlags)@class.W((BindingFlags)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default), array5, (Type)(object)Class5.Default, (Type[])(object)@class.W(bindingFlags, null, type, array, null), parameterModifier_), array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out reference), array5, (Type)null, (Type[])null, (ParameterModifier[])null), array5, (Type)(object)@class.W((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)@class.t(bindingFlags, array2, null, cultureInfo)), null, type, array, parameterModifier_), array, null)), array4, out reference), parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj38.e(bindingFlags_48, methodBase_21, null, (ParameterModifier[])(object)obj40.t(bindingFlags, array2, Class5.Default, cultureInfo));
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			catch
			{
			}
		}
		catch
		{
			if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				Class7 class59 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = bindingFlags;
				Class7 class60 = @class;
				BindingFlags bindingFlags_52 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array5;
				Type type_6 = type;
				Class7 obj43 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class59.t(bindingFlags_51, null, obj, (CultureInfo)(object)class60.W(bindingFlags_52, propertyInfo_5, type_6, array, (ParameterModifier[])(object)obj43.j(bindingFlags, null, ref reference2, parameterModifier_, cultureInfo, null, out reference))) == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, null, cultureInfo, array4, out reference);
				}
				else
				{
					@struct = default(Struct2);
					qk = (Qk7)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
					class38 = null;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class36 = class36;
				_ = (Class4)(object)Class5.Default;
				_ = (Class2)(object)@class.e(bindingFlags, array3, array, parameterModifier_);
				_ = (Qk7)(object)Class5.Default;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
			}
			return;
		}
		catch
		{
			do
			{
				gClass2 = (GClass3)(object)Class5.Default;
			}
			while (obj != null);
			return;
		}
		IL_4db4:
		_ = (Struct2)Class5.Default;
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					Class7 class61 = @class;
					BindingFlags bindingFlags_53 = bindingFlags;
					MethodBase[] methodBase_23 = array3;
					Class7 obj46 = (Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array4, out *(object*)Class5.Default)), null, array4, out *(object*)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default));
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class61.j(bindingFlags_53, methodBase_23, ref *(object[]*)null, (ParameterModifier[])(object)obj46.e(bindingFlags, array3, (Type[])(object)@class.t(bindingFlags, null, @class.e(bindingFlags, null, array, parameterModifier_), cultureInfo), parameterModifier_), null, (string[])(object)Class5.Default, out *(object*)null);
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					Class7 obj47 = (Class7)((Class7)(object)Class5.Default).t(null, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					Class7 obj48 = (Class7)(object)obj47.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
					bindingFlags = default(BindingFlags);
					class11 = (Class2)(object)obj48.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
				goto end_IL_4dbf;
			}
			end_IL_4dbf:;
		}
		finally
		{
			@class = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)null, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref reference2, parameterModifier_, cultureInfo, (string[])null, out *(object*)((Class7)((Class7)null).t(obj, (Type)(object)((Class7)null).t((BindingFlags)((Class7)((Class7)(object)Class5.Default).t(Class5.Default, type, (CultureInfo)(object)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array2, obj, cultureInfo), cultureInfo)).t(bindingFlags, null, obj, null)));
			goto IL_5049;
		}
		IL_206c:
		do
		{
			Class7 obj49 = (Class7)(object)Class5.Default;
			Class7 class62 = @class;
			BindingFlags bindingFlags_54 = bindingFlags;
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj50 = (Class7)(object)obj49.j((BindingFlags)class62.t(bindingFlags_54, (FieldInfo[])(object)class63.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), null, (CultureInfo)(object)Class5.Default), array3, ref *(object[]*)null, null, null, (string[])@class.t(Class5.Default, type, cultureInfo), out reference);
			BindingFlags bindingFlags_55 = (BindingFlags)@class.t(((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)@class.j(bindingFlags, null, ref reference2, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), parameterModifier_), type, null);
			MethodBase[] methodBase_24 = array3;
			BindingFlags bindingFlags_56 = bindingFlags;
			MethodBase[] methodBase_25 = array3;
			Class7 class64 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)obj50.e(bindingFlags_55, methodBase_24, array, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_56, methodBase_25, ref *(object[]*)class64.e((BindingFlags)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])null), (MethodBase[])(object)@class.t(bindingFlags, array2, obj, cultureInfo), null, (ParameterModifier[])(object)Class5.Default), parameterModifier_, cultureInfo, array4, out *(object*)null))).t(bindingFlags, null, obj, null) == (UIntPtr)(nuint)0u)
			{
				qk = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo);
			}
		}
		while ((object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)Class5.Default) != null);
		struct2 = struct2;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					class11 = (Class2)(object)@class.W(bindingFlags, array5, (Type)(object)Class5.Default, null, null);
				}
				finally
				{
					class38 = class38;
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
			_ = (Class0)(object)Class5.Default;
			_ = (Class4)(object)Class5.Default;
			Class7 class65 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)class65.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
			gClass4 = null;
		}
		while (obj != null);
		checked
		{
			do
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * (unchecked((nuint)(UIntPtr)Class5.Default) + (unchecked((nuint)(UIntPtr)Class5.Default) - (unchecked((nuint)(UIntPtr)((Class7)null).t(obj, (Type)null, cultureInfo)) - unchecked((nuint)(UIntPtr)Class5.Default)) * uIntPtr)) != 0)
				{
					do
					{
						_ = (Class2)(object)@class.t(bindingFlags, null, obj, cultureInfo);
					}
					while (obj != null);
					continue;
				}
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass1)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array, (ParameterModifier[])null)).e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_)), (object)null, cultureInfo);
				}
			}
			while ((object)Class5.Default != null);
		}
		if ((UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass2)(object)@class.e(bindingFlags, null, array, parameterModifier_);
			}
			catch
			{
				do
				{
					gClass4 = (GClass1)(object)Class5.Default;
					gClass2 = null;
					gClass = (GClass2)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
		}
		try
		{
			class38 = (Class8)(object)@class.t((BindingFlags)@class.t((BindingFlags)Class5.Default, array2, obj, null), (FieldInfo[])(object)Class5.Default, @class.t(obj, (Type)(object)Class5.Default, cultureInfo), cultureInfo);
		}
		catch
		{
			class24 = class24;
			class24 = class24;
		}
		try
		{
			do
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					class56 = null;
					Class7 class66 = @class;
					BindingFlags bindingFlags_57 = bindingFlags;
					FieldInfo[] fieldInfo_5 = array2;
					Class7 obj54 = (Class7)(object)@class.t((BindingFlags)@class.t(((Class7)(object)@class.e((BindingFlags)@class.t(obj, null, cultureInfo), array3, array, parameterModifier_)).j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)@class.t(null, null, cultureInfo), array2, null, null), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null), array4, out reference), type, (CultureInfo)(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, parameterModifier_, null, null, out reference))), (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
					Class7 obj55 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null));
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass3)(object)class66.t(bindingFlags_57, fieldInfo_5, null, (CultureInfo)(object)obj54.e((BindingFlags)obj55.W(default(BindingFlags), (PropertyInfo[])(object)class67.e(bindingFlags, array3, null, parameterModifier_), null, null, null), array3, array, (ParameterModifier[])(object)Class5.Default));
					_ = (Class8)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference), null, array, parameterModifier_));
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			_ = (Class0)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), null, null, null);
			@class = @class;
			Class7 class68 = @class;
			Type type_7 = (Type)(object)Class5.Default;
			Class7 class69 = @class;
			bindingFlags = default(BindingFlags);
			gClass3 = (GClass0)class68.t(obj, type_7, (CultureInfo)(object)class69.W(bindingFlags, array5, (Type)(object)@class.e((BindingFlags)Class5.Default, array3, array, null), array, null));
		}
		nuint num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num2 + (unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0 && unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
			{
				do
				{
					_ = (Struct1)Class5.Default;
				}
				while (obj != null);
			}
			if (uIntPtr * uIntPtr == 0)
			{
				gClass = null;
				goto IL_28d9;
			}
		}
		try
		{
			qk = (Qk7)(object)Class5.Default;
		}
		finally
		{
			_ = (Struct1)@class.e((BindingFlags)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, null), (MethodBase[])(object)((Class7)null).j((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), (MethodBase[])null, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, array3, ref *(object[]*)null, parameterModifier_, cultureInfo, null, out reference))), ref reference2, parameterModifier_, cultureInfo, array4, out *(object*)null), array3, array, null);
			goto IL_28d9;
		}
		IL_1b2d:
		Class7 obj57 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_58 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
		Class7 class70 = @class;
		BindingFlags bindingFlags_59 = (BindingFlags)@class.e(bindingFlags, array3, array, parameterModifier_);
		MethodBase[] methodBase_26 = (MethodBase[])((Class7)null).t(obj, (Type)null, cultureInfo);
		Class7 class71 = @class;
		BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_27 = array3;
		Class7 class72 = @class;
		BindingFlags bindingFlags_61 = (BindingFlags)((Class7)null).j(default(BindingFlags), array3, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array4, out reference);
		MethodBase[] methodBase_28 = array3;
		ref object[] object_12 = ref reference2;
		CultureInfo cultureInfo_5 = cultureInfo;
		Class7 class73 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)obj57.W(bindingFlags_58, propertyInfo_6, (Type)(object)class70.e(bindingFlags_59, methodBase_26, (Type[])(object)class71.j(bindingFlags_60, methodBase_27, ref *(object[]*)class72.j(bindingFlags_61, methodBase_28, ref object_12, parameterModifier_, cultureInfo_5, (string[])(object)class73.e(bindingFlags, array3, array, null), out reference), parameterModifier_, null, array4, out reference), (ParameterModifier[])(object)Class5.Default), array, (ParameterModifier[])(object)Class5.Default);
		_ = (Qk7)(object)Class5.Default;
		try
		{
			Class7 obj58;
			do
			{
				Class7 class74 = @class;
				BindingFlags bindingFlags_62 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array2;
				object object_13 = Class5.Default;
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)(UIntPtr)class74.t(bindingFlags_62, fieldInfo_6, object_13, (CultureInfo)(object)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)(object)@class.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default)))) + uIntPtr == 0)
					{
						gClass2 = gClass2;
					}
				}
				obj58 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])null), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default));
				bindingFlags = default(BindingFlags);
			}
			while ((object)obj58.W(bindingFlags, array5, type, (Type[])@class.t(@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)Class5.Default)), null, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default) != null);
		}
		catch
		{
			try
			{
				try
				{
					class34 = null;
					_ = (Class5)(object)@class.j(bindingFlags, array3, ref reference2, null, cultureInfo, array4, out *(object*)@class.e(bindingFlags, array3, null, null));
					class4 = class4;
				}
				finally
				{
					_ = (Class6)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default);
					goto end_IL_1ddc;
				}
				end_IL_1ddc:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					gClass = gClass;
				}
				else
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
					_ = (Qk7)(object)@class.t((BindingFlags)Class5.Default, array2, null, cultureInfo);
				}
				goto end_IL_1ddb;
			}
			end_IL_1ddb:;
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				finally
				{
					Class7 class75 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					Class7 class76 = @class;
					BindingFlags bindingFlags_64 = (BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, array5, type, array, parameterModifier_);
					MethodBase[] methodBase_29 = array3;
					ref object[] object_14 = ref reference2;
					ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)Class5.Default;
					Class7 class77 = @class;
					Class7 obj60 = (Class7)@class.t(obj, null, cultureInfo);
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)((Class7)(object)class75.j(bindingFlags_63, (MethodBase[])(object)class76.j(bindingFlags_64, methodBase_29, ref object_14, parameterModifier_6, (CultureInfo)(object)class77.W((BindingFlags)obj60.t(class78.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_), (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array2, obj, cultureInfo), null), array5, type, null, parameterModifier_), array4, out reference), ref reference2, null, (CultureInfo)(object)@class.t(bindingFlags, array2, obj, cultureInfo), array4, out *(object*)null)).t(obj, (Type)((Class7)(object)Class5.Default).t(obj, type, null), cultureInfo);
					goto IL_206c;
				}
			}
			goto IL_206c;
		}
		IL_14d4:
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					goto end_IL_13e9;
				}
				end_IL_13e9:;
			}
			finally
			{
				try
				{
					Class7 class79 = @class;
					BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_66 = bindingFlags;
					MethodBase[] methodBase_30 = array3;
					ref object[] object_15 = ref reference2;
					string[] string_4 = array4;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class79.t(bindingFlags_65, fieldInfo_7, ((Class7)null).j(bindingFlags_66, methodBase_30, ref object_15, (ParameterModifier[])null, (CultureInfo)null, string_4, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)), null);
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.t((BindingFlags)@class.t(null, null, null), array2, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, null, (Type[])(object)Class5.Default, parameterModifier_));
				}
				continue;
			}
		}
		gClass4 = null;
		_ = (Class7)@class.t(null, (Type)@class.t(obj, type, (CultureInfo)(object)Class5.Default), null);
		while (true)
		{
			if (obj != null)
			{
				_ = (Class2)(object)Class5.Default;
			}
			else if (obj == null && @class.t(obj, type, cultureInfo) == null)
			{
				break;
			}
		}
		try
		{
			try
			{
				gClass4 = gClass4;
			}
			catch
			{
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class7)@class.t(obj, type, (CultureInfo)(object)Class5.Default);
				}
				finally
				{
					gClass2 = null;
					goto end_IL_1560;
				}
				end_IL_1560:;
			}
			finally
			{
				BindingFlags bindingFlags_67 = bindingFlags;
				Class7 class80 = @class;
				Class7 class81 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_68 = (BindingFlags)class81.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, array3, ref reference2, null, cultureInfo, array4, out *(object*)null), parameterModifier_);
				FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)Class5.Default;
				object object_16 = ((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array5, (Type)(object)Class5.Default, array, parameterModifier_);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).e(bindingFlags_67, (MethodBase[])null, (Type[])(object)class80.t(bindingFlags_68, fieldInfo_8, object_16, (CultureInfo)(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo)), (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					Class7 obj63 = (Class7)(object)((Class7)(object)@class.W(bindingFlags, array5, type, array, parameterModifier_)).j(bindingFlags, array3, ref reference2, parameterModifier_, cultureInfo, array4, out reference);
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)obj63.W(bindingFlags, array5, type, array, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					Class7 class82 = @class;
					MethodBase[] methodBase_31 = array3;
					Class7 obj64 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).t((BindingFlags)class82.e(default(BindingFlags), methodBase_31, (Type[])(object)obj64.t(bindingFlags, array2, obj, cultureInfo), parameterModifier_), array2, (object)@class.W((BindingFlags)((Class7)(object)((Class7)((Class7)null).t(obj, type, cultureInfo)).j(bindingFlags, null, ref reference2, parameterModifier_, cultureInfo, array4, out *(object*)null)).W(bindingFlags, array5, null, null, null), array5, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, parameterModifier_, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo), array4, out *(object*)@class.t(bindingFlags, null, obj, cultureInfo)), parameterModifier_, cultureInfo, array4, out *(object*)null));
					@class = null;
					_ = (Class9)(object)@class.e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_);
					Class7 obj65 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj65.W(bindingFlags, null, type, array, parameterModifier_);
				}
				goto end_IL_155f;
			}
			end_IL_155f:;
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
			}
			goto IL_18d5;
		}
		IL_318a:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Class7 class83 = @class;
			BindingFlags bindingFlags_69 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_32 = array3;
			Class7 class84 = @class;
			BindingFlags bindingFlags_70 = bindingFlags;
			FieldInfo[] fieldInfo_9 = array2;
			Class7 obj67 = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)@class.e(bindingFlags, array3, null, parameterModifier_), out *(object*)@class.e(bindingFlags, array3, array, (ParameterModifier[])(object)Class5.Default));
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class83.e(bindingFlags_69, methodBase_32, null, (ParameterModifier[])(object)class84.e((BindingFlags)((Class7)null).t(bindingFlags_70, fieldInfo_9, obj, (CultureInfo)(object)obj67.e(bindingFlags, null, array, null)), array3, null, null)) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (GClass3)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		checked
		{
			nuint num3 = unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (num3 + (unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0)
			{
				if (uIntPtr == 0)
				{
					try
					{
						_ = (Struct2)@class.W(bindingFlags, array5, (Type)(object)Class5.Default, array, null);
					}
					finally
					{
						gClass = null;
						goto IL_3316;
					}
				}
				try
				{
					_ = (GClass2)(object)((Class7)null).t(unchecked((BindingFlags)Class5.Default), (FieldInfo[])null, obj, cultureInfo);
				}
				finally
				{
					gClass = null;
					goto IL_3316;
				}
			}
			gClass4 = gClass4;
			goto IL_3316;
		}
		IL_37ba:
		checked
		{
			while (obj != null)
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr == 0)
				{
					try
					{
						_ = (Class7)(object)Class5.Default;
					}
					catch
					{
						bindingFlags = default(BindingFlags);
						_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_);
					}
				}
				else if (uIntPtr == 0)
				{
					_ = (Class10)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					qk = null;
				}
			}
			do
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_);
				}
				catch
				{
					Class7 obj69 = (Class7)@class.t(null, type, cultureInfo);
					BindingFlags bindingFlags_71 = bindingFlags;
					FieldInfo[] fieldInfo_10 = (FieldInfo[])(object)Class5.Default;
					Class7 class85 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj69.t(bindingFlags_71, fieldInfo_10, null, (CultureInfo)(object)class85.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, parameterModifier_));
				}
			}
			while ((object)Class5.Default != null);
			do
			{
				class36 = (Class10)(object)Class5.Default;
			}
			while (obj != null);
			try
			{
				if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
				{
					try
					{
						qk = (Qk7)(object)Class5.Default;
					}
					finally
					{
						class38 = (Class8)(object)Class5.Default;
						gClass2 = gClass2;
						_ = (GClass3)(object)Class5.Default;
						_ = (Class6)(object)Class5.Default;
						goto end_IL_386f;
					}
				}
				end_IL_386f:;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					Class7 class86 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class86.t(default(BindingFlags), null, ((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)null), null);
				}
			}
			if (uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
			{
				Class7 obj72;
				Class7 class87;
				do
				{
					gClass = null;
					_ = (Class9)((Class7)(object)((Class7)(object)@class.e(default(BindingFlags), null, array, null)).W(default(BindingFlags), array5, type, (Type[])(object)Class5.Default, null)).t(obj, null, (CultureInfo)(object)Class5.Default);
					obj72 = (Class7)(object)Class5.Default;
					class87 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)obj72.t(unchecked((BindingFlags)class87.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_)), (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, parameterModifier_), obj, cultureInfo) != null);
			}
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
			{
				gClass2 = gClass2;
			}
			_ = (GClass1)(object)Class5.Default;
		}
		while (obj != null)
		{
			_ = (Class8)(object)@class.t((BindingFlags)Class5.Default, array2, null, cultureInfo);
		}
		gClass4 = null;
		class37 = class37;
		while (obj != null)
		{
			try
			{
				_ = (Class7)@class.t(null, (Type)((Class7)(object)@class.e(bindingFlags, array3, array, null)).t(obj, null, null), null);
			}
			catch
			{
				@struct = default(Struct2);
			}
		}
		_ = (Class2)(object)Class5.Default;
		while (true)
		{
			Class7 class88 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class88.W(bindingFlags, array5, null, array, parameterModifier_) == null)
			{
				break;
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					_ = (Struct2)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, parameterModifier_);
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					class24 = class24;
				}
			}
			while (obj != null);
		}
		try
		{
			if (uIntPtr == 0)
			{
				class56 = class56;
			}
			else
			{
				qk = qk;
			}
		}
		finally
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
					class4 = class4;
					gClass2 = null;
					class4 = null;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			goto IL_3bb1;
		}
		IL_3316:
		try
		{
			class36 = class36;
		}
		finally
		{
			try
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
					gClass3 = gClass3;
					_ = (Class9)(object)Class5.Default;
					_ = (Struct2)((Class7)null).t(bindingFlags, array2, obj, (CultureInfo)null);
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					class11 = class11;
				}
				catch
				{
					_ = (Class0)(object)((Class7)null).j(bindingFlags, array3, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out reference);
				}
				goto IL_33ab;
			}
		}
		IL_28d9:
		_ = (Class2)(object)((Class7)null).t((BindingFlags)@class.j(bindingFlags, null, ref reference2, parameterModifier_, cultureInfo, array4, out reference), array2, (object)null, (CultureInfo)null);
		class56 = null;
		_ = (Class8)(object)Class5.Default;
		class38 = (Class8)(object)Class5.Default;
		try
		{
			try
			{
				_ = (Class7)(object)@class.t(bindingFlags, array2, Class5.Default, cultureInfo);
				Class7 obj76 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj76.e(bindingFlags, array3, array, parameterModifier_);
				_ = (Struct2)Class5.Default;
				class4 = (Class9)(object)Class5.Default;
			}
			finally
			{
				do
				{
					class56 = null;
				}
				while (obj != null);
				goto end_IL_2930;
			}
			end_IL_2930:;
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					class11 = class11;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Qk7)(object)@class.t(bindingFlags, array2, null, null);
				}
				while (obj != null);
				goto IL_29f2;
			}
		}
		IL_2fab:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class6)(object)@class.e((BindingFlags)Class5.Default, array3, array, null);
		}
		try
		{
			gClass2 = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, array3, ref reference2, null, cultureInfo, array4, out *(object*)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)((Class7)null).j(default(BindingFlags), array3, ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out reference)));
		}
		finally
		{
			Class7 obj77 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array3, ref *(object[]*)null, null, cultureInfo, null, out reference);
			object object_17 = Class5.Default;
			bindingFlags = default(BindingFlags);
			@struct = (Struct2)obj77.t(object_17, (Type)(object)((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])(object)((Class7)null).j((BindingFlags)@class.t(obj, null, cultureInfo), (MethodBase[])(object)@class.t(bindingFlags, array2, obj, cultureInfo), ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference), (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default)), (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array2, @class.W((BindingFlags)Class5.Default, array5, (Type)(object)@class.e((BindingFlags)Class5.Default, null, null, parameterModifier_), null, null), cultureInfo));
			goto IL_318a;
		}
		IL_2a77:
		try
		{
			try
			{
				nuint num4 = uIntPtr;
				nuint num5 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num4 + (num5 + uIntPtr)) == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					class34 = class34;
				}
			}
			finally
			{
				do
				{
					class56 = class56;
					_ = (Class10)(object)Class5.Default;
					_ = (Struct1)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array2, obj, null)).t((BindingFlags)Class5.Default, array2, obj, cultureInfo);
					class11 = (Class2)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, parameterModifier_)).e((BindingFlags)@class.j((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t(obj, (Type)null, (CultureInfo)null), ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default), null, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array3, ref reference2, parameterModifier_, cultureInfo, (string[])null, out *(object*)null));
				}
				while ((object)Class5.Default != null);
				goto end_IL_2a78;
			}
			end_IL_2a78:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj != null);
			}
			else
			{
				nuint num8;
				checked
				{
					nuint num6 = uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default);
					nuint num7 = uIntPtr;
					Class7 class89 = @class;
					bindingFlags = default(BindingFlags);
					num8 = (num6 - unchecked(num7 / (nuint)(UIntPtr)class89.e(bindingFlags, null, array, null)) * unchecked((nuint)(UIntPtr)@class.e((BindingFlags)@class.t(bindingFlags, array2, obj, null), (MethodBase[])((Class7)(object)Class5.Default).t(@class.e((BindingFlags)Class5.Default, null, array, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, (CultureInfo)null)), type, cultureInfo), (Type[])(object)@class.t(bindingFlags, null, Class5.Default, null), parameterModifier_))) * unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
				}
				if (num8 / uIntPtr == 0)
				{
					class56 = class56;
				}
				else
				{
					_ = (GClass2)@class.t(@class.t(bindingFlags, array2, Class5.Default, cultureInfo), null, cultureInfo);
				}
			}
		}
		class56 = (Class6)(object)Class5.Default;
		if (uIntPtr == 0)
		{
			Class7 class90 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class90.W(bindingFlags, array5, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default);
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (_003CModule_003E)@class.t(null, type, cultureInfo);
			}
		}
		else
		{
			class56 = class56;
		}
		do
		{
			Class7 class91 = @class;
			Class7 obj79 = (Class7)(object)@class.W(bindingFlags, null, null, array, parameterModifier_);
			BindingFlags bindingFlags_72 = (BindingFlags)@class.t(bindingFlags, array2, null, null);
			MethodBase[] methodBase_33 = array3;
			Class7 class92 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)class91.t(obj, (Type)(object)obj79.e(bindingFlags_72, methodBase_33, array, (ParameterModifier[])(object)class92.t(default(BindingFlags), (FieldInfo[])((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array, (ParameterModifier[])(object)Class5.Default)).t(@class.t(bindingFlags, array2, null, (CultureInfo)(object)Class5.Default), type, cultureInfo), null, cultureInfo)), null);
		}
		while (((Class7)null).t((object)null, type, cultureInfo) != null);
		try
		{
		}
		finally
		{
			if (uIntPtr == 0)
			{
				class36 = class36;
			}
			goto IL_2eb3;
		}
		IL_18d5:
		gClass = (GClass2)(object)Class5.Default;
		try
		{
			Class7 class93;
			do
			{
				class93 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class93.j(bindingFlags, null, ref reference2, parameterModifier_, null, null, out *(object*)Class5.Default) != null);
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					class11 = class11;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				class37 = null;
				class38 = null;
			}
		}
		if (uIntPtr == 0)
		{
			do
			{
				Class7 class94 = @class;
				Class7 obj82 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_73 = bindingFlags;
				bindingFlags = default(BindingFlags);
				nuint num9;
				checked
				{
					num9 = unchecked((nuint)(UIntPtr)class94.e((BindingFlags)obj82.j(bindingFlags_73, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, null), cultureInfo, null, out *(object*)Class5.Default), (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default))) * uIntPtr;
					uIntPtr = default(UIntPtr);
				}
				if (num9 / uIntPtr != 0)
				{
					class4 = class4;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			while ((object)Class5.Default != null);
		}
		class38 = null;
		gClass4 = (GClass1)(object)Class5.Default;
		if (uIntPtr == 0)
		{
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)((Class7)null).e(bindingFlags, array3, (Type[])null, (ParameterModifier[])(object)Class5.Default);
		}
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					struct2 = (Struct1)Class5.Default;
				}
				while (obj != null);
			}
			finally
			{
				if ((UIntPtr)@class.j(bindingFlags, array3, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_), cultureInfo, array4, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)Class5.Default;
					_ = Class5.Default;
					_ = (Struct1)Class5.Default;
				}
				goto IL_1b15;
			}
		}
		goto IL_1b15;
		IL_4192:
		_ = (GClass0)(object)Class5.Default;
		try
		{
			_ = (Class5)((Class7)null).t(obj, type, cultureInfo);
		}
		catch
		{
			do
			{
				gClass = null;
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			try
			{
				try
				{
					class38 = class38;
					Class7 class95 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_74 = bindingFlags;
					FieldInfo[] fieldInfo_11 = array2;
					Class7 class96 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj84 = (Class7)(object)class96.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_75 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = array5;
					Type type_8 = type;
					Class7 class97 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)class95.t(bindingFlags_74, fieldInfo_11, obj, (CultureInfo)(object)obj84.W(bindingFlags_75, propertyInfo_7, type_8, null, (ParameterModifier[])class97.t(((Class7)null).e(bindingFlags, array3, (Type[])(object)Class5.Default, parameterModifier_), (Type)(object)Class5.Default, cultureInfo)));
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
					Class7 class98 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class98.e(bindingFlags, array3, null, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_42ab;
				}
				end_IL_42ab:;
			}
			goto IL_42e8;
		}
		IL_0f95:
		if ((UIntPtr)@class.t(bindingFlags, null, obj, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				do
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (GClass3)(object)Class5.Default;
					}
				}
				while ((object)Class5.Default != null);
			}
		}
		else
		{
			try
			{
				do
				{
					@struct = default(Struct2);
				}
				while (obj != null);
			}
			catch
			{
				do
				{
					_ = (GClass2)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array2, obj, cultureInfo), type, array, (ParameterModifier[])((Class7)(object)@class.j(bindingFlags, array3, ref *(object[]*)@class.t(bindingFlags, array2, obj, cultureInfo), null, (CultureInfo)(object)Class5.Default, array4, out reference)).t(obj, (Type)(object)Class5.Default, null));
				}
				while ((object)@class.t((BindingFlags)Class5.Default, array2, obj, cultureInfo) != null);
			}
		}
		while (obj != null)
		{
			try
			{
				_ = Class5.Default;
			}
			finally
			{
				if ((UIntPtr)@class.t((BindingFlags)@class.t(obj, (Type)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo), null), null, null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					gClass2 = null;
					continue;
				}
				class34 = class34;
				class34 = class34;
				continue;
			}
		}
		if (uIntPtr == 0)
		{
			class36 = class36;
		}
		else
		{
			gClass4 = null;
		}
		if (uIntPtr == 0)
		{
			class38 = class38;
		}
		try
		{
			class38 = class38;
		}
		finally
		{
			try
			{
				while ((object)((Class7)null).e(bindingFlags, array3, array, (ParameterModifier[])null) != null)
				{
					gClass3 = gClass3;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					@class = null;
				}
				goto IL_11b6;
			}
		}
		IL_4090:
		do
		{
			if ((UIntPtr)((Class7)null).t((object)@class.j((BindingFlags)@class.e(bindingFlags, null, array, null), array3, ref *(object[]*)null, parameterModifier_, null, array4, out *(object*)Class5.Default), (Type)null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				gClass4 = (GClass1)(object)@class.e((BindingFlags)Class5.Default, array3, null, parameterModifier_);
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			class36 = class36;
		}
		catch
		{
			try
			{
				try
				{
					class24 = (Class4)(object)Class5.Default;
				}
				catch
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					bindingFlags = default(BindingFlags);
					class34 = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo);
					goto end_IL_4111;
				}
				catch
				{
					gClass = gClass;
					qk = (Qk7)(object)@class.t(bindingFlags, array2, obj, null);
					goto end_IL_4111;
				}
				end_IL_4111:;
			}
		}
		try
		{
			if ((UIntPtr)@class.t(bindingFlags, null, obj, null) == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		finally
		{
			goto IL_4192;
		}
		IL_3bb1:
		try
		{
			if (uIntPtr == 0)
			{
				BindingFlags bindingFlags_76 = bindingFlags;
				Class7 obj92 = (Class7)(object)Class5.Default;
				Class7 class99 = @class;
				BindingFlags bindingFlags_77 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_12 = (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
				Class7 class100 = @class;
				BindingFlags bindingFlags_78 = (BindingFlags)Class5.Default;
				Class7 class101 = @class;
				BindingFlags bindingFlags_79 = bindingFlags;
				MethodBase[] methodBase_34 = (MethodBase[])(object)Class5.Default;
				Class7 obj93 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_80 = bindingFlags;
				PropertyInfo[] propertyInfo_8 = array5;
				Class7 obj94 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				object object_18 = ((Class7)null).e((BindingFlags)class100.t(bindingFlags_78, (FieldInfo[])(object)((Class7)null).e((BindingFlags)class101.e(bindingFlags_79, methodBase_34, array, (ParameterModifier[])(object)obj93.W(bindingFlags_80, propertyInfo_8, null, (Type[])(object)obj94.e(bindingFlags, array3, array, null), null)), array3, array, (ParameterModifier[])null), null, cultureInfo), array3, array, (ParameterModifier[])(object)Class5.Default);
				Class7 class102 = @class;
				object object_19 = Class5.Default;
				Type type_9 = type;
				Class7 class103 = @class;
				BindingFlags bindingFlags_81 = bindingFlags;
				Type type_10 = type;
				Class7 obj95 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Type type_11 = (Type)(object)obj92.t((BindingFlags)class99.t(bindingFlags_77, fieldInfo_12, object_18, (CultureInfo)class102.t(object_19, type_9, (CultureInfo)(object)class103.W(bindingFlags_81, null, type_10, array, (ParameterModifier[])(object)obj95.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(obj, type, cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])null))))), (FieldInfo[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), null, cultureInfo);
				Class7 class104 = @class;
				bindingFlags = default(BindingFlags);
				gClass = (GClass2)(object)((Class7)null).W(bindingFlags_76, (PropertyInfo[])null, type_11, (Type[])null, (ParameterModifier[])(object)class104.W(bindingFlags, null, type, array, parameterModifier_));
			}
			else
			{
				class56 = class56;
			}
		}
		finally
		{
			try
			{
				class4 = class4;
				gClass2 = gClass2;
				class24 = class24;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			goto IL_3e23;
		}
	}

	unsafe static void Bf3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			@class = @class;
			Class7 class2 = @class;
			Class7 obj = (Class7)(object)Class5.Default;
			obj2 = null;
			object object_ = obj2;
			Class7 class3 = @class;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = array;
			MethodBase[] methodBase_ = array;
			reference = ref reference;
			ref object[] object_2 = ref reference;
			array2 = array2;
			ParameterModifier[] parameterModifier_ = array2;
			cultureInfo = null;
			CultureInfo cultureInfo_ = cultureInfo;
			Class7 obj3 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_2 = (BindingFlags)Class5.Default;
			ParameterModifier[] parameterModifier_2 = array2;
			array3 = array3;
			string[] string_ = array3;
			Class7 class4 = @class;
			type = (Type)(object)Class5.Default;
			object_3 = ref *(object*)class4.t(null, type, cultureInfo);
			string[] string_2 = (string[])(object)obj3.j(bindingFlags_2, null, ref *(object[]*)null, parameterModifier_2, null, string_, out object_3);
			Class7 class5 = @class;
			BindingFlags bindingFlags_3 = bindingFlags;
			Type type_ = type;
			array4 = array4;
			Class7 obj4 = (Class7)(object)class2.e((BindingFlags)obj.t(object_, null, (CultureInfo)(object)class3.j(bindingFlags_, methodBase_, ref object_2, parameterModifier_, cultureInfo_, string_2, out *(object*)class5.W(bindingFlags_3, null, type_, array4, null))), array, null, null);
			BindingFlags bindingFlags_4 = bindingFlags;
			array5 = array5;
			if ((UIntPtr)((Class7)(object)obj4.W(bindingFlags_4, array5, null, (Type[])@class.t(obj2, type, null), array2)).t(Class5.Default, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					@struct = @struct;
					@struct = @struct;
				}
				finally
				{
					class6 = null;
					class6 = class6;
					goto end_IL_0000;
				}
			}
			end_IL_0000:;
		}
		catch
		{
			BindingFlags bindingFlags_5 = bindingFlags;
			Class7 class7 = @class;
			BindingFlags bindingFlags_6 = bindingFlags;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_7 = bindingFlags;
			FieldInfo[] fieldInfo_ = (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, (CultureInfo)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, out object_3)).e(bindingFlags, array, null, array2);
			Class7 obj5 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			BindingFlags bindingFlags_9 = (BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])null, array2);
			array6 = (FieldInfo[])(object)Class5.Default;
			Class7 obj6 = (Class7)(object)((Class7)null).t(bindingFlags_5, (FieldInfo[])(object)class7.j(bindingFlags_6, (MethodBase[])(object)((Class7)null).t(bindingFlags_7, fieldInfo_, (object)obj5.W(bindingFlags_8, (PropertyInfo[])(object)((Class7)null).t(bindingFlags_9, array6, obj2, cultureInfo), type, array4, null), cultureInfo), ref reference, array2, null, array3, out object_3), obj2, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj6.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class8);
		UIntPtr uIntPtr;
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Struct2)Class5.Default;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					gClass = gClass;
					gClass = gClass;
				}
				goto end_IL_02e3;
			}
			end_IL_02e3:;
		}
		finally
		{
			uIntPtr = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					gClass2 = (GClass1)(object)Class5.Default;
					gClass2 = null;
				}
				else
				{
					class8 = class8;
					class8 = null;
				}
			}
			goto IL_0393;
		}
		IL_3066:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class9);
		try
		{
			while ((object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, array3, out object_3) != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_ = (GClass0)(object)Class5.Default;
					class9 = class9;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo);
				}
			}
			else
			{
				do
				{
					@struct = @struct;
				}
				while (obj2 != null);
			}
			goto IL_30ff;
		}
		IL_0393:
		_ = (Qk7)(object)@class.W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, (CultureInfo)null), null, type, null, (ParameterModifier[])(object)@class.t(bindingFlags, array6, null, cultureInfo));
		_ = (Class0)((Class7)(object)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, null, null, out *(object*)null)).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, null, cultureInfo), null, array2)).t(null, type, cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		if (uIntPtr == 0)
		{
			gClass3 = null;
			gClass3 = gClass3;
		}
		else
		{
			try
			{
				try
				{
					class8 = class8;
				}
				finally
				{
					gClass2 = (GClass1)(object)Class5.Default;
					class10 = class10;
					class10 = class10;
					goto end_IL_045d;
				}
				end_IL_045d:;
			}
			catch
			{
				try
				{
					_ = (Class2)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, array2);
				}
				catch
				{
					Class7 class11 = @class;
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).j((BindingFlags)class11.e(bindingFlags_10, (MethodBase[])(object)class12.t(bindingFlags, array6, null, (CultureInfo)(object)Class5.Default), null, null), array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array3, out *(object*)((Class7)null).t(obj2, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default), cultureInfo));
					_ = (Class8)(object)@class.W(bindingFlags, array5, type, array4, null);
					Class7 class13 = @class;
					MethodBase[] methodBase_2 = array;
					ref object[] object_4 = ref reference;
					ParameterModifier[] parameterModifier_3 = array2;
					CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
					Class7 class14 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class13.j(default(BindingFlags), methodBase_2, ref object_4, parameterModifier_3, cultureInfo_2, (string[])(object)class14.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array2), (PropertyInfo[])(object)@class.e((BindingFlags)@class.t((BindingFlags)@class.e((BindingFlags)Class5.Default, array, array4, null), array6, obj2, cultureInfo), array, array4, array2), type, (Type[])(object)Class5.Default, array2), out *(object*)null);
				}
			}
		}
		nuint num = uIntPtr;
		UIntPtr num2 = (UIntPtr)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		if (num / checked(unchecked((nuint)num2) + uIntPtr) == 0)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (nuint)(UIntPtr)Class5.Default == 0)
				{
					Struct1 obj10 = (Struct1)Class5.Default;
					struct2 = struct2;
					struct2 = obj10;
				}
			}
			while ((object)@class.e((BindingFlags)@class.t(null, null, null), array, (Type[])(object)Class5.Default, array2) != null);
		}
		struct2 = struct2;
		Qk7 qk = null;
		qk = qk;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class16);
		if (uIntPtr == 0)
		{
			class15 = null;
			class15 = class15;
		}
		else
		{
			try
			{
				while (obj2 != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
					class16 = (Class2)@class.t(obj2, null, cultureInfo);
					class16 = class16;
					@struct = @struct;
				}
			}
			catch
			{
				class16 = (Class2)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
			}
		}
		class15 = class15;
		while (@class.t(obj2, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array4, array2), cultureInfo) != null)
		{
			try
			{
				if (checked((unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default)) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					_ = (Class0)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array4, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					@struct = @struct;
				}
			}
			catch
			{
				struct2 = default(Struct1);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class18);
		try
		{
			try
			{
				while (obj2 != null)
				{
					Class7 class17 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class17.W(bindingFlags, array5, type, array4, array2);
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					class18 = null;
					class18 = class18;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					class8 = class8;
				}
				goto end_IL_0841;
			}
			end_IL_0841:;
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				do
				{
					class8 = null;
				}
				while ((object)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])null) != null);
			}
		}
		while (obj2 != null)
		{
			class15 = (Class8)(object)Class5.Default;
		}
		UIntPtr num3 = (UIntPtr)Class5.Default;
		UIntPtr num4 = uIntPtr;
		UIntPtr num5 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class19);
		if (checked(unchecked((nuint)num3 / ((nuint)num4 / checked(unchecked((nuint)num5) * uIntPtr - uIntPtr))) * unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array6, obj2, cultureInfo))) == 0)
		{
			try
			{
				try
				{
					@struct = default(Struct2);
					@struct = @struct;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					class19 = (Class0)(object)((Class7)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, array3, out object_3)).e((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, array3, out object_3), null, null, array2);
					class19 = null;
					goto end_IL_0953;
				}
				end_IL_0953:;
			}
			catch
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, (ParameterModifier[])null);
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), array6, obj2, (CultureInfo)(object)Class5.Default)).t(obj2, type, null), (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null);
			}
			finally
			{
				gClass = gClass;
				goto IL_0af3;
			}
		}
		UIntPtr num6 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num6 / uIntPtr) - uIntPtr == 0 && uIntPtr == 0)
			{
				class9 = (Class9)(object)Class5.Default;
				class9 = class9;
			}
			goto IL_0af3;
		}
		IL_2fff:
		while (true)
		{
			if (obj2 != null)
			{
				Class7 class20 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)(object)class20.e(bindingFlags, array, (Type[])(object)Class5.Default, array2)).t(obj2, type, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo));
			}
			else if ((object)Class5.Default == null && obj2 == null)
			{
				break;
			}
		}
		_ = (Class4)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		try
		{
			gClass = null;
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					struct2 = (Struct1)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					gClass4 = (GClass0)(object)Class5.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_3047;
				}
				end_IL_3047:;
			}
			goto IL_3066;
		}
		IL_46c2:
		while (true)
		{
			Class7 class21 = @class;
			Class7 class22 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class21.e((BindingFlags)class22.j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), array, array4, array2) != null)
			{
				class10 = class10;
				_ = (Class8)(object)Class5.Default;
				gClass = gClass;
				class9 = null;
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			nuint num7 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num8 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num7 - unchecked(num8 / checked(uIntPtr * unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, obj2, cultureInfo)).t(Class5.Default, type, cultureInfo), array2))))) == 0)
			{
				try
				{
					@struct = @struct;
					_ = (GClass3)@class.t(obj2, type, null);
				}
				finally
				{
					Class7 class23 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class23.j(bindingFlags, array, ref *(object[]*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).j(default(BindingFlags), array, ref reference, (ParameterModifier[])(object)((Class7)null).W(default(BindingFlags), array5, type, array4, (ParameterModifier[])(object)Class5.Default), cultureInfo, array3, out *(object*)Class5.Default), array4, (ParameterModifier[])(object)Class5.Default), null, null, (string[])(object)Class5.Default, out *(object*)null);
					goto end_IL_4714;
				}
			}
			end_IL_4714:;
		}
		finally
		{
			class10 = class10;
			goto IL_4890;
		}
		IL_444c:
		class8 = null;
		_ = (Class2)(object)Class5.Default;
		try
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj16 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array2, (CultureInfo)null, array3, out object_3);
					object object_5 = obj2;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)obj16.t(object_5, null, (CultureInfo)(object)class24.W(bindingFlags, array5, type, null, array2));
					@struct = (Struct2)((Class7)null).t(obj2, (Type)null, (CultureInfo)null);
					class8 = class8;
				}
			}
		}
		catch
		{
			try
			{
				_ = (Class0)(object)@class.t(bindingFlags, array6, Class5.Default, cultureInfo);
			}
			catch
			{
				gClass4 = null;
				_ = Class5.Default;
				_ = (Class8)(object)((Class7)@class.t(obj2, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array2, cultureInfo, array3, out *(object*)((Class7)@class.t(obj2, null, (CultureInfo)(object)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, array, ref reference, array2, null, array3, out object_3), Class5.Default, cultureInfo)))).e((BindingFlags)Class5.Default, array, null, null);
			}
			finally
			{
				while (obj2 != null)
				{
					@class = null;
				}
				goto end_IL_4510;
			}
			end_IL_4510:;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				@class = @class;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					class16 = null;
				}
				else
				{
					_ = (Class10)(object)@class.W(default(BindingFlags), (PropertyInfo[])@class.t(obj2, type, cultureInfo), null, array4, null);
				}
			}
			goto IL_46c2;
		}
		IL_4fa8:
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array2), array3, out object_3);
		qk = qk;
		try
		{
			try
			{
				_ = (GClass2)(object)((Class7)(object)@class.e(bindingFlags, array, array4, array2)).t(default(BindingFlags), array6, obj2, cultureInfo);
				return;
			}
			catch
			{
				_ = (Class4)((Class7)(object)@class.j(default(BindingFlags), null, ref *(object[]*)null, array2, cultureInfo, array3, out object_3)).t(obj2, type, cultureInfo);
				return;
			}
			finally
			{
				_ = (Qk7)(object)Class5.Default;
				return;
			}
		}
		finally
		{
			struct2 = struct2;
			return;
		}
		IL_4890:
		Class7 class25 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class25.e(bindingFlags, array, array4, array2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class7)(object)Class5.Default;
					@struct = @struct;
				}
			}
			catch
			{
			}
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		while (obj2 != null)
		{
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0)
			{
				try
				{
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj22 = (Class7)(object)((Class7)(object)class26.e(bindingFlags, null, null, array2)).j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)@class.t(bindingFlags, array6, obj2, cultureInfo)), ref reference, array2, null, array3, out object_3);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj22.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array2);
				}
				catch
				{
					@struct = default(Struct2);
				}
			}
		}
		try
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					gClass3 = gClass3;
					BindingFlags bindingFlags_11 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					Type[] type_2 = array4;
					Class7 class27 = @class;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass1)(object)((Class7)null).e(bindingFlags_11, methodBase_3, type_2, (ParameterModifier[])(object)class27.e(bindingFlags, null, array4, array2));
					class9 = null;
				}
				else
				{
					gClass = gClass;
					class8 = class8;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					class9 = class9;
					@struct = (Struct2)Class5.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					class16 = class16;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo);
					class8 = null;
					class15 = class15;
				}
			}
			goto IL_4ac1;
		}
		IL_30ff:
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)@class.W(bindingFlags, null, type, array4, array2);
				}
				else
				{
					gClass2 = gClass2;
					_ = (GClass3)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo);
					_ = (Class6)(object)Class5.Default;
				}
			}
			finally
			{
				Class7 obj25 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_12 = bindingFlags;
				Class7 class28 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj25.j(bindingFlags_12, (MethodBase[])(object)class28.W(bindingFlags, array5, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), ref reference, array2, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])null))) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)@class.t(@class.t(bindingFlags, null, obj2, cultureInfo), type, null);
				}
				goto end_IL_3100;
			}
			end_IL_3100:;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class6)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					class18 = class18;
				}
				finally
				{
					_ = (Class10)(object)Class5.Default;
					goto end_IL_3231;
				}
			}
			end_IL_3231:;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class7)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
		}
		_ = (Class2)((Class7)(object)Class5.Default).t(obj2, type, null);
		class15 = class15;
		while (obj2 != null)
		{
			try
			{
				try
				{
					class19 = class19;
					_ = (Struct2)((Class7)(object)Class5.Default).t(obj2, null, null);
				}
				finally
				{
					@struct = @struct;
					goto end_IL_32b8;
				}
				end_IL_32b8:;
			}
			finally
			{
				do
				{
					gClass3 = gClass3;
					_ = (Class10)(object)@class.t((BindingFlags)Class5.Default, array6, Class5.Default, null);
					BindingFlags bindingFlags_13 = bindingFlags;
					Class7 class29 = @class;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					Type type_3 = (Type)(object)class30.t(bindingFlags, array6, null, (CultureInfo)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null));
					BindingFlags bindingFlags_14 = bindingFlags;
					MethodBase[] methodBase_4 = array;
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).t(bindingFlags_13, (FieldInfo[])class29.t(null, type_3, (CultureInfo)(object)((Class7)null).j(bindingFlags_14, methodBase_4, ref *(object[]*)class31.W(bindingFlags, array5, (Type)(object)Class5.Default, array4, null), (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out object_3)), (object)null, cultureInfo);
					Class7 obj27 = (Class7)(object)@class.t(bindingFlags, array6, obj2, cultureInfo);
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass1)(object)obj27.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default);
				}
				while (@class.t(obj2, type, null) != null);
				continue;
			}
		}
		BindingFlags bindingFlags_15 = bindingFlags;
		FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
		Class7 class32 = @class;
		BindingFlags bindingFlags_16 = bindingFlags;
		MethodBase[] methodBase_5 = array;
		BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
		ref object[] object_6 = ref reference;
		ParameterModifier[] parameterModifier_4 = array2;
		Class7 obj28 = (Class7)(object)@class.W(default(BindingFlags), array5, type, array4, array2);
		bindingFlags = default(BindingFlags);
		CultureInfo cultureInfo_3 = (CultureInfo)(object)obj28.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)Class5.Default), null, null, array2);
		string[] string_3 = array3;
		Class7 class33 = @class;
		Class7 class34 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			nuint num9 = unchecked(checked(unchecked((nuint)(UIntPtr)((Class7)null).t(bindingFlags_15, fieldInfo_2, (object)class32.e(bindingFlags_16, methodBase_5, (Type[])(object)((Class7)null).j(bindingFlags_17, (MethodBase[])null, ref object_6, parameterModifier_4, cultureInfo_3, string_3, out *(object*)class33.t(class34.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])@class.t(null, null, cultureInfo), null, (string[])(object)Class5.Default, out *(object*)null), null, null)), null), (CultureInfo)null)) - unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out object_3))) / (nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr));
			Class7 class35 = @class;
			bindingFlags = default(BindingFlags);
			if (num9 + unchecked((nuint)(UIntPtr)class35.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array5, type, array4, array2), out object_3)) == 0)
			{
				class10 = class10;
			}
			while ((object)Class5.Default != null)
			{
				while ((object)Class5.Default != null)
				{
					while (obj2 != null)
					{
						gClass = gClass;
						gClass = gClass;
						_ = (Class7)(object)Class5.Default;
					}
				}
			}
			gClass4 = gClass4;
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			Class7 class36 = @class;
			MethodBase[] methodBase_6 = array;
			Type[] type_4 = array4;
			Class7 obj29 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class36.e(default(BindingFlags), methodBase_6, type_4, (ParameterModifier[])(object)obj29.j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array3, out object_3), ref reference, array2, (CultureInfo)null, (string[])null, out object_3), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)Class5.Default)) == (UIntPtr)(nuint)0u)
			{
				nuint num10 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked(num10 / checked(uIntPtr + uIntPtr)) * uIntPtr == 0)
					{
						gClass = gClass;
					}
				}
			}
			else
			{
				while (obj2 != null)
				{
					gClass3 = gClass3;
					_ = (Class6)(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default);
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		else if (uIntPtr == 0)
		{
			try
			{
				class15 = class15;
			}
			finally
			{
				class19 = null;
				goto IL_377e;
			}
		}
		goto IL_377e;
		IL_0af3:
		if (uIntPtr == 0)
		{
			GClass0 obj30 = (GClass0)(object)Class5.Default;
			gClass4 = null;
			gClass4 = obj30;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (GClass0)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					class10 = class10;
				}
				else
				{
					_ = (Struct1)Class5.Default;
					BindingFlags bindingFlags_18 = bindingFlags;
					BindingFlags bindingFlags_19 = (BindingFlags)((Class7)null).W((BindingFlags)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), array5, (Type)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)((Class7)null).W(bindingFlags, array5, type, array4, array2), (ParameterModifier[])null), (Type[])null, (ParameterModifier[])null);
					Type[] type_5 = array4;
					Class7 class37 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_7 = (MethodBase[])(object)((Class7)null).e(bindingFlags_19, (MethodBase[])null, type_5, (ParameterModifier[])(object)class37.j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo, null, out object_3));
					BindingFlags bindingFlags_20 = bindingFlags;
					MethodBase[] methodBase_8 = array;
					ref object[] object_7 = ref reference;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					object object_8 = obj2;
					Class7 class38 = @class;
					Class7 obj31 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					ref object[] object_9 = ref *(object[]*)((Class7)(object)((Class7)null).j(bindingFlags_20, methodBase_8, ref object_7, parameterModifier_5, (CultureInfo)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)((Class7)((Class7)null).t(object_8, (Type)(object)class38.e((BindingFlags)obj31.j(bindingFlags, null, ref reference, null, cultureInfo, null, out object_3), array, array4, array2), (CultureInfo)null)).j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, null, out *(object*)null), obj2, cultureInfo), (string[])(object)Class5.Default, out *(object*)null)).W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, array3, out *(object*)null), (Type[])(object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default), array2), type, (Type[])(object)Class5.Default, array2);
					Class7 class39 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags_18, methodBase_7, ref object_9, (ParameterModifier[])(object)class39.t(bindingFlags, array6, obj2, (CultureInfo)(object)Class5.Default), cultureInfo, (string[])null, out *(object*)null);
				}
			}
			goto IL_0f52;
		}
		try
		{
			_ = (Class4)(object)@class.j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out object_3);
		}
		catch
		{
			Class7 obj33 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_21 = (BindingFlags)Class5.Default;
			Type[] type_6 = array4;
			Class7 obj34 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_22 = bindingFlags;
			MethodBase[] methodBase_9 = array;
			ref object[] object_10 = ref *(object[]*)@class.t((BindingFlags)((Class7)(object)@class.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, array2)).t((BindingFlags)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array4, null), null, obj2, cultureInfo), null, obj2, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)((Class7)(object)obj33.e(bindingFlags_21, null, type_6, (ParameterModifier[])(object)obj34.j(bindingFlags_22, methodBase_9, ref object_10, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, null, null, null)).e(bindingFlags, null, array4, null), array4, array2), (CultureInfo)(object)Class5.Default, array3, out *(object*)Class5.Default))).t(bindingFlags, array6, obj2, cultureInfo);
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)((Class7)(object)@class.t(bindingFlags, array6, obj2, cultureInfo)).e((BindingFlags)Class5.Default, array, array4, null);
			}
			goto IL_0f52;
		}
		IL_1d2c:
		while ((object)Class5.Default != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class40.t(bindingFlags, null, Class5.Default, cultureInfo);
				}
			}
		}
		try
		{
			if ((UIntPtr)@class.e((BindingFlags)Class5.Default, null, array4, null) == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					class18 = null;
				}
				else
				{
					_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, array2, cultureInfo, array3, out *(object*)null), array4, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		finally
		{
			_ = (GClass2)(object)Class5.Default;
			goto IL_1dc9;
		}
		IL_4ac1:
		try
		{
			gClass3 = (GClass2)(object)Class5.Default;
			Class7 class41 = @class;
			object object_11 = obj2;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct1)class41.t(object_11, (Type)(object)((Class7)null).e((BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null), (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)@class.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default)), (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null), (ParameterModifier[])null));
		}
		finally
		{
			_ = (Class2)(object)Class5.Default;
			_ = (Class0)(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)@class.t(null, type, null), (string[])((Class7)(object)Class5.Default).t(obj2, (Type)((Class7)(object)Class5.Default).t(@class.t(obj2, null, cultureInfo), type, cultureInfo), cultureInfo), out *(object*)null);
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_4c3a;
		}
		IL_377e:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
			}
		}
		finally
		{
			Class7 class42 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_23 = bindingFlags;
			Class7 obj36 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)Class5.Default, array2, null, null, out object_3);
			MethodBase[] methodBase_10 = array;
			ref object[] object_12 = ref reference;
			ParameterModifier[] parameterModifier_6 = array2;
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)((Class7)(object)class42.W(bindingFlags_23, (PropertyInfo[])(object)obj36.j(default(BindingFlags), methodBase_10, ref object_12, parameterModifier_6, (CultureInfo)(object)class43.t(bindingFlags, null, obj2, cultureInfo), array3, out object_3), null, null, (ParameterModifier[])(object)Class5.Default)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, null, array3, out object_3), obj2, null);
			goto IL_39b9;
		}
		IL_0f52:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass = (GClass3)(object)Class5.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)@class.W(bindingFlags, array5, null, array4, null);
				class6 = class6;
				class16 = class16;
			}
		}
		catch
		{
			if (checked((unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default)) * uIntPtr) == 0)
			{
				_ = (Class5)((Class7)null).t(obj2, (Type)null, cultureInfo);
			}
			else
			{
				_ = (Struct1)((Class7)null).t((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out object_3), type, cultureInfo);
				Class7 obj37 = (Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)@class.e(bindingFlags, array, array4, array2)).j((BindingFlags)((Class7)null).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)@class.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default), ref reference, null, null, (string[])(object)Class5.Default, out *(object*)null), ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)((Class7)@class.t(obj2, type, null)).W(bindingFlags, array5, type, null, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, array2, (CultureInfo)(object)Class5.Default, array3, out object_3)), array3, out *(object*)@class.t((BindingFlags)@class.t(obj2, null, null), null, obj2, null)), ref reference, (ParameterModifier[])null, cultureInfo, array3, out object_3);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj37.e(bindingFlags, array, array4, array2);
				qk = (Qk7)((Class7)(object)@class.j(bindingFlags, array, ref reference, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)null)).t(obj2, null, cultureInfo);
				_ = (_003CModule_003E)@class.t(null, type, null);
			}
		}
		finally
		{
			goto IL_11d3;
		}
		IL_11d3:
		_ = (Qk7)(object)((Class7)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)Class5.Default)).t((BindingFlags)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), null, obj2, cultureInfo);
		if ((UIntPtr)@class.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num11 = uIntPtr;
				UIntPtr num12 = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				nuint num13 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num11 * (unchecked((nuint)num12) + (num13 + uIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default / checked(uIntPtr - uIntPtr))) == 0)
				{
					BindingFlags bindingFlags_24 = bindingFlags;
					MethodBase[] methodBase_11 = (MethodBase[])(object)Class5.Default;
					ref object[] object_13 = ref reference;
					ParameterModifier[] parameterModifier_7 = array2;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).j(bindingFlags_24, methodBase_11, ref object_13, parameterModifier_7, (CultureInfo)(object)class44.W(bindingFlags, array5, type, array4, array2), array3, out *(object*)null);
				}
				else
				{
					_003CModule_003E obj39 = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = null;
					_003CModule_003E = obj39;
				}
			}
			finally
			{
				try
				{
					struct2 = (Struct1)((Class7)(object)@class.t(bindingFlags, array6, obj2, cultureInfo)).j(bindingFlags, null, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array5, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, (Type[])((Class7)null).t(obj2, (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])@class.t(null, null, cultureInfo), array2)), (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array3, out object_3)), null)));
				}
				catch
				{
					class9 = null;
				}
				goto IL_143e;
			}
		}
		goto IL_143e;
		IL_1dc9:
		try
		{
			while (obj2 != null)
			{
				if (uIntPtr == 0)
				{
					class6 = class6;
				}
				else
				{
					class19 = class19;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				_ = (Class5)(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo);
			}
			goto IL_1e27;
		}
		IL_4c3a:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					gClass2 = gClass2;
				}
				while (obj2 != null);
			}
			else
			{
				UIntPtr num14 = (UIntPtr)Class5.Default;
				Class7 class45 = @class;
				Type type_7 = type;
				Class7 class46 = @class;
				bindingFlags = default(BindingFlags);
				nuint num15;
				Class7 class47;
				BindingFlags bindingFlags_25;
				PropertyInfo[] propertyInfo_;
				Type type_8;
				Type[] type_9;
				checked
				{
					num15 = unchecked((nuint)num14) + unchecked((nuint)(UIntPtr)class45.t(null, type_7, (CultureInfo)(object)class46.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, null, null), null, null))) * uIntPtr;
					class47 = @class;
					bindingFlags_25 = bindingFlags;
					propertyInfo_ = array5;
					type_8 = type;
					type_9 = (Type[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				if (num15 / (nuint)(UIntPtr)class47.W(bindingFlags_25, propertyInfo_, type_8, type_9, (ParameterModifier[])(object)((Class7)(object)((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out object_3), (ParameterModifier[])null)).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, cultureInfo), obj2, cultureInfo)) == 0)
				{
					class18 = null;
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					gClass3 = null;
				}
				finally
				{
					_ = (Class6)@class.t(obj2, null, (CultureInfo)(object)Class5.Default);
					continue;
				}
			}
		}
		Class7 obj42 = (Class7)(object)Class5.Default;
		Class7 obj43 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_26 = bindingFlags;
		MethodBase[] methodBase_12 = array;
		ref object[] object_14 = ref reference;
		ParameterModifier[] parameterModifier_8 = array2;
		CultureInfo cultureInfo_4 = (CultureInfo)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array4, array2)).t(null, type, cultureInfo);
		string[] string_4 = (string[])(object)((Class7)null).t((BindingFlags)@class.W(default(BindingFlags), array5, null, array4, (ParameterModifier[])(object)Class5.Default), array6, obj2, cultureInfo);
		Class7 class48 = @class;
		bindingFlags = default(BindingFlags);
		UIntPtr num16 = (UIntPtr)obj42.t(obj43.j(bindingFlags_26, methodBase_12, ref object_14, parameterModifier_8, cultureInfo_4, string_4, out *(object*)class48.W(bindingFlags, array5, type, array4, null)), type, null);
		uIntPtr = default(UIntPtr);
		UIntPtr num17 = uIntPtr;
		UIntPtr num18 = (UIntPtr)Class5.Default;
		UIntPtr num19 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked((unchecked((nuint)num16) + (unchecked((nuint)num17) + unchecked((nuint)num18) * (unchecked((nuint)num19 / uIntPtr) + uIntPtr) + uIntPtr)) * (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array6, null, cultureInfo)))) / (nuint)(UIntPtr)@class.t((BindingFlags)@class.t(null, type, cultureInfo), array6, obj2, (CultureInfo)(object)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)(object)Class5.Default)) == 0)
		{
			try
			{
				class18 = class18;
			}
			finally
			{
				if ((UIntPtr)((Class7)null).t(obj2, type, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					_ = (Class7)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				goto IL_4fa8;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				gClass2 = null;
			}
			while (obj2 != null);
		}
		goto IL_4fa8;
		IL_2b98:
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					Class7 class49 = @class;
					object object_15 = obj2;
					Type type_10 = type;
					Class7 class50 = @class;
					Class7 obj44 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = (BindingFlags)obj44.t(bindingFlags, null, ((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])@class.t(null, type, (CultureInfo)(object)Class5.Default), null, array2)).j(bindingFlags, array, ref *(object[]*)null, null, null, array3, out *(object*)null), (CultureInfo)(object)Class5.Default);
					MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
					Type[] type_11 = (Type[])(object)Class5.Default;
					Class7 obj45 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)class49.t(object_15, type_10, (CultureInfo)(object)class50.e(bindingFlags_27, methodBase_13, type_11, (ParameterModifier[])(object)obj45.j(bindingFlags, null, ref reference, array2, null, (string[])(object)Class5.Default, out object_3)));
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
					class19 = class19;
				}
				catch
				{
					BindingFlags bindingFlags_28 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array6;
					object object_16 = obj2;
					bindingFlags = default(BindingFlags);
					Class7 obj46 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array2);
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t(bindingFlags_28, fieldInfo_3, object_16, (CultureInfo)(object)((Class7)(object)obj46.W(bindingFlags, array5, type, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array, null, null))).t((BindingFlags)Class5.Default, array6, obj2, cultureInfo));
					_ = (_003CModule_003E)(object)@class.t(bindingFlags, array6, obj2, cultureInfo);
				}
				goto end_IL_2b99;
			}
			end_IL_2b99:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				while (obj2 != null)
				{
					class19 = (Class0)(object)Class5.Default;
				}
			}
			else
			{
				class9 = class9;
				@class = @class;
			}
		}
		_ = (GClass2)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, array2, null, array3, out object_3);
		if (uIntPtr == 0)
		{
			do
			{
				class19 = class19;
			}
			while (obj2 != null || (object)Class5.Default != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					class8 = null;
					goto end_IL_2e19;
				}
				end_IL_2e19:;
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class8 = class8;
				}
			}
			catch
			{
				try
				{
					_ = (Class0)(object)((Class7)null).j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out *(object*)Class5.Default);
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					goto end_IL_2e4e;
				}
				end_IL_2e4e:;
			}
		}
		qk = qk;
		class19 = null;
		_ = (Struct1)((Class7)null).W((BindingFlags)Class5.Default, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out *(object*)null));
		_ = (GClass0)(object)Class5.Default;
		_ = (Class7)(object)Class5.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class7)(object)((Class7)((Class7)null).t((object)Class5.Default, type, cultureInfo)).t(bindingFlags, null, null, null);
					_ = (GClass1)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto IL_2fff;
				}
			}
			do
			{
				_ = (Class9)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		else
		{
			class10 = null;
		}
		goto IL_2fff;
		IL_143e:
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				Class7 obj51 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_29 = bindingFlags;
				ref object[] object_17 = ref *(object[]*)@class.e((BindingFlags)Class5.Default, null, null, array2);
				Class7 class51 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)obj51.j(bindingFlags_29, null, ref object_17, (ParameterModifier[])(object)class51.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.e(bindingFlags, array, null, array2), cultureInfo, (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, null, out object_3), out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, null, out object_3)), cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array3, out object_3), (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)@class.t(bindingFlags, array6, obj2, null)).j(bindingFlags, null, ref *(object[]*)@class.t(obj2, null, cultureInfo), array2, null, (string[])(object)Class5.Default, out *(object*)null), null, cultureInfo, array3, out *(object*)Class5.Default), array6, null, null), out *(object*)null);
			}
		}
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					@class = @class;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) * (uIntPtr + unchecked((nuint)(UIntPtr)@class.e((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).t((object)@class.j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, null, out object_3), type, cultureInfo), null, cultureInfo, null, out *(object*)@class.t(obj2, (Type)@class.t(@class.t(bindingFlags, null, obj2, cultureInfo), type, null), null)), array, array4, (ParameterModifier[])(object)Class5.Default)) * uIntPtr)) == 0)
		{
			while (obj2 != null)
			{
				gClass2 = (GClass1)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array4, array2);
				_ = (Class10)(object)Class5.Default;
				class8 = null;
			}
		}
		else
		{
			try
			{
				class18 = class18;
			}
			catch
			{
				_ = (GClass3)(object)@class.e((BindingFlags)Class5.Default, array, null, array2);
			}
		}
		_ = (Struct1)@class.t((BindingFlags)Class5.Default, array6, null, cultureInfo);
		class6 = (Class10)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out *(object*)((Class7)((Class7)null).t((object)@class.t((BindingFlags)@class.t(default(BindingFlags), array6, @class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), cultureInfo), (FieldInfo[])(object)@class.j(default(BindingFlags), array, ref reference, null, null, null, out object_3), Class5.Default, cultureInfo), type, (CultureInfo)null)).W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, null, array4, (ParameterModifier[])(object)Class5.Default)), array5, type, (Type[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).j(default(BindingFlags), array, ref reference, array2, cultureInfo, (string[])null, out object_3), ref reference, array2, cultureInfo, null, out object_3), array2));
		Class7 class52 = @class;
		Class7 class53 = @class;
		Class7 obj53 = (Class7)(object)Class5.Default;
		Class7 class54 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)(UIntPtr)class52.W((BindingFlags)class53.t(default(BindingFlags), (FieldInfo[])(object)obj53.j(default(BindingFlags), (MethodBase[])(object)class54.e(bindingFlags, array, array4, null), ref *(object[]*)null, array2, cultureInfo, array3, out *(object*)null), ((Class7)@class.t(obj2, null, null)).e(bindingFlags, array, null, array2), (CultureInfo)(object)Class5.Default), array5, type, array4, null) / (nuint)(UIntPtr)Class5.Default) - unchecked(uIntPtr / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				do
				{
					_ = (GClass1)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, cultureInfo);
				}
				while (obj2 != null);
			}
			class16 = null;
		}
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					BindingFlags bindingFlags_30 = bindingFlags;
					Class7 obj54 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_31 = bindingFlags;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_32 = bindingFlags;
					object object_18 = obj2;
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj55 = (Class7)(object)((Class7)null).W(bindingFlags_30, (PropertyInfo[])(object)obj54.W(bindingFlags_31, (PropertyInfo[])(object)class55.e(bindingFlags_32, (MethodBase[])((Class7)null).t(object_18, (Type)(object)class56.W(bindingFlags, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (CultureInfo)((Class7)(object)((Class7)(object)@class.j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, array3, out object_3)).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])@class.t(null, type, cultureInfo), (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), array3, out *(object*)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])null))).t(obj2, null, null)), array4, array2), (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)((Class7)(object)@class.W((BindingFlags)Class5.Default, null, null, (Type[])((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)@class.W(bindingFlags, null, type, null, null)), array2)).j((BindingFlags)@class.t(Class5.Default, null, (CultureInfo)(object)Class5.Default), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, null, array3, out object_3), array2, null, (string[])(object)Class5.Default, out object_3), array4, (ParameterModifier[])(object)@class.e((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, null, out object_3), array, array4, array2)), type, array4, array2);
					BindingFlags bindingFlags_33 = bindingFlags;
					object object_19 = Class5.Default;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj55.t(bindingFlags_33, null, object_19, (CultureInfo)(object)class57.W(bindingFlags, null, type, array4, array2));
				}
				finally
				{
					_ = (GClass3)((Class7)null).t(obj2, type, cultureInfo);
					goto end_IL_1a0e;
				}
			}
			end_IL_1a0e:;
		}
		finally
		{
			_ = (Struct1)Class5.Default;
			goto IL_1d2c;
		}
		IL_39b9:
		while (true)
		{
			Class7 class58 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class58.j(bindingFlags, array, ref reference, array2, null, (string[])(object)((Class7)null).t((BindingFlags)Class5.Default, array6, obj2, cultureInfo), out *(object*)Class5.Default) == null)
			{
				break;
			}
			try
			{
				checked
				{
					if (uIntPtr - unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array5, type, array4, array2)) == 0)
					{
						class18 = class18;
						_ = (GClass0)(object)Class5.Default;
					}
					else
					{
						class9 = (Class9)(object)@class.t(bindingFlags, array6, obj2, null);
					}
				}
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array2) == (UIntPtr)(nuint)0u)
				{
					Class7 obj56 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj56.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array2);
					_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(@class.t(obj2, type, null), type, cultureInfo), obj2, cultureInfo));
					qk = null;
					_ = (GClass0)(object)Class5.Default;
				}
				continue;
			}
		}
		Class7 class59 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)class59.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
		class18 = (Class6)((Class7)null).t((object)Class5.Default, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])null, cultureInfo, array3, out *(object*)null), (CultureInfo)null);
		_ = (_003CModule_003E)(object)Class5.Default;
		@struct = default(Struct2);
		do
		{
			nuint num20 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num20 - uIntPtr) != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class16 = (Class2)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo);
				}
				continue;
			}
			try
			{
				Class7 class60 = @class;
				BindingFlags bindingFlags_34 = bindingFlags;
				MethodBase[] methodBase_14 = array;
				Type[] type_12 = array4;
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class60.e(bindingFlags_34, methodBase_14, type_12, (ParameterModifier[])(object)((Class7)(object)class61.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null), null, cultureInfo)).W((BindingFlags)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, cultureInfo), array5, null, (Type[])@class.t(obj2, type, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)null)), (ParameterModifier[])(object)@class.W(bindingFlags, null, type, array4, array2)));
				_ = (GClass2)(object)@class.e(bindingFlags, array, null, null);
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				_ = (Class8)(object)@class.e(bindingFlags, array, array4, array2);
			}
		}
		while (obj2 != null);
		do
		{
			class16 = class16;
			gClass3 = gClass3;
		}
		while (obj2 != null);
		class8 = class8;
		class15 = class15;
		_ = (Class8)(object)@class.e((BindingFlags)@class.e((BindingFlags)@class.W(bindingFlags, array5, type, array4, null), array, null, array2), null, (Type[])(object)Class5.Default, null);
		gClass2 = null;
		_ = (Struct2)Class5.Default;
		while (true)
		{
			if (uIntPtr != 0)
			{
				Class7 class62 = @class;
				BindingFlags bindingFlags_35 = (BindingFlags)((Class7)(object)((Class7)null).W(default(BindingFlags), array5, type, array4, array2)).t(Class5.Default, type, cultureInfo);
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class62.j(bindingFlags_35, (MethodBase[])(object)class63.W(bindingFlags, array5, (Type)(object)Class5.Default, array4, array2), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, array6, obj2, null)), type, array4, array2), array3, out object_3);
			}
			else
			{
				class15 = (Class8)(object)Class5.Default;
			}
			BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).W(bindingFlags_36, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array2), (Type)(object)@class.t(bindingFlags, array6, obj2, (CultureInfo)(object)Class5.Default), array4, array2) == null)
			{
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class64.t(bindingFlags, array6, obj2, cultureInfo) == null)
				{
					break;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Class7)(object)@class.e(bindingFlags, array, null, (ParameterModifier[])@class.t(obj2, type, cultureInfo));
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					@struct = (Struct2)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type, null), array5, type, null, array2);
				}
				else
				{
					gClass3 = (GClass2)(object)Class5.Default;
				}
			}
		}
		_ = (GClass0)(object)Class5.Default;
		_ = (Class0)(object)((Class7)null).j(default(BindingFlags), array, ref reference, array2, (CultureInfo)(object)@class.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out object_3), array3, out object_3);
		_ = (Class7)(object)Class5.Default;
		Class7 obj58 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class7)((Class7)(object)obj58.j(bindingFlags, null, ref *(object[]*)@class.t(bindingFlags, array6, null, cultureInfo), null, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, cultureInfo))).t(obj2, type, cultureInfo);
		while (obj2 != null)
		{
			Class7 class65 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class65.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null) == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					gClass2 = gClass2;
				}
				continue;
			}
			try
			{
				_ = (Class9)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, null);
			}
			finally
			{
				_ = (Class5)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])null);
				continue;
			}
		}
		Class7 obj59;
		do
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, array3, out object_3) == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)(object)Class5.Default;
			}
			obj59 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj59.j(bindingFlags, array, ref reference, array2, (CultureInfo)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), array3, out object_3) != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					@class = (Class7)@class.t(null, type, cultureInfo);
				}
				finally
				{
					class9 = null;
					struct2 = default(Struct1);
					_ = (Class4)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		if (uIntPtr != (UIntPtr)(nuint)0u)
		{
		}
		try
		{
			_ = (Class6)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array2);
		}
		catch
		{
			_ = (Struct1)((Class7)null).t((object)Class5.Default, (Type)@class.t(obj2, null, cultureInfo), (CultureInfo)null);
		}
		_ = (Class4)(object)Class5.Default;
		class8 = null;
		struct2 = default(Struct1);
		Class7 class66 = @class;
		PropertyInfo[] propertyInfo_2 = array5;
		Class7 class67 = @class;
		MethodBase[] methodBase_15 = array;
		ref object[] object_20 = ref reference;
		CultureInfo cultureInfo_5 = cultureInfo;
		Class7 obj61 = (Class7)@class.t(null, null, cultureInfo);
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)class66.W(default(BindingFlags), propertyInfo_2, (Type)(object)class67.j(default(BindingFlags), methodBase_15, ref object_20, null, cultureInfo_5, (string[])(object)((Class7)(object)obj61.t(bindingFlags, array6, obj2, (CultureInfo)@class.t(@class.j(bindingFlags, array, ref reference, array2, null, array3, out object_3), type, cultureInfo))).e(bindingFlags, null, array4, null), out object_3), null, array2);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Class2)(object)Class5.Default;
		}
		else
		{
			while (true)
			{
				if (obj2 != null)
				{
					Class7 class68 = @class;
					BindingFlags bindingFlags_37 = bindingFlags;
					MethodBase[] methodBase_16 = (MethodBase[])(object)Class5.Default;
					ref object[] object_21 = ref reference;
					Class7 class69 = @class;
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).j((BindingFlags)class68.j(bindingFlags_37, methodBase_16, ref object_21, (ParameterModifier[])(object)class69.t((BindingFlags)class70.W(bindingFlags, null, null, array4, null), array6, null, null), cultureInfo, array3, out object_3), array, ref reference, array2, (CultureInfo)null, (string[])null, out *(object*)Class5.Default);
					gClass2 = gClass2;
					qk = (Qk7)(object)Class5.Default;
					_ = (Class4)(object)Class5.Default;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		if ((UIntPtr)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)@class.t(null, type, cultureInfo);
				}
				goto IL_444c;
			}
		}
		_ = (Struct1)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
		goto IL_444c;
		IL_2b30:
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default / uIntPtr) != 0)
				{
					@class = null;
					_ = (Class7)(object)Class5.Default;
					class15 = null;
					Class7 class71 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class71.t(bindingFlags, null, obj2, cultureInfo);
				}
				else
				{
					Class7 class72 = @class;
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)((Class7)(object)class72.W(default(BindingFlags), (PropertyInfo[])(object)class73.W(bindingFlags, null, type, array4, array2), type, null, (ParameterModifier[])(object)@class.t(bindingFlags, array6, obj2, cultureInfo))).t(obj2, type, cultureInfo);
				}
			}
			while (obj2 != null);
			_ = (Class10)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
			nuint num21 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num21 / uIntPtr == 0)
			{
				_ = Class5.Default;
			}
		}
		finally
		{
			goto IL_2b98;
		}
		IL_1e27:
		Class7 obj62 = (Class7)(object)@class.W(default(BindingFlags), null, type, (Type[])(object)@class.W(default(BindingFlags), array5, type, array4, (ParameterModifier[])(object)Class5.Default), array2);
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)obj62.j(bindingFlags, array, ref *(object[]*)@class.t(null, type, cultureInfo), array2, null, array3, out *(object*)null);
		while ((object)Class5.Default != null)
		{
			while (obj2 != null)
			{
				_ = (GClass2)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, array3, out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])null, (ParameterModifier[])null));
			}
		}
		do
		{
			MethodBase[] methodBase_17 = array;
			Type[] type_13 = array4;
			object object_22 = obj2;
			Type type_14 = type;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).e(default(BindingFlags), methodBase_17, type_13, (ParameterModifier[])(object)((Class7)((Class7)null).t(object_22, type_14, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null))).t((BindingFlags)Class5.Default, array6, null, null)) == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null)).j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)null)).W((BindingFlags)Class5.Default, array5, null, array4, array2), (object)null, cultureInfo);
				}
			}
		}
		while (obj2 != null);
		class15 = class15;
		while (obj2 != null)
		{
			class8 = class8;
		}
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					gClass = gClass;
				}
				finally
				{
					gClass3 = gClass3;
					goto end_IL_2063;
				}
			}
			while (@class.t(null, type, null) != null)
			{
				@struct = (Struct2)Class5.Default;
			}
			end_IL_2063:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				@class = @class;
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				nuint num22 = uIntPtr;
				bindingFlags = default(BindingFlags);
				checked
				{
					nuint num23 = num22 * unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, array5, type, array4, array2));
					uIntPtr = default(UIntPtr);
					if (num23 - uIntPtr == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
					else
					{
						_ = (Class8)(object)Class5.Default;
						Class7 obj64 = (Class7)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						_ = (GClass0)(object)obj64.j(bindingFlags, array, ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out object_3);
					}
				}
			}
		}
		catch
		{
			_ = (Class8)(object)Class5.Default;
		}
		try
		{
			while (obj2 != null)
			{
				do
				{
					@struct = @struct;
				}
				while (obj2 != null);
			}
		}
		catch
		{
		}
		gClass3 = gClass3;
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_18 = array;
					ref object[] object_23 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_6 = (CultureInfo)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
					Class7 class74 = @class;
					Class7 class75 = @class;
					BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)((Class7)null).j(bindingFlags_38, methodBase_18, ref object_23, parameterModifier_9, cultureInfo_6, (string[])(object)class74.j((BindingFlags)class75.e(bindingFlags_39, (MethodBase[])(object)((Class7)(object)((Class7)null).e((BindingFlags)class76.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])@class.t(null, type, null), out *(object*)null), (MethodBase[])(object)Class5.Default, array4, array2)).e(bindingFlags, array, array4, array2), null, array2), array, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, array3, out *(object*)null), out object_3);
					goto end_IL_21a1;
				}
				end_IL_21a1:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class6)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				continue;
			}
		}
		if (uIntPtr == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class8)(object)Class5.Default;
			_ = (Struct2)Class5.Default;
		}
		try
		{
			try
			{
				class8 = null;
				struct2 = struct2;
			}
			finally
			{
				if ((UIntPtr)@class.t(obj2, type, null) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array2);
				}
				goto end_IL_2336;
			}
			end_IL_2336:;
		}
		catch
		{
			qk = qk;
		}
		try
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				qk = qk;
				_ = (Struct2)Class5.Default;
			}
			finally
			{
				class19 = class19;
				qk = null;
				_ = (Class5)(object)((Class7)@class.t(obj2, type, null)).W(bindingFlags, array5, type, null, null);
				goto end_IL_2385;
			}
			end_IL_2385:;
		}
		catch
		{
			class19 = null;
		}
		_ = (Class5)(object)((Class7)(object)@class.e(bindingFlags, array, array4, null)).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				@struct = @struct;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Struct1)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.e(bindingFlags, array, null, array2), obj2, cultureInfo);
				}
			}
			catch
			{
				class9 = class9;
			}
		}
		Class7 obj71 = (Class7)(object)@class.e(bindingFlags, null, array4, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)obj71.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)Class5.Default));
		try
		{
			class18 = null;
		}
		catch
		{
			nuint num25;
			Class7 obj72;
			checked
			{
				nuint num24 = unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array4, array2));
				uIntPtr = default(UIntPtr);
				num25 = num24 - (uIntPtr + uIntPtr);
				obj72 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
			}
			if (num25 / checked(unchecked((nuint)(UIntPtr)obj72.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).W(bindingFlags, array5, type, array4, (ParameterModifier[])(object)Class5.Default))) * unchecked((nuint)default(UIntPtr))) != 0)
			{
				try
				{
					_ = (GClass0)(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array3, out object_3);
				}
				finally
				{
					Class7 obj73 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array2);
					BindingFlags bindingFlags_40 = (BindingFlags)Class5.Default;
					Class7 obj74 = (Class7)((Class7)((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, null, obj2, null))).t(obj2, type, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_41 = bindingFlags;
					Class7 class77 = @class;
					BindingFlags bindingFlags_42 = (BindingFlags)@class.t(@class.t(null, type, null), type, (CultureInfo)(object)((Class7)null).W((BindingFlags)@class.t((BindingFlags)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array2), null, obj2, cultureInfo), array5, type, array4, (ParameterModifier[])(object)Class5.Default));
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					Type type_15 = type;
					Class7 class78 = @class;
					BindingFlags bindingFlags_43 = (BindingFlags)Class5.Default;
					object object_24 = obj2;
					Class7 class79 = @class;
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj73.t(bindingFlags_40, (FieldInfo[])(object)obj74.e(bindingFlags_41, (MethodBase[])(object)class77.W(bindingFlags_42, propertyInfo_3, type_15, (Type[])(object)class78.t(bindingFlags_43, null, object_24, (CultureInfo)((Class7)(object)class79.W((BindingFlags)class80.W(bindingFlags, null, type, array4, array2), array5, type, null, (ParameterModifier[])(object)Class5.Default)).t(Class5.Default, type, null)), null), null, array2), null, null);
					goto end_IL_2540;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class6)@class.t(obj2, type, null);
			}
			else
			{
				Class7 class81 = @class;
				ref object[] object_25 = ref reference;
				ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class81.j(default(BindingFlags), null, ref object_25, parameterModifier_10, null, (string[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj2, cultureInfo), (CultureInfo)null, array3, out *(object*)Class5.Default), out object_3);
			}
			end_IL_2540:;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			UIntPtr num26 = uIntPtr;
			MethodBase[] methodBase_19 = array;
			Class7 class82 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num26) + unchecked((nuint)(UIntPtr)((Class7)null).e(default(BindingFlags), methodBase_19, (Type[])(object)class82.W(bindingFlags, null, type, null, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, null, cultureInfo), (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)Class5.Default), out object_3)), array2)) == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Class0)((Class7)null).t((object)null, type, cultureInfo);
				}
				else
				{
					class18 = null;
				}
			}
			finally
			{
				Class7 class83 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_44 = bindingFlags;
				MethodBase[] methodBase_20 = array;
				ref object[] object_26 = ref reference;
				ParameterModifier[] parameterModifier_11 = array2;
				Class7 obj76 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)class83.j(bindingFlags_44, methodBase_20, ref object_26, parameterModifier_11, (CultureInfo)(object)obj76.e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default), array3, out *(object*)null);
				goto end_IL_295c;
			}
			end_IL_295c:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class0)((Class7)null).t(obj2, type, (CultureInfo)null);
				_ = (Struct1)@class.W(bindingFlags, array5, (Type)(object)Class5.Default, array4, null);
				class15 = null;
				_ = (Class10)(object)Class5.Default;
			}
			goto IL_2b30;
		}
	}

	unsafe static void smethod_5()
	{
		_ = (Struct1)Class5.Default;
		nuint num = (UIntPtr)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (num == 0)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		else
		{
			do
			{
				_ = (Class4)(object)Class5.Default;
				@class = null;
				Class7 class2 = @class;
				bindingFlags = bindingFlags;
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
				type = type;
				Type type_ = type;
				array = array;
				Type[] type_2 = array;
				Class7 class3 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_ = bindingFlags;
				array2 = array2;
				MethodBase[] methodBase_ = array2;
				Type[] type_3 = (Type[])@class.t(obj, type, null);
				array3 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj2 = (Class7)(object)class3.e(bindingFlags_, methodBase_, type_3, array3);
				BindingFlags bindingFlags_2 = bindingFlags;
				array4 = array4;
				obj = class2.W(default(BindingFlags), propertyInfo_, type_, type_2, (ParameterModifier[])(object)obj2.t(bindingFlags_2, array4, Class5.Default, (CultureInfo)(object)Class5.Default));
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class4);
		do
		{
			nuint num2 = num;
			num = default(UIntPtr);
			if (num2 / num != 0)
			{
				_ = (Class6)(object)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])null);
				continue;
			}
			Class8 obj3 = (Class8)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
			class4 = class4;
			class4 = obj3;
		}
		while ((object)Class5.Default != null || obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class9);
		Class0 class10;
		do
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Class7 obj4 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_3 = bindingFlags;
					ref object[] object_ = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_ = array3;
					cultureInfo = (CultureInfo)(object)Class5.Default;
					_ = (Struct1)obj4.j(bindingFlags_3, null, ref object_, parameterModifier_, cultureInfo, null, out *(object*)Class5.Default);
				}
				else
				{
					Class7 class5 = @class;
					BindingFlags bindingFlags_4 = bindingFlags;
					Class7 obj5 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_5 = bindingFlags;
					Class7 class6 = @class;
					BindingFlags bindingFlags_6 = bindingFlags;
					Class7 class7 = @class;
					array5 = array5;
					MethodBase[] methodBase_2 = (MethodBase[])(object)class7.W(default(BindingFlags), array5, type, array, null);
					reference = ref *(object[]*)Class5.Default;
					ref object[] object_2 = ref reference;
					ParameterModifier[] parameterModifier_2 = array3;
					Class7 class8 = @class;
					MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
					MethodBase[] methodBase_4 = array2;
					Class7 obj6 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_7 = bindingFlags;
					MethodBase[] methodBase_5 = array2;
					ref object[] object_3 = ref reference;
					ParameterModifier[] parameterModifier_3 = array3;
					CultureInfo cultureInfo_ = cultureInfo;
					array6 = null;
					string[] string_ = array6;
					reference2 = ref reference2;
					_ = (GClass3)(object)class5.j(bindingFlags_4, (MethodBase[])(object)obj5.W(bindingFlags_5, null, null, (Type[])(object)class6.j(bindingFlags_6, methodBase_2, ref object_2, parameterModifier_2, (CultureInfo)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)class8.j(default(BindingFlags), methodBase_3, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), methodBase_4, (Type[])(object)obj6.j(bindingFlags_7, methodBase_5, ref object_3, parameterModifier_3, cultureInfo_, string_, out reference2), array3), array6, out *(object*)null)), null, out *(object*)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array6, out reference2)), array3), ref reference, array3, null, null, out *(object*)((Class7)@class.t(obj, type, cultureInfo)).e(default(BindingFlags), null, (Type[])(object)Class5.Default, array3));
					_ = (Class9)(object)Class5.Default;
					Class6 obj7 = (Class6)(object)Class5.Default;
					class9 = class9;
					class9 = obj7;
				}
			}
			finally
			{
				bindingFlags = default(BindingFlags);
				class10 = (Class0)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)@class.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array, array3), null, ref *(object[]*)Class5.Default, array3, cultureInfo, array6, out reference2), out reference2);
				class10 = null;
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class14);
		while (true)
		{
			Class7 class11 = @class;
			BindingFlags bindingFlags_8 = bindingFlags;
			Class7 class12 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)(object)class11.t(bindingFlags_8, null, class12.j(bindingFlags, (MethodBase[])@class.t(obj, type, cultureInfo), ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), cultureInfo)).W(bindingFlags, array5, null, array, array3) == null)
			{
				break;
			}
			try
			{
				class13 = (Class4)(object)Class5.Default;
				class13 = class13;
			}
			catch
			{
				do
				{
					class14 = class14;
					class14 = null;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Struct1)((Class7)null).t(obj, type, cultureInfo);
				}
				finally
				{
					qk = qk;
					qk = qk;
					@struct = @struct;
					@struct = default(Struct1);
					@struct = @struct;
					gClass = gClass;
					gClass = gClass;
					class15 = class15;
					class15 = class15;
					goto end_IL_04ec;
				}
				end_IL_04ec:;
			}
			finally
			{
				try
				{
					class4 = (Class8)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass2)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo);
					class16 = class16;
					class16 = class16;
					_ = (Class6)(object)Class5.Default;
					Class7 class17 = @class;
					Type type_4 = type;
					bindingFlags = default(BindingFlags);
					_ = (Class9)class17.t(null, type_4, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, array3));
				}
				goto IL_06b3;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num + unchecked((nuint)(UIntPtr)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array5, type, (Type[])@class.t(obj, type, null), array3), null, (ParameterModifier[])(object)Class5.Default)) == 0)
				{
					class13 = class13;
				}
				else
				{
					struct2 = struct2;
					struct2 = struct2;
				}
			}
			catch
			{
				@struct = @struct;
				_ = (Class4)(object)@class.t(bindingFlags, array4, obj, (CultureInfo)(object)Class5.Default);
				class16 = class16;
				@class = null;
			}
			goto IL_06b3;
		}
		IL_1db1:
		if (num == 0)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		gClass = gClass;
		try
		{
			try
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					class15 = null;
				}
				finally
				{
					class14 = class14;
					goto end_IL_1dca;
				}
			}
			end_IL_1dca:;
		}
		finally
		{
			try
			{
				class15 = null;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)Class5.Default;
					class4 = null;
					_ = (GClass2)(object)Class5.Default;
				}
				goto IL_1e28;
			}
		}
		IL_1ffb:
		do
		{
			Class7 obj11 = (Class7)(object)Class5.Default;
			Class7 class18 = @class;
			Class7 class19 = @class;
			BindingFlags bindingFlags_9 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)obj11.t(class18.t(class19.e(bindingFlags_9, (MethodBase[])(object)((Class7)null).e(bindingFlags, array2, array, (ParameterModifier[])null), array, array3), (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default))).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array6, out reference2)), type, null);
		}
		while ((object)Class5.Default != null);
		try
		{
			num = default(UIntPtr);
			if (checked(num - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				while (obj != null)
				{
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class20 = @class;
					BindingFlags bindingFlags_11 = bindingFlags;
					MethodBase[] methodBase_6 = array2;
					Type[] type_5 = array;
					BindingFlags bindingFlags_12 = (BindingFlags)@class.t(bindingFlags, array4, null, null);
					MethodBase[] methodBase_7 = array2;
					Type[] type_6 = array;
					Class7 class21 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).W(bindingFlags_10, (PropertyInfo[])(object)class20.e(bindingFlags_11, methodBase_6, type_5, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_12, methodBase_7, type_6, (ParameterModifier[])(object)class21.t(bindingFlags, array4, obj, null))), (Type)(object)@class.e((BindingFlags)@class.t(bindingFlags, array4, obj, null), array2, null, array3), array, (ParameterModifier[])null);
				}
			}
		}
		finally
		{
			_ = (Class0)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array, array3);
			goto IL_21f0;
		}
		IL_4941:
		Class7 obj12 = (Class7)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default));
		BindingFlags bindingFlags_13 = bindingFlags;
		Class7 obj13 = (Class7)(object)@class.t(bindingFlags, array4, obj, cultureInfo);
		PropertyInfo[] propertyInfo_2 = array5;
		Class7 class22 = @class;
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)obj13.W(default(BindingFlags), propertyInfo_2, (Type)(object)class22.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array3), array, null);
		Class7 obj14 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_14 = bindingFlags;
		MethodBase[] methodBase_8 = array2;
		ref object[] object_4 = ref *(object[]*)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])null);
		Class7 class23 = @class;
		bindingFlags = default(BindingFlags);
		ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)class23.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)null);
		string[] string_2 = array6;
		Class7 obj15 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_15 = bindingFlags;
		Class7 class24 = @class;
		BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_9 = (MethodBase[])((Class7)null).t(obj, type, (CultureInfo)null);
		ref object[] object_5 = ref reference;
		ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_2 = cultureInfo;
		object object_6 = obj;
		Type type_7 = type;
		Class7 class25 = @class;
		BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_4 = array5;
		Type type_8 = type;
		Class7 obj16 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_18 = bindingFlags;
		Class7 obj17 = (Class7)(object)Class5.Default;
		Class7 class26 = @class;
		object object_7 = ((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)@class.j(bindingFlags, array2, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), cultureInfo);
		BindingFlags bindingFlags_19 = (BindingFlags)((Class7)null).t(bindingFlags, array4, obj, cultureInfo);
		FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
		Class7 class27 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj18 = (Class7)(object)obj17.j((BindingFlags)class26.t(object_7, (Type)(object)((Class7)null).t(bindingFlags_19, fieldInfo_, (object)class27.t(bindingFlags, array4, obj, (CultureInfo)(object)Class5.Default), cultureInfo), cultureInfo), (MethodBase[])@class.t(null, type, null), ref *(object[]*)null, array3, cultureInfo, (string[])(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out reference2)).t(obj, type, cultureInfo), array4, obj, (CultureInfo)(object)Class5.Default), out reference2);
		BindingFlags bindingFlags_20 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = array5;
		Type type_9 = (Type)@class.t(obj, null, (CultureInfo)@class.t(null, type, cultureInfo));
		Class7 class28 = @class;
		BindingFlags bindingFlags_21 = bindingFlags;
		MethodBase[] methodBase_10 = array2;
		Class7 obj19 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_22 = bindingFlags;
		MethodBase[] methodBase_11 = array2;
		ref object[] object_8 = ref *(object[]*)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj20 = (Class7)(object)class24.j(bindingFlags_16, methodBase_9, ref object_5, parameterModifier_5, cultureInfo_2, (string[])((Class7)null).t(object_6, type_7, (CultureInfo)(object)class25.W(bindingFlags_17, propertyInfo_4, type_8, (Type[])(object)obj16.W(bindingFlags_18, (PropertyInfo[])(object)obj18.W(bindingFlags_20, propertyInfo_5, type_9, (Type[])(object)class28.e(bindingFlags_21, methodBase_10, (Type[])((Class7)(object)obj19.j(bindingFlags_22, methodBase_11, ref object_8, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array4, obj, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default)).t(Class5.Default, null, cultureInfo), null), array3), (Type)((Class7)(object)Class5.Default).t(obj, type, null), array, (ParameterModifier[])(object)Class5.Default), null)), out reference2);
		BindingFlags bindingFlags_23 = bindingFlags;
		FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
		object object_9 = @class.e(bindingFlags, array2, array, (ParameterModifier[])(object)Class5.Default);
		Class7 class29 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)(object)obj12.W(bindingFlags_13, propertyInfo_3, (Type)(object)obj14.j(bindingFlags_14, methodBase_8, ref object_4, parameterModifier_4, null, string_2, out *(object*)obj15.j(bindingFlags_15, (MethodBase[])(object)obj20.t(bindingFlags_23, fieldInfo_2, object_9, (CultureInfo)(object)((Class7)(object)((Class7)null).t((BindingFlags)class29.W(bindingFlags, null, type, array, array3), array4, (object)null, cultureInfo)).j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default)), ref *(object[]*)null, array3, cultureInfo, array6, out reference2)), array, array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		while (obj != null)
		{
			if (num == 0)
			{
				try
				{
					gClass2 = (GClass1)(object)@class.W((BindingFlags)Class5.Default, null, null, array, array3);
				}
				finally
				{
					_ = (Class2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array3);
					continue;
				}
			}
		}
		while (obj != null)
		{
			_ = (Class9)(object)Class5.Default;
		}
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * num) != 0)
			{
				try
				{
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class30.t(bindingFlags, null, ((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, cultureInfo, (string[])null, out reference2), cultureInfo);
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_4ea7;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				gClass2 = gClass2;
			}
			end_IL_4ea7:;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					qk = null;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			goto IL_4f52;
		}
		IL_4777:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		bindingFlags = default(BindingFlags);
		_ = (Struct2)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array, (ParameterModifier[])null)).t(bindingFlags, null, ((Class7)(object)@class.W((BindingFlags)Class5.Default, array5, type, array, array3)).j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2), cultureInfo);
		while (obj != null)
		{
			@class = (Class7)(object)@class.W(bindingFlags, array5, null, array, null);
			gClass = null;
		}
		gClass2 = gClass2;
		Class7 class31 = @class;
		Class7 obj22 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		if ((UIntPtr)class31.t((BindingFlags)obj22.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array6, out reference2), null, null, (CultureInfo)(object)@class.t(bindingFlags, array4, @class.W(bindingFlags, array5, type, array, array3), cultureInfo)) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class9 = null;
					gClass3 = (GClass3)(object)Class5.Default;
					class16 = class16;
				}
				finally
				{
					Class7 class32 = @class;
					Class7 class33 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)class32.t(class33.e(bindingFlags, array2, null, array3), null, cultureInfo);
					goto end_IL_48dc;
				}
				end_IL_48dc:;
			}
			finally
			{
				@class = @class;
				goto IL_4941;
			}
		}
		goto IL_4941;
		IL_3849:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class35);
		try
		{
			BindingFlags bindingFlags_24;
			do
			{
				qk = qk;
				bindingFlags_24 = bindingFlags;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)(object)((Class7)null).W(bindingFlags_24, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(obj, null, null)), type, array, (ParameterModifier[])null)).W(bindingFlags, array5, type, array, (ParameterModifier[])(object)Class5.Default) != null);
		}
		catch
		{
			try
			{
				_ = (GClass3)(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t(@class.t(obj, type, cultureInfo), (Type)null, cultureInfo), ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out reference2);
				@class = @class;
				qk = qk;
			}
			catch
			{
				Class7 class34 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class34.j(bindingFlags, null, ref *(object[]*)@class.t(bindingFlags, array4, obj, cultureInfo), array3, cultureInfo, null, out reference2);
				_ = (Qk7)(object)Class5.Default;
				class35 = (Class9)(object)Class5.Default;
				Class7 class36 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class36.e(bindingFlags, null, null, null);
			}
			finally
			{
				while (obj != null)
				{
					_ = (Class5)(object)@class.e(bindingFlags, array2, array, array3);
				}
				goto end_IL_38d8;
			}
			end_IL_38d8:;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					gClass3 = null;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj != null)
		{
			while (obj != null)
			{
				_ = (Class4)(object)Class5.Default;
				class9 = class9;
				Class7 class37 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class37.j(bindingFlags, array2, ref reference, array3, cultureInfo, null, out reference2);
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj25 = (Class7)(object)class38.W(bindingFlags, array5, type, null, null);
					BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_6 = array5;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj25.W(bindingFlags_25, propertyInfo_6, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), array, (ParameterModifier[])(object)Class5.Default);
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Qk7)(object)@class.e(bindingFlags, array2, array, null);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = null;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			else
			{
				class14 = class14;
			}
		}
		catch
		{
			do
			{
				Class7 obj28 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class9 = (Class6)(object)obj28.e(bindingFlags, array2, array, array3);
			}
			while ((object)Class5.Default != null || obj != null);
		}
		do
		{
			try
			{
				do
				{
					_ = (Struct1)Class5.Default;
				}
				while (@class.t(obj, type, (CultureInfo)(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)@class.e(bindingFlags, array2, null, null), array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default)) != null);
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		while (obj != null);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					@struct = @struct;
				}
				finally
				{
					Class7 class39 = @class;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)class39.t(class40.j(bindingFlags, array2, ref *(object[]*)@class.e(bindingFlags, null, array, array3), null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2), null, null);
					goto end_IL_3c33;
				}
			}
			end_IL_3c33:;
		}
		finally
		{
			while ((object)@class.W(bindingFlags, array5, type, array, (ParameterModifier[])(object)Class5.Default) != null)
			{
				class14 = class14;
			}
			goto IL_3ced;
		}
		IL_3e95:
		while (obj != null)
		{
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class41.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3);
		}
		num = default(UIntPtr);
		if (checked(num + num) == 0)
		{
			_ = (Struct1)Class5.Default;
		}
		else
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags, array4, (object)null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, null, cultureInfo)) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				gClass4 = gClass4;
			}
			finally
			{
				struct2 = struct2;
				goto end_IL_3f16;
			}
			end_IL_3f16:;
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (checked(num + unchecked((nuint)(UIntPtr)Class5.Default)) != 0)
				{
					_ = (Class2)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), array3)).j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default);
					class35 = class35;
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.e(bindingFlags, null, null, array3);
					gClass2 = gClass2;
					_ = (_003CModule_003E)(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)@class.t(null, (Type)(object)Class5.Default, null)).W(bindingFlags, array5, type, array, null)).t(Class5.Default, type, (CultureInfo)(object)((Class7)null).e((BindingFlags)@class.t(null, type, cultureInfo), (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array2, ref reference, null, cultureInfo, null, out reference2), (Type[])(object)Class5.Default, array3)), (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, array2, array, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Struct2)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, (string[])(object)@class.t(bindingFlags, array4, obj, cultureInfo), out reference2)).W(bindingFlags, null, null, array, null);
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass2)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo);
					goto end_IL_4173;
				}
				end_IL_4173:;
			}
		}
		else
		{
			try
			{
				if (checked(num * num) == 0)
				{
					_ = (Struct2)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])((Class7)null).t((object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)@class.j(bindingFlags, null, ref *(object[]*)null, array3, null, array6, out *(object*)Class5.Default)), type, (CultureInfo)null));
					gClass2 = (GClass1)(object)Class5.Default;
					_ = (Class5)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, array3, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo), type, array, (ParameterModifier[])null), (FieldInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, null, array6, out reference2), obj, null), out reference2), array4, obj, null);
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			catch
			{
				BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_12 = array2;
				ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null);
				string[] string_3 = array6;
				Class7 class42 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).j(bindingFlags_26, methodBase_12, ref *(object[]*)null, parameterModifier_6, (CultureInfo)null, string_3, out *(object*)class42.e(bindingFlags, null, null, array3)) == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj, null);
				}
			}
		}
		while (obj != null)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					Class7 class43 = @class;
					BindingFlags bindingFlags_27 = bindingFlags;
					MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
					Type[] type_10 = array;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj34 = (Class7)((Class7)(object)class44.t(bindingFlags, null, obj, cultureInfo)).t(Class5.Default, null, cultureInfo);
					object object_10 = ((Class7)(object)Class5.Default).W(bindingFlags, array5, (Type)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default)).e(bindingFlags, array2, array, array3), array, array3);
					Type type_11 = (Type)(object)Class5.Default;
					Class7 obj35 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					ParameterModifier[] parameterModifier_7 = array3;
					CultureInfo cultureInfo_3 = (CultureInfo)(object)Class5.Default;
					Class7 obj36 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array6, out reference2), ref reference, (ParameterModifier[])(object)@class.t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class4)((Class7)(object)class43.e(bindingFlags_27, methodBase_13, type_10, (ParameterModifier[])obj34.t(object_10, type_11, (CultureInfo)(object)obj35.j(bindingFlags_28, null, ref *(object[]*)null, parameterModifier_7, cultureInfo_3, (string[])(object)obj36.e(bindingFlags, array2, array, array3), out reference2)))).t(obj, (Type)((Class7)null).t((object)null, (Type)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)@class.e((BindingFlags)@class.W(bindingFlags, null, type, null, array3), array2, array, null), out reference2), cultureInfo), cultureInfo);
				}
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, null, null, array3) == (UIntPtr)(nuint)0u)
		{
			Class7 class45 = @class;
			BindingFlags bindingFlags_29 = (BindingFlags)((Class7)((Class7)@class.t(((Class7)null).W(bindingFlags, array5, (Type)null, (Type[])null, array3), type, cultureInfo)).t(Class5.Default, type, cultureInfo)).t((BindingFlags)Class5.Default, array4, obj, cultureInfo);
			FieldInfo[] fieldInfo_3 = array4;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t((object)null, (Type)(object)class45.t(bindingFlags_29, fieldInfo_3, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)@class.j(bindingFlags, array2, ref reference, array3, (CultureInfo)(object)Class5.Default, array6, out reference2), (CultureInfo)null)), cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass1)(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
					_ = (GClass0)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					_ = (GClass1)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, array3);
				}
				finally
				{
					gClass2 = null;
					goto IL_4777;
				}
			}
		}
		goto IL_4777;
		IL_3ced:
		try
		{
			try
			{
				_ = (Struct1)Class5.Default;
			}
			finally
			{
				_ = (Class2)(object)Class5.Default;
				class15 = class15;
				class15 = (Class10)(object)@class.e((BindingFlags)Class5.Default, null, (Type[])((Class7)null).t(obj, type, cultureInfo), array3);
				goto end_IL_3cee;
			}
			end_IL_3cee:;
		}
		finally
		{
			try
			{
				Class7 obj37 = (Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.W(bindingFlags, null, type, array, null), array2, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out reference2);
				Class7 class46 = @class;
				Class7 class47 = @class;
				BindingFlags bindingFlags_30 = bindingFlags;
				object object_11 = obj;
				Class7 obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class10)obj37.t(class46.j((BindingFlags)class47.t(bindingFlags_30, null, object_11, (CultureInfo)(object)obj38.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null)), (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)@class.t(bindingFlags, array4, @class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), cultureInfo), array6, out reference2), null, null);
			}
			finally
			{
				class9 = class9;
				gClass = null;
				goto IL_3e95;
			}
		}
		IL_262d:
		while (obj != null)
		{
		}
		while (obj != null)
		{
			while (true)
			{
				Class7 class48 = @class;
				Class7 class49 = @class;
				Class7 class50 = @class;
				BindingFlags bindingFlags_31 = (BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo);
				Class7 class51 = @class;
				BindingFlags bindingFlags_32 = bindingFlags;
				MethodBase[] methodBase_14 = (MethodBase[])(object)Class5.Default;
				ParameterModifier[] parameterModifier_8 = (ParameterModifier[])((Class7)(object)Class5.Default).t(null, null, cultureInfo);
				Class7 class52 = @class;
				Class7 obj39 = (Class7)((Class7)(object)Class5.Default).t(((Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array2, null, array3)).j((BindingFlags)Class5.Default, array2, ref reference, array3, cultureInfo, (string[])@class.t(obj, type, cultureInfo), out reference2), type, null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_33 = (BindingFlags)class50.e(bindingFlags_31, (MethodBase[])(object)class51.j(bindingFlags_32, methodBase_14, ref *(object[]*)null, parameterModifier_8, (CultureInfo)class52.t(obj39.e(bindingFlags, null, array, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, null, array3)), array3, cultureInfo, (string[])null, out reference2)), type, cultureInfo), array6, out reference2), (Type[])((Class7)(object)Class5.Default).t(null, type, null), array3);
				MethodBase[] methodBase_15 = array2;
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				Type[] type_12 = (Type[])(object)class53.W(bindingFlags, null, type, null, array3);
				Class7 class54 = @class;
				BindingFlags bindingFlags_34 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_7 = array5;
				Type type_13 = (Type)(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo);
				bindingFlags = default(BindingFlags);
				Class7 obj40 = (Class7)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)((Class7)null).W((BindingFlags)Class5.Default, array5, type, array, array3), (CultureInfo)null)).W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3)).t(obj, type, (CultureInfo)(object)@class.W(default(BindingFlags), array5, type, null, (ParameterModifier[])(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj, (CultureInfo)null)));
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)(object)class48.W((BindingFlags)((Class7)(object)class49.e(bindingFlags_33, methodBase_15, type_12, (ParameterModifier[])(object)class54.W(bindingFlags_34, propertyInfo_7, type_13, (Type[])(object)obj40.W(bindingFlags, array5, null, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)), array3))).e(bindingFlags, array2, (Type[])(object)@class.t(bindingFlags, array4, obj, (CultureInfo)(object)((Class7)(object)((Class7)null).t(bindingFlags, array4, (object)Class5.Default, cultureInfo)).t((BindingFlags)Class5.Default, array4, obj, cultureInfo)), null), (PropertyInfo[])(object)Class5.Default, type, null, null)).e(bindingFlags, array2, null, array3) == null)
				{
					break;
				}
				class4 = class4;
			}
		}
		try
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				class35 = class35;
				_ = (Class10)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, (ParameterModifier[])(object)@class.e(bindingFlags, array2, array, array3));
				goto end_IL_2a08;
			}
			end_IL_2a08:;
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Class7 class55 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					Class7 class56 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class55.W(bindingFlags_35, (PropertyInfo[])(object)class56.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, cultureInfo, array6, out reference2), null, array, null);
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				while (@class.t(obj, null, (CultureInfo)(object)Class5.Default) != null)
				{
					Class7 obj41 = (Class7)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])(object)@class.e((BindingFlags)Class5.Default, array2, (Type[])(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.W(default(BindingFlags), array5, type, null, null), (MethodBase[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array, array3), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)null), array3), out reference2);
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj41.W(bindingFlags, null, type, array, array3);
				}
			}
			goto IL_2bf6;
		}
		IL_4f52:
		try
		{
			gClass2 = null;
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass = gClass;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_4f99;
		}
		IL_21f0:
		_ = (Class2)(object)Class5.Default;
		try
		{
			try
			{
				while (obj != null)
				{
					class15 = null;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class15 = class15;
				}
				else
				{
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					object object_12 = ((Class7)null).e(bindingFlags, (MethodBase[])null, array, array3);
					Class7 obj43 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_36 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null);
					Class7 obj44 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_37 = (BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array6, out *(object*)Class5.Default)), array, array3);
					Class7 class58 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj45 = (Class7)(object)class58.e(bindingFlags, array2, array, array3);
					BindingFlags bindingFlags_38 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = array5;
					Type type_14 = (Type)(object)Class5.Default;
					Class7 obj46 = (Class7)(object)@class.j(bindingFlags, null, ref reference, array3, null, null, out *(object*)Class5.Default);
					Class7 obj47 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
					bindingFlags = default(BindingFlags);
					Class7 obj48 = (Class7)(object)((Class7)null).W((BindingFlags)obj43.e(bindingFlags_36, (MethodBase[])(object)obj44.t(bindingFlags_37, (FieldInfo[])(object)obj45.W(bindingFlags_38, propertyInfo_8, type_14, (Type[])(object)obj46.W((BindingFlags)obj47.e(bindingFlags, array2, (Type[])(object)@class.t(bindingFlags, array4, Class5.Default, cultureInfo), array3), (PropertyInfo[])(object)Class5.Default, type, array, array3), null), obj, (CultureInfo)(object)Class5.Default), array, array3), (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array2, array, array3), (Type)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, null), (Type[])(object)Class5.Default, array3);
					bindingFlags = default(BindingFlags);
					_ = (GClass2)class57.t(object_12, (Type)(object)obj48.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).j((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array2, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, array2, array, (ParameterModifier[])(object)Class5.Default), null), ref *(object[]*)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array6, out *(object*)null), array3, cultureInfo, array6, out *(object*)null), (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference2), null, cultureInfo, null, out *(object*)null), obj, null), (CultureInfo)(object)Class5.Default);
				}
			}
		}
		catch
		{
			gClass3 = null;
		}
		try
		{
			try
			{
				class16 = null;
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				_ = (GClass0)(object)@class.j(bindingFlags, array2, ref *(object[]*)@class.t(obj, null, (CultureInfo)@class.t(@class.t((BindingFlags)Class5.Default, array4, obj, null), type, null)), null, cultureInfo, array6, out *(object*)null);
			}
		}
		catch
		{
			gClass2 = (GClass1)(object)Class5.Default;
		}
		finally
		{
			try
			{
			}
			finally
			{
				while (obj != null)
				{
					class13 = null;
				}
				goto IL_262d;
			}
		}
		IL_1e28:
		do
		{
			_ = (GClass2)(object)Class5.Default;
		}
		while (obj != null);
		while (obj != null)
		{
			try
			{
			}
			finally
			{
				if (num == 0)
				{
					_ = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array4, obj, cultureInfo);
				}
				else
				{
					class15 = (Class10)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array3);
				}
				continue;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if (num != 0)
			{
				try
				{
					_ = (Class0)(object)((Class7)null).W((BindingFlags)@class.W(bindingFlags, null, type, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array5, type, array, (ParameterModifier[])null)), array5, (Type)null, array, array3);
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_1ffb;
				}
			}
			try
			{
				Class7 class59 = @class;
				Class7 obj53 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				struct2 = (Struct2)class59.e((BindingFlags)obj53.e(bindingFlags, null, null, array3), array2, (Type[])(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), array3);
				class10 = class10;
				class9 = class9;
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				class15 = class15;
			}
		}
		else if (checked(unchecked((nuint)(UIntPtr)@class.W(bindingFlags, null, type, null, array3)) - unchecked((nuint)(UIntPtr)@class.t(obj, type, (CultureInfo)(object)Class5.Default))) == 0)
		{
			_ = (Class8)(object)Class5.Default;
		}
		goto IL_1ffb;
		IL_30a5:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])(object)Class5.Default);
			}
			else
			{
				while (obj != null)
				{
					class4 = (Class8)(object)Class5.Default;
					qk = null;
					_ = (Class6)@class.t(@class.t(obj, null, cultureInfo), type, (CultureInfo)((Class7)null).t(obj, type, cultureInfo));
					Class7 class60 = @class;
					Class7 class61 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class60.t((BindingFlags)((Class7)null).t((object)null, (Type)(object)class61.W(bindingFlags, array5, type, null, array3), cultureInfo), array4, @class.W((BindingFlags)Class5.Default, array5, type, array, array3), cultureInfo);
				}
			}
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			class14 = null;
		}
		do
		{
			_ = (GClass2)(object)Class5.Default;
		}
		while (obj != null);
		try
		{
			while ((object)Class5.Default != null)
			{
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(null, type, null);
				}
			}
			catch
			{
				while (true)
				{
					if ((object)@class.j(bindingFlags, null, ref reference, null, cultureInfo, null, out reference2) != null)
					{
						_003CModule_003E = _003CModule_003E;
						continue;
					}
					goto end_IL_3211;
				}
				end_IL_3211:;
			}
		}
		try
		{
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)(object)Class5.Default;
				gClass2 = null;
			}
			goto IL_3269;
		}
		IL_0a35:
		try
		{
			if (num == 0)
			{
				_ = (Class10)(object)((Class7)null).t((BindingFlags)@class.t(null, null, cultureInfo), (FieldInfo[])null, (object)Class5.Default, cultureInfo);
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					gClass4 = gClass4;
					goto end_IL_0a6e;
				}
				end_IL_0a6e:;
			}
			catch
			{
			}
			goto IL_0a8d;
		}
		IL_06b3:
		try
		{
			try
			{
				try
				{
					gClass3 = gClass3;
					gClass3 = gClass3;
				}
				finally
				{
					class16 = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
					goto end_IL_06b5;
				}
				end_IL_06b5:;
			}
			finally
			{
				gClass = null;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)((Class7)null).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out reference2);
				goto end_IL_06b4;
			}
			end_IL_06b4:;
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		if (num == 0)
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					while (obj != null)
					{
						gClass3 = gClass3;
					}
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		else
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = Class5.Default;
					qk = (Qk7)(object)@class.j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, array6, out *(object*)null);
					class10 = (Class0)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).t(bindingFlags, array4, (object)null, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)null));
				}
				else
				{
					_ = (Struct1)((Class7)null).t(bindingFlags, array4, (object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array3, (CultureInfo)null, (string[])null, out reference2), (CultureInfo)null);
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
					class9 = class9;
					_ = (GClass3)(object)Class5.Default;
					goto end_IL_0845;
				}
				end_IL_0845:;
			}
		}
		num = default(UIntPtr);
		if (checked(num * num) == 0)
		{
			_ = (Class8)(object)Class5.Default;
		}
		if (num == 0 && num == 0)
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
				gClass3 = null;
			}
		}
		_ = (Struct2)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, array2, array, array3), array6, out reference2);
		try
		{
			gClass2 = gClass2;
			gClass2 = gClass2;
		}
		catch
		{
			if (num == 0)
			{
				class16 = null;
				_ = (Qk7)(object)Class5.Default;
			}
			else
			{
				try
				{
					class10 = class10;
				}
				catch
				{
					gClass4 = null;
					gClass4 = gClass4;
				}
			}
		}
		Class9 obj63 = (Class9)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2);
		class35 = class35;
		class35 = obj63;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class13 = class13;
				}
			}
			else
			{
				gClass4 = gClass4;
			}
		}
		finally
		{
			nuint num3 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
			checked
			{
				nuint num4 = unchecked(num3 / num) - num * num;
				num = default(UIntPtr);
				if (num4 * (num + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					try
					{
						_ = (Class0)(object)Class5.Default;
					}
					catch
					{
						gClass2 = null;
					}
				}
				goto IL_0a35;
			}
		}
		IL_0a8d:
		_ = (_003CModule_003E)(object)Class5.Default;
		_ = (GClass3)(object)@class.e(bindingFlags, array2, null, array3);
		@struct = @struct;
		class14 = class14;
		_ = (Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, null, out reference2);
		Class7 class62 = @class;
		BindingFlags bindingFlags_39 = bindingFlags;
		PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default);
		Type type_15 = type;
		BindingFlags bindingFlags_40 = bindingFlags;
		MethodBase[] methodBase_16 = array2;
		BindingFlags bindingFlags_41 = bindingFlags;
		object object_13 = obj;
		Class7 class63 = @class;
		BindingFlags bindingFlags_42 = bindingFlags;
		MethodBase[] methodBase_17 = array2;
		ref object[] object_14 = ref reference;
		Class7 class64 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)((Class7)(object)class62.W(bindingFlags_39, propertyInfo_9, type_15, (Type[])(object)((Class7)null).e(bindingFlags_40, methodBase_16, (Type[])(object)((Class7)(object)((Class7)null).t(bindingFlags_41, (FieldInfo[])null, object_13, (CultureInfo)(object)class63.j(bindingFlags_42, methodBase_17, ref object_14, (ParameterModifier[])(object)class64.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), cultureInfo, array6, out *(object*)null))).e((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array4, (object)null, (CultureInfo)null), array2, null, null), (ParameterModifier[])null), array3)).j(bindingFlags, array2, ref *(object[]*)null, null, cultureInfo, array6, out *(object*)null);
		try
		{
			try
			{
				Class7 class65;
				do
				{
					class16 = null;
					class65 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class65.W(bindingFlags, array5, type, (Type[])(object)@class.t(bindingFlags, array4, obj, cultureInfo), array3) != null);
			}
			catch
			{
				_ = (Struct2)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, array3);
				class14 = (Class2)(object)Class5.Default;
				class13 = (Class4)(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
				class15 = null;
			}
		}
		catch
		{
			if (num == 0)
			{
				_ = (Class0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null);
				class13 = class13;
				_ = (GClass2)(object)@class.j((BindingFlags)((Class7)null).t(bindingFlags, array4, (object)null, cultureInfo), (MethodBase[])((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default), ref *(object[]*)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, array3), (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out *(object*)Class5.Default);
			}
		}
		try
		{
			_ = (Struct2)Class5.Default;
		}
		catch
		{
			try
			{
				try
				{
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					_003CModule_003E obj67 = (_003CModule_003E)(object)class66.j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)@class.W(bindingFlags, array5, null, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)Class5.Default), array3), array2, ref reference, array3, cultureInfo, null, out reference2), ref *(object[]*)Class5.Default, array3, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
					_003CModule_003E = null;
					_003CModule_003E = obj67;
					gClass4 = (GClass0)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)(object)class67.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, null, array6, out reference2)).j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, cultureInfo, null, out *(object*)((Class7)null).W(bindingFlags, array5, type, (Type[])null, array3));
					goto end_IL_0dae;
				}
				end_IL_0dae:;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
			}
		}
		do
		{
			_ = (GClass3)(object)Class5.Default;
		}
		while (obj != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			Class7 class68 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class68.e(bindingFlags, null, array, null);
		}
		class35 = class35;
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					class10 = (Class0)@class.t(Class5.Default, null, cultureInfo);
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					class9 = null;
				}
				finally
				{
					class35 = class35;
					goto end_IL_0fae;
				}
				end_IL_0fae:;
			}
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			@struct = @struct;
		}
		try
		{
			gClass3 = null;
			class10 = (Class0)(object)Class5.Default;
			class14 = null;
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Qk7)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, array, array3)).W(bindingFlags, array5, type, (Type[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array3);
			}
		}
		bindingFlags = default(BindingFlags);
		class16 = (Class5)(object)((Class7)null).t(bindingFlags, array4, (object)Class5.Default, cultureInfo);
		BindingFlags bindingFlags_43;
		FieldInfo[] fieldInfo_4;
		Class7 class69;
		do
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
			}
			bindingFlags_43 = (BindingFlags)Class5.Default;
			fieldInfo_4 = (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
			class69 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).t(bindingFlags_43, fieldInfo_4, (object)class69.W(bindingFlags, array5, (Type)(object)Class5.Default, array, array3), (CultureInfo)null) != null || obj != null);
		class35 = null;
		try
		{
			while (obj != null)
			{
				try
				{
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					class35 = (Class9)(object)((Class7)(object)class70.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default)).W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3);
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.t((BindingFlags)Class5.Default, array4, obj, cultureInfo);
					continue;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					class4 = null;
				}
				finally
				{
					class16 = class16;
					goto end_IL_11b7;
				}
				end_IL_11b7:;
			}
			catch
			{
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class71.t(bindingFlags, array4, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					Class7 class72 = @class;
					BindingFlags bindingFlags_44 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = (PropertyInfo[])@class.t(@class.t(obj, (Type)(object)Class5.Default, cultureInfo), type, cultureInfo);
					Type type_16 = (Type)(object)Class5.Default;
					Class7 obj72 = (Class7)@class.t(obj, null, cultureInfo);
					BindingFlags bindingFlags_45 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class72.W(bindingFlags_44, propertyInfo_10, type_16, null, (ParameterModifier[])((Class7)(object)obj72.W(bindingFlags_45, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array5, type, array, array3), null, (Type[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, (Type)(object)Class5.Default, null, (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)null)), array3)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default));
				}
			}
			goto IL_1304;
		}
		IL_2bf6:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				nuint num5 = num;
				num = default(UIntPtr);
				if (checked(num5 * num) == 0)
				{
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class73.t(bindingFlags, null, obj, cultureInfo);
				}
			}
			catch
			{
				qk = qk;
				class4 = class4;
				class10 = null;
				class16 = class16;
			}
			goto IL_2d4e;
		}
		try
		{
			while (obj != null)
			{
				_ = (Qk7)(object)Class5.Default;
				_ = (GClass2)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, array3);
			}
		}
		finally
		{
			try
			{
				Class7 class74 = @class;
				BindingFlags bindingFlags_46 = bindingFlags;
				Class7 obj75 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class74.t(bindingFlags_46, null, obj75.W(bindingFlags, array5, type, null, null), cultureInfo);
			}
			catch
			{
				_ = (Class5)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default), array4, obj, (CultureInfo)(object)Class5.Default);
				_ = (Class0)(object)Class5.Default;
				_ = (Class9)(object)Class5.Default;
			}
			goto IL_2d4e;
		}
		IL_1304:
		UIntPtr num6 = (UIntPtr)((Class7)(object)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, cultureInfo), array2, null, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, null, type, array, array3)), array3, null, null, out *(object*)Class5.Default)).e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
		num = default(UIntPtr);
		if (checked((unchecked((nuint)num6) - num) * num) == 0)
		{
			if (num == 0)
			{
				struct2 = (Struct2)((Class7)(object)@class.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), (Type[])null, (ParameterModifier[])(object)Class5.Default), null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3)).t((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3), null, obj, cultureInfo);
			}
			else
			{
				Class7 class75 = @class;
				Class7 class76 = @class;
				Class7 obj77 = (Class7)(object)@class.t((BindingFlags)Class5.Default, array4, obj, null);
				BindingFlags bindingFlags_47 = bindingFlags;
				MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
				BindingFlags bindingFlags_48 = bindingFlags;
				PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)Class5.Default;
				Type type_17 = (Type)(object)Class5.Default;
				Type[] type_18 = array;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class75.j((BindingFlags)class76.e((BindingFlags)((Class7)null).W((BindingFlags)obj77.j(bindingFlags_47, methodBase_18, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags_48, propertyInfo_11, type_17, type_18, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array5, (Type)null, array, array3)), (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default, null, out *(object*)null), (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3), null, (Type[])(object)Class5.Default, array3), null, ref reference, array3, cultureInfo, null, out *(object*)null);
				gClass2 = gClass2;
				@class = @class;
			}
		}
		else
		{
			gClass3 = gClass3;
		}
		do
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			finally
			{
				_ = (Class2)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(null, null, cultureInfo), null, (ParameterModifier[])((Class7)null).t((object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array6, out reference2), type, (CultureInfo)null));
				continue;
			}
		}
		while (obj != null || obj != null);
		class15 = null;
		_ = (Qk7)@class.t(((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo), (Type)(object)Class5.Default, (CultureInfo)(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(obj, type, null), array5, type, null, null));
		try
		{
			do
			{
				try
				{
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass3)(object)class77.e(bindingFlags, null, null, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type, cultureInfo));
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					continue;
				}
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			UIntPtr num7 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num7) - (num - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					while (obj != null)
					{
						Class7 class78 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Struct2)class78.t(bindingFlags, array4, ((Class7)(object)Class5.Default).t(null, type, null), cultureInfo);
					}
				}
				else
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + unchecked(num / (nuint)(UIntPtr)((Class7)null).t(obj, type, cultureInfo)) == 0)
					{
						_ = (Struct1)Class5.Default;
					}
				}
			}
		}
		_ = (Class2)(object)Class5.Default;
		try
		{
			try
			{
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class79.t(bindingFlags, array4, ((Class7)null).W(bindingFlags, array5, (Type)null, array, (ParameterModifier[])(object)Class5.Default), cultureInfo);
			}
			catch
			{
				class14 = null;
			}
			finally
			{
				if ((UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null) == (UIntPtr)(nuint)0u)
				{
					Class7 class80 = @class;
					BindingFlags bindingFlags_49 = bindingFlags;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class80.t(bindingFlags_49, null, null, (CultureInfo)(object)class81.t(bindingFlags, array4, @class.t(null, null, null), null));
				}
				goto end_IL_17e3;
			}
			end_IL_17e3:;
		}
		catch
		{
			try
			{
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				struct2 = default(Struct2);
				struct2 = struct2;
				class9 = null;
			}
			finally
			{
				do
				{
					_ = (Class6)(object)@class.j(bindingFlags, array2, ref reference, array3, (CultureInfo)(object)Class5.Default, array6, out reference2);
				}
				while (@class.t(null, null, cultureInfo) != null);
				goto end_IL_18a6;
			}
			end_IL_18a6:;
		}
		try
		{
			while (obj != null)
			{
				if (num == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
		}
		catch
		{
			class10 = null;
		}
		bindingFlags = default(BindingFlags);
		gClass4 = (GClass0)(object)((Class7)null).W(bindingFlags, array5, (Type)null, array, array3);
		try
		{
			try
			{
				_ = (Class9)@class.t(obj, type, cultureInfo);
				Class7 class82 = @class;
				BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class82.j(bindingFlags_50, methodBase_19, ref *(object[]*)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, array6, out reference2), array3, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null), out reference2);
				_ = (Class4)(object)Class5.Default;
			}
			catch
			{
				_ = Class5.Default;
			}
		}
		catch
		{
			try
			{
				class10 = class10;
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		finally
		{
			do
			{
				if ((UIntPtr)@class.t(bindingFlags, array4, null, null) != (UIntPtr)(nuint)0u)
				{
					Class7 obj86 = (Class7)(object)Class5.Default;
					MethodBase[] methodBase_20 = array2;
					ref object[] object_15 = ref reference;
					ParameterModifier[] parameterModifier_9 = array3;
					CultureInfo cultureInfo_4 = (CultureInfo)(object)Class5.Default;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj87 = (Class7)((Class7)null).t((object)((Class7)null).j(default(BindingFlags), methodBase_20, ref object_15, parameterModifier_9, cultureInfo_4, (string[])(object)class83.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), obj, cultureInfo), out *(object*)null), (Type)null, cultureInfo);
					BindingFlags bindingFlags_51 = bindingFlags;
					PropertyInfo[] propertyInfo_12 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), array4, Class5.Default, (CultureInfo)(object)Class5.Default);
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					class14 = (Class2)(object)((Class7)(object)obj86.W((BindingFlags)obj87.W(bindingFlags_51, propertyInfo_12, null, (Type[])(object)class84.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, array3)).j(bindingFlags, array2, ref *(object[]*)@class.t(null, type, cultureInfo), array3, cultureInfo, (string[])(object)Class5.Default, out reference2)).j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, (string[])(object)((Class7)null).j((BindingFlags)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array3), array2, ref reference, array3, cultureInfo, array6, out *(object*)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo), array2, null, array3)), out *(object*)null), cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])@class.t(obj, type, cultureInfo), (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)Class5.Default), out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, array3)), array, (ParameterModifier[])null), null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out reference2), array3), array5, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, null, array, null);
					gClass2 = (GClass1)(object)Class5.Default;
					qk = qk;
				}
				else
				{
					Class7 class85 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class85.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
				}
			}
			while (obj != null);
			goto IL_1db1;
		}
		IL_2d4e:
		try
		{
			class15 = null;
		}
		catch
		{
			if (num == 0)
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array4, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)@class.e((BindingFlags)@class.j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array6, out reference2), null, array, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.j((BindingFlags)@class.t(bindingFlags, array4, @class.W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)Class5.Default, array2, array, null), (Type)(object)Class5.Default, array, array3), cultureInfo), (MethodBase[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.W(bindingFlags, array5, type, null, array3), obj, cultureInfo), (ParameterModifier[])null), ref reference, array3, null, array6, out reference2), (Type[])null, array3));
				}
			}
			else
			{
				class35 = class35;
			}
		}
		_ = (Class10)(object)Class5.Default;
		@struct = @struct;
		class35 = null;
		try
		{
			nuint num8 = num;
			num = default(UIntPtr);
			if (num8 / num == 0)
			{
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array6, out reference2), out reference2));
			}
			else
			{
				try
				{
					@struct = (Struct1)Class5.Default;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		_ = (Struct1)Class5.Default;
		@struct = default(Struct1);
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				checked
				{
					if (unchecked(num / (nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						gClass4 = (GClass0)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default), null, null, null);
					}
					else
					{
						_ = (Class10)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
					}
					continue;
				}
			}
			try
			{
				class15 = (Class10)(object)Class5.Default;
			}
			catch
			{
				_ = (Class10)(object)((Class7)null).e(bindingFlags, array2, array, array3);
			}
		}
		do
		{
			_ = (Class8)(object)Class5.Default;
		}
		while (obj != null);
		try
		{
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class4)(object)Class5.Default;
			}
			goto IL_30a5;
		}
		IL_4f99:
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class10 = null;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		_003CModule_003E = _003CModule_003E;
		gClass3 = gClass3;
		_ = (Class7)(object)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		return;
		IL_3269:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				checked
				{
					nuint num9 = unchecked((nuint)(UIntPtr)Class5.Default) - num;
					nuint num10 = unchecked((nuint)(UIntPtr)Class5.Default / num);
					nuint num11 = num;
					bindingFlags = default(BindingFlags);
					Class7 obj92 = (Class7)(object)((Class7)null).t(bindingFlags, array4, (object)null, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					Class7 class86 = @class;
					bindingFlags = default(BindingFlags);
					if (num9 * (num10 - (num11 * unchecked((nuint)(UIntPtr)obj92.W(bindingFlags_52, null, (Type)(object)class86.e(bindingFlags, null, array, array3), (Type[])(object)Class5.Default, array3)) + unchecked((nuint)(UIntPtr)Class5.Default) * num)) == 0)
					{
						class4 = class4;
						class10 = null;
					}
					else
					{
						_ = (Class8)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array3);
					}
				}
			}
			else if (num / (nuint)(UIntPtr)Class5.Default == 0)
			{
				gClass = null;
			}
			else
			{
				class4 = (Class8)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array, array3);
			}
		}
		catch
		{
			try
			{
				_ = (Class8)(object)((Class7)((Class7)null).t((object)null, (Type)null, cultureInfo)).e((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2), array2, (Type[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array3);
			}
			catch
			{
				class10 = (Class0)(object)Class5.Default;
			}
			finally
			{
				Class7 class87 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class87.j(bindingFlags, array2, ref *(object[]*)null, array3, null, array6, out *(object*)@class.j(bindingFlags, null, ref reference, array3, null, null, out *(object*)null)) == (UIntPtr)(nuint)0u)
				{
					qk = qk;
				}
				else
				{
					class9 = null;
				}
				goto end_IL_33a4;
			}
			end_IL_33a4:;
		}
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			finally
			{
				continue;
			}
		}
		while (((Class7)null).t(obj, type, (CultureInfo)null) != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					class10 = null;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					class9 = class9;
					struct2 = default(Struct2);
					continue;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		try
		{
			_ = (Class9)(object)Class5.Default;
		}
		catch
		{
			try
			{
				try
				{
					class14 = null;
				}
				catch
				{
					gClass4 = (GClass0)(object)Class5.Default;
					gClass2 = gClass2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_53 = bindingFlags;
					MethodBase[] methodBase_21 = (MethodBase[])(object)Class5.Default;
					Class7 class88 = @class;
					object object_16 = obj;
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 class89 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).e(bindingFlags_53, methodBase_21, (Type[])class88.t(object_16, (Type)(object)((Class7)null).j(bindingFlags_54, (MethodBase[])(object)class89.t(bindingFlags, null, obj, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array6, out *(object*)null), (CultureInfo)@class.t(@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), type, null)), (ParameterModifier[])null);
					_ = (Class10)(object)Class5.Default;
				}
			}
			catch
			{
				class14 = (Class2)(object)Class5.Default;
			}
		}
		_ = (Struct1)@class.t(bindingFlags, array4, obj, null);
		@struct = @struct;
		Class7 class90 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)((Class7)(object)class90.e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)@class.e(bindingFlags, null, null, array3), null, obj, cultureInfo), null, array3)).j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array6, out *(object*)null);
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					class13 = class13;
				}
				continue;
			}
		}
		do
		{
			gClass2 = null;
		}
		while ((object)Class5.Default != null);
		gClass2 = null;
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					class9 = class9;
					_ = (Class9)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
					gClass4 = gClass4;
				}
				while (obj != null);
			}
			else if ((UIntPtr)((Class7)null).e(bindingFlags, array2, array, array3) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		catch
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (GClass1)((Class7)(object)Class5.Default).t(obj, null, null);
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		Class7 class91 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)class91.e(bindingFlags, null, array, null);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)(object)Class5.Default;
			goto IL_3849;
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				class16 = class16;
				_ = (Class9)(object)Class5.Default;
				qk = null;
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class15 = null;
			}
			else
			{
				@struct = default(Struct1);
			}
			goto IL_3849;
		}
	}
}
